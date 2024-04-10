using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvidenceKlicu.Modely;

namespace EvidenceKlicu.Okna
{
    public partial class OknoOdstranitZamestnance : Form
    {
        Zamestnanec zamestnanec;
        public OknoOdstranitZamestnance(Zamestnanec zamestnanec)
        {
            InitializeComponent();
            this.zamestnanec = zamestnanec;
        }

        public OknoOdstranitZamestnance()
        {
            InitializeComponent();
        }
    }
}
