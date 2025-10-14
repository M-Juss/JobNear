using JobNear.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_RegisterBusinessForm : UserControl
    {
        private JobPosterDashboardForm JP_parent_form;
        private String business_logo, business_name, business_industry, business_description, business_email_address,
                        business_contact, business_website, business_address, business_country, postal_code;
        
        private void clear_draft_button_Click(object sender, EventArgs e)
        {
            if (business_logo_picturebox.Image != null)
            {
                business_logo_picturebox.Image = null;
                business_logo_picturebox.Tag = null;
            }
            business_name_textbox.Clear();
            business_industry_combobox.SelectedIndex = -1;
            business_description_richbox.Clear();
            business_email_address_textbox.Clear();
            business_contact_textbox.Clear();
            business_website_textbox.Clear();
            business_address_textbox.Clear();
            postal_code_textbox.Clear();
        }
        private void business_logo_picturebox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog select_business_logo = new OpenFileDialog())
            {
                select_business_logo.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
                select_business_logo.Title = "Select an image";

                if (select_business_logo.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        business_logo_picturebox.Image = Image.FromFile(select_business_logo.FileName);
                        business_logo_picturebox.Tag = select_business_logo.FileName;
                        business_logo_picturebox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                    }
                }
            }
        }
        public JP_RegisterBusinessForm(JobPosterDashboardForm parent_form)
        {
            InitializeComponent();
            JP_parent_form = parent_form;
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            String email_pattern = @"^[a-zA-Z0-9_.]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,}$"; 

            business_name = business_name_textbox.Text.ToString();
            business_industry = business_industry_combobox.SelectedItem.ToString();
            business_description = business_description_richbox.Text.ToString();
            business_email_address = business_email_address_textbox.Text.ToString();           
            business_contact = business_contact_textbox.Text.ToString();
            business_website = business_website_textbox.Text.ToString();
            business_address = business_address_textbox.Text.ToString();
            business_country = country_textbox.Text.ToString();
            postal_code = postal_code_textbox.Text.ToString();

            if (Regex.IsMatch(business_email_address, email_pattern))
            {
                MessageBox.Show("Valid email address!");

                Console.WriteLine("Business Name: " + business_name + "\n" +
                "Business Industry: " + business_industry + "\n" +
                "Business Description: " + business_description + "\n" +
                "Business Email Address: " + business_email_address + "\n" +
                "Business Contact Number: " + business_contact + "\n" +
                "Business Website: " + business_website + "\n" +
                "Business Address: " + business_address + "\n" +
                "Country: " + business_country + "\n" +
                "Postal Code: " + postal_code + "\n" +
                "Business Logo: " + business_logo_picturebox.Tag);            
            }
            else
            {
                MessageBox.Show("Invalid email address");
            }         
        }
    }
}
