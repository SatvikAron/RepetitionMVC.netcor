using Microsoft.AspNetCore.Identity;
using RepetitionclassWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepetitionclassWebApp.Data
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {

            //Admin Role for Role mananger for Menu bar
            //Seed one role: Administrators
            if (!context.Roles.Any())
            {
                var admin = new IdentityRole { Name = "Admin" };
                var result = roleManager.CreateAsync(admin);
            }
            //Seed two user accounts: Student and Administrator
            //Seed two user accounts:  Student

            if (!context.Users.Any())
            {
                var user1 = new ApplicationUser { UserName = "Student@test.com", Email = "Student@test.com" };
                var result1 = userManager.CreateAsync(user1, "MVc12@").Result;
                //var roleResult1 = userManager.AddToRoleAsync(user1, "Admin").Result;

                var user2 = new ApplicationUser { UserName = "Admin@test.com", Email = "Admin@test.com" };
                var result2 = userManager.CreateAsync(user2, "MVc1234@").Result;
                var roleResult2 = userManager.AddToRoleAsync(user2, "Admin").Result;

            }
            //Seed two user accounts:  Administrator

            //product list seed
            var aproduct = new Product() { Name = "Computer", UnitPrice = 10000, ReleaseDate = new DateTime(2018,01,10), IsDeleted=true };
            var bproduct = new Product() { Name = "Mouse", UnitPrice = 1000, ReleaseDate = new DateTime(2017, 01, 10), IsDeleted = true };
            var cproduct = new Product() { Name = "Tabletpc", UnitPrice = 30000, ReleaseDate = new DateTime(2016, 01, 10), IsDeleted = false };
            var dproduct = new Product() { Name = "Laptop", UnitPrice = 50000, ReleaseDate = new DateTime(2017, 01, 10), IsDeleted = false };

            context.Add(aproduct);
            context.Add(bproduct);
            context.Add(cproduct);
            context.Add(dproduct);


            context.SaveChanges();


        }
    }
}
