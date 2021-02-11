using AspNetExample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetExample.Controllers
{
    public class JsonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Receive(Book book)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Send()
        {
            return Ok(new Book
            {
                Id = 0,
                Name = "Teste",
                Description = "Um belo teste"
            });
        }
    }
}
