using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTurEkle_Click(object sender, EventArgs e)
        {
            frmTurler frm = new frmTurler();
            frm.ShowDialog();
        }

        private void btnSarkiciEkle_Click(object sender, EventArgs e)
        {
            frmSarkicilar frm = new frmSarkicilar();
            frm.ShowDialog();
        }

        private void btnAlbumEkle_Click(object sender, EventArgs e)
        {
            frmAlbumler frm = new frmAlbumler();
            frm.ShowDialog();
        }
    }
}
