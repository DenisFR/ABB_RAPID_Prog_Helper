Public Class ClsOrient

	'Version 1.0

	' Regroupe les déclarations des variables ABB S4C

	'Modifié par DFraipont
	'
	' Utilise les modules:
	' Utilise les Feuilles:
	' Modifications:

	Private my_Q1 As Double
	Private my_Q2 As Double
	Private my_Q3 As Double
	Private my_Q4 As Double
	Private my_Text As String

	'##############################################################################
	Property Q1() As Double
		Get
			Q1 = my_Q1
		End Get
		Set(ByVal Value As Double)
			my_Q1 = Value
		End Set
	End Property

	Property Q2() As Double
		Get
			Q2 = my_Q2
		End Get
		Set(ByVal Value As Double)
			my_Q2 = Value
		End Set
	End Property

	Property Q3() As Double
		Get
			Q3 = my_Q3
		End Get
		Set(ByVal Value As Double)
			my_Q3 = Value
		End Set
	End Property

	Property Q4() As Double
		Get
			Q4 = my_Q4
		End Get
		Set(ByVal Value As Double)
			my_Q4 = Value
		End Set
	End Property


	Property Text() As String
		Get
			my_Text = "[" & GetEngFromFr(GetExpoFromVal(my_Q1)) & "," & GetEngFromFr(GetExpoFromVal(my_Q2)) & "," & GetEngFromFr(GetExpoFromVal(my_Q3)) & "," & GetEngFromFr(GetExpoFromVal(my_Q4)) & "]"
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
			my_Q1 = CDbl(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, ",")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Q2 = CDbl(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, ",")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Q3 = CDbl(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, "]")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Q4 = CDbl(GetFrFromEng(strTemp))
			my_Text = "[" & GetEngFromFr(GetExpoFromVal(my_Q1)) & "," & GetEngFromFr(GetExpoFromVal(my_Q2)) & "," & GetEngFromFr(GetExpoFromVal(my_Q3)) & "," & GetEngFromFr(GetExpoFromVal(my_Q4)) & "]"
		End Set
	End Property

	Public Sub New()
		Text = "[0,0,0,0]"
	End Sub
End Class
