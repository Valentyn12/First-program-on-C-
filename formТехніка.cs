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
    public partial class formТехніка : Form
    {
        public formТехніка()
        {
            InitializeComponent();
        }

        private void formТехніка_Load(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = MyPublic.stringConnDB;
            conn.Open();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            
            cmd.CommandText = "SELECT * FROM Техніка";
            
            SqlDataReader dr = cmd.ExecuteReader();
            
            int i; 
            int[] len = new int[4] { 5, 25, 12, 12 }; 

            
            while (dr.Read())
            {
                string stringList = "";
                for (i = 0; i < dr.FieldCount; i++)
                {
                    stringList += dr[i].ToString().PadRight(len[i]);
                }
                listBoxТовари.Items.Add(stringList);
            }
            dr.Close();

            cmd.CommandText = "SELECT AVG(Ціна) FROM Техніка";
            
            textBoxСередня_ціна.Text = cmd.ExecuteScalar().ToString();
            
            conn.Close();

        }

        private void listBoxТовари_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxСередня_ціна_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonЗмінити_Click(object sender, EventArgs e)
        {
   
            if (listBoxТовари.SelectedItem != null) 
            {
                MyPublic.ID =
                listBoxТовари.SelectedItem.ToString().Substring(0, 3).Trim();

                Товар вікноТовар = new Товар();
                вікноТовар.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Виберіть товар", "Зміни",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}
