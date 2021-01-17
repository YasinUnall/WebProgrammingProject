using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProgrammingProject.Data;
using WebProgrammingProject.Models;

namespace WebProgrammingProject.Controllers
{
    public class StoreController : Controller
    {
        private readonly MotoCultureDbContext _context;

        public StoreController(MotoCultureDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public JsonResult BuyMotorcycle(short motoID)
        {
            Models.ProductViewModel motorcycle = _context.Products.Find(motoID);
            var user = _context.Users.Where(u => u.Email == User.Identity.Name).FirstOrDefault();

            try
            {
                if (user.Balance >= motorcycle.Price)
                {
                    user.Balance = user.Balance - motorcycle.Price;
                    _context.SaveChanges();

                    return Json("success");
                }
                else
                {
                    return Json("Not enough balance.");
                }
            }
            catch (Exception e)
            {
                return Json(e.Message);

            }

        }

        // GET: ProductViewModels
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Products.Include(p => p.Supplier);
            return View(await applicationDbContext.ToListAsync());
        }

    }
}
