<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastro_professores
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
        Me.lbl_cpf_cliente = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_nome_cliente = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_cep = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbx_situacao = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_exibir_senha = New System.Windows.Forms.CheckBox()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.txt_cref = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.radio_sexo_fem = New System.Windows.Forms.RadioButton()
        Me.radio_sexo_masc = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.num_salario = New System.Windows.Forms.NumericUpDown()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.num_salario, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(500, 38)
        Me.Panel1.TabIndex = 1
        '
        'pic_sair
        '
        Me.pic_sair.Location = New System.Drawing.Point(411, 4)
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
        Me.lbl_title.Text = "HerculesPro | Cadastro de Professores"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_cpf_cliente
        '
        Me.lbl_cpf_cliente.AutoSize = True
        Me.lbl_cpf_cliente.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf_cliente.Location = New System.Drawing.Point(11, 63)
        Me.lbl_cpf_cliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cpf_cliente.Name = "lbl_cpf_cliente"
        Me.lbl_cpf_cliente.Size = New System.Drawing.Size(48, 19)
        Me.lbl_cpf_cliente.TabIndex = 37
        Me.lbl_cpf_cliente.Text = "CPF: *"
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(15, 84)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf.Mask = "000\.000\.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(115, 26)
        Me.txt_cpf.TabIndex = 38
        '
        'lbl_nome_cliente
        '
        Me.lbl_nome_cliente.AutoSize = True
        Me.lbl_nome_cliente.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_cliente.Location = New System.Drawing.Point(139, 63)
        Me.lbl_nome_cliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nome_cliente.Name = "lbl_nome_cliente"
        Me.lbl_nome_cliente.Size = New System.Drawing.Size(64, 19)
        Me.lbl_nome_cliente.TabIndex = 39
        Me.lbl_nome_cliente.Text = "Nome: *"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(143, 84)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.MaxLength = 60
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(344, 26)
        Me.txt_nome.TabIndex = 40
        '
        'lbl_cep
        '
        Me.lbl_cep.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_cep.Location = New System.Drawing.Point(139, 124)
        Me.lbl_cep.Margin = New System.Windows.Forms.Padding(25, 10, 3, 2)
        Me.lbl_cep.Name = "lbl_cep"
        Me.lbl_cep.Size = New System.Drawing.Size(73, 25)
        Me.lbl_cep.TabIndex = 41
        Me.lbl_cep.Text = "CEP: *"
        Me.lbl_cep.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_cep
        '
        Me.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cep.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txt_cep.Location = New System.Drawing.Point(143, 151)
        Me.txt_cep.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.txt_cep.Mask = "00000-000"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(103, 26)
        Me.txt_cep.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Cref: *"
        '
        'cbx_situacao
        '
        Me.cbx_situacao.FormattingEnabled = True
        Me.cbx_situacao.Items.AddRange(New Object() {"ATIVO", "DESLIGADO"})
        Me.cbx_situacao.Location = New System.Drawing.Point(17, 353)
        Me.cbx_situacao.Margin = New System.Windows.Forms.Padding(2)
        Me.cbx_situacao.Name = "cbx_situacao"
        Me.cbx_situacao.Size = New System.Drawing.Size(220, 21)
        Me.cbx_situacao.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 332)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Situação: *"
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_gravar.Location = New System.Drawing.Point(11, 449)
        Me.btn_gravar.Margin = New System.Windows.Forms.Padding(19, 12, 2, 2)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(226, 37)
        Me.btn_gravar.TabIndex = 67
        Me.btn_gravar.Text = "Gravar Informações"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(15, 410)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(19, 2, 2, 2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(471, 25)
        Me.txt_senha.TabIndex = 68
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 389)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Senha: *"
        '
        'chk_exibir_senha
        '
        Me.chk_exibir_senha.AutoSize = True
        Me.chk_exibir_senha.Location = New System.Drawing.Point(403, 389)
        Me.chk_exibir_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_exibir_senha.Name = "chk_exibir_senha"
        Me.chk_exibir_senha.Size = New System.Drawing.Size(83, 17)
        Me.chk_exibir_senha.TabIndex = 70
        Me.chk_exibir_senha.Text = "Exibir senha"
        Me.chk_exibir_senha.UseVisualStyleBackColor = True
        '
        'btn_excluir
        '
        Me.btn_excluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excluir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_excluir.Location = New System.Drawing.Point(260, 449)
        Me.btn_excluir.Margin = New System.Windows.Forms.Padding(19, 12, 2, 2)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(226, 37)
        Me.btn_excluir.TabIndex = 71
        Me.btn_excluir.Text = "Excluir registro"
        Me.btn_excluir.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(11, 493)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(19, 4, 2, 2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(475, 28)
        Me.btn_cancelar.TabIndex = 72
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'txt_cref
        '
        Me.txt_cref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cref.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txt_cref.Location = New System.Drawing.Point(15, 151)
        Me.txt_cref.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.txt_cref.Mask = "000000-LL/L"
        Me.txt_cref.Name = "txt_cref"
        Me.txt_cref.Size = New System.Drawing.Size(115, 26)
        Me.txt_cref.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Telefone: *"
        '
        'txt_telefone
        '
        Me.txt_telefone.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(260, 151)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_telefone.Mask = "(00) 00000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(227, 26)
        Me.txt_telefone.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 197)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 19)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Sexo: *"
        '
        'radio_sexo_fem
        '
        Me.radio_sexo_fem.AutoSize = True
        Me.radio_sexo_fem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_sexo_fem.Location = New System.Drawing.Point(15, 218)
        Me.radio_sexo_fem.Margin = New System.Windows.Forms.Padding(2)
        Me.radio_sexo_fem.Name = "radio_sexo_fem"
        Me.radio_sexo_fem.Size = New System.Drawing.Size(83, 23)
        Me.radio_sexo_fem.TabIndex = 79
        Me.radio_sexo_fem.TabStop = True
        Me.radio_sexo_fem.Text = "Feminino"
        Me.radio_sexo_fem.UseVisualStyleBackColor = True
        '
        'radio_sexo_masc
        '
        Me.radio_sexo_masc.AutoSize = True
        Me.radio_sexo_masc.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_sexo_masc.Location = New System.Drawing.Point(134, 218)
        Me.radio_sexo_masc.Margin = New System.Windows.Forms.Padding(2)
        Me.radio_sexo_masc.Name = "radio_sexo_masc"
        Me.radio_sexo_masc.Size = New System.Drawing.Size(89, 23)
        Me.radio_sexo_masc.TabIndex = 80
        Me.radio_sexo_masc.TabStop = True
        Me.radio_sexo_masc.Text = "Masculino"
        Me.radio_sexo_masc.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 27)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 19)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Salário: *"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.num_salario)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 82)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações de Pagamento"
        '
        'num_salario
        '
        Me.num_salario.DecimalPlaces = 2
        Me.num_salario.Increment = New Decimal(New Integer() {50, 0, 0, 131072})
        Me.num_salario.Location = New System.Drawing.Point(4, 49)
        Me.num_salario.Maximum = New Decimal(New Integer() {99999999, 0, 0, 131072})
        Me.num_salario.Name = "num_salario"
        Me.num_salario.Size = New System.Drawing.Size(222, 20)
        Me.num_salario.TabIndex = 87
        '
        'cadastro_professores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 529)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.radio_sexo_masc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbx_situacao)
        Me.Controls.Add(Me.radio_sexo_fem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cref)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.chk_exibir_senha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_cep)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.lbl_nome_cliente)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_cpf_cliente)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cadastro_professores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cadastro_funcionarios"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pic_sair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.num_salario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pic_sair As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_cpf_cliente As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents lbl_nome_cliente As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_cep As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbx_situacao As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_gravar As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chk_exibir_senha As CheckBox
    Friend WithEvents btn_excluir As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents txt_cref As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents radio_sexo_fem As RadioButton
    Friend WithEvents radio_sexo_masc As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents num_salario As NumericUpDown
End Class
