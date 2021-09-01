using KSharpEditor.Args;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KSharpEditor
{
    public partial class frmInsertImage : Form
    {
        public event EventHandler<ImageArgs> FileUrlAccepted;
        public frmInsertImage()
        {
            InitializeComponent();
        }

        private void txtImageUrl_TextChanged(object sender, EventArgs e)
        {
            if (txtImageUrl.Text.Length > 0)
            {
                btnInsertImage.Enabled = true;
            }
            else
            {
                btnInsertImage.Enabled = false;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                FileSelected(openFileDialog.FileName, true);
                this.Close();
            }
            
        }

        private void FileSelected(string fileName, bool isFile)
        {
            if (FileUrlAccepted != null)
            {
                ImageArgs args = new ImageArgs();
                args.File = fileName;
                args.base64 = isFile;
                args.Cancel = false;

                FileUrlAccepted(this, args);
            }
            
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            FileSelected(txtImageUrl.Text, false);
            this.Close();
        }
    }
}
