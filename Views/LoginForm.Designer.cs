namespace Lab3Assignment.Views
{
    partial class LoginForm
    {
       
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       

       
        private void InitializeComponent()
        {
            rightPanel = new Panel();
            loginPanel = new FlowLayoutPanel();
            lblLoginTitle = new Label();
            lblLoginSubtitle = new Label();
            lblLoginEmail = new Label();
            txtLoginEmail = new TextBox();
            lblLoginPassword = new Label();
            txtLoginPassword = new TextBox();
            btnLogin = new Button();
            lnkSignup = new Label();
            signupPanel = new FlowLayoutPanel();
            lblSignupTitle = new Label();
            lblSignupSubtitle = new Label();
            lblSignRole = new Label();
            roleRow = new TableLayoutPanel();
            btnRoleVendor = new Button();
            btnRolePlanner = new Button();
            lblSignName = new Label();
            txtSignName = new TextBox();
            lblSignEmail = new Label();
            txtSignEmail = new TextBox();
            lblSignPhone = new Label();
            txtSignPhone = new TextBox();
            lblSignPassword = new Label();
            txtSignPassword = new TextBox();
            chkTerms = new CheckBox();
            btnSignup = new Button();
            lnkLogin = new Label();
            rightPanel.SuspendLayout();
            loginPanel.SuspendLayout();
            signupPanel.SuspendLayout();
            roleRow.SuspendLayout();
            SuspendLayout();
           
            // rightPanel
        
            rightPanel.AutoScroll = true;
            rightPanel.BackColor = Color.FromArgb(244, 246, 249);
            rightPanel.Controls.Add(loginPanel);
            rightPanel.Controls.Add(signupPanel);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(996, 764);
            rightPanel.TabIndex = 0;
            rightPanel.Resize += rightPanel_Resize;
            
            // loginPanel
            
            loginPanel.AutoSize = true;
            loginPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginPanel.BackColor = Color.White;
            loginPanel.Controls.Add(lblLoginTitle);
            loginPanel.Controls.Add(lblLoginSubtitle);
            loginPanel.Controls.Add(lblLoginEmail);
            loginPanel.Controls.Add(txtLoginEmail);
            loginPanel.Controls.Add(lblLoginPassword);
            loginPanel.Controls.Add(txtLoginPassword);
            loginPanel.Controls.Add(btnLogin);
            loginPanel.Controls.Add(lnkSignup);
            loginPanel.FlowDirection = FlowDirection.TopDown;
            loginPanel.Location = new Point(92, 30);
            loginPanel.MinimumSize = new Size(460, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Padding = new Padding(40, 32, 40, 32);
            loginPanel.Size = new Size(460, 424);
            loginPanel.TabIndex = 0;
            loginPanel.WrapContents = false;
            loginPanel.SizeChanged += Card_SizeChanged;
            loginPanel.Paint += Card_Paint;
           
            // lblLoginTitle
            
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLoginTitle.Location = new Point(40, 32);
            lblLoginTitle.Margin = new Padding(0, 0, 0, 2);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(263, 48);
            lblLoginTitle.TabIndex = 0;
            lblLoginTitle.Text = "Welcome back";
            
            // lblLoginSubtitle
            
            lblLoginSubtitle.AutoSize = true;
            lblLoginSubtitle.Font = new Font("Segoe UI", 10F);
            lblLoginSubtitle.ForeColor = Color.Gray;
            lblLoginSubtitle.Location = new Point(42, 82);
            lblLoginSubtitle.Margin = new Padding(2, 0, 0, 20);
            lblLoginSubtitle.Name = "lblLoginSubtitle";
            lblLoginSubtitle.Size = new Size(320, 28);
            lblLoginSubtitle.TabIndex = 1;
            lblLoginSubtitle.Text = "Sign in to your account to continue";
            
            // lblLoginEmail
            
            lblLoginEmail.AutoSize = true;
            lblLoginEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLoginEmail.ForeColor = Color.DimGray;
            lblLoginEmail.Location = new Point(40, 130);
            lblLoginEmail.Margin = new Padding(0, 0, 0, 4);
            lblLoginEmail.Name = "lblLoginEmail";
            lblLoginEmail.Size = new Size(128, 25);
            lblLoginEmail.TabIndex = 2;
            lblLoginEmail.Text = "Email address";
            
            // txtLoginEmail
          
            txtLoginEmail.BorderStyle = BorderStyle.FixedSingle;
            txtLoginEmail.Font = new Font("Segoe UI", 12F);
            txtLoginEmail.Location = new Point(40, 159);
            txtLoginEmail.Margin = new Padding(0, 0, 0, 14);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.PlaceholderText = "you@example.com";
            txtLoginEmail.Size = new Size(380, 39);
            txtLoginEmail.TabIndex = 3;
           
            // lblLoginPassword

            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLoginPassword.ForeColor = Color.DimGray;
            lblLoginPassword.Location = new Point(40, 212);
            lblLoginPassword.Margin = new Padding(0, 0, 0, 4);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(92, 25);
            lblLoginPassword.TabIndex = 4;
            lblLoginPassword.Text = "Password";
           
            // txtLoginPassword
            
            txtLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            txtLoginPassword.Font = new Font("Segoe UI", 12F);
            txtLoginPassword.Location = new Point(40, 241);
            txtLoginPassword.Margin = new Padding(0, 0, 0, 14);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PlaceholderText = "Enter your password";
            txtLoginPassword.Size = new Size(380, 39);
            txtLoginPassword.TabIndex = 5;
            txtLoginPassword.UseSystemPasswordChar = true;
           
            // btnLogin
          
            btnLogin.BackColor = Color.FromArgb(61, 76, 155);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 100, 180);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 304);
            btnLogin.Margin = new Padding(0, 10, 0, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(380, 46);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
          
            // lnkSignup
           
            lnkSignup.Cursor = Cursors.Hand;
            lnkSignup.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            lnkSignup.ForeColor = Color.FromArgb(61, 76, 155);
            lnkSignup.Location = new Point(40, 364);
            lnkSignup.Margin = new Padding(0, 14, 0, 0);
            lnkSignup.Name = "lnkSignup";
            lnkSignup.Size = new Size(380, 28);
            lnkSignup.TabIndex = 7;
            lnkSignup.Text = "Don't have an account? Sign up";
            lnkSignup.TextAlign = ContentAlignment.MiddleCenter;
            lnkSignup.Click += lnkSignup_Click;
          
            // signupPanel
            
            signupPanel.AutoSize = true;
            signupPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            signupPanel.BackColor = Color.White;
            signupPanel.Controls.Add(lblSignupTitle);
            signupPanel.Controls.Add(lblSignupSubtitle);
            signupPanel.Controls.Add(lblSignRole);
            signupPanel.Controls.Add(roleRow);
            signupPanel.Controls.Add(lblSignName);
            signupPanel.Controls.Add(txtSignName);
            signupPanel.Controls.Add(lblSignEmail);
            signupPanel.Controls.Add(txtSignEmail);
            signupPanel.Controls.Add(lblSignPhone);
            signupPanel.Controls.Add(txtSignPhone);
            signupPanel.Controls.Add(lblSignPassword);
            signupPanel.Controls.Add(txtSignPassword);
            signupPanel.Controls.Add(chkTerms);
            signupPanel.Controls.Add(btnSignup);
            signupPanel.Controls.Add(lnkLogin);
            signupPanel.FlowDirection = FlowDirection.TopDown;
            signupPanel.Location = new Point(92, 520);
            signupPanel.MinimumSize = new Size(460, 0);
            signupPanel.Name = "signupPanel";
            signupPanel.Padding = new Padding(40, 32, 40, 32);
            signupPanel.Size = new Size(460, 708);
            signupPanel.TabIndex = 1;
            signupPanel.Visible = false;
            signupPanel.WrapContents = false;
            signupPanel.SizeChanged += Card_SizeChanged;
            signupPanel.Paint += Card_Paint;
         
            // lblSignupTitle
         
            lblSignupTitle.AutoSize = true;
            lblSignupTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSignupTitle.Location = new Point(40, 32);
            lblSignupTitle.Margin = new Padding(0, 0, 0, 2);
            lblSignupTitle.Name = "lblSignupTitle";
            lblSignupTitle.Size = new Size(357, 48);
            lblSignupTitle.TabIndex = 0;
            lblSignupTitle.Text = "Create your account";
          
            // lblSignupSubtitle
           
            lblSignupSubtitle.AutoSize = true;
            lblSignupSubtitle.Font = new Font("Segoe UI", 10F);
            lblSignupSubtitle.ForeColor = Color.Gray;
            lblSignupSubtitle.Location = new Point(42, 82);
            lblSignupSubtitle.Margin = new Padding(2, 0, 0, 20);
            lblSignupSubtitle.Name = "lblSignupSubtitle";
            lblSignupSubtitle.Size = new Size(354, 28);
            lblSignupSubtitle.TabIndex = 1;
            lblSignupSubtitle.Text = "Join EventKonnect in less than a minute";
            
            // lblSignRole
            
            lblSignRole.AutoSize = true;
            lblSignRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSignRole.ForeColor = Color.DimGray;
            lblSignRole.Location = new Point(40, 130);
            lblSignRole.Margin = new Padding(0, 0, 0, 4);
            lblSignRole.Name = "lblSignRole";
            lblSignRole.Size = new Size(64, 25);
            lblSignRole.TabIndex = 2;
            lblSignRole.Text = "I am a";
            
            // roleRow
            
            roleRow.ColumnCount = 2;
            roleRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            roleRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            roleRow.Controls.Add(btnRoleVendor, 0, 0);
            roleRow.Controls.Add(btnRolePlanner, 1, 0);
            roleRow.Location = new Point(40, 159);
            roleRow.Margin = new Padding(0, 0, 0, 14);
            roleRow.Name = "roleRow";
            roleRow.RowCount = 1;
            roleRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            roleRow.Size = new Size(380, 42);
            roleRow.TabIndex = 3;
            
            // btnRoleVendor
            
            btnRoleVendor.BackColor = Color.FromArgb(61, 76, 155);
            btnRoleVendor.Cursor = Cursors.Hand;
            btnRoleVendor.Dock = DockStyle.Fill;
            btnRoleVendor.FlatAppearance.BorderColor = Color.FromArgb(61, 76, 155);
            btnRoleVendor.FlatStyle = FlatStyle.Flat;
            btnRoleVendor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRoleVendor.ForeColor = Color.White;
            btnRoleVendor.Location = new Point(0, 0);
            btnRoleVendor.Margin = new Padding(0, 0, 4, 0);
            btnRoleVendor.Name = "btnRoleVendor";
            btnRoleVendor.Size = new Size(186, 42);
            btnRoleVendor.TabIndex = 0;
            btnRoleVendor.Text = "Vendor";
            btnRoleVendor.UseVisualStyleBackColor = false;
            btnRoleVendor.Click += btnRoleVendor_Click;
            
            // btnRolePlanner
            
            btnRolePlanner.BackColor = Color.White;
            btnRolePlanner.Cursor = Cursors.Hand;
            btnRolePlanner.Dock = DockStyle.Fill;
            btnRolePlanner.FlatAppearance.BorderColor = Color.FromArgb(222, 226, 234);
            btnRolePlanner.FlatStyle = FlatStyle.Flat;
            btnRolePlanner.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRolePlanner.ForeColor = Color.DimGray;
            btnRolePlanner.Location = new Point(194, 0);
            btnRolePlanner.Margin = new Padding(4, 0, 0, 0);
            btnRolePlanner.Name = "btnRolePlanner";
            btnRolePlanner.Size = new Size(186, 42);
            btnRolePlanner.TabIndex = 1;
            btnRolePlanner.Text = "Event Planner";
            btnRolePlanner.UseVisualStyleBackColor = false;
            btnRolePlanner.Click += btnRolePlanner_Click;
            
            // lblSignName
            
            lblSignName.AutoSize = true;
            lblSignName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSignName.ForeColor = Color.DimGray;
            lblSignName.Location = new Point(40, 215);
            lblSignName.Margin = new Padding(0, 0, 0, 4);
            lblSignName.Name = "lblSignName";
            lblSignName.Size = new Size(94, 25);
            lblSignName.TabIndex = 4;
            lblSignName.Text = "Full name";
            
            // txtSignName
           
            txtSignName.BorderStyle = BorderStyle.FixedSingle;
            txtSignName.Font = new Font("Segoe UI", 12F);
            txtSignName.Location = new Point(40, 244);
            txtSignName.Margin = new Padding(0, 0, 0, 14);
            txtSignName.Name = "txtSignName";
            txtSignName.PlaceholderText = "e.g. Kundwa Divine";
            txtSignName.Size = new Size(380, 39);
            txtSignName.TabIndex = 5;
             
            // lblSignEmail
            
            lblSignEmail.AutoSize = true;
            lblSignEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSignEmail.ForeColor = Color.DimGray;
            lblSignEmail.Location = new Point(40, 297);
            lblSignEmail.Margin = new Padding(0, 0, 0, 4);
            lblSignEmail.Name = "lblSignEmail";
            lblSignEmail.Size = new Size(128, 25);
            lblSignEmail.TabIndex = 6;
            lblSignEmail.Text = "Email address";
            
            // txtSignEmail
            
            txtSignEmail.BorderStyle = BorderStyle.FixedSingle;
            txtSignEmail.Font = new Font("Segoe UI", 12F);
            txtSignEmail.Location = new Point(40, 326);
            txtSignEmail.Margin = new Padding(0, 0, 0, 14);
            txtSignEmail.Name = "txtSignEmail";
            txtSignEmail.PlaceholderText = "you@example.com";
            txtSignEmail.Size = new Size(380, 39);
            txtSignEmail.TabIndex = 7;
            
            // lblSignPhone
            
            lblSignPhone.AutoSize = true;
            lblSignPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSignPhone.ForeColor = Color.DimGray;
            lblSignPhone.Location = new Point(40, 379);
            lblSignPhone.Margin = new Padding(0, 0, 0, 4);
            lblSignPhone.Name = "lblSignPhone";
            lblSignPhone.Size = new Size(137, 25);
            lblSignPhone.TabIndex = 8;
            lblSignPhone.Text = "Phone number";
            
            // txtSignPhone
            
            txtSignPhone.BorderStyle = BorderStyle.FixedSingle;
            txtSignPhone.Font = new Font("Segoe UI", 12F);
            txtSignPhone.Location = new Point(40, 408);
            txtSignPhone.Margin = new Padding(0, 0, 0, 14);
            txtSignPhone.Name = "txtSignPhone";
            txtSignPhone.PlaceholderText = "e.g. 0788 123 456";
            txtSignPhone.Size = new Size(380, 39);
            txtSignPhone.TabIndex = 9;
            
            // lblSignPassword
            
            lblSignPassword.AutoSize = true;
            lblSignPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSignPassword.ForeColor = Color.DimGray;
            lblSignPassword.Location = new Point(40, 461);
            lblSignPassword.Margin = new Padding(0, 0, 0, 4);
            lblSignPassword.Name = "lblSignPassword";
            lblSignPassword.Size = new Size(92, 25);
            lblSignPassword.TabIndex = 10;
            lblSignPassword.Text = "Password";
            
            // txtSignPassword
            
            txtSignPassword.BorderStyle = BorderStyle.FixedSingle;
            txtSignPassword.Font = new Font("Segoe UI", 12F);
            txtSignPassword.Location = new Point(40, 490);
            txtSignPassword.Margin = new Padding(0, 0, 0, 14);
            txtSignPassword.Name = "txtSignPassword";
            txtSignPassword.PlaceholderText = "Create a password";
            txtSignPassword.Size = new Size(380, 39);
            txtSignPassword.TabIndex = 11;
            txtSignPassword.UseSystemPasswordChar = true;
             
            // chkTerms
             
            chkTerms.AutoSize = true;
            chkTerms.Font = new Font("Segoe UI", 9F);
            chkTerms.Location = new Point(40, 543);
            chkTerms.Margin = new Padding(0, 0, 0, 6);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(321, 29);
            chkTerms.TabIndex = 12;
            chkTerms.Text = "I agree to the Terms and Conditions";
            chkTerms.UseVisualStyleBackColor = true;
             
            // btnSignup
            
            btnSignup.BackColor = Color.FromArgb(61, 76, 155);
            btnSignup.Cursor = Cursors.Hand;
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 100, 180);
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(40, 588);
            btnSignup.Margin = new Padding(0, 10, 0, 0);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(380, 46);
            btnSignup.TabIndex = 13;
            btnSignup.Text = "Create Account";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            
            // lnkLogin
           
            lnkLogin.Cursor = Cursors.Hand;
            lnkLogin.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            lnkLogin.ForeColor = Color.FromArgb(61, 76, 155);
            lnkLogin.Location = new Point(40, 648);
            lnkLogin.Margin = new Padding(0, 14, 0, 0);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(380, 28);
            lnkLogin.TabIndex = 14;
            lnkLogin.Text = "Already have an account? Login";
            lnkLogin.TextAlign = ContentAlignment.MiddleCenter;
            lnkLogin.Click += lnkLogin_Click;
            
            // LoginForm
            // 
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(996, 764);
            Controls.Add(rightPanel);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(560, 600);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EventKonnect";
            FormClosed += LoginForm_FormClosed;
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            signupPanel.ResumeLayout(false);
            signupPanel.PerformLayout();
            roleRow.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.FlowLayoutPanel loginPanel;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblLoginSubtitle;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lnkSignup;
        private System.Windows.Forms.FlowLayoutPanel signupPanel;
        private System.Windows.Forms.Label lblSignupTitle;
        private System.Windows.Forms.Label lblSignupSubtitle;
        private System.Windows.Forms.Label lblSignRole;
        private System.Windows.Forms.TableLayoutPanel roleRow;
        private System.Windows.Forms.Button btnRoleVendor;
        private System.Windows.Forms.Button btnRolePlanner;
        private System.Windows.Forms.Label lblSignName;
        private System.Windows.Forms.TextBox txtSignName;
        private System.Windows.Forms.Label lblSignEmail;
        private System.Windows.Forms.TextBox txtSignEmail;
        private System.Windows.Forms.Label lblSignPhone;
        private System.Windows.Forms.TextBox txtSignPhone;
        private System.Windows.Forms.Label lblSignPassword;
        private System.Windows.Forms.TextBox txtSignPassword;
        private System.Windows.Forms.CheckBox chkTerms;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label lnkLogin;
    }
}
