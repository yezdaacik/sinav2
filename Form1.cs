using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yezdanur815
{
    public partial class Form1 : Form
    {
        BindingList <Islem> islemler = new BindingList<Islem> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Islem islem1 = new Islem (1, "İnternet", new DateTime (2023,10,12),"Fatura", 41, true);
            Islem islem2 = new Islem(2, "Elektrik", new DateTime(2023, 11, 13), "Ek Gelir", 40, true);
            Islem islem3 = new Islem(3, "Su", new DateTime(2023, 11, 11), "Fatura", 42, false);
            Islem islem4 = new Islem(4, "Hastane", new DateTime(2024, 02, 01), "Ek Gelir", 43, false);
            Islem islem5 = new Islem(5, "Mesai", new DateTime(2023, 12, 31), "Ek Gelir", 40, false);

            islemler.Add(islem1);
            islemler.Add(islem2);
            islemler.Add(islem3);
            islemler.Add(islem4);
            islemler.Add(islem5);

            dataGridViewIslem.DataSource = islemler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string tanim = txtTanim.Text;
            DateTime tarih = DateTime.Now;
            string tur = cmbTuryapip.Text;
            int miktar = Convert.ToInt32(numMiktaryapip.Value);
            bool gelir = cbGelir.Checked;

            Islem islem = new Islem(id, tanim, tarih, tur, miktar, gelir);

            islemler.Add(islem);

            txtId.Clear();
            txtTanim.Clear();
            cbGelir.Checked = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewIslem.SelectedRows.Count > 0)
            {
                Islem islem = (Islem)dataGridViewIslem.SelectedRows[0].DataBoundItem;

                islem.Id = Convert.ToInt32(txtId.Text);
                islem.Tanim = txtTanim.Text;
                islem.Tarih = dtTarih.Value;
                islem.Tur = cmbTuryapip.SelectedText;
                islem.Miktar = Convert.ToInt32(numMiktaryapip.Value);
                islem.Gelir = cbGelir.Checked;
                
            }
            dataGridViewIslem.Refresh();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewIslem.SelectedRows.Count > 0)
            {
                Islem islem = (Islem)dataGridViewIslem.SelectedRows[0].DataBoundItem;

                DialogResult sonuc = MessageBox.Show(islem.Tur + " silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    islemler.Remove(islem);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
         Application.Exit(); 
        }

        private void dataGridViewIslem_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewIslem.SelectedRows.Count > 0)
            {
                Islem islem = (Islem)dataGridViewIslem.SelectedRows[0].DataBoundItem;

                txtId.Text = islem.Id.ToString();
                txtTanim.Text = islem.Tanim;
                dtTarih.Value = islem.Tarih;
                cmbTuryapip.Text = islem.Tur;
                numMiktaryapip.Value = Convert.ToDecimal(islem.Miktar);
                cbGelir.Checked = islem.Gelir;
            }
        }
    }
}
