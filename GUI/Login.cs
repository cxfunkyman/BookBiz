using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz.DAL;

namespace BookBiz.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DA_Login.Login(textBoxName.Text, textBoxPassword.Text))
            {
                string role = DA_Login.UserRole(textBoxName.Text);                

                if (role.Equals("MIS Manager"))
                {
                    MISManager listForm = new MISManager(); //opens the windows form listform
                    listForm.Show();
                    this.Hide();
                }
                else if (role.Equals("Sales Manager"))
                {
                    SalesManager listForm = new SalesManager(); //opens the windows form listform
                    listForm.Show();
                    this.Hide();
                }
                else if (role.Equals("Inventory Controller"))
                {
                    InventoryController listForm = new InventoryController(); //opens the windows form listform
                    listForm.Show();
                    this.Hide();
                }
                else if (role.Equals("Order Clerk"))
                {
                    OrderClerks listForm = new OrderClerks(); //opens the windows form listform
                    listForm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Department not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               // MessageBox.Show("User found!");
            else
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
