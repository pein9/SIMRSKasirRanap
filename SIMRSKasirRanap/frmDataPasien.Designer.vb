Imports WeifenLuo.WinFormsUI.Docking
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDataPasien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataPasien))
        Dim Background8 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background9 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding8 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Padding9 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background10 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Background11 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding10 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background12 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding11 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Padding12 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background13 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim Padding13 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Padding14 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding()
        Dim Background14 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.rbRm = New System.Windows.Forms.RadioButton()
        Me.rbNama = New System.Windows.Forms.RadioButton()
        Me.superGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.lblCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.MoveFirst = New System.Windows.Forms.ToolStripButton()
        Me.MovePrev = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtPosition = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MoveNext = New System.Windows.Forms.ToolStripButton()
        Me.MoveLast = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCari = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Font = New System.Drawing.Font("Bauhaus 93", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1068, 49)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackgroundImage = CType(resources.GetObject("PanelEx1.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.Black
        Me.PanelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me.PanelEx1.Style.ForeColor.Color = System.Drawing.Color.WhiteSmoke
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 72
        Me.PanelEx1.Text = "DAFTAR PASIEN RAWAT INAP"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripLabel1.Text = "Pencarian berdasarkan :"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripLabel2.Text = "######################"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'rbRm
        '
        Me.rbRm.BackColor = System.Drawing.Color.Transparent
        Me.rbRm.Checked = True
        Me.rbRm.Location = New System.Drawing.Point(133, 3)
        Me.rbRm.Name = "rbRm"
        Me.rbRm.Size = New System.Drawing.Size(71, 17)
        Me.rbRm.TabIndex = 91
        Me.rbRm.TabStop = True
        Me.rbRm.Text = "No. RM"
        Me.rbRm.UseVisualStyleBackColor = False
        '
        'rbNama
        '
        Me.rbNama.BackColor = System.Drawing.Color.Transparent
        Me.rbNama.Location = New System.Drawing.Point(210, 3)
        Me.rbNama.Name = "rbNama"
        Me.rbNama.Size = New System.Drawing.Size(96, 17)
        Me.rbNama.TabIndex = 92
        Me.rbNama.Text = "Nama Pasien"
        Me.rbNama.UseVisualStyleBackColor = False
        '
        'superGridControl1
        '
        Me.superGridControl1.BackColor = System.Drawing.Color.Red
        Background8.Color1 = System.Drawing.Color.White
        Background8.Color2 = System.Drawing.Color.White
        Me.superGridControl1.DefaultVisualStyles.AlternateColumnCellStyles.Default.Background = Background8
        Me.superGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.superGridControl1.ForeColor = System.Drawing.Color.White
        Me.superGridControl1.Location = New System.Drawing.Point(0, 81)
        Me.superGridControl1.Name = "superGridControl1"
        '
        '
        '
        Me.superGridControl1.PrimaryGrid.AllowEdit = False
        Me.superGridControl1.PrimaryGrid.AutoSelectDeleteBoundRows = False
        Me.superGridControl1.PrimaryGrid.AutoSelectNewBoundRows = False
        Me.superGridControl1.PrimaryGrid.DefaultRowHeight = 0
        Background9.Color1 = System.Drawing.Color.AliceBlue
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Background = Background9
        Padding8.Right = 6
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.ImagePadding = Padding8
        Padding9.Bottom = 6
        Padding9.Left = 6
        Padding9.Right = 6
        Padding9.Top = 6
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Margin = Padding9
        Background10.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.SelectedMouseOver.Background = Background10
        Background11.Color1 = System.Drawing.Color.White
        Background11.Color2 = System.Drawing.Color.White
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Background = Background11
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.TextColor = System.Drawing.Color.Black
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Empty.TextColor = System.Drawing.Color.Black
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Selected.TextColor = System.Drawing.Color.Black
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopLeft
        Padding10.Bottom = 4
        Padding10.Left = 4
        Padding10.Right = 4
        Padding10.Top = 4
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.Margin = Padding10
        Background12.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.SelectedMouseOver.Background = Background12
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.None
        Padding11.Right = 4
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.ImagePadding = Padding11
        Padding12.Bottom = 4
        Padding12.Left = 4
        Padding12.Right = 4
        Padding12.Top = 4
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Margin = Padding12
        Background13.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.SelectedMouseOver.Background = Background13
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Padding13.Right = 6
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.ImagePadding = Padding13
        Padding14.Bottom = 4
        Padding14.Left = 4
        Padding14.Right = 4
        Padding14.Top = 4
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Margin = Padding14
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.TextColor = System.Drawing.Color.Navy
        Background14.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.SelectedMouseOver.Background = Background14
        Me.superGridControl1.PrimaryGrid.ImmediateResize = True
        Me.superGridControl1.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None
        Me.superGridControl1.PrimaryGrid.ReadOnly = True
        Me.superGridControl1.PrimaryGrid.RowDragBehavior = DevComponents.DotNetBar.SuperGrid.RowDragBehavior.Move
        Me.superGridControl1.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.RowWithCellHighlight
        Me.superGridControl1.PrimaryGrid.ShowWhitespaceRowLines = False
        Me.superGridControl1.PrimaryGrid.SizingStyle = DevComponents.DotNetBar.SuperGrid.Style.StyleType.Empty
        Me.superGridControl1.PrimaryGrid.UseAlternateRowStyle = True
        Me.superGridControl1.Size = New System.Drawing.Size(1068, 409)
        Me.superGridControl1.TabIndex = 96
        Me.superGridControl1.Text = "superGridControl1"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Me.lblCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveFirst, Me.MovePrev, Me.BindingNavigatorSeparator3, Me.txtPosition, Me.lblCountItem, Me.BindingNavigatorSeparator4, Me.MoveNext, Me.MoveLast, Me.BindingNavigatorSeparator5})
        Me.BindingNavigator1.Location = New System.Drawing.Point(1, 1)
        Me.BindingNavigator1.MoveFirstItem = Me.MoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.MoveLast
        Me.BindingNavigator1.MoveNextItem = Me.MoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.MovePrev
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.txtPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(592, 30)
        Me.BindingNavigator1.TabIndex = 100
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'lblCountItem
        '
        Me.lblCountItem.Name = "lblCountItem"
        Me.lblCountItem.Size = New System.Drawing.Size(35, 27)
        Me.lblCountItem.Text = "of {0}"
        Me.lblCountItem.ToolTipText = "Total number of items"
        '
        'MoveFirst
        '
        Me.MoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MoveFirst.Image = CType(resources.GetObject("MoveFirst.Image"), System.Drawing.Image)
        Me.MoveFirst.Name = "MoveFirst"
        Me.MoveFirst.RightToLeftAutoMirrorImage = True
        Me.MoveFirst.Size = New System.Drawing.Size(23, 27)
        Me.MoveFirst.Text = "Move first"
        '
        'MovePrev
        '
        Me.MovePrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MovePrev.Image = CType(resources.GetObject("MovePrev.Image"), System.Drawing.Image)
        Me.MovePrev.Name = "MovePrev"
        Me.MovePrev.RightToLeftAutoMirrorImage = True
        Me.MovePrev.Size = New System.Drawing.Size(23, 27)
        Me.MovePrev.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 30)
        Me.BindingNavigatorSeparator3.Visible = False
        '
        'txtPosition
        '
        Me.txtPosition.AccessibleName = "Position"
        Me.txtPosition.AutoSize = False
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(25, 23)
        Me.txtPosition.Text = "0"
        Me.txtPosition.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 30)
        Me.BindingNavigatorSeparator4.Visible = False
        '
        'MoveNext
        '
        Me.MoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MoveNext.Image = CType(resources.GetObject("MoveNext.Image"), System.Drawing.Image)
        Me.MoveNext.Name = "MoveNext"
        Me.MoveNext.RightToLeftAutoMirrorImage = True
        Me.MoveNext.Size = New System.Drawing.Size(23, 27)
        Me.MoveNext.Text = "Move next"
        '
        'MoveLast
        '
        Me.MoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MoveLast.Image = CType(resources.GetObject("MoveLast.Image"), System.Drawing.Image)
        Me.MoveLast.Name = "MoveLast"
        Me.MoveLast.RightToLeftAutoMirrorImage = True
        Me.MoveLast.Size = New System.Drawing.Size(23, 27)
        Me.MoveLast.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.61385!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.38615!))
        Me.TableLayoutPanel1.Controls.Add(Me.BindingNavigator1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 49)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1068, 32)
        Me.TableLayoutPanel1.TabIndex = 101
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCari)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.rbRm)
        Me.Panel1.Controls.Add(Me.rbNama)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(597, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 24)
        Me.Panel1.TabIndex = 101
        '
        'txtCari
        '
        Me.txtCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCari.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCari.Border.Class = "TextBoxBorder"
        Me.txtCari.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCari.DisabledBackColor = System.Drawing.Color.Black
        Me.txtCari.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.ForeColor = System.Drawing.Color.Black
        Me.txtCari.Location = New System.Drawing.Point(312, 1)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.PreventEnterBeep = True
        Me.txtCari.Size = New System.Drawing.Size(152, 23)
        Me.txtCari.TabIndex = 105
        Me.txtCari.WatermarkText = "Tekan Enter untuk Pencarian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Pencarian berdasarkan :"
        '
        'frmDataPasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 490)
        Me.Controls.Add(Me.superGridControl1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PanelEx1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDataPasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Pasien"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents rbRm As RadioButton
    Friend WithEvents rbNama As RadioButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents lblCountItem As ToolStripLabel
    Friend WithEvents MoveFirst As ToolStripButton
    Friend WithEvents MovePrev As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents txtPosition As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents MoveNext As ToolStripButton
    Friend WithEvents MoveLast As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCari As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
End Class
