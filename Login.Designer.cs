namespace ZavrsnaAplikacija
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnPretraga = new RoundButtonDemo.CircularButton();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(254, 235);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(141, 20);
			this.txtPassword.TabIndex = 40;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(254, 193);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(141, 20);
			this.txtUsername.TabIndex = 39;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(84, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(346, 21);
			this.label1.TabIndex = 38;
			this.label1.Text = "Prijava u aplikaciju ( admin ili korisnik )";
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl.Location = new System.Drawing.Point(104, 233);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(80, 21);
			this.lbl.TabIndex = 36;
			this.lbl.Text = "Lozinka:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(84, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 21);
			this.label3.TabIndex = 35;
			this.label3.Text = "Korisnicko ime:";
			// 
			// label2
			// 
			this.label2.AllowDrop = true;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(101, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(459, 38);
			this.label2.TabIndex = 34;
			this.label2.Text = "Inteligentni sustav navodnjavanja";
			// 
			// btnPretraga
			// 
			this.btnPretraga.BackColor = System.Drawing.Color.LightCyan;
			this.btnPretraga.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPretraga.Location = new System.Drawing.Point(388, 306);
			this.btnPretraga.Name = "btnPretraga";
			this.btnPretraga.Size = new System.Drawing.Size(154, 51);
			this.btnPretraga.TabIndex = 37;
			this.btnPretraga.Text = "Prijavi se:";
			this.btnPretraga.UseVisualStyleBackColor = false;
			this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(623, 385);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnPretraga);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label1;
		private RoundButtonDemo.CircularButton btnPretraga;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}