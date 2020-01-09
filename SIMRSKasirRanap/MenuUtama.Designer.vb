<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.vsRender = New WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(Me.components)
        Me.VS2015DarkTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblNamaKomputer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnKeluarKembali = New DevComponents.DotNetBar.ButtonX()
        Me.DockPanel = New WeifenLuo.WinFormsUI.Docking.DockPanel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.VS2015LightTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2015LightTheme()
        Me.Pemisah1 = New NJFLib.Controls.CollapsibleSplitter()
        Me.LayoutPanelUtama = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonX7 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.toolBar = New System.Windows.Forms.ToolBar()
        Me.toolBarButtonToggle1 = New System.Windows.Forms.ToolBarButton()
        Me.StatusStrip1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.LayoutPanelUtama.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsRender
        '
        Me.vsRender.DefaultRenderer = Nothing
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblNamaKomputer, Me.lblDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1103, 22)
        Me.StatusStrip1.TabIndex = 46
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblNamaKomputer
        '
        Me.lblNamaKomputer.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaKomputer.Name = "lblNamaKomputer"
        Me.lblNamaKomputer.Size = New System.Drawing.Size(100, 17)
        Me.lblNamaKomputer.Text = "Nama Komputer :"
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.lblDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(988, 17)
        Me.lblDate.Spring = True
        Me.lblDate.Text = "ToolStripStatusLabel1"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(903, 71)
        Me.Panel2.TabIndex = 30
        '
        'btnKeluarKembali
        '
        Me.btnKeluarKembali.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnKeluarKembali.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnKeluarKembali.CustomColorName = "MyColorName"
        Me.btnKeluarKembali.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluarKembali.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluarKembali.Location = New System.Drawing.Point(903, 0)
        Me.btnKeluarKembali.Name = "btnKeluarKembali"
        Me.btnKeluarKembali.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnKeluarKembali.Size = New System.Drawing.Size(200, 71)
        Me.btnKeluarKembali.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnKeluarKembali.TabIndex = 29
        Me.btnKeluarKembali.Text = "ButtonX1"
        Me.btnKeluarKembali.TextColor = System.Drawing.Color.White
        Me.btnKeluarKembali.ThemeAware = True
        '
        'DockPanel
        '
        Me.DockPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockPanel.DockBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.DockPanel.Location = New System.Drawing.Point(0, 71)
        Me.DockPanel.Name = "DockPanel"
        Me.DockPanel.RightToLeftLayout = True
        Me.DockPanel.ShowAutoHideContentOnHover = False
        Me.DockPanel.Size = New System.Drawing.Size(1103, 357)
        Me.DockPanel.SupportDeeplyNestedContent = True
        Me.DockPanel.TabIndex = 47
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Panel2)
        Me.PanelEx1.Controls.Add(Me.btnKeluarKembali)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1103, 71)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 45
        '
        'Pemisah1
        '
        Me.Pemisah1.AnimationDelay = 500
        Me.Pemisah1.AnimationStep = 50
        Me.Pemisah1.BorderStyle3D = System.Windows.Forms.Border3DStyle.Adjust
        Me.Pemisah1.ControlToHide = Me.LayoutPanelUtama
        Me.Pemisah1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pemisah1.ExpandParentForm = True
        Me.Pemisah1.Location = New System.Drawing.Point(0, 354)
        Me.Pemisah1.MinExtra = 20
        Me.Pemisah1.MinSize = 20
        Me.Pemisah1.Name = "CollapsibleSplitter1"
        Me.Pemisah1.TabIndex = 48
        Me.Pemisah1.TabStop = False
        Me.Pemisah1.UseAnimations = True
        Me.Pemisah1.VisualStyle = NJFLib.Controls.VisualStyles.Mozilla
        '
        'LayoutPanelUtama
        '
        Me.LayoutPanelUtama.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.LayoutPanelUtama.ColumnCount = 8
        Me.LayoutPanelUtama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LayoutPanelUtama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.LayoutPanelUtama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.LayoutPanelUtama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.LayoutPanelUtama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.LayoutPanelUtama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.LayoutPanelUtama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.LayoutPanelUtama.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LayoutPanelUtama.Controls.Add(Me.ButtonX7, 6, 0)
        Me.LayoutPanelUtama.Controls.Add(Me.ButtonX6, 5, 0)
        Me.LayoutPanelUtama.Controls.Add(Me.ButtonX4, 4, 0)
        Me.LayoutPanelUtama.Controls.Add(Me.ButtonX3, 3, 0)
        Me.LayoutPanelUtama.Controls.Add(Me.ButtonX2, 2, 0)
        Me.LayoutPanelUtama.Controls.Add(Me.ButtonX1, 1, 0)
        Me.LayoutPanelUtama.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LayoutPanelUtama.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.LayoutPanelUtama.Location = New System.Drawing.Point(0, 362)
        Me.LayoutPanelUtama.Name = "LayoutPanelUtama"
        Me.LayoutPanelUtama.RowCount = 1
        Me.LayoutPanelUtama.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LayoutPanelUtama.Size = New System.Drawing.Size(1103, 66)
        Me.LayoutPanelUtama.TabIndex = 55
        '
        'ButtonX7
        '
        Me.ButtonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX7.CustomColorName = "MyColorName2"
        Me.ButtonX7.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonX7.FadeEffect = False
        Me.ButtonX7.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX7.Location = New System.Drawing.Point(862, 6)
        Me.ButtonX7.Name = "ButtonX7"
        Me.ButtonX7.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonX7.Size = New System.Drawing.Size(144, 54)
        Me.ButtonX7.TabIndex = 46
        Me.ButtonX7.Text = "Total Pembayaran"
        '
        'ButtonX6
        '
        Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX6.CustomColorName = "MyColorName2"
        Me.ButtonX6.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonX6.FadeEffect = False
        Me.ButtonX6.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX6.Location = New System.Drawing.Point(709, 6)
        Me.ButtonX6.Name = "ButtonX6"
        Me.ButtonX6.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonX6.Size = New System.Drawing.Size(144, 54)
        Me.ButtonX6.TabIndex = 45
        Me.ButtonX6.Text = "Obat"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.CustomColorName = "MyColorName2"
        Me.ButtonX4.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonX4.FadeEffect = False
        Me.ButtonX4.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX4.Location = New System.Drawing.Point(556, 6)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonX4.Size = New System.Drawing.Size(144, 54)
        Me.ButtonX4.TabIndex = 42
        Me.ButtonX4.Text = "Radiologi"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.CustomColorName = "MyColorName2"
        Me.ButtonX3.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonX3.FadeEffect = False
        Me.ButtonX3.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX3.Location = New System.Drawing.Point(403, 6)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonX3.Size = New System.Drawing.Size(144, 54)
        Me.ButtonX3.TabIndex = 41
        Me.ButtonX3.Text = "Laboratorium"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.CustomColorName = "MyColorName2"
        Me.ButtonX2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonX2.FadeEffect = False
        Me.ButtonX2.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(250, 6)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonX2.Size = New System.Drawing.Size(144, 54)
        Me.ButtonX2.TabIndex = 40
        Me.ButtonX2.Text = "Tindakan"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.CustomColorName = "MyColorName2"
        Me.ButtonX1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonX1.FadeEffect = False
        Me.ButtonX1.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(97, 6)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonX1.Size = New System.Drawing.Size(144, 54)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 39
        Me.ButtonX1.Text = "Data Pasien"
        '
        'toolBar
        '
        Me.toolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButtonToggle1})
        Me.toolBar.DropDownArrows = True
        Me.toolBar.Location = New System.Drawing.Point(0, 71)
        Me.toolBar.Name = "toolBar"
        Me.toolBar.ShowToolTips = True
        Me.toolBar.Size = New System.Drawing.Size(1103, 28)
        Me.toolBar.TabIndex = 50
        Me.toolBar.Visible = False
        '
        'toolBarButtonToggle1
        '
        Me.toolBarButtonToggle1.ImageIndex = 0
        Me.toolBarButtonToggle1.Name = "toolBarButtonToggle1"
        Me.toolBarButtonToggle1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        Me.toolBarButtonToggle1.ToolTipText = "Toggle the first CollapsibleSplitter"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pemisah1)
        Me.Controls.Add(Me.LayoutPanelUtama)
        Me.Controls.Add(Me.toolBar)
        Me.Controls.Add(Me.DockPanel)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.LayoutPanelUtama.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vsRender As WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender
    Friend WithEvents VS2015DarkTheme1 As WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblNamaKomputer As ToolStripStatusLabel
    Friend WithEvents lblDate As ToolStripStatusLabel
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnKeluarKembali As DevComponents.DotNetBar.ButtonX
    Friend WithEvents DockPanel As WeifenLuo.WinFormsUI.Docking.DockPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents VS2015LightTheme1 As WeifenLuo.WinFormsUI.Docking.VS2015LightTheme
    Friend WithEvents Pemisah1 As NJFLib.Controls.CollapsibleSplitter
    Private WithEvents toolBar As ToolBar
    Private WithEvents toolBarButtonToggle1 As ToolBarButton
    Friend WithEvents LayoutPanelUtama As TableLayoutPanel
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX7 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
End Class
