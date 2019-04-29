<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcashtran
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
        Me.cbocustomer = New System.Windows.Forms.ComboBox()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.txtcustname = New System.Windows.Forms.TextBox()
        Me.txtcustaddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbopart = New System.Windows.Forms.ComboBox()
        Me.btntransaction = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtnettotal = New System.Windows.Forms.TextBox()
        Me.txtvat = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.lstpick = New System.Windows.Forms.ListBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtcustphone = New System.Windows.Forms.TextBox()
        Me.labelnum = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtpartname = New System.Windows.Forms.TextBox()
        Me.txtpartnum = New System.Windows.Forms.TextBox()
        Me.cbopartnum = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtporderdate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbocustomer
        '
        Me.cbocustomer.FormattingEnabled = True
        Me.cbocustomer.Location = New System.Drawing.Point(8, 170)
        Me.cbocustomer.Name = "cbocustomer"
        Me.cbocustomer.Size = New System.Drawing.Size(174, 21)
        Me.cbocustomer.TabIndex = 0
        '
        'txtcustid
        '
        Me.txtcustid.Location = New System.Drawing.Point(103, 204)
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.ReadOnly = True
        Me.txtcustid.Size = New System.Drawing.Size(137, 20)
        Me.txtcustid.TabIndex = 1
        '
        'txtcustname
        '
        Me.txtcustname.Location = New System.Drawing.Point(103, 242)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.ReadOnly = True
        Me.txtcustname.Size = New System.Drawing.Size(137, 20)
        Me.txtcustname.TabIndex = 2
        '
        'txtcustaddress
        '
        Me.txtcustaddress.Location = New System.Drawing.Point(103, 276)
        Me.txtcustaddress.Name = "txtcustaddress"
        Me.txtcustaddress.ReadOnly = True
        Me.txtcustaddress.Size = New System.Drawing.Size(137, 20)
        Me.txtcustaddress.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Customer Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Please Select Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Please Select Item"
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(278, 51)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(95, 20)
        Me.txtquantity.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(187, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Quantity Needed"
        '
        'txtunitprice
        '
        Me.txtunitprice.Location = New System.Drawing.Point(278, 26)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.ReadOnly = True
        Me.txtunitprice.Size = New System.Drawing.Size(95, 20)
        Me.txtunitprice.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(187, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Unit Price"
        '
        'cbopart
        '
        Me.cbopart.FormattingEnabled = True
        Me.cbopart.Location = New System.Drawing.Point(9, 21)
        Me.cbopart.Name = "cbopart"
        Me.cbopart.Size = New System.Drawing.Size(104, 21)
        Me.cbopart.TabIndex = 26
        '
        'btntransaction
        '
        Me.btntransaction.Location = New System.Drawing.Point(529, 151)
        Me.btntransaction.Name = "btntransaction"
        Me.btntransaction.Size = New System.Drawing.Size(76, 38)
        Me.btntransaction.TabIndex = 27
        Me.btntransaction.Text = "Produce Transaction"
        Me.btntransaction.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(447, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Net Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(467, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "VAT"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(467, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Total"
        '
        'txtnettotal
        '
        Me.txtnettotal.Location = New System.Drawing.Point(505, 12)
        Me.txtnettotal.Name = "txtnettotal"
        Me.txtnettotal.ReadOnly = True
        Me.txtnettotal.Size = New System.Drawing.Size(100, 20)
        Me.txtnettotal.TabIndex = 35
        '
        'txtvat
        '
        Me.txtvat.Location = New System.Drawing.Point(505, 43)
        Me.txtvat.Name = "txtvat"
        Me.txtvat.ReadOnly = True
        Me.txtvat.Size = New System.Drawing.Size(100, 20)
        Me.txtvat.TabIndex = 36
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(505, 73)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 37
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(530, 107)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(75, 38)
        Me.btncalculate.TabIndex = 41
        Me.btncalculate.Text = "Calculate Totals"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'lstpick
        '
        Me.lstpick.FormattingEnabled = True
        Me.lstpick.Location = New System.Drawing.Point(246, 190)
        Me.lstpick.Name = "lstpick"
        Me.lstpick.Size = New System.Drawing.Size(359, 147)
        Me.lstpick.TabIndex = 61
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 309)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 13)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "Customer Phone"
        '
        'txtcustphone
        '
        Me.txtcustphone.Location = New System.Drawing.Point(103, 309)
        Me.txtcustphone.Name = "txtcustphone"
        Me.txtcustphone.ReadOnly = True
        Me.txtcustphone.Size = New System.Drawing.Size(137, 20)
        Me.txtcustphone.TabIndex = 63
        '
        'labelnum
        '
        Me.labelnum.AutoSize = True
        Me.labelnum.Location = New System.Drawing.Point(5, 53)
        Me.labelnum.Name = "labelnum"
        Me.labelnum.Size = New System.Drawing.Size(66, 13)
        Me.labelnum.TabIndex = 64
        Me.labelnum.Text = "Part Number"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(5, 79)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(57, 13)
        Me.lblname.TabIndex = 65
        Me.lblname.Text = "Part Name"
        '
        'txtpartname
        '
        Me.txtpartname.Location = New System.Drawing.Point(74, 77)
        Me.txtpartname.Name = "txtpartname"
        Me.txtpartname.ReadOnly = True
        Me.txtpartname.Size = New System.Drawing.Size(100, 20)
        Me.txtpartname.TabIndex = 66
        '
        'txtpartnum
        '
        Me.txtpartnum.Location = New System.Drawing.Point(74, 53)
        Me.txtpartnum.Name = "txtpartnum"
        Me.txtpartnum.ReadOnly = True
        Me.txtpartnum.Size = New System.Drawing.Size(100, 20)
        Me.txtpartnum.TabIndex = 67
        '
        'cbopartnum
        '
        Me.cbopartnum.FormattingEnabled = True
        Me.cbopartnum.Location = New System.Drawing.Point(246, 163)
        Me.cbopartnum.Name = "cbopartnum"
        Me.cbopartnum.Size = New System.Drawing.Size(121, 21)
        Me.cbopartnum.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(243, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 16)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Please Select Part Number"
        '
        'dtporderdate
        '
        Me.dtporderdate.CustomFormat = "yyyy-MM-dd"
        Me.dtporderdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtporderdate.Location = New System.Drawing.Point(278, 75)
        Me.dtporderdate.Name = "dtporderdate"
        Me.dtporderdate.Size = New System.Drawing.Size(96, 20)
        Me.dtporderdate.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(187, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Order Date"
        '
        'frmcashtran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(609, 341)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtporderdate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbopartnum)
        Me.Controls.Add(Me.txtpartnum)
        Me.Controls.Add(Me.txtpartname)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.labelnum)
        Me.Controls.Add(Me.txtcustphone)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lstpick)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtvat)
        Me.Controls.Add(Me.txtnettotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btntransaction)
        Me.Controls.Add(Me.cbopart)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtunitprice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcustaddress)
        Me.Controls.Add(Me.txtcustname)
        Me.Controls.Add(Me.txtcustid)
        Me.Controls.Add(Me.cbocustomer)
        Me.Name = "frmcashtran"
        Me.Text = "Cash PickingList/Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbocustomer As ComboBox
    Friend WithEvents txtcustid As TextBox
    Friend WithEvents txtcustname As TextBox
    Friend WithEvents txtcustaddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtunitprice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbopart As ComboBox
    Friend WithEvents btntransaction As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtnettotal As TextBox
    Friend WithEvents txtvat As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btncalculate As Button
    Friend WithEvents lstpick As ListBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtcustphone As TextBox
    Friend WithEvents labelnum As Label
    Friend WithEvents lblname As Label
    Friend WithEvents txtpartname As TextBox
    Friend WithEvents txtpartnum As TextBox
    Friend WithEvents cbopartnum As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtporderdate As DateTimePicker
    Friend WithEvents Label9 As Label
End Class
