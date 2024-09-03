namespace Famracy
{
    partial class Price
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.price_update = new System.Windows.Forms.Button();
            this.price_clear = new System.Windows.Forms.Button();
            this.price_drug_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price_drug_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.price_drug_indication = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price_drug_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.price_update);
            this.panel1.Controls.Add(this.price_clear);
            this.panel1.Controls.Add(this.price_drug_name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.price_drug_price);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.price_drug_indication);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.price_drug_id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 533);
            this.panel1.TabIndex = 0;
            // 
            // price_update
            // 
            this.price_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.price_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.price_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.price_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.price_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.price_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.price_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_update.ForeColor = System.Drawing.Color.Black;
            this.price_update.Location = new System.Drawing.Point(32, 392);
            this.price_update.Name = "price_update";
            this.price_update.Size = new System.Drawing.Size(123, 34);
            this.price_update.TabIndex = 15;
            this.price_update.Text = "Update";
            this.price_update.UseVisualStyleBackColor = false;
            this.price_update.Click += new System.EventHandler(this.price_update_Click);
            // 
            // price_clear
            // 
            this.price_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            this.price_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.price_clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.price_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.price_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            this.price_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.price_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_clear.ForeColor = System.Drawing.Color.White;
            this.price_clear.Location = new System.Drawing.Point(166, 392);
            this.price_clear.Name = "price_clear";
            this.price_clear.Size = new System.Drawing.Size(123, 34);
            this.price_clear.TabIndex = 12;
            this.price_clear.Text = "Clear";
            this.price_clear.UseVisualStyleBackColor = false;
            this.price_clear.Click += new System.EventHandler(this.price_clear_Click);
            // 
            // price_drug_name
            // 
            this.price_drug_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_drug_name.Location = new System.Drawing.Point(28, 139);
            this.price_drug_name.Multiline = true;
            this.price_drug_name.Name = "price_drug_name";
            this.price_drug_name.Size = new System.Drawing.Size(261, 35);
            this.price_drug_name.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name :";
            // 
            // price_drug_price
            // 
            this.price_drug_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_drug_price.Location = new System.Drawing.Point(28, 329);
            this.price_drug_price.Multiline = true;
            this.price_drug_price.Name = "price_drug_price";
            this.price_drug_price.Size = new System.Drawing.Size(261, 35);
            this.price_drug_price.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Indication :";
            // 
            // price_drug_indication
            // 
            this.price_drug_indication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_drug_indication.Location = new System.Drawing.Point(28, 234);
            this.price_drug_indication.Multiline = true;
            this.price_drug_indication.Name = "price_drug_indication";
            this.price_drug_indication.Size = new System.Drawing.Size(261, 35);
            this.price_drug_indication.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price :";
            // 
            // price_drug_id
            // 
            this.price_drug_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_drug_id.Location = new System.Drawing.Point(28, 50);
            this.price_drug_id.Multiline = true;
            this.price_drug_id.Name = "price_drug_id";
            this.price_drug_id.Size = new System.Drawing.Size(261, 35);
            this.price_drug_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drug ID :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(363, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 533);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(120)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(179)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(37, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(392, 461);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicines";
            // 
            // Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Price";
            this.Size = new System.Drawing.Size(845, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price_drug_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price_drug_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price_drug_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox price_drug_indication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button price_update;
        private System.Windows.Forms.Button price_clear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
