namespace Sales_Managment_The_Second_Project
{
    partial class frm_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_item));
            this.dgv_frmitem = new System.Windows.Forms.DataGridView();
            this.btn_add_frmitem = new System.Windows.Forms.Button();
            this.txt_itemnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.btn_edit_frmitem = new System.Windows.Forms.Button();
            this.btn_delete_frmitem = new System.Windows.Forms.Button();
            this.btn_save_frmitem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frmitem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_frmitem
            // 
            this.dgv_frmitem.AllowUserToAddRows = false;
            this.dgv_frmitem.AllowUserToDeleteRows = false;
            this.dgv_frmitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_frmitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_frmitem.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_frmitem.Location = new System.Drawing.Point(0, 0);
            this.dgv_frmitem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_frmitem.Name = "dgv_frmitem";
            this.dgv_frmitem.ReadOnly = true;
            this.dgv_frmitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_frmitem.Size = new System.Drawing.Size(456, 207);
            this.dgv_frmitem.TabIndex = 0;
            // 
            // btn_add_frmitem
            // 
            this.btn_add_frmitem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_frmitem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_add_frmitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_frmitem.Location = new System.Drawing.Point(92, 353);
            this.btn_add_frmitem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add_frmitem.Name = "btn_add_frmitem";
            this.btn_add_frmitem.Size = new System.Drawing.Size(148, 28);
            this.btn_add_frmitem.TabIndex = 1;
            this.btn_add_frmitem.Text = "اضافة";
            this.btn_add_frmitem.UseVisualStyleBackColor = true;
            this.btn_add_frmitem.Click += new System.EventHandler(this.btn_add_frmitem_Click);
            // 
            // txt_itemnumber
            // 
            this.txt_itemnumber.Location = new System.Drawing.Point(32, 238);
            this.txt_itemnumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_itemnumber.Name = "txt_itemnumber";
            this.txt_itemnumber.ReadOnly = true;
            this.txt_itemnumber.Size = new System.Drawing.Size(254, 24);
            this.txt_itemnumber.TabIndex = 2;
            this.txt_itemnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(312, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الصنف:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(312, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم الصنف:";
            // 
            // txt_itemname
            // 
            this.txt_itemname.Enabled = false;
            this.txt_itemname.Location = new System.Drawing.Point(32, 302);
            this.txt_itemname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(254, 24);
            this.txt_itemname.TabIndex = 4;
            this.txt_itemname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_edit_frmitem
            // 
            this.btn_edit_frmitem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_edit_frmitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_frmitem.Location = new System.Drawing.Point(92, 389);
            this.btn_edit_frmitem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit_frmitem.Name = "btn_edit_frmitem";
            this.btn_edit_frmitem.Size = new System.Drawing.Size(148, 28);
            this.btn_edit_frmitem.TabIndex = 6;
            this.btn_edit_frmitem.Text = "تعديل";
            this.btn_edit_frmitem.UseVisualStyleBackColor = true;
            this.btn_edit_frmitem.Click += new System.EventHandler(this.btn_edit_frmitem_Click);
            // 
            // btn_delete_frmitem
            // 
            this.btn_delete_frmitem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_delete_frmitem.Location = new System.Drawing.Point(92, 425);
            this.btn_delete_frmitem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete_frmitem.Name = "btn_delete_frmitem";
            this.btn_delete_frmitem.Size = new System.Drawing.Size(148, 28);
            this.btn_delete_frmitem.TabIndex = 7;
            this.btn_delete_frmitem.Text = "حذف";
            this.btn_delete_frmitem.UseVisualStyleBackColor = true;
            this.btn_delete_frmitem.Click += new System.EventHandler(this.btn_delete_frmitem_Click);
            // 
            // btn_save_frmitem
            // 
            this.btn_save_frmitem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_save_frmitem.Location = new System.Drawing.Point(92, 461);
            this.btn_save_frmitem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save_frmitem.Name = "btn_save_frmitem";
            this.btn_save_frmitem.Size = new System.Drawing.Size(148, 28);
            this.btn_save_frmitem.TabIndex = 8;
            this.btn_save_frmitem.Text = "حفظ";
            this.btn_save_frmitem.UseVisualStyleBackColor = true;
            this.btn_save_frmitem.Click += new System.EventHandler(this.btn_save_frmitem_Click);
            // 
            // frm_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 502);
            this.Controls.Add(this.btn_save_frmitem);
            this.Controls.Add(this.btn_delete_frmitem);
            this.Controls.Add(this.btn_edit_frmitem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_itemname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_itemnumber);
            this.Controls.Add(this.btn_add_frmitem);
            this.Controls.Add(this.dgv_frmitem);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_item";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الاصناف";
            this.Load += new System.EventHandler(this.frm_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frmitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_frmitem;
        private System.Windows.Forms.Button btn_add_frmitem;
        private System.Windows.Forms.TextBox txt_itemnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.Button btn_delete_frmitem;
        private System.Windows.Forms.Button btn_save_frmitem;
        private System.Windows.Forms.Button btn_edit_frmitem;
    }
}