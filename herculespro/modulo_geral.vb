Imports MySql.Data.MySqlClient
Module modulo_geral
    Public conn As MySqlConnection
    Public acessoGerente As Boolean
    Public resp As String

    Sub abrir_conexao_banco()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=db_herculespro;Convert Zero Datetime=True"

        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            conn.Close()
        End Try
    End Sub

    Sub fechar_conexao_banco()
        Try
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Public Function buscar_numero_professores()
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim resultado As Object
        Try
            Call abrir_conexao_banco()

            sql = "SELECT COUNT(codigo) as professores_ativos FROM tb_professores WHERE situacao = 3" '3 -> "ATIVO"
            cmd = New MySqlCommand(sql, conn)

            resultado = cmd.ExecuteScalar()

            Return resultado
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            Return 0
        End Try
    End Function

    Public Function buscar_numero_alunos()
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim resultado As Object
        Try
            Call abrir_conexao_banco()

            sql = "SELECT COUNT(codigo) as clientes_ativos FROM tb_clientes WHERE situacao = 1" '1 -> "REGULAR"
            cmd = New MySqlCommand(sql, conn)

            resultado = cmd.ExecuteScalar()

            Return resultado
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
            Return 0
        End Try
    End Function

    Public Sub popular_dgv_clientes()
        Dim sql As String
        Dim table As New DataTable()
        Dim adapter As MySqlDataAdapter

        Call abrir_conexao_banco()

        sql = "select tb_clientes.nome, tb_clientes.cpf, tb_planos.nome as assinatura , ifnull(max(tb_pag_assinaturas.datapgto),'NENHUM PAGAMENTO REALIZADO') as ultimo_pgto
                from tb_clientes 
                left outer join tb_planos
                on tb_clientes.plano = tb_planos.codigo
                left outer join tb_pag_assinaturas
                on tb_clientes.codigo = tb_pag_assinaturas.cliente
                where tb_clientes.situacao = 1
                group by tb_clientes.codigo
                order by ultimo_pgto desc;"

        adapter = New MySqlDataAdapter(sql, conn)

        adapter.Fill(table)

        With operacional
            .dgv_clientes.DataSource = table
        End With

        Call fechar_conexao_banco()
    End Sub

    Public Sub popular_dgv_professores()
        Dim sql As String
        Dim table As New DataTable()
        Dim adapter As MySqlDataAdapter

        Call abrir_conexao_banco()

        sql = "select tb_professores.nome, tb_professores.cpf, tb_professores.salario, ifnull(max(tb_pagamentos.datapgto),'NENHUM PAGAMENTO REALIZADO') as ultimo_pgto
                from tb_professores 
                left outer join tb_pagamentos
                on tb_professores.codigo = tb_pagamentos.professor
                where tb_professores.situacao = 3
                group by tb_professores.codigo
                order by ultimo_pgto desc;"

        adapter = New MySqlDataAdapter(sql, conn)

        adapter.Fill(table)

        With operacional
            .dgv_professores.DataSource = table
        End With

        Call fechar_conexao_banco()
    End Sub


    Public Function calcular_SHA512(ByVal content As String) As String
        Dim encriptar As New Security.Cryptography.SHA512CryptoServiceProvider
        Dim bytestring() As Byte = System.Text.Encoding.ASCII.GetBytes(content)

        bytestring = encriptar.ComputeHash(bytestring)

        Dim resultado_hash As String = Nothing

        For Each bt As Byte In bytestring
            resultado_hash &= bt.ToString("x2")
        Next

        Return resultado_hash
    End Function

End Module
