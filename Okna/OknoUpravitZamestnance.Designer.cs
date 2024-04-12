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
		SuspendLayout();
		// 
		// label1
		// 
		label1.Location = new Point(154, 52);
		label1.Margin = new Padding(5, 0, 5, 0);
		// 
		// textBoxJmeno
		// 
		textBoxJmeno.Location = new Point(240, 52);
		textBoxJmeno.Margin = new Padding(5, 3, 5, 3);
		textBoxJmeno.Size = new Size(299, 23);
		// 
		// textBoxPrijmeni
		// 
		textBoxPrijmeni.Location = new Point(240, 104);
		textBoxPrijmeni.Margin = new Padding(5, 3, 5, 3);
		textBoxPrijmeni.Size = new Size(299, 23);
		// 
		// label2
		// 
		label2.Location = new Point(145, 104);
		label2.Margin = new Padding(5, 0, 5, 0);
		// 
		// textBoxZkratka
		// 
		textBoxZkratka.Location = new Point(240, 159);
		textBoxZkratka.Margin = new Padding(5, 3, 5, 3);
		textBoxZkratka.Size = new Size(299, 23);
		// 
		// label3
		// 
		label3.Location = new Point(41, 165);
		label3.Margin = new Padding(5, 0, 5, 0);
		// 
		// buttonZavrit
		// 
		buttonZavrit.Location = new Point(107, 262);
		buttonZavrit.Margin = new Padding(5, 3, 5, 3);
		buttonZavrit.Size = new Size(187, 81);
		buttonZavrit.Click += buttonZavrit_Click;
		// 
		// buttonOk
		// 
		buttonOk.Location = new Point(355, 262);
		buttonOk.Margin = new Padding(5, 3, 5, 3);
		buttonOk.Size = new Size(187, 81);
		buttonOk.Click += buttonOk_Click;
		// 
		// OknoUpravitZamestnance
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(659, 414);
		Margin = new Padding(5, 3, 5, 3);
		MaximumSize = new Size(675, 453);
		MinimumSize = new Size(675, 453);
		Name = "OknoUpravitZamestnance";
		Text = "OknoUpravitZamestnance";
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion
}