﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcashrefund
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
        Me.txtorderdate = New System.Windows.Forms.TextBox()
        Me.btnprintreceipt = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtvat = New System.Windows.Forms.TextBox()
        Me.txtnettotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcustphone = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcustaddress = New System.Windows.Forms.TextBox()
        Me.txtcustname = New System.Windows.Forms.TextBox()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpartnum = New System.Windows.Forms.TextBox()
        Me.txtpartname = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.labelnum = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbocashnum = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtorderdate
        '
        Me.txtorderdate.Location = New System.Drawing.Point(293, 301)
        Me.txtorderdate.Name = "txtorderdate"
        Me.txtorderdate.ReadOnly = True
        Me.txtorderdate.Size = New System.Drawing.Size(95, 20)
        Me.txtorderdate.TabIndex = 166
        '
        'btnprintreceipt
        '
        Me.btnprintreceipt.Location = New System.Drawing.Point(386, 347)
        Me.btnprintreceipt.Name = "btnprintreceipt"
        Me.btnprintreceipt.Size = New System.Drawing.Size(99, 36)
        Me.btnprintreceipt.TabIndex = 164
        Me.btnprintreceipt.Text = "Print Credit Note"
        Me.btnprintreceipt.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 16)
        Me.Label8.TabIndex = 162
        Me.Label8.Text = "Item Order Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 16)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Cash Customer Details"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(86, 368)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 160
        '
        'txtvat
        '
        Me.txtvat.Location = New System.Drawing.Point(86, 338)
        Me.txtvat.Name = "txtvat"
        Me.txtvat.ReadOnly = True
        Me.txtvat.Size = New System.Drawing.Size(100, 20)
        Me.txtvat.TabIndex = 159
        '
        'txtnettotal
        '
        Me.txtnettotal.Location = New System.Drawing.Point(86, 307)
        Me.txtnettotal.Name = "txtnettotal"
        Me.txtnettotal.ReadOnly = True
        Me.txtnettotal.Size = New System.Drawing.Size(100, 20)
        Me.txtnettotal.TabIndex = 158
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(48, 370)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 157
        Me.Label13.Text = "Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(48, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "VAT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 308)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "Net Total"
        '
        'txtcustphone
        '
        Me.txtcustphone.Location = New System.Drawing.Point(360, 175)
        Me.txtcustphone.Name = "txtcustphone"
        Me.txtcustphone.ReadOnly = True
        Me.txtcustphone.Size = New System.Drawing.Size(137, 20)
        Me.txtcustphone.TabIndex = 154
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(263, 175)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 13)
        Me.Label20.TabIndex = 153
        Me.Label20.Text = "Customer Phone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Customer Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Customer ID"
        '
        'txtcustaddress
        '
        Me.txtcustaddress.Location = New System.Drawing.Point(360, 136)
        Me.txtcustaddress.Name = "txtcustaddress"
        Me.txtcustaddress.ReadOnly = True
        Me.txtcustaddress.Size = New System.Drawing.Size(137, 20)
        Me.txtcustaddress.TabIndex = 149
        '
        'txtcustname
        '
        Me.txtcustname.Location = New System.Drawing.Point(108, 172)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.ReadOnly = True
        Me.txtcustname.Size = New System.Drawing.Size(137, 20)
        Me.txtcustname.TabIndex = 148
        '
        'txtcustid
        '
        Me.txtcustid.Location = New System.Drawing.Point(108, 139)
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.ReadOnly = True
        Me.txtcustid.Size = New System.Drawing.Size(137, 20)
        Me.txtcustid.TabIndex = 147
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(202, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 146
        Me.Label9.Text = "Order Date"
        '
        'txtpartnum
        '
        Me.txtpartnum.Location = New System.Drawing.Point(86, 254)
        Me.txtpartnum.Name = "txtpartnum"
        Me.txtpartnum.ReadOnly = True
        Me.txtpartnum.Size = New System.Drawing.Size(100, 20)
        Me.txtpartnum.TabIndex = 145
        '
        'txtpartname
        '
        Me.txtpartname.Location = New System.Drawing.Point(86, 278)
        Me.txtpartname.Name = "txtpartname"
        Me.txtpartname.ReadOnly = True
        Me.txtpartname.Size = New System.Drawing.Size(100, 20)
        Me.txtpartname.TabIndex = 144
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(17, 280)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(57, 13)
        Me.lblname.TabIndex = 143
        Me.lblname.Text = "Part Name"
        '
        'labelnum
        '
        Me.labelnum.AutoSize = True
        Me.labelnum.Location = New System.Drawing.Point(17, 254)
        Me.labelnum.Name = "labelnum"
        Me.labelnum.Size = New System.Drawing.Size(66, 13)
        Me.labelnum.TabIndex = 142
        Me.labelnum.Text = "Part Number"
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(293, 276)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.ReadOnly = True
        Me.txtquantity.Size = New System.Drawing.Size(95, 20)
        Me.txtquantity.TabIndex = 141
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "Quantity"
        '
        'txtunitprice
        '
        Me.txtunitprice.Location = New System.Drawing.Point(293, 251)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.ReadOnly = True
        Me.txtunitprice.Size = New System.Drawing.Size(95, 20)
        Me.txtunitprice.TabIndex = 139
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(202, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "Unit Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 16)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Please Cash Sale Number"
        '
        'cbocashnum
        '
        Me.cbocashnum.FormattingEnabled = True
        Me.cbocashnum.Location = New System.Drawing.Point(20, 31)
        Me.cbocashnum.Name = "cbocashnum"
        Me.cbocashnum.Size = New System.Drawing.Size(136, 21)
        Me.cbocashnum.TabIndex = 136
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(349, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(154, 52)
        Me.Label17.TabIndex = 135
        Me.Label17.Text = "Viney & Crawford" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Unit 10, Cwmdu Trading Estate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Swansea" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tel. 01792 511690"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(291, 347)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(89, 36)
        Me.btndelete.TabIndex = 167
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'frmcashrefund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 398)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.txtorderdate)
        Me.Controls.Add(Me.btnprintreceipt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtvat)
        Me.Controls.Add(Me.txtnettotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtcustphone)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcustaddress)
        Me.Controls.Add(Me.txtcustname)
        Me.Controls.Add(Me.txtcustid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtpartnum)
        Me.Controls.Add(Me.txtpartname)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.labelnum)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtunitprice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbocashnum)
        Me.Controls.Add(Me.Label17)
        Me.Name = "frmcashrefund"
        Me.Text = "Cash Refund"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtorderdate As TextBox
    Friend WithEvents btnprintreceipt As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtvat As TextBox
    Friend WithEvents txtnettotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcustphone As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcustaddress As TextBox
    Friend WithEvents txtcustname As TextBox
    Friend WithEvents txtcustid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtpartnum As TextBox
    Friend WithEvents txtpartname As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents labelnum As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtunitprice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbocashnum As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btndelete As Button
End Class
