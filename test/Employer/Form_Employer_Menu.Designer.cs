namespace test.Employer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.Label();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.SideBar_Control = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_UserInfo = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.Side_Transition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar_Control)).BeginInit();
            this.SideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.SideBar_Control);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 51);
            this.panel1.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(72, 8);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(156, 37);
            this.Username.TabIndex = 2;
            this.Username.Text = "Employer";
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1031, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // SideBar_Control
            // 
            this.SideBar_Control.Image = ((System.Drawing.Image)(resources.GetObject("SideBar_Control.Image")));
            this.SideBar_Control.Location = new System.Drawing.Point(9, 4);
            this.SideBar_Control.Name = "SideBar_Control";
            this.SideBar_Control.Size = new System.Drawing.Size(40, 40);
            this.SideBar_Control.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SideBar_Control.TabIndex = 1;
            this.SideBar_Control.TabStop = false;
            this.SideBar_Control.Click += new System.EventHandler(this.SideBar_Control_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.SideBar.Controls.Add(this.panel2);
            this.SideBar.Controls.Add(this.panel7);
            this.SideBar.Controls.Add(this.panel8);
            this.SideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SideBar.Location = new System.Drawing.Point(0, 51);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(170, 659);
            this.SideBar.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.Btn_UserInfo);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 40, 3, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 47);
            this.panel2.TabIndex = 3;
            // 
            // Btn_UserInfo
            // 
            this.Btn_UserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.Btn_UserInfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UserInfo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_UserInfo.Image")));
            this.Btn_UserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UserInfo.Location = new System.Drawing.Point(-15, -18);
            this.Btn_UserInfo.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_UserInfo.Name = "Btn_UserInfo";
            this.Btn_UserInfo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Btn_UserInfo.Size = new System.Drawing.Size(203, 80);
            this.Btn_UserInfo.TabIndex = 2;
            this.Btn_UserInfo.Text = "          User Info";
            this.Btn_UserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UserInfo.UseVisualStyleBackColor = false;
            this.Btn_UserInfo.Click += new System.EventHandler(this.Btn_UserInfo_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button6);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(0, 167);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 40, 3, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(169, 47);
            this.panel7.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-15, -14);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(203, 76);
            this.button6.TabIndex = 2;
            this.button6.Text = "          Manage Job";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Btn_LogOut);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(0, 294);
            this.panel8.Margin = new System.Windows.Forms.Padding(0, 40, 3, 40);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(169, 47);
            this.panel8.TabIndex = 5;
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.Btn_LogOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.Btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LogOut.Image")));
            this.Btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_LogOut.Location = new System.Drawing.Point(-15, -14);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Btn_LogOut.Size = new System.Drawing.Size(203, 76);
            this.Btn_LogOut.TabIndex = 2;
            this.Btn_LogOut.Text = "          LogOut";
            this.Btn_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_LogOut.UseVisualStyleBackColor = false;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // Side_Transition
            // 
            this.Side_Transition.Interval = 10;
            this.Side_Transition.Tick += new System.EventHandler(this.Side_Transition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar_Control)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Username;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.PictureBox SideBar_Control;
        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_UserInfo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Timer Side_Transition;
    }
}