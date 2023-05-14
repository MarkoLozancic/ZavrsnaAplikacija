using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ZavrsnaAplikacija
{
	public partial class txtTemp : Form
	{
		int id=0;
		XmlWriter xmlWriter;
		public txtTemp()
		{
			InitializeComponent();
		}

		private void btnUnosStanja_Click(object sender, EventArgs e)
		{
			try
			{
				id++;

				List<Stanje> listStanja = new List<Stanje>();
				Stanje os = new Stanje(id, textBox1.Text, txtTlo.Text, txtZrak.Text, DateTime.Now.ToLongDateString());


				listStanja.Add(os);


				try
				{
					var Stanja = XDocument.Load("Stanje.xml");
					foreach (Stanje stanje in listStanja)
					{
						var State = new XElement("Stanje",
							 new XElement("Stanje_ID", os.Id),
							  new XElement("Temperatura", os.Temp),
							new XElement("Tlo", os.Tlo),
							  new XElement("Zrak", os.Zrak),
							   new XElement("Datum", os.Datum));


						Stanja.Element("Stanja").Add(State);
						

					}
					Stanja.Save("Stanje.xml");
				}

				catch
				{

					var Stanja = new XDocument();
					var rootElem = new XElement("Stanja");
					Stanja.Add(rootElem);
					Stanja.Save("Stanje.xml");
					foreach (Stanje stanje in listStanja)
					{
						var State = new XElement("Stanje",
							 new XElement("Stanje_ID", os.Id),
							  new XElement("Temperatura", os.Temp),
							new XElement("Tlo", os.Tlo),
							  new XElement("Zrak", os.Zrak),
							   new XElement("Datum", os.Datum));


						Stanja.Element("stanja").Add(State);
						

					}
					Stanja.Save("Stanje.xml");

				}
				
				
				listStanja.Clear();

				textBox1.Clear();
				txtTlo.Clear();
				txtZrak.Clear();
				
				MessageBox.Show("Uspješno izvršen unos stanja", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch
			{
				MessageBox.Show("Greška u unosu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
