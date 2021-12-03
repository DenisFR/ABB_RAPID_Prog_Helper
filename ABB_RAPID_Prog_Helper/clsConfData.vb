Public Class ClsConfData

	'Version 1.0

	' Regroupe les déclarations des variables ABB S4C

	'Modifié par DFraipont
	'
	' Utilise les modules:
	' Utilise les Feuilles:
	' Modifications:

	Private my_Cf1 As Single
	Private my_Cf4 As Single
	Private my_Cf6 As Single
	Private my_Cfx As Single
	Private my_Text As String

	'##############################################################################
	Public Property Cf1() As Single
		Get
			Cf1 = my_Cf1
		End Get
		Set(ByVal Value As Single)
			my_Cf1 = Value
		End Set
	End Property

	Public Property Cf4() As Single
		Get
			Cf4 = my_Cf4
		End Get
		Set(ByVal Value As Single)
			my_Cf4 = Value
		End Set
	End Property

	Public Property Cf6() As Single
		Get
			Cf6 = my_Cf6
		End Get
		Set(ByVal Value As Single)
			my_Cf6 = Value
		End Set
	End Property

	Public Property Cfx() As Single
		Get
			Cfx = my_Cfx
		End Get
		Set(ByVal Value As Single)
			my_Cfx = Value
		End Set
	End Property


	Property Text() As String
		Get
			my_Text = "[" & GetEngFromFr(my_Cf1) & "," & GetEngFromFr(my_Cf4) & "," & GetEngFromFr(my_Cf6) & "," & GetEngFromFr(my_Cfx) & "]"
			Text = my_Text
		End Get
		Set(ByVal Value As String)
			Dim lngCursDeb As Integer
			Dim lngCursFin As Integer
			Dim strTemp As String
			If InStr(Value, "[") <> 1 Then Exit Property
			lngCursDeb = 2
			lngCursFin = InStr(lngCursDeb, Value, ",")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Cf1 = CSng(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, ",")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Cf4 = CSng(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, ",")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Cf6 = CSng(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, "]")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Cfx = CSng(GetFrFromEng(strTemp))
			my_Text = "[" & GetEngFromFr(my_Cf1) & "," & GetEngFromFr(my_Cf4) & "," & GetEngFromFr(my_Cf6) & "," & GetEngFromFr(my_Cfx) & "]"
		End Set
	End Property

	Public Sub New()
		Text = "[0,0,0,0]"
	End Sub
End Class
