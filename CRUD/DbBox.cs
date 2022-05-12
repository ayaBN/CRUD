using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    internal class DbBox
    {
        public static MySqlConnection GetConnection()
        {
            String sql = "datasource = localhost;port = 3306;username = root;password =;database= testbox_db";
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection();
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySqlConnection ! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddBox(Box box)
        {
            String sql = "INSERT INTO boxdb values (NULL, @ProductOrder,@PartNumber,@SerialNumber,@TrayNumber,@TrayUnit)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductOrder", MySqlDbType.VarChar).Value = box.ProductOrder;
            cmd.Parameters.Add("@PartNumber", MySqlDbType.VarChar).Value = box.PartNumber;
            cmd.Parameters.Add("@SerialNumber", MySqlDbType.VarChar).Value = box.SerialNumber;
            cmd.Parameters.Add("@TrayNumber", MySqlDbType.VarChar).Value = box.TrayNumber;
            cmd.Parameters.Add("@TrayUnit", MySqlDbType.VarChar).Value = box.TrayUnit;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully ! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Box not inserted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }

        public static void UpdateBox(Box box)
        {
            String sql = "UPDATE  boxdb set ProductOrder= @ProductOrder,PartNumber= @PartNumber,SerialNumber= @SerialNumber," +
                "TrayNumber= @TrayNumber,TrayUnit= @TrayUnit)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductOrder", MySqlDbType.VarChar).Value = box.ProductOrder;
            cmd.Parameters.Add("@PartNumber", MySqlDbType.VarChar).Value = box.PartNumber;
            cmd.Parameters.Add("@SerialNumber", MySqlDbType.VarChar).Value = box.SerialNumber;
            cmd.Parameters.Add("@TrayNumber", MySqlDbType.VarChar).Value = box.TrayNumber;
            cmd.Parameters.Add("@TrayUnit", MySqlDbType.VarChar).Value = box.TrayUnit;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully ! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Box not updated! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();





        }

        public static void DeleteBox(int id)
        {
            String sql = "DELETE FROM boxdb WHERE ID= @BOX_ID)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@BOX_ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully ! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Box not deleted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }

        public static void DispalyandSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            conn.Close();

        }

    }
}
