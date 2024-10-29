using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class BankAccount
    {
        private string _owner; 

        private decimal _balance; 

        private string _accountNumber; 

        public BankAccount(string owner, decimal initialBalance, string AccountNumber)
        {
            //set etmek
            _owner = owner;
            _balance = initialBalance;
            _accountNumber = AccountNumber; 
        }
        public string Owner
        {
            get { return _owner; } 

            set {  
                if(!string.IsNullOrWhiteSpace(value)) // boş or null kontrol eder değilse işlem yap! 
                { 
                    _owner = value;  
                }
                else
                {
                    Console.WriteLine();
                }
              
            }
        }
        public decimal Balance
        {
            get { return _balance;} // sadece balance degerını okur set yok
        } 
        public string AccountNumber
        {  
            get { return _accountNumber;}
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"{amount} kadar para yatırıldı. Yeni bakiye {_balance}");
            }
            else 
            {
                Console.WriteLine("Yatırılıcak para mıktarı 0 dan büyük olmalı.");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"{amount} kadar bara çekildi. Yeni bakiye {_balance}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"hesap sahibi : {_owner}");
            Console.WriteLine($"Hedap numarası : {_accountNumber} ");
            Console.WriteLine($"Mevcu bakiye : {_balance}");
        }
    }
}
