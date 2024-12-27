namespace ATMForms6
{
    public partial class ATMView : Form, IObserver
    {
        private ATMController controller;
        private ATMModel model;

        public ATMView()
        {
            InitializeComponent();
            InitializeState();
        }

        public void SetController(ATMController controller)
        {
            this.controller = controller;
        }

        public void SetModel(ATMModel model)
        {
            this.model = model;
            model.AddObserver(this);
        }

        private void InitializeState()
        {
            lblBalance.Visible = false;
            btnDeposit.Enabled = false;
            btnWithdraw.Enabled = false;
            txtPin.Visible = true;
            btnEnterPin.Visible = true;
            lblState.Text = "Введите PIN";
            txtPin.Clear();
        }

        public void Update()
        {
            UpdateView(model.State, model.Balance, model.IsConnected);
        }

        public void UpdateView(string state, int balance, bool isConnected)
        {
            lblState.Text = "Состояние: " + state;
            lblNetworkStatus.Text = "Сеть: " + (isConnected ? "Подключено" : "Отключено");

            if (state.Contains("Аутентификация успешна"))
            {
                lblBalance.Visible = true;
                lblBalance.Text = "Баланс: " + balance + " ед.";
                txtPin.Visible = false;
                btnEnterPin.Visible = false;
                btnDeposit.Enabled = true;
                btnWithdraw.Enabled = balance > 0;
            }
            else if (state.Contains("Ожидание PIN"))
            {
                InitializeState();
            }
            else if (state.Contains("Заблокирован"))
            {
                btnWithdraw.Enabled = false;
                lblBalance.Visible = true;
                lblBalance.Text = "Баланс: " + balance + " ед.";
            }
            else
            {
                lblBalance.Visible = false;
            }
        }

        private void btnEnterPin_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Ввести пин", txtPin.Text);
            int pin = int.Parse(txtPin.Text);
            controller.EnterPin(pin);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txtAmount.Text);
            controller.Withdraw(amount);
            txtAmount.Clear();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txtAmount.Text);
            controller.Deposit(amount);
            txtAmount.Clear();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            controller.Finish();
            InitializeState();
        }
    }
}
