using System.Text.Json.Serialization;

namespace tp3_serveur.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string? FileName { get; set; }
        public string? MimeType { get; set; }
        [JsonIgnore]

        public virtual Gallery? Gallery { get; set; }
    }
}
