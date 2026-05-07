using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YourNxtHome
{
    public partial class BookingPopup : Form
    {
        public BookingPopup()
        {
            InitializeComponent();
            AnimateMessage();
        }

        private async void AnimateMessage()
        {
            string[] dots = { ".", "..", "..." };
            for (int i = 0; i < 6; i++)
            {
                labelStatus.Text = "⏳ Please wait" + dots[i % 3];
                await System.Threading.Tasks.Task.Delay(400);
            }
            labelStatus.Text = "📨 Request sent to flat owner!";
            labelInfo.Visible = true;
            btnClose.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
