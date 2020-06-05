using System;
using System.Collections.Generic;
using System.Text;

namespace WSP.BL
{
    public static class RoleRepository
    {
        public static Role admin = new Role("Admin", "This role can controll everything.");
        public static Role finance = new Role("Finance", "This role can controll everything about finance.");
        public static Role developer = new Role("Developer", "This role can be hired by service product.");
        public static Role customer = new Role("Customer", "This role can buy products.");
    }
} 
