using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TheBlogProject.Data;
using TheBlogProject.Enums;
using TheBlogProject.Models;


namespace TheBlogProject.Services
{
    public class DataService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<BlogUser> _userManager;

        public DataService(ApplicationDbContext dbContext, RoleManager<IdentityRole> roleManager, UserManager<BlogUser> userManager)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task ManageDataAsync()
        {
           await _dbContext.Database.MigrateAsync();

           await SeedRolesAsync();

           await SeedUsersAsync();
        }

         private async Task SeedRolesAsync()
        {
            if (_dbContext.Roles.Any()) return;
            
            foreach(var role in Enum.GetNames(typeof(BlogRole)))
            {
               await _roleManager.CreateAsync(new IdentityRole(role));
            }
                

            
            
        }

        private async Task SeedUsersAsync()
        {
            if(_dbContext.Users.Any()) return;

            var adminUser = new BlogUser()
            {
                //rghgnwnowyolwgnd
                Email = "thegnatx@gmail.com",
                UserName = "thegnatx@gmail.com",
                FirstName = "Simon",
                LastName = "Sparrow",
      
                PhoneNumber = "574941223",
                EmailConfirmed = true
            };
          await  _userManager.CreateAsync(adminUser, "Juiced20!");

          await  _userManager.AddToRoleAsync(adminUser, BlogRole.Administrator.ToString());

            var modUser = new BlogUser()
            {
                Email = "gnatx@op.pl",
                UserName = "gnatx@op.pl",
                FirstName = "Andrew",
                LastName = "Russel",
                PhoneNumber = "574941223",
                EmailConfirmed = true
            };

            await _userManager.CreateAsync(modUser, "Juiced20!");

            await _userManager.AddToRoleAsync(modUser, BlogRole.Moderator.ToString());
        }







    }
}
