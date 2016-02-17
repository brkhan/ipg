using iPagooBilal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iPagooBilal.Domain;
using iPagooBilal.Domain.Services;

namespace iPagooBilal.Controllers
{
    public class HomeController : Controller
    {
        public ISearchBookService searchBookService;
        public HomeController()
        {
            searchBookService = new SearchBookService();
        } 
        public ActionResult Index()
        {
            var model = new BookModel();
            return View(model);
        }

       
        [HttpPost]
        public ActionResult Submit(BookModel model)
        {
            var searchResults = searchBookService.GetBooksBySearchCategory(model.SelectedOption);
            model.Books = searchResults.ToList();
            return View("Index",model);
        }
    }
}