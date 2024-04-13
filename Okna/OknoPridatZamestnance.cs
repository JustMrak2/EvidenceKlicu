using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvidenceKlicu.Db;
using EvidenceKlicu.Modely;

namespace EvidenceKlicu.Okna;

public partial class OknoPridatZamestnance : OknoVychoziZamestnanec
{
    Database database;

    public OknoPridatZamestnance(Database database)
    {
        this.database = database;
    }

    public OknoPridatZamestnance()
    {
        InitializeComponent();
    }

    private void textBoxJmeno_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxPrijmeni_TextChanged(object sender, EventArgs e)
    {

    }

    private void buttonOk_Click(object sender, EventArgs e)
    {
        if (Zamestnanec.JsouUdajeSpravne(textBoxJmeno.Text, textBoxPrijmeni.Text, textBoxZkratka.Text))
        {
            Zamestnanec novyZamestnanec = new Zamestnanec(textBoxJmeno.Text, textBoxPrijmeni.Text, textBoxZkratka.Text);
            database.PridatNovehoZamestnance(novyZamestnanec);
            vymazatTextBoxy();
            Close();
        }
        else
        {
            MessageBox.Show("Máte nevyplněné údaje nebo nevyhovující zkratku, která neobsahuje 2 velká písmena. Prosím napravte.");
        }
    }

    private void buttonZavrit_Click(object sender, EventArgs e)
    {
        vymazatTextBoxy();
        Close();
    }

    private void vymazatTextBoxy()
    {
        textBoxJmeno.Clear();
        textBoxPrijmeni.Clear();
        textBoxZkratka.Clear();
    }
}
