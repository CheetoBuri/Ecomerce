using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using DAL;

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
    }
}
