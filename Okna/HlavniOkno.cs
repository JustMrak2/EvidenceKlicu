using EvidenceKlicu.Db;
using EvidenceKlicu.Modely;

namespace EvidenceKlicu;

public partial class HlavniOkno : Form
{
	Database db;
	public HlavniOkno()
	{
		InitializeComponent();
		Text = "Evidence klicu";
		WindowState = FormWindowState.Maximized;

		string connectionString = "Server=localhost;Integrated security=True;database=master";//"Data Source=GPD-WIN-MAX-2-I;Initial Catalog=EvidenceKlicu;Integrated Security=True;Pooling=False";
		db = new Database(connectionString);
		if(!db.ExistujeDatabaze())
		{
			string adresaVytvoreneDatabaze = db.VytvoritDatabazi();
			string novyPripojovaciRetezec = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={adresaVytvoreneDatabaze};Integrated Security=False;Connect Timeout=30";
			db.ZmenitPripojovaciRetezec(novyPripojovaciRetezec);
			db.VytvoritTabulky();
		}
		else
		{
			if(db.ZjistitStavTabulkyKlice() != StavTabulky.Vporadku
				|| db.ZjistitStavTabulkyZamestnanci() != StavTabulky.Vporadku
				|| db.ZjistitStavTabulkyZaznamyVypujceni() != StavTabulky.Vporadku)
			{
				db.OpravitTabulky();
			}
		}


		FormClosing += HlavniOkno_FormClosing;
	}

	private void HlavniOkno_FormClosing(object? sender, FormClosingEventArgs e)
	{
		db?.UzavritPripojeni();
	}
}