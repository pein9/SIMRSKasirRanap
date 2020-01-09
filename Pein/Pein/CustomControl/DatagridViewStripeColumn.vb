Imports System
Imports System.Drawing
Imports System.Windows.Forms


Namespace DatagridViewStripeColumn
    Public NotInheritable Class DatagridViewStripeColumn
        Inherits DataGridViewColumn

        Public Sub New()
            CellTemplate = New DatagirdViewStripeCell()
            [ReadOnly] = True
        End Sub
    End Class

    Public Class DatagirdViewStripeCell
        Inherits DataGridViewTextBoxCell

        Protected Overrides Sub Paint(ByVal graphics As System.Drawing.Graphics, ByVal clipBounds As System.Drawing.Rectangle, ByVal cellBounds As System.Drawing.Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)
            Dim cellValue = CStr(value)
            ' Const vertoffset As Integer = 0
            Const horizontaloffset As Integer = 0
            Dim newRect = New Rectangle(cellBounds.X + horizontaloffset, cellBounds.Y + cellBounds.Height - 3, cellBounds.Width, 3)
            graphics.FillRectangle(New SolidBrush(GetColor(cellValue)), newRect)
        End Sub

        Private Sub DrawString(ByVal graphics As Graphics, ByVal cellBounds As Rectangle, ByVal cellState As DataGridViewElementStates, ByVal cellText As String)
            Dim fnt As Font = New Font("Arial", 12, GraphicsUnit.Pixel)
            Dim textSize As SizeF = graphics.MeasureString(cellText, fnt)
            Dim textColor As Color = Color.Black

            If (cellState And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected Then
                textColor = InheritedStyle.SelectionForeColor
            End If

            Using brush As SolidBrush = New SolidBrush(textColor)
                graphics.DrawString(cellText, fnt, brush, cellBounds.X, cellBounds.Y)
            End Using
        End Sub

        Private Shared Function GetColor(ByVal data As String) As Color
            If data = "New" Then
                Return Color.FromArgb(51, 153, 255)
            ElseIf data = "PERMINTAAN" Then
                Return Color.FromArgb(255, 204, 102)
            ElseIf data = "SELESAI" Then
                Return Color.FromArgb(255, 51, 0)
            ElseIf data = "TERIMA" Then
                Return Color.FromArgb(0, 204, 0)
            End If

            Return Color.White
        End Function
    End Class
End Namespace
