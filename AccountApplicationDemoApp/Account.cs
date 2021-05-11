using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApplicationDemoApp
{
    class Account
    {
        //FIELD MEMBERS
        private int _Id;
        private string _Name;
        private decimal _Balance;

        private static int _MinBalance = 500;

        public static int MinBalance
        {
            get
            {
                return _MinBalance;
            }
            set
            {
                if(value<0 || value>5000)
                throw new ApplicationException("Invalid value for Minimum Balance (Valid range = 0 to 5000) ");
                _MinBalance = value;
            }
        }

        static Account()
        {   //place for initialization of all members of thr class.
             
            System.Windows.Forms.MessageBox.Show("Class is loaded");
        }


        private static int _PrevId;
        //parameterless constructor 
        public Account()
        {
            //common to all constructors.
            _PrevId++;
            _Id = _PrevId;
        } 
        //parameterized constructor
        public Account(string name, decimal balance)
           :this()
        {
            //this.Id = id;
            this.Name = name;
            this.Balance = balance;
        }
        //copy constructor
        public Account(Account a): this(a._Name,a._Balance)
        { 
            //this.Id = a.Id;
            //this.Name = a.Name;
            //this.Balance = a.Balance;
        }
       
        //Id should be set only once.
        //private bool _IdAlreadySet;
        //PROPERRTIES
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
              //  _IdAlreadySet = true;
              //  if (_IdAlreadySet)
              //      throw new ApplicationException("Id already set once and cannot be changed");
              //  _Id = value;
            }
        }
        //Name should be max 8 chars in length
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value.Length > 8)
                    throw new ApplicationException("Name cannot be more than 8 characters");
                _Name = value;
            }
        }
        //ReadOnly Property
        public decimal Balance
        {
            get
            {
                return _Balance;
            }
              set
            {
              _Balance = value;
            }
        }
     
    
        //Entry point of implementation of encapsulation
        public void Deposit(decimal amount)
        {
            this._Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (this._Balance - amount < MinBalance )
            {
                throw new ApplicationException("Insufficient funds");
            }
            else
                this._Balance -= amount;
        }

        public static Account GetAccountWithMoreBalance(Account a1, Account a2)
        {

            if (a1.Balance > a2.Balance)
                return a1;
            else
                return a2;
        }

    }
}
 