using Microsoft.AspNetCore.Mvc;
using WebApplication6.Data;
using WebApplication6.Data.Entities;

namespace WebApplication6.Controllers
{
    public class AdminController : Controller
    {
        private readonly MyShopDataContext _context;
        public AdminController(MyShopDataContext context)
        {
            _context = context; 
        }
        [HttpGet]
        public IActionResult addUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return View();
        }
    }
}
