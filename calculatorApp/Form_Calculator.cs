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
            double dNum = double.Parse(Num_Label.Text);
            if (!double.TryParse(Num_Label.Text, out dNum)) return;
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
        private void zero_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = zero.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += zero.Text;
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = one.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += one.Text;
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = two.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += two.Text;
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = three.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += three.Text;
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = four.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += four.Text;
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = five.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += five.Text;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = six.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += six.Text;
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = seven.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += seven.Text;
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = eight.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += eight.Text;
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (Label_overwrite == true)
            {
                Num_Label.Text = nine.Text;
                Label_overwrite = false;
            }
            else
            {
                Num_Label.Text += nine.Text;
            }
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
            mType = MarksType.NON;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Calculate();
            mType = MarksType.PLUS;
            Label_overwrite = true;
        }

        private void mark_Click(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {
            Calculate();
            mType = MarksType.NON;
            Label_overwrite = true;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Calculate();
            mType = MarksType.MINUS;
            Label_overwrite = true;
        }

        private void multiplied_Click(object sender, EventArgs e)
        {
            Calculate();
            mType = MarksType.MULTIPLIED;
            Label_overwrite = true;
        }

        private void divided_Click(object sender, EventArgs e)
        {
            Calculate();
            mType = MarksType.DEVIDED;
            Label_overwrite = true;
        }

        private void persent_Click(object sender, EventArgs e)
        {
            Calculate();
            mType = MarksType.PERSENT;
            Label_overwrite = true;
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if(Num_Label.Text.Contains("-"))
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
