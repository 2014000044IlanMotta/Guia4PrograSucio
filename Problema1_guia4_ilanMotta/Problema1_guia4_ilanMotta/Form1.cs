namespace Problema1_guia4_ilanMotta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "_ / _ / _";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Dia = int.Parse(textBox1.Text);
            int Mes = int.Parse(textBox2.Text);
            int Año = int.Parse(textBox3.Text);
            String mes1 = "";
            switch (Mes){ 
                case 1:
                    mes1="Enero";
                    label4.Text = Dia + " de " + mes1 + " de " + Año;
                    break;
                case 2:
                    mes1 = "Febreo";
                    label4.Text = Dia + " de " + mes1 + " de " + Año;
                    break;
                case 3:
                    mes1 = "Marzo";
                    label4.Text = Dia + " de " + mes1 + " de " + Año;
                    break;
                case 4:
                    mes1 = "Abril";
                    label4.Text = Dia + " de " + mes1 + " de " + Año;
                    break;
                case 5:
                    mes1 = "Mayo";
                    label4.Text = Dia + " de " + mes1 + " de " + Año;
                    break;
                case 6:
                    mes1 = "Junio";
                    label4.Text = Dia + " de " + mes1 + " de " + Año;
                    break;
                case 7:
                    mes1 = "Julio";
                    label4.Text = Dia + " de " + mes1 + " de " + Año;
                    break;
                case 8:
                    mes1 = "Agosto";
                    label4.Text = Dia + " de " + mes1 + " de " + Año;
                    break;
                case 9:
                    mes1 = "Septiembre";
                    label4.Text = Dia + " de " + mes1 + " de " + Año;
                    break;
                case 10:
                    mes1 = "Octubre";
                    label4.Text = Dia + " de " + mes1 + " de " + Año;
                    break;
                case 11:
                    mes1 = "Noviembre";
                    label4.Text = Dia + " de " + mes1 + " de " + Año;
                    break;
                case 12:
                    mes1 = "Diciembre";
                    label4.Text = Dia + " de " + mes1 + " de " + Año;
                    break;
                default:
                    textBox2.Text="Ingrese un mes correcto";
                    label4.Text = "_ / _ / _";


                    break;


                    
            }
            
        }
    }
}
