using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZavrsnaAplikacija
{
	public partial class Login : Form
	{
		bool admin, user;

		
		public Login()
		{
			InitializeComponent();
			
		}

		

		private void btnPretraga_Click(object sender, EventArgs e)
		{
			var users = XDocument.Load("credentials.xml");

			string username = txtUsername.Text;
			string password = txtPassword.Text;
			string username1 = (string)users.Root.Element("user").Element("username");
			string password1 = (string)users.Root.Element("user").Element("password");



			


			if(username == "admin" && password == "12345678") { admin = true; }
			
			else if(username == "user" && password == "12345678") { user = true; }

			else { MessageBox.Show("Krivo uneseno korisničko ime i/ili lozinka", "Greška u prijavi", MessageBoxButtons.OK, MessageBoxIcon.Error);


				txtPassword.Clear();
				txtUsername.Clear();
			}
			if (admin == true || user== true)

				{


					
					if(admin == true) { MessageBox.Show("Dobrodošli administrator", "Pozdrav", MessageBoxButtons.OK, MessageBoxIcon.Information); }
				else
				{

					MessageBox.Show("Dobrodošli korisniče", "Pozdrav", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
					Form1 frm = new Form1(txtUsername.Text);
					frm.ShowDialog();
				this.WindowState = FormWindowState.Minimized;
				

			}

			


			
		}
	}
}
