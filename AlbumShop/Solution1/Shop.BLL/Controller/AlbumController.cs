using Shop.DAL.Entity;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL.Controller
{
    public static class AlbumController
    {
        private static MyContext _context = new MyContext();

        public static ICollection<Album> GetAllDatas()
        {
            return _context.Albums.ToList();
        }

        public static void AddAlbum(Album album)
        {
            _context.Albums.Add(album);
            _context.SaveChanges();
        }

        public static void DeleteAlbum(Album album)
        {
            _context.Albums.Remove(album);  
            _context.SaveChanges(); 
        }

        public static void UpdateAlbum(Album album)
        {
            _context.Albums.Update(album);
            _context.SaveChanges();
        }
    }
}
