using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace QLKhoaCNTT {
    public partial class formlop : Form
    {
        Lop_DTO L = new Lop_DTO();
        Lop_BUS loph = new Lop_BUS();
        public formlop()
        {
            InitializeComponent();
        }

        private void formlop_Load(object sender, EventArgs e)
        {
            dgvLop.DataSource = loph.ShowLop();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
                MessageBox.Show("Mã lớp không được bỏ trống!");
            else if (txtTenLop.TextLength == 0)
                MessageBox.Show("Tên lớp không được bỏ trống!");
            else if (txtSoSV.TextLength == 0)
                MessageBox.Show("Số sinh viên không được bỏ trống!");
            else
            {
                try
                {
                    L.Malop = txtMaLop.Text;
                    L.Tenlop = txtTenLop.Text;
                    L.Sosv = int.Parse(txtSoSV.Text);
                    loph.InsertLop(txtMaLop.Text,txtTenLop.Text,int.Parse(txtSoSV.Text));
                    MessageBox.Show("Thêm thành công!");
                   
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
                formlop_Load(sender, e);
            }     
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
                MessageBox.Show("Mã lớp không được bỏ trống!");
            else if (txtTenLop.TextLength == 0)
                MessageBox.Show("Tên lớp không được bỏ trống!");
            else if (txtSoSV.TextLength == 0)
                MessageBox.Show("Số sinh viên không được bỏ trống!");
            else
            {
                try
                {
                    L.Malop = txtMaLop.Text;
                    L.Tenlop = txtTenLop.Text;
                    L.Sosv = Int32.Parse(txtSoSV.Text);
                    loph.UpdateLop(L.Malop, L.Tenlop, L.Sosv);
                    MessageBox.Show("Sửa thành công!");
                    formlop_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLop.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã lớp để xóa");
            else
                L.Malop = txtMaLop.Text;
            loph.DeleteLop(L.Malop);
            MessageBox.Show("Xóa thành công!");
            formlop_Load(sender, e);
        }

        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaLop.Text = dgvLop.Rows[dong].Cells[0].Value.ToString();
            txtTenLop.Text = dgvLop.Rows[dong].Cells[1].Value.ToString();
            txtSoSV.Text = dgvLop.Rows[dong].Cells[2].Value.ToString();
        }
    }
}
