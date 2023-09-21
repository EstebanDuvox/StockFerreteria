<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnB = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbus = New System.Windows.Forms.TextBox()
        Me.cbB = New System.Windows.Forms.ComboBox()
        Me.btnR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPS = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbProv = New System.Windows.Forms.ComboBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.cbC = New System.Windows.Forms.ComboBox()
        Me.cbM = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtpr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.txtcan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnCat = New System.Windows.Forms.Button()
        Me.Dglist = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnF = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCMin = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCMax = New System.Windows.Forms.TextBox()
        Me.cbMK = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnB)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtbus)
        Me.GroupBox2.Controls.Add(Me.cbB)
        Me.GroupBox2.Controls.Add(Me.btnR)
        Me.GroupBox2.Location = New System.Drawing.Point(679, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 149)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar"
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(94, 117)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(65, 23)
        Me.btnB.TabIndex = 22
        Me.btnB.Text = "Buscar"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "En qué campo desea buscar:"
        '
        'txtbus
        '
        Me.txtbus.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtbus.Location = New System.Drawing.Point(9, 81)
        Me.txtbus.Name = "txtbus"
        Me.txtbus.Size = New System.Drawing.Size(143, 20)
        Me.txtbus.TabIndex = 20
        '
        'cbB
        '
        Me.cbB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbB.FormattingEnabled = True
        Me.cbB.Items.AddRange(New Object() {"Codigo", "Marca", "Modelo"})
        Me.cbB.Location = New System.Drawing.Point(9, 41)
        Me.cbB.Name = "cbB"
        Me.cbB.Size = New System.Drawing.Size(143, 21)
        Me.cbB.TabIndex = 19
        Me.cbB.Text = "Codigo"
        '
        'btnR
        '
        Me.btnR.Location = New System.Drawing.Point(9, 117)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(75, 23)
        Me.btnR.TabIndex = 21
        Me.btnR.Text = "Retirar"
        Me.btnR.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtPS)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbProv)
        Me.GroupBox1.Controls.Add(Me.btnUp)
        Me.GroupBox1.Controls.Add(Me.cbC)
        Me.GroupBox1.Controls.Add(Me.cbM)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtpr)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtmo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.Controls.Add(Me.txtcan)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 149)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Compra"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(343, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Precio Salida:"
        '
        'txtPS
        '
        Me.txtPS.Location = New System.Drawing.Point(332, 81)
        Me.txtPS.Name = "txtPS"
        Me.txtPS.Size = New System.Drawing.Size(94, 20)
        Me.txtPS.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Location = New System.Drawing.Point(343, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Proveedores:"
        '
        'cbProv
        '
        Me.cbProv.FormattingEnabled = True
        Me.cbProv.Location = New System.Drawing.Point(332, 39)
        Me.cbProv.Name = "cbProv"
        Me.cbProv.Size = New System.Drawing.Size(94, 21)
        Me.cbProv.TabIndex = 42
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(325, 117)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(101, 23)
        Me.btnUp.TabIndex = 41
        Me.btnUp.Text = "Actualizar Datos"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'cbC
        '
        Me.cbC.FormattingEnabled = True
        Me.cbC.Location = New System.Drawing.Point(30, 81)
        Me.cbC.Name = "cbC"
        Me.cbC.Size = New System.Drawing.Size(84, 21)
        Me.cbC.TabIndex = 40
        '
        'cbM
        '
        Me.cbM.FormattingEnabled = True
        Me.cbM.Location = New System.Drawing.Point(129, 39)
        Me.cbM.Name = "cbM"
        Me.cbM.Size = New System.Drawing.Size(84, 21)
        Me.cbM.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(232, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Precio entrada:"
        '
        'txtpr
        '
        Me.txtpr.Location = New System.Drawing.Point(229, 81)
        Me.txtpr.Name = "txtpr"
        Me.txtpr.Size = New System.Drawing.Size(84, 20)
        Me.txtpr.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Location = New System.Drawing.Point(43, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Categoría:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Location = New System.Drawing.Point(250, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Modelo:"
        '
        'txtmo
        '
        Me.txtmo.Location = New System.Drawing.Point(229, 39)
        Me.txtmo.Name = "txtmo"
        Me.txtmo.Size = New System.Drawing.Size(84, 20)
        Me.txtmo.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Location = New System.Drawing.Point(150, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Marca:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Código producto:"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(30, 40)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(84, 20)
        Me.txtCod.TabIndex = 30
        '
        'txtcan
        '
        Me.txtcan.Location = New System.Drawing.Point(129, 82)
        Me.txtcan.Name = "txtcan"
        Me.txtcan.Size = New System.Drawing.Size(84, 20)
        Me.txtcan.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Location = New System.Drawing.Point(145, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Cantidad:"
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(28, 117)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(75, 23)
        Me.btnA.TabIndex = 18
        Me.btnA.Text = "Registrar"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnM
        '
        Me.btnM.Location = New System.Drawing.Point(6, 67)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(75, 23)
        Me.btnM.TabIndex = 40
        Me.btnM.Text = "Marcas"
        Me.btnM.UseVisualStyleBackColor = True
        '
        'btnCat
        '
        Me.btnCat.Location = New System.Drawing.Point(6, 38)
        Me.btnCat.Name = "btnCat"
        Me.btnCat.Size = New System.Drawing.Size(75, 23)
        Me.btnCat.TabIndex = 30
        Me.btnCat.Text = "Categorias"
        Me.btnCat.UseVisualStyleBackColor = True
        '
        'Dglist
        '
        Me.Dglist.AllowUserToAddRows = False
        Me.Dglist.AllowUserToDeleteRows = False
        Me.Dglist.AllowUserToOrderColumns = True
        Me.Dglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dglist.Location = New System.Drawing.Point(12, 167)
        Me.Dglist.Name = "Dglist"
        Me.Dglist.ReadOnly = True
        Me.Dglist.Size = New System.Drawing.Size(832, 334)
        Me.Dglist.TabIndex = 26
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnF)
        Me.GroupBox3.Controls.Add(Me.btnM)
        Me.GroupBox3.Controls.Add(Me.btnCat)
        Me.GroupBox3.Location = New System.Drawing.Point(585, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(88, 149)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Formularios"
        '
        'btnF
        '
        Me.btnF.Location = New System.Drawing.Point(6, 96)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(75, 23)
        Me.btnF.TabIndex = 41
        Me.btnF.Text = "Facturar"
        Me.btnF.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCMin)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtCMax)
        Me.GroupBox4.Controls.Add(Me.cbMK)
        Me.GroupBox4.Location = New System.Drawing.Point(473, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(106, 149)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos Kardex"
        '
        'txtCMin
        '
        Me.txtCMin.AutoSize = True
        Me.txtCMin.Location = New System.Drawing.Point(9, 98)
        Me.txtCMin.Name = "txtCMin"
        Me.txtCMin.Size = New System.Drawing.Size(88, 13)
        Me.txtCMin.TabIndex = 24
        Me.txtCMin.Text = "Cantidad Minima:"
        '
        'TextBox2
        '
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox2.Location = New System.Drawing.Point(9, 114)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(88, 20)
        Me.TextBox2.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Cantidad Maxima:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Metodo:"
        '
        'txtCMax
        '
        Me.txtCMax.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCMax.Location = New System.Drawing.Point(9, 75)
        Me.txtCMax.Name = "txtCMax"
        Me.txtCMax.Size = New System.Drawing.Size(88, 20)
        Me.txtCMax.TabIndex = 20
        '
        'cbMK
        '
        Me.cbMK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbMK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMK.FormattingEnabled = True
        Me.cbMK.Items.AddRange(New Object() {"PEPS", "UEPS", "Promedio Ponderado"})
        Me.cbMK.Location = New System.Drawing.Point(9, 35)
        Me.cbMK.Name = "cbMK"
        Me.cbMK.Size = New System.Drawing.Size(88, 21)
        Me.cbMK.TabIndex = 19
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(856, 512)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Dglist)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Productos"
        Me.Text = "Gestor de Productos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbus As TextBox
    Friend WithEvents cbB As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtcan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnR As Button
    Friend WithEvents btnA As Button
    Friend WithEvents Dglist As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtmo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtpr As TextBox
    Friend WithEvents btnM As Button
    Friend WithEvents btnCat As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnF As Button
    Friend WithEvents cbM As ComboBox
    Friend WithEvents cbC As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtCMin As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCMax As TextBox
    Friend WithEvents cbMK As ComboBox
    Friend WithEvents btnB As Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbProv As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPS As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As Button
End Class
