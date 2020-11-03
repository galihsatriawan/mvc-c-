using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace myMvc.Controllers
{
    public class TryController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default actiond...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}