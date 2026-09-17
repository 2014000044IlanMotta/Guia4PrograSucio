namespace Problema2_IlanMotta
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String n = "";

            String Text = textBox2.Text;
            if (Text == "Gerente")
            {
                textBox3.Text = n+"= 5000.00";

            }else if (Text == "Administrado")
            {
                textBox3.Text = n+"= 4500.00";
            }
            else if (Text == "Secretaria")
            {
                textBox3.Text = n+"=3500.00";
            }
            else if (Text =="Contador")
            {
                textBox3.Text =n+"=4000.00";
            }
            else
            {
                textBox3.Text = "Seleccines in cargo correcro";
            }

        }
    }
}
