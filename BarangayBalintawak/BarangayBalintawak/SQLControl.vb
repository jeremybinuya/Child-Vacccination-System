Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLControl
    Public SQLConn As New SqlConnection With {.ConnectionString = "Server=JEREMY\SQLEXPRESS;Database=Barangay_Data;Trusted_Connection=Yes;"}
    Public SQLcmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataSet As DataSet
    Public SQLDR As SqlDataReader
    Dim SQLCommand As New SqlCommand

    'Connection to SQL
    Public Function HasConnection() As Boolean
        Try
            SQLConn.Open()


            SQLConn.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)

            Return False
        End Try
    End Function

    Public Sub ExecuteQuery(Query As String)
        Try
            SQLConn.Open()

            'Create Command
            SQLcmd = New SqlCommand(Query, SQLConn)

            'Load sql record for data grid
            SQLDA = New SqlDataAdapter(SQLcmd)
            SQLDataSet = New DataSet
            SQLDA.Fill(SQLDataSet)

            SQLConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

            If SQLConn.State = ConnectionState.Open Then
                SQLConn.Close()
            End If
        End Try
    End Sub

    'Add Admin User 
    Public Sub AddUser(username As String, password As String, firstname As String, middlename As String, lastname As String, birthday As String, gender As String, scode As String, position As String)
        Try
            Dim datainsert As String = "Insert into tbl_admin (username,password,firstname,middlename,lastname,
                                        birthday,gender,securitycode,position)Values(" &
                                        "'" & username & "'," &
                                        "CONVERT(NVARCHAR(50),HashBytes('MD5','" & password & "'),2)," &
                                        "'" & firstname & "'," &
                                        "'" & middlename & "'," &
                                        "'" & lastname & "'," &
                                        "'" & birthday & "'," &
                                        "'" & gender & "'," &
                                        "'" & scode & "'," &
                                        "'" & position & "')"
            MsgBox("Data Add Successfully")
            SQLConn.Open()
            SQLcmd = New SqlCommand(datainsert, SQLConn)
            SQLcmd.ExecuteNonQuery()

            SQLConn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Add Children
    Public Sub AddChildInfo(nameRHU As String, namebrgy As String, namepurok As String, datecompletion As String,
                        childname As String, childage As String, dateofbirth As String, nameofmother As String, address As String)
        Try
            Dim addchild As String = "Insert into tbl_mstrlistchildren(nameRHU,namebrgy,namepurok,datecompletion,
                                      childname,childage,dateofbirth,nameofmother,address)Values(" &
                                      "'" & nameRHU & "'," &
                                      "'" & namebrgy & "'," &
                                      "'" & namepurok & "'," &
                                      "'" & datecompletion & "'," &
                                      "'" & childname & "'," &
                                      "'" & childage & "'," &
                                      "'" & dateofbirth & "'," &
                                      "'" & nameofmother & "'," &
                                      "'" & address & "')"
            MsgBox("Data Add Successfully")
            SQLConn.Open()
            SQLcmd = New SqlCommand(addchild, SQLConn)
            SQLcmd.ExecuteNonQuery()

            SQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Add Ok or Not OK
    Public Sub ChildOknotok(childname As String, BCG As String, HepB_BD As String, fPenta As String, sPenta As String, tPenta As String, fOPV As String,
                        sOPV As String, tOPV As String, IPV As String, fMVC As String, sMVC As String, TT As String, sTT As String)
        Try
            Dim addchild As String = "Insert into tbl_checkvaccine (childname,BCG,[HepB BD],fPenta,sPenta,tPenta,fOPV,
                                      sOPV,tOPV,IPV,fMVC,sMVC,TT,sTT)Values(" &
                                      "'" & childname & "'," &
                                      "'" & BCG & "'," &
                                      "'" & HepB_BD & "'," &
                                      "'" & fPenta & "'," &
                                      "'" & sPenta & "'," &
                                      "'" & tPenta & "'," &
                                      "'" & fOPV & "'," &
                                      "'" & sOPV & "'," &
                                      "'" & tOPV & "'," &
                                      "'" & IPV & "'," &
                                      "'" & fMVC & "'," &
                                      "'" & sMVC & "'," &
                                      "'" & TT & "'," &
                                      "'" & sTT & "')"
            SQLConn.Open()
            SQLcmd = New SqlCommand(addchild, SQLConn)
            SQLcmd.ExecuteNonQuery()

            SQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Add Date of Vaccine   
    Public Sub AddDates(childname As String, BCG As String, HepB_BD As String, fPenta As String, sPenta As String, tPenta As String, fOPV As String,
                        sOPV As String, tOPV As String, IPV As String, fMVC As String, sMVC As String, TT As String, sTT As String)
        Try
            Dim adddate As String = "Insert into tbl_dates(childname,BCG,[HepB BD],fPenta,sPenta,tPenta,fOPV,
                                      sOPV,tOPV,IPV,fMVC,sMVC,TT,sTT)Values(" &
                                     "'" & childname & "'," &
                                     "'" & BCG & "'," &
                                     "'" & HepB_BD & "'," &
                                     "'" & fPenta & "'," &
                                     "'" & sPenta & "'," &
                                     "'" & tPenta & "'," &
                                     "'" & fOPV & "'," &
                                     "'" & sOPV & "'," &
                                     "'" & tOPV & "'," &
                                     "'" & IPV & "'," &
                                     "'" & fMVC & "'," &
                                     "'" & sMVC & "'," &
                                     "'" & TT & "'," &
                                     "'" & sTT & "')"
            SQLConn.Open()
            SQLcmd = New SqlCommand(adddate, SQLConn)
            SQLcmd.ExecuteNonQuery()

            SQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Delete Children
    Public Sub DataDelete(Command As String)
        Try
            SQLConn.Open()
            SQLcmd = New SqlCommand(Command, SQLConn)

            Dim ChangeCount As Integer = SQLcmd.ExecuteNonQuery

            SQLConn.Close()

            'Report results
            If ChangeCount = 0 Then
                MsgBox("Empty Record")

            Else
                MsgBox(ChangeCount & " Record Deleted")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Delete Data Vaccine
    Public Sub DataDateDelete(Command As String)
        Try
            SQLConn.Open()
            SQLcmd = New SqlCommand(Command, SQLConn)

            Dim ChangeCount As Integer = SQLcmd.ExecuteNonQuery

            SQLConn.Close()

            'Report results
            If ChangeCount = 0 Then
                MsgBox("Empty Record")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Delete Data OK/NOT OK
    Public Sub DataOKNOTOKDelete(Command As String)
        Try
            SQLConn.Open()
            SQLcmd = New SqlCommand(Command, SQLConn)

            Dim ChangeCount As Integer = SQLcmd.ExecuteNonQuery

            SQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Add Date of Vaccine for Children
    Public Function ChildAddDate(Command2 As String) As Integer
        Try
            SQLConn.Open()
            SQLcmd = New SqlCommand(Command2, SQLConn)

            Dim ChangeCount2 As Integer = SQLcmd.ExecuteNonQuery

            SQLConn.Close()

            Return ChangeCount2

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return 0
    End Function

    'Add Ok or Not OK
    Public Function AddOkNotOk(Command2 As String) As Integer
        Try
            SQLConn.Open()
            SQLcmd = New SqlCommand(Command2, SQLConn)

            Dim ChangeCount2 As Integer = SQLcmd.ExecuteNonQuery

            SQLConn.Close()

            Return ChangeCount2

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return 0
    End Function

    'Update child date completion
    Public Function ChildDateCompletion(Command2 As String) As Integer
        Try
            SQLConn.Open()
            SQLcmd = New SqlCommand(Command2, SQLConn)

            Dim ChangeCount2 As Integer = SQLcmd.ExecuteNonQuery

            SQLConn.Close()

            Return ChangeCount2

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return 0
    End Function

    'Search for names
    Public Sub FilterData(ByVal valuetoSearch As String)
        Dim searchQuery As String = "SELECT * from tbl_mstrlistchildren where Concat(childname,nameofmother) like '%" & valuetoSearch & "%'"

        Dim SQLcmd As New SqlCommand(searchQuery, SQLConn)
        Dim SQLAdapater As New SqlDataAdapter(SQLcmd)
        Dim SQLtable As New DataTable()

        SQLAdapater.Fill(SQLtable)
        frmaddchild.dgvData.DataSource = SQLtable
    End Sub

    'UpdatePassword
    Public Function UpdatePassword(Command2 As String) As Integer
        Try
            SQLConn.Open()
            SQLcmd = New SqlCommand(Command2, SQLConn)

            Dim ChangeCount2 As Integer = SQLcmd.ExecuteNonQuery

            SQLConn.Close()

            Return ChangeCount2

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return 0
    End Function

    Public Sub SummaryBCG(ByVal valuetoSearch As String)
        Dim searchQuery As String = "SELECT childname as Name, BCG as BCG from tbl_dates where BCG like '%" & valuetoSearch & "%'"

        Dim SQLcmd As New SqlCommand(searchQuery, SQLConn)
        Dim SQLAdapater As New SqlDataAdapter(SQLcmd)
        Dim SQLtable As New DataTable()

        SQLAdapater.Fill(SQLtable)
        frmsummary.dgvData.DataSource = SQLtable
    End Sub

    Public Sub SummaryHepBBD(ByVal valuetoSearch As String)
        Dim searchQuery As String = "SELECT childname as Name, [HepB BD] as HepBBD from tbl_dates where [HepB BD] like '%" & valuetoSearch & "%'"

        Dim SQLcmd As New SqlCommand(searchQuery, SQLConn)
        Dim SQLAdapater As New SqlDataAdapter(SQLcmd)
        Dim SQLtable As New DataTable()

        SQLAdapater.Fill(SQLtable)
        frmsummary.dgvData.DataSource = SQLtable
    End Sub

    Public Sub SummaryPenta1(ByVal valuetoSearch As String)
        Dim searchQuery As String = "SELECT childname as Name, fPenta as [Penta 1] from tbl_dates where fPenta like '%" & valuetoSearch & "%'"

        Dim SQLcmd As New SqlCommand(searchQuery, SQLConn)
        Dim SQLAdapater As New SqlDataAdapter(SQLcmd)
        Dim SQLtable As New DataTable()

        SQLAdapater.Fill(SQLtable)
        frmsummary.dgvData.DataSource = SQLtable
    End Sub

    Public Sub SummaryPenta2(ByVal valuetoSearch As String)
        Dim searchQuery As String = "SELECT childname as Name, sPenta as [Penta 2] from tbl_dates where sPenta like '%" & valuetoSearch & "%'"

        Dim SQLcmd As New SqlCommand(searchQuery, SQLConn)
        Dim SQLAdapater As New SqlDataAdapter(SQLcmd)
        Dim SQLtable As New DataTable()

        SQLAdapater.Fill(SQLtable)
        frmsummary.dgvData.DataSource = SQLtable
    End Sub

    Public Sub SummaryPenta3(ByVal valuetoSearch As String)
        Dim searchQuery As String = "SELECT childname as Name, tPenta as [Penta 3] from tbl_dates where tPenta like '%" & valuetoSearch & "%'"

        Dim SQLcmd As New SqlCommand(searchQuery, SQLConn)
        Dim SQLAdapater As New SqlDataAdapter(SQLcmd)
        Dim SQLtable As New DataTable()

        SQLAdapater.Fill(SQLtable)
        frmsummary.dgvData.DataSource = SQLtable
    End Sub

    Public Sub SummaryOPV1(ByVal valuetoSearch As String)
        Dim searchQuery As String = "SELECT childname as Name, fOPV as [OPV 1] from tbl_dates where fOPV like '%" & valuetoSearch & "%'"

        Dim SQLcmd As New SqlCommand(searchQuery, SQLConn)
        Dim SQLAdapater As New SqlDataAdapter(SQLcmd)
        Dim SQLtable As New DataTable()

        SQLAdapater.Fill(SQLtable)
        frmsummary.dgvData.DataSource = SQLtable
    End Sub

    Public Sub SummaryOPV2(ByVal valuetoSearch As String)
        Dim searchQuery As String = "SELECT childname as Name, sOPV as [OPV 2] from tbl_dates where sOPV like '%" & valuetoSearch & "%'"

        Dim SQLcmd As New SqlCommand(searchQuery, SQLConn)
        Dim SQLAdapater As New SqlDataAdapter(SQLcmd)
        Dim SQLtable As New DataTable()

        SQLAdapater.Fill(SQLtable)
        frmsummary.dgvData.DataSource = SQLtable
    End Sub

    Public Sub SummaryOPV3(ByVal valuetoSearch As String)
        Dim searchQuery As String = "SELECT childname as Name, tOPV as [OPV 3] from tbl_dates where tOPV like '%" & valuetoSearch & "%'"

        Dim SQLcmd As New SqlCommand(searchQuery, SQLConn)
        Dim SQLAdapater As New SqlDataAdapter(SQLcmd)
        Dim SQLtable As New DataTable()

        SQLAdapater.Fill(SQLtable)
        frmsummary.dgvData.DataSource = SQLtable
    End Sub

    Public Sub SummaryIPV(ByVal valuetoSearch As String)
        Dim searchQuery As String = "SELECT childname as Name, IPV as [IPV] from tbl_dates where IPV like '%" & valuetoSearch & "%'"

        Dim SQLcmd As New SqlCommand(searchQuery, SQLConn)
        Dim SQLAdapater As New SqlDataAdapter(SQLcmd)
        Dim SQLtable As New DataTable()

        SQLAdapater.Fill(SQLtable)
        frmsummary.dgvData.DataSource = SQLtable
    End Sub

    Public Sub SummaryMVC1(ByVal valuetoSearch As String)
        Dim searchQuery As String = "SELECT childname as Name, fMVC as [MVC 1] from tbl_dates where fMVC like '%" & valuetoSearch & "%'"

        Dim SQLcmd As New SqlCommand(searchQuery, SQLConn)
        Dim SQLAdapater As New SqlDataAdapter(SQLcmd)
        Dim SQLtable As New DataTable()

        SQLAdapater.Fill(SQLtable)
        frmsummary.dgvData.DataSource = SQLtable
    End Sub

    Public Sub SummaryMVC2(ByVal valuetoSearch As String)
        Dim searchQuery As String = "SELECT childname as Name, sMVC as [MVC 2] from tbl_dates where sMVC like '%" & valuetoSearch & "%'"

        Dim SQLcmd As New SqlCommand(searchQuery, SQLConn)
        Dim SQLAdapater As New SqlDataAdapter(SQLcmd)
        Dim SQLtable As New DataTable()

        SQLAdapater.Fill(SQLtable)
        frmsummary.dgvData.DataSource = SQLtable
    End Sub


End Class
