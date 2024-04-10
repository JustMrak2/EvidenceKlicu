using EvidenceKlicu.Db;
using EvidenceKlicu.Modely;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidenceKlicu.Okna;

public partial class OknoZamestnanci : Form
{
    Database database;
    public OknoZamestnanci()
    {
        InitializeComponent();
    }

    public OknoZamestnanci(object? _)
    {
        InitializeComponent();

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
        this.database = database;

        IEnumerable<Zamestnanec> zamestnanci = database.ZiskatVsechnyZamestnance();
        foreach (var item in zamestnanci)
        {
            Button button = new Button()
            {
                Text = "Upravit"
            };
            button.Click += Button_Click;
            button.DataContext = item;
            dataGridView.Rows.Add(
                item.Id,
                item.Jmeno,
                item.Prijmeni,
                item.Zkratka,
                button
                );
        }

    }

    private void Button_Click(object? sender, EventArgs e)
    {
        new Okno((Zamestnanec)((Button)sender)?.DataContext).Show();
    }

    private void pridatZamestnance_Click(object sender, EventArgs e)
    {

    }

    private void upravitZamestnance_Click(object sender, EventArgs e)
    {

    }

    private void odstranitZamestnance_Click(object sender, EventArgs e)
    {

    }

    private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void HlavniOkno_FormClosing(object? sender, FormClosingEventArgs e)
    {
        db?.UzavritPripojeni();
    }
}
