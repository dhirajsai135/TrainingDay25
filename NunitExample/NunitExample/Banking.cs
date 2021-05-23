using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitExample
{
    public class Banking
    {
        public double Balance { get; set; }
        public string msg { get; set; }
        public Banking()
        {
            Balance = 400;
        }
        public void DepositAmount(int amt)
        {
            Balance += amt;
        }
        public string WithDrawAmount(int amt)
        {
            if (amt > Balance)
            {
                msg = "Sorry! Insuffecient balance";
                return msg;
            }
            else
            {
                Balance -= amt;
                return "success";
            }
        }
    }
}
