using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webbrowser1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactDetailsDataSet.ContactDetails' table. You can move, or remove it, as needed.
            this.contactDetailsTableAdapter.Fill(this.contactDetailsDataSet.ContactDetails);
            con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=ContactDetails;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = con;

        }
        private void cleardata()
        {
            tbName.Clear();
            tbStreet.Clear();
            tbCity.Clear();
            tbState.Clear();
            tbZip.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = $"INSERT INTO ContactDetails (Name, Street, City, State, Zip) " +
                               $"VALUES('{tbName.Text}', '{tbStreet.Text}', '{tbCity.Text}', '{tbState.Text}', '{tbZip.Text}')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cleardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void displaymydata()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ContactDetails";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataGrid.DataSource = dt;
            con.Close();
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            displaymydata();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string whereClauseCon( string filterOn , string filterVal)
        {
            
            string[] words = filterVal.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string whereClause = string.Join(" OR ", words.Select(word => $"{filterOn} LIKE '%{word}%'"));

            return whereClause;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string filterRemove = comboBox1.Text.ToString();
                string patternRemove = tbPattern.Text.Trim();
                string whereClause = whereClauseCon(filterOn: filterRemove, filterVal: patternRemove);
                string query = $"DELETE FROM ContactDetails WHERE {whereClause}";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cleardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string filterSearch = comboBox1.Text.ToString();
                string patternSearch = tbPattern.Text.Trim();

                if (string.IsNullOrEmpty(comboBox1.Text.ToString()) || string.IsNullOrEmpty(tbPattern.Text.Trim()))
                {
                    MessageBox.Show("Please select a filter option and/or enter a search term.");
                    return;
                }

                con.Open();



                string whereClause = whereClauseCon(filterOn: filterSearch, filterVal: patternSearch);

                string query = $"SELECT * FROM ContactDetails WHERE {whereClause}";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataGrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No matching records found.");
                    cleardata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
