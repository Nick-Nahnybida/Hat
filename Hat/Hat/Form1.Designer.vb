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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picKoala = New System.Windows.Forms.PictureBox()
        Me.btnGo = New System.Windows.Forms.Button()
        CType(Me.picKoala, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picKoala
        '
        Me.picKoala.Image = CType(resources.GetObject("picKoala.Image"), System.Drawing.Image)
        Me.picKoala.Location = New System.Drawing.Point(78, 66)
        Me.picKoala.Name = "picKoala"
        Me.picKoala.Size = New System.Drawing.Size(100, 50)
        Me.picKoala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKoala.TabIndex = 0
        Me.picKoala.TabStop = False
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(60, 196)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 340)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.picKoala)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picKoala, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picKoala As System.Windows.Forms.PictureBox
    Friend WithEvents btnGo As System.Windows.Forms.Button

End Class
