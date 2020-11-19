using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VedioRental
{
    public partial class VedioRental : Form
    {
        ClassDatabase Obj_Data = new ClassDatabase();
        public VedioRental()
        {
            InitializeComponent();
            Customer_Load();
            Movies_Load();
            Rental_Load();
        }
        public void Customer_Load()
        {
            dgv_customer.DataSource = null;
            try
            {
                dgv_customer.DataSource = Obj_Data.FillCustomer_Data();
                dgv_customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Movies_Load()
        {
            dgv_movie.DataSource = null;
            try
            {
                dgv_movie.DataSource = Obj_Data.FillMovies_Data();
                dgv_movie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Rental_Load()
        {
            dgv_rental.DataSource = null;
            try
            {
                dgv_rental.DataSource = Obj_Data.FillRent_Data();
                dgv_rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void VedioRental_Load(object sender, EventArgs e)
        {

        }

       
    }
}
