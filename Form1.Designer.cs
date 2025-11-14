using GetOrdinalRequeteSQL_2.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace GetOrdinalRequeteSQL_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.exportCS = new System.Windows.Forms.ToolStripStatusLabel();
            this.button7 = new System.Windows.Forms.Button();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ListeTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListeDB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatutConnexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.CommandeConnexion = new System.Windows.Forms.Button();
            this.MotDePasse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Utilisateur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InstanceSQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListeColonnes = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExportSQL = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusStrip2);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.txtSQL);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(741, 227);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(326, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concepteur C°";
            this.groupBox1.Visible = false;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportCS});
            this.statusStrip2.Location = new System.Drawing.Point(3, 325);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(320, 22);
            this.statusStrip2.TabIndex = 2;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // exportCS
            // 
            this.exportCS.Name = "exportCS";
            this.exportCS.Size = new System.Drawing.Size(305, 17);
            this.exportCS.Spring = true;
            this.exportCS.Text = "exportCS";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(225, 299);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Exporter en C°";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ExporterEnCS);
            // 
            // txtSQL
            // 
            this.txtSQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSQL.Location = new System.Drawing.Point(3, 15);
            this.txtSQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.ReadOnly = true;
            this.txtSQL.Size = new System.Drawing.Size(320, 279);
            this.txtSQL.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(738, 189);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ListeTables
            // 
            this.ListeTables.FormattingEnabled = true;
            this.ListeTables.Location = new System.Drawing.Point(96, 164);
            this.ListeTables.Name = "ListeTables";
            this.ListeTables.Size = new System.Drawing.Size(196, 21);
            this.ListeTables.TabIndex = 6;
            this.ListeTables.Visible = false;
            this.ListeTables.SelectedIndexChanged += new System.EventHandler(this.ListeTables_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tables";
            this.label1.Visible = false;
            // 
            // ListeDB
            // 
            this.ListeDB.Enabled = false;
            this.ListeDB.FormattingEnabled = true;
            this.ListeDB.Location = new System.Drawing.Point(96, 100);
            this.ListeDB.Name = "ListeDB";
            this.ListeDB.Size = new System.Drawing.Size(196, 21);
            this.ListeDB.TabIndex = 8;
            this.ListeDB.SelectedIndexChanged += new System.EventHandler(this.ListeDB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Base de donnée";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(142, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Énumérer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EnumererRequeteSQL);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 299);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Effacer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EffacerIntégrateurSQL);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(556, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 21);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sauvegarder tout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.SauvegarderTout);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(667, 5);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 21);
            this.button4.TabIndex = 4;
            this.button4.Text = "Quitter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Quitter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(608, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 26);
            this.button5.TabIndex = 2;
            this.button5.Text = "Copier en mémoire";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CopierEnMemoire);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusStrip1);
            this.groupBox2.Controls.Add(this.CommandeConnexion);
            this.groupBox2.Controls.Add(this.ListeTables);
            this.groupBox2.Controls.Add(this.ListeDB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.MotDePasse);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Utilisateur);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.InstanceSQL);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 224);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations Serveur SQL";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatutConnexion});
            this.statusStrip1.Location = new System.Drawing.Point(3, 199);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(323, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatutConnexion
            // 
            this.StatutConnexion.Name = "StatutConnexion";
            this.StatutConnexion.Size = new System.Drawing.Size(308, 17);
            this.StatutConnexion.Spring = true;
            // 
            // CommandeConnexion
            // 
            this.CommandeConnexion.Location = new System.Drawing.Point(207, 128);
            this.CommandeConnexion.Name = "CommandeConnexion";
            this.CommandeConnexion.Size = new System.Drawing.Size(85, 23);
            this.CommandeConnexion.TabIndex = 9;
            this.CommandeConnexion.Text = "Connexion";
            this.CommandeConnexion.UseVisualStyleBackColor = true;
            this.CommandeConnexion.Click += new System.EventHandler(this.CommandeConnexion_Click);
            // 
            // MotDePasse
            // 
            this.MotDePasse.Location = new System.Drawing.Point(96, 74);
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.PasswordChar = '€';
            this.MotDePasse.Size = new System.Drawing.Size(196, 20);
            this.MotDePasse.TabIndex = 5;
            this.MotDePasse.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mot de passe";
            this.label5.Visible = false;
            // 
            // Utilisateur
            // 
            this.Utilisateur.Location = new System.Drawing.Point(96, 48);
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.Size = new System.Drawing.Size(196, 20);
            this.Utilisateur.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Usager";
            // 
            // InstanceSQL
            // 
            this.InstanceSQL.Location = new System.Drawing.Point(96, 22);
            this.InstanceSQL.Name = "InstanceSQL";
            this.InstanceSQL.Size = new System.Drawing.Size(196, 20);
            this.InstanceSQL.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Instance SQL";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListeColonnes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 614);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // ListeColonnes
            // 
            this.ListeColonnes.BackColor = System.Drawing.SystemColors.Control;
            this.ListeColonnes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeColonnes.FormattingEnabled = true;
            this.ListeColonnes.Location = new System.Drawing.Point(0, 0);
            this.ListeColonnes.Name = "ListeColonnes";
            this.ListeColonnes.Size = new System.Drawing.Size(329, 614);
            this.ListeColonnes.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 616);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(331, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 227);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::GetOrdinalRequeteSQL_2.Properties.Resources._00000031;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(331, 586);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 30);
            this.panel4.TabIndex = 8;
            this.panel4.Tag = "Patrice Waechter-Ebling 2025";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusStrip3);
            this.groupBox3.Controls.Add(this.ExportSQL);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(336, 227);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(399, 349);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Intégrateur SQL ";
            this.groupBox3.Visible = false;
            // 
            // statusStrip3
            // 
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip3.Location = new System.Drawing.Point(3, 325);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(393, 22);
            this.statusStrip3.TabIndex = 2;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(378, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "exportSQL";
            // 
            // ExportSQL
            // 
            this.ExportSQL.Location = new System.Drawing.Point(218, 299);
            this.ExportSQL.Name = "ExportSQL";
            this.ExportSQL.Size = new System.Drawing.Size(93, 23);
            this.ExportSQL.TabIndex = 1;
            this.ExportSQL.Text = "Exporter en SQL";
            this.ExportSQL.UseVisualStyleBackColor = true;
            this.ExportSQL.Click += new System.EventHandler(this.ExportSQL_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 279);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 616);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetOrdinalRequeteSQL v:2.00";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal GroupBox groupBox2;
        internal Label label3;
        internal TextBox Utilisateur;
        internal Label label4;
        internal TextBox InstanceSQL;
        internal TextBox MotDePasse;
        internal Label label5;
        internal Button CommandeConnexion;
        internal GroupBox groupBox1;
        internal TextBox txtSQL;
        internal Button button1;
        internal Button button2;
        internal Button button3;
        internal Button button4;
        internal Button button5;
        internal Label label1;
        internal Label label2;
        internal ComboBox ListeTables;
        internal ComboBox ListeDB;
        internal Panel panel1;
        internal StatusStrip statusStrip1;
        internal ToolStripStatusLabel StatutConnexion;
        internal ListBox ListeColonnes;
        internal ListView listView1;
        internal Panel panel2;
        internal Panel panel3;
        internal Panel panel4;
        internal Button button7;
        internal StatusStrip statusStrip2;
        internal ToolStripStatusLabel exportCS;
        internal GroupBox groupBox3;
        internal StatusStrip statusStrip3;
        internal ToolStripStatusLabel toolStripStatusLabel1;
        internal Button ExportSQL;
        internal TextBox textBox1;
    }
}

