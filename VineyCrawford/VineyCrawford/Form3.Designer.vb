<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcredittran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtvat = New System.Windows.Forms.TextBox()
        Me.txtnettotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstpicklist = New System.Windows.Forms.ListBox()
        Me.byntransaction = New System.Windows.Forms.Button()
        Me.cbopart = New System.Windows.Forms.ComboBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.txtpartname = New System.Windows.Forms.TextBox()
        Me.txtpartnum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcustaddress = New System.Windows.Forms.TextBox()
        Me.txtcustname = New System.Windows.Forms.TextBox()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.cbocustomer = New System.Windows.Forms.ComboBox()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.txtcustphone = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtporderdate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbopartnum = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(501, 131)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 67
        '
        'txtvat
        '
        Me.txtvat.Location = New System.Drawing.Point(501, 98)
        Me.txtvat.Name = "txtvat"
        Me.txtvat.ReadOnly = True
        Me.txtvat.Size = New System.Drawing.Size(100, 20)
        Me.txtvat.TabIndex = 66
        '
        'txtnettotal
        '
        Me.txtnettotal.Location = New System.Drawing.Point(501, 62)
        Me.txtnettotal.Name = "txtnettotal"
        Me.txtnettotal.ReadOnly = True
        Me.txtnettotal.Size = New System.Drawing.Size(100, 20)
        Me.txtnettotal.TabIndex = 65
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(463, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(463, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "VAT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(443, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Net Total"
        '
        'lstpicklist
        '
        Me.lstpicklist.FormattingEnabled = True
        Me.lstpicklist.Location = New System.Drawing.Point(248, 249)
        Me.lstpicklist.Name = "lstpicklist"
        Me.lstpicklist.Size = New System.Drawing.Size(353, 121)
        Me.lstpicklist.TabIndex = 58
        '
        'byntransaction
        '
        Me.byntransaction.Location = New System.Drawing.Point(525, 205)
        Me.byntransaction.Name = "byntransaction"
        Me.byntransaction.Size = New System.Drawing.Size(76, 38)
        Me.byntransaction.TabIndex = 57
        Me.byntransaction.Text = "Produce Transaction"
        Me.byntransaction.UseVisualStyleBackColor = True
        '
        'cbopart
        '
        Me.cbopart.FormattingEnabled = True
        Me.cbopart.Location = New System.Drawing.Point(14, 29)
        Me.cbopart.Name = "cbopart"
        Me.cbopart.Size = New System.Drawing.Size(174, 21)
        Me.cbopart.TabIndex = 56
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(305, 64)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(104, 20)
        Me.txtquantity.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Quantity Needed"
        '
        'txtunitprice
        '
        Me.txtunitprice.Location = New System.Drawing.Point(285, 30)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.ReadOnly = True
        Me.txtunitprice.Size = New System.Drawing.Size(124, 20)
        Me.txtunitprice.TabIndex = 53
        '
        'txtpartname
        '
        Me.txtpartname.Location = New System.Drawing.Point(79, 97)
        Me.txtpartname.Name = "txtpartname"
        Me.txtpartname.ReadOnly = True
        Me.txtpartname.Size = New System.Drawing.Size(124, 20)
        Me.txtpartname.TabIndex = 52
        '
        'txtpartnum
        '
        Me.txtpartnum.Location = New System.Drawing.Point(79, 65)
        Me.txtpartnum.Name = "txtpartnum"
        Me.txtpartnum.ReadOnly = True
        Me.txtpartnum.Size = New System.Drawing.Size(124, 20)
        Me.txtpartnum.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(211, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Unit Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Part Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Please Select Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Please Select Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Customer Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Customer ID"
        '
        'txtcustaddress
        '
        Me.txtcustaddress.Location = New System.Drawing.Point(106, 315)
        Me.txtcustaddress.Name = "txtcustaddress"
        Me.txtcustaddress.ReadOnly = True
        Me.txtcustaddress.Size = New System.Drawing.Size(137, 20)
        Me.txtcustaddress.TabIndex = 42
        '
        'txtcustname
        '
        Me.txtcustname.Location = New System.Drawing.Point(106, 280)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.ReadOnly = True
        Me.txtcustname.Size = New System.Drawing.Size(137, 20)
        Me.txtcustname.TabIndex = 41
        '
        'txtcustid
        '
        Me.txtcustid.Location = New System.Drawing.Point(105, 244)
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.ReadOnly = True
        Me.txtcustid.Size = New System.Drawing.Size(137, 20)
        Me.txtcustid.TabIndex = 40
        '
        'cbocustomer
        '
        Me.cbocustomer.FormattingEnabled = True
        Me.cbocustomer.Location = New System.Drawing.Point(9, 212)
        Me.cbocustomer.Name = "cbocustomer"
        Me.cbocustomer.Size = New System.Drawing.Size(174, 21)
        Me.cbocustomer.TabIndex = 39
        '
        'txtdiscount
        '
        Me.txtdiscount.Location = New System.Drawing.Point(501, 30)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.ReadOnly = True
        Me.txtdiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtdiscount.TabIndex = 70
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(443, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Discount"
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(526, 161)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(75, 38)
        Me.btncalculate.TabIndex = 71
        Me.btncalculate.Text = "Calculate Totals"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'txtcustphone
        '
        Me.txtcustphone.Location = New System.Drawing.Point(105, 350)
        Me.txtcustphone.Name = "txtcustphone"
        Me.txtcustphone.ReadOnly = True
        Me.txtcustphone.Size = New System.Drawing.Size(137, 20)
        Me.txtcustphone.TabIndex = 73
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 350)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 13)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "Customer Phone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(214, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Order Date"
        '
        'dtporderdate
        '
        Me.dtporderdate.CustomFormat = "yyyy-MM-dd"
        Me.dtporderdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtporderdate.Location = New System.Drawing.Point(305, 95)
        Me.dtporderdate.Name = "dtporderdate"
        Me.dtporderdate.Size = New System.Drawing.Size(104, 20)
        Me.dtporderdate.TabIndex = 74
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(245, 203)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(195, 16)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Please Select Part Number"
        '
        'cbopartnum
        '
        Me.cbopartnum.FormattingEnabled = True
        Me.cbopartnum.Location = New System.Drawing.Point(248, 222)
        Me.cbopartnum.Name = "cbopartnum"
        Me.cbopartnum.Size = New System.Drawing.Size(121, 21)
        Me.cbopartnum.TabIndex = 76
        '
        'frmcredittran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(613, 378)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbopartnum)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtporderdate)
        Me.Controls.Add(Me.txtcustphone)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtvat)
        Me.Controls.Add(Me.txtnettotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lstpicklist)
        Me.Controls.Add(Me.byntransaction)
        Me.Controls.Add(Me.cbopart)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtunitprice)
        Me.Controls.Add(Me.txtpartname)
        Me.Controls.Add(Me.txtpartnum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcustaddress)
        Me.Controls.Add(Me.txtcustname)
        Me.Controls.Add(Me.txtcustid)
        Me.Controls.Add(Me.cbocustomer)
        Me.Name = "frmcredittran"
        Me.Text = "Credit PickingList/Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtvat As TextBox
    Friend WithEvents txtnettotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lstpicklist As ListBox
    Friend WithEvents byntransaction As Button
    Friend WithEvents cbopart As ComboBox
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtunitprice As TextBox
    Friend WithEvents txtpartname As TextBox
    Friend WithEvents txtpartnum As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcustaddress As TextBox
    Friend WithEvents txtcustname As TextBox
    Friend WithEvents txtcustid As TextBox
    Friend WithEvents cbocustomer As ComboBox
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btncalculate As Button
    Friend WithEvents txtcustphone As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtporderdate As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents cbopartnum As ComboBox
End Class
