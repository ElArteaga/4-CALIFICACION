namespace _4_CALIFICACION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double CAL1, CAL2, CAL3, CAL4;
            CAL1 = double.Parse(textBox1.Text);
            CAL2 = double.Parse(textBox2.Text);
            CAL3 = double.Parse(textBox3.Text);
            CAL4 = double.Parse(textBox4.Text);
            if (CAL1 >= 6.0) label6.Text = "APROBADO";
            if (CAL1 < 6.0) label6.Text = "REPROBADO";
            else
            if (CAL2 >= 6.0) label7.Text = "APROBADO";
            if (CAL2 < 6.0) label7.Text = "REPROBADO";
            else
            if (CAL3 >= 6.0) label8.Text = "APROBADO";
            if (CAL3 < 6.0) label8.Text = "REPROBADO";
            else 
            if (CAL4 >= 6.0) label9.Text = "APROBADO";
            if (CAL4 < 6.0) label9.Text = "REPROBADO";

        }
    }
}
