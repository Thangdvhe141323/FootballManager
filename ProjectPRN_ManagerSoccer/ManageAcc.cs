using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAO;

namespace ProjectPRN_ManagerSoccer
{
    public partial class ManageAcc : Form
    {
        Account account;
        public ManageAcc(Account acc)
        {
            this.account = acc;
            account = (new BUSUser()).checkUser(acc.UserName, acc.Password);
            InitializeComponent();
            
        }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            //var stringChars = new char[8];
            //var random = new Random();

            //for (int i = 0; i < stringChars.Length; i++)
            //{
            //     stringChars[i] = chars[random.Next(chars.Length)];
            //}

            //string pass = new String(stringChars);
            //string ans = (new DataProvider()).getAns("SELECT Answer FROM [User] WHERE UserName = '" + Account.UserName + "'");
            //string ques = (new DataProvider()).getAns("SELECT PrivateQuestion FROM [User] WHERE UserName = '" + Account.UserName + "'");
            //string email = (new DataProvider()).getAns("SELECT Email FROM [User] WHERE UserName = '" + Account.UserName + "'");
            //string phone = (new DataProvider()).getAns("SELECT Phone FROM [User] WHERE UserName = '" + Account.UserName + "'");
            //if (txtPhone.Text == phone && txtAns.Text==ans &&txtEmail.Text==email &&cbQues.Text==ques)
            //{
            //    (new BUSForgot()).Update(txtPassword.Text, ques, ans, phone, email, newpass);
            //    MessageBox.Show("Mat khau moi la:" + newpass);
            //    FrmLogin d = new FrmLogin();
            //    this.Hide();
            //    d.Show();
            //}
            if (txtAns.Text == "")
            {
                MessageBox.Show("Please input Answers");
            }
            else
            {
                if (txtPhone.Text == "")
                {
                    MessageBox.Show("Please input phone..");
                }
                else
                {
                    if (txtEmail.Text == "")
                    {
                        MessageBox.Show("Please input email..");
                    }
                    else
                    {
                        if((new BUSManageAcc()).updateAcc(txtPassword.Text, txtPhone.Text, txtEmail.Text, cbQues.SelectedItem.ToString(), txtAns.Text, account.UserID))
                        {
                            MessageBox.Show("Update success..");
                            FrmHome f = new FrmHome(account);
                            f.Show();
                            this.Hide();
                        }
                    }
                }
            }
            
            

        }

        private void FrmForgot_Load(object sender, EventArgs e)
        {
            txtPassword.Text = account.Password;
            cbQues.SelectedItem = account.PrivateQuesion;
            txtAns.Text = account.Answer;
            txtPhone.Text = account.Phone;
            txtEmail.Text = account.Email;
        }

        private void cbQues_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void txtAns_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome f = new FrmHome(account);
            f.Show();
            this.Hide();
        }
    }
}
