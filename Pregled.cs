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

namespace ZavrsnaAplikacija
{
	public partial class Pregled : Form
	{
		public Pregled(string admin)
		{
			InitializeComponent();
			if(admin=="admin")
			{
				Administrator.Visible = true;
				btnBrisanje.Visible = true;
				btnBrisanje.Enabled = true;
				btnMijenjanje.Enabled = true;
				btnMijenjanje.Visible = true;
				label1.Visible = true;
				cboxMijenjanje.Visible=true;
				cboxMijenjanje.Enabled=true;
				txtMijenjano.Visible=true;
				txtMijenjano.Enabled=true;
				
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnpretragaK_Click(object sender, EventArgs e)
		{
			listbKorisnici.Items.Clear();


			var users = XDocument.Load("Stanje.xml");

			if (txtImeK.Text != "")
			{
			 
				var query =
								from Stanje in
									users.Descendants("Stanje")
								where Stanje.Element("Datum").Value == txtImeK.Text

								select
						   Stanje.Element("Stanje_ID").Value + "\t" + "\t"  +
							   Stanje.Element("Temperatura").Value + "\t"  + Stanje.Element("Tlo").Value + "\t" + 
					Stanje.Element("Zrak").Value + "\t" + Stanje.Element("Datum").Value
								;


				foreach (string Stanje in query)
				{
					if (listbKorisnici.Items.Contains(Stanje) == false)
						listbKorisnici.Items.Add(Convert.ToString(Stanje));
				}


			}
		}

		private void circularButton1_Click(object sender, EventArgs e)
		{
			listbKorisnici.Items.Clear();
			var users = XDocument.Load("Stanje.xml");


			try
			{
				var query =
								from Stanje in
									users.Descendants("Stanje")
								where (Stanje.Element("Datum").Value == txtImeK.Text) && (Stanje.Element(comboBox1.SelectedItem.ToString()).Value == txtPretraga.Text)

								select
								Stanje.Element("Stanje_ID").Value + "\t" + "\t" +
							   Stanje.Element("Temperatura").Value + "\t" + Stanje.Element("Tlo").Value + "\t" +
					Stanje.Element("Zrak").Value + "\t" + Stanje.Element("Datum").Value
								;

				foreach (string Stanje in query)
				{
					if (listbKorisnici.Items.Contains(Stanje) == false)
						listbKorisnici.Items.Add(Convert.ToString(Stanje));
				}
			}
			catch
			{
				MessageBox.Show("Greška u unosu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnBrisanje_Click(object sender, EventArgs e)
		{
			string str = listbKorisnici.SelectedItem.ToString();
			char[] ch = new char[1];
			for (int i = 0; i < 1; i++)
			{
				ch[i] = (str.ToCharArray())[i];
			}

			var users = XDocument.Load("Stanje.xml");
			try
			{

				var query2 =
										from Stanje in
											users.Descendants("Stanje")
										where Stanje.Element("Stanje_ID").Value == ch[0].ToString()

										select Stanje;


				query2.FirstOrDefault().Remove();



			}
			catch
			{
				MessageBox.Show("Došlo je do pogreške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			users.Save("Stanje.xml");
		}

		private void btnMijenjanje_Click(object sender, EventArgs e)
		{
			string str = listbKorisnici.SelectedItem.ToString();
			char[] ch = new char[1];
			for (int i = 0; i < 1; i++)
			{
				ch[i] = (str.ToCharArray())[i];
			}

			var users = XDocument.Load("Stanje.xml");
			try
			{

			var query2 =
									from Stanje in
										users.Descendants("Stanje")
									where Stanje.Element("Stanje_ID").Value   == ch[0].ToString()

									select Stanje;

					
						query2.FirstOrDefault().Element(cboxMijenjanje.SelectedItem.ToString()).Value = txtMijenjano.Text;
						
					
					
			}
			catch
			{
				MessageBox.Show("Došlo je do pogreške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			users.Save("Stanje.xml");
		}
	}
}
