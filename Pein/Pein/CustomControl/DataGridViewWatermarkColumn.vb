Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DataGridViewWatermark
    Public Class DataGridViewWatermarkColumn
        Inherits DataGridViewTextBoxColumn

        Public Sub New()
            CellTemplate = New DataGridViewWatermarkCell()
        End Sub

        Public Property WatermarkText As String
            Get

                If (CType(CellTemplate, DataGridViewWatermarkCell)) Is Nothing Then
                    Throw New InvalidOperationException("cell template required")
                End If

                Return (CType(CellTemplate, DataGridViewWatermarkCell)).WatermarkText
            End Get
            Set(ByVal value As String)

                If Me.WatermarkText <> value Then
                    CType(CellTemplate, DataGridViewWatermarkCell).WatermarkText = value

                    If Me.DataGridView IsNot Nothing Then
                        Dim dataGridViewRows As DataGridViewRowCollection = Me.DataGridView.Rows
                        Dim rowCount As Integer = dataGridViewRows.Count

                        For rowIndex As Integer = 0 To rowCount - 1
                            Dim dataGridViewRow As DataGridViewRow = dataGridViewRows.SharedRow(rowIndex)
                            Dim cell As DataGridViewWatermarkCell = TryCast(dataGridViewRow.Cells(Me.Index), DataGridViewWatermarkCell)

                            If cell IsNot Nothing Then
                                cell.WatermarkText = value
                            End If
                        Next
                    End If
                End If
            End Set
        End Property
    End Class

    Public Class DataGridViewWatermarkCell
        Inherits DataGridViewTextBoxCell

        Private watermarkTextValue As String

        Public Property WatermarkText As String
            Get
                Return watermarkTextValue
            End Get
            Set(ByVal value As String)
                watermarkTextValue = value
            End Set
        End Property

        Public Overrides Function Clone() As Object
            Dim cell As DataGridViewWatermarkCell = CType(MyBase.Clone(), DataGridViewWatermarkCell)
            cell.WatermarkText = Me.WatermarkText
            Return cell
        End Function

        Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)
            If Me.RowIndex <> -1 Then
                If (OwningColumn.Site Is Nothing OrElse Not OwningColumn.Site.DesignMode) AndAlso
                (rowIndex < 0 OrElse Not IsInEditMode) AndAlso Not String.IsNullOrEmpty(WatermarkText) AndAlso
                (GetValue(rowIndex) Is Nothing OrElse GetValue(rowIndex) = DBNull.Value) Then
                    cellStyle.Font = New Font(cellStyle.Font, FontStyle.Italic)
                    cellStyle.ForeColor = Color.Gray
                    formattedValue = WatermarkText
                End If
                'To check if the row is being shared, make sure that "this.RowIndex >= 0" in the beginning of the Paint method. (Shared rows have a RowIndex == -1).
                MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)

            End If
        End Sub
    End Class
End Namespace
