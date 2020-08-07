﻿using System.Data.Entity;

namespace Kosmisch.Sample.GroupwareApp.Data
{
    public class UserContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public UserContext() : base("name=DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Kosmisch.Sample.GroupwareApp.Models.User> Users { get; set; }
    }
}
