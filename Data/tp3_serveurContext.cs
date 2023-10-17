using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tp3_serveur.Models;

namespace tp3_serveur.Data
{
    public class tp3_serveurContext : IdentityDbContext<User>
    {
        public tp3_serveurContext (DbContextOptions<tp3_serveurContext> options)
            : base(options){}

        public DbSet<tp3_serveur.Models.Gallery> Gallery { get; set; } = default!;
        public DbSet<tp3_serveur.Models.Photo> Photo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            User u1 = new User
            {
                Id = "11111111-1111-1111-1111-111111111111",
                UserName = "oui",
                Email = "o@o.o",
                NormalizedEmail = "O@O.O",
                NormalizedUserName = "OUI"
            };
            u1.PasswordHash = hasher.HashPassword(u1, "Salut1!");
            Photo p = new Photo
            {
                Id = 1,
                FileName = "11111111-1111-1111-1111-111111111111.jpg",
                MimeType = "image/jpg"

            };

            byte[] file = System.IO.File.ReadAllBytes(Directory.GetCurrentDirectory() + "/images/lg/" + p.FileName);
            Image image = Image.Load(file);
            image.Mutate(i =>
                         i.Resize(new ResizeOptions()
                         {
                             Mode = ResizeMode.Min,
                             Size = new Size() { Width = 320 }
                         })
                      );
            image.Save(Directory.GetCurrentDirectory() + "/images/sm/" + p.FileName);

            modelBuilder.Entity<Gallery>()
            .HasMany(u => u.Photo)
            .WithOne(p => p.Gallery);


            modelBuilder.Entity<Photo>().HasData(p);

            modelBuilder.Entity<User>().HasData(u1);


            modelBuilder.Entity<Gallery>().HasData(
                new { Id = 1, Name = "Galerie du seed", IsPublic = true, UserId = "11111111-1111-1111-1111-111111111111" }
            );

            modelBuilder.Entity<Gallery>().HasData(
            new { Id = 2, Name = "Galerie numero 53", FileName = p.FileName, MimeType = p.MimeType, UserId = "11111111-1111-1111-1111-111111111111", PhotoId= "1" }
            );

        }
    }
}
