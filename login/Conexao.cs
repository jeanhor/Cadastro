using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
namespace login
{
  public class Conexao
    {
        public SqlConnection con = new SqlConnection();
    public void conectar ()
        {
            try
            {
                con.ConnectionString = @"Data Source=nome servidor Sql; Initial Catalog = nome do banco; Integrated Security = True";
                con.Open();
                MessageBox.Show("Conexao Bem Sucedida");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
        }
     public void desconectar()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
    
    }
}
