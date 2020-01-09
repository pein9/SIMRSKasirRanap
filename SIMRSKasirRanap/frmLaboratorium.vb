Imports Pein
Imports WeifenLuo.WinFormsUI.Docking
Imports QueryKasir
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports System.Threading
Imports System.ComponentModel
Imports System.Data.Common
Imports Devart.Data.MySql
Imports System.Text
Public Class frmLaboratorium

    Private ops As New QueryKasir.Pasien
    Private ConnectionTemp As New QueryKasir.ConnectionSQL

    Dim Err As New Pein.BaseExceptionsHandler
    Private _Bm As BindingManagerBase

    Dim r As DevComponents.DotNetBar.Rendering.Office2007Renderer = CType(DevComponents.DotNetBar.Rendering.GlobalManager.Renderer, DevComponents.DotNetBar.Rendering.Office2007Renderer)
    Dim tableColorButton As DevComponents.DotNetBar.Rendering.Office2007ButtonItemColorTable = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemColorTable()

    Private _Loading As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Protected Sub SkinButton()

        tableColorButton.Name = "BlueFlat2"

        tableColorButton.Default = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        tableColorButton.Default.OuterBorder.Start = System.Drawing.Color.FromArgb(1, 115, 199)
        tableColorButton.Default.OuterBorder.End = System.Drawing.Color.FromArgb(1, 115, 199)
        tableColorButton.Default.TopBackground.Start = System.Drawing.Color.FromArgb(1, 115, 199)
        tableColorButton.Default.TopBackground.End = System.Drawing.Color.FromArgb(1, 115, 199)
        tableColorButton.Default.BottomBackground.Start = System.Drawing.Color.FromArgb(1, 115, 199)
        tableColorButton.Default.BottomBackground.End = System.Drawing.Color.FromArgb(1, 115, 199)
        tableColorButton.Default.BottomBackgroundHighlight.Start = System.Drawing.Color.FromArgb(1, 115, 199)
        tableColorButton.Default.BottomBackgroundHighlight.End = System.Drawing.Color.FromArgb(1, 115, 199)
        tableColorButton.Default.Text = System.Drawing.Color.White

        tableColorButton.MouseOver = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        tableColorButton.MouseOver.OuterBorder.Start = System.Drawing.Color.FromArgb(1, 115, 199)
        tableColorButton.MouseOver.OuterBorder.End = System.Drawing.Color.FromArgb(1, 115, 199)
        tableColorButton.MouseOver.TopBackground.Start = System.Drawing.Color.WhiteSmoke
        tableColorButton.MouseOver.TopBackground.End = System.Drawing.Color.WhiteSmoke
        tableColorButton.MouseOver.BottomBackground.Start = System.Drawing.Color.WhiteSmoke
        tableColorButton.MouseOver.BottomBackground.End = System.Drawing.Color.White
        tableColorButton.MouseOver.BottomBackgroundHighlight.Start = System.Drawing.Color.WhiteSmoke
        tableColorButton.MouseOver.BottomBackgroundHighlight.End = System.Drawing.Color.WhiteSmoke
        tableColorButton.MouseOver.Text = System.Drawing.Color.FromArgb(1, 115, 199)

        tableColorButton.Pressed = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        tableColorButton.Pressed.OuterBorder.Start = System.Drawing.Color.WhiteSmoke
        tableColorButton.Pressed.OuterBorder.End = System.Drawing.Color.WhiteSmoke
        tableColorButton.Pressed.TopBackground.Start = System.Drawing.Color.WhiteSmoke
        tableColorButton.Pressed.TopBackground.End = System.Drawing.Color.WhiteSmoke
        tableColorButton.Pressed.BottomBackground.Start = System.Drawing.Color.WhiteSmoke
        tableColorButton.Pressed.BottomBackground.End = System.Drawing.Color.WhiteSmoke
        tableColorButton.Pressed.BottomBackgroundHighlight.Start = System.Drawing.Color.WhiteSmoke
        tableColorButton.Pressed.BottomBackgroundHighlight.End = System.Drawing.Color.WhiteSmoke
        tableColorButton.Pressed.Text = System.Drawing.Color.OrangeRed

        If TypeOf (DevComponents.DotNetBar.Rendering.GlobalManager.Renderer) Is DevComponents.DotNetBar.Rendering.Office2007Renderer Then
            r.ColorTable.ButtonItemColors.Add(tableColorButton)
        End If
        btnProses.Text = "Proses"
    End Sub
    Private Sub EnableVSRenderer(ByVal version As VisualStudioToolStripExtender.VsVersion, ByVal theme As ThemeBase)
        vsRender.SetStyle(StatusStrip1, version, theme)
    End Sub
    Private Sub frmLaboratorium_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel5.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator

        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        Panel5.BackColor = VS2015LightTheme1.ColorPalette.ToolWindowSeparator

        If tableColorButton.Name <> "BlueFlat2" Then SkinButton()

        txtNoRM.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtNoRM.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtNoRM.AutoCompleteCustomSource = ops.LoadAutoNoRM

        sgLab.DefaultVisualStyles.GridPanelStyle.Background.Color1 = SystemColors.Control
        sgLab.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.TextColor = Color.Black
        sgLab.PrimaryGrid.UseAlternateRowStyle = False

        sgLab.PrimaryGrid.UseAlternateColumnStyle = True
        sgLab.PrimaryGrid.ShowRowHeaders = False
        sgLab.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill

    End Sub
    Protected Sub LoadNoDaftar()
        Dim columns As GridColumnCollection = sgLab.PrimaryGrid.Columns
        Dim context As Object = Nothing
        dsetLab = Lab.DataLabPasien(txtNoDaftar.Text.Trim)

        sgLab.PrimaryGrid.DataSource = GetPasienDataSet()
        sgLab.PrimaryGrid.DataMember = "Pasien"

        context = DirectCast(GetPasienDataSet(), DataSet).Tables("Pasien")

        UpdateBindings(context)
    End Sub
    Private Sub UpdateBindings(ByVal context As Object)
        cboStatus.DataBindings.Clear()
        If context IsNot Nothing Then
            cboStatus.DataBindings.Add(New Binding("Text", context, "Status"))
        Else
            cboStatus.Text = ""
        End If
    End Sub
    Private Function GetPasienDataSet() As DataSet
        While _Loading = True
            Application.DoEvents()
            Thread.Sleep(200)
        End While

        Return (dsetLab)
    End Function
#Region "Pencarian"
    Protected Sub CariNoRM()
        ops.NoRM = txtNoRM.Text
        If ops.AmbilNoRegistrasi(ops.NoRM) Then
            'pKdBahan = BAHAN.bkdBahan
            txtNama.Text = ops.NamaPasien
            txtAlamat.Text = ops.Alamat
            txtJK.Text = ops.JK
            txtTempat.Text = ops.TempatLahir
            txtTglLahir.Text = ops.TanggalLahir
            txtNoDaftar.Text = ops.NDaftar
            txtTanggalDaftar.Text = ops.TanggalDaftar
            txtRawatInap.Text = ops.NamaRuang
            txtKelas.Text = ops.Kelas
            txtCaraBayar.Text = ops.CaraBayar
            txtNoDaftarRanap.Text = ops.NoDaftarRawatInap
            AmbilTotal()
        End If
    End Sub
#End Region
#Region "Query"
    Protected Sub UpdateStatus()
        Dim ds As New DataSet()
        Dim da As MySqlDataAdapter = New MySqlDataAdapter()
        Using cn As New MySqlConnection With {.ConnectionString = ConnectionTemp.con}
            Using cmd As New MySqlCommand With {.Connection = cn}
                cmd.CommandText = Lab.SelectNoPenunjang()
                cmd.Parameters.AddWithValue("@noRegistrasiPenunjangRanap", Label11.Text)

                da.SelectCommand = cmd

                cmd.CommandText = Lab.UpdateStatusLabPasienRanap

                cmd.Parameters.AddWithValue("@statusPembayaran", cboStatus.Text)
                cmd.Parameters.AddWithValue("@Identifier", Label11.Text)


                da.UpdateCommand = cmd

                da.Fill(ds, "Pasien")

                da.Update(ds, "Pasien")
                dsetLab.Tables("Pasien").AcceptChanges()
            End Using
        End Using
    End Sub
#End Region
#Region "HitungTotal"
    Protected Sub AmbilTotal()
        If Lab.AmbilNoTarifLab(txtNoDaftar.Text.Trim) Then
            lblKet3.Text = "Rp. " & Format(Lab.ToLabTarifTindakan, "N")
        End If
    End Sub
#End Region
    Protected Sub DataKosong()
        txtNoRM.Text = Nothing
        txtNama.Text = Nothing
        txtAlamat.Text = Nothing
        txtJK.Text = Nothing
        txtTempat.Text = Nothing
        txtTglLahir.Text = Nothing
        txtNoDaftar.Text = Nothing
        txtTanggalDaftar.Text = Nothing
        txtRawatInap.Text = Nothing
        txtKelas.Text = Nothing
        txtCaraBayar.Text = Nothing
        cboStatus.Text = Nothing
        btnProses.Enabled = False
        txtNoDaftarRanap.Text = Nothing
    End Sub
    Private Sub txtNoRM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoRM.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub
    Private Sub txtNoRM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNoRM.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            lblKet3.Text = "Rp. 0.0"
            cboStatus.Text = Nothing

            ops.NoRM = txtNoRM.Text
            If ops.isExist(ops.NoRM) Then
                CariNoRM()
                LoadNoDaftar()
                epUser.SetError(txtNoRM, Nothing)
            Else
                epUser.SetError(txtNoRM, "Data bahan ini tidak ada.")
                CariNoRM()
                bsLab.DataSource = Nothing
                'bsLab.Sort = "Tanggal Registrasi DESC" 'ASC
                sgLab.PrimaryGrid.DataSource = bsLab
            End If
        ElseIf e.KeyCode = Keys.Back Then
            DataKosong()
            bsLab.DataSource = Nothing
            ' bsLab.Sort = "Tanggal Registrasi DESC" 'ASC
            sgLab.PrimaryGrid.DataSource = bsLab
            epUser.SetError(txtNoRM, Nothing)
        End If


        Dim bHandled As Boolean = False

        If txtNoRM.Text <> Nothing Then
            If e.KeyCode = Keys.Down Then
                e.Handled = True
                ops.NoRM = txtNoRM.Text
                If ops.isExist(ops.NoRM) Then
                    CariNoRM()
                    LoadNoDaftar()
                    epUser.SetError(txtNoRM, Nothing)
                Else
                    epUser.SetError(txtNoRM, "Data bahan ini tidak ada.")
                    CariNoRM()
                    bsLab.DataSource = Nothing
                    'bsLab.Sort = "Tanggal Registrasi DESC" 'ASC
                    sgLab.PrimaryGrid.DataSource = bsLab
                End If
            ElseIf e.KeyCode = Keys.Up Then
                e.Handled = True
                ops.NoRM = txtNoRM.Text
                If ops.isExist(ops.NoRM) Then
                    CariNoRM()
                    LoadNoDaftar()
                    epUser.SetError(txtNoRM, Nothing)
                Else
                    epUser.SetError(txtNoRM, "Data bahan ini tidak ada.")
                    CariNoRM()
                    bsLab.DataSource = Nothing
                    'bsLab.Sort = "Tanggal Registrasi DESC" 'ASC
                    sgLab.PrimaryGrid.DataSource = bsLab
                End If
            End If
        End If
    End Sub
    Private Sub txtNoRM_TextChanged(sender As Object, e As EventArgs) Handles txtNoRM.TextChanged
        ops.NoRM = txtNoRM.Text
        If ops.isExist(ops.NoRM) Then
            CariNoRM()
            LoadNoDaftar()
            epUser.SetError(txtNoRM, Nothing)
        Else
            epUser.SetError(txtNoRM, "Data bahan ini tidak ada.")
            CariNoRM()
            bsTindakan.DataSource = Nothing
            'bsTindakan.Sort = "Tanggal Registrasi DESC" 'ASC
            sgLab.PrimaryGrid.DataSource = bsTindakan
        End If
    End Sub
    Private Sub UpdateDetailsFooter(ByVal panel As GridPanel)
        If panel.Footer Is Nothing Then
            panel.Footer = New GridFooter()
        End If

        Dim total As Double = TotalRows(panel.Rows)

        panel.Footer.Text = String.Format("Total Rp. <font color=""Black"">{0:N}</font>", total)
        'lblKet3.Text = "Total Rp. " & total
        btnProses.Enabled = True
    End Sub
    Private Function TotalRows(ByVal rows As IEnumerable(Of GridElement)) As Double
        Dim total As Double = 0

        For Each item As GridContainer In rows
            If TypeOf item Is GridRow Then
                Dim row As GridRow = CType(item, GridRow)
                Dim unitPrice As Double = CDbl(IIf(row("TotalTarif").Value Is Nothing, 0R, row("TotalTarif").Value))
                total += unitPrice

                Dim pp As String = CStr(row("No.Registrasi Laboratorium").Value.ToString)
                Label11.Text = pp
            End If

            If item.Rows.Count > 0 Then
                total += TotalRows(item.Rows)
            End If
        Next item


        Return (total)
    End Function
    Private Sub CustomizeDetailsPanel(ByVal panel As GridPanel)
        panel.ColumnHeader.RowHeight = 30

        For Each column As GridColumn In panel.Columns
            column.ReadOnly = True

            column.CellStyles.Default.Background.Color1 = SystemColors.Control
            column.CellStyles.Default.TextColor = Color.Black
            panel.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        Next column

        UpdateDetailsFooter(panel)
    End Sub
    Private Sub sgLab_DataBindingComplete(sender As Object, e As GridDataBindingCompleteEventArgs) Handles sgLab.DataBindingComplete
        Dim panel As GridPanel = e.GridPanel
        ' Panel.GroupByRow.Visible = True
        Select Case panel.DataMember
            Case "Penunjang"
                CustomizeDetailsPanel(panel)
        End Select
    End Sub
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If dsetLab IsNot Nothing Then
            UpdateStatus()
            AmbilTotal()
        End If
    End Sub
    Private Sub frmLaboratorium_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        r.ColorTable.ButtonItemColors.Remove(tableColorButton)
    End Sub
End Class