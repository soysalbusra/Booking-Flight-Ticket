using ComponentFactory.Krypton.Toolkit;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp1.Context.Entities;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class CheckinForm :KryptonForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nRigtRect,
            int nBottomRect,
            int nTopRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public CheckinForm()
        {
            InitializeComponent();
            panel4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 40, 40));

        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            ChooseSeatForm chooseSeatForm = new ChooseSeatForm();
            KryptonButton button = sender as KryptonButton;

            chooseSeatForm.ShowDialog();
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "" || kryptonTextBox2.Text == "")
                MessageBox.Show("Please fill out the form completely.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var res = ReservationService.GetReservationByPnr(kryptonTextBox1.Text.Trim());
                var user = UserService.GetUserBySurname(kryptonTextBox2.Text.Trim());

                var f = FlightService.Read(res.FlightId);
                var diff = f.DepartureTime.Subtract(DateTime.Now).TotalHours;
                if (user != null && res.UserId == user.Id && res.isActive)
                {
                    if (!res.isCheckin)
                    {
                        

                        if (diff > 24 || diff < 1)
                        {
                            MessageBox.Show("You cannot check in your flight now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            ChooseSeatForm chooseSeatForm = new ChooseSeatForm();
                            chooseSeatForm.myReservation = res;
                            chooseSeatForm.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Checkin has been already done.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Check your information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainPage form = new MainPage();
            form.Show();
            this.Close();
                
        }
    }
}