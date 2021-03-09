Imports System.IO
Imports System.Text
Public Class Form1
    Dim increment As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        My.Computer.FileSystem.DeleteFile("C:\Windows\System32\drivers\etc\hosts")
        Dim files As System.IO.StreamWriter
        files = My.Computer.FileSystem.OpenTextFileWriter("C:\Windows\System32\drivers\etc\hosts", True)
        files.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp.")
        files.WriteLine("#")
        files.WriteLine("# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.")
        files.WriteLine("#")
        files.WriteLine("# This file contains the mappings of IP addresses to host names. Each")
        files.WriteLine("# entry should be kept on an individual line. The IP address should")
        files.WriteLine("# be placed in the first column followed by the corresponding host name.")
        files.WriteLine("# The IP address and the host name should be separated by at least one")
        files.WriteLine("# space.")
        files.WriteLine("#")
        files.WriteLine("# Additionally, comments (such as these) may be inserted on individual")
        files.WriteLine("# lines or following the machine name denoted by a '#' symbol.")
        files.WriteLine("#")
        files.WriteLine("# For example:")
        files.WriteLine("#")
        files.WriteLine("#      102.54.94.97     rhino.acme.com          # source server")
        files.WriteLine("#       38.25.63.10     x.acme.com              # x client host")
        files.WriteLine("")
        files.WriteLine("# localhost name resolution is handled within DNS itself.")
        files.WriteLine("#      127.0.0.1       localhost")
        files.WriteLine("#      ::1             localhost")
        files.WriteLine("test growtopia1.com")
        files.WriteLine("test growtopia1.com")
        files.Close()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
        My.Computer.FileSystem.DeleteFile("C:\Windows\System32\drivers\etc\hosts")
        Dim files As System.IO.StreamWriter
        files = My.Computer.FileSystem.OpenTextFileWriter("C:\Windows\System32\drivers\etc\hosts", True)
        files.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp.")
        files.WriteLine("#")
        files.WriteLine("# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.")
        files.WriteLine("#")
        files.WriteLine("# This file contains the mappings of IP addresses to host names. Each")
        files.WriteLine("# entry should be kept on an individual line. The IP address should")
        files.WriteLine("# be placed in the first column followed by the corresponding host name.")
        files.WriteLine("# The IP address and the host name should be separated by at least one")
        files.WriteLine("# space.")
        files.WriteLine("#")
        files.WriteLine("# Additionally, comments (such as these) may be inserted on individual")
        files.WriteLine("# lines or following the machine name denoted by a '#' symbol.")
        files.WriteLine("#")
        files.WriteLine("# For example:")
        files.WriteLine("#")
        files.WriteLine("#      102.54.94.97     rhino.acme.com          # source server")
        files.WriteLine("#       38.25.63.10     x.acme.com              # x client host")
        files.WriteLine("")
        files.WriteLine("# localhost name resolution is handled within DNS itself.")
        files.WriteLine("#      127.0.0.1       localhost")
        files.WriteLine("#      ::1             localhost")
        files.WriteLine($"{TextBox1.Text} growtopia1.com")
        files.WriteLine($"{TextBox1.Text} growtopia2.com")
        files.Close()
        MessageBox.Show("Added")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
        My.Computer.FileSystem.DeleteFile("C:\Windows\System32\drivers\etc\hosts")
        Dim files As System.IO.StreamWriter
        files = My.Computer.FileSystem.OpenTextFileWriter("C:\Windows\System32\drivers\etc\hosts", True)
        files.WriteLine("# Copyright (c) 1993-2009 Microsoft Corp.")
        files.WriteLine("#")
        files.WriteLine("# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.")
        files.WriteLine("#")
        files.WriteLine("# This file contains the mappings of IP addresses to host names. Each")
        files.WriteLine("# entry should be kept on an individual line. The IP address should")
        files.WriteLine("# be placed in the first column followed by the corresponding host name.")
        files.WriteLine("# The IP address and the host name should be separated by at least one")
        files.WriteLine("# space.")
        files.WriteLine("#")
        files.WriteLine("# Additionally, comments (such as these) may be inserted on individual")
        files.WriteLine("# lines or following the machine name denoted by a '#' symbol.")
        files.WriteLine("#")
        files.WriteLine("# For example:")
        files.WriteLine("#")
        files.WriteLine("#      102.54.94.97     rhino.acme.com          # source server")
        files.WriteLine("#       38.25.63.10     x.acme.com              # x client host")
        files.WriteLine("")
        files.WriteLine("# localhost name resolution is handled within DNS itself.")
        files.WriteLine("#      127.0.0.1       localhost")
        files.WriteLine("#      ::1             localhost")
        files.Close()
        MessageBox.Show("Removed")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim webAddress As String = "http://www.example.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
        Dim path As String = "growtopia.bat"

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("@echo off" & vbCrLf & "cd C:\Users\Danilo\AppData\Local\Growtopia" & vbCrLf & "start Growtopia.exe param1")
        fs.Write(info, 0, info.Length)
        fs.Close()
        fs.Close()
        Process.Start("growtopia.bat")
        Threading.Thread.Sleep(500)
        My.Computer.FileSystem.DeleteFile("growtopia.bat")
        MessageBox.Show("Success")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label3.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
        Dim path As String = $"{TextBox4.Text}.{TextBox3.Text}"

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes($"{TextBox2.Text} growtopia1.com" & vbCrLf & $"{TextBox2.Text} growtopia2.com")
        fs.Write(info, 0, info.Length)
        fs.Close()
        fs.Close()
        MessageBox.Show("Success")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label3.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
        Dim path As String = "server_data.php"

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes($"server|{TextBox5.Text}" & vbCrLf & $"port|{TextBox6.Text}" & vbCrLf & "type|1" & vbCrLf & $"#maint|{TextBox7.Text}" & vbCrLf & "beta_server|127.0.0.1" & vbCrLf & "beta_port|17091" & vbCrLf & "beta_type|1" & vbCrLf & "meta|localhost" & vbCrLf & "RTENDMARKERBS1001")
        fs.Write(info, 0, info.Length)
        fs.Close()
        MessageBox.Show(path & " Maded")
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
    End Sub
End Class
