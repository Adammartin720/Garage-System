Imports System.Data.SqlClient
Public Class frmcashrefund
    Dim dbSource As String
    Dim sql As String
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim rdr As SqlDataReader
    Dim dt As New DataTable
    Private Sub Frmcashrefund_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbSource = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VineyCraw;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        Try
            sql = "SELECT CashSale_Num FROM CashSale"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                cbocashnum.Items.Add(rdr("CashSale_Num").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error While retrieving records from table...",
                            "Read Record Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cbocashnum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocashnum.SelectedIndexChanged
        If cbocashnum.SelectedIndex <> -1 Then
            Try
                sql = "SELECT * FROM CashSale WHERE CashSale_Num = @CashSale"

                cmd.Parameters.Add("@CashSale", SqlDbType.VarChar).Value = cbocashnum.SelectedItem.ToString
                cmd.CommandText = sql
                cmd.Connection = con
                con.ConnectionString = dbSource
                con.Open()
                rdr = cmd.ExecuteReader
                While rdr.Read
                    txtcustid.Text = rdr("CashCustomer_Id").ToString
                    txtcustname.Text = rdr("Customer_Name").ToString
                    txtcustaddress.Text = rdr("Customer_Address").ToString
                    txtcustphone.Text = rdr("Customer_Phone").ToString
                    txtpartnum.Text = rdr("Part_Num").ToString
                    txtpartname.Text = rdr("Description").ToString
                    txtunitprice.Text = rdr("Unit_Price").ToString
                    txtnettotal.Text = rdr("Net_Total").ToString
                    txtquantity.Text = rdr("Quantity").ToString
                    txtvat.Text = rdr("VAT").ToString
                    txttotal.Text = rdr("Total").ToString
                    txtorderdate.Text = rdr("Order_Date").ToString
                End While
            Catch ex As Exception
                MessageBox.Show("Error while retrieving records from table...",
                                "Read Record Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            Finally
                cmd.Parameters.Clear()
                con.Close()
            End Try
        End If
    End Sub

    Private Sub btnprintreceipt_Click(sender As Object, e As EventArgs) Handles btnprintreceipt.Click
        MessageBox.Show("Receipt Now Printed, Please Head To Printer",
                                "Receipt Printed", MessageBoxButtons.OK)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            sql = "DELETE FROM CashSale WHERE CashSale_Num = @CashSale"
            cmd.Parameters.Add("@CashSale", SqlDbType.Int).Value = Integer.Parse(cbocashnum.Text)
            cmd.CommandText = sql
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error While updating record",
              "Update Record error", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        Finally
            cmd.Parameters.Clear()
            con.Close()
        End Try
    End Sub
End Class