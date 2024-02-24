Imports PaperCraft

''' <summary>
''' Template for Mini size designs.
''' </summary>
Public Class MiniTemplate
  Implements ITemplate

  Public Shared ReadOnly Side1Rect As Rectangle = New Rectangle(29, 69, 64, 64)
  Public Shared ReadOnly Side2Rect As Rectangle = New Rectangle(93, 69, 64, 64)
  Public Shared ReadOnly TopRect As Rectangle = New Rectangle(93, 5, 64, 64)
  Public Shared ReadOnly BottomRect As Rectangle = New Rectangle(93, 133, 64, 64)
  Public Shared ReadOnly Side3Rect As Rectangle = New Rectangle(157, 69, 64, 64)
  Public Shared ReadOnly Side4Rect As Rectangle = New Rectangle(221, 69, 64, 64)

  Public ReadOnly Property DefaultBitmap As Image Implements ITemplate.DefaultBitmap
    Get
      Return TryCast(My.Resources.miniTemplate.Clone(), Image)
    End Get
  End Property

  Public ReadOnly Property ImageSize As Size Implements ITemplate.ImageSize
    Get
      Return New Size(300, 200)
    End Get
  End Property

  Public Function TemplateTargetToRectangle(target As TemplateTarget) As Rectangle Implements ITemplate.TemplateTargetToRectangle
    Select Case target
      Case TemplateTarget.Side1
        Return New Rectangle(Side1Rect.Location, Side1Rect.Size)
      Case TemplateTarget.Side2
        Return New Rectangle(Side2Rect.Location, Side2Rect.Size)
      Case TemplateTarget.Top
        Return New Rectangle(TopRect.Location, TopRect.Size)
      Case TemplateTarget.Bottom
        Return New Rectangle(BottomRect.Location, BottomRect.Size)
      Case TemplateTarget.Side3
        Return New Rectangle(Side3Rect.Location, Side3Rect.Size)
      Case TemplateTarget.Side4
        Return New Rectangle(Side4Rect.Location, Side4Rect.Size)
      Case Else
        Return Rectangle.Empty
    End Select
  End Function

  Public Function PointToTemplateTarget(pt As Point) As TemplateTarget Implements ITemplate.PointToTemplateTarget
    If Side1Rect.Contains(pt) Then
      Return TemplateTarget.Side1
    ElseIf Side2Rect.Contains(pt) Then
      Return TemplateTarget.Side2
    ElseIf TopRect.Contains(pt) Then
      Return TemplateTarget.Top
    ElseIf BottomRect.Contains(pt) Then
      Return TemplateTarget.Bottom
    ElseIf Side3Rect.Contains(pt) Then
      Return TemplateTarget.Side3
    ElseIf Side4Rect.Contains(pt) Then
      Return TemplateTarget.Side4
    Else
      Return TemplateTarget.None
    End If
  End Function

End Class
