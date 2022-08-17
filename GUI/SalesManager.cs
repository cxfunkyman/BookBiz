using BookBiz.DAL;
using BookBiz.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookBiz.BLL;

namespace BookBiz.GUI
{
    public partial class SalesManager : Form
    {
        DataTable dt = new DataTable();
        string anyID;

        public SalesManager()
        {
            InitializeComponent();
        }

        private void SalesManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login listForm = new Login(); //opens the windows form listform
            listForm.Show();
        }

        private void SalesManager_Load(object sender, EventArgs e)
        {
            dataGridViewSales.DataSource = DA_SalesManager.dtSales();
        }

        private void ClearAll()
        {
            textBoxName.Clear();
            textBoxStreet.Clear();
            textBoxCity.Clear();
            textBoxPostalCode.Clear();
            maskedTextBoxPhoneNumber.Clear();
            maskedTextBoxFaxNumber.Clear();
            textBoxCreditLimit.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmpty(textBoxName.Text) &&
               Validator.IsEmpty(textBoxStreet.Text) &&
               Validator.IsEmpty(textBoxCity.Text) &&
               Validator.IsEmpty(textBoxPostalCode.Text) &&
               Validator.IsEmpty(maskedTextBoxPhoneNumber.Text) &&
               Validator.IsEmpty(maskedTextBoxFaxNumber.Text) &&
               Validator.IsEmpty(textBoxCreditLimit.Text))
            {
                Clients cli = new Clients();

                cli.Name = textBoxName.Text;
                cli.Street = textBoxStreet.Text;
                cli.City = textBoxCity.Text;
                cli.PostalCode = textBoxPostalCode.Text;
                cli.PhoneNumber = maskedTextBoxPhoneNumber.Text;
                cli.FaxNumber = maskedTextBoxFaxNumber.Text;
                cli.CreditLimit = textBoxCreditLimit.Text;

                DA_SalesManager.SaveClient(cli);
                dataGridViewSales.DataSource = DA_SalesManager.dtSales();
                MessageBox.Show("Client has been added");
                ClearAll();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxName.Text) &&
               Validator.IsEmpty(textBoxStreet.Text) &&
               Validator.IsEmpty(textBoxCity.Text) &&
               Validator.IsEmpty(textBoxPostalCode.Text) &&
               Validator.IsEmpty(maskedTextBoxPhoneNumber.Text) &&
               Validator.IsEmpty(maskedTextBoxFaxNumber.Text) &&
               Validator.IsEmpty(textBoxCreditLimit.Text))
            {
                Clients cli = new Clients();

                cli.ClientId = anyID;
                cli.Name = textBoxName.Text;
                cli.Street = textBoxStreet.Text;
                cli.City = textBoxCity.Text;
                cli.PostalCode = textBoxPostalCode.Text;
                cli.PhoneNumber = maskedTextBoxPhoneNumber.Text;
                cli.FaxNumber = maskedTextBoxFaxNumber.Text;
                cli.CreditLimit = textBoxCreditLimit.Text;

                DA_SalesManager.ModifyClient(cli);
                dataGridViewSales.DataSource = DA_SalesManager.dtSales();
                MessageBox.Show("Client has been updated");
                ClearAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxName.Text) &&
                Validator.IsEmpty(textBoxStreet.Text) &&
                Validator.IsEmpty(textBoxCity.Text) &&
                Validator.IsEmpty(textBoxPostalCode.Text) &&
                Validator.IsEmpty(maskedTextBoxPhoneNumber.Text) &&
                Validator.IsEmpty(maskedTextBoxFaxNumber.Text) &&
                Validator.IsEmpty(textBoxCreditLimit.Text))
            {
                Clients cli = new Clients();

                cli.ClientId = anyID;

                DA_SalesManager.DeleteClient(cli);
                dataGridViewSales.DataSource = DA_SalesManager.dtSales();
                MessageBox.Show("Client has been deleted");
                ClearAll();
                textBoxSearchName.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxSearchName.Text))
            {
                Clients cli = DA_SalesManager.SearchClient(textBoxSearchName.Text);

                anyID = cli.ClientId;
                textBoxName.Text = cli.Name;
                textBoxStreet.Text = cli.Street;
                textBoxCity.Text = cli.City;
                textBoxPostalCode.Text = cli.PostalCode;
                maskedTextBoxPhoneNumber.Text = cli.PhoneNumber;
                maskedTextBoxFaxNumber.Text = cli.FaxNumber;
                textBoxCreditLimit.Text = cli.CreditLimit;
                
                textBoxSearchName.Clear();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridViewSales.DataSource = DA_SalesManager.dtSales();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
