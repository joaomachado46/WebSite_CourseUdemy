using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcCore.Data;
using WebAppMvcCore.Models;

namespace WebAppMvcCore.Services
{
    public class DepartmentService
    {
        private readonly WebAppMvcCoreContext _context;

        public DepartmentService(WebAppMvcCoreContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Departments.OrderBy(x => x.Name).ToList();
        }
    }
}
