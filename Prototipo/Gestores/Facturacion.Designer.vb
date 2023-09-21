<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturacion))
        Me.btnGF = New System.Windows.Forms.Button()
        Me.facA = New System.Windows.Forms.RadioButton()
        Me.facB = New System.Windows.Forms.RadioButton()
        Me.facC = New System.Windows.Forms.RadioButton()
        Me.facE = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.facT = New System.Windows.Forms.RadioButton()
        Me.dacM = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnB = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGF
        '
        Me.btnGF.Location = New System.Drawing.Point(313, 107)
        Me.btnGF.Name = "btnGF"
        Me.btnGF.Size = New System.Drawing.Size(75, 40)
        Me.btnGF.TabIndex = 0
        Me.btnGF.Text = "Generar Factura"
        Me.btnGF.UseVisualStyleBackColor = True
        '
        'facA
        '
        Me.facA.AutoSize = True
        Me.facA.Location = New System.Drawing.Point(6, 37)
        Me.facA.Name = "facA"
        Me.facA.Size = New System.Drawing.Size(32, 17)
        Me.facA.TabIndex = 3
        Me.facA.TabStop = True
        Me.facA.Text = "A"
        Me.facA.UseVisualStyleBackColor = True
        '
        'facB
        '
        Me.facB.AutoSize = True
        Me.facB.Location = New System.Drawing.Point(6, 60)
        Me.facB.Name = "facB"
        Me.facB.Size = New System.Drawing.Size(32, 17)
        Me.facB.TabIndex = 4
        Me.facB.TabStop = True
        Me.facB.Text = "B"
        Me.facB.UseVisualStyleBackColor = True
        '
        'facC
        '
        Me.facC.AutoSize = True
        Me.facC.Location = New System.Drawing.Point(6, 83)
        Me.facC.Name = "facC"
        Me.facC.Size = New System.Drawing.Size(32, 17)
        Me.facC.TabIndex = 5
        Me.facC.TabStop = True
        Me.facC.Text = "C"
        Me.facC.UseVisualStyleBackColor = True
        '
        'facE
        '
        Me.facE.AutoSize = True
        Me.facE.Location = New System.Drawing.Point(42, 37)
        Me.facE.Name = "facE"
        Me.facE.Size = New System.Drawing.Size(32, 17)
        Me.facE.TabIndex = 6
        Me.facE.TabStop = True
        Me.facE.Text = "E"
        Me.facE.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.facT)
        Me.GroupBox1.Controls.Add(Me.dacM)
        Me.GroupBox1.Controls.Add(Me.facE)
        Me.GroupBox1.Controls.Add(Me.facA)
        Me.GroupBox1.Controls.Add(Me.facB)
        Me.GroupBox1.Controls.Add(Me.facC)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(89, 113)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione tipo de factura"
        '
        'facT
        '
        Me.facT.AutoSize = True
        Me.facT.Location = New System.Drawing.Point(42, 83)
        Me.facT.Name = "facT"
        Me.facT.Size = New System.Drawing.Size(32, 17)
        Me.facT.TabIndex = 7
        Me.facT.TabStop = True
        Me.facT.Text = "T"
        Me.facT.UseVisualStyleBackColor = True
        '
        'dacM
        '
        Me.dacM.AutoSize = True
        Me.dacM.Location = New System.Drawing.Point(42, 60)
        Me.dacM.Name = "dacM"
        Me.dacM.Size = New System.Drawing.Size(34, 17)
        Me.dacM.TabIndex = 6
        Me.dacM.TabStop = True
        Me.dacM.Text = "M"
        Me.dacM.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCC)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(107, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 68)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del comprador"
        '
        'txtCC
        '
        Me.txtCC.Location = New System.Drawing.Point(6, 36)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(188, 20)
        Me.txtCC.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUIL del Cliente"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"10.5%", "21%"})
        Me.ComboBox1.Location = New System.Drawing.Point(21, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(46, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "21%"
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(313, 153)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(75, 40)
        Me.btnB.TabIndex = 9
        Me.btnB.Text = "Borrar"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.TxtS)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtC)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtCP)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(107, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 113)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ventas"
        '
        'TxtS
        '
        Me.TxtS.Location = New System.Drawing.Point(11, 83)
        Me.TxtS.Name = "TxtS"
        Me.TxtS.ReadOnly = True
        Me.TxtS.Size = New System.Drawing.Size(100, 20)
        Me.TxtS.TabIndex = 15
        Me.TxtS.Text = "$                    250,5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Subtotal"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(123, 36)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(64, 20)
        Me.txtC.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cantidad"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(16, 36)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(103, 20)
        Me.txtCP.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Código del Producto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Generar Venta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 131)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(89, 68)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de IVA"
        '
        'Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 205)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGF)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Facturacion"
        Me.Text = "Facturacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGF As Button
    Friend WithEvents facA As RadioButton
    Friend WithEvents facB As RadioButton
    Friend WithEvents facC As RadioButton
    Friend WithEvents facE As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents facT As RadioButton
    Friend WithEvents dacM As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtCC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnB As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtS As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
