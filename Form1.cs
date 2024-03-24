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
            this.Width = 360;
            txtResult.Width = 318;

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
            if (txtResult.Text == "0")
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

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);

            switch (op)
            {
                case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();

                    break;

                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();

                    break;

                case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();

                    break;

                case "/":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();

                    break;

                case "Mod":
                    txtResult.Text = (enterFirstValue % enterSecondValue).ToString();

                    break;

                case "Exp":

                    double i = Convert.ToDouble(txtResult.Text);
                    double j;
                    j = enterSecondValue;
                    txtResult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();

                    break;

                default:

                    break;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            string f, s;

            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);

            txtResult.Text = Convert.ToString(-1 * q);

        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 360;
            txtResult.Width = 318;

        }

        private void scientficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 705;
            txtResult.Width = 664;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;

            exitCal = MessageBox.Show("confirm if you want to exis ", "Scientific Calculator",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {

            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Sqrt(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double x;

            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);

            txtResult.Text = Convert.ToString(x);

        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            double x, q, p, m;

            q = Convert.ToDouble(txtResult.Text);
            p = Convert.ToDouble(txtResult.Text);
            m = Convert.ToDouble(txtResult.Text);

            x = (q * p * m);

            txtResult.Text = Convert.ToString(x);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtResult.Text);
            sh = Math.Sinh(sh);
            txtResult.Text = Convert.ToString(sh);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {

            double ch = Convert.ToDouble(txtResult.Text);
            ch = Math.Cosh(ch);
            txtResult.Text = Convert.ToString(ch);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {

            double th = Convert.ToDouble(txtResult.Text);
            th = Math.Tanh(th);
            txtResult.Text = Convert.ToString(th);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {

            double tan = Convert.ToDouble(txtResult.Text);
            tan = Math.Tan(tan);
            txtResult.Text = Convert.ToString(tan);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {

            double cos = Convert.ToDouble(txtResult.Text);
            cos = Math.Cos(cos);
            txtResult.Text = Convert.ToString(cos);
        }

        private void btnSin_Click_1(object sender, EventArgs e)
        {

            double sin = Convert.ToDouble(txtResult.Text);
            sin = Math.Sin(sin);
            txtResult.Text = Convert.ToString(sin);
        }
    }
}

