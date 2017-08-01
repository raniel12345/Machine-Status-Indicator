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
        Me.components = New System.ComponentModel.Container
        Me.BtnEBR = New System.Windows.Forms.Button
        Me.BtnNoMaterial = New System.Windows.Forms.Button
        Me.BtnIDLE = New System.Windows.Forms.Button
        Me.BtnOngoRep = New System.Windows.Forms.Button
        Me.BtnRunProd = New System.Windows.Forms.Button
        Me.lblIDLECount = New System.Windows.Forms.Label
        Me.IndicatorTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BtnEBR
        '
        Me.BtnEBR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEBR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEBR.ForeColor = System.Drawing.Color.Black
        Me.BtnEBR.Location = New System.Drawing.Point(344, 7)
        Me.BtnEBR.Name = "BtnEBR"
        Me.BtnEBR.Size = New System.Drawing.Size(77, 42)
        Me.BtnEBR.TabIndex = 10
        Me.BtnEBR.Text = "EBR"
        Me.BtnEBR.UseVisualStyleBackColor = False
        '
        'BtnNoMaterial
        '
        Me.BtnNoMaterial.BackColor = System.Drawing.Color.Gray
        Me.BtnNoMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNoMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNoMaterial.ForeColor = System.Drawing.Color.Black
        Me.BtnNoMaterial.Location = New System.Drawing.Point(261, 7)
        Me.BtnNoMaterial.Name = "BtnNoMaterial"
        Me.BtnNoMaterial.Size = New System.Drawing.Size(77, 42)
        Me.BtnNoMaterial.TabIndex = 9
        Me.BtnNoMaterial.Text = "No Material"
        Me.BtnNoMaterial.UseVisualStyleBackColor = False
        '
        'BtnIDLE
        '
        Me.BtnIDLE.BackColor = System.Drawing.Color.Yellow
        Me.BtnIDLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIDLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIDLE.ForeColor = System.Drawing.Color.Black
        Me.BtnIDLE.Location = New System.Drawing.Point(178, 7)
        Me.BtnIDLE.Name = "BtnIDLE"
        Me.BtnIDLE.Size = New System.Drawing.Size(77, 42)
        Me.BtnIDLE.TabIndex = 8
        Me.BtnIDLE.Text = "IDLE"
        Me.BtnIDLE.UseVisualStyleBackColor = False
        '
        'BtnOngoRep
        '
        Me.BtnOngoRep.BackColor = System.Drawing.Color.Red
        Me.BtnOngoRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOngoRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOngoRep.ForeColor = System.Drawing.Color.Black
        Me.BtnOngoRep.Location = New System.Drawing.Point(95, 7)
        Me.BtnOngoRep.Name = "BtnOngoRep"
        Me.BtnOngoRep.Size = New System.Drawing.Size(77, 42)
        Me.BtnOngoRep.TabIndex = 7
        Me.BtnOngoRep.Text = "Ongoing Repair"
        Me.BtnOngoRep.UseVisualStyleBackColor = False
        '
        'BtnRunProd
        '
        Me.BtnRunProd.BackColor = System.Drawing.Color.Lime
        Me.BtnRunProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRunProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRunProd.ForeColor = System.Drawing.Color.Black
        Me.BtnRunProd.Location = New System.Drawing.Point(12, 7)
        Me.BtnRunProd.Name = "BtnRunProd"
        Me.BtnRunProd.Size = New System.Drawing.Size(77, 42)
        Me.BtnRunProd.TabIndex = 6
        Me.BtnRunProd.Text = "Running Production"
        Me.BtnRunProd.UseVisualStyleBackColor = False
        '
        'lblIDLECount
        '
        Me.lblIDLECount.AutoSize = True
        Me.lblIDLECount.Location = New System.Drawing.Point(12, 52)
        Me.lblIDLECount.Name = "lblIDLECount"
        Me.lblIDLECount.Size = New System.Drawing.Size(13, 13)
        Me.lblIDLECount.TabIndex = 12
        Me.lblIDLECount.Text = "--"
        '
        'IndicatorTimer
        '
        Me.IndicatorTimer.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(370, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "___"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Location = New System.Drawing.Point(405, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "X"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(431, 74)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblIDLECount)
        Me.Controls.Add(Me.BtnEBR)
        Me.Controls.Add(Me.BtnNoMaterial)
        Me.Controls.Add(Me.BtnIDLE)
        Me.Controls.Add(Me.BtnOngoRep)
        Me.Controls.Add(Me.BtnRunProd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEBR As System.Windows.Forms.Button
    Friend WithEvents BtnNoMaterial As System.Windows.Forms.Button
    Friend WithEvents BtnIDLE As System.Windows.Forms.Button
    Friend WithEvents BtnOngoRep As System.Windows.Forms.Button
    Friend WithEvents BtnRunProd As System.Windows.Forms.Button
    Friend WithEvents lblIDLECount As System.Windows.Forms.Label
    Friend WithEvents IndicatorTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
