using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; // Or use Microsoft.Data.Sqlite for the other package.
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;


namespace WinFormsApp123
{
    // Connection string for SQLite


    public partial class Form4 : Form
    {
        Form2 fn = new Form2();
        String query;
        protected int n, grandTotal = 0;

        public Form4()
        {
            InitializeComponent();


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void find_price(object sender, EventArgs e)
        {
            String text = textBox2.Text;
            string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";  // Ensure cs is declared here if not passed from another form.

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string query = "SELECT price FROM test WHERE name = @name";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", text);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            label4.Text = dr["price"].ToString();
                            label4.Show();
                        }
                        else
                        {
                            label4.Text = "Item not found";
                            label4.Show();
                        }
                    }
                }
            }
        }




        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            find_price(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)

        {
            int quan = int.Parse(textBox1.Text);
            int price = int.Parse(label4.Text);

            label7.Text = (quan * price).ToString();
            n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBox2.Text;
            dataGridView1.Rows[n].Cells[1].Value = label4.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBox1.Text;
            dataGridView1.Rows[n].Cells[3].Value = label7.Text;

            grandTotal = grandTotal + int.Parse(label7.Text);
            label8.Text = "Net Bill Rs." + grandTotal;
            textBox2.Clear();
            textBox1.Clear();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {





        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SaveBillAsPdf()
        {
            // Create a new document
            Document doc = new Document(PageSize.A4);

            // Specify the file path to save the PDF
            string filePath = @"C:\Users\Upeka Nanayakkara\Videos\bill.pdf"; // Specify the file name (e.g., "bill.pdf")


            // Create a FileStream to write the PDF
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                // Create a PdfWriter instance
                PdfWriter.GetInstance(doc, fs);

                // Open the document for writing
                doc.Open();

                // Add some title text to the PDF
                doc.Add(new Paragraph("Cafe Bill"));
                
                doc.Add(new Chunk("\n"));

                // Add table to display items in the bill
                PdfPTable table = new PdfPTable(4); // 4 columns (Item Name, Price, Quantity, Total)

                // Set column widths
                table.SetWidths(new float[] { 3f, 2f, 2f, 3f });

                // Add table header row
                table.AddCell("Item Name");
                table.AddCell("Price");
                table.AddCell("Quantity");
                table.AddCell("Total");

                // Loop through the DataGridView rows and add them to the table
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null) // Ensure row is not empty
                    {
                        table.AddCell(row.Cells[0].Value.ToString()); // Item Name
                        table.AddCell(row.Cells[1].Value.ToString()); // Price
                        table.AddCell(row.Cells[2].Value.ToString()); // Quantity
                        table.AddCell(row.Cells[3].Value.ToString()); // Total
                    }
                }

                // Add the table to the document
                doc.Add(table);

                // Add the grand total
                doc.Add(new Chunk("\n"));
                doc.Add(new Paragraph("Grand Total: Rs. " + grandTotal.ToString()));

                // Close the document
                doc.Close();
            }

            // Inform the user that the bill has been saved
            MessageBox.Show("Bill saved to: " + filePath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveBillAsPdf();
        }
    }


}

