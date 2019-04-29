Imports System.Data.SqlClient
Public Class frmaddparts
    Dim dbSource As String
    Dim sql As String
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim rdr As SqlDataReader
    Dim dt As New DataTable
    Private Sub frmaddparts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbSource = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VineyCraw;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

        Try
            sql = "SELECT Description FROM Part"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                cbopartname.Items.Add(rdr("Description").ToString)
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
                cbosupplierid.Items.Add(rdr("Supplier_Name").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error While retrieving records from table...",
                            "Read Record Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cbopartname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopartname.SelectedIndexChanged
        If cbopartname.SelectedIndex <> -1 Then
            Try
                sql = "SELECT * FROM Part WHERE Description = @Description"

                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = cbopartname.SelectedItem.ToString
                cmd.CommandText = sql
                cmd.Connection = con
                con.ConnectionString = dbSource
                con.Open()
                rdr = cmd.ExecuteReader
                While rdr.Read
                    txtpartid.Text = rdr("Part_Number").ToString
                    txtdescription.Text = rdr("Description").ToString
                    txtunitprice.Text = rdr("Unit_Price").ToString
                    txtstocklevel.Text = rdr("Stock_Level").ToString
                    txtreorder.Text = rdr("Reorder_Level").ToString
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

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            sql = "INSERT INTO Part (Part_Number, Description, Unit_Price, Stock_Level, Reorder_Level, Supplier_Id)
                VALUES (@PartNumber, @PartName, @UnitPrice, @StockLevel, @Reorder, @SupplierID)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@PartNumber", SqlDbType.Int).Value = Integer.Parse(txtpartid.Text)
            cmd.Parameters.Add("@PartName", SqlDbType.NChar).Value = RTrim(txtdescription.Text)
            cmd.Parameters.Add("@UnitPrice", SqlDbType.Float).Value = RTrim(txtunitprice.Text)
            cmd.Parameters.Add("@StockLevel", SqlDbType.Int).Value = Integer.Parse(txtstocklevel.Text)
            cmd.Parameters.Add("@Reorder", SqlDbType.Int).Value = Integer.Parse(txtreorder.Text)
            cmd.Parameters.Add("@SupplierID", SqlDbType.Int).Value = Integer.Parse(cbosupplierid.Text)
            cmd.CommandText = sql
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error While inserting new record to table...",
                            "Insert Record Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            cmd.Parameters.Clear()
            con.Close()
        End Try
    End Sub
End Class