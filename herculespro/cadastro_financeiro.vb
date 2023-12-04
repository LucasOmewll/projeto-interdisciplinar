Imports MySql.Data.MySqlClient

Public Class cadastro_financeiro
    Private Sub cadastro_financeiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operacional.Close()

        'Cmb_responsavel'
        Dim conexao As String = "server=localhost;userid=root;password='';database=db_herculespro"
        Dim query As String = "SELECT nome FROM tb_professores"

        ' Cria uma conexão com o banco de dados
        ' Cria uma conexão com o banco de dados
        Using connection As New MySqlConnection(conexao)
            Using command As New MySqlCommand(query, connection)
                Try
                    ' Abre a conexão
                    connection.Open()

                    ' Cria um leitor de dados para ler os resultados da consulta
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Limpa a ComboBox antes de preencher
                        cmb_responsavel.Items.Clear()

                        ' Verifica se há linhas retornadas pela consulta
                        If reader.HasRows Then
                            ' Preenche a ComboBox com os resultados da consulta
                            While reader.Read()
                                cmb_responsavel.Items.Add(reader("nome").ToString())
                            End While

                        End If
                    End Using
                Catch ex As Exception
                    ' Manipula exceções, exibe mensagem de erro ou realiza outra ação necessária
                    MessageBox.Show("Erro ao consultar o banco de dados: " & ex.Message)
                End Try
            End Using
        End Using

        '==================================================================================='

        'cmb_tipopagamento'

        With cmb_tipoPagamento
            .Items.Add("À vista")
            .Items.Add("Parcelado")
        End With

        '==================================================================================='

        'Saída ou entrada' cmb_tipoTransacao

        With cmb_tipoTransacao
            .Items.Add("Entrada")
            .Items.Add("Saída")
        End With

        'responsável padrão'

        With cmb_responsavel
            .Items.Add("Gerente")
            .Items.Add("Funcionário")
        End With
        '=============================================================================='
    End Sub

    Private Sub cmb_transacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipoTransacao.SelectedIndexChanged
        cmb_categoria.Items.Clear() ' Limpa os itens anteriores na ComboBox de categorias

        If cmb_tipoTransacao.SelectedItem IsNot Nothing Then
            Dim tipoSelecionado As String = cmb_tipoTransacao.SelectedItem.ToString()

            If tipoSelecionado = "Saída" Then
                ' Adiciona os itens de saída à ComboBox de categoria
                With cmb_categoria
                    .Items.Add("Serviços Prestados")
                    .Items.Add("Equipamentos e Materiais")
                    .Items.Add("Gastos com Instrutores e Funcionários")
                    .Items.Add("Despesas Operacionais")
                    .Items.Add("Marketing e Publicidade")
                End With
            ElseIf tipoSelecionado = "Entrada" Then
                ' Adiciona os itens de entrada à ComboBox de categoria
                With cmb_categoria
                    .Items.Add("Mensalidades")
                    .Items.Add("Matrículas e Taxas")
                    .Items.Add("Vendas de Produtos Adicionais")
                    .Items.Add("Parcerias ou Patrocínios")
                    .Items.Add("Eventos Especiais ou Workshops")
                End With
            End If
        End If
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        'gravação de dados'

        'Jogando os dados em variáveis'
        Dim descricao As String = txt_descricao.Text
        Dim valor As Decimal = num_valor.Value

        Dim data As Date = date_transacao.Value
        Dim dataTransacaoFormatada As String = data.ToString("yyyy-MM-dd")

        Dim data_pagamento As Date = date_pagamento.Value
        Dim dataPagamentoFormatada As String = data_pagamento.ToString("yyyy-MM-dd")

        Dim tipo_transacao As String = cmb_tipoTransacao.SelectedItem.ToString
        Dim responsavel As String = cmb_responsavel.SelectedItem.ToString
        Dim categoria As String = cmb_categoria.SelectedItem.ToString
        Dim tipo_pagamento As String = cmb_tipoPagamento.SelectedItem.ToString

        'gravando no banco'
        Dim connectionString As String = "server=localhost;userid=root;password='';database=db_herculespro"

        ' Definindo a query SQL com parâmetros
        Dim queryGravarDados As String = "INSERT INTO financeiro (descricao, valor, tipo_pagamento, data, tipo, data_pagamento, responsavel, categoria) VALUES (@descricao, @valor, @tipo_pagamento, @data, @tipo, @data_pagamento, @responsavel, @categoria)"

        ' Criando a conexão e o comando com a query e a conexão
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(queryGravarDados, connection)
                ' Adicionando os parâmetros e seus valores ao comando
                command.Parameters.AddWithValue("@descricao", descricao)
                command.Parameters.AddWithValue("@valor", valor)
                command.Parameters.AddWithValue("@tipo_pagamento", tipo_pagamento)
                command.Parameters.AddWithValue("@data", dataTransacaoFormatada)
                command.Parameters.AddWithValue("@tipo", tipo_transacao)
                command.Parameters.AddWithValue("@data_pagamento", dataPagamentoFormatada)
                command.Parameters.AddWithValue("@responsavel", responsavel)
                command.Parameters.AddWithValue("@categoria", categoria)

                ' Abrindo a conexão e executando o comando SQL
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                connection.Close()



                ' Verificando se a inserção foi bem-sucedida
                If rowsAffected > 0 Then
                    ' Limpar os campos
                    txt_descricao.Text = ""
                    num_valor.Value = 0.00
                    cmb_responsavel.SelectedIndex = -1 ' Limpa a seleção do ComboBox
                    cmb_tipoPagamento.SelectedIndex = -1
                    cmb_tipoTransacao.SelectedIndex = -1
                    cmb_categoria.SelectedIndex = -1
                    date_pagamento.Value = Date.Now ' Define a data para a data atual
                    date_transacao.Value = Date.Now

                    ' Exibir mensagem de sucesso
                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Se houve um problema na inserção, exibir uma mensagem de erro
                    MessageBox.Show("Erro ao inserir os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cadastro_financeiro_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        operacional.Show()
    End Sub
End Class