using iPagooBilal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iPagooBilal.Models
{
    public class BookModel
    {
        public List<SelectListItem> SearchOptions { get; set; }

        public List<Book> Books { get; set; }
        public string SelectedOption { get; set; }
        public string SearchedText { get; set; }
        public BookModel()
        {
            SearchOptions = new List<SelectListItem>();
            SearchOptions.Add(new SelectListItem { Text = "Author", Value = "Author" });

            SearchOptions.Add(new SelectListItem { Text = "Title", Value = "Title" });

            SearchOptions.Add(new SelectListItem { Text = "Genre", Value = "Genre"});

            SearchOptions.Add(new SelectListItem { Text = "ISBN", Value = "ISBN" });

            Books = new List<Book>();
        }
    }
}