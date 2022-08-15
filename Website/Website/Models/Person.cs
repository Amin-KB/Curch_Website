using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Website.Models
{
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Guid Guid { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; } = 2;
        public bool Active { get; set; } = true;

    }
}
