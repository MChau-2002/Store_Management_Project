﻿using StoreManagement.BUS;
using StoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class FormThemPhanLoai : Form
    {
        PhanLoaiDTO phanLoai;
        public FormThemPhanLoai()
        {
            InitializeComponent();
        }

        private void FormThemPhanLoai_Load(object sender, EventArgs e)
        {
            tbxMaPL.Text = PhanLoaiBUS.Instance.idGenerate("PL");
        }

        private void GetValue()
        {
            string MaLoai = tbxMaPL.Text;
            string TenLoai = tbxPL.Text;

            phanLoai = new PhanLoaiDTO(MaLoai, TenLoai);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                GetValue();
                if (tbxPL.Text.Trim() == "")
                {
                    MessageBox.Show("Mời nhập đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PhanLoaiBUS.Instance.ThemLoai(phanLoai) == true)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
