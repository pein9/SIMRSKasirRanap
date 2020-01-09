﻿Imports System.Windows.Forms
Namespace DatagridviewNumUpDown
    Public Class NumericUpDownColumnRight
        Inherits DataGridViewColumn
        Public Sub New()
            MyBase.New(New NumericUpDownRightCell())
        End Sub
        Public Overrides Property CellTemplate() As DataGridViewCell
            Get
                Return MyBase.CellTemplate
            End Get
            Set(ByVal value As DataGridViewCell)
                ' Ensure that the cell used for the template is a NumericUpDownCell.
                If Not (value Is Nothing) AndAlso Not value.GetType().IsAssignableFrom(GetType(NumericUpDownRightCell)) Then
                    Throw New InvalidCastException("Must be a NumericUpDown")
                End If
                MyBase.CellTemplate = value
            End Set
        End Property
    End Class
    Public Class NumericUpDownRightCell
        Inherits DataGridViewTextBoxCell
        Public Sub New()
            '
        End Sub
        Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As DataGridViewCellStyle)
            ' Set the value of the editing control to the current cell value.
            MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)
            Dim ctl As NumericUpDownRightEditingControl = CType(DataGridView.EditingControl, NumericUpDownRightEditingControl)
            ctl.Minimum = 1
            ctl.Maximum = 500
            Dim CurrentValue As Decimal = 1
            If Not DBNull.Value.Equals(Me.Value) Then
                If Decimal.TryParse(Me.Value.ToString, CurrentValue) Then
                    ctl.Value = CurrentValue
                End If
            Else
                ctl.Value = 1
            End If
        End Sub
        Public Overrides ReadOnly Property EditType() As Type
            Get
                ' Return the type of the editing contol that NumericUpDownCell uses.
                Return GetType(NumericUpDownRightEditingControl)
            End Get
        End Property
        Public Overrides ReadOnly Property ValueType() As Type
            Get
                ' Return the type of the value that NumericUpDownCell contains.
                Return GetType(Decimal)
            End Get
        End Property
        Public Overrides ReadOnly Property DefaultNewRowValue() As Object
            Get
                ' Use as the current default value.
                Return Nothing
            End Get
        End Property
    End Class
    Class NumericUpDownRightEditingControl
        Inherits NumericUpDown
        Implements IDataGridViewEditingControl
        Private dataGridViewControl As DataGridView
        Private valueIsChanged As Boolean = False
        Private rowIndexNum As Integer
        Public Sub New()
            Me.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        End Sub
        Public Property EditingControlFormattedValue() As Object Implements IDataGridViewEditingControl.EditingControlFormattedValue
            Get
                Return Me.Value.ToString("#.##")
            End Get
            Set(ByVal value As Object)
                If TypeOf value Is Decimal Then
                    Me.Value = Decimal.Parse(CStr(value))
                End If
            End Set
        End Property
        Public Function GetEditingControlFormattedValue(ByVal context As DataGridViewDataErrorContexts) As Object _
        Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
            Return Me.Value.ToString() ' Me.Value.ToString("#.##")
        End Function
        Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As DataGridViewCellStyle) _
        Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
            Me.Font = dataGridViewCellStyle.Font
            Me.ForeColor = dataGridViewCellStyle.ForeColor
            Me.BackColor = dataGridViewCellStyle.BackColor
        End Sub
        Public Property EditingControlRowIndex() As Integer _
        Implements IDataGridViewEditingControl.EditingControlRowIndex
            Get
                Return rowIndexNum
            End Get
            Set(ByVal value As Integer)
                rowIndexNum = value
            End Set
        End Property
        Public Function EditingControlWantsInputKey(ByVal key As Keys, ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
        Implements IDataGridViewEditingControl.EditingControlWantsInputKey
            ' Let the NumericUpDown handle the keys listed.
            Select Case key And Keys.KeyCode
                Case Keys.Left, Keys.Up, Keys.Down, Keys.Right,
                Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp
                    Return True
                Case Else
                    Return False
            End Select
        End Function
        Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
        Implements IDataGridViewEditingControl.PrepareEditingControlForEdit
            ' No preparation needs to be done.
        End Sub
        Public ReadOnly Property RepositionEditingControlOnValueChange() As Boolean Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange
            Get
                Return False
            End Get
        End Property
        Public Property EditingControlDataGridView() As DataGridView Implements IDataGridViewEditingControl.EditingControlDataGridView
            Get
                Return dataGridViewControl
            End Get
            Set(ByVal value As DataGridView)
                dataGridViewControl = value
            End Set
        End Property
        Public Property EditingControlValueChanged() As Boolean Implements IDataGridViewEditingControl.EditingControlValueChanged
            Get
                Return valueIsChanged
            End Get
            Set(ByVal value As Boolean)
                valueIsChanged = value
            End Set
        End Property
        Public ReadOnly Property EditingControlCursor() As Cursor Implements IDataGridViewEditingControl.EditingPanelCursor
            Get
                Return MyBase.Cursor
            End Get
        End Property
        Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs)
            ' Notify the DataGridView that the contents of the cell have changed.
            valueIsChanged = True
            Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
            MyBase.OnValueChanged(eventargs)
        End Sub
    End Class
End Namespace

