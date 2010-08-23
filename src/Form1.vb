Imports Microsoft.Win32
Public Class Form1
    Public Function getOSArchitectureLegacy() As Integer

        Dim pa As String = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")
        Return IIf((String.IsNullOrEmpty(pa) Or String.Compare(pa, 0, "x86", 0, 3, True) = 0), 32, 64)

    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Text = "Shutting iTunes down..."
        Dim KilliTunes As String
        Dim Patchbr As String
        Dim iTunes32 As String
        Dim iTunes64 As String
        Dim iTunes32patch As String
        Dim iTunes64patch As String
        Dim PatchiTunes32 As String
        Dim PatchiTunes64 As String
        iTunes32patch = Quote.Text & "C:\Program Files\Common Files\Apple\Mobile Device Support\iTunesMobileDevice2.dll" & Quote.Text
        iTunes64patch = Quote.Text & "C:\Program Files (x86)\Common Files\Apple\Mobile Device Support\iTunesMobileDevice2.dll" & Quote.Text
        iTunes32 = Quote.Text & "C:\Program Files\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll" & Quote.Text
        iTunes64 = Quote.Text & "C:\Program Files (x86)\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll" & Quote.Text
        PatchiTunes32 = "bspatch.exe " & iTunes32 & " " & iTunes32patch & " " & Quote.Text & "iTunes.patch" & Quote.Text
        PatchiTunes64 = "bspatch.exe " & iTunes64 & " " & iTunes64patch & " " & Quote.Text & "iTunes.patch" & Quote.Text
        KilliTunes = "taskkill /f /t /im iTunes.exe"
        Shell(KilliTunes, AppWinStyle.Hide)
        Button1.Text = "iTunes Shutdown!"
        'Bye Bye! :D
        Button1.Text = "Browse for blackra1n exe..."
        blackra1n.ShowDialog()
        If blackra1n.FileName = "" Then
            MsgBox("No blackra1n file was found!")
            Button1.Enabled = True
            Button1.Text = "Fix my ra1n!"
        Else
            Button1.Text = "Select a save location..."
            blackra1nsave.ShowDialog()
            If blackra1nsave.FileName = "" Then
                MsgBox("No File Name given!")
                Button1.Enabled = True
                Button1.Text = "Fix my ra1n!"
            Else
                Patchbr = "bspatch.exe " & Quote.Text & blackra1n.FileName & Quote.Text & " " & Quote.Text & blackra1nsave.FileName & Quote.Text & " " & Quote.Text & "blackra1n.patch" & Quote.Text
                Shell(Patchbr, AppWinStyle.Hide)
                Button1.Text = "blackra1n Patched!"
                Call getOSArchitectureLegacy()
                If getOSArchitectureLegacy() = "32" Then
                    Button1.Text = "Patching iTunes..."
                    Shell(PatchiTunes32, AppWinStyle.Hide)
                    Button1.Text = "Adding Entries..."
                    Dim regKey32 As RegistryKey
                    regKey32 = Registry.LocalMachine.OpenSubKey("Software\Apple Inc.\Apple Mobile Device Support\Shared\", True)
                    regKey32.SetValue("iTunesMobileDeviceD11", "C:\Program Files\Common Files\Apple\Mobile Device Support\iTunesMobileDevice2.dll")
                    regKey32.Close()
                    Button1.Enabled = True
                    Button1.Text = "Fix my ra1n!"
                    MsgBox("blackra1n has been fixed for iTunes 9.1!" & (Chr(13)) & "Make sure you select the blackra1n file that you saved!" & (Chr(13)) & "Enjoy!")
                Else
                    Button1.Text = "Patching iTunes..."
                    Shell(PatchiTunes64, AppWinStyle.Hide)
                    Button1.Text = "Adding Entries..."
                    Dim regKey64 As RegistryKey
                    regKey64 = Registry.LocalMachine.OpenSubKey("Software\Wow6432Node\Apple Inc.\Apple Mobile Device Support\Shared\", True)
                    regKey64.SetValue("iTunesMobileDeviceD11", "C:\Program Files (x86)\Common Files\Apple\Mobile Device Support\iTunesMobileDevice2.dll")
                    regKey64.Close()
                    Button1.Enabled = True
                    Button1.Text = "Fix my ra1n!"
                    MsgBox("blackra1n has been fixed for iTunes 9.1!" & (Chr(13)) & "Make sure you select the blackra1n file that you saved!" & (Chr(13)) & "Enjoy!")
                End If
            End If
        End If

    End Sub
End Class
