Imports System.Globalization
Imports MySql.Data.MySqlClient
Public Class cadastro_pagamentos_clientes
    Structure aluno
        Public codigo As Integer
        Public cpf As String
        Public nome As String
    End Structure

    Public alunos() As aluno

    Private Sub cadastro_pagamentos_clientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            operacional.Close()

            Call abrir_conexao_banco()
            'Obtendo o número de clientes registrados
            Dim index As Integer
            Dim sql As String
            Dim cmd As MySqlCommand
            Dim num_alunos As Object
            Dim resultado As Object

            sql = "SELECT COUNT(tb_clientes.codigo) FROM tb_clientes"
            cmd = New MySqlCommand(sql, conn)

            num_alunos = cmd.ExecuteScalar

            If num_alunos = 0 Then
                Throw New System.Exception("Não há alunos disponíveis.")
            Else
                ReDim alunos(num_alunos - 1) 'Definindo o tamanho do array alunos

                sql = "SELECT tb_clientes.codigo, tb_clientes.cpf, tb_clientes.nome FROM tb_clientes"

                cmd = New MySqlCommand(sql, conn)

                resultado = cmd.ExecuteReader

                index = 0
                While resultado.read
                    alunos(index).codigo = resultado(0)
                    alunos(index).cpf = resultado(1).ToString
                    alunos(index).nome = resultado(2).ToString
                    index = index + 1
                End While

                Call fechar_conexao_banco()
                For i As Integer = 0 To (alunos.Length - 1)
                    With cbx_alunos_pag.Items
                        .Add(alunos(i).nome & " - " & alunos(i).cpf)
                    End With
                Next
            End If

            Call fechar_conexao_banco()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim codigo_cliente As Integer
        Dim data_pagamento As Date

        Try
            If cbx_alunos_pag.SelectedIndex = -1 Then
                Throw New System.Exception("Por favor, selecione um aluno para realizar o pagamento.")
            Else
                resp = MsgBox("Gostaria de registrar este pagamento?" + vbNewLine + "ALERTA: POR MOTIVOS DE SEGURANÇA, ESTE REGISTRO NÃO PODE SER EXCLUÍDO", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)

                If resp = vbNo Then
                    Exit Sub
                Else
                    Call abrir_conexao_banco()

                    sql = "INSERT INTO tb_pag_assinaturas(tb_pag_assinaturas.cliente, tb_pag_assinaturas.datapgto) VALUES (@cliente, @data)"
                    codigo_cliente = alunos(cbx_alunos_pag.SelectedIndex).codigo
                    data_pagamento = Format(date_pagamento.Value, "yyyy-MM-dd")

                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cliente", codigo_cliente)
                    cmd.Parameters.AddWithValue("@data", data_pagamento)

                    cmd.ExecuteScalar()

                    MsgBox("Pagamento registrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")

                    cbx_alunos_pag.SelectedIndex = -1

                    Call fechar_conexao_banco()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cadastro_pagamentos_clientes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        operacional.Show()
    End Sub
End Class