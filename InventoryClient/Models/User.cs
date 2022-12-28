using System.ComponentModel.DataAnnotations;

namespace InventoryClient.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IsActive { get; set; }
        public int IsAdmin { get; set; }
    }
}
