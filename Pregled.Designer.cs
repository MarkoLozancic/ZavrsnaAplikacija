namespace ZavrsnaAplikacija
{
	partial class Pregled
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pregled));
			this.label2 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPretraga = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Temperatura = new System.Windows.Forms.Label();
			this.listbKorisnici = new System.Windows.Forms.ListBox();
			this.txtImeK = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnpretragaK = new RoundButtonDemo.CircularButton();
			this.circularButton1 = new RoundButtonDemo.CircularButton();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AllowDrop = true;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(205, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(314, 38);
			this.label2.TabIndex = 20;
			this.label2.Text = "Pregled stanja senzora";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold);
			this.label9.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.label9.Location = new System.Drawing.Point(389, 180);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 20);
			this.label9.TabIndex = 57;
			this.label9.Text = "Datum:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold);
			this.label8.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.label8.Location = new System.Drawing.Point(302, 180);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 20);
			this.label8.TabIndex = 56;
			this.label8.Text = "Zrak:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold);
			this.label7.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.label7.Location = new System.Drawing.Point(7, 180);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 20);
			this.label7.TabIndex = 55;
			this.label7.Text = "Stanje ID:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.label3.Location = new System.Drawing.Point(514, 104);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 18);
			this.label3.TabIndex = 53;
			this.label3.Text = "Daljnja pretraga po:";
			// 
			// txtPretraga
			// 
			this.txtPretraga.Location = new System.Drawing.Point(609, 182);
			this.txtPretraga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtPretraga.Name = "txtPretraga";
			this.txtPretraga.Size = new System.Drawing.Size(154, 20);
			this.txtPretraga.TabIndex = 52;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold);
			this.label6.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.label6.Location = new System.Drawing.Point(235, 180);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 20);
			this.label6.TabIndex = 51;
			this.label6.Text = "Tlo:";
			// 
			// Temperatura
			// 
			this.Temperatura.AutoSize = true;
			this.Temperatura.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold);
			this.Temperatura.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.Temperatura.Location = new System.Drawing.Point(109, 180);
			this.Temperatura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Temperatura.Name = "Temperatura";
			this.Temperatura.Size = new System.Drawing.Size(113, 20);
			this.Temperatura.TabIndex = 49;
			this.Temperatura.Text = "Temperatura:";
			this.Temperatura.Click += new System.EventHandler(this.label1_Click);
			// 
			// listbKorisnici
			// 
			this.listbKorisnici.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
			this.listbKorisnici.FormattingEnabled = true;
			this.listbKorisnici.ItemHeight = 17;
			this.listbKorisnici.Location = new System.Drawing.Point(11, 202);
			this.listbKorisnici.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listbKorisnici.Name = "listbKorisnici";
			this.listbKorisnici.Size = new System.Drawing.Size(508, 191);
			this.listbKorisnici.TabIndex = 48;
			// 
			// txtImeK
			// 
			this.txtImeK.Location = new System.Drawing.Point(34, 111);
			this.txtImeK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtImeK.Name = "txtImeK";
			this.txtImeK.Size = new System.Drawing.Size(154, 20);
			this.txtImeK.TabIndex = 47;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.label4.Location = new System.Drawing.Point(48, 86);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 18);
			this.label4.TabIndex = 46;
			this.label4.Text = "Datum stanja";
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Temperatura",
            "Tlo",
            "Zrak",
            "Stanje_ID"});
			this.comboBox1.Location = new System.Drawing.Point(517, 144);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(138, 21);
			this.comboBox1.TabIndex = 54;
			// 
			// btnpretragaK
			// 
			this.btnpretragaK.BackColor = System.Drawing.Color.LightCyan;
			this.btnpretragaK.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnpretragaK.Location = new System.Drawing.Point(193, 104);
			this.btnpretragaK.Name = "btnpretragaK";
			this.btnpretragaK.Size = new System.Drawing.Size(111, 29);
			this.btnpretragaK.TabIndex = 58;
			this.btnpretragaK.Text = "Pregled";
			this.btnpretragaK.UseVisualStyleBackColor = false;
			this.btnpretragaK.Click += new System.EventHandler(this.btnpretragaK_Click);
			// 
			// circularButton1
			// 
			this.circularButton1.BackColor = System.Drawing.Color.LightCyan;
			this.circularButton1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.circularButton1.Location = new System.Drawing.Point(678, 137);
			this.circularButton1.Name = "circularButton1";
			this.circularButton1.Size = new System.Drawing.Size(120, 31);
			this.circularButton1.TabIndex = 59;
			this.circularButton1.Text = "Pregled";
			this.circularButton1.UseVisualStyleBackColor = false;
			this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
			// 
			// Pregled
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(810, 404);
			this.Controls.Add(this.circularButton1);
			this.Controls.Add(this.btnpretragaK);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPretraga);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Temperatura);
			this.Controls.Add(this.listbKorisnici);
			this.Controls.Add(this.txtImeK);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Pregled";
			this.Text = "Pregled";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPretraga;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label Temperatura;
		private System.Windows.Forms.ListBox listbKorisnici;
		private System.Windows.Forms.TextBox txtImeK;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private RoundButtonDemo.CircularButton btnpretragaK;
		private RoundButtonDemo.CircularButton circularButton1;
	}
}