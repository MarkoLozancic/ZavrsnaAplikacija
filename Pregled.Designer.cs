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
            this.listbZapisi = new System.Windows.Forms.ListBox();
            this.btnPretraga = new RoundButtonDemo.CircularButton();
            this.btnPretraga2 = new RoundButtonDemo.CircularButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtUvjet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listbZapisi
            // 
            this.listbZapisi.FormattingEnabled = true;
            this.listbZapisi.Location = new System.Drawing.Point(41, 122);
            this.listbZapisi.Name = "listbZapisi";
            this.listbZapisi.Size = new System.Drawing.Size(455, 212);
            this.listbZapisi.TabIndex = 0;
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.Color.LightCyan;
            this.btnPretraga.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga.Location = new System.Drawing.Point(282, 63);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(111, 33);
            this.btnPretraga.TabIndex = 1;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = false;
            // 
            // btnPretraga2
            // 
            this.btnPretraga2.BackColor = System.Drawing.Color.LightCyan;
            this.btnPretraga2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraga2.Location = new System.Drawing.Point(753, 70);
            this.btnPretraga2.Name = "btnPretraga2";
            this.btnPretraga2.Size = new System.Drawing.Size(107, 36);
            this.btnPretraga2.TabIndex = 2;
            this.btnPretraga2.Text = "Pretraga2";
            this.btnPretraga2.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(593, 122);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(267, 212);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(72, 70);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(169, 20);
            this.txtDatum.TabIndex = 4;
            // 
            // txtUvjet
            // 
            this.txtUvjet.Location = new System.Drawing.Point(566, 79);
            this.txtUvjet.Name = "txtUvjet";
            this.txtUvjet.Size = new System.Drawing.Size(163, 20);
            this.txtUvjet.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Detaljan pregled zapisa";
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(899, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUvjet);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnPretraga2);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.listbZapisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pregled";
            this.Text = "Pregled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbZapisi;
        private RoundButtonDemo.CircularButton btnPretraga;
        private RoundButtonDemo.CircularButton btnPretraga2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtUvjet;
        private System.Windows.Forms.Label label2;
    }
}