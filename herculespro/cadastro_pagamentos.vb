Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class cadastro_pagamentos
    Structure professor
        Public codigo As Integer
        Public cpf As String
        Public nome As String
    End Structure

    Public professores() As professor
    Private Sub cadastro_pagamentos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            operacional.Close()
            Call abrir_conexao_banco()
            'Obtendo o número de professores registrados
            Dim index As Integer
            Dim sql As String
            Dim cmd As MySqlCommand
            Dim num_professores As Object
            Dim resultado As Object

            sql = "SELECT COUNT(tb_professores.codigo) FROM tb_professores"
            cmd = New MySqlCommand(sql, conn)

            num_professores = cmd.ExecuteScalar

            If num_professores = 0 Then
                Throw New System.Exception("Não há professores disponíveis.")
            Else
                ReDim professores(num_professores - 1) 'Definindo o tamanho do array professores

                sql = "SELECT tb_professores.codigo, tb_professores.cpf, tb_professores.nome FROM tb_professores"

                cmd = New MySqlCommand(sql, conn)

                resultado = cmd.ExecuteReader

                index = 0
                'Com a lista de código e nomes dos professores obtida, estes valores serão adicionados ao array professores,
                'do tipo "professor" criado no início desta classe
                While resultado.read
                    professores(index).codigo = resultado(0)
                    professores(index).cpf = resultado(1).ToString
                    professores(index).nome = resultado(2).ToString
                    index = index + 1
                End While

                Call fechar_conexao_banco()

                'Adicionando os valores do array professores na combo box cbx_professores
                For i As Integer = 0 To (professores.Length - 1)
                    With cbx_professores_pag.Items
                        .Add(professores(i).nome & " - " & professores(i).cpf)
                    End With
                Next

            End If

            Call fechar_conexao_banco()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Call fechar_conexao_banco()
        End Try
    End Sub
    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim codigo_professor As Integer
        Dim data_pagamento As Date

        Try
            If cbx_professores_pag.SelectedIndex = -1 Then
                Throw New System.Exception("Por favor, selecione um professor para realizar o pagamento.")
            Else
                resp = MsgBox("Gostaria de registrar este pagamento?" + vbNewLine + "ALERTA: POR MOTIVOS DE SEGURANÇA, ESTE REGISTRO NÃO PODE SER EXCLUÍDO", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)

                If resp = vbNo Then
                    Exit Sub
                Else
                    Call abrir_conexao_banco()

                    sql = "INSERT INTO tb_pagamentos(tb_pagamentos.professor, tb_pagamentos.datapgto) VALUES (@professor, @data)"
                    codigo_professor = professores(cbx_professores_pag.SelectedIndex).codigo
                    data_pagamento = Format(date_pagamento.Value, "yyyy-MM-dd")

                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@professor", codigo_professor)
                    cmd.Parameters.AddWithValue("@data", data_pagamento)

                    cmd.ExecuteScalar()

                    MsgBox("Pagamento registrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")

                    cbx_professores_pag.SelectedIndex = -1

                    Call fechar_conexao_banco()

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click

        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub cadastro_pagamentos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            operacional.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class