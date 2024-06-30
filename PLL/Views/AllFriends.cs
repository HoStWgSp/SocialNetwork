using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class AllFriends
    {
        public static UserService userService = new UserService();

        public void Show()
        {
            List<FriendEntity> friends = userService.GetAllFriends();

            foreach (FriendEntity friend in friends)
            {
                Console.WriteLine(@"Пользователь с id={0} является другом пользователя с id = {1}", friend.friend_id, friend.user_id);
                Console.WriteLine();
            }
        }
    }
}
