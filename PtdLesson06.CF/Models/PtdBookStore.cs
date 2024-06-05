using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PtdLesson06.CF.Models
{
    public class PtdBookStore : DbContext
    {
        public PtdBookStore() : base("PtdBookStoreConnectionString") { }
        //khai bao cac thuoc tinh tuong ung voi bang trong csdl
        public DbSet<PtdCategory> PtdCategories { get; set; }
        public DbSet<PtdBook> PtdBooks { get; set; }
    }
}