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

public partial class OknoUpravitZamestnance : OknoVychoziZamestnanec
{
    Zamestnanec zamestnanec;
    Database database;

    public OknoUpravitZamestnance(Database database, Zamestnanec zamestnanec)
    {
        InitializeComponent();
        this.database = database;
        this.zamestnanec = zamestnanec;


        textBoxJmeno.Text = zamestnanec.Jmeno;
        textBoxPrijmeni.Text = zamestnanec.Prijmeni;
        textBoxZkratka.Text = zamestnanec.Zkratka;
    }

    public OknoUpravitZamestnance()
    {
        InitializeComponent();
    }

    private void buttonOk_Click(object sender, EventArgs e)
    {
        if (Zamestnanec.JsouUdajeSpravne(textBoxJmeno.Text, textBoxPrijmeni.Text, textBoxZkratka.Text))
        {
            Zamestnanec novyZamestnanec = new Zamestnanec(textBoxJmeno.Text, textBoxPrijmeni.Text, textBoxZkratka.Text);
            database.UpravitZamestnance(); // přiradit hodnoty (dodělat)
        }
        else
        {
            MessageBox.Show("Máte nevyplněné údaje nebo nevyhovující zkratku, která neobsahuje 2 velká písmena. Prosím napravte.");
        }
    }

    private void buttonZavrit_Click(object sender, EventArgs e)
    {
        Close();
    }
}
