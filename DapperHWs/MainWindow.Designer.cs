namespace DapperHWs {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tpAdding = new System.Windows.Forms.TabPage();
            this.bAdd = new System.Windows.Forms.Button();
            this.tcAddings = new System.Windows.Forms.TabControl();
            this.tpAddCustomer = new System.Windows.Forms.TabPage();
            this.lAddCity = new System.Windows.Forms.Label();
            this.lAddBirthDate = new System.Windows.Forms.Label();
            this.lAddEmail = new System.Windows.Forms.Label();
            this.lAddSurname = new System.Windows.Forms.Label();
            this.lAddName = new System.Windows.Forms.Label();
            this.cbAddIsMale = new System.Windows.Forms.CheckBox();
            this.cbAddCity = new System.Windows.Forms.ComboBox();
            this.dtpAddBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbAddEmail = new System.Windows.Forms.TextBox();
            this.tbAddSurname = new System.Windows.Forms.TextBox();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.tpAddCountry = new System.Windows.Forms.TabPage();
            this.tpAddCity = new System.Windows.Forms.TabPage();
            this.tpAddCategory = new System.Windows.Forms.TabPage();
            this.tpAddDiscountGood = new System.Windows.Forms.TabPage();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.tpDelete = new System.Windows.Forms.TabPage();
            this.tpShop = new System.Windows.Forms.TabPage();
            this.tbAddCountryName = new System.Windows.Forms.TextBox();
            this.lCountryName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddCityName = new System.Windows.Forms.TextBox();
            this.cbAddCountryId = new System.Windows.Forms.ComboBox();
            this.lCountryId = new System.Windows.Forms.Label();
            this.lAddCategoriesName = new System.Windows.Forms.Label();
            this.tbAddCategoriesName = new System.Windows.Forms.TextBox();
            this.tbAddDiscountName = new System.Windows.Forms.TextBox();
            this.dtpAddDiscountStart = new System.Windows.Forms.DateTimePicker();
            this.dtpAddDiscountFinish = new System.Windows.Forms.DateTimePicker();
            this.cbAddCountryCategoryId = new System.Windows.Forms.ComboBox();
            this.cbAddCategoryId = new System.Windows.Forms.ComboBox();
            this.tbMain.SuspendLayout();
            this.tpAdding.SuspendLayout();
            this.tcAddings.SuspendLayout();
            this.tpAddCustomer.SuspendLayout();
            this.tpAddCountry.SuspendLayout();
            this.tpAddCity.SuspendLayout();
            this.tpAddCategory.SuspendLayout();
            this.tpAddDiscountGood.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tpAdding);
            this.tbMain.Controls.Add(this.tpUpdate);
            this.tbMain.Controls.Add(this.tpDelete);
            this.tbMain.Controls.Add(this.tpShop);
            this.tbMain.Location = new System.Drawing.Point(12, 12);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(776, 426);
            this.tbMain.TabIndex = 0;
            // 
            // tpAdding
            // 
            this.tpAdding.Controls.Add(this.bAdd);
            this.tpAdding.Controls.Add(this.tcAddings);
            this.tpAdding.Location = new System.Drawing.Point(4, 22);
            this.tpAdding.Name = "tpAdding";
            this.tpAdding.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdding.Size = new System.Drawing.Size(768, 400);
            this.tpAdding.TabIndex = 0;
            this.tpAdding.Text = "Adding";
            this.tpAdding.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(10, 371);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(748, 23);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAddClick);
            // 
            // tcAddings
            // 
            this.tcAddings.Controls.Add(this.tpAddCustomer);
            this.tcAddings.Controls.Add(this.tpAddCountry);
            this.tcAddings.Controls.Add(this.tpAddCity);
            this.tcAddings.Controls.Add(this.tpAddCategory);
            this.tcAddings.Controls.Add(this.tpAddDiscountGood);
            this.tcAddings.Location = new System.Drawing.Point(6, 6);
            this.tcAddings.Name = "tcAddings";
            this.tcAddings.SelectedIndex = 0;
            this.tcAddings.Size = new System.Drawing.Size(756, 359);
            this.tcAddings.TabIndex = 0;
            // 
            // tpAddCustomer
            // 
            this.tpAddCustomer.Controls.Add(this.lAddCity);
            this.tpAddCustomer.Controls.Add(this.lAddBirthDate);
            this.tpAddCustomer.Controls.Add(this.lAddEmail);
            this.tpAddCustomer.Controls.Add(this.lAddSurname);
            this.tpAddCustomer.Controls.Add(this.lAddName);
            this.tpAddCustomer.Controls.Add(this.cbAddIsMale);
            this.tpAddCustomer.Controls.Add(this.cbAddCity);
            this.tpAddCustomer.Controls.Add(this.dtpAddBirthDate);
            this.tpAddCustomer.Controls.Add(this.tbAddEmail);
            this.tpAddCustomer.Controls.Add(this.tbAddSurname);
            this.tpAddCustomer.Controls.Add(this.tbAddName);
            this.tpAddCustomer.Location = new System.Drawing.Point(4, 22);
            this.tpAddCustomer.Name = "tpAddCustomer";
            this.tpAddCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddCustomer.Size = new System.Drawing.Size(748, 333);
            this.tpAddCustomer.TabIndex = 0;
            this.tpAddCustomer.Text = "Customer";
            this.tpAddCustomer.UseVisualStyleBackColor = true;
            // 
            // lAddCity
            // 
            this.lAddCity.AutoSize = true;
            this.lAddCity.Location = new System.Drawing.Point(43, 139);
            this.lAddCity.Name = "lAddCity";
            this.lAddCity.Size = new System.Drawing.Size(27, 13);
            this.lAddCity.TabIndex = 12;
            this.lAddCity.Text = "City:";
            // 
            // lAddBirthDate
            // 
            this.lAddBirthDate.AutoSize = true;
            this.lAddBirthDate.Location = new System.Drawing.Point(15, 93);
            this.lAddBirthDate.Name = "lAddBirthDate";
            this.lAddBirthDate.Size = new System.Drawing.Size(55, 13);
            this.lAddBirthDate.TabIndex = 10;
            this.lAddBirthDate.Text = "Birth date:";
            // 
            // lAddEmail
            // 
            this.lAddEmail.AutoSize = true;
            this.lAddEmail.Location = new System.Drawing.Point(35, 64);
            this.lAddEmail.Name = "lAddEmail";
            this.lAddEmail.Size = new System.Drawing.Size(35, 13);
            this.lAddEmail.TabIndex = 9;
            this.lAddEmail.Text = "Email:";
            // 
            // lAddSurname
            // 
            this.lAddSurname.AutoSize = true;
            this.lAddSurname.Location = new System.Drawing.Point(18, 38);
            this.lAddSurname.Name = "lAddSurname";
            this.lAddSurname.Size = new System.Drawing.Size(52, 13);
            this.lAddSurname.TabIndex = 8;
            this.lAddSurname.Text = "Surname:";
            // 
            // lAddName
            // 
            this.lAddName.AutoSize = true;
            this.lAddName.Location = new System.Drawing.Point(35, 12);
            this.lAddName.Name = "lAddName";
            this.lAddName.Size = new System.Drawing.Size(38, 13);
            this.lAddName.TabIndex = 7;
            this.lAddName.Text = "Name:";
            // 
            // cbAddIsMale
            // 
            this.cbAddIsMale.AutoSize = true;
            this.cbAddIsMale.Location = new System.Drawing.Point(76, 113);
            this.cbAddIsMale.Name = "cbAddIsMale";
            this.cbAddIsMale.Size = new System.Drawing.Size(66, 17);
            this.cbAddIsMale.TabIndex = 6;
            this.cbAddIsMale.Text = "Is Male?";
            this.cbAddIsMale.UseVisualStyleBackColor = true;
            // 
            // cbAddCity
            // 
            this.cbAddCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddCity.FormattingEnabled = true;
            this.cbAddCity.Location = new System.Drawing.Point(76, 136);
            this.cbAddCity.Name = "cbAddCity";
            this.cbAddCity.Size = new System.Drawing.Size(666, 21);
            this.cbAddCity.TabIndex = 5;
            // 
            // dtpAddBirthDate
            // 
            this.dtpAddBirthDate.Location = new System.Drawing.Point(76, 87);
            this.dtpAddBirthDate.Name = "dtpAddBirthDate";
            this.dtpAddBirthDate.Size = new System.Drawing.Size(666, 20);
            this.dtpAddBirthDate.TabIndex = 4;
            // 
            // tbAddEmail
            // 
            this.tbAddEmail.Location = new System.Drawing.Point(76, 61);
            this.tbAddEmail.Name = "tbAddEmail";
            this.tbAddEmail.Size = new System.Drawing.Size(666, 20);
            this.tbAddEmail.TabIndex = 3;
            // 
            // tbAddSurname
            // 
            this.tbAddSurname.Location = new System.Drawing.Point(76, 35);
            this.tbAddSurname.Name = "tbAddSurname";
            this.tbAddSurname.Size = new System.Drawing.Size(666, 20);
            this.tbAddSurname.TabIndex = 1;
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(76, 9);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(666, 20);
            this.tbAddName.TabIndex = 0;
            // 
            // tpAddCountry
            // 
            this.tpAddCountry.Controls.Add(this.lCountryName);
            this.tpAddCountry.Controls.Add(this.tbAddCountryName);
            this.tpAddCountry.Location = new System.Drawing.Point(4, 22);
            this.tpAddCountry.Name = "tpAddCountry";
            this.tpAddCountry.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddCountry.Size = new System.Drawing.Size(748, 333);
            this.tpAddCountry.TabIndex = 1;
            this.tpAddCountry.Text = "Country";
            this.tpAddCountry.UseVisualStyleBackColor = true;
            // 
            // tpAddCity
            // 
            this.tpAddCity.Controls.Add(this.lCountryId);
            this.tpAddCity.Controls.Add(this.cbAddCountryId);
            this.tpAddCity.Controls.Add(this.label1);
            this.tpAddCity.Controls.Add(this.tbAddCityName);
            this.tpAddCity.Location = new System.Drawing.Point(4, 22);
            this.tpAddCity.Name = "tpAddCity";
            this.tpAddCity.Size = new System.Drawing.Size(748, 333);
            this.tpAddCity.TabIndex = 2;
            this.tpAddCity.Text = "City";
            this.tpAddCity.UseVisualStyleBackColor = true;
            // 
            // tpAddCategory
            // 
            this.tpAddCategory.Controls.Add(this.lAddCategoriesName);
            this.tpAddCategory.Controls.Add(this.tbAddCategoriesName);
            this.tpAddCategory.Location = new System.Drawing.Point(4, 22);
            this.tpAddCategory.Name = "tpAddCategory";
            this.tpAddCategory.Size = new System.Drawing.Size(748, 333);
            this.tpAddCategory.TabIndex = 3;
            this.tpAddCategory.Text = "Category";
            this.tpAddCategory.UseVisualStyleBackColor = true;
            // 
            // tpAddDiscountGood
            // 
            this.tpAddDiscountGood.Controls.Add(this.cbAddCategoryId);
            this.tpAddDiscountGood.Controls.Add(this.cbAddCountryCategoryId);
            this.tpAddDiscountGood.Controls.Add(this.dtpAddDiscountFinish);
            this.tpAddDiscountGood.Controls.Add(this.dtpAddDiscountStart);
            this.tpAddDiscountGood.Controls.Add(this.tbAddDiscountName);
            this.tpAddDiscountGood.Location = new System.Drawing.Point(4, 22);
            this.tpAddDiscountGood.Name = "tpAddDiscountGood";
            this.tpAddDiscountGood.Size = new System.Drawing.Size(748, 333);
            this.tpAddDiscountGood.TabIndex = 4;
            this.tpAddDiscountGood.Text = "Discount good";
            this.tpAddDiscountGood.UseVisualStyleBackColor = true;
            // 
            // tpUpdate
            // 
            this.tpUpdate.Location = new System.Drawing.Point(4, 22);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdate.Size = new System.Drawing.Size(768, 400);
            this.tpUpdate.TabIndex = 1;
            this.tpUpdate.Text = "Update";
            this.tpUpdate.UseVisualStyleBackColor = true;
            // 
            // tpDelete
            // 
            this.tpDelete.Location = new System.Drawing.Point(4, 22);
            this.tpDelete.Name = "tpDelete";
            this.tpDelete.Size = new System.Drawing.Size(768, 400);
            this.tpDelete.TabIndex = 2;
            this.tpDelete.Text = "Delete";
            this.tpDelete.UseVisualStyleBackColor = true;
            // 
            // tpShop
            // 
            this.tpShop.Location = new System.Drawing.Point(4, 22);
            this.tpShop.Name = "tpShop";
            this.tpShop.Size = new System.Drawing.Size(768, 400);
            this.tpShop.TabIndex = 3;
            this.tpShop.Text = "Show";
            this.tpShop.UseVisualStyleBackColor = true;
            // 
            // tbAddCountryName
            // 
            this.tbAddCountryName.Location = new System.Drawing.Point(61, 11);
            this.tbAddCountryName.Name = "tbAddCountryName";
            this.tbAddCountryName.Size = new System.Drawing.Size(681, 20);
            this.tbAddCountryName.TabIndex = 0;
            // 
            // lCountryName
            // 
            this.lCountryName.AutoSize = true;
            this.lCountryName.Location = new System.Drawing.Point(17, 14);
            this.lCountryName.Name = "lCountryName";
            this.lCountryName.Size = new System.Drawing.Size(38, 13);
            this.lCountryName.TabIndex = 1;
            this.lCountryName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // tbAddCityName
            // 
            this.tbAddCityName.Location = new System.Drawing.Point(71, 15);
            this.tbAddCityName.Name = "tbAddCityName";
            this.tbAddCityName.Size = new System.Drawing.Size(665, 20);
            this.tbAddCityName.TabIndex = 2;
            // 
            // cbAddCountryId
            // 
            this.cbAddCountryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddCountryId.FormattingEnabled = true;
            this.cbAddCountryId.Location = new System.Drawing.Point(71, 41);
            this.cbAddCountryId.Name = "cbAddCountryId";
            this.cbAddCountryId.Size = new System.Drawing.Size(665, 21);
            this.cbAddCountryId.TabIndex = 4;
            // 
            // lCountryId
            // 
            this.lCountryId.AutoSize = true;
            this.lCountryId.Location = new System.Drawing.Point(11, 44);
            this.lCountryId.Name = "lCountryId";
            this.lCountryId.Size = new System.Drawing.Size(46, 13);
            this.lCountryId.TabIndex = 5;
            this.lCountryId.Text = "Country:";
            // 
            // lAddCategoriesName
            // 
            this.lAddCategoriesName.AutoSize = true;
            this.lAddCategoriesName.Location = new System.Drawing.Point(10, 19);
            this.lAddCategoriesName.Name = "lAddCategoriesName";
            this.lAddCategoriesName.Size = new System.Drawing.Size(38, 13);
            this.lAddCategoriesName.TabIndex = 3;
            this.lAddCategoriesName.Text = "Name:";
            // 
            // tbAddCategoriesName
            // 
            this.tbAddCategoriesName.Location = new System.Drawing.Point(54, 16);
            this.tbAddCategoriesName.Name = "tbAddCategoriesName";
            this.tbAddCategoriesName.Size = new System.Drawing.Size(681, 20);
            this.tbAddCategoriesName.TabIndex = 2;
            // 
            // tbAddDiscountName
            // 
            this.tbAddDiscountName.Location = new System.Drawing.Point(283, 101);
            this.tbAddDiscountName.Name = "tbAddDiscountName";
            this.tbAddDiscountName.Size = new System.Drawing.Size(200, 20);
            this.tbAddDiscountName.TabIndex = 0;
            // 
            // dtpAddDiscountStart
            // 
            this.dtpAddDiscountStart.Location = new System.Drawing.Point(283, 181);
            this.dtpAddDiscountStart.Name = "dtpAddDiscountStart";
            this.dtpAddDiscountStart.Size = new System.Drawing.Size(200, 20);
            this.dtpAddDiscountStart.TabIndex = 1;
            // 
            // dtpAddDiscountFinish
            // 
            this.dtpAddDiscountFinish.Location = new System.Drawing.Point(283, 207);
            this.dtpAddDiscountFinish.Name = "dtpAddDiscountFinish";
            this.dtpAddDiscountFinish.Size = new System.Drawing.Size(200, 20);
            this.dtpAddDiscountFinish.TabIndex = 2;
            // 
            // cbAddCountryCategoryId
            // 
            this.cbAddCountryCategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddCountryCategoryId.FormattingEnabled = true;
            this.cbAddCountryCategoryId.Location = new System.Drawing.Point(283, 154);
            this.cbAddCountryCategoryId.Name = "cbAddCountryCategoryId";
            this.cbAddCountryCategoryId.Size = new System.Drawing.Size(200, 21);
            this.cbAddCountryCategoryId.TabIndex = 3;
            // 
            // cbAddCategoryId
            // 
            this.cbAddCategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddCategoryId.FormattingEnabled = true;
            this.cbAddCategoryId.Location = new System.Drawing.Point(283, 127);
            this.cbAddCategoryId.Name = "cbAddCategoryId";
            this.cbAddCategoryId.Size = new System.Drawing.Size(200, 21);
            this.cbAddCategoryId.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Dapper - HW";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.tbMain.ResumeLayout(false);
            this.tpAdding.ResumeLayout(false);
            this.tcAddings.ResumeLayout(false);
            this.tpAddCustomer.ResumeLayout(false);
            this.tpAddCustomer.PerformLayout();
            this.tpAddCountry.ResumeLayout(false);
            this.tpAddCountry.PerformLayout();
            this.tpAddCity.ResumeLayout(false);
            this.tpAddCity.PerformLayout();
            this.tpAddCategory.ResumeLayout(false);
            this.tpAddCategory.PerformLayout();
            this.tpAddDiscountGood.ResumeLayout(false);
            this.tpAddDiscountGood.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tpAdding;
        private System.Windows.Forms.TabControl tcAddings;
        private System.Windows.Forms.TabPage tpAddCustomer;
        private System.Windows.Forms.TabPage tpAddCountry;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.TabPage tpDelete;
        private System.Windows.Forms.TabPage tpShop;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TabPage tpAddCity;
        private System.Windows.Forms.TabPage tpAddCategory;
        private System.Windows.Forms.TabPage tpAddDiscountGood;
        private System.Windows.Forms.TextBox tbAddEmail;
        private System.Windows.Forms.TextBox tbAddSurname;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.Label lAddCity;
        private System.Windows.Forms.Label lAddBirthDate;
        private System.Windows.Forms.Label lAddEmail;
        private System.Windows.Forms.Label lAddSurname;
        private System.Windows.Forms.Label lAddName;
        private System.Windows.Forms.CheckBox cbAddIsMale;
        private System.Windows.Forms.ComboBox cbAddCity;
        private System.Windows.Forms.DateTimePicker dtpAddBirthDate;
        private System.Windows.Forms.Label lCountryName;
        private System.Windows.Forms.TextBox tbAddCountryName;
        private System.Windows.Forms.Label lCountryId;
        private System.Windows.Forms.ComboBox cbAddCountryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddCityName;
        private System.Windows.Forms.Label lAddCategoriesName;
        private System.Windows.Forms.TextBox tbAddCategoriesName;
        private System.Windows.Forms.ComboBox cbAddCategoryId;
        private System.Windows.Forms.ComboBox cbAddCountryCategoryId;
        private System.Windows.Forms.DateTimePicker dtpAddDiscountFinish;
        private System.Windows.Forms.DateTimePicker dtpAddDiscountStart;
        private System.Windows.Forms.TextBox tbAddDiscountName;
    }
}

