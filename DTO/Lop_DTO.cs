using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop_DTO
    {
        string malop_, tenlop_, tensv_, masv_, khoa_, mahp_, tenhp_, magv_, tengv_;
        int sosv_, sotc_;
        public string Malop
        {
            get { return malop_; }
            set { malop_ = value; }
        }
        public string Tenlop
        {
            get { return tenlop_; }
            set { tenlop_ = value; }
        }
        public int Sosv
        {
            get { return sosv_; }
            set { sosv_ = value; }
        }
        public string Masv
        {
            get { return masv_; }
            set { masv_ = value; }
        }
        public string Tensv
        {
            get { return tensv_; }
            set { tensv_ = value; }
        }
        public string Khoa
        {
            get { return khoa_; }
            set { khoa_ = value; }
        }
        public string Mahp
        {
            get { return mahp_; }
            set { mahp_ = value; }
        }
        public string Tenhp
        {
            get { return tenhp_; }
            set { tenhp_ = value; }
        }
        public int Sotc
        {
            get { return sotc_; }
            set { sotc_ = value; }
        }
        public string Magv
        {
            get { return magv_; }
            set { magv_ = value; }
        }
        public string Tegv
        {
            get { return tengv_; }
            set { tengv_ = value; }
        }
    }
}

