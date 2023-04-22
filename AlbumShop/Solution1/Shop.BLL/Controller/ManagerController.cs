using Shop.DAL.Entity;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL.Controller
{
    public static class ManagerController
    {
        private static MyContext _context = new MyContext();

        public static ICollection<Manager> GetAllDatas()
        {
            return _context.Managers.ToList();
        }

        public static void AddManager(Manager manager)
        {
            _context.Managers.Add(manager);
            _context.SaveChanges();
        }

        public static void DeleteAlbum(Manager manager)
        {
            _context.Managers.Remove(manager);
            _context.SaveChanges();
        }

        public static void UpdateAlbum(Manager manager)
        {
            _context.Managers.Update(manager);
            _context.SaveChanges();
        }
        public static string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

    }
}
