using EvidenceKlicu.Db;
using EvidenceKlicu.Modely;
using EvidenceKlicu.Okna;
using System.Data.SqlClient;

namespace EvidenceKlicu;

public partial class HlavniOkno : Form
{
    Database db;
    public HlavniOkno()
    {
        InitializeComponent();
        Text = "Evidence klicu";
        WindowState = FormWindowState.Maximized;

        /*
		string connectionString = "Server=localhost;Integrated security=True";//"Data Source=GPD-WIN-MAX-2-I;Initial Catalog=EvidenceKlicu;Integrated Security=True;Pooling=False";
		db = new Database(connectionString);
		if(!db.ExistujeDatabaze())
		{
			db.VytvoritDatabazi();
		}
		if(db.ZjistitStavTabulkyKlice() != StavTabulky.Vporadku
			|| db.ZjistitStavTabulkyZamestnanci() != StavTabulky.Vporadku
			|| db.ZjistitStavTabulkyZaznamyVypujceni() != StavTabulky.Vporadku)
		{
			db.OpravitTabulky();
		}
		FormClosing += HlavniOkno_FormClosing;
		*/
    }

    private void HlavniOkno_FormClosing(object? sender, FormClosingEventArgs e)
    {
        db?.UzavritPripojeni();
    }

    private void buttonPridatZamestnance_Click(object sender, EventArgs e)
    {
        this.Close();
        Form oknoPridat = new OknoPridatZamestnance();
        oknoPridat.ShowDialog();
    }

    private void buttonUpravitZamestnance_Click(object sender, EventArgs e)
    {
        this.Close();
        Form oknoPridat = new OknoUpravitZamestnance();
        oknoPridat.ShowDialog();
    }
}