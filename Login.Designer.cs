using System.Drawing;

namespace KeyAuth
{
    // Token: 0x02000002 RID: 2
    public partial class Login : global::System.Windows.Forms.Form
    {
        // Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002194 File Offset: 0x00000394
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation2 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.headerpanel = new Siticone.UI.WinForms.SiticoneCustomGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.loginpanel1 = new Siticone.UI.WinForms.SiticoneCustomGradientPanel();
            this.siticoneRoundedGradientButton4 = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.siticoneVSeparator4 = new Siticone.Desktop.UI.WinForms.SiticoneVSeparator();
            this.siticoneRoundedGradientButton3 = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton2 = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton1 = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.siticoneCirclePictureBox1 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.loginpanel2 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.autologin = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.rememberme = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneCirclePictureBox2 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneLabel4 = new Siticone.UI.WinForms.SiticoneLabel();
            this.loginstatus = new System.Windows.Forms.Label();
            this.username = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.password = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.LoginBtn = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.siticoneGradientPanel3 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.siticoneLabel5 = new Siticone.UI.WinForms.SiticoneLabel();
            this.registerstatus = new System.Windows.Forms.Label();
            this.RgstrBtn = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.registerkey = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneCirclePictureBox3 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneLabel6 = new Siticone.UI.WinForms.SiticoneLabel();
            this.registerusername = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.registerpassword = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.siticoneGradientPanel4 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.siticoneLabel7 = new Siticone.UI.WinForms.SiticoneLabel();
            this.UpgradeBtn = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.upgradestatus = new System.Windows.Forms.Label();
            this.upgradekey = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneCirclePictureBox4 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneLabel8 = new Siticone.UI.WinForms.SiticoneLabel();
            this.upgradeusername = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.siticoneGradientPanel5 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.siticoneLabel9 = new Siticone.UI.WinForms.SiticoneLabel();
            this.keyrememberme = new Siticone.UI.WinForms.SiticoneCustomCheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.keystatus = new System.Windows.Forms.Label();
            this.siticoneCirclePictureBox5 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.siticoneLabel10 = new Siticone.UI.WinForms.SiticoneLabel();
            this.KeyBtn = new Siticone.UI.WinForms.SiticoneRoundedGradientButton();
            this.keylogin = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticoneAnimateWindow1 = new Siticone.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.siticoneToolTip1 = new Siticone.UI.WinForms.SiticoneToolTip();
            this.siticoneToolTip2 = new Siticone.UI.WinForms.SiticoneToolTip();
            this.siticoneToolTip3 = new Siticone.UI.WinForms.SiticoneToolTip();
            this.siticoneToolTip4 = new Siticone.UI.WinForms.SiticoneToolTip();
            this.siticoneToolTip5 = new Siticone.UI.WinForms.SiticoneToolTip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.loginpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.siticoneGradientPanel1.SuspendLayout();
            this.siticoneTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.loginpanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.siticoneGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox3)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.siticoneGradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox4)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.siticoneGradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.headerpanel;
            // 
            // headerpanel
            // 
            this.headerpanel.Controls.Add(this.label2);
            this.headerpanel.Controls.Add(this.siticonePictureBox1);
            this.headerpanel.Controls.Add(this.siticoneControlBox1);
            this.headerpanel.Controls.Add(this.siticoneControlBox2);
            this.headerpanel.CustomBorderColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.headerpanel, Siticone.UI.AnimatorNS.DecorationType.None);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.headerpanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.headerpanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.headerpanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.ShadowDecoration.Parent = this.headerpanel;
            this.headerpanel.Size = new System.Drawing.Size(678, 33);
            this.headerpanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(37, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "TOLA PLUS LOADER BETA - LOGIN";
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticonePictureBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticonePictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(32, 33);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 43;
            this.siticonePictureBox1.TabStop = false;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.BorderRadius = 2;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(633, -4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 40);
            this.siticoneControlBox1.TabIndex = 1;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.BorderRadius = 2;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(589, -4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 40);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 1F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // loginpanel1
            // 
            this.loginpanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.loginpanel1.Controls.Add(this.siticoneRoundedGradientButton4);
            this.loginpanel1.Controls.Add(this.siticoneVSeparator4);
            this.loginpanel1.Controls.Add(this.siticoneRoundedGradientButton3);
            this.loginpanel1.Controls.Add(this.siticoneRoundedGradientButton2);
            this.loginpanel1.Controls.Add(this.siticoneRoundedGradientButton1);
            this.loginpanel1.Controls.Add(this.siticoneCirclePictureBox1);
            this.siticoneTransition1.SetDecoration(this.loginpanel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.loginpanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginpanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.loginpanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.loginpanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(97)))), ((int)(((byte)(1)))));
            this.loginpanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.loginpanel1.Location = new System.Drawing.Point(0, 33);
            this.loginpanel1.Name = "loginpanel1";
            this.loginpanel1.ShadowDecoration.Parent = this.loginpanel1;
            this.loginpanel1.Size = new System.Drawing.Size(261, 375);
            this.loginpanel1.TabIndex = 2;
            // 
            // siticoneRoundedGradientButton4
            // 
            this.siticoneRoundedGradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedGradientButton4.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneRoundedGradientButton4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.siticoneRoundedGradientButton4.BorderThickness = 1;
            this.siticoneRoundedGradientButton4.CheckedState.Parent = this.siticoneRoundedGradientButton4;
            this.siticoneRoundedGradientButton4.CustomImages.Parent = this.siticoneRoundedGradientButton4;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedGradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.siticoneRoundedGradientButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.siticoneRoundedGradientButton4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneRoundedGradientButton4.ForeColor = System.Drawing.SystemColors.Control;
            this.siticoneRoundedGradientButton4.HoveredState.Parent = this.siticoneRoundedGradientButton4;
            this.siticoneRoundedGradientButton4.Image = global::Loader.Properties.Resources.shopping_48;
            this.siticoneRoundedGradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneRoundedGradientButton4.ImageSize = new System.Drawing.Size(24, 24);
            this.siticoneRoundedGradientButton4.Location = new System.Drawing.Point(39, 307);
            this.siticoneRoundedGradientButton4.Name = "siticoneRoundedGradientButton4";
            this.siticoneRoundedGradientButton4.PressedDepth = 38;
            this.siticoneRoundedGradientButton4.ShadowDecoration.Parent = this.siticoneRoundedGradientButton4;
            this.siticoneRoundedGradientButton4.Size = new System.Drawing.Size(183, 32);
            this.siticoneRoundedGradientButton4.TabIndex = 65;
            this.siticoneRoundedGradientButton4.Text = "Buy a subscription !";
            this.siticoneRoundedGradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneRoundedGradientButton4.Click += new System.EventHandler(this.siticoneRoundedGradientButton4_Click);
            // 
            // siticoneVSeparator4
            // 
            this.siticoneVSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneVSeparator4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneVSeparator4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneVSeparator4.Location = new System.Drawing.Point(255, 2);
            this.siticoneVSeparator4.Name = "siticoneVSeparator4";
            this.siticoneVSeparator4.Size = new System.Drawing.Size(10, 371);
            this.siticoneVSeparator4.TabIndex = 64;
            // 
            // siticoneRoundedGradientButton3
            // 
            this.siticoneRoundedGradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedGradientButton3.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneRoundedGradientButton3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.siticoneRoundedGradientButton3.BorderThickness = 1;
            this.siticoneRoundedGradientButton3.CheckedState.Parent = this.siticoneRoundedGradientButton3;
            this.siticoneRoundedGradientButton3.CustomImages.Parent = this.siticoneRoundedGradientButton3;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedGradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.siticoneRoundedGradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.siticoneRoundedGradientButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneRoundedGradientButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.siticoneRoundedGradientButton3.HoveredState.Parent = this.siticoneRoundedGradientButton3;
            this.siticoneRoundedGradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedGradientButton3.Image")));
            this.siticoneRoundedGradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneRoundedGradientButton3.ImageSize = new System.Drawing.Size(24, 24);
            this.siticoneRoundedGradientButton3.Location = new System.Drawing.Point(39, 250);
            this.siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
            this.siticoneRoundedGradientButton3.PressedDepth = 38;
            this.siticoneRoundedGradientButton3.ShadowDecoration.Parent = this.siticoneRoundedGradientButton3;
            this.siticoneRoundedGradientButton3.Size = new System.Drawing.Size(183, 32);
            this.siticoneRoundedGradientButton3.TabIndex = 48;
            this.siticoneRoundedGradientButton3.Text = "Upgrade subscription";
            this.siticoneRoundedGradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneRoundedGradientButton3.Click += new System.EventHandler(this.siticoneRoundedGradientButton3_Click);
            // 
            // siticoneRoundedGradientButton2
            // 
            this.siticoneRoundedGradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedGradientButton2.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneRoundedGradientButton2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.siticoneRoundedGradientButton2.BorderThickness = 1;
            this.siticoneRoundedGradientButton2.CheckedState.Parent = this.siticoneRoundedGradientButton2;
            this.siticoneRoundedGradientButton2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedGradientButton2.CustomImages.Parent = this.siticoneRoundedGradientButton2;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedGradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.siticoneRoundedGradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.siticoneRoundedGradientButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneRoundedGradientButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.siticoneRoundedGradientButton2.HoveredState.Parent = this.siticoneRoundedGradientButton2;
            this.siticoneRoundedGradientButton2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedGradientButton2.Image")));
            this.siticoneRoundedGradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneRoundedGradientButton2.ImageSize = new System.Drawing.Size(22, 22);
            this.siticoneRoundedGradientButton2.Location = new System.Drawing.Point(38, 364);
            this.siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
            this.siticoneRoundedGradientButton2.ShadowDecoration.Parent = this.siticoneRoundedGradientButton2;
            this.siticoneRoundedGradientButton2.Size = new System.Drawing.Size(184, 32);
            this.siticoneRoundedGradientButton2.TabIndex = 48;
            this.siticoneRoundedGradientButton2.Text = "Key Login";
            this.siticoneRoundedGradientButton2.Visible = false;
            this.siticoneRoundedGradientButton2.Click += new System.EventHandler(this.siticoneRoundedGradientButton2_Click);
            // 
            // siticoneRoundedGradientButton1
            // 
            this.siticoneRoundedGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedGradientButton1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneRoundedGradientButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.siticoneRoundedGradientButton1.BorderThickness = 1;
            this.siticoneRoundedGradientButton1.CheckedState.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.CustomImages.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedGradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.siticoneRoundedGradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.siticoneRoundedGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneRoundedGradientButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.siticoneRoundedGradientButton1.HoveredState.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedGradientButton1.Image")));
            this.siticoneRoundedGradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneRoundedGradientButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.siticoneRoundedGradientButton1.Location = new System.Drawing.Point(38, 193);
            this.siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
            this.siticoneRoundedGradientButton1.PressedDepth = 37;
            this.siticoneRoundedGradientButton1.ShadowDecoration.Parent = this.siticoneRoundedGradientButton1;
            this.siticoneRoundedGradientButton1.Size = new System.Drawing.Size(184, 32);
            this.siticoneRoundedGradientButton1.TabIndex = 48;
            this.siticoneRoundedGradientButton1.Text = "Register";
            this.siticoneRoundedGradientButton1.Click += new System.EventHandler(this.siticoneRoundedGradientButton1_Click);
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCirclePictureBox1.BackgroundImage = global::Loader.Properties.Resources.logo;
            this.siticoneCirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.siticoneTransition1.SetDecoration(this.siticoneCirclePictureBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(41, 0);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(179, 183);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox1.TabIndex = 0;
            this.siticoneCirclePictureBox1.TabStop = false;
            this.siticoneCirclePictureBox1.Click += new System.EventHandler(this.siticoneCirclePictureBox1_Click);
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneGradientPanel1.Controls.Add(this.siticoneTabControl1);
            this.siticoneTransition1.SetDecoration(this.siticoneGradientPanel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(261, 33);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(417, 375);
            this.siticoneGradientPanel1.TabIndex = 48;
            // 
            // siticoneTabControl1
            // 
            this.siticoneTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.siticoneTabControl1.Controls.Add(this.tabPage1);
            this.siticoneTabControl1.Controls.Add(this.tabPage2);
            this.siticoneTabControl1.Controls.Add(this.tabPage3);
            this.siticoneTabControl1.Controls.Add(this.tabPage4);
            this.siticoneTransition1.SetDecoration(this.siticoneTabControl1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(417, 375);
            this.siticoneTabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.siticoneTabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.siticoneTabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.siticoneTabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.TabIndex = 0;
            this.siticoneTabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.siticoneTabControl1.TabMenuVisible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage1.Controls.Add(this.loginpanel2);
            this.siticoneTransition1.SetDecoration(this.tabPage1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(5, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(408, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "loginPage1";
            // 
            // loginpanel2
            // 
            this.loginpanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.loginpanel2.Controls.Add(this.autologin);
            this.loginpanel2.Controls.Add(this.rememberme);
            this.loginpanel2.Controls.Add(this.label4);
            this.loginpanel2.Controls.Add(this.label3);
            this.loginpanel2.Controls.Add(this.siticoneLabel3);
            this.loginpanel2.Controls.Add(this.siticoneCirclePictureBox2);
            this.loginpanel2.Controls.Add(this.siticoneLabel4);
            this.loginpanel2.Controls.Add(this.loginstatus);
            this.loginpanel2.Controls.Add(this.username);
            this.loginpanel2.Controls.Add(this.password);
            this.loginpanel2.Controls.Add(this.LoginBtn);
            this.siticoneTransition1.SetDecoration(this.loginpanel2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.loginpanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpanel2.Location = new System.Drawing.Point(3, 3);
            this.loginpanel2.Name = "loginpanel2";
            this.loginpanel2.ShadowDecoration.Parent = this.loginpanel2;
            this.loginpanel2.Size = new System.Drawing.Size(402, 361);
            this.loginpanel2.TabIndex = 50;
            // 
            // autologin
            // 
            this.autologin.Animated = true;
            this.autologin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.autologin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.autologin.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.autologin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.autologin.CheckedState.Parent = this.autologin;
            this.siticoneTransition1.SetDecoration(this.autologin, Siticone.UI.AnimatorNS.DecorationType.None);
            this.autologin.Location = new System.Drawing.Point(242, 220);
            this.autologin.Name = "autologin";
            this.autologin.ShadowDecoration.Parent = this.autologin;
            this.autologin.Size = new System.Drawing.Size(35, 20);
            this.autologin.TabIndex = 78;
            this.autologin.UncheckedState.BorderColor = System.Drawing.SystemColors.Control;
            this.autologin.UncheckedState.BorderThickness = 1;
            this.autologin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.autologin.UncheckedState.InnerBorderColor = System.Drawing.SystemColors.Control;
            this.autologin.UncheckedState.InnerColor = System.Drawing.SystemColors.Control;
            this.autologin.UncheckedState.Parent = this.autologin;
            // 
            // rememberme
            // 
            this.rememberme.Animated = true;
            this.rememberme.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.rememberme.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.rememberme.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.rememberme.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rememberme.CheckedState.Parent = this.rememberme;
            this.siticoneTransition1.SetDecoration(this.rememberme, Siticone.UI.AnimatorNS.DecorationType.None);
            this.rememberme.Location = new System.Drawing.Point(242, 183);
            this.rememberme.Name = "rememberme";
            this.rememberme.ShadowDecoration.Parent = this.rememberme;
            this.rememberme.Size = new System.Drawing.Size(35, 20);
            this.rememberme.TabIndex = 77;
            this.rememberme.UncheckedState.BorderColor = System.Drawing.SystemColors.Control;
            this.rememberme.UncheckedState.BorderThickness = 1;
            this.rememberme.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.rememberme.UncheckedState.InnerBorderColor = System.Drawing.SystemColors.Control;
            this.rememberme.UncheckedState.InnerColor = System.Drawing.SystemColors.Control;
            this.rememberme.UncheckedState.Parent = this.rememberme;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.label4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(153, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Auto login";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.label3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(125, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Remember me";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.AutoSize = false;
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.siticoneLabel3.Location = new System.Drawing.Point(340, 335);
            this.siticoneLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(216, 29);
            this.siticoneLabel3.TabIndex = 66;
            this.siticoneLabel3.Text = "Current Session Validation Status: \r\n";
            this.siticoneLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneLabel3.Visible = false;
            // 
            // siticoneCirclePictureBox2
            // 
            this.siticoneCirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneCirclePictureBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox2.Image")));
            this.siticoneCirclePictureBox2.Location = new System.Drawing.Point(142, 3);
            this.siticoneCirclePictureBox2.Name = "siticoneCirclePictureBox2";
            this.siticoneCirclePictureBox2.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox2.ShadowDecoration.Parent = this.siticoneCirclePictureBox2;
            this.siticoneCirclePictureBox2.Size = new System.Drawing.Size(45, 45);
            this.siticoneCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticoneCirclePictureBox2.TabIndex = 56;
            this.siticoneCirclePictureBox2.TabStop = false;
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.siticoneLabel4.Location = new System.Drawing.Point(194, 3);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(82, 40);
            this.siticoneLabel4.TabIndex = 55;
            this.siticoneLabel4.Text = "Login";
            // 
            // loginstatus
            // 
            this.loginstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.loginstatus, Siticone.UI.AnimatorNS.DecorationType.None);
            this.loginstatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginstatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginstatus.ForeColor = System.Drawing.SystemColors.Control;
            this.loginstatus.Location = new System.Drawing.Point(0, 292);
            this.loginstatus.Name = "loginstatus";
            this.loginstatus.Size = new System.Drawing.Size(402, 69);
            this.loginstatus.TabIndex = 3;
            this.loginstatus.Text = "Status : Welcome! Authorization waiting!";
            this.loginstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username
            // 
            this.username.AllowDrop = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.username, Siticone.UI.AnimatorNS.DecorationType.None);
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.username.FocusedState.Parent = this.username;
            this.username.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.username.HoveredState.BorderColor = System.Drawing.SystemColors.Control;
            this.username.HoveredState.Parent = this.username;
            this.username.IconLeft = ((System.Drawing.Image)(resources.GetObject("username.IconLeft")));
            this.username.Location = new System.Drawing.Point(83, 93);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(236, 30);
            this.username.TabIndex = 8;
            this.username.Tag = "User";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.siticoneToolTip2.SetToolTip(this.username, "Username");
            // 
            // password
            // 
            this.password.AllowDrop = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.password, Siticone.UI.AnimatorNS.DecorationType.None);
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.password.FocusedState.Parent = this.password;
            this.password.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.password.HoveredState.BorderColor = System.Drawing.SystemColors.Control;
            this.password.HoveredState.Parent = this.password;
            this.password.IconLeft = ((System.Drawing.Image)(resources.GetObject("password.IconLeft")));
            this.password.Location = new System.Drawing.Point(83, 134);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderText = "";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(236, 30);
            this.password.TabIndex = 9;
            this.password.Tag = "*";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.siticoneToolTip2.SetToolTip(this.password, "Password");
            this.password.UseSystemPasswordChar = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.LoginBtn.BorderThickness = 1;
            this.LoginBtn.CheckedState.Parent = this.LoginBtn;
            this.LoginBtn.CustomImages.Parent = this.LoginBtn;
            this.siticoneTransition1.SetDecoration(this.LoginBtn, Siticone.UI.AnimatorNS.DecorationType.None);
            this.LoginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.LoginBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginBtn.HoveredState.Parent = this.LoginBtn;
            this.LoginBtn.Image = ((System.Drawing.Image)(resources.GetObject("LoginBtn.Image")));
            this.LoginBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LoginBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.LoginBtn.Location = new System.Drawing.Point(109, 254);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.PressedDepth = 36;
            this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
            this.LoginBtn.Size = new System.Drawing.Size(184, 32);
            this.LoginBtn.TabIndex = 10;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage2.Controls.Add(this.siticoneGradientPanel3);
            this.siticoneTransition1.SetDecoration(this.tabPage2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(5, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(408, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "registerPage2";
            // 
            // siticoneGradientPanel3
            // 
            this.siticoneGradientPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneGradientPanel3.Controls.Add(this.siticoneLabel5);
            this.siticoneGradientPanel3.Controls.Add(this.registerstatus);
            this.siticoneGradientPanel3.Controls.Add(this.RgstrBtn);
            this.siticoneGradientPanel3.Controls.Add(this.registerkey);
            this.siticoneGradientPanel3.Controls.Add(this.siticoneCirclePictureBox3);
            this.siticoneGradientPanel3.Controls.Add(this.siticoneLabel6);
            this.siticoneGradientPanel3.Controls.Add(this.registerusername);
            this.siticoneGradientPanel3.Controls.Add(this.registerpassword);
            this.siticoneTransition1.SetDecoration(this.siticoneGradientPanel3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneGradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneGradientPanel3.Location = new System.Drawing.Point(3, 3);
            this.siticoneGradientPanel3.Name = "siticoneGradientPanel3";
            this.siticoneGradientPanel3.ShadowDecoration.Parent = this.siticoneGradientPanel3;
            this.siticoneGradientPanel3.Size = new System.Drawing.Size(402, 361);
            this.siticoneGradientPanel3.TabIndex = 59;
            // 
            // siticoneLabel5
            // 
            this.siticoneLabel5.AutoSize = false;
            this.siticoneLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel5.Location = new System.Drawing.Point(91, 295);
            this.siticoneLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel5.Name = "siticoneLabel5";
            this.siticoneLabel5.Size = new System.Drawing.Size(216, 29);
            this.siticoneLabel5.TabIndex = 65;
            this.siticoneLabel5.Text = "Current Session Validation Status: \r\n";
            this.siticoneLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneLabel5.Visible = false;
            // 
            // registerstatus
            // 
            this.registerstatus.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.registerstatus, Siticone.UI.AnimatorNS.DecorationType.None);
            this.registerstatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerstatus.ForeColor = System.Drawing.Color.White;
            this.registerstatus.Location = new System.Drawing.Point(0, 326);
            this.registerstatus.Name = "registerstatus";
            this.registerstatus.Size = new System.Drawing.Size(418, 46);
            this.registerstatus.TabIndex = 64;
            this.registerstatus.Text = "Status : Welcome! Authorization waiting!";
            this.registerstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RgstrBtn
            // 
            this.RgstrBtn.BackColor = System.Drawing.Color.Transparent;
            this.RgstrBtn.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.RgstrBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.RgstrBtn.BorderThickness = 1;
            this.RgstrBtn.CheckedState.Parent = this.RgstrBtn;
            this.RgstrBtn.CustomImages.Parent = this.RgstrBtn;
            this.siticoneTransition1.SetDecoration(this.RgstrBtn, Siticone.UI.AnimatorNS.DecorationType.None);
            this.RgstrBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.RgstrBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.RgstrBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RgstrBtn.ForeColor = System.Drawing.Color.White;
            this.RgstrBtn.HoveredState.Parent = this.RgstrBtn;
            this.RgstrBtn.Image = ((System.Drawing.Image)(resources.GetObject("RgstrBtn.Image")));
            this.RgstrBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RgstrBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.RgstrBtn.Location = new System.Drawing.Point(117, 255);
            this.RgstrBtn.Name = "RgstrBtn";
            this.RgstrBtn.PressedDepth = 37;
            this.RgstrBtn.ShadowDecoration.Parent = this.RgstrBtn;
            this.RgstrBtn.Size = new System.Drawing.Size(184, 32);
            this.RgstrBtn.TabIndex = 63;
            this.RgstrBtn.Text = "Register";
            this.RgstrBtn.Click += new System.EventHandler(this.RgstrBtn_Click);
            // 
            // registerkey
            // 
            this.registerkey.AllowDrop = true;
            this.registerkey.BackColor = System.Drawing.Color.Transparent;
            this.registerkey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.registerkey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.registerkey, Siticone.UI.AnimatorNS.DecorationType.None);
            this.registerkey.DefaultText = "";
            this.registerkey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.registerkey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.registerkey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registerkey.DisabledState.Parent = this.registerkey;
            this.registerkey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registerkey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.registerkey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.registerkey.FocusedState.Parent = this.registerkey;
            this.registerkey.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.registerkey.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.registerkey.HoveredState.Parent = this.registerkey;
            this.registerkey.IconLeft = ((System.Drawing.Image)(resources.GetObject("registerkey.IconLeft")));
            this.registerkey.Location = new System.Drawing.Point(33, 190);
            this.registerkey.Margin = new System.Windows.Forms.Padding(4);
            this.registerkey.Name = "registerkey";
            this.registerkey.PasswordChar = '\0';
            this.registerkey.PlaceholderText = "";
            this.registerkey.SelectedText = "";
            this.registerkey.ShadowDecoration.Parent = this.registerkey;
            this.registerkey.Size = new System.Drawing.Size(353, 30);
            this.registerkey.TabIndex = 62;
            this.registerkey.Tag = "";
            this.registerkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.siticoneToolTip3.SetToolTip(this.registerkey, "XXXXX-XXXXX-XXXXX-XXXXX (Key)");
            // 
            // siticoneCirclePictureBox3
            // 
            this.siticoneCirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneCirclePictureBox3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox3.Image")));
            this.siticoneCirclePictureBox3.Location = new System.Drawing.Point(124, 3);
            this.siticoneCirclePictureBox3.Name = "siticoneCirclePictureBox3";
            this.siticoneCirclePictureBox3.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox3.ShadowDecoration.Parent = this.siticoneCirclePictureBox3;
            this.siticoneCirclePictureBox3.Size = new System.Drawing.Size(45, 45);
            this.siticoneCirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticoneCirclePictureBox3.TabIndex = 61;
            this.siticoneCirclePictureBox3.TabStop = false;
            // 
            // siticoneLabel6
            // 
            this.siticoneLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneLabel6.Location = new System.Drawing.Point(175, 0);
            this.siticoneLabel6.Name = "siticoneLabel6";
            this.siticoneLabel6.Size = new System.Drawing.Size(125, 40);
            this.siticoneLabel6.TabIndex = 60;
            this.siticoneLabel6.Text = "Register";
            // 
            // registerusername
            // 
            this.registerusername.AllowDrop = true;
            this.registerusername.BackColor = System.Drawing.Color.Transparent;
            this.registerusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.registerusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.registerusername, Siticone.UI.AnimatorNS.DecorationType.None);
            this.registerusername.DefaultText = "";
            this.registerusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.registerusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.registerusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registerusername.DisabledState.Parent = this.registerusername;
            this.registerusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registerusername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.registerusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.registerusername.FocusedState.Parent = this.registerusername;
            this.registerusername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.registerusername.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.registerusername.HoveredState.Parent = this.registerusername;
            this.registerusername.IconLeft = ((System.Drawing.Image)(resources.GetObject("registerusername.IconLeft")));
            this.registerusername.Location = new System.Drawing.Point(91, 92);
            this.registerusername.Margin = new System.Windows.Forms.Padding(4);
            this.registerusername.Name = "registerusername";
            this.registerusername.PasswordChar = '\0';
            this.registerusername.PlaceholderText = "";
            this.registerusername.SelectedText = "";
            this.registerusername.ShadowDecoration.Parent = this.registerusername;
            this.registerusername.Size = new System.Drawing.Size(236, 30);
            this.registerusername.TabIndex = 58;
            this.registerusername.Tag = "User";
            this.registerusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.siticoneToolTip3.SetToolTip(this.registerusername, "Username");
            // 
            // registerpassword
            // 
            this.registerpassword.AllowDrop = true;
            this.registerpassword.BackColor = System.Drawing.Color.Transparent;
            this.registerpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.registerpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.registerpassword, Siticone.UI.AnimatorNS.DecorationType.None);
            this.registerpassword.DefaultText = "";
            this.registerpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.registerpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.registerpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registerpassword.DisabledState.Parent = this.registerpassword;
            this.registerpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.registerpassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.registerpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.registerpassword.FocusedState.Parent = this.registerpassword;
            this.registerpassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.registerpassword.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.registerpassword.HoveredState.Parent = this.registerpassword;
            this.registerpassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("registerpassword.IconLeft")));
            this.registerpassword.Location = new System.Drawing.Point(91, 141);
            this.registerpassword.Margin = new System.Windows.Forms.Padding(4);
            this.registerpassword.Name = "registerpassword";
            this.registerpassword.PasswordChar = '\0';
            this.registerpassword.PlaceholderText = "";
            this.registerpassword.SelectedText = "";
            this.registerpassword.ShadowDecoration.Parent = this.registerpassword;
            this.registerpassword.Size = new System.Drawing.Size(236, 30);
            this.registerpassword.TabIndex = 59;
            this.registerpassword.Tag = "*";
            this.registerpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.siticoneToolTip3.SetToolTip(this.registerpassword, "Password");
            this.registerpassword.UseSystemPasswordChar = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage3.Controls.Add(this.siticoneGradientPanel4);
            this.siticoneTransition1.SetDecoration(this.tabPage3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage3.Location = new System.Drawing.Point(5, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(408, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "upgradePage3";
            // 
            // siticoneGradientPanel4
            // 
            this.siticoneGradientPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneGradientPanel4.Controls.Add(this.siticoneLabel7);
            this.siticoneGradientPanel4.Controls.Add(this.UpgradeBtn);
            this.siticoneGradientPanel4.Controls.Add(this.upgradestatus);
            this.siticoneGradientPanel4.Controls.Add(this.upgradekey);
            this.siticoneGradientPanel4.Controls.Add(this.siticoneCirclePictureBox4);
            this.siticoneGradientPanel4.Controls.Add(this.siticoneLabel8);
            this.siticoneGradientPanel4.Controls.Add(this.upgradeusername);
            this.siticoneTransition1.SetDecoration(this.siticoneGradientPanel4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneGradientPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneGradientPanel4.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel4.Name = "siticoneGradientPanel4";
            this.siticoneGradientPanel4.ShadowDecoration.Parent = this.siticoneGradientPanel4;
            this.siticoneGradientPanel4.Size = new System.Drawing.Size(408, 367);
            this.siticoneGradientPanel4.TabIndex = 1;
            // 
            // siticoneLabel7
            // 
            this.siticoneLabel7.AutoSize = false;
            this.siticoneLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneLabel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel7.Location = new System.Drawing.Point(111, 283);
            this.siticoneLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel7.Name = "siticoneLabel7";
            this.siticoneLabel7.Size = new System.Drawing.Size(216, 29);
            this.siticoneLabel7.TabIndex = 63;
            this.siticoneLabel7.Text = "Current Session Validation Status: \r\n";
            this.siticoneLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneLabel7.Visible = false;
            // 
            // UpgradeBtn
            // 
            this.UpgradeBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpgradeBtn.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.UpgradeBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.UpgradeBtn.BorderThickness = 1;
            this.UpgradeBtn.CheckedState.Parent = this.UpgradeBtn;
            this.UpgradeBtn.CustomImages.Parent = this.UpgradeBtn;
            this.siticoneTransition1.SetDecoration(this.UpgradeBtn, Siticone.UI.AnimatorNS.DecorationType.None);
            this.UpgradeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.UpgradeBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.UpgradeBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpgradeBtn.ForeColor = System.Drawing.Color.White;
            this.UpgradeBtn.HoveredState.Parent = this.UpgradeBtn;
            this.UpgradeBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpgradeBtn.Image")));
            this.UpgradeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UpgradeBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.UpgradeBtn.Location = new System.Drawing.Point(118, 231);
            this.UpgradeBtn.Name = "UpgradeBtn";
            this.UpgradeBtn.PressedDepth = 38;
            this.UpgradeBtn.ShadowDecoration.Parent = this.UpgradeBtn;
            this.UpgradeBtn.Size = new System.Drawing.Size(183, 32);
            this.UpgradeBtn.TabIndex = 62;
            this.UpgradeBtn.Text = "Upgrade subscription";
            this.UpgradeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UpgradeBtn.Click += new System.EventHandler(this.UpgradeBtn_Click);
            // 
            // upgradestatus
            // 
            this.upgradestatus.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.upgradestatus, Siticone.UI.AnimatorNS.DecorationType.None);
            this.upgradestatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.upgradestatus.ForeColor = System.Drawing.Color.White;
            this.upgradestatus.Location = new System.Drawing.Point(0, 326);
            this.upgradestatus.Name = "upgradestatus";
            this.upgradestatus.Size = new System.Drawing.Size(418, 46);
            this.upgradestatus.TabIndex = 61;
            this.upgradestatus.Text = "Status : Welcome! Authorization waiting!";
            this.upgradestatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upgradekey
            // 
            this.upgradekey.AllowDrop = true;
            this.upgradekey.BackColor = System.Drawing.Color.Transparent;
            this.upgradekey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.upgradekey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.upgradekey, Siticone.UI.AnimatorNS.DecorationType.None);
            this.upgradekey.DefaultText = "";
            this.upgradekey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.upgradekey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.upgradekey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.upgradekey.DisabledState.Parent = this.upgradekey;
            this.upgradekey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.upgradekey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.upgradekey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.upgradekey.FocusedState.Parent = this.upgradekey;
            this.upgradekey.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.upgradekey.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.upgradekey.HoveredState.Parent = this.upgradekey;
            this.upgradekey.IconLeft = ((System.Drawing.Image)(resources.GetObject("upgradekey.IconLeft")));
            this.upgradekey.Location = new System.Drawing.Point(33, 167);
            this.upgradekey.Margin = new System.Windows.Forms.Padding(4);
            this.upgradekey.Name = "upgradekey";
            this.upgradekey.PasswordChar = '\0';
            this.upgradekey.PlaceholderText = "";
            this.upgradekey.SelectedText = "";
            this.upgradekey.ShadowDecoration.Parent = this.upgradekey;
            this.upgradekey.Size = new System.Drawing.Size(353, 30);
            this.upgradekey.TabIndex = 60;
            this.upgradekey.Tag = "";
            this.upgradekey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.siticoneToolTip4.SetToolTip(this.upgradekey, "XXXXX-XXXXX-XXXXX-XXXXX-XXXXX (New Key)");
            // 
            // siticoneCirclePictureBox4
            // 
            this.siticoneCirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneCirclePictureBox4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCirclePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox4.Image")));
            this.siticoneCirclePictureBox4.Location = new System.Drawing.Point(120, 3);
            this.siticoneCirclePictureBox4.Name = "siticoneCirclePictureBox4";
            this.siticoneCirclePictureBox4.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox4.ShadowDecoration.Parent = this.siticoneCirclePictureBox4;
            this.siticoneCirclePictureBox4.Size = new System.Drawing.Size(45, 45);
            this.siticoneCirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticoneCirclePictureBox4.TabIndex = 59;
            this.siticoneCirclePictureBox4.TabStop = false;
            // 
            // siticoneLabel8
            // 
            this.siticoneLabel8.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneLabel8.Location = new System.Drawing.Point(171, 0);
            this.siticoneLabel8.Name = "siticoneLabel8";
            this.siticoneLabel8.Size = new System.Drawing.Size(128, 40);
            this.siticoneLabel8.TabIndex = 58;
            this.siticoneLabel8.Text = "Upgrade";
            // 
            // upgradeusername
            // 
            this.upgradeusername.AllowDrop = true;
            this.upgradeusername.BackColor = System.Drawing.Color.Transparent;
            this.upgradeusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.upgradeusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.upgradeusername, Siticone.UI.AnimatorNS.DecorationType.None);
            this.upgradeusername.DefaultText = "";
            this.upgradeusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.upgradeusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.upgradeusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.upgradeusername.DisabledState.Parent = this.upgradeusername;
            this.upgradeusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.upgradeusername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.upgradeusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.upgradeusername.FocusedState.Parent = this.upgradeusername;
            this.upgradeusername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.upgradeusername.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.upgradeusername.HoveredState.Parent = this.upgradeusername;
            this.upgradeusername.IconLeft = ((System.Drawing.Image)(resources.GetObject("upgradeusername.IconLeft")));
            this.upgradeusername.Location = new System.Drawing.Point(91, 116);
            this.upgradeusername.Margin = new System.Windows.Forms.Padding(4);
            this.upgradeusername.Name = "upgradeusername";
            this.upgradeusername.PasswordChar = '\0';
            this.upgradeusername.PlaceholderText = "";
            this.upgradeusername.SelectedText = "";
            this.upgradeusername.ShadowDecoration.Parent = this.upgradeusername;
            this.upgradeusername.Size = new System.Drawing.Size(236, 30);
            this.upgradeusername.TabIndex = 57;
            this.upgradeusername.Tag = "User";
            this.upgradeusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.siticoneToolTip4.SetToolTip(this.upgradeusername, "Username");
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage4.Controls.Add(this.siticoneGradientPanel5);
            this.siticoneTransition1.SetDecoration(this.tabPage4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage4.Location = new System.Drawing.Point(5, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(408, 367);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "keyLogin4";
            // 
            // siticoneGradientPanel5
            // 
            this.siticoneGradientPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneGradientPanel5.Controls.Add(this.siticoneLabel9);
            this.siticoneGradientPanel5.Controls.Add(this.keyrememberme);
            this.siticoneGradientPanel5.Controls.Add(this.label7);
            this.siticoneGradientPanel5.Controls.Add(this.keystatus);
            this.siticoneGradientPanel5.Controls.Add(this.siticoneCirclePictureBox5);
            this.siticoneGradientPanel5.Controls.Add(this.siticoneLabel10);
            this.siticoneGradientPanel5.Controls.Add(this.KeyBtn);
            this.siticoneGradientPanel5.Controls.Add(this.keylogin);
            this.siticoneTransition1.SetDecoration(this.siticoneGradientPanel5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneGradientPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneGradientPanel5.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel5.Name = "siticoneGradientPanel5";
            this.siticoneGradientPanel5.ShadowDecoration.Parent = this.siticoneGradientPanel5;
            this.siticoneGradientPanel5.Size = new System.Drawing.Size(408, 367);
            this.siticoneGradientPanel5.TabIndex = 1;
            // 
            // siticoneLabel9
            // 
            this.siticoneLabel9.AutoSize = false;
            this.siticoneLabel9.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneLabel9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel9.Location = new System.Drawing.Point(99, 293);
            this.siticoneLabel9.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel9.Name = "siticoneLabel9";
            this.siticoneLabel9.Size = new System.Drawing.Size(216, 29);
            this.siticoneLabel9.TabIndex = 66;
            this.siticoneLabel9.Text = "Current Session Validation Status: \r\n";
            this.siticoneLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneLabel9.Visible = false;
            // 
            // keyrememberme
            // 
            this.keyrememberme.BackColor = System.Drawing.Color.Transparent;
            this.keyrememberme.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.keyrememberme.CheckedState.BorderRadius = 3;
            this.keyrememberme.CheckedState.BorderThickness = 0;
            this.keyrememberme.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.keyrememberme.CheckedState.Parent = this.keyrememberme;
            this.keyrememberme.CheckMarkColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneTransition1.SetDecoration(this.keyrememberme, Siticone.UI.AnimatorNS.DecorationType.None);
            this.keyrememberme.Location = new System.Drawing.Point(258, 184);
            this.keyrememberme.Name = "keyrememberme";
            this.keyrememberme.ShadowDecoration.Parent = this.keyrememberme;
            this.keyrememberme.Size = new System.Drawing.Size(20, 20);
            this.keyrememberme.TabIndex = 65;
            this.keyrememberme.UncheckedState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.keyrememberme.UncheckedState.BorderRadius = 3;
            this.keyrememberme.UncheckedState.BorderThickness = 1;
            this.keyrememberme.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.keyrememberme.UncheckedState.Parent = this.keyrememberme;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.label7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(141, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "Remember me";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keystatus
            // 
            this.keystatus.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.keystatus, Siticone.UI.AnimatorNS.DecorationType.None);
            this.keystatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.keystatus.ForeColor = System.Drawing.Color.White;
            this.keystatus.Location = new System.Drawing.Point(0, 326);
            this.keystatus.Name = "keystatus";
            this.keystatus.Size = new System.Drawing.Size(418, 46);
            this.keystatus.TabIndex = 63;
            this.keystatus.Text = "Status : Welcome! Authorization waiting!";
            this.keystatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneCirclePictureBox5
            // 
            this.siticoneCirclePictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneCirclePictureBox5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCirclePictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("siticoneCirclePictureBox5.Image")));
            this.siticoneCirclePictureBox5.Location = new System.Drawing.Point(57, 3);
            this.siticoneCirclePictureBox5.Name = "siticoneCirclePictureBox5";
            this.siticoneCirclePictureBox5.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox5.ShadowDecoration.Parent = this.siticoneCirclePictureBox5;
            this.siticoneCirclePictureBox5.Size = new System.Drawing.Size(45, 45);
            this.siticoneCirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.siticoneCirclePictureBox5.TabIndex = 62;
            this.siticoneCirclePictureBox5.TabStop = false;
            // 
            // siticoneLabel10
            // 
            this.siticoneLabel10.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel10, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneLabel10.Location = new System.Drawing.Point(108, 3);
            this.siticoneLabel10.Name = "siticoneLabel10";
            this.siticoneLabel10.Size = new System.Drawing.Size(254, 40);
            this.siticoneLabel10.TabIndex = 61;
            this.siticoneLabel10.Text = "License key login";
            // 
            // KeyBtn
            // 
            this.KeyBtn.BackColor = System.Drawing.Color.Transparent;
            this.KeyBtn.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.KeyBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.KeyBtn.BorderThickness = 1;
            this.KeyBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.KeyBtn.CheckedState.Parent = this.KeyBtn;
            this.KeyBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.KeyBtn.CustomImages.Parent = this.KeyBtn;
            this.siticoneTransition1.SetDecoration(this.KeyBtn, Siticone.UI.AnimatorNS.DecorationType.None);
            this.KeyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.KeyBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.KeyBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyBtn.ForeColor = System.Drawing.Color.White;
            this.KeyBtn.HoveredState.Parent = this.KeyBtn;
            this.KeyBtn.Image = ((System.Drawing.Image)(resources.GetObject("KeyBtn.Image")));
            this.KeyBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.KeyBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.KeyBtn.Location = new System.Drawing.Point(117, 237);
            this.KeyBtn.Name = "KeyBtn";
            this.KeyBtn.ShadowDecoration.Parent = this.KeyBtn;
            this.KeyBtn.Size = new System.Drawing.Size(184, 32);
            this.KeyBtn.TabIndex = 60;
            this.KeyBtn.Text = "Key Login";
            this.KeyBtn.Click += new System.EventHandler(this.KeyBtn_Click);
            // 
            // keylogin
            // 
            this.keylogin.AllowDrop = true;
            this.keylogin.BackColor = System.Drawing.Color.Transparent;
            this.keylogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.keylogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.keylogin, Siticone.UI.AnimatorNS.DecorationType.None);
            this.keylogin.DefaultText = "";
            this.keylogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.keylogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.keylogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keylogin.DisabledState.Parent = this.keylogin;
            this.keylogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keylogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.keylogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.keylogin.FocusedState.Parent = this.keylogin;
            this.keylogin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.keylogin.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(161)))), ((int)(((byte)(1)))));
            this.keylogin.HoveredState.Parent = this.keylogin;
            this.keylogin.IconLeft = ((System.Drawing.Image)(resources.GetObject("keylogin.IconLeft")));
            this.keylogin.Location = new System.Drawing.Point(33, 122);
            this.keylogin.Margin = new System.Windows.Forms.Padding(4);
            this.keylogin.Name = "keylogin";
            this.keylogin.PasswordChar = '\0';
            this.keylogin.PlaceholderText = "";
            this.keylogin.SelectedText = "";
            this.keylogin.ShadowDecoration.Parent = this.keylogin;
            this.keylogin.Size = new System.Drawing.Size(353, 30);
            this.keylogin.TabIndex = 59;
            this.keylogin.Tag = "";
            this.keylogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.siticoneToolTip5.SetToolTip(this.keylogin, "XXXXX-XXXXX-XXXXX-XXXXX (License Key)");
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.AutoSize = false;
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siticoneLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel1.Location = new System.Drawing.Point(91, 295);
            this.siticoneLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(216, 29);
            this.siticoneLabel1.TabIndex = 39;
            this.siticoneLabel1.Text = "Current Session Validation Status: \r\n";
            this.siticoneLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneLabel1.Visible = false;
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticoneLabel2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.siticoneLabel2.Location = new System.Drawing.Point(194, 8);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(82, 40);
            this.siticoneLabel2.TabIndex = 48;
            this.siticoneLabel2.Text = "Login";
            // 
            // siticoneAnimateWindow1
            // 
            this.siticoneAnimateWindow1.Interval = 666;
            // 
            // siticoneToolTip1
            // 
            this.siticoneToolTip1.AllowLinksHandling = true;
            this.siticoneToolTip1.AutomaticDelay = 1000;
            this.siticoneToolTip1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneToolTip1.ForeColor = System.Drawing.Color.White;
            this.siticoneToolTip1.IsBalloon = true;
            this.siticoneToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // siticoneToolTip2
            // 
            this.siticoneToolTip2.AllowLinksHandling = true;
            this.siticoneToolTip2.AutomaticDelay = 1000;
            this.siticoneToolTip2.MaximumSize = new System.Drawing.Size(0, 0);
            this.siticoneToolTip2.ShowAlways = true;
            // 
            // siticoneToolTip3
            // 
            this.siticoneToolTip3.AllowLinksHandling = true;
            this.siticoneToolTip3.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // siticoneToolTip4
            // 
            this.siticoneToolTip4.AllowLinksHandling = true;
            this.siticoneToolTip4.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // siticoneToolTip5
            // 
            this.siticoneToolTip5.AllowLinksHandling = true;
            this.siticoneToolTip5.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(678, 408);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Controls.Add(this.loginpanel1);
            this.Controls.Add(this.headerpanel);
            this.Controls.Add(this.label1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.loginpanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.loginpanel2.ResumeLayout(false);
            this.loginpanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.siticoneGradientPanel3.ResumeLayout(false);
            this.siticoneGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.siticoneGradientPanel4.ResumeLayout(false);
            this.siticoneGradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox4)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.siticoneGradientPanel5.ResumeLayout(false);
            this.siticoneGradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000005 RID: 5
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.UI.WinForms.SiticoneCustomGradientPanel headerpanel;
        private Siticone.UI.WinForms.SiticoneCustomGradientPanel loginpanel1;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton3;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton2;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton1;
        private Siticone.UI.WinForms.SiticoneToolTip siticoneToolTip1;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Siticone.UI.WinForms.SiticoneGradientPanel loginpanel2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel4;
        private System.Windows.Forms.Label loginstatus;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox username;
        private Siticone.UI.WinForms.SiticoneToolTip siticoneToolTip2;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox password;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton LoginBtn;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel3;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel5;
        private System.Windows.Forms.Label registerstatus;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton RgstrBtn;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox registerkey;
        private Siticone.UI.WinForms.SiticoneToolTip siticoneToolTip3;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox3;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel6;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox registerusername;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox registerpassword;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel4;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel7;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton UpgradeBtn;
        private System.Windows.Forms.Label upgradestatus;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox upgradekey;
        private Siticone.UI.WinForms.SiticoneToolTip siticoneToolTip4;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox4;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel8;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox upgradeusername;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel5;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel9;
        private Siticone.UI.WinForms.SiticoneCustomCheckBox keyrememberme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label keystatus;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox5;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel10;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton KeyBtn;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox keylogin;
        private Siticone.UI.WinForms.SiticoneToolTip siticoneToolTip5;
        private Siticone.Desktop.UI.WinForms.SiticoneVSeparator siticoneVSeparator4;
        private System.Windows.Forms.Timer timer1;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch rememberme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch autologin;
        private Siticone.UI.WinForms.SiticoneRoundedGradientButton siticoneRoundedGradientButton4;
    }
}
