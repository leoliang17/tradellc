using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using tradellc.Models;

namespace tradellc.DAL
{
    public class TradeContext : DbContext
    {
        public TradeContext() : base("TradeContext")
        {
        }


       public DbSet<ProductTypes> productTypes { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Types> types { get; set; }
        public DbSet<Types_Users> types_users { get; set; }
        public DbSet<Comments> comments { get; set; }
        public DbSet<CommentReplies> commentReplies { get; set; }

    }
}