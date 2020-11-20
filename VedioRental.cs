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

        private void add_cust_btn_Click(object sender, EventArgs e)
        {
            if (tb_first_name.Text != "" && tb_last_name.Text != "" && tb_address.Text != "" && tb_phone.Text != "")
            {
                string message = Obj_Data.CustomerInsert(tb_first_name.Text, tb_last_name.Text, tb_phone.Text, tb_address.Text);
                MessageBox.Show(message);
                tb_first_name.Text = "";
                tb_last_name.Text = "";
                tb_phone.Text = "";
                tb_address.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the required details and add the new details by clicking Add button");
            }
        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = dgv_customer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.CustomerID = Convert.ToInt32(dgv_customer.Rows[e.RowIndex].Cells[0].Value);
                tb_first_name.Text = dgv_customer.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_last_name.Text = dgv_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_phone.Text = dgv_customer.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_address.Text = dgv_customer.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_cust_name_rental.Text = dgv_customer.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dgv_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }

        private void update_cust_btn_Click(object sender, EventArgs e)
        {
            if (tb_first_name.Text != "" && tb_last_name.Text != "" && tb_address.Text != "" && tb_phone.Text != "")
            {
                string message = Obj_Data.CustomerUpdate(tb_first_name.Text, tb_last_name.Text, tb_phone.Text, tb_address.Text);
                MessageBox.Show(message);
                tb_first_name.Text = "";
                tb_last_name.Text = "";
                tb_phone.Text = "";
                tb_address.Text = "";
                tb_cust_name_rental.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the required details and add the new details by clicking Add button");
            }


        }

        private void del_cust_btn_Click(object sender, EventArgs e)
        {
            string message = Obj_Data.CustomerDelete();
            MessageBox.Show(message);
            tb_first_name.Text = "";
            tb_last_name.Text = "";
            tb_phone.Text = "";
            tb_address.Text = "";
            tb_cust_name_rental.Text = "";
            Customer_Load();
        }
    }
    
}
