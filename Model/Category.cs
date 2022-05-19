namespace AspNetIdentity.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AspNetIdentityUserId { get; }
        public List<Note> Notes { get; set; } = new List<Note>();


    }
}
