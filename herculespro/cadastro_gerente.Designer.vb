<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastro_gerente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pic_sair = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_cep = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.lbl_confirmar_senha = New System.Windows.Forms.Label()
        Me.txt_confirmar_senha = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_instrucoes = New System.Windows.Forms.Label()
        Me.chk_exibir_senha = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.pic_sair)
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 38)
        Me.Panel1.TabIndex = 0
        '
        'pic_sair
        '
        Me.pic_sair.Location = New System.Drawing.Point(513, 4)
        Me.pic_sair.Name = "pic_sair"
        Me.pic_sair.Size = New System.Drawing.Size(75, 28)
        Me.pic_sair.TabIndex = 1
        Me.pic_sair.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(36, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(352, 23)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "HerculesPro | Cadastro de Gerente"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_cpf
        '
        Me.lbl_cpf.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(91, 105)
        Me.lbl_cpf.Margin = New System.Windows.Forms.Padding(25, 10, 3, 2)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(150, 25)
        Me.lbl_cpf.TabIndex = 14
        Me.lbl_cpf.Text = "CPF:"
        Me.lbl_cpf.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_cpf
        '
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(91, 136)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.txt_cpf.Mask = "000\.000\.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(418, 22)
        Me.txt_cpf.TabIndex = 15
        '
        'lbl_nome
        '
        Me.lbl_nome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(91, 155)
        Me.lbl_nome.Margin = New System.Windows.Forms.Padding(25, 10, 3, 2)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(150, 25)
        Me.lbl_nome.TabIndex = 16
        Me.lbl_nome.Text = "Nome Completo:"
        Me.lbl_nome.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_nome
        '
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(91, 185)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.txt_nome.MaxLength = 70
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(418, 22)
        Me.txt_nome.TabIndex = 17
        '
        'lbl_telefone
        '
        Me.lbl_telefone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.Location = New System.Drawing.Point(91, 211)
        Me.lbl_telefone.Margin = New System.Windows.Forms.Padding(25, 10, 3, 2)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(150, 25)
        Me.lbl_telefone.TabIndex = 18
        Me.lbl_telefone.Text = "Telefone:"
        Me.lbl_telefone.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_telefone
        '
        Me.txt_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_telefone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(91, 241)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.txt_telefone.Mask = "(00) 00000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(418, 22)
        Me.txt_telefone.TabIndex = 19
        '
        'lbl_cep
        '
        Me.lbl_cep.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cep.Location = New System.Drawing.Point(91, 269)
        Me.lbl_cep.Margin = New System.Windows.Forms.Padding(25, 10, 3, 2)
        Me.lbl_cep.Name = "lbl_cep"
        Me.lbl_cep.Size = New System.Drawing.Size(150, 25)
        Me.lbl_cep.TabIndex = 20
        Me.lbl_cep.Text = "CEP:"
        Me.lbl_cep.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_cep
        '
        Me.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cep.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.Location = New System.Drawing.Point(91, 299)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.txt_cep.Mask = "00000-000"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(418, 22)
        Me.txt_cep.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 328)
        Me.Label1.Margin = New System.Windows.Forms.Padding(25, 10, 3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Senha: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_senha
        '
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(91, 360)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(418, 22)
        Me.txt_senha.TabIndex = 23
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'lbl_confirmar_senha
        '
        Me.lbl_confirmar_senha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirmar_senha.Location = New System.Drawing.Point(91, 386)
        Me.lbl_confirmar_senha.Margin = New System.Windows.Forms.Padding(25, 10, 3, 2)
        Me.lbl_confirmar_senha.Name = "lbl_confirmar_senha"
        Me.lbl_confirmar_senha.Size = New System.Drawing.Size(150, 25)
        Me.lbl_confirmar_senha.TabIndex = 24
        Me.lbl_confirmar_senha.Text = "Confirmar Senha: "
        Me.lbl_confirmar_senha.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_confirmar_senha
        '
        Me.txt_confirmar_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_confirmar_senha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirmar_senha.Location = New System.Drawing.Point(91, 415)
        Me.txt_confirmar_senha.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.txt_confirmar_senha.Name = "txt_confirmar_senha"
        Me.txt_confirmar_senha.Size = New System.Drawing.Size(418, 22)
        Me.txt_confirmar_senha.TabIndex = 25
        Me.txt_confirmar_senha.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(140, 486)
        Me.Button1.Margin = New System.Windows.Forms.Padding(25, 15, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(321, 45)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "CADASTRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(141, 539)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(25, 5, 3, 3)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(321, 30)
        Me.btn_cancelar.TabIndex = 27
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'lbl_instrucoes
        '
        Me.lbl_instrucoes.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_instrucoes.Location = New System.Drawing.Point(40, 59)
        Me.lbl_instrucoes.Name = "lbl_instrucoes"
        Me.lbl_instrucoes.Size = New System.Drawing.Size(348, 36)
        Me.lbl_instrucoes.TabIndex = 30
        Me.lbl_instrucoes.Text = "Por favor, insira suas informações"
        Me.lbl_instrucoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk_exibir_senha
        '
        Me.chk_exibir_senha.AutoSize = True
        Me.chk_exibir_senha.Location = New System.Drawing.Point(406, 332)
        Me.chk_exibir_senha.Name = "chk_exibir_senha"
        Me.chk_exibir_senha.Size = New System.Drawing.Size(103, 23)
        Me.chk_exibir_senha.TabIndex = 31
        Me.chk_exibir_senha.Text = "Exibir senha"
        Me.chk_exibir_senha.UseVisualStyleBackColor = True
        '
        'cadastro_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 600)
        Me.Controls.Add(Me.chk_exibir_senha)
        Me.Controls.Add(Me.lbl_instrucoes)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_telefone)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.lbl_cep)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.lbl_confirmar_senha)
        Me.Controls.Add(Me.txt_confirmar_senha)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(150, 13)
        Me.Name = "cadastro_gerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cadastro_gerente"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pic_sair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents lbl_nome As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_telefone As Label
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents lbl_cep As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents lbl_confirmar_senha As Label
    Friend WithEvents txt_confirmar_senha As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents lbl_instrucoes As Label
    Friend WithEvents pic_sair As PictureBox
    Friend WithEvents chk_exibir_senha As CheckBox
End Class
