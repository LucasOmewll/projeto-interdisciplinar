<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro_pagamentos
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
        Me.group_cadastro_planos = New System.Windows.Forms.GroupBox()
        Me.date_pagamento = New System.Windows.Forms.DateTimePicker()
        Me.cbx_professores_pag = New System.Windows.Forms.ComboBox()
        Me.lbl_professores_pag = New System.Windows.Forms.Label()
        Me.lbl_nome_plano = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.group_cadastro_planos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'group_cadastro_planos
        '
        Me.group_cadastro_planos.Controls.Add(Me.date_pagamento)
        Me.group_cadastro_planos.Controls.Add(Me.cbx_professores_pag)
        Me.group_cadastro_planos.Controls.Add(Me.lbl_professores_pag)
        Me.group_cadastro_planos.Controls.Add(Me.lbl_nome_plano)
        Me.group_cadastro_planos.Location = New System.Drawing.Point(12, 40)
        Me.group_cadastro_planos.Name = "group_cadastro_planos"
        Me.group_cadastro_planos.Size = New System.Drawing.Size(370, 186)
        Me.group_cadastro_planos.TabIndex = 73
        Me.group_cadastro_planos.TabStop = False
        Me.group_cadastro_planos.Text = "Por favor, insira as informações do pagamento"
        '
        'date_pagamento
        '
        Me.date_pagamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_pagamento.Location = New System.Drawing.Point(6, 129)
        Me.date_pagamento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.date_pagamento.Name = "date_pagamento"
        Me.date_pagamento.Size = New System.Drawing.Size(327, 20)
        Me.date_pagamento.TabIndex = 68
        Me.date_pagamento.Value = New Date(2023, 11, 27, 0, 0, 0, 0)
        '
        'cbx_professores_pag
        '
        Me.cbx_professores_pag.FormattingEnabled = True
        Me.cbx_professores_pag.Location = New System.Drawing.Point(6, 65)
        Me.cbx_professores_pag.Name = "cbx_professores_pag"
        Me.cbx_professores_pag.Size = New System.Drawing.Size(327, 21)
        Me.cbx_professores_pag.TabIndex = 67
        '
        'lbl_professores_pag
        '
        Me.lbl_professores_pag.AutoSize = True
        Me.lbl_professores_pag.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_professores_pag.Location = New System.Drawing.Point(2, 43)
        Me.lbl_professores_pag.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_professores_pag.Name = "lbl_professores_pag"
        Me.lbl_professores_pag.Size = New System.Drawing.Size(78, 19)
        Me.lbl_professores_pag.TabIndex = 65
        Me.lbl_professores_pag.Text = "Professor:"
        '
        'lbl_nome_plano
        '
        Me.lbl_nome_plano.AutoSize = True
        Me.lbl_nome_plano.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_plano.Location = New System.Drawing.Point(2, 108)
        Me.lbl_nome_plano.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nome_plano.Name = "lbl_nome_plano"
        Me.lbl_nome_plano.Size = New System.Drawing.Size(54, 19)
        Me.lbl_nome_plano.TabIndex = 39
        Me.lbl_nome_plano.Text = "Data: *"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 284)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(19, 4, 2, 2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(370, 24)
        Me.btn_cancelar.TabIndex = 72
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_gravar.Location = New System.Drawing.Point(12, 241)
        Me.btn_gravar.Margin = New System.Windows.Forms.Padding(19, 12, 2, 2)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(370, 37)
        Me.btn_gravar.TabIndex = 70
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
        Me.Panel1.Size = New System.Drawing.Size(394, 38)
        Me.Panel1.TabIndex = 69
        '
        'lbl_title
        '
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(3, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(352, 23)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "HerculesPro | Cadastro de Pagamentos"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cadastro_pagamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 318)
        Me.Controls.Add(Me.group_cadastro_planos)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cadastro_pagamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cadastro_pagamentos"
        Me.group_cadastro_planos.ResumeLayout(False)
        Me.group_cadastro_planos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents group_cadastro_planos As GroupBox
    Friend WithEvents lbl_professores_pag As Label
    Friend WithEvents lbl_nome_plano As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_gravar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents cbx_professores_pag As ComboBox
    Friend WithEvents date_pagamento As DateTimePicker
End Class
