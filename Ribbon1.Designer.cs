namespace appinion_add_on
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonButton button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.Appinion = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            button1 = this.Factory.CreateRibbonButton();
            this.Appinion.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Appinion
            // 
            this.Appinion.Groups.Add(this.group1);
            this.Appinion.Label = "Appinion";
            this.Appinion.Name = "Appinion";
            // 
            // group1
            // 
            this.group1.Items.Add(button1);
            this.group1.Label = "Dodaj prezentacije";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            button1.Label = "Get Presentation";
            button1.Name = "button1";
            button1.ShowImage = true;
            button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.Appinion);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.Appinion.ResumeLayout(false);
            this.Appinion.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Appinion;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
