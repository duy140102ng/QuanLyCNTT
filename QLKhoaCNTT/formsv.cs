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
    public partial class formsv : Form
    {
        Lop_DTO L = new Lop_DTO();
        Lop_BUS loph = new Lop_BUS();
        public formsv()
        {
            InitializeComponent();
        }

        private void formsv_Load(object sender, EventArgs e)
        {
            Lop_DAL da = new Lop_DAL();
            string sql = "select Khoa from SinhVien where Khoa = Khoa";
            cbKhoa.DataSource = da.GetTable(sql);
            cbKhoa.DisplayMember = "Khoa";
            dgvSinhVien.DataSource = loph.ShowSinhVien();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.TextLength == 0)
                MessageBox.Show("Mã sinh viên không được bỏ trống!");
            else if (txtTenSV.TextLength == 0)
                MessageBox.Show("Tên sinh viên không được bỏ trống!");
            else if (txtMaLop.TextLength == 0)
                MessageBox.Show("Mã sinh viên không được bỏ trống!");            
            else
            {
                try
                {
                    L.Masv = txtMaSV.Text;
                    L.Tensv = txtTenSV.Text;
                    L.Malop = txtMaLop.Text;                   
                    loph.InsertSinhVien(txtMaSV.Text, txtTenSV.Text, txtMaLop.Text, cbKhoa.Text);
                    MessageBox.Show("Thêm thành công!");

                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
                formsv_Load(sender, e);
            }
        }

        private void dgvSinhVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                txtMaSV.Text = dgvSinhVien.Rows[dong].Cells[0].Value.ToString();
                txtTenSV.Text = dgvSinhVien.Rows[dong].Cells[1].Value.ToString();
                txtMaLop.Text = dgvSinhVien.Rows[dong].Cells[2].Value.ToString();
                cbKhoa.Text = dgvSinhVien.Rows[dong].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.TextLength == 0)
                MessageBox.Show("Mã sinh viên không được bỏ trống!");
            else if (txtTenSV.TextLength == 0)
                MessageBox.Show("Tên sinh viên không được bỏ trống!");
            else if (txtMaLop.TextLength == 0)
                MessageBox.Show("Mã lớp không được bỏ trống!");           
            else
            {
                try
                { 
                    L.Masv = txtMaSV.Text.Trim();
                    L.Tensv = txtTenSV.Text;
                    L.Malop = txtMaLop.Text;
                    L.Khoa = cbKhoa.Text;
                    loph.UpdateSinhVien(L.Masv, L.Tensv, L.Malop, L.Khoa);
                    MessageBox.Show("Sửa thành công!");
                    formsv_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.TextLength == 0)
                MessageBox.Show("Bạn cần chọn mã học sinh viên để xóa");
            else
                L.Masv = txtMaSV.Text;
            loph.DeleteSinhVien(L.Masv);
            MessageBox.Show("Xóa thành công!");
            formsv_Load(sender, e);
        }
    }
}
