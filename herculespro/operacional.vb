Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Public Class operacional
    Dim tabela As New DataTable
    Dim sqlTabela As String = ""
    Dim adaptador As New MySqlDataAdapter()
    Private Sub operacional_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Verficando níveis de acesso: Se o usuário não for gerente, não poderá utilizar os módulos gerenciais e financeiro
            If acessoGerente = False Then
                TabControl1.TabPages(2).Enabled = False 'Desabilita o módulo gerencial
                TabControl1.TabPages(3).Enabled = False 'Desabilita o módulo financeiro

                TabControl1.TabPages(2).Visible = False
                TabControl1.TabPages(3).Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Call fechar_conexao_banco()
        End Try
        '====================================================================================================================='
        'PARTE DO TREINO'

        'cmb_tipoTreinoAdicionar'
        With cmb_tipoTreinoAdicionar
            .Items.Add("Iniciante")
            .Items.Add("Intermediário")
            .Items.Add("Avançado")
        End With
        'cmb_tipoTreinoAlterar'
        With cmb_tipoTreinoAlterar
            .Items.Add("Iniciante")
            .Items.Add("Intermediário")
            .Items.Add("Avançado")
        End With

        'cmb_professor'
        Dim conexao As String = "server=localhost;userid=root;password='';database=db_herculespro"
        Dim query As String = "SELECT nome FROM tb_professores"

        ' Cria uma conexão com o banco de dados
        Using connection As New MySqlConnection(conexao)
            Using command As New MySqlCommand(query, connection)
                Try
                    ' Abre a conexão
                    connection.Open()

                    ' Cria um leitor de dados para ler os resultados da consulta
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Limpa a ComboBox antes de preencher
                        cmb_professor.Items.Clear()

                        ' Verifica se há linhas retornadas pela consulta
                        If reader.HasRows Then
                            ' Preenche a ComboBox com os resultados da consulta
                            While reader.Read()
                                cmb_professor.Items.Add(reader("nome").ToString())
                            End While

                        End If
                    End Using
                Catch ex As Exception
                    ' Manipula exceções, exibe mensagem de erro ou realiza outra ação necessária
                    MessageBox.Show("Erro ao consultar o banco de dados: " & ex.Message)
                End Try
            End Using
        End Using

        'add nome dos professores a combobox cmb_professoresAlterar'

        Dim conexaoAlterar As String = "server=localhost;userid=root;password='';database=db_herculespro"
        Dim queryAlterar As String = "SELECT nome FROM tb_professores"

        ' Cria uma conexão com o banco de dados
        Using connection As New MySqlConnection(conexaoAlterar)
            Using command As New MySqlCommand(queryAlterar, connection)
                Try
                    ' Abre a conexão
                    connection.Open()

                    ' Cria um leitor de dados para ler os resultados da consulta
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Limpa a ComboBox antes de preencher
                        cmb_professorAlterar.Items.Clear()

                        ' Verifica se há linhas retornadas pela consulta
                        If reader.HasRows Then
                            ' Preenche a ComboBox com os resultados da consulta
                            While reader.Read()
                                cmb_professorAlterar.Items.Add(reader("nome").ToString())
                            End While

                        End If
                    End Using
                Catch ex As Exception
                    ' Manipula exceções, exibe mensagem de erro ou realiza outra ação necessária
                    MessageBox.Show("Erro ao consultar o banco de dados: " & ex.Message)
                End Try
            End Using
        End Using


    End Sub

    Private Sub operacional_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            'Obtendo a quantidade de clientes cadastrados


            lbl_contagem_clientes.Text = buscar_numero_alunos()
            dgv_clientes.AutoGenerateColumns = False
            Call popular_dgv_clientes()

            Call fechar_conexao_banco()

            '===================================================

            If acessoGerente = True Then
                'Obtendo a quantidade de professores cadastrados

                lbl_contagem_professores.Text = buscar_numero_professores()
                dgv_professores.AutoGenerateColumns = False
                Call popular_dgv_professores()

                'despesas'
                Try
                    Dim conn As New MySqlConnection()
                    conn.ConnectionString = "server=localhost;userid=root;password='';database=db_herculespro"

                    conn.Open()

                    Dim sqlDespesas As String = "SELECT SUM(valor) AS total_despesas FROM financeiro WHERE tipo = 'saida'"
                    Dim cmdDespesas As New MySqlCommand(sqlDespesas, conn)
                    Dim resultadoDespesas As Object = cmdDespesas.ExecuteScalar()

                    ' Verificar se o resultado não é DBNull e exibir na label
                    If resultadoDespesas IsNot DBNull.Value Then
                        lbl_despesas.Text = Convert.ToDecimal(resultadoDespesas).ToString("C")
                    Else
                        lbl_despesas.Text = "R$ 0.00" ' Ou outro valor padrão caso não haja despesas
                    End If

                    conn.Close() ' Fechar a conexão após utilizar

                Catch ex As Exception
                    MessageBox.Show(ex.Message) ' Exibir mensagem de erro, se houver
                End Try
                '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\'
                Try 'faturamento'
                    Dim conn As New MySqlConnection()
                    conn.ConnectionString = "server=localhost;userid=root;password='';database=db_herculespro"

                    conn.Open()

                    Dim sqlFaturamento As String = "SELECT SUM(valor) AS total_faturamento FROM financeiro WHERE tipo = 'entrada'"
                    Dim cmdFaturamento As New MySqlCommand(sqlFaturamento, conn)
                    Dim resultadoFaturamento As Object = cmdFaturamento.ExecuteScalar()

                    ' Verificar se o resultado não é DBNull e exibir na label
                    If resultadoFaturamento IsNot DBNull.Value Then
                        lbl_faturamento.Text = Convert.ToDecimal(resultadoFaturamento).ToString("C")
                    Else
                        lbl_faturamento.Text = "R$ 0.00" ' Ou outro valor padrão caso não haja despesas
                    End If
                    conn.Close() ' Fechar a conexão após utilizar

                Catch ex As Exception
                    MessageBox.Show(ex.Message) ' Exibir mensagem de erro, se houver
                End Try

                Try 'vendas'
                    Dim conn As New MySqlConnection()
                    conn.ConnectionString = "server=localhost;userid=root;password='';database=db_herculespro"

                    conn.Open()

                    Dim sqlVendas As String = "SELECT SUM(valor) AS total_faturamento FROM financeiro WHERE tipo = 'entrada' AND categoria = 'Vendas de Produtos Adicionais'"
                    Dim cmdVendas As New MySqlCommand(sqlVendas, conn)
                    Dim resultadoVendas As Object = cmdVendas.ExecuteScalar()

                    ' Verificar se o resultado não é DBNull e exibir na label
                    If resultadoVendas IsNot DBNull.Value Then
                        lbl_vendas.Text = Convert.ToDecimal(resultadoVendas).ToString("C")
                    Else
                        lbl_vendas.Text = "R$ 0.00" ' Ou outro valor padrão caso não haja despesas
                    End If
                    conn.Close() ' Fechar a conexão após utilizar

                Catch ex As Exception
                    MessageBox.Show(ex.Message) ' Exibir mensagem de erro, se houver
                End Try

                'barras'
                Try
                    Call abrir_conexao_banco()

                    ' Defina a consulta SQL para buscar os dados de entrada (receitas) por mês
                    Dim sqlEntradas As String = "SELECT MONTH(data) AS Mes, SUM(valor) AS TotalEntradas FROM financeiro WHERE tipo = 'entrada' GROUP BY MONTH(data)"
                    Dim cmdEntradas As New MySqlCommand(sqlEntradas, conn)
                    Dim daEntradas As New MySqlDataAdapter(cmdEntradas)
                    Dim dtEntradas As New DataTable()
                    daEntradas.Fill(dtEntradas)

                    ' Defina a consulta SQL para buscar os dados de saída (despesas) por mês
                    Dim sqlSaidas As String = "SELECT MONTH(data) AS Mes, SUM(valor) AS TotalSaidas FROM financeiro WHERE tipo = 'saida' GROUP BY MONTH(data)"
                    Dim cmdSaidas As New MySqlCommand(sqlSaidas, conn)
                    Dim daSaidas As New MySqlDataAdapter(cmdSaidas)
                    Dim dtSaidas As New DataTable()
                    daSaidas.Fill(dtSaidas)

                    ' Configuração para agrupar as barras de cada mês
                    char_dif.Series.Clear()

                    ' Definição das séries para entradas e saídas
                    Dim seriesEntradas As New Series()
                    seriesEntradas.Name = "Entradas"
                    seriesEntradas.Color = Color.FromArgb(0, 120, 215) ' Azul
                    seriesEntradas.ChartType = SeriesChartType.Column ' Tipo de gráfico: colunas
                    seriesEntradas.BorderWidth = 2 ' Espessura da borda
                    seriesEntradas.IsValueShownAsLabel = False ' Não Mostrar valores nas barras

                    Dim seriesSaidas As New Series()
                    seriesSaidas.Name = "Saídas"
                    seriesSaidas.Color = Color.FromArgb(220, 70, 70) ' Vermelho
                    seriesSaidas.ChartType = SeriesChartType.Column ' Tipo de gráfico: colunas
                    seriesSaidas.BorderWidth = 2 ' Espessura da borda
                    seriesSaidas.IsValueShownAsLabel = False ' Mostrar valores nas barras

                    ' Itera por cada mês nos resultados das entradas e adiciona ao gráfico
                    For Each row As DataRow In dtEntradas.Rows
                        Dim mes As Integer = Convert.ToInt32(row("Mes"))
                        Dim valorEntrada As Decimal = Convert.ToDecimal(row("TotalEntradas"))

                        seriesEntradas.Points.AddXY(mes, valorEntrada)
                    Next

                    ' Itera por cada mês nos resultados das saídas e adiciona ao gráfico
                    For Each row As DataRow In dtSaidas.Rows
                        Dim mes As Integer = Convert.ToInt32(row("Mes"))
                        Dim valorSaida As Decimal = Convert.ToDecimal(row("TotalSaidas"))

                        seriesSaidas.Points.AddXY(mes, valorSaida)
                    Next

                    ' Adiciona as séries ao Chart
                    char_dif.Series.Add(seriesEntradas)
                    char_dif.Series.Add(seriesSaidas)

                    ' Adiciona título ao gráfico
                    char_dif.Titles.Add("Entradas e Saídas por Mês")

                    ' Adiciona legenda e posiciona à direita do gráfico
                    char_dif.Legends.Add(New Legend("Legenda"))
                    char_dif.Legends("Legenda").Docking = Docking.Right

                    ' Configurações adicionais para a aparência do gráfico
                    char_dif.ChartAreas(0).AxisX.Title = "Mês"
                    char_dif.ChartAreas(0).AxisY.Title = "Valor (R$)"
                    char_dif.ChartAreas(0).AxisX.Interval = 1 ' Intervalo entre os meses
                    char_dif.ChartAreas(0).AxisX.Minimum = 1 ' Mínimo do eixo X como o primeiro mês

                    ' Ajustes estéticos adicionais
                    char_dif.BackColor = Color.FromArgb(240, 240, 240) ' Cor de fundo do gráfico
                    char_dif.BorderlineColor = Color.DarkGray ' Cor da borda externa
                    char_dif.BorderlineDashStyle = ChartDashStyle.Solid
                    char_dif.BorderlineWidth = 2

                    ' Ajusta o tamanho e a fonte dos textos nos eixos X e Y
                    char_dif.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
                    char_dif.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)

                    Call fechar_conexao_banco()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                '====================================================================================='
                'pizza'
                Try
                    Call abrir_conexao_banco()


                    ' Consulta SQL para buscar os tipos de saída e contar suas ocorrências
                    Dim sqlDespesas As String = "SELECT categoria, COUNT(*) AS Quantidade FROM financeiro WHERE tipo = 'saida' GROUP BY categoria"
                    Dim cmdDespesas As New MySqlCommand(sqlDespesas, conn)
                    Dim daDespesas As New MySqlDataAdapter(cmdDespesas)
                    Dim dtDespesas As New DataTable()
                    daDespesas.Fill(dtDespesas)

                    ' Limpa as séries existentes no Chart
                    char_despesas.Series.Clear()

                    ' Criar o Chart de Pizza
                    char_despesas.Series.Add("Despesas")
                    char_despesas.Series("Despesas").ChartType = SeriesChartType.Pie
                    char_despesas.Series("Despesas").IsValueShownAsLabel = True ' Não mostrar valores nas fatias da pizza

                    ' Adicionar os dados ao gráfico de pizza
                    For Each row As DataRow In dtDespesas.Rows
                        Dim categoria As String = row("categoria").ToString()
                        Dim quantidade As Integer = Convert.ToInt32(row("Quantidade"))

                        char_despesas.Series("Despesas").Points.AddXY(categoria, quantidade)
                    Next

                    ' Configurações adicionais (opcional)
                    char_despesas.Titles.Add("Tipos de Saída - Despesas")
                    char_despesas.Legends.Add(New Legend("Legenda"))
                    char_despesas.Legends("Legenda").Docking = Docking.Bottom

                    Call fechar_conexao_banco()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Call fechar_conexao_banco()
        End Try
    End Sub

    'MÓDULO CLIENTES
    '============================================================================
    Private Sub btn_pesquisa_rapida_Click(sender As Object, e As EventArgs) Handles btn_pesquisa_rapida.Click
        Try
            If txt_cpf.MaskCompleted = False Then
                Throw New SystemException("Por favor, preencha o campo CPF.")
            Else
                Call abrir_conexao_banco()

                Dim sql As String = "SELECT nome, telefone, patologia, restricoes, examevalidade, situacao FROM tb_clientes WHERE cpf = @cpf_cliente"
                Dim cmd As New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@cpf_cliente", txt_cpf.Text)

                Dim resultado As MySqlDataReader = cmd.ExecuteReader()
                While resultado.Read
                    txt_nome.Text = resultado.Item("nome").ToString
                    txt_telefone.Text = resultado.Item("telefone").ToString
                    txt_patologia.Text = resultado.Item("patologia").ToString
                    txt_restricoes.Text = resultado.Item("restricoes").ToString
                    txt_validade_exame.Text = resultado.Item("examevalidade").ToString

                    If resultado.Item("situacao") = 1 Then
                        txt_situacao.Text = "REGULAR"
                    Else
                        txt_situacao.Text = "INADIMPLENTE"
                    End If
                End While

                If resultado Is Nothing Then
                    Throw New SystemException("Cliente não encontrado.")
                Else

                End If

                Call fechar_conexao_banco()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Call fechar_conexao_banco()
            Exit Sub
        End Try
    End Sub

    Private Sub btn_gerenciar_clientes_Click(sender As Object, e As EventArgs) Handles btn_gerenciar_clientes.Click
        Try
            cadastro_clientes.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_exibir_clientes_Click(sender As Object, e As EventArgs) Handles btn_exibir_clientes.Click
        Try
            relatorio_clientes.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        txt_cpf.Clear()
        txt_nome.Clear()
        txt_telefone.Clear()
        txt_patologia.Clear()
        txt_restricoes.Clear()
        txt_validade_exame.Clear()
        txt_situacao.Clear()
    End Sub

    Private Sub txt_situacao_DoubleClick(sender As Object, e As EventArgs) Handles txt_situacao.DoubleClick
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim cpf As String

        Try
            If txt_cpf.MaskCompleted = False Then
                Throw New System.Exception("Forneça um CPF para alterar a situação do professor")
            Else
                cpf = txt_cpf.Text

                resp = MsgBox("Gostaria de alterar a situação deste aluno?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")

                If resp = vbYes Then
                    Call abrir_conexao_banco()
                    'Verificando a atual situação do professor
                    If txt_situacao.Text = "REGULAR" Then
                        sql = "UPDATE tb_clientes SET situacao = 2 WHERE cpf = @cpf"
                        txt_situacao.Text = "INADIMPLENTE"
                    Else
                        sql = "UPDATE tb_clientes SET situacao = 1 WHERE cpf = @cpf"
                        txt_situacao.Text = "REGULAR"
                    End If

                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", cpf)

                    cmd.ExecuteNonQuery()

                    Call fechar_conexao_banco()

                    MsgBox("Situação alterada com sucesso!", MsgBoxStyle.Information, "Atenção")

                    lbl_contagem_clientes.Text = buscar_numero_alunos()
                    Call popular_dgv_clientes()
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try

    End Sub

    Private Sub btn_pagamentos_clientes_Click(sender As Object, e As EventArgs) Handles btn_pagamentos_clientes.Click
        cadastro_pagamentos_clientes.Show()
    End Sub
    '============================================================================

    'MÓDULO GERENCIAL
    '============================================================================
    Private Sub btn_gerenciar_funcionarios_Click(sender As Object, e As EventArgs) Handles btn_gerenciar_funcionarios.Click
        Try
            cadastro_professores.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_busca_rapida_professores_Click(sender As Object, e As EventArgs) Handles btn_busca_rapida_professores.Click
        If txt_cpf_professores.MaskCompleted = False Then
            Throw New System.Exception("Por favor, preencha o campo CPF")
        Else
            Dim sql As String
            Dim cmd As MySqlCommand
            Dim resultado As Object

            Dim cpf As String = txt_cpf_professores.Text

            Call abrir_conexao_banco()

            sql = "select tb_professores.nome, tb_professores.cref, tb_professores.telefone, tb_situacoes.nome, COUNT(tb_clientes.professor) as numero_alunos
                    from tb_professores
                    inner join tb_situacoes on tb_professores.situacao = tb_situacoes.codigo
                    inner join tb_clientes on tb_professores.codigo = tb_clientes.professor
                    where tb_professores.cpf = @cpf"

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@cpf", cpf)

            resultado = cmd.ExecuteReader()

            If resultado Is Nothing Then
                Throw New System.Exception("Professor não encontrado")
            Else
                While resultado.read()
                    txt_nome_professores.Text = resultado(0)
                    txt_cref_professores.Text = resultado(1)
                    txt_telefone_professores.Text = resultado(2)
                    txt_situacao_professores.Text = resultado(3)
                    txt_cont_alunos_supervisionados.Text = resultado(4)
                End While
            End If

            Call fechar_conexao_banco()
        End If
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Call fechar_conexao_banco()
        End Try
    End Sub

    Private Sub txt_cpf_professores_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf_professores.DoubleClick
        Try
            txt_cpf_professores.Clear()
            txt_nome_professores.Clear()
            txt_cref_professores.Clear()
            txt_telefone_professores.Clear()
            txt_situacao_professores.Clear()
            txt_cont_alunos_supervisionados.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Call fechar_conexao_banco()
        End Try
    End Sub

    Private Sub btn_gerenciar_planos_Click(sender As Object, e As EventArgs) Handles btn_gerenciar_planos.Click
        Try
            cadastro_planos.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btn_registrar_pagamento_Click(sender As Object, e As EventArgs) Handles btn_registrar_pagamento.Click
        Try
            cadastro_pagamentos.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub


    Private Sub txt_situacao_professores_DoubleClick(sender As Object, e As EventArgs) Handles txt_situacao_professores.DoubleClick
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim cpf As String

        If txt_cpf_professores.MaskCompleted = False Then
            Throw New System.Exception("Forneça um CPF para alterar a situação do professor")
        Else
            cpf = txt_cpf_professores.Text

            resp = MsgBox("Gostaria de alterar a situação deste professor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")

            If resp = vbYes Then
                Call abrir_conexao_banco()
                'Verificando se o professor possui algum aluno supervisionado
                If CInt(txt_cont_alunos_supervisionados.Text) > 0 Then
                    Throw New System.Exception("Por favor, atribua um novo professor aos alunos supervisionados por este antes de desligá-lo.")
                Else

                    'Verificando a atual situação do professor
                    If txt_situacao_professores.Text = "ATIVO" Then
                        sql = "UPDATE tb_professores SET situacao = 4 WHERE cpf = @cpf"
                        txt_situacao_professores.Text = "DESLIGADO"
                    Else
                        sql = "UPDATE tb_professores SET situacao = 3 WHERE cpf = @cpf"
                        txt_situacao_professores.Text = "ATIVO"
                    End If

                    cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", cpf)

                    cmd.ExecuteNonQuery()

                    Call fechar_conexao_banco()

                    MsgBox("Situação alterada com sucesso!", MsgBoxStyle.Information, "Atenção")

                    Call popular_dgv_professores()
                    lbl_contagem_professores.Text = buscar_numero_professores()
                End If
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btn_relatorio_Click(sender As Object, e As EventArgs) Handles btn_relatorio.Click
        relatorio_professores.Show()
    End Sub

    Private Sub btn_adicionar_lancamento_Click(sender As Object, e As EventArgs) Handles btn_adicionar_lancamento.Click
        cadastro_financeiro.Show()
    End Sub

    Private Sub pic_sair_Click(sender As Object, e As EventArgs) Handles pic_sair.Click
        acessoGerente = False
        login.Show()
        Me.Close()
    End Sub

    Private Sub btn_pesquisar_Click(sender As Object, e As EventArgs) Handles btn_pesquisar.Click

        Try
            Dim conexao As String = "server=localhost;userid=root;password='';database=db_herculespro"

            Dim cpf As String = txt_cpfAluno.Text.Trim()

            ' Verifica se o campo de texto do CPF não está vazio
            If Not String.IsNullOrEmpty(cpf) Then
                Dim query As String = "SELECT tipo_treino, professor FROM tb_treino WHERE cpf_aluno = @CPFAluno"

                Using connection As New MySqlConnection(conexao)
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@CPFAluno", cpf)

                        Try
                            connection.Open()
                            Dim reader As MySqlDataReader = command.ExecuteReader()

                            If reader.Read() Then
                                lbl_tipoTreino.Text = reader.GetString("tipo_treino")
                                lbl_profResponsavel.Text = reader.GetString("professor")
                            Else
                                lbl_tipoTreino.Text = "Tipo de treino não encontrado para este CPF."
                                lbl_profResponsavel.Text = ""
                            End If

                            reader.Close()
                        Catch ex As Exception
                            MessageBox.Show("Erro ao pesquisar tipo de treino: " & ex.Message)
                        Finally
                            connection.Close()
                        End Try
                    End Using
                End Using
            Else
                MessageBox.Show("Por favor, insira um CPF.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btn_adicionarTreino_Click(sender As Object, e As EventArgs) Handles btn_adicionarTreino.Click
        Try
            Dim conexao As String = "server=localhost;userid=root;password='';database=db_herculespro"

            Dim cpf As String = txt_cpfAdicionar.Text.Trim()
            Dim tipoTreino As String = cmb_tipoTreinoAdicionar.SelectedItem.ToString()
            Dim professor As String = cmb_professor.SelectedItem.ToString()

            ' Verifica se o campo de texto do CPF não está vazio
            If Not String.IsNullOrEmpty(cpf) Then
                Dim queryVerificaExistencia As String = "SELECT COUNT(*) FROM tb_treino WHERE cpf_aluno = @CPFAluno"

                Using connection As New MySqlConnection(conexao)
                    Using commandVerificaExistencia As New MySqlCommand(queryVerificaExistencia, connection)
                        commandVerificaExistencia.Parameters.AddWithValue("@CPFAluno", cpf)

                        Try
                            connection.Open()
                            Dim count As Integer = Convert.ToInt32(commandVerificaExistencia.ExecuteScalar())

                            If count > 0 Then
                                MessageBox.Show("Este CPF já possui treino.")
                            Else
                                ' Adiciona os dados à tabela
                                Dim queryAdicionar As String = "INSERT INTO tb_treino (cpf_aluno, tipo_treino, professor) VALUES (@CPFAluno, @TipoTreino, @Professor)"

                                Using commandAdicionar As New MySqlCommand(queryAdicionar, connection)
                                    commandAdicionar.Parameters.AddWithValue("@CPFAluno", cpf)
                                    commandAdicionar.Parameters.AddWithValue("@TipoTreino", tipoTreino)
                                    commandAdicionar.Parameters.AddWithValue("@Professor", professor)

                                    commandAdicionar.ExecuteNonQuery()
                                    MessageBox.Show("Treino adicionado com sucesso para o CPF " & cpf)
                                End Using
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Erro ao adicionar treino: " & ex.Message)
                        End Try
                    End Using
                End Using
            Else
                MessageBox.Show("Por favor, insira um CPF.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btn_alterarTreino_Click(sender As Object, e As EventArgs) Handles btn_alterarTreino.Click
        Try
            Dim conexao As String = "server=localhost;userid=root;password='';database=db_herculespro"

            Dim cpf As String = txt_cpfAlterar.Text.Trim()
            Dim tipoTreino As String = cmb_tipoTreinoAlterar.SelectedItem.ToString()
            Dim professor As String = cmb_professorAlterar.SelectedItem.ToString()

            ' Verifica se o campo de texto do CPF não está vazio
            If Not String.IsNullOrEmpty(cpf) Then
                Dim queryVerificaExistencia As String = "SELECT COUNT(*) FROM tb_treino WHERE cpf_aluno = @CPFAluno"

                Using connection As New MySqlConnection(conexao)
                    Using commandVerificaExistencia As New MySqlCommand(queryVerificaExistencia, connection)
                        commandVerificaExistencia.Parameters.AddWithValue("@CPFAluno", cpf)

                        Try
                            connection.Open()
                            Dim count As Integer = Convert.ToInt32(commandVerificaExistencia.ExecuteScalar())

                            If count = 0 Then
                                MessageBox.Show("Este CPF não possui treino.")
                            Else
                                ' Altera os dados na tabela
                                Dim queryAlterar As String = "UPDATE tb_treino SET tipo_treino = @TipoTreino, professor = @Professor WHERE cpf_aluno = @CPFAluno"

                                Using commandAlterar As New MySqlCommand(queryAlterar, connection)
                                    commandAlterar.Parameters.AddWithValue("@CPFAluno", cpf)
                                    commandAlterar.Parameters.AddWithValue("@TipoTreino", tipoTreino)
                                    commandAlterar.Parameters.AddWithValue("@Professor", professor)

                                    commandAlterar.ExecuteNonQuery()
                                    MessageBox.Show("Treino alterado com sucesso para o CPF " & cpf)
                                End Using
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Erro ao alterar treino: " & ex.Message)
                        End Try
                    End Using
                End Using
            Else
                MessageBox.Show("Por favor, insira um CPF.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try

    End Sub

End Class
'============================================================================
