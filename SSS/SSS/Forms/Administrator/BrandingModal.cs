using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;

namespace SSS_Windows_Forms.Forms.Administrator
{
    public partial class BrandingModal : Form
    {
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.BRANDINGTableAdapter _brandingTableAdapter = new BRANDINGTableAdapter();
        private byte[] _programIconByteArray;
        private byte[] _programImage;
        private string _splashColourCode;
        
        public BrandingModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog()
            {
                ShowHelp = true,
                Color = textBox1.ForeColor
            };

            if (colorDialog1.ShowDialog() == DialogResult.OK)
                _splashColourCode = colorDialog1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            openFileDialog1 = new OpenFileDialog
            {
                Filter = SSS_Library.Properties.Resources.IconFileTypesRegexOpenDialog,
                FilterIndex = 1,
                Multiselect = true
            };

            // Set filter options and filter index.
            
            // Call the ShowDialog method to show the dialog box.
            DialogResult result = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (result == DialogResult.OK)
            {
                _programIconByteArray = SSS_Library.DataServices.ByteImageConverter.ConvertImageToBytes(Image.FromFile(openFileDialog1.FileName));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            openFileDialog1 = new OpenFileDialog
            {
                Filter = SSS_Library.Properties.Resources.ImageFileTypesRegexOpenDialog,
                FilterIndex = 1,
                Multiselect = true
            };

            // Set filter options and filter index.

            // Call the ShowDialog method to show the dialog box.
            DialogResult result = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (result == DialogResult.OK)
            {
                _programImage = SSS_Library.DataServices.ByteImageConverter.ConvertImageToBytes(Image.FromFile(openFileDialog1.FileName));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string systemName = textBox1.Text;
            TimeSpan splashTime;
            TimeSpan.TryParse(textBox2.Text, out splashTime);
            bool isMetroDefualt = checkBox1.Checked;
            
            var branding = _brandingTableAdapter.GetData();
            if (branding.Count <= 0)
            {
                if (_programIconByteArray == null && _programImage == null && systemName == null && systemName.Equals("") && systemName.Equals(" ")
                    && _splashColourCode == null)
                {
                    
                    MessageBox.Show(SSS_Library.Properties.Resources.BrandingErrorMessage, SSS_Library.Properties.Resources.BrandingErrorMessage);
                }
                else if (_programIconByteArray == null || _programImage == null || systemName == null || systemName.Equals("") || systemName.Equals(" ")
                    || _splashColourCode == null || splashTime == null)
                {
                    var updateBranding = branding.First();

                    if (_programIconByteArray != null)
                        updateBranding.program_icon = _programIconByteArray;
                    if (_programImage != null)
                        updateBranding.system_logo = _programImage;
                    if (systemName != null && (!systemName.Equals("") || !systemName.Equals(" ")))
                        updateBranding.system_name = systemName;
                    if (_splashColourCode != null)
                        updateBranding.splash_colour = _splashColourCode;
                    if (splashTime != null)
                        updateBranding.splash_time = splashTime;

                    _brandingTableAdapter.Update(updateBranding);
                    MessageBox.Show(SSS_Library.Properties.Resources.BrandingUpdateSuccess, SSS_Library.Properties.Resources.BrandingUpdateSuccess);
                }
                else
                {
                    _brandingTableAdapter.Insert(_programIconByteArray, _programImage, systemName, _splashColourCode, splashTime, false, isMetroDefualt);
                    MessageBox.Show(SSS_Library.Properties.Resources.BrandingUpdateSuccess, SSS_Library.Properties.Resources.BrandingUpdateSuccess);
                }
            }
        }
    }
}
