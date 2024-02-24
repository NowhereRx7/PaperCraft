''' <summary>
''' Main Form
''' </summary>
''' <author>T. Finster</author>
Public Class MainForm

  Private template As ITemplate
  Private templateBitmap As Image
  Private texturesBitmap As Image
  Private modified As Boolean
  Private saveFilename As String = String.Empty
  Private lastDesignPath As String = String.Empty
  Private lastTexturePath As String = String.Empty
  Private templateSelection As TemplateTarget

  Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    TemplateXX_Click(Me, New EventArgs())
    TexturesNN_Click(Me, New EventArgs())
    FileNew.PerformClick()
  End Sub

  Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    If (modified) Then
      If (Not DiscardPrompt()) Then
        e.Cancel = True
      End If
    End If
  End Sub

#Region "Menu"

  Private Sub FileNew_Click(sender As Object, e As EventArgs) Handles FileNew.Click
    If (modified) Then
      If (Not DiscardPrompt()) Then
        Return
      End If
    End If
    If (templateBitmap IsNot Nothing) Then
      templateBitmap.Dispose()
      templateBitmap = Nothing
    End If
    templateBitmap = template.DefaultBitmap
    modified = False
    saveFilename = String.Empty
    UpdateTemplateImage()
  End Sub

  Private Sub FileOpen_Click(sender As Object, e As EventArgs) Handles FileOpen.Click
    If (modified) Then
      If (Not DiscardPrompt()) Then
        Return
      End If
    End If
    If (Not String.IsNullOrEmpty(lastDesignPath)) AndAlso (IO.Directory.Exists(lastDesignPath)) Then
      OpenDesignDialog.InitialDirectory = lastDesignPath
    End If
    If (OpenDesignDialog.ShowDialog() = DialogResult.OK) Then
      Dim bmp As Bitmap
      Try
        bmp = New Bitmap(Bitmap.FromFile(OpenDesignDialog.FileName))

        'TODO: Handle different template sizes
        Dim mt As New MiniTemplate()
        If (bmp.Size <> mt.ImageSize) Then
          MessageBox.Show(Me, "Image is the wrong dimensions for a PaperCraft Mini design.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
          bmp.Dispose()
          Return
        End If
        If (templateBitmap IsNot Nothing) Then
          templateBitmap.Dispose()
          templateBitmap = Nothing
        End If
        templateBitmap = bmp
        modified = False
        saveFilename = IO.Path.GetFileName(OpenDesignDialog.FileName)
        lastDesignPath = IO.Path.GetDirectoryName(OpenDesignDialog.FileName)
        UpdateTemplateImage()
      Catch ex As Exception
        MessageBox.Show(Me, "Error opening file '" & OpenDesignDialog.FileName & "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If
  End Sub

  Private Sub FileSave_Click(sender As Object, e As EventArgs) Handles FileSave.Click
    If String.IsNullOrEmpty(saveFilename) Then
      FileSaveAs.PerformClick()
      Return
    End If
    Try
      templateBitmap.Save(saveFilename, Imaging.ImageFormat.Png)
      modified = False
    Catch ex As Exception
      MessageBox.Show(Me, "An error occured saving the file." & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub FileSaveAs_Click(sender As Object, e As EventArgs) Handles FileSaveAs.Click
    If (Not String.IsNullOrEmpty(lastDesignPath)) AndAlso (IO.Directory.Exists(lastDesignPath)) Then
      SaveDesignDialog.InitialDirectory = lastDesignPath
    End If
    SaveDesignDialog.FileName = saveFilename
    If (SaveDesignDialog.ShowDialog() = DialogResult.OK) Then
      saveFilename = SaveDesignDialog.FileName
      Try
        templateBitmap.Save(saveFilename, Imaging.ImageFormat.Png)
        saveFilename = IO.Path.GetFileName(SaveDesignDialog.FileName)
        modified = False
        UpdateTemplateImage()
      Catch ex As Exception
        MessageBox.Show(Me, "An error occured saving the file." & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If
  End Sub

  Private Sub FileExit_Click(sender As Object, e As EventArgs) Handles FileExit.Click
    Me.Close()
  End Sub

  Private Sub TemplateXX_Click(sender As Object, e As EventArgs) Handles TemplateMini.Click, TemplateStandard.Click
    If (modified) Then
      If (Not DiscardPrompt()) Then
        Return
      End If
    End If
    If (sender Is TemplateStandard) Then
      'TODO: Standard template
      If (TypeOf template Is StandardTemplate) Then
        Return
      End If
      'My.Settings.Template = "Standard"
    ElseIf (sender Is TemplateMini) Then
      If (TypeOf template Is MiniTemplate) Then
        Return
      End If
      My.Settings.Template = "Mini"
    End If
    If (My.Settings.Template.ToLower = "mini") Then
      template = New MiniTemplate()
    Else
      template = New StandardTemplate
    End If
    TemplateMini.Checked = False
    TemplateStandard.Checked = False
    If (TypeOf template Is MiniTemplate) Then
      TemplateMini.Checked = True
    Else
      TemplateStandard.Checked = True
    End If
    templateBitmap = template.DefaultBitmap
    UpdateTemplateImage()
    SplitContainer1.SplitterDistance = TemplatePanel.Width
  End Sub

  Private Sub TexturesOpenTexturePackImage_Click(sender As Object, e As EventArgs) Handles TexturesOpenTexturePackImage.Click
    If (Not String.IsNullOrEmpty(lastTexturePath)) AndAlso (IO.Directory.Exists(lastTexturePath)) Then
      OpenTextureDialog.InitialDirectory = lastTexturePath
    End If
    If (OpenTextureDialog.ShowDialog() = DialogResult.OK) Then
      Dim bmp As Image
      Try
        bmp = Bitmap.FromFile(OpenTextureDialog.FileName)
        If (bmp.Height Mod 32 <> 0) OrElse (bmp.Width Mod 32 <> 0) Then
          MessageBox.Show(Me, "Image does not appear to be a valid textures file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
          bmp.Dispose()
          Return
        End If
        If (texturesBitmap IsNot Nothing) Then
          texturesBitmap.Dispose()
          texturesBitmap = Nothing
        End If
        lastTexturePath = IO.Path.GetDirectoryName(OpenTextureDialog.FileName)
        texturesBitmap = bmp
        UpdateTexturesImage()
      Catch ex As Exception
        MessageBox.Show(Me, "Error opening file '" & OpenTextureDialog.FileName & "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If
  End Sub

  Private Sub TexturesOpenResourcePack_Click(sender As Object, e As EventArgs) Handles TexturesOpenResourcePack.Click
    If (Not String.IsNullOrEmpty(lastTexturePath)) AndAlso (IO.Directory.Exists(lastTexturePath)) Then
      OpenResourcePackDialog.SelectedPath = lastTexturePath
    End If
    If (OpenResourcePackDialog.ShowDialog() = DialogResult.OK) Then
      Dim dir As New IO.DirectoryInfo(OpenResourcePackDialog.SelectedPath)
      Dim fis() As IO.FileInfo = dir.GetFiles("*.png")
      If (fis.LongLength = 0) Then
        MessageBox.Show(Me, "No PNG files found in folder", "Error loading Resource Pack", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return
      End If
      For Each fi As IO.FileInfo In fis
        'TODO: Load Resource Pack images
      Next
    End If
  End Sub

  Private Sub TexturesNN_Click(sender As Object, e As EventArgs) Handles Textures32.Click, Textures64.Click, Textures128.Click
    Dim newTextureSize As Integer = My.Settings.TextureSize
    Select Case sender.GetType
      Case Textures32.GetType
        newTextureSize = 32
      Case Textures64.GetType
        newTextureSize = 64
      Case Textures128.GetType
        newTextureSize = 128
      Case Else
        newTextureSize = My.Settings.TextureSize
    End Select
    My.Settings.TextureSize = newTextureSize
    Textures32.Checked = False
    Textures64.Checked = False
    Textures128.Checked = False
    Select Case My.Settings.TextureSize
      Case 32
        Textures32.Checked = True
      Case 64
        Textures64.Checked = True
      Case 128
        Textures128.Checked = True
      Case Else
        My.Settings.TextureSize = 64
        Textures64.Checked = True
    End Select
    UpdateTexturesImage()
  End Sub

  Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
    Dim about As AboutBox1 = New AboutBox1()
    about.ShowDialog()
  End Sub

  Private Sub HelpGettingStarted_Click(sender As Object, e As EventArgs) Handles HelpGettingStarted.Click

  End Sub

#End Region

  Private Sub UpdateTemplateImage()
    If (templateBitmap Is Nothing) Then
      Return
    End If
    TemplatePanel.BackgroundImage = templateBitmap
    TemplatePanel.Size = TemplatePanel.BackgroundImage.Size
    TemplatePanel.Refresh()
    If String.IsNullOrEmpty(saveFilename) Then
      Me.Text = My.Application.Info.Title
    Else
      Me.Text = My.Application.Info.Title & " [" & saveFilename & "]"
    End If
  End Sub

  Private Sub UpdateTexturesImage()
    If (texturesBitmap Is Nothing) Then
      Return
    End If
    Dim bmp As Bitmap = New Bitmap(texturesBitmap)
    For y As Integer = My.Settings.TextureSize To (bmp.Height - 1) Step My.Settings.TextureSize
      For x As Integer = 0 To (bmp.Width - 1) Step 2
        Dim c As Color = bmp.GetPixel(x, y)
        Dim nc As Color = Color.FromArgb(c.A, 255 - c.R, 255 - c.G, 255 - c.B)
        bmp.SetPixel(x, y, nc)
      Next
    Next
    For x As Integer = My.Settings.TextureSize To (bmp.Width - 1) Step My.Settings.TextureSize
      For y As Integer = 0 To (bmp.Height - 1) Step 2
        Dim c As Color = bmp.GetPixel(x, y)
        Dim nc As Color = Color.FromArgb(c.A, 255 - c.R, 255 - c.G, 255 - c.B)
        bmp.SetPixel(x, y, nc)
      Next
    Next
    TexturesPanel.BackgroundImage = bmp
    TexturesPanel.Height = bmp.Height
    TexturesPanel.Width = bmp.Width
  End Sub

  Function GetTexture(xIndex As Integer, yIndex As Integer) As Bitmap
    Dim left As Integer = xIndex * My.Settings.TextureSize
    Dim top As Integer = yIndex * My.Settings.TextureSize
    Dim right As Integer = left + (My.Settings.TextureSize)
    Dim bottom As Integer = top + (My.Settings.TextureSize)
    Dim rect As Rectangle = Rectangle.FromLTRB(left, top, right, bottom)
    Try
      Dim bmp As Bitmap = New Bitmap(My.Settings.TextureSize, My.Settings.TextureSize)
      bmp.SetResolution(templateBitmap.HorizontalResolution, templateBitmap.VerticalResolution)
      Using g As Graphics = Graphics.FromImage(bmp)
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        g.DrawImage(texturesBitmap, 0, 0, rect, GraphicsUnit.Pixel)
      End Using
      bmp.Save("C:\Users\Travis\Desktop\test.png")
      Return bmp
    Catch ex As Exception
      Return Nothing
    End Try
  End Function

  Sub PlaceOnTemplate(bmp As Bitmap)
    Dim destRect As Rectangle = template.TemplateTargetToRectangle(templateSelection)
    If (destRect.IsEmpty) Then
      Return
    End If
    Using gr_dest As Graphics = Graphics.FromImage(templateBitmap)
      gr_dest.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
      gr_dest.DrawImage(bmp, destRect)
    End Using
    modified = True
    'templateSelection = TemplateTarget.None
    templateBitmap.Save("C:\Users\Travis\Desktop\template.png", Imaging.ImageFormat.Png)
    UpdateTemplateImage()
  End Sub

  Private Sub TemplatePanel_MouseClick(sender As Object, e As MouseEventArgs) Handles TemplatePanel.MouseClick
    If (e.Button <> MouseButtons.Left) Then
      Return
    End If
    templateSelection = template.PointToTemplateTarget(e.Location)
    'TODO: Draw selection?
    StatusLabel1.Text = String.Format("Selected side: {0}", templateSelection)
  End Sub

  Private Sub TexturesPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles TexturesPanel.MouseClick
    If (e.Button <> MouseButtons.Left) Then
      Return
    End If
    If (texturesBitmap Is Nothing) Then
      Return
    ElseIf (templateSelection = TemplateTarget.None) Then
      Return
    End If
    Dim xIndex As Integer = e.Location.X \ My.Settings.TextureSize
    Dim yIndex As Integer = e.Location.Y \ My.Settings.TextureSize
    'StatusLabel2.Text = String.Format("Last Texture: {0},{1}", xIndex, yIndex)
    Dim bmp As Bitmap = GetTexture(xIndex, yIndex)
    If (bmp IsNot Nothing) Then
      PlaceOnTemplate(bmp)
    End If
  End Sub

  Private Function DiscardPrompt() As Boolean
    Select Case MessageBox.Show(Me, "The current design has been modified; do you wish to save it?", "Save Design", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
      Case DialogResult.Yes
        FileSave.PerformClick()
        Return (Not modified)
      Case DialogResult.No
        Return True
      Case Else
        Return False
    End Select

  End Function

End Class
