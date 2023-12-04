<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class relatorio_clientes
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_filtro_nome = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_ferramentas = New System.Windows.Forms.ToolStrip()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv_relatorio_clientes = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.patologia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.restricoes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exame_validade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ultimo_pagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.professor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf_responsavel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.ts_ferramentas.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv_relatorio_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 38)
        Me.Panel1.TabIndex = 2
        '
        'lbl_title
        '
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(36, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(352, 23)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "HerculesPro | Relatório de Clientes"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel1.Text = "NOME:"
        '
        'txt_filtro_nome
        '
        Me.txt_filtro_nome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_filtro_nome.MaxLength = 60
        Me.txt_filtro_nome.Name = "txt_filtro_nome"
        Me.txt_filtro_nome.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ts_ferramentas
        '
        Me.ts_ferramentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ts_ferramentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_filtro_nome, Me.ToolStripSeparator1})
        Me.ts_ferramentas.Location = New System.Drawing.Point(0, 38)
        Me.ts_ferramentas.Name = "ts_ferramentas"
        Me.ts_ferramentas.Size = New System.Drawing.Size(710, 25)
        Me.ts_ferramentas.TabIndex = 7
        Me.ts_ferramentas.Text = "ToolStrip1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgv_relatorio_clientes, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 63)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(710, 384)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'dgv_relatorio_clientes
        '
        Me.dgv_relatorio_clientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_relatorio_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_relatorio_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome, Me.cpf, Me.telefone, Me.idade, Me.patologia, Me.restricoes, Me.exame_validade, Me.plano, Me.ultimo_pagamento, Me.professor, Me.cpf_responsavel})
        Me.dgv_relatorio_clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_relatorio_clientes.Location = New System.Drawing.Point(3, 3)
        Me.dgv_relatorio_clientes.Name = "dgv_relatorio_clientes"
        Me.dgv_relatorio_clientes.RowHeadersVisible = False
        Me.dgv_relatorio_clientes.Size = New System.Drawing.Size(704, 301)
        Me.dgv_relatorio_clientes.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.codigo.DataPropertyName = "codigo"
        Me.codigo.FillWeight = 20.0!
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        '
        'nome
        '
        Me.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nome.DataPropertyName = "nome"
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        '
        'cpf
        '
        Me.cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cpf.DataPropertyName = "cpf"
        Me.cpf.HeaderText = "CPF"
        Me.cpf.Name = "cpf"
        '
        'telefone
        '
        Me.telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.telefone.DataPropertyName = "telefone"
        Me.telefone.HeaderText = "Telefone"
        Me.telefone.Name = "telefone"
        '
        'idade
        '
        Me.idade.DataPropertyName = "idade"
        Me.idade.HeaderText = "Idade"
        Me.idade.Name = "idade"
        '
        'patologia
        '
        Me.patologia.DataPropertyName = "patologia"
        Me.patologia.HeaderText = "Patologia"
        Me.patologia.Name = "patologia"
        '
        'restricoes
        '
        Me.restricoes.DataPropertyName = "restricoes"
        Me.restricoes.HeaderText = "Restrições"
        Me.restricoes.Name = "restricoes"
        '
        'exame_validade
        '
        Me.exame_validade.DataPropertyName = "exame_validade"
        Me.exame_validade.HeaderText = "Validade do Exame"
        Me.exame_validade.Name = "exame_validade"
        '
        'plano
        '
        Me.plano.DataPropertyName = "nome_plano"
        Me.plano.HeaderText = "Plano"
        Me.plano.Name = "plano"
        '
        'ultimo_pagamento
        '
        Me.ultimo_pagamento.DataPropertyName = "ultimo_pagamento"
        Me.ultimo_pagamento.HeaderText = "Último Pagamento"
        Me.ultimo_pagamento.Name = "ultimo_pagamento"
        '
        'professor
        '
        Me.professor.DataPropertyName = "nome_professor"
        Me.professor.HeaderText = "Professor"
        Me.professor.Name = "professor"
        '
        'cpf_responsavel
        '
        Me.cpf_responsavel.DataPropertyName = "cpf_responsavel"
        Me.cpf_responsavel.HeaderText = "CPF do Responsável"
        Me.cpf_responsavel.Name = "cpf_responsavel"
        '
        'relatorio_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 447)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ts_ferramentas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "relatorio_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RELATÓRIO - Clientes do Estabelecimento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ts_ferramentas.ResumeLayout(False)
        Me.ts_ferramentas.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv_relatorio_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_filtro_nome As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ts_ferramentas As ToolStrip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgv_relatorio_clientes As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents telefone As DataGridViewTextBoxColumn
    Friend WithEvents idade As DataGridViewTextBoxColumn
    Friend WithEvents patologia As DataGridViewTextBoxColumn
    Friend WithEvents restricoes As DataGridViewTextBoxColumn
    Friend WithEvents exame_validade As DataGridViewTextBoxColumn
    Friend WithEvents plano As DataGridViewTextBoxColumn
    Friend WithEvents ultimo_pagamento As DataGridViewTextBoxColumn
    Friend WithEvents professor As DataGridViewTextBoxColumn
    Friend WithEvents cpf_responsavel As DataGridViewTextBoxColumn
End Class
