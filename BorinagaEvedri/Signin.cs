using Microsoft.Extensions.Logging;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BorinagaEvedri
{
    public partial class Signin : Form
    {
        List<Image> images = new List<Image>();
        string[] location = new string[25];

        private readonly ILogger<Signin> _logger;
        private string imagePath;
        private string label1FullText;
        private string label2FullText;
        private int label1Index = 0;
        private int label2Index = 0;
        private object lblName { get; set; }
        public Signin(ILogger<Signin> logger)
        {
            InitializeComponent();
            _logger = logger;
            
              // Set lblName to the provided username
            _logger.LogInformation("Signin form initialized.");

            location[0] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_1.jpg";
            location[1] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_2.jpg";
            location[2] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_4.jpg";
            location[3] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_5.jpg";
            location[4] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_6.jpg";
            location[5] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_7.jpg";
            location[6] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_8.jpg";
            location[7] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_9.jpg";
            location[8] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_10.jpg";
            location[9] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_11.jpg";
            location[10] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_12.jpg";
            location[11] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_13.jpg";
            location[12] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_14.jpg";
            location[13] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_15.jpg";
            location[14] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_16.jpg";
            location[15] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_17.jpg";
            location[16] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_18.jpg";
            location[17] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_19.jpg";
            location[18] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_20.jpg";
            location[19] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_21.jpg";
            location[20] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_22.jpg";
            location[21] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_23.jpg";
            location[22] = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_user_24.jpg";
            tounage();

        }
        private void tounage()
        {
            for (int i = 0; i < 23; i++)
            {
                Bitmap bitmap = new Bitmap(location[i]);
                images.Add(bitmap);
            }
            images.Add(Properties.Resources.textbox_user_24);
        }

        public void SetImagePath(string path)
        {
            imagePath = path;
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnHidePass.BringToFront();
                txtPassword.PasswordChar = '\0';

            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShowPass.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Bitmap bmpass = new Bitmap(@"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\animation\textbox_password.png");
            guna2CirclePictureBox1.Image = bmpass;
        }

        private void lblusername_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtUsername.Text.Length <= 15)
            {
                guna2CirclePictureBox1.Image = images[txtUsername.Text.Length - 1];
                guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (txtUsername.Text.Length <= 0)
                guna2CirclePictureBox1.Image = Properties.Resources.debut;
            else
                guna2CirclePictureBox1.Image = images[22];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //string filePath = @"C:\Users\ACT-STUDENT\Downloads\Book1(1).xlsx"; // Change this to your file path
            //_logger.LogInformation("User clicked Submit.");
            //Workbook book = new Workbook();
            //book.LoadFromFile(@"C:\Users\ACT-STUDENT\Downloads\Book1(1).xlsx");
            //Worksheet sheet = book.Worksheets[0];
            //int row = sheet.Rows.Length + 1;
            //DataTable dt = sheet.ExportDataTable(); // Convert sheet data to DataTable
            //bool log = false;
            //bool userFound = false;

            //foreach (DataRow row1 in dt.Rows)
            //{
            //    if (row1["Username"].ToString() == txtUsername.Text && row1["Password"].ToString() == txtPassword.Text)
            //    {
            //        userFound = true;
            //        int status = Convert.ToInt32(row1["Status"]);

            //        if (status == 1)
            //        {
            //            Form2 activeForm = new Form2(_logger);
                       
            //        }
            //        else
            //        {
            //            Inactive_Students inactiveForm = new Inactive_Students();
                        
            //        }

            //        this.Hide(); // Hide SignIn form after login
            //        break;
            //    }
            //}

            //if (!userFound)
            //{
            //    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //for (int i = 2; i <= row; i++)
            //{
            //    if (sheet.Range[i, 10].Value == txtUsername.Text && sheet.Range[i, 11].Value == txtPassword.Text)
            //    {
            //        //Success
            //        log = true;
            //        _logger.LogInformation($"User {txtUsername.Text} successfully logged in.");
            //        break;

            //    }
                
            //}

            //if (log)
            //{
            //    MessageBox.Show("Successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    _logger.LogInformation("Navigating to Dashboard.");


            //    Dashboard db = new Dashboard(_logger);
            //    this.Hide();
            //    db.Show();


            //}
            //else
            //{
            //    MessageBox.Show("Invalid Username & Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    _logger.LogWarning("Login failed for user: " + txtUsername.Text);
            //}


            //string username = txtUsername.Text;
            //string password = txtPassword.Text;

            //// Check if the user exists
            //var user = Form1.RegisteredUsers.FirstOrDefault(u => u.Username == username && u.Password == password);

            //if (user.Username != null)
            //{
            //    MessageBox.Show("Sign in successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    // Pass all user data to Form2
            //    Form2 f2 = new Form2();
            //    f2.AddAllUsers(); // Method to populate the DataGridView with all users
            //    f2.Show();
            //    this.Hide(); // Hide the Signin form
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password.", "Sign In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (lblusername.Visible)
            {
                lblusername.Visible = false;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblusername.Visible = true;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (lblpassword.Visible)
            {
                lblpassword.Visible = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblpassword.Visible = true;
            }
        }

        private void guna2SignUp_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(_logger);
            f1.Show();
            this.Hide();
        }

        private void guna2Login_Click(object sender, EventArgs e)
        {
            // Show loading indicator
            guna2Loading.Visible = true;
            timer2.Start();

            Task.Run(() =>
            {
                string filePath = @"C:\Users\Natalie Erika\Desktop\BorinagaEvedri\Book1(1).xlsx"; // File path to the Excel file
                _logger.LogInformation("User clicked Submit.");
                Workbook book = new Workbook();
                book.LoadFromFile(filePath);
                Worksheet sheet = book.Worksheets[0];
                DataTable dt = sheet.ExportDataTable(); // Convert sheet data to DataTable

                bool log = false;
                string fullName = "Unknown"; // Default value for full name
                string imagePath = ""; // Variable to hold the image path
                int status = 0; // Default status
                bool userFound = false; // Track if user was found
                string gender = "Unknown"; // Default gender

                // Check if the DataTable has the ImagePath column
                if (!dt.Columns.Contains("ImagePath"))
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show("The ImagePath column does not exist in the Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        guna2Loading.Visible = false; // Hide loading
                    }));
                    return;
                }

                // Check for matching credentials in DataTable
                foreach (DataRow row1 in dt.Rows)
                {
                    if (row1["Username"].ToString() == txtUsername.Text && row1["Password"].ToString() == txtPassword.Text)
                    {
                        userFound = true;
                        status = Convert.ToInt32(row1["Status"]);
                        fullName = row1["Name"].ToString(); // Get the full name
                        gender = row1["Gender"].ToString(); // Get the gender
                        imagePath = row1["ImagePath"].ToString(); // Retrieve the image path

                        // Handle user status
                        if (status == 1) // Check if active
                        {
                            log = true; // Successful login
                        }
                        break; // Exit loop once found
                    }
                }

                // Handle login result
                if (!userFound)
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _logger.LogWarning("Login failed for user: " + txtUsername.Text);
                        guna2Loading.Visible = false; // Hide loading
                    }));
                    return; // Exit if user not found
                }

                if (log)
                {
                    Invoke(new Action(() =>
                    {
                        guna2Loading.Visible = false; // Hide loading
                        MessageBox.Show($"Successful! Welcome, {fullName}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _logger.LogInformation("Navigating to Dashboard.");

                        // Pass the full name, gender, and image path to the Dashboard
                        Dashboard db = new Dashboard(_logger, fullName, gender, imagePath);
                        db.lblDate.Text = DateTime.Now.ToShortDateString(); // Set the current date
                        db.lblName.Text = fullName; // Set the full name

                        // Set the image in the dashboard
                        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                        {
                            db.guna2CirclePictureBox1.Image = Image.FromFile(imagePath); // Load image only if exists
                        }

                        this.Hide();
                        db.Show();
                        
                    }));
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show("Invalid Username & Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _logger.LogWarning("Login failed for user: " + txtUsername.Text);
                        guna2Loading.Visible = false; // Hide loading
                    }));
                }
            });


            //string username = txtUsername.Text;
            //string password = txtPassword.Text;

            //// Check if the user exists
            //var user = Form1.RegisteredUsers.FirstOrDefault(u => u.Username == username && u.Password == password);

            //if (user.Username != null)
            //{
            //    MessageBox.Show("Sign in successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    // Pass all user data to Form2
            //    Form2 f2 = new Form2();
            //    f2.AddAllUsers(); // Method to populate the DataGridView with all users
            //    f2.Show();
            //    this.Hide(); // Hide the Signin form
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password.", "Sign In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            // Hide the loading gif initially
            guna2Loading.Visible = false;
            label1FullText = label1.Text;
            label2FullText = label2.Text; // make sure you have label2 on your form

            label1.Text = "";
            label2.Text = "";

            label1Index = 0;
            label2Index = 0;

            timer1.Start();

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1Index < label1FullText.Length)
            {
                label1.Text += label1FullText[label1Index];
                label1Index++;
            }
            else if (label2Index < label2FullText.Length)
            {
                label2.Text += label2FullText[label2Index];
                label2Index++;
            }
            else
            {
                timer1.Stop(); // Stop the timer when both are done
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
