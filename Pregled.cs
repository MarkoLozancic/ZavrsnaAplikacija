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
		public Pregled()
		{
			InitializeComponent();
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
								Stanje.Element("Stanje_ID").Value + "\t"+ "\t" + 
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
	}
}
