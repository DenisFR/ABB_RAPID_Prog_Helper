Option Explicit On
Public Module modModifPoints

	'Version 1.00

	'Modifié par DFraipont
	'
	' Utilise les modules:
	' Utilise les Feuilles:
	' Modifications:



	Public Sub ModifPoints(ByVal clbListe As CheckedListBox _
											 , Optional ByRef ModifX As String = "" _
											 , Optional ByRef ModifY As String = "" _
											 , Optional ByRef ModifZ As String = "" _
											 , Optional ByRef ModifQ1 As String = "" _
											 , Optional ByRef ModifQ2 As String = "" _
											 , Optional ByRef ModifQ3 As String = "" _
											 , Optional ByRef ModifQ4 As String = "" _
											 , Optional ByRef ModifCf1 As String = "" _
											 , Optional ByRef ModifCf4 As String = "" _
											 , Optional ByRef ModifCf6 As String = "" _
											 , Optional ByRef ModifCfx As String = "")

		' Robot Target
		Dim robTemp As New ClsRobTarget
		' Nombre d'espace à gauche
		Dim lngNbSpace As Integer
		' Curseur
		Dim objCurs

		For Each objCurs In clbListe.CheckedIndices
			If clbListe.GetItemCheckState(objCurs) = CheckState.Checked Then
				Dim strTemp As String = clbListe.Items(objCurs)
				If (Trim(strTemp) <> "") And (InStr(1, strTemp.ToUpper, "ROBTARGET") <> 0) Then
					lngNbSpace = GetNbSpace(strTemp)
					robTemp.Text = LTrim(strTemp)

					If ModifX <> "" Then robTemp.Trans.X = CDbl(ModifX)
					If ModifY <> "" Then robTemp.Trans.Y = CDbl(ModifY)
					If ModifZ <> "" Then robTemp.Trans.Z = CDbl(ModifZ)
					If ModifQ1 <> "" Then robTemp.Rot.Q1 = CDbl(ModifQ1)
					If ModifQ2 <> "" Then robTemp.Rot.Q2 = CDbl(ModifQ2)
					If ModifQ3 <> "" Then robTemp.Rot.Q3 = CDbl(ModifQ3)
					If ModifQ4 <> "" Then robTemp.Rot.Q4 = CDbl(ModifQ4)
					If ModifCf1 <> "" Then robTemp.Robconf.cf1 = CDbl(ModifCf1)
					If ModifCf4 <> "" Then robTemp.Robconf.cf4 = CDbl(ModifCf4)
					If ModifCf6 <> "" Then robTemp.Robconf.cf6 = CDbl(ModifCf6)
					If ModifCfx <> "" Then robTemp.Robconf.cfx = CDbl(ModifCfx)

					clbListe.Items(objCurs) = Space(lngNbSpace) & robTemp.Text
				End If
			End If
		Next objCurs
		robTemp = Nothing
	End Sub

	Public Sub DecalPoints(ByVal clbListe As CheckedListBox _
											 , Optional ByRef DecalX As String = "" _
											 , Optional ByRef DecalY As String = "" _
											 , Optional ByRef DecalZ As String = "")
		' Robot Target
		Dim robTemp As New ClsRobTarget
		' Nombre d'espace à gauche
		Dim lngNbSpace As Integer
		' Curseur
		Dim objCurs As String

		robTemp = New ClsRobTarget


		For Each objCurs In clbListe.CheckedIndices
			If clbListe.GetItemCheckState(objCurs) = CheckState.Checked Then
				Dim strTemp As String = clbListe.Items(objCurs)
				If (Trim(strTemp) <> "") And (InStr(1, strTemp.ToUpper, "ROBTARGET") <> 0) Then
					lngNbSpace = GetNbSpace(strTemp)
					robTemp.Text = LTrim(strTemp)

					If DecalX <> "" Then robTemp.Trans.X = robTemp.Trans.X + CSng(DecalX)
					If DecalY <> "" Then robTemp.Trans.Y = robTemp.Trans.Y + CSng(DecalY)
					If DecalZ <> "" Then robTemp.Trans.Z = robTemp.Trans.Z + CSng(DecalZ)

					clbListe.Items(objCurs) = Space(lngNbSpace) & robTemp.Text
				End If
			End If
		Next
		robTemp = Nothing
	End Sub


	Public Function GetNbSpace(ByRef strText As String) As Integer
		Dim lngCurs As Integer = 0
		While Mid(strText, lngCurs + 1, 1) = " "
			lngCurs = lngCurs + 1
		End While
		GetNbSpace = lngCurs
	End Function

End Module
