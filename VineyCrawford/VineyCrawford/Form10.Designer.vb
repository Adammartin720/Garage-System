<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddparts
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
        Me.grppart = New System.Windows.Forms.GroupBox()
        Me.cbosupplierid = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtreorder = New System.Windows.Forms.TextBox()
        Me.txtstocklevel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpartid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbopartname = New System.Windows.Forms.ComboBox()
        Me.grppart.SuspendLayout()
        Me.SuspendLayout()
        '
        'grppart
        '
        Me.grppart.Controls.Add(Me.cbosupplierid)
        Me.grppart.Controls.Add(Me.Label7)
        Me.grppart.Controls.Add(Me.txtreorder)
        Me.grppart.Controls.Add(Me.txtstocklevel)
        Me.grppart.Controls.Add(Me.Label6)
        Me.grppart.Controls.Add(Me.Label5)
        Me.grppart.Controls.Add(Me.btnadd)
        Me.grppart.Controls.Add(Me.txtunitprice)
        Me.grppart.Controls.Add(Me.Label1)
        Me.grppart.Controls.Add(Me.Label2)
        Me.grppart.Controls.Add(Me.txtdescription)
        Me.grppart.Controls.Add(Me.Label3)
        Me.grppart.Controls.Add(Me.txtpartid)
        Me.grppart.Location = New System.Drawing.Point(12, 66)
        Me.grppart.Name = "grppart"
        Me.grppart.Size = New System.Drawing.Size(419, 280)
        Me.grppart.TabIndex = 11
        Me.grppart.TabStop = False
        Me.grppart.Text = "Part Details"
        '
        'cbosupplierid
        '
        Me.cbosupplierid.FormattingEnabled = True
        Me.cbosupplierid.Location = New System.Drawing.Point(96, 253)
        Me.cbosupplierid.Name = "cbosupplierid"
        Me.cbosupplierid.Size = New System.Drawing.Size(167, 21)
        Me.cbosupplierid.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Supplier ID"
        '
        'txtreorder
        '
        Me.txtreorder.Location = New System.Drawing.Point(96, 215)
        Me.txtreorder.Name = "txtreorder"
        Me.txtreorder.Size = New System.Drawing.Size(167, 20)
        Me.txtreorder.TabIndex = 13
        '
        'txtstocklevel
        '
        Me.txtstocklevel.Location = New System.Drawing.Point(96, 172)
        Me.txtstocklevel.Name = "txtstocklevel"
        Me.txtstocklevel.Size = New System.Drawing.Size(167, 20)
        Me.txtstocklevel.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Reorder Level"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Stock Level"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(307, 19)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(95, 37)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtunitprice
        '
        Me.txtunitprice.Location = New System.Drawing.Point(96, 126)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.Size = New System.Drawing.Size(167, 20)
        Me.txtunitprice.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Part ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description"
        '
        'txtdescription
        '
        Me.txtdescription.Location = New System.Drawing.Point(96, 79)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(167, 20)
        Me.txtdescription.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Unit Price"
        '
        'txtpartid
        '
        Me.txtpartid.Location = New System.Drawing.Point(96, 37)
        Me.txtpartid.Name = "txtpartid"
        Me.txtpartid.Size = New System.Drawing.Size(167, 20)
        Me.txtpartid.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Please Select Part"
        '
        'cbopartname
        '
        Me.cbopartname.FormattingEnabled = True
        Me.cbopartname.Location = New System.Drawing.Point(12, 26)
        Me.cbopartname.Name = "cbopartname"
        Me.cbopartname.Size = New System.Drawing.Size(165, 21)
        Me.cbopartname.TabIndex = 9
        '
        'frmaddparts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 358)
        Me.Controls.Add(Me.grppart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbopartname)
        Me.Name = "frmaddparts"
        Me.Text = "Add Parts"
        Me.grppart.ResumeLayout(False)
        Me.grppart.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grppart As GroupBox
    Friend WithEvents btnadd As Button
    Friend WithEvents txtunitprice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpartid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbopartname As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbosupplierid As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtreorder As TextBox
    Friend WithEvents txtstocklevel As TextBox
End Class
