Public Class frmsummary
    Dim SQL As New SQLControl

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If cbvaccinces.Text = "BCG" Then
            SQL.SummaryBCG(dtpdate.Text)
        ElseIf cbvaccinces.Text = "HepB BD" Then
            SQL.SummaryHepBBD(dtpdate.Text)
        ElseIf cbvaccinces.Text = "Penta 1" Then
            SQL.SummaryPenta1(dtpdate.Text)
        ElseIf cbvaccinces.Text = "Penta 2" Then
            SQL.SummaryPenta2(dtpdate.Text)
        ElseIf cbvaccinces.Text = "Penta 3" Then
            SQL.SummaryPenta3(dtpdate.Text)
        ElseIf cbvaccinces.Text = "OPV 1" Then
            SQL.SummaryOPV1(dtpdate.Text)
        ElseIf cbvaccinces.Text = "OPV 2" Then
            SQL.SummaryOPV2(dtpdate.Text)
        ElseIf cbvaccinces.Text = "OPV 3" Then
            SQL.SummaryOPV3(dtpdate.Text)
        ElseIf cbvaccinces.Text = "IPV" Then
            SQL.SummaryIPV(dtpdate.Text)
        ElseIf cbvaccinces.Text = "MVC 1" Then
            SQL.SummaryMVC1(dtpdate.Text)
        ElseIf cbvaccinces.Text = "MVC 2" Then
            SQL.SummaryMVC2(dtpdate.Text)
        End If
    End Sub


End Class