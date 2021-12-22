using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplicationIteration1
{
    public partial class Form1 : Form
    {
        //list to maintain objs of the account class
        private List<Account> AllAccounts = new List<Account>();
        double overallBal = 0;

        public Form1()
        {
            InitializeComponent();
            //read data from file
            ReadAccountFile();
            //display accounts from file to listbox
            DisplayAccounts();

        }


        public void DisplayAccounts()
        {    
            //clear the display box
            listBoxWithAccounts.Items.Clear();

            //add items to the list box
            foreach (Account a in AllAccounts)
            {
                listBoxWithAccounts.Items.Add(a); 
            }

            //listBoxWithAccounts.SelectedIndex = 0;
        }



        private void getAccountInfo_Click(object sender, EventArgs e)
        {
            //takes the selected account in the list box
            //and shows the data into the label 
            Account account = (Account)listBoxWithAccounts.SelectedItem;
            displayForAccountInfo.Text = account.AllInfo();
            overallBal = account.ReturnBal();
        }

        private void listBoxWithAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        private void withdrawlMoneyButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(moneyEntryBox.Text))
            {
                //error popup saying please enter value
                MessageBox.Show("Please input value into text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double userVal = double.Parse(moneyEntryBox.Text);
                if (userVal > overallBal)
                {
                    MessageBox.Show("You do not have enough to complete this transaction, A failed transaction fee has been withdrawn from your account.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    overallBal = overallBal - 10.00;
                    newBalanceOutput.Text = overallBal.ToString();
                }
                else
                {
                    //Account account = (Account)listBoxWithAccounts.SelectedItem;
                    //double oldbal = account.ReturnBal();
                    double newbal = overallBal - userVal;
                    newBalanceOutput.Text = newbal.ToString();
                    //need this to eventually override the balance in the accounts list

                    overallBal = newbal;
                }

            }

        }

        private void depositMoneyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(moneyEntryBox.Text))
            {
                //error popup saying please enter value
                MessageBox.Show("Please input value into text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                double userVal = double.Parse(moneyEntryBox.Text); 
                //Account account = (Account)listBoxWithAccounts.SelectedItem;
                //double oldbal = account.ReturnBal();
                double newbal = overallBal + userVal;
                newBalanceOutput.Text = newbal.ToString();
                //need this to eventually override the balance in the accounts list

                overallBal = newbal;
            }

        }

        private void addIntrestButton_Click(object sender, EventArgs e)
        {
            Account account = (Account)listBoxWithAccounts.SelectedItem;
            //double balance = account.ReturnBal();
            string type = account.ReturnAccType();

            if(type == "OmniAccount")
            {
                double calc1 = (overallBal * 4 * 1) / 100;
                double calc2 = overallBal + calc1;
                newBalanceOutput.Text = calc2.ToString();
            }
            else if(type == "IntrestAccount")
            {
                double calc1 = (overallBal * 8 * 1) / 100;
                double calc2 = overallBal + calc1;
                newBalanceOutput.Text = calc2.ToString();
            }
            else
            {
                double calc1 = (overallBal * 0 * 1) / 100;
                double calc2 = overallBal + calc1;
                newBalanceOutput.Text = calc2.ToString();
            }
            
            
        }


        private void ReadAccountFile()
        {
            //reads the data from the account txt file
            Account account;
            string[] strArray;

            //opens the txt file
            var myfile = new StreamReader("../../accounts.txt");

            while (!myfile.EndOfStream)
            {
                //reads line and splits into sub strings
                strArray = myfile.ReadLine().Split(',');
                //calls constructor
                account = new Account(Convert.ToInt32(strArray[0]), Convert.ToInt32(strArray[1]), Convert.ToDouble(strArray[2]), strArray[3], Convert.ToInt32(strArray[4]));
                //add objs to list
                AllAccounts.Add(account);
            }

            myfile.Close();
        }

      
    }
}
