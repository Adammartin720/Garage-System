﻿Imports System.Data.SqlClient
Public Class frmcreditsale
    Dim dbSource As String
    Dim sql As String
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim rdr As SqlDataReader
    Dim dt As New DataTable
    Private Sub btnloadorder_Click(sender As Object, e As EventArgs) Handles btnloadorder.Click
        Try
            sql = "SELECT * FROM CreditSale"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                lstcreditorder.Items.Add(rdr("CreditSale_Id") & "  " & RTrim(rdr("Customer_AC_Number")) & "  " & rdr("Customer_Name") & "  " & rdr("Customer_Address") & " " & rdr("Customer_Phone") & " " & rdr("Part_Num") & "  " & rdr("Description") & "  " & rdr("Unit_Price") & " " & rdr("Quantity") & "  " & rdr("Net_Total") & " " & rdr("VAT") & " " & rdr("Total") & " " & rdr("Order_Date"))
            End While
        Catch ex As Exception
            MessageBox.Show("Error while retrieving records from table...",
                                "Read Record Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
        Finally
            cmd.Parameters.Clear()
            con.Close()
        End Try
    End Sub

    Private Sub frmcreditsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbSource = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VineyCraw;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        Try
            sql = "SELECT CreditSale_Id FROM CreditSale"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                cbocreditnum.Items.Add(rdr("CreditSale_Id").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error While retrieving records from table...",
                            "Read Record Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cbocreditnum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocreditnum.SelectedIndexChanged
        If cbocreditnum.SelectedIndex <> -1 Then
            Try
                sql = "SELECT * FROM CreditSale WHERE CreditSale_Id = @CreditSale"

                cmd.Parameters.Add("@CreditSale", SqlDbType.VarChar).Value = cbocreditnum.SelectedItem.ToString
                cmd.CommandText = sql
                cmd.Connection = con
                con.ConnectionString = dbSource
                con.Open()
                rdr = cmd.ExecuteReader
                While rdr.Read
                    txtcustid.Text = rdr("Customer_AC_Number").ToString
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
End Class