namespace Sales_Managment_The_Second_Project
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.ac_login = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aci_login = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aci_logout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ac_store = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aci_class = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aci_product = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ac_sales = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aci_salesmanagment = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aci_salesoreder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ac_purcheses = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aci_purchesesmanagment = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aci_purchesesorder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ac_suppliers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aci_suppliersmanagment = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ac_customers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aci_customersmanagment = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ac_users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aci_usersmanagment = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.ElementPositionOnExpanding = DevExpress.XtraBars.Navigation.ElementPositionOnExpanding.ScrollUp;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ac_login,
            this.ac_store,
            this.ac_sales,
            this.ac_purcheses,
            this.ac_suppliers,
            this.ac_customers,
            this.ac_users});
            this.accordionControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(261, 484);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "hf";
            this.accordionControl1.Click += new System.EventHandler(this.accordionControl1_Click);
            // 
            // ac_login
            // 
            this.ac_login.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aci_login,
            this.aci_logout});
            this.ac_login.Expanded = true;
            this.ac_login.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.ac_login.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ac_login.ImageOptions.Image")));
            this.ac_login.Name = "ac_login";
            this.ac_login.Text = "الدخول";
            this.ac_login.Click += new System.EventHandler(this.ac_login_Click);
            // 
            // aci_login
            // 
            this.aci_login.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aci_login.ImageOptions.Image")));
            this.aci_login.Name = "aci_login";
            this.aci_login.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aci_login.Text = "تسجيل الدخول";
            this.aci_login.Click += new System.EventHandler(this.aci_login_Click);
            // 
            // aci_logout
            // 
            this.aci_logout.Enabled = false;
            this.aci_logout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aci_logout.ImageOptions.Image")));
            this.aci_logout.Name = "aci_logout";
            this.aci_logout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aci_logout.Text = "تسجيل الخروج";
            this.aci_logout.Click += new System.EventHandler(this.aci_logout_Click);
            // 
            // ac_store
            // 
            this.ac_store.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aci_class,
            this.aci_product});
            this.ac_store.Enabled = false;
            this.ac_store.Expanded = true;
            this.ac_store.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.ac_store.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ac_store.ImageOptions.Image")));
            this.ac_store.Name = "ac_store";
            this.ac_store.Text = "المخزن";
            // 
            // aci_class
            // 
            this.aci_class.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aci_class.ImageOptions.Image")));
            this.aci_class.Name = "aci_class";
            this.aci_class.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aci_class.Text = "الاصناف";
            this.aci_class.Click += new System.EventHandler(this.aci_class_Click);
            // 
            // aci_product
            // 
            this.aci_product.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aci_product.ImageOptions.Image")));
            this.aci_product.Name = "aci_product";
            this.aci_product.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aci_product.Text = "المنتجات";
            this.aci_product.Click += new System.EventHandler(this.aci_product_Click);
            // 
            // ac_sales
            // 
            this.ac_sales.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aci_salesmanagment,
            this.aci_salesoreder});
            this.ac_sales.Enabled = false;
            this.ac_sales.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.ac_sales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ac_sales.ImageOptions.Image")));
            this.ac_sales.Name = "ac_sales";
            this.ac_sales.Text = "المبيعات";
            // 
            // aci_salesmanagment
            // 
            this.aci_salesmanagment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aci_salesmanagment.ImageOptions.Image")));
            this.aci_salesmanagment.Name = "aci_salesmanagment";
            this.aci_salesmanagment.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aci_salesmanagment.Text = "ادارة المبيعات";
            // 
            // aci_salesoreder
            // 
            this.aci_salesoreder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aci_salesoreder.ImageOptions.Image")));
            this.aci_salesoreder.Name = "aci_salesoreder";
            this.aci_salesoreder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aci_salesoreder.Text = "طلبات المبيعات";
            // 
            // ac_purcheses
            // 
            this.ac_purcheses.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aci_purchesesmanagment,
            this.aci_purchesesorder});
            this.ac_purcheses.Enabled = false;
            this.ac_purcheses.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.ac_purcheses.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ac_purcheses.ImageOptions.Image")));
            this.ac_purcheses.Name = "ac_purcheses";
            this.ac_purcheses.Text = "المشتريات";
            // 
            // aci_purchesesmanagment
            // 
            this.aci_purchesesmanagment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aci_purchesesmanagment.ImageOptions.Image")));
            this.aci_purchesesmanagment.Name = "aci_purchesesmanagment";
            this.aci_purchesesmanagment.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aci_purchesesmanagment.Text = "ادارة المشتريات";
            // 
            // aci_purchesesorder
            // 
            this.aci_purchesesorder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aci_purchesesorder.ImageOptions.Image")));
            this.aci_purchesesorder.Name = "aci_purchesesorder";
            this.aci_purchesesorder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aci_purchesesorder.Text = "طلبات المشتريات";
            // 
            // ac_suppliers
            // 
            this.ac_suppliers.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aci_suppliersmanagment});
            this.ac_suppliers.Enabled = false;
            this.ac_suppliers.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.ac_suppliers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ac_suppliers.ImageOptions.Image")));
            this.ac_suppliers.Name = "ac_suppliers";
            this.ac_suppliers.Text = "الموردين";
            // 
            // aci_suppliersmanagment
            // 
            this.aci_suppliersmanagment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aci_suppliersmanagment.ImageOptions.Image")));
            this.aci_suppliersmanagment.Name = "aci_suppliersmanagment";
            this.aci_suppliersmanagment.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aci_suppliersmanagment.Text = "ادارة الموردين";
            // 
            // ac_customers
            // 
            this.ac_customers.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aci_customersmanagment});
            this.ac_customers.Enabled = false;
            this.ac_customers.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.ac_customers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ac_customers.ImageOptions.Image")));
            this.ac_customers.Name = "ac_customers";
            this.ac_customers.Text = "العملاء";
            // 
            // aci_customersmanagment
            // 
            this.aci_customersmanagment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aci_customersmanagment.ImageOptions.Image")));
            this.aci_customersmanagment.Name = "aci_customersmanagment";
            this.aci_customersmanagment.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aci_customersmanagment.Text = "ادارة العملاء";
            // 
            // ac_users
            // 
            this.ac_users.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aci_usersmanagment});
            this.ac_users.Enabled = false;
            this.ac_users.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.ac_users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ac_users.ImageOptions.Image")));
            this.ac_users.Name = "ac_users";
            this.ac_users.Text = "المستخدمين";
            this.ac_users.Click += new System.EventHandler(this.accordionControlElement7_Click);
            // 
            // aci_usersmanagment
            // 
            this.aci_usersmanagment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aci_usersmanagment.ImageOptions.Image")));
            this.aci_usersmanagment.Name = "aci_usersmanagment";
            this.aci_usersmanagment.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aci_usersmanagment.Text = "ادارة المستخدمين";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Sales_Managment_The_Second_Project.Properties.Resources._02;
            this.pictureBox1.Location = new System.Drawing.Point(261, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 484);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.accordionControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج المبيعات الكامل";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aci_class;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aci_product;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aci_salesmanagment;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aci_salesoreder;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aci_purchesesmanagment;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aci_purchesesorder;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aci_suppliersmanagment;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aci_customersmanagment;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aci_usersmanagment;
        private System.Windows.Forms.PictureBox pictureBox1;
        public DevExpress.XtraBars.Navigation.AccordionControlElement ac_login;
        public DevExpress.XtraBars.Navigation.AccordionControlElement aci_login;
        public DevExpress.XtraBars.Navigation.AccordionControlElement aci_logout;
        public DevExpress.XtraBars.Navigation.AccordionControlElement ac_store;
        public DevExpress.XtraBars.Navigation.AccordionControlElement ac_sales;
        public DevExpress.XtraBars.Navigation.AccordionControlElement ac_purcheses;
        public DevExpress.XtraBars.Navigation.AccordionControlElement ac_suppliers;
        public DevExpress.XtraBars.Navigation.AccordionControlElement ac_customers;
        public DevExpress.XtraBars.Navigation.AccordionControlElement ac_users;
    }
}

