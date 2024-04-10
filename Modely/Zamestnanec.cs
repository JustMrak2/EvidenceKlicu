using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EvidenceKlicu.Modely;

public class Zamestnanec
{
    public int Id { get; set; }
    public string Jmeno { get; set; }
    public string Prijmeni { get; set; }
    public string Zkratka { get; set; }
    public Zamestnanec(string jmeno, string prijmeni, string zkratka)
    {
        this.Jmeno = jmeno;
        this.Prijmeni = prijmeni;
        this.Zkratka = zkratka;
    }

    public static bool JsouUdajeSpravne(string jmeno, string prijmeni, string zkratka)
    {
        if (string.IsNullOrEmpty(jmeno) &&
        jmeno.Length <= 64 &&
        string.IsNullOrEmpty(prijmeni) &&
        prijmeni.Length <= 64 &&
        string.IsNullOrEmpty(zkratka) &&
        return Regex.IsMatch(zkratka, "^[A-Z]{2}$");
    }
}
