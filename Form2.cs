using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WinFormsApp123
{
    public partial class Form2 : Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;





        public Form2()
        {
            InitializeComponent();

            button3.Show();
            button4.Show();
            button5.Show();

        }

        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM test";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetString(0), dr.GetString(1));
            }
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source = " + path))
                {
                    sqlite.Open();
                    string sql = "create table test(name varchar(20),id varchar(12),price varchar(12))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("Database cannot be created");
                return;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "INSERT INTO test(name,id,price) VALUES(@name,@id,@price)";

            string NAME = textBox1.Text;
            string ID = textBox2.Text;
            string PRICE = textBox3.Text;

            cmd.Parameters.AddWithValue("name", NAME);
            cmd.Parameters.AddWithValue("id", ID);
            cmd.Parameters.AddWithValue("price", PRICE);

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Id";
            dataGridView1.Columns[2].Name = "Price";
            string[] row = new string[] { NAME, ID, PRICE };
            dataGridView1.Rows.Add(row);

            cmd.ExecuteNonQuery();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Close();
            fm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Create_db();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            using (var cmd = new SQLiteCommand(con))
            {
                // First UPDATE command
                cmd.CommandText = "UPDATE test SET name=@Name WHERE id=@Id";
                cmd.Parameters.AddWithValue("@Id", textBox2.Text);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.ExecuteNonQuery();

                // Clear parameters for the next command
                cmd.Parameters.Clear();

                // Second UPDATE command
                cmd.CommandText = "UPDATE test SET price=@Price WHERE id=@Id";
                cmd.Parameters.AddWithValue("@Id", textBox2.Text);
                cmd.Parameters.AddWithValue("@Price", textBox3.Text);
                cmd.ExecuteNonQuery();
            }

            // Refresh the data grid
            dataGridView1.Rows.Clear();
            data_show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(con);
            cmd.CommandText = "DELETE FROM test where name = @Name";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            data_show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fm1 = new Form4();
            fm1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string getData(string itemName)
        {
            string result = string.Empty;

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                string query = "SELECT price FROM test WHERE name = @name";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", itemName);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = dr["price"].ToString();
                        }
                    }
                }
            }

            return result;
        }


    }
}
