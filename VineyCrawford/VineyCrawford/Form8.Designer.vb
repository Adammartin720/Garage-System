<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmpurchacestock
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboitem = New System.Windows.Forms.ComboBox()
        Me.lstpartdetails = New System.Windows.Forms.ListBox()
        Me.btnaddparts = New System.Windows.Forms.Button()
        Me.btnsuppliers = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboitemselect = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtporderdate = New System.Windows.Forms.DateTimePicker()
        Me.txtpartname = New System.Windows.Forms.TextBox()
        Me.txtpartnum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtquantityord = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsuppliername = New System.Windows.Forms.TextBox()
        Me.txtsupplieraddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnaddpurchace = New System.Windows.Forms.Button()
        Me.lstpurchace = New System.Windows.Forms.ListBox()
        Me.btnloadpurchace = New System.Windows.Forms.Button()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.txtpartid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtstocklevel = New System.Windows.Forms.TextBox()
        Me.txtreorder = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnloadsupplier = New System.Windows.Forms.Button()
        Me.cbosupplierid = New System.Windows.Forms.ComboBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnloadstock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Select Item"
        '
        'cboitem
        '
        Me.cboitem.FormattingEnabled = True
        Me.cboitem.Location = New System.Drawing.Point(3, 31)
        Me.cboitem.Name = "cboitem"
        Me.cboitem.Size = New System.Drawing.Size(166, 21)
        Me.cboitem.TabIndex = 10
        '
        'lstpartdetails
        '
        Me.lstpartdetails.FormattingEnabled = True
        Me.lstpartdetails.Location = New System.Drawing.Point(181, 12)
        Me.lstpartdetails.Name = "lstpartdetails"
        Me.lstpartdetails.Size = New System.Drawing.Size(377, 108)
        Me.lstpartdetails.TabIndex = 16
        '
        'btnaddparts
        '
        Me.btnaddparts.Location = New System.Drawing.Point(400, 126)
        Me.btnaddparts.Name = "btnaddparts"
        Me.btnaddparts.Size = New System.Drawing.Size(79, 41)
        Me.btnaddparts.TabIndex = 17
        Me.btnaddparts.Text = "Add More Parts"
        Me.btnaddparts.UseVisualStyleBackColor = True
        '
        'btnsuppliers
        '
        Me.btnsuppliers.Location = New System.Drawing.Point(315, 126)
        Me.btnsuppliers.Name = "btnsuppliers"
        Me.btnsuppliers.Size = New System.Drawing.Size(79, 41)
        Me.btnsuppliers.TabIndex = 18
        Me.btnsuppliers.Text = "Add More Suppliers"
        Me.btnsuppliers.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Select Item"
        '
        'cboitemselect
        '
        Me.cboitemselect.FormattingEnabled = True
        Me.cboitemselect.Location = New System.Drawing.Point(4, 241)
        Me.cboitemselect.Name = "cboitemselect"
        Me.cboitemselect.Size = New System.Drawing.Size(166, 21)
        Me.cboitemselect.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 371)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Order Date"
        '
        'dtporderdate
        '
        Me.dtporderdate.CustomFormat = "yyyy-MM-dd"
        Me.dtporderdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtporderdate.Location = New System.Drawing.Point(100, 367)
        Me.dtporderdate.Name = "dtporderdate"
        Me.dtporderdate.Size = New System.Drawing.Size(144, 20)
        Me.dtporderdate.TabIndex = 76
        '
        'txtpartname
        '
        Me.txtpartname.Location = New System.Drawing.Point(77, 303)
        Me.txtpartname.Name = "txtpartname"
        Me.txtpartname.ReadOnly = True
        Me.txtpartname.Size = New System.Drawing.Size(136, 20)
        Me.txtpartname.TabIndex = 81
        '
        'txtpartnum
        '
        Me.txtpartnum.Location = New System.Drawing.Point(77, 271)
        Me.txtpartnum.Name = "txtpartnum"
        Me.txtpartnum.ReadOnly = True
        Me.txtpartnum.Size = New System.Drawing.Size(136, 20)
        Me.txtpartnum.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Part Number"
        '
        'txtquantityord
        '
        Me.txtquantityord.Location = New System.Drawing.Point(100, 338)
        Me.txtquantityord.Name = "txtquantityord"
        Me.txtquantityord.Size = New System.Drawing.Size(144, 20)
        Me.txtquantityord.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Quantity Ordered"
        '
        'txtsuppliername
        '
        Me.txtsuppliername.Location = New System.Drawing.Point(368, 333)
        Me.txtsuppliername.Name = "txtsuppliername"
        Me.txtsuppliername.ReadOnly = True
        Me.txtsuppliername.Size = New System.Drawing.Size(124, 20)
        Me.txtsuppliername.TabIndex = 85
        '
        'txtsupplieraddress
        '
        Me.txtsupplieraddress.Location = New System.Drawing.Point(368, 367)
        Me.txtsupplieraddress.Name = "txtsupplieraddress"
        Me.txtsupplieraddress.ReadOnly = True
        Me.txtsupplieraddress.Size = New System.Drawing.Size(124, 20)
        Me.txtsupplieraddress.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Supplier ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Supplier Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Supplier Address"
        '
        'btnaddpurchace
        '
        Me.btnaddpurchace.Location = New System.Drawing.Point(480, 406)
        Me.btnaddpurchace.Name = "btnaddpurchace"
        Me.btnaddpurchace.Size = New System.Drawing.Size(75, 55)
        Me.btnaddpurchace.TabIndex = 90
        Me.btnaddpurchace.Text = "Add to Purchace Order"
        Me.btnaddpurchace.UseVisualStyleBackColor = True
        '
        'lstpurchace
        '
        Me.lstpurchace.FormattingEnabled = True
        Me.lstpurchace.Location = New System.Drawing.Point(8, 401)
        Me.lstpurchace.Name = "lstpurchace"
        Me.lstpurchace.Size = New System.Drawing.Size(445, 121)
        Me.lstpurchace.TabIndex = 91
        '
        'btnloadpurchace
        '
        Me.btnloadpurchace.Location = New System.Drawing.Point(480, 467)
        Me.btnloadpurchace.Name = "btnloadpurchace"
        Me.btnloadpurchace.Size = New System.Drawing.Size(75, 55)
        Me.btnloadpurchace.TabIndex = 92
        Me.btnloadpurchace.Text = "Load"
        Me.btnloadpurchace.UseVisualStyleBackColor = True
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(80, 89)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.ReadOnly = True
        Me.txtdescription.Size = New System.Drawing.Size(95, 20)
        Me.txtdescription.TabIndex = 96
        '
        'txtpartid
        '
        Me.txtpartid.Location = New System.Drawing.Point(80, 57)
        Me.txtpartid.Name = "txtpartid"
        Me.txtpartid.ReadOnly = True
        Me.txtpartid.Size = New System.Drawing.Size(95, 20)
        Me.txtpartid.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-1, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Description"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(-1, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Part Number"
        '
        'txtstocklevel
        '
        Me.txtstocklevel.Location = New System.Drawing.Point(80, 115)
        Me.txtstocklevel.Name = "txtstocklevel"
        Me.txtstocklevel.Size = New System.Drawing.Size(95, 20)
        Me.txtstocklevel.TabIndex = 97
        '
        'txtreorder
        '
        Me.txtreorder.Location = New System.Drawing.Point(80, 141)
        Me.txtreorder.Name = "txtreorder"
        Me.txtreorder.Size = New System.Drawing.Size(95, 20)
        Me.txtreorder.TabIndex = 98
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Stock Level"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(0, 148)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Reorder Level"
        '
        'btnloadsupplier
        '
        Me.btnloadsupplier.Location = New System.Drawing.Point(389, 280)
        Me.btnloadsupplier.Name = "btnloadsupplier"
        Me.btnloadsupplier.Size = New System.Drawing.Size(78, 39)
        Me.btnloadsupplier.TabIndex = 101
        Me.btnloadsupplier.Text = "Load Supplier info"
        Me.btnloadsupplier.UseVisualStyleBackColor = True
        '
        'cbosupplierid
        '
        Me.cbosupplierid.FormattingEnabled = True
        Me.cbosupplierid.Location = New System.Drawing.Point(368, 252)
        Me.cbosupplierid.Name = "cbosupplierid"
        Me.cbosupplierid.Size = New System.Drawing.Size(121, 21)
        Me.cbosupplierid.TabIndex = 102
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(181, 127)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(128, 40)
        Me.btnupdate.TabIndex = 103
        Me.btnupdate.Text = "UpDate Stock/Reorder Levels"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnloadstock
        '
        Me.btnloadstock.Location = New System.Drawing.Point(485, 126)
        Me.btnloadstock.Name = "btnloadstock"
        Me.btnloadstock.Size = New System.Drawing.Size(79, 41)
        Me.btnloadstock.TabIndex = 104
        Me.btnloadstock.Text = "Load Records"
        Me.btnloadstock.UseVisualStyleBackColor = True
        '
        'frmpurchacestock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 524)
        Me.Controls.Add(Me.btnloadstock)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.cbosupplierid)
        Me.Controls.Add(Me.btnloadsupplier)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtreorder)
        Me.Controls.Add(Me.txtstocklevel)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.txtpartid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnloadpurchace)
        Me.Controls.Add(Me.lstpurchace)
        Me.Controls.Add(Me.btnaddpurchace)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsupplieraddress)
        Me.Controls.Add(Me.txtsuppliername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtquantityord)
        Me.Controls.Add(Me.txtpartname)
        Me.Controls.Add(Me.txtpartnum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtporderdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboitemselect)
        Me.Controls.Add(Me.btnsuppliers)
        Me.Controls.Add(Me.btnaddparts)
        Me.Controls.Add(Me.lstpartdetails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboitem)
        Me.Name = "frmpurchacestock"
        Me.Text = "Purchace/Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cboitem As ComboBox
    Friend WithEvents lstpartdetails As ListBox
    Friend WithEvents btnaddparts As Button
    Friend WithEvents btnsuppliers As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboitemselect As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtporderdate As DateTimePicker
    Friend WithEvents txtpartname As TextBox
    Friend WithEvents txtpartnum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtquantityord As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsuppliername As TextBox
    Friend WithEvents txtsupplieraddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnaddpurchace As Button
    Friend WithEvents lstpurchace As ListBox
    Friend WithEvents btnloadpurchace As Button
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents txtpartid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtstocklevel As TextBox
    Friend WithEvents txtreorder As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnloadsupplier As Button
    Friend WithEvents cbosupplierid As ComboBox
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnloadstock As Button
End Class
