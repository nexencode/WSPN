using System;
using System.Collections.Generic;

namespace WSP.BL
{
    /// <summary>
    /// Base class User
    /// </summary>
    abstract public class User
    {
        // Fields and Properties
        #region Fields and Properties
        private static int userId;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Address UserAddress { get; set; }
        public List<Role> RoleList { get; set; }
        #endregion

        #region Constructor
        public User()
        {
            ID = ++userId;
            RoleList = new List<Role>();
        }
        public User(string firstName, string lastName, int age) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public User(string firstName, string lastName, int age, Address userAddress) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.UserAddress = userAddress;
        }
        #endregion Constructor

        #region Methods
        public void PrintUser()
        {
            Console.WriteLine($"ID: {ID}, Name: {FirstName} {LastName}, Age: {Age}");
        }

        public void AddRoleToUserList(Role role)
        {
            RoleList.Add(role);
        }

        public bool CheckIfActionIsAvailable()
        {
            bool isavailable = true;

            return isavailable;
        }
        #endregion
    }
}
