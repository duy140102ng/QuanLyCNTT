using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhoaCNTT {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            loadform(new formgv());
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            loadform(new formsv());
        }

        private void btnHP_Click(object sender, EventArgs e)
        {
            loadform(new formhp());
        }

        private void btnLop_Click(object sender, EventArgs e) {
            loadform(new formlop());
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThongKe_Click(object sender, EventArgs e) {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
