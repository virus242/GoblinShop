using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GoblinShop
{
    public partial class Registration : Form
    {
        database DB = new database();
        public Registration()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var login = NameReg.Text;
            var password = PasswordReg.Text;

            string querystring = $"INSERT INTO USERS(UserCoins, UserName, UserPassword) VALUES ('{1000}', '{login}', '{password}')";
            if (!cheakuser())
            { 
                SqlCommand command= new SqlCommand(querystring, DB.getConnection());
                DB.openConnection();
                if(command.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Fail REG", "Fail");
                }
                else
                {
                    MessageBox.Show("Account is ready", $"hello {login}");
                }
            }
           
            DB.closeConnection();
        }

        private Boolean cheakuser()
        {
            var login = NameReg.Text;
            var password = PasswordReg.Text;

            SqlDataAdapter adapter= new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"SELECT UserName, UserPassword FROM USERS WHERE UserName = '{login}' and UserPassword = '{password}'";

            SqlCommand command = new SqlCommand(querystring, DB.getConnection());
            adapter.SelectCommand= command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("The name is taken");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthUser authUser= new AuthUser();
            authUser.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
    }
}
