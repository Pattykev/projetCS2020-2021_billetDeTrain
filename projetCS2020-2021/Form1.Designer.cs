namespace projetCS2020_2021
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPrixttc = new System.Windows.Forms.TextBox();
            this.txtTva = new System.Windows.Forms.TextBox();
            this.txtPrixht = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrixbase = new System.Windows.Forms.TextBox();
            this.cb = new System.Windows.Forms.ComboBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.Controls.Add(this.btnR);
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Location = new System.Drawing.Point(177, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 171);
            this.panel1.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(53, 125);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(108, 33);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(53, 73);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(108, 34);
            this.btnR.TabIndex = 1;
            this.btnR.Text = "Rénitialiser";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(53, 20);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(108, 38);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculer";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPrixttc);
            this.panel2.Controls.Add(this.txtTva);
            this.panel2.Controls.Add(this.txtPrixht);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(79, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 222);
            this.panel2.TabIndex = 1;
            // 
            // txtPrixttc
            // 
            this.txtPrixttc.Location = new System.Drawing.Point(180, 149);
            this.txtPrixttc.Multiline = true;
            this.txtPrixttc.Name = "txtPrixttc";
            this.txtPrixttc.Size = new System.Drawing.Size(172, 34);
            this.txtPrixttc.TabIndex = 5;
            // 
            // txtTva
            // 
            this.txtTva.Location = new System.Drawing.Point(180, 85);
            this.txtTva.Multiline = true;
            this.txtTva.Name = "txtTva";
            this.txtTva.Size = new System.Drawing.Size(172, 32);
            this.txtTva.TabIndex = 4;
            this.txtTva.Text = "0.2";
            this.txtTva.TextChanged += new System.EventHandler(this.txtTva_TextChanged);
            // 
            // txtPrixht
            // 
            this.txtPrixht.Location = new System.Drawing.Point(180, 29);
            this.txtPrixht.Multiline = true;
            this.txtPrixht.Name = "txtPrixht";
            this.txtPrixht.Size = new System.Drawing.Size(172, 32);
            this.txtPrixht.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "TVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix TTC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prix HT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix de base";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type du billet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Réduction";
            // 
            // txtPrixbase
            // 
            this.txtPrixbase.Location = new System.Drawing.Point(259, 7);
            this.txtPrixbase.Multiline = true;
            this.txtPrixbase.Name = "txtPrixbase";
            this.txtPrixbase.Size = new System.Drawing.Size(172, 29);
            this.txtPrixbase.TabIndex = 6;
            this.txtPrixbase.Text = "0";
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "Pas de réduction",
            "Carte jeune",
            "Carte adulte",
            "Carte famille"});
            this.cb.Location = new System.Drawing.Point(259, 104);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(172, 24);
            this.cb.TabIndex = 8;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Items.AddRange(new object[] {
            "Premiere classe",
            "Deuxieme classe"});
            this.listbox.Location = new System.Drawing.Point(259, 53);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(172, 36);
            this.listbox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 567);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.txtPrixbase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Billet de train";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPrixttc;
        private System.Windows.Forms.TextBox txtTva;
        private System.Windows.Forms.TextBox txtPrixht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrixbase;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.ListBox listbox;
    }
}

