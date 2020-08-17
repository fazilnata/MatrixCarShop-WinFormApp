using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NataCarShop.Forms
{
    public partial class AdminLogIn : Form
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }
        public bool ControlEmpty()
        {
            bool control = true;
            if (admintxt.Text == "") { admintxt.ErrorText = "Admin bölməsini doldurun!"; control = false; }
            if (passwordtxt.Text == "") { passwordtxt.ErrorText = "Şifrə bölməsini doldurun!"; control = false; }
            return control;
        }
        private void AdminGoBtn_Click(object sender, EventArgs e)
        {
            string ad;
            ad = admintxt.Text;
            if (ControlEmpty() == true)
            {
                if (ad.ToLower() == "nata" && passwordtxt.Text == "12345") { MessageBox.Show("Uğurlu qoşulma"); AdminPage1 ap = new AdminPage1(); this.Hide(); ap.ShowDialog(); this.Close(); }
                else { MessageBox.Show("Daxil etdiyiniz məlumatlar yalnışdır!"); }
            }

        }

      

        private void AdminLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainPage mp = new MainPage();
            mp.ShowDialog();
        }
    }
}
