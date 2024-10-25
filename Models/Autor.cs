namespace Pop_Andra_lab2.Models
{
    public class Autor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
