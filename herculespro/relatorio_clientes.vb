Imports MySql.Data.MySqlClient

Public Class relatorio_clientes
    Dim sql As String
    Dim nome_filtro As String
    Dim table As New DataTable()
    Dim adapter As MySqlDataAdapter
    Private Sub relatorio_clientes_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            dgv_relatorio_clientes.AutoGenerateColumns = False

            sql = "SELECT tb_clientes.codigo, tb_clientes.nome, tb_clientes.cpf, tb_clientes.telefone, tb_clientes.idade, tb_clientes.situacao,
                ifnull(tb_clientes.patologia, 'N/A') as patologia,
                ifnull(tb_clientes.restricoes, 'N/A') as restricoes, 
                if(tb_clientes.examevalidade < current_date(), 'VALIDADE EXPIRADA', tb_clientes.examevalidade) as exame_validade,
                tb_planos.nome as nome_plano, 
                if(timestampdiff(month, max(tb_pag_assinaturas.datapgto), current_date()) > tb_planos.meses,'CLIENTE INADIMPLENTE', max(tb_pag_assinaturas.datapgto))
                as ultimo_pagamento,
                tb_professores.nome as nome_professor, ifnull(tb_clientes.cpf_responsavel, 'N/A') as cpf_responsavel
                from tb_clientes
                inner join tb_planos 
                on tb_clientes.plano = tb_planos.codigo
                inner join tb_professores
                on tb_clientes.professor = tb_professores.codigo
                left outer join tb_pag_assinaturas
                on tb_clientes.codigo = tb_pag_assinaturas.cliente
                where tb_clientes.nome like concat(@nome, '%')
                group by tb_clientes.codigo"

            Call txt_filtro_nome_TextChanged(Nothing, Nothing)

            Call percorrer_tabela()

            atualizar_operacional()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txt_filtro_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro_nome.TextChanged
        nome_filtro = txt_filtro_nome.Text
        table = New DataTable()
        adapter = New MySqlDataAdapter

        Try
            Call abrir_conexao_banco()
            adapter = New MySqlDataAdapter(sql, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@nome", nome_filtro)
            adapter.SelectCommand.Prepare()


            adapter.Fill(table)

            Call fechar_conexao_banco()

            dgv_relatorio_clientes.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Alerta")
        End Try
    End Sub

    Private Sub percorrer_tabela()
        For Each row As DataRow In table.Rows
            If row.Item("ultimo_pagamento") = "CLIENTE INADIMPLENTE" And row.Item("situacao") = 1 Then
                Call atualizar_situacao(2, row.Item("codigo"))
            End If

            If row.Item("ultimo_pagamento") IsNot "CLIENTE INADIMPLENTE" And row.Item("situacao") = 2 Then
                Call atualizar_situacao(1, row.Item("codigo"))
            End If
        Next
    End Sub

    Private Sub atualizar_situacao(situacao As Integer, codigo As Integer)
        Call abrir_conexao_banco()

        Dim sql_atualizar As String = "UPDATE tb_clientes SET situacao = @situacao WHERE codigo = @codigo"
        Dim cmd_atualizar As New MySqlCommand(sql_atualizar, conn)

        cmd_atualizar.Parameters.AddWithValue("@situacao", situacao)
        cmd_atualizar.Parameters.AddWithValue("@codigo", codigo)

        cmd_atualizar.ExecuteScalar()

        Call fechar_conexao_banco()
    End Sub

    Private Sub atualizar_operacional()
        With operacional
            .lbl_contagem_clientes.Text = buscar_numero_alunos()
            Call popular_dgv_clientes()
        End With
    End Sub
End Class