using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using Dapper;
using System.Collections.ObjectModel;
using System;
using System.Linq;

namespace DapperHWs {
    public partial class MainWindow : Form {
        private const string ConnectionString = @"Data Source=DESKTOP-LK1SE6P\MSSQL;Initial Catalog=MailingDB;Integrated Security=True";
        private SqlConnection conn = null;
        public MainWindow() {
            InitializeComponent();
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            cbAddCity.DisplayMember = "Title";
            cbAddCity.ValueMember = "Id";

            cbAddCountryId.DisplayMember = "Title";
            cbAddCountryId.ValueMember = "Id";

            cbAddCountryCategoryId.DisplayMember = "Title";
            cbAddCountryCategoryId.ValueMember = "Id";

            cbAddCategoryId.ValueMember = "Id";
            cbAddCategoryId.DisplayMember = "Title";

            cbAddCity.DataSource = conn.Query("select Cities.Title, Cities.Id from Cities").ToList();

            cbAddCategoryId.DataSource = conn.Query("select GoodsCategories.Title, GoodsCategories.Id from GoodsCategories").ToList();

            var Countries = conn.Query("select Countries.Title, Countries.Id from Countries").ToList();

            cbAddCountryId.DataSource = Countries;
            cbAddCountryCategoryId.DataSource = Countries;
        }

        private void bAddClick(object sender, EventArgs e) {
            string _command = string.Empty;
            switch (tcAddings.SelectedIndex) {
                case 0:
                    if (string.IsNullOrWhiteSpace(tbAddName.Text)
                        || string.IsNullOrWhiteSpace(tbAddSurname.Text)
                        || string.IsNullOrWhiteSpace(tbAddEmail.Text)
                        || dtpAddBirthDate.Value > DateTime.Now) return;

                    
                    _command = $"insert into Users values ('{tbAddName.Text}', '{tbAddSurname.Text}', '{tbAddEmail.Text}', '{bflib.BasicFunctions.DateFormatToStringSQL(dtpAddBirthDate.Value)}', {Convert.ToInt16(cbAddIsMale.Checked)}, {cbAddCity.SelectedValue})";
                    break;
                case 1:
                    if (string.IsNullOrWhiteSpace(tbAddCountryName.Text)) return;

                    _command = $"insert into Countries values ('{tbAddCountryName.Text}')";
                    break;
                case 2:
                    if (string.IsNullOrWhiteSpace(tbAddCityName.Text)) return;

                    _command = $"insert into Cities values ('{tbAddCityName.Text}',{cbAddCountryId.SelectedValue})";
                    break;
                case 3:
                    if (string.IsNullOrWhiteSpace(tbAddCategoriesName.Text)) return;

                    _command = $"insert into GoodsCategories values ('{tbAddCategoriesName.Text}')";
                    break;
                case 4:
                    if(string.IsNullOrWhiteSpace(tbAddDiscountName.Text) 
                        || dtpAddDiscountFinish.Value < DateTime.Now
                        || dtpAddDiscountStart.Value > DateTime.Now) return;

                    _command = $"insert into DiscountGoods values ('{tbAddDiscountName.Text}', '{cbAddCategoryId.SelectedValue}', '{cbAddCountryCategoryId.SelectedValue}', '{bflib.BasicFunctions.DateTimeFormatToStringSQL(dtpAddDiscountStart.Value)}', '{bflib.BasicFunctions.DateTimeFormatToStringSQL(dtpAddDiscountFinish.Value)}')";
                    break;
                default:
                    break;
            }
            conn.Execute(_command);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            if (conn != null) conn.Close();
        }
    }
}
