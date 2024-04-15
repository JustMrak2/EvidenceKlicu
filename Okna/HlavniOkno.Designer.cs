namespace EvidenceKlicu
{
	partial class HlavniOkno
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            buttonSmazatZamestnance = new Button();
            buttonUpravitZamestnance = new Button();
            buttonPridatZamestnance = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(895, 633);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zamestnanci";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(6, 81);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(883, 546);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Data";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(871, 518);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonSmazatZamestnance);
            groupBox2.Controls.Add(buttonUpravitZamestnance);
            groupBox2.Controls.Add(buttonPridatZamestnance);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(883, 53);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Úpravy";
            // 
            // buttonSmazatZamestnance
            // 
            buttonSmazatZamestnance.Location = new Point(595, 22);
            buttonSmazatZamestnance.Name = "buttonSmazatZamestnance";
            buttonSmazatZamestnance.Size = new Size(288, 23);
            buttonSmazatZamestnance.TabIndex = 2;
            buttonSmazatZamestnance.Text = "Smazat zaměstnance";
            buttonSmazatZamestnance.UseVisualStyleBackColor = true;
            // 
            // buttonUpravitZamestnance
            // 
            buttonUpravitZamestnance.Location = new Point(301, 22);
            buttonUpravitZamestnance.Name = "buttonUpravitZamestnance";
            buttonUpravitZamestnance.Size = new Size(288, 23);
            buttonUpravitZamestnance.TabIndex = 1;
            buttonUpravitZamestnance.Text = "Upravit zaměstnance";
            buttonUpravitZamestnance.UseVisualStyleBackColor = true;
            buttonUpravitZamestnance.Click += buttonUpravitZamestnance_Click;
            // 
            // buttonPridatZamestnance
            // 
            buttonPridatZamestnance.Location = new Point(6, 22);
            buttonPridatZamestnance.Name = "buttonPridatZamestnance";
            buttonPridatZamestnance.Size = new Size(289, 23);
            buttonPridatZamestnance.TabIndex = 0;
            buttonPridatZamestnance.Text = "Přidat zaměstnance";
            buttonPridatZamestnance.UseVisualStyleBackColor = true;
            buttonPridatZamestnance.Click += buttonPridatZamestnance_Click;
            // 
            // HlavniOkno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 657);
            Controls.Add(groupBox1);
            Name = "HlavniOkno";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
		private GroupBox groupBox3;
		private DataGridView dataGridView1;
		private GroupBox groupBox2;
        private Button buttonUpravitZamestnance;
        private Button buttonPridatZamestnance;
        private Button buttonSmazatZamestnance;
    }
}