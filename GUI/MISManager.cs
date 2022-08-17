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
using BookBiz.Validation;
using BookBiz.BLL;

namespace BookBiz.GUI
{
    public partial class MISManager : Form
    {
        private string employeeID;

        public MISManager()
        {
            InitializeComponent();
        }

        private void ClearUsers()
        {
            textBoxName.Clear();
            textBoxUserName.Clear();
            textBoxPassword1.Clear();
            textBoxRole1.Clear();
            textBoxSearchEmployeeName.Clear();
            textBoxSearchEmployeeName.Focus();
        }

        private void ClearEmployee()
        {
            textBoxFName2.Clear();
            textBoxLName2.Clear();
            textBoxEmail2.Clear();
            textBoxUserName2.Clear();
            textBoxPassword2.Clear();
            comboBoxRole2.ResetText();
            textBoxSearch2.Clear();            
            textBoxFName2.Focus();
        }

        private void MISManager_Load(object sender, EventArgs e)
        {
            dataGridViewEmployee.DataSource = DA_MISManager.dtEmployee();
            dataGridViewUsers.DataSource = DA_MISManager.dtUsers();
        }

        private void MISManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login listForm = new Login(); //opens the windows form listform
            listForm.Show();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmpty(textBoxName.Text) && Validator.IsEmpty(textBoxUserName.Text) && Validator.IsEmpty(textBoxPassword1.Text) && Validator.IsEmpty(textBoxRole1.Text))
            {
                User user = new User(
                    textBoxName.Text, 
                    textBoxUserName.Text, 
                    textBoxPassword1.Text,
                    textBoxRole1.Text);

                DA_MISManager.SaveUser(user);
                dataGridViewUsers.DataSource = DA_MISManager.dtUsers();
                MessageBox.Show("User has been added");
                ClearUsers();
            }
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {            
            if (Validator.IsEmpty(textBoxSearchEmployeeName.Text))
            {
                User user = new User();
                user = DA_MISManager.SearchEmployee(textBoxSearchEmployeeName.Text);

                employeeID = user.EmployeeID;
                textBoxName.Text = user.Name;
                textBoxUserName.Text = user.UserName;
                textBoxPassword1.Text = user.Password;
                textBoxRole1.Text = user.Position;                
            }
            else
                MessageBox.Show("Employee not found");                
        }

        private void btnModify1_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmpty(textBoxName.Text) && 
                Validator.IsEmpty(textBoxUserName.Text) && 
                Validator.IsEmpty(textBoxPassword1.Text) && 
                Validator.IsEmpty(textBoxRole1.Text))
            {
                User user = new User();
                user = DA_MISManager.SearchEmployee(textBoxSearchEmployeeName.Text);

                user.EmployeeID = user.EmployeeID;
                user.Name = textBoxName.Text;
                user.UserName = textBoxUserName.Text;
                user.Password = textBoxPassword1.Text;
                user.Position = textBoxRole1.Text;

                DA_MISManager.ModifyUser(user);
                dataGridViewUsers.DataSource = DA_MISManager.dtUsers();

                MessageBox.Show("User has been modify");
                ClearUsers();
            }
        }

        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxName.Text) &&
                Validator.IsEmpty(textBoxUserName.Text) &&
                Validator.IsEmpty(textBoxPassword1.Text) &&
                Validator.IsEmpty(textBoxRole1.Text))
            {
                User user = new User();
                user = DA_MISManager.SearchEmployee(textBoxSearchEmployeeName.Text);

                DA_MISManager.DeleteUser(user);
                dataGridViewUsers.DataSource = DA_MISManager.dtUsers();
                MessageBox.Show("User has been deleted");
                ClearUsers();
            }
        }

        private void btnList1_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = DA_MISManager.dtUsers();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxFName2.Text) && 
                Validator.IsEmpty(textBoxLName2.Text) && 
                Validator.IsEmpty(textBoxEmail2.Text) && 
                Validator.IsEmpty(textBoxUserName2.Text) && 
                Validator.IsEmpty(textBoxPassword2.Text) && 
                Validator.IsEmpty(comboBoxRole2.Text))
            {
                string roleNumber = DA_MISManager.RoleNumber(comboBoxRole2.Text);

                Employee emp = new Employee(
                    textBoxFName2.Text,
                    textBoxLName2.Text,
                    textBoxEmail2.Text,
                    textBoxUserName2.Text,
                    textBoxPassword2.Text,
                    roleNumber
                    );

                DA_MISManager.SaveEmployee(emp);
                dataGridViewEmployee.DataSource = DA_MISManager.dtEmployee();
                MessageBox.Show("Employee has been added");
                ClearEmployee();
            }
        }

        private void btnModify2_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxFName2.Text) &&
                Validator.IsEmpty(textBoxLName2.Text) &&
                Validator.IsEmpty(textBoxEmail2.Text) &&
                Validator.IsEmpty(textBoxUserName2.Text) &&
                Validator.IsEmpty(textBoxPassword2.Text) &&
                Validator.IsEmpty(comboBoxRole2.Text))
            {
                string roleNumber = DA_MISManager.RoleNumber(comboBoxRole2.Text);
                string empIDNumb = DA_MISManager.EmpIdNumber(comboBoxSearchBy2.SelectedIndex, textBoxSearch2.Text);

                Employee emp = new Employee(
                    textBoxFName2.Text,
                    textBoxLName2.Text,
                    textBoxEmail2.Text,
                    textBoxUserName2.Text,
                    textBoxPassword2.Text,
                    roleNumber
                    );

                DA_MISManager.ModifyEmployee(emp, empIDNumb);
                dataGridViewEmployee.DataSource = DA_MISManager.dtEmployee();
                MessageBox.Show("Employee has been updated");
                ClearEmployee();
            }

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(textBoxFName2.Text) &&
                Validator.IsEmpty(textBoxLName2.Text) &&
                Validator.IsEmpty(textBoxEmail2.Text) &&
                Validator.IsEmpty(textBoxUserName2.Text) &&
                Validator.IsEmpty(textBoxPassword2.Text) &&
                Validator.IsEmpty(comboBoxRole2.Text))
            {
                Employee emp = new Employee();
                emp = DA_MISManager.SearchEmployeeID(textBoxUserName2.Text);

                DA_MISManager.DeleteEmployee(emp.EmployeeID);
                dataGridViewEmployee.DataSource = DA_MISManager.dtEmployee();
                MessageBox.Show("Employee has been deleted");
                ClearEmployee();
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            if(Validator.IsEmpty(textBoxSearch2.Text) && Validator.IsEmpty(comboBoxSearchBy2.Text))
            {
                Employee emp = DA_MISManager.SearchEmployee(textBoxSearch2.Text, comboBoxSearchBy2.SelectedIndex);

                textBoxFName2.Text = emp.FirstName;
                textBoxLName2.Text = emp.LastName;
                textBoxEmail2.Text = emp.Email;
                textBoxUserName2.Text = emp.UserName;
                textBoxPassword2.Text = emp.Password;
                comboBoxRole2.SelectedIndex = ((Convert.ToInt32(emp.Role)) - 1);

            }
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            dataGridViewEmployee.DataSource = DA_MISManager.dtEmployee();
        }

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
