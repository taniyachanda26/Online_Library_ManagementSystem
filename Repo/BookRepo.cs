using Online_Library_Management_System.Models;

namespace Online_Library_Management_System.Repo
{
    public class BookRepo
    {
        public List<Book> GetAllBook()
        {
            return DataSource();
        }
        public Book SearchBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<Book> SearchBookByName(string name)
        {
            return DataSource().Where(x=>x.Title.Contains(name)).ToList();
        }
        public List<Book> SearchBookByAuthor(string name)
        {
            return DataSource().Where(x=>x.Author.Contains(name)).ToList();
        }
        private List<Book> DataSource()
        {
            List<Book> books = new List<Book>() {
            new Book(){Id=1,Title="Believe-What Life and Cricket Taught Me",Author="Suresh Raina",ImagePath="https://m.media-amazon.com/images/I/51pW8eY7BEL.jpg"},
            new Book(){Id=2,Title="Queen of Fire",Author="Devika Rangachari",ImagePath="https://m.media-amazon.com/images/I/71Vb9WZH6SL.jpg"},
            new Book(){Id=3,Title="The Night Train at Deoli and Other Stories",Author="Ruskin Bond",ImagePath="https://m.media-amazon.com/images/I/81APABLp4wS.jpg" },
            new Book(){Id=4,Title="WRIST ASSURED - AN AUTOBIOGRAPHY",Author="Gundappa Vishwanath",ImagePath="https://m.media-amazon.com/images/I/61qbPx+-HlL.jpg"},
            };
            return books;
        }
    }
}
