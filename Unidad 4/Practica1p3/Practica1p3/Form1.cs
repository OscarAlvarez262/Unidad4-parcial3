namespace Practica1p3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String u, p;

            u = txtUser.Text;
            p = txtPassword.Text;
            bool ban = false;

            if (u.Length == 0 || p.Length == 0)
            {
                MessageBox.Show("Error faltan datos", "Error");
            }
            else
            {
                if (File.Exists("Usuarios.csv"))
                {

                    StreamReader leer = File.OpenText("Usuarios.csv");
                    string dato = "";
                    do
                    {
                        dato = leer.ReadLine();
                        if (dato != null)
                        {
                            String[] d = dato.Split(",");
                            if (u.Equals(d[0]) && p.Equals(d[1]))
                            {
                                //MessageBox.Show("El usuario existe", "Correcto");
                                ban = true;
                                break;


                            }

                        }
                    } while (dato != null);
                    if (ban == false)
                    {
                        MessageBox.Show("El usuario no existe", "Error");
                        txtPassword.Clear();
                        txtUser.Clear();
                    }
                    else
                    {
                        leer.Close();
                        crud crd = new crud();
                        this.Hide();
                        crd.ShowDialog();
                        
                    }
                        
                }
                else
                {
                    MessageBox.Show("El archivo no existe");
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String u, p;
            bool exis=false;

            u = txtUser.Text;
            p = txtPassword.Text;

            StreamReader leer = File.OpenText("Usuarios.csv");
            string dato = "";
            do
            {
                dato = leer.ReadLine();
                if (dato != null)
                {
                    String[] d = dato.Split(",");
                    if (u.Equals(d[0]))
                    {

                        MessageBox.Show("Usuario existente", "Error usuario");
                        txtPassword.Clear();
                        txtUser.Clear();
                        leer.Close();
                        exis= true;
                        break;

                    }

                }
            } while (dato != null);
            leer.Close();
            if (exis) { }
            else {
                if (u.Length == 0 || p.Length == 0)
                {
                    MessageBox.Show("Error faltan datos", "Error");

                }
                else
                {

                    StreamWriter archivo = null;
                    archivo = File.AppendText("Usuarios.csv");
                    archivo.WriteLine(u + "," + p);
                    archivo.Close();
                    MessageBox.Show("El usuario se ha guardado", "Usuario");
                    txtPassword.Clear();
                    txtUser.Clear();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar == 08))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar == 08)||
                (e.KeyChar >= 48 && e.KeyChar <= 57))
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
