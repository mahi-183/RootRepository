using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_Programms.DataProceesing
{
   public class UserAccontData
    {
        private string UserName { get; set; }
        private int balance { get; set; }
        private double[] Stock { get; set; }


        public string Name
        {
            get { return this.UserName; }
            set { this.UserName = value; }
        }
        public int Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        
    }
    class UserList
    {
        public List<UserAccontData> User { get; set; }
    }
}
