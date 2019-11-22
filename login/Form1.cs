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

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            string sql = "select * from usuario where id = @id and nome = @nome";
            Conexao conectar = new Conexao();
            conectar.conectar();
            SqlCommand cmd = new SqlCommand(sql,conectar.con);
            cmd.Parameters.AddWithValue("@id",textBox1.Text);
            cmd.Parameters.AddWithValue("@nome",textBox2.Text);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("OK Usuario Existe");
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Usuario não Existe");

            }
        }
    }
}
