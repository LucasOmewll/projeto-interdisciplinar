Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class cadastro_clientes
    Structure professor
        Public codigo As Integer
        Public nome As String
    End Structure
    Structure plano
        Public codigo As Integer
        Public nome As String
        Public valor As Decimal
    End Structure

    Public professores() As professor
    Public planos() As plano

    Dim cpf As String
    Dim nome As String
    Dim sexo As Char
    Dim telefone As String
    Dim idade As Integer
    Dim validade_exame As String
    Dim frequencia_semanal As Integer
    Dim plano_assinatura As Integer
    Dim professor_supervisor As Integer
    Dim situacao As Integer
    Dim patologia As String
    Dim restricoes As String
    Dim cpf_responsavel As String

    Private Sub cadastro_clientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        operacional.Close()

        popular_cbx_professor()

        popular_cbx_plano()

        verificar_validade_exame()
    End Sub
    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Dim sql As String
        Dim cmd As MySqlCommand

        Try
            If num_idade.Value < 18 And txt_cpf_responsavel.MaskCompleted = False Then
                Throw New System.Exception("Por favor, forneça o CPF do responsável legal do menor de idade.")
            Else
                If verificar_preenchimento() = False Then
                    Throw New System.Exception("Por favor, preencha todos os campos obrigatórios")
                Else
                    cpf = txt_cpf.Text
                    nome = UCase(txt_nome.Text)
                    'sexo definido no momento em que o usuário clica o radio button
                    telefone = txt_telefone.Text
                    idade = num_idade.Value
                    validade_exame = Format(date_validade_exame.Value, "yyyy-MM-dd")
                    plano_assinatura = planos(cbx_plano.SelectedIndex).codigo
                    frequencia_semanal = num_frequencia.Value
                    professor_supervisor = professores(cbx_professor.SelectedIndex).codigo
                    'situação definida no momento em que o usuário seleciona uma opção na combo box
                    patologia = UCase(txt_patologia.Text)
                    restricoes = UCase(txt_restricoes.Text)

                    If num_idade.Value < 18 Then
                        cpf_responsavel = txt_cpf_responsavel.Text
                    Else
                        cpf_responsavel = Nothing
                    End If

                    Dim codigo As Integer = buscar_codigo(cpf)
                    'ABRINDO CONEXÃO COM O BANCO
                    Call abrir_conexao_banco()

                    'Variáveis do SQL
                    If codigo = 0 Then

                        sql = "INSERT INTO tb_clientes (cpf, nome, telefone, sexo, idade, patologia, restricoes, examevalidade, frequencia, plano, situacao, professor, cpf_responsavel)
                        VALUES (@cpf, @nome, @telefone, @sexo, @idade, @patologia, @restricoes, @exame, @frequencia, @plano, @situacao, @professor, @cpf_responsavel)"
                    Else
                        sql = "UPDATE tb_clientes 
                                SET nome = @nome, telefone = @telefone, sexo = @sexo, idade = @idade, patologia = @patologia, restricoes = @restricoes, examevalidade = @exame, frequencia = @frequencia, plano = @plano, situacao = @situacao, professor = @professor, cpf_responsavel = @cpf_responsavel
                                WHERE codigo = @codigo"
                    End If
                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", cpf)
                    cmd.Parameters.AddWithValue("@nome", nome)
                    cmd.Parameters.AddWithValue("@telefone", telefone)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@idade", idade)
                    cmd.Parameters.AddWithValue("@patologia", patologia)
                    cmd.Parameters.AddWithValue("@restricoes", restricoes)
                    cmd.Parameters.AddWithValue("@exame", validade_exame)
                    cmd.Parameters.AddWithValue("@frequencia", frequencia_semanal)
                    cmd.Parameters.AddWithValue("@plano", plano_assinatura)
                    cmd.Parameters.AddWithValue("@situacao", situacao)
                    cmd.Parameters.AddWithValue("@professor", professor_supervisor)
                    cmd.Parameters.AddWithValue("@cpf_responsavel", cpf_responsavel)
                    cmd.Parameters.AddWithValue("@codigo", codigo)

                    cmd.ExecuteNonQuery()

                    resp = MsgBox("Cadastro de cliente realizado com sucesso!" + vbNewLine + "Gostaria de realizar outro cadastro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                    If resp = vbYes Then
                        Call limpar_form()
                        'FECHANDO CONEXÃO COM O BANCO
                        Call fechar_conexao_banco()
                        Exit Sub
                    Else
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub radio_sexo_fem_CheckedChanged(sender As Object, e As EventArgs) Handles radio_sexo_fem.CheckedChanged
        Try
            radio_sexo_masc.Checked = Not radio_sexo_fem.Checked
            sexo = "F"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub radio_sexo_masc_CheckedChanged(sender As Object, e As EventArgs) Handles radio_sexo_masc.CheckedChanged
        Try
            radio_sexo_fem.Checked = Not radio_sexo_masc.Checked
            sexo = "M"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub popular_cbx_professor()
        'Obtendo o número de professores registrados
        Dim index As Integer
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim num_professores As Object
        Dim resultado As Object

        Try
            Call abrir_conexao_banco()

            sql = "SELECT COUNT(tb_professores.codigo) FROM tb_professores WHERE tb_professores.situacao = 3"
            cmd = New MySqlCommand(sql, conn)

            num_professores = cmd.ExecuteScalar

            If num_professores = 0 Then
                Throw New System.Exception("Não há professores disponíveis.")
            Else
                ReDim professores(num_professores - 1) 'Definindo o tamanho do array professores

                sql = "SELECT tb_professores.codigo, tb_professores.nome FROM tb_professores WHERE tb_professores.situacao = 3"

                cmd = New MySqlCommand(sql, conn)

                resultado = cmd.ExecuteReader

                index = 0
                'Com a lista de código e nomes dos professores obtida, estes valores serão adicionados ao array professores,
                'do tipo "professor" criado no início desta classe
                While resultado.read
                    professores(index).codigo = resultado(0)
                    professores(index).nome = resultado(1).ToString
                    index = index + 1
                End While

                Call fechar_conexao_banco()

                'Adicionando os valores do array professores na combo box cbx_professores
                For i As Integer = 0 To (professores.Length - 1)
                    With cbx_professor.Items
                        .Add(professores(i).nome)
                    End With
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub popular_cbx_plano()
        'Obtendo o número de planos registrados
        Dim index As Integer
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim num_planos As Object
        Dim resultado As Object


        Try
            Call abrir_conexao_banco()

            sql = "SELECT COUNT(codigo) FROM tb_planos"
            cmd = New MySqlCommand(sql, conn)

            num_planos = cmd.ExecuteScalar()

            If num_planos = 0 Then
                Throw New System.Exception("Não há planos disponíveis.")
            Else
                ReDim planos(num_planos - 1) 'Definindo o tamanho do array planos

                sql = "SELECT tb_planos.codigo, tb_planos.nome, tb_planos.valor FROM tb_planos"
                cmd = New MySqlCommand(sql, conn)

                resultado = cmd.ExecuteReader

                index = 0
                While resultado.read
                    planos(index).codigo = resultado(0)
                    planos(index).nome = resultado(1).ToString
                    planos(index).valor = resultado(2)
                    index = index + 1
                End While

                'Adicionando os valores do array planos na combo box cbx_plano
                For i As Integer = 0 To (planos.Length - 1)
                    With cbx_plano.Items
                        .Add(planos(i).nome)
                    End With
                Next
            End If

            Call fechar_conexao_banco()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub cbx_plano_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbx_plano.SelectionChangeCommitted
        resp = MsgBox("Confirmar plano?" + vbNewLine + "Plano: " & planos(cbx_plano.SelectedIndex).nome + vbNewLine + "Valor: R$" & planos(cbx_plano.SelectedIndex).valor, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
        If resp = vbNo Then
            cbx_plano.SelectedIndex = -1
        End If

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cadastro_clientes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        operacional.Show()
    End Sub

    Private Sub num_idade_LostFocus(sender As Object, e As EventArgs) Handles num_idade.LostFocus
        verificar_idade()
    End Sub

    Private Sub num_idade_GotFocus(sender As Object, e As EventArgs) Handles num_idade.GotFocus
        verificar_idade()
    End Sub

    Private Sub num_idade_ValueChanged(sender As Object, e As EventArgs) Handles num_idade.ValueChanged
        verificar_idade()
    End Sub

    Private Sub cbx_situacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_situacao.SelectedIndexChanged
        Select Case cbx_situacao.SelectedIndex
            Case 0
                situacao = 1 '1 -> 'REGULAR'
            Case 1
                situacao = 2 '2 -> 'INADIMPLENTE'
        End Select
    End Sub

    Private Sub verificar_idade()
        If num_frequencia.Value < 18 Then
            lbl_cpf_responsavel.Enabled = True
            txt_cpf_responsavel.Enabled = True

        Else
            lbl_cpf_responsavel.Enabled = False
            txt_cpf_responsavel.Enabled = False

        End If
    End Sub

    Private Function verificar_preenchimento()
        Dim campos_preenchidos As Boolean = True

        If txt_cpf.MaskCompleted = False Or String.IsNullOrEmpty(txt_nome.Text) = True Or txt_telefone.MaskCompleted = False Or date_validade_exame.Value = Today Or cbx_plano.SelectedIndex = -1 Or cbx_situacao.SelectedIndex = -1 Or cbx_professor.SelectedIndex = -1 Then
            campos_preenchidos = False
        End If

        If radio_sexo_fem.Checked = False And radio_sexo_masc.Checked = False Then
            campos_preenchidos = False
        End If

        Return campos_preenchidos
    End Function

    Private Function buscar_codigo(cpf As String)
        'ABRINDO CONEXÃO COM O BANCO
        Call abrir_conexao_banco()

        Dim sql As String = "SELECT codigo FROM tb_clientes WHERE cpf = @cpf"
        Dim cmd As New MySqlCommand(sql, conn)
        Dim resultado As Object
        Dim codigo As Integer

        cmd.Parameters.AddWithValue("@cpf", cpf)


        resultado = cmd.ExecuteScalar

        If resultado Is Nothing Then
            codigo = 0
        Else
            codigo = resultado
        End If
        'FECHANDO CONEXÃO COM O BANCO
        Call fechar_conexao_banco()

        Return codigo
    End Function

    Private Sub limpar_form()
        txt_cpf.Clear()
        txt_nome.Clear()
        txt_patologia.Clear()
        txt_restricoes.Clear()
        txt_telefone.Clear()
        num_frequencia.Value = 1
        cbx_plano.SelectedIndex = -1
        cbx_professor.SelectedIndex = -1
        cbx_situacao.SelectedIndex = -1
    End Sub

    Private Sub popular_form(cpf As String)
        Try
            Dim sql As String
            Dim cmd As MySqlCommand
            Dim codigo As Object
            Dim resultado As Object

            Call abrir_conexao_banco()

            sql = "SELECT codigo FROM tb_clientes WHERE cpf = @cpf"
            cmd = New MySqlCommand(sql, conn)



            cmd.Parameters.AddWithValue("@cpf", cpf)

            codigo = cmd.ExecuteScalar

            If codigo Is Nothing Then
                Call fechar_conexao_banco()
                Exit Sub
            Else
                sql = "SELECT nome, telefone, sexo, idade, patologia, restricoes, examevalidade, frequencia, plano, situacao, professor, cpf_responsavel
                                FROM tb_clientes
                                WHERE codigo = @codigo"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@codigo", codigo)

                resultado = cmd.ExecuteReader

                While resultado.read()
                    txt_nome.Text = resultado(0).ToString
                    txt_telefone.Text = resultado(1).ToString

                    If resultado(2).ToString = "F" Then
                        radio_sexo_fem.Checked = True
                    Else
                        radio_sexo_masc.Checked = True
                    End If

                    num_idade.Value = resultado(3)
                    txt_patologia.Text = resultado(4).ToString
                    txt_restricoes.Text = resultado(5).ToString
                    date_validade_exame.Value = resultado(6)
                    num_frequencia.Value = resultado(7)
                    cbx_plano.SelectedIndex = resultado(8) - 1

                    If resultado(9) = 1 Then
                        cbx_situacao.SelectedIndex = 0
                    Else
                        cbx_situacao.SelectedIndex = 1
                    End If

                    cbx_professor.SelectedIndex = resultado(10) - 1

                    If resultado(11) Is Nothing Then
                        txt_cpf_responsavel.Text = ""
                    Else
                        txt_cpf_responsavel.Text = resultado(11).ToString
                    End If

                End While
            End If
            Call fechar_conexao_banco()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        If txt_cpf.MaskCompleted = True Then
            Call popular_form(txt_cpf.Text)
        End If
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        Call limpar_form()
    End Sub

    Private Sub verificar_validade_exame()
        date_validade_exame.MinDate = Date.Today
    End Sub

End Class