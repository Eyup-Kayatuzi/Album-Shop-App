using Shop.BLL.Controller;
using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.UI
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            var forControl = ArtistController.GetAllDatas().FirstOrDefault(x => x.Name == txt_aRTİSTaD.Text);
            if(forControl == null)
            {
                AlbumController.AddAlbum(new Album() { IsContinue = true, AlbumPrice = Convert.ToDecimal(txt_Fiyat.Text), ReleaseDate = txt_YayinYil.Text, Name = txt_AlbumAd.Text, Artist = new Artist() { Name = txt_aRTİSTaD.Text } });
                MessageBox.Show("Eklendi");
            }
            else
            {
                AlbumController.AddAlbum(new Album() { Name = txt_AlbumAd.Text, ArtistId = forControl.ArtistId });
                MessageBox.Show("Eklendi");
            }
  
        }

        private void Data_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AlbumController.GetAllDatas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            var selectedAlbum = dataGridView1.SelectedRows[0].DataBoundItem as Album;
            selectedAlbum.Name = txt_AlbumAd.Text;
            selectedAlbum.ReleaseDate = txt_YayinYil.Text;
            selectedAlbum.AlbumPrice = decimal.Parse(txt_Fiyat.Text);
            selectedAlbum.IsContinue = true;
            selectedAlbum.AlbumDiscount = 12;
            var forControl = ArtistController.GetAllDatas().FirstOrDefault(x => x.Name == txt_aRTİSTaD.Text);
            if (forControl == null)
            {
                selectedAlbum.Artist = new Artist() { Name = txt_aRTİSTaD.Text };
                AlbumController.UpdateAlbum(selectedAlbum);
                MessageBox.Show("Guncellendi");
            }
            else
            {
                AlbumController.UpdateAlbum(selectedAlbum);
                MessageBox.Show("Guncellendi");
            }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            var selectedAlbum = dataGridView1.SelectedRows[0].DataBoundItem as Album;
            AlbumController.DeleteAlbum(selectedAlbum);
            MessageBox.Show("Silindi");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = AlbumController.GetAllDatas().Where(x => !x.IsContinue).ToList();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = AlbumController.GetAllDatas().Where(x => x.IsContinue).ToList();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = AlbumController.GetAllDatas().OrderByDescending(x => x.AlbumId).Take(10).ToList();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = AlbumController.GetAllDatas().Where(x => x.AlbumDiscount > 0).ToList();

        }
    }
}
