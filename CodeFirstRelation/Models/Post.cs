namespace CodeFirstRelation.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        // Foreign Key
        public int UserId { get; set; }

        // Navigation property for the related user
        public User User { get; set; }
    }
}
