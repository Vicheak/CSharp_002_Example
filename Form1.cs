using System.Globalization;

namespace _006_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[,] history;
        private string[,] report;
        private int count;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUse.Focus();
            lblUseShowError.Text = string.Empty;
            lblPaidShowError.Text = string.Empty;

            this.history = new string[100, 2];
            history[count, 0] = "ល.រ";
            history[count, 1] = "ចំនួនប្រើ";

            this.report = new string[100, 6];
            report[count, 0] = "ល.រ";
            report[count, 1] = "ចំនួនប្រើ";
            report[count, 2] = "ថ្លៃឯកតា";
            report[count, 3] = "ថ្លៃសរុប\t";
            report[count, 4] = "បានបង់\t";
            report[count, 5] = "ជំពាក់";

            count++;

            ShowTableData(this.history, txtHistory);
            ShowTableData(this.report, txtReport);
        }

        private void ShowTableData(string[,] array_data, TextBox textBox)
        {
            string text = "";
            for (int i = 0; i < this.count; i++)
            {
                for (int j = 0; j < array_data.GetLength(1); j++)
                {
                    text += array_data[i, j];
                    if (j < array_data.GetLength(1) - 1)
                        text += "\t";
                }
                text += "\r\n";
            }
            textBox.Text = text;
        }

        private void txtUse_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblUseShowError.Text = "";
                if (string.IsNullOrWhiteSpace(txtUse.Text))
                {
                    lblUseShowError.Text = "សូមបញ្ខូលជាលេខឡាតាំង";
                    return;
                }
                double useAmount = Convert.ToDouble(txtUse.Text);
                if (useAmount < 0)
                {
                    lblUseShowError.Text = "សូមបញ្ខូលតម្លៃវិជ្ជមាន";
                    return;
                }
                double unitPrice = 0;

                if (useAmount > 500) unitPrice = 1500;
                else if (useAmount > 200) unitPrice = 1000;
                else if (useAmount > 50) unitPrice = 700;
                else if (useAmount > 10) unitPrice = 500;
                else unitPrice = 300;

                double total = useAmount * unitPrice;

                txtUnit.Text = unitPrice.ToString("#,##0.00៛");
                txtTotal.Text = total.ToString("#,##0.00៛");
                txtPay.Text = total.ToString();
            }
            catch (Exception ex)
            {
                lblUseShowError.Text = "សូមបញ្ខូលជាលេខឡាតាំង";
            }
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblPaidShowError.Text = "";
                if (string.IsNullOrWhiteSpace(txtUse.Text) || string.IsNullOrWhiteSpace(txtPay.Text))
                {
                    lblPaidShowError.Text = "សូមបញ្ខូលចំនួនប្រើប្រាស់";
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPaid.Text))
                {
                    lblPaidShowError.Text = "សូមបញ្ខូលជាលេខឡាតាំង";
                    return;
                }
                double paid = Convert.ToDouble(txtPaid.Text);
                double pay = Convert.ToDouble(txtPay.Text);

                if (paid < 100 || paid > pay)
                {
                    lblPaidShowError.Text = "ចំនួនទឹកប្រាក់មិនត្រឹមត្រូវ";
                    return;
                }
                double remain = pay - paid;

                txtRemain.Text = remain.ToString("#,##0.00៛");
                txtPayTotal.Text = paid.ToString("#,##0.00៛");
            }
            catch (Exception ex)
            {
                lblPaidShowError.Text = "សូមបញ្ខូលជាលេខឡាតាំង";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            txtUse.Text = "";
            txtUnit.Text = "";
            txtTotal.Text = "";
            txtPay.Text = "";
            txtPaid.Text = "";
            txtRemain.Text = "";
            txtPayTotal.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUse.Text.Trim()) || string.IsNullOrWhiteSpace(txtPaid.Text.Trim()))
            {
                MessageBox.Show("Please enter the information!", "Error");
                return;
            }

            history[count, 0] = count.ToString("00#");
            history[count, 1] = txtUse.Text + "KWH";

            report[count, 0] = history[count, 0];
            report[count, 1] = history[count, 1];
            report[count, 2] = txtUnit.Text;
            report[count, 3] = txtTotal.Text;
            report[count, 4] = string.Format(new CultureInfo("km-KH"), "{0:C}", Convert.ToDouble(txtPaid.Text.Trim()));
            report[count, 5] = txtRemain.Text;

            count++;

            ShowTableData(history, txtHistory);
            ShowTableData(report, txtReport);
        }
    }
}