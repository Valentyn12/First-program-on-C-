using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Товар : Form
    {
        public Товар()
        {
            InitializeComponent();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Товар_Load(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = MyPublic.stringConnDB;
            conn.Open();
            

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

           
            cmd.CommandText = "SELECT * FROM Техніка Where ID=" +
            MyPublic.ID;
            
            
            SqlDataReader dr =
            cmd.ExecuteReader(CommandBehavior.CloseConnection);
            
            dr.Read();
            
            textBoxID.Text = dr[0].ToString();
            textBoxТовар.Text = dr[1].ToString();
            textBoxЦіна.Text = dr[2].ToString();
            textBoxЦіна_закупівлі.Text = dr[3].ToString();
            
            dr.Close();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = MyPublic.stringConnDB;
            conn.Open();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text; 
                                                
            cmd.CommandText = "UPDATE Техніка SET Товар = '" +
            textBoxТовар.Text + "'" +
            ", Ціна = " + textBoxЦіна.Text.Replace(",", ".") +
            ", Ціна_закупівлі = " + textBoxЦіна_закупівлі.Text.Replace(",",
            ".") +
            " WHERE ID=" + textBoxID.Text;
            
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Зміни збережені ", "Збережено");
            
            conn.Close();

        }
    }
}
