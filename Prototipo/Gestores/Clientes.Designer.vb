<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.btN = New System.Windows.Forms.Button()
        Me.Dglist = New System.Windows.Forms.DataGridView()
        Me.btE = New System.Windows.Forms.Button()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.cbb = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.cbtc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnB = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Dglist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btN
        '
        Me.btN.Location = New System.Drawing.Point(413, 120)
        Me.btN.Name = "btN"
        Me.btN.Size = New System.Drawing.Size(75, 23)
        Me.btN.TabIndex = 18
        Me.btN.Text = "Registrar"
        Me.btN.UseVisualStyleBackColor = True
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
        Me.Dglist.Size = New System.Drawing.Size(776, 334)
        Me.Dglist.TabIndex = 22
        '
        'btE
        '
        Me.btE.Location = New System.Drawing.Point(9, 120)
        Me.btE.Name = "btE"
        Me.btE.Size = New System.Drawing.Size(75, 23)
        Me.btE.TabIndex = 21
        Me.btE.Text = "Quitar"
        Me.btE.UseVisualStyleBackColor = True
        '
        'txtB
        '
        Me.txtB.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtB.Location = New System.Drawing.Point(6, 93)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(264, 20)
        Me.txtB.TabIndex = 20
        '
        'cbb
        '
        Me.cbb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbb.FormattingEnabled = True
        Me.cbb.Items.AddRange(New Object() {"Apellido", "CUIL"})
        Me.cbb.Location = New System.Drawing.Point(158, 40)
        Me.cbb.Name = "cbb"
        Me.cbb.Size = New System.Drawing.Size(112, 21)
        Me.cbb.TabIndex = 19
        Me.cbb.Text = "Apellido"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEm)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnUp)
        Me.GroupBox1.Controls.Add(Me.cbtc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtD)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btN)
        Me.GroupBox1.Controls.Add(Me.txtN)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 149)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control"
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(6, 120)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(101, 23)
        Me.btnUp.TabIndex = 42
        Me.btnUp.Text = "Actualizar Datos"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'cbtc
        '
        Me.cbtc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbtc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbtc.FormattingEnabled = True
        Me.cbtc.Items.AddRange(New Object() {"Consumidor Final", "IVA Responsable Inscripto", "IVA Responsable no incripto", "IVA no Responsable", "IVA Sujeto Exento", "Responsable Monotributo", "Sujeto no Categorizado", "Proveedor del Exterior", "Cliente del Exterior", "IVA Liberado - Ley N°19.640", "IVA Responsable incripto-Agente de Percepcion", "Pequeño Contribuyente Eventual", "Monotributista Social", "Pequeño Contribuyente Eventual Social"})
        Me.cbtc.Location = New System.Drawing.Point(270, 75)
        Me.cbtc.Name = "cbtc"
        Me.cbtc.Size = New System.Drawing.Size(218, 21)
        Me.cbtc.TabIndex = 29
        Me.cbtc.Text = "Consumidor Final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Tipo contribuyente:"
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(270, 50)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(218, 20)
        Me.txtD.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Location = New System.Drawing.Point(209, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Dirección:"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(64, 76)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(93, 20)
        Me.txtC.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "CUIT:"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(64, 50)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(93, 20)
        Me.txtA.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Apellido:"
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(64, 24)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(93, 20)
        Me.txtN.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnB)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtB)
        Me.GroupBox2.Controls.Add(Me.cbb)
        Me.GroupBox2.Controls.Add(Me.btE)
        Me.GroupBox2.Location = New System.Drawing.Point(512, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 149)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar"
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(205, 119)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(65, 23)
        Me.btnB.TabIndex = 22
        Me.btnB.Text = "Buscar"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "En qué campo desea buscar:"
        '
        'txtEm
        '
        Me.txtEm.Location = New System.Drawing.Point(270, 24)
        Me.txtEm.Name = "txtEm"
        Me.txtEm.Size = New System.Drawing.Size(218, 20)
        Me.txtEm.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Location = New System.Drawing.Point(229, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Email:"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 513)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Dglist)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clientes"
        Me.Text = "Gestor de Clientes"
        CType(Me.Dglist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btN As Button
    Friend WithEvents Dglist As DataGridView
    Friend WithEvents btE As Button
    Friend WithEvents txtB As TextBox
    Friend WithEvents cbb As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtD As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbtc As ComboBox
    Friend WithEvents btnB As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents txtEm As TextBox
    Friend WithEvents Label1 As Label
End Class
