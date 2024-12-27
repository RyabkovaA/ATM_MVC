using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMForms6
{
    public class ATMController
    {
        private ATMModel model;
        private ATMView view;

        public ATMController(ATMModel model, ATMView view)
        {
            this.model = model;
            this.view = view;
            this.view.SetController(this);

            //model.StateChanged += OnStateChanged;

        }

        private void OnStateChanged()
        {
            view.UpdateView(model.State, model.Balance, model.IsConnected);
        }

        public void EnterPin(int pin)
        {
            model.Authenticate(pin);
        }

        public void Withdraw(int amount)
        {
            if (model.State.Contains("Аутентификация") && model.Balance > 0)
            {
                model.Withdraw(amount);
            }
            else if (model.Balance <= 0)
            {
                model.SetState("Заблокирован");
            }
            else
            {
                model.SetState("Сначала введите PIN");
            }
        }

        public void Deposit(int amount)
        {
            model.Deposit(amount);
        }

        public void Finish()
        {
            model.Finish();
        }
        
    }
}
