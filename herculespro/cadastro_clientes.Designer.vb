<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro_clientes
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pic_sair = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_validade_exame = New System.Windows.Forms.Label()
        Me.txt_restricoes = New System.Windows.Forms.TextBox()
        Me.lbl_restricoes = New System.Windows.Forms.Label()
        Me.txt_patologia = New System.Windows.Forms.TextBox()
        Me.lbl_patologia = New System.Windows.Forms.Label()
        Me.radio_sexo_fem = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radio_sexo_masc = New System.Windows.Forms.RadioButton()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.lbl_data_matricula = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_nome_cliente = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_cpf_cliente = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbx_professor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_situacao = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbx_plano = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.num_frequencia = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.num_idade = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_cpf_responsavel = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_cpf_responsavel = New System.Windows.Forms.Label()
        Me.date_validade_exame = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.num_frequencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_idade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(549, 38)
        Me.Panel1.TabIndex = 1
        '
        'pic_sair
        '
        Me.pic_sair.Location = New System.Drawing.Point(446, 3)
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
        Me.lbl_title.Text = "HerculesPro | Cadastro de Clientes"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_validade_exame
        '
        Me.lbl_validade_exame.AutoSize = True
        Me.lbl_validade_exame.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_validade_exame.Location = New System.Drawing.Point(13, 304)
        Me.lbl_validade_exame.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_validade_exame.Name = "lbl_validade_exame"
        Me.lbl_validade_exame.Size = New System.Drawing.Size(205, 19)
        Me.lbl_validade_exame.TabIndex = 49
        Me.lbl_validade_exame.Text = "Validade do Exame Médico: *"
        '
        'txt_restricoes
        '
        Me.txt_restricoes.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_restricoes.Location = New System.Drawing.Point(3, 99)
        Me.txt_restricoes.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_restricoes.Name = "txt_restricoes"
        Me.txt_restricoes.Size = New System.Drawing.Size(314, 26)
        Me.txt_restricoes.TabIndex = 48
        '
        'lbl_restricoes
        '
        Me.lbl_restricoes.AutoSize = True
        Me.lbl_restricoes.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_restricoes.Location = New System.Drawing.Point(0, 78)
        Me.lbl_restricoes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_restricoes.Name = "lbl_restricoes"
        Me.lbl_restricoes.Size = New System.Drawing.Size(81, 19)
        Me.lbl_restricoes.TabIndex = 47
        Me.lbl_restricoes.Text = "Restrições:"
        '
        'txt_patologia
        '
        Me.txt_patologia.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_patologia.Location = New System.Drawing.Point(2, 41)
        Me.txt_patologia.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_patologia.Multiline = True
        Me.txt_patologia.Name = "txt_patologia"
        Me.txt_patologia.Size = New System.Drawing.Size(314, 35)
        Me.txt_patologia.TabIndex = 46
        '
        'lbl_patologia
        '
        Me.lbl_patologia.AutoSize = True
        Me.lbl_patologia.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_patologia.Location = New System.Drawing.Point(0, 20)
        Me.lbl_patologia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_patologia.Name = "lbl_patologia"
        Me.lbl_patologia.Size = New System.Drawing.Size(78, 19)
        Me.lbl_patologia.TabIndex = 45
        Me.lbl_patologia.Text = "Patologia:"
        '
        'radio_sexo_fem
        '
        Me.radio_sexo_fem.AutoSize = True
        Me.radio_sexo_fem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_sexo_fem.Location = New System.Drawing.Point(14, 217)
        Me.radio_sexo_fem.Margin = New System.Windows.Forms.Padding(2)
        Me.radio_sexo_fem.Name = "radio_sexo_fem"
        Me.radio_sexo_fem.Size = New System.Drawing.Size(83, 23)
        Me.radio_sexo_fem.TabIndex = 44
        Me.radio_sexo_fem.TabStop = True
        Me.radio_sexo_fem.Text = "Feminino"
        Me.radio_sexo_fem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 196)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Sexo: *"
        '
        'radio_sexo_masc
        '
        Me.radio_sexo_masc.AutoSize = True
        Me.radio_sexo_masc.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_sexo_masc.Location = New System.Drawing.Point(130, 217)
        Me.radio_sexo_masc.Margin = New System.Windows.Forms.Padding(2)
        Me.radio_sexo_masc.Name = "radio_sexo_masc"
        Me.radio_sexo_masc.Size = New System.Drawing.Size(89, 23)
        Me.radio_sexo_masc.TabIndex = 42
        Me.radio_sexo_masc.TabStop = True
        Me.radio_sexo_masc.Text = "Masculino"
        Me.radio_sexo_masc.UseVisualStyleBackColor = True
        '
        'txt_telefone
        '
        Me.txt_telefone.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(14, 153)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_telefone.Mask = "(00) 00000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(315, 26)
        Me.txt_telefone.TabIndex = 41
        Me.txt_telefone.ValidatingType = GetType(Date)
        '
        'lbl_telefone
        '
        Me.lbl_telefone.AutoSize = True
        Me.lbl_telefone.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.Location = New System.Drawing.Point(13, 131)
        Me.lbl_telefone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(80, 19)
        Me.lbl_telefone.TabIndex = 40
        Me.lbl_telefone.Text = "Telefone: *"
        '
        'lbl_data_matricula
        '
        Me.lbl_data_matricula.AutoSize = True
        Me.lbl_data_matricula.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_data_matricula.Location = New System.Drawing.Point(229, 500)
        Me.lbl_data_matricula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_data_matricula.Name = "lbl_data_matricula"
        Me.lbl_data_matricula.Size = New System.Drawing.Size(0, 19)
        Me.lbl_data_matricula.TabIndex = 39
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(193, 86)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.MaxLength = 60
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(343, 26)
        Me.txt_nome.TabIndex = 38
        '
        'lbl_nome_cliente
        '
        Me.lbl_nome_cliente.AutoSize = True
        Me.lbl_nome_cliente.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_cliente.Location = New System.Drawing.Point(189, 65)
        Me.lbl_nome_cliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nome_cliente.Name = "lbl_nome_cliente"
        Me.lbl_nome_cliente.Size = New System.Drawing.Size(64, 19)
        Me.lbl_nome_cliente.TabIndex = 37
        Me.lbl_nome_cliente.Text = "Nome: *"
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(14, 86)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf.Mask = "000\.000\.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(125, 26)
        Me.txt_cpf.TabIndex = 36
        '
        'lbl_cpf_cliente
        '
        Me.lbl_cpf_cliente.AutoSize = True
        Me.lbl_cpf_cliente.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf_cliente.Location = New System.Drawing.Point(15, 65)
        Me.lbl_cpf_cliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cpf_cliente.Name = "lbl_cpf_cliente"
        Me.lbl_cpf_cliente.Size = New System.Drawing.Size(48, 19)
        Me.lbl_cpf_cliente.TabIndex = 35
        Me.lbl_cpf_cliente.Text = "CPF: *"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbx_professor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbx_situacao)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbx_plano)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.num_frequencia)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(351, 131)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(185, 420)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações Práticas"
        '
        'cbx_professor
        '
        Me.cbx_professor.FormattingEnabled = True
        Me.cbx_professor.Location = New System.Drawing.Point(8, 234)
        Me.cbx_professor.Margin = New System.Windows.Forms.Padding(2)
        Me.cbx_professor.Name = "cbx_professor"
        Me.cbx_professor.Size = New System.Drawing.Size(162, 21)
        Me.cbx_professor.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 213)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 19)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Professor: *"
        '
        'cbx_situacao
        '
        Me.cbx_situacao.FormattingEnabled = True
        Me.cbx_situacao.Items.AddRange(New Object() {"REGULAR", "INADIMPLENTE"})
        Me.cbx_situacao.Location = New System.Drawing.Point(8, 175)
        Me.cbx_situacao.Margin = New System.Windows.Forms.Padding(2)
        Me.cbx_situacao.Name = "cbx_situacao"
        Me.cbx_situacao.Size = New System.Drawing.Size(162, 21)
        Me.cbx_situacao.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Situação: *"
        '
        'cbx_plano
        '
        Me.cbx_plano.FormattingEnabled = True
        Me.cbx_plano.Location = New System.Drawing.Point(10, 122)
        Me.cbx_plano.Margin = New System.Windows.Forms.Padding(2)
        Me.cbx_plano.Name = "cbx_plano"
        Me.cbx_plano.Size = New System.Drawing.Size(162, 21)
        Me.cbx_plano.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 19)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Plano: *"
        '
        'num_frequencia
        '
        Me.num_frequencia.Location = New System.Drawing.Point(8, 55)
        Me.num_frequencia.Margin = New System.Windows.Forms.Padding(2)
        Me.num_frequencia.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.num_frequencia.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_frequencia.Name = "num_frequencia"
        Me.num_frequencia.Size = New System.Drawing.Size(164, 20)
        Me.num_frequencia.TabIndex = 60
        Me.num_frequencia.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 19)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Frequência Semanal:"
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_gravar.Location = New System.Drawing.Point(16, 565)
        Me.btn_gravar.Margin = New System.Windows.Forms.Padding(19, 12, 2, 2)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(520, 37)
        Me.btn_gravar.TabIndex = 60
        Me.btn_gravar.Text = "Gravar registro"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(16, 612)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(19, 4, 2, 2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(520, 24)
        Me.btn_cancelar.TabIndex = 61
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 257)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 19)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Idade: *"
        '
        'num_idade
        '
        Me.num_idade.Location = New System.Drawing.Point(17, 278)
        Me.num_idade.Margin = New System.Windows.Forms.Padding(2)
        Me.num_idade.Maximum = New Decimal(New Integer() {122, 0, 0, 0})
        Me.num_idade.Minimum = New Decimal(New Integer() {14, 0, 0, 0})
        Me.num_idade.Name = "num_idade"
        Me.num_idade.Size = New System.Drawing.Size(164, 20)
        Me.num_idade.TabIndex = 69
        Me.num_idade.Value = New Decimal(New Integer() {14, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_cpf_responsavel)
        Me.GroupBox2.Controls.Add(Me.lbl_cpf_responsavel)
        Me.GroupBox2.Controls.Add(Me.txt_patologia)
        Me.GroupBox2.Controls.Add(Me.lbl_restricoes)
        Me.GroupBox2.Controls.Add(Me.txt_restricoes)
        Me.GroupBox2.Controls.Add(Me.lbl_patologia)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 373)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 178)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'txt_cpf_responsavel
        '
        Me.txt_cpf_responsavel.Enabled = False
        Me.txt_cpf_responsavel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_responsavel.Location = New System.Drawing.Point(3, 148)
        Me.txt_cpf_responsavel.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf_responsavel.Mask = "000\.000\.000-00"
        Me.txt_cpf_responsavel.Name = "txt_cpf_responsavel"
        Me.txt_cpf_responsavel.Size = New System.Drawing.Size(314, 26)
        Me.txt_cpf_responsavel.TabIndex = 71
        '
        'lbl_cpf_responsavel
        '
        Me.lbl_cpf_responsavel.AutoSize = True
        Me.lbl_cpf_responsavel.Enabled = False
        Me.lbl_cpf_responsavel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf_responsavel.Location = New System.Drawing.Point(0, 127)
        Me.lbl_cpf_responsavel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cpf_responsavel.Name = "lbl_cpf_responsavel"
        Me.lbl_cpf_responsavel.Size = New System.Drawing.Size(157, 19)
        Me.lbl_cpf_responsavel.TabIndex = 49
        Me.lbl_cpf_responsavel.Text = "CPF do Responsável: *"
        '
        'date_validade_exame
        '
        Me.date_validade_exame.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_validade_exame.Location = New System.Drawing.Point(17, 326)
        Me.date_validade_exame.Name = "date_validade_exame"
        Me.date_validade_exame.Size = New System.Drawing.Size(200, 20)
        Me.date_validade_exame.TabIndex = 71
        '
        'cadastro_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 643)
        Me.Controls.Add(Me.date_validade_exame)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.num_idade)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_cpf_cliente)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.lbl_nome_cliente)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_data_matricula)
        Me.Controls.Add(Me.lbl_telefone)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.lbl_validade_exame)
        Me.Controls.Add(Me.radio_sexo_masc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radio_sexo_fem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cadastro_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cadastro_clientes"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pic_sair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.num_frequencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_idade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pic_sair As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_validade_exame As Label
    Friend WithEvents txt_restricoes As TextBox
    Friend WithEvents lbl_restricoes As Label
    Friend WithEvents txt_patologia As TextBox
    Friend WithEvents lbl_patologia As Label
    Friend WithEvents radio_sexo_fem As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents radio_sexo_masc As RadioButton
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents lbl_telefone As Label
    Friend WithEvents lbl_data_matricula As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_nome_cliente As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents lbl_cpf_cliente As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbx_professor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbx_situacao As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbx_plano As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents num_frequencia As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_gravar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents num_idade As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_cpf_responsavel As Label
    Friend WithEvents txt_cpf_responsavel As MaskedTextBox
    Friend WithEvents date_validade_exame As DateTimePicker
End Class
