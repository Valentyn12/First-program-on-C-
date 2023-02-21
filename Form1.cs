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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void buttonСтворитиБд_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = MyPublic.stringConnServer;
            conn.Open();
           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            
            cmd.CommandText = @"CREATE DATABASE ПобутоваТехніка On (NAME = ПобутоваТехніка_dat, " +
            @"Filename='C:\Users\valik\source\repos\lab1\ПобутоваТехнікаГладких.mdf')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Базу даних Побутова техніка створено", "База даних");
            conn.Close();

        }

        private void buttonВидалитиБд_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
           
            conn.ConnectionString = MyPublic.stringConnServer;
            conn.Open();

            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"DROP DATABASE ПобутоваТехніка";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Базу даних Побутова техніка видалено", "База даних");
            conn.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonДобавитиТовари_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = MyPublic.stringConnDB;
            conn.Open();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CREATE TABLE Техніка " +
            "(ID int IDENTITY (1,1) Primary Key, " +
            "Товар NVarChar(25) NOT NULL, " +
            "Ціна Money NOT NULL, " +
            "Ціна_закупівлі Money NOT NULL)";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Таблицю Техніка створено", "Таблиця Техніка");
            conn.Close();


        }

        private void buttonЗаповнитиТовари_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = MyPublic.stringConnDB;
            conn.Open();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"INSERT Техніка VALUES" +
            @"(N'Refrigerator ""SAMSUNG""',25000,20000), " +
            @"(N'Washing machine ""SAMSUNG""',18000,14000), " +
            @"(N'Vacuum cleaner ""BOSCH""',4700,3000)";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Дані додано ", "Таблиця Техніка");
            conn.Close();

        }

        private void buttonЗмінитиТовари_Click(object sender, EventArgs e)
        {
            formТехніка вікноТехніка = new formТехніка();
            вікноТехніка.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
