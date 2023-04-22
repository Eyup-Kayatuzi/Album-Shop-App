using Microsoft.VisualBasic.ApplicationServices;
using Shop.BLL.Controller;
using Shop.Model.Models;
using System.Linq;

namespace Shop.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Login_Click(object sender, EventArgs e)
        {
            var gelen = ManagerController.GetAllDatas().Where(x => x.UserName == txt_UserName.Text && x.Password == ManagerController.sha256_hash(txt_Password.Text));
            if (gelen.Count() != 0 )
            {
                Data data = new Data();
                data.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya şifre Hatalı");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registered rg = new Registered();
            rg.ShowDialog();
        }
    }
}