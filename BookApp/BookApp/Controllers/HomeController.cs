using BookApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookLibrary;

namespace BookApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View(BookRepository.kitapListesi);
        }

        public IActionResult Details(int id)
        {
            return View(BookRepository.kitapListesi.FirstOrDefault(i => i.BookId == id));
        }
     }

   
    }

