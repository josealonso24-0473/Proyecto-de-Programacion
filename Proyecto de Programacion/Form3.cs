using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Proyecto_de_Programacion
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Jetty Polanco\\source\\repos\\Proyecto de Programacion\\Proyecto de Programacion\\Database1.mdf\";Integrated Security=True");

        private void LoadTabla1()
        {
            con.Open();
            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Tabla1", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Tabla1");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tabla1";
            con.Close();
        }

       
        

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadTabla1();
        }
    }
}
