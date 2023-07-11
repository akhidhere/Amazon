using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Account
    {

        int myaccountbalance = 1000;

        public void setbalance(int amount)
        {
            myaccountbalance = amount;

        }
        public void getbalance()
        {

            Console.WriteLine("your acco balance is:" + myaccountbalance);
        }

        class balance
        {

            public static void Main(string[] args)
            {

                Account myAccount = new Account();
                myAccount.setbalance(10000);
                myAccount.getbalance();
                Console.ReadLine();
            }


        }
    }
}
