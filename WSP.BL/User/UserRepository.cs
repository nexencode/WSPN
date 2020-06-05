using System;
using System.Collections.Generic;
using System.Text;

namespace WSP.BL
{
    /// <summary>
    /// Class User Repository have responsability to Save and Retrive Users
    /// </summary>
    public class UserRepository
    {
        private AddressRepository addressRepository { get; set; }

        public UserRepository()
        {
            addressRepository = new AddressRepository();
        }
        public List<User> AllUsers { get; set; }
        public List<User> GetUsers()
        {

            AllUsers = new List<User>
            {
                new User("Nemanja", "Nikolic", 29, addressRepository.RetriveAddress(1)),
                new User("John", "Ritch", 59),
                new User("James", "Jones", 33),
                new User("Maggy", "Temp", 56),
                new User("Todd", "Nikolic", 56)
            };

            return AllUsers;
        }

        public void SaveUser(List<User> users, User user)
        {
            users.Add(user);
        }

    }
}
