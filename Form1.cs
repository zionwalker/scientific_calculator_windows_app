namespace Scient_Calculator
{
    public partial class Calculator : Form
    {
        double enterFirstValue, enterSecondValue;
        string op;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void EnterNumbers(object sender, EventArgs e)
        {
                Button num = (Button)sender;
            if(txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".") 
                {
                    if (!txtResult.Text.Contains("."))

                        txtResult.Text = txtResult.Text + num.Text;
                
                }

                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }
    }
}
