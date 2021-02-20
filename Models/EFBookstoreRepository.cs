using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreDbContext _context;

        //Constructor
        public EFBookstoreRepository (BookstoreDbContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
