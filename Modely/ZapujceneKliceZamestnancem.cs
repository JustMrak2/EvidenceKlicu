using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceKlicu.Modely;

public class ZapujceneKliceZamestnancem
{
	internal Zamestnanec Zamestnanec { get; init; }
	internal IEnumerable<Klic> ZapujceneKlice { get; init; }

	public ZapujceneKliceZamestnancem(Zamestnanec zamestnanec, IEnumerable<Klic> zapujceneKlice)
	{
		ZapujceneKlice = zapujceneKlice;
		Zamestnanec = zamestnanec;
	}
}
