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
using WindowsFormsApp1.Context.Entities;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class Login : KryptonForm
    {
        public static string UserId = "-1";
        public string IdentificationNumber = "";
        public string Name = "";
        public string Surname = "";
        public string Email = "";
        public string Password = "";


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
        public Login()
        {
            InitializeComponent();
            LoginFormPanelColor.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, LoginFormPanelColor.Width, LoginFormPanelColor.Height, 20, 20));

        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }
        private void SignUpBackButton(object sender, EventArgs e)
        {
            LoginFormPanelGood.Visible = true;
            LoginFormPanelLogin.Visible = true;
            LoginFormPanelSignUp.Visible = false;
            backbutton.Visible = false;
            EmployeeCheckBox.Visible = true;
            UserCheckBox.Visible = true;
            signUpInfoPanel.Visible = false;
        }

        private void LoginFormKryptonButtonSignUp_Click(object sender, EventArgs e)
        {
            LoginFormPanelGood.Visible = false;
            LoginFormPanelLogin.Visible = false;
            LoginFormPanelSignUp.Visible = true;
            backbutton.Visible = true;
            EmployeeCheckBox.Visible = false;
            UserCheckBox.Visible = false;
            signUpInfoPanel.Visible = true;

        }
        private void LoginFormKryptonButtonLogin_Click(object sender, EventArgs e)
        {
            if (EmployeeCheckBox.Checked == true)
            {
                if (passwordInputLogin == "" || IdentificationInputLogin == "")
                {
                    MessageBox.Show("Check the informations", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    User user = UserService.Read("1");
                    if (user.IdentificationNumber == IdentificationInputLogin && user.Password == passwordInputLogin)
                    {
                        Staff staff= new Staff();
                        staff.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("The admin login is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           else if (UserCheckBox.Checked == true)
           {
                if (passwordInputLogin == "" || IdentificationInputLogin == "")
                {
                    MessageBox.Show("Check the informations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UserId = UserService.Login(IdentificationInputLogin, passwordInputLogin);
                    if (UserId != "-1")
                    {
                        MainPage form = new MainPage();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login is invalid. Please check your information.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select your role!");
            }
            
        }

        private void LoginFormKryptonButtonSignUp2_Click(object sender, EventArgs e)
        {
            
            if (IdentificationNumber == "" || Name == "" || Surname == "" || Email == "" || Password == "")
            {
                MessageBox.Show("Check your informations.");
            }
            else
            {
                try
                {

                    UserService.Insert(new User()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = Email,
                        Name = Name,
                        IdentificationNumber = IdentificationNumber,
                        isPersonel = EmployeeCheckBox.Checked,
                        Password = Password,
                        Surname = Surname
                    });


                    LoginFormPanelGood.Visible = true;
                    LoginFormPanelLogin.Visible = true;
                    LoginFormPanelSignUp.Visible = false;
                    backbutton.Visible = false;
                    EmployeeCheckBox.Visible = true;
                    UserCheckBox.Visible = true;
                    signUpInfoPanel.Visible = false;
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }

            }
        }


        private void IdentificationChanged(object sender, EventArgs e)
        {
            IdentificationNumber = IdentificationInput.Text;
        }

        private void NameChanged(object sender, EventArgs e)
        {
            Name = NameInput.Text;
        }

        private void SurnameInput_TextChanged(object sender, EventArgs e)
        {
            Surname=SurnameInput.Text;
        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {
            Email = EmailInput.Text;
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            Password=PasswordInput.Text;
        }

        private string IdentificationInputLogin = "";
        private string passwordInputLogin = "";

        private void identificationLoginInput_TextChanged(object sender, EventArgs e)
        {
            IdentificationInputLogin = identificationLoginInput.Text;

        }
        private void passwordInputforLogin_TextChanged(object sender, EventArgs e)
        {
            passwordInputLogin = passwordInputforLogin.Text;

        }

        private void identificationLoginInput_Enter(object sender, EventArgs e)
        {
            if (identificationLoginInput.Text == "ID Number")
            {
                identificationLoginInput.Text = "";
            }
        }

        private void identificationLoginInput_Leave(object sender, EventArgs e)
        {
            if (identificationLoginInput.Text == "")
            {
                identificationLoginInput.Text = "ID Number";
            }
        }

        private void passwordInputforLogin_Enter(object sender, EventArgs e)
        {
            if (passwordInputforLogin.Text == "Password")
            {
                passwordInputforLogin.Text = "";
            }
        }

        private void passwordInputforLogin_Leave(object sender, EventArgs e)
        {
            if (passwordInputforLogin.Text == "")
            {
                passwordInputforLogin.Text = "Password";
            }
        }

        private void IdentificationInput_Enter(object sender, EventArgs e)
        {
            if (IdentificationInput.Text == "ID Number")
            {
                IdentificationInput.Text = "";
            }
        }

        private void IdentificationInput_Leave(object sender, EventArgs e)
        {
            if (IdentificationInput.Text == "")
            {
                IdentificationInput.Text = "ID Number";
            }
        }

        private void NameInput_Enter(object sender, EventArgs e)
        {
            if (NameInput.Text == "Name")
            {
                NameInput.Text = "";
            }
        }

        private void NameInput_Leave(object sender, EventArgs e)
        {
            if (NameInput.Text == "")
            {
                NameInput.Text = "Name";
            }
        }

        private void SurnameInput_Enter(object sender, EventArgs e)
        {
            if (SurnameInput.Text == "Surname")
            {
                SurnameInput.Text = "";
            }
        }

        private void SurnameInput_Leave(object sender, EventArgs e)
        {
            if (SurnameInput.Text == "")
            {
                SurnameInput.Text = "Surname";
            }
        }

        private void EmailInput_Enter(object sender, EventArgs e)
        {
            if (EmailInput.Text == "E-Mail")
            {
                EmailInput.Text = "";
            }
        }

        private void EmailInput_Leave(object sender, EventArgs e)
        {
            if (EmailInput.Text == "")
            {
                EmailInput.Text = "E-Mail";
            }
        }

        private void PasswordInput_Enter(object sender, EventArgs e)
        {
            if (PasswordInput.Text == "Password")
            {
                PasswordInput.Text = "";
            }
        }

        private void PasswordInput_Leave(object sender, EventArgs e)
        {
            if (PasswordInput.Text == "")
            {
                PasswordInput.Text = "Password";
            }
        }
    }
}
