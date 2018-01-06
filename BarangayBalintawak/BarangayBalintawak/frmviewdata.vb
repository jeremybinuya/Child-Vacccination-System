Public Class frmviewdata
    Dim SQL As New SQLControl

    Private Sub CurrentDataDGV()
        If SQL.HasConnection = True Then
            SQL.ExecuteQuery("Select *from tbl_mstrlistchildren")

            If SQL.SQLDataSet.Tables.Count > 0 Then
                dgvData.DataSource = SQL.SQLDataSet.Tables(0)
            End If


            With dgvData
                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(2).Visible = False
                .Columns(3).Visible = False
                .Columns(4).Visible = False
                .Columns(5).Width = 10
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(6).Width = 20
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(7).Visible = False
                .Columns(8).Width = 175
                .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With
        End If
    End Sub

    Private Sub frmviewdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentDataDGV()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If dgvData.Rows.Count > 0 Then
                If MsgBox("Do you want to delete " & dgvData.CurrentRow.Cells(5).Value & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    SQL.DataDelete("DELETE FROM tbl_mstrlistchildren WHERE childnumber ='" & dgvData.CurrentRow.Cells(0).Value & " '")
                    SQL.DataDateDelete("DELETE FROM tbl_dates WHERE childnumber ='" & dgvData.CurrentRow.Cells(0).Value & " '")
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        CurrentDataDGV()
        btnmodify.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub btnmodify_Click(sender As Object, e As EventArgs) Handles btnmodify.Click
        If Label3.Text = "OK" Then

            With frmaddchild
                .Show()
                .txtnameRHUBHS.ReadOnly = True
                .txtnamebrgy.ReadOnly = True
                .cmbpurok.Enabled = False
                .txtcname.ReadOnly = True
                .txtcage.ReadOnly = True
                .txtcmother.ReadOnly = True
                .txtcpurok.ReadOnly = True



                If dgvData.Rows.Count > 0 Then
                    .txtcnumber.Text = dgvData.CurrentRow.Cells(0).Value
                    .txtnameRHUBHS.Text = dgvData.CurrentRow.Cells(1).Value
                    .txtnamebrgy.Text = dgvData.CurrentRow.Cells(2).Value
                    .cmbpurok.Text = dgvData.CurrentRow.Cells(3).Value
                    .dtpbday.Text = dgvData.CurrentRow.Cells(4).Value
                    .txtcname.Text = dgvData.CurrentRow.Cells(5).Value
                    .txtcage.Text = dgvData.CurrentRow.Cells(6).Value
                    .txtcmother.Text = dgvData.CurrentRow.Cells(8).Value
                    .txtcpurok.Text = dgvData.CurrentRow.Cells(9).Value
                End If
            End With

        End If
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        btnmodify.Enabled = True
        btndelete.Enabled = True
    End Sub

    Private Sub btbprofile_Click(sender As Object, e As EventArgs) Handles btbprofile.Click
        With frmprofile
            .Show()

            If dgvData.Rows.Count > 0 Then
                .lblnameRHUBHS.Text = dgvData.CurrentRow.Cells(1).Value
                .lblnbrgy.Text = dgvData.CurrentRow.Cells(2).Value
                .lblnpurok.Text = dgvData.CurrentRow.Cells(3).Value
                .lblbday.Text = dgvData.CurrentRow.Cells(4).Value
                .lblcname.Text = dgvData.CurrentRow.Cells(5).Value
                .lblcage.Text = dgvData.CurrentRow.Cells(6).Value
                .lblcmother.Text = dgvData.CurrentRow.Cells(8).Value
                .lblcpurok.Text = dgvData.CurrentRow.Cells(9).Value
            End If
        End With


    End Sub
End Class