Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class MyRadioButton
    Inherits RadioButton

    Public Sub New()
        Me.Appearance = System.Windows.Forms.Appearance.Button
        Me.BackColor = Color.Transparent
        Me.TextAlign = ContentAlignment.MiddleCenter
        Me.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatAppearance.BorderColor = Color.RoyalBlue
        Me.FlatAppearance.BorderSize = 2
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Me.OnPaintBackground(e)

        Using path = New GraphicsPath()
            Dim c = e.Graphics.ClipBounds
            Dim r = Me.ClientRectangle
            r.Inflate(-FlatAppearance.BorderSize, -FlatAppearance.BorderSize)
            path.AddEllipse(r)
            e.Graphics.SetClip(path)
            MyBase.OnPaint(e)
            e.Graphics.SetClip(c)
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

            If Me.Checked Then

                Using p = New Pen(FlatAppearance.BorderColor, FlatAppearance.BorderSize)
                    e.Graphics.DrawEllipse(p, r)
                End Using
            End If
        End Using
    End Sub
End Class
