using Shop.BLL.Controller;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.UI
{
    public partial class Registered : Form
    {
        public Registered()
        {
            InitializeComponent();
        }

        private void txt_Login_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text.Length <= 8)
            {
                MessageBox.Show("Şifreniz en az 8 karakter uzunluğunda olmalıdır.");
                return;
            }

            int uppercaseCount = 0;
            int lowercaseCount = 0;
            int specialCharCount = 0;

            // büyük harf, küçük harf ve özel karakter sayısı kontrolü
            foreach (char c in txt_Password.Text)
            {
                if (char.IsUpper(c))
                {
                    uppercaseCount++;
                }
                else if (char.IsLower(c))
                {
                    lowercaseCount++;
                }
                else if (char.IsPunctuation(c))
                {
                    specialCharCount++;
                }
            }

            if (uppercaseCount < 2 || lowercaseCount < 3 || specialCharCount < 2)
            {
                MessageBox.Show("Şifreniz en az 2 buyuk harf, 3 küçük harf ve 2 özel karakter içermelidir.");
                return;
            }
            else if (txt_Password.Text != txt_RePassword.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
                return;
            }

            else
            {
                
                ManagerController.AddManager(new Manager { UserName = txt_UserName.Text, Name = txt_Name.Text, Password = ManagerController.sha256_hash(txt_Password.Text) });
                MessageBox.Show("Başarıyla giriş yaptınız");
                this.Close();
            }
        }
    }
}
