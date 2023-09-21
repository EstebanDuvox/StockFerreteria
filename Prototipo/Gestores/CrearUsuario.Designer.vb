<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rbp = New System.Windows.Forms.RadioButton()
        Me.txtcnu = New System.Windows.Forms.TextBox()
        Me.rba = New System.Windows.Forms.RadioButton()
        Me.rbg = New System.Windows.Forms.RadioButton()
        Me.txtcc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbp
        '
        Me.rbp.AutoSize = True
        Me.rbp.Location = New System.Drawing.Point(74, 351)
        Me.rbp.Name = "rbp"
        Me.rbp.Size = New System.Drawing.Size(66, 17)
        Me.rbp.TabIndex = 0
        Me.rbp.TabStop = True
        Me.rbp.Text = "Personal"
        Me.rbp.UseVisualStyleBackColor = True
        '
        'txtcnu
        '
        Me.txtcnu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcnu.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtcnu.Location = New System.Drawing.Point(109, 202)
        Me.txtcnu.Name = "txtcnu"
        Me.txtcnu.Size = New System.Drawing.Size(226, 20)
        Me.txtcnu.TabIndex = 1
        Me.txtcnu.Text = "Ej: Juan_P"
        '
        'rba
        '
        Me.rba.AutoSize = True
        Me.rba.Location = New System.Drawing.Point(268, 351)
        Me.rba.Name = "rba"
        Me.rba.Size = New System.Drawing.Size(88, 17)
        Me.rba.TabIndex = 2
        Me.rba.TabStop = True
        Me.rba.Text = "Administrador"
        Me.rba.UseVisualStyleBackColor = True
        '
        'rbg
        '
        Me.rbg.AutoSize = True
        Me.rbg.Location = New System.Drawing.Point(174, 351)
        Me.rbg.Name = "rbg"
        Me.rbg.Size = New System.Drawing.Size(63, 17)
        Me.rbg.TabIndex = 3
        Me.rbg.TabStop = True
        Me.rbg.Text = "Gerente"
        Me.rbg.UseVisualStyleBackColor = True
        '
        'txtcc
        '
        Me.txtcc.Location = New System.Drawing.Point(109, 245)
        Me.txtcc.Name = "txtcc"
        Me.txtcc.Size = New System.Drawing.Size(226, 20)
        Me.txtcc.TabIndex = 4
        Me.txtcc.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nombre de Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Contraseña:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(109, 271)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(118, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Mostrar Contraseña"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Prototipo.My.Resources.Resources.Crear_Usuario
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(28, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 155)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(109, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(225, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tipo de Usuario:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcc)
        Me.Controls.Add(Me.rbg)
        Me.Controls.Add(Me.rba)
        Me.Controls.Add(Me.txtcnu)
        Me.Controls.Add(Me.rbp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Crear Usuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbp As RadioButton
    Friend WithEvents txtcnu As TextBox
    Friend WithEvents rba As RadioButton
    Friend WithEvents rbg As RadioButton
    Friend WithEvents txtcc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
End Class
