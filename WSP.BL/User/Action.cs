using System;
using System.Collections.Generic;
using System.Text;

namespace WSP.BL
{
    public class Action
    {
        #region Fields and Properties
        private static int actionId;
        public int ActionId { get; set; } = ++actionId;
        public string ActionName { get; set; }
        public string ActionDescription { get; set; }
        #endregion

        #region Constructors
        public Action(string actionName, string actionDescription)
        {
            //ActionId = ++actionId;
            ActionName = actionName;
            ActionDescription = actionDescription;
        }
        #endregion

        #region Methods
        public void PrintAction()
        {
            Console.WriteLine($"ID: {ActionId}, Description: {ActionDescription}");
        }
        #endregion
    }
}
