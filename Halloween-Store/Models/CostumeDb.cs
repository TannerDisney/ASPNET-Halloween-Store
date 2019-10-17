using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Halloween_Store.Data;
using Microsoft.EntityFrameworkCore;

namespace Halloween_Store.Models
{
    public static class CostumeDb
    {
        public static async Task<List<Costume>> GetAllCostumes(ApplicationDbContext context)
        {
            List<Costume> costumes = await (from c in context.Costumes 
                                            orderby c.CostumeName ascending
                                            select c).ToListAsync();
            return costumes;
        }

        public static async Task<Costume> AddCostume(Costume costume, ApplicationDbContext context)
        {
            await context.AddAsync(costume);
            await context.SaveChangesAsync();
            return costume;
        }

        public static async Task<Costume> GetCostumeById(int id, ApplicationDbContext context)
        {
            Costume c = await(from costume in context.Costumes
                              where costume.CostumeId == id
                              select costume).SingleOrDefaultAsync();
            return c;
        }

        public static async Task<Costume> UpdateCostume(Costume costume, ApplicationDbContext context)
        {
            context.Update(costume);
            await context.SaveChangesAsync();
            return costume;
        }
    }
}
