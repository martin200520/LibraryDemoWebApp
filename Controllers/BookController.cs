using Library3.Data;
using Library3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library3.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryContext _context;

        public BookController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Book> books = _context.Books.ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
