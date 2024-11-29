namespace Test
{
    partial class Serverlist
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serverlist));
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.BorderRadius = 30;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.FromArgb(15, 15, 15);
            guna2ComboBox1.BorderColor = Color.FromArgb(15, 15, 15);
            guna2ComboBox1.CustomizableEdges = customizableEdges3;
            guna2Transition1.SetDecoration(guna2ComboBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FillColor = Color.FromArgb(15, 15, 15);
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2ComboBox1.ForeColor = Color.White;
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Items.AddRange(new object[] { "TORONTO", "https://acstuff.ru/s/q:race/online/join?ip=45.55.38.4&httpPort=8000", "", "SRP", "https://acstuff.ru/s/q:race/online/join?ip=45.55.38.4&httpPort=8002", "", "FDR", "https://acstuff.ru/s/q:race/online/join?ip=45.55.38.4&httpPort=8003" });
            guna2ComboBox1.Location = new Point(36, 167);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ComboBox1.Size = new Size(268, 36);
            guna2ComboBox1.TabIndex = 0;
            guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // guna2Transition1
            // 
            guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            guna2Transition1.DefaultAnimation = animation1;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Black;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Transition1.SetDecoration(guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(15, 15, 15);
            guna2Button1.Font = new Font("Nexa Bold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(36, 360);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(268, 32);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Join";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Serverlist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(335, 465);
            Controls.Add(guna2Button1);
            Controls.Add(guna2ComboBox1);
            guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Serverlist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Serverlist";
            Load += Serverlist_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}