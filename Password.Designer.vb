<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Password))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ResetNetworkIntefaceButton = New System.Windows.Forms.Button()
        Me.NewIPAddressGroupBox = New System.Windows.Forms.GroupBox()
        Me.IPAddressTabControl = New System.Windows.Forms.TabControl()
        Me.AutoIP = New System.Windows.Forms.TabPage()
        Me.AutoIP4TextBox = New System.Windows.Forms.TextBox()
        Me.AutoIP3TextBox = New System.Windows.Forms.TextBox()
        Me.AutoIP2TextBox = New System.Windows.Forms.TextBox()
        Me.AutoIPButton = New System.Windows.Forms.Button()
        Me.AutoIP1TextBox = New System.Windows.Forms.TextBox()
        Me.ManualIP = New System.Windows.Forms.TabPage()
        Me.ManualIP4TextBox = New System.Windows.Forms.TextBox()
        Me.ManualIP3TextBox = New System.Windows.Forms.TextBox()
        Me.ManualIP1TextBox = New System.Windows.Forms.TextBox()
        Me.ManualIP2TextBox = New System.Windows.Forms.TextBox()
        Me.UpdateNetworkInterfaceButton = New System.Windows.Forms.Button()
        Me.InterfaceComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.NewIPAddressGroupBox.SuspendLayout()
        Me.IPAddressTabControl.SuspendLayout()
        Me.AutoIP.SuspendLayout()
        Me.ManualIP.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(401, 23)
        Me.TextBox1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter Your Password To Unlock IP Assigner :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(338, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Unlock"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ResetNetworkIntefaceButton)
        Me.GroupBox1.Controls.Add(Me.NewIPAddressGroupBox)
        Me.GroupBox1.Controls.Add(Me.UpdateNetworkInterfaceButton)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 249)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IP Assignment"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 93)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saved Presets By ID"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(7, 23)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(374, 64)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'ResetNetworkIntefaceButton
        '
        Me.ResetNetworkIntefaceButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResetNetworkIntefaceButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetNetworkIntefaceButton.Location = New System.Drawing.Point(238, 214)
        Me.ResetNetworkIntefaceButton.Name = "ResetNetworkIntefaceButton"
        Me.ResetNetworkIntefaceButton.Size = New System.Drawing.Size(157, 29)
        Me.ResetNetworkIntefaceButton.TabIndex = 35
        Me.ResetNetworkIntefaceButton.Text = "Reset Network Inteface"
        Me.ResetNetworkIntefaceButton.UseVisualStyleBackColor = True
        '
        'NewIPAddressGroupBox
        '
        Me.NewIPAddressGroupBox.Controls.Add(Me.IPAddressTabControl)
        Me.NewIPAddressGroupBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewIPAddressGroupBox.Location = New System.Drawing.Point(7, 22)
        Me.NewIPAddressGroupBox.Name = "NewIPAddressGroupBox"
        Me.NewIPAddressGroupBox.Size = New System.Drawing.Size(387, 86)
        Me.NewIPAddressGroupBox.TabIndex = 6
        Me.NewIPAddressGroupBox.TabStop = False
        Me.NewIPAddressGroupBox.Text = "New IP Address"
        '
        'IPAddressTabControl
        '
        Me.IPAddressTabControl.Controls.Add(Me.AutoIP)
        Me.IPAddressTabControl.Controls.Add(Me.ManualIP)
        Me.IPAddressTabControl.Location = New System.Drawing.Point(7, 16)
        Me.IPAddressTabControl.Name = "IPAddressTabControl"
        Me.IPAddressTabControl.SelectedIndex = 0
        Me.IPAddressTabControl.Size = New System.Drawing.Size(374, 64)
        Me.IPAddressTabControl.TabIndex = 0
        '
        'AutoIP
        '
        Me.AutoIP.Controls.Add(Me.AutoIP4TextBox)
        Me.AutoIP.Controls.Add(Me.AutoIP3TextBox)
        Me.AutoIP.Controls.Add(Me.AutoIP2TextBox)
        Me.AutoIP.Controls.Add(Me.AutoIPButton)
        Me.AutoIP.Controls.Add(Me.AutoIP1TextBox)
        Me.AutoIP.Location = New System.Drawing.Point(4, 24)
        Me.AutoIP.Name = "AutoIP"
        Me.AutoIP.Size = New System.Drawing.Size(366, 36)
        Me.AutoIP.TabIndex = 0
        Me.AutoIP.Text = "Auto"
        Me.AutoIP.UseVisualStyleBackColor = True
        '
        'AutoIP4TextBox
        '
        Me.AutoIP4TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoIP4TextBox.Location = New System.Drawing.Point(213, 7)
        Me.AutoIP4TextBox.Name = "AutoIP4TextBox"
        Me.AutoIP4TextBox.Size = New System.Drawing.Size(34, 23)
        Me.AutoIP4TextBox.TabIndex = 5
        '
        'AutoIP3TextBox
        '
        Me.AutoIP3TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoIP3TextBox.Location = New System.Drawing.Point(173, 7)
        Me.AutoIP3TextBox.Name = "AutoIP3TextBox"
        Me.AutoIP3TextBox.Size = New System.Drawing.Size(34, 23)
        Me.AutoIP3TextBox.TabIndex = 4
        '
        'AutoIP2TextBox
        '
        Me.AutoIP2TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoIP2TextBox.Location = New System.Drawing.Point(133, 7)
        Me.AutoIP2TextBox.Name = "AutoIP2TextBox"
        Me.AutoIP2TextBox.Size = New System.Drawing.Size(34, 23)
        Me.AutoIP2TextBox.TabIndex = 3
        '
        'AutoIPButton
        '
        Me.AutoIPButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoIPButton.Location = New System.Drawing.Point(2, 4)
        Me.AutoIPButton.Name = "AutoIPButton"
        Me.AutoIPButton.Size = New System.Drawing.Size(85, 29)
        Me.AutoIPButton.TabIndex = 1
        Me.AutoIPButton.Text = "Auto IP"
        Me.AutoIPButton.UseVisualStyleBackColor = True
        '
        'AutoIP1TextBox
        '
        Me.AutoIP1TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoIP1TextBox.Location = New System.Drawing.Point(93, 7)
        Me.AutoIP1TextBox.Name = "AutoIP1TextBox"
        Me.AutoIP1TextBox.Size = New System.Drawing.Size(34, 23)
        Me.AutoIP1TextBox.TabIndex = 0
        '
        'ManualIP
        '
        Me.ManualIP.Controls.Add(Me.ManualIP4TextBox)
        Me.ManualIP.Controls.Add(Me.ManualIP3TextBox)
        Me.ManualIP.Controls.Add(Me.ManualIP1TextBox)
        Me.ManualIP.Controls.Add(Me.ManualIP2TextBox)
        Me.ManualIP.Location = New System.Drawing.Point(4, 24)
        Me.ManualIP.Name = "ManualIP"
        Me.ManualIP.Size = New System.Drawing.Size(366, 36)
        Me.ManualIP.TabIndex = 1
        Me.ManualIP.Text = "Manual"
        Me.ManualIP.UseVisualStyleBackColor = True
        '
        'ManualIP4TextBox
        '
        Me.ManualIP4TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualIP4TextBox.Location = New System.Drawing.Point(126, 7)
        Me.ManualIP4TextBox.Name = "ManualIP4TextBox"
        Me.ManualIP4TextBox.Size = New System.Drawing.Size(34, 23)
        Me.ManualIP4TextBox.TabIndex = 10
        '
        'ManualIP3TextBox
        '
        Me.ManualIP3TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualIP3TextBox.Location = New System.Drawing.Point(86, 7)
        Me.ManualIP3TextBox.Name = "ManualIP3TextBox"
        Me.ManualIP3TextBox.Size = New System.Drawing.Size(34, 23)
        Me.ManualIP3TextBox.TabIndex = 9
        '
        'ManualIP1TextBox
        '
        Me.ManualIP1TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualIP1TextBox.Location = New System.Drawing.Point(6, 7)
        Me.ManualIP1TextBox.Name = "ManualIP1TextBox"
        Me.ManualIP1TextBox.Size = New System.Drawing.Size(34, 23)
        Me.ManualIP1TextBox.TabIndex = 6
        '
        'ManualIP2TextBox
        '
        Me.ManualIP2TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManualIP2TextBox.Location = New System.Drawing.Point(46, 7)
        Me.ManualIP2TextBox.Name = "ManualIP2TextBox"
        Me.ManualIP2TextBox.Size = New System.Drawing.Size(34, 23)
        Me.ManualIP2TextBox.TabIndex = 8
        '
        'UpdateNetworkInterfaceButton
        '
        Me.UpdateNetworkInterfaceButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UpdateNetworkInterfaceButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateNetworkInterfaceButton.Location = New System.Drawing.Point(7, 214)
        Me.UpdateNetworkInterfaceButton.Name = "UpdateNetworkInterfaceButton"
        Me.UpdateNetworkInterfaceButton.Size = New System.Drawing.Size(157, 29)
        Me.UpdateNetworkInterfaceButton.TabIndex = 34
        Me.UpdateNetworkInterfaceButton.Text = "Update Network Inteface"
        Me.UpdateNetworkInterfaceButton.UseVisualStyleBackColor = True
        '
        'InterfaceComboBox
        '
        Me.InterfaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InterfaceComboBox.FormattingEnabled = True
        Me.InterfaceComboBox.Location = New System.Drawing.Point(72, 64)
        Me.InterfaceComboBox.MaxLength = 255
        Me.InterfaceComboBox.Name = "InterfaceComboBox"
        Me.InterfaceComboBox.Size = New System.Drawing.Size(260, 21)
        Me.InterfaceComboBox.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Interface : "
        '
        'Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 355)
        Me.Controls.Add(Me.InterfaceComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Password"
        Me.Text = "IP Assigner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.NewIPAddressGroupBox.ResumeLayout(False)
        Me.IPAddressTabControl.ResumeLayout(False)
        Me.AutoIP.ResumeLayout(False)
        Me.AutoIP.PerformLayout()
        Me.ManualIP.ResumeLayout(False)
        Me.ManualIP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NewIPAddressGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents IPAddressTabControl As System.Windows.Forms.TabControl
    Friend WithEvents AutoIP As System.Windows.Forms.TabPage
    Friend WithEvents AutoIP4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutoIP3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutoIP2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutoIPButton As System.Windows.Forms.Button
    Friend WithEvents AutoIP1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManualIP As System.Windows.Forms.TabPage
    Friend WithEvents ManualIP4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManualIP3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManualIP1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManualIP2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResetNetworkIntefaceButton As System.Windows.Forms.Button
    Friend WithEvents UpdateNetworkInterfaceButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents InterfaceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
