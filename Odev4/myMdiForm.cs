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
    public partial class myMdiForm : Form
    {
        public myMdiForm()
        {
            InitializeComponent();
        }

        public void ChildForm(Form childForm)
        {
            this.Width = childForm.Width + 25;
            this.Height = childForm.Height + 70;

            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == childForm.Text)
                {
                    frm.Activate();
                    durum = true;
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }

        }

        private void ogrenciKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Ogrenci());
        }

        private void ogretmenKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Ogretmen());
        }
    }
}
