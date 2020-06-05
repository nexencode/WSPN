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
        public Admin(string firstName, string lastName, int age, RoleType roleType) : base()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.UserRole = new Role(roleType);
        }
    }
}
