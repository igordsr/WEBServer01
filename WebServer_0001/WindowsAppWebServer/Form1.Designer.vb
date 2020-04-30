<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtBoxTitle = New System.Windows.Forms.TextBox()
        Me.txtBoxUserId = New System.Windows.Forms.TextBox()
        Me.txtBoxBoby = New System.Windows.Forms.RichTextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtBoxResponse = New System.Windows.Forms.RichTextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtBox_cep = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(457, 301)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 23
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtBoxTitle
        '
        Me.txtBoxTitle.Location = New System.Drawing.Point(289, 60)
        Me.txtBoxTitle.Name = "txtBoxTitle"
        Me.txtBoxTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTitle.TabIndex = 22
        '
        'txtBoxUserId
        '
        Me.txtBoxUserId.Location = New System.Drawing.Point(289, 32)
        Me.txtBoxUserId.Name = "txtBoxUserId"
        Me.txtBoxUserId.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxUserId.TabIndex = 21
        '
        'txtBoxBoby
        '
        Me.txtBoxBoby.Location = New System.Drawing.Point(242, 101)
        Me.txtBoxBoby.Name = "txtBoxBoby"
        Me.txtBoxBoby.Size = New System.Drawing.Size(290, 194)
        Me.txtBoxBoby.TabIndex = 20
        Me.txtBoxBoby.Text = ""
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(239, 36)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(44, 13)
        Me.label4.TabIndex = 19
        Me.label4.Text = "User Id:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(239, 63)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(27, 13)
        Me.label3.TabIndex = 18
        Me.label3.Text = "Title"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(239, 85)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(31, 13)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Body"
        '
        'txtBoxResponse
        '
        Me.txtBoxResponse.Location = New System.Drawing.Point(12, 36)
        Me.txtBoxResponse.Name = "txtBoxResponse"
        Me.txtBoxResponse.Size = New System.Drawing.Size(221, 259)
        Me.txtBoxResponse.TabIndex = 16
        Me.txtBoxResponse.Text = ""
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(158, 4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 15
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtBox_cep
        '
        Me.txtBox_cep.Location = New System.Drawing.Point(51, 5)
        Me.txtBox_cep.Name = "txtBox_cep"
        Me.txtBox_cep.Size = New System.Drawing.Size(100, 20)
        Me.txtBox_cep.TabIndex = 14
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(9, 8)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(29, 13)
        Me.lblCep.TabIndex = 13
        Me.lblCep.Text = "Cod:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 334)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtBoxTitle)
        Me.Controls.Add(Me.txtBoxUserId)
        Me.Controls.Add(Me.txtBoxBoby)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtBoxResponse)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtBox_cep)
        Me.Controls.Add(Me.lblCep)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnSend As Button
    Private WithEvents txtBoxTitle As TextBox
    Private WithEvents txtBoxUserId As TextBox
    Private WithEvents txtBoxBoby As RichTextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents txtBoxResponse As RichTextBox
    Private WithEvents btnConsultar As Button
    Private WithEvents txtBox_cep As TextBox
    Private WithEvents lblCep As Label
End Class
