﻿using System;
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
//code to link the ClassDatabase with the VedioRental form
        ClassDatabase Obj_Data = new ClassDatabase();

        public VedioRental()
        {
            InitializeComponent();

//code to display the database while load or start the progamme or vedioRental form
            Customer_Load();
            Movies_Load();
            Rental_Load();
            Popular_Customer_Load();
            Popular_Movie_Load();
        }

//code to display the database of the customer table while load or start the progamme or vedioRental form
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

//code to display the database of movies table while load and start the progamme or vedioRental form
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

//code to display the database of rental table while load or start the progamme or vedioRental form
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
//code of POPULAR CUSTOMER
        public void Popular_Customer_Load()
        {
            dgv_popularCustomer.DataSource = null;
            try
            {
                dgv_popularCustomer.DataSource = Obj_Data.FillPopular_Customer();
                dgv_popularCustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


 //code of POPULAR MOVIE
        public void Popular_Movie_Load()
        {
            dgv_popularMovie.DataSource = null;
            try
            {
                dgv_popularMovie.DataSource = Obj_Data.FillPopular_Movie();
                dgv_popularMovie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void VedioRental_Load(object sender, EventArgs e)
        {

        }


//code of DATA GRID VIEW from the customer panel to Show the data after clicking on ADD,DELETE,UPDATE BUTTON and also show the database after starting the programme
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

                // code to show the message if user did not fill all the details
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }

        //code of ADD BUTTON from the customer panel to add the data after clicking on ADD BUTTON
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
// code to show the message if user did not fill all the details
                MessageBox.Show("All the required details are need to be filled");
            }
        }


//code of UPDATE BUTTON from the customer panel to update the data after clicking on UPDATE BUTTON
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
// code to show the message if user did not fill all the details
                MessageBox.Show("All the required details are need to be filled, after that click the Update button");
            }


        }

//code of DELETE BUTTON from the customer panel to delete the data after clicking on DELETE BUTTON
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

//code of DATA GRID VIEW of the Movie  panel to Show the data after clicking on ADD,DELETE,UPDATE BUTTON and also show the database after starting the programme
        private void dgv_movie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = dgv_movie.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.MovieID = Convert.ToInt32(dgv_movie.Rows[e.RowIndex].Cells[0].Value);
                tb_rating.Text = dgv_movie.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_title.Text = dgv_movie.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_year.Text = dgv_movie.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_rental_cost.Text = dgv_movie.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_copies.Text = dgv_movie.Rows[e.RowIndex].Cells[5].Value.ToString();
                tb_plot.Text = dgv_movie.Rows[e.RowIndex].Cells[6].Value.ToString();
                tb_genre.Text = dgv_movie.Rows[e.RowIndex].Cells[7].Value.ToString();
                tb_movie_name_rental.Text = dgv_movie.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

// code to show the message if user did not fill all the details or select something wrong while using the movie panel's button
                MessageBox.Show("Something is wrong", ex.Message);
            }

        }


//code of ADD BUTTON from the Movie panel to add the data after clicking on ADD BUTTON
        private void add_movie_btn_Click(object sender, EventArgs e)
        {
            if (tb_rating.Text != "" && tb_title.Text != "" && tb_year.Text != "" && tb_rental_cost.Text != "" && tb_copies.Text != "" && tb_plot.Text != "" && tb_genre.Text != "")
            {
                string message = Obj_Data.MovieInsert(tb_rating.Text, tb_title.Text, tb_year.Text, tb_rental_cost.Text, tb_copies.Text, tb_plot.Text, tb_genre.Text);
                MessageBox.Show(message);
                tb_rating.Text = "";
                tb_title.Text = "";
                tb_year.Text = "";
                tb_rental_cost.Text = "";
                tb_copies.Text = "";
                tb_plot.Text = "";
                tb_genre.Text = "";
                Movies_Load();
            }
            else
            {
                // code to show the message if user did not fill all the details
                MessageBox.Show("All the required details are need to be filled");
            }
        }


//code of UPDATE BUTTON from the movie panel to update the data after clicking on UPDATE BUTTON
        private void update_movie_btn_Click(object sender, EventArgs e)
        {
            if (tb_rating.Text != "" && tb_title.Text != "" && tb_year.Text != "" && tb_rental_cost.Text != "" && tb_copies.Text != "" && tb_plot.Text != "" && tb_genre.Text != "")
            {
                string message = Obj_Data.MovieUpdate(tb_rating.Text, tb_title.Text, tb_year.Text, tb_rental_cost.Text, tb_copies.Text, tb_plot.Text, tb_genre.Text);
                MessageBox.Show(message);
                tb_rating.Text = "";
                tb_title.Text = "";
                tb_year.Text = "";
                tb_rental_cost.Text = "";
                tb_copies.Text = "";
                tb_plot.Text = "";
                tb_genre.Text = "";
                Movies_Load();
            }
            else
            {
// code to show the message if user did not fill all the details
                MessageBox.Show("All the required details are need to be filled");
            }

        }

//code of DELETE BUTTON from the Movie panel to delete the data after clicking on Delete BUTTON
        private void del_movie_btn_Click(object sender, EventArgs e)
        {
            string message = Obj_Data.MovieDelete();
            MessageBox.Show(message);
            tb_rating.Text = "";
            tb_title.Text = "";
            tb_year.Text = "";
            tb_rental_cost.Text = "";
            tb_copies.Text = "";
            tb_plot.Text = "";
            tb_genre.Text = "";
            tb_movie_name_rental.Text = "";
            Movies_Load();
        }

  //code of ISSUE BUTTON from the rental panel to issue the movie to the customer after clicking on ISSUE BUTTON
        private void issue_btn_Click(object sender, EventArgs e)
        {
            if (tb_movie_name_rental.Text != "" && tb_cust_name_rental.Text != "")
            {
                string message = Obj_Data.IssueMovie(Convert.ToDateTime(DTP_Date_Rented_Rental.Text));
                MessageBox.Show(message);
                tb_rating.Text = "";
                tb_title.Text = "";
                tb_year.Text = "";
                tb_rental_cost.Text = "";
                tb_copies.Text = "";
                tb_plot.Text = "";
                tb_genre.Text = "";
                tb_movie_name_rental.Text = "";
                tb_first_name.Text = "";
                tb_last_name.Text = "";
                tb_phone.Text = "";
                tb_address.Text = "";
                tb_cust_name_rental.Text = "";

                Rental_Load();
            }
            else
            {

// code to show the message if user did not fill all the details
                MessageBox.Show("All the Required details are need to be filled and click the ISSUE button");
            }
        }


//code of RETURN BUTTON from the rental panel to show the data after clicking on RETURN BUTTON
        private void return_btn_Click(object sender, EventArgs e)
        {
            if (tb_movie_name_rental.Text != "" && tb_cust_name_rental.Text!="")
            {
                string message = Obj_Data.MovieReturn(Convert.ToDateTime(DTP_DateReturned_Rented.Text));
                MessageBox.Show(message);
                tb_rating.Text = "";
                tb_title.Text = "";
                tb_year.Text = "";
                tb_rental_cost.Text = "";
                tb_copies.Text = "";
                tb_plot.Text = "";
                tb_genre.Text = "";
                tb_movie_name_rental.Text = "";
                tb_first_name.Text = "";
                tb_last_name.Text = "";
                tb_phone.Text = "";
                tb_address.Text = "";
                tb_cust_name_rental.Text = "";
                Rental_Load();
            }
            else
            {
// code to show the message if user did not fill all the details
                MessageBox.Show("All the required details are need to be filled");
            }

        }


//code of allmovies button
        private void allmovies_btn_Click(object sender, EventArgs e)
        {
            Rental_Load();
        }


//code of rented out button
        private void rentedOut_btn_Click(object sender, EventArgs e)
        {
            dgv_rental.DataSource = null;
            try
            {
                dgv_rental.DataSource = Obj_Data.RentedOut_Data();
                dgv_rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

//code of DATA GRID VIEW of the Rental  panel to Show the data after clicking 
        private void dgv_rental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = dgv_rental.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.RentalMovieID = Convert.ToInt32(dgv_rental.Rows[e.RowIndex].Cells[9].Value);
                tb_movie_name_rental.Text = dgv_rental.Rows[e.RowIndex].Cells[6].Value.ToString();
                tb_cust_name_rental.Text = dgv_rental.Rows[e.RowIndex].Cells[0].Value.ToString()+""+dgv_rental.Rows[e.RowIndex].Cells[1].Value.ToString();
                DTP_Date_Rented_Rental.Text = dgv_rental.Rows[e.RowIndex].Cells[4].Value.ToString();
              
             
            }
            catch (Exception ex)
            {

// code to show the message if user did not fill all the details
                MessageBox.Show("Something is wrong", ex.Message);
            }

        }

     
    }
}
    

