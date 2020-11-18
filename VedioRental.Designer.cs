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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.customer_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.movie_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movie)).BeginInit();
            this.rental_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rental)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.customer_tab);
            this.tabControl1.Controls.Add(this.movie_tab);
            this.tabControl1.Controls.Add(this.rental_tab);
            this.tabControl1.Location = new System.Drawing.Point(39, 35);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(612, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 230);
            this.panel1.TabIndex = 1;
            // 
            // VedioRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::VedioRental.Properties.Resources.vedio_wal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 638);
            this.Controls.Add(this.panel1);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage customer_tab;
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.TabPage movie_tab;
        private System.Windows.Forms.DataGridView dgv_movie;
        private System.Windows.Forms.TabPage rental_tab;
        private System.Windows.Forms.DataGridView dgv_rental;
        private System.Windows.Forms.Panel panel1;
    }
}

