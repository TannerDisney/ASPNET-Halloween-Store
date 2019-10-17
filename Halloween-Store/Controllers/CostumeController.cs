using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Halloween_Store.Data;
using Halloween_Store.Models;
using Microsoft.AspNetCore.Mvc;

namespace Halloween_Store.Controllers
{
    public class CostumeController : Controller
    {
        private readonly ApplicationDbContext context;

        public CostumeController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            List<Costume> c = await CostumeDb.GetAllCostumes(context);
            return View(c);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Costume costume)
        {
            if (ModelState.IsValid)
            {
                await CostumeDb.AddCostume(costume, context);
                return RedirectToAction("Index");
            }

            return View(costume);
        }

        public async Task<IActionResult> Update(int id)
        {
            Costume costume = await CostumeDb.GetCostumeById(id, context);
            return View(costume);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Costume costume)
        {
            if (ModelState.IsValid)
            {
                await CostumeDb.UpdateCostume(costume, context);
                return RedirectToAction("Index");
            }

            return View(costume);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Costume costume = await CostumeDb.GetCostumeById(id, context);

            return View(costume);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await CostumeDb.DeleteCostumeById(id, context);
            return RedirectToAction("Index");
        }
    }
}