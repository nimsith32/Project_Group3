
namespace Project_Group12
{
    partial class formTextEditor
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
            this.components = new System.ComponentModel.Container();
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.windowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.windowTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.windowTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.windowCustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.windowCarList = new System.Windows.Forms.ToolStripMenuItem();
            this.windowAverageUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.windowNewTextEditor1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowNewTextEditor2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuWindow,
            this.menuHelp});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(800, 28);
            this.menuTop.TabIndex = 0;
            this.menuTop.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.toolStripSeparator3,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator4,
            this.menuFileClose,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "&File";
            this.menuFile.ToolTipText = "Options related to file management";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(181, 26);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.ToolTipText = "click to create a new file";
            this.menuFileNew.Click += new System.EventHandler(this.FileNew);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(181, 26);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.ToolTipText = "Click to Open a new File";
            this.menuFileOpen.Click += new System.EventHandler(this.FileOpen);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(181, 26);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.ToolTipText = "Click to save the document";
            this.menuFileSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(181, 26);
            this.menuFileSaveAs.Text = "Save &As...";
            this.menuFileSaveAs.ToolTipText = "Click to find a file location to save the newly created file.";
            this.menuFileSaveAs.Click += new System.EventHandler(this.FileSaveAs);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // menuFileClose
            // 
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.Size = new System.Drawing.Size(181, 26);
            this.menuFileClose.Text = "C&lose";
            this.menuFileClose.ToolTipText = "Click to close a window";
            this.menuFileClose.Click += new System.EventHandler(this.FileClose);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(181, 26);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.ToolTipText = "Click to exit the current application";
            this.menuFileExit.Click += new System.EventHandler(this.FileExit);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(49, 24);
            this.menuEdit.Text = "&Edit";
            // 
            // menuEditCut
            // 
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuEditCut.Size = new System.Drawing.Size(177, 26);
            this.menuEditCut.Text = "Cu&t";
            this.menuEditCut.ToolTipText = "Click to remove the current selection and to keep it in the clipboard";
            this.menuEditCut.Click += new System.EventHandler(this.EditCut);
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(177, 26);
            this.menuEditCopy.Text = "&Copy";
            this.menuEditCopy.ToolTipText = "Click to copy selected words ";
            this.menuEditCopy.Click += new System.EventHandler(this.EditCopy);
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(177, 26);
            this.menuEditPaste.Text = "&Paste";
            this.menuEditPaste.ToolTipText = "Click to paste the contents in the clipboard";
            this.menuEditPaste.Click += new System.EventHandler(this.EditPaste);
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowCascade,
            this.windowTileVertical,
            this.windowTileHorizontal,
            this.toolStripSeparator1,
            this.windowCustomerList,
            this.windowCarList,
            this.windowAverageUnits,
            this.toolStripSeparator2,
            this.windowNewTextEditor1,
            this.windowNewTextEditor2});
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size(78, 24);
            this.menuWindow.Text = "&Window";
            // 
            // windowCascade
            // 
            this.windowCascade.Name = "windowCascade";
            this.windowCascade.Size = new System.Drawing.Size(231, 26);
            this.windowCascade.Text = "Casca&de";
            this.windowCascade.Click += new System.EventHandler(this.WindowCascade);
            // 
            // windowTileVertical
            // 
            this.windowTileVertical.Name = "windowTileVertical";
            this.windowTileVertical.Size = new System.Drawing.Size(231, 26);
            this.windowTileVertical.Text = "Tile Vertical";
            // 
            // windowTileHorizontal
            // 
            this.windowTileHorizontal.Name = "windowTileHorizontal";
            this.windowTileHorizontal.Size = new System.Drawing.Size(231, 26);
            this.windowTileHorizontal.Text = "Tile Horizontal";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // windowCustomerList
            // 
            this.windowCustomerList.Name = "windowCustomerList";
            this.windowCustomerList.Size = new System.Drawing.Size(231, 26);
            this.windowCustomerList.Text = "Custo&mer List Form";
            // 
            // windowCarList
            // 
            this.windowCarList.Name = "windowCarList";
            this.windowCarList.Size = new System.Drawing.Size(231, 26);
            this.windowCarList.Text = "Open Car &List";
            this.windowCarList.ToolTipText = "Click to open the Car list program";
            // 
            // windowAverageUnits
            // 
            this.windowAverageUnits.Name = "windowAverageUnits";
            this.windowAverageUnits.Size = new System.Drawing.Size(231, 26);
            this.windowAverageUnits.Text = "Open &Average Units";
            this.windowAverageUnits.ToolTipText = "Click to open the Average Units program";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(228, 6);
            // 
            // windowNewTextEditor1
            // 
            this.windowNewTextEditor1.Name = "windowNewTextEditor1";
            this.windowNewTextEditor1.Size = new System.Drawing.Size(231, 26);
            this.windowNewTextEditor1.Text = "1 Text Editor 1 - New";
            this.windowNewTextEditor1.ToolTipText = "Click to open a new text editor";
            this.windowNewTextEditor1.Click += new System.EventHandler(this.windowNewTextEditor);
            // 
            // windowNewTextEditor2
            // 
            this.windowNewTextEditor2.Name = "windowNewTextEditor2";
            this.windowNewTextEditor2.Size = new System.Drawing.Size(231, 26);
            this.windowNewTextEditor2.Text = "2 Text Editor 2 - New";
            this.windowNewTextEditor2.ToolTipText = "Click to open another textEditor";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(55, 24);
            this.menuHelp.Text = "&Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(142, 26);
            this.menuHelpAbout.Text = "&About...";
            this.menuHelpAbout.ToolTipText = "Click to learn more about the application";
            this.menuHelpAbout.Click += new System.EventHandler(this.HelpAbout);
            // 
            // formTextEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuTop);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuTop;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Text Editor";
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem windowCascade;
        private System.Windows.Forms.ToolStripMenuItem windowTileVertical;
        private System.Windows.Forms.ToolStripMenuItem windowTileHorizontal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem windowCarList;
        private System.Windows.Forms.ToolStripMenuItem windowAverageUnits;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem windowNewTextEditor1;
        private System.Windows.Forms.ToolStripMenuItem windowNewTextEditor2;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem windowCustomerList;
    }
}

