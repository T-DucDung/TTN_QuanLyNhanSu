﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.GUI.KyLuat
{
    public partial class ChiTietQuyetDinhKyLuat : Form
    {

        /// <summary>
        /// 
        /// - Xử lý ngày (regex)
        /// 
        /// - trạng thái có 3 trang thái có sẵn.
        /// 
        /// - trước khi lưu thông báo có muốn lưu thay đổi.
        /// 
        /// - Lưu khi có sự thay đổi dữ liệu.
        /// 
        /// </summary>

        public ChiTietQuyetDinhKyLuat()
        {
            InitializeComponent();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
