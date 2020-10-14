﻿namespace Graphics_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaintLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaintRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaintCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.drawingToolLabel = new System.Windows.Forms.ToolStripLabel();
            this.drawingToolsButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.pencilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintBrushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.violetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuPaint,
            this.menuHelp});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1333, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileNewWindow,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFilePrint});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(143, 22);
            this.menuFileNew.Text = "New";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileNewWindow
            // 
            this.menuFileNewWindow.Name = "menuFileNewWindow";
            this.menuFileNewWindow.Size = new System.Drawing.Size(143, 22);
            this.menuFileNewWindow.Text = "New window";
            this.menuFileNewWindow.Click += new System.EventHandler(this.menuFileNewWindow_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(143, 22);
            this.menuFileOpen.Text = "Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.Size = new System.Drawing.Size(143, 22);
            this.menuFileSave.Text = "Save";
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(143, 22);
            this.menuFileSaveAs.Text = "Save as...";
            // 
            // menuFilePrint
            // 
            this.menuFilePrint.Name = "menuFilePrint";
            this.menuFilePrint.Size = new System.Drawing.Size(143, 22);
            this.menuFilePrint.Text = "Print...";
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditUndo,
            this.menuEditRedo,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "Edit";
            // 
            // menuEditUndo
            // 
            this.menuEditUndo.Name = "menuEditUndo";
            this.menuEditUndo.Size = new System.Drawing.Size(103, 22);
            this.menuEditUndo.Text = "Undo";
            // 
            // menuEditRedo
            // 
            this.menuEditRedo.Name = "menuEditRedo";
            this.menuEditRedo.Size = new System.Drawing.Size(103, 22);
            this.menuEditRedo.Text = "Redo";
            // 
            // menuEditCut
            // 
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.Size = new System.Drawing.Size(103, 22);
            this.menuEditCut.Text = "Cut";
            // 
            // menuEditCopy
            // 
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.Size = new System.Drawing.Size(103, 22);
            this.menuEditCopy.Text = "Copy";
            // 
            // menuEditPaste
            // 
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.Size = new System.Drawing.Size(103, 22);
            this.menuEditPaste.Text = "Paste";
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewTools});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 20);
            this.menuView.Text = "View";
            // 
            // menuViewTools
            // 
            this.menuViewTools.Name = "menuViewTools";
            this.menuViewTools.Size = new System.Drawing.Size(101, 22);
            this.menuViewTools.Text = "Tools";
            // 
            // menuPaint
            // 
            this.menuPaint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPaintLine,
            this.menuPaintRectangle,
            this.menuPaintCircle});
            this.menuPaint.Name = "menuPaint";
            this.menuPaint.Size = new System.Drawing.Size(55, 20);
            this.menuPaint.Text = "Paint...";
            // 
            // menuPaintLine
            // 
            this.menuPaintLine.Name = "menuPaintLine";
            this.menuPaintLine.Size = new System.Drawing.Size(126, 22);
            this.menuPaintLine.Text = "Line";
            // 
            // menuPaintRectangle
            // 
            this.menuPaintRectangle.Name = "menuPaintRectangle";
            this.menuPaintRectangle.Size = new System.Drawing.Size(126, 22);
            this.menuPaintRectangle.Text = "Rectangle";
            // 
            // menuPaintCircle
            // 
            this.menuPaintCircle.Name = "menuPaintCircle";
            this.menuPaintCircle.Size = new System.Drawing.Size(126, 22);
            this.menuPaintCircle.Text = "Circle";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.menuHelpAbout.Text = "About";
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawingToolLabel,
            this.drawingToolsButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripDropDownButton1});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1333, 25);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "toolStrip1";
            // 
            // drawingToolLabel
            // 
            this.drawingToolLabel.Name = "drawingToolLabel";
            this.drawingToolLabel.Size = new System.Drawing.Size(76, 22);
            this.drawingToolLabel.Text = "Drawing Tool";
            // 
            // drawingToolsButton
            // 
            this.drawingToolsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawingToolsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencilToolStripMenuItem,
            this.paintBrushToolStripMenuItem,
            this.toolStripMenuItem1,
            this.lineToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.circleToolStripMenuItem});
            this.drawingToolsButton.Image = ((System.Drawing.Image)(resources.GetObject("drawingToolsButton.Image")));
            this.drawingToolsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawingToolsButton.Name = "drawingToolsButton";
            this.drawingToolsButton.Size = new System.Drawing.Size(29, 22);
            this.drawingToolsButton.Text = "Drawing Tools";
            // 
            // pencilToolStripMenuItem
            // 
            this.pencilToolStripMenuItem.Name = "pencilToolStripMenuItem";
            this.pencilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pencilToolStripMenuItem.Text = "Pencil";
            // 
            // paintBrushToolStripMenuItem
            // 
            this.paintBrushToolStripMenuItem.Name = "paintBrushToolStripMenuItem";
            this.paintBrushToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paintBrushToolStripMenuItem.Text = "Paint Brush";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lineToolStripMenuItem.Text = "Line";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "Color";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.pinkToolStripMenuItem,
            this.brownToolStripMenuItem,
            this.violetToolStripMenuItem,
            this.greyToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blackToolStripMenuItem.Text = "Black";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.whiteToolStripMenuItem.Text = "White";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "Red";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orangeToolStripMenuItem.Text = "Orange";
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pinkToolStripMenuItem.Text = "Pink";
            // 
            // brownToolStripMenuItem
            // 
            this.brownToolStripMenuItem.Name = "brownToolStripMenuItem";
            this.brownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brownToolStripMenuItem.Text = "Brown";
            // 
            // violetToolStripMenuItem
            // 
            this.violetToolStripMenuItem.Name = "violetToolStripMenuItem";
            this.violetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.violetToolStripMenuItem.Text = "Violet";
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greyToolStripMenuItem.Text = "Grey";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otherToolStripMenuItem.Text = "Other...";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(0, 52);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1333, 570);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphics Editor";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileNewWindow;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditUndo;
        private System.Windows.Forms.ToolStripMenuItem menuEditRedo;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuViewTools;
        private System.Windows.Forms.ToolStrip toolBar;
        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripLabel drawingToolLabel;
        private System.Windows.Forms.ToolStripMenuItem menuPaint;
        private System.Windows.Forms.ToolStripMenuItem menuPaintLine;
        private System.Windows.Forms.ToolStripMenuItem menuPaintRectangle;
        private System.Windows.Forms.ToolStripMenuItem menuPaintCircle;
        private System.Windows.Forms.ToolStripDropDownButton drawingToolsButton;
        private System.Windows.Forms.ToolStripMenuItem pencilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintBrushToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem violetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
    }
}

