using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class RegisteredUsers
    {
        public static UserService userService = new UserService();

        public void Show()
        {
            List<UserEntity> users = userService.GetAllUsers();

            foreach (var item in users)
            {
                Console.WriteLine(item.firstname);
                Console.WriteLine(item.lastname);
                Console.WriteLine(item.password);
                Console.WriteLine(item.email);
                Console.WriteLine();
            }
        }        
    }
}
