namespace BookBiz.GUI
{
    partial class SalesManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesManager));
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxControlSales = new System.Windows.Forms.GroupBox();
            this.labelFaxNumber = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxFaxNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCreditLimit = new System.Windows.Forms.TextBox();
            this.labelCreditLimit = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.groupBoxControlSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(144, 501);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(194, 26);
            this.textBoxSearchName.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 425);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(131, 425);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(93, 30);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(131, 568);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(93, 30);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(245, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 498);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 30);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search Name";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBoxControlSales
            // 
            this.groupBoxControlSales.Controls.Add(this.labelFaxNumber);
            this.groupBoxControlSales.Controls.Add(this.labelPhoneNumber);
            this.groupBoxControlSales.Controls.Add(this.textBoxSearchName);
            this.groupBoxControlSales.Controls.Add(this.maskedTextBoxFaxNumber);
            this.groupBoxControlSales.Controls.Add(this.btnAdd);
            this.groupBoxControlSales.Controls.Add(this.btnModify);
            this.groupBoxControlSales.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.groupBoxControlSales.Controls.Add(this.btnList);
            this.groupBoxControlSales.Controls.Add(this.textBoxCreditLimit);
            this.groupBoxControlSales.Controls.Add(this.btnDelete);
            this.groupBoxControlSales.Controls.Add(this.labelCreditLimit);
            this.groupBoxControlSales.Controls.Add(this.btnSearch);
            this.groupBoxControlSales.Controls.Add(this.textBoxCity);
            this.groupBoxControlSales.Controls.Add(this.labelName);
            this.groupBoxControlSales.Controls.Add(this.textBoxPostalCode);
            this.groupBoxControlSales.Controls.Add(this.textBoxName);
            this.groupBoxControlSales.Controls.Add(this.labelPostalCode);
            this.groupBoxControlSales.Controls.Add(this.labelStreet);
            this.groupBoxControlSales.Controls.Add(this.textBoxStreet);
            this.groupBoxControlSales.Controls.Add(this.labelCity);
            this.groupBoxControlSales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxControlSales.Location = new System.Drawing.Point(17, 12);
            this.groupBoxControlSales.Name = "groupBoxControlSales";
            this.groupBoxControlSales.Size = new System.Drawing.Size(354, 635);
            this.groupBoxControlSales.TabIndex = 21;
            this.groupBoxControlSales.TabStop = false;
            // 
            // labelFaxNumber
            // 
            this.labelFaxNumber.AutoSize = true;
            this.labelFaxNumber.Location = new System.Drawing.Point(12, 282);
            this.labelFaxNumber.Name = "labelFaxNumber";
            this.labelFaxNumber.Size = new System.Drawing.Size(93, 18);
            this.labelFaxNumber.TabIndex = 21;
            this.labelFaxNumber.Text = "Fax Number";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(16, 227);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(112, 18);
            this.labelPhoneNumber.TabIndex = 20;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // maskedTextBoxFaxNumber
            // 
            this.maskedTextBoxFaxNumber.Location = new System.Drawing.Point(131, 278);
            this.maskedTextBoxFaxNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxFaxNumber.Name = "maskedTextBoxFaxNumber";
            this.maskedTextBoxFaxNumber.Size = new System.Drawing.Size(119, 26);
            this.maskedTextBoxFaxNumber.TabIndex = 6;
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(131, 223);
            this.maskedTextBoxPhoneNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(119, 26);
            this.maskedTextBoxPhoneNumber.TabIndex = 5;
            // 
            // textBoxCreditLimit
            // 
            this.textBoxCreditLimit.Location = new System.Drawing.Point(131, 332);
            this.textBoxCreditLimit.Name = "textBoxCreditLimit";
            this.textBoxCreditLimit.Size = new System.Drawing.Size(207, 26);
            this.textBoxCreditLimit.TabIndex = 7;
            // 
            // labelCreditLimit
            // 
            this.labelCreditLimit.AutoSize = true;
            this.labelCreditLimit.Location = new System.Drawing.Point(12, 337);
            this.labelCreditLimit.Name = "labelCreditLimit";
            this.labelCreditLimit.Size = new System.Drawing.Size(89, 18);
            this.labelCreditLimit.TabIndex = 22;
            this.labelCreditLimit.Text = "Credit Limit";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(131, 120);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(207, 26);
            this.textBoxCity.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 18);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Name";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(131, 170);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(207, 26);
            this.textBoxPostalCode.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(131, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(207, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(12, 175);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(95, 18);
            this.labelPostalCode.TabIndex = 19;
            this.labelPostalCode.Text = "Postal Code";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(12, 76);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(50, 18);
            this.labelStreet.TabIndex = 17;
            this.labelStreet.Text = "Street";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(131, 71);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(207, 26);
            this.textBoxStreet.TabIndex = 2;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(12, 125);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 18);
            this.labelCity.TabIndex = 18;
            this.labelCity.Text = "City";
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(397, 21);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.Size = new System.Drawing.Size(939, 626);
            this.dataGridViewSales.TabIndex = 20;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1214, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 30);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.btnLogout);
            this.groupBoxOptions.Location = new System.Drawing.Point(17, 664);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(1319, 59);
            this.groupBoxOptions.TabIndex = 22;
            this.groupBoxOptions.TabStop = false;
            // 
            // SalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 741);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxControlSales);
            this.Controls.Add(this.dataGridViewSales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesManager";
            this.Text = "SalesManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesManager_FormClosed);
            this.Load += new System.EventHandler(this.SalesManager_Load);
            this.groupBoxControlSales.ResumeLayout(false);
            this.groupBoxControlSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.groupBoxOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxControlSales;
        private System.Windows.Forms.TextBox textBoxCreditLimit;
        private System.Windows.Forms.Label labelCreditLimit;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Label labelFaxNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFaxNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBoxOptions;
    }
}