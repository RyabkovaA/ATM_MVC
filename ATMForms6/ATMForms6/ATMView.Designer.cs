namespace ATMForms6
{
    partial class ATMView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEnterPin = new Button();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            btnFinish = new Button();
            txtPin = new TextBox();
            txtAmount = new TextBox();
            lblState = new Label();
            lblBalance = new Label();
            lblNetworkStatus = new Label();
            SuspendLayout();
            // 
            // btnEnterPin
            // 
            btnEnterPin.Location = new Point(121, 247);
            btnEnterPin.Name = "btnEnterPin";
            btnEnterPin.Size = new Size(94, 29);
            btnEnterPin.TabIndex = 0;
            btnEnterPin.Text = "Ввести";
            btnEnterPin.UseVisualStyleBackColor = true;
            btnEnterPin.Click += btnEnterPin_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(544, 237);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(103, 29);
            btnWithdraw.TabIndex = 1;
            btnWithdraw.Text = "Снять";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(543, 281);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(104, 29);
            btnDeposit.TabIndex = 2;
            btnDeposit.Text = "Пополнить";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnFinish
            // 
            btnFinish.Location = new Point(682, 397);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(94, 29);
            btnFinish.TabIndex = 3;
            btnFinish.Text = "Завершить";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(105, 181);
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.Size = new Size(125, 27);
            txtPin.TabIndex = 4;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(531, 181);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 5;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(43, 17);
            lblState.Name = "lblState";
            lblState.Size = new Size(163, 20);
            lblState.TabIndex = 6;
            lblState.Text = "Состояние: Ожидание";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(529, 115);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(61, 20);
            lblBalance.TabIndex = 7;
            lblBalance.Text = "Баланс:";
            // 
            // lblNetworkStatus
            // 
            lblNetworkStatus.AutoSize = true;
            lblNetworkStatus.Location = new Point(539, 31);
            lblNetworkStatus.Name = "lblNetworkStatus";
            lblNetworkStatus.Size = new Size(43, 20);
            lblNetworkStatus.TabIndex = 8;
            lblNetworkStatus.Text = "Сеть:";
            // 
            // ATMView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNetworkStatus);
            Controls.Add(lblBalance);
            Controls.Add(lblState);
            Controls.Add(txtAmount);
            Controls.Add(txtPin);
            Controls.Add(btnFinish);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(btnEnterPin);
            Name = "ATMView";
            Text = "ATM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnterPin;
        private Button btnWithdraw;
        private Button btnDeposit;
        private Button btnFinish;
        private TextBox txtPin;
        private TextBox txtAmount;
        private Label lblState;
        private Label lblBalance;
        private Label lblNetworkStatus;
    }
}
