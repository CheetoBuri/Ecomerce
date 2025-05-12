using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class UserService
    {
        private UserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepository();
        }

        public List<User> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }

        public User ValidateUser(string username, string password)
        {
            return userRepository.GetUserByCredentials(username, password);
        }

        public User AuthenticateUser(string username, string password)
        {
            return userRepository.GetUserByCredentials(username, password);
        }

    }
}
