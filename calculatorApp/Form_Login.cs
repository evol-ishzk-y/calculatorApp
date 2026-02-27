using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace calculatorApp
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            if (db.CheckLogin(userTextBox.Text, passTextBox.Text))
            {
                MessageBox.Show("ログイン成功！");

                Form_Calculator calc = new Form_Calculator(userTextBox.Text);
                calc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ログインに失敗しました");
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
