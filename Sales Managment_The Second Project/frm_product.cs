using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sales_Managment_The_Second_Project
{
    public partial class frm_product : Form
    {
        Boolean ADD;
        //Function For Delete Data
        public void cleartext()
            {
            txt_productnumber.Clear();
            txt_productbuy.Clear();
            txt_productcode.Clear();
            txt_productearnprice.Clear();
            txt_productname.Clear();
            txt_productstoredquantity.Clear();
            txt_productsaleprice.Clear();
            pib_productimage.Image = null;
            }//End cleartext

        //Function To Load Product Data
        public void LoadProduct()
        {
            class_product clsp = new class_product();
            clsp.loadpublic("LoadView_ProductItems_SM");
            gc_frmproduct.DataSource = clsp.Dtpublic;
            dgv_frm_product.DataSource = clsp.Dtpublic;
        }//End LoadProduct
        public frm_product()
        {
            InitializeComponent();
            class_items cls = new class_items();
            cls.loaditem();
            comb_productitem.DataSource = cls.dtitem;
            comb_productitem.DisplayMember = "nameitem";
            comb_productitem.ValueMember   = "id";
            //Disable Products Options
            grobx_frm_product.Enabled = false;

            LoadProduct();
        }//End frm_product

        //Fun to use numbers only for textbox
        private void usenumbersonly(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':case'1': case '2': case '3': case '5': case '6':
                case '7': case '8': case '9': case '.': case (char)Keys.Back:
                case(char) Keys.Enter:
                    e.Handled = false;
                    break;
                default:
                    MessageBox.Show("Please use number only", "Warning operation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    e.Handled = true;
                    break;
            }//End switch
        }//End fun usenumbersonly

        private void txt_itemnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_product_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_frmproduct_Click(object sender, EventArgs e)
        {
            cleartext();
            class_product cls = new class_product();
            int max = cls.MaxIDpublic("MaxIDproduct_SM") + 1;
            txt_productnumber.Text = max.ToString();

            ADD = true;
            btn_save_frmproduct.Enabled = true;
            grobx_frm_product.Enabled = true;  
        }//End btn_add_frmproduct_Click

        private void btn_edit_frmproduct_Click(object sender, EventArgs e)
        {
            ADD = false;
            btn_save_frmproduct.Enabled = true;
            grobx_frm_product.Enabled = true;
            txt_productcode.ReadOnly = true;
            //To Edit Product Data
            try
            {
                txt_productnumber.Text         = dgv_frm_product.CurrentRow.Cells[0].Value.ToString();
                txt_productcode.Text           = dgv_frm_product.CurrentRow.Cells[1].Value.ToString();
                txt_productname.Text           = dgv_frm_product.CurrentRow.Cells[2].Value.ToString();
                txt_productbuy.Text            = dgv_frm_product.CurrentRow.Cells[3].Value.ToString();
                txt_productsaleprice.Text      = dgv_frm_product.CurrentRow.Cells[4].Value.ToString();
                txt_productearnprice.Text      = dgv_frm_product.CurrentRow.Cells[5].Value.ToString();
                txt_productstoredquantity.Text = dgv_frm_product.CurrentRow.Cells[6].Value.ToString();
                comb_productitem.Text          = dgv_frm_product.CurrentRow.Cells[8].Value.ToString();

            }
            catch (Exception)
            {

                return;
            }

            try
            {
                class_product cls = new class_product();
                byte[] img = (byte[])cls.getimageproduct(dgv_frm_product.CurrentRow.Cells[1]
                .Value.ToString()).Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                pib_productimage.Image = Image.FromStream(ms);
            
            }
            catch (Exception)
            {

                pib_productimage.Image = null;
            }
             
        }//End btn_edit_frmproduct_Click

        private void btn_save_frmproduct_Click(object sender, EventArgs e)
        {
            if (ADD==true)
            {
                //Insert

            if(pib_productimage.Image==null)
                {
                    //Insert Without Image
                    class_product cls = new class_product();
                    cls.insertproductNotImage(Convert.ToInt32(txt_productnumber.Text), txt_productcode.Text, txt_productname.Text,Convert.ToDouble(txt_productbuy.Text),
                    Convert.ToDouble (txt_productsaleprice.Text),Convert.ToDouble(txt_productearnprice.Text),Convert.ToDouble(txt_productstoredquantity.Text),Convert.ToInt32(comb_productitem.SelectedValue));
                    MessageBox.Show("Do You Want Added Successfully..Without Image","Save operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }//End if
            else
                {
                    //Insert With Image
                    MemoryStream ms = new MemoryStream();
                    pib_productimage.Image.Save(ms, pib_productimage.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    class_product cls = new class_product();
                    cls.insertproductImage(Convert.ToInt32(txt_productnumber.Text), txt_productcode.Text, txt_productname.Text, Convert.ToDouble(txt_productbuy.Text),
                    Convert.ToDouble(txt_productsaleprice.Text), Convert.ToDouble(txt_productearnprice.Text), Convert.ToDouble(txt_productstoredquantity.Text),img, Convert.ToInt32(comb_productitem.SelectedValue));
                    MessageBox.Show("Do You Want Added Successfully..With Image", "Save operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

            }//End if
            else
            {
                if (pib_productimage.Image==null)
                {
                    //Update Without Image
                    class_product cls = new class_product();
                    cls.updateproduct(txt_productname.Text, Convert.ToDouble(txt_productbuy.Text),Convert.ToDouble(txt_productsaleprice.Text),
                    Convert.ToDouble(txt_productearnprice.Text), Convert.ToDouble(txt_productstoredquantity.Text), Convert.ToInt32(comb_productitem.SelectedValue), txt_productcode.Text);
                    MessageBox.Show("Do You Want Edit Successfully..Without An Image", "Edit operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }//End if
                else
                {
                    //Update With Image
                    MemoryStream ms = new MemoryStream();
                    pib_productimage.Image.Save(ms, pib_productimage.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    class_product cls = new class_product();
                    cls.updateproductimage(txt_productname.Text, Convert.ToDouble(txt_productbuy.Text),Convert.ToDouble(txt_productsaleprice.Text), Convert.ToDouble(txt_productearnprice.Text), 
                    Convert.ToDouble(txt_productstoredquantity.Text), img ,Convert.ToInt32(comb_productitem.SelectedValue),txt_productcode.Text);
                    MessageBox.Show("Do You Want Added Successfully..With Image", "Save operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                
            }

            cleartext();
            btn_save_frmproduct.Enabled = false;
            grobx_frm_product.Enabled = false;
            LoadProduct();

        }//End btn_save_frmproduct_Click

        private void txt_productbuy_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_productearnprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txt_productearnprice.Text) <= 0)
                {
                    txt_productearnprice.BackColor = Color.Red;
                }
                else
                {
                    txt_productearnprice.BackColor = Color.White;
                }
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void txt_produtsaleprice_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txt_produtsaleprice_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                //Process : Earn=Saleprice-Buyprice
                txt_productearnprice.Text = (Convert.ToDouble(txt_productsaleprice.Text) - Convert.ToDouble(txt_productbuy.Text)).ToString();
            }
            catch (Exception)
            {

                return;
            }
        }

        private void txt_productbuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            usenumbersonly(e);
        }

        private void txt_produtsaleprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            usenumbersonly(e);
        }

        private void txt_productearnprice_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_productstoredquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            usenumbersonly(e);
        }

        private void btn_selectimage_frmproduct_Click(object sender, EventArgs e)
        {
            openfd_frm_product.Filter = "Img |*.jpeg; *.jpg; *.png";
            if (openfd_frm_product.ShowDialog()==DialogResult.OK)
            {
                pib_productimage.Image = Image.FromFile(openfd_frm_product.FileName);
            }
        }

        private void grobx_frm_product_Enter(object sender, EventArgs e)
        {

        }
    }
}
