﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.Forms.Hotel
{
    public partial class HotelMainForm : Form
    {
        public HotelMainForm()
        {
            InitializeComponent();
        }

        private void btnCreateHotel_Click(object sender, EventArgs e)
        {
            HotelCreateForm dlg = new HotelCreateForm();
            dlg.ShowDialog();
        }
    }
}
