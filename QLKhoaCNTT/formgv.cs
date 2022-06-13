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
    public partial class formgv : Form
    {
        Lop_DTO L = new Lop_DTO();
        Lop_BUS loph = new Lop_BUS();
        public formgv()
        {
            InitializeComponent();
        }

        private void formgv_Load(object sender, EventArgs e)
        {
            dgvGiangVien.DataSource = loph.ShowGiangVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaGV.TextLength == 0)
                MessageBox.Show("Mã giảng viên không được bỏ trống!");
            else if (txtTenGV.TextLength == 0)
                MessageBox.Show("Tên giảng viên không được bỏ trống!");
            else if (txtMaLop.TextLength == 0)
                MessageBox.Show("Mã lớp không được bỏ trống!");
            else if (txtMaHP.TextLength == 0)
                MessageBox.Show("Mã học phần không được bỏ trống!");
            else
            {
                try
                {
                    L.Magv = txtMaGV.Text;
                    L.Tegv = txtTenGV.Text; 
                    L.Malop = txtMaLop.Text;
                    L.Mahp = txtMaHP.Text;
                    MessageBox.Show($"{L.Magv}, {L.Tegv}, {L.Malop}, {L.Mahp}");
                    loph.InsertGiangVien(L.Magv,L.Tegv,L.Malop,L.Mahp);
                    MessageBox.Show("Thêm thành công!");

                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
                formgv_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaGV.TextLength == 0)
                MessageBox.Show("Mã giảng viên không được bỏ trống!");
            else if (txtTenGV.TextLength == 0)
                MessageBox.Show("Tên giảng viên không được bỏ trống!");
            else if (txtMaLop.TextLength == 0)
                MessageBox.Show("Mã lớp không được bỏ trống!");
            else if (txtMaHP.TextLength == 0)
                MessageBox.Show("Mã học phần không được bỏ trống!");
            else
            {
                try
                {
                    L.Magv = txtMaGV.Text;
                    L.Tegv = txtTenGV.Text;
                    L.Malop = txtMaLop.Text;
                    L.Mahp = txtMaHP.Text;
                    loph.UpdateGiangVien(txtMaGV.Text, txtTenGV.Text, txtMaLop.Text, txtMaHP.Text);
                    MessageBox.Show("Sửa thành công!");

                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
                formgv_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaGV.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã học phần để xóa");
            else
                L.Magv = txtMaGV.Text;
            loph.DeleteGiangVien(L.Magv);
            MessageBox.Show("Xóa thành công!");
            formgv_Load(sender, e);
        }

        private void dgvGiangVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                txtMaGV.Text = dgvGiangVien.Rows[dong].Cells[0].Value.ToString();
                txtTenGV.Text = dgvGiangVien.Rows[dong].Cells[1].Value.ToString();
                txtMaLop.Text = dgvGiangVien.Rows[dong].Cells[2].Value.ToString();
                txtMaHP.Text = dgvGiangVien.Rows[dong].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
