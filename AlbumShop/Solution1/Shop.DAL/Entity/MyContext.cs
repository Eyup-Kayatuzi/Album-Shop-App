using Microsoft.EntityFrameworkCore;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Entity
{
    public class MyContext : DbContext
    {
        public virtual DbSet<Album> Albums { get; set; }    
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=EYP\\SQLEXPRESS;Initial Catalog=AlbumDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
