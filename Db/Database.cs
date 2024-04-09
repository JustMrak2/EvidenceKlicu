using EvidenceKlicu.Modely;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Common;

namespace EvidenceKlicu.Db;

internal class Database
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
        Console.WriteLine("changed succesfully");
    }

	/*public void VytvoritDatabazi()
    {
		string skript = NacistSkript(Skripty.VytvoritDatabazi);
		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
        string absolutniCesta = Path.GetFullPath(cestaDatabaze);
        prikaz.Parameters.AddWithValue("DbPath", absolutniCesta);
        _ = prikaz.ExecuteNonQuery();
	}*/

	public string VytvoritDatabazi()
	{//commonapplicationdata Xcommonprogramfiles
        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

		string dataFileFolderPath = Path.GetFullPath(
			Path.Combine(appdata, "EvidenceKlicu", "Data")
			);
		string logFileFolderPath = Path.GetFullPath(
			Path.Combine(appdata, "EvidenceKlicu", "Log")
			);
        string dataFilePath = Path.Combine(dataFileFolderPath, "EvidenceKlicu.mdf");
        string logFilePath = Path.Combine(logFileFolderPath, "EvidenceKlicu.ldf");
        string skript = $@"
        CREATE DATABASE EvidenceKlicu
        ON --PRIMARY
        (
            NAME = 'EvidenceKlicu_data',
            FILENAME = '{dataFilePath}',
            SIZE = 8MB,
            MAXSIZE = UNLIMITED,
            FILEGROWTH = 8MB
        )
        LOG ON
        (
            NAME = 'EvidenceKlicu_log',
            FILENAME = '{logFilePath}',
            SIZE = 8MB,
            MAXSIZE = 32MB,
            FILEGROWTH = 8MB
        );
    ";
        if(!Directory.Exists(dataFileFolderPath))
        {
            Directory.CreateDirectory(dataFileFolderPath);
        }
        if(!Directory.Exists(logFileFolderPath))
        {
            Directory.CreateDirectory(logFileFolderPath);
        }


		using SqlCommand prikaz = new SqlCommand(skript, sqlServerPripojeni);
		_ = prikaz.ExecuteNonQuery();
        Console.WriteLine("success");
        return dataFilePath;

	}

	#endregion

	public IEnumerable<Klic> ZiskatKlice()
    {
        throw new NotImplementedException();
    }

	public IEnumerable<Zamestnanec> ZiskatZamestnance()
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


    public void PridatNovehoZamestnance()
    {
        //instance tridy Zamestnanec
        //naplneni instance tridy hodnotami z Okna vytvorit zamestnance
        string textPrikazu = "INSERT INTO Zamestnanci()" +
                             "VALUES()";
        // zbytečné -> SqlConnection connection = new SqlConnection(PripojovaciRetezec);
        
        SqlCommand prikaz = new SqlCommand(textPrikazu, sqlServerPripojeni);
        //prikaz.Parameters.AddWithValue();
        //vsechny parametry

        prikaz.ExecuteNonQuery();
    }

    public void UpravitZamestnance()
    {
        //instance tridy Zamestnanec
        //naplneni instance tridy hodnotami z Okna upravit zamestnance
        string textPrikazu = "UPDATE Zamestnanci" +
                             "SET sloupec = hodnota, sloupec = hodnota" +
                             "WHERE condition";
        SqlCommand prikaz = new SqlCommand(textPrikazu, sqlServerPripojeni);
        //prikaz.Parameters.AddWithValue();
        //vsechny parametry

        prikaz.ExecuteNonQuery();
    }

    public void OdstranitZamestnance()
    {
        string textPrikazu = "DELETE FROM Zamestnanci WHERE condition";
        SqlCommand prikaz = new SqlCommand(textPrikazu, sqlServerPripojeni);
        prikaz.ExecuteNonQuery();
    }


}
