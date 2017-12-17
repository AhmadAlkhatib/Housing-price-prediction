<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ENGForm
    Inherits System.Windows.Forms.Form

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ENGForm))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.slidePanel = New System.Windows.Forms.Panel()
		Me.Panel11 = New System.Windows.Forms.Panel()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.btnGithub = New System.Windows.Forms.Button()
		Me.btnEng = New System.Windows.Forms.Button()
		Me.btnTR = New System.Windows.Forms.Button()
		Me.btnAbout = New System.Windows.Forms.Button()
		Me.btnHistory = New System.Windows.Forms.Button()
		Me.btnHome = New System.Windows.Forms.Button()
		Me.lbMessage = New System.Windows.Forms.Label()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.btnMinimize = New System.Windows.Forms.Button()
		Me.btnMaximize = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lbRoom = New System.Windows.Forms.Label()
		Me.lbFloor = New System.Windows.Forms.Label()
		Me.lbAge = New System.Windows.Forms.Label()
		Me.lbLocation = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lblPrice = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.btnPredict = New System.Windows.Forms.Button()
		Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.Panel8 = New System.Windows.Forms.Panel()
		Me.Panel9 = New System.Windows.Forms.Panel()
		Me.MacTrackBar1 = New XComponent.SliderBar.MACTrackBar()
		Me.cbRoom = New System.Windows.Forms.ComboBox()
		Me.cbFloor = New System.Windows.Forms.ComboBox()
		Me.cbAge = New System.Windows.Forms.ComboBox()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.GMapControl1 = New GMap.NET.WindowsForms.GMapControl()
		Me.CityComboBox = New System.Windows.Forms.ComboBox()
		Me.lbSelectCity = New System.Windows.Forms.Label()
		Me.TxtBoxSize = New System.Windows.Forms.TextBox()
		Me.Panel1.SuspendLayout()
		Me.Panel5.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		resources.ApplyResources(Me.Panel1, "Panel1")
		Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Panel1.Controls.Add(Me.slidePanel)
		Me.Panel1.Controls.Add(Me.Panel11)
		Me.Panel1.Controls.Add(Me.Panel4)
		Me.Panel1.Controls.Add(Me.btnGithub)
		Me.Panel1.Controls.Add(Me.btnEng)
		Me.Panel1.Controls.Add(Me.btnTR)
		Me.Panel1.Controls.Add(Me.btnAbout)
		Me.Panel1.Controls.Add(Me.btnHistory)
		Me.Panel1.Controls.Add(Me.btnHome)
		Me.Panel1.Name = "Panel1"
		'
		'slidePanel
		'
		Me.slidePanel.BackColor = System.Drawing.Color.PaleGreen
		resources.ApplyResources(Me.slidePanel, "slidePanel")
		Me.slidePanel.Name = "slidePanel"
		'
		'Panel11
		'
		Me.Panel11.BackColor = System.Drawing.SystemColors.Window
		resources.ApplyResources(Me.Panel11, "Panel11")
		Me.Panel11.Name = "Panel11"
		'
		'Panel4
		'
		resources.ApplyResources(Me.Panel4, "Panel4")
		Me.Panel4.Name = "Panel4"
		'
		'btnGithub
		'
		resources.ApplyResources(Me.btnGithub, "btnGithub")
		Me.btnGithub.BackColor = System.Drawing.SystemColors.MenuText
		Me.btnGithub.FlatAppearance.BorderSize = 0
		Me.btnGithub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btnGithub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
		Me.btnGithub.ForeColor = System.Drawing.SystemColors.MenuBar
		Me.btnGithub.Name = "btnGithub"
		Me.btnGithub.UseVisualStyleBackColor = False
		'
		'btnEng
		'
		Me.btnEng.BackColor = System.Drawing.SystemColors.MenuText
		Me.btnEng.FlatAppearance.BorderSize = 0
		Me.btnEng.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen
		Me.btnEng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
		Me.btnEng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
		resources.ApplyResources(Me.btnEng, "btnEng")
		Me.btnEng.ForeColor = System.Drawing.SystemColors.ControlLight
		Me.btnEng.Name = "btnEng"
		Me.btnEng.UseVisualStyleBackColor = False
		'
		'btnTR
		'
		Me.btnTR.BackColor = System.Drawing.SystemColors.MenuText
		Me.btnTR.FlatAppearance.BorderSize = 0
		Me.btnTR.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen
		Me.btnTR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
		Me.btnTR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
		resources.ApplyResources(Me.btnTR, "btnTR")
		Me.btnTR.ForeColor = System.Drawing.SystemColors.ControlLight
		Me.btnTR.Name = "btnTR"
		Me.btnTR.UseVisualStyleBackColor = False
		'
		'btnAbout
		'
		Me.btnAbout.BackColor = System.Drawing.SystemColors.MenuText
		Me.btnAbout.FlatAppearance.BorderSize = 0
		Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		resources.ApplyResources(Me.btnAbout, "btnAbout")
		Me.btnAbout.ForeColor = System.Drawing.SystemColors.MenuBar
		Me.btnAbout.Name = "btnAbout"
		Me.btnAbout.UseVisualStyleBackColor = False
		'
		'btnHistory
		'
		Me.btnHistory.BackColor = System.Drawing.SystemColors.MenuText
		Me.btnHistory.FlatAppearance.BorderSize = 0
		Me.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		resources.ApplyResources(Me.btnHistory, "btnHistory")
		Me.btnHistory.ForeColor = System.Drawing.SystemColors.MenuBar
		Me.btnHistory.Name = "btnHistory"
		Me.btnHistory.UseVisualStyleBackColor = False
		'
		'btnHome
		'
		Me.btnHome.BackColor = System.Drawing.SystemColors.MenuText
		Me.btnHome.FlatAppearance.BorderSize = 0
		Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		resources.ApplyResources(Me.btnHome, "btnHome")
		Me.btnHome.ForeColor = System.Drawing.SystemColors.MenuBar
		Me.btnHome.Name = "btnHome"
		Me.btnHome.UseVisualStyleBackColor = False
		'
		'lbMessage
		'
		resources.ApplyResources(Me.lbMessage, "lbMessage")
		Me.lbMessage.Name = "lbMessage"
		'
		'btnExit
		'
		resources.ApplyResources(Me.btnExit, "btnExit")
		Me.btnExit.BackColor = System.Drawing.Color.Transparent
		Me.btnExit.FlatAppearance.BorderSize = 0
		Me.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen
		Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
		Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btnExit.Name = "btnExit"
		Me.btnExit.UseVisualStyleBackColor = False
		'
		'btnMinimize
		'
		resources.ApplyResources(Me.btnMinimize, "btnMinimize")
		Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
		Me.btnMinimize.FlatAppearance.BorderSize = 0
		Me.btnMinimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen
		Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
		Me.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btnMinimize.Name = "btnMinimize"
		Me.btnMinimize.UseVisualStyleBackColor = False
		'
		'btnMaximize
		'
		resources.ApplyResources(Me.btnMaximize, "btnMaximize")
		Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
		Me.btnMaximize.FlatAppearance.BorderSize = 0
		Me.btnMaximize.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen
		Me.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
		Me.btnMaximize.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.btnMaximize.Name = "btnMaximize"
		Me.btnMaximize.UseVisualStyleBackColor = False
		'
		'Label1
		'
		resources.ApplyResources(Me.Label1, "Label1")
		Me.Label1.Name = "Label1"
		'
		'Label2
		'
		resources.ApplyResources(Me.Label2, "Label2")
		Me.Label2.Name = "Label2"
		'
		'lbRoom
		'
		resources.ApplyResources(Me.lbRoom, "lbRoom")
		Me.lbRoom.Name = "lbRoom"
		'
		'lbFloor
		'
		resources.ApplyResources(Me.lbFloor, "lbFloor")
		Me.lbFloor.Name = "lbFloor"
		'
		'lbAge
		'
		resources.ApplyResources(Me.lbAge, "lbAge")
		Me.lbAge.Name = "lbAge"
		'
		'lbLocation
		'
		resources.ApplyResources(Me.lbLocation, "lbLocation")
		Me.lbLocation.Name = "lbLocation"
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.OliveDrab
		resources.ApplyResources(Me.Panel3, "Panel3")
		Me.Panel3.Name = "Panel3"
		'
		'Label6
		'
		Me.Label6.BackColor = System.Drawing.Color.OliveDrab
		resources.ApplyResources(Me.Label6, "Label6")
		Me.Label6.Name = "Label6"
		'
		'lblPrice
		'
		Me.lblPrice.BackColor = System.Drawing.Color.OliveDrab
		Me.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		resources.ApplyResources(Me.lblPrice, "lblPrice")
		Me.lblPrice.Name = "lblPrice"
		'
		'Label8
		'
		Me.Label8.BackColor = System.Drawing.Color.OliveDrab
		Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		resources.ApplyResources(Me.Label8, "Label8")
		Me.Label8.Name = "Label8"
		'
		'btnPredict
		'
		Me.btnPredict.BackColor = System.Drawing.Color.Black
		Me.btnPredict.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen
		Me.btnPredict.FlatAppearance.BorderSize = 0
		Me.btnPredict.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
		Me.btnPredict.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
		resources.ApplyResources(Me.btnPredict, "btnPredict")
		Me.btnPredict.ForeColor = System.Drawing.SystemColors.Window
		Me.btnPredict.Name = "btnPredict"
		Me.btnPredict.UseVisualStyleBackColor = False
		'
		'CircularProgressBar1
		'
		Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
		Me.CircularProgressBar1.AnimationSpeed = 500
		Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
		resources.ApplyResources(Me.CircularProgressBar1, "CircularProgressBar1")
		Me.CircularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.CircularProgressBar1.InnerColor = System.Drawing.Color.Transparent
		Me.CircularProgressBar1.InnerMargin = 0
		Me.CircularProgressBar1.InnerWidth = -1
		Me.CircularProgressBar1.MarqueeAnimationSpeed = 2000
		Me.CircularProgressBar1.Name = "CircularProgressBar1"
		Me.CircularProgressBar1.OuterColor = System.Drawing.Color.Black
		Me.CircularProgressBar1.OuterMargin = -35
		Me.CircularProgressBar1.OuterWidth = 30
		Me.CircularProgressBar1.ProgressColor = System.Drawing.Color.OliveDrab
		Me.CircularProgressBar1.ProgressWidth = 10
		Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Arial", 3.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CircularProgressBar1.StartAngle = 270
		Me.CircularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
		Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
		Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
		Me.CircularProgressBar1.SubscriptText = ""
		Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
		Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
		Me.CircularProgressBar1.SuperscriptText = ""
		Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
		Me.CircularProgressBar1.Value = 68
		'
		'Panel6
		'
		Me.Panel6.BackColor = System.Drawing.Color.OliveDrab
		resources.ApplyResources(Me.Panel6, "Panel6")
		Me.Panel6.Name = "Panel6"
		'
		'Panel7
		'
		Me.Panel7.BackColor = System.Drawing.Color.OliveDrab
		resources.ApplyResources(Me.Panel7, "Panel7")
		Me.Panel7.Name = "Panel7"
		'
		'Panel8
		'
		Me.Panel8.BackColor = System.Drawing.Color.OliveDrab
		resources.ApplyResources(Me.Panel8, "Panel8")
		Me.Panel8.Name = "Panel8"
		'
		'Panel9
		'
		Me.Panel9.BackColor = System.Drawing.Color.OliveDrab
		resources.ApplyResources(Me.Panel9, "Panel9")
		Me.Panel9.Name = "Panel9"
		'
		'MacTrackBar1
		'
		Me.MacTrackBar1.BackColor = System.Drawing.Color.Transparent
		Me.MacTrackBar1.BorderColor = System.Drawing.SystemColors.ActiveBorder
		resources.ApplyResources(Me.MacTrackBar1, "MacTrackBar1")
		Me.MacTrackBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(123, Byte), Integer))
		Me.MacTrackBar1.IndentHeight = 1
		Me.MacTrackBar1.LargeChange = 100
		Me.MacTrackBar1.Maximum = 850
		Me.MacTrackBar1.Minimum = 0
		Me.MacTrackBar1.Name = "MacTrackBar1"
		Me.MacTrackBar1.TickColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(148, Byte), Integer))
		Me.MacTrackBar1.TickFrequency = 300
		Me.MacTrackBar1.TickHeight = 2
		Me.MacTrackBar1.TrackerColor = System.Drawing.Color.OliveDrab
		Me.MacTrackBar1.TrackerSize = New System.Drawing.Size(16, 16)
		Me.MacTrackBar1.TrackLineColor = System.Drawing.Color.Black
		Me.MacTrackBar1.TrackLineHeight = 2
		Me.MacTrackBar1.TrackLineSelectedColor = System.Drawing.Color.OliveDrab
		Me.MacTrackBar1.Value = 0
		'
		'cbRoom
		'
		Me.cbRoom.BackColor = System.Drawing.Color.OliveDrab
		Me.cbRoom.DropDownHeight = 90
		resources.ApplyResources(Me.cbRoom, "cbRoom")
		Me.cbRoom.FormattingEnabled = True
		Me.cbRoom.Items.AddRange(New Object() {resources.GetString("cbRoom.Items"), resources.GetString("cbRoom.Items1"), resources.GetString("cbRoom.Items2"), resources.GetString("cbRoom.Items3"), resources.GetString("cbRoom.Items4"), resources.GetString("cbRoom.Items5"), resources.GetString("cbRoom.Items6"), resources.GetString("cbRoom.Items7"), resources.GetString("cbRoom.Items8"), resources.GetString("cbRoom.Items9"), resources.GetString("cbRoom.Items10"), resources.GetString("cbRoom.Items11"), resources.GetString("cbRoom.Items12"), resources.GetString("cbRoom.Items13"), resources.GetString("cbRoom.Items14"), resources.GetString("cbRoom.Items15"), resources.GetString("cbRoom.Items16"), resources.GetString("cbRoom.Items17"), resources.GetString("cbRoom.Items18"), resources.GetString("cbRoom.Items19"), resources.GetString("cbRoom.Items20"), resources.GetString("cbRoom.Items21"), resources.GetString("cbRoom.Items22"), resources.GetString("cbRoom.Items23"), resources.GetString("cbRoom.Items24"), resources.GetString("cbRoom.Items25"), resources.GetString("cbRoom.Items26"), resources.GetString("cbRoom.Items27"), resources.GetString("cbRoom.Items28"), resources.GetString("cbRoom.Items29"), resources.GetString("cbRoom.Items30"), resources.GetString("cbRoom.Items31")})
		Me.cbRoom.Name = "cbRoom"
		'
		'cbFloor
		'
		Me.cbFloor.BackColor = System.Drawing.Color.OliveDrab
		Me.cbFloor.DropDownHeight = 90
		Me.cbFloor.DropDownWidth = 100
		resources.ApplyResources(Me.cbFloor, "cbFloor")
		Me.cbFloor.FormattingEnabled = True
		Me.cbFloor.Items.AddRange(New Object() {resources.GetString("cbFloor.Items"), resources.GetString("cbFloor.Items1"), resources.GetString("cbFloor.Items2"), resources.GetString("cbFloor.Items3"), resources.GetString("cbFloor.Items4"), resources.GetString("cbFloor.Items5"), resources.GetString("cbFloor.Items6"), resources.GetString("cbFloor.Items7"), resources.GetString("cbFloor.Items8"), resources.GetString("cbFloor.Items9"), resources.GetString("cbFloor.Items10"), resources.GetString("cbFloor.Items11"), resources.GetString("cbFloor.Items12"), resources.GetString("cbFloor.Items13"), resources.GetString("cbFloor.Items14"), resources.GetString("cbFloor.Items15"), resources.GetString("cbFloor.Items16"), resources.GetString("cbFloor.Items17"), resources.GetString("cbFloor.Items18"), resources.GetString("cbFloor.Items19"), resources.GetString("cbFloor.Items20"), resources.GetString("cbFloor.Items21"), resources.GetString("cbFloor.Items22"), resources.GetString("cbFloor.Items23"), resources.GetString("cbFloor.Items24"), resources.GetString("cbFloor.Items25"), resources.GetString("cbFloor.Items26"), resources.GetString("cbFloor.Items27"), resources.GetString("cbFloor.Items28"), resources.GetString("cbFloor.Items29"), resources.GetString("cbFloor.Items30"), resources.GetString("cbFloor.Items31"), resources.GetString("cbFloor.Items32"), resources.GetString("cbFloor.Items33"), resources.GetString("cbFloor.Items34")})
		Me.cbFloor.Name = "cbFloor"
		'
		'cbAge
		'
		Me.cbAge.BackColor = System.Drawing.Color.OliveDrab
		Me.cbAge.DropDownHeight = 90
		Me.cbAge.DropDownWidth = 100
		resources.ApplyResources(Me.cbAge, "cbAge")
		Me.cbAge.FormattingEnabled = True
		Me.cbAge.Items.AddRange(New Object() {resources.GetString("cbAge.Items"), resources.GetString("cbAge.Items1"), resources.GetString("cbAge.Items2"), resources.GetString("cbAge.Items3"), resources.GetString("cbAge.Items4"), resources.GetString("cbAge.Items5"), resources.GetString("cbAge.Items6"), resources.GetString("cbAge.Items7"), resources.GetString("cbAge.Items8"), resources.GetString("cbAge.Items9")})
		Me.cbAge.Name = "cbAge"
		'
		'Panel5
		'
		resources.ApplyResources(Me.Panel5, "Panel5")
		Me.Panel5.BackColor = System.Drawing.Color.Honeydew
		Me.Panel5.Controls.Add(Me.GMapControl1)
		Me.Panel5.Name = "Panel5"
		'
		'GMapControl1
		'
		Me.GMapControl1.AllowDrop = True
		resources.ApplyResources(Me.GMapControl1, "GMapControl1")
		Me.GMapControl1.Bearing = 0!
		Me.GMapControl1.CanDragMap = True
		Me.GMapControl1.EmptyTileColor = System.Drawing.Color.Navy
		Me.GMapControl1.GrayScaleMode = False
		Me.GMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
		Me.GMapControl1.LevelsKeepInMemmory = 5
		Me.GMapControl1.MarkersEnabled = True
		Me.GMapControl1.MaxZoom = 20
		Me.GMapControl1.MinZoom = 5
		Me.GMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter
		Me.GMapControl1.Name = "GMapControl1"
		Me.GMapControl1.NegativeMode = False
		Me.GMapControl1.PolygonsEnabled = True
		Me.GMapControl1.RetryLoadTile = 0
		Me.GMapControl1.RoutesEnabled = True
		Me.GMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
		Me.GMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
		Me.GMapControl1.ShowTileGridLines = False
		Me.GMapControl1.Zoom = 5.0R
		'
		'CityComboBox
		'
		Me.CityComboBox.BackColor = System.Drawing.Color.LightGray
		Me.CityComboBox.DropDownHeight = 90
		resources.ApplyResources(Me.CityComboBox, "CityComboBox")
		Me.CityComboBox.FormattingEnabled = True
		Me.CityComboBox.Items.AddRange(New Object() {resources.GetString("CityComboBox.Items"), resources.GetString("CityComboBox.Items1"), resources.GetString("CityComboBox.Items2"), resources.GetString("CityComboBox.Items3"), resources.GetString("CityComboBox.Items4")})
		Me.CityComboBox.Name = "CityComboBox"
		'
		'lbSelectCity
		'
		resources.ApplyResources(Me.lbSelectCity, "lbSelectCity")
		Me.lbSelectCity.Name = "lbSelectCity"
		'
		'TxtBoxSize
		'
		Me.TxtBoxSize.BackColor = System.Drawing.Color.OliveDrab
		Me.TxtBoxSize.BorderStyle = System.Windows.Forms.BorderStyle.None
		resources.ApplyResources(Me.TxtBoxSize, "TxtBoxSize")
		Me.TxtBoxSize.Name = "TxtBoxSize"
		'
		'ENGForm
		'
		Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
		Me.AllowDrop = True
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Window
		Me.Controls.Add(Me.TxtBoxSize)
		Me.Controls.Add(Me.lbSelectCity)
		Me.Controls.Add(Me.CityComboBox)
		Me.Controls.Add(Me.btnMaximize)
		Me.Controls.Add(Me.btnMinimize)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.cbAge)
		Me.Controls.Add(Me.cbFloor)
		Me.Controls.Add(Me.cbRoom)
		Me.Controls.Add(Me.MacTrackBar1)
		Me.Controls.Add(Me.Panel9)
		Me.Controls.Add(Me.Panel8)
		Me.Controls.Add(Me.Panel7)
		Me.Controls.Add(Me.Panel6)
		Me.Controls.Add(Me.CircularProgressBar1)
		Me.Controls.Add(Me.lbMessage)
		Me.Controls.Add(Me.btnPredict)
		Me.Controls.Add(Me.Panel5)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.lblPrice)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.lbLocation)
		Me.Controls.Add(Me.lbAge)
		Me.Controls.Add(Me.lbFloor)
		Me.Controls.Add(Me.lbRoom)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "ENGForm"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Panel1.ResumeLayout(False)
		Me.Panel5.ResumeLayout(False)
		Me.Panel5.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnHome As Button
    Friend WithEvents btnGithub As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnHistory As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbMessage As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEng As Button
    Friend WithEvents btnTR As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnMaximize As Button
    Friend WithEvents slidePanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbRoom As Label
    Friend WithEvents lbFloor As Label
    Friend WithEvents lbAge As Label
    Friend WithEvents lbLocation As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnPredict As Button
    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents MacTrackBar1 As XComponent.SliderBar.MACTrackBar
    Friend WithEvents cbRoom As ComboBox
    Friend WithEvents cbFloor As ComboBox
	Friend WithEvents cbAge As ComboBox
	Friend WithEvents Panel5 As Panel
	Friend WithEvents GMapControl1 As GMap.NET.WindowsForms.GMapControl
	Friend WithEvents CityComboBox As ComboBox
	Friend WithEvents lbSelectCity As Label
	Friend WithEvents TxtBoxSize As TextBox
End Class
