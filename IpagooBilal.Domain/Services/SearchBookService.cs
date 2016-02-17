using System;
using System.Collections.Generic;

namespace iPagooBilal.Domain.Services
{
    public class SearchBookService : ISearchBookService
    {
        public IEnumerable<Book> GetBooksBySearchCategory(string selectedOption)
        {
            return new List<Book>
            {
                new Book
                {
                    ISBN= "eqweqwe",
                    Title= "VBook",
                    Author= "Author",
                    Genre = "ewrwerwer"
                },
                new Book
                {
                    ISBN= "eqweqwe",
                    Title= "VBook234",
                    Author= "Author",
                    Genre = "ewrwerwer"
                }
            };
        }
    }
}