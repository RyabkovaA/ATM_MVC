using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMForms6
{
    public class ATMModel : Observable
    {
        private int balance;
        private string state;
        private bool isConnected;

        public ATMModel()
        {
            balance = 5000;
            state = "Ожидание PIN";
            InitializeNetwork();
        }

        public int Balance
        {
            get => balance;
            private set
            {
                balance = value;
                NotifyObservers();
            }
        }

        public string State
        {
            get => state;
            private set
            {
                state = value;
                NotifyObservers();
            }
        }

        public bool IsConnected
        {
            get => isConnected;
            private set
            {
                isConnected = value;
            }
        }

        private void InitializeNetwork()
        {
            Random random = new Random();
            isConnected = random.Next(1, 101) <= 90; 
        }

        public void SetState(string newState)
        {
            State = newState;
            NotifyObservers();
        }

        public bool Authenticate(int pin)
        {
            if (pin == 1234)
            {
                State = "Аутентификация успешна";
                return true;
            }
            State = "Неверный PIN";
            return false;
        }

        public void Withdraw(int amount)
        {
            if (balance > amount)
            {
                Balance -= amount;
                State = "Аутентификация успешна. Снято: " + amount;
            }
            else if (balance == amount)
            {
                Balance -= amount;
                State = "Заблокирован. Снято: " + amount;
            }
            else
                State = "Заблокирован. Недостаточно средств";

        }

        public void Deposit(int amount)
        {
            Balance += amount;
            State = "Аутентификация успешна. Баланс пополнен на: " + amount;
        }

        public void Finish()
        {
            State = "Ожидание PIN";
        }
    }
}