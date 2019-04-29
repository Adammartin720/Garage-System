Imports System.Data.SqlClient
Public Class frmpurchacestock
    Dim dbSource As String
    Dim sql As String
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim rdr As SqlDataReader
    Dim dt As New DataTable
    Private Sub frmpurchacestock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbSource = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VineyCraw;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        Try
            sql = "SELECT Description FROM Part"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                cboitem.Items.Add(rdr("Description").ToString)
                cboitemselect.Items.Add(rdr("Description").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error While retrieving records from table...",
                            "Read Record Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

        Try
            sql = "SELECT Supplier_Id FROM Supplier"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                cbosupplierid.Items.Add(rdr("Supplier_Id").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error While retrieving records from table...",
                            "Read Record Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub cboitem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboitem.SelectedIndexChanged
        If cboitem.SelectedIndex <> -1 Then
            Try
                sql = "SELECT * FROM Part WHERE Description = @StockDescription"

                cmd.Parameters.Add("@StockDescription", SqlDbType.VarChar).Value = cboitem.SelectedItem.ToString
                cmd.CommandText = sql
                cmd.Connection = con
                con.ConnectionString = dbSource
                con.Open()
                rdr = cmd.ExecuteReader
                While rdr.Read
                    txtpartid.Text = rdr("Part_Number").ToString
                    txtdescription.Text = rdr("Description").ToString
                    txtstocklevel.Text = rdr("Stock_Level").ToString
                    txtreorder.Text = rdr("Reorder_Level").ToString
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

    Private Sub cboitemselect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboitemselect.SelectedIndexChanged
        If cboitemselect.SelectedIndex <> -1 Then
            Try
                sql = "SELECT * FROM Part WHERE Description = @PurDescription"

                cmd.Parameters.Add("@PurDescription", SqlDbType.VarChar).Value = cboitemselect.SelectedItem.ToString
                cmd.CommandText = sql
                cmd.Connection = con
                con.ConnectionString = dbSource
                con.Open()
                rdr = cmd.ExecuteReader
                While rdr.Read
                    txtpartnum.Text = rdr("Part_Number").ToString
                    txtpartname.Text = rdr("Description").ToString
                    cbosupplierid.Text = rdr("Supplier_Id").ToString
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

    Private Sub btnloadsupplier_Click(sender As Object, e As EventArgs) Handles btnloadsupplier.Click
        If cbosupplierid.SelectedIndex <> -1 Then
            Try
                sql = "SELECT * FROM Supplier WHERE Supplier_Id = @SupplierID"

                cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar).Value = cbosupplierid.SelectedItem.ToString
                cmd.CommandText = sql
                cmd.Connection = con
                con.ConnectionString = dbSource
                con.Open()
                rdr = cmd.ExecuteReader
                While rdr.Read
                    txtsuppliername.Text = rdr("Supplier_Name").ToString
                    txtsupplieraddress.Text = rdr("Supplier_Address").ToString
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

    Private Sub btnsuppliers_Click(sender As Object, e As EventArgs) Handles btnsuppliers.Click
        frmaddsupplier.Show()
    End Sub

    Private Sub btnaddparts_Click(sender As Object, e As EventArgs) Handles btnaddparts.Click
        frmaddparts.Show()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            sql = "UPDATE Part SET Stock_Level = @StockLevel WHERE Part_Number = @PartNum"
            sql = "UPDATE Part SET Reorder_Level = @ReorderLevel WHERE Part_Number = @PartNum"
            cmd.Parameters.Add("@StockLevel", SqlDbType.Int).Value = Integer.Parse(txtstocklevel.Text)
            cmd.Parameters.Add("@ReorderLevel", SqlDbType.Int).Value = Integer.Parse(txtreorder.Text)
            cmd.Parameters.Add("@PartNum", SqlDbType.Int).Value = RTrim(txtpartid.Text)
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

    Private Sub btnloadstock_Click(sender As Object, e As EventArgs) Handles btnloadstock.Click
        Try
            sql = "SELECT * FROM Part"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                lstpartdetails.Items.Add(rdr("Part_Number") & "  " & RTrim(rdr("Description")) & "  " & rdr("Unit_Price") & "  " & rdr("Stock_Level") & " " & rdr("Reorder_Level"))
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

    Private Sub btnloadpurchace_Click(sender As Object, e As EventArgs) Handles btnloadpurchace.Click
        Try
            sql = "SELECT * FROM PurchaceOrder"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                lstpurchace.Items.Add(rdr("Purchace_Order_Id") & "  " & RTrim(rdr("Part_Num")) & "  " & rdr("Description") & "  " & rdr("Quantity_Order") & " " & rdr("PurchaceOrder_Date") & " " & rdr("Supplier_Id") & " " & rdr("Supplier_Name") & " " & rdr("Supplier_Address"))
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

    Private Sub btnaddpurchace_Click(sender As Object, e As EventArgs) Handles btnaddpurchace.Click
        Try
            sql = "INSERT INTO PurchaceOrder (Part_Num, Description, Quantity_Order, PurchaceOrder_Date, Supplier_Id, Supplier_Name, Supplier_Address)
                    VALUES (@PartNumbe, @Descrip, @QuantityOrd, @PurchaceDate, @SupplierID, @SupplierName, @SupplierAddress)"
            cmd.Parameters.Clear()

            cmd.Parameters.Add("@PartNumbe", SqlDbType.Int).Value = Integer.Parse(txtpartnum.Text)
            cmd.Parameters.Add("@Descrip", SqlDbType.NChar).Value = RTrim(txtpartname.Text)
            cmd.Parameters.Add("@QuantityOrd", SqlDbType.Int).Value = Integer.Parse(txtquantityord.Text)
            cmd.Parameters.Add("@PurchaceDate", SqlDbType.Date).Value = RTrim(dtporderdate.Text)
            cmd.Parameters.Add("@SupplierID", SqlDbType.Int).Value = Integer.Parse(cbosupplierid.Text)
            cmd.Parameters.Add("@SupplierName", SqlDbType.NChar).Value = RTrim(txtsuppliername.Text)
            cmd.Parameters.Add("@SupplierAddress", SqlDbType.NChar).Value = RTrim(txtsupplieraddress.Text)
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
End Class