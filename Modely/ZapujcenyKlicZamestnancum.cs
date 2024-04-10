using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceKlicu.Modely;

public class ZapujcenyKlicZamestnancum
{
	internal Klic Klic { get; init; }
	internal IEnumerable<Zamestnanec> Zamestnanci { get; init; }

	public ZapujcenyKlicZamestnancum(Klic klic, IEnumerable<Zamestnanec> zamestnanci)
	{
		Klic = klic;
		Zamestnanci = zamestnanci;
	}


}
