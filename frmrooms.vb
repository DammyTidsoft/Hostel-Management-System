Public Class frmrooms
    Public i As Integer = 0
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtroom.Text = "" Or txtcap.Text = "" Then
            MsgBox("Enter the Details", MsgBoxStyle.Information)
        Else
            sql = "select * from tbl_room where Room_no='" & txtroom.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                sql = "update tbl_room set capacity='" & txtcap.Text & "' where Room_no='" & txtroom.Text & "'"
                conn.Execute(sql)
                MsgBox("Room Updated sucessfully", MsgBoxStyle.Information)
            Else
                sql = "insert into tbl_room(Room_no,capacity)values('" & txtroom.Text & "','" & txtcap.Text & "')"
                conn.Execute(sql)
                MsgBox("Room added sucessfully", MsgBoxStyle.Information)
            End If
            txtroom.Clear()
            txtcap.Text = 4
            rooms()
        End If
    End Sub

    Private Sub frmrooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        rooms()
        rno()

    End Sub
    Sub rooms()
        i = 0
        dgvroom.Rows.Clear()
        sql = "select room_no,capacity from tbl_room"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            dgvroom.Rows.Add()
            dgvroom.Item(0, i).Value = rs(0).Value
            dgvroom.Item(1, i).Value = rs(1).Value
            i = i + 1
            rs.MoveNext()
        Loop
    End Sub

    Private Sub dgvroom_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvroom.DoubleClick
        txtroom.Text = dgvroom.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If MsgBoxResult.No = MsgBox("do you want to delete the Room ?", MsgBoxStyle.YesNo) Then Exit Sub
        sql = "delete from tbl_room where room_no='" & txtroom.Text & "'"
        conn.Execute(sql)
        MsgBox("Room deleted sucessfully", MsgBoxStyle.Information)
        txtroom.Clear()
        rooms()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Sub rno()
        Dim j
        j = 1
        txtroom.Text = j
        sql = "select max(room_no) from tbl_room"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)



        If rs.EOF = False Then
            j = rs(0).Value
            j = j + 1
            txtroom.Text = j
        End If

    End Sub

    Private Sub txtcap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcap.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        Else
            If Len(txtcap.Text) < 25 Or Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class