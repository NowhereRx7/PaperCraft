Imports PaperCraft

''' <summary>
''' Template for Standard size designs.
''' </summary>
Public Class StandardTemplate
  Implements ITemplate

  Public ReadOnly Property DefaultBitmap As Image Implements ITemplate.DefaultBitmap
    Get
      Return TryCast(My.Resources.standardTemplate.Clone(), Image)
    End Get
  End Property

  Public ReadOnly Property ImageSize As Size Implements ITemplate.ImageSize
    Get
      Return New Size(600, 500)
    End Get
  End Property

  Public Function PointToTemplateTarget(pt As Point) As TemplateTarget Implements ITemplate.PointToTemplateTarget
    Throw New NotImplementedException()
  End Function

  Public Function TemplateTargetToRectangle(target As TemplateTarget) As Rectangle Implements ITemplate.TemplateTargetToRectangle
    Throw New NotImplementedException()
  End Function
End Class
