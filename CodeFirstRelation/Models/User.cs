using Microsoft.Extensions.Hosting;

namespace CodeFirstRelation.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        // Navigation property for the related posts
        public ICollection<Post> Posts { get; set; }
    }
}
