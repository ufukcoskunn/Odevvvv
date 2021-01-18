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
    public partial class Ogretmen : Form
    {
        MsqlDal1 ms = new MsqlDal1(@"Data Source=DESKTOP-HDAQ64V\SQLEXPRESS01;Initial Catalog=Okul;Integrated Security=True;");
        byte Cinsiyet = 0;
        private Teacher teacher;

        public Ogretmen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id;
            int Sinif;
            char Sube;
            string SinifSube = txtSinif.Text.ToUpper();
            string[] Args = SinifSube.Split('/');
            Sinif = Convert.ToInt32(Args[0]);
            Sube = Convert.ToChar(Args[1]);
            Id = ms.GetSubeId(Sinif, Sube);
            Student student = new Student
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Tc = txtTc.Text,
                Email = txtEmail.Text,
                Gsm = txtGsm.Text,
                SubeId = Id,
                Cinsiyet = Cinsiyet,
                DogumTarihi = (dTpDogum.Value)



            };
            ms.Add(teacher);
            DGVogretmen.DataSource = ms.GetAll();
        }

        private void CbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbCins.Text == "Erkek")
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
    }
}
    

