Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports QueryKasir
Imports DevComponents.DotNetBar.SuperGrid
Imports System.ComponentModel

Public Class frmDataPasien
    Inherits DockContent

    Private bs As BindingSource = New BindingSource()
    Private tables As BindingList(Of DataTable) = New BindingList(Of DataTable)()

    Private f_Tindakan As New frmTindakan
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
    Private Sub frmDataPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtPasienRegistrasi = ops.DataRegistrasiPasien

        Dim columns As GridColumnCollection = superGridControl1.PrimaryGrid.Columns

        bsData.DataSource = dtPasienRegistrasi

        superGridControl1.PrimaryGrid.DataSource = bsData
        BindingNavigator1.BindingSource = bsData

        superGridControl1.PrimaryGrid.UseAlternateRowStyle = False
        superGridControl1.PrimaryGrid.UseAlternateColumnStyle = False

        superGridControl1.DefaultVisualStyles.GridPanelStyle.Background.Color1 = SystemColors.Control
        superGridControl1.DefaultVisualStyles.GridPanelStyle.TextColor = Color.Black

        superGridControl1.PrimaryGrid.ShowRowHeaders = False
        superGridControl1.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
    End Sub
    Private Sub rbRm_CheckedChanged(sender As Object, e As EventArgs) Handles rbRm.CheckedChanged
        txtCari.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCari.AutoCompleteCustomSource = ops.LoadAutoNoRM
    End Sub
    Private Sub rbNama_CheckedChanged(sender As Object, e As EventArgs) Handles rbNama.CheckedChanged
        txtCari.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCari.AutoCompleteCustomSource = ops.LoadAutoNama
    End Sub
    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If rbRm.Checked = True Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                If txtCari.Text <> Nothing Then bsData.Filter = "No.RM= '" & txtCari.Text & "'"
            End If
        ElseIf rbNama.Checked = True Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                If txtCari.Text <> Nothing Then bsData.Filter = "Nama= '" & txtCari.Text & "'"
            End If
        End If
    End Sub
    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            If rbRm.Checked = True Then
                If txtCari.Text <> Nothing Then bsData.Filter = "No.RM= '" & txtCari.Text & "'"
            ElseIf rbNama.Checked = True Then
                If txtCari.Text <> Nothing Then bsData.Filter = "Nama= '" & txtCari.Text & "'"
            End If
        End If
    End Sub
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text = Nothing Then bsData.Filter = Nothing
    End Sub


#Region "Extract Data"
    Protected Sub ToTindakan()
        ExtractDataTindakan()
        If (f_Tindakan.IsDisposed = True) Then
            f_Tindakan = New frmTindakan()
            f_Tindakan.Show(DockPanel)
        Else
            f_Tindakan.Show(DockPanel)
        End If
    End Sub
    Private Sub superGridControl1_CellDoubleClick(sender As Object, e As GridCellDoubleClickEventArgs) Handles superGridControl1.CellDoubleClick
        '   If e.GridCell.RowIndex <> -1 Then
        ' ToTindakan()
        ' End If
    End Sub

#End Region
End Class