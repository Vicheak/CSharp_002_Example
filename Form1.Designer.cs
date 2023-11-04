namespace _006_example
{
    partial class Form1
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
            Label label1;
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtUse = new TextBox();
            txtUnit = new TextBox();
            txtTotal = new TextBox();
            txtPay = new TextBox();
            txtPaid = new TextBox();
            txtRemain = new TextBox();
            txtPayTotal = new TextBox();
            lblUseShowError = new Label();
            lblPaidShowError = new Label();
            label11 = new Label();
            label12 = new Label();
            txtHistory = new TextBox();
            txtReport = new TextBox();
            label5 = new Label();
            label13 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Khmer M1", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(20, 0, 0, 0);
            label1.Size = new Size(982, 44);
            label1.TabIndex = 0;
            label1.Text = "កម្មវិធីបង់ថ្លៃភ្លើង";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(117, 33);
            label2.TabIndex = 1;
            label2.Text = "ចំនួនប្រើប្រាស់";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 153);
            label3.Name = "label3";
            label3.Size = new Size(75, 33);
            label3.TabIndex = 1;
            label3.Text = "ថ្លៃឯកតា";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 228);
            label4.Name = "label4";
            label4.Size = new Size(69, 33);
            label4.TabIndex = 1;
            label4.Text = "ថ្លៃសរុប";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(371, 228);
            label6.Name = "label6";
            label6.Size = new Size(69, 33);
            label6.TabIndex = 1;
            label6.Text = "បានបង់";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(684, 153);
            label7.Name = "label7";
            label7.Size = new Size(57, 33);
            label7.TabIndex = 1;
            label7.Text = "ជំពាក់";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(684, 228);
            label8.Name = "label8";
            label8.Size = new Size(51, 33);
            label8.TabIndex = 1;
            label8.Text = "សរុប";
            // 
            // txtUse
            // 
            txtUse.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUse.Location = new Point(129, 59);
            txtUse.Name = "txtUse";
            txtUse.Size = new Size(223, 40);
            txtUse.TabIndex = 1;
            txtUse.TextChanged += txtUse_TextChanged;
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.WhiteSmoke;
            txtUnit.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnit.Location = new Point(129, 146);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(223, 40);
            txtUnit.TabIndex = 2;
            txtUnit.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.WhiteSmoke;
            txtTotal.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(129, 225);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(223, 40);
            txtTotal.TabIndex = 2;
            txtTotal.TabStop = false;
            // 
            // txtPay
            // 
            txtPay.BackColor = Color.WhiteSmoke;
            txtPay.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPay.Location = new Point(438, 146);
            txtPay.Name = "txtPay";
            txtPay.ReadOnly = true;
            txtPay.Size = new Size(223, 40);
            txtPay.TabIndex = 2;
            txtPay.TabStop = false;
            // 
            // txtPaid
            // 
            txtPaid.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaid.Location = new Point(438, 225);
            txtPaid.Name = "txtPaid";
            txtPaid.Size = new Size(223, 40);
            txtPaid.TabIndex = 2;
            txtPaid.TextChanged += txtPaid_TextChanged;
            // 
            // txtRemain
            // 
            txtRemain.BackColor = Color.WhiteSmoke;
            txtRemain.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtRemain.Location = new Point(747, 146);
            txtRemain.Name = "txtRemain";
            txtRemain.ReadOnly = true;
            txtRemain.Size = new Size(223, 40);
            txtRemain.TabIndex = 2;
            txtRemain.TabStop = false;
            // 
            // txtPayTotal
            // 
            txtPayTotal.BackColor = Color.WhiteSmoke;
            txtPayTotal.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPayTotal.Location = new Point(747, 225);
            txtPayTotal.Name = "txtPayTotal";
            txtPayTotal.ReadOnly = true;
            txtPayTotal.Size = new Size(223, 40);
            txtPayTotal.TabIndex = 2;
            txtPayTotal.TabStop = false;
            // 
            // lblUseShowError
            // 
            lblUseShowError.AutoSize = true;
            lblUseShowError.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUseShowError.ForeColor = Color.Red;
            lblUseShowError.Location = new Point(129, 102);
            lblUseShowError.Name = "lblUseShowError";
            lblUseShowError.Size = new Size(27, 33);
            lblUseShowError.TabIndex = 1;
            lblUseShowError.Text = "--";
            // 
            // lblPaidShowError
            // 
            lblPaidShowError.AutoSize = true;
            lblPaidShowError.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaidShowError.ForeColor = Color.Red;
            lblPaidShowError.Location = new Point(438, 268);
            lblPaidShowError.Name = "lblPaidShowError";
            lblPaidShowError.Size = new Size(27, 33);
            lblPaidShowError.TabIndex = 1;
            lblPaidShowError.Text = "--";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(12, 324);
            label11.Name = "label11";
            label11.Size = new Size(117, 33);
            label11.TabIndex = 1;
            label11.Text = "ប្រវត្តិប្រើប្រាស់";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(218, 324);
            label12.Name = "label12";
            label12.Size = new Size(105, 33);
            label12.TabIndex = 1;
            label12.Text = "របាយការណ៏";
            // 
            // txtHistory
            // 
            txtHistory.BackColor = Color.WhiteSmoke;
            txtHistory.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtHistory.Location = new Point(12, 363);
            txtHistory.Multiline = true;
            txtHistory.Name = "txtHistory";
            txtHistory.ReadOnly = true;
            txtHistory.ScrollBars = ScrollBars.Both;
            txtHistory.Size = new Size(200, 178);
            txtHistory.TabIndex = 3;
            txtHistory.TabStop = false;
            // 
            // txtReport
            // 
            txtReport.BackColor = Color.WhiteSmoke;
            txtReport.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtReport.Location = new Point(218, 363);
            txtReport.Multiline = true;
            txtReport.Name = "txtReport";
            txtReport.ReadOnly = true;
            txtReport.ScrollBars = ScrollBars.Vertical;
            txtReport.Size = new Size(752, 178);
            txtReport.TabIndex = 3;
            txtReport.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(371, 153);
            label5.Name = "label5";
            label5.Size = new Size(57, 33);
            label5.TabIndex = 1;
            label5.Text = "ថ្លៃបង់";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Khmer M1", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(431, 63);
            label13.Name = "label13";
            label13.Size = new Size(120, 38);
            label13.TabIndex = 1;
            label13.Text = "បង់ថ្លៃសេវា";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Transparent;
            btnCancel.Location = new Point(747, 288);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 41);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "បោះបង់";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Khmer OS Siemreap", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(876, 288);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 41);
            btnSave.TabIndex = 3;
            btnSave.Text = "រក្សាទុក";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AcceptButton = btnSave;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(982, 553);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtReport);
            Controls.Add(txtHistory);
            Controls.Add(txtPayTotal);
            Controls.Add(txtPaid);
            Controls.Add(txtTotal);
            Controls.Add(txtRemain);
            Controls.Add(txtPay);
            Controls.Add(txtUnit);
            Controls.Add(txtUse);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(lblPaidShowError);
            Controls.Add(lblUseShowError);
            Controls.Add(label13);
            Controls.Add(label5);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Khmer OS Siemreap", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtUse;
        private TextBox txtUnit;
        private TextBox txtTotal;
        private TextBox txtPay;
        private TextBox txtPaid;
        private TextBox txtRemain;
        private TextBox txtPayTotal;
        private Label lblUseShowError;
        private Label lblPaidShowError;
        private Label label11;
        private Label label12;
        private TextBox txtHistory;
        private TextBox txtReport;
        private Label label5;
        private Label label13;
        private Button btnCancel;
        private Button btnSave;
    }
}