Imports System.IO

Public Class makepal
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblBackGround As System.Windows.Forms.Label
    Friend WithEvents lblSprites As System.Windows.Forms.Label
    Friend WithEvents lblBG_01 As System.Windows.Forms.Label
    Friend WithEvents lblBG_00 As System.Windows.Forms.Label
    Friend WithEvents lblBG_02 As System.Windows.Forms.Label
    Friend WithEvents lblBG_03 As System.Windows.Forms.Label
    Friend WithEvents lblBG_04 As System.Windows.Forms.Label
    Friend WithEvents lblBG_05 As System.Windows.Forms.Label
    Friend WithEvents lblBG_06 As System.Windows.Forms.Label
    Friend WithEvents lblBG_07 As System.Windows.Forms.Label
    Friend WithEvents lblBG_08 As System.Windows.Forms.Label
    Friend WithEvents lblBG_09 As System.Windows.Forms.Label
    Friend WithEvents lblBG_10 As System.Windows.Forms.Label
    Friend WithEvents lblBG_11 As System.Windows.Forms.Label
    Friend WithEvents lblBG_15 As System.Windows.Forms.Label
    Friend WithEvents lblBG_14 As System.Windows.Forms.Label
    Friend WithEvents lblBG_13 As System.Windows.Forms.Label
    Friend WithEvents lblBG_12 As System.Windows.Forms.Label
    Friend WithEvents lblSP_12 As System.Windows.Forms.Label
    Friend WithEvents lblSP_13 As System.Windows.Forms.Label
    Friend WithEvents lblSP_14 As System.Windows.Forms.Label
    Friend WithEvents lblSP_15 As System.Windows.Forms.Label
    Friend WithEvents lblSP_11 As System.Windows.Forms.Label
    Friend WithEvents lblSP_10 As System.Windows.Forms.Label
    Friend WithEvents lblSP_09 As System.Windows.Forms.Label
    Friend WithEvents lblSP_08 As System.Windows.Forms.Label
    Friend WithEvents lblSP_07 As System.Windows.Forms.Label
    Friend WithEvents lblSP_06 As System.Windows.Forms.Label
    Friend WithEvents lblSP_05 As System.Windows.Forms.Label
    Friend WithEvents lblSP_04 As System.Windows.Forms.Label
    Friend WithEvents lblSP_03 As System.Windows.Forms.Label
    Friend WithEvents lblSP_02 As System.Windows.Forms.Label
    Friend WithEvents lblSP_00 As System.Windows.Forms.Label
    Friend WithEvents lblSP_01 As System.Windows.Forms.Label
    Friend WithEvents lbl0c As System.Windows.Forms.Label
    Friend WithEvents lbl0d As System.Windows.Forms.Label
    Friend WithEvents lbl0e As System.Windows.Forms.Label
    Friend WithEvents lbl0f As System.Windows.Forms.Label
    Friend WithEvents lbl0b As System.Windows.Forms.Label
    Friend WithEvents lbl0a As System.Windows.Forms.Label
    Friend WithEvents lbl09 As System.Windows.Forms.Label
    Friend WithEvents lbl08 As System.Windows.Forms.Label
    Friend WithEvents lbl07 As System.Windows.Forms.Label
    Friend WithEvents lbl06 As System.Windows.Forms.Label
    Friend WithEvents lbl05 As System.Windows.Forms.Label
    Friend WithEvents lbl04 As System.Windows.Forms.Label
    Friend WithEvents lbl03 As System.Windows.Forms.Label
    Friend WithEvents lbl02 As System.Windows.Forms.Label
    Friend WithEvents lbl00 As System.Windows.Forms.Label
    Friend WithEvents lbl01 As System.Windows.Forms.Label
    Friend WithEvents lbl1c As System.Windows.Forms.Label
    Friend WithEvents lbl1d As System.Windows.Forms.Label
    Friend WithEvents lbl1e As System.Windows.Forms.Label
    Friend WithEvents lbl1f As System.Windows.Forms.Label
    Friend WithEvents lbl1b As System.Windows.Forms.Label
    Friend WithEvents lbl1a As System.Windows.Forms.Label
    Friend WithEvents lbl19 As System.Windows.Forms.Label
    Friend WithEvents lbl18 As System.Windows.Forms.Label
    Friend WithEvents lbl17 As System.Windows.Forms.Label
    Friend WithEvents lbl16 As System.Windows.Forms.Label
    Friend WithEvents lbl15 As System.Windows.Forms.Label
    Friend WithEvents lbl14 As System.Windows.Forms.Label
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents lbl2c As System.Windows.Forms.Label
    Friend WithEvents lbl2d As System.Windows.Forms.Label
    Friend WithEvents lbl2e As System.Windows.Forms.Label
    Friend WithEvents lbl2f As System.Windows.Forms.Label
    Friend WithEvents lbl2b As System.Windows.Forms.Label
    Friend WithEvents lbl2a As System.Windows.Forms.Label
    Friend WithEvents lbl29 As System.Windows.Forms.Label
    Friend WithEvents lbl28 As System.Windows.Forms.Label
    Friend WithEvents lbl27 As System.Windows.Forms.Label
    Friend WithEvents lbl26 As System.Windows.Forms.Label
    Friend WithEvents lbl25 As System.Windows.Forms.Label
    Friend WithEvents lbl24 As System.Windows.Forms.Label
    Friend WithEvents lbl23 As System.Windows.Forms.Label
    Friend WithEvents lbl22 As System.Windows.Forms.Label
    Friend WithEvents lbl20 As System.Windows.Forms.Label
    Friend WithEvents lbl21 As System.Windows.Forms.Label
    Friend WithEvents lbl3c As System.Windows.Forms.Label
    Friend WithEvents lbl3d As System.Windows.Forms.Label
    Friend WithEvents lbl3e As System.Windows.Forms.Label
    Friend WithEvents lbl3f As System.Windows.Forms.Label
    Friend WithEvents lbl3b As System.Windows.Forms.Label
    Friend WithEvents lbl3a As System.Windows.Forms.Label
    Friend WithEvents lbl39 As System.Windows.Forms.Label
    Friend WithEvents lbl38 As System.Windows.Forms.Label
    Friend WithEvents lbl37 As System.Windows.Forms.Label
    Friend WithEvents lbl36 As System.Windows.Forms.Label
    Friend WithEvents lbl35 As System.Windows.Forms.Label
    Friend WithEvents lbl34 As System.Windows.Forms.Label
    Friend WithEvents lbl33 As System.Windows.Forms.Label
    Friend WithEvents lbl32 As System.Windows.Forms.Label
    Friend WithEvents lbl30 As System.Windows.Forms.Label
    Friend WithEvents lbl31 As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents lbl0_side As System.Windows.Forms.Label
    Friend WithEvents lbl1_side As System.Windows.Forms.Label
    Friend WithEvents lbl2_side As System.Windows.Forms.Label
    Friend WithEvents lbl3_side As System.Windows.Forms.Label
    Friend WithEvents lbl0_top As System.Windows.Forms.Label
    Friend WithEvents lbl1_top As System.Windows.Forms.Label
    Friend WithEvents lbl2_top As System.Windows.Forms.Label
    Friend WithEvents lbl3_top As System.Windows.Forms.Label
    Friend WithEvents lbl4_top As System.Windows.Forms.Label
    Friend WithEvents lbl5_top As System.Windows.Forms.Label
    Friend WithEvents lbl6_top As System.Windows.Forms.Label
    Friend WithEvents lbl7_top As System.Windows.Forms.Label
    Friend WithEvents lbl8_top As System.Windows.Forms.Label
    Friend WithEvents lbl9_top As System.Windows.Forms.Label
    Friend WithEvents lbla_top As System.Windows.Forms.Label
    Friend WithEvents lblb_top As System.Windows.Forms.Label
    Friend WithEvents lblc_top As System.Windows.Forms.Label
    Friend WithEvents lbld_top As System.Windows.Forms.Label
    Friend WithEvents lble_top As System.Windows.Forms.Label
    Friend WithEvents lblf_top As System.Windows.Forms.Label
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents tipTool As System.Windows.Forms.ToolTip
    Friend WithEvents lblHidden As System.Windows.Forms.Label
    Friend WithEvents rchData As System.Windows.Forms.RichTextBox
    Friend WithEvents txtLabel As System.Windows.Forms.TextBox
    Friend WithEvents lblDivider As System.Windows.Forms.Label
    Friend WithEvents lblLabel As System.Windows.Forms.Label
    Friend WithEvents btnGetTable As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblSDS As System.Windows.Forms.LinkLabel
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
				Me.components = New System.ComponentModel.Container()
				Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(makepal))
				Me.lblBackGround = New System.Windows.Forms.Label()
				Me.lblSprites = New System.Windows.Forms.Label()
				Me.lblBG_01 = New System.Windows.Forms.Label()
				Me.lblBG_00 = New System.Windows.Forms.Label()
				Me.lblBG_02 = New System.Windows.Forms.Label()
				Me.lblBG_03 = New System.Windows.Forms.Label()
				Me.lblBG_04 = New System.Windows.Forms.Label()
				Me.lblBG_05 = New System.Windows.Forms.Label()
				Me.lblBG_06 = New System.Windows.Forms.Label()
				Me.lblBG_07 = New System.Windows.Forms.Label()
				Me.lblBG_08 = New System.Windows.Forms.Label()
				Me.lblBG_09 = New System.Windows.Forms.Label()
				Me.lblBG_10 = New System.Windows.Forms.Label()
				Me.lblBG_11 = New System.Windows.Forms.Label()
				Me.lblBG_15 = New System.Windows.Forms.Label()
				Me.lblBG_14 = New System.Windows.Forms.Label()
				Me.lblBG_13 = New System.Windows.Forms.Label()
				Me.lblBG_12 = New System.Windows.Forms.Label()
				Me.lblSP_12 = New System.Windows.Forms.Label()
				Me.lblSP_13 = New System.Windows.Forms.Label()
				Me.lblSP_14 = New System.Windows.Forms.Label()
				Me.lblSP_15 = New System.Windows.Forms.Label()
				Me.lblSP_11 = New System.Windows.Forms.Label()
				Me.lblSP_10 = New System.Windows.Forms.Label()
				Me.lblSP_09 = New System.Windows.Forms.Label()
				Me.lblSP_08 = New System.Windows.Forms.Label()
				Me.lblSP_07 = New System.Windows.Forms.Label()
				Me.lblSP_06 = New System.Windows.Forms.Label()
				Me.lblSP_05 = New System.Windows.Forms.Label()
				Me.lblSP_04 = New System.Windows.Forms.Label()
				Me.lblSP_03 = New System.Windows.Forms.Label()
				Me.lblSP_02 = New System.Windows.Forms.Label()
				Me.lblSP_00 = New System.Windows.Forms.Label()
				Me.lblSP_01 = New System.Windows.Forms.Label()
				Me.lbl0c = New System.Windows.Forms.Label()
				Me.lbl0d = New System.Windows.Forms.Label()
				Me.lbl0e = New System.Windows.Forms.Label()
				Me.lbl0f = New System.Windows.Forms.Label()
				Me.lbl0b = New System.Windows.Forms.Label()
				Me.lbl0a = New System.Windows.Forms.Label()
				Me.lbl09 = New System.Windows.Forms.Label()
				Me.lbl08 = New System.Windows.Forms.Label()
				Me.lbl07 = New System.Windows.Forms.Label()
				Me.lbl06 = New System.Windows.Forms.Label()
				Me.lbl05 = New System.Windows.Forms.Label()
				Me.lbl04 = New System.Windows.Forms.Label()
				Me.lbl03 = New System.Windows.Forms.Label()
				Me.lbl02 = New System.Windows.Forms.Label()
				Me.lbl00 = New System.Windows.Forms.Label()
				Me.lbl01 = New System.Windows.Forms.Label()
				Me.lbl1c = New System.Windows.Forms.Label()
				Me.lbl1d = New System.Windows.Forms.Label()
				Me.lbl1e = New System.Windows.Forms.Label()
				Me.lbl1f = New System.Windows.Forms.Label()
				Me.lbl1b = New System.Windows.Forms.Label()
				Me.lbl1a = New System.Windows.Forms.Label()
				Me.lbl19 = New System.Windows.Forms.Label()
				Me.lbl18 = New System.Windows.Forms.Label()
				Me.lbl17 = New System.Windows.Forms.Label()
				Me.lbl16 = New System.Windows.Forms.Label()
				Me.lbl15 = New System.Windows.Forms.Label()
				Me.lbl14 = New System.Windows.Forms.Label()
				Me.lbl13 = New System.Windows.Forms.Label()
				Me.lbl12 = New System.Windows.Forms.Label()
				Me.lbl10 = New System.Windows.Forms.Label()
				Me.lbl11 = New System.Windows.Forms.Label()
				Me.lbl2c = New System.Windows.Forms.Label()
				Me.lbl2d = New System.Windows.Forms.Label()
				Me.lbl2e = New System.Windows.Forms.Label()
				Me.lbl2f = New System.Windows.Forms.Label()
				Me.lbl2b = New System.Windows.Forms.Label()
				Me.lbl2a = New System.Windows.Forms.Label()
				Me.lbl29 = New System.Windows.Forms.Label()
				Me.lbl28 = New System.Windows.Forms.Label()
				Me.lbl27 = New System.Windows.Forms.Label()
				Me.lbl26 = New System.Windows.Forms.Label()
				Me.lbl25 = New System.Windows.Forms.Label()
				Me.lbl24 = New System.Windows.Forms.Label()
				Me.lbl23 = New System.Windows.Forms.Label()
				Me.lbl22 = New System.Windows.Forms.Label()
				Me.lbl20 = New System.Windows.Forms.Label()
				Me.lbl21 = New System.Windows.Forms.Label()
				Me.lbl3c = New System.Windows.Forms.Label()
				Me.lbl3d = New System.Windows.Forms.Label()
				Me.lbl3e = New System.Windows.Forms.Label()
				Me.lbl3f = New System.Windows.Forms.Label()
				Me.lbl3b = New System.Windows.Forms.Label()
				Me.lbl3a = New System.Windows.Forms.Label()
				Me.lbl39 = New System.Windows.Forms.Label()
				Me.lbl38 = New System.Windows.Forms.Label()
				Me.lbl37 = New System.Windows.Forms.Label()
				Me.lbl36 = New System.Windows.Forms.Label()
				Me.lbl35 = New System.Windows.Forms.Label()
				Me.lbl34 = New System.Windows.Forms.Label()
				Me.lbl33 = New System.Windows.Forms.Label()
				Me.lbl32 = New System.Windows.Forms.Label()
				Me.lbl30 = New System.Windows.Forms.Label()
				Me.lbl31 = New System.Windows.Forms.Label()
				Me.lblValue = New System.Windows.Forms.Label()
				Me.lbl0_side = New System.Windows.Forms.Label()
				Me.lbl1_side = New System.Windows.Forms.Label()
				Me.lbl2_side = New System.Windows.Forms.Label()
				Me.lbl3_side = New System.Windows.Forms.Label()
				Me.lbl0_top = New System.Windows.Forms.Label()
				Me.lbl1_top = New System.Windows.Forms.Label()
				Me.lbl2_top = New System.Windows.Forms.Label()
				Me.lbl3_top = New System.Windows.Forms.Label()
				Me.lbl4_top = New System.Windows.Forms.Label()
				Me.lbl5_top = New System.Windows.Forms.Label()
				Me.lbl6_top = New System.Windows.Forms.Label()
				Me.lbl7_top = New System.Windows.Forms.Label()
				Me.lbl8_top = New System.Windows.Forms.Label()
				Me.lbl9_top = New System.Windows.Forms.Label()
				Me.lbla_top = New System.Windows.Forms.Label()
				Me.lblb_top = New System.Windows.Forms.Label()
				Me.lblc_top = New System.Windows.Forms.Label()
				Me.lbld_top = New System.Windows.Forms.Label()
				Me.lble_top = New System.Windows.Forms.Label()
				Me.lblf_top = New System.Windows.Forms.Label()
				Me.lblSelected = New System.Windows.Forms.Label()
				Me.tipTool = New System.Windows.Forms.ToolTip(Me.components)
				Me.lblAbout = New System.Windows.Forms.Label()
				Me.lblSDS = New System.Windows.Forms.LinkLabel()
				Me.lblHidden = New System.Windows.Forms.Label()
				Me.rchData = New System.Windows.Forms.RichTextBox()
				Me.txtLabel = New System.Windows.Forms.TextBox()
				Me.lblDivider = New System.Windows.Forms.Label()
				Me.lblLabel = New System.Windows.Forms.Label()
				Me.btnGetTable = New System.Windows.Forms.Button()
				Me.btnExit = New System.Windows.Forms.Button()
				Me.btnClear = New System.Windows.Forms.Button()
				Me.SuspendLayout()
				'
				'lblBackGround
				'
				Me.lblBackGround.Location = New System.Drawing.Point(8, 8)
				Me.lblBackGround.Name = "lblBackGround"
				Me.lblBackGround.Size = New System.Drawing.Size(96, 16)
				Me.lblBackGround.TabIndex = 0
				Me.lblBackGround.Text = "Background Sets"
				'
				'lblSprites
				'
				Me.lblSprites.Location = New System.Drawing.Point(8, 64)
				Me.lblSprites.Name = "lblSprites"
				Me.lblSprites.Size = New System.Drawing.Size(64, 16)
				Me.lblSprites.TabIndex = 1
				Me.lblSprites.Text = "Sprite Sets"
				'
				'lblBG_01
				'
				Me.lblBG_01.BackColor = System.Drawing.Color.Black
				Me.lblBG_01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_01.Location = New System.Drawing.Point(48, 32)
				Me.lblBG_01.Name = "lblBG_01"
				Me.lblBG_01.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_01.TabIndex = 2
				Me.tipTool.SetToolTip(Me.lblBG_01, "$0f")
				'
				'lblBG_00
				'
				Me.lblBG_00.BackColor = System.Drawing.Color.Black
				Me.lblBG_00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_00.Location = New System.Drawing.Point(16, 32)
				Me.lblBG_00.Name = "lblBG_00"
				Me.lblBG_00.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_00.TabIndex = 3
				Me.tipTool.SetToolTip(Me.lblBG_00, "$0f")
				'
				'lblBG_02
				'
				Me.lblBG_02.BackColor = System.Drawing.Color.Black
				Me.lblBG_02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_02.Location = New System.Drawing.Point(80, 32)
				Me.lblBG_02.Name = "lblBG_02"
				Me.lblBG_02.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_02.TabIndex = 4
				Me.tipTool.SetToolTip(Me.lblBG_02, "$0f")
				'
				'lblBG_03
				'
				Me.lblBG_03.BackColor = System.Drawing.Color.Black
				Me.lblBG_03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_03.Location = New System.Drawing.Point(112, 32)
				Me.lblBG_03.Name = "lblBG_03"
				Me.lblBG_03.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_03.TabIndex = 5
				Me.tipTool.SetToolTip(Me.lblBG_03, "$0f")
				'
				'lblBG_04
				'
				Me.lblBG_04.BackColor = System.Drawing.Color.Black
				Me.lblBG_04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_04.Location = New System.Drawing.Point(160, 32)
				Me.lblBG_04.Name = "lblBG_04"
				Me.lblBG_04.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_04.TabIndex = 6
				Me.tipTool.SetToolTip(Me.lblBG_04, "$0f")
				'
				'lblBG_05
				'
				Me.lblBG_05.BackColor = System.Drawing.Color.Black
				Me.lblBG_05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_05.Location = New System.Drawing.Point(192, 32)
				Me.lblBG_05.Name = "lblBG_05"
				Me.lblBG_05.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_05.TabIndex = 7
				Me.tipTool.SetToolTip(Me.lblBG_05, "$0f")
				'
				'lblBG_06
				'
				Me.lblBG_06.BackColor = System.Drawing.Color.Black
				Me.lblBG_06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_06.Location = New System.Drawing.Point(224, 32)
				Me.lblBG_06.Name = "lblBG_06"
				Me.lblBG_06.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_06.TabIndex = 8
				Me.tipTool.SetToolTip(Me.lblBG_06, "$0f")
				'
				'lblBG_07
				'
				Me.lblBG_07.BackColor = System.Drawing.Color.Black
				Me.lblBG_07.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_07.Location = New System.Drawing.Point(256, 32)
				Me.lblBG_07.Name = "lblBG_07"
				Me.lblBG_07.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_07.TabIndex = 9
				Me.tipTool.SetToolTip(Me.lblBG_07, "$0f")
				'
				'lblBG_08
				'
				Me.lblBG_08.BackColor = System.Drawing.Color.Black
				Me.lblBG_08.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_08.Location = New System.Drawing.Point(304, 32)
				Me.lblBG_08.Name = "lblBG_08"
				Me.lblBG_08.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_08.TabIndex = 10
				Me.tipTool.SetToolTip(Me.lblBG_08, "$0f")
				'
				'lblBG_09
				'
				Me.lblBG_09.BackColor = System.Drawing.Color.Black
				Me.lblBG_09.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_09.Location = New System.Drawing.Point(336, 32)
				Me.lblBG_09.Name = "lblBG_09"
				Me.lblBG_09.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_09.TabIndex = 11
				Me.tipTool.SetToolTip(Me.lblBG_09, "$0f")
				'
				'lblBG_10
				'
				Me.lblBG_10.BackColor = System.Drawing.Color.Black
				Me.lblBG_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_10.Location = New System.Drawing.Point(368, 32)
				Me.lblBG_10.Name = "lblBG_10"
				Me.lblBG_10.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_10.TabIndex = 12
				Me.tipTool.SetToolTip(Me.lblBG_10, "$0f")
				'
				'lblBG_11
				'
				Me.lblBG_11.BackColor = System.Drawing.Color.Black
				Me.lblBG_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_11.Location = New System.Drawing.Point(400, 32)
				Me.lblBG_11.Name = "lblBG_11"
				Me.lblBG_11.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_11.TabIndex = 13
				Me.tipTool.SetToolTip(Me.lblBG_11, "$0f")
				'
				'lblBG_15
				'
				Me.lblBG_15.BackColor = System.Drawing.Color.Black
				Me.lblBG_15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_15.Location = New System.Drawing.Point(544, 32)
				Me.lblBG_15.Name = "lblBG_15"
				Me.lblBG_15.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_15.TabIndex = 14
				Me.tipTool.SetToolTip(Me.lblBG_15, "$0f")
				'
				'lblBG_14
				'
				Me.lblBG_14.BackColor = System.Drawing.Color.Black
				Me.lblBG_14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_14.Location = New System.Drawing.Point(512, 32)
				Me.lblBG_14.Name = "lblBG_14"
				Me.lblBG_14.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_14.TabIndex = 15
				Me.tipTool.SetToolTip(Me.lblBG_14, "$0f")
				'
				'lblBG_13
				'
				Me.lblBG_13.BackColor = System.Drawing.Color.Black
				Me.lblBG_13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_13.Location = New System.Drawing.Point(480, 32)
				Me.lblBG_13.Name = "lblBG_13"
				Me.lblBG_13.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_13.TabIndex = 16
				Me.tipTool.SetToolTip(Me.lblBG_13, "$0f")
				'
				'lblBG_12
				'
				Me.lblBG_12.BackColor = System.Drawing.Color.Black
				Me.lblBG_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblBG_12.Location = New System.Drawing.Point(448, 32)
				Me.lblBG_12.Name = "lblBG_12"
				Me.lblBG_12.Size = New System.Drawing.Size(24, 16)
				Me.lblBG_12.TabIndex = 17
				Me.tipTool.SetToolTip(Me.lblBG_12, "$0f")
				'
				'lblSP_12
				'
				Me.lblSP_12.BackColor = System.Drawing.Color.Black
				Me.lblSP_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_12.Location = New System.Drawing.Point(448, 88)
				Me.lblSP_12.Name = "lblSP_12"
				Me.lblSP_12.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_12.TabIndex = 33
				Me.tipTool.SetToolTip(Me.lblSP_12, "$0f")
				'
				'lblSP_13
				'
				Me.lblSP_13.BackColor = System.Drawing.Color.Black
				Me.lblSP_13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_13.Location = New System.Drawing.Point(480, 88)
				Me.lblSP_13.Name = "lblSP_13"
				Me.lblSP_13.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_13.TabIndex = 32
				Me.tipTool.SetToolTip(Me.lblSP_13, "$0f")
				'
				'lblSP_14
				'
				Me.lblSP_14.BackColor = System.Drawing.Color.Black
				Me.lblSP_14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_14.Location = New System.Drawing.Point(512, 88)
				Me.lblSP_14.Name = "lblSP_14"
				Me.lblSP_14.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_14.TabIndex = 31
				Me.tipTool.SetToolTip(Me.lblSP_14, "$0f")
				'
				'lblSP_15
				'
				Me.lblSP_15.BackColor = System.Drawing.Color.Black
				Me.lblSP_15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_15.Location = New System.Drawing.Point(544, 88)
				Me.lblSP_15.Name = "lblSP_15"
				Me.lblSP_15.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_15.TabIndex = 30
				Me.tipTool.SetToolTip(Me.lblSP_15, "$0f")
				'
				'lblSP_11
				'
				Me.lblSP_11.BackColor = System.Drawing.Color.Black
				Me.lblSP_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_11.Location = New System.Drawing.Point(400, 88)
				Me.lblSP_11.Name = "lblSP_11"
				Me.lblSP_11.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_11.TabIndex = 29
				Me.tipTool.SetToolTip(Me.lblSP_11, "$0f")
				'
				'lblSP_10
				'
				Me.lblSP_10.BackColor = System.Drawing.Color.Black
				Me.lblSP_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_10.Location = New System.Drawing.Point(368, 88)
				Me.lblSP_10.Name = "lblSP_10"
				Me.lblSP_10.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_10.TabIndex = 28
				Me.tipTool.SetToolTip(Me.lblSP_10, "$0f")
				'
				'lblSP_09
				'
				Me.lblSP_09.BackColor = System.Drawing.Color.Black
				Me.lblSP_09.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_09.Location = New System.Drawing.Point(336, 88)
				Me.lblSP_09.Name = "lblSP_09"
				Me.lblSP_09.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_09.TabIndex = 27
				Me.tipTool.SetToolTip(Me.lblSP_09, "$0f")
				'
				'lblSP_08
				'
				Me.lblSP_08.BackColor = System.Drawing.Color.Black
				Me.lblSP_08.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_08.Location = New System.Drawing.Point(304, 88)
				Me.lblSP_08.Name = "lblSP_08"
				Me.lblSP_08.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_08.TabIndex = 26
				Me.tipTool.SetToolTip(Me.lblSP_08, "$0f")
				'
				'lblSP_07
				'
				Me.lblSP_07.BackColor = System.Drawing.Color.Black
				Me.lblSP_07.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_07.Location = New System.Drawing.Point(256, 88)
				Me.lblSP_07.Name = "lblSP_07"
				Me.lblSP_07.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_07.TabIndex = 25
				Me.tipTool.SetToolTip(Me.lblSP_07, "$0f")
				'
				'lblSP_06
				'
				Me.lblSP_06.BackColor = System.Drawing.Color.Black
				Me.lblSP_06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_06.Location = New System.Drawing.Point(224, 88)
				Me.lblSP_06.Name = "lblSP_06"
				Me.lblSP_06.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_06.TabIndex = 24
				Me.tipTool.SetToolTip(Me.lblSP_06, "$0f")
				'
				'lblSP_05
				'
				Me.lblSP_05.BackColor = System.Drawing.Color.Black
				Me.lblSP_05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_05.Location = New System.Drawing.Point(192, 88)
				Me.lblSP_05.Name = "lblSP_05"
				Me.lblSP_05.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_05.TabIndex = 23
				Me.tipTool.SetToolTip(Me.lblSP_05, "$0f")
				'
				'lblSP_04
				'
				Me.lblSP_04.BackColor = System.Drawing.Color.Black
				Me.lblSP_04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_04.Location = New System.Drawing.Point(160, 88)
				Me.lblSP_04.Name = "lblSP_04"
				Me.lblSP_04.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_04.TabIndex = 22
				Me.tipTool.SetToolTip(Me.lblSP_04, "$0f")
				'
				'lblSP_03
				'
				Me.lblSP_03.BackColor = System.Drawing.Color.Black
				Me.lblSP_03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_03.Location = New System.Drawing.Point(112, 88)
				Me.lblSP_03.Name = "lblSP_03"
				Me.lblSP_03.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_03.TabIndex = 21
				Me.tipTool.SetToolTip(Me.lblSP_03, "$0f")
				'
				'lblSP_02
				'
				Me.lblSP_02.BackColor = System.Drawing.Color.Black
				Me.lblSP_02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_02.Location = New System.Drawing.Point(80, 88)
				Me.lblSP_02.Name = "lblSP_02"
				Me.lblSP_02.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_02.TabIndex = 20
				Me.tipTool.SetToolTip(Me.lblSP_02, "$0f")
				'
				'lblSP_00
				'
				Me.lblSP_00.BackColor = System.Drawing.Color.Black
				Me.lblSP_00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_00.Location = New System.Drawing.Point(16, 88)
				Me.lblSP_00.Name = "lblSP_00"
				Me.lblSP_00.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_00.TabIndex = 19
				Me.tipTool.SetToolTip(Me.lblSP_00, "$0f")
				'
				'lblSP_01
				'
				Me.lblSP_01.BackColor = System.Drawing.Color.Black
				Me.lblSP_01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lblSP_01.Location = New System.Drawing.Point(48, 88)
				Me.lblSP_01.Name = "lblSP_01"
				Me.lblSP_01.Size = New System.Drawing.Size(24, 16)
				Me.lblSP_01.TabIndex = 18
				Me.tipTool.SetToolTip(Me.lblSP_01, "$0f")
				'
				'lbl0c
				'
				Me.lbl0c.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(109, Byte), Integer))
				Me.lbl0c.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl0c.Location = New System.Drawing.Point(448, 136)
				Me.lbl0c.Name = "lbl0c"
				Me.lbl0c.Size = New System.Drawing.Size(24, 16)
				Me.lbl0c.TabIndex = 49
				Me.tipTool.SetToolTip(Me.lbl0c, "$0c")
				'
				'lbl0d
				'
				Me.lbl0d.BackColor = System.Drawing.Color.Black
				Me.lbl0d.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl0d.Location = New System.Drawing.Point(480, 136)
				Me.lbl0d.Name = "lbl0d"
				Me.lbl0d.Size = New System.Drawing.Size(24, 16)
				Me.lbl0d.TabIndex = 48
				Me.tipTool.SetToolTip(Me.lbl0d, "$0d - Are you sure you want to use this? ;)")
				'
				'lbl0e
				'
				Me.lbl0e.BackColor = System.Drawing.Color.Black
				Me.lbl0e.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl0e.Location = New System.Drawing.Point(512, 136)
				Me.lbl0e.Name = "lbl0e"
				Me.lbl0e.Size = New System.Drawing.Size(24, 16)
				Me.lbl0e.TabIndex = 47
				Me.tipTool.SetToolTip(Me.lbl0e, "$0e")
				'
				'lbl0f
				'
				Me.lbl0f.BackColor = System.Drawing.Color.Black
				Me.lbl0f.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl0f.Location = New System.Drawing.Point(544, 136)
				Me.lbl0f.Name = "lbl0f"
				Me.lbl0f.Size = New System.Drawing.Size(24, 16)
				Me.lbl0f.TabIndex = 46
				Me.tipTool.SetToolTip(Me.lbl0f, "$0f")
				'
				'lbl0b
				'
				Me.lbl0b.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(42, Byte), Integer))
				Me.lbl0b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl0b.Location = New System.Drawing.Point(416, 136)
				Me.lbl0b.Name = "lbl0b"
				Me.lbl0b.Size = New System.Drawing.Size(24, 16)
				Me.lbl0b.TabIndex = 45
				Me.tipTool.SetToolTip(Me.lbl0b, "$0b")
				'
				'lbl0a
				'
				Me.lbl0a.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(0, Byte), Integer))
				Me.lbl0a.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl0a.Location = New System.Drawing.Point(384, 136)
				Me.lbl0a.Name = "lbl0a"
				Me.lbl0a.Size = New System.Drawing.Size(24, 16)
				Me.lbl0a.TabIndex = 44
				Me.tipTool.SetToolTip(Me.lbl0a, "$0a")
				'
				'lbl09
				'
				Me.lbl09.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(0, Byte), Integer))
				Me.lbl09.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl09.Location = New System.Drawing.Point(352, 136)
				Me.lbl09.Name = "lbl09"
				Me.lbl09.Size = New System.Drawing.Size(24, 16)
				Me.lbl09.TabIndex = 43
				Me.tipTool.SetToolTip(Me.lbl09, "$09")
				'
				'lbl08
				'
				Me.lbl08.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(0, Byte), Integer))
				Me.lbl08.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl08.Location = New System.Drawing.Point(320, 136)
				Me.lbl08.Name = "lbl08"
				Me.lbl08.Size = New System.Drawing.Size(24, 16)
				Me.lbl08.TabIndex = 42
				Me.tipTool.SetToolTip(Me.lbl08, "$08")
				'
				'lbl07
				'
				Me.lbl07.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(0, Byte), Integer))
				Me.lbl07.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl07.Location = New System.Drawing.Point(288, 136)
				Me.lbl07.Name = "lbl07"
				Me.lbl07.Size = New System.Drawing.Size(24, 16)
				Me.lbl07.TabIndex = 41
				Me.tipTool.SetToolTip(Me.lbl07, "$07")
				'
				'lbl06
				'
				Me.lbl06.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(17, Byte), Integer))
				Me.lbl06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl06.Location = New System.Drawing.Point(256, 136)
				Me.lbl06.Name = "lbl06"
				Me.lbl06.Size = New System.Drawing.Size(24, 16)
				Me.lbl06.TabIndex = 40
				Me.tipTool.SetToolTip(Me.lbl06, "$06")
				'
				'lbl05
				'
				Me.lbl05.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer))
				Me.lbl05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl05.Location = New System.Drawing.Point(224, 136)
				Me.lbl05.Name = "lbl05"
				Me.lbl05.Size = New System.Drawing.Size(24, 16)
				Me.lbl05.TabIndex = 39
				Me.tipTool.SetToolTip(Me.lbl05, "$05")
				'
				'lbl04
				'
				Me.lbl04.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(97, Byte), Integer))
				Me.lbl04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl04.Location = New System.Drawing.Point(192, 136)
				Me.lbl04.Name = "lbl04"
				Me.lbl04.Size = New System.Drawing.Size(24, 16)
				Me.lbl04.TabIndex = 38
				Me.tipTool.SetToolTip(Me.lbl04, "$04")
				'
				'lbl03
				'
				Me.lbl03.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(149, Byte), Integer))
				Me.lbl03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl03.Location = New System.Drawing.Point(160, 136)
				Me.lbl03.Name = "lbl03"
				Me.lbl03.Size = New System.Drawing.Size(24, 16)
				Me.lbl03.TabIndex = 37
				Me.tipTool.SetToolTip(Me.lbl03, "$03")
				'
				'lbl02
				'
				Me.lbl02.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(170, Byte), Integer))
				Me.lbl02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl02.Location = New System.Drawing.Point(128, 136)
				Me.lbl02.Name = "lbl02"
				Me.lbl02.Size = New System.Drawing.Size(24, 16)
				Me.lbl02.TabIndex = 36
				Me.tipTool.SetToolTip(Me.lbl02, "$02")
				'
				'lbl00
				'
				Me.lbl00.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
				Me.lbl00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl00.ForeColor = System.Drawing.SystemColors.ControlText
				Me.lbl00.Location = New System.Drawing.Point(64, 136)
				Me.lbl00.Name = "lbl00"
				Me.lbl00.Size = New System.Drawing.Size(24, 16)
				Me.lbl00.TabIndex = 35
				Me.tipTool.SetToolTip(Me.lbl00, "$00")
				'
				'lbl01
				'
				Me.lbl01.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(156, Byte), Integer))
				Me.lbl01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl01.Location = New System.Drawing.Point(96, 136)
				Me.lbl01.Name = "lbl01"
				Me.lbl01.Size = New System.Drawing.Size(24, 16)
				Me.lbl01.TabIndex = 34
				Me.tipTool.SetToolTip(Me.lbl01, "$01")
				'
				'lbl1c
				'
				Me.lbl1c.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(183, Byte), Integer))
				Me.lbl1c.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl1c.Location = New System.Drawing.Point(448, 160)
				Me.lbl1c.Name = "lbl1c"
				Me.lbl1c.Size = New System.Drawing.Size(24, 16)
				Me.lbl1c.TabIndex = 65
				Me.tipTool.SetToolTip(Me.lbl1c, "$1c")
				'
				'lbl1d
				'
				Me.lbl1d.BackColor = System.Drawing.Color.Black
				Me.lbl1d.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl1d.Location = New System.Drawing.Point(480, 160)
				Me.lbl1d.Name = "lbl1d"
				Me.lbl1d.Size = New System.Drawing.Size(24, 16)
				Me.lbl1d.TabIndex = 64
				Me.tipTool.SetToolTip(Me.lbl1d, "$1d")
				'
				'lbl1e
				'
				Me.lbl1e.BackColor = System.Drawing.Color.Black
				Me.lbl1e.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl1e.Location = New System.Drawing.Point(512, 160)
				Me.lbl1e.Name = "lbl1e"
				Me.lbl1e.Size = New System.Drawing.Size(24, 16)
				Me.lbl1e.TabIndex = 63
				Me.tipTool.SetToolTip(Me.lbl1e, "$1e")
				'
				'lbl1f
				'
				Me.lbl1f.BackColor = System.Drawing.Color.Black
				Me.lbl1f.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl1f.Location = New System.Drawing.Point(544, 160)
				Me.lbl1f.Name = "lbl1f"
				Me.lbl1f.Size = New System.Drawing.Size(24, 16)
				Me.lbl1f.TabIndex = 62
				Me.tipTool.SetToolTip(Me.lbl1f, "$1f")
				'
				'lbl1b
				'
				Me.lbl1b.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(96, Byte), Integer))
				Me.lbl1b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl1b.Location = New System.Drawing.Point(416, 160)
				Me.lbl1b.Name = "lbl1b"
				Me.lbl1b.Size = New System.Drawing.Size(24, 16)
				Me.lbl1b.TabIndex = 61
				Me.tipTool.SetToolTip(Me.lbl1b, "$1b")
				'
				'lbl1a
				'
				Me.lbl1a.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(6, Byte), Integer))
				Me.lbl1a.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl1a.Location = New System.Drawing.Point(384, 160)
				Me.lbl1a.Name = "lbl1a"
				Me.lbl1a.Size = New System.Drawing.Size(24, 16)
				Me.lbl1a.TabIndex = 60
				Me.tipTool.SetToolTip(Me.lbl1a, "$1a")
				'
				'lbl19
				'
				Me.lbl19.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(0, Byte), Integer))
				Me.lbl19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl19.Location = New System.Drawing.Point(352, 160)
				Me.lbl19.Name = "lbl19"
				Me.lbl19.Size = New System.Drawing.Size(24, 16)
				Me.lbl19.TabIndex = 59
				Me.tipTool.SetToolTip(Me.lbl19, "$19")
				'
				'lbl18
				'
				Me.lbl18.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(0, Byte), Integer))
				Me.lbl18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl18.Location = New System.Drawing.Point(320, 160)
				Me.lbl18.Name = "lbl18"
				Me.lbl18.Size = New System.Drawing.Size(24, 16)
				Me.lbl18.TabIndex = 58
				Me.tipTool.SetToolTip(Me.lbl18, "$18")
				'
				'lbl17
				'
				Me.lbl17.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(0, Byte), Integer))
				Me.lbl17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl17.Location = New System.Drawing.Point(288, 160)
				Me.lbl17.Name = "lbl17"
				Me.lbl17.Size = New System.Drawing.Size(24, 16)
				Me.lbl17.TabIndex = 57
				Me.tipTool.SetToolTip(Me.lbl17, "$17")
				'
				'lbl16
				'
				Me.lbl16.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(0, Byte), Integer))
				Me.lbl16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl16.Location = New System.Drawing.Point(256, 160)
				Me.lbl16.Name = "lbl16"
				Me.lbl16.Size = New System.Drawing.Size(24, 16)
				Me.lbl16.TabIndex = 56
				Me.tipTool.SetToolTip(Me.lbl16, "$16")
				'
				'lbl15
				'
				Me.lbl15.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(77, Byte), Integer))
				Me.lbl15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl15.Location = New System.Drawing.Point(224, 160)
				Me.lbl15.Name = "lbl15"
				Me.lbl15.Size = New System.Drawing.Size(24, 16)
				Me.lbl15.TabIndex = 55
				Me.tipTool.SetToolTip(Me.lbl15, "$15")
				'
				'lbl14
				'
				Me.lbl14.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(167, Byte), Integer))
				Me.lbl14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl14.Location = New System.Drawing.Point(192, 160)
				Me.lbl14.Name = "lbl14"
				Me.lbl14.Size = New System.Drawing.Size(24, 16)
				Me.lbl14.TabIndex = 54
				Me.tipTool.SetToolTip(Me.lbl14, "$14")
				'
				'lbl13
				'
				Me.lbl13.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(255, Byte), Integer))
				Me.lbl13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl13.Location = New System.Drawing.Point(160, 160)
				Me.lbl13.Name = "lbl13"
				Me.lbl13.Size = New System.Drawing.Size(24, 16)
				Me.lbl13.TabIndex = 53
				Me.tipTool.SetToolTip(Me.lbl13, "$13")
				'
				'lbl12
				'
				Me.lbl12.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer))
				Me.lbl12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl12.Location = New System.Drawing.Point(128, 160)
				Me.lbl12.Name = "lbl12"
				Me.lbl12.Size = New System.Drawing.Size(24, 16)
				Me.lbl12.TabIndex = 52
				Me.tipTool.SetToolTip(Me.lbl12, "$12")
				'
				'lbl10
				'
				Me.lbl10.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
				Me.lbl10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl10.Location = New System.Drawing.Point(64, 160)
				Me.lbl10.Name = "lbl10"
				Me.lbl10.Size = New System.Drawing.Size(24, 16)
				Me.lbl10.TabIndex = 51
				Me.tipTool.SetToolTip(Me.lbl10, "$10")
				'
				'lbl11
				'
				Me.lbl11.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(244, Byte), Integer))
				Me.lbl11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl11.Location = New System.Drawing.Point(96, 160)
				Me.lbl11.Name = "lbl11"
				Me.lbl11.Size = New System.Drawing.Size(24, 16)
				Me.lbl11.TabIndex = 50
				Me.tipTool.SetToolTip(Me.lbl11, "$11")
				'
				'lbl2c
				'
				Me.lbl2c.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
				Me.lbl2c.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl2c.Location = New System.Drawing.Point(448, 184)
				Me.lbl2c.Name = "lbl2c"
				Me.lbl2c.Size = New System.Drawing.Size(24, 16)
				Me.lbl2c.TabIndex = 81
				Me.tipTool.SetToolTip(Me.lbl2c, "$2c")
				'
				'lbl2d
				'
				Me.lbl2d.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
				Me.lbl2d.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl2d.Location = New System.Drawing.Point(480, 184)
				Me.lbl2d.Name = "lbl2d"
				Me.lbl2d.Size = New System.Drawing.Size(24, 16)
				Me.lbl2d.TabIndex = 80
				Me.tipTool.SetToolTip(Me.lbl2d, "$2d")
				'
				'lbl2e
				'
				Me.lbl2e.BackColor = System.Drawing.Color.Black
				Me.lbl2e.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl2e.Location = New System.Drawing.Point(512, 184)
				Me.lbl2e.Name = "lbl2e"
				Me.lbl2e.Size = New System.Drawing.Size(24, 16)
				Me.lbl2e.TabIndex = 79
				Me.tipTool.SetToolTip(Me.lbl2e, "$2e")
				'
				'lbl2f
				'
				Me.lbl2f.BackColor = System.Drawing.Color.Black
				Me.lbl2f.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl2f.Location = New System.Drawing.Point(544, 184)
				Me.lbl2f.Name = "lbl2f"
				Me.lbl2f.Size = New System.Drawing.Size(24, 16)
				Me.lbl2f.TabIndex = 78
				Me.tipTool.SetToolTip(Me.lbl2f, "$2f")
				'
				'lbl2b
				'
				Me.lbl2b.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(177, Byte), Integer))
				Me.lbl2b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl2b.Location = New System.Drawing.Point(416, 184)
				Me.lbl2b.Name = "lbl2b"
				Me.lbl2b.Size = New System.Drawing.Size(24, 16)
				Me.lbl2b.TabIndex = 77
				Me.tipTool.SetToolTip(Me.lbl2b, "$2b")
				'
				'lbl2a
				'
				Me.lbl2a.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(86, Byte), Integer))
				Me.lbl2a.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl2a.Location = New System.Drawing.Point(384, 184)
				Me.lbl2a.Name = "lbl2a"
				Me.lbl2a.Size = New System.Drawing.Size(24, 16)
				Me.lbl2a.TabIndex = 76
				Me.tipTool.SetToolTip(Me.lbl2a, "$2a")
				'
				'lbl29
				'
				Me.lbl29.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(17, Byte), Integer))
				Me.lbl29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl29.Location = New System.Drawing.Point(352, 184)
				Me.lbl29.Name = "lbl29"
				Me.lbl29.Size = New System.Drawing.Size(24, 16)
				Me.lbl29.TabIndex = 75
				Me.tipTool.SetToolTip(Me.lbl29, "$29")
				'
				'lbl28
				'
				Me.lbl28.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(0, Byte), Integer))
				Me.lbl28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl28.Location = New System.Drawing.Point(320, 184)
				Me.lbl28.Name = "lbl28"
				Me.lbl28.Size = New System.Drawing.Size(24, 16)
				Me.lbl28.TabIndex = 74
				Me.tipTool.SetToolTip(Me.lbl28, "$28")
				'
				'lbl27
				'
				Me.lbl27.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(7, Byte), Integer))
				Me.lbl27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl27.Location = New System.Drawing.Point(288, 184)
				Me.lbl27.Name = "lbl27"
				Me.lbl27.Size = New System.Drawing.Size(24, 16)
				Me.lbl27.TabIndex = 73
				Me.tipTool.SetToolTip(Me.lbl27, "$27")
				'
				'lbl26
				'
				Me.lbl26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(112, Byte), Integer))
				Me.lbl26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl26.Location = New System.Drawing.Point(256, 184)
				Me.lbl26.Name = "lbl26"
				Me.lbl26.Size = New System.Drawing.Size(24, 16)
				Me.lbl26.TabIndex = 72
				Me.tipTool.SetToolTip(Me.lbl26, "$26")
				'
				'lbl25
				'
				Me.lbl25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(205, Byte), Integer))
				Me.lbl25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl25.Location = New System.Drawing.Point(224, 184)
				Me.lbl25.Name = "lbl25"
				Me.lbl25.Size = New System.Drawing.Size(24, 16)
				Me.lbl25.TabIndex = 71
				Me.tipTool.SetToolTip(Me.lbl25, "$25")
				'
				'lbl24
				'
				Me.lbl24.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(255, Byte), Integer))
				Me.lbl24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl24.Location = New System.Drawing.Point(192, 184)
				Me.lbl24.Name = "lbl24"
				Me.lbl24.Size = New System.Drawing.Size(24, 16)
				Me.lbl24.TabIndex = 70
				Me.tipTool.SetToolTip(Me.lbl24, "$24")
				'
				'lbl23
				'
				Me.lbl23.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(255, Byte), Integer))
				Me.lbl23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl23.Location = New System.Drawing.Point(160, 184)
				Me.lbl23.Name = "lbl23"
				Me.lbl23.Size = New System.Drawing.Size(24, 16)
				Me.lbl23.TabIndex = 69
				Me.tipTool.SetToolTip(Me.lbl23, "$23")
				'
				'lbl22
				'
				Me.lbl22.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
				Me.lbl22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl22.Location = New System.Drawing.Point(128, 184)
				Me.lbl22.Name = "lbl22"
				Me.lbl22.Size = New System.Drawing.Size(24, 16)
				Me.lbl22.TabIndex = 68
				Me.tipTool.SetToolTip(Me.lbl22, "$22")
				'
				'lbl20
				'
				Me.lbl20.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
				Me.lbl20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl20.Location = New System.Drawing.Point(64, 184)
				Me.lbl20.Name = "lbl20"
				Me.lbl20.Size = New System.Drawing.Size(24, 16)
				Me.lbl20.TabIndex = 67
				Me.tipTool.SetToolTip(Me.lbl20, "$20")
				'
				'lbl21
				'
				Me.lbl21.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(255, Byte), Integer))
				Me.lbl21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl21.Location = New System.Drawing.Point(96, 184)
				Me.lbl21.Name = "lbl21"
				Me.lbl21.Size = New System.Drawing.Size(24, 16)
				Me.lbl21.TabIndex = 66
				Me.tipTool.SetToolTip(Me.lbl21, "$21")
				'
				'lbl3c
				'
				Me.lbl3c.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
				Me.lbl3c.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl3c.Location = New System.Drawing.Point(448, 208)
				Me.lbl3c.Name = "lbl3c"
				Me.lbl3c.Size = New System.Drawing.Size(24, 16)
				Me.lbl3c.TabIndex = 97
				Me.tipTool.SetToolTip(Me.lbl3c, "$3c")
				'
				'lbl3d
				'
				Me.lbl3d.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
				Me.lbl3d.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl3d.Location = New System.Drawing.Point(480, 208)
				Me.lbl3d.Name = "lbl3d"
				Me.lbl3d.Size = New System.Drawing.Size(24, 16)
				Me.lbl3d.TabIndex = 96
				Me.tipTool.SetToolTip(Me.lbl3d, "$3d")
				'
				'lbl3e
				'
				Me.lbl3e.BackColor = System.Drawing.Color.Black
				Me.lbl3e.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl3e.Location = New System.Drawing.Point(512, 208)
				Me.lbl3e.Name = "lbl3e"
				Me.lbl3e.Size = New System.Drawing.Size(24, 16)
				Me.lbl3e.TabIndex = 95
				Me.tipTool.SetToolTip(Me.lbl3e, "$3e")
				'
				'lbl3f
				'
				Me.lbl3f.BackColor = System.Drawing.Color.Black
				Me.lbl3f.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl3f.Location = New System.Drawing.Point(544, 208)
				Me.lbl3f.Name = "lbl3f"
				Me.lbl3f.Size = New System.Drawing.Size(24, 16)
				Me.lbl3f.TabIndex = 94
				Me.tipTool.SetToolTip(Me.lbl3f, "$3f")
				'
				'lbl3b
				'
				Me.lbl3b.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(205, Byte), Integer))
				Me.lbl3b.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl3b.Location = New System.Drawing.Point(416, 208)
				Me.lbl3b.Name = "lbl3b"
				Me.lbl3b.Size = New System.Drawing.Size(24, 16)
				Me.lbl3b.TabIndex = 93
				Me.tipTool.SetToolTip(Me.lbl3b, "$3b")
				'
				'lbl3a
				'
				Me.lbl3a.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(171, Byte), Integer))
				Me.lbl3a.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl3a.Location = New System.Drawing.Point(384, 208)
				Me.lbl3a.Name = "lbl3a"
				Me.lbl3a.Size = New System.Drawing.Size(24, 16)
				Me.lbl3a.TabIndex = 92
				Me.tipTool.SetToolTip(Me.lbl3a, "$3a")
				'
				'lbl39
				'
				Me.lbl39.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(150, Byte), Integer))
				Me.lbl39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl39.Location = New System.Drawing.Point(352, 208)
				Me.lbl39.Name = "lbl39"
				Me.lbl39.Size = New System.Drawing.Size(24, 16)
				Me.lbl39.TabIndex = 91
				Me.tipTool.SetToolTip(Me.lbl39, "$39")
				'
				'lbl38
				'
				Me.lbl38.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(148, Byte), Integer))
				Me.lbl38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl38.Location = New System.Drawing.Point(320, 208)
				Me.lbl38.Name = "lbl38"
				Me.lbl38.Size = New System.Drawing.Size(24, 16)
				Me.lbl38.TabIndex = 90
				Me.tipTool.SetToolTip(Me.lbl38, "$38")
				'
				'lbl37
				'
				Me.lbl37.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(166, Byte), Integer))
				Me.lbl37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl37.Location = New System.Drawing.Point(288, 208)
				Me.lbl37.Name = "lbl37"
				Me.lbl37.Size = New System.Drawing.Size(24, 16)
				Me.lbl37.TabIndex = 89
				Me.tipTool.SetToolTip(Me.lbl37, "$37")
				'
				'lbl36
				'
				Me.lbl36.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer))
				Me.lbl36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl36.Location = New System.Drawing.Point(256, 208)
				Me.lbl36.Name = "lbl36"
				Me.lbl36.Size = New System.Drawing.Size(24, 16)
				Me.lbl36.TabIndex = 88
				Me.tipTool.SetToolTip(Me.lbl36, "$36")
				'
				'lbl35
				'
				Me.lbl35.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(235, Byte), Integer))
				Me.lbl35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl35.Location = New System.Drawing.Point(224, 208)
				Me.lbl35.Name = "lbl35"
				Me.lbl35.Size = New System.Drawing.Size(24, 16)
				Me.lbl35.TabIndex = 87
				Me.tipTool.SetToolTip(Me.lbl35, "$35")
				'
				'lbl34
				'
				Me.lbl34.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(255, Byte), Integer))
				Me.lbl34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl34.Location = New System.Drawing.Point(192, 208)
				Me.lbl34.Name = "lbl34"
				Me.lbl34.Size = New System.Drawing.Size(24, 16)
				Me.lbl34.TabIndex = 86
				Me.tipTool.SetToolTip(Me.lbl34, "$34")
				'
				'lbl33
				'
				Me.lbl33.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
				Me.lbl33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl33.Location = New System.Drawing.Point(160, 208)
				Me.lbl33.Name = "lbl33"
				Me.lbl33.Size = New System.Drawing.Size(24, 16)
				Me.lbl33.TabIndex = 85
				Me.tipTool.SetToolTip(Me.lbl33, "$33")
				'
				'lbl32
				'
				Me.lbl32.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer))
				Me.lbl32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl32.Location = New System.Drawing.Point(128, 208)
				Me.lbl32.Name = "lbl32"
				Me.lbl32.Size = New System.Drawing.Size(24, 16)
				Me.lbl32.TabIndex = 84
				Me.tipTool.SetToolTip(Me.lbl32, "$32")
				'
				'lbl30
				'
				Me.lbl30.BackColor = System.Drawing.Color.White
				Me.lbl30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl30.Location = New System.Drawing.Point(64, 208)
				Me.lbl30.Name = "lbl30"
				Me.lbl30.Size = New System.Drawing.Size(24, 16)
				Me.lbl30.TabIndex = 83
				Me.tipTool.SetToolTip(Me.lbl30, "$30")
				'
				'lbl31
				'
				Me.lbl31.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(255, Byte), Integer))
				Me.lbl31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
				Me.lbl31.Location = New System.Drawing.Point(96, 208)
				Me.lbl31.Name = "lbl31"
				Me.lbl31.Size = New System.Drawing.Size(24, 16)
				Me.lbl31.TabIndex = 82
				Me.tipTool.SetToolTip(Me.lbl31, "$31")
				'
				'lblValue
				'
				Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
				Me.lblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
				Me.lblValue.Location = New System.Drawing.Point(8, 168)
				Me.lblValue.Name = "lblValue"
				Me.lblValue.Size = New System.Drawing.Size(32, 23)
				Me.lblValue.TabIndex = 98
				Me.lblValue.Text = "0F"
				Me.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl0_side
				'
				Me.lbl0_side.Location = New System.Drawing.Point(48, 136)
				Me.lbl0_side.Name = "lbl0_side"
				Me.lbl0_side.Size = New System.Drawing.Size(8, 16)
				Me.lbl0_side.TabIndex = 99
				Me.lbl0_side.Text = "0"
				Me.lbl0_side.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl1_side
				'
				Me.lbl1_side.Location = New System.Drawing.Point(48, 160)
				Me.lbl1_side.Name = "lbl1_side"
				Me.lbl1_side.Size = New System.Drawing.Size(8, 16)
				Me.lbl1_side.TabIndex = 100
				Me.lbl1_side.Text = "1"
				Me.lbl1_side.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl2_side
				'
				Me.lbl2_side.Location = New System.Drawing.Point(48, 184)
				Me.lbl2_side.Name = "lbl2_side"
				Me.lbl2_side.Size = New System.Drawing.Size(8, 16)
				Me.lbl2_side.TabIndex = 101
				Me.lbl2_side.Text = "2"
				Me.lbl2_side.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl3_side
				'
				Me.lbl3_side.Location = New System.Drawing.Point(48, 208)
				Me.lbl3_side.Name = "lbl3_side"
				Me.lbl3_side.Size = New System.Drawing.Size(8, 16)
				Me.lbl3_side.TabIndex = 102
				Me.lbl3_side.Text = "3"
				Me.lbl3_side.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl0_top
				'
				Me.lbl0_top.Location = New System.Drawing.Point(72, 120)
				Me.lbl0_top.Name = "lbl0_top"
				Me.lbl0_top.Size = New System.Drawing.Size(8, 16)
				Me.lbl0_top.TabIndex = 103
				Me.lbl0_top.Text = "0"
				Me.lbl0_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl1_top
				'
				Me.lbl1_top.Location = New System.Drawing.Point(104, 120)
				Me.lbl1_top.Name = "lbl1_top"
				Me.lbl1_top.Size = New System.Drawing.Size(8, 16)
				Me.lbl1_top.TabIndex = 104
				Me.lbl1_top.Text = "1"
				Me.lbl1_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl2_top
				'
				Me.lbl2_top.Location = New System.Drawing.Point(136, 120)
				Me.lbl2_top.Name = "lbl2_top"
				Me.lbl2_top.Size = New System.Drawing.Size(8, 16)
				Me.lbl2_top.TabIndex = 105
				Me.lbl2_top.Text = "2"
				Me.lbl2_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl3_top
				'
				Me.lbl3_top.Location = New System.Drawing.Point(168, 120)
				Me.lbl3_top.Name = "lbl3_top"
				Me.lbl3_top.Size = New System.Drawing.Size(8, 16)
				Me.lbl3_top.TabIndex = 106
				Me.lbl3_top.Text = "3"
				Me.lbl3_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl4_top
				'
				Me.lbl4_top.Location = New System.Drawing.Point(200, 120)
				Me.lbl4_top.Name = "lbl4_top"
				Me.lbl4_top.Size = New System.Drawing.Size(8, 16)
				Me.lbl4_top.TabIndex = 107
				Me.lbl4_top.Text = "4"
				Me.lbl4_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl5_top
				'
				Me.lbl5_top.Location = New System.Drawing.Point(232, 120)
				Me.lbl5_top.Name = "lbl5_top"
				Me.lbl5_top.Size = New System.Drawing.Size(8, 16)
				Me.lbl5_top.TabIndex = 108
				Me.lbl5_top.Text = "5"
				Me.lbl5_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl6_top
				'
				Me.lbl6_top.Location = New System.Drawing.Point(264, 120)
				Me.lbl6_top.Name = "lbl6_top"
				Me.lbl6_top.Size = New System.Drawing.Size(8, 16)
				Me.lbl6_top.TabIndex = 109
				Me.lbl6_top.Text = "6"
				Me.lbl6_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl7_top
				'
				Me.lbl7_top.Location = New System.Drawing.Point(296, 120)
				Me.lbl7_top.Name = "lbl7_top"
				Me.lbl7_top.Size = New System.Drawing.Size(8, 16)
				Me.lbl7_top.TabIndex = 110
				Me.lbl7_top.Text = "7"
				Me.lbl7_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl8_top
				'
				Me.lbl8_top.Location = New System.Drawing.Point(328, 120)
				Me.lbl8_top.Name = "lbl8_top"
				Me.lbl8_top.Size = New System.Drawing.Size(8, 16)
				Me.lbl8_top.TabIndex = 111
				Me.lbl8_top.Text = "8"
				Me.lbl8_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbl9_top
				'
				Me.lbl9_top.Location = New System.Drawing.Point(360, 120)
				Me.lbl9_top.Name = "lbl9_top"
				Me.lbl9_top.Size = New System.Drawing.Size(8, 16)
				Me.lbl9_top.TabIndex = 112
				Me.lbl9_top.Text = "9"
				Me.lbl9_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbla_top
				'
				Me.lbla_top.Location = New System.Drawing.Point(392, 120)
				Me.lbla_top.Name = "lbla_top"
				Me.lbla_top.Size = New System.Drawing.Size(8, 16)
				Me.lbla_top.TabIndex = 113
				Me.lbla_top.Text = "a"
				Me.lbla_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lblb_top
				'
				Me.lblb_top.Location = New System.Drawing.Point(424, 120)
				Me.lblb_top.Name = "lblb_top"
				Me.lblb_top.Size = New System.Drawing.Size(8, 16)
				Me.lblb_top.TabIndex = 114
				Me.lblb_top.Text = "b"
				Me.lblb_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lblc_top
				'
				Me.lblc_top.Location = New System.Drawing.Point(456, 120)
				Me.lblc_top.Name = "lblc_top"
				Me.lblc_top.Size = New System.Drawing.Size(8, 16)
				Me.lblc_top.TabIndex = 115
				Me.lblc_top.Text = "c"
				Me.lblc_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lbld_top
				'
				Me.lbld_top.Location = New System.Drawing.Point(488, 120)
				Me.lbld_top.Name = "lbld_top"
				Me.lbld_top.Size = New System.Drawing.Size(8, 16)
				Me.lbld_top.TabIndex = 116
				Me.lbld_top.Text = "d"
				Me.lbld_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lble_top
				'
				Me.lble_top.Location = New System.Drawing.Point(520, 120)
				Me.lble_top.Name = "lble_top"
				Me.lble_top.Size = New System.Drawing.Size(8, 16)
				Me.lble_top.TabIndex = 117
				Me.lble_top.Text = "e"
				Me.lble_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lblf_top
				'
				Me.lblf_top.Location = New System.Drawing.Point(552, 120)
				Me.lblf_top.Name = "lblf_top"
				Me.lblf_top.Size = New System.Drawing.Size(8, 16)
				Me.lblf_top.TabIndex = 118
				Me.lblf_top.Text = "f"
				Me.lblf_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lblSelected
				'
				Me.lblSelected.BackColor = System.Drawing.Color.Black
				Me.lblSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
				Me.lblSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
				Me.lblSelected.Location = New System.Drawing.Point(8, 136)
				Me.lblSelected.Name = "lblSelected"
				Me.lblSelected.Size = New System.Drawing.Size(32, 23)
				Me.lblSelected.TabIndex = 119
				Me.lblSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'lblAbout
				'
				Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
				Me.lblAbout.Location = New System.Drawing.Point(552, 8)
				Me.lblAbout.Name = "lblAbout"
				Me.lblAbout.Size = New System.Drawing.Size(16, 16)
				Me.lblAbout.TabIndex = 128
				Me.lblAbout.Text = "?"
				Me.tipTool.SetToolTip(Me.lblAbout, "Create palette tables for use in your NES games." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Empty colors default to $0f. Ge" & _
								"t Table auto-copies data.")
				'
				'lblSDS
				'
				Me.lblSDS.LinkArea = New System.Windows.Forms.LinkArea(3, 18)
				Me.lblSDS.LinkColor = System.Drawing.Color.Red
				Me.lblSDS.Location = New System.Drawing.Point(480, 248)
				Me.lblSDS.Name = "lblSDS"
				Me.lblSDS.Size = New System.Drawing.Size(100, 16)
				Me.lblSDS.TabIndex = 127
				Me.lblSDS.TabStop = True
				Me.lblSDS.Text = "by Sly Dog Studios"
				Me.tipTool.SetToolTip(Me.lblSDS, "https://slydogstudios.org")
				Me.lblSDS.UseCompatibleTextRendering = True
				Me.lblSDS.VisitedLinkColor = System.Drawing.Color.Red
				'
				'lblHidden
				'
				Me.lblHidden.Location = New System.Drawing.Point(232, 8)
				Me.lblHidden.Name = "lblHidden"
				Me.lblHidden.Size = New System.Drawing.Size(48, 8)
				Me.lblHidden.TabIndex = 120
				Me.tipTool.SetToolTip(Me.lblHidden, "$0f")
				Me.lblHidden.Visible = False
				'
				'rchData
				'
				Me.rchData.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
				Me.rchData.Location = New System.Drawing.Point(8, 288)
				Me.rchData.Name = "rchData"
				Me.rchData.Size = New System.Drawing.Size(568, 48)
				Me.rchData.TabIndex = 1
				Me.rchData.Text = ""
				'
				'txtLabel
				'
				Me.txtLabel.Location = New System.Drawing.Point(88, 240)
				Me.txtLabel.Name = "txtLabel"
				Me.txtLabel.Size = New System.Drawing.Size(100, 20)
				Me.txtLabel.TabIndex = 0
				Me.txtLabel.Text = "palette"
				'
				'lblDivider
				'
				Me.lblDivider.BackColor = System.Drawing.Color.Black
				Me.lblDivider.Location = New System.Drawing.Point(8, 272)
				Me.lblDivider.Name = "lblDivider"
				Me.lblDivider.Size = New System.Drawing.Size(568, 8)
				Me.lblDivider.TabIndex = 123
				'
				'lblLabel
				'
				Me.lblLabel.Location = New System.Drawing.Point(8, 240)
				Me.lblLabel.Name = "lblLabel"
				Me.lblLabel.Size = New System.Drawing.Size(72, 16)
				Me.lblLabel.TabIndex = 124
				Me.lblLabel.Text = "Label Name:"
				Me.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
				'
				'btnGetTable
				'
				Me.btnGetTable.Location = New System.Drawing.Point(232, 240)
				Me.btnGetTable.Name = "btnGetTable"
				Me.btnGetTable.Size = New System.Drawing.Size(75, 23)
				Me.btnGetTable.TabIndex = 125
				Me.btnGetTable.Text = "Get Table"
				'
				'btnExit
				'
				Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
				Me.btnExit.Location = New System.Drawing.Point(480, 320)
				Me.btnExit.Name = "btnExit"
				Me.btnExit.Size = New System.Drawing.Size(8, 8)
				Me.btnExit.TabIndex = 126
				Me.btnExit.TabStop = False
				'
				'btnClear
				'
				Me.btnClear.Location = New System.Drawing.Point(352, 240)
				Me.btnClear.Name = "btnClear"
				Me.btnClear.Size = New System.Drawing.Size(80, 23)
				Me.btnClear.TabIndex = 129
				Me.btnClear.Text = "Clear Palette"
				'
				'makepal
				'
				Me.AcceptButton = Me.btnGetTable
				Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
				Me.CancelButton = Me.btnExit
				Me.ClientSize = New System.Drawing.Size(584, 337)
				Me.Controls.Add(Me.btnClear)
				Me.Controls.Add(Me.lblAbout)
				Me.Controls.Add(Me.lblSDS)
				Me.Controls.Add(Me.btnGetTable)
				Me.Controls.Add(Me.lblLabel)
				Me.Controls.Add(Me.lblDivider)
				Me.Controls.Add(Me.txtLabel)
				Me.Controls.Add(Me.rchData)
				Me.Controls.Add(Me.lblHidden)
				Me.Controls.Add(Me.lblSelected)
				Me.Controls.Add(Me.lblf_top)
				Me.Controls.Add(Me.lble_top)
				Me.Controls.Add(Me.lbld_top)
				Me.Controls.Add(Me.lblc_top)
				Me.Controls.Add(Me.lblb_top)
				Me.Controls.Add(Me.lbla_top)
				Me.Controls.Add(Me.lbl9_top)
				Me.Controls.Add(Me.lbl8_top)
				Me.Controls.Add(Me.lbl7_top)
				Me.Controls.Add(Me.lbl6_top)
				Me.Controls.Add(Me.lbl5_top)
				Me.Controls.Add(Me.lbl4_top)
				Me.Controls.Add(Me.lbl3_top)
				Me.Controls.Add(Me.lbl2_top)
				Me.Controls.Add(Me.lbl1_top)
				Me.Controls.Add(Me.lbl0_top)
				Me.Controls.Add(Me.lbl3_side)
				Me.Controls.Add(Me.lbl2_side)
				Me.Controls.Add(Me.lbl1_side)
				Me.Controls.Add(Me.lbl0_side)
				Me.Controls.Add(Me.lblValue)
				Me.Controls.Add(Me.lbl3c)
				Me.Controls.Add(Me.lbl3d)
				Me.Controls.Add(Me.lbl3e)
				Me.Controls.Add(Me.lbl3f)
				Me.Controls.Add(Me.lbl3b)
				Me.Controls.Add(Me.lbl3a)
				Me.Controls.Add(Me.lbl39)
				Me.Controls.Add(Me.lbl38)
				Me.Controls.Add(Me.lbl37)
				Me.Controls.Add(Me.lbl36)
				Me.Controls.Add(Me.lbl35)
				Me.Controls.Add(Me.lbl34)
				Me.Controls.Add(Me.lbl33)
				Me.Controls.Add(Me.lbl32)
				Me.Controls.Add(Me.lbl30)
				Me.Controls.Add(Me.lbl31)
				Me.Controls.Add(Me.lbl2c)
				Me.Controls.Add(Me.lbl2d)
				Me.Controls.Add(Me.lbl2e)
				Me.Controls.Add(Me.lbl2f)
				Me.Controls.Add(Me.lbl2b)
				Me.Controls.Add(Me.lbl2a)
				Me.Controls.Add(Me.lbl29)
				Me.Controls.Add(Me.lbl28)
				Me.Controls.Add(Me.lbl27)
				Me.Controls.Add(Me.lbl26)
				Me.Controls.Add(Me.lbl25)
				Me.Controls.Add(Me.lbl24)
				Me.Controls.Add(Me.lbl23)
				Me.Controls.Add(Me.lbl22)
				Me.Controls.Add(Me.lbl20)
				Me.Controls.Add(Me.lbl21)
				Me.Controls.Add(Me.lbl1c)
				Me.Controls.Add(Me.lbl1d)
				Me.Controls.Add(Me.lbl1e)
				Me.Controls.Add(Me.lbl1f)
				Me.Controls.Add(Me.lbl1b)
				Me.Controls.Add(Me.lbl1a)
				Me.Controls.Add(Me.lbl19)
				Me.Controls.Add(Me.lbl18)
				Me.Controls.Add(Me.lbl17)
				Me.Controls.Add(Me.lbl16)
				Me.Controls.Add(Me.lbl15)
				Me.Controls.Add(Me.lbl14)
				Me.Controls.Add(Me.lbl13)
				Me.Controls.Add(Me.lbl12)
				Me.Controls.Add(Me.lbl10)
				Me.Controls.Add(Me.lbl11)
				Me.Controls.Add(Me.lbl0c)
				Me.Controls.Add(Me.lbl0d)
				Me.Controls.Add(Me.lbl0e)
				Me.Controls.Add(Me.lbl0f)
				Me.Controls.Add(Me.lbl0b)
				Me.Controls.Add(Me.lbl0a)
				Me.Controls.Add(Me.lbl09)
				Me.Controls.Add(Me.lbl08)
				Me.Controls.Add(Me.lbl07)
				Me.Controls.Add(Me.lbl06)
				Me.Controls.Add(Me.lbl05)
				Me.Controls.Add(Me.lbl04)
				Me.Controls.Add(Me.lbl03)
				Me.Controls.Add(Me.lbl02)
				Me.Controls.Add(Me.lbl00)
				Me.Controls.Add(Me.lbl01)
				Me.Controls.Add(Me.lblSP_12)
				Me.Controls.Add(Me.lblSP_13)
				Me.Controls.Add(Me.lblSP_14)
				Me.Controls.Add(Me.lblSP_15)
				Me.Controls.Add(Me.lblSP_11)
				Me.Controls.Add(Me.lblSP_10)
				Me.Controls.Add(Me.lblSP_09)
				Me.Controls.Add(Me.lblSP_08)
				Me.Controls.Add(Me.lblSP_07)
				Me.Controls.Add(Me.lblSP_06)
				Me.Controls.Add(Me.lblSP_05)
				Me.Controls.Add(Me.lblSP_04)
				Me.Controls.Add(Me.lblSP_03)
				Me.Controls.Add(Me.lblSP_02)
				Me.Controls.Add(Me.lblSP_00)
				Me.Controls.Add(Me.lblSP_01)
				Me.Controls.Add(Me.lblBG_12)
				Me.Controls.Add(Me.lblBG_13)
				Me.Controls.Add(Me.lblBG_14)
				Me.Controls.Add(Me.lblBG_15)
				Me.Controls.Add(Me.lblBG_11)
				Me.Controls.Add(Me.lblBG_10)
				Me.Controls.Add(Me.lblBG_09)
				Me.Controls.Add(Me.lblBG_08)
				Me.Controls.Add(Me.lblBG_07)
				Me.Controls.Add(Me.lblBG_06)
				Me.Controls.Add(Me.lblBG_05)
				Me.Controls.Add(Me.lblBG_04)
				Me.Controls.Add(Me.lblBG_03)
				Me.Controls.Add(Me.lblBG_02)
				Me.Controls.Add(Me.lblBG_00)
				Me.Controls.Add(Me.lblBG_01)
				Me.Controls.Add(Me.lblSprites)
				Me.Controls.Add(Me.lblBackGround)
				Me.Controls.Add(Me.btnExit)
				Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
				Me.MaximizeBox = False
				Me.MaximumSize = New System.Drawing.Size(600, 376)
				Me.MinimumSize = New System.Drawing.Size(600, 376)
				Me.Name = "makepal"
				Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
				Me.Text = "makepal"
				Me.ResumeLayout(False)
				Me.PerformLayout()

		End Sub

#End Region
		Dim getOffset As Integer
		Dim numToString As String
		Dim ourBytes(31) As Byte
		Dim cpuByte As Byte
		Dim origTip As ToolTip
		Dim pals() As Label
		Dim theseLabels() As Label
		Dim allPalette(,) As Byte = { _
																																{0, 102, 102, 102}, _
																																{1, 1, 29, 156}, _
																																{2, 39, 7, 170}, _
																																{3, 77, 0, 149}, _
																																{4, 103, 0, 97}, _
																																{5, 111, 0, 28}, _
																																{6, 99, 0, 17}, _
																																{7, 70, 41, 0}, _
																																{8, 51, 53, 0}, _
																																{9, 0, 78, 0}, _
																																{10, 0, 82, 0}, _
																																{11, 0, 73, 42}, _
																																{12, 0, 53, 109}, _
																																{13, 0, 0, 0}, _
																																{14, 0, 0, 0}, _
																																{15, 0, 0, 0}, _
																																{16, 174, 174, 174}, _
																																{17, 42, 79, 244}, _
																																{18, 92, 50, 255}, _
																																{19, 141, 30, 255}, _
																																{20, 175, 26, 167}, _
																																{21, 186, 38, 77}, _
																																{22, 170, 63, 0}, _
																																{23, 153, 78, 0}, _
																																{24, 107, 110, 0}, _
																																{25, 32, 143, 0}, _
																																{26, 0, 147, 6}, _
																																{27, 0, 135, 96}, _
																																{28, 3, 110, 183}, _
																																{29, 0, 0, 0}, _
																																{30, 0, 0, 0}, _
																																{31, 0, 0, 0}, _
																																{32, 255, 255, 255}, _
																																{33, 121, 159, 255}, _
																																{34, 146, 144, 255}, _
																																{35, 222, 110, 255}, _
																																{36, 242, 106, 255}, _
																																{37, 255, 110, 205}, _
																																{38, 255, 129, 112}, _
																																{39, 213, 175, 7}, _
																																{40, 162, 205, 0}, _
																																{41, 112, 224, 17}, _
																																{42, 77, 229, 86}, _
																																{43, 67, 217, 177}, _
																																{44, 83, 191, 255}, _
																																{45, 79, 79, 79}, _
																																{46, 0, 0, 0}, _
																																{47, 0, 0, 0}, _
																																{48, 255, 255, 255}, _
																																{49, 192, 223, 255}, _
																																{50, 211, 210, 255}, _
																																{51, 232, 200, 255}, _
																																{52, 250, 195, 255}, _
																																{53, 255, 196, 235}, _
																																{54, 255, 204, 197}, _
																																{55, 247, 216, 166}, _
																																{56, 228, 229, 148}, _
																																{57, 207, 240, 150}, _
																																{58, 189, 245, 171}, _
																																{59, 180, 243, 205}, _
																																{60, 185, 229, 255}, _
																																{61, 184, 184, 184}, _
																																{62, 0, 0, 0}, _
																																{63, 0, 0, 0} _
																																												}

		Private Sub makepal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
				pals = New Label() {lbl00, lbl01, lbl02, lbl03, lbl04, lbl05, lbl06, lbl07, lbl08, _
										lbl09, lbl0a, lbl0b, lbl0c, lbl0d, lbl0e, lbl0f, lbl10, lbl11, lbl12, lbl13, _
										lbl14, lbl15, lbl16, lbl17, lbl18, lbl19, lbl1a, lbl1b, lbl1c, lbl1d, lbl1e, _
										lbl1f, lbl20, lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27, lbl28, lbl29, _
										lbl2a, lbl2b, lbl2c, lbl2d, lbl2e, lbl2f, lbl30, lbl31, lbl32, lbl33, lbl34, _
										lbl35, lbl36, lbl37, lbl38, lbl39, lbl3a, lbl3b, lbl3c, lbl3d, lbl3e, lbl3f}

				theseLabels = New Label() {lblBG_00, lblBG_01, lblBG_02, lblBG_03, lblBG_04, lblBG_05, lblBG_06, _
										lblBG_07, lblBG_08, lblBG_09, lblBG_10, lblBG_11, lblBG_12, lblBG_13, lblBG_14, lblBG_15, _
										lblSP_00, lblSP_01, lblSP_02, lblSP_03, lblSP_04, lblSP_05, lblSP_06, lblSP_07, _
										lblSP_08, lblSP_09, lblSP_10, lblSP_11, lblSP_12, lblSP_13, lblSP_14, lblSP_15}
		End Sub


		Private Sub lbl00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl00.Click, _
														lbl01.Click, lbl02.Click, lbl03.Click, lbl04.Click, lbl05.Click, lbl06.Click, lbl07.Click, _
														lbl08.Click, lbl09.Click, lbl0a.Click, lbl0b.Click, lbl0c.Click, lbl0d.Click, lbl0e.Click, lbl0f.Click, _
														lbl10.Click, lbl11.Click, lbl12.Click, lbl13.Click, lbl14.Click, lbl15.Click, lbl16.Click, lbl17.Click, _
														lbl18.Click, lbl19.Click, lbl1a.Click, lbl1b.Click, lbl1c.Click, lbl1d.Click, lbl1e.Click, lbl1f.Click, _
														lbl20.Click, lbl21.Click, lbl22.Click, lbl23.Click, lbl24.Click, lbl25.Click, lbl26.Click, lbl27.Click, _
														lbl28.Click, lbl29.Click, lbl2a.Click, lbl2b.Click, lbl2c.Click, lbl2d.Click, lbl2e.Click, lbl2f.Click, _
														lbl30.Click, lbl31.Click, lbl32.Click, lbl33.Click, lbl34.Click, lbl35.Click, lbl36.Click, lbl37.Click, _
														lbl38.Click, lbl39.Click, lbl3a.Click, lbl3b.Click, lbl3c.Click, lbl3d.Click, lbl3e.Click, lbl3f.Click

				getOffset = 0
				Do Until (String.Equals(pals(getOffset).Name, sender.Name)) = True
						getOffset += 1
				Loop

				numToString = getOffset.ToString("X2").ToLower()

				lblValue.Text = numToString
				lblSelected.BackColor = sender.BackColor
				cpuByte = getOffset
				numToString = "$" & numToString
				tipTool.SetToolTip(lblHidden, numToString)
		End Sub


		Private Sub lblBG_00_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBG_00.Click, _
								lblBG_04.Click, lblBG_08.Click, lblBG_12.Click, lblSP_00.Click, lblSP_04.Click, lblSP_08.Click, lblSP_12.Click

				lblBG_00.BackColor = lblSelected.BackColor
				lblBG_04.BackColor = lblSelected.BackColor
				lblBG_08.BackColor = lblSelected.BackColor
				lblBG_12.BackColor = lblSelected.BackColor
				lblSP_00.BackColor = lblSelected.BackColor
				lblSP_04.BackColor = lblSelected.BackColor
				lblSP_08.BackColor = lblSelected.BackColor
				lblSP_12.BackColor = lblSelected.BackColor
				ourBytes(0) = cpuByte
				ourBytes(4) = cpuByte
				ourBytes(8) = cpuByte
				ourBytes(12) = cpuByte
				ourBytes(16) = cpuByte
				ourBytes(20) = cpuByte
				ourBytes(24) = cpuByte
				ourBytes(28) = cpuByte
				tipTool.SetToolTip(lblBG_00, tipTool.GetToolTip(lblHidden))
				tipTool.SetToolTip(lblBG_04, tipTool.GetToolTip(lblHidden))
				tipTool.SetToolTip(lblBG_08, tipTool.GetToolTip(lblHidden))
				tipTool.SetToolTip(lblBG_12, tipTool.GetToolTip(lblHidden))
				tipTool.SetToolTip(lblSP_00, tipTool.GetToolTip(lblHidden))
				tipTool.SetToolTip(lblSP_04, tipTool.GetToolTip(lblHidden))
				tipTool.SetToolTip(lblSP_08, tipTool.GetToolTip(lblHidden))
				tipTool.SetToolTip(lblSP_12, tipTool.GetToolTip(lblHidden))
		End Sub

		Private Sub lblBG_01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBG_01.Click, _
										lblBG_02.Click, lblBG_03.Click, lblBG_05.Click, lblBG_06.Click, lblBG_07.Click, _
										lblBG_09.Click, lblBG_10.Click, lblBG_11.Click, lblBG_13.Click, lblBG_14.Click, _
										lblBG_15.Click, lblSP_01.Click, lblSP_02.Click, lblSP_03.Click, lblSP_05.Click, _
										lblSP_06.Click, lblSP_07.Click, lblSP_09.Click, lblSP_10.Click, lblSP_11.Click, _
										lblSP_13.Click, lblSP_14.Click, lblSP_15.Click

				getOffset = 0
				Do Until (String.Equals(theseLabels(getOffset).Name, sender.Name)) = True
						getOffset += 1
				Loop

				sender.BackColor = lblSelected.BackColor
				ourBytes(getOffset) = cpuByte
				tipTool.SetToolTip(sender, tipTool.GetToolTip(lblHidden))
		End Sub

		Private Sub btnGetTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetTable.Click
				If txtLabel.Text = "" Then
						txtLabel.Text = "palette"
				End If

				rchData.Text = txtLabel.Text & ":" & ControlChars.NewLine & ControlChars.Tab & _
																				".byte " & _
																				tipTool.GetToolTip(lblBG_00) & "," & tipTool.GetToolTip(lblBG_01) & "," & _
																				tipTool.GetToolTip(lblBG_02) & "," & tipTool.GetToolTip(lblBG_03) & ", " & _
																				tipTool.GetToolTip(lblBG_04) & "," & tipTool.GetToolTip(lblBG_05) & "," & _
																				tipTool.GetToolTip(lblBG_06) & "," & tipTool.GetToolTip(lblBG_07) & ", " & _
																				tipTool.GetToolTip(lblBG_08) & "," & tipTool.GetToolTip(lblBG_09) & "," & _
																				tipTool.GetToolTip(lblBG_10) & "," & tipTool.GetToolTip(lblBG_11) & ", " & _
																				tipTool.GetToolTip(lblBG_12) & "," & tipTool.GetToolTip(lblBG_13) & "," & _
																				tipTool.GetToolTip(lblBG_14) & "," & tipTool.GetToolTip(lblBG_15) & _
																				ControlChars.NewLine & ControlChars.Tab & ".byte " & _
																				tipTool.GetToolTip(lblSP_00) & "," & tipTool.GetToolTip(lblSP_01) & "," & _
																				tipTool.GetToolTip(lblSP_02) & "," & tipTool.GetToolTip(lblSP_03) & ", " & _
																				tipTool.GetToolTip(lblSP_04) & "," & tipTool.GetToolTip(lblSP_05) & "," & _
																				tipTool.GetToolTip(lblSP_06) & "," & tipTool.GetToolTip(lblSP_07) & ", " & _
																				tipTool.GetToolTip(lblSP_08) & "," & tipTool.GetToolTip(lblSP_09) & "," & _
																				tipTool.GetToolTip(lblSP_10) & "," & tipTool.GetToolTip(lblSP_11) & ", " & _
																				tipTool.GetToolTip(lblSP_12) & "," & tipTool.GetToolTip(lblSP_13) & "," & _
																				tipTool.GetToolTip(lblSP_14) & "," & tipTool.GetToolTip(lblSP_15)
		End Sub

		Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
				Me.Close()
		End Sub

		Private Sub lblSDS_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblSDS.LinkClicked
				System.Diagnostics.Process.Start("http://slydogstudios.org")
		End Sub

		Private Sub rchData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rchData.TextChanged
				rchData.SelectAll()
				rchData.Copy()
		End Sub

		Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

				For index As Integer = 0 To 31
						theseLabels(index).BackColor = System.Drawing.Color.Black
						tipTool.SetToolTip(theseLabels(index), "$0f")
				Next

				txtLabel.Text = "palette"
				txtLabel.Focus()
				rchData.Clear()
		End Sub
End Class
