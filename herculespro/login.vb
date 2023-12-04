Imports System.CodeDom
Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class login
    Private Sub chk_exibir_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_exibir_senha.CheckedChanged
        Try
            txt_senha.UseSystemPasswordChar = Not chk_exibir_senha.Checked
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Try
            Application.Exit()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            'Verificando se todos os campos estão preenchidos
            If txt_cpf.MaskCompleted = False Or txt_senha.Text = "" Or cbx_cargos.SelectedIndex = -1 Then
                Throw New SystemException("Por favor, preencha todos os campos.")
            Else

                Dim cpf_input As String = txt_cpf.Text
                Dim senha_input_hashed As String
                Dim senha_banco As String
                Dim sql As String
                Dim cmd As MySqlCommand
                Dim resultado_01 As Object
                Dim resultado_02 As Object

                Call abrir_conexao_banco()

                'Obtendo o código do usuário através do CPF
                '===========================================

                'Verificando o cargo do usuário para determinar em qual tabela procurar o CPF
                If cbx_cargos.SelectedIndex = 0 Then
                    sql = "SELECT codigo FROM tb_gerentes WHERE cpf = @cpf"
                Else
                    sql = "SELECT codigo FROM tb_professores WHERE cpf = @cpf"
                End If

                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("cpf", cpf_input)

                'Variável resultado_01 obtém o valor da query. No caso, o código do usuário
                resultado_01 = cmd.ExecuteScalar()

                'Caso o cpf fornecido existir no sistema, sua senha será buscada
                If resultado_01 Is Nothing Then
                    Throw New System.Exception("Este CPF não consta no sistema.")
                Else

                    'Verificando o cargo do usuário para determinar em qual tabela procurar a senha
                    If cbx_cargos.SelectedIndex = 0 Then
                        'O cargo do usuário também é buscado no banco de dados para criar uma camada de segurança adicional
                        sql = "SELECT senha, cargo FROM tb_gerentes WHERE codigo = @codigo"
                    Else
                        sql = "SELECT senha, cargo, situacao FROM tb_professores WHERE codigo = @codigo"
                    End If

                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("codigo", resultado_01)

                    'Variável resultado_02 recebe o hash da senha do usuário, armazenado no banco de dados
                    resultado_02 = cmd.ExecuteReader

                    'Obtém o hash da senha informada pelo usuário no login
                    senha_input_hashed = calcular_SHA512(txt_senha.Text)



                    While resultado_02.read()
                        'Decodifica o hash armazenado no banco de dados, que está em binário
                        senha_banco = System.Text.Encoding.UTF8.GetString(resultado_02(0))

                        'Verificando se o hash da senha armazenado no banco bate com o hash da senha providenciada pelo usuário
                        If senha_input_hashed = senha_banco Then

                            'Verificando se o usuário possui permissões gerenciais
                            If resultado_02(1) = 1 Then
                                acessoGerente = True
                            End If

                            If cbx_cargos.SelectedIndex = 1 Then
                                If resultado_02(2) <> 3 Then
                                    Throw New System.Exception("Você não tem permissão para acessar o sistema")
                                End If
                            End If

                                MsgBox("Login realizado com sucesso!" + vbNewLine + "Tenha um bom trabalho.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")

                                'Exibe a tela de operações da aplicação
                                operacional.Show()
                                Me.Close()

                            Else
                                Throw New System.Exception("Senha incorreta.")
                        End If
                    End While

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            Call fechar_conexao_banco()
        End Try
    End Sub
End Class