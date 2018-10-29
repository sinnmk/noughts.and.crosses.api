using System.ComponentModel.DataAnnotations;

namespace noughtsandcrosses.api.Repositories.Models
{
    public class SignUp
    {
        [Key]
        public int SignUpId { get; set; }
        [Required]
        public string Nickname { get; set; }
        [Required]
        public int Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
