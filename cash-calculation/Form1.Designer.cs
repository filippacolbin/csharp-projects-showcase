namespace VaxelRaknare1
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
            this.lblPris = new System.Windows.Forms.Label();
            this.txtPris = new System.Windows.Forms.TextBox();
            this.lblBetalt = new System.Windows.Forms.Label();
            this.txtBetalt = new System.Windows.Forms.TextBox();
            this.btnBerakna = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.btnRensa = new System.Windows.Forms.Button();
            this.btnAvsluta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPris
            // 
            this.lblPris.AutoSize = true;
            this.lblPris.Location = new System.Drawing.Point(54, 36);
            this.lblPris.Name = "lblPris";
            this.lblPris.Size = new System.Drawing.Size(55, 13);
            this.lblPris.TabIndex = 0;
            this.lblPris.Text = "Ange Pris:";
            // 
            // txtPris
            // 
            this.txtPris.Location = new System.Drawing.Point(57, 52);
            this.txtPris.Name = "txtPris";
            this.txtPris.Size = new System.Drawing.Size(198, 20);
            this.txtPris.TabIndex = 1;
            // 
            // lblBetalt
            // 
            this.lblBetalt.AutoSize = true;
            this.lblBetalt.Location = new System.Drawing.Point(54, 95);
            this.lblBetalt.Name = "lblBetalt";
            this.lblBetalt.Size = new System.Drawing.Size(37, 13);
            this.lblBetalt.TabIndex = 2;
            this.lblBetalt.Text = "Betalt:";
            // 
            // txtBetalt
            // 
            this.txtBetalt.Location = new System.Drawing.Point(57, 111);
            this.txtBetalt.Name = "txtBetalt";
            this.txtBetalt.Size = new System.Drawing.Size(198, 20);
            this.txtBetalt.TabIndex = 3;
            // 
            // btnBerakna
            // 
            this.btnBerakna.Location = new System.Drawing.Point(126, 146);
            this.btnBerakna.Name = "btnBerakna";
            this.btnBerakna.Size = new System.Drawing.Size(75, 23);
            this.btnBerakna.TabIndex = 4;
            this.btnBerakna.Text = "Beräkna växel";
            this.btnBerakna.UseVisualStyleBackColor = true;
            this.btnBerakna.Click += new System.EventHandler(this.btnBerakna_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResultat.Location = new System.Drawing.Point(57, 175);
            this.txtResultat.Multiline = true;
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ReadOnly = true;
            this.txtResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultat.Size = new System.Drawing.Size(208, 48);
            this.txtResultat.TabIndex = 5;
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(57, 229);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(75, 23);
            this.btnRensa.TabIndex = 6;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // btnAvsluta
            // 
            this.btnAvsluta.Location = new System.Drawing.Point(190, 229);
            this.btnAvsluta.Name = "btnAvsluta";
            this.btnAvsluta.Size = new System.Drawing.Size(75, 23);
            this.btnAvsluta.TabIndex = 7;
            this.btnAvsluta.Text = "Avsluta";
            this.btnAvsluta.UseVisualStyleBackColor = true;
            this.btnAvsluta.Click += new System.EventHandler(this.btnAvsluta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 295);
            this.Controls.Add(this.btnAvsluta);
            this.Controls.Add(this.btnRensa);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.btnBerakna);
            this.Controls.Add(this.txtBetalt);
            this.Controls.Add(this.lblBetalt);
            this.Controls.Add(this.txtPris);
            this.Controls.Add(this.lblPris);
            this.Name = "Form1";
            this.Text = "Växelräknare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPris;
        private System.Windows.Forms.TextBox txtPris;
        private System.Windows.Forms.Label lblBetalt;
        private System.Windows.Forms.TextBox txtBetalt;
        private System.Windows.Forms.Button btnBerakna;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.Button btnAvsluta;
    }
}

