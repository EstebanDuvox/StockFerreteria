<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnB = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btE = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.txtT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btN = New System.Windows.Forms.Button()
        Me.txtE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgList = New System.Windows.Forms.DataGridView()
        Me.txtEm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnB)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtB)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.btE)
        Me.GroupBox2.Location = New System.Drawing.Point(512, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 149)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar"
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(205, 120)
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
        'txtB
        '
        Me.txtB.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtB.Location = New System.Drawing.Point(6, 93)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(264, 20)
        Me.txtB.TabIndex = 20
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Empresa", "CUIT", "Telefono"})
        Me.ComboBox1.Location = New System.Drawing.Point(158, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox1.TabIndex = 19
        Me.ComboBox1.Text = "Empresa"
        '
        'btE
        '
        Me.btE.Location = New System.Drawing.Point(6, 120)
        Me.btE.Name = "btE"
        Me.btE.Size = New System.Drawing.Size(75, 23)
        Me.btE.TabIndex = 21
        Me.btE.Text = "Remover"
        Me.btE.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEm)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnUp)
        Me.GroupBox1.Controls.Add(Me.txtT)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtD)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btN)
        Me.GroupBox1.Controls.Add(Me.txtE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 149)
        Me.GroupBox1.TabIndex = 27
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
        'txtT
        '
        Me.txtT.Location = New System.Drawing.Point(311, 81)
        Me.txtT.Name = "txtT"
        Me.txtT.Size = New System.Drawing.Size(157, 20)
        Me.txtT.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(250, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Teléfono:"
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(311, 55)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(157, 20)
        Me.txtD.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Location = New System.Drawing.Point(250, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Dirección:"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(91, 67)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(93, 20)
        Me.txtC.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "CUIT:"
        '
        'btN
        '
        Me.btN.Location = New System.Drawing.Point(413, 120)
        Me.btN.Name = "btN"
        Me.btN.Size = New System.Drawing.Size(75, 23)
        Me.btN.TabIndex = 18
        Me.btN.Text = "Agregar"
        Me.btN.UseVisualStyleBackColor = True
        '
        'txtE
        '
        Me.txtE.Location = New System.Drawing.Point(91, 41)
        Me.txtE.Name = "txtE"
        Me.txtE.Size = New System.Drawing.Size(93, 20)
        Me.txtE.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Empresa:"
        '
        'dgList
        '
        Me.dgList.AllowUserToAddRows = False
        Me.dgList.AllowUserToDeleteRows = False
        Me.dgList.AllowUserToOrderColumns = True
        Me.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgList.Location = New System.Drawing.Point(12, 167)
        Me.dgList.Name = "dgList"
        Me.dgList.ReadOnly = True
        Me.dgList.Size = New System.Drawing.Size(776, 334)
        Me.dgList.TabIndex = 26
        '
        'txtEm
        '
        Me.txtEm.Location = New System.Drawing.Point(311, 29)
        Me.txtEm.Name = "txtEm"
        Me.txtEm.Size = New System.Drawing.Size(157, 20)
        Me.txtEm.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Location = New System.Drawing.Point(267, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Email:"
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 513)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Proveedores"
        Me.Text = "Gestor de Proveedores"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtD As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btE As Button
    Friend WithEvents btN As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dgList As DataGridView
    Friend WithEvents txtE As TextBox
    Friend WithEvents btnB As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents txtEm As TextBox
    Friend WithEvents Label1 As Label
End Class
