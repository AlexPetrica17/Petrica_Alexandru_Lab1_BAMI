using Microsoft.AspNetCore.Mvc;

namespace Petrica_Alexandru_Lab1.Controllers
{
    public class MessagesController : Controller
    {
        public string Index()
        {
            return "Welcome";
        }

        public string Greeting()
        {
            return "Hello!";
        }

        public string PersonalizedMessage(string name, int age)
        {
            return $"{name} has the age of {age}";
        }
    }
}
