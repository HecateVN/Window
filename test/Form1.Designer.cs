namespace test
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
            this.label1 = new System.Windows.Forms.Label();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.SideBar_Control = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.SubContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_Message = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_UserInfo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_HomePage = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Btn_LogOut = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.Sub_Con_Transition = new System.Windows.Forms.Timer(this.components);
            this.Side_Transition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar_Control)).BeginInit();
            this.SideBar.SuspendLayout();
            this.SubContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.SideBar_Control);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 51);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.nightControlBox1.Location = new System.Drawing.Point(1098, 8);
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
            this.SideBar_Control.Size = new System.Drawing.Size(47, 49);
            this.SideBar_Control.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SideBar_Control.TabIndex = 1;
            this.SideBar_Control.TabStop = false;
            this.SideBar_Control.Click += new System.EventHandler(this.SideBar_Control_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.Silver;
            this.SideBar.Controls.Add(this.panel2);
            this.SideBar.Controls.Add(this.panel3);
            this.SideBar.Controls.Add(this.panel7);
            this.SideBar.Controls.Add(this.panel9);
            this.SideBar.Controls.Add(this.SubContainer);
            this.SideBar.Controls.Add(this.panel8);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SideBar.Location = new System.Drawing.Point(0, 51);
            this.SideBar.Name = "SideBar";
            this.SideBar.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.SideBar.Size = new System.Drawing.Size(170, 645);
            this.SideBar.TabIndex = 1;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // SubContainer
            // 
            this.SubContainer.Controls.Add(this.panel4);
            this.SubContainer.Controls.Add(this.panel5);
            this.SubContainer.Controls.Add(this.panel6);
            this.SubContainer.Location = new System.Drawing.Point(0, 333);
            this.SubContainer.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.SubContainer.Name = "SubContainer";
            this.SubContainer.Size = new System.Drawing.Size(169, 47);
            this.SubContainer.TabIndex = 7;
            this.SubContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Btn_Message);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 47);
            this.panel4.TabIndex = 4;
            // 
            // Btn_Message
            // 
            this.Btn_Message.BackColor = System.Drawing.Color.White;
            this.Btn_Message.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Message.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Message.Image")));
            this.Btn_Message.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Message.Location = new System.Drawing.Point(-15, -16);
            this.Btn_Message.Name = "Btn_Message";
            this.Btn_Message.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Btn_Message.Size = new System.Drawing.Size(203, 79);
            this.Btn_Message.TabIndex = 2;
            this.Btn_Message.Text = "         Message";
            this.Btn_Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Message.UseVisualStyleBackColor = false;
            this.Btn_Message.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Location = new System.Drawing.Point(0, 47);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 47);
            this.panel5.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-15, -14);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(264, 76);
            this.button4.TabIndex = 2;
            this.button4.Text = "        Receive";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button5);
            this.panel6.Location = new System.Drawing.Point(0, 94);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 47);
            this.panel6.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-15, -14);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(264, 76);
            this.button5.TabIndex = 2;
            this.button5.Text = "        Sended";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_UserInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 47);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Btn_UserInfo
            // 
            this.Btn_UserInfo.BackColor = System.Drawing.Color.White;
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
            this.Btn_UserInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn_HomePage);
            this.panel3.Location = new System.Drawing.Point(0, 123);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 47);
            this.panel3.TabIndex = 4;
            // 
            // Btn_HomePage
            // 
            this.Btn_HomePage.BackColor = System.Drawing.Color.White;
            this.Btn_HomePage.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_HomePage.Image = ((System.Drawing.Image)(resources.GetObject("Btn_HomePage.Image")));
            this.Btn_HomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_HomePage.Location = new System.Drawing.Point(-15, -14);
            this.Btn_HomePage.Name = "Btn_HomePage";
            this.Btn_HomePage.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Btn_HomePage.Size = new System.Drawing.Size(203, 76);
            this.Btn_HomePage.TabIndex = 2;
            this.Btn_HomePage.Text = "          Home Page";
            this.Btn_HomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_HomePage.UseVisualStyleBackColor = false;
            this.Btn_HomePage.Click += new System.EventHandler(this.Btn_HomePage_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Btn_LogOut);
            this.panel8.Location = new System.Drawing.Point(0, 403);
            this.panel8.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(169, 47);
            this.panel8.TabIndex = 5;
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.BackColor = System.Drawing.Color.White;
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
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button6);
            this.panel7.Location = new System.Drawing.Point(0, 193);
            this.panel7.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(169, 47);
            this.panel7.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-15, -14);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(203, 76);
            this.button6.TabIndex = 2;
            this.button6.Text = "          LogOut";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button8);
            this.panel9.Location = new System.Drawing.Point(0, 263);
            this.panel9.Margin = new System.Windows.Forms.Padding(0, 3, 3, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(169, 47);
            this.panel9.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-15, -14);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(203, 76);
            this.button8.TabIndex = 2;
            this.button8.Text = "          LogOut";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // Sub_Con_Transition
            // 
            this.Sub_Con_Transition.Interval = 10;
            this.Sub_Con_Transition.Tick += new System.EventHandler(this.Sub_Con_Transition_Tick);
            // 
            // Side_Transition
            // 
            this.Side_Transition.Interval = 10;
            this.Side_Transition.Tick += new System.EventHandler(this.Side_Transition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1243, 696);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar_Control)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.SubContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox SideBar_Control;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Button Btn_UserInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_HomePage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_Message;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FlowLayoutPanel SubContainer;
        private System.Windows.Forms.Timer Sub_Con_Transition;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button Btn_LogOut;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer Side_Transition;
    }
}

