using System.Diagnostics.Eventing.Reader;

namespace calculatorApp
{
    public partial class Form_Calculator : Form
    {
        private bool Label_overwrite = true;
        private bool Dot_Label = false;
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
            if(Label_overwrite == true)
            {
                Num_Label.Text = zero.Text;
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
    }
}
