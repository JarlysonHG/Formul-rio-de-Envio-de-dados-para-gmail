<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Timer1 = New Timer(components)
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(146, 87)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(489, 87)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(124, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(146, 124)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(124, 23)
        TextBox3.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(25, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 17)
        Label1.TabIndex = 3
        Label1.Text = "Nome Completo:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(61, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 17)
        Label2.TabIndex = 4
        Label2.Text = "Identidade:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(451, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 17)
        Label3.TabIndex = 5
        Label3.Text = "CPF:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(349, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 17)
        Label4.TabIndex = 6
        Label4.Text = "Data de Nascimento:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(489, 124)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(124, 23)
        TextBox4.TabIndex = 7
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(176, 184)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(338, 26)
        ProgressBar1.TabIndex = 80
        ProgressBar1.Value = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.BlueViolet
        Button1.Location = New Point(278, 246)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 36)
        Button1.TabIndex = 9
        Button1.Text = "Enviar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(105, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(464, 45)
        Label5.TabIndex = 10
        Label5.Text = "Preencha os Campos Abaixo"
        ' 
        ' Form1
        ' 
        AcceptButton = Button1
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._1297020
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(653, 309)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(ProgressBar1)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Formulário para Envio de Dados"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label

End Class
