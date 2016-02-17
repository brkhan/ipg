using System.Collections.Generic;

namespace iPagooBilal.Domain.Services
{
    public interface ISearchBookService
    {
        IEnumerable<Book> GetBooksBySearchCategory(string selectedOption);
    }
}