using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odev4
{
    public partial class Ogrenci : Form
    {
        
        MsqlDal ms = new MsqlDal(@"Data Source=DESKTOP-HDAQ64V\SQLEXPRESS01;Initial Catalog=Okul;Integrated Security=True;");
        byte Cinsiyet = 0;

        public Ogrenci()
        {
            InitializeComponent();
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            DgvOgrenci.DataSource = ms.GetAll();

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            int Id;
            int Sinif;
            char Sube;
            string SinifSube = TxtSinif.Text.ToUpper();
            string[] Args = SinifSube.Split('/');
            Sinif = Convert.ToInt32(Args[0]);
            Sube = Convert.ToChar(Args[1]);
            Id = ms.GetSubeId(Sinif,Sube);
            Student student = new Student
            {
                Ad = txtAd.Text,
                Soyad = txtSoyAd.Text,
                Tc = txtTc.Text,
                Email = txtEmail.Text,
                Gsm = txtGsm.Text,
                SubeId = Id,
                Cinsiyet = Cinsiyet,
                DogumTarihi = (DtpDogumTarihi.Value)
                
                
                
            };
            ms.Add(student);
            DgvOgrenci.DataSource = ms.GetAll();
        }

        private void CbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbCinsiyet.Text=="Erkek")
            {
                Cinsiyet = 1;
            }
            else
            {
                Cinsiyet = 0;
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvOgrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
