Module modDecodevFC
	'Version 1.0

	'Modification:
	' V1.0 Création
	Private lngInc0 As Long
	Private ReadOnly lngInc1(3) As Integer
	Private ReadOnly lngInc2(15) As Integer
	Private ReadOnly lngInc3(63) As Integer
	Private ReadOnly lngInc4(255) As Integer
	Private lngIncA0 As Integer
	Private ReadOnly lngIncA1(3) As Integer
	Private ReadOnly lngIncA2(15) As Integer
	Private ReadOnly lngIncA3(63) As Integer

	Private lngDecMul1_0 As Integer
	Private ReadOnly lngDecMul1_1(3) As Integer
	Private ReadOnly lngDecMul1_2(15) As Integer
	Private ReadOnly lngDecMul1_3(63) As Integer

	Private Sub MakeInc()
		Dim lngCurs As Long
		lngInc0 = &H40
		lngInc1(0) = &H10 '&HF0
		For lngCurs = 1 To 3
			lngInc1(lngCurs) = (lngInc1(lngCurs - 1) + lngInc0) Mod &H100
		Next
		lngInc2(0) = &H34 ' &H34
		For lngCurs = 1 To 15
			lngInc2(lngCurs) = (lngInc2(lngCurs - 1) + lngInc1((lngCurs - 1) Mod 4)) Mod &H100
		Next
		lngInc3(0) = &HE9 ' &H17
		For lngCurs = 1 To 63
			lngInc3(lngCurs) = (lngInc3(lngCurs - 1) + lngInc2((lngCurs - 1) Mod 16)) Mod &H100
		Next
		lngInc4(0) = &H32
		For lngCurs = 1 To 255
			lngInc4(lngCurs) = (lngInc4(lngCurs - 1) + lngInc3((lngCurs - 1) Mod 64)) Mod &H100
		Next
	End Sub


	Private Sub MakeIncA()
		Dim lngCurs As Long
		lngIncA0 = &H70
		lngIncA1(0) = &HF0
		lngIncA1(1) = &HF0
		lngIncA1(2) = &H70
		lngIncA1(3) = &H70

		'  For lngCurs = 2 To 4
		'    lngIncA1(lngCurs) = CLng("&H" & Right(Hex(lngIncA1(lngCurs - 1) + lngIncA0), 2))
		'  Next
		lngIncA2(0) = &H4C ' &H34
		For lngCurs = 1 To 15
			lngIncA2(lngCurs) = (lngIncA2(lngCurs - 1) + lngIncA1((lngCurs - 1) Mod 4)) Mod &H100
		Next
		lngIncA3(0) = &HA9 ' &H17
		For lngCurs = 1 To 63
			lngIncA3(lngCurs) = (&H100 + lngIncA3(lngCurs - 1) - lngIncA2((lngCurs - 1) Mod 16)) Mod &H100
		Next
		'  lngIncA4(0) = &H32
		'  For lngCurs = 1 To 255
		'    lngIncA4(lngCurs) = CLng("&H" & Right(Hex(lngIncA4(lngCurs - 1) + lngIncA3((lngCurs - 1) Mod 64)), 2))
		'    lngIncA4(lngCurs) = (lngIncA4(lngCurs - 1) + lngIncA3((lngCurs - 1) Mod 64)) Mod &H100
		'  Next
	End Sub

	Private Sub MakeDecal()
		Dim lngCurs As Integer

		lngDecMul1_0 = &H40

		lngDecMul1_1(0) = &HD0
		For lngCurs = 1 To 3
			lngDecMul1_1(lngCurs) = (lngDecMul1_1(lngCurs - 1) + lngDecMul1_0) Mod &H100
		Next lngCurs

		lngDecMul1_2(0) = &HA4
		For lngCurs = 1 To 15
			lngDecMul1_2(lngCurs) = (lngDecMul1_2(lngCurs - 1) + lngDecMul1_1(((lngCurs - 1) Mod 4))) Mod &H100
		Next lngCurs

		lngDecMul1_3(0) = &H15
		For lngCurs = 1 To 63
			lngDecMul1_3(lngCurs) = (lngDecMul1_3(lngCurs - 1) + lngDecMul1_2(((lngCurs - 1) Mod 16))) Mod &H100
		Next lngCurs
	End Sub

	Private Function GetDecal(ByVal intSource As Integer, ByVal intMul1 As Integer, ByVal intMul2 As Integer, ByVal intNumLigne As Integer) As Integer
		Dim intDec1 As Integer
		Dim intDec2 As Integer
		Dim intRes As Integer
		Dim intCursLig As Integer

		Select Case intNumLigne
			Case 0 To 2
				GetDecal = intSource : Exit Function
			Case 3 To 7
				intCursLig = intNumLigne - 2
			Case 8 To 17
				GetDecal = intSource : Exit Function
			Case Else
				intCursLig = intNumLigne - 18 + 5
		End Select

		MakeDecal()
		intDec1 = (lngDecMul1_3(intCursLig Mod 64) * (intMul1 / 8)) Mod &H100
		intDec2 = (IIf((intCursLig Mod 2) = 1, &H20, &HA0) * intMul2) Mod &H100
		intRes = (&H300 + intSource - intDec1 - intDec2) Mod &H100
		GetDecal = intRes
	End Function

	Public Function GetDecodeFileVFC(ByVal strFileToDecode As String, ByVal strFileOutput As String, Optional ByVal blShowMessNoCrypted As Boolean = False) As Boolean
		Dim intChar As Integer
		Dim strHexaChar As String
		Dim intInc As Integer 'Incrément pour cette colonne
		Dim intResult As Integer 'Résultat
		Dim bytFileToDecode() As Byte
		Dim bytFileOutput() As Byte
		Dim lngCurs As Long
		Dim intStartCoding As Integer
		Dim intCode1 As Integer
		Dim intCode2 As Integer
		GetDecodeFileVFC = False

		MakeInc()
		MakeIncA()


		'FileClose()
		If Not My.Computer.FileSystem.FileExists(strFileToDecode) Then
			MsgBox(String.Format(My.Resources.NoFileExist, strFileToDecode) _
				  , MsgBoxStyle.Critical, "modDecodevFC.GetDecodeFileVFC ")
			Exit Function
		End If
		If strFileOutput = "" Then Exit Function
		If My.Computer.FileSystem.FileExists(strFileOutput) Then
			intChar = MsgBox(String.Format(My.Resources.FileAlreadyExist, strFileOutput) _
							, MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "modDecodevFC.GetDecodeFileVFC ")
			If intChar = MsgBoxResult.No Then Exit Function
			My.Computer.FileSystem.DeleteFile(strFileOutput, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
		End If

		'FileOpen(1, strFileToDecode, OpenMode.Binary, OpenAccess.Read)
		'FileOpen(2, strFileOutput, OpenMode.Binary, OpenAccess.Write)
		bytFileToDecode = My.Computer.FileSystem.ReadAllBytes(strFileToDecode)
		If bytFileToDecode(0) <> &HFC Then
			If Not blShowMessNoCrypted Then
				MsgBox(String.Format(My.Resources.FileNotCoded, strFileToDecode) _
					  , vbCritical, "modDecodevFC.GetDecodeFileVFC")
			Else
				My.Computer.FileSystem.CopyFile(strFileToDecode, strFileOutput)
				GetDecodeFileVFC = True
			End If

			Exit Function
		End If

		intStartCoding = 18
		'If bytFileToDecode(17) = &H0 Then
		'  intStartCoding = 58
		'  blIsTask0Mod = True
		'End If

		ReDim bytFileOutput(UBound(bytFileToDecode) - intStartCoding) 'Entête

		'While Loc(1) < LOF(1)
		For lngCurs = LBound(bytFileToDecode) To UBound(bytFileToDecode)
			'intChar = Asc(InputString(1, 1))
			intChar = bytFileToDecode(lngCurs)
			'Debug.Print(Hex(intChar))

			'Select Case Loc(1)
			Select Case lngCurs
				Case 0 To 5, 8 To (intStartCoding - 1)
					'Entête "FC YY YY YY YY 01 C1 C2 XX XX XX XX XX YY YY YY YY 01 "
				Case 6 'C1
					intCode1 = intChar '(intChar \ 16)
				Case 7 'C2
					intCode2 = intChar
				Case Else
					'Récupère l'incrément suivant la position
					intInc = lngInc4((lngCurs - intStartCoding) Mod 256)
					'intInc = &H100 + intInc - lngIncA3((lngCurs - intStartCoding) Mod 64)
					'Récupère l'octet de poids faible
					intInc = intInc Mod &H100

					'Récupère le code ascci du caractère (+&h100 pour être positif)
					'intResult = SupDecal(intChar, intCode1, intCode2, lngCurs) '- intStartCoding)
					intResult = GetDecal(intChar, intCode1, intCode2, lngCurs)
					intResult = ((&H100 + intResult) + intInc) Mod &H100

					strHexaChar = ChrW(intResult)
					'Debug.Print(strHexaChar)
					' Valeur de l'entrée décodée
					'FilePut(2, strHexaChar)
					bytFileOutput(lngCurs - intStartCoding) = intResult
			End Select
			'End While
		Next lngCurs

		'FileClose()
		If Not My.Computer.FileSystem.DirectoryExists(Strings.Left(strFileOutput, Strings.InStrRev(strFileOutput, "\"))) Then
			My.Computer.FileSystem.CreateDirectory(Strings.Left(strFileOutput, Strings.InStrRev(strFileOutput, "\")))
		End If

		My.Computer.FileSystem.WriteAllBytes(strFileOutput, bytFileOutput, False)
		GetDecodeFileVFC = True
	End Function

End Module
