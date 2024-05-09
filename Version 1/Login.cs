using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Version_1
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}


		SqlConnection conn = new SqlConnection(@"Data Source=TUF-DASH-F15\SQLSERVER;Initial Catalog=CONGTY;Integrated Security=True;");



		private void button1_Click(object sender, EventArgs e)
		{
			String username, password;
			username = textBox1.Text;
			password = textBox2.Text;


			try
			{
				String query = "SELECT * FROM Login WHERE" +
					" username  = '" + textBox1.Text + "'   AND password = '" + textBox2.Text + "'";
				SqlDataAdapter sda = new SqlDataAdapter(query, conn);

				DataTable dtable = new DataTable();
				sda.Fill(dtable);

				if (dtable.Rows.Count > 0 )
				{
					username = textBox1.Text;
					password = textBox2.Text;

					frmChinh Home = new frmChinh();
					Home.Show();
					this.Hide();

				}
			}
			catch
			{
				MessageBox.Show("Invalid", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
				textBox1.Clear();
				textBox2.Clear();

				textBox1.Focus();
			}
			finally
			{
				//MessageBox.Show("Error");
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();

			textBox1.Focus();
		}
	}
}
