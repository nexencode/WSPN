using System;

namespace WSP.BL
{
    /// <summary>
    /// Base class User
    /// </summary>
    public class User
    {
        // Fields and Properties
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

        #region Constructor
        public User()
        {
            ID = ++userId;
        }
        public User(string firstName, string lastName, int age, RoleType roleType) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.UserRole = new Role(roleType);
        }
        public User(string firstName, string lastName, int age, RoleType roleType, Address userAddress) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.UserRole = new Role(roleType);
            this.UserAddress = userAddress;
        }
        #endregion Constructor

        public void PrintUser()
        {
            Console.WriteLine($"ID: {ID}, Name: {FirstName} {LastName}, Age: {Age}, Role: { UserRole.RoleTypeName}, Role Description: {UserAddress.ShowAddress()}");
        }
    }
}
