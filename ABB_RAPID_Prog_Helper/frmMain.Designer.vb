<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.mltpChoix = New System.Windows.Forms.TabControl()
        Me.pagModif = New System.Windows.Forms.TabPage()
        Me.cmdModifOK = New System.Windows.Forms.Button()
        Me.txtRobValue = New System.Windows.Forms.TextBox()
        Me.lblRobValue = New System.Windows.Forms.Label()
        Me.fraRobConf = New System.Windows.Forms.GroupBox()
        Me.txtModifCfx = New System.Windows.Forms.TextBox()
        Me.chkModifCfx = New System.Windows.Forms.CheckBox()
        Me.txtModifCf6 = New System.Windows.Forms.TextBox()
        Me.chkModifCf6 = New System.Windows.Forms.CheckBox()
        Me.txtModifCf4 = New System.Windows.Forms.TextBox()
        Me.chkModifCf4 = New System.Windows.Forms.CheckBox()
        Me.txtModifCf1 = New System.Windows.Forms.TextBox()
        Me.chkModifCf1 = New System.Windows.Forms.CheckBox()
        Me.fraRot = New System.Windows.Forms.GroupBox()
        Me.txtModifQ4 = New System.Windows.Forms.TextBox()
        Me.chkModifQ4 = New System.Windows.Forms.CheckBox()
        Me.txtModifQ3 = New System.Windows.Forms.TextBox()
        Me.chkModifQ3 = New System.Windows.Forms.CheckBox()
        Me.txtModifQ2 = New System.Windows.Forms.TextBox()
        Me.chkModifQ2 = New System.Windows.Forms.CheckBox()
        Me.txtModifQ1 = New System.Windows.Forms.TextBox()
        Me.chkModifQ1 = New System.Windows.Forms.CheckBox()
        Me.fraTrans = New System.Windows.Forms.GroupBox()
        Me.txtModifZ = New System.Windows.Forms.TextBox()
        Me.chkModifZ = New System.Windows.Forms.CheckBox()
        Me.txtModifY = New System.Windows.Forms.TextBox()
        Me.chkModifY = New System.Windows.Forms.CheckBox()
        Me.txtModifX = New System.Windows.Forms.TextBox()
        Me.chkModifX = New System.Windows.Forms.CheckBox()
        Me.pagDecal = New System.Windows.Forms.TabPage()
        Me.cmdDecalOK = New System.Windows.Forms.Button()
        Me.fraDecalTrans = New System.Windows.Forms.GroupBox()
        Me.txtDecalZ = New System.Windows.Forms.TextBox()
        Me.chkDecalZ = New System.Windows.Forms.CheckBox()
        Me.txtDecalY = New System.Windows.Forms.TextBox()
        Me.chkDecalY = New System.Windows.Forms.CheckBox()
        Me.txtDecalX = New System.Windows.Forms.TextBox()
        Me.chkDecalX = New System.Windows.Forms.CheckBox()
        Me.pagReorient = New System.Windows.Forms.TabPage()
        Me.btReoDown = New System.Windows.Forms.Button()
        Me.btReoUp = New System.Windows.Forms.Button()
        Me.txtReorientOriValue = New System.Windows.Forms.TextBox()
        Me.lblReorientOriValue = New System.Windows.Forms.Label()
        Me.frmReorientEuler = New System.Windows.Forms.GroupBox()
        Me.txtReorientRZ = New System.Windows.Forms.TextBox()
        Me.txtReorientRY = New System.Windows.Forms.TextBox()
        Me.txtReorientRX = New System.Windows.Forms.TextBox()
        Me.lblReorientRZ = New System.Windows.Forms.Label()
        Me.lblReorientRY = New System.Windows.Forms.Label()
        Me.lblReorientRX = New System.Windows.Forms.Label()
        Me.cmdReorientCopy2Modif = New System.Windows.Forms.Button()
        Me.cmdReorientGetFromModif = New System.Windows.Forms.Button()
        Me.frmReorientQuat = New System.Windows.Forms.GroupBox()
        Me.lblReorientQ4 = New System.Windows.Forms.Label()
        Me.lblReorientQ3 = New System.Windows.Forms.Label()
        Me.lblReorientQ2 = New System.Windows.Forms.Label()
        Me.lblReorientQ1 = New System.Windows.Forms.Label()
        Me.imgReorientQuatOK = New System.Windows.Forms.PictureBox()
        Me.txtReorientQ4 = New System.Windows.Forms.TextBox()
        Me.txtReorientQ3 = New System.Windows.Forms.TextBox()
        Me.txtReorientQ2 = New System.Windows.Forms.TextBox()
        Me.txtReorientQ1 = New System.Windows.Forms.TextBox()
        Me.pagDecod = New System.Windows.Forms.TabPage()
        Me.cmdDecod = New System.Windows.Forms.Button()
        Me.pagEncod = New System.Windows.Forms.TabPage()
        Me.lblEncodeVers = New System.Windows.Forms.Label()
        Me.cbEncodeVers = New System.Windows.Forms.ComboBox()
        Me.cmdEncod = New System.Windows.Forms.Button()
        Me.ttToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.clbPoints = New System.Windows.Forms.CheckedListBox()
        Me.cmnuLBPoints = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuLBPointsCopier = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuLBPointsColler = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuLBPointsEffacer = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuLBPointsEffacerTout = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuLBPointsSelRef = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmnuLBPointsSel = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuLBPointsSelTout = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuLBPointsSelAucun = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuLBPointsSelInverser = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.fbdFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.mltpChoix.SuspendLayout()
        Me.pagModif.SuspendLayout()
        Me.fraRobConf.SuspendLayout()
        Me.fraRot.SuspendLayout()
        Me.fraTrans.SuspendLayout()
        Me.pagDecal.SuspendLayout()
        Me.fraDecalTrans.SuspendLayout()
        Me.pagReorient.SuspendLayout()
        Me.frmReorientEuler.SuspendLayout()
        Me.frmReorientQuat.SuspendLayout()
        CType(Me.imgReorientQuatOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagDecod.SuspendLayout()
        Me.pagEncod.SuspendLayout()
        Me.cmnuLBPoints.SuspendLayout()
        Me.SuspendLayout()
        '
        'mltpChoix
        '
        Me.mltpChoix.AllowDrop = True
        Me.mltpChoix.Controls.Add(Me.pagModif)
        Me.mltpChoix.Controls.Add(Me.pagDecal)
        Me.mltpChoix.Controls.Add(Me.pagReorient)
        Me.mltpChoix.Controls.Add(Me.pagDecod)
        Me.mltpChoix.Controls.Add(Me.pagEncod)
        resources.ApplyResources(Me.mltpChoix, "mltpChoix")
        Me.mltpChoix.HotTrack = True
        Me.mltpChoix.Name = "mltpChoix"
        Me.mltpChoix.SelectedIndex = 0
        '
        'pagModif
        '
        Me.pagModif.Controls.Add(Me.cmdModifOK)
        Me.pagModif.Controls.Add(Me.txtRobValue)
        Me.pagModif.Controls.Add(Me.lblRobValue)
        Me.pagModif.Controls.Add(Me.fraRobConf)
        Me.pagModif.Controls.Add(Me.fraRot)
        Me.pagModif.Controls.Add(Me.fraTrans)
        resources.ApplyResources(Me.pagModif, "pagModif")
        Me.pagModif.Name = "pagModif"
        Me.pagModif.UseVisualStyleBackColor = True
        '
        'cmdModifOK
        '
        resources.ApplyResources(Me.cmdModifOK, "cmdModifOK")
        Me.cmdModifOK.Name = "cmdModifOK"
        Me.ttToolTip.SetToolTip(Me.cmdModifOK, resources.GetString("cmdModifOK.ToolTip"))
        Me.cmdModifOK.UseVisualStyleBackColor = True
        '
        'txtRobValue
        '
        resources.ApplyResources(Me.txtRobValue, "txtRobValue")
        Me.txtRobValue.Name = "txtRobValue"
        Me.ttToolTip.SetToolTip(Me.txtRobValue, resources.GetString("txtRobValue.ToolTip"))
        '
        'lblRobValue
        '
        resources.ApplyResources(Me.lblRobValue, "lblRobValue")
        Me.lblRobValue.Name = "lblRobValue"
        '
        'fraRobConf
        '
        Me.fraRobConf.Controls.Add(Me.txtModifCfx)
        Me.fraRobConf.Controls.Add(Me.chkModifCfx)
        Me.fraRobConf.Controls.Add(Me.txtModifCf6)
        Me.fraRobConf.Controls.Add(Me.chkModifCf6)
        Me.fraRobConf.Controls.Add(Me.txtModifCf4)
        Me.fraRobConf.Controls.Add(Me.chkModifCf4)
        Me.fraRobConf.Controls.Add(Me.txtModifCf1)
        Me.fraRobConf.Controls.Add(Me.chkModifCf1)
        resources.ApplyResources(Me.fraRobConf, "fraRobConf")
        Me.fraRobConf.Name = "fraRobConf"
        Me.fraRobConf.TabStop = False
        '
        'txtModifCfx
        '
        resources.ApplyResources(Me.txtModifCfx, "txtModifCfx")
        Me.txtModifCfx.Name = "txtModifCfx"
        Me.ttToolTip.SetToolTip(Me.txtModifCfx, resources.GetString("txtModifCfx.ToolTip"))
        '
        'chkModifCfx
        '
        resources.ApplyResources(Me.chkModifCfx, "chkModifCfx")
        Me.chkModifCfx.Name = "chkModifCfx"
        Me.ttToolTip.SetToolTip(Me.chkModifCfx, resources.GetString("chkModifCfx.ToolTip"))
        Me.chkModifCfx.UseVisualStyleBackColor = True
        '
        'txtModifCf6
        '
        resources.ApplyResources(Me.txtModifCf6, "txtModifCf6")
        Me.txtModifCf6.Name = "txtModifCf6"
        Me.ttToolTip.SetToolTip(Me.txtModifCf6, resources.GetString("txtModifCf6.ToolTip"))
        '
        'chkModifCf6
        '
        resources.ApplyResources(Me.chkModifCf6, "chkModifCf6")
        Me.chkModifCf6.Name = "chkModifCf6"
        Me.ttToolTip.SetToolTip(Me.chkModifCf6, resources.GetString("chkModifCf6.ToolTip"))
        Me.chkModifCf6.UseVisualStyleBackColor = True
        '
        'txtModifCf4
        '
        resources.ApplyResources(Me.txtModifCf4, "txtModifCf4")
        Me.txtModifCf4.Name = "txtModifCf4"
        Me.ttToolTip.SetToolTip(Me.txtModifCf4, resources.GetString("txtModifCf4.ToolTip"))
        '
        'chkModifCf4
        '
        resources.ApplyResources(Me.chkModifCf4, "chkModifCf4")
        Me.chkModifCf4.Name = "chkModifCf4"
        Me.ttToolTip.SetToolTip(Me.chkModifCf4, resources.GetString("chkModifCf4.ToolTip"))
        Me.chkModifCf4.UseVisualStyleBackColor = True
        '
        'txtModifCf1
        '
        resources.ApplyResources(Me.txtModifCf1, "txtModifCf1")
        Me.txtModifCf1.Name = "txtModifCf1"
        Me.ttToolTip.SetToolTip(Me.txtModifCf1, resources.GetString("txtModifCf1.ToolTip"))
        '
        'chkModifCf1
        '
        resources.ApplyResources(Me.chkModifCf1, "chkModifCf1")
        Me.chkModifCf1.Name = "chkModifCf1"
        Me.ttToolTip.SetToolTip(Me.chkModifCf1, resources.GetString("chkModifCf1.ToolTip"))
        Me.chkModifCf1.UseVisualStyleBackColor = True
        '
        'fraRot
        '
        Me.fraRot.Controls.Add(Me.txtModifQ4)
        Me.fraRot.Controls.Add(Me.chkModifQ4)
        Me.fraRot.Controls.Add(Me.txtModifQ3)
        Me.fraRot.Controls.Add(Me.chkModifQ3)
        Me.fraRot.Controls.Add(Me.txtModifQ2)
        Me.fraRot.Controls.Add(Me.chkModifQ2)
        Me.fraRot.Controls.Add(Me.txtModifQ1)
        Me.fraRot.Controls.Add(Me.chkModifQ1)
        resources.ApplyResources(Me.fraRot, "fraRot")
        Me.fraRot.Name = "fraRot"
        Me.fraRot.TabStop = False
        '
        'txtModifQ4
        '
        resources.ApplyResources(Me.txtModifQ4, "txtModifQ4")
        Me.txtModifQ4.Name = "txtModifQ4"
        Me.ttToolTip.SetToolTip(Me.txtModifQ4, resources.GetString("txtModifQ4.ToolTip"))
        '
        'chkModifQ4
        '
        resources.ApplyResources(Me.chkModifQ4, "chkModifQ4")
        Me.chkModifQ4.Name = "chkModifQ4"
        Me.ttToolTip.SetToolTip(Me.chkModifQ4, resources.GetString("chkModifQ4.ToolTip"))
        Me.chkModifQ4.UseVisualStyleBackColor = True
        '
        'txtModifQ3
        '
        resources.ApplyResources(Me.txtModifQ3, "txtModifQ3")
        Me.txtModifQ3.Name = "txtModifQ3"
        Me.ttToolTip.SetToolTip(Me.txtModifQ3, resources.GetString("txtModifQ3.ToolTip"))
        '
        'chkModifQ3
        '
        resources.ApplyResources(Me.chkModifQ3, "chkModifQ3")
        Me.chkModifQ3.Name = "chkModifQ3"
        Me.ttToolTip.SetToolTip(Me.chkModifQ3, resources.GetString("chkModifQ3.ToolTip"))
        Me.chkModifQ3.UseVisualStyleBackColor = True
        '
        'txtModifQ2
        '
        resources.ApplyResources(Me.txtModifQ2, "txtModifQ2")
        Me.txtModifQ2.Name = "txtModifQ2"
        Me.ttToolTip.SetToolTip(Me.txtModifQ2, resources.GetString("txtModifQ2.ToolTip"))
        '
        'chkModifQ2
        '
        resources.ApplyResources(Me.chkModifQ2, "chkModifQ2")
        Me.chkModifQ2.Name = "chkModifQ2"
        Me.ttToolTip.SetToolTip(Me.chkModifQ2, resources.GetString("chkModifQ2.ToolTip"))
        Me.chkModifQ2.UseVisualStyleBackColor = True
        '
        'txtModifQ1
        '
        resources.ApplyResources(Me.txtModifQ1, "txtModifQ1")
        Me.txtModifQ1.Name = "txtModifQ1"
        Me.ttToolTip.SetToolTip(Me.txtModifQ1, resources.GetString("txtModifQ1.ToolTip"))
        '
        'chkModifQ1
        '
        resources.ApplyResources(Me.chkModifQ1, "chkModifQ1")
        Me.chkModifQ1.Name = "chkModifQ1"
        Me.ttToolTip.SetToolTip(Me.chkModifQ1, resources.GetString("chkModifQ1.ToolTip"))
        Me.chkModifQ1.UseVisualStyleBackColor = True
        '
        'fraTrans
        '
        Me.fraTrans.Controls.Add(Me.txtModifZ)
        Me.fraTrans.Controls.Add(Me.chkModifZ)
        Me.fraTrans.Controls.Add(Me.txtModifY)
        Me.fraTrans.Controls.Add(Me.chkModifY)
        Me.fraTrans.Controls.Add(Me.txtModifX)
        Me.fraTrans.Controls.Add(Me.chkModifX)
        resources.ApplyResources(Me.fraTrans, "fraTrans")
        Me.fraTrans.Name = "fraTrans"
        Me.fraTrans.TabStop = False
        '
        'txtModifZ
        '
        resources.ApplyResources(Me.txtModifZ, "txtModifZ")
        Me.txtModifZ.Name = "txtModifZ"
        Me.ttToolTip.SetToolTip(Me.txtModifZ, resources.GetString("txtModifZ.ToolTip"))
        '
        'chkModifZ
        '
        resources.ApplyResources(Me.chkModifZ, "chkModifZ")
        Me.chkModifZ.Name = "chkModifZ"
        Me.ttToolTip.SetToolTip(Me.chkModifZ, resources.GetString("chkModifZ.ToolTip"))
        Me.chkModifZ.UseVisualStyleBackColor = True
        '
        'txtModifY
        '
        resources.ApplyResources(Me.txtModifY, "txtModifY")
        Me.txtModifY.Name = "txtModifY"
        Me.ttToolTip.SetToolTip(Me.txtModifY, resources.GetString("txtModifY.ToolTip"))
        '
        'chkModifY
        '
        resources.ApplyResources(Me.chkModifY, "chkModifY")
        Me.chkModifY.Name = "chkModifY"
        Me.ttToolTip.SetToolTip(Me.chkModifY, resources.GetString("chkModifY.ToolTip"))
        Me.chkModifY.UseVisualStyleBackColor = True
        '
        'txtModifX
        '
        resources.ApplyResources(Me.txtModifX, "txtModifX")
        Me.txtModifX.Name = "txtModifX"
        Me.ttToolTip.SetToolTip(Me.txtModifX, resources.GetString("txtModifX.ToolTip"))
        '
        'chkModifX
        '
        resources.ApplyResources(Me.chkModifX, "chkModifX")
        Me.chkModifX.Name = "chkModifX"
        Me.ttToolTip.SetToolTip(Me.chkModifX, resources.GetString("chkModifX.ToolTip"))
        Me.chkModifX.UseVisualStyleBackColor = True
        '
        'pagDecal
        '
        Me.pagDecal.Controls.Add(Me.cmdDecalOK)
        Me.pagDecal.Controls.Add(Me.fraDecalTrans)
        resources.ApplyResources(Me.pagDecal, "pagDecal")
        Me.pagDecal.Name = "pagDecal"
        Me.pagDecal.UseVisualStyleBackColor = True
        '
        'cmdDecalOK
        '
        resources.ApplyResources(Me.cmdDecalOK, "cmdDecalOK")
        Me.cmdDecalOK.Name = "cmdDecalOK"
        Me.ttToolTip.SetToolTip(Me.cmdDecalOK, resources.GetString("cmdDecalOK.ToolTip"))
        Me.cmdDecalOK.UseVisualStyleBackColor = True
        '
        'fraDecalTrans
        '
        Me.fraDecalTrans.Controls.Add(Me.txtDecalZ)
        Me.fraDecalTrans.Controls.Add(Me.chkDecalZ)
        Me.fraDecalTrans.Controls.Add(Me.txtDecalY)
        Me.fraDecalTrans.Controls.Add(Me.chkDecalY)
        Me.fraDecalTrans.Controls.Add(Me.txtDecalX)
        Me.fraDecalTrans.Controls.Add(Me.chkDecalX)
        resources.ApplyResources(Me.fraDecalTrans, "fraDecalTrans")
        Me.fraDecalTrans.Name = "fraDecalTrans"
        Me.fraDecalTrans.TabStop = False
        '
        'txtDecalZ
        '
        resources.ApplyResources(Me.txtDecalZ, "txtDecalZ")
        Me.txtDecalZ.Name = "txtDecalZ"
        Me.ttToolTip.SetToolTip(Me.txtDecalZ, resources.GetString("txtDecalZ.ToolTip"))
        '
        'chkDecalZ
        '
        resources.ApplyResources(Me.chkDecalZ, "chkDecalZ")
        Me.chkDecalZ.Name = "chkDecalZ"
        Me.ttToolTip.SetToolTip(Me.chkDecalZ, resources.GetString("chkDecalZ.ToolTip"))
        Me.chkDecalZ.UseVisualStyleBackColor = True
        '
        'txtDecalY
        '
        resources.ApplyResources(Me.txtDecalY, "txtDecalY")
        Me.txtDecalY.Name = "txtDecalY"
        Me.ttToolTip.SetToolTip(Me.txtDecalY, resources.GetString("txtDecalY.ToolTip"))
        '
        'chkDecalY
        '
        resources.ApplyResources(Me.chkDecalY, "chkDecalY")
        Me.chkDecalY.Name = "chkDecalY"
        Me.ttToolTip.SetToolTip(Me.chkDecalY, resources.GetString("chkDecalY.ToolTip"))
        Me.chkDecalY.UseVisualStyleBackColor = True
        '
        'txtDecalX
        '
        resources.ApplyResources(Me.txtDecalX, "txtDecalX")
        Me.txtDecalX.Name = "txtDecalX"
        Me.ttToolTip.SetToolTip(Me.txtDecalX, resources.GetString("txtDecalX.ToolTip"))
        '
        'chkDecalX
        '
        resources.ApplyResources(Me.chkDecalX, "chkDecalX")
        Me.chkDecalX.Name = "chkDecalX"
        Me.ttToolTip.SetToolTip(Me.chkDecalX, resources.GetString("chkDecalX.ToolTip"))
        Me.chkDecalX.UseVisualStyleBackColor = True
        '
        'pagReorient
        '
        Me.pagReorient.Controls.Add(Me.btReoDown)
        Me.pagReorient.Controls.Add(Me.btReoUp)
        Me.pagReorient.Controls.Add(Me.txtReorientOriValue)
        Me.pagReorient.Controls.Add(Me.lblReorientOriValue)
        Me.pagReorient.Controls.Add(Me.frmReorientEuler)
        Me.pagReorient.Controls.Add(Me.cmdReorientCopy2Modif)
        Me.pagReorient.Controls.Add(Me.cmdReorientGetFromModif)
        Me.pagReorient.Controls.Add(Me.frmReorientQuat)
        resources.ApplyResources(Me.pagReorient, "pagReorient")
        Me.pagReorient.Name = "pagReorient"
        Me.pagReorient.UseVisualStyleBackColor = True
        '
        'btReoDown
        '
        resources.ApplyResources(Me.btReoDown, "btReoDown")
        Me.btReoDown.Name = "btReoDown"
        Me.ttToolTip.SetToolTip(Me.btReoDown, resources.GetString("btReoDown.ToolTip"))
        Me.btReoDown.UseVisualStyleBackColor = True
        '
        'btReoUp
        '
        resources.ApplyResources(Me.btReoUp, "btReoUp")
        Me.btReoUp.Name = "btReoUp"
        Me.ttToolTip.SetToolTip(Me.btReoUp, resources.GetString("btReoUp.ToolTip"))
        Me.btReoUp.UseVisualStyleBackColor = True
        '
        'txtReorientOriValue
        '
        resources.ApplyResources(Me.txtReorientOriValue, "txtReorientOriValue")
        Me.txtReorientOriValue.Name = "txtReorientOriValue"
        Me.ttToolTip.SetToolTip(Me.txtReorientOriValue, resources.GetString("txtReorientOriValue.ToolTip"))
        '
        'lblReorientOriValue
        '
        resources.ApplyResources(Me.lblReorientOriValue, "lblReorientOriValue")
        Me.lblReorientOriValue.Name = "lblReorientOriValue"
        '
        'frmReorientEuler
        '
        Me.frmReorientEuler.Controls.Add(Me.txtReorientRZ)
        Me.frmReorientEuler.Controls.Add(Me.txtReorientRY)
        Me.frmReorientEuler.Controls.Add(Me.txtReorientRX)
        Me.frmReorientEuler.Controls.Add(Me.lblReorientRZ)
        Me.frmReorientEuler.Controls.Add(Me.lblReorientRY)
        Me.frmReorientEuler.Controls.Add(Me.lblReorientRX)
        resources.ApplyResources(Me.frmReorientEuler, "frmReorientEuler")
        Me.frmReorientEuler.Name = "frmReorientEuler"
        Me.frmReorientEuler.TabStop = False
        '
        'txtReorientRZ
        '
        resources.ApplyResources(Me.txtReorientRZ, "txtReorientRZ")
        Me.txtReorientRZ.Name = "txtReorientRZ"
        Me.ttToolTip.SetToolTip(Me.txtReorientRZ, resources.GetString("txtReorientRZ.ToolTip"))
        '
        'txtReorientRY
        '
        resources.ApplyResources(Me.txtReorientRY, "txtReorientRY")
        Me.txtReorientRY.Name = "txtReorientRY"
        Me.ttToolTip.SetToolTip(Me.txtReorientRY, resources.GetString("txtReorientRY.ToolTip"))
        '
        'txtReorientRX
        '
        resources.ApplyResources(Me.txtReorientRX, "txtReorientRX")
        Me.txtReorientRX.Name = "txtReorientRX"
        Me.ttToolTip.SetToolTip(Me.txtReorientRX, resources.GetString("txtReorientRX.ToolTip"))
        '
        'lblReorientRZ
        '
        resources.ApplyResources(Me.lblReorientRZ, "lblReorientRZ")
        Me.lblReorientRZ.Name = "lblReorientRZ"
        '
        'lblReorientRY
        '
        resources.ApplyResources(Me.lblReorientRY, "lblReorientRY")
        Me.lblReorientRY.Name = "lblReorientRY"
        '
        'lblReorientRX
        '
        resources.ApplyResources(Me.lblReorientRX, "lblReorientRX")
        Me.lblReorientRX.Name = "lblReorientRX"
        '
        'cmdReorientCopy2Modif
        '
        resources.ApplyResources(Me.cmdReorientCopy2Modif, "cmdReorientCopy2Modif")
        Me.cmdReorientCopy2Modif.Name = "cmdReorientCopy2Modif"
        Me.ttToolTip.SetToolTip(Me.cmdReorientCopy2Modif, resources.GetString("cmdReorientCopy2Modif.ToolTip"))
        Me.cmdReorientCopy2Modif.UseVisualStyleBackColor = True
        '
        'cmdReorientGetFromModif
        '
        resources.ApplyResources(Me.cmdReorientGetFromModif, "cmdReorientGetFromModif")
        Me.cmdReorientGetFromModif.Name = "cmdReorientGetFromModif"
        Me.ttToolTip.SetToolTip(Me.cmdReorientGetFromModif, resources.GetString("cmdReorientGetFromModif.ToolTip"))
        Me.cmdReorientGetFromModif.UseVisualStyleBackColor = True
        '
        'frmReorientQuat
        '
        Me.frmReorientQuat.Controls.Add(Me.lblReorientQ4)
        Me.frmReorientQuat.Controls.Add(Me.lblReorientQ3)
        Me.frmReorientQuat.Controls.Add(Me.lblReorientQ2)
        Me.frmReorientQuat.Controls.Add(Me.lblReorientQ1)
        Me.frmReorientQuat.Controls.Add(Me.imgReorientQuatOK)
        Me.frmReorientQuat.Controls.Add(Me.txtReorientQ4)
        Me.frmReorientQuat.Controls.Add(Me.txtReorientQ3)
        Me.frmReorientQuat.Controls.Add(Me.txtReorientQ2)
        Me.frmReorientQuat.Controls.Add(Me.txtReorientQ1)
        resources.ApplyResources(Me.frmReorientQuat, "frmReorientQuat")
        Me.frmReorientQuat.Name = "frmReorientQuat"
        Me.frmReorientQuat.TabStop = False
        '
        'lblReorientQ4
        '
        resources.ApplyResources(Me.lblReorientQ4, "lblReorientQ4")
        Me.lblReorientQ4.Name = "lblReorientQ4"
        '
        'lblReorientQ3
        '
        resources.ApplyResources(Me.lblReorientQ3, "lblReorientQ3")
        Me.lblReorientQ3.Name = "lblReorientQ3"
        '
        'lblReorientQ2
        '
        resources.ApplyResources(Me.lblReorientQ2, "lblReorientQ2")
        Me.lblReorientQ2.Name = "lblReorientQ2"
        '
        'lblReorientQ1
        '
        resources.ApplyResources(Me.lblReorientQ1, "lblReorientQ1")
        Me.lblReorientQ1.Name = "lblReorientQ1"
        '
        'imgReorientQuatOK
        '
        Me.imgReorientQuatOK.BackColor = System.Drawing.Color.Lime
        resources.ApplyResources(Me.imgReorientQuatOK, "imgReorientQuatOK")
        Me.imgReorientQuatOK.Name = "imgReorientQuatOK"
        Me.imgReorientQuatOK.TabStop = False
        '
        'txtReorientQ4
        '
        resources.ApplyResources(Me.txtReorientQ4, "txtReorientQ4")
        Me.txtReorientQ4.Name = "txtReorientQ4"
        Me.ttToolTip.SetToolTip(Me.txtReorientQ4, resources.GetString("txtReorientQ4.ToolTip"))
        '
        'txtReorientQ3
        '
        resources.ApplyResources(Me.txtReorientQ3, "txtReorientQ3")
        Me.txtReorientQ3.Name = "txtReorientQ3"
        Me.ttToolTip.SetToolTip(Me.txtReorientQ3, resources.GetString("txtReorientQ3.ToolTip"))
        '
        'txtReorientQ2
        '
        resources.ApplyResources(Me.txtReorientQ2, "txtReorientQ2")
        Me.txtReorientQ2.Name = "txtReorientQ2"
        Me.ttToolTip.SetToolTip(Me.txtReorientQ2, resources.GetString("txtReorientQ2.ToolTip"))
        '
        'txtReorientQ1
        '
        resources.ApplyResources(Me.txtReorientQ1, "txtReorientQ1")
        Me.txtReorientQ1.Name = "txtReorientQ1"
        Me.ttToolTip.SetToolTip(Me.txtReorientQ1, resources.GetString("txtReorientQ1.ToolTip"))
        '
        'pagDecod
        '
        Me.pagDecod.Controls.Add(Me.cmdDecod)
        resources.ApplyResources(Me.pagDecod, "pagDecod")
        Me.pagDecod.Name = "pagDecod"
        Me.pagDecod.UseVisualStyleBackColor = True
        '
        'cmdDecod
        '
        Me.cmdDecod.AllowDrop = True
        resources.ApplyResources(Me.cmdDecod, "cmdDecod")
        Me.cmdDecod.Name = "cmdDecod"
        Me.ttToolTip.SetToolTip(Me.cmdDecod, resources.GetString("cmdDecod.ToolTip"))
        Me.cmdDecod.UseVisualStyleBackColor = True
        '
        'pagEncod
        '
        Me.pagEncod.Controls.Add(Me.lblEncodeVers)
        Me.pagEncod.Controls.Add(Me.cbEncodeVers)
        Me.pagEncod.Controls.Add(Me.cmdEncod)
        resources.ApplyResources(Me.pagEncod, "pagEncod")
        Me.pagEncod.Name = "pagEncod"
        Me.pagEncod.UseVisualStyleBackColor = True
        '
        'lblEncodeVers
        '
        resources.ApplyResources(Me.lblEncodeVers, "lblEncodeVers")
        Me.lblEncodeVers.Name = "lblEncodeVers"
        '
        'cbEncodeVers
        '
        Me.cbEncodeVers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEncodeVers.FormattingEnabled = True
        Me.cbEncodeVers.Items.AddRange(New Object() {resources.GetString("cbEncodeVers.Items"), resources.GetString("cbEncodeVers.Items1"), resources.GetString("cbEncodeVers.Items2")})
        resources.ApplyResources(Me.cbEncodeVers, "cbEncodeVers")
        Me.cbEncodeVers.Name = "cbEncodeVers"
        Me.ttToolTip.SetToolTip(Me.cbEncodeVers, resources.GetString("cbEncodeVers.ToolTip"))
        '
        'cmdEncod
        '
        Me.cmdEncod.AllowDrop = True
        resources.ApplyResources(Me.cmdEncod, "cmdEncod")
        Me.cmdEncod.Name = "cmdEncod"
        Me.ttToolTip.SetToolTip(Me.cmdEncod, resources.GetString("cmdEncod.ToolTip"))
        Me.cmdEncod.UseVisualStyleBackColor = True
        '
        'clbPoints
        '
        Me.clbPoints.AllowDrop = True
        Me.clbPoints.ContextMenuStrip = Me.cmnuLBPoints
        resources.ApplyResources(Me.clbPoints, "clbPoints")
        Me.clbPoints.FormattingEnabled = True
        Me.clbPoints.Name = "clbPoints"
        '
        'cmnuLBPoints
        '
        Me.cmnuLBPoints.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuLBPointsCopier, Me.cmnuLBPointsColler, Me.cmnuLBPointsEffacer, Me.cmnuLBPointsEffacerTout, Me.cmnuLBPointsSelRef, Me.ToolStripSeparator1, Me.cmnuLBPointsSel})
        Me.cmnuLBPoints.Name = "cmnuLBPoints"
        resources.ApplyResources(Me.cmnuLBPoints, "cmnuLBPoints")
        '
        'cmnuLBPointsCopier
        '
        Me.cmnuLBPointsCopier.Name = "cmnuLBPointsCopier"
        resources.ApplyResources(Me.cmnuLBPointsCopier, "cmnuLBPointsCopier")
        '
        'cmnuLBPointsColler
        '
        Me.cmnuLBPointsColler.Name = "cmnuLBPointsColler"
        resources.ApplyResources(Me.cmnuLBPointsColler, "cmnuLBPointsColler")
        '
        'cmnuLBPointsEffacer
        '
        Me.cmnuLBPointsEffacer.Name = "cmnuLBPointsEffacer"
        resources.ApplyResources(Me.cmnuLBPointsEffacer, "cmnuLBPointsEffacer")
        '
        'cmnuLBPointsEffacerTout
        '
        Me.cmnuLBPointsEffacerTout.Name = "cmnuLBPointsEffacerTout"
        resources.ApplyResources(Me.cmnuLBPointsEffacerTout, "cmnuLBPointsEffacerTout")
        '
        'cmnuLBPointsSelRef
        '
        Me.cmnuLBPointsSelRef.Name = "cmnuLBPointsSelRef"
        resources.ApplyResources(Me.cmnuLBPointsSelRef, "cmnuLBPointsSelRef")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'cmnuLBPointsSel
        '
        Me.cmnuLBPointsSel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuLBPointsSelTout, Me.cmnuLBPointsSelAucun, Me.cmnuLBPointsSelInverser})
        Me.cmnuLBPointsSel.Name = "cmnuLBPointsSel"
        resources.ApplyResources(Me.cmnuLBPointsSel, "cmnuLBPointsSel")
        '
        'cmnuLBPointsSelTout
        '
        Me.cmnuLBPointsSelTout.Name = "cmnuLBPointsSelTout"
        resources.ApplyResources(Me.cmnuLBPointsSelTout, "cmnuLBPointsSelTout")
        '
        'cmnuLBPointsSelAucun
        '
        Me.cmnuLBPointsSelAucun.Name = "cmnuLBPointsSelAucun"
        resources.ApplyResources(Me.cmnuLBPointsSelAucun, "cmnuLBPointsSelAucun")
        '
        'cmnuLBPointsSelInverser
        '
        Me.cmnuLBPointsSelInverser.Name = "cmnuLBPointsSelInverser"
        resources.ApplyResources(Me.cmnuLBPointsSelInverser, "cmnuLBPointsSelInverser")
        '
        'ofdOpenFileDialog
        '
        Me.ofdOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.clbPoints)
        Me.Controls.Add(Me.mltpChoix)
        Me.Name = "frmMain"
        Me.ttToolTip.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.mltpChoix.ResumeLayout(False)
        Me.pagModif.ResumeLayout(False)
        Me.pagModif.PerformLayout()
        Me.fraRobConf.ResumeLayout(False)
        Me.fraRobConf.PerformLayout()
        Me.fraRot.ResumeLayout(False)
        Me.fraRot.PerformLayout()
        Me.fraTrans.ResumeLayout(False)
        Me.fraTrans.PerformLayout()
        Me.pagDecal.ResumeLayout(False)
        Me.fraDecalTrans.ResumeLayout(False)
        Me.fraDecalTrans.PerformLayout()
        Me.pagReorient.ResumeLayout(False)
        Me.pagReorient.PerformLayout()
        Me.frmReorientEuler.ResumeLayout(False)
        Me.frmReorientEuler.PerformLayout()
        Me.frmReorientQuat.ResumeLayout(False)
        Me.frmReorientQuat.PerformLayout()
        CType(Me.imgReorientQuatOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagDecod.ResumeLayout(False)
        Me.pagEncod.ResumeLayout(False)
        Me.pagEncod.PerformLayout()
        Me.cmnuLBPoints.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mltpChoix As TabControl
    Friend WithEvents pagModif As TabPage
    Friend WithEvents pagDecal As TabPage
    Friend WithEvents pagReorient As TabPage
    Friend WithEvents fraRot As GroupBox
    Friend WithEvents fraTrans As GroupBox
    Friend WithEvents fraRobConf As GroupBox
    Friend WithEvents txtModifX As TextBox
    Friend WithEvents chkModifX As CheckBox
    Friend WithEvents txtModifQ4 As TextBox
    Friend WithEvents chkModifQ4 As CheckBox
    Friend WithEvents txtModifQ3 As TextBox
    Friend WithEvents chkModifQ3 As CheckBox
    Friend WithEvents txtModifQ2 As TextBox
    Friend WithEvents chkModifQ2 As CheckBox
    Friend WithEvents txtModifQ1 As TextBox
    Friend WithEvents chkModifQ1 As CheckBox
    Friend WithEvents txtModifZ As TextBox
    Friend WithEvents chkModifZ As CheckBox
    Friend WithEvents txtModifY As TextBox
    Friend WithEvents chkModifY As CheckBox
    Friend WithEvents txtModifCf1 As TextBox
    Friend WithEvents chkModifCf1 As CheckBox
    Friend WithEvents txtRobValue As TextBox
    Friend WithEvents lblRobValue As Label
    Friend WithEvents txtModifCfx As TextBox
    Friend WithEvents chkModifCfx As CheckBox
    Friend WithEvents txtModifCf6 As TextBox
    Friend WithEvents chkModifCf6 As CheckBox
    Friend WithEvents txtModifCf4 As TextBox
    Friend WithEvents chkModifCf4 As CheckBox
    Friend WithEvents ttToolTip As ToolTip
    Friend WithEvents fraDecalTrans As GroupBox
    Friend WithEvents txtDecalZ As TextBox
    Friend WithEvents chkDecalZ As CheckBox
    Friend WithEvents txtDecalY As TextBox
    Friend WithEvents chkDecalY As CheckBox
    Friend WithEvents txtDecalX As TextBox
    Friend WithEvents chkDecalX As CheckBox
    Friend WithEvents frmReorientQuat As GroupBox
    Friend WithEvents txtReorientQ4 As TextBox
    Friend WithEvents txtReorientQ3 As TextBox
    Friend WithEvents txtReorientQ2 As TextBox
    Friend WithEvents txtReorientQ1 As TextBox
    Friend WithEvents imgReorientQuatOK As PictureBox
    Friend WithEvents cmdReorientGetFromModif As Button
    Friend WithEvents cmdReorientCopy2Modif As Button
    Friend WithEvents frmReorientEuler As GroupBox
    Friend WithEvents txtReorientRZ As TextBox
    Friend WithEvents txtReorientRY As TextBox
    Friend WithEvents txtReorientRX As TextBox
    Friend WithEvents lblReorientOriValue As Label
    Friend WithEvents cmdModifOK As Button
    Friend WithEvents cmdDecalOK As Button
    Friend WithEvents txtReorientOriValue As TextBox
    Friend WithEvents lblReorientQ1 As Label
    Friend WithEvents lblReorientRZ As Label
    Friend WithEvents lblReorientRY As Label
    Friend WithEvents lblReorientRX As Label
    Friend WithEvents lblReorientQ4 As Label
    Friend WithEvents lblReorientQ3 As Label
    Friend WithEvents lblReorientQ2 As Label
    Friend WithEvents clbPoints As CheckedListBox
    Friend WithEvents cmnuLBPoints As ContextMenuStrip
    Friend WithEvents cmnuLBPointsCopier As ToolStripMenuItem
    Friend WithEvents cmnuLBPointsColler As ToolStripMenuItem
    Friend WithEvents cmnuLBPointsEffacer As ToolStripMenuItem
    Friend WithEvents cmnuLBPointsSelRef As ToolStripMenuItem
    Friend WithEvents cmnuLBPointsSel As ToolStripMenuItem
    Friend WithEvents cmnuLBPointsSelTout As ToolStripMenuItem
    Friend WithEvents cmnuLBPointsSelAucun As ToolStripMenuItem
    Friend WithEvents cmnuLBPointsSelInverser As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btReoUp As Button
    Friend WithEvents btReoDown As Button
    Friend WithEvents cmnuLBPointsEffacerTout As ToolStripMenuItem
    Friend WithEvents ofdOpenFileDialog As OpenFileDialog
    Friend WithEvents sfdSaveFileDialog As SaveFileDialog
    Friend WithEvents pagDecod As TabPage
    Friend WithEvents cmdDecod As Button
    Friend WithEvents fbdFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents pagEncod As TabPage
    Friend WithEvents cmdEncod As Button
    Friend WithEvents cbEncodeVers As ComboBox
    Friend WithEvents lblEncodeVers As Label
End Class
