<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        TextBox1 = New TextBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton6 = New RadioButton()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(27, 40)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(296, 23)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Hello world from earth"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Segoe UI", 10F)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(634, 370)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 45)
        Button1.TabIndex = 1
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(27, 96)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(296, 248)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.MenuHighlight
        Button2.Font = New Font("Segoe UI", 10F)
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(27, 370)
        Button2.Name = "Button2"
        Button2.Size = New Size(296, 41)
        Button2.TabIndex = 3
        Button2.Text = "Load Image"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(461, 74)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(81, 19)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "Garamond"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(577, 74)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(73, 19)
        RadioButton2.TabIndex = 5
        RadioButton2.TabStop = True
        RadioButton2.Text = "Magneto"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(673, 74)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(67, 19)
        RadioButton3.TabIndex = 6
        RadioButton3.TabStop = True
        RadioButton3.Text = "Tahoma"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(461, 132)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(51, 19)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Italic"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(461, 181)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(50, 19)
        CheckBox2.TabIndex = 8
        CheckBox2.Text = "Bold"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(461, 229)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(78, 19)
        CheckBox3.TabIndex = 9
        CheckBox3.Text = "Bold Italic"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(670, 132)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(56, 19)
        RadioButton4.TabIndex = 10
        RadioButton4.TabStop = True
        RadioButton4.Text = "Green"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(670, 180)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(48, 19)
        RadioButton5.TabIndex = 11
        RadioButton5.TabStop = True
        RadioButton5.Text = "Blue"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(670, 228)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(45, 19)
        RadioButton6.TabIndex = 12
        RadioButton6.TabStop = True
        RadioButton6.Text = "Red"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(460, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 21)
        Label1.TabIndex = 13
        Label1.Text = "Font"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(RadioButton6)
        Controls.Add(RadioButton5)
        Controls.Add(RadioButton4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Label1 As Label
End Class
