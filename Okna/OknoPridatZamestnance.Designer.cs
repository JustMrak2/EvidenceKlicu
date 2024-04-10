namespace EvidenceKlicu.Okna;

partial class OknoPridatZamestnance
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.SuspendLayout();
        // 
        // textBoxJmeno
        // 
        this.textBoxJmeno.TextChanged += new System.EventHandler(this.textBoxJmeno_TextChanged);
        // 
        // textBoxPrijmeni
        // 
        this.textBoxPrijmeni.TextChanged += new System.EventHandler(this.textBoxPrijmeni_TextChanged);
        // 
        // buttonZavrit
        // 
        this.buttonZavrit.Click += new System.EventHandler(this.buttonZavrit_Click);
        // 
        // buttonOk
        // 
        this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
        // 
        // OknoPridatZamestnance
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(500, 296);
        this.Name = "OknoPridatZamestnance";
        this.Text = "OknoPridatZamestnance";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion
}