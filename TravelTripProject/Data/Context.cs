using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using TravelTripProject.Models;

namespace TravelTripProject.Data
{
    public class Context : DbContext
    {
        //public DbSet<HomePage> HomePages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<AddressBlog> AddressBlogs { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}