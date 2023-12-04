Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Namespace My
    ' Os seguintes eventos estão disponíveis para MyApplication:
    ' Inicialização: Ocorre quando o aplicativo é iniciado, antes da criação do formulário de inicialização.
    ' Desligamento: Ocorre após todos os formulários de aplicativo serem fechados.  Esse evento não ocorrerá se o aplicativo for encerrado de forma anormal.
    ' UnhandledException: Ocorre se o aplicativo encontra uma exceção sem tratamento.
    ' StartupNextInstance: Ocorre durante a inicialização de um aplicativo de instância única quando o aplicativo já está ativo. 
    ' NetworkAvailabilityChanged: Ocorre quando a conexão de rede é conectada ou desconectada.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Try
                'Define o nível de permissão gerencial como falso
                acessoGerente = False

                'Abre a conexão com banco de dados
                Call abrir_conexao_banco()

                Dim sql As String = "SELECT codigo FROM tb_gerentes WHERE cargo = @cargo_gerente"
                Dim cmd As New MySqlCommand(sql, conn)
                Dim resultado As Object

                cmd.Parameters.AddWithValue("@cargo_gerente", 1)

                'Executa o comando
                resultado = cmd.ExecuteScalar()

                'Verifica se há algum gerente já cadastrado 
                If resultado Is Nothing Then
                    Form1.ShowDialog()
                End If
                Call fechar_conexao_banco()
            Catch ex As Exception
                MsgBox("Erro de Inicialização", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
                Call fechar_conexao_banco()
            End Try
        End Sub
    End Class
End Namespace
