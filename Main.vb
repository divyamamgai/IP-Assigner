Imports System.Text.RegularExpressions
Imports System.Text
Imports System.IO

Public Class Main

    Public ProgramDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\IP Assigner"
    Public PresetFilePath As String = ProgramDataPath & "\presets.bin"
    Public PresetTempFilePath As String = ProgramDataPath & "\_presets.bin"

    Public Structure PresetStruct
        Public Name As String
        Public SubnetMask As String
        Public DefaultGateway As String
        Public PrimaryDNS As String
        Public SecondaryDNS As String
    End Structure

    Public Structure InterfaceStruct
        Dim AdminState As String
        Dim State As String
        Dim Type As String
        Dim Name As String
    End Structure

    Enum IPType As Integer
        Auto
        Manual
    End Enum

    Public SystemIP As String
    Public SystemIPRaw() As String
    Public SystemPreset As New PresetStruct
    Public InterfaceList() As InterfaceStruct
    Public InterfaceCount As Integer
    Public SelectedInterfaceIndex As Integer
    Public SelectedIPType As IPType = IPType.Auto

    Public Function CheckForInterfaceAdapter(ByVal Input As String, Optional ByVal InterfaceName As String = "")
        If InterfaceName = "" Then
            For Count As Integer = 0 To InterfaceCount - 1
                If Input.Contains("adapter " & InterfaceList(Count).Name & ":") Then
                    Return True
                End If
            Next
        Else
            If Input.Contains("adapter " & InterfaceName & ":") Then
                Return True
            End If
        End If
        Return False
    End Function

    Public Function GetIP(ByVal InterfaceIndex As Integer) As String
        Dim IPAddress As String = ""
        Try
            Dim GetIPProcessOutput As String
            Dim GetIPProcess As Process = New Process
            With GetIPProcess
                .StartInfo.CreateNoWindow = True
                .StartInfo.RedirectStandardOutput = True
                .StartInfo.UseShellExecute = False
                .StartInfo.FileName = "cmd.exe"
                .StartInfo.Arguments = "/c ipconfig"
                .Start()
                GetIPProcessOutput = .StandardOutput.ReadToEnd
                .WaitForExit()
            End With
            Dim LineCount As Integer = 0
            Dim FoundInterface As Boolean = False
            For Each GetIPProcessOutputLine As String In GetIPProcessOutput.Split(CChar(vbCrLf))
                If GetIPProcessOutputLine.Trim() <> "" Then
                    If FoundInterface = False Then
                        If CheckForInterfaceAdapter(GetIPProcessOutputLine, InterfaceList(InterfaceIndex).Name) = True Then
                            FoundInterface = True
                        End If
                    Else
                        If CheckForInterfaceAdapter(GetIPProcessOutputLine) = True Then
                            FoundInterface = False
                            Exit For
                        Else
                            If GetIPProcessOutputLine.Contains("   IPv4 Address. . . . . . . . . . . :") Then
                                IPAddress = GetIPProcessOutputLine.Replace("   IPv4 Address. . . . . . . . . . . :", "").Trim()
                            End If
                        End If
                    End If
                    LineCount = LineCount + 1
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Exception : " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return IPAddress
    End Function

    Public Sub InitializeInterfaceList()
        Try
            Dim InitializeProcessOutput As String
            Dim InitializeProcess As Process = New Process
            With InitializeProcess
                .StartInfo.CreateNoWindow = True
                .StartInfo.RedirectStandardOutput = True
                .StartInfo.UseShellExecute = False
                .StartInfo.FileName = "cmd.exe"
                .StartInfo.Arguments = "/c netsh interface show interface"
                .Start()
                InitializeProcessOutput = .StandardOutput.ReadToEnd
                .WaitForExit()
            End With
            Dim LineCount As Integer = 0
            For Each InitializeProcessOutputLine As String In InitializeProcessOutput.Split(CChar(vbCrLf))
                If InitializeProcessOutputLine.Trim() <> "" Then
                    If LineCount >= 2 Then
                        Dim ElementCount As Integer = 0
                        ReDim Preserve InterfaceList(InterfaceCount)
                        InterfaceList(InterfaceCount) = New InterfaceStruct
                        For Each InitializeProcessOutputLineElement As String In Regex.Replace(InitializeProcessOutputLine, "\s{2,}", " ").Split(CChar(" "))
                            Select Case ElementCount
                                Case 0
                                    InterfaceList(InterfaceCount).AdminState = InitializeProcessOutputLineElement
                                Case 1
                                    InterfaceList(InterfaceCount).State = InitializeProcessOutputLineElement
                                Case 2
                                    InterfaceList(InterfaceCount).Type = InitializeProcessOutputLineElement
                                Case Else
                                    InterfaceList(InterfaceCount).Name = InterfaceList(InterfaceCount).Name & " " & InitializeProcessOutputLineElement
                            End Select
                            ElementCount = ElementCount + 1
                        Next
                        InterfaceList(InterfaceCount).Name = InterfaceList(InterfaceCount).Name.Trim()
                        InterfaceCount = InterfaceCount + 1
                    End If
                    LineCount = LineCount + 1
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Exception : " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadInterfaceList()
        For Count As Integer = 0 To InterfaceCount - 1
            InterfaceComboBox.Items.Add(InterfaceList(Count).Name)
        Next
    End Sub

    Private Sub InterfaceComboBoxChange() Handles InterfaceComboBox.SelectedIndexChanged
        SelectedInterfaceIndex = InterfaceComboBox.SelectedIndex
        SystemIP = GetIP(SelectedInterfaceIndex)
        SystemIPRaw = SystemIP.Split(".")
        PerformAutoIPSearch()
        NewIPAddressGroupBox.Enabled = True
        IPPresetGroupBox.Enabled = True
        UpdateNetworkInterfaceButton.Enabled = True
        ResetNetworkIntefaceButton.Enabled = True
    End Sub

    Public Function GetPresetCount() As Integer
        Try
            Dim Presets() As String = My.Computer.FileSystem.ReadAllText(PresetFilePath, System.Text.Encoding.ASCII).Split(New String() {vbCrLf}, StringSplitOptions.None)
            Return Presets.Length - 1
        Catch ex As Exception
            Try
                File.Create(PresetFilePath).Dispose()
                Return 0
            Catch _ex As Exception
                Directory.CreateDirectory(ProgramDataPath)
                File.Create(PresetFilePath).Dispose()
                Return 0
            End Try
        End Try
    End Function

    Public Function GetPreset(ByVal Index As Integer) As PresetStruct
        Try
            Dim Presets() As String = My.Computer.FileSystem.ReadAllText(PresetFilePath, System.Text.Encoding.ASCII).Split(New String() {vbCrLf}, StringSplitOptions.None)
            Dim Count As Integer = 0
            For Each Preset In Presets
                If Count = Index Then
                    Dim FoundedPreset As New PresetStruct
                    Dim PresetData() As String = Preset.Split("|")
                    If PresetData.Length = 5 Then
                        FoundedPreset.Name = PresetData(0)
                        FoundedPreset.SubnetMask = PresetData(1)
                        FoundedPreset.DefaultGateway = PresetData(2)
                        FoundedPreset.PrimaryDNS = PresetData(3)
                        FoundedPreset.SecondaryDNS = PresetData(4)
                        Return FoundedPreset
                    Else
                        Return Nothing
                    End If
                End If
                Count = Count + 1
            Next
            Return Nothing
        Catch ex As Exception
            Try
                File.Create(PresetFilePath).Dispose()
                Return Nothing
            Catch _ex As Exception
                Directory.CreateDirectory(ProgramDataPath)
                File.Create(PresetFilePath).Dispose()
                Return Nothing
            End Try
        End Try
    End Function

    Public Function GetPresetRaw(ByVal Index As Integer)
        Try
            Dim Presets() As String = My.Computer.FileSystem.ReadAllText(PresetFilePath, System.Text.Encoding.ASCII).Split(New String() {vbCrLf}, StringSplitOptions.None)
            Return Presets(Index)
        Catch ex As Exception
            Try
                File.Create(PresetFilePath).Dispose()
                Return Nothing
            Catch _ex As Exception
                Directory.CreateDirectory(ProgramDataPath)
                File.Create(PresetFilePath).Dispose()
                Return Nothing
            End Try
        End Try
    End Function

    Public Sub LoadPresets()
        FlowLayoutPanel1.Controls.Clear()
        Dim TotalCount As Integer = GetPresetCount()
        For Count As Integer = 0 To TotalCount - 1
            Dim PresetButton As New Button
            Dim Preset As PresetStruct = GetPreset(Count)
            With PresetButton
                .Name = Preset.Name & "Button"
                .Text = Preset.Name
                .AutoSize = True
            End With
            AddHandler PresetButton.Click, Sub()
                                               PresetNameTextBox.Text = Preset.Name
                                               SubnetMask1TextBox.Text = Preset.SubnetMask.Split(".")(0)
                                               SubnetMask2TextBox.Text = Preset.SubnetMask.Split(".")(1)
                                               SubnetMask3TextBox.Text = Preset.SubnetMask.Split(".")(2)
                                               SubnetMask4TextBox.Text = Preset.SubnetMask.Split(".")(3)
                                               DefaultGateway1TextBox.Text = Preset.DefaultGateway.Split(".")(0)
                                               DefaultGateway2TextBox.Text = Preset.DefaultGateway.Split(".")(1)
                                               DefaultGateway3TextBox.Text = Preset.DefaultGateway.Split(".")(2)
                                               DefaultGateway4TextBox.Text = Preset.DefaultGateway.Split(".")(3)
                                               PreferredDNS1TextBox.Text = Preset.PrimaryDNS.Split(".")(0)
                                               PreferredDNS2TextBox.Text = Preset.PrimaryDNS.Split(".")(1)
                                               PreferredDNS3TextBox.Text = Preset.PrimaryDNS.Split(".")(2)
                                               PreferredDNS4TextBox.Text = Preset.PrimaryDNS.Split(".")(3)
                                               AlternateDNS1TextBox.Text = Preset.SecondaryDNS.Split(".")(0)
                                               AlternateDNS2TextBox.Text = Preset.SecondaryDNS.Split(".")(1)
                                               AlternateDNS3TextBox.Text = Preset.SecondaryDNS.Split(".")(2)
                                               AlternateDNS4TextBox.Text = Preset.SecondaryDNS.Split(".")(3)
                                               DeleteButton.Enabled = True
                                           End Sub
            FlowLayoutPanel1.Controls.Add(PresetButton)
        Next
    End Sub

    Public Sub PerformAutoIPSearch()
        If SystemIPRaw.Length = 4 Then
            AutoIPButton.Text = "Searching..."
            AutoIPButton.Enabled = False
            Dim AutoIPProcessOutput As String
            Dim AutoIPProcess As Process = New Process
            With AutoIPProcess
                .StartInfo.CreateNoWindow = True
                .StartInfo.RedirectStandardOutput = True
                .StartInfo.UseShellExecute = False
                .StartInfo.FileName = "cmd.exe"
                .StartInfo.Arguments = "/c arp -a"
                .Start()
                AutoIPProcessOutput = .StandardOutput.ReadToEnd
                .WaitForExit()
            End With
            Dim FoundIPInterface As Boolean = False
            Dim LineCount As Integer = 0
            Dim IPAddressRegex As Regex = New Regex("\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")
            Dim IPAddressRegexMatch As Match = Nothing
            Dim TestIP As String = ""
            Dim FoundUniqueIP As Boolean = False
            For IPDigit As Integer = 1 To 250
                TestIP = SystemIPRaw(0) & "." & SystemIPRaw(1) & "." & SystemIPRaw(2) & "." & CStr(IPDigit)
                AutoIP1TextBox.Text = SystemIPRaw(0)
                AutoIP2TextBox.Text = SystemIPRaw(1)
                AutoIP3TextBox.Text = SystemIPRaw(2)
                AutoIP4TextBox.Text = CStr(IPDigit)
                AutoIPButton.Select()
                AutoIP4TextBox.Focus()
                For Each AutoIPProcessOutputLine As String In AutoIPProcessOutput.Split(CChar(vbLf))
                    If FoundIPInterface = False Then
                        If AutoIPProcessOutputLine.Contains("Interface: " & SystemIP & " ---") Then
                            FoundIPInterface = True
                        End If
                    Else
                        If LineCount <> 0 Then
                            If AutoIPProcessOutputLine <> "" Then
                                IPAddressRegexMatch = IPAddressRegex.Match(AutoIPProcessOutputLine)
                                If IPAddressRegexMatch.Success = True Then
                                    If String.Compare(TestIP, IPAddressRegexMatch.Value) = 0 Then
                                        FoundUniqueIP = False
                                        Exit For
                                    ElseIf String.Compare(TestIP, SystemIP) = 0 Then
                                        FoundUniqueIP = False
                                        Exit For
                                    Else
                                        FoundUniqueIP = True
                                    End If
                                End If
                            End If
                        End If
                        LineCount = LineCount + 1
                    End If
                Next
                If FoundUniqueIP = True Then
                    Exit For
                End If
            Next
            AutoIPButton.Select()
            AutoIPButton.Text = "Auto IP"
            AutoIPButton.Enabled = True
        Else
            AutoIP1TextBox.Text = ""
            AutoIP2TextBox.Text = ""
            AutoIP3TextBox.Text = ""
            AutoIP4TextBox.Text = ""
        End If
    End Sub

    Private Sub AutoIPButtonClick(sender As Object, e As EventArgs) Handles AutoIPButton.Click
        PerformAutoIPSearch()
    End Sub

    Private Sub MainLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeInterfaceList()
        LoadInterfaceList()
        LoadPresets()
    End Sub

    Private Sub IPAddressTabControlSelectedIndexChanged(sender As Object, e As EventArgs) Handles IPAddressTabControl.SelectedIndexChanged
        If IPAddressTabControl.SelectedIndex = 0 Then
            SelectedIPType = IPType.Auto
        ElseIf IPAddressTabControl.SelectedIndex = 1 Then
            SelectedIPType = IPType.Manual
        End If
    End Sub

    Private Sub SavedPresetsClick(sender As Object, e As EventArgs) Handles RefreshPresetsButton.Click
        LoadPresets()
    End Sub

    Public Function CheckForPresetName(ByVal PresetName As String) As Boolean
        Dim TotalCount As Integer = GetPresetCount()
        For Count As Integer = 0 To TotalCount - 1
            Dim Preset As PresetStruct = GetPreset(Count)
            If String.Compare(Preset.Name, PresetName) = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub SaveButtonClick(sender As Object, e As EventArgs) Handles SaveButton.Click
        If SubnetMask1TextBox.Text = "" Or SubnetMask2TextBox.Text = "" Or SubnetMask3TextBox.Text = "" Or SubnetMask4TextBox.Text = "" _
            Or DefaultGateway4TextBox.Text = "" Or DefaultGateway3TextBox.Text = "" Or DefaultGateway2TextBox.Text = "" _
            Or DefaultGateway1TextBox.Text = "" Or PreferredDNS4TextBox.Text = "" Or PreferredDNS3TextBox.Text = "" _
            Or PreferredDNS2TextBox.Text = "" Or PreferredDNS1TextBox.Text = "" Or AlternateDNS4TextBox.Text = "" _
            Or AlternateDNS3TextBox.Text = "" Or AlternateDNS2TextBox.Text = "" Or AlternateDNS1TextBox.Text = "" _
            Or PresetNameTextBox.Text = "" Then
            MessageBox.Show("One of the required fields in empty! Please make sure you have inputed every IP address.", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim PresetBuilder As New StringBuilder()
            PresetBuilder.Append(PresetNameTextBox.Text & "|")
            PresetBuilder.Append(SubnetMask1TextBox.Text & "." & SubnetMask2TextBox.Text & "." & SubnetMask3TextBox.Text & "." & SubnetMask4TextBox.Text & "." & "|")
            PresetBuilder.Append(DefaultGateway1TextBox.Text & "." & DefaultGateway2TextBox.Text & "." & DefaultGateway3TextBox.Text & "." & DefaultGateway4TextBox.Text & "." & "|")
            PresetBuilder.Append(PreferredDNS1TextBox.Text & "." & PreferredDNS2TextBox.Text & "." & PreferredDNS3TextBox.Text & "." & PreferredDNS4TextBox.Text & "." & "|")
            PresetBuilder.Append(AlternateDNS1TextBox.Text & "." & AlternateDNS2TextBox.Text & "." & AlternateDNS3TextBox.Text & "." & AlternateDNS4TextBox.Text & ".")
            If CheckForPresetName(PresetNameTextBox.Text) = True Then
                Dim PresetFileWriter As StreamWriter = File.AppendText(PresetFilePath)
                PresetFileWriter.WriteLine(PresetBuilder.ToString())
                PresetFileWriter.Dispose()
                MessageBox.Show("New preset saved successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim Result As Integer = MessageBox.Show("Do you really want to update the preset data?" & vbCrLf & "Note: This can't be undone, proceed with caution.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If Result = DialogResult.Yes Then
                    Dim Success As Boolean = False
                    Try
                        File.Create(PresetTempFilePath).Dispose()
                        Success = True
                    Catch _ex As Exception
                        Directory.CreateDirectory(ProgramDataPath)
                        File.Create(PresetTempFilePath).Dispose()
                        Success = True
                    End Try
                    If Success = True Then
                        Dim PresetTotalCount As Integer = GetPresetCount()
                        Dim PresetTempFileWriter As New StreamWriter(PresetTempFilePath, False)
                        For Count As Integer = 0 To PresetTotalCount - 1
                            Dim CurrentPreset As PresetStruct = GetPreset(Count)
                            If String.Compare(CurrentPreset.Name, PresetNameTextBox.Text) = 0 Then
                                PresetTempFileWriter.WriteLine(PresetBuilder.ToString())
                            Else
                                PresetTempFileWriter.WriteLine(GetPresetRaw(Count))
                            End If
                        Next
                        PresetTempFileWriter.Dispose()
                        Try
                            My.Computer.FileSystem.DeleteFile(PresetFilePath)
                            My.Computer.FileSystem.RenameFile(PresetTempFilePath, "presets.bin")
                        Catch ex As Exception
                            MessageBox.Show("Error occurred while updating preset data!" & vbCrLf & "Exception : " & ex.Message, "Error While Updating!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        MessageBox.Show("Error occurred while updating preset data!", "Error While Updating!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
            LoadPresets()
        End If
    End Sub

    Private Sub ResetButtonClick(sender As Object, e As EventArgs) Handles ResetButton.Click
        Dim PerformReset As Boolean = True
        If SubnetMask1TextBox.Text <> "" Or SubnetMask2TextBox.Text <> "" Or SubnetMask3TextBox.Text <> "" Or SubnetMask4TextBox.Text <> "" _
            Or DefaultGateway4TextBox.Text <> "" Or DefaultGateway3TextBox.Text <> "" Or DefaultGateway2TextBox.Text <> "" _
            Or DefaultGateway1TextBox.Text <> "" Or PreferredDNS4TextBox.Text <> "" Or PreferredDNS3TextBox.Text <> "" _
            Or PreferredDNS2TextBox.Text <> "" Or PreferredDNS1TextBox.Text <> "" Or AlternateDNS4TextBox.Text <> "" _
            Or AlternateDNS3TextBox.Text <> "" Or AlternateDNS2TextBox.Text <> "" Or AlternateDNS1TextBox.Text <> "" _
            Or PresetNameTextBox.Text <> "" Then
            Dim Result As Integer = MessageBox.Show("Do you really want to reset the preset field?" & vbCrLf & "Note : Can't be undone!", "Confirm Reset?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If Result = DialogResult.No Then
                PerformReset = False
            End If
        End If
        If PerformReset = True Then
            PresetNameTextBox.Text = ""
            AlternateDNS1TextBox.Text = ""
            AlternateDNS2TextBox.Text = ""
            AlternateDNS3TextBox.Text = ""
            AlternateDNS4TextBox.Text = ""
            PreferredDNS1TextBox.Text = ""
            PreferredDNS2TextBox.Text = ""
            PreferredDNS3TextBox.Text = ""
            PreferredDNS4TextBox.Text = ""
            DefaultGateway1TextBox.Text = ""
            DefaultGateway2TextBox.Text = ""
            DefaultGateway3TextBox.Text = ""
            DefaultGateway4TextBox.Text = ""
            SubnetMask1TextBox.Text = ""
            SubnetMask2TextBox.Text = ""
            SubnetMask3TextBox.Text = ""
            SubnetMask4TextBox.Text = ""
        End If
    End Sub

    Private Sub ClearPresetFileButtonClick(sender As Object, e As EventArgs) Handles ClearPresetFileButton.Click
        Dim Result As Integer = MessageBox.Show("Do you really want to clear the preset file?" & vbCrLf & "Note : Can't be undone!", "Confirm Preset File Clear?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If Result = DialogResult.Yes Then
            Dim PresetFileStream As New StreamWriter(PresetFilePath, False)
            PresetFileStream.Write("")
            PresetFileStream.Dispose()
            LoadPresets()
        End If
    End Sub

    Private Sub UpdateNetworkInterfaceButtonClick(sender As Object, e As EventArgs) Handles UpdateNetworkInterfaceButton.Click
        If SubnetMask1TextBox.Text = "" Or SubnetMask2TextBox.Text = "" Or SubnetMask3TextBox.Text = "" Or SubnetMask4TextBox.Text = "" _
            Or DefaultGateway4TextBox.Text = "" Or DefaultGateway3TextBox.Text = "" Or DefaultGateway2TextBox.Text = "" _
            Or DefaultGateway1TextBox.Text = "" Or PreferredDNS4TextBox.Text = "" Or PreferredDNS3TextBox.Text = "" _
            Or PreferredDNS2TextBox.Text = "" Or PreferredDNS1TextBox.Text = "" Or AlternateDNS4TextBox.Text = "" _
            Or AlternateDNS3TextBox.Text = "" Or AlternateDNS2TextBox.Text = "" Or AlternateDNS1TextBox.Text = "" _
            Or PresetNameTextBox.Text = "" Then
            MessageBox.Show("One of the required fields in empty! Please make sure you have inputed every IP address.", "Empty Field!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            UpdateNetworkInterfaceButton.Text = "Updating..."
            UpdateNetworkInterfaceButton.Enabled = False
            Dim UsingIP As String = ""
            If SelectedIPType = IPType.Auto Then
                UsingIP = AutoIP1TextBox.Text & "." & AutoIP2TextBox.Text & "." & AutoIP3TextBox.Text & "." & AutoIP4TextBox.Text
            Else
                UsingIP = ManualIP1TextBox.Text & "." & ManualIP2TextBox.Text & "." & ManualIP3TextBox.Text & "." & ManualIP4TextBox.Text
            End If
            Dim UpdateNetworkInterfaceProcess As Process = New Process
            With UpdateNetworkInterfaceProcess
                .StartInfo.CreateNoWindow = True
                .StartInfo.RedirectStandardOutput = True
                .StartInfo.UseShellExecute = False
                .StartInfo.FileName = "cmd.exe"
                .StartInfo.Arguments = "/c netsh interface ip set address name=""" & InterfaceList(SelectedInterfaceIndex).Name & """ static " & UsingIP & " " & _
                    SubnetMask1TextBox.Text & "." & SubnetMask2TextBox.Text & "." & SubnetMask3TextBox.Text & "." & SubnetMask4TextBox.Text & " " & _
                    DefaultGateway1TextBox.Text & "." & DefaultGateway2TextBox.Text & "." & DefaultGateway3TextBox.Text & "." & DefaultGateway4TextBox.Text
                .Start()
                .WaitForExit()
            End With
            With UpdateNetworkInterfaceProcess
                .StartInfo.CreateNoWindow = True
                .StartInfo.RedirectStandardOutput = True
                .StartInfo.UseShellExecute = False
                .StartInfo.FileName = "cmd.exe"
                .StartInfo.Arguments = "/c netsh interface ip set dns name=""" & InterfaceList(SelectedInterfaceIndex).Name & """ static " & _
                    PreferredDNS1TextBox.Text & "." & PreferredDNS2TextBox.Text & "." & PreferredDNS3TextBox.Text & "." & PreferredDNS4TextBox.Text
                .Start()
                .WaitForExit()
            End With
            With UpdateNetworkInterfaceProcess
                .StartInfo.CreateNoWindow = True
                .StartInfo.RedirectStandardOutput = True
                .StartInfo.UseShellExecute = False
                .StartInfo.FileName = "cmd.exe"
                .StartInfo.Arguments = "/c netsh interface ip add dns name=""" & InterfaceList(SelectedInterfaceIndex).Name & """ " & _
                    AlternateDNS1TextBox.Text & "." & AlternateDNS2TextBox.Text & "." & AlternateDNS3TextBox.Text & "." & AlternateDNS4TextBox.Text & " index=2"
                .Start()
                .WaitForExit()
            End With
            SystemIP = UsingIP
            SystemIPRaw = SystemIP.Split(".")
            PerformAutoIPSearch()
            UpdateNetworkInterfaceButton.Text = "Update Network Inteface"
            UpdateNetworkInterfaceButton.Enabled = True
        End If
    End Sub

    Private Sub DeleteButtonClick(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If PresetNameTextBox.Text <> "" Then
            If CheckForPresetName(PresetNameTextBox.Text) = False Then
                Dim Result As Integer = MessageBox.Show("Are you sure that you want to delete this preset?" & vbCrLf & "Note : This can't be undone!", "Confirm Deletion?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If Result = DialogResult.Yes Then
                    Dim Success As Boolean = False
                    Try
                        File.Create(PresetTempFilePath).Dispose()
                        Success = True
                    Catch _ex As Exception
                        Directory.CreateDirectory(ProgramDataPath)
                        File.Create(PresetTempFilePath).Dispose()
                        Success = True
                    End Try
                    If Success = True Then
                        Dim PresetTotalCount As Integer = GetPresetCount()
                        Dim PresetTempFileWriter As New StreamWriter(PresetTempFilePath, False)
                        For Count As Integer = 0 To PresetTotalCount - 1
                            Dim CurrentPreset As PresetStruct = GetPreset(Count)
                            If String.Compare(CurrentPreset.Name, PresetNameTextBox.Text) <> 0 Then
                                PresetTempFileWriter.WriteLine(GetPresetRaw(Count))
                            End If
                        Next
                        PresetTempFileWriter.Dispose()
                        Try
                            My.Computer.FileSystem.DeleteFile(PresetFilePath)
                            My.Computer.FileSystem.RenameFile(PresetTempFilePath, "presets.bin")
                        Catch ex As Exception
                            MessageBox.Show("Error occurred while updating preset data!" & vbCrLf & "Exception : " & ex.Message, "Error While Updating!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        MessageBox.Show("Error occurred while updating preset data!", "Error While Updating!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    LoadPresets()
                End If
            Else
                MessageBox.Show("Preset not found in the preset data file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No preset name provided!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ResetNetworkIntefaceButtonClick(sender As Object, e As EventArgs) Handles ResetNetworkIntefaceButton.Click
        ResetNetworkIntefaceButton.Text = "Reseting..."
        ResetNetworkIntefaceButton.Enabled = False
        Dim UpdateNetworkInterfaceProcess As Process = New Process
        With UpdateNetworkInterfaceProcess
            .StartInfo.CreateNoWindow = True
            .StartInfo.RedirectStandardOutput = True
            .StartInfo.UseShellExecute = False
            .StartInfo.FileName = "cmd.exe"
            .StartInfo.Arguments = "/c netsh interface ip set address name=""" & InterfaceList(SelectedInterfaceIndex).Name & """ source=dhcp"
            .Start()
            .WaitForExit()
        End With
        With UpdateNetworkInterfaceProcess
            .StartInfo.CreateNoWindow = True
            .StartInfo.RedirectStandardOutput = True
            .StartInfo.UseShellExecute = False
            .StartInfo.FileName = "cmd.exe"
            .StartInfo.Arguments = "/c netsh interface ip set dnsservers name=""" & InterfaceList(SelectedInterfaceIndex).Name & """ source=dhcp"
            .Start()
            .WaitForExit()
        End With
        SystemIP = GetIP(SelectedInterfaceIndex)
        SystemIPRaw = SystemIP.Split(".")
        PerformAutoIPSearch()
        ResetNetworkIntefaceButton.Text = "Reset Network Inteface"
        ResetNetworkIntefaceButton.Enabled = True
    End Sub

    Private Sub AboutButtonClick(sender As Object, e As EventArgs) Handles AboutButton.Click
        About.Show()
    End Sub
End Class