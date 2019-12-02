namespace C-ChatBox{
    partial class LogForm{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(){
            this.logTab = new MetroFramework.Controls.MetroTabControl();
            this.signIn = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.loginLevel = new MetroFramework.Controls.MetroLabel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.passText = new MetroFramework.Controls.MetroTextBox();
            this.userText = new MetroFramework.Controls.MetroTextBox();
            this.regTab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.regPass = new MetroFramework.Controls.MetroTextBox();
            this.regEmail = new MetroFramework.Controls.MetroTextBox();
            this.regUserName = new MetroFramework.Controls.MetroTextBox();
            this.regFullName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.logTab.SuspendLayout();
            this.signIn.SuspendLayout();
            this.regTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.signIn);
            this.logTab.Controls.Add(this.regTab);
            this.logTab.CustomBackground = false;
            this.logTab.FontSize = MetroFramework.MetroTabControlSize.Medium;
            this.logTab.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            this.logTab.ItemSize = new System.Drawing.Size(57, 31);
            this.logTab.Location = new System.Drawing.Point(23, 63);
            this.logTab.Name = "logTab";
            this.logTab.SelectedIndex = 0;
            this.logTab.Size = new System.Drawing.Size(674, 379);
            this.logTab.Style = MetroFramework.MetroColorStyle.Red;
            this.logTab.StyleManager = null;
            this.logTab.TabIndex = 0;
            this.logTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logTab.Theme = MetroFramework.MetroThemeStyle.Light;
            this.logTab.UseStyleColors = false;
            // 
            // signIn
            // 
            this.signIn.Controls.Add(this.metroLabel8);
            this.signIn.Controls.Add(this.loginLevel);
            this.signIn.Controls.Add(this.metroLink2);
            this.signIn.Controls.Add(this.metroLink1);
            this.signIn.Controls.Add(this.metroLabel4);
            this.signIn.Controls.Add(this.metroButton1);
            this.signIn.Controls.Add(this.metroLabel2);
            this.signIn.Controls.Add(this.metroLabel1);
            this.signIn.Controls.Add(this.passText);
            this.signIn.Controls.Add(this.userText);
            this.signIn.CustomBackground = false;
            this.signIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signIn.HorizontalScrollbar = false;
            this.signIn.HorizontalScrollbarBarColor = true;
            this.signIn.HorizontalScrollbarHighlightOnWheel = false;
            this.signIn.HorizontalScrollbarSize = 10;
            this.signIn.Location = new System.Drawing.Point(4, 35);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(666, 340);
            this.signIn.Style = MetroFramework.MetroColorStyle.Red;
            this.signIn.StyleManager = null;
            this.signIn.TabIndex = 0;
            this.signIn.Text = "Sign In";
            this.signIn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.signIn.VerticalScrollbar = false;
            this.signIn.VerticalScrollbarBarColor = true;
            this.signIn.VerticalScrollbarHighlightOnWheel = false;
            this.signIn.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.CustomBackground = false;
            this.metroLabel8.CustomForeColor = false;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel8.Location = new System.Drawing.Point(273, 34);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(140, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel8.StyleManager = null;
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "You can Login Now.";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel8.UseStyleColors = false;
            this.metroLabel8.Visible = false;
            // 
            // loginLevel
            // 
            this.loginLevel.AutoSize = true;
            this.loginLevel.CustomBackground = false;
            this.loginLevel.CustomForeColor = false;
            this.loginLevel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.loginLevel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.loginLevel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.loginLevel.Location = new System.Drawing.Point(210, 172);
            this.loginLevel.Name = "loginLevel";
            this.loginLevel.Size = new System.Drawing.Size(246, 15);
            this.loginLevel.Style = MetroFramework.MetroColorStyle.Red;
            this.loginLevel.StyleManager = null;
            this.loginLevel.TabIndex = 14;
            this.loginLevel.Text = "Username or Password is Wrong. Try Again.";
            this.loginLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginLevel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginLevel.UseStyleColors = false;
            this.loginLevel.Visible = false;
            // 
            // metroLink2
            // 
            this.metroLink2.CustomBackground = false;
            this.metroLink2.CustomForeColor = false;
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroLink2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroLink2.Location = new System.Drawing.Point(340, 216);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(40, 23);
            this.metroLink2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLink2.StyleManager = null;
            this.metroLink2.TabIndex = 13;
            this.metroLink2.Text = "Cancel";
            this.metroLink2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink2.UseStyleColors = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.AutoSize = true;
            this.metroLink1.CustomBackground = false;
            this.metroLink1.CustomForeColor = false;
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Location = new System.Drawing.Point(336, 276);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(108, 23);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLink1.StyleManager = null;
            this.metroLink1.TabIndex = 12;
            this.metroLink1.Text = "Register Now";
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.CustomForeColor = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(221, 278);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "New in C-Chat Box? ";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSize = true;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(386, 209);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(89, 30);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Sign in";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.CustomForeColor = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(175, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Password :";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(175, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Username :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // passText
            // 
            this.passText.CustomBackground = false;
            this.passText.CustomForeColor = false;
            this.passText.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.passText.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.passText.Location = new System.Drawing.Point(256, 137);
            this.passText.Multiline = false;
            this.passText.Name = "passText";
            this.passText.SelectedText = "";
            this.passText.Size = new System.Drawing.Size(219, 23);
            this.passText.Style = MetroFramework.MetroColorStyle.Red;
            this.passText.StyleManager = null;
            this.passText.TabIndex = 2;
            this.passText.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passText.UseStyleColors = false;
            // 
            // userText
            // 
            this.userText.CustomBackground = false;
            this.userText.CustomForeColor = false;
            this.userText.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.userText.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.userText.Location = new System.Drawing.Point(256, 85);
            this.userText.Multiline = false;
            this.userText.Name = "userText";
            this.userText.SelectedText = "";
            this.userText.Size = new System.Drawing.Size(219, 23);
            this.userText.Style = MetroFramework.MetroColorStyle.Red;
            this.userText.StyleManager = null;
            this.userText.TabIndex = 1;
            this.userText.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userText.UseStyleColors = false;
            // 
            // regTab
            // 
            this.regTab.Controls.Add(this.metroLabel9);
            this.regTab.Controls.Add(this.metroLink3);
            this.regTab.Controls.Add(this.metroButton2);
            this.regTab.Controls.Add(this.regPass);
            this.regTab.Controls.Add(this.regEmail);
            this.regTab.Controls.Add(this.regUserName);
            this.regTab.Controls.Add(this.regFullName);
            this.regTab.Controls.Add(this.metroLabel7);
            this.regTab.Controls.Add(this.metroLabel6);
            this.regTab.Controls.Add(this.metroLabel5);
            this.regTab.Controls.Add(this.metroLabel11);
            this.regTab.CustomBackground = false;
            this.regTab.HorizontalScrollbar = false;
            this.regTab.HorizontalScrollbarBarColor = true;
            this.regTab.HorizontalScrollbarHighlightOnWheel = false;
            this.regTab.HorizontalScrollbarSize = 10;
            this.regTab.Location = new System.Drawing.Point(4, 35);
            this.regTab.Name = "regTab";
            this.regTab.Size = new System.Drawing.Size(666, 340);
            this.regTab.Style = MetroFramework.MetroColorStyle.Blue;
            this.regTab.StyleManager = null;
            this.regTab.TabIndex = 1;
            this.regTab.Text = "Register";
            this.regTab.Theme = MetroFramework.MetroThemeStyle.Light;
            this.regTab.VerticalScrollbar = false;
            this.regTab.VerticalScrollbarBarColor = true;
            this.regTab.VerticalScrollbarHighlightOnWheel = false;
            this.regTab.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = false;
            this.metroLabel9.CustomForeColor = false;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel9.Location = new System.Drawing.Point(161, 221);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(314, 15);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel9.StyleManager = null;
            this.metroLabel9.TabIndex = 28;
            this.metroLabel9.Text = "Some went Wrong. Try Again with different Username.";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel9.UseStyleColors = false;
            this.metroLabel9.Visible = false;
            // 
            // metroLink3
            // 
            this.metroLink3.CustomBackground = false;
            this.metroLink3.CustomForeColor = false;
            this.metroLink3.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroLink3.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroLink3.Location = new System.Drawing.Point(361, 255);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(40, 23);
            this.metroLink3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLink3.StyleManager = null;
            this.metroLink3.TabIndex = 27;
            this.metroLink3.Text = "Cancel";
            this.metroLink3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink3.UseStyleColors = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(407, 248);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(80, 30);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 26;
            this.metroButton2.Text = "Register";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // regPass
            // 
            this.regPass.CustomBackground = false;
            this.regPass.CustomForeColor = false;
            this.regPass.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.regPass.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.regPass.Location = new System.Drawing.Point(293, 180);
            this.regPass.Multiline = false;
            this.regPass.Name = "regPass";
            this.regPass.SelectedText = "";
            this.regPass.Size = new System.Drawing.Size(194, 23);
            this.regPass.Style = MetroFramework.MetroColorStyle.Blue;
            this.regPass.StyleManager = null;
            this.regPass.TabIndex = 25;
            this.regPass.Theme = MetroFramework.MetroThemeStyle.Light;
            this.regPass.UseStyleColors = false;
            // 
            // regEmail
            // 
            this.regEmail.CustomBackground = false;
            this.regEmail.CustomForeColor = false;
            this.regEmail.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.regEmail.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.regEmail.Location = new System.Drawing.Point(293, 142);
            this.regEmail.Multiline = false;
            this.regEmail.Name = "regEmail";
            this.regEmail.SelectedText = "";
            this.regEmail.Size = new System.Drawing.Size(194, 23);
            this.regEmail.Style = MetroFramework.MetroColorStyle.Blue;
            this.regEmail.StyleManager = null;
            this.regEmail.TabIndex = 24;
            this.regEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.regEmail.UseStyleColors = false;
            // 
            // regUserName
            // 
            this.regUserName.CustomBackground = false;
            this.regUserName.CustomForeColor = false;
            this.regUserName.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.regUserName.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.regUserName.Location = new System.Drawing.Point(293, 102);
            this.regUserName.Multiline = false;
            this.regUserName.Name = "regUserName";
            this.regUserName.SelectedText = "";
            this.regUserName.Size = new System.Drawing.Size(194, 23);
            this.regUserName.Style = MetroFramework.MetroColorStyle.Blue;
            this.regUserName.StyleManager = null;
            this.regUserName.TabIndex = 23;
            this.regUserName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.regUserName.UseStyleColors = false;
            // 
            // regFullName
            // 
            this.regFullName.CustomBackground = false;
            this.regFullName.CustomForeColor = false;
            this.regFullName.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.regFullName.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.regFullName.Location = new System.Drawing.Point(293, 63);
            this.regFullName.Multiline = false;
            this.regFullName.Name = "regFullName";
            this.regFullName.SelectedText = "";
            this.regFullName.Size = new System.Drawing.Size(194, 23);
            this.regFullName.Style = MetroFramework.MetroColorStyle.Blue;
            this.regFullName.StyleManager = null;
            this.regFullName.TabIndex = 22;
            this.regFullName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.regFullName.UseStyleColors = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = false;
            this.metroLabel7.CustomForeColor = false;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel7.Location = new System.Drawing.Point(149, 180);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.StyleManager = null;
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "Password:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel7.UseStyleColors = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.CustomForeColor = false;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(149, 63);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Full Name :";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = false;
            this.metroLabel5.CustomForeColor = false;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(149, 142);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Email :";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.CustomBackground = false;
            this.metroLabel11.CustomForeColor = false;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel11.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel11.Location = new System.Drawing.Point(149, 102);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(75, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel11.StyleManager = null;
            this.metroLabel11.TabIndex = 18;
            this.metroLabel11.Text = "Username :";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel11.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.CustomForeColor = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(281, 445);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(159, 15);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "© Shaheen Mohammad Foisal";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.logTab);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.ShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "C-ChatBox";
            this.logTab.ResumeLayout(false);
            this.signIn.ResumeLayout(false);
            this.signIn.PerformLayout();
            this.regTab.ResumeLayout(false);
            this.regTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl logTab;
        private MetroFramework.Controls.MetroTabPage signIn;
        private MetroFramework.Controls.MetroTabPage regTab;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox passText;
        private MetroFramework.Controls.MetroTextBox userText;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox regPass;
        private MetroFramework.Controls.MetroTextBox regEmail;
        private MetroFramework.Controls.MetroTextBox regUserName;
        private MetroFramework.Controls.MetroTextBox regFullName;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLabel loginLevel;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
    }
}
