<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class relatorio_professores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(relatorio_professores))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.ts_ferramentas = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_filtro_nome = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_filtros = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btn_situacao = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesligadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_sexo = New System.Windows.Forms.ToolStripMenuItem()
        Me.FemininoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasculinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoverFiltrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv_relatorio_professores = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cref = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.ts_ferramentas.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv_relatorio_professores, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 3
        '
        'lbl_title
        '
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(3, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(352, 23)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "HerculesPro | Relatório de Professores"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ts_ferramentas
        '
        Me.ts_ferramentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ts_ferramentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_filtro_nome, Me.ToolStripSeparator1, Me.btn_filtros})
        Me.ts_ferramentas.Location = New System.Drawing.Point(0, 38)
        Me.ts_ferramentas.Name = "ts_ferramentas"
        Me.ts_ferramentas.Size = New System.Drawing.Size(710, 25)
        Me.ts_ferramentas.TabIndex = 4
        Me.ts_ferramentas.Text = "ToolStrip1"
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
        'btn_filtros
        '
        Me.btn_filtros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_filtros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_situacao, Me.btn_sexo, Me.RemoverFiltrosToolStripMenuItem})
        Me.btn_filtros.Image = CType(resources.GetObject("btn_filtros.Image"), System.Drawing.Image)
        Me.btn_filtros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filtros.Margin = New System.Windows.Forms.Padding(0, 1, 60, 2)
        Me.btn_filtros.Name = "btn_filtros"
        Me.btn_filtros.Size = New System.Drawing.Size(29, 22)
        Me.btn_filtros.Text = "ToolStripDropDownButton1"
        Me.btn_filtros.ToolTipText = "Filtrar busca"
        '
        'btn_situacao
        '
        Me.btn_situacao.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtivoToolStripMenuItem, Me.DesligadoToolStripMenuItem})
        Me.btn_situacao.Name = "btn_situacao"
        Me.btn_situacao.Size = New System.Drawing.Size(156, 22)
        Me.btn_situacao.Text = "Situação"
        '
        'AtivoToolStripMenuItem
        '
        Me.AtivoToolStripMenuItem.Name = "AtivoToolStripMenuItem"
        Me.AtivoToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AtivoToolStripMenuItem.Text = "Ativo"
        '
        'DesligadoToolStripMenuItem
        '
        Me.DesligadoToolStripMenuItem.Name = "DesligadoToolStripMenuItem"
        Me.DesligadoToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.DesligadoToolStripMenuItem.Text = "Desligado"
        '
        'btn_sexo
        '
        Me.btn_sexo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FemininoToolStripMenuItem, Me.MasculinoToolStripMenuItem})
        Me.btn_sexo.Name = "btn_sexo"
        Me.btn_sexo.Size = New System.Drawing.Size(156, 22)
        Me.btn_sexo.Text = "Sexo"
        '
        'FemininoToolStripMenuItem
        '
        Me.FemininoToolStripMenuItem.Name = "FemininoToolStripMenuItem"
        Me.FemininoToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.FemininoToolStripMenuItem.Text = "Feminino"
        '
        'MasculinoToolStripMenuItem
        '
        Me.MasculinoToolStripMenuItem.Name = "MasculinoToolStripMenuItem"
        Me.MasculinoToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.MasculinoToolStripMenuItem.Text = "Masculino"
        '
        'RemoverFiltrosToolStripMenuItem
        '
        Me.RemoverFiltrosToolStripMenuItem.Name = "RemoverFiltrosToolStripMenuItem"
        Me.RemoverFiltrosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.RemoverFiltrosToolStripMenuItem.Text = "Remover Filtros"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgv_relatorio_professores, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 63)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(710, 384)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'dgv_relatorio_professores
        '
        Me.dgv_relatorio_professores.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_relatorio_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_relatorio_professores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome, Me.cpf, Me.cref, Me.telefone, Me.cep, Me.sexo, Me.descricao, Me.situacao, Me.salario})
        Me.dgv_relatorio_professores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_relatorio_professores.Location = New System.Drawing.Point(3, 3)
        Me.dgv_relatorio_professores.Name = "dgv_relatorio_professores"
        Me.dgv_relatorio_professores.RowHeadersVisible = False
        Me.dgv_relatorio_professores.Size = New System.Drawing.Size(704, 301)
        Me.dgv_relatorio_professores.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.codigo.DataPropertyName = "codigo"
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
        'cref
        '
        Me.cref.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cref.DataPropertyName = "cref"
        Me.cref.HeaderText = "CREF"
        Me.cref.Name = "cref"
        '
        'telefone
        '
        Me.telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.telefone.DataPropertyName = "telefone"
        Me.telefone.HeaderText = "Telefone"
        Me.telefone.Name = "telefone"
        '
        'cep
        '
        Me.cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cep.DataPropertyName = "cep"
        Me.cep.HeaderText = "CEP"
        Me.cep.Name = "cep"
        '
        'sexo
        '
        Me.sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.sexo.DataPropertyName = "sexo"
        Me.sexo.HeaderText = "Sexo"
        Me.sexo.Name = "sexo"
        '
        'descricao
        '
        Me.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descricao.DataPropertyName = "descricao"
        Me.descricao.HeaderText = "Descrição"
        Me.descricao.Name = "descricao"
        '
        'situacao
        '
        Me.situacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.situacao.DataPropertyName = "situacao"
        Me.situacao.HeaderText = "Situação"
        Me.situacao.Name = "situacao"
        '
        'salario
        '
        Me.salario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.salario.DataPropertyName = "salario"
        Me.salario.HeaderText = "Salário"
        Me.salario.Name = "salario"
        '
        'relatorio_professores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 447)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ts_ferramentas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "relatorio_professores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RELATÓRIO - Professores do Estabelecimento"
        Me.Panel1.ResumeLayout(False)
        Me.ts_ferramentas.ResumeLayout(False)
        Me.ts_ferramentas.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv_relatorio_professores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents ts_ferramentas As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_filtro_nome As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btn_filtros As ToolStripDropDownButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgv_relatorio_professores As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents cref As DataGridViewTextBoxColumn
    Friend WithEvents telefone As DataGridViewTextBoxColumn
    Friend WithEvents cep As DataGridViewTextBoxColumn
    Friend WithEvents sexo As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents situacao As DataGridViewTextBoxColumn
    Friend WithEvents salario As DataGridViewTextBoxColumn
    Friend WithEvents btn_situacao As ToolStripMenuItem
    Friend WithEvents AtivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesligadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_sexo As ToolStripMenuItem
    Friend WithEvents FemininoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasculinoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoverFiltrosToolStripMenuItem As ToolStripMenuItem
End Class
