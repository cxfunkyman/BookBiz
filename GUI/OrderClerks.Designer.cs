namespace BookBiz.GUI
{
    partial class OrderClerks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderClerks));
            this.groupBoxButtons2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearchOrder = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrderClerk = new System.Windows.Forms.DataGridView();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.textBoxQTY = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelQty = new System.Windows.Forms.Label();
            this.textBoxOrder = new System.Windows.Forms.TextBox();
            this.labelBook = new System.Windows.Forms.Label();
            this.textBoxDeleteOrder = new System.Windows.Forms.TextBox();
            this.groupBoxButtons2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderClerk)).BeginInit();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxButtons2
            // 
            this.groupBoxButtons2.Controls.Add(this.textBoxDeleteOrder);
            this.groupBoxButtons2.Controls.Add(this.labelBook);
            this.groupBoxButtons2.Controls.Add(this.textBoxOrder);
            this.groupBoxButtons2.Controls.Add(this.labelQty);
            this.groupBoxButtons2.Controls.Add(this.labelOrder);
            this.groupBoxButtons2.Controls.Add(this.labelClient);
            this.groupBoxButtons2.Controls.Add(this.textBoxQTY);
            this.groupBoxButtons2.Controls.Add(this.comboBoxClient);
            this.groupBoxButtons2.Controls.Add(this.comboBoxBook);
            this.groupBoxButtons2.Controls.Add(this.textBoxSearchOrder);
            this.groupBoxButtons2.Controls.Add(this.btnAdd);
            this.groupBoxButtons2.Controls.Add(this.btnList);
            this.groupBoxButtons2.Controls.Add(this.btnDelete);
            this.groupBoxButtons2.Controls.Add(this.btnSearchOrder);
            this.groupBoxButtons2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxButtons2.Location = new System.Drawing.Point(12, 17);
            this.groupBoxButtons2.Name = "groupBoxButtons2";
            this.groupBoxButtons2.Size = new System.Drawing.Size(1599, 191);
            this.groupBoxButtons2.TabIndex = 22;
            this.groupBoxButtons2.TabStop = false;
            // 
            // textBoxSearchOrder
            // 
            this.textBoxSearchOrder.Location = new System.Drawing.Point(541, 133);
            this.textBoxSearchOrder.Name = "textBoxSearchOrder";
            this.textBoxSearchOrder.Size = new System.Drawing.Size(157, 26);
            this.textBoxSearchOrder.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1090, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 56);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(1090, 101);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(135, 56);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(733, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(407, 131);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(128, 30);
            this.btnSearchOrder.TabIndex = 10;
            this.btnSearchOrder.Text = "Search Order";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // dataGridViewOrderClerk
            // 
            this.dataGridViewOrderClerk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderClerk.Location = new System.Drawing.Point(12, 214);
            this.dataGridViewOrderClerk.Name = "dataGridViewOrderClerk";
            this.dataGridViewOrderClerk.Size = new System.Drawing.Size(1599, 384);
            this.dataGridViewOrderClerk.TabIndex = 15;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.btnLogout);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 605);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(1599, 59);
            this.groupBoxOptions.TabIndex = 23;
            this.groupBoxOptions.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1488, 17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 30);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(459, 28);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(239, 26);
            this.comboBoxBook.TabIndex = 1;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(459, 78);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(239, 26);
            this.comboBoxClient.TabIndex = 2;
            // 
            // textBoxQTY
            // 
            this.textBoxQTY.Location = new System.Drawing.Point(784, 28);
            this.textBoxQTY.Name = "textBoxQTY";
            this.textBoxQTY.Size = new System.Drawing.Size(239, 26);
            this.textBoxQTY.TabIndex = 3;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(405, 82);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(48, 18);
            this.labelClient.TabIndex = 17;
            this.labelClient.Text = "Client";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(730, 80);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(48, 18);
            this.labelOrder.TabIndex = 17;
            this.labelOrder.Text = "Order";
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Location = new System.Drawing.Point(730, 32);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(31, 18);
            this.labelQty.TabIndex = 17;
            this.labelQty.Text = "Qty";
            // 
            // textBoxOrder
            // 
            this.textBoxOrder.Location = new System.Drawing.Point(784, 76);
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.ReadOnly = true;
            this.textBoxOrder.Size = new System.Drawing.Size(239, 26);
            this.textBoxOrder.TabIndex = 4;
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Location = new System.Drawing.Point(405, 32);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(45, 18);
            this.labelBook.TabIndex = 19;
            this.labelBook.Text = "Book";
            // 
            // textBoxDeleteOrder
            // 
            this.textBoxDeleteOrder.Location = new System.Drawing.Point(866, 131);
            this.textBoxDeleteOrder.Name = "textBoxDeleteOrder";
            this.textBoxDeleteOrder.Size = new System.Drawing.Size(157, 26);
            this.textBoxDeleteOrder.TabIndex = 20;
            // 
            // OrderClerks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 672);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxButtons2);
            this.Controls.Add(this.dataGridViewOrderClerk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderClerks";
            this.Text = "Older Clerks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderClerks_FormClosed);
            this.Load += new System.EventHandler(this.OrderClerks_Load);
            this.groupBoxButtons2.ResumeLayout(false);
            this.groupBoxButtons2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderClerk)).EndInit();
            this.groupBoxOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxButtons2;
        private System.Windows.Forms.TextBox textBoxSearchOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrderClerk;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.TextBox textBoxOrder;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxQTY;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.TextBox textBoxDeleteOrder;
    }
}