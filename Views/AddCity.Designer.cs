
namespace AppointmentScheduler_C969.Views
{
    partial class AddCity
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
            this.gb_newCity = new System.Windows.Forms.GroupBox();
            this.btn_createNewCntry = new System.Windows.Forms.Button();
            this.lb_addNewCntry = new System.Windows.Forms.Label();
            this.tb_addNewCntry = new System.Windows.Forms.TextBox();
            this.ll_cancel = new System.Windows.Forms.LinkLabel();
            this.btn_addCity = new System.Windows.Forms.Button();
            this.btn_addCountry = new System.Windows.Forms.Button();
            this.tb_cityName = new System.Windows.Forms.TextBox();
            this.cb_countryList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_newCityName = new System.Windows.Forms.Label();
            this.gb_newCity.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_newCity
            // 
            this.gb_newCity.BackColor = System.Drawing.Color.AliceBlue;
            this.gb_newCity.Controls.Add(this.btn_createNewCntry);
            this.gb_newCity.Controls.Add(this.lb_addNewCntry);
            this.gb_newCity.Controls.Add(this.tb_addNewCntry);
            this.gb_newCity.Controls.Add(this.ll_cancel);
            this.gb_newCity.Controls.Add(this.btn_addCity);
            this.gb_newCity.Controls.Add(this.btn_addCountry);
            this.gb_newCity.Controls.Add(this.tb_cityName);
            this.gb_newCity.Controls.Add(this.cb_countryList);
            this.gb_newCity.Controls.Add(this.label1);
            this.gb_newCity.Controls.Add(this.lb_newCityName);
            this.gb_newCity.Location = new System.Drawing.Point(12, 12);
            this.gb_newCity.Name = "gb_newCity";
            this.gb_newCity.Size = new System.Drawing.Size(450, 254);
            this.gb_newCity.TabIndex = 0;
            this.gb_newCity.TabStop = false;
            this.gb_newCity.Text = "Add New City";
            // 
            // btn_createNewCntry
            // 
            this.btn_createNewCntry.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_createNewCntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createNewCntry.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_createNewCntry.Location = new System.Drawing.Point(327, 164);
            this.btn_createNewCntry.Name = "btn_createNewCntry";
            this.btn_createNewCntry.Size = new System.Drawing.Size(67, 23);
            this.btn_createNewCntry.TabIndex = 9;
            this.btn_createNewCntry.Text = "Create";
            this.btn_createNewCntry.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_createNewCntry.UseVisualStyleBackColor = false;
            this.btn_createNewCntry.Visible = false;
            this.btn_createNewCntry.Click += new System.EventHandler(this.btn_createNewCntry_Click);
            // 
            // lb_addNewCntry
            // 
            this.lb_addNewCntry.AutoSize = true;
            this.lb_addNewCntry.Location = new System.Drawing.Point(55, 167);
            this.lb_addNewCntry.Name = "lb_addNewCntry";
            this.lb_addNewCntry.Size = new System.Drawing.Size(75, 15);
            this.lb_addNewCntry.TabIndex = 8;
            this.lb_addNewCntry.Text = "Add Country";
            this.lb_addNewCntry.Visible = false;
            // 
            // tb_addNewCntry
            // 
            this.tb_addNewCntry.Location = new System.Drawing.Point(135, 164);
            this.tb_addNewCntry.Name = "tb_addNewCntry";
            this.tb_addNewCntry.Size = new System.Drawing.Size(170, 23);
            this.tb_addNewCntry.TabIndex = 7;
            this.tb_addNewCntry.Visible = false;
            // 
            // ll_cancel
            // 
            this.ll_cancel.AutoSize = true;
            this.ll_cancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ll_cancel.LinkColor = System.Drawing.Color.Red;
            this.ll_cancel.Location = new System.Drawing.Point(380, 220);
            this.ll_cancel.Name = "ll_cancel";
            this.ll_cancel.Size = new System.Drawing.Size(64, 18);
            this.ll_cancel.TabIndex = 6;
            this.ll_cancel.TabStop = true;
            this.ll_cancel.Text = "Cancel";
            this.ll_cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_cancel_LinkClicked);
            // 
            // btn_addCity
            // 
            this.btn_addCity.BackColor = System.Drawing.Color.LightBlue;
            this.btn_addCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addCity.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_addCity.Location = new System.Drawing.Point(6, 211);
            this.btn_addCity.Name = "btn_addCity";
            this.btn_addCity.Size = new System.Drawing.Size(84, 37);
            this.btn_addCity.TabIndex = 5;
            this.btn_addCity.Text = "Add";
            this.btn_addCity.UseVisualStyleBackColor = false;
            this.btn_addCity.Click += new System.EventHandler(this.btn_addCity_Click);
            // 
            // btn_addCountry
            // 
            this.btn_addCountry.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_addCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCountry.Location = new System.Drawing.Point(327, 95);
            this.btn_addCountry.Name = "btn_addCountry";
            this.btn_addCountry.Size = new System.Drawing.Size(46, 23);
            this.btn_addCountry.TabIndex = 4;
            this.btn_addCountry.Text = "Add";
            this.btn_addCountry.UseVisualStyleBackColor = false;
            this.btn_addCountry.Click += new System.EventHandler(this.btn_addCountry_Click);
            // 
            // tb_cityName
            // 
            this.tb_cityName.Location = new System.Drawing.Point(135, 57);
            this.tb_cityName.Name = "tb_cityName";
            this.tb_cityName.Size = new System.Drawing.Size(222, 23);
            this.tb_cityName.TabIndex = 3;
            // 
            // cb_countryList
            // 
            this.cb_countryList.FormattingEnabled = true;
            this.cb_countryList.Location = new System.Drawing.Point(135, 95);
            this.cb_countryList.Name = "cb_countryList";
            this.cb_countryList.Size = new System.Drawing.Size(172, 23);
            this.cb_countryList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country";
            // 
            // lb_newCityName
            // 
            this.lb_newCityName.AutoSize = true;
            this.lb_newCityName.Location = new System.Drawing.Point(55, 57);
            this.lb_newCityName.Name = "lb_newCityName";
            this.lb_newCityName.Size = new System.Drawing.Size(63, 15);
            this.lb_newCityName.TabIndex = 0;
            this.lb_newCityName.Text = "City Name";
            // 
            // AddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 278);
            this.Controls.Add(this.gb_newCity);
            this.Name = "AddCity";
            this.Text = "AddCity";
            this.Load += new System.EventHandler(this.AddCity_Load);
            this.gb_newCity.ResumeLayout(false);
            this.gb_newCity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_newCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_newCityName;
        private System.Windows.Forms.Button btn_addCountry;
        private System.Windows.Forms.TextBox tb_cityName;
        private System.Windows.Forms.ComboBox cb_countryList;
        private System.Windows.Forms.Button btn_addCity;
        private System.Windows.Forms.LinkLabel ll_cancel;
        private System.Windows.Forms.Label lb_addNewCntry;
        private System.Windows.Forms.TextBox tb_addNewCntry;
        private System.Windows.Forms.Button btn_createNewCntry;
    }
}