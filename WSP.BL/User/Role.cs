﻿using System;
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
        #region Fields and Properties
        private static int roleId;
        public int RoleId { get; } = ++roleId;
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public List<Action> RoleActions { get; set; }
        #endregion

        #region Constructors
        public Role(string roleName, string roleDescription)
        {
            RoleName = roleName;
            RoleDescription = roleDescription;
            RoleActions = new List<Action>();
        }
        #endregion

        #region Methods
        public void PrintRole()
        {
            Console.WriteLine($"Role{RoleName}, Role Description: {RoleDescription}");
        }

        public void AddActionToRole(Action action)
        {
            RoleActions.Add(action);
        }

        public bool CheckIfActionIsAvailable(string actionName)
        {
            bool isAvailable = false;

            foreach (var a in RoleActions)
            {
                if (actionName == a.ActionName)
                {
                    isAvailable = true;
                }
            }
            return isAvailable;
        }

        public void PrintAllRoleActions()
        {
            foreach (var action in RoleActions)
            {
                action.PrintAction();
            }
        }
        #endregion
    }
}
