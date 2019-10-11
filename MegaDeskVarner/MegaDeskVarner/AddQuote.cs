using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskVarner
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            DateTime quoteDate = new DateTime();

            quoteDate = DateTime.Now;

            string strDate = quoteDate.ToString("MM/dd/yyyy");


        }

        private void closeAddQuote_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }


        private void firstName_Validating(object sender, CancelEventArgs e)
        {
            //testing this out
            if (firstName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a valid Name");
                firstName.Text = String.Empty;
                firstName.BackColor = Color.LightPink;
                firstName.Focus();
            }
            else
            {
                firstName.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void width_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(width.Text, out int WidthInput) == true)
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width from " + Desk.MINWIDTH + " to " + Desk.MAXWIDTH + " inches");
                    width.Text = String.Empty;
                    width.BackColor = Color.LightPink;
                    width.Focus();
                }
                else
                {
                    width.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            else if (int.TryParse(width.Text, out WidthInput) == false && width.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                width.Text = String.Empty;
                width.BackColor = Color.LightPink;
                width.Focus();
            }
            else
            {
                width.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please enter a number");
                e.Handled = true;
                depth.BackColor = Color.DarkOrange;
                depth.Focus();
            }
            else
            {
                depth.BackColor = System.Drawing.SystemColors.Window;
            }
        }
        private void depth_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(depth.Text, out int DepthInput) == true)
            {
                if (DepthInput < Desk.MINDEPTH || DepthInput > Desk.MAXDEPTH)
                {
                    MessageBox.Show("Please enter a depth from " + Desk.MINDEPTH + " to " + Desk.MAXDEPTH + " inches");
                    depth.Text = String.Empty;
                    depth.BackColor = Color.LightPink;
                    depth.Focus();
                }
                else
                {
                    depth.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            
            else if (int.TryParse(depth.Text, out DepthInput) == false && depth.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                depth.Text = String.Empty;
                depth.BackColor = Color.LightPink;
                depth.Focus();
            }
            else
            {
                depth.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void lastName_Validating(object sender, CancelEventArgs e)
        {
            //testing this out
            if (lastName.Text == String.Empty)
            {
                MessageBox.Show("Please enter a valid Name");
                lastName.Text = String.Empty;
                lastName.BackColor = Color.LightPink;
                lastName.Focus();
            }
            else
            {
                lastName.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void submitButton_Validating(object sender, CancelEventArgs e)
        {
            Close();
        }
    }
}

