using System;
using System.Collections.Generic;
using System.Text;

namespace WSP.BL
{
    /// <summary>
    /// Derived class from User
    /// </summary>
    public class Admin : User
    {
        private static int adminId;
        public int AdminId { get; set; } = ++adminId;
        public Admin(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
