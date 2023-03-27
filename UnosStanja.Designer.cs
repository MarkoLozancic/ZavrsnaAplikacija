namespace ZavrsnaAplikacija
{
	partial class txtTemp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtTemp));
			this.btnUnosStanja = new RoundButtonDemo.CircularButton();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txtTlo = new System.Windows.Forms.TextBox();
			this.txtZrak = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnUnosStanja
			// 
			this.btnUnosStanja.BackColor = System.Drawing.Color.LightCyan;
			this.btnUnosStanja.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUnosStanja.Location = new System.Drawing.Point(113, 296);
			this.btnUnosStanja.Name = "btnUnosStanja";
			this.btnUnosStanja.Size = new System.Drawing.Size(147, 42);
			this.btnUnosStanja.TabIndex = 19;
			this.btnUnosStanja.Text = "Unos";
			this.btnUnosStanja.UseVisualStyleBackColor = false;
			this.btnUnosStanja.Click += new System.EventHandler(this.btnUnosStanja_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Onyx", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(34, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 16);
			this.label4.TabIndex = 20;
			this.label4.Text = "Temperatura zraka:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Onyx", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(34, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 16);
			this.label5.TabIndex = 21;
			this.label5.Text = "Vlažnost tla:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Onyx", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(34, 211);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(111, 16);
			this.label6.TabIndex = 22;
			this.label6.Text = "Vlažnost zraka:";
			// 
			// label2
			// 
			this.label2.AllowDrop = true;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(412, 38);
			this.label2.TabIndex = 23;
			this.label2.Text = "Manualni unos stanja senzora";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(193, 97);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(136, 20);
			this.textBox1.TabIndex = 24;
			// 
			// txtTlo
			// 
			this.txtTlo.Location = new System.Drawing.Point(180, 152);
			this.txtTlo.Name = "txtTlo";
			this.txtTlo.Size = new System.Drawing.Size(136, 20);
			this.txtTlo.TabIndex = 25;
			// 
			// txtZrak
			// 
			this.txtZrak.Location = new System.Drawing.Point(168, 207);
			this.txtZrak.Name = "txtZrak";
			this.txtZrak.Size = new System.Drawing.Size(136, 20);
			this.txtZrak.TabIndex = 26;
			// 
			// txtTemp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(424, 376);
			this.Controls.Add(this.txtZrak);
			this.Controls.Add(this.txtTlo);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnUnosStanja);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "txtTemp";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RoundButtonDemo.CircularButton btnUnosStanja;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txtTlo;
		private System.Windows.Forms.TextBox txtZrak;
	}
}