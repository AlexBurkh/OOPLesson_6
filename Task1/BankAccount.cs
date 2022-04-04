using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class BankAccount
    {
        public BankAccount() : this(BankAccountType.debit, default(decimal)) { }
        public BankAccount(decimal balance) : this(BankAccountType.debit, balance) { }
        public BankAccount(BankAccountType type) : this(type, default(decimal)) { }
        public BankAccount(BankAccountType type, decimal balance)
        {
            _accountNumber = BankAccount.GenerateAccountNumber();
            _accountType = type;
            _balance = balance;
        }


        private static int _lastNumber = 0;
        private decimal _accountNumber;
        private decimal _balance;
        private BankAccountType _accountType;

        internal decimal Number { get { return _accountNumber; } }
        internal decimal Balance { get { return _balance; } private set { _balance = value; } }
        internal BankAccountType Type
        {
            get
            {
                return _accountType;
            }
            set
            {
                _accountType = value;
            }
        }

        private static int GenerateAccountNumber()
        {
            int num = _lastNumber;
            _lastNumber += 1;
            return num;
        }
        public void AddToBalance(decimal sum) { Balance += sum; }
        public decimal TakeFromBalance(decimal sum)
        {
            if (Balance >= sum)
            {
                Balance -= sum;
                return sum;
            }
            return 0;
        }
        public void TopUpBalanceFromAnotherAccount(BankAccount sourceAccount, decimal amount)
        {
            decimal moneyTaken = sourceAccount.TakeFromBalance(amount);
            if (moneyTaken > 0)
            {
                _balance += moneyTaken;
            }
        }
    }
}