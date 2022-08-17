using BookBiz.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz.Validation;
using BookBiz.BLL;

namespace BookBiz.GUI
{
    public partial class OrderClerks : Form
    {
        public OrderClerks()
        {
            InitializeComponent();
        }

        private void OrderClerks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login listForm = new Login(); //opens the windows form listform
            listForm.Show();
        }

        private void CBBook()
        {
            comboBoxBook.DataSource = DA_OrderClerks.dtComboBox("book_view");
            comboBoxBook.DisplayMember = "Title";
            comboBoxBook.ValueMember = "Title";
        }

        private void CBClient()
        {
            comboBoxClient.DataSource = DA_OrderClerks.dtComboBox("client_view");
            comboBoxClient.DisplayMember = "Name";
            comboBoxClient.ValueMember = "Name";
        }

        private void OrderClerks_Load(object sender, EventArgs e)
        {
            dataGridViewOrderClerk.DataSource = DA_OrderClerks.dtOrderClerk();
            CBBook();
            CBClient();
            textBoxOrder.Text = DA_OrderClerks.NextOrderNumber();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmpty(comboBoxBook.Text) &&
               Validator.IsEmpty(comboBoxClient.Text) &&
               Validator.IsEmpty(textBoxQTY.Text))
            {
                Orders ord = new Orders();

                ord.OrderNumber = textBoxOrder.Text;
                ord.BookID = comboBoxBook.Text;
                ord.ClientID = comboBoxClient.Text;
                ord.QTY = textBoxQTY.Text;

                DA_OrderClerks.SaveOrders(ord);
                dataGridViewOrderClerk.DataSource = DA_OrderClerks.dtOrderClerk();
                textBoxQTY.Clear();
                textBoxOrder.Text = DA_OrderClerks.NextOrderNumber();
                MessageBox.Show("Order has been added");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxDeleteOrder.Text))
            {
                DA_OrderClerks.DeleteOrders(textBoxDeleteOrder.Text);
                dataGridViewOrderClerk.DataSource = DA_OrderClerks.dtOrderClerk();
                MessageBox.Show("Order has been deleted");
                textBoxDeleteOrder.Clear();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridViewOrderClerk.DataSource = DA_OrderClerks.dtOrderClerk();
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxSearchOrder.Text))
            {
                dataGridViewOrderClerk.DataSource = DA_OrderClerks.SearchOrders(textBoxSearchOrder.Text);
                
            }  
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
