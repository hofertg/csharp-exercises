using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(string name = "World")
        {
            string html = @"<form method = 'post'>
                <input type = 'text' name = 'name' />
                <select name = 'language'>
                    <option>English</option>
                    <option>French</option>
                    <option>Italian</option>
                    <option>Japanese</option>
                    <option>Romanian</option>
                    <option>German</option>
                </select>
                <input type = 'submit' value = 'Greet me!' />
                </form>";
             
            return Content(html, "text/html");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World", string language = "English")
        {
            string hello;
            Dictionary<string, string> hellos = new Dictionary<string, string>();
            hellos.Add("English", "Hello");
            hellos.Add("French", "Bonjour");
            hellos.Add("Italian", "Ciao");
            hellos.Add("Japanese", "Konnichiwa");
            hellos.Add("Romanian", "Buna ziua");
            hellos.Add("German", "Guten Tag");

            hello = hellos[language];
            return Content(string.Format("<h1>{0}, {1}!</h1>", hello, name), "text/html");
        }

        [Route("Hello/{name}")]
        public IActionResult Index2(string name = "World")
        {
            return Content(string.Format("<h1>Hello, {0}!</h1>", name), "text/html");
        }

        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
