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
    public partial class formhp : Form
    {
        Lop_DTO L = new Lop_DTO();
        Lop_BUS loph = new Lop_BUS();
        public formhp()
        {
            InitializeComponent();
        }

        private void formhp_Load(object sender, EventArgs e)
        {
            dgvHocPhan.DataSource = loph.ShowHocPhan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHP.TextLength == 0)
                MessageBox.Show("Mã học phần không được bỏ trống!");
            else if (txtTenHP.TextLength == 0)
                MessageBox.Show("Tên học phần không được bỏ trống!");
            else if (txtSoTC.TextLength == 0)
                MessageBox.Show("Số tín chỉ không được bỏ trống!");
            else if (txtMaGV.TextLength == 0)
                MessageBox.Show("Mã giảng viên không được bỏ trống!");
            else
            {
                try
                {
                    L.Mahp = txtMaHP.Text;
                    L.Tenhp = txtTenHP.Text;
                    L.Sotc = int.Parse(txtSoTC.Text);
                    L.Magv = txtMaGV.Text;
                    loph.InsertHocPhan(txtMaHP.Text, txtTenHP.Text, int.Parse(txtSoTC.Text), txtMaGV.Text);
                    MessageBox.Show("Thêm thành công!");

                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
                formhp_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHP.TextLength == 0)
                MessageBox.Show("Mã học phần không được bỏ trống!");
            else if (txtTenHP.TextLength == 0)
                MessageBox.Show("Tên học phần không được bỏ trống!");
            else if (txtSoTC.TextLength == 0)
                MessageBox.Show("Số tín chỉ không được bỏ trống!");
            else if (txtMaGV.TextLength == 0)
                MessageBox.Show("Mã giảng viên không được bỏ trống!");
            else
            {
                try
                {
                    L.Mahp = txtMaHP.Text;
                    L.Tenhp = txtTenHP.Text;
                    L.Sotc = int.Parse(txtSoTC.Text);
                    L.Magv = txtMaGV.Text;
                    loph.UpdateHocPhan(L.Mahp, L.Tenhp, L.Sotc, L.Magv);
                    MessageBox.Show("Sửa thành công!");
                    formhp_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHP.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã học phần để xóa");
            else
                L.Mahp = txtMaHP.Text;
            loph.DeleteHocPhan(L.Mahp);
            MessageBox.Show("Xóa thành công!");
            formhp_Load(sender, e);
        }

        private void dgvHocPhan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                txtMaHP.Text = dgvHocPhan.Rows[dong].Cells[0].Value.ToString();
                txtTenHP.Text = dgvHocPhan.Rows[dong].Cells[1].Value.ToString();
                txtSoTC.Text = dgvHocPhan.Rows[dong].Cells[2].Value.ToString();
                txtMaGV.Text = dgvHocPhan.Rows[dong].Cells[3].Value.ToString();
            } catch
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
