namespace Tivi6_Project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.AnimatorNS.Animation animation8 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UidTb = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(0);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation8;
            // 
            // pictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UidTb
            // 
            this.guna2Transition1.SetDecoration(this.UidTb, Guna.UI2.AnimatorNS.DecorationType.None);
            this.UidTb.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UidTb.ForeColor = System.Drawing.Color.Crimson;
            this.UidTb.Location = new System.Drawing.Point(357, 76);
            this.UidTb.Name = "UidTb";
            this.UidTb.Size = new System.Drawing.Size(207, 48);
            this.UidTb.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(570, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(570, 147);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // PassTb
            // 
            this.guna2Transition1.SetDecoration(this.PassTb, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PassTb.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassTb.ForeColor = System.Drawing.Color.Crimson;
            this.PassTb.Location = new System.Drawing.Point(357, 147);
            this.PassTb.Name = "PassTb";
            this.PassTb.PasswordChar = '*';
            this.PassTb.Size = new System.Drawing.Size(207, 48);
            this.PassTb.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(167)))), ((int)(((byte)(221)))));
            this.guna2Transition1.SetDecoration(this.button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(492, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sıfırla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(31)))), ((int)(((byte)(104)))));
            this.guna2Transition1.SetDecoration(this.button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(378, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Giriş";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(31)))), ((int)(((byte)(104)))));
            this.label2.Location = new System.Drawing.Point(596, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.UidTb);
            this.Controls.Add(this.pictureBox1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private PictureBox pictureBox1;
        private TextBox UidTb;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox PassTb;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}