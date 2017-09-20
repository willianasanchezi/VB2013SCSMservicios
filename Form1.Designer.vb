<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCSM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SCSM))
        Me.btnservicios = New System.Windows.Forms.Button()
        Me.btnrenombrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnservicios
        '
        Me.btnservicios.Location = New System.Drawing.Point(77, 37)
        Me.btnservicios.Name = "btnservicios"
        Me.btnservicios.Size = New System.Drawing.Size(150, 23)
        Me.btnservicios.TabIndex = 0
        Me.btnservicios.Text = "HealthService"
        Me.btnservicios.UseVisualStyleBackColor = True
        '
        'btnrenombrar
        '
        Me.btnrenombrar.Location = New System.Drawing.Point(77, 136)
        Me.btnrenombrar.Name = "btnrenombrar"
        Me.btnrenombrar.Size = New System.Drawing.Size(150, 23)
        Me.btnrenombrar.TabIndex = 1
        Me.btnrenombrar.Text = "Renombrar Carpeta"
        Me.btnrenombrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desarrollado: Willian Sanchez Ibañez"
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(77, 165)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(150, 23)
        Me.btnborrar.TabIndex = 3
        Me.btnborrar.Text = "Borrar Carpeta"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(77, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "OMSDK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(77, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "OMCFG"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SCSM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 262)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnrenombrar)
        Me.Controls.Add(Me.btnservicios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SCSM"
        Me.Text = "SCSM Servicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnservicios As System.Windows.Forms.Button
    Friend WithEvents btnrenombrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
