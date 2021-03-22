using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HocWeb2.Models
{
    public partial class QuanLyShop_Context : DbContext
    {
        public QuanLyShop_Context()
            : base("name=QuanLyShop_Context")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
