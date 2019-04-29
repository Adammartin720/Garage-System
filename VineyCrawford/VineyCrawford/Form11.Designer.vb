<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnmenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnaddsupplier = New System.Windows.Forms.Button()
        Me.btncashrefund = New System.Windows.Forms.Button()
        Me.btncreditsale = New System.Windows.Forms.Button()
        Me.btncashsalr = New System.Windows.Forms.Button()
        Me.btnaddcustomer = New System.Windows.Forms.Button()
        Me.btncredit = New System.Windows.Forms.Button()
        Me.btncash = New System.Windows.Forms.Button()
        Me.btnstock = New System.Windows.Forms.Button()
        Me.btncreditnote = New System.Windows.Forms.Button()
        Me.btnaddpart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Viney And Crawford MENU"
        '
        'btnaddsupplier
        '
        Me.btnaddsupplier.Location = New System.Drawing.Point(12, 57)
        Me.btnaddsupplier.Name = "btnaddsupplier"
        Me.btnaddsupplier.Size = New System.Drawing.Size(79, 44)
        Me.btnaddsupplier.TabIndex = 1
        Me.btnaddsupplier.Text = "Add Supplier"
        Me.btnaddsupplier.UseVisualStyleBackColor = True
        '
        'btncashrefund
        '
        Me.btncashrefund.Location = New System.Drawing.Point(12, 207)
        Me.btncashrefund.Name = "btncashrefund"
        Me.btncashrefund.Size = New System.Drawing.Size(79, 44)
        Me.btncashrefund.TabIndex = 2
        Me.btncashrefund.Text = "Cash Refund"
        Me.btncashrefund.UseVisualStyleBackColor = True
        '
        'btncreditsale
        '
        Me.btncreditsale.Location = New System.Drawing.Point(97, 157)
        Me.btncreditsale.Name = "btncreditsale"
        Me.btncreditsale.Size = New System.Drawing.Size(79, 44)
        Me.btncreditsale.TabIndex = 3
        Me.btncreditsale.Text = "Credit Sale"
        Me.btncreditsale.UseVisualStyleBackColor = True
        '
        'btncashsalr
        '
        Me.btncashsalr.Location = New System.Drawing.Point(12, 157)
        Me.btncashsalr.Name = "btncashsalr"
        Me.btncashsalr.Size = New System.Drawing.Size(79, 44)
        Me.btncashsalr.TabIndex = 4
        Me.btncashsalr.Text = "Cash Sale"
        Me.btncashsalr.UseVisualStyleBackColor = True
        '
        'btnaddcustomer
        '
        Me.btnaddcustomer.Location = New System.Drawing.Point(97, 57)
        Me.btnaddcustomer.Name = "btnaddcustomer"
        Me.btnaddcustomer.Size = New System.Drawing.Size(79, 44)
        Me.btnaddcustomer.TabIndex = 5
        Me.btnaddcustomer.Text = "Add Customer"
        Me.btnaddcustomer.UseVisualStyleBackColor = True
        '
        'btncredit
        '
        Me.btncredit.Location = New System.Drawing.Point(97, 107)
        Me.btncredit.Name = "btncredit"
        Me.btncredit.Size = New System.Drawing.Size(79, 44)
        Me.btncredit.TabIndex = 6
        Me.btncredit.Text = "Credit Picking List"
        Me.btncredit.UseVisualStyleBackColor = True
        '
        'btncash
        '
        Me.btncash.Location = New System.Drawing.Point(12, 107)
        Me.btncash.Name = "btncash"
        Me.btncash.Size = New System.Drawing.Size(79, 44)
        Me.btncash.TabIndex = 7
        Me.btncash.Text = "Cash Picking List"
        Me.btncash.UseVisualStyleBackColor = True
        '
        'btnstock
        '
        Me.btnstock.Location = New System.Drawing.Point(12, 262)
        Me.btnstock.Name = "btnstock"
        Me.btnstock.Size = New System.Drawing.Size(79, 58)
        Me.btnstock.TabIndex = 8
        Me.btnstock.Text = "Purchace Stock/ Stock Records"
        Me.btnstock.UseVisualStyleBackColor = True
        '
        'btncreditnote
        '
        Me.btncreditnote.Location = New System.Drawing.Point(98, 207)
        Me.btncreditnote.Name = "btncreditnote"
        Me.btncreditnote.Size = New System.Drawing.Size(78, 44)
        Me.btncreditnote.TabIndex = 9
        Me.btncreditnote.Text = "Credit Note"
        Me.btncreditnote.UseVisualStyleBackColor = True
        '
        'btnaddpart
        '
        Me.btnaddpart.Location = New System.Drawing.Point(182, 57)
        Me.btnaddpart.Name = "btnaddpart"
        Me.btnaddpart.Size = New System.Drawing.Size(78, 44)
        Me.btnaddpart.TabIndex = 10
        Me.btnaddpart.Text = "Add Part"
        Me.btnaddpart.UseVisualStyleBackColor = True
        '
        'frnmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 332)
        Me.Controls.Add(Me.btnaddpart)
        Me.Controls.Add(Me.btncreditnote)
        Me.Controls.Add(Me.btnstock)
        Me.Controls.Add(Me.btncash)
        Me.Controls.Add(Me.btncredit)
        Me.Controls.Add(Me.btnaddcustomer)
        Me.Controls.Add(Me.btncashsalr)
        Me.Controls.Add(Me.btncreditsale)
        Me.Controls.Add(Me.btncashrefund)
        Me.Controls.Add(Me.btnaddsupplier)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frnmenu"
        Me.Text = "Viney CrawFord Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnaddsupplier As Button
    Friend WithEvents btncashrefund As Button
    Friend WithEvents btncreditsale As Button
    Friend WithEvents btncashsalr As Button
    Friend WithEvents btnaddcustomer As Button
    Friend WithEvents btncredit As Button
    Friend WithEvents btncash As Button
    Friend WithEvents btnstock As Button
    Friend WithEvents btncreditnote As Button
    Friend WithEvents btnaddpart As Button
End Class
