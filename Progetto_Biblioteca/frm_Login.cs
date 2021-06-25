using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Progetto_Biblioteca
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //***DICHIRAZIONE VARIABILI PUBBLICHE
        public int numero_tentativo;
        //CONESSIONE
        public SqlConnection sqlCnn;
        //Definire la stringa della connessione
        public string connection_string
            = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kevin\Documents\Progetto_Biblioteca.mdf;Integrated Security = True; Connect Timeout = 30";
        //Definire Il DataAdapter è il trasportatore dei dati
        public SqlDataAdapter adapter = new SqlDataAdapter();

        //Definire Il DATASET - dove appoggio i DATA
        public DataSet ds = new DataSet();
        private void frm_Login_Load(object sender, EventArgs e)
        {
            //codice che viene eseguiti al caricamento
            //della form
            numero_tentativo = 1;
            ss_lbl_Numero_Tentativi.Text = "Numero Tentativo: " +
                numero_tentativo.ToString();
            //codice oer popolare la combobox
            string sql = "SELECT * FROM vw_Utenti ORDER BY NomeUtente";
 
            //imposto la connessione
            sqlCnn = new SqlConnection(connection_string);

            //apre il DB -- vogliamo controllare eventuali errori
            //per questo usiamo il costrutto TRY

            try
            {
                sqlCnn.Open();
                //devo creare un comando
                SqlCommand sqlCmd = new SqlCommand(sql, sqlCnn);


                //assengo l'incarico al nostro ADAPTE
                adapter.SelectCommand = sqlCmd;
                adapter.Fill(ds);

                int numero_utenti = ds.Tables[0].Rows.Count;


                //Dobbiamo popolare la COMBOBOX

                for (int i = 0; i < numero_utenti; i++) 
                
                {
                    cb_NomeUtente.Items.Add(ds.Tables[0].Rows[i]["NomeUtente"]).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //chiudo la connessione

            sqlCnn.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

        }

        private void cb_NomeUtente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //codice viene seguito quando si cambia il valore della combobox
            txt_Password.Enabled = true;
            //creo una nuova conessione per restituire le informazione dell'Utente selezionato
            string sql = "SELECT * FROM vw_Utenti WHERE NomeUtente='" +
                cb_NomeUtente.Text + "'";

            sqlCnn = new SqlConnection(connection_string);

            try
            {
                sqlCnn.Open();
                SqlCommand sqlCmd = new SqlCommand(sql, sqlCnn);
                adapter.SelectCommand = sqlCmd;
                ds.Clear();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //ha trovato l'utente selezionato
                    ss_lbl_Utente_Scelto.Text = "Nome: " + ds.Tables[0].Rows[0]["Nome"];
                }

                else
                {
                    ss_lbl_Messaggio_Errore.Text = "Utente Non Trovato";
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlCnn.Close();


        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            //codice viene seguito quando si inserisce un valore nella textbox-password
            btn_Login.Enabled = true;
        }
    }
}
