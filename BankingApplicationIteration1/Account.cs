using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationIteration1
{
    public class Account
    {
        static int nextAccountID = 1;
        private int accountID;
        private int accountHolderID;
        private double accountBalance;
        private string accountType;
        private int accountTransactions;

        public Account()
        {
            //default constructor
            //sets ID and increases when next called
            accountID = nextAccountID;
            nextAccountID++;
        }

        public Account(int newAccID, int newAccHolderID, double accBal, string accType, int accTrans) : this()
        {
            //contructor with parameters
            accountID = newAccID;
            accountHolderID = newAccHolderID;
            accountBalance = accBal;
            accountType = accType;
            accountTransactions = accTrans;
                
        }
        public int AccountID
        {
            //read only as we dont want to be able to set this
            get { return accountID; }
        }

        public double AccountBalance
        {
            // get and set for account balance so can be updated with deposits/interest etc
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public int AccountHolderID
        {
            //get only for account holder ID as should be linked to the accountholder class
            get { return accountHolderID; }
            set { accountHolderID = value; }
        }
        
        public string  AccountType
        {
            //links to account types class so can set rates for account
            get { return accountType; }
            set { accountType = value; }
        }

        public int AccountTransactions
        {
            //links to transaction numbers
            get { return accountTransactions; }
            set { accountTransactions = value; }
        }

        public virtual string AllInfo()
        {
            return "Account Number: " + accountID + ". Account Holder ID:  " + accountHolderID + ". Balance: " + accountBalance + ". Type: " + accountType;
        }

        public virtual string Info()
        {
            return accountType + " " + accountID + " " + accountBalance;
        }

        public virtual double ReturnBal()
        {
            return accountBalance;
        }

        public virtual string ReturnAccType()
        {
            return accountType;
        }

        public override string ToString()
        {
            return accountType;
        }

    }

    public class EverydayAccount : Account
    {
        private double eintrest;
        private double fee;
        private int overdraft;

        public double Intrest
        {
         
            get { return eintrest; }
            set { eintrest = value; }
        }

        public double Fee
        {

            get { return fee; }
            set { fee = value; }
        }

        public int Overdraft
        {

            get { return overdraft; }
            set { overdraft = value; }
        }
        public override string Info()
        {
            return base.Info() + " " + eintrest + " Intrest Rate, " + fee + " Fee, " + overdraft + " Overdraft Limit";
        }    
        
        public virtual double EIntrest()
        {
            return eintrest;
        }

    }

    public class InvestAccount : Account
    {
        private double investintrest;
        private double fee = 10.00;
        private int overdraft;
        public double Intrest
        {

            get { return investintrest; }
            set { investintrest = value; }
        }

        public double Fee
        {

            get { return fee; }
            set { fee = value; }
        }

        public int Overdraft
        {

            get { return overdraft; }
            set { overdraft = value; }
        }
        public override string Info()
        {
            return base.Info() + " " + investintrest + " Intrest Rate, " + fee + " Fee, " + overdraft + " Overdraft Limit";
        }

        public virtual double InvestIntrest()
        {
            return investintrest;
        }
    }

    public class OmniAccount : Account
    {
        private double omniintrest;
        private double fee = 10.00;
        private double overdraft = 100.00;

        public double Intrest
        {

            get { return omniintrest; }
            set { omniintrest = value; }
        }

        public double Fee
        {

            get { return fee; }
            set { fee = value; }
        }

        public double Overdraft
        {

            get { return overdraft; }
            set { overdraft = value; }
        }
        public override string Info()
        {
            return base.Info() + " " + omniintrest + " Intrest Rate, " + fee + " Fee, " + overdraft + " Overdraft Limit";
        }

        public virtual double OmniIntrest()
        {
            return omniintrest;
        }

    }

    public class Withdrawl : Account
    {
        private int withdrawlAmount;
        private int fromAccount;
        private int accOriginalBal;
        private int accNewBal;
        private int withdawFee;
        private bool transAccepted;
        private int transactionNumber;
        static int nexttransactionNumber = 1;

        public Withdrawl()
        {
            //default constructor
            //sets ID and increases when next called
            transactionNumber = nexttransactionNumber;
            nexttransactionNumber++;
        }
        public int TransactionNumber
        {
            //read only so no set
            get { return transactionNumber; }
        }

        public int WithdrawlAmount
        {
            get { return withdrawlAmount; }
            set { withdrawlAmount = value; }
        }

        public int FromAccount
        {
            get { return fromAccount; }
            set { fromAccount = value; }
        }

        public int OriginalBal
        {
            get { return accOriginalBal; }
            set { accOriginalBal = value; }
        }

        public int NewBal
        {
            get { return accNewBal; }
            set { accNewBal = value; }
        }

        public int WithdrawlFee
        {
            get { return withdawFee; }
            set { withdawFee = value; }
        }

        public bool TransAccepted
        {
            set { _ = transAccepted; }
        }

        public override string Info()
        {
            return base.Info() + " " ;
        }

    }

    public class Deposit : Account
    {
        private int depositAmount;
        private int fromAccount;
        private int accOriginalBal;
        private int accNewBal;
        private int depositFee;
        private bool transAccepted;
        private int transactionNumber;
        static int nexttransactionNumber = 1;

        public Deposit()
        {
            //default constructor
            //sets ID and increases when next called
            transactionNumber = nexttransactionNumber;
            nexttransactionNumber++;
        }
        public int TransactionNumber
        {
            //read only so no set
            get { return transactionNumber; }
        }

        public int WithdrawlAmount
        {
            get { return depositAmount; }
            set { depositAmount = value; }
        }

        public int FromAccount
        {
            get { return fromAccount; }
            set { fromAccount = value; }
        }

        public int OriginalBal
        {
            get { return accOriginalBal; }
            set { accOriginalBal = value; }
        }

        public int NewBal
        {
            get { return accNewBal; }
            set { accNewBal = value; }
        }

        public int WithdrawlFee
        {
            get { return depositFee; }
            set { depositFee = value; }
        }

        public bool TransAccepted
        {
            set { _ = transAccepted; }
        }

        public override string Info()
        {
            return base.Info() + " ";
        }

    }

    public class WithdrawMoney
    {

    }
}

