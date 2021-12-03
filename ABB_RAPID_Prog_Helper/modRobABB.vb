Public Module modRobABB

	'Version 1.00

	' Regroupe les déclarations des variables ABB S4C

	'Modifié par DFraipont
	'
	' Utilise les modules:
	' Utilise les Feuilles:
	' Modifications:


	'##############################################################################
	' Déclarations des types
	Public Enum EnTypes
		enCONST = 1
		enPERS = 2
		enVAR = 3
	End Enum

	'##############################################################################
	' Déclarations des domaines
	Public Enum EnDomaines
		enGLOBAL = 1
		enLOCAL = 2
	End Enum

	' Modifie le format français en format anglais
	Public Function GetFrFromEng(ByVal strValue As String) As String
		Dim lngCursDeb As Integer
		lngCursDeb = InStr(1, strValue, ".")
		If lngCursDeb = 0 Then GetFrFromEng = strValue : Exit Function
		GetFrFromEng = Left(strValue, lngCursDeb - 1)
		GetFrFromEng = GetFrFromEng & "," & Right(strValue, Len(strValue) - lngCursDeb)
	End Function

	' Modifie le format anglais en format français
	Public Function GetEngFromFr(ByVal strValue As String) As String
		Dim lngCursDeb As Integer
		lngCursDeb = InStr(1, strValue, ",")
		If lngCursDeb = 0 Then GetEngFromFr = strValue : Exit Function
		GetEngFromFr = Left(strValue, lngCursDeb - 1)
		GetEngFromFr = GetEngFromFr & "." & Right(strValue, Len(strValue) - lngCursDeb)
	End Function

	' Donne une donnée en format exponentiel
	Public Function GetExpoFromVal(ByVal dblValeur As Double) As String
		If (((System.Math.Abs(dblValeur) < 0.0001) Or (System.Math.Abs(dblValeur) >= 1000000.0#)) And dblValeur <> 0) Then
			If CDbl(dblValeur.ToString("E0")) = CDbl(dblValeur.ToString("E6")) Then
				GetExpoFromVal = dblValeur.ToString("E0").Replace("E+00", "E+0").Replace("E-00", "E-0")
			Else
				GetExpoFromVal = dblValeur.ToString("E6").Replace("E+00", "E+0").Replace("E-00", "E-0")
			End If
		Else
			If CDbl(dblValeur.ToString()) = CDbl(dblValeur.ToString("F6")) Then
				GetExpoFromVal = dblValeur.ToString()
			Else
				GetExpoFromVal = dblValeur.ToString("F6")
			End If
		End If
	End Function

End Module
