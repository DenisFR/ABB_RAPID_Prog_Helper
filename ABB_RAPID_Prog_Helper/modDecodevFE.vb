Module modDecodevFE
	'Version 1.1

	'Modification:
	' V1.2 Correction bugg sur fichier vide
	'     Ajout modDecodeFD et FC
	' V1.1 Ajout mode sans message si fichier non crypté
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
		intStart0 = &HC0 '&H40
		intStart1(0) = &H30 ' &HD0
		For intCurs = 1 To 3
			intStart1(intCurs) = CInt("&H" & Right(Hex(intStart1(intCurs - 1) + intStart0), 2))
		Next
		intStart2(0) = &H5C '&HA4
		For intCurs = 1 To 15
			intStart2(intCurs) = CInt("&H" & Right(Hex(intStart2(intCurs - 1) + intStart1(((intCurs - 1) Mod 4))), 2))
		Next
		intStart3(0) = &HEB ' &H15
		For intCurs = 1 To 255
			intStart3(intCurs) = CInt("&H" & Right(Hex(intStart3(intCurs - 1) + intStart2(((intCurs - 1) Mod 16))), 2))
		Next
		intStart4(0) = &HFF ' &H40 '
		For intCurs = 1 To 65535
			intStart4(intCurs) = CInt("&H" & Right(Hex(intStart4(intCurs - 1) + intStart3(((intCurs - 1) Mod 256))), 2))
		Next
	End Sub

	Public Function GetDecodeFileVFE(ByVal strFileToDecode As String, ByVal strFileOutput As String, Optional ByVal blShowMessNoCrypted As Boolean = False) As Boolean
		Dim intChar As Integer
		Dim strHexaChar As String
		Dim intInc As Integer 'Incrément pour cette colonne
		Dim intStart As Integer 'Début (chr(0))
		Dim intResult As Integer 'Résultat
		Dim bytFileToDecode() As Byte
		Dim bytFileOutput() As Byte
		Dim lngCurs As Long
		Dim intName As Integer
		GetDecodeFileVFE = False


		MakeInc()
		MakeStart()


		'FileClose()
		If Not My.Computer.FileSystem.FileExists(strFileToDecode) Then
			MsgBox(String.Format(My.Resources.NoFileExist, strFileToDecode) _
				  , MsgBoxStyle.Critical, "modDecodeFE.GetDecodeFileVFE ")
			Exit Function
		End If
		If strFileOutput = "" Then Exit Function
		If My.Computer.FileSystem.FileExists(strFileOutput) Then
			intChar = MsgBox(String.Format(My.Resources.FileAlreadyExist, strFileOutput) _
							, MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "modDecodeFE.GetDecodeFileVFE ")
			If intChar = MsgBoxResult.No Then Exit Function
			My.Computer.FileSystem.DeleteFile(strFileOutput, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
		End If

		'FileOpen(1, strFileToDecode, OpenMode.Binary, OpenAccess.Read)
		'FileOpen(2, strFileOutput, OpenMode.Binary, OpenAccess.Write)
		bytFileToDecode = My.Computer.FileSystem.ReadAllBytes(strFileToDecode)
		'Fichier vide
		If bytFileToDecode.Length = 0 Then ReDim bytFileToDecode(0) : bytFileToDecode(0) = 0

		Select Case bytFileToDecode(0)
			Case &HFE
				'Codé IRB4
				'Continu
			Case &HFD
				'Codé IRC5
				GetDecodeFileVFE = GetDecodeFileVFD(strFileToDecode, strFileOutput, blShowMessNoCrypted)
				Exit Function
			Case &HFC
				'Codé IRC5
				GetDecodeFileVFE = GetDecodeFileVFC(strFileToDecode, strFileOutput, blShowMessNoCrypted)
				Exit Function
			Case Else
				If Not blShowMessNoCrypted Then
					MsgBox(String.Format(My.Resources.FileNotCoded, strFileToDecode) _
						  , vbCritical, "modDecodeFE.GetDecodeFileVFE")
				Else
					My.Computer.FileSystem.CopyFile(strFileToDecode, strFileOutput)
					GetDecodeFileVFE = True
				End If
				Exit Function
		End Select

		ReDim bytFileOutput(UBound(bytFileToDecode) - 18) 'Entête

		'While Loc(1) < LOF(1)
		For lngCurs = LBound(bytFileToDecode) To UBound(bytFileToDecode)
			'intChar = Asc(InputString(1, 1))
			intChar = bytFileToDecode(lngCurs)
			'Debug.Print(Hex(intChar))

			'Select Case Loc(1)
			Select Case lngCurs
				Case 0, 3 To 17
					'Entête "FE XX XX A0 3D 52 00 84 F9 13 00 B0 16 40 00 7C 02 02 "
				Case 1
					intName = intChar
				Case 2
					intName = intName + (intChar * &H100)
					Debug.Print(Hex(intName))
					intName = intName / 8
					'Ces deux caractères (2-3) sont défini suivant le premier caractère du fichier codé _
					' et le nombre de lettre (avant le .) suivant cette méthode:
					'    lngResult = Asc(LCase(Left(strTitre, 1))) * Len(strTitre)
					'    lngResult = (lngResult Mod 204) * 8 '(204 =&h660 car codé de 8 en 8 de 00 00 à 55 06
					'Sauf s'il commence par "_" où là les 2 caractères sont (&h00 &h00)
				Case Else
					'Récupère l'incrément suivant la position
					'intInc = intInc3(((Loc(1) - 19) Mod 256))
					intInc = intInc3(((lngCurs - 18) Mod 256))
					'Multipli suivant le codage du nom
					intInc = intInc * intName
					'Récupère l'octet de poids faible
					intInc = intInc Mod &H100

					'Récupère le départ suivant position
					'intStart = intStart4(((Loc(1) - 19) Mod 65536))
					intStart = intStart4(((lngCurs - 18) Mod 65536))

					'Debug.Print Hex(lngChar) & "-" & Hex(lngInc) & "-"; Hex(lngStart)

					'Récupère le code ascci du caractère (+&h100 pour être positif)
					intResult = ((&H100 + intChar) - intStart) Mod &H100
					intResult = ((&H100 + intResult) - intInc) Mod &H100

					strHexaChar = ChrW(intResult)
					'Debug.Print(strHexaChar)
					' Valeur de l'entrée décodée
					'FilePut(2, strHexaChar)
					bytFileOutput(lngCurs - 18) = intResult
			End Select
			'End While
		Next lngCurs

		'FileClose()
		If Not My.Computer.FileSystem.DirectoryExists(Strings.Left(strFileOutput, Strings.InStrRev(strFileOutput, "\"))) Then
			My.Computer.FileSystem.CreateDirectory(Strings.Left(strFileOutput, Strings.InStrRev(strFileOutput, "\")))
		End If

		My.Computer.FileSystem.WriteAllBytes(strFileOutput, bytFileOutput, False)
		GetDecodeFileVFE = True
	End Function

End Module
