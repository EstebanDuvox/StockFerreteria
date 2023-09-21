<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu1))
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnProv = New System.Windows.Forms.Button()
        Me.btnProd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCU = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnC
        '
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(8, 159)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(92, 36)
        Me.btnC.TabIndex = 0
        Me.btnC.Text = "Clientes"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnProv
        '
        Me.btnProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProv.Location = New System.Drawing.Point(142, 159)
        Me.btnProv.Name = "btnProv"
        Me.btnProv.Size = New System.Drawing.Size(92, 36)
        Me.btnProv.TabIndex = 1
        Me.btnProv.Text = "Proveedores"
        Me.btnProv.UseVisualStyleBackColor = True
        '
        'btnProd
        '
        Me.btnProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProd.Location = New System.Drawing.Point(275, 159)
        Me.btnProd.Name = "btnProd"
        Me.btnProd.Size = New System.Drawing.Size(92, 36)
        Me.btnProd.TabIndex = 2
        Me.btnProd.Text = "Productos"
        Me.btnProd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "¿A cuál gestor desea ingresar?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(275, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cerrar Sesión"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCU
        '
        Me.btnCU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCU.Location = New System.Drawing.Point(8, 223)
        Me.btnCU.Name = "btnCU"
        Me.btnCU.Size = New System.Drawing.Size(92, 22)
        Me.btnCU.TabIndex = 6
        Me.btnCU.Text = "Crear Usuario"
        Me.btnCU.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Prototipo.My.Resources.Resources.Benvenue
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(8, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(359, 76)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(376, 268)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCU)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnProd)
        Me.Controls.Add(Me.btnProv)
        Me.Controls.Add(Me.btnC)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu1"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnC As Button
    Friend WithEvents btnProv As Button
    Friend WithEvents btnProd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCU As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
