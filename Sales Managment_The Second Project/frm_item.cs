using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Managment_The_Second_Project
{
    public partial class frm_item : Form
    {
        int ADD = 0;
        public frm_item()
        {
            InitializeComponent();
            class_items item = new class_items();
            item.loaditem();
            dgv_frmitem.DataSource = item.dtitem;
            //Change the field names
            dgv_frmitem.Columns[0].HeaderText = "رقم الصنف";
            dgv_frmitem.Columns[1].HeaderText = "اسم الصنف";
            //For max id
            //int id = item.maxid() + 1;
            //txt_itemnumber.Text = id.ToString();
        }

        private void frm_item_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_frmitem_Click(object sender, EventArgs e)
        {
            ADD = 0;
            class_items cls = new class_items();
            txt_itemname.Enabled = true;
            txt_itemname.Clear();
            txt_itemname.Select();
            int id = cls.maxid() + 1;
            txt_itemnumber.Text = id.ToString();
        }

        private void btn_save_frmitem_Click(object sender, EventArgs e)
        {
            if(ADD==0)
            {
                class_items cls = new class_items();
                cls.Insertitems(Convert.ToInt32(txt_itemnumber.Text), txt_itemname.Text);
                //Download items data
                cls.loaditem();
                dgv_frmitem.DataSource = cls.dtitem;
                MessageBox.Show("Added Successfully");
                txt_itemname.Clear();
                txt_itemname.Enabled = false;
            }
            else
            {
                class_items cls = new class_items();
                cls.Updateitems(Convert.ToInt32(txt_itemnumber.Text), txt_itemname.Text);
                cls.loaditem();
                dgv_frmitem.DataSource = cls.dtitem;
                MessageBox.Show("Editting Successfully");
                txt_itemname.Clear();
                txt_itemname.Enabled = false;
            }
        }//End btn_save_frmitem_Click

        private void btn_edit_frmitem_Click(object sender, EventArgs e)
        {
            ADD = 1;
            txt_itemnumber.Text = dgv_frmitem.CurrentRow.Cells[0].Value.ToString();
            txt_itemname.Text = dgv_frmitem.CurrentRow.Cells[1].Value.ToString();
            txt_itemname.Enabled = true;
        }

        private void btn_delete_frmitem_Click(object sender, EventArgs e)
        {
            class_items cls = new class_items();
            int id = Convert.ToInt32(dgv_frmitem.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Do you want delete the specified item?","Delete Process"+dgv_frmitem.CurrentRow.Cells[1].Value,MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                cls.Deleteitems(id);
                MessageBox.Show("Delete Successfuly", "Delete Process"+ " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The Deletion Was Canceled", "Delete Process"+ " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Download data again
            cls.loaditem();
            dgv_frmitem.DataSource = cls.dtitem;
        }//End btn_delete_frmitem_Click
    }
}
