Public Interface ITemplate

  ReadOnly Property ImageSize As Size

  ReadOnly Property DefaultBitmap As Image

  Function TemplateTargetToRectangle(target As TemplateTarget) As Rectangle

  Function PointToTemplateTarget(pt As Point) As TemplateTarget

End Interface
