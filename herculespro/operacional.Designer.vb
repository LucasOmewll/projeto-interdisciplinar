<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class operacional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(operacional))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea13 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend13 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series13 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea14 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend14 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series14 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pic_sair = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_clientes = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.assinatura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ultimo_pagamento_clientes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.group_pesquisa_cliente = New System.Windows.Forms.GroupBox()
        Me.txt_telefone = New System.Windows.Forms.TextBox()
        Me.txt_validade_exame = New System.Windows.Forms.TextBox()
        Me.lbl_telefone = New System.Windows.Forms.Label()
        Me.btn_pesquisa_rapida = New System.Windows.Forms.Button()
        Me.txt_situacao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_validade_exame = New System.Windows.Forms.Label()
        Me.txt_restricoes = New System.Windows.Forms.TextBox()
        Me.lbl_restricoes = New System.Windows.Forms.Label()
        Me.txt_patologia = New System.Windows.Forms.TextBox()
        Me.lbl_patologia = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_nome_cliente = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_cpf_cliente = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_gerenciar_clientes = New System.Windows.Forms.Button()
        Me.btn_pagamentos_clientes = New System.Windows.Forms.Button()
        Me.btn_exibir_clientes = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_contagem_clientes = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_treinos = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_alterarTreino = New System.Windows.Forms.Button()
        Me.cmb_tipoTreinoAlterar = New System.Windows.Forms.ComboBox()
        Me.cmb_professorAlterar = New System.Windows.Forms.ComboBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_adicionarTreino = New System.Windows.Forms.Button()
        Me.cmb_tipoTreinoAdicionar = New System.Windows.Forms.ComboBox()
        Me.cmb_professor = New System.Windows.Forms.ComboBox()
        Me.btn_pesquisar = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lbl_profResponsavel = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_tipoTreino = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tab_gerencial = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgv_professores = New System.Windows.Forms.DataGridView()
        Me.nome_professor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salario_professor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_pagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbx_pesquisa_professores = New System.Windows.Forms.GroupBox()
        Me.txt_cont_alunos_supervisionados = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cref_professores = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telefone_professores = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_busca_rapida_professores = New System.Windows.Forms.Button()
        Me.txt_situacao_professores = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_nome_professores = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cpf_professores = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_contagem_professores = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_gerenciar_funcionarios = New System.Windows.Forms.Button()
        Me.btn_gerenciar_planos = New System.Windows.Forms.Button()
        Me.btn_registrar_pagamento = New System.Windows.Forms.Button()
        Me.btn_relatorio = New System.Windows.Forms.Button()
        Me.tab_financeiro = New System.Windows.Forms.TabPage()
        Me.btn_adicionar_lancamento = New System.Windows.Forms.Button()
        Me.char_despesas = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.char_dif = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_despesas = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbl_vendas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btn_lancamento = New System.Windows.Forms.Panel()
        Me.lbl_faturamento = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txt_cpfAluno = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpfAdicionar = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpfAlterar = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_sair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tab_clientes.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_pesquisa_cliente.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_treinos.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.tab_gerencial.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_professores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_pesquisa_professores.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.tab_financeiro.SuspendLayout()
        CType(Me.char_despesas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.char_dif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn_lancamento.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(848, 38)
        Me.Panel1.TabIndex = 2
        '
        'pic_sair
        '
        Me.pic_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_sair.Image = CType(resources.GetObject("pic_sair.Image"), System.Drawing.Image)
        Me.pic_sair.Location = New System.Drawing.Point(796, 3)
        Me.pic_sair.Name = "pic_sair"
        Me.pic_sair.Size = New System.Drawing.Size(40, 32)
        Me.pic_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_sair.TabIndex = 1
        Me.pic_sair.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(3, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(352, 23)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "HerculesPro | Menu Operacional"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_clientes)
        Me.TabControl1.Controls.Add(Me.tab_treinos)
        Me.TabControl1.Controls.Add(Me.tab_gerencial)
        Me.TabControl1.Controls.Add(Me.tab_financeiro)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 38)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(848, 602)
        Me.TabControl1.TabIndex = 3
        '
        'tab_clientes
        '
        Me.tab_clientes.BackColor = System.Drawing.Color.Transparent
        Me.tab_clientes.Controls.Add(Me.Panel5)
        Me.tab_clientes.Controls.Add(Me.group_pesquisa_cliente)
        Me.tab_clientes.Controls.Add(Me.FlowLayoutPanel1)
        Me.tab_clientes.Controls.Add(Me.Panel2)
        Me.tab_clientes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_clientes.Location = New System.Drawing.Point(4, 30)
        Me.tab_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_clientes.Name = "tab_clientes"
        Me.tab_clientes.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_clientes.Size = New System.Drawing.Size(840, 568)
        Me.tab_clientes.TabIndex = 0
        Me.tab_clientes.Text = "CLIENTES"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgv_clientes)
        Me.Panel5.Location = New System.Drawing.Point(151, 134)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(383, 412)
        Me.Panel5.TabIndex = 6
        '
        'dgv_clientes
        '
        Me.dgv_clientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome, Me.cpf_cliente, Me.assinatura, Me.ultimo_pagamento_clientes})
        Me.dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_clientes.Location = New System.Drawing.Point(0, 0)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.RowHeadersVisible = False
        Me.dgv_clientes.Size = New System.Drawing.Size(383, 412)
        Me.dgv_clientes.TabIndex = 0
        '
        'nome
        '
        Me.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nome.DataPropertyName = "nome"
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        '
        'cpf_cliente
        '
        Me.cpf_cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cpf_cliente.DataPropertyName = "cpf"
        Me.cpf_cliente.HeaderText = "CPF"
        Me.cpf_cliente.Name = "cpf_cliente"
        '
        'assinatura
        '
        Me.assinatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.assinatura.DataPropertyName = "assinatura"
        Me.assinatura.HeaderText = "Assinatura"
        Me.assinatura.Name = "assinatura"
        '
        'ultimo_pagamento_clientes
        '
        Me.ultimo_pagamento_clientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ultimo_pagamento_clientes.DataPropertyName = "ultimo_pgto"
        Me.ultimo_pagamento_clientes.HeaderText = "Último Pagamento"
        Me.ultimo_pagamento_clientes.Name = "ultimo_pagamento_clientes"
        '
        'group_pesquisa_cliente
        '
        Me.group_pesquisa_cliente.Controls.Add(Me.txt_telefone)
        Me.group_pesquisa_cliente.Controls.Add(Me.txt_validade_exame)
        Me.group_pesquisa_cliente.Controls.Add(Me.lbl_telefone)
        Me.group_pesquisa_cliente.Controls.Add(Me.btn_pesquisa_rapida)
        Me.group_pesquisa_cliente.Controls.Add(Me.txt_situacao)
        Me.group_pesquisa_cliente.Controls.Add(Me.Label3)
        Me.group_pesquisa_cliente.Controls.Add(Me.lbl_validade_exame)
        Me.group_pesquisa_cliente.Controls.Add(Me.txt_restricoes)
        Me.group_pesquisa_cliente.Controls.Add(Me.lbl_restricoes)
        Me.group_pesquisa_cliente.Controls.Add(Me.txt_patologia)
        Me.group_pesquisa_cliente.Controls.Add(Me.lbl_patologia)
        Me.group_pesquisa_cliente.Controls.Add(Me.txt_nome)
        Me.group_pesquisa_cliente.Controls.Add(Me.lbl_nome_cliente)
        Me.group_pesquisa_cliente.Controls.Add(Me.txt_cpf)
        Me.group_pesquisa_cliente.Controls.Add(Me.lbl_cpf_cliente)
        Me.group_pesquisa_cliente.Location = New System.Drawing.Point(550, 5)
        Me.group_pesquisa_cliente.Margin = New System.Windows.Forms.Padding(2)
        Me.group_pesquisa_cliente.Name = "group_pesquisa_cliente"
        Me.group_pesquisa_cliente.Padding = New System.Windows.Forms.Padding(2)
        Me.group_pesquisa_cliente.Size = New System.Drawing.Size(275, 541)
        Me.group_pesquisa_cliente.TabIndex = 5
        Me.group_pesquisa_cliente.TabStop = False
        Me.group_pesquisa_cliente.Text = "Pesquisa Rápida"
        '
        'txt_telefone
        '
        Me.txt_telefone.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(16, 177)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.ReadOnly = True
        Me.txt_telefone.Size = New System.Drawing.Size(239, 26)
        Me.txt_telefone.TabIndex = 19
        '
        'txt_validade_exame
        '
        Me.txt_validade_exame.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_validade_exame.Location = New System.Drawing.Point(16, 367)
        Me.txt_validade_exame.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_validade_exame.Name = "txt_validade_exame"
        Me.txt_validade_exame.ReadOnly = True
        Me.txt_validade_exame.Size = New System.Drawing.Size(239, 26)
        Me.txt_validade_exame.TabIndex = 17
        '
        'lbl_telefone
        '
        Me.lbl_telefone.AutoSize = True
        Me.lbl_telefone.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefone.Location = New System.Drawing.Point(14, 151)
        Me.lbl_telefone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_telefone.Name = "lbl_telefone"
        Me.lbl_telefone.Size = New System.Drawing.Size(70, 19)
        Me.lbl_telefone.TabIndex = 15
        Me.lbl_telefone.Text = "Telefone:"
        '
        'btn_pesquisa_rapida
        '
        Me.btn_pesquisa_rapida.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pesquisa_rapida.Location = New System.Drawing.Point(186, 57)
        Me.btn_pesquisa_rapida.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pesquisa_rapida.Name = "btn_pesquisa_rapida"
        Me.btn_pesquisa_rapida.Size = New System.Drawing.Size(69, 28)
        Me.btn_pesquisa_rapida.TabIndex = 14
        Me.btn_pesquisa_rapida.Text = "Buscar"
        Me.btn_pesquisa_rapida.UseVisualStyleBackColor = True
        '
        'txt_situacao
        '
        Me.txt_situacao.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_situacao.Location = New System.Drawing.Point(16, 426)
        Me.txt_situacao.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_situacao.Name = "txt_situacao"
        Me.txt_situacao.ReadOnly = True
        Me.txt_situacao.Size = New System.Drawing.Size(239, 26)
        Me.txt_situacao.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 400)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Situação:"
        '
        'lbl_validade_exame
        '
        Me.lbl_validade_exame.AutoSize = True
        Me.lbl_validade_exame.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_validade_exame.Location = New System.Drawing.Point(14, 341)
        Me.lbl_validade_exame.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_validade_exame.Name = "lbl_validade_exame"
        Me.lbl_validade_exame.Size = New System.Drawing.Size(141, 19)
        Me.lbl_validade_exame.TabIndex = 8
        Me.lbl_validade_exame.Text = "Validade do Exame:"
        '
        'txt_restricoes
        '
        Me.txt_restricoes.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_restricoes.Location = New System.Drawing.Point(16, 308)
        Me.txt_restricoes.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_restricoes.Name = "txt_restricoes"
        Me.txt_restricoes.ReadOnly = True
        Me.txt_restricoes.Size = New System.Drawing.Size(239, 26)
        Me.txt_restricoes.TabIndex = 7
        '
        'lbl_restricoes
        '
        Me.lbl_restricoes.AutoSize = True
        Me.lbl_restricoes.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_restricoes.Location = New System.Drawing.Point(14, 282)
        Me.lbl_restricoes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_restricoes.Name = "lbl_restricoes"
        Me.lbl_restricoes.Size = New System.Drawing.Size(81, 19)
        Me.lbl_restricoes.TabIndex = 6
        Me.lbl_restricoes.Text = "Restrições:"
        '
        'txt_patologia
        '
        Me.txt_patologia.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_patologia.Location = New System.Drawing.Point(16, 236)
        Me.txt_patologia.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_patologia.Multiline = True
        Me.txt_patologia.Name = "txt_patologia"
        Me.txt_patologia.ReadOnly = True
        Me.txt_patologia.Size = New System.Drawing.Size(239, 39)
        Me.txt_patologia.TabIndex = 5
        '
        'lbl_patologia
        '
        Me.lbl_patologia.AutoSize = True
        Me.lbl_patologia.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_patologia.Location = New System.Drawing.Point(14, 210)
        Me.lbl_patologia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_patologia.Name = "lbl_patologia"
        Me.lbl_patologia.Size = New System.Drawing.Size(78, 19)
        Me.lbl_patologia.TabIndex = 4
        Me.lbl_patologia.Text = "Patologia:"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(16, 118)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.ReadOnly = True
        Me.txt_nome.Size = New System.Drawing.Size(239, 26)
        Me.txt_nome.TabIndex = 3
        '
        'lbl_nome_cliente
        '
        Me.lbl_nome_cliente.AutoSize = True
        Me.lbl_nome_cliente.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_cliente.Location = New System.Drawing.Point(14, 92)
        Me.lbl_nome_cliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nome_cliente.Name = "lbl_nome_cliente"
        Me.lbl_nome_cliente.Size = New System.Drawing.Size(54, 19)
        Me.lbl_nome_cliente.TabIndex = 2
        Me.lbl_nome_cliente.Text = "Nome:"
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(16, 59)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf.Mask = "000\.000\.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(166, 26)
        Me.txt_cpf.TabIndex = 1
        '
        'lbl_cpf_cliente
        '
        Me.lbl_cpf_cliente.AutoSize = True
        Me.lbl_cpf_cliente.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf_cliente.Location = New System.Drawing.Point(14, 33)
        Me.lbl_cpf_cliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cpf_cliente.Name = "lbl_cpf_cliente"
        Me.lbl_cpf_cliente.Size = New System.Drawing.Size(38, 19)
        Me.lbl_cpf_cliente.TabIndex = 0
        Me.lbl_cpf_cliente.Text = "CPF:"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_gerenciar_clientes)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_pagamentos_clientes)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_exibir_clientes)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(144, 564)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'btn_gerenciar_clientes
        '
        Me.btn_gerenciar_clientes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_gerenciar_clientes.Location = New System.Drawing.Point(2, 2)
        Me.btn_gerenciar_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gerenciar_clientes.Name = "btn_gerenciar_clientes"
        Me.btn_gerenciar_clientes.Size = New System.Drawing.Size(142, 57)
        Me.btn_gerenciar_clientes.TabIndex = 0
        Me.btn_gerenciar_clientes.Text = "Gerenciar Clientes"
        Me.btn_gerenciar_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gerenciar_clientes.UseVisualStyleBackColor = True
        '
        'btn_pagamentos_clientes
        '
        Me.btn_pagamentos_clientes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_pagamentos_clientes.Location = New System.Drawing.Point(2, 63)
        Me.btn_pagamentos_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pagamentos_clientes.Name = "btn_pagamentos_clientes"
        Me.btn_pagamentos_clientes.Size = New System.Drawing.Size(142, 57)
        Me.btn_pagamentos_clientes.TabIndex = 2
        Me.btn_pagamentos_clientes.Text = "Cadastrar Pagamentos"
        Me.btn_pagamentos_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pagamentos_clientes.UseVisualStyleBackColor = True
        '
        'btn_exibir_clientes
        '
        Me.btn_exibir_clientes.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_exibir_clientes.Location = New System.Drawing.Point(2, 124)
        Me.btn_exibir_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_exibir_clientes.Name = "btn_exibir_clientes"
        Me.btn_exibir_clientes.Size = New System.Drawing.Size(142, 57)
        Me.btn_exibir_clientes.TabIndex = 1
        Me.btn_exibir_clientes.Text = "Relatórios"
        Me.btn_exibir_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exibir_clientes.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_contagem_clientes)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(151, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(383, 118)
        Me.Panel2.TabIndex = 3
        '
        'lbl_contagem_clientes
        '
        Me.lbl_contagem_clientes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contagem_clientes.Location = New System.Drawing.Point(70, 24)
        Me.lbl_contagem_clientes.Name = "lbl_contagem_clientes"
        Me.lbl_contagem_clientes.Size = New System.Drawing.Size(227, 64)
        Me.lbl_contagem_clientes.TabIndex = 5
        Me.lbl_contagem_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Clientes Ativos:"
        '
        'tab_treinos
        '
        Me.tab_treinos.Controls.Add(Me.txt_cpfAluno)
        Me.tab_treinos.Controls.Add(Me.Panel8)
        Me.tab_treinos.Controls.Add(Me.Panel9)
        Me.tab_treinos.Controls.Add(Me.btn_pesquisar)
        Me.tab_treinos.Controls.Add(Me.Panel10)
        Me.tab_treinos.Controls.Add(Me.Label21)
        Me.tab_treinos.Location = New System.Drawing.Point(4, 30)
        Me.tab_treinos.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_treinos.Name = "tab_treinos"
        Me.tab_treinos.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_treinos.Size = New System.Drawing.Size(840, 568)
        Me.tab_treinos.TabIndex = 1
        Me.tab_treinos.Text = "TREINOS"
        Me.tab_treinos.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Gray
        Me.Panel8.Controls.Add(Me.txt_cpfAlterar)
        Me.Panel8.Controls.Add(Me.Label16)
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Controls.Add(Me.Label18)
        Me.Panel8.Controls.Add(Me.btn_alterarTreino)
        Me.Panel8.Controls.Add(Me.cmb_tipoTreinoAlterar)
        Me.Panel8.Controls.Add(Me.cmb_professorAlterar)
        Me.Panel8.Location = New System.Drawing.Point(569, 27)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(208, 335)
        Me.Panel8.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(28, 177)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 21)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Tipo de Treino"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 95)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 21)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Professor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(28, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 21)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "CPF Aluno"
        '
        'btn_alterarTreino
        '
        Me.btn_alterarTreino.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alterarTreino.Location = New System.Drawing.Point(28, 271)
        Me.btn_alterarTreino.Name = "btn_alterarTreino"
        Me.btn_alterarTreino.Size = New System.Drawing.Size(154, 42)
        Me.btn_alterarTreino.TabIndex = 11
        Me.btn_alterarTreino.Text = "Alterar Treino"
        Me.btn_alterarTreino.UseVisualStyleBackColor = True
        '
        'cmb_tipoTreinoAlterar
        '
        Me.cmb_tipoTreinoAlterar.FormattingEnabled = True
        Me.cmb_tipoTreinoAlterar.Location = New System.Drawing.Point(21, 201)
        Me.cmb_tipoTreinoAlterar.Name = "cmb_tipoTreinoAlterar"
        Me.cmb_tipoTreinoAlterar.Size = New System.Drawing.Size(166, 29)
        Me.cmb_tipoTreinoAlterar.TabIndex = 4
        '
        'cmb_professorAlterar
        '
        Me.cmb_professorAlterar.FormattingEnabled = True
        Me.cmb_professorAlterar.Location = New System.Drawing.Point(21, 119)
        Me.cmb_professorAlterar.Name = "cmb_professorAlterar"
        Me.cmb_professorAlterar.Size = New System.Drawing.Size(166, 29)
        Me.cmb_professorAlterar.TabIndex = 3
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Gray
        Me.Panel9.Controls.Add(Me.txt_cpfAdicionar)
        Me.Panel9.Controls.Add(Me.Label15)
        Me.Panel9.Controls.Add(Me.Label13)
        Me.Panel9.Controls.Add(Me.Label14)
        Me.Panel9.Controls.Add(Me.btn_adicionarTreino)
        Me.Panel9.Controls.Add(Me.cmb_tipoTreinoAdicionar)
        Me.Panel9.Controls.Add(Me.cmb_professor)
        Me.Panel9.Location = New System.Drawing.Point(326, 27)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(208, 335)
        Me.Panel9.TabIndex = 19
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 177)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 21)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Tipo de Treino"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 21)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Professor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 21)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "CPF Aluno"
        '
        'btn_adicionarTreino
        '
        Me.btn_adicionarTreino.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adicionarTreino.Location = New System.Drawing.Point(27, 271)
        Me.btn_adicionarTreino.Name = "btn_adicionarTreino"
        Me.btn_adicionarTreino.Size = New System.Drawing.Size(154, 42)
        Me.btn_adicionarTreino.TabIndex = 11
        Me.btn_adicionarTreino.Text = "Adicionar Treino"
        Me.btn_adicionarTreino.UseVisualStyleBackColor = True
        '
        'cmb_tipoTreinoAdicionar
        '
        Me.cmb_tipoTreinoAdicionar.FormattingEnabled = True
        Me.cmb_tipoTreinoAdicionar.Location = New System.Drawing.Point(21, 201)
        Me.cmb_tipoTreinoAdicionar.Name = "cmb_tipoTreinoAdicionar"
        Me.cmb_tipoTreinoAdicionar.Size = New System.Drawing.Size(166, 29)
        Me.cmb_tipoTreinoAdicionar.TabIndex = 4
        '
        'cmb_professor
        '
        Me.cmb_professor.FormattingEnabled = True
        Me.cmb_professor.Location = New System.Drawing.Point(21, 119)
        Me.cmb_professor.Name = "cmb_professor"
        Me.cmb_professor.Size = New System.Drawing.Size(166, 29)
        Me.cmb_professor.TabIndex = 3
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.Image = CType(resources.GetObject("btn_pesquisar.Image"), System.Drawing.Image)
        Me.btn_pesquisar.Location = New System.Drawing.Point(51, 27)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(61, 58)
        Me.btn_pesquisar.TabIndex = 18
        Me.btn_pesquisar.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Gray
        Me.Panel10.Controls.Add(Me.lbl_profResponsavel)
        Me.Panel10.Controls.Add(Me.Label19)
        Me.Panel10.Controls.Add(Me.lbl_tipoTreino)
        Me.Panel10.Controls.Add(Me.Label20)
        Me.Panel10.Location = New System.Drawing.Point(51, 126)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(237, 236)
        Me.Panel10.TabIndex = 16
        '
        'lbl_profResponsavel
        '
        Me.lbl_profResponsavel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profResponsavel.Location = New System.Drawing.Point(0, 177)
        Me.lbl_profResponsavel.Name = "lbl_profResponsavel"
        Me.lbl_profResponsavel.Size = New System.Drawing.Size(234, 25)
        Me.lbl_profResponsavel.TabIndex = 5
        Me.lbl_profResponsavel.Text = "####"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(63, 128)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 30)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Professor"
        '
        'lbl_tipoTreino
        '
        Me.lbl_tipoTreino.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipoTreino.Location = New System.Drawing.Point(3, 78)
        Me.lbl_tipoTreino.Name = "lbl_tipoTreino"
        Me.lbl_tipoTreino.Size = New System.Drawing.Size(231, 25)
        Me.lbl_tipoTreino.TabIndex = 7
        Me.lbl_tipoTreino.Text = "####"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(38, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(161, 30)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Tipo de Treino"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(118, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 21)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "CPF Aluno"
        '
        'tab_gerencial
        '
        Me.tab_gerencial.Controls.Add(Me.Panel4)
        Me.tab_gerencial.Controls.Add(Me.gbx_pesquisa_professores)
        Me.tab_gerencial.Controls.Add(Me.Panel3)
        Me.tab_gerencial.Controls.Add(Me.FlowLayoutPanel2)
        Me.tab_gerencial.Location = New System.Drawing.Point(4, 30)
        Me.tab_gerencial.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_gerencial.Name = "tab_gerencial"
        Me.tab_gerencial.Size = New System.Drawing.Size(840, 568)
        Me.tab_gerencial.TabIndex = 2
        Me.tab_gerencial.Text = "GERENCIAL"
        Me.tab_gerencial.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgv_professores)
        Me.Panel4.Location = New System.Drawing.Point(153, 142)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(381, 404)
        Me.Panel4.TabIndex = 8
        '
        'dgv_professores
        '
        Me.dgv_professores.AllowUserToAddRows = False
        Me.dgv_professores.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_professores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_professores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome_professor, Me.cpf, Me.salario_professor, Me.data_pagamento})
        Me.dgv_professores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_professores.Location = New System.Drawing.Point(0, 0)
        Me.dgv_professores.Name = "dgv_professores"
        Me.dgv_professores.RowHeadersVisible = False
        Me.dgv_professores.Size = New System.Drawing.Size(381, 404)
        Me.dgv_professores.TabIndex = 1
        '
        'nome_professor
        '
        Me.nome_professor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nome_professor.DataPropertyName = "nome"
        Me.nome_professor.HeaderText = "Nome"
        Me.nome_professor.Name = "nome_professor"
        '
        'cpf
        '
        Me.cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cpf.DataPropertyName = "cpf"
        Me.cpf.HeaderText = "CPF"
        Me.cpf.Name = "cpf"
        '
        'salario_professor
        '
        Me.salario_professor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.salario_professor.DataPropertyName = "salario"
        Me.salario_professor.HeaderText = "Salário"
        Me.salario_professor.Name = "salario_professor"
        '
        'data_pagamento
        '
        Me.data_pagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.data_pagamento.DataPropertyName = "ultimo_pgto"
        Me.data_pagamento.HeaderText = "Último Pgto."
        Me.data_pagamento.Name = "data_pagamento"
        '
        'gbx_pesquisa_professores
        '
        Me.gbx_pesquisa_professores.Controls.Add(Me.txt_cont_alunos_supervisionados)
        Me.gbx_pesquisa_professores.Controls.Add(Me.Label8)
        Me.gbx_pesquisa_professores.Controls.Add(Me.txt_cref_professores)
        Me.gbx_pesquisa_professores.Controls.Add(Me.txt_telefone_professores)
        Me.gbx_pesquisa_professores.Controls.Add(Me.Label2)
        Me.gbx_pesquisa_professores.Controls.Add(Me.btn_busca_rapida_professores)
        Me.gbx_pesquisa_professores.Controls.Add(Me.txt_situacao_professores)
        Me.gbx_pesquisa_professores.Controls.Add(Me.Label5)
        Me.gbx_pesquisa_professores.Controls.Add(Me.Label9)
        Me.gbx_pesquisa_professores.Controls.Add(Me.txt_nome_professores)
        Me.gbx_pesquisa_professores.Controls.Add(Me.Label10)
        Me.gbx_pesquisa_professores.Controls.Add(Me.txt_cpf_professores)
        Me.gbx_pesquisa_professores.Controls.Add(Me.Label11)
        Me.gbx_pesquisa_professores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbx_pesquisa_professores.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbx_pesquisa_professores.Location = New System.Drawing.Point(550, 5)
        Me.gbx_pesquisa_professores.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx_pesquisa_professores.Name = "gbx_pesquisa_professores"
        Me.gbx_pesquisa_professores.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx_pesquisa_professores.Size = New System.Drawing.Size(275, 541)
        Me.gbx_pesquisa_professores.TabIndex = 7
        Me.gbx_pesquisa_professores.TabStop = False
        Me.gbx_pesquisa_professores.Text = "Pesquisa Rápida"
        '
        'txt_cont_alunos_supervisionados
        '
        Me.txt_cont_alunos_supervisionados.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cont_alunos_supervisionados.Location = New System.Drawing.Point(14, 365)
        Me.txt_cont_alunos_supervisionados.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cont_alunos_supervisionados.Name = "txt_cont_alunos_supervisionados"
        Me.txt_cont_alunos_supervisionados.ReadOnly = True
        Me.txt_cont_alunos_supervisionados.Size = New System.Drawing.Size(239, 26)
        Me.txt_cont_alunos_supervisionados.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 338)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(245, 19)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Número de alunos supervisionados"
        '
        'txt_cref_professores
        '
        Me.txt_cref_professores.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cref_professores.Location = New System.Drawing.Point(14, 182)
        Me.txt_cref_professores.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cref_professores.Mask = "000000-CC/C"
        Me.txt_cref_professores.Name = "txt_cref_professores"
        Me.txt_cref_professores.ReadOnly = True
        Me.txt_cref_professores.Size = New System.Drawing.Size(239, 26)
        Me.txt_cref_professores.TabIndex = 17
        Me.txt_cref_professores.ValidatingType = GetType(Date)
        '
        'txt_telefone_professores
        '
        Me.txt_telefone_professores.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone_professores.Location = New System.Drawing.Point(14, 243)
        Me.txt_telefone_professores.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_telefone_professores.Mask = "(00) 00000-0000"
        Me.txt_telefone_professores.Name = "txt_telefone_professores"
        Me.txt_telefone_professores.ReadOnly = True
        Me.txt_telefone_professores.Size = New System.Drawing.Size(239, 26)
        Me.txt_telefone_professores.TabIndex = 16
        Me.txt_telefone_professores.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 216)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Telefone:"
        '
        'btn_busca_rapida_professores
        '
        Me.btn_busca_rapida_professores.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_busca_rapida_professores.Location = New System.Drawing.Point(184, 59)
        Me.btn_busca_rapida_professores.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_busca_rapida_professores.Name = "btn_busca_rapida_professores"
        Me.btn_busca_rapida_professores.Size = New System.Drawing.Size(69, 26)
        Me.btn_busca_rapida_professores.TabIndex = 14
        Me.btn_busca_rapida_professores.Text = "Buscar"
        Me.btn_busca_rapida_professores.UseVisualStyleBackColor = True
        '
        'txt_situacao_professores
        '
        Me.txt_situacao_professores.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_situacao_professores.Location = New System.Drawing.Point(14, 304)
        Me.txt_situacao_professores.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_situacao_professores.Name = "txt_situacao_professores"
        Me.txt_situacao_professores.ReadOnly = True
        Me.txt_situacao_professores.Size = New System.Drawing.Size(239, 26)
        Me.txt_situacao_professores.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 277)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Situação:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 155)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Cref:"
        '
        'txt_nome_professores
        '
        Me.txt_nome_professores.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_professores.Location = New System.Drawing.Point(14, 121)
        Me.txt_nome_professores.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome_professores.Name = "txt_nome_professores"
        Me.txt_nome_professores.ReadOnly = True
        Me.txt_nome_professores.Size = New System.Drawing.Size(239, 26)
        Me.txt_nome_professores.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 94)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 19)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Nome:"
        '
        'txt_cpf_professores
        '
        Me.txt_cpf_professores.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf_professores.Location = New System.Drawing.Point(14, 60)
        Me.txt_cpf_professores.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf_professores.Mask = "000\.000\.000-00"
        Me.txt_cpf_professores.Name = "txt_cpf_professores"
        Me.txt_cpf_professores.Size = New System.Drawing.Size(166, 26)
        Me.txt_cpf_professores.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 33)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 19)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "CPF:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbl_contagem_professores)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(149, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(385, 118)
        Me.Panel3.TabIndex = 6
        '
        'lbl_contagem_professores
        '
        Me.lbl_contagem_professores.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contagem_professores.Location = New System.Drawing.Point(70, 27)
        Me.lbl_contagem_professores.Name = "lbl_contagem_professores"
        Me.lbl_contagem_professores.Size = New System.Drawing.Size(227, 64)
        Me.lbl_contagem_professores.TabIndex = 5
        Me.lbl_contagem_professores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(385, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Professores Ativos:"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_gerenciar_funcionarios)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_gerenciar_planos)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_registrar_pagamento)
        Me.FlowLayoutPanel2.Controls.Add(Me.btn_relatorio)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(144, 568)
        Me.FlowLayoutPanel2.TabIndex = 5
        '
        'btn_gerenciar_funcionarios
        '
        Me.btn_gerenciar_funcionarios.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerenciar_funcionarios.Location = New System.Drawing.Point(2, 2)
        Me.btn_gerenciar_funcionarios.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gerenciar_funcionarios.Name = "btn_gerenciar_funcionarios"
        Me.btn_gerenciar_funcionarios.Size = New System.Drawing.Size(142, 57)
        Me.btn_gerenciar_funcionarios.TabIndex = 0
        Me.btn_gerenciar_funcionarios.Text = "Gerenciar Professores"
        Me.btn_gerenciar_funcionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gerenciar_funcionarios.UseVisualStyleBackColor = True
        '
        'btn_gerenciar_planos
        '
        Me.btn_gerenciar_planos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_gerenciar_planos.Location = New System.Drawing.Point(2, 63)
        Me.btn_gerenciar_planos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_gerenciar_planos.Name = "btn_gerenciar_planos"
        Me.btn_gerenciar_planos.Size = New System.Drawing.Size(142, 57)
        Me.btn_gerenciar_planos.TabIndex = 2
        Me.btn_gerenciar_planos.Text = "Gerenciar Planos"
        Me.btn_gerenciar_planos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gerenciar_planos.UseVisualStyleBackColor = True
        '
        'btn_registrar_pagamento
        '
        Me.btn_registrar_pagamento.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_registrar_pagamento.Location = New System.Drawing.Point(2, 124)
        Me.btn_registrar_pagamento.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_registrar_pagamento.Name = "btn_registrar_pagamento"
        Me.btn_registrar_pagamento.Size = New System.Drawing.Size(142, 57)
        Me.btn_registrar_pagamento.TabIndex = 3
        Me.btn_registrar_pagamento.Text = "Registrar Pagamento"
        Me.btn_registrar_pagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_registrar_pagamento.UseVisualStyleBackColor = True
        '
        'btn_relatorio
        '
        Me.btn_relatorio.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_relatorio.Location = New System.Drawing.Point(2, 185)
        Me.btn_relatorio.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_relatorio.Name = "btn_relatorio"
        Me.btn_relatorio.Size = New System.Drawing.Size(142, 57)
        Me.btn_relatorio.TabIndex = 4
        Me.btn_relatorio.Text = "Relatório"
        Me.btn_relatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_relatorio.UseVisualStyleBackColor = True
        '
        'tab_financeiro
        '
        Me.tab_financeiro.Controls.Add(Me.btn_adicionar_lancamento)
        Me.tab_financeiro.Controls.Add(Me.char_despesas)
        Me.tab_financeiro.Controls.Add(Me.char_dif)
        Me.tab_financeiro.Controls.Add(Me.Panel6)
        Me.tab_financeiro.Controls.Add(Me.Panel7)
        Me.tab_financeiro.Controls.Add(Me.btn_lancamento)
        Me.tab_financeiro.Location = New System.Drawing.Point(4, 30)
        Me.tab_financeiro.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_financeiro.Name = "tab_financeiro"
        Me.tab_financeiro.Size = New System.Drawing.Size(840, 568)
        Me.tab_financeiro.TabIndex = 3
        Me.tab_financeiro.Text = "FINANCEIRO"
        Me.tab_financeiro.UseVisualStyleBackColor = True
        '
        'btn_adicionar_lancamento
        '
        Me.btn_adicionar_lancamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_adicionar_lancamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_adicionar_lancamento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_adicionar_lancamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_adicionar_lancamento.Location = New System.Drawing.Point(422, 385)
        Me.btn_adicionar_lancamento.Name = "btn_adicionar_lancamento"
        Me.btn_adicionar_lancamento.Size = New System.Drawing.Size(410, 60)
        Me.btn_adicionar_lancamento.TabIndex = 23
        Me.btn_adicionar_lancamento.Text = "Adicionar Lançamento"
        Me.btn_adicionar_lancamento.UseVisualStyleBackColor = False
        '
        'char_despesas
        '
        ChartArea13.Name = "ChartArea1"
        Me.char_despesas.ChartAreas.Add(ChartArea13)
        Legend13.Name = "Legend1"
        Me.char_despesas.Legends.Add(Legend13)
        Me.char_despesas.Location = New System.Drawing.Point(8, 236)
        Me.char_despesas.Name = "char_despesas"
        Series13.ChartArea = "ChartArea1"
        Series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series13.Legend = "Legend1"
        Series13.Name = "Series1"
        Me.char_despesas.Series.Add(Series13)
        Me.char_despesas.Size = New System.Drawing.Size(389, 209)
        Me.char_despesas.TabIndex = 22
        Me.char_despesas.Text = "Chart3"
        '
        'char_dif
        '
        ChartArea14.Name = "ChartArea1"
        Me.char_dif.ChartAreas.Add(ChartArea14)
        Legend14.Name = "Legend1"
        Me.char_dif.Legends.Add(Legend14)
        Me.char_dif.Location = New System.Drawing.Point(8, 27)
        Me.char_dif.Name = "char_dif"
        Series14.ChartArea = "ChartArea1"
        Series14.Legend = "Legend1"
        Series14.Name = "Series1"
        Me.char_dif.Series.Add(Series14)
        Me.char_dif.Size = New System.Drawing.Size(389, 203)
        Me.char_dif.TabIndex = 21
        Me.char_dif.Text = "Chart2"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.Controls.Add(Me.lbl_despesas)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel6.Location = New System.Drawing.Point(422, 215)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(195, 119)
        Me.Panel6.TabIndex = 18
        '
        'lbl_despesas
        '
        Me.lbl_despesas.AutoSize = True
        Me.lbl_despesas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_despesas.ForeColor = System.Drawing.Color.Tomato
        Me.lbl_despesas.Location = New System.Drawing.Point(53, 60)
        Me.lbl_despesas.Name = "lbl_despesas"
        Me.lbl_despesas.Size = New System.Drawing.Size(58, 24)
        Me.lbl_despesas.TabIndex = 2
        Me.lbl_despesas.Text = "####"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(12, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Despesas"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(7, 45)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 58)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel7.Controls.Add(Me.lbl_vendas)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Controls.Add(Me.PictureBox5)
        Me.Panel7.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel7.Location = New System.Drawing.Point(637, 215)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(195, 119)
        Me.Panel7.TabIndex = 20
        '
        'lbl_vendas
        '
        Me.lbl_vendas.AutoSize = True
        Me.lbl_vendas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vendas.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_vendas.Location = New System.Drawing.Point(55, 60)
        Me.lbl_vendas.Name = "lbl_vendas"
        Me.lbl_vendas.Size = New System.Drawing.Size(58, 24)
        Me.lbl_vendas.TabIndex = 2
        Me.lbl_vendas.Text = "####"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(27, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 24)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Vendas"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(7, 60)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(42, 34)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'btn_lancamento
        '
        Me.btn_lancamento.BackColor = System.Drawing.Color.LightGray
        Me.btn_lancamento.Controls.Add(Me.lbl_faturamento)
        Me.btn_lancamento.Controls.Add(Me.Label12)
        Me.btn_lancamento.Controls.Add(Me.PictureBox4)
        Me.btn_lancamento.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_lancamento.Location = New System.Drawing.Point(422, 27)
        Me.btn_lancamento.Name = "btn_lancamento"
        Me.btn_lancamento.Size = New System.Drawing.Size(410, 182)
        Me.btn_lancamento.TabIndex = 19
        '
        'lbl_faturamento
        '
        Me.lbl_faturamento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_faturamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.lbl_faturamento.Location = New System.Drawing.Point(84, 85)
        Me.lbl_faturamento.Name = "lbl_faturamento"
        Me.lbl_faturamento.Size = New System.Drawing.Size(310, 38)
        Me.lbl_faturamento.TabIndex = 2
        Me.lbl_faturamento.Text = "####"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(3, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 24)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Faturamento"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(7, 47)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(71, 114)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'txt_cpfAluno
        '
        Me.txt_cpfAluno.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpfAluno.Location = New System.Drawing.Point(122, 55)
        Me.txt_cpfAluno.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpfAluno.Mask = "000\.000\.000-00"
        Me.txt_cpfAluno.Name = "txt_cpfAluno"
        Me.txt_cpfAluno.Size = New System.Drawing.Size(166, 26)
        Me.txt_cpfAluno.TabIndex = 21
        '
        'txt_cpfAdicionar
        '
        Me.txt_cpfAdicionar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpfAdicionar.Location = New System.Drawing.Point(21, 53)
        Me.txt_cpfAdicionar.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpfAdicionar.Mask = "000\.000\.000-00"
        Me.txt_cpfAdicionar.Name = "txt_cpfAdicionar"
        Me.txt_cpfAdicionar.Size = New System.Drawing.Size(166, 26)
        Me.txt_cpfAdicionar.TabIndex = 22
        '
        'txt_cpfAlterar
        '
        Me.txt_cpfAlterar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpfAlterar.Location = New System.Drawing.Point(21, 53)
        Me.txt_cpfAlterar.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpfAlterar.Mask = "000\.000\.000-00"
        Me.txt_cpfAlterar.Name = "txt_cpfAlterar"
        Me.txt_cpfAlterar.Size = New System.Drawing.Size(166, 26)
        Me.txt_cpfAlterar.TabIndex = 23
        '
        'operacional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 640)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "operacional"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "operacional"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pic_sair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_clientes.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_pesquisa_cliente.ResumeLayout(False)
        Me.group_pesquisa_cliente.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_treinos.ResumeLayout(False)
        Me.tab_treinos.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.tab_gerencial.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgv_professores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_pesquisa_professores.ResumeLayout(False)
        Me.gbx_pesquisa_professores.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.tab_financeiro.ResumeLayout(False)
        CType(Me.char_despesas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.char_dif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn_lancamento.ResumeLayout(False)
        Me.btn_lancamento.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_clientes As TabPage
    Friend WithEvents tab_treinos As TabPage
    Friend WithEvents tab_gerencial As TabPage
    Friend WithEvents tab_financeiro As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_contagem_clientes As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btn_gerenciar_clientes As Button
    Friend WithEvents btn_exibir_clientes As Button
    Friend WithEvents group_pesquisa_cliente As GroupBox
    Friend WithEvents lbl_cpf_cliente As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents lbl_nome_cliente As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_patologia As Label
    Friend WithEvents lbl_restricoes As Label
    Friend WithEvents txt_patologia As TextBox
    Friend WithEvents txt_restricoes As TextBox
    Friend WithEvents lbl_validade_exame As Label
    Friend WithEvents txt_situacao As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_pesquisa_rapida As Button
    Friend WithEvents lbl_telefone As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_contagem_professores As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btn_gerenciar_funcionarios As Button
    Friend WithEvents gbx_pesquisa_professores As GroupBox
    Friend WithEvents txt_telefone_professores As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_busca_rapida_professores As Button
    Friend WithEvents txt_situacao_professores As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_nome_professores As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_cpf_professores As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_cref_professores As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cont_alunos_supervisionados As TextBox
    Friend WithEvents btn_gerenciar_planos As Button
    Friend WithEvents txt_validade_exame As TextBox
    Friend WithEvents txt_telefone As TextBox
    Friend WithEvents btn_registrar_pagamento As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgv_professores As DataGridView
    Friend WithEvents nome_professor As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents salario_professor As DataGridViewTextBoxColumn
    Friend WithEvents data_pagamento As DataGridViewTextBoxColumn
    Friend WithEvents btn_relatorio As Button
    Friend WithEvents btn_pagamentos_clientes As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents cpf_cliente As DataGridViewTextBoxColumn
    Friend WithEvents assinatura As DataGridViewTextBoxColumn
    Friend WithEvents ultimo_pagamento_clientes As DataGridViewTextBoxColumn
    Friend WithEvents btn_adicionar_lancamento As Button
    Friend WithEvents char_despesas As DataVisualization.Charting.Chart
    Friend WithEvents char_dif As DataVisualization.Charting.Chart
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_despesas As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lbl_vendas As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btn_lancamento As Panel
    Friend WithEvents lbl_faturamento As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents pic_sair As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btn_alterarTreino As Button
    Friend WithEvents cmb_tipoTreinoAlterar As ComboBox
    Friend WithEvents cmb_professorAlterar As ComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_adicionarTreino As Button
    Friend WithEvents cmb_tipoTreinoAdicionar As ComboBox
    Friend WithEvents cmb_professor As ComboBox
    Friend WithEvents btn_pesquisar As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lbl_profResponsavel As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_tipoTreino As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_cpfAluno As MaskedTextBox
    Friend WithEvents txt_cpfAdicionar As MaskedTextBox
    Friend WithEvents txt_cpfAlterar As MaskedTextBox
End Class
