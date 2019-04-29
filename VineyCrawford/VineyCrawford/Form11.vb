Public Class frnmenu
    Private Sub btnstock_Click(sender As Object, e As EventArgs) Handles btnstock.Click
        frmpurchacestock.Show()
    End Sub

    Private Sub btnaddsupplier_Click(sender As Object, e As EventArgs) Handles btnaddsupplier.Click
        frmaddsupplier.Show()
    End Sub

    Private Sub btncash_Click(sender As Object, e As EventArgs) Handles btncash.Click
        frmcashtran.Show()
    End Sub

    Private Sub btncredit_Click(sender As Object, e As EventArgs) Handles btncredit.Click
        frmcredittran.Show()
    End Sub

    Private Sub btnaddcustomer_Click(sender As Object, e As EventArgs) Handles btnaddcustomer.Click
        frmaddcustomer.Show()
    End Sub

    Private Sub btncashsalr_Click(sender As Object, e As EventArgs) Handles btncashsalr.Click
        frmcashsale.Show()
    End Sub

    Private Sub btncreditsale_Click(sender As Object, e As EventArgs) Handles btncreditsale.Click
        frmcreditsale.Show()
    End Sub

    Private Sub btncashrefund_Click(sender As Object, e As EventArgs) Handles btncashrefund.Click
        frmcashrefund.Show()
    End Sub

    Private Sub btncreditnote_Click(sender As Object, e As EventArgs) Handles btncreditnote.Click
        frmcreditnote.Show()
    End Sub

    Private Sub btnaddpart_Click(sender As Object, e As EventArgs) Handles btnaddpart.Click
        frmaddparts.Show()
    End Sub
End Class