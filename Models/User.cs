using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace tp3_serveur.Models
{
    public class User : IdentityUser
    {
        [JsonIgnore]
        public virtual List<Gallery> Galleries { get; set; } = null!;
    }
}
