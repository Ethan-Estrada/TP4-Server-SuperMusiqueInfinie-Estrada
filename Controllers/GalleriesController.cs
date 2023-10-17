using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tp3_serveur.Data;
using tp3_serveur.Models;

namespace tp3_serveur.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class GalleriesController : ControllerBase
    {
        private readonly tp3_serveurContext _context;

        public GalleriesController(tp3_serveurContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Gallery>>> GetPublicGalleries()
        {
            // Si un utilisateur est authentifié, le trouver
            User? user = await _context.Users.FindAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));

            // Obtenir toutes les galeries publiques
            List<Gallery> galleries = await _context.Gallery.ToListAsync();

            // Retirer les galeries de l'utilisateur authentifié s'il y en a un
            if (user != null)
            {
                galleries = galleries.Where(x => x.User == null || !x.User.Equals(user)).ToList();
            }
            return galleries;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gallery>>> GetMyGalleries()
        {
            User? user = await _context.Users.FindAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (user == null)
            {
                return NotFound();
            }

            return user.Galleries;
        }


        [HttpGet("{size}/{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<Gallery>> GetFile(string size, int id)
        {
            if (_context.Gallery == null)
            {
                return NotFound();
            }
            Gallery? gallery = await _context.Gallery.FindAsync(id);

            if (gallery == null || gallery.FileName == null || gallery.MimeType == null)
            {
                return NotFound(new { Message = "Cette image n'existe pas ou n'a pas d'image." });
            }
            if (!(Regex.Match(size, "lg|sm").Success))
            {
                return BadRequest(new { Message = "La taille demandee est inadequate." });
            }
            byte[] bytes = System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + "/images/" + size + "/" + gallery.FileName);
            return File(bytes, gallery.MimeType);
        }

        [HttpPost("{name}")]
        [DisableRequestSizeLimit]
        public async Task<ActionResult<Gallery>> PostGallery(string name)
        {
            try
            {
                IFormCollection formCollection = await Request.ReadFormAsync();
                IFormFile? file = formCollection.Files.GetFile("monGallery");

                if (file != null)
                {
                    Image image = Image.Load(file.OpenReadStream());

                    //creation de la g
                    Gallery g = new Gallery();
                    User? user = await _context.Users.FindAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));

                    g.Name = name;
                    g.FileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    g.MimeType = file.ContentType;
                    user.Galleries.Add(g);

                    image.Save(Directory.GetCurrentDirectory() + "/images/lg/" + g.FileName);

                    image.Mutate(i =>
                        i.Resize(new ResizeOptions()
                        {
                            Mode = ResizeMode.Min,
                            Size = new Size() { Width = 320 }
                        })
                   );
                    image.Save(Directory.GetCurrentDirectory() + "/images/sm/" + g.FileName);

                    _context.Gallery.Add(g);
                    await _context.SaveChangesAsync();

                    return CreatedAtAction("PostGallery", new { id = g.Id }, g);
                }
                else
                {
                    return NotFound(new { Message = "Aucune image fournie" });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("{id}")]
        [DisableRequestSizeLimit]
        public async Task<ActionResult<Gallery>> PutGallery(int id)
        {
            Gallery? oldGalerie = await _context.Gallery.FindAsync(id);

            if (_context.Gallery == null || oldGalerie == null)
            {
                return NotFound();
            }

            // Remplace ancien galerie avec l'id par la Galerie galrie recue
            try
            {
                IFormCollection formCollection = await Request.ReadFormAsync();
                IFormFile? file = formCollection.Files.GetFile("monNewGallery");

                if (file != null)
                {
                    Image image = Image.Load(file.OpenReadStream());

                    //creation de la g
                    Gallery newGalerie = new Gallery();
                    newGalerie.FileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    newGalerie.MimeType = file.ContentType;

                    image.Save(Directory.GetCurrentDirectory() + "/images/lg/" + newGalerie.FileName);
                    image.Mutate(i =>
                        i.Resize(new ResizeOptions()
                        {
                            Mode = ResizeMode.Min,
                            Size = new Size() { Width = 320 }
                        }));
                    image.Save(Directory.GetCurrentDirectory() + "/images/sm/" + newGalerie.FileName);

                    //delete old galerie image dans le projet et bd
                    if (oldGalerie == null)
                    {
                        return NotFound(new { Message = "Cette oldGalerie n'existe pas." });
                    }

                    if (oldGalerie.MimeType != null && oldGalerie.FileName != null)
                    {
                        System.IO.File.Delete(Directory.GetCurrentDirectory() + "/images/sm/" + oldGalerie.FileName);
                        System.IO.File.Delete(Directory.GetCurrentDirectory() + "/images/lg/" + oldGalerie.FileName);
                    }

                    oldGalerie.FileName = newGalerie.FileName;
                    oldGalerie.MimeType = newGalerie.MimeType;

                    await _context.SaveChangesAsync();

                    return CreatedAtAction("PutGallery", new { id = oldGalerie.Id }, oldGalerie);
                }
                else
                {
                    return NotFound(new { Message = "Aucune image fournie" });
                }

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _context.Gallery.AnyAsync(x => x.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(new { Message = "Galerie modifiee" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGallery(int id)
        {
            User? user = await _context.Users.FindAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
            Gallery? gallery = await _context.Gallery.FindAsync(id);
            if (user == null || gallery == null)
            {
                return NotFound();
            }

            // L'utilisateur est-il propriétaire de la galerie ?
            if (!user.Galleries.Contains(gallery))
            {
                return Unauthorized();
            }

            // Supprimer la galerie
            _context.Gallery.Remove(gallery);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Gallerie supprimée !" });
        }
    }
}
