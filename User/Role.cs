using System;
using System.Collections.Generic;
using System.Text;

namespace WSP.BL
{
    public enum RoleType
    {
        Admin = 1,
        Finance = 2,
        Developer = 3,
        Customer = 4
    }

    public class Role
    {
        public RoleType RoleTypeName { get; set; }
        public string _description;
        public string Description {
            get
            {
                return _description;
            }
            set
            {
                switch (RoleTypeName)
                {
                    case RoleType.Admin:
                        _description = "Ovo je Rola Admin koja upravlja celom aplikacijom i ima sva ovlascenja.";
                        break;
                    case RoleType.Finance:
                        _description = "Ovo je Rola Finance koja upravlja sa svim sto ima veze sa finansijama.";
                        break;
                    case RoleType.Developer:
                        _description = "Developer je posebna Rola. Developer moze da bude unajmljen od strane Customer-a u slucaju da ovaj kupuje Service odnosno uslugu.";
                        break;
                    case RoleType.Customer:
                        _description = "Customer je user koji ima mogucnost kupovine proizvoda i usluga....";
                        break;
                }
            }


        }
        public Role(RoleType roleTypeName)
        {
            this.RoleTypeName = roleTypeName;
        }

        public void PrintRole()
        {
            Console.WriteLine($"Role{RoleTypeName}, Role Description: {Description}");
        }
    }
}
