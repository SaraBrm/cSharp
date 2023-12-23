using System.Data;
using System.Data.SqlClient;

namespace ContactManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Read();
        }

        public void Read()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=.; Initial Catalog=PhoneBookDB; User Id=sa; Password=123"))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Info", connection);
                DataSet ds = new DataSet();
                da.Fill(ds, "Info");
                dataGridView1.DataBindings.Clear();
                //dataGridView1.DataBindings.Add("datasource", ds, "Info");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Info";
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.; Initial Catalog=PhoneBookDB; User Id=sa; Password=123");
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Info values(@name,@family,@mobile,@phone)", connection);
                command.Parameters.AddWithValue("name", txtName.Text);
                command.Parameters.AddWithValue("family", txtFamily.Text);
                command.Parameters.AddWithValue("mobile", txtMobile.Text);
                command.Parameters.AddWithValue("phone", txtPhone.Text);
                command.ExecuteNonQuery();
                Read();
            }
            catch (Exception ex)
            {
                // ... create log
            }
            finally
            {
                connection.Close();
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFamily.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMobile.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.; Initial Catalog=PhoneBookDB; User Id=sa; Password=123");
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update Info set Name=@name,Family=@family, Mobile=@mobile, Phone=@phone where Id=@id", connection);
                command.Parameters.AddWithValue("id", txtId.Text);
                command.Parameters.AddWithValue("name", txtName.Text);
                command.Parameters.AddWithValue("family", txtFamily.Text);
                command.Parameters.AddWithValue("mobile", txtMobile.Text);
                command.Parameters.AddWithValue("phone", txtPhone.Text);
                command.ExecuteNonQuery();
                Clear();
                Read();

            }
            catch (Exception)
            {

                // ... create log
            }
            finally
            {
                connection.Close();
            }
        }

        public void Clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtFamily.Text = "";
            txtMobile.Text = "";
            txtPhone.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.; Initial Catalog=PhoneBookDB; User Id=sa; Password=123");
            try
            {
                var result = MessageBox.Show($"آیا مخاطب {txtName.Text} {txtFamily.Text} حذف شود؟", "حذف", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    return;

                connection.Open();
                SqlCommand command = new SqlCommand("delete from Info where Id=@id", connection);
                command.Parameters.AddWithValue("id", txtId.Text);
                command.ExecuteNonQuery();
                Clear();
                Read();
            }
            catch (Exception)
            {

                // Create log
            }
            finally
            {
                connection.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=.; Initial Catalog=PhoneBookDB; User Id=sa; Password=123");
            SqlDataAdapter da = new SqlDataAdapter("select * from Info where Name Like @value or Family like @value", connection);
            da.SelectCommand.Parameters.AddWithValue("value", $"%{txtSearch.Text}%");
            DataSet ds = new DataSet();
            da.Fill(ds, "Info");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "Info");
        }
    }
}