Module modEncodevFE
	'Version 1.0

	' V1.0 Création
	Private intInc0 As Integer
	Private ReadOnly intInc1(3) As Integer
	Private ReadOnly intInc2(15) As Integer
	Private ReadOnly intInc3(255) As Integer
	Private intStart0 As Integer
	Private ReadOnly intStart1(3) As Integer
	Private ReadOnly intStart2(15) As Integer
	Private ReadOnly intStart3(255) As Integer
	Private ReadOnly intStart4(65535) As Integer

	Private Sub MakeInc()
		Dim intCurs As Integer
		intInc0 = &H40
		intInc1(0) = &HD0
		For intCurs = 1 To 3
			intInc1(intCurs) = CInt("&H" & Right(Hex(intInc1(intCurs - 1) + intInc0), 2))
		Next
		intInc2(0) = &HA4
		For intCurs = 1 To 15
			intInc2(intCurs) = CInt("&H" & Right(Hex(intInc2(intCurs - 1) + intInc1(((intCurs - 1) Mod 4))), 2))
		Next
		intInc3(0) = &H15
		For intCurs = 1 To 255
			intInc3(intCurs) = CInt("&H" & Right(Hex(intInc3(intCurs - 1) + intInc2(((intCurs - 1) Mod 16))), 2))
		Next
	End Sub

	Private Sub MakeStart()
		Dim intCurs As Integer
		intStart0 = &HC0
		intStart1(0) = &H30
		For intCurs = 1 To 3
			intStart1(intCurs) = CInt("&H" & Right(Hex(intStart1(intCurs - 1) + intStart0), 2))
		Next
		intStart2(0) = &H5C
		For intCurs = 1 To 15
			intStart2(intCurs) = CInt("&H" & Right(Hex(intStart2(intCurs - 1) + intStart1(((intCurs - 1) Mod 4))), 2))
		Next
		intStart3(0) = &HEB
		For intCurs = 1 To 255
			intStart3(intCurs) = CInt("&H" & Right(Hex(intStart3(intCurs - 1) + intStart2(((intCurs - 1) Mod 16))), 2))
		Next
		intStart4(0) = &HFF
		For intCurs = 1 To 65535
			intStart4(intCurs) = CInt("&H" & Right(Hex(intStart4(intCurs - 1) + intStart3(((intCurs - 1) Mod 256))), 2))
		Next
	End Sub

	Public Function GetEncodeFileVFE(ByVal strFileToEncode As String, ByVal strFileOutput As String) As Boolean
		Dim intChar As Integer
		Dim intInc As Integer 'Incrément pour cette colonne
		Dim intStart As Integer 'Début (chr(0))
		Dim intResult As Integer 'Résultat
		Dim bytFileToEncode() As Byte
		Dim bytFileOutput() As Byte
		Dim lngCurs As Long
		Dim intStartCoding As Integer
		Dim intName As Integer
		GetEncodeFileVFE = False


		MakeInc()
		MakeStart()


		If Not My.Computer.FileSystem.FileExists(strFileToEncode) Then
			MsgBox(String.Format(My.Resources.NoFileExist, strFileToEncode) _
				  , MsgBoxStyle.Critical, "modEncodeFE.GetEncodeFileVFE ")
			Exit Function
		End If
		If strFileOutput = "" Then Exit Function
		If My.Computer.FileSystem.FileExists(strFileOutput) Then
			intChar = MsgBox(String.Format(My.Resources.FileAlreadyExist, strFileOutput) _
							, MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "modEncodeFE.GetEncodeFileVFE ")
			If intChar = MsgBoxResult.No Then Exit Function
			My.Computer.FileSystem.DeleteFile(strFileOutput, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
		End If

		bytFileToEncode = My.Computer.FileSystem.ReadAllBytes(strFileToEncode)
		'Fichier vide
		If bytFileToEncode.Length = 0 Then ReDim bytFileToEncode(0) : bytFileToEncode(0) = 0

		If bytFileToEncode(0) = &HFE Then
			My.Computer.FileSystem.CopyFile(strFileToEncode, strFileOutput)
			GetEncodeFileVFE = True
			Exit Function
		End If

		intStartCoding = 18

		ReDim bytFileOutput(UBound(bytFileToEncode) + intStartCoding) 'Entête
		intName = &H3D8

		For lngCurs = LBound(bytFileOutput) To UBound(bytFileOutput)

			Select Case lngCurs
				Case 0
					intResult = &HFE
				Case 3 To (intStartCoding - 1)
					'Entête "FE XX XX A0 3D 52 00 84 F9 13 00 B0 16 40 00 7C 02 02 "
					intResult = &HAA
				Case 1
					intResult = intName Mod &H100
				Case 2
					intResult = (intName \ &H100) Mod &H100
					'Ces deux caractères (2-3) sont défini suivant le premier caractère du fichier codé _
					' et le nombre de lettre (avant le .) suivant cette méthode:
					'    lngResult = Asc(LCase(Left(strTitre, 1))) * Len(strTitre)
					'    lngResult = (lngResult Mod 204) * 8 '(204 =&h660 car codé de 8 en 8 de 00 00 à 55 06
					'Sauf s'il commence par "_" où là les 2 caractères sont (&h00 &h00)
				Case Else
					intChar = bytFileToEncode(lngCurs - intStartCoding)

					'Récupère l'incrément suivant la position
					intInc = intInc3(((lngCurs - intStartCoding) Mod 256))
					'Multipli suivant le codage du nom
					intInc = intInc * intName / 8
					'Récupère l'octet de poids faible
					intInc = intInc Mod &H100

					'Récupère le départ suivant position
					intStart = intStart4(((lngCurs - intStartCoding) Mod 65536))

					'Récupère le code ascci du caractère (+&h100 pour être positif)
					intResult = (intChar + intStart) Mod &H100
					intResult = (intResult + intInc) Mod &H100

			End Select
			bytFileOutput(lngCurs) = intResult
		Next lngCurs

		If Not My.Computer.FileSystem.DirectoryExists(Strings.Left(strFileOutput, Strings.InStrRev(strFileOutput, "\"))) Then
			My.Computer.FileSystem.CreateDirectory(Strings.Left(strFileOutput, Strings.InStrRev(strFileOutput, "\")))
		End If

		My.Computer.FileSystem.WriteAllBytes(strFileOutput, bytFileOutput, False)
		GetEncodeFileVFE = True
	End Function

End Module
