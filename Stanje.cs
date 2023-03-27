using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZavrsnaAplikacija
{
	internal class Stanje
	{
		int id;
		string temp, tlo, zrak,datum;

		public Stanje(int id, string temp, string tlo, string zrak, string datum)
		{
			this.id = id;
			this.temp = temp;
			this.tlo = tlo;
			this.zrak = zrak;
			this.datum = datum;
		}

		public int Id { get => id; set => id = value; }
		public string Temp { get => temp; set => temp = value; }
		public string Tlo { get => tlo; set => tlo = value; }
		public string Zrak { get => zrak; set => zrak = value; }
		public string Datum { get => datum; set => datum = value; }



	}
}
