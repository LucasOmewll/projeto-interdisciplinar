<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RoundPictureBox1 = New herculespro.RoundPictureBox()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        CType(Me.RoundPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoundPictureBox1
        '
        resources.ApplyResources(Me.RoundPictureBox1, "RoundPictureBox1")
        Me.RoundPictureBox1.Name = "RoundPictureBox1"
        Me.RoundPictureBox1.TabStop = False
        '
        'lbl_titulo
        '
        resources.ApplyResources(Me.lbl_titulo, "lbl_titulo")
        Me.lbl_titulo.Name = "lbl_titulo"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.AutoEllipsis = True
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        resources.ApplyResources(Me.btn_cadastrar, "btn_cadastrar")
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.AutoEllipsis = True
        Me.btn_sair.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(87, Byte), Integer))
        resources.ApplyResources(Me.btn_sair, "btn_sair")
        Me.btn_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.RoundPictureBox1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        CType(Me.RoundPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RoundPictureBox1 As RoundPictureBox
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents btn_sair As Button
End Class
