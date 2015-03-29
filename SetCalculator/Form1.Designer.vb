<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FormSkin1 = New SetCalculator.FormSkin()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.FlatButton6 = New SetCalculator.FlatButton()
        Me.btnSetA = New SetCalculator.FlatButton()
        Me.FlatButton5 = New SetCalculator.FlatButton()
        Me.btnSetB = New SetCalculator.FlatButton()
        Me.btnSetC = New SetCalculator.FlatButton()
        Me.btnUnion = New SetCalculator.FlatButton()
        Me.btnClear = New SetCalculator.FlatButton()
        Me.btnIntersection = New SetCalculator.FlatButton()
        Me.btnBackspace = New SetCalculator.FlatButton()
        Me.btnDifference = New SetCalculator.FlatButton()
        Me.btnEquals = New SetCalculator.FlatButton()
        Me.btnMultiply = New SetCalculator.FlatButton()
        Me.btnSubset = New SetCalculator.FlatButton()
        Me.btnComplement = New SetCalculator.FlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatClose1 = New SetCalculator.FlatClose()
        Me.FlatMini1 = New SetCalculator.FlatMini()
        Me.lblAnswer = New SetCalculator.FlatLabel()
        Me.lblInput = New SetCalculator.FlatLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlatLabel1 = New SetCalculator.FlatLabel()
        Me.FlatButton4 = New SetCalculator.FlatButton()
        Me.btnSetCClr = New SetCalculator.FlatButton()
        Me.btnSetBClr = New SetCalculator.FlatButton()
        Me.btnSetAClr = New SetCalculator.FlatButton()
        Me.FlatButton3 = New SetCalculator.FlatButton()
        Me.FlatButton2 = New SetCalculator.FlatButton()
        Me.FlatButton1 = New SetCalculator.FlatButton()
        Me.txtSetC = New System.Windows.Forms.TextBox()
        Me.txtSetB = New System.Windows.Forms.TextBox()
        Me.txtSetA = New System.Windows.Forms.TextBox()
        Me.FormSkin1.SuspendLayout()
        Me.grpButtons.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.grpButtons)
        Me.FormSkin1.Controls.Add(Me.Panel1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.lblAnswer)
        Me.FormSkin1.Controls.Add(Me.lblInput)
        Me.FormSkin1.Controls.Add(Me.GroupBox1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(593, 667)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Set Calculator"
        '
        'grpButtons
        '
        Me.grpButtons.BackColor = System.Drawing.Color.Gainsboro
        Me.grpButtons.Controls.Add(Me.FlatButton6)
        Me.grpButtons.Controls.Add(Me.btnSetA)
        Me.grpButtons.Controls.Add(Me.FlatButton5)
        Me.grpButtons.Controls.Add(Me.btnSetB)
        Me.grpButtons.Controls.Add(Me.btnSetC)
        Me.grpButtons.Controls.Add(Me.btnUnion)
        Me.grpButtons.Controls.Add(Me.btnClear)
        Me.grpButtons.Controls.Add(Me.btnIntersection)
        Me.grpButtons.Controls.Add(Me.btnBackspace)
        Me.grpButtons.Controls.Add(Me.btnDifference)
        Me.grpButtons.Controls.Add(Me.btnEquals)
        Me.grpButtons.Controls.Add(Me.btnMultiply)
        Me.grpButtons.Controls.Add(Me.btnSubset)
        Me.grpButtons.Controls.Add(Me.btnComplement)
        Me.grpButtons.Location = New System.Drawing.Point(5, 424)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(578, 225)
        Me.grpButtons.TabIndex = 23
        Me.grpButtons.TabStop = False
        '
        'FlatButton6
        '
        Me.FlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton6.BaseColor = System.Drawing.Color.Teal
        Me.FlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton6.Enabled = False
        Me.FlatButton6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton6.Location = New System.Drawing.Point(18, 32)
        Me.FlatButton6.Name = "FlatButton6"
        Me.FlatButton6.Rounded = False
        Me.FlatButton6.Size = New System.Drawing.Size(73, 29)
        Me.FlatButton6.TabIndex = 23
        Me.FlatButton6.Text = "Sets"
        Me.FlatButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnSetA
        '
        Me.btnSetA.BackColor = System.Drawing.Color.Transparent
        Me.btnSetA.BaseColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSetA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetA.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSetA.Location = New System.Drawing.Point(18, 62)
        Me.btnSetA.Name = "btnSetA"
        Me.btnSetA.Rounded = False
        Me.btnSetA.Size = New System.Drawing.Size(73, 48)
        Me.btnSetA.TabIndex = 6
        Me.btnSetA.Text = "Set A"
        Me.btnSetA.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton5
        '
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.Teal
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Enabled = False
        Me.FlatButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton5.Location = New System.Drawing.Point(97, 32)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = False
        Me.FlatButton5.Size = New System.Drawing.Size(247, 29)
        Me.FlatButton5.TabIndex = 22
        Me.FlatButton5.Text = "Operations"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnSetB
        '
        Me.btnSetB.BackColor = System.Drawing.Color.Transparent
        Me.btnSetB.BaseColor = System.Drawing.Color.Aqua
        Me.btnSetB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSetB.Location = New System.Drawing.Point(18, 116)
        Me.btnSetB.Name = "btnSetB"
        Me.btnSetB.Rounded = False
        Me.btnSetB.Size = New System.Drawing.Size(73, 48)
        Me.btnSetB.TabIndex = 6
        Me.btnSetB.Text = "Set B"
        Me.btnSetB.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnSetC
        '
        Me.btnSetC.BackColor = System.Drawing.Color.Transparent
        Me.btnSetC.BaseColor = System.Drawing.Color.Teal
        Me.btnSetC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetC.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSetC.Location = New System.Drawing.Point(17, 170)
        Me.btnSetC.Name = "btnSetC"
        Me.btnSetC.Rounded = False
        Me.btnSetC.Size = New System.Drawing.Size(73, 48)
        Me.btnSetC.TabIndex = 6
        Me.btnSetC.Text = "Set C"
        Me.btnSetC.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnUnion
        '
        Me.btnUnion.BackColor = System.Drawing.Color.Transparent
        Me.btnUnion.BaseColor = System.Drawing.Color.LightSeaGreen
        Me.btnUnion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnion.Location = New System.Drawing.Point(97, 62)
        Me.btnUnion.Name = "btnUnion"
        Me.btnUnion.Rounded = False
        Me.btnUnion.Size = New System.Drawing.Size(122, 48)
        Me.btnUnion.TabIndex = 7
        Me.btnUnion.Text = "Union"
        Me.btnUnion.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BaseColor = System.Drawing.Color.Teal
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnClear.Location = New System.Drawing.Point(350, 87)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Rounded = False
        Me.btnClear.Size = New System.Drawing.Size(127, 132)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnIntersection
        '
        Me.btnIntersection.BackColor = System.Drawing.Color.Transparent
        Me.btnIntersection.BaseColor = System.Drawing.Color.LightSeaGreen
        Me.btnIntersection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntersection.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntersection.Location = New System.Drawing.Point(97, 116)
        Me.btnIntersection.Name = "btnIntersection"
        Me.btnIntersection.Rounded = False
        Me.btnIntersection.Size = New System.Drawing.Size(122, 48)
        Me.btnIntersection.TabIndex = 8
        Me.btnIntersection.Text = "Intersection"
        Me.btnIntersection.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnBackspace
        '
        Me.btnBackspace.BackColor = System.Drawing.Color.Transparent
        Me.btnBackspace.BaseColor = System.Drawing.Color.Teal
        Me.btnBackspace.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackspace.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBackspace.Location = New System.Drawing.Point(350, 32)
        Me.btnBackspace.Name = "btnBackspace"
        Me.btnBackspace.Rounded = False
        Me.btnBackspace.Size = New System.Drawing.Size(127, 49)
        Me.btnBackspace.TabIndex = 14
        Me.btnBackspace.Text = "<------"
        Me.btnBackspace.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnDifference
        '
        Me.btnDifference.BackColor = System.Drawing.Color.Transparent
        Me.btnDifference.BaseColor = System.Drawing.Color.LightSeaGreen
        Me.btnDifference.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDifference.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDifference.Location = New System.Drawing.Point(97, 170)
        Me.btnDifference.Name = "btnDifference"
        Me.btnDifference.Rounded = False
        Me.btnDifference.Size = New System.Drawing.Size(122, 48)
        Me.btnDifference.TabIndex = 9
        Me.btnDifference.Text = "Difference"
        Me.btnDifference.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnEquals
        '
        Me.btnEquals.BackColor = System.Drawing.Color.Transparent
        Me.btnEquals.BaseColor = System.Drawing.Color.DarkCyan
        Me.btnEquals.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEquals.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnEquals.Location = New System.Drawing.Point(483, 32)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Rounded = False
        Me.btnEquals.Size = New System.Drawing.Size(73, 187)
        Me.btnEquals.TabIndex = 13
        Me.btnEquals.Text = "="
        Me.btnEquals.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnMultiply
        '
        Me.btnMultiply.BackColor = System.Drawing.Color.Transparent
        Me.btnMultiply.BaseColor = System.Drawing.Color.LightSeaGreen
        Me.btnMultiply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMultiply.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(221, 62)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Rounded = False
        Me.btnMultiply.Size = New System.Drawing.Size(123, 48)
        Me.btnMultiply.TabIndex = 10
        Me.btnMultiply.Text = "Multiply"
        Me.btnMultiply.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnSubset
        '
        Me.btnSubset.BackColor = System.Drawing.Color.Transparent
        Me.btnSubset.BaseColor = System.Drawing.Color.LightSeaGreen
        Me.btnSubset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubset.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubset.Location = New System.Drawing.Point(221, 170)
        Me.btnSubset.Name = "btnSubset"
        Me.btnSubset.Rounded = False
        Me.btnSubset.Size = New System.Drawing.Size(123, 49)
        Me.btnSubset.TabIndex = 12
        Me.btnSubset.Text = "Subset"
        Me.btnSubset.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnComplement
        '
        Me.btnComplement.BackColor = System.Drawing.Color.Transparent
        Me.btnComplement.BaseColor = System.Drawing.Color.LightSeaGreen
        Me.btnComplement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnComplement.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplement.Location = New System.Drawing.Point(221, 116)
        Me.btnComplement.Name = "btnComplement"
        Me.btnComplement.Rounded = False
        Me.btnComplement.Size = New System.Drawing.Size(123, 48)
        Me.btnComplement.TabIndex = 11
        Me.btnComplement.Text = "Complement"
        Me.btnComplement.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(8, 419)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 241)
        Me.Panel1.TabIndex = 24
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(563, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 19
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(531, 12)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 18
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblAnswer
        '
        Me.lblAnswer.BackColor = System.Drawing.Color.LightGray
        Me.lblAnswer.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.ForeColor = System.Drawing.Color.Gray
        Me.lblAnswer.Location = New System.Drawing.Point(25, 373)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(543, 38)
        Me.lblAnswer.TabIndex = 2
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblInput
        '
        Me.lblInput.BackColor = System.Drawing.Color.LightGray
        Me.lblInput.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.ForeColor = System.Drawing.Color.Gray
        Me.lblInput.Location = New System.Drawing.Point(25, 334)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(543, 34)
        Me.lblInput.TabIndex = 1
        Me.lblInput.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.FlatLabel1)
        Me.GroupBox1.Controls.Add(Me.FlatButton4)
        Me.GroupBox1.Controls.Add(Me.btnSetCClr)
        Me.GroupBox1.Controls.Add(Me.btnSetBClr)
        Me.GroupBox1.Controls.Add(Me.btnSetAClr)
        Me.GroupBox1.Controls.Add(Me.FlatButton3)
        Me.GroupBox1.Controls.Add(Me.FlatButton2)
        Me.GroupBox1.Controls.Add(Me.FlatButton1)
        Me.GroupBox1.Controls.Add(Me.txtSetC)
        Me.GroupBox1.Controls.Add(Me.txtSetB)
        Me.GroupBox1.Controls.Add(Me.txtSetA)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 244)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Red
        Me.FlatLabel1.Location = New System.Drawing.Point(147, 204)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(60, 13)
        Me.FlatLabel1.TabIndex = 22
        Me.FlatLabel1.Text = "FlatLabel1"
        Me.FlatLabel1.Visible = False
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.Teal
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Enabled = False
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton4.Location = New System.Drawing.Point(-18, 10)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(596, 29)
        Me.FlatButton4.TabIndex = 21
        Me.FlatButton4.Text = "Set Elements"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnSetCClr
        '
        Me.btnSetCClr.BackColor = System.Drawing.Color.Transparent
        Me.btnSetCClr.BaseColor = System.Drawing.Color.Teal
        Me.btnSetCClr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetCClr.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSetCClr.Location = New System.Drawing.Point(391, 160)
        Me.btnSetCClr.Name = "btnSetCClr"
        Me.btnSetCClr.Rounded = False
        Me.btnSetCClr.Size = New System.Drawing.Size(73, 33)
        Me.btnSetCClr.TabIndex = 20
        Me.btnSetCClr.Text = "Clear"
        Me.btnSetCClr.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnSetBClr
        '
        Me.btnSetBClr.BackColor = System.Drawing.Color.Transparent
        Me.btnSetBClr.BaseColor = System.Drawing.Color.Teal
        Me.btnSetBClr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetBClr.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSetBClr.Location = New System.Drawing.Point(391, 109)
        Me.btnSetBClr.Name = "btnSetBClr"
        Me.btnSetBClr.Rounded = False
        Me.btnSetBClr.Size = New System.Drawing.Size(73, 33)
        Me.btnSetBClr.TabIndex = 19
        Me.btnSetBClr.Text = "Clear"
        Me.btnSetBClr.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnSetAClr
        '
        Me.btnSetAClr.BackColor = System.Drawing.Color.Transparent
        Me.btnSetAClr.BaseColor = System.Drawing.Color.Teal
        Me.btnSetAClr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetAClr.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSetAClr.Location = New System.Drawing.Point(391, 61)
        Me.btnSetAClr.Name = "btnSetAClr"
        Me.btnSetAClr.Rounded = False
        Me.btnSetAClr.Size = New System.Drawing.Size(73, 33)
        Me.btnSetAClr.TabIndex = 18
        Me.btnSetAClr.Text = "Clear"
        Me.btnSetAClr.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.Teal
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(64, 160)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(80, 33)
        Me.FlatButton3.TabIndex = 5
        Me.FlatButton3.Text = "Set C"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(64, 109)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(80, 33)
        Me.FlatButton2.TabIndex = 4
        Me.FlatButton2.Text = "Set B"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(64, 61)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(80, 32)
        Me.FlatButton1.TabIndex = 3
        Me.FlatButton1.Text = "Set A"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtSetC
        '
        Me.txtSetC.Location = New System.Drawing.Point(150, 160)
        Me.txtSetC.Name = "txtSetC"
        Me.txtSetC.Size = New System.Drawing.Size(235, 33)
        Me.txtSetC.TabIndex = 2
        '
        'txtSetB
        '
        Me.txtSetB.Location = New System.Drawing.Point(150, 109)
        Me.txtSetB.Name = "txtSetB"
        Me.txtSetB.Size = New System.Drawing.Size(235, 33)
        Me.txtSetB.TabIndex = 1
        '
        'txtSetA
        '
        Me.txtSetA.Location = New System.Drawing.Point(150, 60)
        Me.txtSetA.Name = "txtSetA"
        Me.txtSetA.Size = New System.Drawing.Size(235, 33)
        Me.txtSetA.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 667)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.grpButtons.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As SetCalculator.FormSkin
    Friend WithEvents btnClear As SetCalculator.FlatButton
    Friend WithEvents btnBackspace As SetCalculator.FlatButton
    Friend WithEvents btnEquals As SetCalculator.FlatButton
    Friend WithEvents btnSubset As SetCalculator.FlatButton
    Friend WithEvents btnComplement As SetCalculator.FlatButton
    Friend WithEvents btnMultiply As SetCalculator.FlatButton
    Friend WithEvents btnDifference As SetCalculator.FlatButton
    Friend WithEvents btnIntersection As SetCalculator.FlatButton
    Friend WithEvents btnUnion As SetCalculator.FlatButton
    Friend WithEvents btnSetC As SetCalculator.FlatButton
    Friend WithEvents btnSetB As SetCalculator.FlatButton
    Friend WithEvents btnSetA As SetCalculator.FlatButton
    Friend WithEvents lblAnswer As SetCalculator.FlatLabel
    Friend WithEvents lblInput As SetCalculator.FlatLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FlatButton3 As SetCalculator.FlatButton
    Friend WithEvents FlatButton2 As SetCalculator.FlatButton
    Friend WithEvents FlatButton1 As SetCalculator.FlatButton
    Friend WithEvents txtSetC As System.Windows.Forms.TextBox
    Friend WithEvents txtSetB As System.Windows.Forms.TextBox
    Friend WithEvents txtSetA As System.Windows.Forms.TextBox
    Friend WithEvents btnSetCClr As SetCalculator.FlatButton
    Friend WithEvents btnSetBClr As SetCalculator.FlatButton
    Friend WithEvents btnSetAClr As SetCalculator.FlatButton
    Friend WithEvents FlatClose1 As SetCalculator.FlatClose
    Friend WithEvents FlatMini1 As SetCalculator.FlatMini
    Friend WithEvents FlatButton4 As SetCalculator.FlatButton
    Friend WithEvents FlatButton6 As SetCalculator.FlatButton
    Friend WithEvents FlatButton5 As SetCalculator.FlatButton
    Friend WithEvents FlatLabel1 As SetCalculator.FlatLabel
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
