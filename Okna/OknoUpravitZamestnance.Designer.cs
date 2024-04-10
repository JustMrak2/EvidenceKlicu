namespace EvidenceKlicu.Okna;

partial class OknoUpravitZamestnance : OknoVychoziZamestnanec
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
        // buttonZavrit
        // 
        this.buttonZavrit.Click += new System.EventHandler(this.buttonZavrit_Click);
        // 
        // buttonOk
        // 
        this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
        // 
        // OknoUpravitZamestnance
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(484, 311);
        this.Name = "OknoUpravitZamestnance";
        this.Text = "OknoUpravitZamestnance";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion
}