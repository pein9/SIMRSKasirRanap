Imports System.Net
Imports System.Runtime.InteropServices
Imports WeifenLuo.WinFormsUI.Docking
Imports Pein
Imports Devart.Data.MySql
Imports QueryKasir
Module modTimer
    Private WithEvents TmrCheck As New Timer
    Private connect As New QueryKasir.ConnectionSQL
    Public CekServer As New Pein.DetectServer
    Public connectionDevart As Devart.Data.MySql.MySqlConnection = New Devart.Data.MySql.MySqlConnection(connect.con)
    Public attemptGUI As Integer

    Public Err As New Pein.BaseExceptionsHandler
    Public _Bm As BindingManagerBase


    Public f_Pasien As frmDataPasien
    Public f_Tindakan As frmTindakan
    Public f_Laboratorium As frmLaboratorium
    Public f_Radiologi As frmRadiologi
    Public f_Obat As frmObat


    Public SumList As List(Of Double)

    'Data Pasien
    Public ops As New QueryKasir.Pasien
    Public bsData As New BindingSource
    Public dtPasienRegistrasi As DataTable

    'Data Tindakan
    Public Tind As New QueryKasir.Tindakan
    Public bsTindakan As New BindingSource
    Public dtTindakan As DataTable
    Public dsetTindakan As DataSet

    'Data Lab
    Public Lab As New QueryKasir.Penunjang
    Public bsLab As New BindingSource
    Public dtLab As DataTable
    Public dsetLab As DataSet

    'Data Radiologi
    Public Radiolog As New QueryKasir.Radiologi
    Public bsRadiolog As New BindingSource
    Public dtRadiolog As DataTable
    Public dsetRadiolog As DataSet

    'Data Obat
    Public Medicine As New QueryKasir.Obat
    Public bsObat As New BindingSource
    Public dtObat As DataTable
    Public dsetObat As DataSet


    Public Sub ExtractDataTindakan()
        Try
            Dim TindakanRow As DataRow = CType(bsData.Current, DataRowView).Row
            f_Tindakan.txtNoRM.Text = Nothing
            f_Tindakan.txtNama.Text = Nothing
            f_Tindakan.txtAlamat.Text = Nothing
            f_Tindakan.txtJK.Text = Nothing
            f_Tindakan.txtTempat.Text = Nothing
            f_Tindakan.txtTglLahir.Text = Nothing
            f_Tindakan.txtNoDaftar.Text = Nothing
            f_Tindakan.txtTanggalDaftar.Text = Nothing
            f_Tindakan.txtRawatInap.Text = Nothing
            f_Tindakan.txtKelas.Text = Nothing
            f_Tindakan.txtCaraBayar.Text = Nothing
            f_Tindakan.cboStatus.Text = Nothing
            f_Tindakan.btnProses.Enabled = False
            f_Tindakan.txtNoDaftarRanap.Text = Nothing

            f_Tindakan.txtNoRM.Text = TindakanRow.Field(Of String)("No.RM")

            f_Tindakan.txtNoRM.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ExtractDataLaborat()
        Try
            Dim LabRow As DataRow = CType(bsData.Current, DataRowView).Row
            f_Laboratorium.txtNoRM.Text = Nothing
            f_Laboratorium.txtNama.Text = Nothing
            f_Laboratorium.txtAlamat.Text = Nothing
            f_Laboratorium.txtJK.Text = Nothing
            f_Laboratorium.txtTempat.Text = Nothing
            f_Laboratorium.txtTglLahir.Text = Nothing
            f_Laboratorium.txtNoDaftar.Text = Nothing
            f_Laboratorium.txtTanggalDaftar.Text = Nothing
            f_Laboratorium.txtRawatInap.Text = Nothing
            f_Laboratorium.txtKelas.Text = Nothing
            f_Laboratorium.txtCaraBayar.Text = Nothing
            'f_Laboratorium.cboStatus.Text = Nothing
            'f_Laboratorium.btnProses.Enabled = False
            f_Laboratorium.txtNoDaftarRanap.Text = Nothing

            f_Laboratorium.txtNoRM.Text = LabRow.Field(Of String)("No.RM")

            f_Laboratorium.txtNoRM.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ExtractDataRadiologi()
        Try
            Dim RadiologiRow As DataRow = CType(bsData.Current, DataRowView).Row
            f_Radiologi.txtNoRM.Text = Nothing
            f_Radiologi.txtNama.Text = Nothing
            f_Radiologi.txtAlamat.Text = Nothing
            f_Radiologi.txtJK.Text = Nothing
            f_Radiologi.txtTempat.Text = Nothing
            f_Radiologi.txtTglLahir.Text = Nothing
            f_Radiologi.txtNoDaftar.Text = Nothing
            f_Radiologi.txtTanggalDaftar.Text = Nothing
            f_Radiologi.txtRawatInap.Text = Nothing
            f_Radiologi.txtKelas.Text = Nothing
            f_Radiologi.txtCaraBayar.Text = Nothing
            'f_Laboratorium.cboStatus.Text = Nothing
            'f_Laboratorium.btnProses.Enabled = False
            f_Radiologi.txtNoDaftarRanap.Text = Nothing

            f_Radiologi.txtNoRM.Text = RadiologiRow.Field(Of String)("No.RM")

            f_Radiologi.txtNoRM.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ExtractDataObat()
        Try
            Dim ObatRow As DataRow = CType(bsData.Current, DataRowView).Row
            f_Obat.txtNoRM.Text = Nothing
            f_Obat.txtNama.Text = Nothing
            f_Obat.txtAlamat.Text = Nothing
            f_Obat.txtJK.Text = Nothing
            f_Obat.txtTempat.Text = Nothing
            f_Obat.txtTglLahir.Text = Nothing
            f_Obat.txtNoDaftar.Text = Nothing
            f_Obat.txtTanggalDaftar.Text = Nothing
            f_Obat.txtRawatInap.Text = Nothing
            f_Obat.txtKelas.Text = Nothing
            f_Obat.txtCaraBayar.Text = Nothing
            'f_Laboratorium.cboStatus.Text = Nothing
            'f_Laboratorium.btnProses.Enabled = False
            f_Obat.txtNoDaftarRanap.Text = Nothing

            f_Obat.txtNoRM.Text = ObatRow.Field(Of String)("No.RM")

            f_Obat.txtNoRM.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function Start()
        TmrCheck = New Timer
        TmrCheck.Interval = 100
        TmrCheck.Start()
        Return 0
    End Function
    Private Sub TmrCheck_Tick(sender As Object, e As EventArgs) Handles TmrCheck.Tick
        CekServer.IsConnectedToInternet()

        Dim strIPV4 = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)


        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                strIPV4 = ipheal.ToString()
            End If
        Next

        If CekServer.ServerHidup = True Then
            CekServer.serverStatus = "Online"
            With MenuUtama
                .lblNamaKomputer.Text = Environment.MachineName & " [OS " & My.Computer.Info.OSFullName & " ] - Framework " & Environment.Version.ToString & ", IP Address : " & strIPV4
                .lblDate.Text = "Tanggal Server : " & CekServer.dDate.ToShortDateString & " [Status Server : " & CekServer.serverStatus & " ]"
                .DockPanel.Theme = .VS2015LightTheme1
                .EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, MenuUtama.VS2015LightTheme1)
                .LayoutPanelUtama.BackColor = SystemColors.Control
                .DockPanel.BorderStyle = BorderStyle.None
                .Pemisah1.BackColor = .DockPanel.Theme.ColorPalette.ToolWindowTabUnselected.Background

                If .DockPanel.Theme.ColorPalette IsNot Nothing Then
                    .StatusStrip1.BackColor = .DockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background
                End If
            End With
        Else
            CekServer.serverStatus = "Offline"
            With MenuUtama
                .lblNamaKomputer.Text = Environment.MachineName & " [OS " & My.Computer.Info.OSFullName & " ] - Framework " & Environment.Version.ToString & ", IP Address : " & strIPV4
                .lblDate.Text = "Tanggal tidak terdeteksi [Server : " & CekServer.serverStatus & " ]"
                .DockPanel.Theme = .VS2015DarkTheme1
                .EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, .VS2015DarkTheme1)
                .LayoutPanelUtama.BackColor = .DockPanel.Theme.ColorPalette.MainWindowActive.Background
                .DockPanel.BorderStyle = BorderStyle.None
                .Pemisah1.BackColor = .DockPanel.Theme.ColorPalette.ToolWindowTabUnselected.Background


                If .DockPanel.Theme.ColorPalette IsNot Nothing Then
                    .StatusStrip1.BackColor = .DockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background
                End If

            End With
        End If
    End Sub
End Module
