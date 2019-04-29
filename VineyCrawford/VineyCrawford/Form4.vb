Imports System.Data.SqlClient


Public Class frmaddcustomer
    Dim dbSource As String
    Dim sql As String
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection
    Dim rdr As SqlDataReader

    Private Sub frmaddcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbSource = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VineyCraw;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"


        Try
            sql = "SELECT Customer_Name FROM CreditCustomer"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                cbocreditcustomer.Items.Add(rdr("Customer_Name").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error While retrieving records from table...",
                                "Read Record Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try


        Try
            sql = "SELECT Customer_Name FROM CashCustomer"
            cmd.CommandText = sql
            cmd.Connection = con
            con.ConnectionString = dbSource
            con.Open()
            rdr = cmd.ExecuteReader
            While rdr.Read
                cbocashcustomer.Items.Add(rdr("Customer_Name").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error While retrieving records from table...",
                                    "Read Record Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub btnaddcredit_Click(sender As Object, e As EventArgs) Handles btnaddcredit.Click
        Try
            sql = "INSERT INTO CreditCustomer (Customer_Name, Customer_Address, Customer_Phone)
                VALUES (@CreditCustomerName, @CreditCustomerAddress, @CreditCustomerPhone)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@CreditCustomerName", SqlDbType.NChar).Value = RTrim(txtcreditcustname.Text)
            cmd.Parameters.Add("@CreditCustomerAddress", SqlDbType.NChar).Value = RTrim(txtcreditcustaddress.Text)
            cmd.Parameters.Add("@CreditCustomerPhone", SqlDbType.BigInt).Value = Integer.Parse(txtcreditcustphone.Text)
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

    Private Sub btnaddcash_Click(sender As Object, e As EventArgs) Handles btnaddcash.Click
        Try
            sql = "INSERT INTO CashCustomer (Customer_Name, Customer_Address, Customer_Phone)
                VALUES (@CashCustomerName, @CashCustomerAddress, @CashCustomerPhone)"
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@CashCustomerName", SqlDbType.NChar).Value = RTrim(txtcashcustname.Text)
            cmd.Parameters.Add("@CashCustomerAddress", SqlDbType.NChar).Value = RTrim(txtcashcustaddress.Text)
            cmd.Parameters.Add("@CashCustomerPhone", SqlDbType.BigInt).Value = Integer.Parse(txtcashcustphone.Text)
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

    Private Sub cbocashcustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocashcustomer.SelectedIndexChanged
        If cbocashcustomer.SelectedIndex <> -1 Then
            Try
                sql = "SELECT * FROM CashCustomer WHERE Customer_Name = @CAName"

                cmd.Parameters.Add("@CAName", SqlDbType.VarChar).Value = cbocashcustomer.SelectedItem.ToString
                cmd.CommandText = sql
                cmd.Connection = con
                con.ConnectionString = dbSource
                con.Open()
                rdr = cmd.ExecuteReader
                While rdr.Read
                    txtcashid.Text = rdr("CashCustomer_Id").ToString
                    txtcashcustname.Text = rdr("Customer_Name").ToString
                    txtcashcustaddress.Text = rdr("Customer_Address").ToString
                    txtcashcustphone.Text = rdr("Customer_Phone").ToString
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

    Private Sub cbocreditcustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocreditcustomer.SelectedIndexChanged
        If cbocreditcustomer.SelectedIndex <> -1 Then
            Try
                sql = "SELECT * FROM CreditCustomer WHERE Customer_Name = @CRName"

                cmd.Parameters.Add("@CRName", SqlDbType.VarChar).Value = cbocreditcustomer.SelectedItem.ToString
                cmd.CommandText = sql
                cmd.Connection = con
                con.ConnectionString = dbSource
                con.Open()
                rdr = cmd.ExecuteReader
                While rdr.Read
                    txtcreditacnum.Text = rdr("Customer_AC_Number").ToString
                    txtcreditcustname.Text = rdr("Customer_Name").ToString
                    txtcreditcustaddress.Text = rdr("Customer_Address").ToString
                    txtcreditcustphone.Text = rdr("Customer_Phone").ToString
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

    Private Sub btneditcredit_Click(sender As Object, e As EventArgs) Handles btneditcredit.Click
        Try
            sql = "UPDATE CreditCustomer SET Customer_Name = @CustomerName WHERE Customer_AC_Number = @CustomerAC"
            sql = "UPDATE CreditCustomer SET Customer_Address = @CustomerAddress WHERE Customer_AC_Number = @CustomerAC"
            sql = "UPDATE CreditCustomer SET Customer_Phone = @CustomerPhone WHERE Customer_AC_Number = @CustomerAC"

            cmd.Parameters.Add("@CustomerName", SqlDbType.NChar).Value = RTrim(txtcreditcustname.Text)
            cmd.Parameters.Add("@CustomerAddress", SqlDbType.NChar).Value = RTrim(txtcreditcustaddress.Text)
            cmd.Parameters.Add("@CustomerPhone", SqlDbType.BigInt).Value = Integer.Parse(txtcreditcustphone.Text)
            cmd.Parameters.Add("@CustomerAC", SqlDbType.Int).Value = Integer.Parse(txtcreditacnum.Text)
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

    Private Sub btneditcash_Click(sender As Object, e As EventArgs) Handles btneditcash.Click
        Try
            sql = "UPDATE CashCustomer SET Customer_Name = @CustomerName WHERE CashCustomer_Id = @CustomerC"
            sql = "UPDATE CashCustomer SET Customer_Address = @CustomerAddress WHERE CashCustomer_Id = @CustomerC"
            sql = "UPDATE CashCustomer SET Customer_Phone = @CustomerPhone WHERE CashCustomer_Id = @CustomerC"

            cmd.Parameters.Add("@CustomerName", SqlDbType.NChar).Value = RTrim(txtcashcustname.Text)
            cmd.Parameters.Add("@CustomerAddress", SqlDbType.NChar).Value = RTrim(txtcashcustaddress.Text)
            cmd.Parameters.Add("@CustomerPhone", SqlDbType.BigInt).Value = Integer.Parse(txtcashcustphone.Text)
            cmd.Parameters.Add("@CustomerC", SqlDbType.Int).Value = Integer.Parse(txtcashid.Text)
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