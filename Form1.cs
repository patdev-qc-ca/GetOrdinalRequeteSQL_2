using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
namespace GetOrdinalRequeteSQL_II
{
    public partial class Form1 : Form
    {
        public static string connectionString { get; set; } = string.Empty;
        internal static string StringSQL { get; set; } = string.Empty;
        public static string SqlNameDB { get; private set; } = string.Empty;
        internal static bool SecuriteIntegree { get; set; } = true;
        public static string NomServeur { get; private set; } = string.Empty;
        public static string Instance { get; private set; } = string.Empty;
        internal static Microsoft.Data.SqlClient.SqlConnection con;
        public Form1() => InitializeComponent();
        private void Chargement(object sender, EventArgs e)
        {
            InstanceSQL.Text = (Environment.MachineName + "\\sqlexpress").ToUpper();
            if (MessageBox.Show("Voulez vous utiliser l'autentification Windows?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MotDePasse.Visible = false;
                Utilisateur.Text = Environment.UserDomainName + "\\" + Environment.UserName;
                label5.Visible = false;
                connectionString = $"Server={InstanceSQL.Text};Database=master;Integrated Security=true;Encrypt=true;TrustServerCertificate=true;";
                SecuriteIntegree = true;
            }
            else
            {
                Utilisateur.Text = "sa";
                MotDePasse.Text = "Password01$";
                MotDePasse.Visible = true;
                label5.Visible = true;
                connectionString = $"Server={InstanceSQL.Text};Database=master;User Id={Utilisateur.Text};Password={MotDePasse.Text};Encrypt=true;TrustServerCertificate=true;";
                SecuriteIntegree = false;
            }
            listView1.Columns.Add("Base de donnée", 100);
            listView1.Columns.Add("Schema", 100);
            listView1.Columns.Add("Table", 100);
            listView1.Columns.Add("Identifiant", 100);
            listView1.Columns.Add("Index", 100);
            listView1.Columns.Add("Nullable", 100);
            listView1.Columns.Add("Type", 100);
            listView1.Columns.Add("Longeur", 100);
        }
        public static void ListerTableDansBaseChoisie()
        {
            ListeTables.Items.Clear();
            using (SqlConnection connection = new SqlConnection(StringSQL))
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        StatutConnexion.Text = $"\\\\{NomServeur}\\{Instance}.DBO.{SqlNameDB}".ToUpper();
                    }
                    string query = "SELECT TABLE_CATALOG,TABLE_SCHEMA,UPPER(TABLE_NAME),TABLE_TYPE FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' AND TABLE_NAME NOT LIKE 'SPT_%' AND TABLE_NAME !='MSREPLICATION_OPTIONS' ORDER BY TABLE_NAME,TABLE_CATALOG";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListeTables.Items.Add(reader.GetString(2));
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}\n{ex.StackTrace}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ListerColonnesDansTable()
        {
            ListeColonnes.Items.Clear();
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            using (SqlConnection connection = new SqlConnection(StringSQL))
            {
                string codeSql = string.Empty;
                exportCS.Text = $"{Environment.CurrentDirectory}\\{ListeTables.Text}.cs";
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open) { StatutConnexion.Text = $"[DBO].[{SqlNameDB}].[{ListeTables.Text}]".ToUpper(); }
                    string query = $"SELECT TABLE_CATALOG, TABLE_SCHEMA, TABLE_NAME, COLUMN_NAME , ORDINAL_POSITION, IS_NULLABLE, DATA_TYPE AS 'TYPE', CHARACTER_OCTET_LENGTH AS 'LONGEUR',NUMERIC_PRECISION,NUMERIC_PRECISION_RADIX FROM INFORMATION_SCHEMA.COLUMNS " +
                        $"WHERE TABLE_CATALOG = '{SqlNameDB}' AND TABLE_NAME = '{ListeTables.Text}' AND TABLE_NAME NOT LIKE 'SPT_%' AND TABLE_NAME != 'MSREPLICATION_OPTIONS'  " +
                        $"ORDER BY TABLE_NAME";
                    txtSQL.Text = query;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        codeSql = $"/*[{SqlNameDB}].[dbo].[{ListeTables.Text}]*/\n\nUSE [{SqlNameDB}]\r\n" +
                            $"IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{ListeTables.Text}]')" +
                            $" AND type in (N'U'))\r\nDROP TABLE [dbo].[{ListeTables.Text}]\r\nSET ANSI_NULLS ON\r\nSET QUOTED_IDENTIFIER ON" +
                            $"\r\nCREATE TABLE [dbo].[Achat{ListeTables.Text}](\r\n".ToUpper();
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader[0].ToString());
                            item.SubItems.Add(reader[1].ToString());
                            item.SubItems.Add(reader[2].ToString());
                            item.SubItems.Add(reader[3].ToString());
                            item.SubItems.Add(reader[4].ToString());
                            item.SubItems.Add(reader[5].ToString());
                            item.SubItems.Add(reader[6].ToString());
                            item.SubItems.Add(reader[7].ToString());
                            item.SubItems.Add(reader[8].ToString());
                            item.SubItems.Add(reader[9].ToString());
                            listView1.Items.Add(item);
                            if (reader[5].ToString() == "NO")
                            {
                                if (reader[4].ToString() == "1")
                                {
                                    codeSql += $"[{reader[3].ToString()}] [{reader[4].ToString()}] NOT NULL PRIMARY KEY,\n";
                                }
                                else
                                {
                                    codeSql += $"[{reader[3].ToString()}] [{reader[4].ToString()}] NOT NULL,\n";
                                }
                            }
                            else
                            {
                                codeSql += $"[{reader[3].ToString()}] [{reader[4].ToString()}] NULL,\n";
                            }
                            codeSql += $" ) ON [PRIMARY]\n";
                        }
                        if (listView1.Items.Count > 0) //verou anti-plantage stack over // move ax,bx[offset[eax]] ou eax =-1
                        {
                            for (int i = 0; i < listView1.Items.Count; i++) //valeur d'index non negative
                            {
                                ListeColonnes.Items.Add($"{i}\t{listView1.Items[i].SubItems[4].Text}\t{listView1.Items[i].SubItems[3].Text}");
                            }
                        }
                        textBox1.Text = codeSql;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}\n{ex.StackTrace}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void ListerBasesDonneeSurLeServeur()
        {
            ListeDB.Items.Clear();
            StatutConnexion.Text = connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        StatutConnexion.Text = "Connecté à " + InstanceSQL.Text;
                    }
                    string query = "SELECT UPPER(NAME),DATABASE_ID,CREATE_DATE FROM SYS.DATABASES ORDER BY NAME";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if ((int)reader[1] == 1 || (int)reader[1] > 4)
                            {
                                ListeDB.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
        private void CommandeConnexion_Click(object sender, EventArgs e)
        {
            CommandeConnexion.Text = "Déconnexion";
            ListeDB.Enabled = true;

            NomServeur = InstanceSQL.Text.Split('\\')[0];
            Instance = InstanceSQL.Text.Split('\\')[1];
            if (InstanceSQL.Text.Length > 0)
            {
                if (Utilisateur.Text.Length > 1)
                {
                    if (MotDePasse.Text.Length > 3 || SecuriteIntegree == true)
                    {
                        ListerBasesDonneeSurLeServeur();
                        if (ListeDB.Items.Count > 0)
                        {
                            ListeDB.SelectedIndex = 0;
                            groupBox1.Visible = true;
                            StatutConnexion.Text = $"{Instance}@{NomServeur}.DBO.{SqlNameDB}";
                            label1.Visible = true;
                            ListeTables.Visible = true;
                        }
                        else
                        {
                            StatutConnexion.Text = $"{Instance}@{NomServeur}";
                            MessageBox.Show("IL n'y a pas de tables listées");
                        }
                    }
                    else { MessageBox.Show("Longueur du mot de passe invalide\n" + MotDePasse.Text); }
                }
                else { MessageBox.Show("Longueur du nom d'utilisateur invalide\n" + Utilisateur.Text); }

            }
            else { MessageBox.Show("Longueur de l'instance SQL invalide\n" + InstanceSQL.Text); }
        }
        private void ListeDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlNameDB = ListeDB.Text.Trim();
            if (SecuriteIntegree == true)
            {
                StringSQL = $"Server={InstanceSQL.Text};Database={SqlNameDB};Integrated Security=true;Encrypt=true;TrustServerCertificate=true;";
            }
            else
            {
                StringSQL = $"Server={InstanceSQL.Text};Database={SqlNameDB};User Id={Utilisateur.Text};Password={MotDePasse.Text};Encrypt=true;TrustServerCertificate=true;";
            }
            ListerTableDansBaseChoisie();
        }

        private void ListeTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListeTables.Items.Count > 0)
            {
                panel1.Visible = true;
                ListerColonnesDansTable();
            }
        }

        private void CopierEnMemoire(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void ExporterEnCS(object sender, EventArgs e)
        {

        }

        private void EnumererRequeteSQL(object sender, EventArgs e)
        {

        }

        private void ExportSQL_Click(object sender, EventArgs e)
        {

        }

        private void EffacerIntégrateurSQL(object sender, EventArgs e)
        {

        }

        private void SauvegarderTout(object sender, EventArgs e)
        {

        }

        private void Quitter(object sender, EventArgs e)
        {
            if (Application.AllowQuit == true)
            {
                Application.Exit();
            }
        }
    }
}
