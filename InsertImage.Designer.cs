
namespace KSharpEditor
{
    partial class frmInsertImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsertImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(-157, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1273, 2);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insert Image";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblClose.Location = new System.Drawing.Point(575, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 19);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(25, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 31);
            this.textBox1.TabIndex = 3;
            this.textBox1.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select from files";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(252, 82);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(112, 34);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Image URL";
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Location = new System.Drawing.Point(25, 163);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(573, 31);
            this.txtImageUrl.TabIndex = 7;
            this.txtImageUrl.TextChanged += new System.EventHandler(this.txtImageUrl_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(-325, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1273, 2);
            this.label5.TabIndex = 8;
            // 
            // btnInsertImage
            // 
            this.btnInsertImage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInsertImage.Enabled = false;
            this.btnInsertImage.Location = new System.Drawing.Point(450, 235);
            this.btnInsertImage.Name = "btnInsertImage";
            this.btnInsertImage.Size = new System.Drawing.Size(148, 34);
            this.btnInsertImage.TabIndex = 9;
            this.btnInsertImage.Text = "Insert Image";
            this.btnInsertImage.UseVisualStyleBackColor = false;
            this.btnInsertImage.Click += new System.EventHandler(this.btnInsertImage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "JPEG|*.jpg|Bitmap|*.bmp|png|*.png";
            // 
            // frmInsertImage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 281);
            this.Controls.Add(this.btnInsertImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImageUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertImage";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InsertImage";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsertImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}