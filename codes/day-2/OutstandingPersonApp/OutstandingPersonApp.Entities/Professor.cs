namespace OutstandingPersonApp.Entities
{
    public class Professor : Person, IOutstanding
    {
        public int BooksPublished { get; set; }
        public Professor()
        {

        }
        public Professor(string? name, int booksPublished):base(name) => BooksPublished = booksPublished;

        public bool IsOutstanding() => BooksPublished >=5;
    }
}
