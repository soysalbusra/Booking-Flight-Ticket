using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace WindowsFormsApp1
{
    public partial class MainPage : KryptonForm
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
     );
        public MainPage()
        {
            InitializeComponent();
            MainPagePanelColor.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, MainPagePanelColor.Width, MainPagePanelColor.Height, 20, 20));
            MainPagePictureBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, MainPagePictureBox.Width, MainPagePictureBox.Height, 20, 20));
            MainPagepanelNon.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, MainPagepanelNon.Width, MainPagepanelNon.Height, 30, 30));
        }

        private void timerMainPageDate_Tick(object sender, EventArgs e)
        {
            MainPageLabelDate.Text = DateTime.Now.ToShortDateString();
            MainPageLabelTime.Text = DateTime.Now.ToLongTimeString();
        }

        /*kayan resimler*/
        private int imageNum = 1;

        private void Slider()
        {
            if (imageNum == 6)
            {
                imageNum = 1;
            }
            MainPagePictureBox.ImageLocation = string.Format(@"Images\{0}.png", imageNum);
            imageNum++;
        }

        private void timerMainPageImages_Tick(object sender, EventArgs e)
        {
            Slider();
        }

        private void MainPageLabelTime_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void MainPageKryptonButtonTicket_Click(object sender, EventArgs e)
        {
            Flying form = new Flying();
            form.Show();
            this.Close();
        }

        private void MainPageKryptonButtonMyReservations_Click(object sender, EventArgs e)
        {
            ReservationForm form = new ReservationForm();
            form.Show();
            this.Close();
        }

        private void MainPageLogout_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Close();
        }

        private void checkinButton_Click(object sender, EventArgs e)
        {
            CheckinForm checkinForm=new CheckinForm();
            checkinForm.Show();
            this.Close();
        }

        private void MainPagepanelNon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonPaletteMainPage_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }
    }
}
