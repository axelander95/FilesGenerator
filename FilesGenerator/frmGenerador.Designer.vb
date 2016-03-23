<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerador
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
        Me.lblSeleccion = New System.Windows.Forms.Label()
        Me.txtSeleccion = New System.Windows.Forms.TextBox()
        Me.btnSeleccion = New System.Windows.Forms.Button()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.nudNumero = New System.Windows.Forms.NumericUpDown()
        Me.lblCarpeta = New System.Windows.Forms.Label()
        Me.txtCarpeta = New System.Windows.Forms.TextBox()
        Me.btnCarpeta = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.ofdSeleccion = New System.Windows.Forms.OpenFileDialog()
        Me.fbdCarpeta = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSeleccion
        '
        Me.lblSeleccion.AutoSize = True
        Me.lblSeleccion.Location = New System.Drawing.Point(65, 15)
        Me.lblSeleccion.Name = "lblSeleccion"
        Me.lblSeleccion.Size = New System.Drawing.Size(109, 13)
        Me.lblSeleccion.TabIndex = 0
        Me.lblSeleccion.Text = "Seleccione el archivo"
        '
        'txtSeleccion
        '
        Me.txtSeleccion.Location = New System.Drawing.Point(180, 12)
        Me.txtSeleccion.Name = "txtSeleccion"
        Me.txtSeleccion.ReadOnly = True
        Me.txtSeleccion.Size = New System.Drawing.Size(310, 20)
        Me.txtSeleccion.TabIndex = 1
        '
        'btnSeleccion
        '
        Me.btnSeleccion.Location = New System.Drawing.Point(496, 12)
        Me.btnSeleccion.Name = "btnSeleccion"
        Me.btnSeleccion.Size = New System.Drawing.Size(26, 20)
        Me.btnSeleccion.TabIndex = 2
        Me.btnSeleccion.Text = "..."
        Me.btnSeleccion.UseVisualStyleBackColor = True
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(32, 41)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(142, 13)
        Me.lblNumero.TabIndex = 3
        Me.lblNumero.Text = "Nº de clonaciones a generar"
        '
        'nudNumero
        '
        Me.nudNumero.Location = New System.Drawing.Point(180, 39)
        Me.nudNumero.Name = "nudNumero"
        Me.nudNumero.Size = New System.Drawing.Size(120, 20)
        Me.nudNumero.TabIndex = 4
        Me.nudNumero.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblCarpeta
        '
        Me.lblCarpeta.AutoSize = True
        Me.lblCarpeta.Location = New System.Drawing.Point(12, 68)
        Me.lblCarpeta.Name = "lblCarpeta"
        Me.lblCarpeta.Size = New System.Drawing.Size(162, 13)
        Me.lblCarpeta.TabIndex = 5
        Me.lblCarpeta.Text = "Seleccione la carpeta de destino"
        '
        'txtCarpeta
        '
        Me.txtCarpeta.Location = New System.Drawing.Point(180, 65)
        Me.txtCarpeta.Name = "txtCarpeta"
        Me.txtCarpeta.ReadOnly = True
        Me.txtCarpeta.Size = New System.Drawing.Size(310, 20)
        Me.txtCarpeta.TabIndex = 6
        '
        'btnCarpeta
        '
        Me.btnCarpeta.Location = New System.Drawing.Point(496, 64)
        Me.btnCarpeta.Name = "btnCarpeta"
        Me.btnCarpeta.Size = New System.Drawing.Size(26, 20)
        Me.btnCarpeta.TabIndex = 7
        Me.btnCarpeta.Text = "..."
        Me.btnCarpeta.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(447, 91)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(366, 91)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 9
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'ofdSeleccion
        '
        Me.ofdSeleccion.Filter = "Archivos de Excel (.xls)|*.xls|Archivos de texto (.txt)|*.txt"
        Me.ofdSeleccion.Title = "Archivo"
        '
        'frmGenerador
        '
        Me.AcceptButton = Me.btnGenerar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(534, 122)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCarpeta)
        Me.Controls.Add(Me.txtCarpeta)
        Me.Controls.Add(Me.lblCarpeta)
        Me.Controls.Add(Me.nudNumero)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.btnSeleccion)
        Me.Controls.Add(Me.txtSeleccion)
        Me.Controls.Add(Me.lblSeleccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmGenerador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de Archivos (Herramienta Intermedia)"
        CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeleccion As System.Windows.Forms.Label
    Friend WithEvents txtSeleccion As System.Windows.Forms.TextBox
    Friend WithEvents btnSeleccion As System.Windows.Forms.Button
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents nudNumero As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCarpeta As System.Windows.Forms.Label
    Friend WithEvents txtCarpeta As System.Windows.Forms.TextBox
    Friend WithEvents btnCarpeta As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents ofdSeleccion As System.Windows.Forms.OpenFileDialog
    Friend WithEvents fbdCarpeta As System.Windows.Forms.FolderBrowserDialog

End Class
