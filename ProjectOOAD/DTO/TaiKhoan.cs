﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TaiKhoan
    {
        public  string maNhanVien
        {
            get;
            set;
        }

        public  string taiKhoan
        {
            get;
            set;
        }

        public  string matKhau
        {
            get;
            set;
        }

        public TaiKhoan()
        {

        }
        public TaiKhoan(string _maNhanVien, string _taiKhoan, string _matKhau)
        {
            this.maNhanVien = _maNhanVien;
            this.taiKhoan = _taiKhoan;
            this.matKhau = _matKhau;
        }
    }
}


