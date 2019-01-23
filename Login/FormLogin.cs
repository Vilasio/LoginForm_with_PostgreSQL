using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Npgsql;

namespace Login
{
    public partial class FormLogin : Form
    {
        static string connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        bool isAllreadyregistered = false;

        public FormLogin()
        {
            InitializeComponent();
             
        }

        NpgsqlConnection connection = new NpgsqlConnection(connectionString);

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Datenbackverbindung war nicht möglich\r\n{ex.Message}", "Verbingungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = "select count(*) from login.userLogin where user_name = :na";
            command.Parameters.AddWithValue("na", this.textBoxUserName.Text);
            long exist = (long)command.ExecuteScalar();
            if(exist == 0)
            {
                this.textBoxPasswordRep.Visible = true;
                this.labelPasswordRep.Visible = true;
                this.isAllreadyregistered = false;
            }
            else
            {
                this.isAllreadyregistered = true;
            }
        }

        private void buttonAbrechen_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;

            if (isAllreadyregistered)
            {
                command.CommandText = "select count(*) from login.userLogin where user_name = :na";
                command.Parameters.AddWithValue("na", this.textBoxUserName.Text);
                long exist = (long)command.ExecuteScalar();
                if(exist == 0)
                {
                    MessageBox.Show("Benutzername falsch", "Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                command.CommandText = "select count(*) from login.userLogin where user_pwd = :pwd";
                command.Parameters.AddWithValue("pwd", this.textBoxPassword.Text);
                exist = (long)command.ExecuteScalar();
                if (exist == 0)
                {
                    MessageBox.Show("Passwort falsch", "Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                this.DialogResult = DialogResult.OK;
                //this.Close()
                MessageBox.Show("Erfolg", "Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if ((this.textBoxPassword.Text == this.textBoxPasswordRep.Text) && (this.textBoxPassword.Text != ""))
                {
                    NpgsqlTransaction transaction = connection.BeginTransaction();
                    try
                    {
                        command.Transaction = transaction;
                        command.CommandText = "Insert into login.userlogin values(nextval('login.user_id_seq'), :na, :pwd)";
                        command.Parameters.AddWithValue("na", this.textBoxUserName.Text);
                        command.Parameters.AddWithValue("pwd", this.textBoxPassword.Text);
                        int result = command.ExecuteNonQuery();
                        transaction.Commit();
                        this.DialogResult = DialogResult.OK;
                        //this.Close();
                        MessageBox.Show($"{result} row(s) affected!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show($"Übertragung Fehlgeschlagen\n\r{ex.Message}", "Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        transaction.Rollback();
                        return;
                    }
                    
                    
                }
            }
        }
    }
}
