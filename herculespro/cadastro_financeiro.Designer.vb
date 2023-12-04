<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro_financeiro
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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_valor = New System.Windows.Forms.Label()
        Me.num_valor = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.cmb_responsavel = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_tipoTransacao = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_tipoPagamento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_descricao = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.date_pagamento = New System.Windows.Forms.DateTimePicker()
        Me.date_transacao = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.num_valor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(18, 420)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(19, 4, 2, 2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(520, 24)
        Me.btn_cancelar.TabIndex = 63
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_gravar.Location = New System.Drawing.Point(18, 373)
        Me.btn_gravar.Margin = New System.Windows.Forms.Padding(19, 12, 2, 2)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(520, 37)
        Me.btn_gravar.TabIndex = 62
        Me.btn_gravar.Text = "Gravar registro"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 38)
        Me.Panel1.TabIndex = 64
        '
        'lbl_title
        '
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(36, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(352, 23)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "HerculesPro | Lançamentos Financeiros"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_valor
        '
        Me.lbl_valor.AutoSize = True
        Me.lbl_valor.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor.Location = New System.Drawing.Point(14, 53)
        Me.lbl_valor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_valor.Name = "lbl_valor"
        Me.lbl_valor.Size = New System.Drawing.Size(59, 19)
        Me.lbl_valor.TabIndex = 65
        Me.lbl_valor.Text = "Valor: *"
        '
        'num_valor
        '
        Me.num_valor.DecimalPlaces = 2
        Me.num_valor.Increment = New Decimal(New Integer() {50, 0, 0, 131072})
        Me.num_valor.Location = New System.Drawing.Point(18, 75)
        Me.num_valor.Name = "num_valor"
        Me.num_valor.Size = New System.Drawing.Size(158, 20)
        Me.num_valor.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 175)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Categoria: *"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(18, 197)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(158, 21)
        Me.cmb_categoria.TabIndex = 68
        '
        'cmb_responsavel
        '
        Me.cmb_responsavel.FormattingEnabled = True
        Me.cmb_responsavel.Location = New System.Drawing.Point(214, 74)
        Me.cmb_responsavel.Name = "cmb_responsavel"
        Me.cmb_responsavel.Size = New System.Drawing.Size(121, 21)
        Me.cmb_responsavel.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(210, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 19)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Responsável"
        '
        'cmb_tipoTransacao
        '
        Me.cmb_tipoTransacao.FormattingEnabled = True
        Me.cmb_tipoTransacao.Location = New System.Drawing.Point(18, 151)
        Me.cmb_tipoTransacao.Name = "cmb_tipoTransacao"
        Me.cmb_tipoTransacao.Size = New System.Drawing.Size(158, 21)
        Me.cmb_tipoTransacao.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(14, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 19)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Tipo Transação"
        '
        'cmb_tipoPagamento
        '
        Me.cmb_tipoPagamento.FormattingEnabled = True
        Me.cmb_tipoPagamento.Location = New System.Drawing.Point(358, 74)
        Me.cmb_tipoPagamento.Name = "cmb_tipoPagamento"
        Me.cmb_tipoPagamento.Size = New System.Drawing.Size(158, 21)
        Me.cmb_tipoPagamento.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(354, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 19)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Tipo de Pagamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(210, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Descrição"
        '
        'txt_descricao
        '
        Me.txt_descricao.Location = New System.Drawing.Point(214, 152)
        Me.txt_descricao.Multiline = True
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(302, 66)
        Me.txt_descricao.TabIndex = 69
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.date_pagamento)
        Me.Panel2.Controls.Add(Me.date_transacao)
        Me.Panel2.Location = New System.Drawing.Point(32, 243)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(484, 115)
        Me.Panel2.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Data Pagamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Data Transação"
        '
        'date_pagamento
        '
        Me.date_pagamento.Location = New System.Drawing.Point(135, 68)
        Me.date_pagamento.Name = "date_pagamento"
        Me.date_pagamento.Size = New System.Drawing.Size(332, 20)
        Me.date_pagamento.TabIndex = 1
        '
        'date_transacao
        '
        Me.date_transacao.Location = New System.Drawing.Point(135, 24)
        Me.date_transacao.Name = "date_transacao"
        Me.date_transacao.Size = New System.Drawing.Size(332, 20)
        Me.date_transacao.TabIndex = 0
        '
        'cadastro_financeiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 466)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmb_responsavel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_tipoTransacao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_tipoPagamento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.cmb_categoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.num_valor)
        Me.Controls.Add(Me.lbl_valor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_gravar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cadastro_financeiro"
        Me.Text = "cadastro_financeiro"
        Me.Panel1.ResumeLayout(False)
        CType(Me.num_valor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_gravar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_valor As Label
    Friend WithEvents num_valor As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents cmb_responsavel As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_tipoTransacao As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_tipoPagamento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_descricao As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents date_pagamento As DateTimePicker
    Friend WithEvents date_transacao As DateTimePicker
End Class
