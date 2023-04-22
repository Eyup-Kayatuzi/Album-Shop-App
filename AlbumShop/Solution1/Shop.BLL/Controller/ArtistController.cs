using Shop.DAL.Entity;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL.Controller
{
    public static class ArtistController
    {
        private static MyContext _context = new MyContext();

        public static ICollection<Artist> GetAllDatas()
        {
            return _context.Artists.ToList();
        }

        public static void AddAlbum(Artist artist)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
        }

        public static void DeleteAlbum(Artist artist)
        {
            _context.Artists.Remove(artist);
            _context.SaveChanges();
        }

        public static void UpdateAlbum(Artist artist)
        {
            _context.Artists.Update(artist);
            _context.SaveChanges();
        }
    }
}
