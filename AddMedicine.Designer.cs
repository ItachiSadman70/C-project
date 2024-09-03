namespace Famracy
{
    partial class AddMedicine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addMed_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addMed_updateBtn = new System.Windows.Forms.Button();
            this.addMed_clearBtn = new System.Windows.Forms.Button();
            this.addMed_deleteBtn = new System.Windows.Forms.Button();
            this.addMed_addBtn = new System.Windows.Forms.Button();
            this.addMed_importBtn = new System.Windows.Forms.Button();
            this.addMed_pic = new System.Windows.Forms.PictureBox();
            this.addMed_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addMed_Indication = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addMed_gener = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addMed_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addMed_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addMed_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 280);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(772, 226);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addMed_status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addMed_updateBtn);
            this.panel2.Controls.Add(this.addMed_clearBtn);
            this.panel2.Controls.Add(this.addMed_deleteBtn);
            this.panel2.Controls.Add(this.addMed_addBtn);
            this.panel2.Controls.Add(this.addMed_importBtn);
            this.panel2.Controls.Add(this.addMed_pic);
            this.panel2.Controls.Add(this.addMed_price);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addMed_Indication);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addMed_gener);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addMed_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addMed_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(19, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 223);
            this.panel2.TabIndex = 1;
            // 
            // addMed_status
            // 
            this.addMed_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMed_status.FormattingEnabled = true;
            this.addMed_status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.addMed_status.Location = new System.Drawing.Point(439, 117);
            this.addMed_status.Name = "addMed_status";
            this.addMed_status.Size = new System.Drawing.Size(203, 24);
            this.addMed_status.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status :";
            // 
            // addMed_updateBtn
            // 
            this.addMed_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addMed_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMed_updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMed_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMed_updateBtn.ForeColor = System.Drawing.Color.Black;
            this.addMed_updateBtn.Location = new System.Drawing.Point(167, 170);
            this.addMed_updateBtn.Name = "addMed_updateBtn";
            this.addMed_updateBtn.Size = new System.Drawing.Size(123, 34);
            this.addMed_updateBtn.TabIndex = 15;
            this.addMed_updateBtn.Text = "Update";
            this.addMed_updateBtn.UseVisualStyleBackColor = false;
            this.addMed_updateBtn.Click += new System.EventHandler(this.addMed_updateBtn_Click);
            // 
            // addMed_clearBtn
            // 
            this.addMed_clearBtn.BackColor = System.Drawing.Color.Yellow;
            this.addMed_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMed_clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMed_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMed_clearBtn.ForeColor = System.Drawing.Color.Black;
            this.addMed_clearBtn.Location = new System.Drawing.Point(462, 170);
            this.addMed_clearBtn.Name = "addMed_clearBtn";
            this.addMed_clearBtn.Size = new System.Drawing.Size(123, 34);
            this.addMed_clearBtn.TabIndex = 14;
            this.addMed_clearBtn.Text = "Clear";
            this.addMed_clearBtn.UseVisualStyleBackColor = false;
            this.addMed_clearBtn.Click += new System.EventHandler(this.addMed_clearBtn_Click);
            // 
            // addMed_deleteBtn
            // 
            this.addMed_deleteBtn.BackColor = System.Drawing.Color.Red;
            this.addMed_deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMed_deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMed_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMed_deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.addMed_deleteBtn.Location = new System.Drawing.Point(319, 170);
            this.addMed_deleteBtn.Name = "addMed_deleteBtn";
            this.addMed_deleteBtn.Size = new System.Drawing.Size(123, 34);
            this.addMed_deleteBtn.TabIndex = 13;
            this.addMed_deleteBtn.Text = "Delete";
            this.addMed_deleteBtn.UseVisualStyleBackColor = false;
            this.addMed_deleteBtn.Click += new System.EventHandler(this.addMed_deleteBtn_Click);
            // 
            // addMed_addBtn
            // 
            this.addMed_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.addMed_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMed_addBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMed_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMed_addBtn.ForeColor = System.Drawing.Color.White;
            this.addMed_addBtn.Location = new System.Drawing.Point(19, 170);
            this.addMed_addBtn.Name = "addMed_addBtn";
            this.addMed_addBtn.Size = new System.Drawing.Size(123, 34);
            this.addMed_addBtn.TabIndex = 12;
            this.addMed_addBtn.Text = "Add";
            this.addMed_addBtn.UseVisualStyleBackColor = false;
            this.addMed_addBtn.Click += new System.EventHandler(this.addMed_addBtn_Click);
            // 
            // addMed_importBtn
            // 
            this.addMed_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.addMed_importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMed_importBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.addMed_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMed_importBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMed_importBtn.ForeColor = System.Drawing.Color.White;
            this.addMed_importBtn.Location = new System.Drawing.Point(651, 153);
            this.addMed_importBtn.Name = "addMed_importBtn";
            this.addMed_importBtn.Size = new System.Drawing.Size(123, 34);
            this.addMed_importBtn.TabIndex = 11;
            this.addMed_importBtn.Text = "Import";
            this.addMed_importBtn.UseVisualStyleBackColor = false;
            this.addMed_importBtn.Click += new System.EventHandler(this.addMed_importBtn_Click);
            // 
            // addMed_pic
            // 
            this.addMed_pic.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addMed_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addMed_pic.Location = new System.Drawing.Point(651, 19);
            this.addMed_pic.Name = "addMed_pic";
            this.addMed_pic.Size = new System.Drawing.Size(123, 128);
            this.addMed_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addMed_pic.TabIndex = 10;
            this.addMed_pic.TabStop = false;
            // 
            // addMed_price
            // 
            this.addMed_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMed_price.Location = new System.Drawing.Point(439, 63);
            this.addMed_price.Multiline = true;
            this.addMed_price.Name = "addMed_price";
            this.addMed_price.Size = new System.Drawing.Size(203, 35);
            this.addMed_price.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price :";
            // 
            // addMed_Indication
            // 
            this.addMed_Indication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMed_Indication.Location = new System.Drawing.Point(439, 18);
            this.addMed_Indication.Multiline = true;
            this.addMed_Indication.Name = "addMed_Indication";
            this.addMed_Indication.Size = new System.Drawing.Size(203, 35);
            this.addMed_Indication.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Indication :";
            // 
            // addMed_gener
            // 
            this.addMed_gener.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMed_gener.FormattingEnabled = true;
            this.addMed_gener.Items.AddRange(new object[] {
            "Capsul",
            "Tablet",
            "Suspension",
            "Powder",
            "Injection",
            "Inhale",
            "Pediatric",
            "Drop"});
            this.addMed_gener.Location = new System.Drawing.Point(102, 116);
            this.addMed_gener.Name = "addMed_gener";
            this.addMed_gener.Size = new System.Drawing.Size(235, 24);
            this.addMed_gener.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Generic :";
            // 
            // addMed_name
            // 
            this.addMed_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMed_name.Location = new System.Drawing.Point(102, 67);
            this.addMed_name.Multiline = true;
            this.addMed_name.Name = "addMed_name";
            this.addMed_name.Size = new System.Drawing.Size(235, 35);
            this.addMed_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name :";
            // 
            // addMed_id
            // 
            this.addMed_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMed_id.Location = new System.Drawing.Point(102, 19);
            this.addMed_id.Multiline = true;
            this.addMed_id.Name = "addMed_id";
            this.addMed_id.Size = new System.Drawing.Size(235, 35);
            this.addMed_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Drug ID :";
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddMedicine";
            this.Size = new System.Drawing.Size(845, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addMed_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addMed_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addMed_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox addMed_gener;
        private System.Windows.Forms.TextBox addMed_Indication;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addMed_importBtn;
        private System.Windows.Forms.PictureBox addMed_pic;
        private System.Windows.Forms.TextBox addMed_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMed_updateBtn;
        private System.Windows.Forms.Button addMed_clearBtn;
        private System.Windows.Forms.Button addMed_deleteBtn;
        private System.Windows.Forms.Button addMed_addBtn;
        private System.Windows.Forms.ComboBox addMed_status;
        private System.Windows.Forms.Label label7;
    }
}
