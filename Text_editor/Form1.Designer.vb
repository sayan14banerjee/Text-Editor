<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        OPenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem1 = New ToolStripMenuItem()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        PrintPreviewToolStripMenuItem = New ToolStripMenuItem()
        PrintToolStripMenuItem1 = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        ColorToolStripMenuItem = New ToolStripMenuItem()
        FrontColorToolStripMenuItem = New ToolStripMenuItem()
        BackColorToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        RichTextBox1 = New RichTextBox()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        FontDialog1 = New FontDialog()
        ColorDialog1 = New ColorDialog()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDialog1 = New PrintDialog()
        PrintDocument1 = New Printing.PrintDocument()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Black
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(878, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SaveToolStripMenuItem, OPenToolStripMenuItem, SaveToolStripMenuItem1, PrintToolStripMenuItem})
        FileToolStripMenuItem.ForeColor = SystemColors.ControlLight
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText
        SaveToolStripMenuItem.ForeColor = SystemColors.ControlLight
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(103, 22)
        SaveToolStripMenuItem.Text = "New"
        ' 
        ' OPenToolStripMenuItem
        ' 
        OPenToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText
        OPenToolStripMenuItem.ForeColor = SystemColors.ControlLight
        OPenToolStripMenuItem.Name = "OPenToolStripMenuItem"
        OPenToolStripMenuItem.Size = New Size(103, 22)
        OPenToolStripMenuItem.Text = "Open"
        ' 
        ' SaveToolStripMenuItem1
        ' 
        SaveToolStripMenuItem1.BackColor = SystemColors.ActiveCaptionText
        SaveToolStripMenuItem1.ForeColor = SystemColors.ControlLight
        SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        SaveToolStripMenuItem1.Size = New Size(103, 22)
        SaveToolStripMenuItem1.Text = "Save"
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText
        PrintToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PrintPreviewToolStripMenuItem, PrintToolStripMenuItem1})
        PrintToolStripMenuItem.ForeColor = SystemColors.ControlLight
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.Size = New Size(103, 22)
        PrintToolStripMenuItem.Text = "Print"
        ' 
        ' PrintPreviewToolStripMenuItem
        ' 
        PrintPreviewToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText
        PrintPreviewToolStripMenuItem.ForeColor = SystemColors.ControlLight
        PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        PrintPreviewToolStripMenuItem.Size = New Size(143, 22)
        PrintPreviewToolStripMenuItem.Text = "Print Preview"
        ' 
        ' PrintToolStripMenuItem1
        ' 
        PrintToolStripMenuItem1.BackColor = SystemColors.ActiveCaptionText
        PrintToolStripMenuItem1.ForeColor = SystemColors.ControlLight
        PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        PrintToolStripMenuItem1.Size = New Size(143, 22)
        PrintToolStripMenuItem1.Text = "Print"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ColorToolStripMenuItem, FontToolStripMenuItem})
        EditToolStripMenuItem.ForeColor = SystemColors.ControlLight
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' ColorToolStripMenuItem
        ' 
        ColorToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText
        ColorToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FrontColorToolStripMenuItem, BackColorToolStripMenuItem})
        ColorToolStripMenuItem.ForeColor = SystemColors.ControlLight
        ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        ColorToolStripMenuItem.Size = New Size(180, 22)
        ColorToolStripMenuItem.Text = "Color"
        ' 
        ' FrontColorToolStripMenuItem
        ' 
        FrontColorToolStripMenuItem.Name = "FrontColorToolStripMenuItem"
        FrontColorToolStripMenuItem.Size = New Size(180, 22)
        FrontColorToolStripMenuItem.Text = "Front Color"
        ' 
        ' BackColorToolStripMenuItem
        ' 
        BackColorToolStripMenuItem.Name = "BackColorToolStripMenuItem"
        BackColorToolStripMenuItem.Size = New Size(180, 22)
        BackColorToolStripMenuItem.Text = "Back Color"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.BackColor = SystemColors.ActiveCaptionText
        FontToolStripMenuItem.ForeColor = SystemColors.ControlLight
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(180, 22)
        FontToolStripMenuItem.Text = "Font"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.ForeColor = SystemColors.ControlLight
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(38, 20)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = SystemColors.InfoText
        RichTextBox1.Location = New Point(18, 34)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(848, 265)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Desktop
        ClientSize = New Size(878, 308)
        Controls.Add(RichTextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "TextEditor"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OPenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents FrontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackColorToolStripMenuItem As ToolStripMenuItem
End Class
