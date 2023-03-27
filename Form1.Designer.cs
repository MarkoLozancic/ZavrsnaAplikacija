namespace ZavrsnaAplikacija
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblTemp = new System.Windows.Forms.Label();
			this.lblTlo = new System.Windows.Forms.Label();
			this.lblZrak = new System.Windows.Forms.Label();
			this.lblVentil = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.lbl = new System.Windows.Forms.Label();
			this.btnUnosStanja = new RoundButtonDemo.CircularButton();
			this.circularButton1 = new RoundButtonDemo.CircularButton();
			this.btnPretraga = new RoundButtonDemo.CircularButton();
			this.label8 = new System.Windows.Forms.Label();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(32, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Stanje ventila:";
			// 
			// label2
			// 
			this.label2.AllowDrop = true;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(160, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(459, 38);
			this.label2.TabIndex = 2;
			this.label2.Text = "Inteligentni sustav navodnjavanja";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(447, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "Stanje parametara:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Onyx", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(362, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Temperatura zraka:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Onyx", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(411, 251);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 16);
			this.label5.TabIndex = 5;
			this.label5.Text = "Vlažnost tla:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Onyx", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(391, 292);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(111, 16);
			this.label6.TabIndex = 6;
			this.label6.Text = "Vlažnost zraka:";
			// 
			// lblTemp
			// 
			this.lblTemp.AutoSize = true;
			this.lblTemp.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTemp.Location = new System.Drawing.Point(525, 201);
			this.lblTemp.Name = "lblTemp";
			this.lblTemp.Size = new System.Drawing.Size(62, 28);
			this.lblTemp.TabIndex = 7;
			this.lblTemp.Text = "_____";
			// 
			// lblTlo
			// 
			this.lblTlo.AutoSize = true;
			this.lblTlo.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTlo.Location = new System.Drawing.Point(525, 251);
			this.lblTlo.Name = "lblTlo";
			this.lblTlo.Size = new System.Drawing.Size(62, 28);
			this.lblTlo.TabIndex = 8;
			this.lblTlo.Text = "_____";
			// 
			// lblZrak
			// 
			this.lblZrak.AutoSize = true;
			this.lblZrak.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblZrak.Location = new System.Drawing.Point(525, 283);
			this.lblZrak.Name = "lblZrak";
			this.lblZrak.Size = new System.Drawing.Size(62, 28);
			this.lblZrak.TabIndex = 9;
			this.lblZrak.Text = "_____";
			// 
			// lblVentil
			// 
			this.lblVentil.AutoSize = true;
			this.lblVentil.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVentil.Location = new System.Drawing.Point(196, 95);
			this.lblVentil.Name = "lblVentil";
			this.lblVentil.Size = new System.Drawing.Size(99, 28);
			this.lblVentil.TabIndex = 10;
			this.lblVentil.Text = "Zatvoren";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(48, 325);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(270, 21);
			this.label7.TabIndex = 11;
			this.label7.Text = "Pregled prošlih stanja senzora:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(627, 123);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(142, 51);
			this.richTextBox1.TabIndex = 12;
			this.richTextBox1.Text = "";
			// 
			// lbl
			// 
			this.lbl.AutoSize = true;
			this.lbl.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl.Location = new System.Drawing.Point(372, 362);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(102, 21);
			this.lbl.TabIndex = 13;
			this.lbl.Text = "Preporuka:";
			// 
			// btnUnosStanja
			// 
			this.btnUnosStanja.BackColor = System.Drawing.Color.LightCyan;
			this.btnUnosStanja.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUnosStanja.Location = new System.Drawing.Point(627, 304);
			this.btnUnosStanja.Name = "btnUnosStanja";
			this.btnUnosStanja.Size = new System.Drawing.Size(147, 42);
			this.btnUnosStanja.TabIndex = 18;
			this.btnUnosStanja.Text = "Unos stanja";
			this.btnUnosStanja.UseVisualStyleBackColor = false;
			this.btnUnosStanja.Click += new System.EventHandler(this.btnUnosStanja_Click);
			// 
			// circularButton1
			// 
			this.circularButton1.BackColor = System.Drawing.Color.LightCyan;
			this.circularButton1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.circularButton1.Location = new System.Drawing.Point(86, 362);
			this.circularButton1.Name = "circularButton1";
			this.circularButton1.Size = new System.Drawing.Size(147, 42);
			this.circularButton1.TabIndex = 16;
			this.circularButton1.Text = "Pregled";
			this.circularButton1.UseVisualStyleBackColor = false;
			this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
			// 
			// btnPretraga
			// 
			this.btnPretraga.BackColor = System.Drawing.Color.LightCyan;
			this.btnPretraga.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPretraga.Location = new System.Drawing.Point(68, 157);
			this.btnPretraga.Name = "btnPretraga";
			this.btnPretraga.Size = new System.Drawing.Size(154, 51);
			this.btnPretraga.TabIndex = 15;
			this.btnPretraga.Text = "Pali/Gasi";
			this.btnPretraga.UseVisualStyleBackColor = false;
			this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Onyx", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label8.Location = new System.Drawing.Point(624, 95);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(135, 16);
			this.label8.TabIndex = 19;
			this.label8.Text = "Veza sa sustavom:";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(480, 364);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(251, 94);
			this.richTextBox2.TabIndex = 20;
			this.richTextBox2.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(799, 482);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnUnosStanja);
			this.Controls.Add(this.circularButton1);
			this.Controls.Add(this.btnPretraga);
			this.Controls.Add(this.lbl);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblVentil);
			this.Controls.Add(this.lblZrak);
			this.Controls.Add(this.lblTlo);
			this.Controls.Add(this.lblTemp);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblTlo;
        private System.Windows.Forms.Label lblZrak;
        private System.Windows.Forms.Label lblVentil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl;
        private RoundButtonDemo.CircularButton btnPretraga;
        private RoundButtonDemo.CircularButton circularButton1;
		private RoundButtonDemo.CircularButton btnUnosStanja;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RichTextBox richTextBox2;
	}
}

