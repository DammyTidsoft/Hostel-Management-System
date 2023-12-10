Module General
    Public conn As New ADODB.Connection
    Public sql As String
    Public rs, rss As New ADODB.Recordset
    Public admission_no As Integer
    Public view_student As Boolean = False
    Public visitor_name, vdate, sname, comp, dat, stat
    Public visitor As Boolean = False
    Public complaint As Boolean = False
    Public abc As String
    Public Function OpenDB()
        Try


            If Conn.State = 1 Then Conn.Close()
            conn.Open("Provider=SQLOLEDB.1;Persist Security Info=False;user id=sa;password=q1w2e3r4/;Initial Catalog=hostel1;Data Source=SHARUN-PC")
            Return (0)
        Catch ex As Exception
            MsgBox("Database is not connected ..... Please Check Your Network Connection", MsgBoxStyle.Critical)
            End
        End Try
    End Function
End Module
