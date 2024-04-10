using EvidenceKlicu.Modely;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Common;

namespace EvidenceKlicu.Db;

public class Database
{
    private static string cestaKeSkriptum = "../../../Db/Sql/";
    private static string cestaDatabaze = "../../../Db";
	readonly SqlConnection sqlServerPripojeni;

	public Database(string pripojovaciRetezec)
	{
		sqlServerPripojeni = new SqlConnection(pripojovaciRetezec);
        sqlServerPripojeni.Open();
	}

	private static string NacistSkript(string jmenoSkriptu)
    {
        using FileStream fs = new FileStream(cestaKeSkriptum + jmenoSkriptu, FileMode.Open, FileAccess.Read);
        using StreamReader sr = new StreamReader(fs);
        return sr.ReadToEnd();
    }

    public void UzavritPripojeni()
    {
        sqlServerPripojeni.Close();
    }
	#region Sprava databaze
	public bool ExistujeDatabaze()
    {
        string skript = NacistSkript(Skripty.ExistujeDatabaze);
        using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
        using SqlDataReader reader = prikaz.ExecuteReader();
        _ = reader.Read();
        bool dbExistuje = (int)reader[0] == 1;
        return dbExistuje;
    }

	#region Sprava tabulek
    public StavTabulky ZjistitStavTabulkyKlice()
    {
        string skript = NacistSkript(Skripty.StavTabulkyKlice);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		using SqlDataReader reader = prikaz.ExecuteReader();
		_ = reader.Read();
		StavTabulky stav = (StavTabulky)reader[0];
		return stav;
	}

	public StavTabulky ZjistitStavTabulkyZamestnanci()
	{
		string skript = NacistSkript(Skripty.StavTabulkyZamstnanci);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		using SqlDataReader reader = prikaz.ExecuteReader();
		_ = reader.Read();
		StavTabulky stav = (StavTabulky)reader[0];
		return stav;
	}

	public StavTabulky ZjistitStavTabulkyZaznamyVypujceni()
	{
		string skript = NacistSkript(Skripty.StavTabulkyZaznamyVypujceni);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		using SqlDataReader reader = prikaz.ExecuteReader();
		_ = reader.Read();
		StavTabulky stav = (StavTabulky)reader[0];
		return stav;
	}

	public void OpravitTabulky()
    {
		string skript = NacistSkript(Skripty.SmazatVsechnyTabulky);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		_ = prikaz.ExecuteNonQuery();
        VytvoritTabulky();
	}
	public void VytvoritTabulky()
    {
        VytvoritTabulkuKlice();
        VytvoritTabulkuZamestnanci();
        VytvoritTabulkuZaznamyVypujceni();
	}

	private void VytvoritTabulkuZamestnanci()
	{
		string skript = NacistSkript(Skripty.VytvoritTabulkuZamestnanci);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		_ = prikaz.ExecuteNonQuery();
	}

	private void VytvoritTabulkuZaznamyVypujceni()
	{
		string skript = NacistSkript(Skripty.VytvoritTabulkuZaznamyVypujceni);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		_ = prikaz.ExecuteNonQuery();
	}

	private void VytvoritTabulkuKlice()
    {
		string skript = NacistSkript(Skripty.VytvoritTabulkuKlice);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		_ = prikaz.ExecuteNonQuery();
    }
    #endregion
    public void ZmenitPripojovaciRetezec(string pripojovaciRetezec)
    {
        sqlServerPripojeni.Close();
        sqlServerPripojeni.ConnectionString = pripojovaciRetezec;
        sqlServerPripojeni.Open();
    }

	public void VytvoritDatabazi()
	{
        string skript = NacistSkript(Skripty.VytvoritDatabazi);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		_ = prikaz.ExecuteNonQuery();
	}

	#endregion

	public IEnumerable<Klic> ZiskatVsechnyKlice()
    {
        throw new NotImplementedException();
    }

	public IEnumerable<Zamestnanec> ZiskatVsechnyZamestnance()
    {
        throw new NotImplementedException();
    }

	public ZapujceneKliceZamestnancem ZiskatZapujceneKlice(Zamestnanec zamestnanec)
    {
        throw new NotImplementedException();
    }

	public ZapujcenyKlicZamestnancum ZiskatZapujceneKlice(Klic klic)
    {
        throw new NotImplementedException();
    }


    public void PridatNovehoZamestnance(Zamestnanec zamestnanec)
    {
        string skript = NacistSkript(Skripty.PridatZamestnance);
        using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
        prikaz.Parameters.AddWithValue("Jmeno", zamestnanec.Jmeno);
		prikaz.Parameters.AddWithValue("Prijmeni", zamestnanec.Prijmeni);
		prikaz.Parameters.AddWithValue("Zkratka", zamestnanec.Zkratka);
        SqlDataReader reader = prikaz.ExecuteReader();
        int id = (int)reader[0];
        zamestnanec.Id = id;
    }

    public void UpravitZamestnance(Zamestnanec zamestnanec)
    {
        string skript = NacistSkript(Skripty.UpravitZamestnance);
        using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
        prikaz.Parameters.AddWithValue("Jmeno", zamestnanec.Jmeno);
        prikaz.Parameters.AddWithValue("Prijmeni", zamestnanec.Prijmeni);
        prikaz.Parameters.AddWithValue("Zkratka", zamestnanec.Zkratka);        

        prikaz.ExecuteNonQuery();
    }

    public void OdstranitZamestnance(Zamestnanec zamestnanec)
    {
		string skript = NacistSkript(Skripty.OdstranitZamestnance);		
        SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
        prikaz.ExecuteNonQuery();
    }

    public void PridatNovyKlic(Klic klic)
	{
		throw new NotImplementedException();
	}

	public void UpravitKlic(Klic klic)
	{
		throw new NotImplementedException();
	}

	public void OdstranitKlic(Klic klci)
	{
		throw new NotImplementedException();
	}
}
