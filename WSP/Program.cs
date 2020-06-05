using System;
using System.Reflection.Metadata;
using WSP.BL;

namespace WSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var userRepository = new UserRepository();
            var users = userRepository.GetUsers();

            foreach (var user in users)
            {
                user.PrintUser();
            }

            Console.WriteLine("======================");

            User userNew = new Admin("Neko", "Tamo", 29);

            userRepository.SaveUser(users, userNew);

            foreach (var user in users)
            {
                user.PrintUser();
            }

            RoleRepository.admin.AddActionToRole(ActionRepository.UpdateProduct);

            RoleRepository.admin.AddActionToRole(ActionRepository.CreateProduct);

            RoleRepository.admin.AddActionToRole(ActionRepository.DeleteProduct);

            RoleRepository.admin.PrintAllRoleActions();



            Console.ReadKey();

        }
    }
}
