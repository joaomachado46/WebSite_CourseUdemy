using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcCore.Data;
using WebAppMvcCore.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAppMvcCore.Services
{
    public class SellerService
    {
        private readonly WebAppMvcCoreContext _context;

        public SellerService(WebAppMvcCoreContext context)
        {
            _context = context;
        }

        public List<Seller>FindAll()
        {
            return _context.Sellers.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Sellers.Include(obj => obj.Department).FirstOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Sellers.Find(id);
            _context.Sellers.Remove(obj);
            _context.SaveChanges();
        }

        public Seller Detail(int id)
        {
            return _context.Sellers.FirstOrDefault(x => x.Id == id);
        }
    }
}
