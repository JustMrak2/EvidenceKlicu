namespace EvidenceKlicu.Okna;

partial class OknoVychoziZamestnanec
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
		label1 = new Label();
		textBoxJmeno = new TextBox();
		textBoxPrijmeni = new TextBox();
		label2 = new Label();
		textBoxZkratka = new TextBox();
		label3 = new Label();
		buttonZavrit = new Button();
		buttonOk = new Button();
		dataGridView1 = new DataGridView();
		((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
		SuspendLayout();
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
		label1.Location = new Point(103, 9);
		label1.Margin = new Padding(4, 0, 4, 0);
		label1.Name = "label1";
		label1.Size = new Size(58, 18);
		label1.TabIndex = 0;
		label1.Text = "Jméno:";
		// 
		// textBoxJmeno
		// 
		textBoxJmeno.Location = new Point(177, 9);
		textBoxJmeno.Margin = new Padding(4, 3, 4, 3);
		textBoxJmeno.Name = "textBoxJmeno";
		textBoxJmeno.Size = new Size(257, 23);
		textBoxJmeno.TabIndex = 1;
		// 
		// textBoxPrijmeni
		// 
		textBoxPrijmeni.Location = new Point(177, 38);
		textBoxPrijmeni.Margin = new Padding(4, 3, 4, 3);
		textBoxPrijmeni.Name = "textBoxPrijmeni";
		textBoxPrijmeni.Size = new Size(257, 23);
		textBoxPrijmeni.TabIndex = 3;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
		label2.Location = new Point(95, 38);
		label2.Margin = new Padding(4, 0, 4, 0);
		label2.Name = "label2";
		label2.Size = new Size(65, 18);
		label2.TabIndex = 2;
		label2.Text = "Příjmení:";
		// 
		// textBoxZkratka
		// 
		textBoxZkratka.Location = new Point(177, 67);
		textBoxZkratka.Margin = new Padding(4, 3, 4, 3);
		textBoxZkratka.Name = "textBoxZkratka";
		textBoxZkratka.Size = new Size(257, 23);
		textBoxZkratka.TabIndex = 5;
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
		label3.Location = new Point(6, 72);
		label3.Margin = new Padding(4, 0, 4, 0);
		label3.Name = "label3";
		label3.Size = new Size(155, 18);
		label3.TabIndex = 4;
		label3.Text = "Zkratka zaměstnance:";
		// 
		// buttonZavrit
		// 
		buttonZavrit.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
		buttonZavrit.Location = new Point(62, 96);
		buttonZavrit.Margin = new Padding(4, 3, 4, 3);
		buttonZavrit.Name = "buttonZavrit";
		buttonZavrit.Size = new Size(160, 70);
		buttonZavrit.TabIndex = 6;
		buttonZavrit.Text = "Zavřít";
		buttonZavrit.UseVisualStyleBackColor = true;
		// 
		// buttonOk
		// 
		buttonOk.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
		buttonOk.Location = new Point(274, 96);
		buttonOk.Margin = new Padding(4, 3, 4, 3);
		buttonOk.Name = "buttonOk";
		buttonOk.Size = new Size(160, 70);
		buttonOk.TabIndex = 7;
		buttonOk.Text = "OK";
		buttonOk.UseVisualStyleBackColor = true;
		// 
		// dataGridView1
		// 
		dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView1.Location = new Point(6, 172);
		dataGridView1.Name = "dataGridView1";
		dataGridView1.RowTemplate.Height = 25;
		dataGridView1.Size = new Size(547, 175);
		dataGridView1.TabIndex = 8;
		// 
		// OknoVychoziZamestnanec
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(565, 359);
		Controls.Add(dataGridView1);
		Controls.Add(buttonOk);
		Controls.Add(buttonZavrit);
		Controls.Add(textBoxZkratka);
		Controls.Add(label3);
		Controls.Add(textBoxPrijmeni);
		Controls.Add(label2);
		Controls.Add(textBoxJmeno);
		Controls.Add(label1);
		Margin = new Padding(4, 3, 4, 3);
		MaximumSize = new Size(581, 398);
		MinimumSize = new Size(581, 398);
		Name = "OknoVychoziZamestnanec";
		Text = "OknoVychoziZamestnanec";
		((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion
	protected Label label1;
    protected TextBox textBoxJmeno;
    protected TextBox textBoxPrijmeni;
    protected Label label2;
    protected TextBox textBoxZkratka;
    protected Label label3;
    protected Button buttonZavrit;
    protected Button buttonOk;
	private DataGridView dataGridView1;
}