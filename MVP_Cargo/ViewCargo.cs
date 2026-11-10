using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVP_Cargo
{
    public partial class ViewCargo : Form, ICargoView
    {
        private CargoPresenter presenter;

        private TextBox textBox1, textBox2, textBox3, textBox4;
        private Label label1, label2, label3, label4, labelResult;
        private Button button1;

        public ViewCargo()
        {
            InitInterface();

             presenter = new CargoPresenter(this, new CargoTransport());
        }

        private void InitInterface()
        {
            this.Text = "MVP — Міжміські перевезення вантажу";
            this.Width = 450;
            this.Height = 330;
            this.StartPosition = FormStartPosition.CenterScreen;

            label1 = new Label() { Text = "Вага вантажу (кг):", Left = 20, Top = 20, Width = 160 };
            textBox1 = new TextBox() { Left = 200, Top = 20, Width = 200, Text = "10" };

            label2 = new Label() { Text = "Тариф за кг (грн):", Left = 20, Top = 60, Width = 160 };
            textBox2 = new TextBox() { Left = 200, Top = 60, Width = 200, Text = "5" };

            label3 = new Label() { Text = "Відстань (км):", Left = 20, Top = 100, Width = 160 };
            textBox3 = new TextBox() { Left = 200, Top = 100, Width = 200, Text = "100" };

            label4 = new Label() { Text = "Тариф за км (грн):", Left = 20, Top = 140, Width = 160 };
            textBox4 = new TextBox() { Left = 200, Top = 140, Width = 200, Text = "2" };

            button1 = new Button() { Text = "Розрахунок", Left = 20, Top = 180, Width = 380, Height = 35 };
            button1.Click += new EventHandler(button1_Click);

            labelResult = new Label() { Text = "Результат = ", Left = 20, Top = 230, Width = 380, Font = new Font("Arial", 11, FontStyle.Bold) };

            this.Controls.Add(label1);
            this.Controls.Add(textBox1);
            this.Controls.Add(label2);
            this.Controls.Add(textBox2);
            this.Controls.Add(label3);
            this.Controls.Add(textBox3);
            this.Controls.Add(label4);
            this.Controls.Add(textBox4);
            this.Controls.Add(button1);
            this.Controls.Add(labelResult);
        }

        public void SetCost(double cost)
        {
            labelResult.Text = "Результат = " + cost.ToString() + " грн";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double w = Convert.ToDouble(textBox1.Text);
                double tk = Convert.ToDouble(textBox2.Text);
                double d = Convert.ToDouble(textBox3.Text);
                double tkm = Convert.ToDouble(textBox4.Text);

                presenter.LoadCargo(w, tk, d, tkm);
            }
            catch
            {
                MessageBox.Show("Помилка введення даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}