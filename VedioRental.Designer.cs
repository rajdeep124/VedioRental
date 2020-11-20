namespace VedioRental
{
    partial class VedioRental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.customer_tab = new System.Windows.Forms.TabPage();
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.movie_tab = new System.Windows.Forms.TabPage();
            this.dgv_movie = new System.Windows.Forms.DataGridView();
            this.rental_tab = new System.Windows.Forms.TabPage();
            this.dgv_rental = new System.Windows.Forms.DataGridView();
            this.customer_panel = new System.Windows.Forms.Panel();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_last_name = new System.Windows.Forms.TextBox();
            this.tb_first_name = new System.Windows.Forms.TextBox();
            this.update_cust_btn = new System.Windows.Forms.Button();
            this.del_cust_btn = new System.Windows.Forms.Button();
            this.add_cust_btn = new System.Windows.Forms.Button();
            this.phone_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.Last_Name_label = new System.Windows.Forms.Label();
            this.First_Name_label = new System.Windows.Forms.Label();
            this.customer_title = new System.Windows.Forms.Label();
            this.rental_panel = new System.Windows.Forms.Panel();
            this.tb_cust_name_rental = new System.Windows.Forms.TextBox();
            this.tb_movie_name_rental = new System.Windows.Forms.TextBox();
            this.update_rental_btn = new System.Windows.Forms.Button();
            this.del_rental_btn = new System.Windows.Forms.Button();
            this.add_rental_btn = new System.Windows.Forms.Button();
            this.date_returned_lbl_rental = new System.Windows.Forms.Label();
            this.date_rented_lbl_rental = new System.Windows.Forms.Label();
            this.cust_name_lbl_lbl = new System.Windows.Forms.Label();
            this.movie_name_lbl_rental = new System.Windows.Forms.Label();
            this.rental_title = new System.Windows.Forms.Label();
            this.movie_panel = new System.Windows.Forms.Panel();
            this.tb_genre = new System.Windows.Forms.TextBox();
            this.tb_plot = new System.Windows.Forms.TextBox();
            this.tb_copies = new System.Windows.Forms.TextBox();
            this.tb_rental_cost = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.tb_rating = new System.Windows.Forms.TextBox();
            this.del_movie_btn = new System.Windows.Forms.Button();
            this.update_movie_btn = new System.Windows.Forms.Button();
            this.add_movie_btn = new System.Windows.Forms.Button();
            this.genre_lbl = new System.Windows.Forms.Label();
            this.plot_lbl = new System.Windows.Forms.Label();
            this.copies_lbl = new System.Windows.Forms.Label();
            this.rental_cost_lbl = new System.Windows.Forms.Label();
            this.year_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.rating_lbl = new System.Windows.Forms.Label();
            this.movie_title = new System.Windows.Forms.Label();
            this.vedioRental_title_lbl = new System.Windows.Forms.Label();
            this.DTP_Date_Rented_Rental = new System.Windows.Forms.DateTimePicker();
            this.DTP_DateReturned_Rented = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.customer_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.movie_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movie)).BeginInit();
            this.rental_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rental)).BeginInit();
            this.customer_panel.SuspendLayout();
            this.rental_panel.SuspendLayout();
            this.movie_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.customer_tab);
            this.tabControl1.Controls.Add(this.movie_tab);
            this.tabControl1.Controls.Add(this.rental_tab);
            this.tabControl1.Location = new System.Drawing.Point(39, 111);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 341);
            this.tabControl1.TabIndex = 0;
            // 
            // customer_tab
            // 
            this.customer_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.customer_tab.Controls.Add(this.dgv_customer);
            this.customer_tab.Location = new System.Drawing.Point(4, 22);
            this.customer_tab.Name = "customer_tab";
            this.customer_tab.Padding = new System.Windows.Forms.Padding(3);
            this.customer_tab.Size = new System.Drawing.Size(536, 315);
            this.customer_tab.TabIndex = 0;
            this.customer_tab.Text = "Customer";
            // 
            // dgv_customer
            // 
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Location = new System.Drawing.Point(9, 9);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.Size = new System.Drawing.Size(521, 300);
            this.dgv_customer.TabIndex = 0;
            this.dgv_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellContentClick);
            this.dgv_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellContentClick);
            // 
            // movie_tab
            // 
            this.movie_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.movie_tab.Controls.Add(this.dgv_movie);
            this.movie_tab.Location = new System.Drawing.Point(4, 22);
            this.movie_tab.Name = "movie_tab";
            this.movie_tab.Padding = new System.Windows.Forms.Padding(3);
            this.movie_tab.Size = new System.Drawing.Size(536, 315);
            this.movie_tab.TabIndex = 1;
            this.movie_tab.Text = "Movie";
            // 
            // dgv_movie
            // 
            this.dgv_movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_movie.Location = new System.Drawing.Point(19, 18);
            this.dgv_movie.Name = "dgv_movie";
            this.dgv_movie.Size = new System.Drawing.Size(511, 285);
            this.dgv_movie.TabIndex = 0;
            // 
            // rental_tab
            // 
            this.rental_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rental_tab.Controls.Add(this.dgv_rental);
            this.rental_tab.Location = new System.Drawing.Point(4, 22);
            this.rental_tab.Name = "rental_tab";
            this.rental_tab.Padding = new System.Windows.Forms.Padding(3);
            this.rental_tab.Size = new System.Drawing.Size(536, 315);
            this.rental_tab.TabIndex = 2;
            this.rental_tab.Text = "Rental";
            // 
            // dgv_rental
            // 
            this.dgv_rental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rental.Location = new System.Drawing.Point(18, 19);
            this.dgv_rental.Name = "dgv_rental";
            this.dgv_rental.Size = new System.Drawing.Size(511, 285);
            this.dgv_rental.TabIndex = 0;
            // 
            // customer_panel
            // 
            this.customer_panel.Controls.Add(this.tb_phone);
            this.customer_panel.Controls.Add(this.tb_address);
            this.customer_panel.Controls.Add(this.tb_last_name);
            this.customer_panel.Controls.Add(this.tb_first_name);
            this.customer_panel.Controls.Add(this.update_cust_btn);
            this.customer_panel.Controls.Add(this.del_cust_btn);
            this.customer_panel.Controls.Add(this.add_cust_btn);
            this.customer_panel.Controls.Add(this.phone_label);
            this.customer_panel.Controls.Add(this.address_label);
            this.customer_panel.Controls.Add(this.Last_Name_label);
            this.customer_panel.Controls.Add(this.First_Name_label);
            this.customer_panel.Controls.Add(this.customer_title);
            this.customer_panel.Location = new System.Drawing.Point(637, 130);
            this.customer_panel.Name = "customer_panel";
            this.customer_panel.Size = new System.Drawing.Size(336, 268);
            this.customer_panel.TabIndex = 1;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(229, 189);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(100, 20);
            this.tb_phone.TabIndex = 11;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(229, 153);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(100, 20);
            this.tb_address.TabIndex = 10;
            // 
            // tb_last_name
            // 
            this.tb_last_name.Location = new System.Drawing.Point(229, 114);
            this.tb_last_name.Name = "tb_last_name";
            this.tb_last_name.Size = new System.Drawing.Size(100, 20);
            this.tb_last_name.TabIndex = 9;
            // 
            // tb_first_name
            // 
            this.tb_first_name.Location = new System.Drawing.Point(229, 78);
            this.tb_first_name.Name = "tb_first_name";
            this.tb_first_name.Size = new System.Drawing.Size(100, 20);
            this.tb_first_name.TabIndex = 8;
            // 
            // update_cust_btn
            // 
            this.update_cust_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.update_cust_btn.Location = new System.Drawing.Point(258, 227);
            this.update_cust_btn.Name = "update_cust_btn";
            this.update_cust_btn.Size = new System.Drawing.Size(75, 23);
            this.update_cust_btn.TabIndex = 7;
            this.update_cust_btn.Text = "Update";
            this.update_cust_btn.UseVisualStyleBackColor = false;
            this.update_cust_btn.Click += new System.EventHandler(this.update_cust_btn_Click);
            // 
            // del_cust_btn
            // 
            this.del_cust_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.del_cust_btn.Location = new System.Drawing.Point(128, 227);
            this.del_cust_btn.Name = "del_cust_btn";
            this.del_cust_btn.Size = new System.Drawing.Size(75, 23);
            this.del_cust_btn.TabIndex = 6;
            this.del_cust_btn.Text = "Delete";
            this.del_cust_btn.UseVisualStyleBackColor = false;
            this.del_cust_btn.Click += new System.EventHandler(this.del_cust_btn_Click);
            // 
            // add_cust_btn
            // 
            this.add_cust_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_cust_btn.Location = new System.Drawing.Point(4, 227);
            this.add_cust_btn.Name = "add_cust_btn";
            this.add_cust_btn.Size = new System.Drawing.Size(75, 23);
            this.add_cust_btn.TabIndex = 5;
            this.add_cust_btn.Text = "Add";
            this.add_cust_btn.UseVisualStyleBackColor = false;
            this.add_cust_btn.Click += new System.EventHandler(this.add_cust_btn_Click);
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(22, 196);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(38, 13);
            this.phone_label.TabIndex = 4;
            this.phone_label.Text = "Phone";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(21, 153);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(45, 13);
            this.address_label.TabIndex = 3;
            this.address_label.Text = "Address";
            // 
            // Last_Name_label
            // 
            this.Last_Name_label.AutoSize = true;
            this.Last_Name_label.Location = new System.Drawing.Point(21, 117);
            this.Last_Name_label.Name = "Last_Name_label";
            this.Last_Name_label.Size = new System.Drawing.Size(58, 13);
            this.Last_Name_label.TabIndex = 2;
            this.Last_Name_label.Text = "Last Name";
            // 
            // First_Name_label
            // 
            this.First_Name_label.AutoSize = true;
            this.First_Name_label.Location = new System.Drawing.Point(22, 78);
            this.First_Name_label.Name = "First_Name_label";
            this.First_Name_label.Size = new System.Drawing.Size(57, 13);
            this.First_Name_label.TabIndex = 1;
            this.First_Name_label.Text = "First Name";
            // 
            // customer_title
            // 
            this.customer_title.AutoSize = true;
            this.customer_title.BackColor = System.Drawing.Color.MediumPurple;
            this.customer_title.Font = new System.Drawing.Font("Script MT Bold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_title.Location = new System.Drawing.Point(88, 9);
            this.customer_title.Name = "customer_title";
            this.customer_title.Size = new System.Drawing.Size(200, 33);
            this.customer_title.TabIndex = 0;
            this.customer_title.Text = "Customer Details";
            // 
            // rental_panel
            // 
            this.rental_panel.Controls.Add(this.DTP_DateReturned_Rented);
            this.rental_panel.Controls.Add(this.DTP_Date_Rented_Rental);
            this.rental_panel.Controls.Add(this.tb_cust_name_rental);
            this.rental_panel.Controls.Add(this.tb_movie_name_rental);
            this.rental_panel.Controls.Add(this.update_rental_btn);
            this.rental_panel.Controls.Add(this.del_rental_btn);
            this.rental_panel.Controls.Add(this.add_rental_btn);
            this.rental_panel.Controls.Add(this.date_returned_lbl_rental);
            this.rental_panel.Controls.Add(this.date_rented_lbl_rental);
            this.rental_panel.Controls.Add(this.cust_name_lbl_lbl);
            this.rental_panel.Controls.Add(this.movie_name_lbl_rental);
            this.rental_panel.Controls.Add(this.rental_title);
            this.rental_panel.Location = new System.Drawing.Point(268, 466);
            this.rental_panel.Name = "rental_panel";
            this.rental_panel.Size = new System.Drawing.Size(380, 266);
            this.rental_panel.TabIndex = 2;
            // 
            // tb_cust_name_rental
            // 
            this.tb_cust_name_rental.Location = new System.Drawing.Point(165, 100);
            this.tb_cust_name_rental.Name = "tb_cust_name_rental";
            this.tb_cust_name_rental.Size = new System.Drawing.Size(100, 20);
            this.tb_cust_name_rental.TabIndex = 9;
            // 
            // tb_movie_name_rental
            // 
            this.tb_movie_name_rental.Location = new System.Drawing.Point(165, 58);
            this.tb_movie_name_rental.Name = "tb_movie_name_rental";
            this.tb_movie_name_rental.Size = new System.Drawing.Size(100, 20);
            this.tb_movie_name_rental.TabIndex = 8;
            // 
            // update_rental_btn
            // 
            this.update_rental_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.update_rental_btn.Location = new System.Drawing.Point(210, 226);
            this.update_rental_btn.Name = "update_rental_btn";
            this.update_rental_btn.Size = new System.Drawing.Size(75, 23);
            this.update_rental_btn.TabIndex = 7;
            this.update_rental_btn.Text = "Update";
            this.update_rental_btn.UseVisualStyleBackColor = false;
            // 
            // del_rental_btn
            // 
            this.del_rental_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.del_rental_btn.Location = new System.Drawing.Point(100, 226);
            this.del_rental_btn.Name = "del_rental_btn";
            this.del_rental_btn.Size = new System.Drawing.Size(75, 23);
            this.del_rental_btn.TabIndex = 6;
            this.del_rental_btn.Text = "Delete";
            this.del_rental_btn.UseVisualStyleBackColor = false;
            // 
            // add_rental_btn
            // 
            this.add_rental_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_rental_btn.Location = new System.Drawing.Point(12, 226);
            this.add_rental_btn.Name = "add_rental_btn";
            this.add_rental_btn.Size = new System.Drawing.Size(75, 23);
            this.add_rental_btn.TabIndex = 5;
            this.add_rental_btn.Text = "Add";
            this.add_rental_btn.UseVisualStyleBackColor = false;
            // 
            // date_returned_lbl_rental
            // 
            this.date_returned_lbl_rental.AutoSize = true;
            this.date_returned_lbl_rental.Location = new System.Drawing.Point(27, 187);
            this.date_returned_lbl_rental.Name = "date_returned_lbl_rental";
            this.date_returned_lbl_rental.Size = new System.Drawing.Size(77, 13);
            this.date_returned_lbl_rental.TabIndex = 4;
            this.date_returned_lbl_rental.Text = "Date Returned";
            // 
            // date_rented_lbl_rental
            // 
            this.date_rented_lbl_rental.AutoSize = true;
            this.date_rented_lbl_rental.Location = new System.Drawing.Point(27, 153);
            this.date_rented_lbl_rental.Name = "date_rented_lbl_rental";
            this.date_rented_lbl_rental.Size = new System.Drawing.Size(68, 13);
            this.date_rented_lbl_rental.TabIndex = 3;
            this.date_rented_lbl_rental.Text = "Date Rented";
            // 
            // cust_name_lbl_lbl
            // 
            this.cust_name_lbl_lbl.AutoSize = true;
            this.cust_name_lbl_lbl.Location = new System.Drawing.Point(27, 107);
            this.cust_name_lbl_lbl.Name = "cust_name_lbl_lbl";
            this.cust_name_lbl_lbl.Size = new System.Drawing.Size(82, 13);
            this.cust_name_lbl_lbl.TabIndex = 2;
            this.cust_name_lbl_lbl.Text = "Customer Name";
            // 
            // movie_name_lbl_rental
            // 
            this.movie_name_lbl_rental.AutoSize = true;
            this.movie_name_lbl_rental.Location = new System.Drawing.Point(27, 58);
            this.movie_name_lbl_rental.Name = "movie_name_lbl_rental";
            this.movie_name_lbl_rental.Size = new System.Drawing.Size(67, 13);
            this.movie_name_lbl_rental.TabIndex = 1;
            this.movie_name_lbl_rental.Text = "Movie Name";
            // 
            // rental_title
            // 
            this.rental_title.AutoSize = true;
            this.rental_title.BackColor = System.Drawing.Color.MediumPurple;
            this.rental_title.Font = new System.Drawing.Font("Script MT Bold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_title.ForeColor = System.Drawing.Color.Black;
            this.rental_title.Location = new System.Drawing.Point(71, 13);
            this.rental_title.Name = "rental_title";
            this.rental_title.Size = new System.Drawing.Size(177, 33);
            this.rental_title.TabIndex = 0;
            this.rental_title.Text = "Rental Details";
            // 
            // movie_panel
            // 
            this.movie_panel.Controls.Add(this.tb_genre);
            this.movie_panel.Controls.Add(this.tb_plot);
            this.movie_panel.Controls.Add(this.tb_copies);
            this.movie_panel.Controls.Add(this.tb_rental_cost);
            this.movie_panel.Controls.Add(this.tb_title);
            this.movie_panel.Controls.Add(this.tb_year);
            this.movie_panel.Controls.Add(this.tb_rating);
            this.movie_panel.Controls.Add(this.del_movie_btn);
            this.movie_panel.Controls.Add(this.update_movie_btn);
            this.movie_panel.Controls.Add(this.add_movie_btn);
            this.movie_panel.Controls.Add(this.genre_lbl);
            this.movie_panel.Controls.Add(this.plot_lbl);
            this.movie_panel.Controls.Add(this.copies_lbl);
            this.movie_panel.Controls.Add(this.rental_cost_lbl);
            this.movie_panel.Controls.Add(this.year_lbl);
            this.movie_panel.Controls.Add(this.title_lbl);
            this.movie_panel.Controls.Add(this.rating_lbl);
            this.movie_panel.Controls.Add(this.movie_title);
            this.movie_panel.Location = new System.Drawing.Point(681, 412);
            this.movie_panel.Name = "movie_panel";
            this.movie_panel.Size = new System.Drawing.Size(292, 320);
            this.movie_panel.TabIndex = 3;
            // 
            // tb_genre
            // 
            this.tb_genre.Location = new System.Drawing.Point(177, 245);
            this.tb_genre.Name = "tb_genre";
            this.tb_genre.Size = new System.Drawing.Size(100, 20);
            this.tb_genre.TabIndex = 17;
            // 
            // tb_plot
            // 
            this.tb_plot.Location = new System.Drawing.Point(177, 212);
            this.tb_plot.Name = "tb_plot";
            this.tb_plot.Size = new System.Drawing.Size(100, 20);
            this.tb_plot.TabIndex = 16;
            // 
            // tb_copies
            // 
            this.tb_copies.Location = new System.Drawing.Point(177, 183);
            this.tb_copies.Name = "tb_copies";
            this.tb_copies.Size = new System.Drawing.Size(100, 20);
            this.tb_copies.TabIndex = 15;
            // 
            // tb_rental_cost
            // 
            this.tb_rental_cost.Location = new System.Drawing.Point(177, 150);
            this.tb_rental_cost.Name = "tb_rental_cost";
            this.tb_rental_cost.Size = new System.Drawing.Size(100, 20);
            this.tb_rental_cost.TabIndex = 14;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(177, 95);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(100, 20);
            this.tb_title.TabIndex = 13;
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(177, 121);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(100, 20);
            this.tb_year.TabIndex = 12;
            // 
            // tb_rating
            // 
            this.tb_rating.Location = new System.Drawing.Point(177, 62);
            this.tb_rating.Name = "tb_rating";
            this.tb_rating.Size = new System.Drawing.Size(100, 20);
            this.tb_rating.TabIndex = 11;
            // 
            // del_movie_btn
            // 
            this.del_movie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.del_movie_btn.Location = new System.Drawing.Point(109, 280);
            this.del_movie_btn.Name = "del_movie_btn";
            this.del_movie_btn.Size = new System.Drawing.Size(75, 23);
            this.del_movie_btn.TabIndex = 10;
            this.del_movie_btn.Text = "Delete";
            this.del_movie_btn.UseVisualStyleBackColor = false;
            // 
            // update_movie_btn
            // 
            this.update_movie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.update_movie_btn.Location = new System.Drawing.Point(202, 280);
            this.update_movie_btn.Name = "update_movie_btn";
            this.update_movie_btn.Size = new System.Drawing.Size(75, 23);
            this.update_movie_btn.TabIndex = 9;
            this.update_movie_btn.Text = "Update";
            this.update_movie_btn.UseVisualStyleBackColor = false;
            // 
            // add_movie_btn
            // 
            this.add_movie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_movie_btn.Location = new System.Drawing.Point(8, 280);
            this.add_movie_btn.Name = "add_movie_btn";
            this.add_movie_btn.Size = new System.Drawing.Size(75, 23);
            this.add_movie_btn.TabIndex = 8;
            this.add_movie_btn.Text = "Add";
            this.add_movie_btn.UseVisualStyleBackColor = false;
            // 
            // genre_lbl
            // 
            this.genre_lbl.AutoSize = true;
            this.genre_lbl.Location = new System.Drawing.Point(22, 248);
            this.genre_lbl.Name = "genre_lbl";
            this.genre_lbl.Size = new System.Drawing.Size(36, 13);
            this.genre_lbl.TabIndex = 7;
            this.genre_lbl.Text = "Genre";
            // 
            // plot_lbl
            // 
            this.plot_lbl.AutoSize = true;
            this.plot_lbl.Location = new System.Drawing.Point(22, 219);
            this.plot_lbl.Name = "plot_lbl";
            this.plot_lbl.Size = new System.Drawing.Size(25, 13);
            this.plot_lbl.TabIndex = 6;
            this.plot_lbl.Text = "Plot";
            // 
            // copies_lbl
            // 
            this.copies_lbl.AutoSize = true;
            this.copies_lbl.Location = new System.Drawing.Point(21, 190);
            this.copies_lbl.Name = "copies_lbl";
            this.copies_lbl.Size = new System.Drawing.Size(39, 13);
            this.copies_lbl.TabIndex = 5;
            this.copies_lbl.Text = "Copies";
            // 
            // rental_cost_lbl
            // 
            this.rental_cost_lbl.AutoSize = true;
            this.rental_cost_lbl.Location = new System.Drawing.Point(21, 161);
            this.rental_cost_lbl.Name = "rental_cost_lbl";
            this.rental_cost_lbl.Size = new System.Drawing.Size(62, 13);
            this.rental_cost_lbl.TabIndex = 4;
            this.rental_cost_lbl.Text = "Rental Cost";
            // 
            // year_lbl
            // 
            this.year_lbl.AutoSize = true;
            this.year_lbl.Location = new System.Drawing.Point(21, 128);
            this.year_lbl.Name = "year_lbl";
            this.year_lbl.Size = new System.Drawing.Size(29, 13);
            this.year_lbl.TabIndex = 3;
            this.year_lbl.Text = "Year";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Location = new System.Drawing.Point(21, 95);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(27, 13);
            this.title_lbl.TabIndex = 2;
            this.title_lbl.Text = "Title";
            // 
            // rating_lbl
            // 
            this.rating_lbl.AutoSize = true;
            this.rating_lbl.Location = new System.Drawing.Point(24, 65);
            this.rating_lbl.Name = "rating_lbl";
            this.rating_lbl.Size = new System.Drawing.Size(38, 13);
            this.rating_lbl.TabIndex = 1;
            this.rating_lbl.Text = "Rating";
            // 
            // movie_title
            // 
            this.movie_title.AutoSize = true;
            this.movie_title.BackColor = System.Drawing.Color.MediumPurple;
            this.movie_title.Font = new System.Drawing.Font("Script MT Bold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_title.Location = new System.Drawing.Point(70, 15);
            this.movie_title.Name = "movie_title";
            this.movie_title.Size = new System.Drawing.Size(168, 33);
            this.movie_title.TabIndex = 0;
            this.movie_title.Text = "Movie Details";
            // 
            // vedioRental_title_lbl
            // 
            this.vedioRental_title_lbl.AutoSize = true;
            this.vedioRental_title_lbl.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vedioRental_title_lbl.Location = new System.Drawing.Point(238, 9);
            this.vedioRental_title_lbl.Name = "vedioRental_title_lbl";
            this.vedioRental_title_lbl.Size = new System.Drawing.Size(582, 65);
            this.vedioRental_title_lbl.TabIndex = 4;
            this.vedioRental_title_lbl.Text = "Video Rental System";
            // 
            // DTP_Date_Rented_Rental
            // 
            this.DTP_Date_Rented_Rental.Location = new System.Drawing.Point(165, 147);
            this.DTP_Date_Rented_Rental.Name = "DTP_Date_Rented_Rental";
            this.DTP_Date_Rented_Rental.Size = new System.Drawing.Size(200, 20);
            this.DTP_Date_Rented_Rental.TabIndex = 10;
            // 
            // DTP_DateReturned_Rented
            // 
            this.DTP_DateReturned_Rented.Location = new System.Drawing.Point(165, 181);
            this.DTP_DateReturned_Rented.Name = "DTP_DateReturned_Rented";
            this.DTP_DateReturned_Rented.Size = new System.Drawing.Size(200, 20);
            this.DTP_DateReturned_Rented.TabIndex = 11;
            // 
            // VedioRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::VedioRental.Properties.Resources.gamewal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 736);
            this.Controls.Add(this.vedioRental_title_lbl);
            this.Controls.Add(this.movie_panel);
            this.Controls.Add(this.rental_panel);
            this.Controls.Add(this.customer_panel);
            this.Controls.Add(this.tabControl1);
            this.Name = "VedioRental";
            this.Text = "VedioRental";
            this.Load += new System.EventHandler(this.VedioRental_Load);
            this.tabControl1.ResumeLayout(false);
            this.customer_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.movie_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movie)).EndInit();
            this.rental_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rental)).EndInit();
            this.customer_panel.ResumeLayout(false);
            this.customer_panel.PerformLayout();
            this.rental_panel.ResumeLayout(false);
            this.rental_panel.PerformLayout();
            this.movie_panel.ResumeLayout(false);
            this.movie_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage customer_tab;
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.TabPage movie_tab;
        private System.Windows.Forms.DataGridView dgv_movie;
        private System.Windows.Forms.TabPage rental_tab;
        private System.Windows.Forms.DataGridView dgv_rental;
        private System.Windows.Forms.Panel customer_panel;
        private System.Windows.Forms.Label customer_title;
        private System.Windows.Forms.Label Last_Name_label;
        private System.Windows.Forms.Label First_Name_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Button update_cust_btn;
        private System.Windows.Forms.Button del_cust_btn;
        private System.Windows.Forms.Button add_cust_btn;
        private System.Windows.Forms.Panel rental_panel;
        private System.Windows.Forms.Panel movie_panel;
        private System.Windows.Forms.Label rental_title;
        private System.Windows.Forms.Label movie_title;
        private System.Windows.Forms.Label date_returned_lbl_rental;
        private System.Windows.Forms.Label date_rented_lbl_rental;
        private System.Windows.Forms.Label cust_name_lbl_lbl;
        private System.Windows.Forms.Label movie_name_lbl_rental;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label rating_lbl;
        private System.Windows.Forms.Label genre_lbl;
        private System.Windows.Forms.Label plot_lbl;
        private System.Windows.Forms.Label copies_lbl;
        private System.Windows.Forms.Label rental_cost_lbl;
        private System.Windows.Forms.Label year_lbl;
        private System.Windows.Forms.Button update_rental_btn;
        private System.Windows.Forms.Button del_rental_btn;
        private System.Windows.Forms.Button add_rental_btn;
        private System.Windows.Forms.Button del_movie_btn;
        private System.Windows.Forms.Button update_movie_btn;
        private System.Windows.Forms.Button add_movie_btn;
        private System.Windows.Forms.TextBox tb_cust_name_rental;
        private System.Windows.Forms.TextBox tb_movie_name_rental;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_last_name;
        private System.Windows.Forms.TextBox tb_first_name;
        private System.Windows.Forms.TextBox tb_genre;
        private System.Windows.Forms.TextBox tb_plot;
        private System.Windows.Forms.TextBox tb_copies;
        private System.Windows.Forms.TextBox tb_rental_cost;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.TextBox tb_rating;
        private System.Windows.Forms.Label vedioRental_title_lbl;
        private System.Windows.Forms.DateTimePicker DTP_DateReturned_Rented;
        private System.Windows.Forms.DateTimePicker DTP_Date_Rented_Rental;
    }
}

