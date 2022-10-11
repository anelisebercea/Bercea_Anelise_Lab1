using Microsoft.AspNetCore.Mvc;

namespace Bercea_Anelise_Lab1.Controllers
{
    public class Home1Controller : Controller
    {
       

        public string Index()
        {
            return "WELCOME!";
        }

        public string Hello()
        {
            return "Hello world!";
        }

        public string Person(string name, int age)
        {
            return name + " your age is: " + age;
        }
    }
}
