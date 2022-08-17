namespace BookBiz.GUI
{
    partial class MISManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MISManager));
            this.menuStripMIS = new System.Windows.Forms.MenuStrip();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.groupBoxButtons2 = new System.Windows.Forms.GroupBox();
            this.labelSearchBy2 = new System.Windows.Forms.Label();
            this.comboBoxSearchBy2 = new System.Windows.Forms.ComboBox();
            this.textBoxSearch2 = new System.Windows.Forms.TextBox();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnModify2 = new System.Windows.Forms.Button();
            this.btnList2 = new System.Windows.Forms.Button();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.groupBoxDetails2 = new System.Windows.Forms.GroupBox();
            this.labelUserName2 = new System.Windows.Forms.Label();
            this.textBoxUserName2 = new System.Windows.Forms.TextBox();
            this.comboBoxRole2 = new System.Windows.Forms.ComboBox();
            this.labelRole2 = new System.Windows.Forms.Label();
            this.textBoxEmail2 = new System.Windows.Forms.TextBox();
            this.labelFName2 = new System.Windows.Forms.Label();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.textBoxFName2 = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.labelLName2 = new System.Windows.Forms.Label();
            this.textBoxLName2 = new System.Windows.Forms.TextBox();
            this.labelEmail2 = new System.Windows.Forms.Label();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBoxButtons1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnModify1 = new System.Windows.Forms.Button();
            this.btnList1 = new System.Windows.Forms.Button();
            this.buttonDelete1 = new System.Windows.Forms.Button();
            this.groupBoxDetails1 = new System.Windows.Forms.GroupBox();
            this.textBoxRole1 = new System.Windows.Forms.TextBox();
            this.textBoxSearchEmployeeName = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPassword1 = new System.Windows.Forms.Label();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.labelRole1 = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.tabControlMIS = new System.Windows.Forms.TabControl();
            this.tabPageEmployee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxButtons2.SuspendLayout();
            this.groupBoxDetails2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.tabPageUsers.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxButtons1.SuspendLayout();
            this.groupBoxDetails1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabControlMIS.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMIS
            // 
            this.menuStripMIS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMIS.Location = new System.Drawing.Point(0, 0);
            this.menuStripMIS.Name = "menuStripMIS";
            this.menuStripMIS.Size = new System.Drawing.Size(1234, 24);
            this.menuStripMIS.TabIndex = 1;
            this.menuStripMIS.Text = "menuStrip1";
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.groupBox1);
            this.tabPageEmployee.Controls.Add(this.groupBoxButtons2);
            this.tabPageEmployee.Controls.Add(this.groupBoxDetails2);
            this.tabPageEmployee.Controls.Add(this.dataGridViewEmployee);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 27);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(1226, 626);
            this.tabPageEmployee.TabIndex = 1;
            this.tabPageEmployee.Text = "Employee";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogout2);
            this.groupBox1.Location = new System.Drawing.Point(14, 558);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1199, 59);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btnLogout2
            // 
            this.btnLogout2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout2.Location = new System.Drawing.Point(1093, 19);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(93, 30);
            this.btnLogout2.TabIndex = 14;
            this.btnLogout2.Text = "Logout";
            this.btnLogout2.UseVisualStyleBackColor = true;
            this.btnLogout2.Click += new System.EventHandler(this.btnLogout2_Click);
            // 
            // groupBoxButtons2
            // 
            this.groupBoxButtons2.Controls.Add(this.labelSearchBy2);
            this.groupBoxButtons2.Controls.Add(this.comboBoxSearchBy2);
            this.groupBoxButtons2.Controls.Add(this.textBoxSearch2);
            this.groupBoxButtons2.Controls.Add(this.btnAdd2);
            this.groupBoxButtons2.Controls.Add(this.btnModify2);
            this.groupBoxButtons2.Controls.Add(this.btnList2);
            this.groupBoxButtons2.Controls.Add(this.btnDelete2);
            this.groupBoxButtons2.Controls.Add(this.btnSearch2);
            this.groupBoxButtons2.Location = new System.Drawing.Point(14, 334);
            this.groupBoxButtons2.Name = "groupBoxButtons2";
            this.groupBoxButtons2.Size = new System.Drawing.Size(354, 218);
            this.groupBoxButtons2.TabIndex = 16;
            this.groupBoxButtons2.TabStop = false;
            // 
            // labelSearchBy2
            // 
            this.labelSearchBy2.AutoSize = true;
            this.labelSearchBy2.Location = new System.Drawing.Point(19, 130);
            this.labelSearchBy2.Name = "labelSearchBy2";
            this.labelSearchBy2.Size = new System.Drawing.Size(80, 18);
            this.labelSearchBy2.TabIndex = 14;
            this.labelSearchBy2.Text = "Search By";
            // 
            // comboBoxSearchBy2
            // 
            this.comboBoxSearchBy2.FormattingEnabled = true;
            this.comboBoxSearchBy2.Items.AddRange(new object[] {
            "Fist Name",
            "Last Name",
            "User Name"});
            this.comboBoxSearchBy2.Location = new System.Drawing.Point(135, 127);
            this.comboBoxSearchBy2.Name = "comboBoxSearchBy2";
            this.comboBoxSearchBy2.Size = new System.Drawing.Size(207, 26);
            this.comboBoxSearchBy2.TabIndex = 12;
            // 
            // textBoxSearch2
            // 
            this.textBoxSearch2.Location = new System.Drawing.Point(135, 80);
            this.textBoxSearch2.Name = "textBoxSearch2";
            this.textBoxSearch2.Size = new System.Drawing.Size(207, 26);
            this.textBoxSearch2.TabIndex = 11;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(22, 25);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(93, 30);
            this.btnAdd2.TabIndex = 7;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnModify2
            // 
            this.btnModify2.Location = new System.Drawing.Point(135, 25);
            this.btnModify2.Name = "btnModify2";
            this.btnModify2.Size = new System.Drawing.Size(93, 30);
            this.btnModify2.TabIndex = 8;
            this.btnModify2.Text = "Modify";
            this.btnModify2.UseVisualStyleBackColor = true;
            this.btnModify2.Click += new System.EventHandler(this.btnModify2_Click);
            // 
            // btnList2
            // 
            this.btnList2.Location = new System.Drawing.Point(22, 171);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(93, 30);
            this.btnList2.TabIndex = 13;
            this.btnList2.Text = "List";
            this.btnList2.UseVisualStyleBackColor = true;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(249, 25);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(93, 30);
            this.btnDelete2.TabIndex = 9;
            this.btnDelete2.Text = "Delete";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(22, 77);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(93, 30);
            this.btnSearch2.TabIndex = 10;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // groupBoxDetails2
            // 
            this.groupBoxDetails2.Controls.Add(this.labelUserName2);
            this.groupBoxDetails2.Controls.Add(this.textBoxUserName2);
            this.groupBoxDetails2.Controls.Add(this.comboBoxRole2);
            this.groupBoxDetails2.Controls.Add(this.labelRole2);
            this.groupBoxDetails2.Controls.Add(this.textBoxEmail2);
            this.groupBoxDetails2.Controls.Add(this.labelFName2);
            this.groupBoxDetails2.Controls.Add(this.textBoxPassword2);
            this.groupBoxDetails2.Controls.Add(this.textBoxFName2);
            this.groupBoxDetails2.Controls.Add(this.labelPassword2);
            this.groupBoxDetails2.Controls.Add(this.labelLName2);
            this.groupBoxDetails2.Controls.Add(this.textBoxLName2);
            this.groupBoxDetails2.Controls.Add(this.labelEmail2);
            this.groupBoxDetails2.Location = new System.Drawing.Point(14, 7);
            this.groupBoxDetails2.Name = "groupBoxDetails2";
            this.groupBoxDetails2.Size = new System.Drawing.Size(354, 321);
            this.groupBoxDetails2.TabIndex = 15;
            this.groupBoxDetails2.TabStop = false;
            // 
            // labelUserName2
            // 
            this.labelUserName2.AutoSize = true;
            this.labelUserName2.Location = new System.Drawing.Point(19, 176);
            this.labelUserName2.Name = "labelUserName2";
            this.labelUserName2.Size = new System.Drawing.Size(87, 18);
            this.labelUserName2.TabIndex = 17;
            this.labelUserName2.Text = "User Name";
            // 
            // textBoxUserName2
            // 
            this.textBoxUserName2.Location = new System.Drawing.Point(112, 171);
            this.textBoxUserName2.Name = "textBoxUserName2";
            this.textBoxUserName2.Size = new System.Drawing.Size(207, 26);
            this.textBoxUserName2.TabIndex = 4;
            // 
            // comboBoxRole2
            // 
            this.comboBoxRole2.FormattingEnabled = true;
            this.comboBoxRole2.Items.AddRange(new object[] {
            "MIS Manager",
            "Sales Manager",
            "Inventory Controller",
            "Order Clerk"});
            this.comboBoxRole2.Location = new System.Drawing.Point(112, 269);
            this.comboBoxRole2.Name = "comboBoxRole2";
            this.comboBoxRole2.Size = new System.Drawing.Size(207, 26);
            this.comboBoxRole2.TabIndex = 6;
            // 
            // labelRole2
            // 
            this.labelRole2.AutoSize = true;
            this.labelRole2.Location = new System.Drawing.Point(19, 277);
            this.labelRole2.Name = "labelRole2";
            this.labelRole2.Size = new System.Drawing.Size(40, 18);
            this.labelRole2.TabIndex = 15;
            this.labelRole2.Text = "Role";
            // 
            // textBoxEmail2
            // 
            this.textBoxEmail2.Location = new System.Drawing.Point(112, 127);
            this.textBoxEmail2.Name = "textBoxEmail2";
            this.textBoxEmail2.Size = new System.Drawing.Size(207, 26);
            this.textBoxEmail2.TabIndex = 3;
            // 
            // labelFName2
            // 
            this.labelFName2.AutoSize = true;
            this.labelFName2.Location = new System.Drawing.Point(19, 38);
            this.labelFName2.Name = "labelFName2";
            this.labelFName2.Size = new System.Drawing.Size(85, 18);
            this.labelFName2.TabIndex = 10;
            this.labelFName2.Text = "First Name";
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(112, 220);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(207, 26);
            this.textBoxPassword2.TabIndex = 5;
            // 
            // textBoxFName2
            // 
            this.textBoxFName2.Location = new System.Drawing.Point(112, 33);
            this.textBoxFName2.Name = "textBoxFName2";
            this.textBoxFName2.Size = new System.Drawing.Size(207, 26);
            this.textBoxFName2.TabIndex = 1;
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Location = new System.Drawing.Point(19, 225);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(78, 18);
            this.labelPassword2.TabIndex = 13;
            this.labelPassword2.Text = "Password";
            // 
            // labelLName2
            // 
            this.labelLName2.AutoSize = true;
            this.labelLName2.Location = new System.Drawing.Point(19, 83);
            this.labelLName2.Name = "labelLName2";
            this.labelLName2.Size = new System.Drawing.Size(84, 18);
            this.labelLName2.TabIndex = 11;
            this.labelLName2.Text = "Last Name";
            // 
            // textBoxLName2
            // 
            this.textBoxLName2.Location = new System.Drawing.Point(112, 78);
            this.textBoxLName2.Name = "textBoxLName2";
            this.textBoxLName2.Size = new System.Drawing.Size(207, 26);
            this.textBoxLName2.TabIndex = 2;
            // 
            // labelEmail2
            // 
            this.labelEmail2.AutoSize = true;
            this.labelEmail2.Location = new System.Drawing.Point(19, 132);
            this.labelEmail2.Name = "labelEmail2";
            this.labelEmail2.Size = new System.Drawing.Size(48, 18);
            this.labelEmail2.TabIndex = 12;
            this.labelEmail2.Text = "Email";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(380, 16);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(833, 536);
            this.dataGridViewEmployee.TabIndex = 1;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.groupBoxOptions);
            this.tabPageUsers.Controls.Add(this.groupBoxButtons1);
            this.tabPageUsers.Controls.Add(this.groupBoxDetails1);
            this.tabPageUsers.Controls.Add(this.dataGridViewUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 27);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(1226, 626);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.btnLogout);
            this.groupBoxOptions.Location = new System.Drawing.Point(13, 556);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(1205, 59);
            this.groupBoxOptions.TabIndex = 23;
            this.groupBoxOptions.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1100, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 30);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBoxButtons1
            // 
            this.groupBoxButtons1.Controls.Add(this.label1);
            this.groupBoxButtons1.Controls.Add(this.btnAdd1);
            this.groupBoxButtons1.Controls.Add(this.btnModify1);
            this.groupBoxButtons1.Controls.Add(this.btnList1);
            this.groupBoxButtons1.Controls.Add(this.buttonDelete1);
            this.groupBoxButtons1.Location = new System.Drawing.Point(13, 335);
            this.groupBoxButtons1.Name = "groupBoxButtons1";
            this.groupBoxButtons1.Size = new System.Drawing.Size(354, 217);
            this.groupBoxButtons1.TabIndex = 15;
            this.groupBoxButtons1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Only User Name and Password can be updated";
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(16, 75);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(129, 51);
            this.btnAdd1.TabIndex = 7;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnModify1
            // 
            this.btnModify1.Location = new System.Drawing.Point(190, 75);
            this.btnModify1.Name = "btnModify1";
            this.btnModify1.Size = new System.Drawing.Size(129, 51);
            this.btnModify1.TabIndex = 8;
            this.btnModify1.Text = "Modify";
            this.btnModify1.UseVisualStyleBackColor = true;
            this.btnModify1.Click += new System.EventHandler(this.btnModify1_Click);
            // 
            // btnList1
            // 
            this.btnList1.Location = new System.Drawing.Point(13, 144);
            this.btnList1.Name = "btnList1";
            this.btnList1.Size = new System.Drawing.Size(129, 51);
            this.btnList1.TabIndex = 13;
            this.btnList1.Text = "List";
            this.btnList1.UseVisualStyleBackColor = true;
            this.btnList1.Click += new System.EventHandler(this.btnList1_Click);
            // 
            // buttonDelete1
            // 
            this.buttonDelete1.Location = new System.Drawing.Point(190, 144);
            this.buttonDelete1.Name = "buttonDelete1";
            this.buttonDelete1.Size = new System.Drawing.Size(129, 51);
            this.buttonDelete1.TabIndex = 9;
            this.buttonDelete1.Text = "Delete";
            this.buttonDelete1.UseVisualStyleBackColor = true;
            this.buttonDelete1.Click += new System.EventHandler(this.buttonDelete1_Click);
            // 
            // groupBoxDetails1
            // 
            this.groupBoxDetails1.Controls.Add(this.textBoxRole1);
            this.groupBoxDetails1.Controls.Add(this.textBoxSearchEmployeeName);
            this.groupBoxDetails1.Controls.Add(this.btnSearchEmployee);
            this.groupBoxDetails1.Controls.Add(this.labelUserName);
            this.groupBoxDetails1.Controls.Add(this.textBoxUserName);
            this.groupBoxDetails1.Controls.Add(this.labelName);
            this.groupBoxDetails1.Controls.Add(this.textBoxName);
            this.groupBoxDetails1.Controls.Add(this.labelPassword1);
            this.groupBoxDetails1.Controls.Add(this.textBoxPassword1);
            this.groupBoxDetails1.Controls.Add(this.labelRole1);
            this.groupBoxDetails1.Location = new System.Drawing.Point(13, 8);
            this.groupBoxDetails1.Name = "groupBoxDetails1";
            this.groupBoxDetails1.Size = new System.Drawing.Size(354, 321);
            this.groupBoxDetails1.TabIndex = 14;
            this.groupBoxDetails1.TabStop = false;
            // 
            // textBoxRole1
            // 
            this.textBoxRole1.Location = new System.Drawing.Point(112, 188);
            this.textBoxRole1.Name = "textBoxRole1";
            this.textBoxRole1.ReadOnly = true;
            this.textBoxRole1.Size = new System.Drawing.Size(207, 26);
            this.textBoxRole1.TabIndex = 4;
            // 
            // textBoxSearchEmployeeName
            // 
            this.textBoxSearchEmployeeName.Location = new System.Drawing.Point(76, 237);
            this.textBoxSearchEmployeeName.Name = "textBoxSearchEmployeeName";
            this.textBoxSearchEmployeeName.Size = new System.Drawing.Size(207, 26);
            this.textBoxSearchEmployeeName.TabIndex = 5;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(76, 277);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(207, 30);
            this.btnSearchEmployee.TabIndex = 6;
            this.btnSearchEmployee.Text = "Search Employee Name";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(19, 82);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(87, 18);
            this.labelUserName.TabIndex = 14;
            this.labelUserName.Text = "User Name";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(112, 77);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(207, 26);
            this.textBoxUserName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 18);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(112, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(207, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // labelPassword1
            // 
            this.labelPassword1.AutoSize = true;
            this.labelPassword1.Location = new System.Drawing.Point(19, 137);
            this.labelPassword1.Name = "labelPassword1";
            this.labelPassword1.Size = new System.Drawing.Size(78, 18);
            this.labelPassword1.TabIndex = 11;
            this.labelPassword1.Text = "Password";
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Location = new System.Drawing.Point(112, 132);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(207, 26);
            this.textBoxPassword1.TabIndex = 3;
            // 
            // labelRole1
            // 
            this.labelRole1.AutoSize = true;
            this.labelRole1.Location = new System.Drawing.Point(19, 191);
            this.labelRole1.Name = "labelRole1";
            this.labelRole1.Size = new System.Drawing.Size(40, 18);
            this.labelRole1.TabIndex = 12;
            this.labelRole1.Text = "Role";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(379, 16);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(839, 502);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // tabControlMIS
            // 
            this.tabControlMIS.Controls.Add(this.tabPageUsers);
            this.tabControlMIS.Controls.Add(this.tabPageEmployee);
            this.tabControlMIS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMIS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMIS.Location = new System.Drawing.Point(0, 24);
            this.tabControlMIS.Name = "tabControlMIS";
            this.tabControlMIS.SelectedIndex = 0;
            this.tabControlMIS.Size = new System.Drawing.Size(1234, 657);
            this.tabControlMIS.TabIndex = 0;
            // 
            // MISManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 681);
            this.Controls.Add(this.tabControlMIS);
            this.Controls.Add(this.menuStripMIS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMIS;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MISManager";
            this.Text = "MIS Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MISManager_FormClosed);
            this.Load += new System.EventHandler(this.MISManager_Load);
            this.tabPageEmployee.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxButtons2.ResumeLayout(false);
            this.groupBoxButtons2.PerformLayout();
            this.groupBoxDetails2.ResumeLayout(false);
            this.groupBoxDetails2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.tabPageUsers.ResumeLayout(false);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxButtons1.ResumeLayout(false);
            this.groupBoxButtons1.PerformLayout();
            this.groupBoxDetails1.ResumeLayout(false);
            this.groupBoxDetails1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabControlMIS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMIS;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.Button buttonDelete1;
        private System.Windows.Forms.Button btnModify1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TabControl tabControlMIS;
        private System.Windows.Forms.GroupBox groupBoxButtons2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnModify2;
        private System.Windows.Forms.Button btnList2;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.GroupBox groupBoxDetails2;
        private System.Windows.Forms.TextBox textBoxEmail2;
        private System.Windows.Forms.Label labelFName2;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.TextBox textBoxFName2;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.Label labelLName2;
        private System.Windows.Forms.TextBox textBoxLName2;
        private System.Windows.Forms.Label labelEmail2;
        private System.Windows.Forms.GroupBox groupBoxButtons1;
        private System.Windows.Forms.Button btnList1;
        private System.Windows.Forms.GroupBox groupBoxDetails1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPassword1;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.Label labelRole1;
        private System.Windows.Forms.Label labelSearchBy2;
        private System.Windows.Forms.ComboBox comboBoxSearchBy2;
        private System.Windows.Forms.TextBox textBoxSearch2;
        private System.Windows.Forms.Label labelRole2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.ComboBox comboBoxRole2;
        private System.Windows.Forms.TextBox textBoxSearchEmployeeName;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.TextBox textBoxRole1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserName2;
        private System.Windows.Forms.TextBox textBoxUserName2;
    }
}