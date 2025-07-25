using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserManagement02.Data;
using UserManagement02.Interfaces;
using UserManagement02.Models;

namespace UserManagement02.Repositories
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly ApplicationDbContext _ctx;
        public DepartmentRepo(ApplicationDbContext ctx) => _ctx = ctx;

        public async Task<IEnumerable<Department>> GetAllAsync() =>
            await _ctx.Departments.ToListAsync();
    }
}