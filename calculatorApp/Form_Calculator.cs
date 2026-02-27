using System;
using System.Diagnostics.Eventing.Reader;

namespace calculatorApp
{
    public partial class Form_Calculator : Form
    {
        private string loginName;
        private bool Label_overwrite = true;
        private bool Dot_Label = false;
        private double dNum_Pool = 0;
        private enum MarksType
        {
            NON,        // ‚È‚µ
            PLUS,       // {
            MINUS,      // |
            MULTIPLIED, // ~
            DEVIDED,     // €
            PERSENT
        }
        private MarksType mType = MarksType.NON;

        private void Calculate()
        {
            if (!double.TryParse(Num_Label.Text, out double dNum)) return;
            switch (mType)
            {
                case MarksType.NON:
                    dNum_Pool = dNum;
                    break;
                case MarksType.PLUS:
                    dNum_Pool += dNum;
                    break;
                case MarksType.MINUS:
                    dNum_Pool -= dNum;
                    break;
                case MarksType.MULTIPLIED:
                    dNum_Pool *= dNum;
                    break;
                case MarksType.DEVIDED:
                    if (dNum == 0)
                    {
                        MessageBox.Show("0‚ÅŠ„‚é‚±‚Æ‚Ío—ˆ‚Ü‚¹‚ñ");
                        all_clear_Click(null, null);
                        return;
                    }
                    dNum_Pool /= dNum;
                    break;
                case MarksType.PERSENT:
                    dNum_Pool = dNum * 0.01;
                    break;
            }
            Num_Label.Text = dNum_Pool.ToString();
        }

        public Form_Calculator(string name)
        {
            InitializeComponent();
            loginName = name;
            this.Text = "‚æ‚¤‚±‚»" + loginName + "‚³‚ñ";
        }

        //0`9‚ðƒNƒŠƒbƒN‚µ‚ÄNum_Label‚É“ü‚ê‚é
        private void numButton_Click(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;

            string buttonText = ClickedButton.Text;

            if (Label_overwrite == true)
            {
                if (buttonText == "0") return;

                Num_Label.Text = buttonText;
                Label_overwrite = false;
            }
            else
            {
                if (buttonText == "0" && Num_Label.Text == "0") return;

                Num_Label.Text += buttonText;
            }
        }

        private void optionButton_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == false)
            {
                Calculate();
            }
            Button ClickedButton = (Button)sender;
            string option = ClickedButton.Text;
            Mark_Label.Text = option;

            switch (option)
            {
                case "+":
                    mType = MarksType.PLUS;
                    break;
                case "-":
                    mType = MarksType.MINUS;
                    break;
                case "~":
                    mType = MarksType.MULTIPLIED;
                    break;
                case "€":
                    mType = MarksType.DEVIDED;
                    break;
                case "%":
                    mType = MarksType.PERSENT;
                    Calculate();
                    mType = MarksType.NON;
                    break;
            }
            Label_overwrite = true;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = "0.";
                Label_overwrite = false;
                return;
            }

            if (Num_Label.Text.Contains(dot.Text))
            {
                return;
            }
            else
            {
                Num_Label.Text += dot.Text;
            }

        }

        private void all_clear_Click(object sender, EventArgs e)
        {
            Num_Label.Text = "0";
            Label_overwrite = true;
            Dot_Label = false;

            //”Žš‚Ì“ü‚Á‚½•Ï”‚ðíœ‚·‚é
            dNum_Pool = 0;
            Mark_Label.Text = "";
            mType = MarksType.NON;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            string formula = dNum_Pool.ToString() + " " + Mark_Label.Text + " " + Num_Label.Text;
            Calculate();
            mType = MarksType.NON;
            Label_overwrite = true;
            Mark_Label.Text = "=";

            string result = Num_Label.Text;

            try
            {
                DatabaseHelper db = new DatabaseHelper();
                db.SaveHistory(this.loginName, formula, result);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("—š—ð‚Ì•Û‘¶‚ÉŽ¸”s‚µ‚Ü‚µ‚½" + ex.Message);
            }
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if (Num_Label.Text.Contains("-"))
            {
                Num_Label.Text = Num_Label.Text.Replace("-", "");
            }
            else
            {
                Num_Label.Text = "-" + Num_Label.Text;
            }
        }

        private void Form_Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                equal_Click(null, null);
            }

        }

        private void backSpace_Click(object sender, EventArgs e)
        {
            int length = Num_Label.Text.Length;

            if (length > 1)
            {
                Num_Label.Text = Num_Label.Text.Substring(0, length - 1);

                if (Num_Label.Text == "-")
                {
                    Num_Label.Text = "0";
                    Label_overwrite = true;
                }
            }
            else
            {
                Num_Label.Text = "0";
                Label_overwrite = true;
            }
        }
        //“Á‚ÉŽg—p‚È‚µ
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Num_Label_Click(object sender, EventArgs e)
        {

        }

    }
}
