using System.Diagnostics.Eventing.Reader;

namespace calculatorApp
{
    public partial class Form_Calculator : Form
    {
        private bool Label_overwrite = true;
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
    }
}
