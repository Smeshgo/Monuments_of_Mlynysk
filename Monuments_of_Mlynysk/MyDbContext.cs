using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Monuments_of_Mlynysk.Models;
using Monuments_of_Mlynysk.Controllers;

namespace Monuments_of_Mlynysk
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=SmeSh100;Database=Monuments_of_Mlynysk");
        }
        public static void TestConnection()
            {

            using NpgsqlConnection con = GetConnection();
            con.Open();

            if (con.State == ConnectionState.Open)
            {
                Debug.WriteLine("///////////");
                Debug.WriteLine(message: "bd Conncted");
                Debug.WriteLine("///////////");
            }
            else
            {
                Debug.WriteLine("----------------");
                Debug.WriteLine("bd NOT Conncted");
                Debug.WriteLine("----------------");
            }

        }

            private static NpgsqlConnection GetConnection()
            {
                return new NpgsqlConnection(@"Host=127.0.0.1;Database=Monuments_of_Mlynysk;Password=SmeSh100;Username=postgres");
            }
        public DbSet<Users> users { get; set; }
        public DbSet<Role> role { get; set; }
        public DbSet<User_role> user_role { get; set; }

        public static void TestWrite()
            {
                
                using (MyDbContext context = new MyDbContext())
                {
                //UsersController user1;

                #region заповнення данними
                //var role = new Role()
                //{
                //    id_role = 1,
                //    name = "Admin",
                //    status = "Active",
                    
                //};

                //var user = new Users()
                //{
                //    id_user = 1,
                //    username = "Admin",
                //    password = "Admin",
                //    create_user = DateTime.Parse("2021-01-01 00:00:00"),
                //    update_user = DateTime.Parse("2021-01-01 00:00:00"),
                //    firstName = "Oleg",
                //    lastName = "Berezhanskyy",
                //    email = "Smeshgo@gmail.com",
                //    status = "Admin"
                //};

                //var user_role = new User_role()
                //{
                //    id_role = 1,
                //    id_user = 1

                //};

                //context.role.Add(role);
                //context.users.Add(user);
                //context.user_role.Add(user_role);
                //context.SaveChanges();
                #endregion
                var user = new Users();
                Debug.WriteLine(message: "-------------------------");
                Debug.WriteLine(message: user.email, user.lastName);
                } 
        }

        
    }
}