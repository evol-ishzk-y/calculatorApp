using System;
using System.Diagnostics.Eventing.Reader;

namespace calculatorApp
{
    public partial class Form_Calculator : Form
    {
        private bool Label_overwrite = true;
        private bool Dot_Label = false;
        private double dNum_Pool = 0;
        private enum MarksType
        {
            NON,        // Ç»Çµ
            PLUS,       // Å{
            MINUS,      // Å|
            MULTIPLIED, // Å~
            DEVIDED,     // ÅÄ
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
                        MessageBox.Show("0Ç≈äÑÇÈÇ±Ç∆ÇÕèoóàÇ‹ÇπÇÒ");
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

        public Form_Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Num_Label_Click(object sender, EventArgs e)
        {

        }

        //0Å`9ÇÉNÉäÉbÉNÇµÇƒNum_LabelÇ…ì¸ÇÍÇÈ
        private void numButton_Click(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;

            string buttonText = ClickedButton.Text;

            if (Label_overwrite == true)
            {
                Num_Label.Text = buttonText;
                Label_overwrite = false;
            }
            else
            {
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
                case "Å~":
                    mType = MarksType.MULTIPLIED;
                    break;
                case "ÅÄ":
                    mType = MarksType.DEVIDED;
                    break;
                case "%":
                    mType = MarksType.PERSENT;
                    break;
            }
            Label_overwrite = true;
        }



        private void dot_Click(object sender, EventArgs e)
        {
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

            //êîéöÇÃì¸Ç¡ÇΩïœêîÇçÌèúÇ∑ÇÈ
            dNum_Pool = 0;
            Mark_Label.Text = "=";
            mType = MarksType.NON;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Calculate();
            mType = MarksType.NON;
            Label_overwrite = true;
            Mark_Label.Text = "=";
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
    }
}
