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
            groupBox1 = new System.Windows.Forms.GroupBox();
            ListBox1 = new System.Windows.Forms.ListBox();
            txtSQL = new System.Windows.Forms.TextBox();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ListBox1);
            groupBox1.Controls.Add(txtSQL);
            groupBox1.Location = new System.Drawing.Point(328, 5);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(718, 555);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // ListBox1
            // 
            ListBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 21;
            ListBox1.Location = new System.Drawing.Point(385, 30);
            ListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new System.Drawing.Size(400, 277);
            ListBox1.TabIndex = 1;
            // 
            // txtSQL
            // 
            txtSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSQL.Location = new System.Drawing.Point(5, 72);
            txtSQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSQL.Multiline = true;
            txtSQL.Name = "txtSQL";
            txtSQL.Size = new System.Drawing.Size(365, 235);
            txtSQL.TabIndex = 0;
            // 
            // ListeTables
            // 
            ListeTables.FormattingEnabled = true;
            ListeTables.Location = new System.Drawing.Point(96, 164);
            ListeTables.Name = "ListeTables";
            ListeTables.Size = new System.Drawing.Size(196, 21);
            ListeTables.TabIndex = 6;
            ListeTables.Visible = false;
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
            button1.Location = new System.Drawing.Point(702, 580);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(70, 19);
            button1.TabIndex = 1;
            button1.Text = "Énumérer";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(776, 580);
            button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(70, 19);
            button2.TabIndex = 2;
            button2.Text = "Effacer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(852, 580);
            button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(78, 19);
            button3.TabIndex = 3;
            button3.Text = "Sauvegarder";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(934, 580);
            button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(70, 19);
            button4.TabIndex = 4;
            button4.Text = "Quitter";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(888, 239);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(147, 20);
            button5.TabIndex = 2;
            button5.Text = "Copier en mémoire";
            button5.UseVisualStyleBackColor = true;
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
            groupBox2.Location = new System.Drawing.Point(13, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(309, 224);
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
            statusStrip1.Size = new System.Drawing.Size(303, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatutConnexion
            // 
            StatutConnexion.Name = "StatutConnexion";
            StatutConnexion.Size = new System.Drawing.Size(288, 17);
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
            panel1.Location = new System.Drawing.Point(54, 462);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(200, 100);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1071, 616);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
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
        internal static ListBox ListBox1;
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
    }
}

