namespace Famracy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exit_main = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.salesbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainform_logout = new System.Windows.Forms.Button();
            this.price_btn = new System.Windows.Forms.Button();
            this.addMed_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greet_user = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard1 = new Famracy.Dashboard();
            this.addMedicine1 = new Famracy.AddMedicine();
            this.price1 = new Famracy.Price();
            this.sales1 = new PharmacyManagementSystem.sales();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.exit_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pharmacy Management System";
            // 
            // exit_main
            // 
            this.exit_main.AutoSize = true;
            this.exit_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_main.Location = new System.Drawing.Point(1069, 6);
            this.exit_main.Name = "exit_main";
            this.exit_main.Size = new System.Drawing.Size(20, 20);
            this.exit_main.TabIndex = 0;
            this.exit_main.Text = "X";
            this.exit_main.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.salesbtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.mainform_logout);
            this.panel2.Controls.Add(this.price_btn);
            this.panel2.Controls.Add(this.addMed_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greet_user);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 565);
            this.panel2.TabIndex = 1;
            // 
            // salesbtn
            // 
            this.salesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.salesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.salesbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.salesbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.salesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesbtn.ForeColor = System.Drawing.Color.White;
            this.salesbtn.Location = new System.Drawing.Point(25, 421);
            this.salesbtn.Name = "salesbtn";
            this.salesbtn.Size = new System.Drawing.Size(200, 40);
            this.salesbtn.TabIndex = 7;
            this.salesbtn.Text = "POS";
            this.salesbtn.UseVisualStyleBackColor = false;
            this.salesbtn.Click += new System.EventHandler(this.salesbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // mainform_logout
            // 
            this.mainform_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainform_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.mainform_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.mainform_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.mainform_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainform_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainform_logout.ForeColor = System.Drawing.Color.White;
            this.mainform_logout.Location = new System.Drawing.Point(140, 508);
            this.mainform_logout.Name = "mainform_logout";
            this.mainform_logout.Size = new System.Drawing.Size(85, 45);
            this.mainform_logout.TabIndex = 5;
            this.mainform_logout.Text = "Log Out";
            this.mainform_logout.UseVisualStyleBackColor = true;
            this.mainform_logout.Click += new System.EventHandler(this.mainform_logout_Click);
            // 
            // price_btn
            // 
            this.price_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.price_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.price_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.price_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.price_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.price_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.price_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_btn.ForeColor = System.Drawing.Color.White;
            this.price_btn.Location = new System.Drawing.Point(25, 369);
            this.price_btn.Name = "price_btn";
            this.price_btn.Size = new System.Drawing.Size(200, 40);
            this.price_btn.TabIndex = 4;
            this.price_btn.Text = "Price";
            this.price_btn.UseVisualStyleBackColor = false;
            this.price_btn.Click += new System.EventHandler(this.price_btn_Click);
            // 
            // addMed_btn
            // 
            this.addMed_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.addMed_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMed_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMed_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMed_btn.ForeColor = System.Drawing.Color.White;
            this.addMed_btn.Location = new System.Drawing.Point(25, 314);
            this.addMed_btn.Name = "addMed_btn";
            this.addMed_btn.Size = new System.Drawing.Size(200, 40);
            this.addMed_btn.TabIndex = 3;
            this.addMed_btn.Text = "Add Medicine";
            this.addMed_btn.UseVisualStyleBackColor = false;
            this.addMed_btn.Click += new System.EventHandler(this.addMed_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(25, 259);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(200, 40);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "DashBoard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // greet_user
            // 
            this.greet_user.AutoSize = true;
            this.greet_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.greet_user.Location = new System.Drawing.Point(58, 215);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(140, 24);
            this.greet_user.TabIndex = 1;
            this.greet_user.Text = "Welcome, User";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addMedicine1);
            this.panel3.Controls.Add(this.price1);
            this.panel3.Controls.Add(this.sales1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(255, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(845, 565);
            this.panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(845, 565);
            this.dashboard1.TabIndex = 2;
            // 
            // addMedicine1
            // 
            this.addMedicine1.Location = new System.Drawing.Point(-3, 0);
            this.addMedicine1.Name = "addMedicine1";
            this.addMedicine1.Size = new System.Drawing.Size(845, 565);
            this.addMedicine1.TabIndex = 1;
            // 
            // price1
            // 
            this.price1.Location = new System.Drawing.Point(-3, 0);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(845, 565);
            this.price1.TabIndex = 0;
            // 
            // sales1
            // 
            this.sales1.Location = new System.Drawing.Point(0, 0);
            this.sales1.Name = "sales1";
            this.sales1.Size = new System.Drawing.Size(845, 565);
            this.sales1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit_main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label greet_user;
        private System.Windows.Forms.Button price_btn;
        private System.Windows.Forms.Button addMed_btn;
        private System.Windows.Forms.Button mainform_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private Dashboard dashboard1;
        private AddMedicine addMedicine1;
        private Price price1;
        private PharmacyManagementSystem.sales sales1;
        private System.Windows.Forms.Button salesbtn;
    }
}