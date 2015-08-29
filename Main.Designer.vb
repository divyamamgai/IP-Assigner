<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.IPPresetGroupBox = New System.Windows.Forms.GroupBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.PresetNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.AlternateDNS4TextBox = New System.Windows.Forms.TextBox()
        Me.AlternateDNS3TextBox = New System.Windows.Forms.TextBox()
        Me.AlternateDNS2TextBox = New System.Windows.Forms.TextBox()
        Me.AlternateDNS1TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PreferredDNS4TextBox = New System.Windows.Forms.TextBox()
        Me.PreferredDNS3TextBox = New System.Windows.Forms.TextBox()
        Me.PreferredDNS2TextBox = New System.Windows.Forms.TextBox()
        Me.PreferredDNS1TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DefaultGateway4TextBox = New System.Windows.Forms.TextBox()
        Me.DefaultGateway3TextBox = New System.Windows.Forms.TextBox()
        Me.DefaultGateway2TextBox = New System.Windows.Forms.TextBox()
        Me.DefaultGateway1TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SubnetMask4TextBox = New System.Windows.Forms.TextBox()
        Me.SubnetMask3TextBox = New System.Windows.Forms.TextBox()
        Me.SubnetMask2TextBox = New System.Windows.Forms.TextBox()
        Me.SubnetMask1TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClearPresetFileButton = New System.Windows.Forms.Button()
        Me.RefreshPresetsButton = New System.Windows.Forms.Button()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InterfaceComboBox = New System.Windows.Forms.ComboBox()
        Me.ResetNetworkIntefaceButton = New System.Windows.Forms.Button()
        Me.IPPresetGroupBox.SuspendLayout()
        Me.NewIPAddressGroupBox.SuspendLayout()
        Me.IPAddressTabControl.SuspendLayout()
        Me.AutoIP.SuspendLayout()
        Me.ManualIP.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'IPPresetGroupBox
        '
        Me.IPPresetGroupBox.Controls.Add(Me.DeleteButton)
        Me.IPPresetGroupBox.Controls.Add(Me.PresetNameTextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.Label5)
        Me.IPPresetGroupBox.Controls.Add(Me.SaveButton)
        Me.IPPresetGroupBox.Controls.Add(Me.ResetButton)
        Me.IPPresetGroupBox.Controls.Add(Me.AlternateDNS4TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.AlternateDNS3TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.AlternateDNS2TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.AlternateDNS1TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.Label4)
        Me.IPPresetGroupBox.Controls.Add(Me.PreferredDNS4TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.PreferredDNS3TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.PreferredDNS2TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.PreferredDNS1TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.Label3)
        Me.IPPresetGroupBox.Controls.Add(Me.DefaultGateway4TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.DefaultGateway3TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.DefaultGateway2TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.DefaultGateway1TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.Label2)
        Me.IPPresetGroupBox.Controls.Add(Me.SubnetMask4TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.SubnetMask3TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.SubnetMask2TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.SubnetMask1TextBox)
        Me.IPPresetGroupBox.Controls.Add(Me.Label1)
        Me.IPPresetGroupBox.Enabled = False
        Me.IPPresetGroupBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPPresetGroupBox.Location = New System.Drawing.Point(12, 104)
        Me.IPPresetGroupBox.Name = "IPPresetGroupBox"
        Me.IPPresetGroupBox.Size = New System.Drawing.Size(387, 177)
        Me.IPPresetGroupBox.TabIndex = 0
        Me.IPPresetGroupBox.TabStop = False
        Me.IPPresetGroupBox.Text = "IP Preset"
        '
        'DeleteButton
        '
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(306, 107)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 29)
        Me.DeleteButton.TabIndex = 30
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'PresetNameTextBox
        '
        Me.PresetNameTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PresetNameTextBox.Location = New System.Drawing.Point(92, 23)
        Me.PresetNameTextBox.MaxLength = 255
        Me.PresetNameTextBox.Name = "PresetNameTextBox"
        Me.PresetNameTextBox.Size = New System.Drawing.Size(156, 23)
        Me.PresetNameTextBox.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Preset Name :"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(306, 72)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 29)
        Me.SaveButton.TabIndex = 27
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(306, 142)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 29)
        Me.ResetButton.TabIndex = 26
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'AlternateDNS4TextBox
        '
        Me.AlternateDNS4TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlternateDNS4TextBox.Location = New System.Drawing.Point(257, 148)
        Me.AlternateDNS4TextBox.MaxLength = 3
        Me.AlternateDNS4TextBox.Name = "AlternateDNS4TextBox"
        Me.AlternateDNS4TextBox.Size = New System.Drawing.Size(34, 23)
        Me.AlternateDNS4TextBox.TabIndex = 24
        '
        'AlternateDNS3TextBox
        '
        Me.AlternateDNS3TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlternateDNS3TextBox.Location = New System.Drawing.Point(217, 148)
        Me.AlternateDNS3TextBox.MaxLength = 3
        Me.AlternateDNS3TextBox.Name = "AlternateDNS3TextBox"
        Me.AlternateDNS3TextBox.Size = New System.Drawing.Size(34, 23)
        Me.AlternateDNS3TextBox.TabIndex = 23
        '
        'AlternateDNS2TextBox
        '
        Me.AlternateDNS2TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlternateDNS2TextBox.Location = New System.Drawing.Point(177, 148)
        Me.AlternateDNS2TextBox.MaxLength = 3
        Me.AlternateDNS2TextBox.Name = "AlternateDNS2TextBox"
        Me.AlternateDNS2TextBox.Size = New System.Drawing.Size(34, 23)
        Me.AlternateDNS2TextBox.TabIndex = 22
        '
        'AlternateDNS1TextBox
        '
        Me.AlternateDNS1TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlternateDNS1TextBox.Location = New System.Drawing.Point(137, 148)
        Me.AlternateDNS1TextBox.MaxLength = 3
        Me.AlternateDNS1TextBox.Name = "AlternateDNS1TextBox"
        Me.AlternateDNS1TextBox.Size = New System.Drawing.Size(34, 23)
        Me.AlternateDNS1TextBox.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Alternate DNS Server : "
        '
        'PreferredDNS4TextBox
        '
        Me.PreferredDNS4TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreferredDNS4TextBox.Location = New System.Drawing.Point(257, 116)
        Me.PreferredDNS4TextBox.MaxLength = 3
        Me.PreferredDNS4TextBox.Name = "PreferredDNS4TextBox"
        Me.PreferredDNS4TextBox.Size = New System.Drawing.Size(34, 23)
        Me.PreferredDNS4TextBox.TabIndex = 19
        '
        'PreferredDNS3TextBox
        '
        Me.PreferredDNS3TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreferredDNS3TextBox.Location = New System.Drawing.Point(217, 116)
        Me.PreferredDNS3TextBox.MaxLength = 3
        Me.PreferredDNS3TextBox.Name = "PreferredDNS3TextBox"
        Me.PreferredDNS3TextBox.Size = New System.Drawing.Size(34, 23)
        Me.PreferredDNS3TextBox.TabIndex = 18
        '
        'PreferredDNS2TextBox
        '
        Me.PreferredDNS2TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreferredDNS2TextBox.Location = New System.Drawing.Point(177, 116)
        Me.PreferredDNS2TextBox.MaxLength = 3
        Me.PreferredDNS2TextBox.Name = "PreferredDNS2TextBox"
        Me.PreferredDNS2TextBox.Size = New System.Drawing.Size(34, 23)
        Me.PreferredDNS2TextBox.TabIndex = 17
        '
        'PreferredDNS1TextBox
        '
        Me.PreferredDNS1TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreferredDNS1TextBox.Location = New System.Drawing.Point(137, 116)
        Me.PreferredDNS1TextBox.MaxLength = 3
        Me.PreferredDNS1TextBox.Name = "PreferredDNS1TextBox"
        Me.PreferredDNS1TextBox.Size = New System.Drawing.Size(34, 23)
        Me.PreferredDNS1TextBox.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Preferred DNS Server : "
        '
        'DefaultGateway4TextBox
        '
        Me.DefaultGateway4TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultGateway4TextBox.Location = New System.Drawing.Point(233, 84)
        Me.DefaultGateway4TextBox.MaxLength = 3
        Me.DefaultGateway4TextBox.Name = "DefaultGateway4TextBox"
        Me.DefaultGateway4TextBox.Size = New System.Drawing.Size(34, 23)
        Me.DefaultGateway4TextBox.TabIndex = 14
        '
        'DefaultGateway3TextBox
        '
        Me.DefaultGateway3TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultGateway3TextBox.Location = New System.Drawing.Point(193, 84)
        Me.DefaultGateway3TextBox.MaxLength = 3
        Me.DefaultGateway3TextBox.Name = "DefaultGateway3TextBox"
        Me.DefaultGateway3TextBox.Size = New System.Drawing.Size(34, 23)
        Me.DefaultGateway3TextBox.TabIndex = 13
        '
        'DefaultGateway2TextBox
        '
        Me.DefaultGateway2TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultGateway2TextBox.Location = New System.Drawing.Point(153, 84)
        Me.DefaultGateway2TextBox.MaxLength = 3
        Me.DefaultGateway2TextBox.Name = "DefaultGateway2TextBox"
        Me.DefaultGateway2TextBox.Size = New System.Drawing.Size(34, 23)
        Me.DefaultGateway2TextBox.TabIndex = 12
        '
        'DefaultGateway1TextBox
        '
        Me.DefaultGateway1TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultGateway1TextBox.Location = New System.Drawing.Point(113, 84)
        Me.DefaultGateway1TextBox.MaxLength = 3
        Me.DefaultGateway1TextBox.Name = "DefaultGateway1TextBox"
        Me.DefaultGateway1TextBox.Size = New System.Drawing.Size(34, 23)
        Me.DefaultGateway1TextBox.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Default Gateway : "
        '
        'SubnetMask4TextBox
        '
        Me.SubnetMask4TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubnetMask4TextBox.Location = New System.Drawing.Point(214, 52)
        Me.SubnetMask4TextBox.MaxLength = 3
        Me.SubnetMask4TextBox.Name = "SubnetMask4TextBox"
        Me.SubnetMask4TextBox.Size = New System.Drawing.Size(34, 23)
        Me.SubnetMask4TextBox.TabIndex = 9
        '
        'SubnetMask3TextBox
        '
        Me.SubnetMask3TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubnetMask3TextBox.Location = New System.Drawing.Point(174, 52)
        Me.SubnetMask3TextBox.MaxLength = 3
        Me.SubnetMask3TextBox.Name = "SubnetMask3TextBox"
        Me.SubnetMask3TextBox.Size = New System.Drawing.Size(34, 23)
        Me.SubnetMask3TextBox.TabIndex = 8
        '
        'SubnetMask2TextBox
        '
        Me.SubnetMask2TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubnetMask2TextBox.Location = New System.Drawing.Point(134, 52)
        Me.SubnetMask2TextBox.MaxLength = 3
        Me.SubnetMask2TextBox.Name = "SubnetMask2TextBox"
        Me.SubnetMask2TextBox.Size = New System.Drawing.Size(34, 23)
        Me.SubnetMask2TextBox.TabIndex = 7
        '
        'SubnetMask1TextBox
        '
        Me.SubnetMask1TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubnetMask1TextBox.Location = New System.Drawing.Point(94, 52)
        Me.SubnetMask1TextBox.MaxLength = 3
        Me.SubnetMask1TextBox.Name = "SubnetMask1TextBox"
        Me.SubnetMask1TextBox.Size = New System.Drawing.Size(34, 23)
        Me.SubnetMask1TextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subnet Mask : "
        '
        'ClearPresetFileButton
        '
        Me.ClearPresetFileButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearPresetFileButton.Location = New System.Drawing.Point(127, 234)
        Me.ClearPresetFileButton.Name = "ClearPresetFileButton"
        Me.ClearPresetFileButton.Size = New System.Drawing.Size(123, 29)
        Me.ClearPresetFileButton.TabIndex = 30
        Me.ClearPresetFileButton.Text = "Clear Preset File"
        Me.ClearPresetFileButton.UseVisualStyleBackColor = True
        '
        'RefreshPresetsButton
        '
        Me.RefreshPresetsButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshPresetsButton.Location = New System.Drawing.Point(6, 234)
        Me.RefreshPresetsButton.Name = "RefreshPresetsButton"
        Me.RefreshPresetsButton.Size = New System.Drawing.Size(115, 29)
        Me.RefreshPresetsButton.TabIndex = 25
        Me.RefreshPresetsButton.Text = "Refresh Presets"
        Me.RefreshPresetsButton.UseVisualStyleBackColor = True
        '
        'NewIPAddressGroupBox
        '
        Me.NewIPAddressGroupBox.Controls.Add(Me.IPAddressTabControl)
        Me.NewIPAddressGroupBox.Enabled = False
        Me.NewIPAddressGroupBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewIPAddressGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.NewIPAddressGroupBox.Name = "NewIPAddressGroupBox"
        Me.NewIPAddressGroupBox.Size = New System.Drawing.Size(387, 86)
        Me.NewIPAddressGroupBox.TabIndex = 1
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
        Me.UpdateNetworkInterfaceButton.Enabled = False
        Me.UpdateNetworkInterfaceButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateNetworkInterfaceButton.Location = New System.Drawing.Point(12, 287)
        Me.UpdateNetworkInterfaceButton.Name = "UpdateNetworkInterfaceButton"
        Me.UpdateNetworkInterfaceButton.Size = New System.Drawing.Size(157, 29)
        Me.UpdateNetworkInterfaceButton.TabIndex = 27
        Me.UpdateNetworkInterfaceButton.Text = "Update Network Inteface"
        Me.UpdateNetworkInterfaceButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ClearPresetFileButton)
        Me.GroupBox3.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox3.Controls.Add(Me.RefreshPresetsButton)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(405, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 269)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select The Preset You Want To Use : "
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(244, 212)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'AboutButton
        '
        Me.AboutButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutButton.Location = New System.Drawing.Point(338, 287)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(61, 29)
        Me.AboutButton.TabIndex = 31
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(407, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Interface : "
        '
        'InterfaceComboBox
        '
        Me.InterfaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InterfaceComboBox.FormattingEnabled = True
        Me.InterfaceComboBox.Location = New System.Drawing.Point(470, 292)
        Me.InterfaceComboBox.MaxLength = 255
        Me.InterfaceComboBox.Name = "InterfaceComboBox"
        Me.InterfaceComboBox.Size = New System.Drawing.Size(191, 21)
        Me.InterfaceComboBox.TabIndex = 32
        '
        'ResetNetworkIntefaceButton
        '
        Me.ResetNetworkIntefaceButton.Enabled = False
        Me.ResetNetworkIntefaceButton.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetNetworkIntefaceButton.Location = New System.Drawing.Point(175, 287)
        Me.ResetNetworkIntefaceButton.Name = "ResetNetworkIntefaceButton"
        Me.ResetNetworkIntefaceButton.Size = New System.Drawing.Size(157, 29)
        Me.ResetNetworkIntefaceButton.TabIndex = 33
        Me.ResetNetworkIntefaceButton.Text = "Reset Network Inteface"
        Me.ResetNetworkIntefaceButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 328)
        Me.Controls.Add(Me.ResetNetworkIntefaceButton)
        Me.Controls.Add(Me.InterfaceComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.UpdateNetworkInterfaceButton)
        Me.Controls.Add(Me.NewIPAddressGroupBox)
        Me.Controls.Add(Me.IPPresetGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "IP Assigner"
        Me.IPPresetGroupBox.ResumeLayout(False)
        Me.IPPresetGroupBox.PerformLayout()
        Me.NewIPAddressGroupBox.ResumeLayout(False)
        Me.IPAddressTabControl.ResumeLayout(False)
        Me.AutoIP.ResumeLayout(False)
        Me.AutoIP.PerformLayout()
        Me.ManualIP.ResumeLayout(False)
        Me.ManualIP.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IPPresetGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NewIPAddressGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents IPAddressTabControl As System.Windows.Forms.TabControl
    Friend WithEvents AutoIP As System.Windows.Forms.TabPage
    Friend WithEvents ManualIP As System.Windows.Forms.TabPage
    Friend WithEvents AutoIP1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutoIPButton As System.Windows.Forms.Button
    Friend WithEvents AutoIP4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutoIP3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AutoIP2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManualIP4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManualIP3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManualIP1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManualIP2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SubnetMask4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubnetMask3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubnetMask2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubnetMask1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DefaultGateway4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DefaultGateway3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DefaultGateway2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DefaultGateway1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PreferredDNS4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreferredDNS3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreferredDNS2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PreferredDNS1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AlternateDNS4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlternateDNS3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlternateDNS2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlternateDNS1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RefreshPresetsButton As System.Windows.Forms.Button
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents UpdateNetworkInterfaceButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents PresetNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ClearPresetFileButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents AboutButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents InterfaceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ResetNetworkIntefaceButton As System.Windows.Forms.Button

End Class
