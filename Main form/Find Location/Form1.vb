'In order to make our project use the new components, we'll need to create a reference to downloaded DLL files
'Project - > Add Reference - > Browse 
'To add GMap.Net to Toolbox,  ToolBox - > Right Click - > Choose Items

Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.MapProviders

Public Class ENGForm

	Dim mySqlHandler As New MySqlHandler
	Dim lat, lng As Double
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lbMessage.Visible = False

	End Sub

	Private Sub GMapControl1_Load(sender As Object, e As EventArgs) Handles GMapControl1.Load

        'define map provider
        GMapControl1.MapProvider = MapProviders.GoogleMapProvider.Instance
        GMaps.Instance.Mode = AccessMode.ServerOnly
        GMapControl1.SetPositionByKeywords("Turkey")

        'map properties
        GMapControl1.ShowCenter = False
        GMapControl1.CanDragMap = True

		GMapControl1.EmptyTileText = "No Internet Connection."

		'dont change this color xD
		GMapControl1.EmptyTileColor = Color.Red
	End Sub

    Private Sub GMapControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles GMapControl1.MouseClick

		If CityComboBox.SelectedIndex = -1 Then
			Dim str As String = "Please select a city first"
			If TRbuttonIsClicked Then
				str = "Lütfen ilk önce bir şehir seçiniz"
			End If
			MsgBox(str)
			Exit Sub
		End If

		Dim markers As New GMapOverlay("markers")

		If e.Button = MouseButtons.Left Then

			lat = GMapControl1.FromLocalToLatLng(e.X, e.Y).Lat
            lng = GMapControl1.FromLocalToLatLng(e.X, e.Y).Lng

			GMapControl1.Overlays.Clear() 'clear previous markers
			Dim marker As New GMarkerGoogle(New PointLatLng(lat, lng), GMarkerGoogleType.green_small)
            GMapControl1.Overlays.Add(markers)
			markers.Markers.Add(marker)
		End If

        'Getting the string of address
        Dim place As List(Of Placemark)
        Dim check As GeoCoderStatusCode = GMapProviders.GoogleMap.GetPlacemarks(New PointLatLng(lat, lng), place)
		If check = GeoCoderStatusCode.G_GEO_SUCCESS Then
			For Each p1 As Placemark In place
				lbLocation.Text = p1.Address
				Exit For
			Next
		End If
		Dim message As String = "Thank you! You can keep trying different points."
		If TRbuttonIsClicked Then
			message = "Teşekkürler! Farklı noktalar deneyebilirsiniz."
		End If
		lbMessage.Text = message
	End Sub


	Private Sub btnPredict_Click(sender As Object, e As EventArgs) Handles btnPredict.Click

		If lbLocation.Text = "" Or cbAge.SelectedIndex = -1 Or cbFloor.SelectedIndex = -1 Or cbRoom.SelectedIndex = -1 Then

			Dim message As String = "Please complete filling up all the required feilds"
			If TRbuttonIsClicked Then
				message = "Lütfen bütün bilgileri giriniz"
			End If
			MsgBox(message)
			Exit Sub
		End If
		'CircularProgressBar1.Visible = True

		Dim city, location, size, rooms, age, story, query As String
		Dim estimatedPrice As Integer
		Dim centerHouse As String = ""

		city = CityComboBox.SelectedItem.ToString
		size = TxtBoxSize.Text
		rooms = cbRoom.SelectedItem.ToString
		location = getLocation(lbLocation.Text)
		age = cbAge.SelectedItem.ToString
		story = cbFloor.SelectedItem.ToString

		query = mySqlHandler.formQuery(city, location, size)
		centerHouse = location & "q" & size & "q" & rooms & "q" & age & "q" & story & "q" & lng & "q" & lat & "q170.000 TL"

		estimatedPrice = mySqlHandler.issueQuery(query, centerHouse)

		lblPrice.Text = estimatedPrice

	End Sub

	Private Function getLocation(str As String)

		Dim temp As String()
		temp = str.Split("/")(str.Split("/").Length - 2).ToString().Split(" ")

		Return temp(temp.Length - 1)
	End Function

	Private Sub MacTrackBar1_ValueChanged(sender As Object, value As Decimal) Handles MacTrackBar1.ValueChanged
		TxtBoxSize.Text = MacTrackBar1.Value.ToString
	End Sub

    'exit window
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'minimize window
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    'maximize window
    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click

        If Me.WindowState = System.Windows.Forms.FormWindowState.Maximized Then
            Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Else
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        End If


    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        'slidePanel plaecement
        slidePanel.Height = btnHome.Height
        slidePanel.Top = btnHome.Top


	End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click

		slidePanel.Height = btnHistory.Height
        slidePanel.Top = btnHistory.Top

	End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click

		slidePanel.Height = btnAbout.Height
        slidePanel.Top = btnAbout.Top

	End Sub

	Private Sub btnGithub_Click(sender As Object, e As EventArgs) Handles btnGithub.Click

		Dim webAddress As String = "https://github.com/AhmadAlkhatib/Housing-price-prediction"
		Process.Start(webAddress)
	End Sub

	Public TRbuttonIsClicked As Boolean = False
	Private Sub btnTR_Click(sender As Object, e As EventArgs) Handles btnTR.Click
		TRbuttonIsClicked = True
		btnHome.Text = "Ana Sayfa"
		btnAbout.Text = "Ön Bilgiler"
		btnHistory.Text = "Geçmiş Arama"
		btnGithub.Text = "Kaynak Kodu"
		Label2.Text = "Alan:"
		lbRoom.Text = "Oda Sayısı:"
		lbFloor.Text = "Bulunduğu Kat:"
		lbAge.Text = "Bina Yaşı:"
		btnPredict.Text = "Tahmin et"
		lbSelectCity.Text = "Lütfen bir şehir seçiniz:"
		lbMessage.Text = "Şimdi bir noktayi seçiniz ve sizin için adresi elde edeceğiz:"
	End Sub
	Private Sub btnEng_Click(sender As Object, e As EventArgs) Handles btnEng.Click

		btnHome.Text = "Home"
		btnAbout.Text = "About"
		btnHistory.Text = "History"
		btnGithub.Text = "Source Code"
		Label2.Text = "Size:"
		lbRoom.Text = "Room Number:"
		lbFloor.Text = "Story:"
		lbAge.Text = "Age:"
		btnPredict.Text = "Estimate"


	End Sub
	'set position on the map by selected city
	Private Sub CityComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CityComboBox.SelectedIndexChanged
        If CityComboBox.SelectedIndex = 0 Then
            GMapControl1.SetPositionByKeywords("Istanbul" & "Turkey")
            GMapControl1.Zoom = 9
        End If

        If CityComboBox.SelectedIndex = 1 Then
            GMapControl1.SetPositionByKeywords("Edirne" & "Turkey")
            GMapControl1.Zoom = 9
        End If

        If CityComboBox.SelectedIndex = 2 Then
            GMapControl1.SetPositionByKeywords("Bursa" & "Turkey")
            GMapControl1.Zoom = 9
        End If

        If CityComboBox.SelectedIndex = 3 Then
            GMapControl1.SetPositionByKeywords("Ankara" & "Turkey")
            GMapControl1.Zoom = 9
        End If

        If CityComboBox.SelectedIndex = 4 Then
            GMapControl1.SetPositionByKeywords("Izmir" & "Turkey")
            GMapControl1.Zoom = 10
        End If

        lbMessage.Visible = True
        lbSelectCity.Hide()
        CityComboBox.Hide()

    End Sub

	Private Sub TxtBoxSize_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxSize.TextChanged
		MacTrackBar1.Value = TxtBoxSize.Text
	End Sub
End Class
