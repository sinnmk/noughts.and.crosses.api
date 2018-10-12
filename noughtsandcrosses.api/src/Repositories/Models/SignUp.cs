using System;
using System.ComponentModel.DataAnnotations;

namespace noughtsandcrosses.Server.Repositories.Models
{
    public class SignUp
    {
        [Required]
        public int SignUpId { get; set; }
        public string Nickname { get; set; }
        public int Email { get; set; }
        public string Password { get; set; }
    }
}
