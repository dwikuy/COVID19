Imports MySql.Data.MySqlClient
Module Module1
    Public cn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String
    Sub con()
        Dim url, server, user, password, database As String
        server = "localhost"
        user = "root"
        password = "asdfasdf"
        database = "covid19"
        url = "Data Source=" & server & "; user id=" & user & "; password=" & password & "; database=" & database
        cn = New MySqlConnection(url)
    End Sub
End Module
