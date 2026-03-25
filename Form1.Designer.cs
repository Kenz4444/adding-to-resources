namespace Topic_10
{
    partial class FormAddResources
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
            this.imgMario = new System.Windows.Forms.PictureBox();
            this.imgimage3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgimage3)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMario
            // 
            this.imgMario.Image = global::Topic_10.Properties.Resources.mario1;
            this.imgMario.Location = new System.Drawing.Point(12, 3);
            this.imgMario.Name = "imgMario";
            this.imgMario.Size = new System.Drawing.Size(377, 229);
            this.imgMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMario.TabIndex = 0;
            this.imgMario.TabStop = false;
            this.imgMario.Click += new System.EventHandler(this.imgMario_Click);
            // 
            // imgimage3
            // 
            this.imgimage3.Image = global::Topic_10.Properties.Resources.image3;
            this.imgimage3.Location = new System.Drawing.Point(390, 244);
            this.imgimage3.Name = "imgimage3";
            this.imgimage3.Size = new System.Drawing.Size(271, 177);
            this.imgimage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgimage3.TabIndex = 1;
            this.imgimage3.TabStop = false;
            this.imgimage3.Visible = false;
            this.imgimage3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAddResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgimage3);
            this.Controls.Add(this.imgMario);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormAddResources";
            this.Text = "Resources";
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgimage3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMario;
        private System.Windows.Forms.PictureBox imgimage3;
    }
}

