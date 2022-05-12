using MySql.Data.MySqlClient;
using System.Data;

namespace CRUD
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        DataTable dt = new DataTable();
        string sql;
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        DataSet ds = new DataSet();
        String server = "localhost";
        String username = "root";
        String password = "";
        String database = "testbox_db";

        public Form1()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Box box = new Box(textPO.Text.Trim(), textPN.Text.Trim(), textSN.Text.Trim(), textTN.Text.Trim(),textTU.Text.Trim());
            DbBox.AddBox(box);
            CLear();
        }
        public void CLear()
        {
            textPO.Text = textPN.Text = textSN.Text = textTN.Text = textTU.Text = String.Empty;
        }

        public void Display()
        {
            DbBox.DispalyandSearch("SELECT ID, ProductOrder, PartNumber, SerialNumber, TrayNumber, TrayUnit", dataGridView1);
        }
        private void frmboxList_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
