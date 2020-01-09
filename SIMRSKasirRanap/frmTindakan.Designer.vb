Imports WeifenLuo.WinFormsUI.Docking
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTindakan
    Inherits DockContent
    'Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Padding2 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background3 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background4 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding3 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background5 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding4 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Padding5 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background6 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding6 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Padding7 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background7 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Me.sgTindakan = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTempat = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNama = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAlamat = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJK = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTglLahir = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNoDaftarRanap = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTanggalDaftar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtKelas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCaraBayar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNoDaftar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRawatInap = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNoRM = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.epUser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.VS2015LightTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015LightTheme()
        Me.vsRender = New WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblKet3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnProses = New DevComponents.DotNetBar.ButtonX()
        Me.ExpandablePanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'sgTindakan
        '
        Me.sgTindakan.BackColor = System.Drawing.Color.Red
        Background1.Color1 = System.Drawing.Color.White
        Background1.Color2 = System.Drawing.Color.White
        Me.sgTindakan.DefaultVisualStyles.AlternateColumnCellStyles.Default.Background = Background1
        Me.sgTindakan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sgTindakan.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.sgTindakan.ForeColor = System.Drawing.Color.White
        Me.sgTindakan.Location = New System.Drawing.Point(0, 211)
        Me.sgTindakan.Name = "sgTindakan"
        '
        '
        '
        Me.sgTindakan.PrimaryGrid.AllowEdit = False
        Me.sgTindakan.PrimaryGrid.AutoSelectDeleteBoundRows = False
        Me.sgTindakan.PrimaryGrid.AutoSelectNewBoundRows = False
        Me.sgTindakan.PrimaryGrid.DefaultRowHeight = 0
        Background2.Color1 = System.Drawing.Color.AliceBlue
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Background = Background2
        Padding1.Right = 6
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.ImagePadding = Padding1
        Padding2.Bottom = 6
        Padding2.Left = 6
        Padding2.Right = 6
        Padding2.Top = 6
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Margin = Padding2
        Background3.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.CaptionStyles.SelectedMouseOver.Background = Background3
        Background4.Color1 = System.Drawing.Color.White
        Background4.Color2 = System.Drawing.Color.White
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Background = Background4
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.TextColor = System.Drawing.Color.Black
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopLeft
        Padding3.Bottom = 4
        Padding3.Left = 4
        Padding3.Right = 4
        Padding3.Top = 4
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.Margin = Padding3
        Background5.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.FooterStyles.SelectedMouseOver.Background = Background5
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.None
        Padding4.Right = 4
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.ImagePadding = Padding4
        Padding5.Bottom = 4
        Padding5.Left = 4
        Padding5.Right = 4
        Padding5.Top = 4
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Margin = Padding5
        Background6.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.HeaderStyles.SelectedMouseOver.Background = Background6
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Padding6.Right = 6
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.ImagePadding = Padding6
        Padding7.Bottom = 4
        Padding7.Left = 4
        Padding7.Right = 4
        Padding7.Top = 4
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Margin = Padding7
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.TextColor = System.Drawing.Color.Navy
        Background7.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sgTindakan.PrimaryGrid.DefaultVisualStyles.TitleStyles.SelectedMouseOver.Background = Background7
        Me.sgTindakan.PrimaryGrid.ImmediateResize = True
        Me.sgTindakan.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None
        Me.sgTindakan.PrimaryGrid.ReadOnly = True
        Me.sgTindakan.PrimaryGrid.RowDragBehavior = DevComponents.DotNetBar.SuperGrid.RowDragBehavior.Move
        Me.sgTindakan.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.RowWithCellHighlight
        Me.sgTindakan.PrimaryGrid.ShowWhitespaceRowLines = False
        Me.sgTindakan.PrimaryGrid.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.Empty
        Me.sgTindakan.PrimaryGrid.UseAlternateRowStyle = True
        Me.sgTindakan.Size = New System.Drawing.Size(1195, 298)
        Me.sgTindakan.TabIndex = 101
        Me.sgTindakan.Text = "superGridControl1"
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel1.Controls.Add(Me.Panel1)
        Me.ExpandablePanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ExpandablePanel1.ExpandButtonVisible = False
        Me.ExpandablePanel1.ExpandOnTitleClick = True
        Me.ExpandablePanel1.HideControlsWhenCollapsed = True
        Me.ExpandablePanel1.Location = New System.Drawing.Point(0, 0)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(1195, 211)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ExpandablePanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine
        Me.ExpandablePanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ExpandablePanel1.Style.ForeColor.Color = System.Drawing.Color.WhiteSmoke
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 106
        Me.ExpandablePanel1.TitleHeight = 50
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ExpandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.TitleStyle.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ExpandablePanel1.TitleStyle.Font = New System.Drawing.Font("Bauhaus 93", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.WhiteSmoke
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "DATA TINDAKAN PASIEN RAWAT INAP"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.txtNoRM)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1195, 161)
        Me.Panel1.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.62343!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.37657!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 48)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1193, 111)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtTempat)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtNama)
        Me.Panel2.Controls.Add(Me.txtAlamat)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtJK)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtTglLahir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 105)
        Me.Panel2.TabIndex = 0
        '
        'txtTempat
        '
        Me.txtTempat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTempat.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTempat.Border.Class = "TextBoxBorder"
        Me.txtTempat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTempat.DisabledBackColor = System.Drawing.Color.Black
        Me.txtTempat.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTempat.ForeColor = System.Drawing.Color.Black
        Me.txtTempat.Location = New System.Drawing.Point(243, 68)
        Me.txtTempat.Name = "txtTempat"
        Me.txtTempat.PreventEnterBeep = True
        Me.txtTempat.ReadOnly = True
        Me.txtTempat.Size = New System.Drawing.Size(162, 23)
        Me.txtTempat.TabIndex = 15
        Me.txtTempat.WatermarkText = "Output"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(82, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(37, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Jenis Kelamin :"
        '
        'txtNama
        '
        Me.txtNama.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNama.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNama.Border.Class = "TextBoxBorder"
        Me.txtNama.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNama.DisabledBackColor = System.Drawing.Color.Black
        Me.txtNama.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.ForeColor = System.Drawing.Color.Black
        Me.txtNama.Location = New System.Drawing.Point(133, 10)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.PreventEnterBeep = True
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(352, 23)
        Me.txtNama.TabIndex = 8
        Me.txtNama.WatermarkText = "Output"
        '
        'txtAlamat
        '
        Me.txtAlamat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlamat.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtAlamat.Border.Class = "TextBoxBorder"
        Me.txtAlamat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAlamat.DisabledBackColor = System.Drawing.Color.Black
        Me.txtAlamat.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.ForeColor = System.Drawing.Color.Black
        Me.txtAlamat.Location = New System.Drawing.Point(133, 39)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.PreventEnterBeep = True
        Me.txtAlamat.ReadOnly = True
        Me.txtAlamat.Size = New System.Drawing.Size(352, 23)
        Me.txtAlamat.TabIndex = 10
        Me.txtAlamat.WatermarkText = "Output"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(75, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Alamat :"
        '
        'txtJK
        '
        Me.txtJK.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtJK.Border.Class = "TextBoxBorder"
        Me.txtJK.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJK.DisabledBackColor = System.Drawing.Color.Black
        Me.txtJK.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJK.ForeColor = System.Drawing.Color.Black
        Me.txtJK.Location = New System.Drawing.Point(133, 68)
        Me.txtJK.Name = "txtJK"
        Me.txtJK.PreventEnterBeep = True
        Me.txtJK.ReadOnly = True
        Me.txtJK.Size = New System.Drawing.Size(49, 23)
        Me.txtJK.TabIndex = 13
        Me.txtJK.WatermarkText = "Output"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(207, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "TTL:"
        '
        'txtTglLahir
        '
        Me.txtTglLahir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTglLahir.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTglLahir.Border.Class = "TextBoxBorder"
        Me.txtTglLahir.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTglLahir.DisabledBackColor = System.Drawing.Color.Black
        Me.txtTglLahir.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTglLahir.ForeColor = System.Drawing.Color.Black
        Me.txtTglLahir.Location = New System.Drawing.Point(411, 68)
        Me.txtTglLahir.Name = "txtTglLahir"
        Me.txtTglLahir.PreventEnterBeep = True
        Me.txtTglLahir.ReadOnly = True
        Me.txtTglLahir.Size = New System.Drawing.Size(74, 23)
        Me.txtTglLahir.TabIndex = 16
        Me.txtTglLahir.WatermarkText = "Output"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtNoDaftarRanap)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtTanggalDaftar)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtKelas)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtCaraBayar)
        Me.Panel3.Controls.Add(Me.txtNoDaftar)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtRawatInap)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(595, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(595, 105)
        Me.Panel3.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(3, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 15)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "No Daftar Rawat Inap :"
        '
        'txtNoDaftarRanap
        '
        Me.txtNoDaftarRanap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoDaftarRanap.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNoDaftarRanap.Border.Class = "TextBoxBorder"
        Me.txtNoDaftarRanap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoDaftarRanap.DisabledBackColor = System.Drawing.Color.Black
        Me.txtNoDaftarRanap.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoDaftarRanap.ForeColor = System.Drawing.Color.Black
        Me.txtNoDaftarRanap.Location = New System.Drawing.Point(142, 40)
        Me.txtNoDaftarRanap.Name = "txtNoDaftarRanap"
        Me.txtNoDaftarRanap.PreventEnterBeep = True
        Me.txtNoDaftarRanap.ReadOnly = True
        Me.txtNoDaftarRanap.Size = New System.Drawing.Size(102, 23)
        Me.txtNoDaftarRanap.TabIndex = 28
        Me.txtNoDaftarRanap.WatermarkText = "Output"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(91, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Kelas :"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(68, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "No Daftar :"
        '
        'txtTanggalDaftar
        '
        Me.txtTanggalDaftar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTanggalDaftar.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTanggalDaftar.Border.Class = "TextBoxBorder"
        Me.txtTanggalDaftar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTanggalDaftar.DisabledBackColor = System.Drawing.Color.Black
        Me.txtTanggalDaftar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTanggalDaftar.ForeColor = System.Drawing.Color.Black
        Me.txtTanggalDaftar.Location = New System.Drawing.Point(348, 12)
        Me.txtTanggalDaftar.Name = "txtTanggalDaftar"
        Me.txtTanggalDaftar.PreventEnterBeep = True
        Me.txtTanggalDaftar.ReadOnly = True
        Me.txtTanggalDaftar.Size = New System.Drawing.Size(149, 23)
        Me.txtTanggalDaftar.TabIndex = 20
        Me.txtTanggalDaftar.WatermarkText = "Output"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(273, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Cara Bayar :"
        '
        'txtKelas
        '
        Me.txtKelas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKelas.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtKelas.Border.Class = "TextBoxBorder"
        Me.txtKelas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtKelas.DisabledBackColor = System.Drawing.Color.Black
        Me.txtKelas.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKelas.ForeColor = System.Drawing.Color.Black
        Me.txtKelas.Location = New System.Drawing.Point(142, 71)
        Me.txtKelas.Name = "txtKelas"
        Me.txtKelas.PreventEnterBeep = True
        Me.txtKelas.ReadOnly = True
        Me.txtKelas.Size = New System.Drawing.Size(102, 23)
        Me.txtKelas.TabIndex = 22
        Me.txtKelas.WatermarkText = "Output"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(254, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Tanggal Daftar :"
        '
        'txtCaraBayar
        '
        Me.txtCaraBayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCaraBayar.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCaraBayar.Border.Class = "TextBoxBorder"
        Me.txtCaraBayar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCaraBayar.DisabledBackColor = System.Drawing.Color.Black
        Me.txtCaraBayar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaraBayar.ForeColor = System.Drawing.Color.Black
        Me.txtCaraBayar.Location = New System.Drawing.Point(348, 72)
        Me.txtCaraBayar.Name = "txtCaraBayar"
        Me.txtCaraBayar.PreventEnterBeep = True
        Me.txtCaraBayar.ReadOnly = True
        Me.txtCaraBayar.Size = New System.Drawing.Size(148, 23)
        Me.txtCaraBayar.TabIndex = 24
        Me.txtCaraBayar.WatermarkText = "Output"
        '
        'txtNoDaftar
        '
        Me.txtNoDaftar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoDaftar.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNoDaftar.Border.Class = "TextBoxBorder"
        Me.txtNoDaftar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoDaftar.DisabledBackColor = System.Drawing.Color.Black
        Me.txtNoDaftar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoDaftar.ForeColor = System.Drawing.Color.Black
        Me.txtNoDaftar.Location = New System.Drawing.Point(142, 11)
        Me.txtNoDaftar.Name = "txtNoDaftar"
        Me.txtNoDaftar.PreventEnterBeep = True
        Me.txtNoDaftar.ReadOnly = True
        Me.txtNoDaftar.Size = New System.Drawing.Size(102, 23)
        Me.txtNoDaftar.TabIndex = 18
        Me.txtNoDaftar.WatermarkText = "Output"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(272, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Rawat Inap :"
        '
        'txtRawatInap
        '
        Me.txtRawatInap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRawatInap.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtRawatInap.Border.Class = "TextBoxBorder"
        Me.txtRawatInap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRawatInap.DisabledBackColor = System.Drawing.Color.Black
        Me.txtRawatInap.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRawatInap.ForeColor = System.Drawing.Color.Black
        Me.txtRawatInap.Location = New System.Drawing.Point(348, 40)
        Me.txtRawatInap.Name = "txtRawatInap"
        Me.txtRawatInap.PreventEnterBeep = True
        Me.txtRawatInap.ReadOnly = True
        Me.txtRawatInap.Size = New System.Drawing.Size(149, 23)
        Me.txtRawatInap.TabIndex = 25
        Me.txtRawatInap.WatermarkText = "Output"
        '
        'txtNoRM
        '
        Me.txtNoRM.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNoRM.Border.Class = "TextBoxBorder"
        Me.txtNoRM.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNoRM.DisabledBackColor = System.Drawing.Color.Black
        Me.txtNoRM.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRM.ForeColor = System.Drawing.Color.Black
        Me.txtNoRM.Location = New System.Drawing.Point(136, 13)
        Me.txtNoRM.Name = "txtNoRM"
        Me.txtNoRM.PreventEnterBeep = True
        Me.txtNoRM.Size = New System.Drawing.Size(353, 23)
        Me.txtNoRM.TabIndex = 6
        Me.txtNoRM.WatermarkText = "Tekan Enter untuk Pencarian No.RM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(85, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No.RM :"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Line1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1193, 48)
        Me.Panel4.TabIndex = 7
        '
        'Line1
        '
        Me.Line1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Line1.ForeColor = System.Drawing.Color.Black
        Me.Line1.Location = New System.Drawing.Point(52, 43)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(1078, 8)
        Me.Line1.TabIndex = 0
        Me.Line1.Text = "Line1"
        '
        'epUser
        '
        Me.epUser.ContainerControl = Me
        Me.epUser.RightToLeft = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 539)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1195, 80)
        Me.Panel5.TabIndex = 110
        '
        'vsRender
        '
        Me.vsRender.DefaultRenderer = Nothing
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 619)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1195, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 111
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel7, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblKet3, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel6, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 509)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1195, 30)
        Me.TableLayoutPanel2.TabIndex = 112
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.cboStatus)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(600, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(291, 22)
        Me.Panel7.TabIndex = 11
        '
        'cboStatus
        '
        Me.cboStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"BELUM LUNAS", "LUNAS"})
        Me.cboStatus.Location = New System.Drawing.Point(0, 0)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(291, 21)
        Me.cboStatus.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(291, 28)
        Me.Label11.TabIndex = 7
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKet3
        '
        Me.lblKet3.AutoSize = True
        Me.lblKet3.BackColor = System.Drawing.Color.Transparent
        Me.lblKet3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKet3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKet3.Location = New System.Drawing.Point(302, 1)
        Me.lblKet3.Name = "lblKet3"
        Me.lblKet3.Size = New System.Drawing.Size(291, 28)
        Me.lblKet3.TabIndex = 5
        Me.lblKet3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnProses)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(898, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(293, 22)
        Me.Panel6.TabIndex = 10
        '
        'btnProses
        '
        Me.btnProses.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnProses.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnProses.CustomColorName = "BlueFlat"
        Me.btnProses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProses.Location = New System.Drawing.Point(0, 0)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(293, 22)
        Me.btnProses.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnProses.TabIndex = 0
        Me.btnProses.Text = "Proses"
        '
        'frmTindakan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 641)
        Me.Controls.Add(Me.sgTindakan)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTindakan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Tindakan"
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents sgTindakan As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents txtNoRM As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents Label1 As Label
    Friend WithEvents txtNama As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents Label2 As Label
    Friend WithEvents txtAlamat As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents Label3 As Label
    Friend WithEvents epUser As ErrorProvider
    Friend WithEvents txtTglLahir As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTempat As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents Label4 As Label
    Friend WithEvents txtJK As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents Label5 As Label
    Friend WithEvents txtRawatInap As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCaraBayar As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents Label6 As Label
    Friend WithEvents txtKelas As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents Label7 As Label
    Friend WithEvents txtTanggalDaftar As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents Label8 As Label
    Friend WithEvents txtNoDaftar As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents Label9 As Label
    Private WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Panel5 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents VS2015LightTheme1 As VS2015LightTheme
    Friend WithEvents vsRender As VisualStudioToolStripExtender
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents lblKet3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnProses As DevComponents.DotNetBar.ButtonX
    Private WithEvents Label12 As Label
    Friend WithEvents txtNoDaftarRanap As DevComponents.DotNetBar.Controls.TextBoxX
End Class
