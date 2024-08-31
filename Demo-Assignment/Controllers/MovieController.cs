using Microsoft.AspNetCore.Mvc;

namespace Demo_Assignment.Controllers
{
    public class MovieController:Controller
    {

        public IActionResult GetMovie(int id)
        {
            ContentResult result = new ContentResult();

            //result.Content = $"Movie with id = {id}";
            //result.ContentType = "text/pdf";
            //result.StatusCode = 200;
            //return result;

            return Content($"Movie with id = {id}", "txt/html");

        }

        public IActionResult Index()
        {

            //RedirectResult redirect  = new RedirectResult ("http://localhost:36661/Movie/GetMovie/10");
            //return redirect;
            //return Redirect("{BaseUrl}/Movie/GetMovie/10");
            //return RedirectToAction("GetMovie", new { id = 10 });
            return RedirectToRoute("Default", new { controller = "Product", action = "GetProduct", id = 100 });


        }

        public ViewResult VW() {
            return View();        
        }
    }
}
