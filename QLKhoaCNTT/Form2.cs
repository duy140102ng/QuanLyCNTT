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
using System.Data.SqlClient;

namespace QLKhoaCNTT {
    public partial class Form2 : Form {

        Lop_DTO L = new Lop_DTO();
        Lop_BUS loph = new Lop_BUS();
        Lop_DAL da = new Lop_DAL();
        string condition1 = "",
            condition2 = "";
  
        public Form2() {
            InitializeComponent();
            form_Load();
        }

        private void form_Load() {
            DataTable dt = loph.GetTableName();
            cbTable.DataSource = dt;
            cbTable.DisplayMember = "name";
            form_Load_c(dt);
        }

        private void load_condition() {
            string table = cbTable.Text;
            switch (table) {
                case "Lop":
                    condition1 = $"Select * from GiangVien where MaLop='{LopcbMaLop.Text}'";
                    break;
                case "SinhVien":
                    condition1 = $"Select * from SinhVien where MaLop='{SinhViencbMaLop.Text}'";
                    condition2 = $"Select * from SinhVien where Khoa='{SinhViencbKhoa.Text}'";
                    break;
                case "GiangVien":
                    condition1 = $"Select * from HocPhan where MaGV='{GiangViencbMaGV.Text}'";
                    condition2 = $"Select * from GiangVien where MaLop='{GiangViencbMaLop.Text}'";
                    break;
                case "HocPhan":
                    condition1 = $"Select * from GiangVien where MaHP='{HocPhancbMaHP.Text}'";
                    condition1 = $"Select * from HocPhan where SoTC='{HocPhancbSoTC.Text}'";
                    break;
            }
        }

        private void form_Load_c(DataTable _dt) {
            foreach (DataRow row in _dt.Rows) {
                string table = row.ItemArray[0].ToString();
                //MessageBox.Show(table);
                string sql = $"select * from {table}";
                DataTable dt = da.GetTable(sql);
                foreach (Panel a in this.Controls.OfType<Panel>()) {
                    foreach (DataColumn column in dt.Columns) {
                        string name = column.ColumnName;
                        foreach (ComboBox box in a.Controls
                        .OfType<ComboBox>()
                        .Where(x => x.Name.StartsWith($"{table}"))) {
                            if (box.Name.Equals($"{table}cb{name}")) {
                                box.DataSource = dt;
                                box.DisplayMember = name;
                            }
                        }
                    }
                }
            }
        } // form_Load_c


        private void cbTable_SelectedIndexChanged(object sender, EventArgs e) {
            string table = cbTable.Text;
            foreach (Panel a in this.Controls.OfType<Panel>()) {
                if (a.Name.Equals(table)) {
                    a.Enabled = true;
                    a.Visible = true;
                }
                else {
                    a.Enabled = false;
                    a.Visible = false;
                }
            }

            load_condition();
        }

        private void comboBoxSelectedIndexChanged(object sender, EventArgs e) {
            load_condition();
        }

        private void CheckBoxChanged(object sender, EventArgs e) {
            CheckBox cb = (CheckBox)sender;
            string table = cb.Name.Substring(0, cb.Name.IndexOf("check"));
            CheckBox cb1 = null, cb2 = null;
            foreach (Panel a in this.Controls.OfType<Panel>()
                .Where(x => x.Name.Equals(table))) {
                foreach (CheckBox box in a.Controls.OfType<CheckBox>())
                    if (box.Name.EndsWith("1"))
                        cb1 = box;
                    else cb2 = box;

                if (cb.Checked) {
                    if (cb.Name.EndsWith("1"))
                        cb2.Enabled = false;
                    else cb1.Enabled = false;
                } else {
                    if (cb.Name.EndsWith("1"))
                        cb2.Enabled = true;
                    else cb1.Enabled = true;
                }
            }
            load_condition();
        }
        private void btnFill_Click(object sender, EventArgs e) {
            string table = cbTable.Text;
            if (table.Equals("System.Data.DataRowView")) return;
            dgvTable.DataSource = loph.ShowTable($"select * from {table}");
            foreach (Panel a in this.Controls.OfType<Panel>().Where(x => x.Name.Equals(table))) {
                    foreach (CheckBox box in a.Controls
                        .OfType<CheckBox>()) {

                    if (box.Checked) {
                        if (!box.Name.StartsWith(table)) continue;
                        if (box.Name.EndsWith("1")) {
                            dgvTable.DataSource = loph.ShowTable(condition1);
                            //MessageBox.Show($"{box.Name} - {condition1}");
                            break;
                        }
                        else {
                            dgvTable.DataSource = loph.ShowTable(condition2);
                            //MessageBox.Show($"{box.Name} - {condition2}");
                            break;
                        }
                    }
                }
            }
        }
    }
}
