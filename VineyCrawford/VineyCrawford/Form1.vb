Imports System.Data.SqlClient
Public Class frmaddsupplier

    Dim dbSource As String
    Dim sql As String
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim rdr As SqlDataReader
    Dim dt As New DataTable


    Private Sub frmaddsupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbSource = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VineyCraw;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Try
            sql = "SELECT Supplier_Name FROM Supplier"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                cboSupplierName.Items.Add(rdr("Supplier_Name").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error While retrieving records from table...",
                            "Read Record Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cboSupplierName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSupplierName.SelectedIndexChanged
        If cboSupplierName.SelectedIndex <> -1 Then
            Try
                sql = "SELECT * FROM Supplier WHERE Supplier_Name = @Name"

                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = cboSupplierName.SelectedItem.ToString
                cmd.CommandText = sql
                cmd.Connection = con
                con.ConnectionString = dbSource
                con.Open()
                rdr = cmd.ExecuteReader
                While rdr.Read
                    txtsupplierid.Text = rdr("Supplier_Id").ToString
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

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            sql = "INSERT INTO Supplier (Supplier_Name, Supplier_Address)
                VALUES (@SupplierName, @SupplierAddress)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@SupplierName", SqlDbType.NChar).Value = RTrim(txtsuppliername.Text)
            cmd.Parameters.Add("@SupplierAddress", SqlDbType.NChar).Value = RTrim(txtsupplieraddress.Text)
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

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            sql = "UPDATE Supplier SET Supplier_Name = @SupplierName WHERE Supplier_ID = @SupplierID"
            sql = "UPDATE Supplier SET Supplier_Address = @SupplierAddress WHERE Supplier_ID = @SupplierID"
            cmd.Parameters.Add("@SupplierName", SqlDbType.NChar).Value = RTrim(txtsuppliername.Text)
            cmd.Parameters.Add("@SupplierAddress", SqlDbType.NChar).Value = RTrim(txtsupplieraddress.Text)
            cmd.Parameters.Add("@SupplierID", SqlDbType.Int).Value = RTrim(txtsupplierid.Text)
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

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            sql = "DELETE FROM Supplier WHERE Supplier_Id = @SupplierDelete"
            cmd.Parameters.Add("@SupplierDelete", SqlDbType.Int).Value = Integer.Parse(txtsupplierid.Text)
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
