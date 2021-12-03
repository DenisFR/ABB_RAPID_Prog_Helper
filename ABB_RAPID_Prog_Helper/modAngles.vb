Public Module modAngles

	'Origin: http://membres.lycos.fr/javamus/articles/mqfaq.html
	'Version 1.00
	'Edited by DFraipont

	' Utilise les classes:
	' Utilise les fenêtres
	' Utilise les modules
	' Modifications :

	'Index des matrices ColLig
	Const M11 As Short = 0
	Const M12 As Short = 1
	Const M13 As Short = 2
	Const M14 As Short = 3
	Const M21 As Short = 4
	Const M22 As Short = 5
	Const M23 As Short = 6
	Const M24 As Short = 7
	Const M31 As Short = 8
	Const M32 As Short = 9
	Const M33 As Short = 10
	Const M34 As Short = 11
	Const M41 As Short = 12
	Const M42 As Short = 13
	Const M43 As Short = 14
	Const M44 As Short = 15

	' Type Quaternion
	Public Structure TpQuat
		Dim Q1 As Double
		Dim Q2 As Double
		Dim Q3 As Double
		Dim Q4 As Double
	End Structure

	' Type Rotation Euler
	Public Structure TpEuler
		Dim X As Double
		Dim Y As Double
		Dim Z As Double
	End Structure

	' Récupère un Quaternion depuis une Rotation Euler
	Public Sub GetQuatFEuler(ByRef Quat As TpQuat, ByRef Euler As TpEuler)
		Dim Matrice(16) As Double
		GetMatFEuler(Matrice, Euler)
		GetQuatFMat(Quat, Matrice)
	End Sub

	' Récupère une Rotation Euler depuis un Quaternion
	Public Sub GetEulerFQuat(ByRef Euler As TpEuler, ByRef Quat As TpQuat)
		Dim Matrice(16) As Double
		GetMatFQuat(Matrice, Quat)
		GetEulerFMat(Euler, Matrice)
	End Sub

	' Récupère un Quaternion depuis une Matrice
	Public Sub GetQuatFMat(ByRef Quat As TpQuat, ByRef Matrice() As Double)
		Dim lngSigne As Integer

		Quat.Q1 = System.Math.Sqrt(Matrice(M11) + Matrice(M22) + Matrice(M33) + 1) / 2
		lngSigne = IIf((Matrice(M23) - Matrice(M32)) >= 0, 1, -1)
		Quat.Q2 = lngSigne * System.Math.Sqrt(Matrice(M11) - Matrice(M22) - Matrice(M33) + 1) / 2
		lngSigne = IIf((Matrice(M31) - Matrice(M13)) >= 0, 1, -1)
		Quat.Q3 = lngSigne * System.Math.Sqrt(Matrice(M22) - Matrice(M33) - Matrice(M11) + 1) / 2
		lngSigne = IIf((Matrice(M12) - Matrice(M21)) >= 0, 1, -1)
		Quat.Q4 = lngSigne * System.Math.Sqrt(Matrice(M33) - Matrice(M11) - Matrice(M22) + 1) / 2

	End Sub

	' Récupère une Matrice depuis un Quaternion
	Public Sub GetMatFQuat(ByRef Matrice() As Double, ByRef Quat As TpQuat)

		Matrice(M11) = 2 * (Quat.Q1 * Quat.Q1 + Quat.Q2 * Quat.Q2) - 1
		Matrice(M12) = 2 * (Quat.Q2 * Quat.Q3 + Quat.Q1 * Quat.Q4)
		Matrice(M13) = 2 * (Quat.Q2 * Quat.Q4 - Quat.Q1 * Quat.Q3)
		Matrice(M14) = 0

		Matrice(M21) = 2 * (Quat.Q2 * Quat.Q3 - Quat.Q1 * Quat.Q4)
		Matrice(M22) = 2 * (Quat.Q1 * Quat.Q1 + Quat.Q3 * Quat.Q3) - 1
		Matrice(M23) = 2 * (Quat.Q3 * Quat.Q4 + Quat.Q1 * Quat.Q2)
		Matrice(M24) = 0

		Matrice(M31) = 2 * (Quat.Q2 * Quat.Q4 + Quat.Q1 * Quat.Q3)
		Matrice(M32) = 2 * (Quat.Q3 * Quat.Q4 - Quat.Q1 * Quat.Q2)
		Matrice(M33) = 2 * (Quat.Q1 * Quat.Q1 + Quat.Q4 * Quat.Q4) - 1
		Matrice(M34) = 0

		Matrice(M41) = 0
		Matrice(M42) = 0
		Matrice(M43) = 0
		Matrice(M44) = 1
	End Sub

	' Récupère une Matrice depuis une Rotation Euler
	Public Sub GetMatFEuler(ByRef Matrice() As Double, ByRef Euler As TpEuler)
		Dim dCRX As Double
		Dim dSRX As Double
		Dim dCRY As Double
		Dim dSRY As Double
		Dim dCRZ As Double
		Dim dSRZ As Double
		dCRX = System.Math.Cos(Deg2Rad(Euler.X))
		dSRX = System.Math.Sin(Deg2Rad(Euler.X))
		dCRY = System.Math.Cos(Deg2Rad(Euler.Y))
		dSRY = System.Math.Sin(Deg2Rad(Euler.Y))
		dCRZ = System.Math.Cos(Deg2Rad(Euler.Z))
		dSRZ = System.Math.Sin(Deg2Rad(Euler.Z))
		Dim dCRXxSRY As Double
		Dim dSRXxSRY As Double
		dCRXxSRY = dCRX * dSRY
		dSRXxSRY = dSRX * dSRY

		Matrice(M11) = dCRY * dCRZ
		Matrice(M12) = dCRY * dSRZ '-dCRY * dSRZ
		Matrice(M13) = -dSRY
		Matrice(M14) = 0

		Matrice(M21) = -(-dSRXxSRY * dCRZ + dCRX * dSRZ) '-dSRXxSRY * dCRZ + dCRX * dSRZ
		Matrice(M22) = dSRXxSRY * dSRZ + dCRX * dCRZ
		Matrice(M23) = dSRX * dCRY '-dSRX * dCRY
		Matrice(M24) = 0

		Matrice(M31) = dCRXxSRY * dCRZ + dSRX * dSRZ
		Matrice(M32) = -(-dCRXxSRY * dSRZ + dSRX * dCRZ) '-dCRXxSRY * dSRZ + dSRX * dCRZ
		Matrice(M33) = dCRX * dCRY
		Matrice(M34) = 0

		Matrice(M41) = 0
		Matrice(M42) = 0
		Matrice(M43) = 0
		Matrice(M44) = 1
	End Sub

	' Récupère une Rotation Euler depuis une Matrice
	Public Sub GetEulerFMat(ByRef Euler As TpEuler, ByRef Matrice() As Double)
		Dim Angle_X As Double
		Dim Angle_Y As Double
		Dim Angle_Z As Double
		Const DBL_EPSILON As Double = 0.005

		Dim sp As Double
		Dim cp As Double
		If ((System.Math.Abs(Matrice(M11)) < DBL_EPSILON) And (System.Math.Abs(Matrice(M12)) < DBL_EPSILON)) Then
			Angle_Z = 0
			Angle_Y = ATan2(-Matrice(M13), Matrice(M11))
			Angle_X = ATan2(-Matrice(M32), Matrice(M22))
		Else
			Angle_Z = ATan2(Matrice(M12), Matrice(M11))
			sp = System.Math.Sin(Angle_Z)
			cp = System.Math.Cos(Angle_Z)
			Angle_Y = ATan2(-Matrice(M13), cp * Matrice(M11) + sp * Matrice(M12))
			Angle_X = ATan2(sp * Matrice(M31) - cp * Matrice(M32), cp * Matrice(M22) - sp * Matrice(M21))
		End If
		Angle_X = Clamp(Rad2Deg(Angle_X), -180, 180) ' Modulo ;) */
		Angle_Y = Clamp(Rad2Deg(Angle_Y), -180, 180)
		Angle_Z = Clamp(Rad2Deg(Angle_Z), -180, 180)
		Euler.X = Angle_X
		Euler.Y = Angle_Y
		Euler.Z = Angle_Z
	End Sub


	' Transformation d'unité d'angle
	Public Function Rad2Deg(ByRef dblAngleRad As Double) As Object
		Rad2Deg = (dblAngleRad * (180 / PI()))
	End Function
	Public Function Deg2Rad(ByRef dblAngleDeg As Double) As Object
		Deg2Rad = (dblAngleDeg * (PI() / 180))
	End Function

	' Fonction sinus inverse
	Public Function ArcSin(ByRef X As Double) As Double
		If X = 1 Then
			ArcSin = PI() / 2
		ElseIf X = -1 Then
			ArcSin = -PI() / 2
		Else
			ArcSin = System.Math.Atan(X / System.Math.Sqrt(-X * X + 1))
		End If
	End Function

	' Fonction récupérant un angle sur 360°
	Public Function ATan2(ByRef Y As Double, ByRef X As Double) As Double
		' Retourne l'ArcTangente basé sur les coordonnées de X et Y
		' Si X et Y sont tous deux à zéro une erreur se produit.
		' La valeur de l'axe des X est supposée être +0, allant dans le sens positif dans la direction
		' opposée aux aiguilles d'une montre, et dans le sens négatif dans le sens des aiguilles d'une montre.
		If X = 0 Then
			If Y = 0 Then
				ATan2 = 1 / 0
			ElseIf Y > 0 Then
				ATan2 = PI() / 2
			Else
				ATan2 = -PI() / 2
			End If
		ElseIf X > 0 Then
			If Y = 0 Then
				ATan2 = 0
			Else
				ATan2 = System.Math.Atan(Y / X)
			End If
		Else
			If Y = 0 Then
				ATan2 = PI()
			Else
				ATan2 = (PI() - System.Math.Atan(System.Math.Abs(Y) / System.Math.Abs(X))) * System.Math.Sign(Y)
			End If
		End If
	End Function

	' Récupère le nombre PI avec précision
	Public Function PI() As Double
		PI = System.Math.Atan(1) * 4
	End Function

	' Reformate un angle
	Public Function Clamp(ByVal dblAngle As Double, ByVal dblDeb As Double, ByVal dblEnd As Double) As Double
		While dblAngle > dblEnd
			dblAngle = dblAngle - (dblEnd - dblDeb)
		End While
		While dblAngle < dblDeb
			dblAngle = dblAngle + (dblEnd - dblDeb)
		End While
		Clamp = dblAngle
	End Function

End Module
