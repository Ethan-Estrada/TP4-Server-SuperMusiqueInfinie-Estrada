using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tp3_serveur.Data;
using tp3_serveur.Models;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System.Security.Claims;

namespace tp3_serveur.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private readonly tp3_serveurContext _context;

        public PhotosController(tp3_serveurContext context)
        {
            _context = context;
        }

        // GET: api/Photos
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Photo>>> GetPhoto(int id)
        {
            if (_context.Photo == null)
            {
                return NotFound();
            }
            Gallery? gallery = await _context.Gallery.FindAsync(id);

            return gallery.Photo.ToList();
        }

        // GET: api/Photos/5
        [HttpGet("{size}/{galid}/{id}")]
        public async Task<ActionResult<Photo>> GetFile(int galid, string size, int id)
        {
            if (_context.Photo == null)
            {
                return NotFound();
            }
            Gallery? gallery = await _context.Gallery.FindAsync(galid);

            Photo? photo = gallery.Photo.Where(x => x.Id == id).FirstOrDefault();

            if (photo == null || photo.FileName == null || photo.MimeType == null)
            {
                return NotFound(new { Message = "Cette image n'existe pas ou n'a pas d'image." });
            }
            if (!(Regex.Match(size, "lg|sm").Success))
            {
                return BadRequest(new { Message = "La taille demandee est inadequate." });
            }
            byte[] bytes = System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + "/images/" + size + "/" + photo.FileName);
            return File(bytes, photo.MimeType);
        }

        // POST: api/Photos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{id}")]
        [DisableRequestSizeLimit]
        public async Task<ActionResult<Photo>> PostPhoto(int id)
        {
            if (_context.Photo == null)
            {
                return Problem("Entity set 'ServeurImagesContext.Picture'  is null.");
            }

            try
            {
                IFormCollection formCollection = await Request.ReadFormAsync();
                IFormFile? file = formCollection.Files.GetFile("monImage");

                if (file != null)
                {

                    Image image = Image.Load(file.OpenReadStream());
                    //creation de la galerie 
                    Gallery? gallery = await _context.Gallery.FindAsync(id);
                    if (gallery == null)
                    {
                        return NotFound();
                    }
                    //creation de la photo
                    Photo photo = new Photo();

                    photo.FileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    photo.MimeType = file.ContentType;
                    ////ajout dans la galerie
                    gallery.Photo.Add(photo);

                    image.Save(Directory.GetCurrentDirectory() + "/images/lg/" + photo.FileName);

                    image.Mutate(i =>
                        i.Resize(new ResizeOptions()
                        {

                            Mode = ResizeMode.Min,
                            Size = new Size() { Width = 320 }
                        })
                   );
                    image.Save(Directory.GetCurrentDirectory() + "/images/sm/" + photo.FileName);              

                    _context.Photo.Add(photo);
                    await _context.SaveChangesAsync();

                    return CreatedAtAction("PostPhoto", new { id = photo.Id }, photo);
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

        // DELETE: api/Photos/5
        [HttpDelete("{galid}/{id}")]
        public async Task<IActionResult> DeletePhoto(int galid,int id)
        {
            if (_context.Photo == null)
            {
                return NotFound();
            }

            Gallery? gallery = await _context.Gallery.FindAsync(galid);

            Photo? photo = gallery.Photo.Where(x => x.Id == id).FirstOrDefault();


            if (photo == null)
            {
                return NotFound(new { Message = "Cette photo n'existe pas." });
            }

            if (photo.MimeType != null && photo.FileName != null)
            {
                System.IO.File.Delete(Directory.GetCurrentDirectory() + "/images/sm/" + photo.FileName);
                System.IO.File.Delete(Directory.GetCurrentDirectory() + "/images/lg/" + photo.FileName);

            }

            _context.Photo.Remove(photo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PictureExists(int id)
        {
            return (_context.Photo?.Any(e => e.Id == id)).GetValueOrDefault();
        }

    }


    
}
