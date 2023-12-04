Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class cadastro_professores
    Dim sexo As Char
    Dim situacao As Integer


    Private Sub limpar_form()
        Try
            txt_cpf.Clear()
            txt_nome.Clear()
            txt_cref.Clear()
            txt_cep.Clear()
            txt_telefone.Clear()
            radio_sexo_fem.Checked = False
            radio_sexo_masc.Checked = False
            num_salario.Value = 0.00
            txt_senha.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Private Sub cadastro_professores_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            operacional.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub chk_exibir_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_exibir_senha.CheckedChanged
        Try
            txt_senha.UseSystemPasswordChar = Not chk_exibir_senha.Checked
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    'DEFININDO OPÇÃO DE SEXO
    '============================================================
    Private Sub radio_sexo_fem_CheckedChanged(sender As Object, e As EventArgs) Handles radio_sexo_fem.CheckedChanged
        Try
            radio_sexo_masc.Checked = Not radio_sexo_fem.Checked

            sexo = "F"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub radio_sexo_masc_CheckedChanged(sender As Object, e As EventArgs) Handles radio_sexo_masc.CheckedChanged
        Try
            radio_sexo_fem.Checked = Not radio_sexo_masc.Checked

            sexo = "M"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    '============================================================


    'DEFININDO SITUAÇÃO
    '============================================================
    Private Sub cbx_situacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_situacao.SelectedIndexChanged
        Try
            Select Case cbx_situacao.SelectedIndex
                Case 0
                    situacao = 3 '3 é o valor do código da situação "ATIVO" na tabela tb_situacoes do banco de dados
                Case 1
                    If txt_cpf.MaskCompleted = True Then

                        'Verificando se o professor possui algum aluno supervisionado
                        If buscar_alunos_supervisionados() > 0 Then
                            cbx_situacao.SelectedIndex = 0
                            Throw New System.Exception("Este professor ainda possui alunos supervisionados." + vbNewLine + "Atribua estes alunos a outro professor antes de realizar a exclusão lógica.")
                        Else
                            situacao = 4 '4 é o valor do código da situação "DESLIGADO" na tabela tb_situacoes do banco de dados
                        End If
                    Else
                        situacao = 4 '4 é o valor do código da situação "DESLIGADO" na tabela tb_situacoes do banco de dados
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    '============================================================

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            'Verificando se o usuário preencheu todos os campos
            If txt_cpf.MaskCompleted = False Or
               String.IsNullOrEmpty(txt_nome.Text) = True Or
               txt_cref.MaskCompleted = False Or
               txt_cep.MaskCompleted = False Or
               txt_telefone.MaskCompleted = False Or
               num_salario.Value = 0.00 Or
               cbx_situacao.SelectedIndex = -1 Or
               String.IsNullOrEmpty(txt_senha.Text) Or
               (radio_sexo_fem.Checked = False And radio_sexo_masc.Checked = False) Then

                Throw New System.Exception("Por favor, preencha todos os campos e selecione uma opção de sexo.")
            Else
                'Variáveis 
                Dim cpf As String
                Dim senha_hashed As String
                Dim sql As String
                Dim cmd As MySqlCommand
                Dim resultado_01 As Object
                Dim resultado_02 As Object

                cpf = txt_cpf.Text
                senha_hashed = calcular_SHA512(txt_senha.Text)

                Call abrir_conexao_banco()

                sql = "SELECT codigo FROM tb_professores WHERE cpf = @cpf"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@cpf", cpf)

                resultado_01 = cmd.ExecuteScalar()

                If resultado_01 Is Nothing Then
                    'Cadastrando novo registro 
                    sql = "INSERT INTO tb_professores (cpf, cref, nome, telefone, cep, sexo, cargo, situacao, salario, senha) VALUES (@cpf, @cref, @nome, @telefone, @cep, @sexo, @cargo, @situacao, @salario, @senha)"
                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", cpf)
                    cmd.Parameters.AddWithValue("@cref", UCase(txt_cref.Text))
                    cmd.Parameters.AddWithValue("@nome", UCase(txt_nome.Text))
                    cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text)
                    cmd.Parameters.AddWithValue("@cep", txt_cep.Text)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@cargo", 2)
                    cmd.Parameters.AddWithValue("@situacao", situacao)
                    cmd.Parameters.AddWithValue("@salario", num_salario.Value)
                    cmd.Parameters.AddWithValue("@senha", senha_hashed)

                    'Executando a query
                    cmd.ExecuteScalar()

                    Call fechar_conexao_banco()

                    'Verificando se o usuário gostaria de realizar outra operação
                    resp = MsgBox("Professor cadastrado com sucesso!" + vbNewLine + "Gostaria de realizar outro cadastro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)


                    If resp = vbYes Then
                        Call limpar_form()
                    Else
                        Me.Close()
                        operacional.Show()
                    End If
                Else
                    'Atualizando dados de registro já presente dentro do banco de dados
                    sql = "UPDATE tb_professores SET cref = @cref, nome = @nome, telefone = @telefone, cep = @cep, sexo = @sexo, cargo = @cargo, situacao = @situacao, salario = @salario, senha = @senha WHERE codigo = @codigo"
                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cref", UCase(txt_cref.Text))
                    cmd.Parameters.AddWithValue("@nome", UCase(txt_nome.Text))
                    cmd.Parameters.AddWithValue("@telefone", txt_telefone.Text)
                    cmd.Parameters.AddWithValue("@cep", txt_cep.Text)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@cargo", 2)
                    cmd.Parameters.AddWithValue("@situacao", situacao)
                    cmd.Parameters.AddWithValue("@salario", num_salario.Value)
                    cmd.Parameters.AddWithValue("@senha", senha_hashed)
                    cmd.Parameters.AddWithValue("@codigo", resultado_01)


                    'Executando a query
                    resultado_02 = cmd.ExecuteNonQuery()

                    Call fechar_conexao_banco()

                    If resultado_02 > 0 Then
                        MsgBox("Dados atualizados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                        Call limpar_form()
                    End If

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Call fechar_conexao_banco()
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        Try
            Call limpar_form()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            If txt_cpf.MaskCompleted = True Then
                Dim cpf As String
                Dim sql As String
                Dim cmd As MySqlCommand
                Dim resultado As Object


                cpf = txt_cpf.Text

                Call abrir_conexao_banco()


                sql = "SELECT tb_professores.cref, tb_professores.nome, tb_professores.telefone, tb_professores.cep, tb_professores.sexo, tb_professores.situacao, tb_professores.salario
                    FROM tb_professores
                    WHERE tb_professores.cpf = @cpf"

                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@cpf", cpf)

                resultado = cmd.ExecuteReader

                If resultado IsNot Nothing Then
                    While resultado.read()
                        txt_cref.Text = resultado(0)
                        txt_nome.Text = resultado(1)
                        txt_telefone.Text = resultado(2)
                        txt_cep.Text = resultado(3)

                        'Verificando o sexo registrado no banco de dados
                        If resultado(4) = "F" Then
                            radio_sexo_fem.Checked = True
                        Else
                            radio_sexo_masc.Checked = True
                        End If

                        'Verificando a situação registrada no bando de dados
                        'Valores: 3 -> "ATIVO" | 4 -> "DESLIGADO"
                        If resultado(5) = 3 Then
                            cbx_situacao.SelectedIndex = 0
                        Else
                            cbx_situacao.SelectedIndex = 1
                        End If

                        num_salario.Value = resultado(6)
                    End While
                End If

                txt_nome.Focus()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Call fechar_conexao_banco()
        End Try
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            If txt_cpf.MaskCompleted = False Then
                Throw New System.Exception("Por favor, informe um CPF para deletar o registro")
            Else
                'Verficando se um pagamento já foi realizado a este usuário
                If buscar_pagamentos() = True Then
                    Throw New System.Exception("Exclusão física do registro negada: Informações referentes a este registro constam em 'Pagamentos'" + vbNewLine + "Recomendação: Realizar exclusão lógica alterando a situação para 'DESLIGADO'")
                Else
                    'Verificando se o usuário realmente deseja excluir o registro
                    resp = MsgBox("Gostaria de excluir este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")

                    If resp = vbNo Then
                        Exit Sub
                    Else
                        'Variáveis 
                        Dim cpf As String
                        Dim sql As String
                        Dim cmd As MySqlCommand
                        Dim resultado_01 As Object

                        cpf = txt_cpf.Text

                        Call abrir_conexao_banco()

                        sql = "SELECT codigo FROM tb_professores WHERE cpf = @cpf"
                        cmd = New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@cpf", cpf)

                        resultado_01 = cmd.ExecuteScalar()

                        If resultado_01 Is Nothing Then
                            Throw New Exception("CPF não encontrado.")
                        Else
                            sql = "DELETE FROM tb_professores WHERE codigo = @codigo"
                            cmd = New MySqlCommand(sql, conn)
                            cmd.Parameters.AddWithValue("@codigo", resultado_01)

                            cmd.ExecuteNonQuery()

                            Call fechar_conexao_banco()

                            MsgBox("Registro excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")

                            Call limpar_form()
                        End If
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Call fechar_conexao_banco()
        End Try
    End Sub

    Private Sub cadastro_professores_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            operacional.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Function buscar_pagamentos()
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim resultado As Object
        Dim cont_linhas As Object
        Dim cpf As String = txt_cpf.Text
        Dim pagamento_realizado As Boolean

        Call abrir_conexao_banco()

        sql = "SELECT codigo FROM tb_professores WHERE cpf = @cpf"
        cmd = New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@cpf", cpf)

        resultado = cmd.ExecuteScalar

        Call fechar_conexao_banco()

        Call abrir_conexao_banco()
        sql = "SELECT COUNT(professor) FROM tb_pagamentos WHERE professor = @codigo"
        cmd = New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@codigo", resultado)

        cont_linhas = cmd.ExecuteScalar

        If cont_linhas > 0 Then
            pagamento_realizado = True
        Else
            pagamento_realizado = False
        End If
        Call fechar_conexao_banco()
        Return pagamento_realizado
    End Function

    Private Function buscar_alunos_supervisionados()
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim codigo As Object
        Dim cont_linhas As Object
        Dim cpf As String = txt_cpf.Text

        Call abrir_conexao_banco()

        sql = "SELECT codigo FROM tb_professores WHERE cpf = @cpf"
        cmd = New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@cpf", cpf)

        codigo = cmd.ExecuteScalar

        Call fechar_conexao_banco()

        Call abrir_conexao_banco()

        sql = "SELECT COUNT(professor) FROM tb_clientes WHERE professor = @codigo"
        cmd = New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@codigo", codigo)
        cont_linhas = cmd.ExecuteScalar

        Return cont_linhas
    End Function
End Class
