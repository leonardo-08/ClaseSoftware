namespace EjemploDeMetodos
{
    public partial class nmTXT : Form
    {
        public nmTXT()
        {
            InitializeComponent();
        }

      
        private void BTN_Click(object sender, EventArgs e) 
        {

            calcular();
      


        }


        private void calcular()
        {


            string nombres;
            nombres = textBox1.Text +" y "+ textBox2.Text;
            label1.Text = nombres;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular();
        }
    }
}