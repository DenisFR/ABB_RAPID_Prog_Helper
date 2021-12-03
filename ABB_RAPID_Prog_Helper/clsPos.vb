Public Class ClsPos

	'Version 1.0

	' Regroupe les déclarations des variables ABB S4C

	'Modifié par DFraipont
	'
	' Utilise les modules:
	'                       modRobotABB
	' Utilise les Feuilles:
	' Modifications:

	Private my_X As Single
	Private my_Y As Single
	Private my_Z As Single
	Private my_Text As String

	'##############################################################################
	Property X() As Single
		Get
			X = my_X
		End Get
		Set(ByVal Value As Single)
			my_X = Value
		End Set
	End Property

	Property Y() As Single
		Get
			Y = my_Y
		End Get
		Set(ByVal Value As Single)
			my_Y = Value
		End Set
	End Property

	Property Z() As Single
		Get
			Z = my_Z
		End Get
		Set(ByVal Value As Single)
			my_Z = Value
		End Set
	End Property


	Property Text() As String
		Get
			my_Text = "[" & GetEngFromFr(my_X) & "," & GetEngFromFr(my_Y) & "," & GetEngFromFr(my_Z) & "]"
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
			my_X = CSng(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, ",")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Y = CSng(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, "]")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Z = CSng(GetFrFromEng(strTemp))
			my_Text = "[" & GetEngFromFr(my_X) & "," & GetEngFromFr(my_Y) & "," & GetEngFromFr(my_Z) & "]"
		End Set
	End Property

	Public Sub New()
		Text = "[0,0,0]"
	End Sub
End Class
