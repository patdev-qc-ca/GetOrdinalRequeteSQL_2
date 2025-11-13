using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetOrdinalRequeteSQL_2
{
    public partial class Form1 : Form
    {
        public static string connectionString { get; set; }
        static string StringSQL { get; set; }
        public static string SqlNameDB { get; private set; }
        internal static bool SecuriteIntegree { get; set; }
        public string NomServeur { get; private set; }
        public string Instance { get; private set; }

        internal static SqlConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
        }
        public static void OuvrirConnexionTableSQL() => con = new SqlConnection(StringSQL);
        public static void ListerBasesDonneeSurLeServeur()
        {
            ListeDB.Items.Clear();
            MessageBox.Show(connectionString);
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
        }
    }
}