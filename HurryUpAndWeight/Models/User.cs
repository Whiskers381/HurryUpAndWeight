﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Server
{
    public class User
    {
        [Key]
        public string Name { get; set; }

        public string Password { get; set; }

        public User()
        {

        }
    }
    public static class UserDatabaseAccess
    {
        public static bool CreateUser(UserContext context, string name, string password)
        {
            if(Exists(context, name))
            {
                return false;
            }
            else
            {
                User user = new User() { Name = name, Password = password };

                context.Users.Add(user);
                context.SaveChanges();

                return true;
            }
        }
        public static bool CreateUser(UserContext context, NetworkAPI.JsonMirrors.User.NameAndPassword nameAndPassword)
        {
            return CreateUser(context, nameAndPassword.UserName, nameAndPassword.UserPassword);
        }

        public static bool Exists(UserContext context, string name)
        {

            if (context.Users.Find(name) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool LogIn(UserContext context, string name, string password)
        {
            User user = context.Users.Find(name);
            if (user != null)
            {
                if (user.Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool LogIn(UserContext context, NetworkAPI.JsonMirrors.User.NameAndPassword nameAndPassword)
        {
            return LogIn(context, nameAndPassword.UserName, nameAndPassword.UserPassword);
        }
    }
    public class UserContext : DbContext
    {
        public UserContext() : base()
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DistSysACW;");

            //https://www.roundthecode.com/dotnet/entity-framework/setting-up-your-dbcontext-for-entity-framework-in-dotnet-core
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("UserContext"));






            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Users;");
        }
    }
}
