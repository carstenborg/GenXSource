<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuGenComplexOperationsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.subtraction = New System.Windows.Forms.Button
        Me.clear = New System.Windows.Forms.Button
        Me.y1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.res_y = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.res_x = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.y2 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.x2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.x1 = New System.Windows.Forms.TextBox
        Me.addition = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SystemOfCoordinateMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.subtraction)
        Me.GroupBox2.Controls.Add(Me.clear)
        Me.GroupBox2.Controls.Add(Me.y1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.res_y)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.res_x)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.y2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.x2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.x1)
        Me.GroupBox2.Controls.Add(Me.addition)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(27, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(507, 174)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'subtraction
        '
        Me.subtraction.Location = New System.Drawing.Point(211, 73)
        Me.subtraction.Name = "subtraction"
        Me.subtraction.Size = New System.Drawing.Size(125, 30)
        Me.subtraction.TabIndex = 6
        Me.subtraction.Text = "Subtraction"
        Me.subtraction.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(211, 115)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(125, 30)
        Me.clear.TabIndex = 7
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'y1
        '
        Me.y1.Location = New System.Drawing.Point(132, 62)
        Me.y1.Name = "y1"
        Me.y1.Size = New System.Drawing.Size(54, 20)
        Me.y1.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(17, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Enter Value Of Y1"
        '
        'res_y
        '
        Me.res_y.Enabled = False
        Me.res_y.Location = New System.Drawing.Point(433, 85)
        Me.res_y.Name = "res_y"
        Me.res_y.Size = New System.Drawing.Size(54, 20)
        Me.res_y.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(363, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Result Y"
        '
        'res_x
        '
        Me.res_x.Enabled = False
        Me.res_x.Location = New System.Drawing.Point(433, 51)
        Me.res_x.Name = "res_x"
        Me.res_x.Size = New System.Drawing.Size(54, 20)
        Me.res_x.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Window
        Me.Label11.Location = New System.Drawing.Point(363, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Result X"
        '
        'y2
        '
        Me.y2.Enabled = False
        Me.y2.Location = New System.Drawing.Point(132, 127)
        Me.y2.Name = "y2"
        Me.y2.Size = New System.Drawing.Size(54, 20)
        Me.y2.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Window
        Me.Label12.Location = New System.Drawing.Point(17, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Enter Value Of Y2"
        '
        'x2
        '
        Me.x2.Location = New System.Drawing.Point(132, 92)
        Me.x2.Name = "x2"
        Me.x2.Size = New System.Drawing.Size(54, 20)
        Me.x2.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Window
        Me.Label13.Location = New System.Drawing.Point(17, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Enter Value Of X2"
        '
        'x1
        '
        Me.x1.Location = New System.Drawing.Point(132, 28)
        Me.x1.Name = "x1"
        Me.x1.Size = New System.Drawing.Size(54, 20)
        Me.x1.TabIndex = 1
        '
        'addition
        '
        Me.addition.Location = New System.Drawing.Point(211, 28)
        Me.addition.Name = "addition"
        Me.addition.Size = New System.Drawing.Size(125, 30)
        Me.addition.TabIndex = 5
        Me.addition.Text = "Addition"
        Me.addition.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Window
        Me.Label14.Location = New System.Drawing.Point(17, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Enter Value Of  X1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(576, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemOfCoordinateMenuToolStripMenuItem, Me.MainMenuToolStripMenuItem})
        Me.BackToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.BackToolStripMenuItem.Text = " &Back"
        '
        'SystemOfCoordinateMenuToolStripMenuItem
        '
        Me.SystemOfCoordinateMenuToolStripMenuItem.Name = "SystemOfCoordinateMenuToolStripMenuItem"
        Me.SystemOfCoordinateMenuToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.SystemOfCoordinateMenuToolStripMenuItem.Text = "System Of Co-ordinate Menu"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'NuGenComplexOperationsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(576, 272)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "NuGenComplexOperationsForm"
        Me.Text = "NuGenComplexOperationsForm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents y1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents res_y As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents res_x As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents y2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents x2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents x1 As System.Windows.Forms.TextBox
    Friend WithEvents addition As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemOfCoordinateMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subtraction As System.Windows.Forms.Button
End Class
