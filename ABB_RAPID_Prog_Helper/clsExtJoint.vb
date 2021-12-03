Public Class ClsExtJoint

	'Version 1.0

	' Regroupe les déclarations des variables ABB S4C

	'Modifié par DFraipont
	'
	' Utilise les modules:
	' Utilise les Feuilles:
	' Modifications:

	Private my_Eax_a As Double
	Private my_Eax_b As Double
	Private my_Eax_c As Double
	Private my_Eax_d As Double
	Private my_Eax_e As Double
	Private my_Eax_f As Double
	Private my_Text As String

	'##############################################################################
	Public Property Eax_a() As Double
		Get
			Eax_a = my_Eax_a
		End Get
		Set(ByVal Value As Double)
			my_Eax_a = Value
		End Set
	End Property

	Public Property Eax_b() As Double
		Get
			Eax_b = my_Eax_b
		End Get
		Set(ByVal Value As Double)
			my_Eax_b = Value
		End Set
	End Property

	Public Property Eax_c() As Double
		Get
			Eax_c = my_Eax_c
		End Get
		Set(ByVal Value As Double)
			my_Eax_c = Value
		End Set
	End Property

	Public Property Eax_d() As Double
		Get
			Eax_d = my_Eax_d
		End Get
		Set(ByVal Value As Double)
			my_Eax_d = Value
		End Set
	End Property

	Public Property Eax_e() As Double
		Get
			Eax_e = my_Eax_e
		End Get
		Set(ByVal Value As Double)
			my_Eax_e = Value
		End Set
	End Property

	Public Property Eax_f() As Double
		Get
			Eax_f = my_Eax_f
		End Get
		Set(ByVal Value As Double)
			my_Eax_f = Value
		End Set
	End Property

	Public Property Text() As String
		Get
			my_Text = "[" & GetEngFromFr(GetExpoFromVal(my_Eax_a)) & "," & GetEngFromFr(GetExpoFromVal(my_Eax_b)) & "," & GetEngFromFr(GetExpoFromVal(my_Eax_c)) & "," & GetEngFromFr(GetExpoFromVal(my_Eax_d)) & "," & GetEngFromFr(GetExpoFromVal(my_Eax_e)) & "," & GetEngFromFr(GetExpoFromVal(my_Eax_f)) & "]"
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
			my_Eax_a = CDbl(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, ",")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Eax_b = CDbl(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, ",")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Eax_c = CDbl(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, ",")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Eax_d = CDbl(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, ",")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Eax_e = CDbl(GetFrFromEng(strTemp))
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, "]")
			strTemp = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Eax_f = CDbl(GetFrFromEng(strTemp))
			my_Text = "[" & GetEngFromFr(GetExpoFromVal(my_Eax_a)) & "," & GetEngFromFr(GetExpoFromVal(my_Eax_b)) & "," & GetEngFromFr(GetExpoFromVal(my_Eax_c)) & "," & GetEngFromFr(GetExpoFromVal(my_Eax_d)) & "," & GetEngFromFr(GetExpoFromVal(my_Eax_e)) & "," & GetEngFromFr(GetExpoFromVal(my_Eax_f)) & "]"
		End Set
	End Property

	Public Sub New()
		Text = "[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]"
	End Sub
End Class
