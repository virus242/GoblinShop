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
using System.Data.Sql;
using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace GoblinShop
{
    public partial class GoblinShop : Form
    {
        string UserName;


        database DB = new database();
        public GoblinShop()
        {
            InitializeComponent();
        }


        private System.Collections.Generic.List<int> getINTArrDataFromTableAsEnumerable(DataTable table, string column)
        {
            return table.AsEnumerable()
                .Select(r => r.Field<int>(column))
                .ToList();
        }

        private void GoblinShop_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            AuthUser authF = (AuthUser)this.Owner;
            UserName = authF.GetNameUser();
            this.NameLabel.Text = UserName;
            ShowCoins();
            showShopTable();
        }
        

        private void showShopTable() {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Items", DB.getConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void GoblinShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private string queryPublish()
        {
            var nameGood = NameGood.Text.ToLower();
            var damageGood = DamageGood.Text.ToLower();
            var protectionGood = ProtectionGood.Text.ToLower();
            var distancGood = DistancGood.Text.ToLower();
            var classGood = ClassGood.Text.ToLower();
            var price = Price.Text.ToLower();

            return $"INSERT INTO Items " +
                $"(NameSeller, NameProduct, DamagProduct," +
                $" ProtectionProduct, DistanceProduct," +
                $" ClassItemProduct, Price) " +
                $"VALUES ('{NameLabel.Text}', '{nameGood}', '{damageGood}'," +
                $"'{protectionGood}','{distancGood}','{classGood}', '{price}')";
        }

        private void PublishButton_Click(object sender, EventArgs e)
        {
            var querystring = queryPublish();
            SqlCommand command = new SqlCommand(querystring, DB.getConnection());
            DB.openConnection();
            if (command.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("Fail", "Fail");

                }

            DB.closeConnection();
            showShopTable();
        }


        private void ShowCoins()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            var coins = getCoinsByName(NameLabel.Text);
            this.Coins.Text = coins.ToString();
        }


        private string getQueryStringForSearch() {
            var IDGood = IDShow.Text.ToLower();
            var nameGood = NameShow.Text.ToLower();
            var damageGood = DamageShow.Text.ToLower();
            var protectionGood = ProtectionShow.Text.ToLower();
            var distancGood = DistancGoodShow.Text.ToLower();
            var classGood = ClassGoodShow.Text.ToLower();

            string itemsString = "";

            if (IDGood != "") { itemsString += $"IdProduct = '{IDGood}'"; }

            if (itemsString.Length > 0 && nameGood != "") { itemsString += $"AND NameProduct='{nameGood}'"; }
            else if (nameGood != "") { itemsString += $"NameProduct  = '{nameGood}'"; }

            if (itemsString.Length > 0 && damageGood != "") { itemsString += $"AND DamagProduct='{damageGood}'"; }
            else if (damageGood != "") { itemsString += $"DamagProduct = '{nameGood}'"; }

            if (itemsString.Length > 0 && protectionGood != "") { itemsString += $"AND ProtectionProduct  = '{protectionGood}'"; }
            else if (protectionGood != "") { itemsString += $"ProtectionProduct='{protectionGood}'"; }

            if (itemsString.Length > 0 && distancGood != "") { itemsString += $"AND DistanceProduct  = '{distancGood}'"; }
            else if (distancGood != "") { itemsString += $"DistanceProduct='{distancGood}'"; }

            if (itemsString.Length > 0 && classGood != "") { itemsString += $"AND ClassItemProduct  = '{classGood}'"; }
            else if (classGood != "") { itemsString += $"ClassItemProduct='{classGood}'"; }

            if (itemsString.Length > 0 && ShowWhatCanBuy.Checked == true)
            {
                itemsString += $"AND Price <= {getCoinsByName(NameLabel.Text)}";
            }
            else if (ShowWhatCanBuy.Checked == true)
            {
                itemsString += $"Price <= {getCoinsByName(NameLabel.Text)}";
            }

            string querystirng = $"SELECT * FROM Items";
            if (itemsString.Length > 0)
            {
                querystirng += $" WHERE {itemsString}";
            }
            return querystirng;
        }


        private void showGoodButton_Click(object sender, EventArgs e)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            var querystring = getQueryStringForSearch();

            SqlCommand command = new SqlCommand(querystring, DB.getConnection());
            Console.WriteLine(querystring);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        private Boolean isUserEnouthCoin(int price)
        {
            if (Int32.Parse(this.Coins.Text) >= price)
            {
                return true;
            }
            return false;
        }


        private void GetCoinsFromUser(int coins)
        {
            string querystring = $"Update USERS SET UserCoins={Int32.Parse(this.Coins.Text) - coins} WHERE UserName='{this.NameLabel.Text}'";

            SqlCommand command = new SqlCommand(querystring, DB.getConnection());
            DB.openConnection();
            if (command.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Fail", "Fail");
            }
            DB.closeConnection();

        }


        private int getPriceFromProductById(string ID)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystirng = $"SELECT Price FROM Items WHERE IdProduct = {ID}";
            SqlCommand command = new SqlCommand(querystirng, DB.getConnection());
            DB.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            var coins = getINTArrDataFromTableAsEnumerable(table, "Price");

            DB.closeConnection();
            if (coins.Count > 0)
            {
                return coins[0];
            }
            return -1;
        }


        private string getNameSellerByIdProd(string IDProd)
        {
            var IDProdINT = Int32.Parse(IDProd);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"SELECT NameSeller FROM Items WHERE IdProduct = {IDProdINT}";
            SqlCommand command = new SqlCommand(querystring, DB.getConnection());
            DB.openConnection();

            string name = (string)command.ExecuteScalar();

            DB.closeConnection();
            Console.WriteLine(name);
            return name;
        }


        private int getCoinsByName(string Name)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystirng = $"SELECT UserCoins FROM USERS WHERE UserName = '{Name}'";
            SqlCommand command = new SqlCommand(querystirng, DB.getConnection());
            DB.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            var coins = getINTArrDataFromTableAsEnumerable(table, "UserCoins");

            DB.closeConnection();
            if (coins.Count > 0)
            {
                return coins[0];
            }
            return -1;
        }


        private void AddCoinsToSeller(string IDProd)
        {
            var NameSeller = getNameSellerByIdProd(IDProd);
            var coinsHave = getCoinsByName(NameSeller);
            var Price = getPriceFromProductById(IDProd);
            AddCoinsToUser(NameSeller, coinsHave, Price);
        }


        private void deleteItemShopByIdProduct(string ID)
        {
            string querystring = $"DELETE FROM ITEMS WHERE IdProduct='{ID}'";

            SqlCommand command = new SqlCommand(querystring, DB.getConnection());
            DB.openConnection();
            if (command.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Fail", "Fail");

            }

            DB.closeConnection();
        }


        private void BuyButton_Click(object sender, EventArgs e)
        {
            var ID = IDBuy.Text;

            AddCoinsToSeller(ID);
            
            int priceProduct = getPriceFromProductById(ID);

            if (!isUserEnouthCoin(priceProduct))
            {
                MessageBox.Show("not enouth Coins", "Fail Coins");
            }
            else
            {
                GetCoinsFromUser(priceProduct);
                deleteItemShopByIdProduct(ID);
                ShowCoins();
                showShopTable();
            }
        }


        private void Picture_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bit;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
           
        }

        private void AddCoinsToUser(string name, int counsCoinsHave,int countCoinsAdd)
        {
            string querystring = $"Update USERS SET UserCoins={countCoinsAdd + counsCoinsHave} WHERE UserName='{name}'";

            SqlCommand command = new SqlCommand(querystring, DB.getConnection());
            DB.openConnection();

            if (command.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Fail", "Fail");
            }

            DB.closeConnection();
        }

        private void AddCoins_Click(object sender, EventArgs e)
        {
            AddCoinsToUser(NameLabel.Text, Int32.Parse(Coins.Text),int.Parse(countCoins.Text));
            ShowCoins();
        }


    }
}
