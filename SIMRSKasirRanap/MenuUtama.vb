Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Windows.Forms
Imports System.Net
Imports WeifenLuo.WinFormsUI.Docking
Imports System.Runtime.InteropServices
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports Devart.Data.MySql
Imports System.ComponentModel
Imports System.Net.Sockets
Imports System.Drawing.Drawing2D
Imports Devart.Common
Imports System.Threading
Imports Pein
Imports QueryKasir
Imports System.Drawing.Text
Public Class MenuUtama
    Private ReadOnly RenderToolStrip As ToolStripRenderer = New ToolStripProfessionalRenderer()

    Dim DependentScript As New QueryKasir.MyDependency
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AutoScaleMode = AutoScaleMode.Dpi

        BuatStandardControls()
        vsRender.DefaultRenderer = RenderToolStrip
        SetSchema()
        modTimer.Start()
    End Sub
    Protected Sub SkinButtonKeluar()
        Dim table As DevComponents.DotNetBar.Rendering.Office2007ButtonItemColorTable = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemColorTable()
        table.Name = "MyColorName"

        table.Default = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        table.Default.OuterBorder.Start = System.Drawing.Color.Maroon
        table.Default.OuterBorder.End = System.Drawing.Color.OrangeRed
        table.Default.TopBackground.Start = System.Drawing.Color.OrangeRed
        table.Default.TopBackground.End = System.Drawing.Color.OrangeRed
        table.Default.BottomBackground.Start = System.Drawing.Color.OrangeRed
        table.Default.BottomBackground.End = System.Drawing.Color.OrangeRed
        table.Default.BottomBackgroundHighlight.Start = System.Drawing.Color.OrangeRed
        table.Default.BottomBackgroundHighlight.End = System.Drawing.Color.OrangeRed
        table.Default.Text = System.Drawing.Color.OrangeRed


        table.MouseOver = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        table.MouseOver.OuterBorder.Start = System.Drawing.Color.Yellow
        table.MouseOver.OuterBorder.End = System.Drawing.Color.Orange
        table.MouseOver.TopBackground.Start = System.Drawing.Color.Orange
        table.MouseOver.TopBackground.End = System.Drawing.Color.Orange
        table.MouseOver.BottomBackground.Start = System.Drawing.Color.Orange
        table.MouseOver.BottomBackground.End = System.Drawing.Color.Orange
        table.MouseOver.BottomBackgroundHighlight.Start = System.Drawing.Color.Orange
        table.MouseOver.BottomBackgroundHighlight.End = System.Drawing.Color.Orange
        table.MouseOver.Text = System.Drawing.Color.Orange


        table.Pressed = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        table.Pressed.OuterBorder.Start = System.Drawing.Color.Maroon
        table.Pressed.OuterBorder.End = System.Drawing.Color.Black
        table.Pressed.TopBackground.Start = System.Drawing.Color.Yellow
        table.Pressed.TopBackground.End = System.Drawing.Color.OrangeRed
        table.Pressed.BottomBackground.Start = System.Drawing.Color.OrangeRed
        table.Pressed.BottomBackground.End = System.Drawing.Color.DarkOrange
        table.Pressed.BottomBackgroundHighlight.Start = System.Drawing.Color.Yellow
        table.Pressed.BottomBackgroundHighlight.End = System.Drawing.Color.Transparent
        table.Pressed.Text = System.Drawing.Color.Maroon

        If TypeOf (DevComponents.DotNetBar.Rendering.GlobalManager.Renderer) Is DevComponents.DotNetBar.Rendering.Office2007Renderer Then
            Dim r As DevComponents.DotNetBar.Rendering.Office2007Renderer = CType(DevComponents.DotNetBar.Rendering.GlobalManager.Renderer, DevComponents.DotNetBar.Rendering.Office2007Renderer)
            r.ColorTable.ButtonItemColors.Add(table)
        End If


        btnKeluarKembali.Pulse(11)
        btnKeluarKembali.Text = "Keluar"
    End Sub
    Protected Sub SkinButton()
        Dim table As DevComponents.DotNetBar.Rendering.Office2007ButtonItemColorTable = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemColorTable()

        table.Name = "MyColorName2"


        table.Default = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        table.Default.OuterBorder.Start = System.Drawing.Color.FromArgb(1, 115, 199)
        table.Default.OuterBorder.End = System.Drawing.Color.FromArgb(1, 115, 199)
        table.Default.TopBackground.Start = System.Drawing.Color.FromArgb(1, 115, 199)
        table.Default.TopBackground.End = System.Drawing.Color.FromArgb(1, 115, 199)
        table.Default.BottomBackground.Start = System.Drawing.Color.FromArgb(1, 115, 199)
        table.Default.BottomBackground.End = System.Drawing.Color.FromArgb(1, 115, 199)
        table.Default.BottomBackgroundHighlight.Start = System.Drawing.Color.FromArgb(1, 115, 199)
        table.Default.BottomBackgroundHighlight.End = System.Drawing.Color.FromArgb(1, 115, 199)
        table.Default.Text = System.Drawing.Color.White


        table.MouseOver = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        table.MouseOver.OuterBorder.Start = System.Drawing.Color.FromArgb(1, 115, 199)
        table.MouseOver.OuterBorder.End = System.Drawing.Color.FromArgb(1, 115, 199)
        table.MouseOver.TopBackground.Start = System.Drawing.Color.WhiteSmoke
        table.MouseOver.TopBackground.End = System.Drawing.Color.WhiteSmoke
        table.MouseOver.BottomBackground.Start = System.Drawing.Color.WhiteSmoke
        table.MouseOver.BottomBackground.End = System.Drawing.Color.White
        table.MouseOver.BottomBackgroundHighlight.Start = System.Drawing.Color.WhiteSmoke
        table.MouseOver.BottomBackgroundHighlight.End = System.Drawing.Color.WhiteSmoke
        table.MouseOver.Text = System.Drawing.Color.FromArgb(1, 115, 199)

        table.Pressed = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        table.Pressed.OuterBorder.Start = System.Drawing.Color.WhiteSmoke
        table.Pressed.OuterBorder.End = System.Drawing.Color.WhiteSmoke
        table.Pressed.TopBackground.Start = System.Drawing.Color.WhiteSmoke
        table.Pressed.TopBackground.End = System.Drawing.Color.WhiteSmoke
        table.Pressed.BottomBackground.Start = System.Drawing.Color.WhiteSmoke
        table.Pressed.BottomBackground.End = System.Drawing.Color.WhiteSmoke
        table.Pressed.BottomBackgroundHighlight.Start = System.Drawing.Color.WhiteSmoke
        table.Pressed.BottomBackgroundHighlight.End = System.Drawing.Color.WhiteSmoke
        table.Pressed.Text = System.Drawing.Color.OrangeRed

        If TypeOf (DevComponents.DotNetBar.Rendering.GlobalManager.Renderer) Is DevComponents.DotNetBar.Rendering.Office2007Renderer Then
            Dim r As DevComponents.DotNetBar.Rendering.Office2007Renderer = CType(DevComponents.DotNetBar.Rendering.GlobalManager.Renderer, DevComponents.DotNetBar.Rendering.Office2007Renderer)
            r.ColorTable.ButtonItemColors.Add(table)
        End If

        ButtonX1.Text = "Data Pasien"
        ButtonX2.Text = "Tindakan"
        ButtonX3.Text = "Laboratorium"
        ButtonX4.Text = "Radiologi"
        ButtonX6.Text = "Obat"
        ButtonX7.Text = "Total Pembayaran"
    End Sub
    Public Function GetComputerName() As String
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        Return ComputerName
    End Function

#Region "Thema"
    Private Sub SetSchema()

        TutupSemuaContent()

        Me.DockPanel.Theme = VS2015LightTheme1

        Me.EnableVSRenderer(VisualStudioToolStripExtender.VsVersion.Vs2015, VS2015LightTheme1)
        'Me.MenuStrip.BackColor = DockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background

        'Me.toolBar.BackColor = DockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background
        'Me.LayoutPanelUtama.BackColor = SystemColors.Control 'DockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background
        Me.DockPanel.BorderStyle = BorderStyle.None
        Me.Pemisah1.BackColor = DockPanel.Theme.ColorPalette.ToolWindowTabUnselected.Background


        If DockPanel.Theme.ColorPalette IsNot Nothing Then
            StatusStrip1.BackColor = DockPanel.Theme.ColorPalette.MainWindowStatusBarDefault.Background
        End If

    End Sub
    Public Sub EnableVSRenderer(ByVal version As VisualStudioToolStripExtender.VsVersion, ByVal theme As ThemeBase)
        vsRender.SetStyle(StatusStrip1, version, theme)
    End Sub
    Private Sub btnKeluarKembali_Click(sender As Object, e As EventArgs) Handles btnKeluarKembali.Click
        TutupSemuaContent()
        TutupSemuaDokumen()

        If btnKeluarKembali.Text.Trim = "Keluar" Then
            Dim p As String
            p = MsgBox("Apakah anda ingin keluar dari aplikasi?", MsgBoxStyle.YesNo, "Konfimasi")
            If p = vbYes Then Application.Exit()
        End If
    End Sub
#End Region

#Region "Dock"
    Private Sub TutupSemuaDokumen()
        If DockPanel.DocumentStyle = DocumentStyle.SystemMdi Then

            For Each form As Form In MdiChildren
                form.Close()
            Next
        Else

            For Each document As IDockContent In DockPanel.DocumentsToArray()
                document.DockHandler.DockPanel = Nothing
                document.DockHandler.Close()
            Next
        End If
    End Sub
    Private Sub BuatStandardControls()
        f_Pasien = New frmDataPasien()
        f_Tindakan = New frmTindakan()
        f_Laboratorium = New frmLaboratorium()
        f_Radiologi = New frmRadiologi
        f_Obat = New frmObat
    End Sub
    Private Sub TutupSemuaContent()
        f_Pasien.DockPanel = Nothing
        f_Tindakan.DockPanel = Nothing
        f_Laboratorium.DockPanel = Nothing
        f_Radiologi.DockPanel = Nothing
        f_Obat.DockPanel = Nothing
        TutupSemuaDokumen()

        For Each window In DockPanel.FloatWindows.ToList()
            window.Dispose()
        Next
    End Sub
#End Region
    Private Sub toolBar_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles toolBar.ButtonClick
        Select Case toolBar.Buttons.IndexOf(e.Button)
            Case 0
                Me.Pemisah1.ToggleState()
                Me.toolBarButtonToggle1.Pushed = Me.Pemisah1.IsCollapsed
                Me.toolBar.Invalidate()
        End Select
    End Sub
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkinButtonKeluar()
        SkinButton()
        SQLDependencies()
        ButtonX1.PerformClick()
    End Sub

#Region "Dependencies Not Fix Yet"
    Public Sub SQLDependencies()
        connectionDevart.LocalFailover = True
        AddHandler connectionDevart.ConnectionLost, New ConnectionLostEventHandler(AddressOf connection_ConnectionLost)
        connectionDevart.Open()
        Dim cmd As MySqlCommand = New MySqlCommand(DependentScript.SelectDependencyScript, connectionDevart)
        Dim depend As MySqlDependency = New MySqlDependency(cmd, 100)
        AddHandler depend.OnChange, New OnChangeEventHandler(AddressOf dependency_OnChange)
        MySqlDependency.Start(connectionDevart)
    End Sub
    Public Sub connection_ConnectionLost(ByVal sender As Object, ByVal e As ConnectionLostEventArgs)
        Console.WriteLine("AttemptNumber: {0}", e.AttemptNumber)
        If e.Cause = ConnectionLostCause.Connect Then
            If e.Context = ConnectionLostContext.None Then
                e.RetryMode = RetryMode.Reexecute
                Try
                    If e.AttemptNumber < 1000 Then
                        e.RetryMode = RetryMode.Reexecute
                    Else
                        attemptGUI += 1
                        If attemptGUI > 3 Then
                            Dim p = AutoClosingMessageBox.Factory(showMethod:=Function(caption, buttons)
                                                                                  Return MessageBox.Show(Me, "Gagal terhubung dengan server, apakah anda ingin keluar dari aplikasi ?", caption, buttons, MessageBoxIcon.Question)
                                                                              End Function, caption:="Konfimasi")
                            If DialogResult.Yes = p.Show(timeout:=5000, buttons:=MessageBoxButtons.YesNo, defaultResult:=DialogResult.No) Then
                                Application.Exit()
                            End If
                        Else
                            Exit Sub
                        End If
                    End If
                Catch ex As MySqlException
                    MsgBox("Gagal terhubung dengan server : " & ex.ToString)
                End Try
            End If
        Else
            Try
                If e.AttemptNumber < 15 Then
                    e.RetryMode = RetryMode.Reexecute
                Else
                    e.RetryMode = RetryMode.Raise
                    MsgBox("Terputus Dari Server ")
                    Application.Exit()
                End If
            Catch ex As MySqlException
                MsgBox("Gagal terhubung dengan server : " & ex.ToString)
            End Try
        End If
    End Sub
    Private Sub dependency_OnChange(ByVal sender As Object, ByVal e As Devart.Data.MySql.MySqlTableChangeEventArgs)
        ButtonX1.PerformClick()
    End Sub
#End Region

#Region "Collapsed"
    Private Sub Pemisah1_Click(sender As Object, e As EventArgs) Handles Pemisah1.Click
        CekServer.serverStatus = Pemisah1.IsCollapsed
    End Sub
    Private Sub MenuUtama_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
    Private Sub lblDate_TextChanged(sender As Object, e As EventArgs) Handles lblDate.TextChanged
        If CekServer.serverStatus = "Online" Then
            EnableWhenOnline()
        ElseIf CekServer.serverStatus = "Offline" Then
            DisableWhenOffline()
        End If
    End Sub
    Protected Sub DisableWhenOffline()
        Me.Pemisah1.ToggleState()
        Me.toolBarButtonToggle1.Pushed = Me.Pemisah1.IsCollapsed
    End Sub
    Protected Sub EnableWhenOnline()
        If Pemisah1.IsCollapsed Then
            Me.Pemisah1.ToggleState()
            Me.toolBarButtonToggle1.Pushed = Me.Pemisah1.IsCollapsed
            ButtonX1.PerformClick()
        Else
            Exit Sub
        End If
    End Sub
#End Region

#Region "Navigation"
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If (f_Pasien.IsDisposed = True) Then
            f_Pasien = New frmDataPasien()
            f_Pasien.Show(DockPanel)
        Else
            f_Pasien.Show(DockPanel)
        End If
    End Sub
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        ExtractDataTindakan()
        If (f_Tindakan.IsDisposed = True) Then
            f_Tindakan = New frmTindakan()
            f_Tindakan.Show(DockPanel)
        Else
            f_Tindakan.Show(DockPanel)
        End If
    End Sub
    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        ExtractDataLaborat()
        If (f_Laboratorium.IsDisposed = True) Then
            f_Laboratorium = New frmLaboratorium()
            f_Laboratorium.Show(DockPanel)
        Else
            f_Laboratorium.Show(DockPanel)
        End If
    End Sub
    Private Sub ButtonX6_Click(sender As Object, e As EventArgs) Handles ButtonX6.Click
        ExtractDataObat()

        If (f_Obat.IsDisposed = True) Then
            f_Obat = New frmObat()
            f_Obat.Show(DockPanel)
        Else
            f_Obat.Show(DockPanel)
        End If
    End Sub
    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        ExtractDataRadiologi()
        If (f_Radiologi.IsDisposed = True) Then
            f_Radiologi = New frmRadiologi()
            f_Radiologi.Show(DockPanel)
        Else
            f_Radiologi.Show(DockPanel)
        End If
    End Sub
#End Region
End Class