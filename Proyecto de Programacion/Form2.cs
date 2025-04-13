using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;

namespace Proyecto_de_Programacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Insertar_al_SQL_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Jetty Polanco\\source\\repos\\Proyecto de Programacion\\Proyecto de Programacion\\Database1.mdf\";Integrated Security=True");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "InsertTabla1";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nombre_del_libro", textBoxNombre_libro.Text);
            cmd.Parameters.AddWithValue("@Autor", textBoxAutor.Text);
            cmd.Parameters.AddWithValue("@Genero", textBoxGenero.Text);
            cmd.Parameters.AddWithValue("@Fecha_de_Guardado", textBoxFecha_guardado.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
