using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountApplicationDemoApp
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

           Account a;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //creates an account object in create button
            a = new Account();//parameterless constructor

            Account a1;
            a1 = new Account("Test", 10000);//parameterized constructor

            Account a2 = new Account(a1);//copy constructor
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            //we are taking data fom the GUI controls and putting them into the object on the heap
            //Set data into the Account object through controls

           // a.Id = int.Parse(txtId.Text);
            a.Name = txtName.Text;
            //    a.Balance = -10000000;
            // a.Deposit(decimal.Parse(txtBalance.Text));
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //taking data from to object and giving it to the GUI
            //Get back data from the Account object which is referenced by "a" from the controls
            txtId.Text = a.Id.ToString();
            txtName.Text = a.Name;
            txtBalance.Text = a.Balance.ToString();
        }

        private void btnCleaar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtBalance.Clear();
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            a = null; 
        }

        private void btnGC_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            Account a1;
            a1 = new Account();
            a = a1;
        }

        private void btnGetGeneration_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GC.GetGeneration(a).ToString());
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            a.Deposit(decimal.Parse(txtAmount.Text));
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            a.Withdraw(decimal.Parse(txtAmount.Text));
        }

        private void btnSetMB_Click(object sender, EventArgs e)
        {
            Account.MinBalance = int.Parse(txtMB.Text);
        }

        private void btnGetMB_Click(object sender, EventArgs e)
        {
            txtMB.Text = Account.MinBalance.ToString();
        }
    }
}