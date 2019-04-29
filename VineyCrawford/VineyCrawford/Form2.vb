Imports System.Data.SqlClient
Public Class frmcashtran
    Dim dbSource As String
    Dim sql As String
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim rdr As SqlDataReader
    Dim dt As New DataTable

    Private Sub frmcashtran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbSource = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VineyCraw;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        Try
            sql = "SELECT Customer_Name FROM CashCustomer"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                cbocustomer.Items.Add(rdr("Customer_Name").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error While retrieving records from table...",
                            "Read Record Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        Try
            sql = "SELECT Description FROM Part"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                cbopart.Items.Add(rdr("Description").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error While retrieving records from table...",
                            "Read Record Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        Try
            sql = "SELECT Part_Num FROM CashSale"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                cbopartnum.Items.Add(rdr("Part_Num").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error While retrieving records from table...",
                            "Read Record Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cbocustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocustomer.SelectedIndexChanged
        If cbocustomer.SelectedIndex <> -1 Then
            Try
                sql = "SELECT * FROM CashCustomer WHERE Customer_Name = @CName"

                cmd.Parameters.Add("@CName", SqlDbType.VarChar).Value = cbocustomer.SelectedItem.ToString
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

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click

        Dim itemtotal As Double
        itemtotal = txtquantity.Text * txtunitprice.Text


        Dim nettotal As Double
        nettotal = itemtotal
        txtnettotal.Text = nettotal

        Dim vat As Double
        vat = 17.5
        Dim vattotal As Double
        vattotal = (vat / 100) * txtnettotal.Text
        txtvat.Text = vattotal

        txttotal.Text = vattotal + nettotal
    End Sub

    Private Sub cbopart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopart.SelectedIndexChanged
        If cbopart.SelectedIndex <> -1 Then
            Try
                sql = "SELECT * FROM Part WHERE Description = @PDescrip"

                cmd.Parameters.Add("@PDescrip", SqlDbType.VarChar).Value = cbopart.SelectedItem.ToString
                cmd.CommandText = sql
                cmd.Connection = con
                con.ConnectionString = dbSource
                con.Open()
                rdr = cmd.ExecuteReader
                While rdr.Read
                    txtunitprice.Text = rdr("Unit_Price").ToString
                    txtpartnum.Text = rdr("Part_Number").ToString
                    txtpartname.Text = rdr("Description").ToString
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
    Private Sub btntransaction_Click(sender As Object, e As EventArgs) Handles btntransaction.Click
        Try
            sql = "INSERT INTO CashSale (CashCustomer_Id, Customer_Name, Customer_Address,  Customer_Phone, Part_Num, Description, Unit_Price, Quantity, Net_Total, VAT, Total, Order_Date)
                    VALUES (@CashCustID, @CashCustName, @CashCustAddress, @CashCustPhone, @PartNumb, @PartDescription, @PartPrice, @PartQuantity, @NetTotal, @VAT, @Total, @OrderDate)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@CashCustID", SqlDbType.Int).Value = Integer.Parse(txtcustid.Text)
            cmd.Parameters.Add("@CashCustName", SqlDbType.NChar).Value = RTrim(txtcustname.Text)
            cmd.Parameters.Add("@CashCustAddress", SqlDbType.NChar).Value = RTrim(txtcustaddress.Text)
            cmd.Parameters.Add("@CashCustPhone", SqlDbType.BigInt).Value = Integer.Parse(txtcustphone.Text)
            cmd.Parameters.Add("@PartNumb", SqlDbType.Int).Value = Integer.Parse(txtpartnum.Text)
            cmd.Parameters.Add("@PartDescription", SqlDbType.NChar).Value = RTrim(txtpartname.Text)
            cmd.Parameters.Add("@PartPrice", SqlDbType.Float).Value = RTrim(txtunitprice.Text)
            cmd.Parameters.Add("@PartQuantity", SqlDbType.Int).Value = Integer.Parse(txtquantity.Text)
            cmd.Parameters.Add("@NetTotal", SqlDbType.Float).Value = RTrim(txtnettotal.Text)
            cmd.Parameters.Add("@VAT", SqlDbType.Float).Value = RTrim(txtvat.Text)
            cmd.Parameters.Add("@Total", SqlDbType.Float).Value = RTrim(txttotal.Text)
            cmd.Parameters.Add("@OrderDate", SqlDbType.Date).Value = RTrim(dtporderdate.Text)
            cmd.CommandText = sql
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error While inserting new record.....",
                            "Insert Record Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            cmd.Parameters.Clear()
            con.Close()
        End Try
    End Sub

    Private Sub cbopartnum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopartnum.SelectedIndexChanged

        Try
            sql = "SELECT * FROM CashSale WHERE Part_Num = @SalesPart"
            cmd.Parameters.Add("@SalesPart", SqlDbType.Int).Value = cbopartnum.SelectedItem
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                lstpick.Items.Add(rdr("CashSale_Num") & "  " & RTrim(rdr("CashCustomer_Id")) & "  " & rdr("Customer_Name") & "  " & rdr("Part_Num") & "  " & rdr("Description") & "  " & rdr("Quantity") & "  " & rdr("Net_Total"))
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
End Class