<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.lbl_cpf = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.lbl_texto = New System.Windows.Forms.Label()
        Me.lbl_recup_senha = New System.Windows.Forms.Label()
        Me.chk_exibir_senha = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_cargos = New System.Windows.Forms.ComboBox()
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
        Me.Panel1.Size = New System.Drawing.Size(584, 38)
        Me.Panel1.TabIndex = 1
        '
        'pic_sair
        '
        Me.pic_sair.Location = New System.Drawing.Point(497, 4)
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
        Me.lbl_title.Text = "HerculesPro | Login"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_cpf
        '
        Me.lbl_cpf.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cpf.Location = New System.Drawing.Point(82, 69)
        Me.lbl_cpf.Margin = New System.Windows.Forms.Padding(25, 10, 3, 2)
        Me.lbl_cpf.Name = "lbl_cpf"
        Me.lbl_cpf.Size = New System.Drawing.Size(150, 25)
        Me.lbl_cpf.TabIndex = 16
        Me.lbl_cpf.Text = "CPF:"
        Me.lbl_cpf.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_cpf
        '
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(82, 100)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.txt_cpf.Mask = "000\.000\.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(418, 18)
        Me.txt_cpf.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(25, 10, 3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Senha: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txt_senha
        '
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(82, 170)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(25, 3, 3, 3)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(418, 18)
        Me.txt_senha.TabIndex = 30
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'btn_entrar
        '
        Me.btn_entrar.Location = New System.Drawing.Point(132, 268)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(25, 15, 3, 3)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(321, 45)
        Me.btn_entrar.TabIndex = 32
        Me.btn_entrar.Text = "ENTRAR"
        Me.btn_entrar.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(132, 321)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(25, 5, 3, 3)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(321, 30)
        Me.btn_sair.TabIndex = 33
        Me.btn_sair.Text = "SAIR"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'lbl_texto
        '
        Me.lbl_texto.AutoSize = True
        Me.lbl_texto.Location = New System.Drawing.Point(187, 368)
        Me.lbl_texto.Name = "lbl_texto"
        Me.lbl_texto.Size = New System.Drawing.Size(131, 13)
        Me.lbl_texto.TabIndex = 34
        Me.lbl_texto.Text = "Esqueceu da sua senha? "
        '
        'lbl_recup_senha
        '
        Me.lbl_recup_senha.AutoSize = True
        Me.lbl_recup_senha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_recup_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_recup_senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_recup_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_recup_senha.Location = New System.Drawing.Point(310, 368)
        Me.lbl_recup_senha.Name = "lbl_recup_senha"
        Me.lbl_recup_senha.Size = New System.Drawing.Size(62, 13)
        Me.lbl_recup_senha.TabIndex = 35
        Me.lbl_recup_senha.Text = "Clique aqui."
        '
        'chk_exibir_senha
        '
        Me.chk_exibir_senha.AutoSize = True
        Me.chk_exibir_senha.Location = New System.Drawing.Point(417, 147)
        Me.chk_exibir_senha.Name = "chk_exibir_senha"
        Me.chk_exibir_senha.Size = New System.Drawing.Size(83, 17)
        Me.chk_exibir_senha.TabIndex = 36
        Me.chk_exibir_senha.Text = "Exibir senha"
        Me.chk_exibir_senha.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 201)
        Me.Label2.Margin = New System.Windows.Forms.Padding(25, 10, 3, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Cargo: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cbx_cargos
        '
        Me.cbx_cargos.FormattingEnabled = True
        Me.cbx_cargos.Items.AddRange(New Object() {"GERENTE", "PROFESSOR"})
        Me.cbx_cargos.Location = New System.Drawing.Point(82, 231)
        Me.cbx_cargos.Name = "cbx_cargos"
        Me.cbx_cargos.Size = New System.Drawing.Size(121, 21)
        Me.cbx_cargos.TabIndex = 38
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 390)
        Me.Controls.Add(Me.cbx_cargos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk_exibir_senha)
        Me.Controls.Add(Me.lbl_recup_senha)
        Me.Controls.Add(Me.lbl_texto)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.lbl_cpf)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.pic_sair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pic_sair As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_cpf As Label
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_entrar As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents lbl_texto As Label
    Friend WithEvents lbl_recup_senha As Label
    Friend WithEvents chk_exibir_senha As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbx_cargos As ComboBox
End Class
