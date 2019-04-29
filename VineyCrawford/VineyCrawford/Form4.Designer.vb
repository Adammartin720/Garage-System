<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmaddcustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbocreditcustomer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcreditcustaddress = New System.Windows.Forms.TextBox()
        Me.txtcreditcustname = New System.Windows.Forms.TextBox()
        Me.txtcreditacnum = New System.Windows.Forms.TextBox()
        Me.btnaddcredit = New System.Windows.Forms.Button()
        Me.btneditcredit = New System.Windows.Forms.Button()
        Me.btndeletecredit = New System.Windows.Forms.Button()
        Me.btndeletecash = New System.Windows.Forms.Button()
        Me.btneditcash = New System.Windows.Forms.Button()
        Me.btnaddcash = New System.Windows.Forms.Button()
        Me.txtcashcustaddress = New System.Windows.Forms.TextBox()
        Me.txtcashcustname = New System.Windows.Forms.TextBox()
        Me.txtcashid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbocashcustomer = New System.Windows.Forms.ComboBox()
        Me.grpcredit = New System.Windows.Forms.GroupBox()
        Me.txtcreditcustphone = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpcash = New System.Windows.Forms.GroupBox()
        Me.txtcashcustphone = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpcredit.SuspendLayout()
        Me.grpcash.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbocreditcustomer
        '
        Me.cbocreditcustomer.FormattingEnabled = True
        Me.cbocreditcustomer.Location = New System.Drawing.Point(6, 43)
        Me.cbocreditcustomer.Name = "cbocreditcustomer"
        Me.cbocreditcustomer.Size = New System.Drawing.Size(169, 21)
        Me.cbocreditcustomer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please Select Record To update"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer A/C Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Customer Address"
        '
        'txtcreditcustaddress
        '
        Me.txtcreditcustaddress.Location = New System.Drawing.Point(117, 170)
        Me.txtcreditcustaddress.Name = "txtcreditcustaddress"
        Me.txtcreditcustaddress.Size = New System.Drawing.Size(137, 20)
        Me.txtcreditcustaddress.TabIndex = 7
        '
        'txtcreditcustname
        '
        Me.txtcreditcustname.Location = New System.Drawing.Point(117, 127)
        Me.txtcreditcustname.Name = "txtcreditcustname"
        Me.txtcreditcustname.Size = New System.Drawing.Size(137, 20)
        Me.txtcreditcustname.TabIndex = 6
        '
        'txtcreditacnum
        '
        Me.txtcreditacnum.Location = New System.Drawing.Point(117, 83)
        Me.txtcreditacnum.Name = "txtcreditacnum"
        Me.txtcreditacnum.ReadOnly = True
        Me.txtcreditacnum.Size = New System.Drawing.Size(137, 20)
        Me.txtcreditacnum.TabIndex = 5
        '
        'btnaddcredit
        '
        Me.btnaddcredit.Location = New System.Drawing.Point(270, 82)
        Me.btnaddcredit.Name = "btnaddcredit"
        Me.btnaddcredit.Size = New System.Drawing.Size(75, 31)
        Me.btnaddcredit.TabIndex = 8
        Me.btnaddcredit.Text = "Add"
        Me.btnaddcredit.UseVisualStyleBackColor = True
        '
        'btneditcredit
        '
        Me.btneditcredit.Location = New System.Drawing.Point(270, 127)
        Me.btneditcredit.Name = "btneditcredit"
        Me.btneditcredit.Size = New System.Drawing.Size(75, 31)
        Me.btneditcredit.TabIndex = 9
        Me.btneditcredit.Text = "Update"
        Me.btneditcredit.UseVisualStyleBackColor = True
        '
        'btndeletecredit
        '
        Me.btndeletecredit.Location = New System.Drawing.Point(270, 171)
        Me.btndeletecredit.Name = "btndeletecredit"
        Me.btndeletecredit.Size = New System.Drawing.Size(75, 31)
        Me.btndeletecredit.TabIndex = 10
        Me.btndeletecredit.Text = "Delete"
        Me.btndeletecredit.UseVisualStyleBackColor = True
        '
        'btndeletecash
        '
        Me.btndeletecash.Location = New System.Drawing.Point(273, 176)
        Me.btndeletecash.Name = "btndeletecash"
        Me.btndeletecash.Size = New System.Drawing.Size(75, 31)
        Me.btndeletecash.TabIndex = 26
        Me.btndeletecash.Text = "Delete"
        Me.btndeletecash.UseVisualStyleBackColor = True
        '
        'btneditcash
        '
        Me.btneditcash.Location = New System.Drawing.Point(273, 132)
        Me.btneditcash.Name = "btneditcash"
        Me.btneditcash.Size = New System.Drawing.Size(75, 31)
        Me.btneditcash.TabIndex = 25
        Me.btneditcash.Text = "Update"
        Me.btneditcash.UseVisualStyleBackColor = True
        '
        'btnaddcash
        '
        Me.btnaddcash.Location = New System.Drawing.Point(273, 87)
        Me.btnaddcash.Name = "btnaddcash"
        Me.btnaddcash.Size = New System.Drawing.Size(75, 31)
        Me.btnaddcash.TabIndex = 24
        Me.btnaddcash.Text = "Add"
        Me.btnaddcash.UseVisualStyleBackColor = True
        '
        'txtcashcustaddress
        '
        Me.txtcashcustaddress.Location = New System.Drawing.Point(120, 182)
        Me.txtcashcustaddress.Name = "txtcashcustaddress"
        Me.txtcashcustaddress.Size = New System.Drawing.Size(137, 20)
        Me.txtcashcustaddress.TabIndex = 23
        '
        'txtcashcustname
        '
        Me.txtcashcustname.Location = New System.Drawing.Point(120, 138)
        Me.txtcashcustname.Name = "txtcashcustname"
        Me.txtcashcustname.Size = New System.Drawing.Size(137, 20)
        Me.txtcashcustname.TabIndex = 22
        '
        'txtcashid
        '
        Me.txtcashid.Location = New System.Drawing.Point(120, 93)
        Me.txtcashid.Name = "txtcashid"
        Me.txtcashid.ReadOnly = True
        Me.txtcashid.Size = New System.Drawing.Size(137, 20)
        Me.txtcashid.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Customer Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Customer Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Cash Customer ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(213, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Please Select Record To update"
        '
        'cbocashcustomer
        '
        Me.cbocashcustomer.FormattingEnabled = True
        Me.cbocashcustomer.Location = New System.Drawing.Point(9, 48)
        Me.cbocashcustomer.Name = "cbocashcustomer"
        Me.cbocashcustomer.Size = New System.Drawing.Size(169, 21)
        Me.cbocashcustomer.TabIndex = 16
        '
        'grpcredit
        '
        Me.grpcredit.Controls.Add(Me.txtcreditcustphone)
        Me.grpcredit.Controls.Add(Me.Label11)
        Me.grpcredit.Controls.Add(Me.cbocreditcustomer)
        Me.grpcredit.Controls.Add(Me.Label1)
        Me.grpcredit.Controls.Add(Me.Label2)
        Me.grpcredit.Controls.Add(Me.Label3)
        Me.grpcredit.Controls.Add(Me.Label4)
        Me.grpcredit.Controls.Add(Me.txtcreditacnum)
        Me.grpcredit.Controls.Add(Me.txtcreditcustname)
        Me.grpcredit.Controls.Add(Me.txtcreditcustaddress)
        Me.grpcredit.Controls.Add(Me.btnaddcredit)
        Me.grpcredit.Controls.Add(Me.btneditcredit)
        Me.grpcredit.Controls.Add(Me.btndeletecredit)
        Me.grpcredit.Location = New System.Drawing.Point(12, 57)
        Me.grpcredit.Name = "grpcredit"
        Me.grpcredit.Size = New System.Drawing.Size(363, 248)
        Me.grpcredit.TabIndex = 27
        Me.grpcredit.TabStop = False
        Me.grpcredit.Text = "Credit Customer"
        '
        'txtcreditcustphone
        '
        Me.txtcreditcustphone.Location = New System.Drawing.Point(117, 212)
        Me.txtcreditcustphone.Name = "txtcreditcustphone"
        Me.txtcreditcustphone.Size = New System.Drawing.Size(137, 20)
        Me.txtcreditcustphone.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Customer Phone"
        '
        'grpcash
        '
        Me.grpcash.Controls.Add(Me.txtcashcustphone)
        Me.grpcash.Controls.Add(Me.Label13)
        Me.grpcash.Controls.Add(Me.btndeletecash)
        Me.grpcash.Controls.Add(Me.cbocashcustomer)
        Me.grpcash.Controls.Add(Me.Label9)
        Me.grpcash.Controls.Add(Me.btneditcash)
        Me.grpcash.Controls.Add(Me.Label8)
        Me.grpcash.Controls.Add(Me.btnaddcash)
        Me.grpcash.Controls.Add(Me.Label7)
        Me.grpcash.Controls.Add(Me.txtcashcustaddress)
        Me.grpcash.Controls.Add(Me.Label6)
        Me.grpcash.Controls.Add(Me.txtcashcustname)
        Me.grpcash.Controls.Add(Me.txtcashid)
        Me.grpcash.Location = New System.Drawing.Point(381, 57)
        Me.grpcash.Name = "grpcash"
        Me.grpcash.Size = New System.Drawing.Size(365, 248)
        Me.grpcash.TabIndex = 28
        Me.grpcash.TabStop = False
        Me.grpcash.Text = "Cash Customer"
        '
        'txtcashcustphone
        '
        Me.txtcashcustphone.Location = New System.Drawing.Point(120, 217)
        Me.txtcashcustphone.Name = "txtcashcustphone"
        Me.txtcashcustphone.Size = New System.Drawing.Size(137, 20)
        Me.txtcashcustphone.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 215)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Customer Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(605, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Here you can add, edit and delete both Credit Customer Records and Cash Customer " &
    "Records"
        '
        'frmaddcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 308)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grpcash)
        Me.Controls.Add(Me.grpcredit)
        Me.Name = "frmaddcustomer"
        Me.Text = "Add Customers"
        Me.grpcredit.ResumeLayout(False)
        Me.grpcredit.PerformLayout()
        Me.grpcash.ResumeLayout(False)
        Me.grpcash.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbocreditcustomer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcreditcustaddress As TextBox
    Friend WithEvents txtcreditcustname As TextBox
    Friend WithEvents txtcreditacnum As TextBox
    Friend WithEvents btnaddcredit As Button
    Friend WithEvents btneditcredit As Button
    Friend WithEvents btndeletecredit As Button
    Friend WithEvents btndeletecash As Button
    Friend WithEvents btneditcash As Button
    Friend WithEvents btnaddcash As Button
    Friend WithEvents txtcashcustaddress As TextBox
    Friend WithEvents txtcashcustname As TextBox
    Friend WithEvents txtcashid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbocashcustomer As ComboBox
    Friend WithEvents grpcredit As GroupBox
    Friend WithEvents grpcash As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcreditcustphone As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcashcustphone As TextBox
    Friend WithEvents Label13 As Label
End Class
