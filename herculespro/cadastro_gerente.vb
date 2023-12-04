Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class cadastro_gerente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txt_cpf.MaskCompleted = False Or
               txt_nome.Text = "" Or
               txt_telefone.MaskCompleted = False Or
               txt_cep.MaskCompleted = False Or
               txt_senha.Text = "" Or
               txt_confirmar_senha.Text = "" Then

                Throw New System.Exception("Preencha todos os campos.")
            Else
                If txt_senha.Text = txt_confirmar_senha.Text Then
                    'Abrindo conexão com o banco de dados
                    Call abrir_conexao_banco()

                    Dim sql As String = "SELECT cpf FROM tb_gerentes WHERE cpf = @cpf_user"
                    Dim cmd As New MySqlCommand(sql, conn)

                    cmd.Parameters.AddWithValue("@cpf_user", txt_cpf.Text)

                    'Executando a query e obtendo o resultado como objeto
                    Dim resultado As Object = cmd.ExecuteScalar()

                    'Se nenhum registro for encontrado, os dados serão cadastrados
                    If resultado Is Nothing Then
                        'criptografando senha
                        Dim senha_hashed = calcular_SHA512(txt_senha.Text)

                        'Definindo query e parâmetros
                        '==============================================
                        sql = "INSERT INTO tb_gerentes (cpf, nome, telefone, cep, cargo, senha) values (@cpf_user, @nome_user, @tel_user, @cep_user, @cargo_user, @senha_user)"
                        Dim cmd_02 As New MySqlCommand(sql, conn)

                        cmd_02.Parameters.AddWithValue("@cpf_user", txt_cpf.Text)
                        cmd_02.Parameters.AddWithValue("@nome_user", txt_nome.Text)
                        cmd_02.Parameters.AddWithValue("@tel_user", txt_telefone.Text)
                        cmd_02.Parameters.AddWithValue("@cep_user", txt_cep.Text)
                        cmd_02.Parameters.AddWithValue("@cargo_user", 1)
                        cmd_02.Parameters.AddWithValue("@senha_user", senha_hashed)
                        '==============================================


                        cmd_02.ExecuteScalar()
                        MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")

                        'Encerrando conexão com o banco
                        Call fechar_conexao_banco()

                        'Reiniciando a Aplicação
                        MsgBox("Obrigado por se cadastrar!" + vbNewLine + "A aplicação será reiniciada agora, por favor aguarde para realizar o seu login...", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Atenção")

                        'Limpando todos os forms ativos
                        For i As Integer = Application.OpenForms.Count - 1 To 0 Step -1
                            Dim form_ativo = Application.OpenForms(i)
                            If form_ativo.Text <> Me.Text Then
                                form_ativo.Close()
                                form_ativo.Dispose()
                            End If
                        Next

                        Application.Restart()

                    Else
                        Throw New System.Exception("Este CPF já está cadastrado no sistema.")
                    End If
                Else
                    Throw New System.Exception("As senhas não coincidem.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            Call fechar_conexao_banco()
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub txt_cpf_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_cpf.MouseDoubleClick
        txt_cpf.Text = ""
        txt_nome.Text = ""
        txt_telefone.Text = ""
        txt_cep.Text = ""
        txt_senha.Text = ""
        txt_confirmar_senha.Text = ""
    End Sub

    Private Sub chk_exibir_senha_CheckedChanged(sender As Object, e As EventArgs) Handles chk_exibir_senha.CheckedChanged
        txt_senha.UseSystemPasswordChar = Not chk_exibir_senha.Checked
    End Sub
End Class
