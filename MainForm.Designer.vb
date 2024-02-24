<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.FileNew = New System.Windows.Forms.ToolStripMenuItem()
    Me.FileOpen = New System.Windows.Forms.ToolStripMenuItem()
    Me.FileSave = New System.Windows.Forms.ToolStripMenuItem()
    Me.FileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
    Me.FileExit = New System.Windows.Forms.ToolStripMenuItem()
    Me.TemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.TemplateStandard = New System.Windows.Forms.ToolStripMenuItem()
    Me.TemplateMini = New System.Windows.Forms.ToolStripMenuItem()
    Me.TexturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.TexturesOpenTexturePackImage = New System.Windows.Forms.ToolStripMenuItem()
    Me.TexturesOpenResourcePack = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
    Me.Textures32 = New System.Windows.Forms.ToolStripMenuItem()
    Me.Textures64 = New System.Windows.Forms.ToolStripMenuItem()
    Me.Textures128 = New System.Windows.Forms.ToolStripMenuItem()
    Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
    Me.HelpGettingStarted = New System.Windows.Forms.ToolStripMenuItem()
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.StatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
    Me.StatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
    Me.OpenDesignDialog = New System.Windows.Forms.OpenFileDialog()
    Me.SaveDesignDialog = New System.Windows.Forms.SaveFileDialog()
    Me.OpenResourcePackDialog = New System.Windows.Forms.FolderBrowserDialog()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.TemplatePanel = New System.Windows.Forms.Panel()
    Me.TexturesPanel = New System.Windows.Forms.Panel()
    Me.OpenTextureDialog = New System.Windows.Forms.OpenFileDialog()
    Me.MenuStrip1.SuspendLayout()
    Me.StatusStrip1.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TemplateToolStripMenuItem, Me.TexturesToolStripMenuItem, Me.HelpToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(898, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileNew, Me.FileOpen, Me.FileSave, Me.FileSaveAs, Me.ToolStripMenuItem1, Me.FileExit})
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
    Me.FileToolStripMenuItem.Text = "&File"
    '
    'FileNew
    '
    Me.FileNew.Name = "FileNew"
    Me.FileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
    Me.FileNew.Size = New System.Drawing.Size(146, 22)
    Me.FileNew.Text = "&New"
    '
    'FileOpen
    '
    Me.FileOpen.Name = "FileOpen"
    Me.FileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
    Me.FileOpen.Size = New System.Drawing.Size(146, 22)
    Me.FileOpen.Text = "&Open"
    '
    'FileSave
    '
    Me.FileSave.Name = "FileSave"
    Me.FileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
    Me.FileSave.Size = New System.Drawing.Size(146, 22)
    Me.FileSave.Text = "&Save"
    '
    'FileSaveAs
    '
    Me.FileSaveAs.Name = "FileSaveAs"
    Me.FileSaveAs.Size = New System.Drawing.Size(146, 22)
    Me.FileSaveAs.Text = "Save &As"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 6)
    '
    'FileExit
    '
    Me.FileExit.Name = "FileExit"
    Me.FileExit.Size = New System.Drawing.Size(146, 22)
    Me.FileExit.Text = "E&xit"
    '
    'TemplateToolStripMenuItem
    '
    Me.TemplateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemplateStandard, Me.TemplateMini})
    Me.TemplateToolStripMenuItem.Name = "TemplateToolStripMenuItem"
    Me.TemplateToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
    Me.TemplateToolStripMenuItem.Text = "&Template"
    '
    'TemplateStandard
    '
    Me.TemplateStandard.Name = "TemplateStandard"
    Me.TemplateStandard.Size = New System.Drawing.Size(121, 22)
    Me.TemplateStandard.Text = "&Standard"
    '
    'TemplateMini
    '
    Me.TemplateMini.Checked = True
    Me.TemplateMini.CheckState = System.Windows.Forms.CheckState.Checked
    Me.TemplateMini.Name = "TemplateMini"
    Me.TemplateMini.Size = New System.Drawing.Size(121, 22)
    Me.TemplateMini.Text = "&Mini"
    '
    'TexturesToolStripMenuItem
    '
    Me.TexturesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TexturesOpenTexturePackImage, Me.TexturesOpenResourcePack, Me.ToolStripMenuItem2, Me.Textures32, Me.Textures64, Me.Textures128})
    Me.TexturesToolStripMenuItem.Name = "TexturesToolStripMenuItem"
    Me.TexturesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
    Me.TexturesToolStripMenuItem.Text = "Te&xtures"
    '
    'TexturesOpenTexturePackImage
    '
    Me.TexturesOpenTexturePackImage.Name = "TexturesOpenTexturePackImage"
    Me.TexturesOpenTexturePackImage.Size = New System.Drawing.Size(215, 22)
    Me.TexturesOpenTexturePackImage.Text = "Open &TexturePack Image"
    '
    'TexturesOpenResourcePack
    '
    Me.TexturesOpenResourcePack.Name = "TexturesOpenResourcePack"
    Me.TexturesOpenResourcePack.Size = New System.Drawing.Size(215, 22)
    Me.TexturesOpenResourcePack.Text = "Open &ResourcePack Folder"
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(212, 6)
    '
    'Textures32
    '
    Me.Textures32.CheckOnClick = True
    Me.Textures32.Name = "Textures32"
    Me.Textures32.Size = New System.Drawing.Size(215, 22)
    Me.Textures32.Tag = "32"
    Me.Textures32.Text = "32"
    '
    'Textures64
    '
    Me.Textures64.Checked = True
    Me.Textures64.CheckOnClick = True
    Me.Textures64.CheckState = System.Windows.Forms.CheckState.Checked
    Me.Textures64.Name = "Textures64"
    Me.Textures64.Size = New System.Drawing.Size(215, 22)
    Me.Textures64.Tag = "64"
    Me.Textures64.Text = "64"
    '
    'Textures128
    '
    Me.Textures128.CheckOnClick = True
    Me.Textures128.Name = "Textures128"
    Me.Textures128.Size = New System.Drawing.Size(215, 22)
    Me.Textures128.Tag = "128"
    Me.Textures128.Text = "128"
    '
    'HelpToolStripMenuItem
    '
    Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ToolStripMenuItem3, Me.HelpGettingStarted})
    Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
    Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
    Me.HelpToolStripMenuItem.Text = "&Help"
    '
    'AboutToolStripMenuItem
    '
    Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
    Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
    Me.AboutToolStripMenuItem.Text = "&About"
    '
    'ToolStripMenuItem3
    '
    Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    Me.ToolStripMenuItem3.Size = New System.Drawing.Size(150, 6)
    '
    'HelpGettingStarted
    '
    Me.HelpGettingStarted.Name = "HelpGettingStarted"
    Me.HelpGettingStarted.Size = New System.Drawing.Size(153, 22)
    Me.HelpGettingStarted.Text = "&Getting Started"
    '
    'StatusStrip1
    '
    Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel1, Me.StatusLabel2})
    Me.StatusStrip1.Location = New System.Drawing.Point(0, 483)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Size = New System.Drawing.Size(898, 22)
    Me.StatusStrip1.TabIndex = 3
    '
    'StatusLabel1
    '
    Me.StatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.StatusLabel1.Name = "StatusLabel1"
    Me.StatusLabel1.Size = New System.Drawing.Size(0, 17)
    '
    'StatusLabel2
    '
    Me.StatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
    Me.StatusLabel2.Name = "StatusLabel2"
    Me.StatusLabel2.Size = New System.Drawing.Size(0, 17)
    '
    'OpenDesignDialog
    '
    Me.OpenDesignDialog.DefaultExt = "png"
    Me.OpenDesignDialog.Filter = "PNG Images (*.png)|*.png"
    Me.OpenDesignDialog.Title = "Open Design"
    '
    'SaveDesignDialog
    '
    Me.SaveDesignDialog.DefaultExt = "png"
    Me.SaveDesignDialog.Filter = "PNG Image (*.png)|*.png"
    Me.SaveDesignDialog.Title = "Save Design As"
    '
    'OpenResourcePackDialog
    '
    Me.OpenResourcePackDialog.Description = "Please select a Resource Pack textures folder"
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 27)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.AutoScroll = True
    Me.SplitContainer1.Panel1.Controls.Add(Me.TemplatePanel)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.AutoScroll = True
    Me.SplitContainer1.Panel2.Controls.Add(Me.TexturesPanel)
    Me.SplitContainer1.Size = New System.Drawing.Size(898, 453)
    Me.SplitContainer1.SplitterDistance = 307
    Me.SplitContainer1.SplitterWidth = 6
    Me.SplitContainer1.TabIndex = 4
    '
    'TemplatePanel
    '
    Me.TemplatePanel.BackgroundImage = CType(resources.GetObject("TemplatePanel.BackgroundImage"), System.Drawing.Image)
    Me.TemplatePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
    Me.TemplatePanel.Location = New System.Drawing.Point(0, 0)
    Me.TemplatePanel.Margin = New System.Windows.Forms.Padding(0)
    Me.TemplatePanel.Name = "TemplatePanel"
    Me.TemplatePanel.Size = New System.Drawing.Size(300, 200)
    Me.TemplatePanel.TabIndex = 2
    '
    'TexturesPanel
    '
    Me.TexturesPanel.Location = New System.Drawing.Point(0, 0)
    Me.TexturesPanel.Margin = New System.Windows.Forms.Padding(0)
    Me.TexturesPanel.Name = "TexturesPanel"
    Me.TexturesPanel.Size = New System.Drawing.Size(180, 74)
    Me.TexturesPanel.TabIndex = 3
    '
    'OpenTextureDialog
    '
    Me.OpenTextureDialog.DefaultExt = "png"
    Me.OpenTextureDialog.Filter = "PNG Images (*.png)|*.png"
    Me.OpenTextureDialog.Title = "Open TexturePack Image"
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(898, 505)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Controls.Add(Me.StatusStrip1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "MainForm"
    Me.Text = "PaperCraftMini"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.StatusStrip1.ResumeLayout(False)
    Me.StatusStrip1.PerformLayout()
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents FileNew As ToolStripMenuItem
  Friend WithEvents FileSave As ToolStripMenuItem
  Friend WithEvents FileSaveAs As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
  Friend WithEvents FileExit As ToolStripMenuItem
  Friend WithEvents TexturesToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents TexturesOpenTexturePackImage As ToolStripMenuItem
  Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents StatusStrip1 As StatusStrip
  Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
  Friend WithEvents Textures32 As ToolStripMenuItem
  Friend WithEvents Textures64 As ToolStripMenuItem
  Friend WithEvents Textures128 As ToolStripMenuItem
  Friend WithEvents FileOpen As ToolStripMenuItem
  Friend WithEvents OpenDesignDialog As OpenFileDialog
  Friend WithEvents StatusLabel1 As ToolStripStatusLabel
  Friend WithEvents StatusLabel2 As ToolStripStatusLabel
  Friend WithEvents SaveDesignDialog As SaveFileDialog
  Friend WithEvents TexturesOpenResourcePack As ToolStripMenuItem
  Friend WithEvents OpenResourcePackDialog As FolderBrowserDialog
  Friend WithEvents TemplateToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents TemplateStandard As ToolStripMenuItem
  Friend WithEvents TemplateMini As ToolStripMenuItem
  Friend WithEvents SplitContainer1 As SplitContainer
  Friend WithEvents TemplatePanel As Panel
  Friend WithEvents TexturesPanel As Panel
  Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
  Friend WithEvents HelpGettingStarted As ToolStripMenuItem
  Friend WithEvents OpenTextureDialog As OpenFileDialog
End Class
