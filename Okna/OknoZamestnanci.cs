using EvidenceKlicu.Db;
using EvidenceKlicu.Modely;

namespace EvidenceKlicu.Okna;

public partial class OknoZamestnanci : Form
{
    Database? database;
    public OknoZamestnanci()
    {
        InitializeComponent();
    }

    public OknoZamestnanci(object? _)
    {
        InitializeComponent();

        string connectionString = "Server=localhost;Integrated security=True";//"Data Source=GPD-WIN-MAX-2-I;Initial Catalog=EvidenceKlicu;Integrated Security=True;Pooling=False";
		database = new Database(connectionString);
		if(!database.ExistujeDatabaze())
		{
			database.VytvoritDatabazi();
		}
		if(database.ZjistitStavTabulkyKlice() != StavTabulky.Vporadku
			|| database.ZjistitStavTabulkyZamestnanci() != StavTabulky.Vporadku
			|| database.ZjistitStavTabulkyZaznamyVypujceni() != StavTabulky.Vporadku)
		{
			database.OpravitTabulky();
		}
		FormClosing += HlavniOkno_FormClosing;
        
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
        Button? button = (Button?)sender;
        Zamestnanec? zamestnanec = (Zamestnanec?)button?.DataContext;
        if (zamestnanec is null || database is null) return;

        new OknoUpravitZamestnance(database, zamestnanec).Show();
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
        database?.UzavritPripojeni();
    }
}
