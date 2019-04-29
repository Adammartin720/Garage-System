<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddsupplier
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
        Me.cboSupplierName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsupplierid = New System.Windows.Forms.TextBox()
        Me.txtsuppliername = New System.Windows.Forms.TextBox()
        Me.txtsupplieraddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpsupplier = New System.Windows.Forms.GroupBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.grpsupplier.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboSupplierName
        '
        Me.cboSupplierName.FormattingEnabled = True
        Me.cboSupplierName.Location = New System.Drawing.Point(15, 28)
        Me.cboSupplierName.Name = "cboSupplierName"
        Me.cboSupplierName.Size = New System.Drawing.Size(165, 21)
        Me.cboSupplierName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Supplier ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Supplier Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Supplier Address"
        '
        'txtsupplierid
        '
        Me.txtsupplierid.Location = New System.Drawing.Point(96, 37)
        Me.txtsupplierid.Name = "txtsupplierid"
        Me.txtsupplierid.ReadOnly = True
        Me.txtsupplierid.Size = New System.Drawing.Size(167, 20)
        Me.txtsupplierid.TabIndex = 4
        '
        'txtsuppliername
        '
        Me.txtsuppliername.Location = New System.Drawing.Point(96, 79)
        Me.txtsuppliername.MaxLength = 30
        Me.txtsuppliername.Name = "txtsuppliername"
        Me.txtsuppliername.Size = New System.Drawing.Size(167, 20)
        Me.txtsuppliername.TabIndex = 5
        '
        'txtsupplieraddress
        '
        Me.txtsupplieraddress.Location = New System.Drawing.Point(96, 126)
        Me.txtsupplieraddress.MaxLength = 30
        Me.txtsupplieraddress.Name = "txtsupplieraddress"
        Me.txtsupplieraddress.Size = New System.Drawing.Size(167, 20)
        Me.txtsupplieraddress.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Please Select Supplier"
        '
        'grpsupplier
        '
        Me.grpsupplier.Controls.Add(Me.btndelete)
        Me.grpsupplier.Controls.Add(Me.btnedit)
        Me.grpsupplier.Controls.Add(Me.btnadd)
        Me.grpsupplier.Controls.Add(Me.txtsupplieraddress)
        Me.grpsupplier.Controls.Add(Me.Label1)
        Me.grpsupplier.Controls.Add(Me.Label2)
        Me.grpsupplier.Controls.Add(Me.txtsuppliername)
        Me.grpsupplier.Controls.Add(Me.Label3)
        Me.grpsupplier.Controls.Add(Me.txtsupplierid)
        Me.grpsupplier.Location = New System.Drawing.Point(15, 68)
        Me.grpsupplier.Name = "grpsupplier"
        Me.grpsupplier.Size = New System.Drawing.Size(419, 163)
        Me.grpsupplier.TabIndex = 8
        Me.grpsupplier.TabStop = False
        Me.grpsupplier.Text = "Supplier Details"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(307, 106)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(95, 33)
        Me.btndelete.TabIndex = 9
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(307, 63)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(95, 36)
        Me.btnedit.TabIndex = 8
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
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
        'frmaddsupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 241)
        Me.Controls.Add(Me.grpsupplier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboSupplierName)
        Me.Name = "frmaddsupplier"
        Me.Text = "Add Supplier"
        Me.grpsupplier.ResumeLayout(False)
        Me.grpsupplier.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboSupplierName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsupplierid As TextBox
    Friend WithEvents txtsuppliername As TextBox
    Friend WithEvents txtsupplieraddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents grpsupplier As GroupBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnadd As Button
End Class
