using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class AddUserToFriends
    {
        UserService userService;


        public AddUserToFriends(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            var authenticationData = new UserAuthenticationData();

            Console.WriteLine("Введите почтовый адрес будущего друга:");
            authenticationData.Email = Console.ReadLine();

            try
            {
                userService.AddToFriend(user, authenticationData);
                Program.allFriends.Show();
            }
            catch(ArgumentNullException ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
