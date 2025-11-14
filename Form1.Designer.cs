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
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtSQL = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.txtSQL);
            this.groupBox1.Location = new System.Drawing.Point(328, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(718, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(712, 217);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtSQL
            // 
            this.txtSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSQL.Location = new System.Drawing.Point(0, 306);
            this.txtSQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(365, 235);
            this.txtSQL.TabIndex = 0;
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
            this.button1.Location = new System.Drawing.Point(702, 580);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Énumérer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(776, 580);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 19);
            this.button2.TabIndex = 2;
            this.button2.Text = "Effacer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(852, 580);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 19);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sauvegarder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(934, 580);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 19);
            this.button4.TabIndex = 4;
            this.button4.Text = "Quitter";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(888, 239);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 20);
            this.button5.TabIndex = 2;
            this.button5.Text = "Copier en mémoire";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(statusStrip1);
            groupBox2.Controls.Add(CommandeConnexion);
            groupBox2.Controls.Add(ListeTables);
            groupBox2.Controls.Add(ListeDB);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(MotDePasse);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(Utilisateur);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(InstanceSQL);
            groupBox2.Controls.Add(label3);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox2.Location = new System.Drawing.Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(329, 224);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informations Serveur SQL";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatutConnexion});
            this.statusStrip1.Location = new System.Drawing.Point(3, 199);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(303, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatutConnexion
            // 
            this.StatutConnexion.Name = "StatutConnexion";
            this.StatutConnexion.Size = new System.Drawing.Size(288, 17);
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
            this.panel1.Location = new System.Drawing.Point(12, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 319);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // ListeColonnes
            // 
            ListeColonnes.BackColor = System.Drawing.SystemColors.Control;
            ListeColonnes.Dock = System.Windows.Forms.DockStyle.Fill;
            ListeColonnes.FormattingEnabled = true;
            ListeColonnes.Location = new System.Drawing.Point(0, 0);
            ListeColonnes.Name = "ListeColonnes";
            ListeColonnes.Size = new System.Drawing.Size(329, 614);
            ListeColonnes.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(panel1);
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(331, 616);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(listView1);
            panel3.Controls.Add(button5);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(331, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(740, 227);
            panel3.TabIndex = 3;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(498, 195);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(104, 26);
            button6.TabIndex = 3;
            button6.Text = "Réinitialiser";
            button6.UseVisualStyleBackColor = true;
            button6.Click += new System.EventHandler(button6_Click);
            // 
            // panel4
            // 
            panel4.BackgroundImage = global::GetOrdinalRequeteSQL_2.Properties.Resources._00000031;
            panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel4.Location = new System.Drawing.Point(331, 586);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(740, 30);
            panel4.TabIndex = 8;
            panel4.Tag = "Patrice Waechter-Ebling 2025";
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(225, 299);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(93, 23);
            button7.TabIndex = 1;
            button7.Text = "Exporter en C°";
            button7.UseVisualStyleBackColor = true;
            button7.Click += new System.EventHandler(button7_Click);
            // 
            // statusStrip2
            // 
            statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            exportCS});
            statusStrip2.Location = new System.Drawing.Point(3, 325);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new System.Drawing.Size(320, 22);
            statusStrip2.TabIndex = 2;
            statusStrip2.Text = "statusStrip2";
            // 
            // exportCS
            // 
            exportCS.Name = "exportCS";
            exportCS.Size = new System.Drawing.Size(305, 17);
            exportCS.Spring = true;
            exportCS.Text = "exportCS";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(statusStrip3);
            groupBox3.Controls.Add(ExportSQL);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox3.Location = new System.Drawing.Point(336, 227);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox3.Size = new System.Drawing.Size(399, 349);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Intégrateur SQL ";
            groupBox3.Visible = false;
            // 
            // statusStrip3
            // 
            statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1});
            statusStrip3.Location = new System.Drawing.Point(3, 325);
            statusStrip3.Name = "statusStrip3";
            statusStrip3.Size = new System.Drawing.Size(393, 22);
            statusStrip3.TabIndex = 2;
            statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(378, 17);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "exportSQL";
            // 
            // ExportSQL
            // 
            ExportSQL.Location = new System.Drawing.Point(218, 299);
            ExportSQL.Name = "ExportSQL";
            ExportSQL.Size = new System.Drawing.Size(93, 23);
            ExportSQL.TabIndex = 1;
            ExportSQL.Text = "Exporter en SQL";
            ExportSQL.UseVisualStyleBackColor = true;
            ExportSQL.Click += new System.EventHandler(ExportSQL_Click);
            // 
            // textBox1
            // 
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            textBox1.Location = new System.Drawing.Point(3, 15);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(393, 279);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1071, 616);
            Controls.Add(groupBox3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "GetOrdinalRequeteSQL v:2.00";
            Load += new System.EventHandler(Form1_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            statusStrip3.ResumeLayout(false);
            statusStrip3.PerformLayout();
            ResumeLayout(false);

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
    }
}

