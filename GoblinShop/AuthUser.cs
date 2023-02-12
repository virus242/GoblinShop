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

namespace GoblinShop
{
    public partial class AuthUser : Form
    {
        string loginNameUser;
        database Db = new database();

        public AuthUser()
        {
            InitializeComponent();
        }

        public string GetNameUser() {
            return loginNameUser;
           }
        private void buttonSingIn_Click_1(object sender, EventArgs e)
        {
            loginNameUser = NameBox.Text;
            var loginPasswordUser = PasswordBox.Text;

            SqlDataAdapter adapter= new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystirng = $"select UserName, UserPassword From USERS WHERE UserName='{loginNameUser}' and UserPassword ='{loginPasswordUser}'";

            SqlCommand command= new SqlCommand(querystirng, Db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count > 0 ) {
                this.Hide();
                GoblinShop goblinShop = new GoblinShop();
                goblinShop.Owner = this;
                goblinShop.Show();
                
            }
            else
            {
                MessageBox.Show("Incorrect password", "Fail Auth", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SingUp_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void AuthUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AuthUser_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
    }
}
