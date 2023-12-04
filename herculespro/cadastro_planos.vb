Imports MySql.Data.MySqlClient

Public Class cadastro_planos
    Private Sub cadastro_planos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            operacional.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Sub limpar_cadastro_planos()
        txt_codigo_plano.Clear()
        txt_nome_plano.Clear()
        num_periodo_plano.Value = 1
        num_valor_plano.Value = 0.0
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            If txt_nome_plano.Text = "" Or num_valor_plano.Value = 0.0 Or txt_codigo_plano.Text = "" Then
                Throw New System.Exception("Por favor, preencha todos os campos obrigatórios.")
            Else
                'Definindo variáveis
                'Valores
                Dim codigoPlano As Integer = CInt(txt_codigo_plano.Text)
                Dim nomePlano As String = txt_nome_plano.Text
                Dim valorPlano As Decimal = num_valor_plano.Value
                Dim periodoPlano As Integer = num_periodo_plano.Value

                Call abrir_conexao_banco()

                'Variáveis utilizadas no SQL
                Dim sql As String
                Dim cmd As MySqlCommand
                Dim resultado As Object

                'Buscando o código no banco de dados, determina-se se o plano já está cadastrado
                sql = "SELECT tb_planos.codigo FROM tb_planos WHERE codigo = @codigo"
                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@codigo", codigoPlano)

                resultado = cmd.ExecuteScalar()

                If resultado Is Nothing Then
                    sql = "INSERT INTO tb_planos (codigo, nome, valor, meses) VALUES (@codigo, @nome, @valor, @meses)"
                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@codigo", codigoPlano)
                    cmd.Parameters.AddWithValue("@nome", UCase(nomePlano))
                    cmd.Parameters.AddWithValue("@valor", valorPlano)
                    cmd.Parameters.AddWithValue("@meses", periodoPlano)

                    resultado = cmd.ExecuteScalar()

                    Call fechar_conexao_banco()

                    resp = MsgBox("Plano cadastrado com sucesso!" + vbNewLine + "Gostaria de realizar um novo cadastro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")

                    If resp = vbYes Then
                        Call limpar_cadastro_planos()
                        Exit Sub
                    Else
                        Me.Close()
                    End If

                Else
                    resp = MsgBox("Um plano com este código já está cadastrado." + vbNewLine + "Gostaria de atualizar as informações do mesmo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")

                    If resp = vbYes Then
                        sql = "UPDATE tb_planos SET nome = @nome, valor = @valor, meses = @meses WHERE codigo = @codigo"
                        cmd = New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@nome", UCase(nomePlano))
                        cmd.Parameters.AddWithValue("@valor", valorPlano)
                        cmd.Parameters.AddWithValue("@meses", periodoPlano)
                        cmd.Parameters.AddWithValue("@codigo", codigoPlano)

                        resultado = cmd.ExecuteScalar()

                        Call fechar_conexao_banco()

                        resp = MsgBox("Plano atualizado com sucesso!" + vbNewLine + "Gostaria de realizar uma nova operação?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")

                        If resp = vbYes Then
                            Call limpar_cadastro_planos()
                            Exit Sub
                        Else
                            Me.Close()
                        End If

                    Else
                        Call limpar_cadastro_planos()
                        Exit Sub
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Call fechar_conexao_banco()
        End Try
    End Sub

    Private Sub btn_excluir_Click(sender As Object, e As EventArgs) Handles btn_excluir.Click
        Try
            If String.IsNullOrEmpty(txt_codigo_plano.Text) = True Then
                Throw New System.Exception("Para excluir um plano, por favor informe o código respectivo.")
            Else

                'Verificando se o usuário gostaria de proceder com a operação de exclusão do plano
                resp = MsgBox("Gostaria de excluir este registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")

                If resp = vbYes Then
                    'Variáveis
                    Dim codigo As Integer = CInt(txt_codigo_plano.Text)

                    Call abrir_conexao_banco()

                    'Variáveis utilizadas no SQL
                    Dim sql As String = "SELECT codigo FROM tb_planos WHERE codigo = @codigo" 'Verificando se o código inserido pelo usuário existe na tabela
                    Dim cmd As New MySqlCommand(sql, conn)
                    Dim resultado As Object

                    cmd.Parameters.AddWithValue("@codigo", codigo)

                    resultado = cmd.ExecuteScalar

                    If resultado IsNot Nothing Then
                        sql = "DELETE FROM tb_planos WHERE codigo = @codigo"
                        cmd = New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@codigo", codigo)

                        cmd.ExecuteScalar()

                        Call fechar_conexao_banco()

                        MsgBox("Plano excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                        Call limpar_cadastro_planos()
                        Exit Sub
                    Else
                        Throw New System.Exception("Nenhum plano encontrado com o código fornecido.")
                    End If
                Else
                    Exit Sub
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            Call fechar_conexao_banco()
        End Try
    End Sub

    Private Sub txt_codigo_plano_LostFocus(sender As Object, e As EventArgs) Handles txt_codigo_plano.LostFocus
        Try
            If String.IsNullOrEmpty(txt_codigo_plano.Text) = False Then
                Dim codigo As Integer = CInt(txt_codigo_plano.Text)

                'Variáveis utilizadas no SQL
                Dim sql As String = "SELECT tb_planos.nome, tb_planos.valor, tb_planos.meses FROM tb_planos WHERE codigo = @codigo"
                Dim cmd As MySqlCommand
                Dim resultado As Object

                Call abrir_conexao_banco()

                cmd = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@codigo", codigo)

                resultado = cmd.ExecuteReader()

                If resultado IsNot Nothing Then
                    While resultado.Read()
                        txt_nome_plano.Text = resultado(0)
                        num_valor_plano.Value = resultado(1)
                        num_periodo_plano.Value = resultado(2)
                    End While

                    Call fechar_conexao_banco()
                End If

                Call fechar_conexao_banco()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            Call fechar_conexao_banco()
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub cadastro_planos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            operacional.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub txt_codigo_plano_DoubleClick(sender As Object, e As EventArgs) Handles txt_codigo_plano.DoubleClick
        Try
            Call limpar_cadastro_planos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class