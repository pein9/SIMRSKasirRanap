Imports System.Windows.Forms
Imports System.Text
Imports Pein

Public Module ExtensionMethods

    ''' <summary>
    ''' Get underlying DataTable
    ''' </summary>
    ''' <param name="pBindingSource"></param>
    ''' <returns></returns>
    ''' <remarks>
    ''' This version does not check if the DataSource is a DataTable.
    ''' </remarks>
    <DebuggerStepThrough()>
    <Runtime.CompilerServices.Extension()>
    Public Function DataTable(ByVal pBindingSource As BindingSource) As DataTable
        Return DirectCast(pBindingSource.DataSource, DataTable)
    End Function
    ''' <summary>
    ''' Locate a value in the DataSource of the BindingSource
    ''' </summary>
    ''' <param name="pBindingSource"></param>
    ''' <param name="pKey"></param>
    ''' <param name="pValue"></param>
    ''' <returns>
    ''' Row index if found, minus 1 if not located.
    ''' </returns>
    ''' <remarks></remarks>
    <DebuggerStepThrough()>
    <Runtime.CompilerServices.Extension()>
    Public Function Locate(ByVal pBindingSource As BindingSource, ByVal pKey As String, ByVal pValue As String) As Integer
        Dim Position As Integer = -1

        Position = pBindingSource.Find(pKey, pValue)
        If Position > -1 Then
            pBindingSource.Position = Position
        End If

        Return Position

    End Function
    <DebuggerStepThrough()>
    <Runtime.CompilerServices.Extension()>
    Public Function CurrentRow(ByVal pBindingSource As BindingSource) As DataRow
        Return DirectCast(pBindingSource.Current, DataRowView).Row
    End Function
    <DebuggerStepThrough()>
    <Runtime.CompilerServices.Extension()>
    Public Function CurrentRowValue(ByVal pBindingSource As BindingSource, ByVal pColumn As String) As String
        Return DirectCast(pBindingSource.Current, DataRowView).Row(pColumn).ToString
    End Function
    <DebuggerStepThrough()>
    <Runtime.CompilerServices.Extension()>
    Public Sub ExpandColumns(ByVal sender As DataGridView)
        For Each col As DataGridViewColumn In sender.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    ''' <summary>
    ''' Get changes for a DataTable
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="PrimaryKeyIndex">Primary auto-incrementing key column index</param>
    ''' <returns></returns>
    ''' <remarks>
    ''' DO NOT Access Deleted table unless you first invoke AcceptChanges on the DataTable.
    ''' Generally we only need to know a) are there any deleted rows and/or the primary key
    ''' of the deleted record(s)
    ''' </remarks>
    <System.Runtime.CompilerServices.Extension>
    Public Function AllChanges(ByVal sender As DataTable, ByVal PrimaryKeyIndex As Integer) As TableChanges
        Dim results = New TableChanges()

        results.Deleted = sender.GetChanges(DataRowState.Deleted)
        results.HasDeleted = results.Deleted IsNot Nothing

        For index = 0 To sender.Rows.Count - 1
            If sender.Rows(index).RowState = DataRowState.Deleted Then
                results.DeletedPrimaryKeys.Add(Convert.ToInt32(sender.Rows(index)(PrimaryKeyIndex, DataRowVersion.Original)))
            End If
        Next index

        results.Modified = sender.GetChanges(DataRowState.Modified)
        results.HasModified = results.Modified IsNot Nothing

        results.Added = sender.GetChanges(DataRowState.Added)
        results.HasNew = results.Added IsNot Nothing

        results.UnChanged = sender.GetChanges(DataRowState.Unchanged)
        results.HasUnchanged = results.UnChanged IsNot Nothing

        results.Any = results.HasDeleted OrElse results.HasModified OrElse results.HasNew

        Return results

    End Function
    ''' <summary>
    ''' Get changes by primary name
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="PrimaryKeyColumnName"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension>
    Public Function AllChanges(ByVal sender As DataTable, ByVal PrimaryKeyColumnName As String) As TableChanges
        Dim PrimaryKeyIndex As Integer = sender.Columns(PrimaryKeyColumnName).Ordinal
        Dim results = sender.AllChanges(PrimaryKeyIndex)

        Return results

    End Function
    ''' <summary>
    ''' Returns a comma delimited string representing all 
    ''' data rows in the table.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension>
    Public Function Flatten(ByVal sender As DataTable) As String
        Dim sb = New StringBuilder()
        For Each row As DataRow In sender.Rows
            sb.AppendLine(String.Join(",", row.ItemArray))
        Next row

        Return sb.ToString()

    End Function
End Module
