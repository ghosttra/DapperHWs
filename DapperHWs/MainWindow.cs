using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
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

            var Users = conn.Query("select * from Users").Select(s => new { s.Id, s.Name, s.Surname, s.Email, s.BirthDate, s.IsMale, s.CityId }).ToList();
            var Countries = conn.Query("select * from Countries").Select(s => new { s.Id, s.Title }).ToList();
            var GoodsCategories = conn.Query("select * from GoodsCategories").Select(s => new { s.Id, s.Title }).ToList();
            var Cities = conn.Query("select * from Cities").Select(s => new { s.Id, s.Title, s.CountryId }).ToList();
            var DiscountGoods = conn.Query("select * from DiscountGoods").Select(s => new { s.Id, s.Title, s.CategoryId, s.CountryId, s.StartDateTime, s.FinishDateTime }).ToList();

            cbAddCity.DisplayMember = "Title";
            cbAddCity.ValueMember = "Id";

            cbAddCountryId.DisplayMember = "Title";
            cbAddCountryId.ValueMember = "Id";

            cbAddCountryCategoryId.DisplayMember = "Title";
            cbAddCountryCategoryId.ValueMember = "Id";

            cbAddCategoryId.ValueMember = "Id";
            cbAddCategoryId.DisplayMember = "Title";

            cbCC.ValueMember = "Id";
            cbCC.DisplayMember = "Surname";
            cbCC.DataSource = Users;

            cbDG.ValueMember = "Id";
            cbDG.DisplayMember = "Title";
            cbDG.DataSource = GoodsCategories;

            cbCFC.ValueMember = "Id";
            cbCFC.DisplayMember = "Title";
            cbCFC.DataSource = Countries;

            cbAddCity.DataSource = Cities;

            cbAddCategoryId.DataSource = GoodsCategories;

            cbAddCountryId.DataSource = Countries;
            cbAddCountryCategoryId.DataSource = Countries;

            dgvUCategories.DataSource = GoodsCategories;
            dgvUCities.DataSource = Cities;
            dgvUCountry.DataSource = Countries;
            dgvUCustomer.DataSource = Users;
            dgvUDiscounts.DataSource = DiscountGoods;
        }

        private void bAddClick(object sender, EventArgs e) {
            string _command = "insert into ";
            switch (tcAddings.SelectedIndex) {
                case 0:
                    if (string.IsNullOrWhiteSpace(tbAddName.Text)
                        || string.IsNullOrWhiteSpace(tbAddSurname.Text)
                        || string.IsNullOrWhiteSpace(tbAddEmail.Text)
                        || dtpAddBirthDate.Value > DateTime.Now) return;


                    _command += $"Users values ('{tbAddName.Text}', '{tbAddSurname.Text}', '{tbAddEmail.Text}', '{bflib.BasicFunctions.DateFormatToStringSQL(dtpAddBirthDate.Value)}', {Convert.ToInt16(cbAddIsMale.Checked)}, {cbAddCity.SelectedValue})";
                    break;
                case 1:
                    if (string.IsNullOrWhiteSpace(tbAddCountryName.Text)) return;

                    _command += $"Countries values ('{tbAddCountryName.Text}')";
                    break;
                case 2:
                    if (string.IsNullOrWhiteSpace(tbAddCityName.Text)) return;

                    _command += $"Cities values ('{tbAddCityName.Text}',{cbAddCountryId.SelectedValue})";
                    break;
                case 3:
                    if (string.IsNullOrWhiteSpace(tbAddCategoriesName.Text)) return;

                    _command += $"GoodsCategories values ('{tbAddCategoriesName.Text}')";
                    break;
                case 4:
                    if (string.IsNullOrWhiteSpace(tbAddDiscountName.Text)
                        || dtpAddDiscountFinish.Value < DateTime.Now
                        || dtpAddDiscountStart.Value > DateTime.Now) return;

                    _command += $"DiscountGoods values ('{tbAddDiscountName.Text}', '{cbAddCategoryId.SelectedValue}', '{cbAddCountryCategoryId.SelectedValue}', '{bflib.BasicFunctions.DateTimeFormatToStringSQL(dtpAddDiscountStart.Value)}', '{bflib.BasicFunctions.DateTimeFormatToStringSQL(dtpAddDiscountFinish.Value)}')";
                    break;
                default:
                    break;
            }
            conn.Execute(_command);
        }

        private void bUpdate_Click(object sender, EventArgs e) {
            string _command = "update ";
            switch (tcUpdate.SelectedIndex) {
                case 0:
                    if (string.IsNullOrWhiteSpace(tbUName.Text)
                       || string.IsNullOrWhiteSpace(tbUSurname.Text)
                       || string.IsNullOrWhiteSpace(tbUEmail.Text)
                       || dtpUBD.Value > DateTime.Now) return;

                    _command += $"Users set [Name] = '{tbUName.Text}', Surname = '{tbUSurname.Text}', Email = '{tbUEmail.Text}'," +
                        $" BirthDate = '{bflib.BasicFunctions.DateFormatToStringSQL(dtpUBD.Value)}'," +
                        $" IsMale = {Convert.ToInt16(chBUIsMale.Checked)}, CityId = {cbUCities.SelectedValue} where Users.Id = {dgvUCustomer.SelectedRows[0].Cells[0].Value}";
                    break;
                case 1:
                    if (string.IsNullOrWhiteSpace(tbUCountryName.Text)) return;

                    _command += $"Countries set Title = '{tbUCountryName.Text}' where Countries.Id = {dgvUCountry.SelectedRows[0].Cells[0].Value}";
                    break;
                case 2:
                    if (string.IsNullOrWhiteSpace(tbUCityName.Text)) return;

                    _command += $"Cities set Title = '{tbUCityName.Text}', CountryId = {cbUCountryCity.SelectedValue} where Cities.Id = {dgvUCities.SelectedRows[0].Cells[0].Value}";
                    break;
                case 3:
                    if (string.IsNullOrWhiteSpace(tbUCategoryName.Text)) return;

                    _command += $"GoodsCategories set Title = '{tbUCategoryName.Text}' where GoodsCategories.Id = {dgvUCategories.SelectedRows[0].Cells[0].Value}";
                    break;
                case 4:
                    if (string.IsNullOrWhiteSpace(tbDiscountName.Text)
                        || dtpUFinish.Value < dtpUStart.Value) return;

                    _command += $"DiscountGoods set Title = '{tbDiscountName.Text}'," +
                        $" CategoryId = {cbUCategoryId.SelectedValue}," +
                        $" CountryId = {cbUCountryId.SelectedValue}," +
                        $" StartDateTime = '{bflib.BasicFunctions.DateTimeFormatToStringSQL(dtpUStart.Value)}'," +
                        $" FinishDateTime = '{bflib.BasicFunctions.DateTimeFormatToStringSQL(dtpUFinish.Value)}'" +
                        $" where DiscountGoods.Id = {dgvUDiscounts.SelectedRows[0].Cells[0].Value}";
                    break;
                default:
                    break;
            }
            conn.Execute(_command);
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            if (conn != null) conn.Close();
        }

        private void dgvUCustomer_RowEnter(object sender, DataGridViewCellEventArgs e) {
            if (dgvUCustomer.SelectedRows.Count == 1) {
                tbUName.Text = dgvUCustomer.SelectedRows[0].Cells[1].Value.ToString();
                tbUEmail.Text = dgvUCustomer.SelectedRows[0].Cells[3].Value.ToString();
                tbUSurname.Text = dgvUCustomer.SelectedRows[0].Cells[2].Value.ToString();
                dtpUBD.Value = Convert.ToDateTime(dgvUCustomer.SelectedRows[0].Cells[4].Value.ToString());
                chBUIsMale.Checked = Convert.ToBoolean(dgvUCustomer.SelectedRows[0].Cells[5].Value.ToString());

                var cities = conn.Query("select * from Cities").Select(s => new { s.Id, s.Title, s.CountryId }).ToList();

                cbUCities.ValueMember = "Id";
                cbUCities.DisplayMember = "Title";
                cbUCities.DataSource = cities;

                var city = cities.Select(s => s.Id).ToList();

                for (int i = 0; i < city.Count; i++)
                    if (city[i] == (int)dgvUCustomer.SelectedRows[0].Cells[6].Value)
                        cbUCities.SelectedIndex = i;
            }


        }

        private void dgvUCountry_RowEnter(object sender, DataGridViewCellEventArgs e) {
            if (dgvUCountry.SelectedRows.Count == 1)
                tbUCountryName.Text = dgvUCountry.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dgvUCities_RowEnter(object sender, DataGridViewCellEventArgs e) {
            if (dgvUCities.SelectedRows.Count == 1) {
                tbUCityName.Text = dgvUCities.SelectedRows[0].Cells[1].Value.ToString();

                var countries = conn.Query("select * from Countries").Select(s => new { s.Id, s.Title }).ToList();

                cbUCountryCity.ValueMember = "Id";
                cbUCountryCity.DisplayMember = "Title";
                cbUCountryCity.DataSource = countries;

                var country = countries.Select(s => s.Id).ToList();

                for (int i = 0; i < country.Count; i++)
                    if (country[i] == (int)dgvUCities.SelectedRows[0].Cells[2].Value)
                        cbUCountryCity.SelectedIndex = i;
            }

        }

        private void dgvUCategories_RowEnter(object sender, DataGridViewCellEventArgs e) {
            if (dgvUCategories.SelectedRows.Count == 1)
                tbUCategoryName.Text = dgvUCategories.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dgvUDiscounts_RowEnter(object sender, DataGridViewCellEventArgs e) {
            if (dgvUDiscounts.SelectedRows.Count == 1) {
                tbDiscountName.Text = dgvUDiscounts.SelectedRows[0].Cells[1].Value.ToString();
                dtpUStart.Value = Convert.ToDateTime(dgvUDiscounts.SelectedRows[0].Cells[4].Value.ToString());
                dtpUFinish.Value = Convert.ToDateTime(dgvUDiscounts.SelectedRows[0].Cells[5].Value.ToString());


                var countries = conn.Query("select * from Countries").Select(s => new { s.Id, s.Title }).ToList();
                var categories = conn.Query("select * from GoodsCategories").Select(s => new { s.Id, s.Title }).ToList();

                cbUCountryId.ValueMember = "Id";
                cbUCountryId.DisplayMember = "Title";
                cbUCountryId.DataSource = countries;

                cbUCategoryId.ValueMember = "Id";
                cbUCategoryId.DisplayMember = "Title";
                cbUCategoryId.DataSource = categories;

                var country = countries.Select(s => s.Id).ToList();

                for (int i = 0; i < country.Count; i++)
                    if (country[i] == (int)dgvUDiscounts.SelectedRows[0].Cells[3].Value)
                        cbUCountryId.SelectedIndex = i;

                var category = categories.Select(s => s.Id).ToList();

                for (int i = 0; i < category.Count; i++)
                    if (category[i] == (int)dgvUDiscounts.SelectedRows[0].Cells[3].Value)
                        cbUCategoryId.SelectedIndex = i;

            }
        }

        private void bDelete_Click(object sender, EventArgs e) {
            string _command = "delete from ";
            switch (tcUpdate.SelectedIndex) {
                case 0:
                    _command += $"Users where id = {dgvUCustomer.SelectedRows[0].Cells[0].Value}";
                    break;
                case 1:
                    _command += $"Countries where Countries.Id = {dgvUCountry.SelectedRows[0].Cells[0].Value}";
                    break;
                case 2:
                    _command += $"Cities where id = {dgvUCities.SelectedRows[0].Cells[0].Value}";
                    break;
                case 3:
                    _command += $"GoodsCategories where GoodsCategories.Id = {dgvUCategories.SelectedRows[0].Cells[0].Value}";
                    break;
                case 4:
                    _command += $"DiscountGoods where DiscountGoods.Id ={dgvUDiscounts.SelectedRows[0].Cells[0].Value}";
                    break;
            }
            conn.Execute(_command);
        }

        private void CheckedChanged_rb(object sender, EventArgs e) {
            cbCC.Enabled = rbCategories.Checked;
            cbCFC.Enabled = rbCitiesFromCountry.Checked;
            cbDG.Enabled = rbDiscount.Checked;
        }

        private void bExecute_Click(object sender, EventArgs e) {
            if (rbCitiesFromCountry.Checked) {
                dgvExercises.DataSource = conn.Query($"select * from cities where countryid = {cbCFC.SelectedValue}").Select(s => new {  s.Id, s.Title}).ToList();
            }
            else if (rbCategories.Checked) {
                dgvExercises.DataSource = conn.Query($"select * from GoodsCategories join UserCategory on GoodsCategories.Id = UserCategory.CategoryId where (UserCategory.UserId = {cbCC.SelectedValue})")
                    .Select(s => new { s.Id, s.Title }).ToList();
            }
            else if (rbDiscount.Checked) {
                dgvExercises.DataSource = conn.Query($"select * from DiscountGoods join GoodsCategories on DiscountGoods.CategoryId = GoodsCategories.Id where GoodsCategories.Id = {cbDG.SelectedValue}")
                    .Select(s=>new {s.Id,s.Title, s.StartDateTime, s.FinishDateTime}).ToList();
            }
        }
    }
}
