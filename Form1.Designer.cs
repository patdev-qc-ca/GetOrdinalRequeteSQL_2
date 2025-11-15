using System.Windows.Forms;

namespace GetOrdinalRequeteSQL_II
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            groupBox1 = new System.Windows.Forms.GroupBox();
            statusStrip2 = new System.Windows.Forms.StatusStrip();
            exportCS = new System.Windows.Forms.ToolStripStatusLabel();
            button7 = new System.Windows.Forms.Button();
            txtSQL = new System.Windows.Forms.TextBox();
            listView1 = new System.Windows.Forms.ListView();
            ListeTables = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            ListeDB = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            StatutConnexion = new System.Windows.Forms.ToolStripStatusLabel();
            CommandeConnexion = new System.Windows.Forms.Button();
            MotDePasse = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            Utilisateur = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            InstanceSQL = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            ListeColonnes = new System.Windows.Forms.ListBox();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            groupBox3 = new System.Windows.Forms.GroupBox();
            statusStrip3 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ExportSQL = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            statusStrip2.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox3.SuspendLayout();
            statusStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(statusStrip2);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(txtSQL);
            groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            groupBox1.Location = new System.Drawing.Point(741, 227);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(326, 349);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Concepteur C°";
            groupBox1.Visible = false;
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
            // button7
            // 
            button7.Location = new System.Drawing.Point(225, 299);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(93, 23);
            button7.TabIndex = 1;
            button7.Text = "Exporter en C°";
            button7.UseVisualStyleBackColor = true;
            button7.Click += new System.EventHandler(ExporterEnCS);
            // 
            // txtSQL
            // 
            txtSQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSQL.Dock = System.Windows.Forms.DockStyle.Top;
            txtSQL.Location = new System.Drawing.Point(3, 15);
            txtSQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSQL.Multiline = true;
            txtSQL.Name = "txtSQL";
            txtSQL.ReadOnly = true;
            txtSQL.Size = new System.Drawing.Size(320, 279);
            txtSQL.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Dock = System.Windows.Forms.DockStyle.Top;
            listView1.HideSelection = false;
            listView1.Location = new System.Drawing.Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(738, 189);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ListeTables
            // 
            ListeTables.FormattingEnabled = true;
            ListeTables.Location = new System.Drawing.Point(96, 164);
            ListeTables.Name = "ListeTables";
            ListeTables.Size = new System.Drawing.Size(196, 21);
            ListeTables.TabIndex = 6;
            ListeTables.Visible = false;
            ListeTables.SelectedIndexChanged += new System.EventHandler(ListeTables_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 167);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 13);
            label1.TabIndex = 5;
            label1.Text = "Tables";
            label1.Visible = false;
            // 
            // ListeDB
            // 
            ListeDB.Enabled = false;
            ListeDB.FormattingEnabled = true;
            ListeDB.Location = new System.Drawing.Point(96, 100);
            ListeDB.Name = "ListeDB";
            ListeDB.Size = new System.Drawing.Size(196, 21);
            ListeDB.TabIndex = 8;
            ListeDB.SelectedIndexChanged += new System.EventHandler(ListeDB_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 13);
            label2.TabIndex = 7;
            label2.Text = "Base de donnée";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new System.Drawing.Point(142, 298);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(70, 24);
            button1.TabIndex = 1;
            button1.Text = "Énumérer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(EnumererRequeteSQL);
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(317, 299);
            button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(70, 23);
            button2.TabIndex = 2;
            button2.Text = "Effacer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(EffacerIntégrateurSQL);
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(556, 5);
            button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(107, 21);
            button3.TabIndex = 3;
            button3.Text = "Sauvegarder tout";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += new System.EventHandler(SauvegarderTout);
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(667, 5);
            button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(70, 21);
            button4.TabIndex = 4;
            button4.Text = "Quitter";
            button4.UseVisualStyleBackColor = true;
            button4.Click += new System.EventHandler(Quitter);
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(608, 195);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(127, 26);
            button5.TabIndex = 2;
            button5.Text = "Copier en mémoire";
            button5.UseVisualStyleBackColor = true;
            button5.Click += new System.EventHandler(CopierEnMemoire);
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
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            StatutConnexion});
            statusStrip1.Location = new System.Drawing.Point(3, 199);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(323, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatutConnexion
            // 
            StatutConnexion.Name = "StatutConnexion";
            StatutConnexion.Size = new System.Drawing.Size(308, 17);
            StatutConnexion.Spring = true;
            // 
            // CommandeConnexion
            // 
            CommandeConnexion.Location = new System.Drawing.Point(207, 128);
            CommandeConnexion.Name = "CommandeConnexion";
            CommandeConnexion.Size = new System.Drawing.Size(85, 23);
            CommandeConnexion.TabIndex = 9;
            CommandeConnexion.Text = "Connexion";
            CommandeConnexion.UseVisualStyleBackColor = true;
            CommandeConnexion.Click += new System.EventHandler(CommandeConnexion_Click);
            // 
            // MotDePasse
            // 
            MotDePasse.Location = new System.Drawing.Point(96, 74);
            MotDePasse.Name = "MotDePasse";
            MotDePasse.PasswordChar = '€';
            MotDePasse.Size = new System.Drawing.Size(196, 20);
            MotDePasse.TabIndex = 5;
            MotDePasse.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 76);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(71, 13);
            label5.TabIndex = 4;
            label5.Text = "Mot de passe";
            label5.Visible = false;
            // 
            // Utilisateur
            // 
            Utilisateur.Location = new System.Drawing.Point(96, 48);
            Utilisateur.Name = "Utilisateur";
            Utilisateur.Size = new System.Drawing.Size(196, 20);
            Utilisateur.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 50);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 13);
            label4.TabIndex = 2;
            label4.Text = "Usager";
            // 
            // InstanceSQL
            // 
            InstanceSQL.Location = new System.Drawing.Point(96, 22);
            InstanceSQL.Name = "InstanceSQL";
            InstanceSQL.Size = new System.Drawing.Size(196, 20);
            InstanceSQL.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 13);
            label3.TabIndex = 0;
            label3.Text = "Instance SQL";
            // 
            // panel1
            // 
            panel1.Controls.Add(ListeColonnes);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(329, 614);
            panel1.TabIndex = 6;
            panel1.Visible = false;
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
            panel3.Controls.Add(listView1);
            panel3.Controls.Add(button5);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(331, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(740, 227);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
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
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "GetOrdinalRequeteSQL v:2.00";
            Load += new System.EventHandler(Chargement);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip2.ResumeLayout(false);
            statusStrip2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            statusStrip3.ResumeLayout(false);
            statusStrip3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        internal static GroupBox groupBox2;
        internal static Label label3;
        internal static TextBox Utilisateur;
        internal static Label label4;
        internal static TextBox InstanceSQL;
        internal static TextBox MotDePasse;
        internal static Label label5;
        internal static Button CommandeConnexion;
        internal static GroupBox groupBox1;
        internal static TextBox txtSQL;
        internal static Button button1;
        internal static Button button2;
        internal static Button button3;
        internal static Button button4;
        internal static Button button5;
        internal static Label label1;
        internal static Label label2;
        internal static ComboBox ListeTables;
        internal static ComboBox ListeDB;
        internal static Panel panel1;
        internal static StatusStrip statusStrip1;
        internal static ToolStripStatusLabel StatutConnexion;
        internal static ListBox ListeColonnes;
        internal static ListView listView1;
        internal static Panel panel2;
        internal static Panel panel3;
        internal static Panel panel4;
        internal static Button button7;
        internal static StatusStrip statusStrip2;
        internal static ToolStripStatusLabel exportCS;
        internal static GroupBox groupBox3;
        internal static StatusStrip statusStrip3;
        internal static ToolStripStatusLabel toolStripStatusLabel1;
        internal static Button ExportSQL;
        internal static TextBox textBox1;
    }
}
