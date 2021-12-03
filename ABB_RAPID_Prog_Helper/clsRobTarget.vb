Public Class ClsRobTarget

	'Version 1.1

	' Regroupe les déclarations des variables ABB S4C

	'Modifié par DFraipont
	'
	' Utilise les modules:
	'             modRobotABB
	' Utilise les Feuilles:
	' Modifications:
	'       v1.1:   Correction lorsque le text entré et un tableau


	'##############################################################################
	' Déclarations des types

	Private my_Domaine As EnDomaines
	Private ReadOnly strDomaine(2) As String
	Private my_Types As EnTypes
	Private ReadOnly strTypes(3) As String
	Private my_Nom As String
	Private my_Trans As New ClsPos
	Private my_Rot As New ClsOrient
	Private my_Robconf As New ClsConfData
	Private my_Extax As New ClsExtJoint
	Private my_Text As String

	Public Property Domaine() As EnDomaines
		Get
			Domaine = my_Domaine
		End Get
		Set(ByVal Value As EnDomaines)
			my_Domaine = Domaine
		End Set
	End Property
	Public Property Types() As EnTypes
		Get
			Types = my_Types
		End Get
		Set(ByVal Value As EnTypes)
			my_Types = Types
		End Set
	End Property
	Public Property Nom() As String
		Get
			Nom = my_Nom
		End Get
		Set(ByVal Value As String)
			my_Nom = Nom
		End Set
	End Property
	Public Property Trans() As Object
		Get
			Trans = my_Trans
		End Get
		Set(ByVal Value As Object)
			my_Trans = Trans
		End Set
	End Property
	Public Property Rot() As Object
		Get
			Rot = my_Rot
		End Get
		Set(ByVal Value As Object)
			my_Rot = Rot
		End Set
	End Property
	Public Property Robconf() As Object
		Get
			Robconf = my_Robconf
		End Get
		Set(ByVal Value As Object)
			my_Robconf = Robconf
		End Set
	End Property
	Public Property Extax() As Object
		Get
			Extax = my_Extax
		End Get
		Set(ByVal Value As Object)
			my_Extax = Extax
		End Set
	End Property


	Property Text() As String
		Get
			my_Text = Trim(strDomaine(CInt(my_Domaine)) & strTypes(CInt(my_Types)) & " " & "robtarget" & " " & my_Nom & ":=[" & my_Trans.Text & "," & my_Rot.Text & "," & my_Robconf.Text & "," & my_Extax.Text & "];")
			Text = my_Text
		End Get
		Set(ByVal Value As String)
			Dim strTypes As String
			Dim lngCursDeb As Integer
			Dim lngCursFin As Integer

			If InStr(Value, "robtarget") = 0 Then Return
			If InStr(Value, "!") <> 0 Then Return
			If InStr(Value, "{") <> 0 Then Return
			If Left(Trim(Value), 5) = "LOCAL" Then
				my_Domaine = EnDomaines.enLOCAL
				lngCursDeb = 6
			Else
				my_Domaine = EnDomaines.enGLOBAL
				lngCursDeb = 1
			End If
			lngCursFin = InStr(lngCursDeb, Value, " robtarget")
			strTypes = Trim(Mid(Value, lngCursDeb, lngCursFin - lngCursDeb))
			Select Case strTypes
				Case "CONST"
					my_Types = EnTypes.enCONST
				Case "PERS"
					my_Types = EnTypes.enPERS
				Case "VAR"
					my_Types = EnTypes.enVAR
			End Select
			lngCursDeb = lngCursFin + 11
			lngCursFin = InStr(lngCursDeb, Value, ":=[")
			my_Nom = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			lngCursDeb = lngCursFin + 3
			lngCursFin = InStr(lngCursDeb, Value, ",[")
			my_Trans.Text = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, ",[")
			my_Rot.Text = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, ",[")
			my_Robconf.Text = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			lngCursDeb = lngCursFin + 1
			lngCursFin = InStr(lngCursDeb, Value, ";")
			my_Extax.Text = Mid(Value, lngCursDeb, lngCursFin - lngCursDeb)
			my_Text = Text

		End Set
	End Property

	Public Sub New()
		strDomaine(EnDomaines.enGLOBAL) = ""
		strDomaine(EnDomaines.enLOCAL) = "LOCAL "
		strTypes(EnTypes.enCONST) = "CONST"
		strTypes(EnTypes.enPERS) = "PERS"
		strTypes(EnTypes.enVAR) = "VAR"

		my_Domaine = EnDomaines.enGLOBAL
		my_Types = EnTypes.enCONST
		my_Nom = "rob1"
		my_Trans = New ClsPos
		my_Rot = New ClsOrient
		my_Robconf = New ClsConfData
		my_Extax = New ClsExtJoint
	End Sub

End Class
