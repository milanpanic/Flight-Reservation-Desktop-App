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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBarUcitavanje = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.LabelUcitavanje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(59, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ONLINE REZERVACIJA KARATA"
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(395, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dizajn: Milan Panić"
        '
        'ProgressBarUcitavanje
        '
        Me.ProgressBarUcitavanje.FillColor = System.Drawing.Color.White
        Me.ProgressBarUcitavanje.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProgressBarUcitavanje.Location = New System.Drawing.Point(-1, 270)
        Me.ProgressBarUcitavanje.Name = "ProgressBarUcitavanje"
        Me.ProgressBarUcitavanje.ProgressColor = System.Drawing.Color.Red
        Me.ProgressBarUcitavanje.ProgressColor2 = System.Drawing.Color.Red
        Me.ProgressBarUcitavanje.ShadowDecoration.Parent = Me.ProgressBarUcitavanje
        Me.ProgressBarUcitavanje.Size = New System.Drawing.Size(552, 20)
        Me.ProgressBarUcitavanje.TabIndex = 5
        Me.ProgressBarUcitavanje.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'LabelUcitavanje
        '
        Me.LabelUcitavanje.AutoSize = True
        Me.LabelUcitavanje.BackColor = System.Drawing.Color.Transparent
        Me.LabelUcitavanje.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUcitavanje.ForeColor = System.Drawing.Color.Red
        Me.LabelUcitavanje.Location = New System.Drawing.Point(241, 242)
        Me.LabelUcitavanje.Name = "LabelUcitavanje"
        Me.LabelUcitavanje.Size = New System.Drawing.Size(0, 25)
        Me.LabelUcitavanje.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(551, 291)
        Me.Controls.Add(Me.LabelUcitavanje)
        Me.Controls.Add(Me.ProgressBarUcitavanje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBarUcitavanje As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents LabelUcitavanje As Label
End Class
