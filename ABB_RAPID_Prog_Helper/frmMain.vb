Option Explicit On
Public Class FrmMain

	'Version 1.5

	'Edited by DFraipont
	'
	' Using modules:
	'             modModifPoints
	'             modTrigo
	'             modDecodevFE
	'             modDecodevFD
	'             modDecodevFC
	' Modifications:
	'       v1.5:   Ajout Multi-Langue
	'       v1.4:   Ajout encodage
	'       v1.3:   Ajout décodage
	'       v1.2:   Ajout de la réorientation
	'       v1.1:   Posibilité de rentrer une déclaration de point pour la copier sur d'autre

	'################################################################ Modification ############
	Private Sub CmdModifOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdModifOK.Click
		ModifPoints(clbPoints _
							, IIf(chkModifX.Checked, CSng(GetFrFromEng(txtModifX.Text)), "") _
							, IIf(chkModifY.Checked, CSng(GetFrFromEng(txtModifY.Text)), "") _
							, IIf(chkModifZ.Checked, CSng(GetFrFromEng(txtModifZ.Text)), "") _
							, IIf(chkModifQ1.Checked, CSng(GetFrFromEng(txtModifQ1.Text)), "") _
							, IIf(chkModifQ2.Checked, CSng(GetFrFromEng(txtModifQ2.Text)), "") _
							, IIf(chkModifQ3.Checked, CSng(GetFrFromEng(txtModifQ3.Text)), "") _
							, IIf(chkModifQ4.Checked, CSng(GetFrFromEng(txtModifQ4.Text)), "") _
							, IIf(chkModifCf1.Checked, CSng(GetFrFromEng(txtModifCf1.Text)), "") _
							, IIf(chkModifCf4.Checked, CSng(GetFrFromEng(txtModifCf4.Text)), "") _
							, IIf(chkModifCf6.Checked, CSng(GetFrFromEng(txtModifCf6.Text)), "") _
							, IIf(chkModifCfx.Checked, CSng(GetFrFromEng(txtModifCfx.Text)), ""))
	End Sub

	Private Sub TxtModifX_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModifX.LostFocus
		VerifText(txtModifX)
	End Sub
	Private Sub TxtModifY_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModifY.LostFocus
		VerifText(txtModifY)
	End Sub
	Private Sub TxtModifZ_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModifZ.LostFocus
		VerifText(txtModifZ)
	End Sub
	Private Sub TxtModifQ1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModifQ1.LostFocus
		VerifText(txtModifQ1)
	End Sub
	Private Sub TxtModifQ2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModifQ2.LostFocus
		VerifText(txtModifQ2)
	End Sub
	Private Sub TtxtModifQ3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModifQ3.LostFocus
		VerifText(txtModifQ3)
	End Sub
	Private Sub TxtModifQ4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModifQ4.LostFocus
		VerifText(txtModifQ4)
	End Sub
	Private Sub TxtModifCf1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModifCf1.LostFocus
		VerifText(txtModifCf1)
	End Sub
	Private Sub TxtModifCf4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModifCf4.LostFocus
		VerifText(txtModifCf4)
	End Sub
	Private Sub TxtModifCf6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModifCf6.LostFocus
		VerifText(txtModifCf6)
	End Sub
	Private Sub TxtModifCfx_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModifCfx.LostFocus
		VerifText(txtModifCfx)
	End Sub

	Private Sub TxtRobValue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRobValue.LostFocus
		Dim robTemp As New ClsRobTarget : Dim strBase As String
		' Nombre d'espace à gauche
		Dim lngNbSpace As Integer
		On Error GoTo erreur
		robTemp = New ClsRobTarget : strBase = robTemp.Text
		lngNbSpace = GetNbSpace(txtRobValue.Text)
		robTemp.Text = LTrim(txtRobValue.Text)
		If robTemp.Text <> strBase Then
			If robTemp.Text <> txtRobValue.Text Then txtRobValue.Text = Space(lngNbSpace) & robTemp.Text

			txtRobValue.BackColor = Color.White
			txtModifX.Text = robTemp.Trans.X
			txtModifY.Text = robTemp.Trans.Y
			txtModifZ.Text = robTemp.Trans.Z
			txtModifQ1.Text = robTemp.Rot.Q1
			txtModifQ2.Text = robTemp.Rot.Q2
			txtModifQ3.Text = robTemp.Rot.Q3
			txtModifQ4.Text = robTemp.Rot.Q4
			txtModifCf1.Text = robTemp.Robconf.cf1
			txtModifCf4.Text = robTemp.Robconf.cf4
			txtModifCf6.Text = robTemp.Robconf.cf6
			txtModifCfx.Text = robTemp.Robconf.cfx
		ElseIf txtRobValue.Text <> "" Then
			txtRobValue.BackColor = Color.Red
		End If
		robTemp = Nothing
		Exit Sub
erreur:
		txtModifX.Text = 0
		txtModifY.Text = 0
		txtModifZ.Text = 0
		txtModifQ1.Text = 0
		txtModifQ2.Text = 0
		txtModifQ3.Text = 0
		txtModifQ4.Text = 0
		txtModifCf1.Text = 0
		txtModifCf4.Text = 0
		txtModifCf6.Text = 0
		txtModifCfx.Text = 0
		robTemp = Nothing
	End Sub

	'################################################################ Décalage ################
	Private Sub CmdDecalOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDecalOK.Click
		DecalPoints(clbPoints _
							, IIf(chkDecalX.Checked, CSng(GetFrFromEng(txtDecalX.Text)), "") _
							, IIf(chkDecalY.Checked, CSng(GetFrFromEng(txtDecalY.Text)), "") _
							, IIf(chkDecalZ.Checked, CSng(GetFrFromEng(txtDecalZ.Text)), ""))
	End Sub

	Private Sub TxtDecalX_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDecalX.LostFocus
		VerifText(txtDecalX)
	End Sub
	Private Sub TxtDecalY_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDecalY.LostFocus
		VerifText(txtDecalY)
	End Sub
	Private Sub TxtDecalZ_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDecalZ.LostFocus
		VerifText(txtDecalZ)
	End Sub

	'################################################################ Réorientation ###########
	Private Sub CmdReorientCopy2Modif_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdReorientCopy2Modif.Click
		txtModifQ1.Text = txtReorientQ1.Text
		txtModifQ2.Text = txtReorientQ2.Text
		txtModifQ3.Text = txtReorientQ3.Text
		txtModifQ4.Text = txtReorientQ4.Text
	End Sub

	Private Sub CmdReorientGetFromModif_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdReorientGetFromModif.Click
		txtReorientQ1.Text = txtModifQ1.Text
		txtReorientQ2.Text = txtModifQ2.Text
		txtReorientQ3.Text = txtModifQ3.Text
		txtReorientQ4.Text = txtModifQ4.Text
	End Sub

	Private Sub TxtReorientQ1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReorientQ1.LostFocus
		VerifText(txtReorientQ1)
	End Sub
	Private Sub TxtReorientQ1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReorientQ1.TextChanged
		VerifQuat()
	End Sub
	Private Sub TtxtReorientQ2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReorientQ2.LostFocus
		VerifText(txtReorientQ2)
	End Sub
	Private Sub TxtReorientQ2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReorientQ2.TextChanged
		VerifQuat()
	End Sub
	Private Sub TxtReorientQ3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReorientQ3.LostFocus
		VerifText(txtReorientQ3)
	End Sub
	Private Sub TxtReorientQ3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReorientQ3.TextChanged
		VerifQuat()
	End Sub
	Private Sub TxtReorientQ4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReorientQ4.LostFocus
		VerifText(txtReorientQ4)
	End Sub
	Private Sub TxtReorientQ4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReorientQ4.TextChanged
		VerifQuat()
	End Sub
	Private Sub TxtReorientRX_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReorientRX.LostFocus
		VerifText(txtReorientRX)
	End Sub
	Private Sub TxtReorientRY_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReorientRY.LostFocus
		VerifText(txtReorientRY)
	End Sub
	Private Sub TxtReorientRZ_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReorientRZ.LostFocus
		VerifText(txtReorientRZ)
	End Sub

	Private Sub TxtReorientOriValue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReorientOriValue.LostFocus
		Dim oriTemp As New ClsOrient : Dim strBase As String
		On Error GoTo erreur
		oriTemp = New ClsOrient : strBase = oriTemp.Text
		oriTemp.Text = txtReorientOriValue.Text
		If oriTemp.Text <> strBase Then
			If oriTemp.Text <> txtReorientOriValue.Text Then txtReorientOriValue.Text = oriTemp.Text
			txtReorientOriValue.BackColor = Color.White
			txtReorientQ1.Text = GetEngFromFr(oriTemp.Q1)
			txtReorientQ2.Text = GetEngFromFr(oriTemp.Q2)
			txtReorientQ3.Text = GetEngFromFr(oriTemp.Q3)
			txtReorientQ4.Text = GetEngFromFr(oriTemp.Q4)
		ElseIf txtReorientOriValue.Text <> "" Then
			txtReorientOriValue.BackColor = Color.Red
		End If
		oriTemp = Nothing
		Exit Sub
erreur:
		txtReorientQ1.Text = 0
		txtReorientQ2.Text = 0
		txtReorientQ3.Text = 0
		txtReorientQ4.Text = 0
		oriTemp = Nothing
	End Sub

	Private Sub BtReoUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReoUp.Click
		Dim oriTemp As New ClsOrient
		Dim Quat As TpQuat
		Dim Euler As TpEuler
		Euler.X = GetFrFromEng(txtReorientRX.Text)
		Euler.Y = GetFrFromEng(txtReorientRY.Text)
		Euler.Z = GetFrFromEng(txtReorientRZ.Text)
		GetQuatFEuler(Quat, Euler)
		txtReorientQ1.Text = GetEngFromFr(Quat.Q1)
		txtReorientQ2.Text = GetEngFromFr(Quat.Q2)
		txtReorientQ3.Text = GetEngFromFr(Quat.Q3)
		txtReorientQ4.Text = GetEngFromFr(Quat.Q4)
		VerifText(txtReorientQ1)
		VerifText(txtReorientQ2)
		VerifText(txtReorientQ3)
		VerifText(txtReorientQ4)
		oriTemp.Q1 = Quat.Q1
		oriTemp.Q2 = Quat.Q2
		oriTemp.Q3 = Quat.Q3
		oriTemp.Q4 = Quat.Q4
		txtReorientOriValue.Text = oriTemp.Text
	End Sub
	Private Sub BtReoDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReoDown.Click
		Dim Quat As TpQuat
		Dim Euler As TpEuler
		Quat.Q1 = GetFrFromEng(txtReorientQ1.Text)
		Quat.Q2 = GetFrFromEng(txtReorientQ2.Text)
		Quat.Q3 = GetFrFromEng(txtReorientQ3.Text)
		Quat.Q4 = GetFrFromEng(txtReorientQ4.Text)
		GetEulerFQuat(Euler, Quat)
		txtReorientRX.Text = GetEngFromFr(Euler.X)
		txtReorientRY.Text = GetEngFromFr(Euler.Y)
		txtReorientRZ.Text = GetEngFromFr(Euler.Z)
	End Sub

	'################################################################ Décodage ###################
	Private Sub PagDecod_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pagDecod.DragOver
		pagDecod.Select()
		Stop
	End Sub

	Private Sub CmdDecod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecod.Click
		cmdDecod.Text = My.Resources.DecInProgress
		If My.Computer.Keyboard.CtrlKeyDown Then
			If DecodeFolder("", "") Then
				MsgBox(My.Resources.DecFinished, MsgBoxStyle.Information, "CmdDecod_Click_Folder")
			End If
		Else
			If DecodeFile("", "") Then
				MsgBox(My.Resources.DecFinished, MsgBoxStyle.Information, "CmdDecod_Click_File")
			End If
		End If
		cmdDecod.Text = GetDefaultText("cmdDecod.Text")
	End Sub

	Private Function DecodeFile(ByVal strFileToDecode As String, ByVal strFileOutput As String, Optional ByVal blShowMessNoCrypted As Boolean = False) As Boolean
		Dim intRet As Integer
		DecodeFile = False
		If Not My.Computer.FileSystem.FileExists(strFileToDecode) Then
			ofdOpenFileDialog.CheckFileExists = True : ofdOpenFileDialog.CheckPathExists = True
			ofdOpenFileDialog.Multiselect = False : ofdOpenFileDialog.ValidateNames = True
			ofdOpenFileDialog.FileName = strFileToDecode
			ofdOpenFileDialog.Filter = My.Resources.DecOFDFilter
			If strFileToDecode <> "" Then
				If My.Computer.FileSystem.DirectoryExists(Strings.Left(strFileToDecode, InStrRev(strFileToDecode, "\"))) Then
					ofdOpenFileDialog.InitialDirectory = Strings.Left(strFileToDecode, InStrRev(strFileToDecode, "\"))
				End If
			End If
			ofdOpenFileDialog.Title = My.Resources.DecOFDTitle

			intRet = ofdOpenFileDialog.ShowDialog()
			If intRet = Windows.Forms.DialogResult.Cancel Then Exit Function
			strFileToDecode = ofdOpenFileDialog.FileName
			If Not My.Computer.FileSystem.FileExists(strFileToDecode) Then Exit Function
		End If
		If strFileOutput = "" Then
			sfdSaveFileDialog.CheckFileExists = False : sfdSaveFileDialog.CheckPathExists = True
			sfdSaveFileDialog.ValidateNames = True
			sfdSaveFileDialog.FileName = strFileOutput
			sfdSaveFileDialog.Filter = My.Resources.DecSFDFilter
			If strFileToDecode <> "" Then
				If My.Computer.FileSystem.DirectoryExists(Strings.Left(strFileToDecode, InStrRev(strFileToDecode, "\"))) Then
					ofdOpenFileDialog.InitialDirectory = Strings.Left(strFileToDecode, InStrRev(strFileToDecode, "\"))
				End If
			End If
			sfdSaveFileDialog.Title = My.Resources.DecSFDTitle

			intRet = sfdSaveFileDialog.ShowDialog()
			If intRet = Windows.Forms.DialogResult.Cancel Then Exit Function
			strFileOutput = sfdSaveFileDialog.FileName
			If My.Computer.FileSystem.FileExists(strFileOutput) Then
				My.Computer.FileSystem.DeleteFile(strFileOutput)
			End If
		End If
		DecodeFile = modDecodevFE.GetDecodeFileVFE(strFileToDecode, strFileOutput, blShowMessNoCrypted)
	End Function
	Private Function DecodeFolder(ByVal strFolderToDecode As String, ByVal strFolderOutput As String) As Boolean
		Dim strCursFile, strCursFolder As String
		Dim strFolderIn, strFileIn As String
		Dim blResult As Boolean
		Dim intRet As Integer
		DecodeFolder = False

		If Not My.Computer.FileSystem.DirectoryExists(strFolderToDecode) Then
			fbdFolderBrowserDialog.ShowNewFolderButton = False
			fbdFolderBrowserDialog.Description = My.Resources.DecFoldDesc

			intRet = fbdFolderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.Abort
			If intRet = Windows.Forms.DialogResult.Cancel Then Exit Function
			strFolderToDecode = fbdFolderBrowserDialog.SelectedPath
			If Not My.Computer.FileSystem.DirectoryExists(strFolderToDecode) Then Exit Function
		End If
		If strFolderOutput = "" Then
			fbdFolderBrowserDialog.ShowNewFolderButton = True
			fbdFolderBrowserDialog.SelectedPath = strFolderToDecode
			fbdFolderBrowserDialog.Description = My.Resources.DecFoldDescSave
			Do
				intRet = fbdFolderBrowserDialog.ShowDialog()
				If intRet = Windows.Forms.DialogResult.Cancel Then Exit Function
			Loop While Strings.Left(fbdFolderBrowserDialog.SelectedPath & "\", Len(strFolderToDecode) + 1) = strFolderToDecode & "\"
			strFolderOutput = fbdFolderBrowserDialog.SelectedPath
			If (My.Computer.FileSystem.GetFiles(strFolderOutput).Count > 0) _
				Or (My.Computer.FileSystem.GetDirectories(strFolderOutput).Count > 0) Then
				intRet = MsgBox(String.Format(My.Resources.DecFoldMsg, strFolderOutput) _
											 , MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "frmMain.DecodeFolder")
				If intRet = MsgBoxResult.No Then Exit Function

				For Each strCursFolder In My.Computer.FileSystem.GetDirectories(strFolderOutput)
					My.Computer.FileSystem.DeleteDirectory(strCursFolder, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
				Next
				For Each strCursFile In My.Computer.FileSystem.GetFiles(strFolderOutput)
					My.Computer.FileSystem.DeleteFile(strCursFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
				Next
			End If
		End If
		blResult = True
		For Each strCursFolder In My.Computer.FileSystem.GetDirectories(strFolderToDecode)
			strFolderIn = Strings.Right(strCursFolder, Len(strCursFolder) - Len(strFolderToDecode))
			blResult = blResult And DecodeFolder(strCursFolder, strFolderOutput & strFolderIn)
		Next
		For Each strCursFile In My.Computer.FileSystem.GetFiles(strFolderToDecode)
			strFileIn = Strings.Right(strCursFile, Len(strCursFile) - Len(strFolderToDecode))
			blResult = blResult And DecodeFile(strCursFile, strFolderOutput & strFileIn, True)
		Next
		DecodeFolder = blResult
	End Function
	Private Sub CmdDecod_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles cmdDecod.DragDrop
		Dim intCurs As Integer
		' Gestion Fichier.
		cmdDecod.Text = My.Resources.DecInProgress
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			' Assign the file names to a string array, in 
			' case the user has selected multiple files.
			Dim strFiles As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
			Try
				For intCurs = 0 To UBound(strFiles)

					If FileIO.FileSystem.FileExists(strFiles(intCurs)) Then
						DecodeFile(strFiles(intCurs), "")
					ElseIf FileIO.FileSystem.DirectoryExists(strFiles(intCurs)) Then
						DecodeFolder(strFiles(intCurs), "")
					End If
				Next
			Catch ex As Exception
				MessageBox.Show(ex.Message, "cmdDecod_DragDrop")
				Return
			End Try
		End If
		cmdDecod.Text = GetDefaultText("cmdDecod.Text")
	End Sub
	Private Sub CmdDecod_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles cmdDecod.DragEnter
		' Si les données sont de type Texte ou Fichier, afficher le curseur de copie.
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			cmdDecod.Text = My.Resources.DecAvailable
			e.Effect = DragDropEffects.Copy
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub
	Private Sub CmdDecod_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDecod.DragLeave
		cmdDecod.Text = GetDefaultText("cmdDecod.Text")
	End Sub


	'################################################################ Encodage ###################
	Private Sub PagEncod_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pagEncod.DragOver
		pagEncod.Select()
		Stop
	End Sub

	Private Sub CmdEncod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEncod.Click
		cmdEncod.Text = My.Resources.EncInProgress
		If EncodeFile("", "") Then
			MsgBox(My.Resources.EncFinished, MsgBoxStyle.Information, "CmdEncod_Click_File")
		End If
		cmdEncod.Text = GetDefaultText("cmdEncod.Text")
	End Sub

	Private Function EncodeFile(ByVal strFileToEncode As String, ByVal strFileOutput As String) As Boolean
		Dim intRet As Integer
		EncodeFile = False

		If Not My.Computer.FileSystem.FileExists(strFileToEncode) Then
			ofdOpenFileDialog.CheckFileExists = True : ofdOpenFileDialog.CheckPathExists = True
			ofdOpenFileDialog.Multiselect = False : ofdOpenFileDialog.ValidateNames = True
			ofdOpenFileDialog.FileName = strFileToEncode
			ofdOpenFileDialog.Filter = My.Resources.EncOFDFilter
			If strFileToEncode <> "" Then
				If My.Computer.FileSystem.DirectoryExists(Strings.Left(strFileToEncode, InStrRev(strFileToEncode, "\"))) Then
					ofdOpenFileDialog.InitialDirectory = Strings.Left(strFileToEncode, InStrRev(strFileToEncode, "\"))
				End If
			End If
			ofdOpenFileDialog.Title = My.Resources.EncOFDTitle

			intRet = ofdOpenFileDialog.ShowDialog()
			If intRet = Windows.Forms.DialogResult.Cancel Then Exit Function
			strFileToEncode = ofdOpenFileDialog.FileName
			If Not My.Computer.FileSystem.FileExists(strFileToEncode) Then Exit Function
		End If
		If strFileOutput = "" Then
			sfdSaveFileDialog.CheckFileExists = False : sfdSaveFileDialog.CheckPathExists = True
			sfdSaveFileDialog.ValidateNames = True
			sfdSaveFileDialog.FileName = strFileOutput
			sfdSaveFileDialog.Filter = My.Resources.EncSFDFilter
			If strFileToEncode <> "" Then
				If My.Computer.FileSystem.DirectoryExists(Strings.Left(strFileToEncode, InStrRev(strFileToEncode, "\"))) Then
					ofdOpenFileDialog.InitialDirectory = Strings.Left(strFileToEncode, InStrRev(strFileToEncode, "\"))
				End If
			End If
			sfdSaveFileDialog.Title = My.Resources.EncSFDTitle

			intRet = sfdSaveFileDialog.ShowDialog()
			If intRet = Windows.Forms.DialogResult.Cancel Then Exit Function
			strFileOutput = sfdSaveFileDialog.FileName
			If My.Computer.FileSystem.FileExists(strFileOutput) Then
				My.Computer.FileSystem.DeleteFile(strFileOutput)
			End If
		End If

		Select Case cbEncodeVers.SelectedIndex
			Case 2
				EncodeFile = modEncodevFC.GetEncodeFileVFC(strFileToEncode, strFileOutput)
			Case 1
				EncodeFile = modEncodevFD.GetEncodeFileVFD(strFileToEncode, strFileOutput)
			Case Else
				EncodeFile = modEncodevFE.GetEncodeFileVFE(strFileToEncode, strFileOutput)
		End Select
	End Function
	Private Sub CmdEncod_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles cmdEncod.DragDrop
		Dim intCurs As Integer
		' Gestion Fichier.
		cmdEncod.Text = My.Resources.EncInProgress
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			' Assign the file names to a string array, in 
			' case the user has selected multiple files.
			Dim strFiles As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
			Try
				For intCurs = 0 To UBound(strFiles)

					If FileIO.FileSystem.FileExists(strFiles(intCurs)) Then
						EncodeFile(strFiles(intCurs), "")
					End If
				Next
			Catch ex As Exception
				MessageBox.Show(ex.Message, "cmdEncod_DragDrop")
				Return
			End Try
		End If
		cmdEncod.Text = GetDefaultText("cmdEncod.Text")
	End Sub
	Private Sub CmdEncod_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles cmdEncod.DragEnter
		' Si les données sont de type Texte ou Fichier, afficher le curseur de copie.
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			cmdEncod.Text = My.Resources.EncAvailable
			e.Effect = DragDropEffects.Copy
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub
	Private Sub CmdEncod_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEncod.DragLeave
		cmdEncod.Text = GetDefaultText("cmdEncod.Text")
	End Sub

	'################################################################ Liste ###################
	Private Sub ClbPoints_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles clbPoints.DragDrop
		' Gestion Fichier.
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			' Assign the file names to a string array, in 
			' case the user has selected multiple files.
			Dim strFiles As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
			Try
				If FileIO.FileSystem.FileExists(strFiles(0)) Then
					If FileIO.FileSystem.ReadAllText(strFiles(0)).Contains("robtarget") Then
						AddRobTarget(Me.clbPoints, FileIO.FileSystem.ReadAllText(strFiles(0)))
					End If
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message, "clbPoints_DragDrop")
				Return
			End Try
		End If

		' Handle Text data.
		If e.Data.GetDataPresent(DataFormats.Text) Then
			Try
				AddRobTarget(Me.clbPoints, e.Data.GetData(DataFormats.Text))
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				Return
			End Try
		End If

	End Sub

	Private Sub ClbPoints_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles clbPoints.DragEnter
		' Si les données sont de type Texte ou Fichier, afficher le curseur de copie.
		If e.Data.GetDataPresent(DataFormats.Text) _
			 Or e.Data.GetDataPresent(DataFormats.FileDrop) Then
			e.Effect = DragDropEffects.Copy
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub

	Private Sub ClbPoints_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles clbPoints.ItemCheck
		If e.CurrentValue = CheckState.Indeterminate Then
			e.NewValue = CheckState.Indeterminate
			'clbPoints.SetItemCheckState(e.Index, CheckState.Indeterminate)
		End If
	End Sub

	Private Sub CmnuLBPointsCopier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuLBPointsCopier.Click
		Dim strLignes As String = ""
		For lngcurs As Long = 0 To clbPoints.Items.Count - 1
			strLignes = strLignes & clbPoints.Items(lngcurs) & ChrW(13) + ChrW(10)
		Next
		Clipboard.SetText(strLignes)
	End Sub
	Private Sub CmnuLBPointsColler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuLBPointsColler.Click
		If Clipboard.ContainsText Then
			AddRobTarget(clbPoints, Clipboard.GetText())
		End If
	End Sub
	Private Sub CmnuLBPointsEffacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuLBPointsEffacer.Click
		clbPoints.Items.Clear()
	End Sub
	Private Sub CmnuLBPointsEffacerTout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuLBPointsEffacerTout.Click
		Me.chkModifX.Checked = False : Me.txtModifX.Text = "0"
		Me.chkModifY.Checked = False : Me.txtModifY.Text = "0"
		Me.chkModifZ.Checked = False : Me.txtModifZ.Text = "0"

		Me.chkModifQ1.Checked = False : Me.txtModifQ1.Text = "1"
		Me.chkModifQ2.Checked = False : Me.txtModifQ2.Text = "0"
		Me.chkModifQ3.Checked = False : Me.txtModifQ3.Text = "0"
		Me.chkModifQ4.Checked = False : Me.txtModifQ4.Text = "0"

		Me.chkModifCf1.Checked = False : Me.txtModifCf1.Text = "0"
		Me.chkModifCf4.Checked = False : Me.txtModifCf4.Text = "0"
		Me.chkModifCf6.Checked = False : Me.txtModifCf6.Text = "0"
		Me.chkModifCfx.Checked = False : Me.txtModifCfx.Text = "0"

		Me.txtRobValue.Text = ""

		Me.chkDecalX.Checked = False : Me.txtDecalX.Text = "0"
		Me.chkDecalY.Checked = False : Me.txtDecalY.Text = "0"
		Me.chkDecalZ.Checked = False : Me.txtDecalZ.Text = "0"

		Me.txtReorientQ1.Text = "1" : Me.txtReorientQ2.Text = "0" : Me.txtReorientQ3.Text = "0" : Me.txtReorientQ4.Text = "0"
		Me.txtReorientRX.Text = "0" : Me.txtReorientRY.Text = "0" : Me.txtReorientRZ.Text = "0"
		Me.txtReorientOriValue.Text = ""

		clbPoints.Items.Clear()
	End Sub
	Private Sub CmnuLBPointsSelRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuLBPointsSelRef.Click
		txtRobValue.Text = Trim(clbPoints.SelectedItem)
		TxtRobValue_LostFocus(sender, e)
	End Sub
	Private Sub CmnuLBPointsSelTout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuLBPointsSelTout.Click
		Dim intCurs As Integer
		For intCurs = 0 To clbPoints.Items.Count - 1
			If clbPoints.GetItemCheckState(intCurs) = CheckState.Unchecked Then
				clbPoints.SetItemCheckState(intCurs, CheckState.Checked)
			End If
		Next
	End Sub
	Private Sub CmnuLBPointsSelAucun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuLBPointsSelAucun.Click
		Dim clbiCurs As Integer
		For Each clbiCurs In clbPoints.CheckedIndices
			If clbPoints.GetItemCheckState(clbiCurs) = CheckState.Checked Then
				clbPoints.SetItemCheckState(clbiCurs, CheckState.Unchecked)
			End If
		Next
	End Sub
	Private Sub CmnuLBPointsSelInverser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuLBPointsSelInverser.Click
		Dim intCurs As Integer
		For intCurs = 0 To clbPoints.Items.Count - 1
			Select Case clbPoints.GetItemCheckState(intCurs)
				Case CheckState.Unchecked : clbPoints.SetItemCheckState(intCurs, CheckState.Checked)
				Case CheckState.Checked : clbPoints.SetItemCheckState(intCurs, CheckState.Unchecked)
			End Select
		Next
	End Sub

	'################################################################ mltpChoix ###############
	Private Sub MltpChoix_DoubleClick(sender As Object, e As EventArgs) Handles mltpChoix.DoubleClick
		If My.Computer.Keyboard.CtrlKeyDown Then
			Dim culListInstalled As Globalization.CultureInfo() = GetInstalledCultures()
			Dim strCurCul As String = Threading.Thread.CurrentThread.CurrentUICulture.ToString
			Dim bTakeNext As Boolean = False
			Dim nextCul As String = ""

			If culListInstalled.Length > 0 Then

				For Each cul As Globalization.CultureInfo In culListInstalled
					If bTakeNext Then
						nextCul = cul.ToString
					End If
					bTakeNext = (cul.ToString = strCurCul)
				Next
				If nextCul = "" Then
					nextCul = culListInstalled(0).ToString
				End If
				ChangeLanguage(nextCul)
			End If
		End If
	End Sub

	'################################################################ Fonctions ###############
	Private Shared Function GetInstalledCultures() As Globalization.CultureInfo()
		Static result As New List(Of Globalization.CultureInfo)
		If result.Count = 0 Then
			Dim rm As New ComponentModel.ComponentResourceManager(GetType(FrmMain))
			Dim culListAll As Globalization.CultureInfo() = Globalization.CultureInfo.GetCultures(Globalization.CultureTypes.AllCultures)
			For Each cul As Globalization.CultureInfo In culListAll
				If Not cul.Equals(Globalization.CultureInfo.InvariantCulture) Then
					If Not IsNothing(rm.GetResourceSet(cul, True, False)) Then
						result.Add(cul)
					End If
				End If
			Next
		End If
		Return result.ToArray
	End Function
	Private Shared Function GetDefaultText(ByVal componentName As String) As String
		Static resources As New ComponentModel.ComponentResourceManager(GetType(FrmMain))
		Return resources.GetString(componentName)
	End Function

	Private Sub VerifText(ByRef txtText As TextBox)
		Dim strText As String
		On Error GoTo erreur
		strText = txtText.Text
		If strText <> GetEngFromFr(strText) Then
			txtText.Text = GetEngFromFr(strText)
		End If
		strText = txtText.Text
		If GetFrFromEng(strText) <> GetExpoFromVal(CDbl(GetFrFromEng(strText))) Then
			txtText.Text = GetEngFromFr(GetExpoFromVal(CDbl(GetFrFromEng(strText))))
		End If
		Exit Sub
erreur:
		MsgBox(My.Resources.VerifTextError & ttToolTip.GetToolTip(txtText), MsgBoxStyle.Critical, "VerifText " & txtText.Name)
		txtText.Text = 0
	End Sub
	Private Sub VerifQuat()
		Dim Q1 As Double
		Dim Q2 As Double
		Dim Q3 As Double
		Dim Q4 As Double
		Dim strTemp As String

		If txtReorientQ1.Text = "" _
		Or txtReorientQ2.Text = "" _
		Or txtReorientQ3.Text = "" _
		Or txtReorientQ4.Text = "" Then Exit Sub

		On Error GoTo Erreure
		Q1 = GetFrFromEng(txtReorientQ1.Text) ^ 2
		Q2 = GetFrFromEng(txtReorientQ2.Text) ^ 2
		Q3 = GetFrFromEng(txtReorientQ3.Text) ^ 2
		Q4 = GetFrFromEng(txtReorientQ4.Text) ^ 2
		If (Q1 + Q2 + Q3 + Q4) < 1.00001 And (Q1 + Q2 + Q3 + Q4) > 0.9999 Then
			imgReorientQuatOK.BackColor = System.Drawing.Color.Lime
		Else
			imgReorientQuatOK.BackColor = System.Drawing.Color.Red
		End If
		Exit Sub
Erreure:
		If Strings.Right(txtReorientQ1.Text, 1) <> "E" _
	   And Strings.Right(txtReorientQ1.Text, 1) <> "-" _
	   And Strings.Right(txtReorientQ2.Text, 1) <> "E" _
	   And Strings.Right(txtReorientQ2.Text, 1) <> "-" _
	   And Strings.Right(txtReorientQ3.Text, 1) <> "E" _
	   And Strings.Right(txtReorientQ3.Text, 1) <> "-" _
	   And Strings.Right(txtReorientQ4.Text, 1) <> "E" _
	   And Strings.Right(txtReorientQ4.Text, 1) <> "-" Then
			MsgBox(Err.Description, MsgBoxStyle.Critical, "frmMain.VerifQuat")
		End If
		Exit Sub
	End Sub

	Private Shared Sub AddRobTarget(ByRef clbListe As CheckedListBox, ByVal strTexte As String)
		Dim robTemp As ClsRobTarget : Dim strBase As String
		Dim strCurs As String = strTexte
		' Nombre d'espace à gauche
		Dim lngNbSpace As Integer

		While Strings.InStr(strTexte, ChrW(13) + ChrW(10)) <> 0
			strCurs = Strings.Left(strTexte, Strings.InStr(strTexte, ChrW(13) + ChrW(10)) - 1)
			lngNbSpace = GetNbSpace(strCurs)

			robTemp = New ClsRobTarget : strBase = robTemp.Text
			robTemp.Text = Trim(strCurs)
			If robTemp.Text <> strBase Then
				If robTemp.Text <> LTrim(strCurs) Then strCurs = Space(lngNbSpace) & robTemp.Text

				clbListe.Items.Add(strCurs, True)
			Else
				clbListe.Items.Add(strCurs, CheckState.Indeterminate)
			End If
			strTexte = Strings.Right(strTexte, Len(strTexte) - Strings.InStr(strTexte, ChrW(13) + ChrW(10)) - 1)
		End While

	End Sub

	Private Sub ChangeLanguage(ByVal lang As String)
		Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo(lang)
		Dim resources As New ComponentModel.ComponentResourceManager(GetType(FrmMain))
		ApplyResourceToControl(Me, New ComponentModel.ComponentResourceManager(GetType(FrmMain)) _
								 , New Globalization.CultureInfo(lang))
		Me.Text = GetDefaultText("$this.Text") + " v" + My.Application.Info.Version.ToString
	End Sub
	Private Sub ApplyResourceToControl(control As Control, cmp As ComponentModel.ComponentResourceManager _
														 , cultureInfo As Globalization.CultureInfo)
		For Each child As Control In control.Controls
			'Store current position And size of the control
			Dim childSize = child.Size
			Dim childLoc = child.Location
			'Apply CultureInfo to child control
			ApplyResourceToControl(child, cmp, cultureInfo)
			'Restore position And size
			child.Location = childLoc
			child.Size = childSize
		Next child
		'Do the same with the parent control
		Dim parentSize = control.Size
		Dim parentLoc = control.Location
		cmp.ApplyResources(control, IIf(control Is Me, "$this", control.Name), cultureInfo)
		Me.ttToolTip.SetToolTip(control, cmp.GetString(IIf(control Is Me, "$this", control.Name) + ".ToolTip"))
		If Not IsNothing(control.ContextMenuStrip) Then
			ApplyResourceToToolStripItemCollection(control.ContextMenuStrip.Items, cmp, cultureInfo)
		End If
		control.Location = parentLoc
		control.Size = parentSize
	End Sub
	Private Sub ApplyResourceToToolStripItemCollection(col As ToolStripItemCollection, cmp As ComponentModel.ComponentResourceManager _
																					 , cultureInfo As Globalization.CultureInfo)
		For i = 0 To col.Count - 1    ' Apply to all sub items
			Dim tsi As ToolStripItem = col(i)
			If tsi.GetType() = GetType(ToolStripMenuItem) Then
				Dim tsmi As ToolStripMenuItem = col(i)
				ApplyResourceToToolStripItemCollection(tsmi.DropDownItems, cmp, cultureInfo)
			End If

			cmp.ApplyResources(tsi, tsi.Name, cultureInfo)
			tsi.ToolTipText = cmp.GetString(col(i).Name + ".ToolTipText")
		Next
	End Sub

	'################################################################ frmMain #################

	Private Sub FrmMain_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
		txtRobValue.Width = mltpChoix.Width - txtRobValue.Left - 11
		cmdModifOK.Width = mltpChoix.Width - cmdModifOK.Left - 11
		cmdDecalOK.Width = mltpChoix.Width - cmdDecalOK.Left - 11
		txtReorientOriValue.Width = mltpChoix.Width - txtReorientOriValue.Left - 11
		cmdEncod.Width = mltpChoix.Width - cmdEncod.Left - 11
		cbEncodeVers.Left = mltpChoix.Width - cbEncodeVers.Width - 11
		lblEncodeVers.Left = cbEncodeVers.Left - lblEncodeVers.Width - 3
	End Sub


	Public Sub New()

		InitializeComponent()

		Me.Text = GetDefaultText("$this.Text") + " v" + My.Application.Info.Version.ToString

		Me.cbEncodeVers.SelectedIndex = 0
	End Sub
End Class
