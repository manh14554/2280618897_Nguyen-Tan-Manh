using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem selected = lvNhanVien.SelectedItems[0];
                selected.SubItems.Clear(); 
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem list = new ListViewItem(txtLastName.Text);
            list.SubItems.Add (txtFirstName.Text);
            list.SubItems.Add(txtPhone.Text);
            lvNhanVien.Items.Add(list);
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lay du lieu tu dong hien thi len cac text box
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem selected = lvNhanVien.SelectedItems[0];
                txtFirstName.Text = selected.SubItems[1].Text;
                txtLastName.Text = selected.SubItems[0].Text;
                txtPhone.Text = selected.SubItems[2].Text;
            }
            else 
            { 
                txtLastName.Clear();
                txtFirstName.Clear();
                txtPhone.Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem selected = lvNhanVien.SelectedItems[0];
                selected.SubItems[0].Text = txtLastName.Text;
                selected.SubItems[1].Text = txtFirstName.Text;
                selected.SubItems[2].Text = txtPhone.Text;
            }
        }
    }
}
