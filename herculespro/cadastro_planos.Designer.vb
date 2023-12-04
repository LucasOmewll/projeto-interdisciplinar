<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastro_planos
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_nome_plano = New System.Windows.Forms.Label()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.btn_excluir = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_planos_disponiveis = New System.Windows.Forms.Label()
        Me.group_cadastro_planos = New System.Windows.Forms.GroupBox()
        Me.lbl_valor_plano = New System.Windows.Forms.Label()
        Me.num_valor_plano = New System.Windows.Forms.NumericUpDown()
        Me.lbl_periodo_plano = New System.Windows.Forms.Label()
        Me.num_periodo_plano = New System.Windows.Forms.NumericUpDown()
        Me.txt_nome_plano = New System.Windows.Forms.TextBox()
        Me.txt_codigo_plano = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.group_cadastro_planos.SuspendLayout()
        CType(Me.num_valor_plano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_periodo_plano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 38)
        Me.Panel1.TabIndex = 3
        '
        'lbl_title
        '
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(3, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(352, 23)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "HerculesPro | Cadastro de Planos"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nome_plano
        '
        Me.lbl_nome_plano.AutoSize = True
        Me.lbl_nome_plano.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_plano.Location = New System.Drawing.Point(2, 108)
        Me.lbl_nome_plano.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nome_plano.Name = "lbl_nome_plano"
        Me.lbl_nome_plano.Size = New System.Drawing.Size(128, 19)
        Me.lbl_nome_plano.TabIndex = 39
        Me.lbl_nome_plano.Text = "Nome do Plano: *"
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_gravar.Location = New System.Drawing.Point(12, 350)
        Me.btn_gravar.Margin = New System.Windows.Forms.Padding(19, 12, 2, 2)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(370, 37)
        Me.btn_gravar.TabIndex = 61
        Me.btn_gravar.Text = "Gravar registro"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'btn_excluir
        '
        Me.btn_excluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excluir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_excluir.Location = New System.Drawing.Point(12, 389)
        Me.btn_excluir.Margin = New System.Windows.Forms.Padding(19, 12, 2, 2)
        Me.btn_excluir.Name = "btn_excluir"
        Me.btn_excluir.Size = New System.Drawing.Size(370, 37)
        Me.btn_excluir.TabIndex = 63
        Me.btn_excluir.Text = "Excluir registro"
        Me.btn_excluir.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 434)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(19, 4, 2, 2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(370, 24)
        Me.btn_cancelar.TabIndex = 64
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'lbl_planos_disponiveis
        '
        Me.lbl_planos_disponiveis.AutoSize = True
        Me.lbl_planos_disponiveis.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_planos_disponiveis.Location = New System.Drawing.Point(2, 43)
        Me.lbl_planos_disponiveis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_planos_disponiveis.Name = "lbl_planos_disponiveis"
        Me.lbl_planos_disponiveis.Size = New System.Drawing.Size(62, 19)
        Me.lbl_planos_disponiveis.TabIndex = 65
        Me.lbl_planos_disponiveis.Text = "Código:"
        '
        'group_cadastro_planos
        '
        Me.group_cadastro_planos.Controls.Add(Me.txt_codigo_plano)
        Me.group_cadastro_planos.Controls.Add(Me.lbl_planos_disponiveis)
        Me.group_cadastro_planos.Controls.Add(Me.lbl_nome_plano)
        Me.group_cadastro_planos.Controls.Add(Me.num_periodo_plano)
        Me.group_cadastro_planos.Controls.Add(Me.txt_nome_plano)
        Me.group_cadastro_planos.Controls.Add(Me.lbl_periodo_plano)
        Me.group_cadastro_planos.Controls.Add(Me.num_valor_plano)
        Me.group_cadastro_planos.Controls.Add(Me.lbl_valor_plano)
        Me.group_cadastro_planos.Location = New System.Drawing.Point(12, 44)
        Me.group_cadastro_planos.Name = "group_cadastro_planos"
        Me.group_cadastro_planos.Size = New System.Drawing.Size(370, 297)
        Me.group_cadastro_planos.TabIndex = 68
        Me.group_cadastro_planos.TabStop = False
        Me.group_cadastro_planos.Text = "Por favor, insira as informações do plano"
        '
        'lbl_valor_plano
        '
        Me.lbl_valor_plano.AutoSize = True
        Me.lbl_valor_plano.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_valor_plano.Location = New System.Drawing.Point(2, 173)
        Me.lbl_valor_plano.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_valor_plano.Name = "lbl_valor_plano"
        Me.lbl_valor_plano.Size = New System.Drawing.Size(59, 19)
        Me.lbl_valor_plano.TabIndex = 42
        Me.lbl_valor_plano.Text = "Valor: *"
        '
        'num_valor_plano
        '
        Me.num_valor_plano.DecimalPlaces = 2
        Me.num_valor_plano.Location = New System.Drawing.Point(6, 202)
        Me.num_valor_plano.Name = "num_valor_plano"
        Me.num_valor_plano.Size = New System.Drawing.Size(326, 20)
        Me.num_valor_plano.TabIndex = 41
        '
        'lbl_periodo_plano
        '
        Me.lbl_periodo_plano.AutoSize = True
        Me.lbl_periodo_plano.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_periodo_plano.Location = New System.Drawing.Point(2, 232)
        Me.lbl_periodo_plano.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_periodo_plano.Name = "lbl_periodo_plano"
        Me.lbl_periodo_plano.Size = New System.Drawing.Size(157, 19)
        Me.lbl_periodo_plano.TabIndex = 43
        Me.lbl_periodo_plano.Text = "Período (em meses): *"
        '
        'num_periodo_plano
        '
        Me.num_periodo_plano.Location = New System.Drawing.Point(6, 261)
        Me.num_periodo_plano.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_periodo_plano.Name = "num_periodo_plano"
        Me.num_periodo_plano.Size = New System.Drawing.Size(326, 20)
        Me.num_periodo_plano.TabIndex = 44
        Me.num_periodo_plano.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txt_nome_plano
        '
        Me.txt_nome_plano.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_plano.Location = New System.Drawing.Point(6, 137)
        Me.txt_nome_plano.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome_plano.MaxLength = 60
        Me.txt_nome_plano.Name = "txt_nome_plano"
        Me.txt_nome_plano.Size = New System.Drawing.Size(327, 26)
        Me.txt_nome_plano.TabIndex = 40
        '
        'txt_codigo_plano
        '
        Me.txt_codigo_plano.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_codigo_plano.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo_plano.Location = New System.Drawing.Point(6, 72)
        Me.txt_codigo_plano.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_codigo_plano.MaxLength = 3
        Me.txt_codigo_plano.Name = "txt_codigo_plano"
        Me.txt_codigo_plano.Size = New System.Drawing.Size(327, 26)
        Me.txt_codigo_plano.TabIndex = 66
        '
        'cadastro_planos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 469)
        Me.Controls.Add(Me.group_cadastro_planos)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_excluir)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cadastro_planos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cadastro_planos"
        Me.Panel1.ResumeLayout(False)
        Me.group_cadastro_planos.ResumeLayout(False)
        Me.group_cadastro_planos.PerformLayout()
        CType(Me.num_valor_plano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_periodo_plano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_nome_plano As Label
    Friend WithEvents btn_gravar As Button
    Friend WithEvents btn_excluir As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents lbl_planos_disponiveis As Label
    Friend WithEvents group_cadastro_planos As GroupBox
    Friend WithEvents txt_codigo_plano As TextBox
    Friend WithEvents num_periodo_plano As NumericUpDown
    Friend WithEvents txt_nome_plano As TextBox
    Friend WithEvents lbl_periodo_plano As Label
    Friend WithEvents num_valor_plano As NumericUpDown
    Friend WithEvents lbl_valor_plano As Label
End Class
