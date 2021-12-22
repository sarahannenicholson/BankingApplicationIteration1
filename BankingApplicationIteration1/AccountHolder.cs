using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationIteration1
{
    public class AccountHolder
    {
        static int nextAccountHolderID = 1;
        private int accountHolderID;
        private string accountHolderName;
        private string accountHolderContact;


        public AccountHolder()
        {
            //default constructor
            //sets ID and increases when next called
            accountHolderID = nextAccountHolderID;
            nextAccountHolderID++;
        }

        public AccountHolder(string newAccountName, string newAccountContact)
        {
            //constructor with parameteres, ensures default is always called first
            accountHolderName = newAccountName;
            accountHolderContact = newAccountContact;
        } 

        public string AccountContact
        {
            get { return accountHolderContact; }
            set { accountHolderContact = value; }
        }

        public int AccountHolderID
        {
            //read only so no set
            get { return accountHolderID; }
        }

        public override string ToString()
        {
            return accountHolderName;
        }

        public virtual string Info()
        {
            return accountHolderID + " " + accountHolderName + " " + accountHolderContact;
        }
    }

    public class Staff : AccountHolder
    {
        private int Sdiscount;

        public override string Info()
        {
            return base.Info() + " " + Sdiscount;
        }
    }

    public class Customer  : AccountHolder
    {
        private int Cdiscount;

        public override string Info()
        {
            return base.Info() + " " + Cdiscount;
        }
    }
}
