using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;




namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            produk Produk = new produk();
           
            Produk.tgl_produksi = dateTimePicker1.Text;
            Produk.shift =  comboBox1.Text;
            Produk.kode_produk = kd_produksi.Text;
            Produk.jumlah_produk = jumlah.Text;

            produksiEntities1 dbEntities = new produksiEntities1();
            dbEntities.produks.Add(Produk);
            dbEntities.SaveChanges();



            //tgl.Text = string.Empty;
            //shift.Text = string.Empty;
            kd_produksi.Text = string.Empty;
            jumlah.Text = string.Empty;

            dgv.DataSource = dbEntities.produks.ToList<produk>();
            dgv.Refresh();


        }
     


        private void Form1_Load(object sender, EventArgs e)
        {
           produksiEntities1 dbentities = new produksiEntities1();
          
            dgv.DataSource = dbentities.produks.ToList();

            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");

       
        }
         private int yangdipilih()
        {
            DataGridViewRow curentRow = dgv.SelectedRows[0];
            int terpilih = Convert.ToInt32(curentRow.Cells[0].Value);
            return terpilih;
        }
        private void btnHapus_Click(object sender, EventArgs e)
        {
            int terpilih = yangdipilih();
            using (produksiEntities1 entity = new produksiEntities1())
            {
                var query = from st in entity.produks where st.Id == terpilih select st;
                var product = query.FirstOrDefault<produk>();

                entity.produks.Remove(product);
                entity.SaveChanges();
                MessageBox.Show("Terhapus");
                dgv.DataSource = entity.produks.ToList<produk>();
                dgv.Refresh();
            }
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
      


        private void btnUbah_Click(object sender, EventArgs e)
        {
            DataGridViewRow curentRow = dgv.SelectedRows[0];
            int terpilih = Convert.ToInt32(curentRow.Cells[0].Value);
          
            using (produksiEntities1 entity = new produksiEntities1())
            {
                var query = from st in entity.produks where st.Id == terpilih select st;
                var product = query.FirstOrDefault<produk>();

                FormUbah formubah = new FormUbah(product);
                formubah.ShowDialog();



            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void jumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            produksiEntities1 dbEntities = new produksiEntities1();
            dgv.DataSource = dbEntities.produks.ToList<produk>();
            dgv.Refresh();
        }
    }
}

