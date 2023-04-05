<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.grpDonutChoices = New System.Windows.Forms.GroupBox()
        Me.radFilled = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radSugar = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.grpCoffeeChoices = New System.Windows.Forms.GroupBox()
        Me.radCappuccino = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpDonutChoices.SuspendLayout()
        Me.grpCoffeeChoices.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(123, 30)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(108, 25)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "Subtotal"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalesTax
        '
        Me.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalesTax.Location = New System.Drawing.Point(123, 73)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(108, 25)
        Me.lblSalesTax.TabIndex = 1
        Me.lblSalesTax.Text = "Sales Tax"
        Me.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(123, 116)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(108, 25)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpDonutChoices
        '
        Me.grpDonutChoices.Controls.Add(Me.radFilled)
        Me.grpDonutChoices.Controls.Add(Me.radChocolate)
        Me.grpDonutChoices.Controls.Add(Me.radSugar)
        Me.grpDonutChoices.Controls.Add(Me.radGlazed)
        Me.grpDonutChoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDonutChoices.Location = New System.Drawing.Point(67, 84)
        Me.grpDonutChoices.Name = "grpDonutChoices"
        Me.grpDonutChoices.Size = New System.Drawing.Size(200, 143)
        Me.grpDonutChoices.TabIndex = 3
        Me.grpDonutChoices.TabStop = False
        Me.grpDonutChoices.Text = "Donut Choices"
        '
        'radFilled
        '
        Me.radFilled.AutoSize = True
        Me.radFilled.Location = New System.Drawing.Point(17, 100)
        Me.radFilled.Name = "radFilled"
        Me.radFilled.Size = New System.Drawing.Size(147, 29)
        Me.radFilled.TabIndex = 3
        Me.radFilled.TabStop = True
        Me.radFilled.Text = "&Filled ($1.50)"
        Me.radFilled.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(17, 74)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(190, 29)
        Me.radChocolate.TabIndex = 2
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "&Chocolate ($1.25)"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radSugar
        '
        Me.radSugar.AutoSize = True
        Me.radSugar.Location = New System.Drawing.Point(17, 48)
        Me.radSugar.Name = "radSugar"
        Me.radSugar.Size = New System.Drawing.Size(154, 29)
        Me.radSugar.TabIndex = 1
        Me.radSugar.TabStop = True
        Me.radSugar.Text = "&Sugar ($1.05)"
        Me.radSugar.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(17, 21)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(163, 29)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "&Glazed ($1.05)"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'grpCoffeeChoices
        '
        Me.grpCoffeeChoices.Controls.Add(Me.radCappuccino)
        Me.grpCoffeeChoices.Controls.Add(Me.radRegular)
        Me.grpCoffeeChoices.Controls.Add(Me.radNone)
        Me.grpCoffeeChoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCoffeeChoices.Location = New System.Drawing.Point(67, 259)
        Me.grpCoffeeChoices.Name = "grpCoffeeChoices"
        Me.grpCoffeeChoices.Size = New System.Drawing.Size(200, 143)
        Me.grpCoffeeChoices.TabIndex = 4
        Me.grpCoffeeChoices.TabStop = False
        Me.grpCoffeeChoices.Text = "Coffee Choices"
        '
        'radCappuccino
        '
        Me.radCappuccino.AutoSize = True
        Me.radCappuccino.Location = New System.Drawing.Point(17, 74)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(206, 29)
        Me.radCappuccino.TabIndex = 2
        Me.radCappuccino.TabStop = True
        Me.radCappuccino.Text = "Ca&ppuccino ($2.75)"
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(17, 48)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(168, 29)
        Me.radRegular.TabIndex = 1
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "&Regular ($1.50)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(17, 21)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(80, 29)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "&None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(411, 280)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(136, 44)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(411, 330)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 44)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblSubtotal)
        Me.GroupBox1.Controls.Add(Me.lblSalesTax)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(372, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 149)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Subtotal:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(19, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sales Tax:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(19, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Due:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(183, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(435, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Our Donuts and Coffee are the best in town!"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpCoffeeChoices)
        Me.Controls.Add(Me.grpDonutChoices)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.grpDonutChoices.ResumeLayout(False)
        Me.grpDonutChoices.PerformLayout()
        Me.grpCoffeeChoices.ResumeLayout(False)
        Me.grpCoffeeChoices.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents grpDonutChoices As GroupBox
    Friend WithEvents radFilled As RadioButton
    Friend WithEvents radChocolate As RadioButton
    Friend WithEvents radSugar As RadioButton
    Friend WithEvents radGlazed As RadioButton
    Friend WithEvents grpCoffeeChoices As GroupBox
    Friend WithEvents radCappuccino As RadioButton
    Friend WithEvents radRegular As RadioButton
    Friend WithEvents radNone As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
