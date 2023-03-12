using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHANVIEN
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelTenDangNhap.Text = Form1.thisForm.RichTextBoxTen.Text;
            //specify columns
            listViewDanhSach.Columns.Add("Họ tên", listViewDanhSach.Width / 2, HorizontalAlignment.Left);
            listViewDanhSach.Columns.Add("Ngày sinh", listViewDanhSach.Width / 4, HorizontalAlignment.Left);
            listViewDanhSach.Columns.Add("Giới tính", listViewDanhSach.Width / 4, HorizontalAlignment.Left);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            ListViewItem hang = new ListViewItem(richTextBoxTen.Text);
            hang.SubItems.Add(dateTmPckrNgaySinh.Value.ToShortDateString());
            hang.SubItems.Add(radioButtonNam.Checked ? radioButtonNam.Text : radioButtonNu.Text);
            listViewDanhSach.Items.Add(hang);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            for (int i = listViewDanhSach.SelectedItems.Count - 1; i >= 0; i--)
            {
                listViewDanhSach.Items.Remove(listViewDanhSach.SelectedItems[i]);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Opacity > 0)
            {
                timerFade.Enabled = true;
                timerFade.Start();
            }
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1 ;
            if (this.Opacity <= 0) {
                this.Close();
                Form1.thisForm.Close();
            }
        }
    }
}
