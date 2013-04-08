<System.ComponentModel.DefaultBindingProperty("Rtf")> _
Public Class MyRichTextBox
    Inherits System.Windows.Forms.RichTextBox

    Public Event RtfChanged As EventHandler

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Me.OnRtfChanged(e)
    End Sub

    Protected Overridable Sub OnRtfChanged(ByVal e As System.EventArgs)
        RaiseEvent RtfChanged(Me, e)
    End Sub

    <System.ComponentModel.Browsable(False), System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public Shadows Property Rtf() As String
        Get
            Return MyBase.Rtf
        End Get
        Set(ByVal value As String)
            MyBase.Rtf = value
        End Set
    End Property
End Class