Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Text

Public Class MySqlHandler

	Private con As New MySqlConnection
	Private rd As MySqlDataReader
	Private cmd As New MySqlCommand

	<DllImport("NeuralNet.dll", CallingConvention:=CallingConvention.Cdecl, CharSet:=CharSet.Ansi)>
	Private Shared Function estimatePrice(<MarshalAs(UnmanagedType.LPStr)> str As String, ByVal size As Integer) As Integer
	End Function


	Public Function issueQuery(query As String, centerHouse As String)

		Dim estimatedPrice As Integer = 0

		Try
			Dim size As Integer = 0
			Dim toSend As String = ""
			Dim price As String
			Dim line As String

			Dim temp As String = ""

			connect()
			cmd.CommandText = query
			rd = cmd.ExecuteReader()

			While rd.Read

				line = rd("price")
				price = line.Remove(line.Length - 1, 1) ' get rid of line reset character 

				temp = rd("location") & "q" & rd("size") & "q" & rd("rooms") & "q" & rd("age") & "q" & rd("story") & "q" & price & "q" & rd("longitude") & "q" & rd("latitude") & "w"
				MsgBox(temp)
				toSend &= temp

				size += 1

			End While

			size += 1
			toSend &= centerHouse ' add the house to the data

			estimatedPrice = estimatePrice(toSend, size)

		Catch ex As Exception
			MsgBox(ex.ToString())

		Finally
			disconnect()
		End Try

		Return estimatedPrice

	End Function

	Public Function formQuery(table As String, location As String, Optional size As String = "", Optional rooms As String = "")

		Dim query As New StringBuilder

		query.Append("SELECT * FROM ")
		query.Append(parse(table) & "1")
		query.Append(" WHERE Location LIKE ")
		query.Append("'%" & parse(location) & "%' ")

		If size <> "" Then
			query.Append(" AND size = ")
			query.Append(size)
		End If
		If rooms <> "" Then
			query.Append(" AND rooms = ")
			query.Append("'" & rooms & "'")
		End If
		query.Append(";")

		Return query.ToString
	End Function

	Private Function parse(str As String)

		Dim result As String = ""

		For i As Integer = 0 To str.Length - 1
			If str(i).ToString.ToLower = "ğ" Then
				result &= "g"

			ElseIf str(i).ToString.ToLower = "ı" Then
				result &= "i"
			ElseIf str(i).ToString.ToLower = "ş" Then
				result &= "s"
			Else
				result &= str(i)
			End If
		Next i

		Return result
	End Function

	Public Sub New()
		con.ConnectionString = "DATABASE=housesdb;SERVER=127.0.0.1;USER=root;PASSWORD=12345ite"
		cmd.Connection = con
	End Sub

	Private Sub connect()
		con.Open()
	End Sub

	Private Sub disconnect()
		con.Close()
	End Sub
End Class
