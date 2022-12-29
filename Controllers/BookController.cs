using Online_Library_Management_System.Models;
using Online_Library_Management_System.Repo;
using Microsoft.AspNetCore.Mvc;

namespace Online_Library_Management_System.Controllers
{
    [Route("[controller]/[action]")]
    public class BookController : Controller
    {
        private readonly BookRepo _bookrepo = null;
        public BookController()
        {
            _bookrepo = new BookRepo();
        }
        [Route("~/")]
        public IActionResult GetAllBook()
        {
            var data= _bookrepo.GetAllBook();
            return View(data);
        }
        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var data=_bookrepo.SearchBookById(id);
            return View(data);
        }
        public IActionResult SearchBookByName(string name)
        {
            var data=_bookrepo.SearchBookByName(name);
            return View(data);
        }
        public IActionResult SearchBookByAuthor(string name)
        {
            var data = _bookrepo.SearchBookByAuthor(name);
            return View(data);
        }
    }
}
