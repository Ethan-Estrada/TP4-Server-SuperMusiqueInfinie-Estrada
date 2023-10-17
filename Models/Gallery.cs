
using System.Text.Json.Serialization;

namespace tp3_serveur.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string? FileName { get; set; }
        public string? MimeType { get; set; }

        [JsonIgnore]
        public virtual User? User { get; set; }
        [JsonIgnore]
        public virtual List<Photo>? Photo { get; set; }
    }
}
