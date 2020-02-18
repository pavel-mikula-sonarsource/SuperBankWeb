
Imports SuperBankWeb.Models
Imports System.Data.SqlClient

Public Class HomeController
    Inherits Controller

    Function Index(Page As String) As ActionResult
        Dim Data As Article
        Using RD As SqlDataReader = ExecuteReader("SELECT ID, Title, Text FROM Article WHERE Page='" & Page & "' AND Active=1")
            If RD.Read Then
                Data = New Article(RD.GetString(1), RD.GetString(2))
            Else
                Data = New Article("Error", "Page " & Page & " not found.")
            End If
        End Using
        Return View(Data)
    End Function

    Function Download(File As String) As ActionResult
        Dim Path As String = Server.MapPath("~/App_Data/" & File)
        If IO.File.Exists(Path) Then
            Return New FilePathResult(Path, "application/pdf")
        Else
            Return View("Index", New Article("Download", "File not found."))
        End If
    End Function

    Private Function ExecuteReader(Command As String, ParamArray Params() As SqlParameter) As SqlDataReader
        Dim Conn As New SqlConnection(ConfigurationManager.ConnectionStrings("Default").ConnectionString)
        Using Cmd As New SqlCommand(Command, Conn)
            Conn.Open()
            Cmd.Parameters.AddRange(Params)
            Return Cmd.ExecuteReader(CommandBehavior.CloseConnection)
        End Using
    End Function

End Class
