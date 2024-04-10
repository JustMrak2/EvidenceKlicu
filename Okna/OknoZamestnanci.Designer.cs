namespace EvidenceKlicu.Okna;

partial class OknoZamestnanci
{
    /// <summary>
    /// Vyžaduje se proměnná návrháře.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Uvolněte všechny používané prostředky.
    /// </summary>
    /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Kód generovaný Návrhářem Windows Form

    /// <summary>
    /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
    /// obsah této metody v editoru kódu.
    /// </summary>
    private void InitializeComponent()
    {
        dataGridView = new DataGridView();
        label1 = new Label();
        menuStrip1 = new MenuStrip();
        pridatZamestnance = new ToolStripMenuItem();
        upravitZamestnance = new ToolStripMenuItem();
        odstranitZamestnance = new ToolStripMenuItem();
        dataGridView1 = new DataGridView();
        label2 = new Label();
        Id = new DataGridViewTextBoxColumn();
        Jmeno = new DataGridViewTextBoxColumn();
        Prijmeni = new DataGridViewTextBoxColumn();
        Zkratka = new DataGridViewTextBoxColumn();
        Akce = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        NazevMistnosti = new DataGridViewTextBoxColumn();
        OznaceniMistnosti = new DataGridViewTextBoxColumn();
        PocetKusu = new DataGridViewTextBoxColumn();
        PocetZapujcenych = new DataGridViewTextBoxColumn();
        Akcee = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
        menuStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView
        // 
        dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Jmeno, Prijmeni, Zkratka, Akce });
        dataGridView.Location = new Point(20, 61);
        dataGridView.Margin = new Padding(4, 3, 4, 3);
        dataGridView.Name = "dataGridView";
        dataGridView.Size = new Size(541, 540);
        dataGridView.TabIndex = 0;
        dataGridView.CellContentClick += dataGridView_CellContentClick;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(14, 28);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(137, 26);
        label1.TabIndex = 1;
        label1.Text = "Zaměstnanci";
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { pridatZamestnance, upravitZamestnance, odstranitZamestnance });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(7, 2, 0, 2);
        menuStrip1.Size = new Size(1225, 24);
        menuStrip1.TabIndex = 2;
        menuStrip1.Text = "menuStrip1";
        // 
        // pridatZamestnance
        // 
        pridatZamestnance.Name = "pridatZamestnance";
        pridatZamestnance.Size = new Size(50, 20);
        pridatZamestnance.Text = "Přidat";
        pridatZamestnance.Click += pridatZamestnance_Click;
        // 
        // upravitZamestnance
        // 
        upravitZamestnance.Name = "upravitZamestnance";
        upravitZamestnance.Size = new Size(57, 20);
        upravitZamestnance.Text = "Upravit";
        upravitZamestnance.Click += upravitZamestnance_Click;
        // 
        // odstranitZamestnance
        // 
        odstranitZamestnance.Name = "odstranitZamestnance";
        odstranitZamestnance.Size = new Size(68, 20);
        odstranitZamestnance.Text = "Odstranit";
        odstranitZamestnance.Click += odstranitZamestnance_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, NazevMistnosti, OznaceniMistnosti, PocetKusu, PocetZapujcenych, Akcee });
        dataGridView1.Location = new Point(569, 61);
        dataGridView1.Margin = new Padding(4, 3, 4, 3);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(640, 540);
        dataGridView1.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(569, 28);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(60, 26);
        label2.TabIndex = 4;
        label2.Text = "Klíče";
        // 
        // Id
        // 
        Id.HeaderText = "Id";
        Id.Name = "Id";
        Id.ReadOnly = true;
        // 
        // Jmeno
        // 
        Jmeno.HeaderText = "Jméno";
        Jmeno.Name = "Jmeno";
        Jmeno.ReadOnly = true;
        // 
        // Prijmeni
        // 
        Prijmeni.HeaderText = "Příjmení";
        Prijmeni.Name = "Prijmeni";
        Prijmeni.ReadOnly = true;
        // 
        // Zkratka
        // 
        Zkratka.HeaderText = "Zkratka";
        Zkratka.Name = "Zkratka";
        Zkratka.ReadOnly = true;
        // 
        // Akce
        // 
        Akce.HeaderText = "Akce";
        Akce.Name = "Akce";
        Akce.ReadOnly = true;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.HeaderText = "Id";
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.ReadOnly = true;
        // 
        // NazevMistnosti
        // 
        NazevMistnosti.HeaderText = "Název Místnosti";
        NazevMistnosti.Name = "NazevMistnosti";
        NazevMistnosti.ReadOnly = true;
        // 
        // OznaceniMistnosti
        // 
        OznaceniMistnosti.HeaderText = "Označení místnosti";
        OznaceniMistnosti.Name = "OznaceniMistnosti";
        OznaceniMistnosti.ReadOnly = true;
        // 
        // PocetKusu
        // 
        PocetKusu.HeaderText = "Počet kusů";
        PocetKusu.Name = "PocetKusu";
        PocetKusu.ReadOnly = true;
        // 
        // PocetZapujcenych
        // 
        PocetZapujcenych.HeaderText = "Počet zapůjčených";
        PocetZapujcenych.Name = "PocetZapujcenych";
        PocetZapujcenych.ReadOnly = true;
        // 
        // Akcee
        // 
        Akcee.HeaderText = "Akce";
        Akcee.Name = "Akcee";
        Akcee.ReadOnly = true;
        // 
        // OknoZamestnanci
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1225, 615);
        Controls.Add(label2);
        Controls.Add(dataGridView1);
        Controls.Add(label1);
        Controls.Add(dataGridView);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(4, 3, 4, 3);
        Name = "OknoZamestnanci";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridView;
    private Label label1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem pridatZamestnance;
    private ToolStripMenuItem upravitZamestnance;
    private ToolStripMenuItem odstranitZamestnance;
    private DataGridView dataGridView1;
    private Label label2;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn Jmeno;
    private DataGridViewTextBoxColumn Prijmeni;
    private DataGridViewTextBoxColumn Zkratka;
    private DataGridViewTextBoxColumn Akce;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn NazevMistnosti;
    private DataGridViewTextBoxColumn OznaceniMistnosti;
    private DataGridViewTextBoxColumn PocetKusu;
    private DataGridViewTextBoxColumn PocetZapujcenych;
    private DataGridViewTextBoxColumn Akcee;
}

