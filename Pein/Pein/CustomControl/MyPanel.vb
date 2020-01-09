Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class MyPanel
    Inherits Panel

    Public Sub New()
        MyBase.Invalidate()
        Me.Padding = New Padding(2)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Using path = New GraphicsPath()
            Dim d = Me.Padding.All
            Dim r = Me.Height - 2 * d
            path.AddArc(d, d, r, r, 90, 180)
            path.AddArc(Me.Width - r - d, d, r, r, -90, 180)
            path.CloseFigure()

            Using pen = New Pen(Color.FromArgb(1, 115, 199), d)
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using
        e.Dispose()
    End Sub

End Class

