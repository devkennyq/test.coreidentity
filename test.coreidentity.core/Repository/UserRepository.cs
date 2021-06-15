using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.coreidentity.core.Data;
using test.coreidentity.core.Interfaces;
using test.coreidentity.core.Models;

namespace test.coreidentity.core.Repository
{
    public class UserRepository : AppDbContext, IUserRepository
    {
        public const string ROLE_NAME = "regular";

        readonly UserManager<ApplicationUser> userManager;
        


        public UserRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
            :base(context)
        {
            this.userManager = userManager;
        }

        public async Task AddUser(UserInfo userInfo)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = userInfo.UserName,
                Email = userInfo.Email,
                ExternalKey = userInfo.ExternalKey,
                EmailConfirmed = false,
                PhoneNumberConfirmed = false
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Password.123");
                    await userManager.AddToRoleAsync(defaultUser, ROLE_NAME);
                }

            }
        }

        public async Task AddUsers()
        {
            //Read users from json file and create them.
            StreamReader r = new StreamReader(@"D:\Workspaces\test.coreidentity\mock_data\MOCK_DATA_USER.json");
            string jsonString = r.ReadToEnd();
            List<UserInfo> userInfo = JsonConvert.DeserializeObject<List<UserInfo>>(jsonString);

            //Create users in db.
            foreach (var user in userInfo.Take(5))
            {
               await AddUser(user);
            }
        }

        
    }
}
