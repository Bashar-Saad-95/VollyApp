namespace Sales_Managment_The_Second_Project
{
    partial class frm_product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_product));
            this.btn_save_frmproduct = new System.Windows.Forms.Button();
            this.btn_delete_frmproduct = new System.Windows.Forms.Button();
            this.btn_edit_frmproduct = new System.Windows.Forms.Button();
            this.btn_add_frmproduct = new System.Windows.Forms.Button();
            this.gc_frmproduct = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grobx_frm_product = new System.Windows.Forms.GroupBox();
            this.btn_selectimage_frmproduct = new System.Windows.Forms.Button();
            this.comb_productitem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pib_productimage = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_productstoredquantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_productearnprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_productsaleprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_productbuy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_productnumber = new System.Windows.Forms.TextBox();
            this.openfd_frm_product = new System.Windows.Forms.OpenFileDialog();
            this.dgv_frm_product = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gc_frmproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grobx_frm_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_productimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frm_product)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save_frmproduct
            // 
            this.btn_save_frmproduct.Enabled = false;
            this.btn_save_frmproduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_save_frmproduct.Location = new System.Drawing.Point(27, 495);
            this.btn_save_frmproduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save_frmproduct.Name = "btn_save_frmproduct";
            this.btn_save_frmproduct.Size = new System.Drawing.Size(148, 43);
            this.btn_save_frmproduct.TabIndex = 16;
            this.btn_save_frmproduct.Text = "حفظ";
            this.btn_save_frmproduct.UseVisualStyleBackColor = true;
            this.btn_save_frmproduct.Click += new System.EventHandler(this.btn_save_frmproduct_Click);
            // 
            // btn_delete_frmproduct
            // 
            this.btn_delete_frmproduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_delete_frmproduct.Location = new System.Drawing.Point(27, 443);
            this.btn_delete_frmproduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete_frmproduct.Name = "btn_delete_frmproduct";
            this.btn_delete_frmproduct.Size = new System.Drawing.Size(148, 44);
            this.btn_delete_frmproduct.TabIndex = 15;
            this.btn_delete_frmproduct.Text = "حذف";
            this.btn_delete_frmproduct.UseVisualStyleBackColor = true;
            // 
            // btn_edit_frmproduct
            // 
            this.btn_edit_frmproduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_edit_frmproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_frmproduct.Location = new System.Drawing.Point(27, 393);
            this.btn_edit_frmproduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit_frmproduct.Name = "btn_edit_frmproduct";
            this.btn_edit_frmproduct.Size = new System.Drawing.Size(148, 42);
            this.btn_edit_frmproduct.TabIndex = 14;
            this.btn_edit_frmproduct.Text = "تعديل";
            this.btn_edit_frmproduct.UseVisualStyleBackColor = true;
            this.btn_edit_frmproduct.Click += new System.EventHandler(this.btn_edit_frmproduct_Click);
            // 
            // btn_add_frmproduct
            // 
            this.btn_add_frmproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_frmproduct.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_add_frmproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_frmproduct.Location = new System.Drawing.Point(27, 343);
            this.btn_add_frmproduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add_frmproduct.Name = "btn_add_frmproduct";
            this.btn_add_frmproduct.Size = new System.Drawing.Size(148, 42);
            this.btn_add_frmproduct.TabIndex = 9;
            this.btn_add_frmproduct.Text = "اضافة";
            this.btn_add_frmproduct.UseVisualStyleBackColor = true;
            this.btn_add_frmproduct.Click += new System.EventHandler(this.btn_add_frmproduct_Click);
            // 
            // gc_frmproduct
            // 
            this.gc_frmproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gc_frmproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_frmproduct.Location = new System.Drawing.Point(0, 0);
            this.gc_frmproduct.MainView = this.layoutView1;
            this.gc_frmproduct.Name = "gc_frmproduct";
            this.gc_frmproduct.Size = new System.Drawing.Size(793, 311);
            this.gc_frmproduct.TabIndex = 32;
            this.gc_frmproduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1,
            this.gridView1});
            // 
            // layoutView1
            // 
            this.layoutView1.GridControl = this.gc_frmproduct;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_frmproduct;
            this.gridView1.Name = "gridView1";
            // 
            // grobx_frm_product
            // 
            this.grobx_frm_product.Controls.Add(this.btn_selectimage_frmproduct);
            this.grobx_frm_product.Controls.Add(this.comb_productitem);
            this.grobx_frm_product.Controls.Add(this.label9);
            this.grobx_frm_product.Controls.Add(this.pib_productimage);
            this.grobx_frm_product.Controls.Add(this.label8);
            this.grobx_frm_product.Controls.Add(this.label7);
            this.grobx_frm_product.Controls.Add(this.txt_productstoredquantity);
            this.grobx_frm_product.Controls.Add(this.label6);
            this.grobx_frm_product.Controls.Add(this.txt_productearnprice);
            this.grobx_frm_product.Controls.Add(this.label5);
            this.grobx_frm_product.Controls.Add(this.txt_productsaleprice);
            this.grobx_frm_product.Controls.Add(this.label4);
            this.grobx_frm_product.Controls.Add(this.txt_productbuy);
            this.grobx_frm_product.Controls.Add(this.label3);
            this.grobx_frm_product.Controls.Add(this.txt_productname);
            this.grobx_frm_product.Controls.Add(this.label2);
            this.grobx_frm_product.Controls.Add(this.txt_productcode);
            this.grobx_frm_product.Controls.Add(this.label1);
            this.grobx_frm_product.Controls.Add(this.txt_productnumber);
            this.grobx_frm_product.Dock = System.Windows.Forms.DockStyle.Right;
            this.grobx_frm_product.Location = new System.Drawing.Point(279, 311);
            this.grobx_frm_product.Name = "grobx_frm_product";
            this.grobx_frm_product.Size = new System.Drawing.Size(514, 287);
            this.grobx_frm_product.TabIndex = 33;
            this.grobx_frm_product.TabStop = false;
            this.grobx_frm_product.Text = "بيانات المنتجات";
            this.grobx_frm_product.Enter += new System.EventHandler(this.grobx_frm_product_Enter);
            // 
            // btn_selectimage_frmproduct
            // 
            this.btn_selectimage_frmproduct.Location = new System.Drawing.Point(14, 140);
            this.btn_selectimage_frmproduct.Name = "btn_selectimage_frmproduct";
            this.btn_selectimage_frmproduct.Size = new System.Drawing.Size(107, 28);
            this.btn_selectimage_frmproduct.TabIndex = 52;
            this.btn_selectimage_frmproduct.Text = "...";
            this.btn_selectimage_frmproduct.UseVisualStyleBackColor = true;
            this.btn_selectimage_frmproduct.Click += new System.EventHandler(this.btn_selectimage_frmproduct_Click);
            // 
            // comb_productitem
            // 
            this.comb_productitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_productitem.FormattingEnabled = true;
            this.comb_productitem.Location = new System.Drawing.Point(233, 244);
            this.comb_productitem.Name = "comb_productitem";
            this.comb_productitem.Size = new System.Drawing.Size(172, 24);
            this.comb_productitem.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(411, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "الصنف";
            // 
            // pib_productimage
            // 
            this.pib_productimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_productimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pib_productimage.Location = new System.Drawing.Point(14, 50);
            this.pib_productimage.Name = "pib_productimage";
            this.pib_productimage.Size = new System.Drawing.Size(107, 79);
            this.pib_productimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pib_productimage.TabIndex = 49;
            this.pib_productimage.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(26, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "صورة المنتج";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(411, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "الكمية المخزنه";
            // 
            // txt_productstoredquantity
            // 
            this.txt_productstoredquantity.Location = new System.Drawing.Point(233, 214);
            this.txt_productstoredquantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_productstoredquantity.Name = "txt_productstoredquantity";
            this.txt_productstoredquantity.Size = new System.Drawing.Size(172, 23);
            this.txt_productstoredquantity.TabIndex = 46;
            this.txt_productstoredquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_productstoredquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productstoredquantity_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(411, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "الربح";
            // 
            // txt_productearnprice
            // 
            this.txt_productearnprice.Location = new System.Drawing.Point(233, 183);
            this.txt_productearnprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_productearnprice.Name = "txt_productearnprice";
            this.txt_productearnprice.ReadOnly = true;
            this.txt_productearnprice.Size = new System.Drawing.Size(172, 23);
            this.txt_productearnprice.TabIndex = 44;
            this.txt_productearnprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_productearnprice.TextChanged += new System.EventHandler(this.txt_productearnprice_TextChanged);
            this.txt_productearnprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productearnprice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(411, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "سعر البيع";
            // 
            // txt_productsaleprice
            // 
            this.txt_productsaleprice.Location = new System.Drawing.Point(233, 152);
            this.txt_productsaleprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_productsaleprice.Name = "txt_productsaleprice";
            this.txt_productsaleprice.Size = new System.Drawing.Size(172, 23);
            this.txt_productsaleprice.TabIndex = 42;
            this.txt_productsaleprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_productsaleprice.TextChanged += new System.EventHandler(this.txt_produtsaleprice_TextChanged_1);
            this.txt_productsaleprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_produtsaleprice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(411, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "سعر الشراء";
            // 
            // txt_productbuy
            // 
            this.txt_productbuy.Location = new System.Drawing.Point(233, 121);
            this.txt_productbuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_productbuy.Name = "txt_productbuy";
            this.txt_productbuy.Size = new System.Drawing.Size(172, 23);
            this.txt_productbuy.TabIndex = 40;
            this.txt_productbuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_productbuy.TextChanged += new System.EventHandler(this.txt_produtsaleprice_TextChanged_1);
            this.txt_productbuy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productbuy_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(411, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "الاسم:";
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(233, 90);
            this.txt_productname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(172, 23);
            this.txt_productname.TabIndex = 38;
            this.txt_productname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(411, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "الكود:";
            // 
            // txt_productcode
            // 
            this.txt_productcode.Location = new System.Drawing.Point(233, 59);
            this.txt_productcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_productcode.Name = "txt_productcode";
            this.txt_productcode.Size = new System.Drawing.Size(172, 23);
            this.txt_productcode.TabIndex = 36;
            this.txt_productcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(411, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "رقم المنتج:";
            // 
            // txt_productnumber
            // 
            this.txt_productnumber.Location = new System.Drawing.Point(233, 28);
            this.txt_productnumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_productnumber.Name = "txt_productnumber";
            this.txt_productnumber.ReadOnly = true;
            this.txt_productnumber.Size = new System.Drawing.Size(172, 23);
            this.txt_productnumber.TabIndex = 34;
            this.txt_productnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openfd_frm_product
            // 
            this.openfd_frm_product.FileName = "openFileDialog1";
            // 
            // dgv_frm_product
            // 
            this.dgv_frm_product.AllowUserToAddRows = false;
            this.dgv_frm_product.AllowUserToDeleteRows = false;
            this.dgv_frm_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_frm_product.Location = new System.Drawing.Point(8, 543);
            this.dgv_frm_product.Name = "dgv_frm_product";
            this.dgv_frm_product.ReadOnly = true;
            this.dgv_frm_product.Size = new System.Drawing.Size(261, 55);
            this.dgv_frm_product.TabIndex = 53;
            this.dgv_frm_product.Visible = false;
            // 
            // frm_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 598);
            this.Controls.Add(this.dgv_frm_product);
            this.Controls.Add(this.grobx_frm_product);
            this.Controls.Add(this.gc_frmproduct);
            this.Controls.Add(this.btn_save_frmproduct);
            this.Controls.Add(this.btn_delete_frmproduct);
            this.Controls.Add(this.btn_edit_frmproduct);
            this.Controls.Add(this.btn_add_frmproduct);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_product";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المنتجات";
            this.Load += new System.EventHandler(this.frm_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_frmproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grobx_frm_product.ResumeLayout(false);
            this.grobx_frm_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_productimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frm_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save_frmproduct;
        private System.Windows.Forms.Button btn_delete_frmproduct;
        private System.Windows.Forms.Button btn_edit_frmproduct;
        private System.Windows.Forms.Button btn_add_frmproduct;
        private DevExpress.XtraGrid.GridControl gc_frmproduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private System.Windows.Forms.GroupBox grobx_frm_product;
        private System.Windows.Forms.Button btn_selectimage_frmproduct;
        private System.Windows.Forms.ComboBox comb_productitem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pib_productimage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_productstoredquantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_productearnprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_productsaleprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_productbuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_productcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_productnumber;
        private System.Windows.Forms.OpenFileDialog openfd_frm_product;
        private System.Windows.Forms.DataGridView dgv_frm_product;
    }
}