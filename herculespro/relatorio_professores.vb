Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Imports System.Reflection
Public Class relatorio_professores
    Dim sql As String
    Private Sub relatorio_professores_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgv_relatorio_professores.AutoGenerateColumns = False
        sql = "select tb_professores.codigo, tb_professores.nome, tb_professores.cpf, tb_professores.cref, tb_professores.telefone,
                tb_professores.cep, tb_professores.sexo, tb_cargos.descricao, tb_situacoes.nome as situacao, tb_professores.salario 
                from tb_professores
                inner join tb_cargos
                on tb_professores.cargo = tb_cargos.codigo
                inner join tb_situacoes
                on tb_professores.situacao = tb_situacoes.codigo
                where tb_professores.nome like concat(@nome, '%')"

        Call txt_filtro_nome_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub txt_filtro_nome_TextChanged(sender As Object, e As EventArgs) Handles txt_filtro_nome.TextChanged
        Dim nome_filtro As String = txt_filtro_nome.Text
        Dim table As New DataTable()
        Dim adapter As MySqlDataAdapter

        Try
            Call abrir_conexao_banco()
            adapter = New MySqlDataAdapter(sql, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@nome", nome_filtro)
            adapter.SelectCommand.Prepare()


            adapter.Fill(table)

            Call fechar_conexao_banco()

            dgv_relatorio_professores.DataSource = table
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Alerta")
        End Try
    End Sub

    Private Sub AtivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtivoToolStripMenuItem.Click

        Try
            sql = "select tb_professores.codigo, tb_professores.nome, tb_professores.cpf, tb_professores.cref, tb_professores.telefone,
                tb_professores.cep, tb_professores.sexo, tb_cargos.descricao, tb_situacoes.nome as situacao, tb_professores.salario 
                from tb_professores
                inner join tb_cargos
                on tb_professores.cargo = tb_cargos.codigo
                inner join tb_situacoes
                on tb_professores.situacao = tb_situacoes.codigo
                where tb_professores.nome like concat(@nome, '%') and tb_professores.situacao = 3"

            Call txt_filtro_nome_TextChanged(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Alerta")
        End Try
    End Sub

    Private Sub DesligadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesligadoToolStripMenuItem.Click


        Try
            sql = "select tb_professores.codigo, tb_professores.nome, tb_professores.cpf, tb_professores.cref, tb_professores.telefone,
                tb_professores.cep, tb_professores.sexo, tb_cargos.descricao, tb_situacoes.nome as situacao, tb_professores.salario 
                from tb_professores
                inner join tb_cargos
                on tb_professores.cargo = tb_cargos.codigo
                inner join tb_situacoes
                on tb_professores.situacao = tb_situacoes.codigo
                where tb_professores.nome like concat(@nome, '%') and tb_professores.situacao = 4"

            Call txt_filtro_nome_TextChanged(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Alerta")
        End Try
    End Sub

    Private Sub FemininoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FemininoToolStripMenuItem.Click

        Try
            sql = "select tb_professores.codigo, tb_professores.nome, tb_professores.cpf, tb_professores.cref, tb_professores.telefone,
                tb_professores.cep, tb_professores.sexo, tb_cargos.descricao, tb_situacoes.nome as situacao, tb_professores.salario 
                from tb_professores
                inner join tb_cargos
                on tb_professores.cargo = tb_cargos.codigo
                inner join tb_situacoes
                on tb_professores.situacao = tb_situacoes.codigo
                where tb_professores.nome like concat(@nome, '%') and tb_professores.sexo = 'F'"

            Call txt_filtro_nome_TextChanged(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Alerta")
        End Try
    End Sub

    Private Sub MasculinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasculinoToolStripMenuItem.Click

        Try
            sql = "select tb_professores.codigo, tb_professores.nome, tb_professores.cpf, tb_professores.cref, tb_professores.telefone,
                tb_professores.cep, tb_professores.sexo, tb_cargos.descricao, tb_situacoes.nome as situacao, tb_professores.salario 
                from tb_professores
                inner join tb_cargos
                on tb_professores.cargo = tb_cargos.codigo
                inner join tb_situacoes
                on tb_professores.situacao = tb_situacoes.codigo
                where tb_professores.nome like concat(@nome, '%') and tb_professores.sexo = 'M'"

            Call txt_filtro_nome_TextChanged(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Alerta")
        End Try
    End Sub

    Private Sub RemoverFiltrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoverFiltrosToolStripMenuItem.Click

        Try
            sql = "select tb_professores.codigo, tb_professores.nome, tb_professores.cpf, tb_professores.cref, tb_professores.telefone,
                tb_professores.cep, tb_professores.sexo, tb_cargos.descricao, tb_situacoes.nome as situacao, tb_professores.salario 
                from tb_professores
                inner join tb_cargos
                on tb_professores.cargo = tb_cargos.codigo
                inner join tb_situacoes
                on tb_professores.situacao = tb_situacoes.codigo
                where tb_professores.nome like concat(@nome, '%')"

            Call txt_filtro_nome_TextChanged(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Alerta")
        End Try
    End Sub

End Class