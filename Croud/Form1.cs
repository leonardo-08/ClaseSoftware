namespace Croud
{
    public partial class Form1 : Form
    {
        private bool Adding = false;
   
        List<Contacto> contactoList = new List<Contacto>();
        public Form1()
        {
            InitializeComponent();
        }
   
        public class Contacto
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Numero { get; set; }
            public string Correo { get; set; }
            public string Direccion { get; set; }
          

        }
        private void SvBtn_Click(object sender, EventArgs e)
        {
       
            EnableControls(true);
            guardar();
            BorrarControles();


        }

       

        private void BorrarControles()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            richTextBox1.Text = String.Empty;
        }

        private void EnableControls(bool enabled)
        {
            textBox1.Enabled = enabled;
            textBox2.Enabled = enabled;
            textBox3.Enabled = enabled;
            textBox4.Enabled = enabled;
            richTextBox1.Enabled = enabled;
        }

       

        private void guardar()
        {
            if  (Adding = true)
            {
                var contacto = new Contacto
                {
                    Nombre = textBox1.Text,
                    Apellido = textBox2.Text,
                    Numero = textBox3.Text,
                    Correo = textBox4.Text,
                    Direccion = richTextBox1.Text,
                 

                 };
              
                contactoList.Add(contacto);

                MessageBox.Show("Contacto Registrado en la base de datos.");

                BorrarControles();
            

               SvBtn.Enabled = true;
                DeleteBtn.Enabled = true;
                BtnEditar.Enabled = true;
                recargar();
            }

        }



        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                contactoList.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }


            recargar();
        }

        private void recargar()
        {
           
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contactoList;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["Numero"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                richTextBox1.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();


            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
            contactoList.RemoveAt(0);
        }
    }
}