using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica1p3
{
    public partial class crud : Form
    {
        int _id = -1, _columna = -1;
        string _usuario = "";

        public crud()
        {
            InitializeComponent();
            precargarDatos();
        }
        private void precargarDatos()

        {
            dataUsuarios.Rows.Clear();
            int c = 0;
            if (File.Exists("Usuarios.csv"))
            {

                StreamReader leer = File.OpenText("Usuarios.csv");
                string dato = "";
                do
                {
                    dato = leer.ReadLine();
                    if (dato != null)
                    {
                        string[] d = dato.Split(",");
                        c++;
                        dataUsuarios.Rows.Add(c.ToString(), d[0], d[1]);
                    }
                } while (dato != null);

                leer.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExitC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataUsuarios_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = e.RowIndex;
            _columna = e.ColumnIndex;

            if (_id != -1)
            {
                string i = dataUsuarios.Rows[_id].Cells[0].Value.ToString();
                string u = dataUsuarios.Rows[_id].Cells[1].Value.ToString();
                string p = dataUsuarios.Rows[_id].Cells[2].Value.ToString();
                _usuario = u;
                txtPasswordC.Text = p;
                txtUserC.Text = u;
                btnDeleteC.Enabled = true;
                btnActivarC.Enabled = true;

            }

        }

        private void btnActivarC_Click(object sender, EventArgs e)
        {
            txtPasswordC.Enabled = true;
            txtUserC.Enabled = true;
            btnDeleteC.Enabled = false;
            btnActivarC.Visible = false;
            btnModifyC.Visible = true;
        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            if (_id != -1)
            {
                dataUsuarios.Rows.RemoveAt(_id);
                btnActivarC.Enabled = false;
                btnDeleteC.Enabled = false;
                txtUserC.Clear();
                txtPasswordC.Clear();
                _id = -1;
                eliminarArchivo();
            }
        }

        private void eliminarArchivo()
        {
            string usuarioC = txtUserC.Text;
            StreamReader streamreader = File.OpenText("Usuarios.csv");
            StreamWriter aux = File.AppendText("Tem.csv");
            string datos = "";
            do
            {
                datos = streamreader.ReadLine();
                if (datos != null)
                {
                    string[] d = datos.Split(",");
                    if (usuarioC.Equals(d[0]))
                    {

                    }
                    else
                    {
                        aux.WriteLine(datos);
                    }
                }
            } while (datos != null);

            streamreader.Close();
            aux.Close();
            File.Delete("Usuarios.csv");
            File.Move("Tem.csv", "Usuarios.csv");
            MessageBox.Show("Usuario eliminado", "Usuario eliminado");


        }

        private void btnModifyC_Click(object sender, EventArgs e)
        {
            if (_id != -1)
            {
                ModificarUsuario();
                precargarDatos();
                txtPasswordC.Clear();
                txtUserC.Clear();
                btnDeleteC.Enabled = false;
                btnModifyC.Visible= false;
                btnActivarC.Visible = true;
                btnActivarC.Enabled = false;
                txtUserC.Enabled = false;
                txtPasswordC.Enabled = false;

            }

        }
        private void ModificarUsuario()
        {
            string usuarioE = txtUserC.Text;
            string PasswordE= txtPasswordC.Text;
            StreamReader streamreader = File.OpenText("Usuarios.csv");
            StreamWriter aux = File.AppendText("Tem.csv");
            string datos = "";
            do
            {
                datos = streamreader.ReadLine();
                if (datos != null)
                {
                    string[] d = datos.Split(",");
                    if (_usuario.Equals(d[0]))
                    {
                        aux.WriteLine(usuarioE+","+PasswordE);
                    }
                    else
                    {
                        aux.WriteLine(datos);
                    }
                }
            } while (datos != null);

            streamreader.Close();
            aux.Close();
            File.Delete("Usuarios.csv");
            File.Move("Tem.csv", "Usuarios.csv");
            MessageBox.Show("El usuario fue modificado", "Usuario modificado");
        }
    }
}
