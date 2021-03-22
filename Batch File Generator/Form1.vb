Imports System.IO
Public Class Main_Window
    Public completedPath As String
    Public gFileName As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Custom_Shutdown_btn.Click
        Dim shutdownTime As Integer = InputBox("Enter The Amount Of Seconds: "), shutdownMessage As String = InputBox("Enter A Shutdown Message: ")
        While shutdownTime.ToString = "" Or shutdownMessage = ""
            If shutdownTime.ToString = "" Then
                MsgBox("You did <> enter the amount of seconds!", MsgBoxStyle.Critical)
                shutdownTime = InputBox("Enter The Amount Of Seconds: ")
            ElseIf shutdownMessage = "" Then
                MsgBox("You did <> enter a shutdown message!", MsgBoxStyle.Critical)
                shutdownMessage = InputBox("Enter A Shutdown Message: ")
            End If
        End While
        Preview_Pane.AppendText("shutdown -s -f -t " + shutdownTime.ToString + " -c " + shutdownMessage + vbNewLine)
    End Sub

    Private Sub Custom_Ping_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Custom_Ping_btn.Click
        Dim pingAddress As String = InputBox("Enter A URL Or IP Address: ")
        While pingAddress.ToString = ""
            MsgBox("You Did <> Enter A URL Or IP Address: ")
            pingAddress = InputBox("Enter A URL Or IP Address: ")
        End While
        Preview_Pane.AppendText("ping " + pingAddress + vbNewLine)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Echo_Off_btn.CheckedChanged
        If Preview_Pane.Lines.Count < 1 Then
            Preview_Pane.AppendText(vbNewLine)
        End If
        If Echo_On_btn.Checked = True Then
            Echo_On_btn.Checked = False
            Dim lines As String()
            lines = Preview_Pane.Lines
            lines.SetValue("@echo off", 0)
            Preview_Pane.Lines = lines
        Else
            Echo_On_btn.Checked = False
            Dim lines As String()
            lines = Preview_Pane.Lines
            lines.SetValue("@echo off", 0)
            Preview_Pane.Lines = lines
        End If
    End Sub

    Private Sub Echo_On_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Echo_On_btn.CheckedChanged
        If Preview_Pane.Lines.Count < 1 Then
            Preview_Pane.AppendText(vbNewLine)
        End If
        If Echo_Off_btn.Checked = True Then
            Echo_Off_btn.Checked = False
            Dim lines As String()
            lines = Preview_Pane.Lines
            lines.SetValue("@echo off", 0)
            Preview_Pane.Lines = lines
        Else
            Dim lines As String()
            lines = Preview_Pane.Lines
            lines.SetValue("@echo on", 0)
            Preview_Pane.Lines = lines
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim text As String = InputBox("Enter A Text String To Display: ")
        While text.ToString = ""
            MsgBox("You Did <> Enter A Text String!", MsgBoxStyle.Critical)
            text = InputBox("Enter A Text String To Display: ")
        End While
        Preview_Pane.AppendText("echo " + text + vbNewLine)
    End Sub

    Private Sub Set_Label_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Set_Label_btn.Click
        Dim loopName As String = InputBox("Enter A Name For Your Loop: "), startPosition As Integer = InputBox("Enter A Line For The Loop To Start: "), endPosition As Integer = InputBox("Enter A Line For The Loop To End: ")
        While loopName.ToString = "" Or startPosition.ToString = "" Or endPosition.ToString = ""
            If loopName = "" Then
                MsgBox("You Did <> Enter A Loop Name!", MsgBoxStyle.Critical)
                loopName = InputBox("Enter A Name For Your Loop: ")
            ElseIf startPosition.ToString = "" Then
                MsgBox("You Did <> Enter A Start Position!", MsgBoxStyle.Critical)
                startPosition = InputBox("Enter A Line For The Loop To Start: ")
            ElseIf endPosition.ToString = "" Then
                MsgBox("You Did <> Enter A End Position!", MsgBoxStyle.Critical)
                endPosition = InputBox("Enter A Line For The Loop To End: ")
            End If
        End While
        While endPosition + 1 > Preview_Pane.Lines.Count
            Preview_Pane.AppendText(vbNewLine)
        End While
        Dim lines As String()
        lines = Preview_Pane.Lines
        lines.SetValue(":" + loopName, startPosition)
        lines.SetValue("goto " + loopName + vbNewLine, endPosition)
        Preview_Pane.Lines = lines
    End Sub

    Private Sub CLS_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLS_btn.CheckedChanged
        If CLS_btn.Checked = True Then
            Preview_Pane.AppendText("cls" + vbNewLine)
        End If
    End Sub

    Private Sub Winver_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Winver_btn.CheckedChanged
        If Winver_btn.Checked = True Then
            Preview_Pane.AppendText("winver" + vbNewLine)
        End If
    End Sub

    Private Sub Sysinfo_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sysinfo_btn.CheckedChanged
        If Sysinfo_btn.Checked = True Then
            Preview_Pane.AppendText("systeminfo" + vbNewLine)
        End If
    End Sub

    Private Sub Pause_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pause_btn.CheckedChanged
        If Pause_btn.Checked = True Then
            Preview_Pane.AppendText("pause" + vbNewLine)
        End If
    End Sub

    Private Sub Tasklist_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tasklist_btn.CheckedChanged
        If Tasklist_btn.Checked = True Then
            Preview_Pane.AppendText("tasklist" + vbNewLine)
        End If
    End Sub

    Private Sub Netstat_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Netstat_btn.CheckedChanged
        If Netstat_btn.Checked = True Then
            Preview_Pane.AppendText("netstat /b" + vbNewLine)
        End If
    End Sub

    Private Sub Exe_Start_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exe_Start_btn.Click
        Dim exeName As String = InputBox("Enter The Name Of The EXE You Want To Start: ")
        While exeName.ToString = ""
            MsgBox("You Did Not Enter An EXE Name!", MsgBoxStyle.Critical)
            exeName = InputBox("Enter The Name Of The EXE You Want To Start: ")
        End While
        Preview_Pane.AppendText("start " + exeName + vbNewLine)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Web_Start_btn.Click
        Dim Address As String = InputBox("Enter The Address Of The Website You Want To Start: ")
        While Address.ToString = ""
            MsgBox("You Did <> Enter An Website Address!", MsgBoxStyle.Critical)
            Address = InputBox("Enter The Address Of The Website You Want To Start: ")
        End While
        Preview_Pane.AppendText("start " + Address + vbNewLine)
    End Sub

    Private Sub Format_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Format_btn.Click
        Dim drive As String = InputBox("Enter The Letter Of The Drive You Want To Format e.g. C: "), fSystem As String = InputBox("Enter A File System For The Drive: " + vbNewLine + "fat, fat32, exfat, ntfs of udf")
        While drive.Length > 3 Or drive = ""
            If drive.Length > 3 Then
                MsgBox("Invalid Drive Letter!", MsgBoxStyle.Critical)
                drive = InputBox("Enter The Letter Of The Drive You Want To Format: ")
            ElseIf drive = "" Then
                MsgBox("You Did <> Enter A Drive Letter", MsgBoxStyle.Critical)
                drive = InputBox("Enter The Letter Of The Drive You Want To Format: ")
            End If
        End While
        Preview_Pane.AppendText("format " + drive.ToString + " /fs:" + fSystem.ToString + vbNewLine)
    End Sub

    Private Sub Make_dir_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Make_dir_btn.Click
        Dim Path As String = InputBox("Enter A Directory Path e.g. C:/Users/Tom/Desktop"), Name As String = InputBox("Enter A Name For The Directory")
        While Path.ToString = "" Or Name.ToString = ""
            If Path.ToString = "" Then
                MsgBox("You Did Not Enter A Directory Path!", MsgBoxStyle.Critical)
                Path = InputBox("Enter A Directory Path")
            ElseIf Name.ToString = "" Then
                MsgBox("You Did Not Enter A Name For The Directory!", MsgBoxStyle.Critical)
                Name = InputBox("Enter A Name For The Directory")
            End If
        End While
        Preview_Pane.AppendText("cd " + Path + vbNewLine + "md " + Name + vbNewLine)
    End Sub

    Private Sub List_Directory_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Preview_Pane.AppendText("dir" + vbNewLine)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles List_Directory_btn.CheckedChanged
        If List_Directory_btn.Checked = True Then
            Preview_Pane.AppendText("dir" + vbNewLine)
        End If
    End Sub

    Private Sub Set_Title_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Set_Title_btn.Click
        Dim title As String = InputBox("Enter A Title For The CMD Window")
        While title = ""
            MsgBox("You Did Not Enter A Title!", MsgBoxStyle.Critical)
            title = InputBox("Enter A Title For The CMD Window")
        End While
        Preview_Pane.AppendText("title " + title + vbNewLine)
    End Sub

    Private Sub Clear_Window_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Window_btn.Click
        Preview_Pane.Text = ""
    End Sub

    Private Sub Main_Window_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Echo_Off_btn.Checked = True
        Run_File_btn.Enabled = False
        Del_File_btn.Enabled = False
    End Sub

    Private Sub Enter_Directory_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enter_Directory_btn.Click
        Dim path As String = InputBox("Enter A Path To A Directory e.g. C:/system32")
        While path.ToString = ""
            If path.ToString = "" Then
                MsgBox("You Did Not Enter A Path!", MsgBoxStyle.Critical)
                path = InputBox("Enter A Path To A Directory")
            End If
        End While
        Preview_Pane.AppendText("cd " + path + vbNewLine)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove_Directory_btn.Click
        Dim path As String = InputBox("Enter The Directory That The Directory Resides In e.g. C:/"), dirName As String = InputBox("Enter The Name Of The Directory That You Want To Delete")
        While path.ToString = "" Or dirName.ToString = ""
            If path.ToString = "" Then
                MsgBox("You Did Not Enter A Directory!", MsgBoxStyle.Critical)
                path = InputBox("Enter The Directory That The Directory Resides In")
            ElseIf dirName.ToString = "" Then
                MsgBox("You Did Not Enter A Directory Name!", MsgBoxStyle.Critical)
                dirName = InputBox("Enter The Name Of The Directory You Want To Delete")
            End If
        End While
        Preview_Pane.AppendText("cd " + path + vbNewLine + "rmdir /s /q " + dirName + vbNewLine)
    End Sub

    Private Sub Delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete_btn.Click
        Dim path As String = InputBox("Enter The Directory Path e.g. C:/"), fileName As String = InputBox("Enter The Name Of The File")
        While path.ToString = "" Or fileName = ""
            If path.ToString = "" Then
                MsgBox("You Did Not Enter A Path", MsgBoxStyle.Critical)
                path = InputBox("Enter The Directory Path")
            ElseIf fileName = "" Then
                MsgBox("You Did Not Enter A File Name!", MsgBoxStyle.Critical)
                fileName = InputBox("Enter The File Name")
            End If
        End While
        Preview_Pane.AppendText("cd " + path + vbNewLine + "del /f /q " + fileName + vbNewLine)
    End Sub

    Private Sub Task_Kill_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Task_Kill_btn.Click
        Dim processName As String = InputBox("Enter The Name Of A Running Process")
        While processName = ""
            MsgBox("You Did Not Enter A Process", MsgBoxStyle.Critical)
            processName = InputBox("Enter The Name Of A Running Process")
        End While
        Preview_Pane.AppendText("taskkill /f /im " + Chr(34) + processName + Chr(34))
    End Sub

    Private Sub Block_Webiste_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Block_Webiste_btn.Click
        Dim url As String = InputBox("Enter A URL You Would Like To Block")
        While url.ToString = ""
            MsgBox("You Did Not Enter A URL!", MsgBoxStyle.Critical)
            url = InputBox("Enter A URL You Would Like To Block")
        End While
        Preview_Pane.AppendText("cd %systemdrive%/Windows/System32/drivers/etc" + vbNewLine + "echo " + url.ToString + " 127.0.0.1 >> hosts" + vbNewLine)
    End Sub

    Private Sub IP_Information_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IP_Information_btn.CheckedChanged
        If IP_Information_btn.Checked = True Then
            Preview_Pane.AppendText("ipconfig /all" + vbNewLine)
        End If
    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles If_Statment_btn.Click
        Dim varName As String = InputBox("Enter A Name For The Varaible"), text As String = InputBox("Enter Some Text To Display"), number As String = InputBox("Enter A Number Of Conditions")
        While varName.ToString = "" Or text.ToString = "" Or number.ToString = ""
            If varName.ToString = "" Then
                MsgBox("You Did Not Enter A Variable Name!", MsgBoxStyle.Critical)
                varName = InputBox("Enter A Name For The Varaible")
            ElseIf text.ToString = "" Then
                MsgBox("You Did Not Enter Some Text!", MsgBoxStyle.Critical)
                text = InputBox("Enter Some Text To Display")
            ElseIf number.ToString = "" Then
                MsgBox("You Did Not Enter A Number Of Conditions")
                number = InputBox("Enter A Number Of Conditions")
            End If
        End While
        Preview_Pane.AppendText("set /p " + varName + "=" + text + vbNewLine)
        Dim i As Integer = 0
        While i < number
            Preview_Pane.AppendText("if %" + varName + "%==" + vbNewLine)
            i += 1
        End While
    End Sub

    Private Sub Save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_btn.Click
        If completedPath <> "" Then
            My.Computer.FileSystem.DeleteFile(completedPath)
            Dim sw_StreamWriter As New StreamWriter(completedPath)
            For Each line In Preview_Pane.Lines
                sw_StreamWriter.WriteLine(line)
            Next
            sw_StreamWriter.Close()
            MsgBox("File Saved!")
        Else
            Dim directory As String = InputBox("Enter A Directory In Which To Save The File"), fileName As String = InputBox("Enter A Name For Your Batch File")
            While directory = "" Or fileName = "" Or My.Computer.FileSystem.DirectoryExists(directory) = False
                If directory = "" Then
                    MsgBox("You Did Not Enter A Directory")
                    directory = InputBox("Enter A Directory In Which To Save The File")
                ElseIf fileName = "" Then
                    MsgBox("Enter A Name For Your Batch File")
                    fileName = InputBox("Enter A Name For Your Batch File")
                ElseIf My.Computer.FileSystem.DirectoryExists(directory) = False Then
                    MsgBox("Specific Directory Does Not Exist")
                    directory = InputBox("Enter A Directory In Which To Save The File")
                End If
            End While
            Dim oWrite As System.IO.StreamWriter
            oWrite = File.CreateText(directory + "\" + fileName + ".bat")
            For Each line In Preview_Pane.Lines
                oWrite.WriteLine(line)
            Next
            oWrite.Close()
            Dim choice As String = InputBox("Would You Like To Test Your Batch File? Yes/No")
            While choice.ToUpper = "" Or choice.ToUpper IsNot "YES" And choice.ToUpper IsNot "NO" = False
                MsgBox("Invalid Choice, Must Be Yes Or No!", MsgBoxStyle.Critical)
                choice = InputBox("Would You Like To Test Your Batch File? Yes/No")
            End While
            If choice.ToUpper = "YES" Then
                Process.Start(directory + "\" + fileName + ".bat")
            End If
            completedPath = (directory + "\" + fileName + ".bat")
            gFileName = fileName
            Me.Text = ("Tom's Batch File Generator - Current File: " + gFileName + ".bat")
            Del_File_btn.Enabled = True
            Run_File_btn.Enabled = True
        End If
    End Sub

    Private Sub User_Name_Entry_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles User_Name_Entry_btn.Click
        Preview_Pane2.Clear()
        Preview_Pane2.Text = ("@echo off" + vbNewLine + ":start" + vbNewLine + "cls" + vbNewLine + "color A" + vbNewLine + "title Name Entry Script" + vbNewLine + "set /p name=enter your name: " + vbNewLine + "echo Hi there %name%" + vbNewLine + "pause" + vbNewLine + "goto start")
    End Sub

    Private Sub Custom_Shutdown_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub


    Private Sub Del_File_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Del_File_btn.Click
        My.Computer.FileSystem.DeleteFile(completedPath)
        gFileName = ""
        completedPath = ""
        Me.Text = ("Tom's Batch File Generator")
        Del_File_btn.Enabled = False
        Run_File_btn.Enabled = False
        MsgBox("The File " + gFileName + " Has Been Deleted!")
    End Sub

    Private Sub Run_File_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Run_File_btn.Click
        Process.Start(completedPath)
    End Sub

    Private Sub If_Exist_Statement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles If_Exist_Statement.Click
        Dim argument = InputBox("Enter a drive letter or file name to verify")
        If argument.ToString = "" Then
            MsgBox("You Did Not Enter A Drive Letter!", MsgBoxStyle.Critical)
            argument = InputBox("Enter a drive letter or file name to verify")
        Else
            Preview_Pane.AppendText("if exist " + argument + vbNewLine)
        End If
    End Sub

    Private Sub Custom_Ping_test_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Custom_Ping_test_btn.Click
        Preview_Pane2.Clear()
        Preview_Pane2.Text = ("@echo off" + vbNewLine + ":start" + vbNewLine + "cls" + vbNewLine + "color A" + vbNewLine + "title Custom Ping Script" + vbNewLine + "set /p address=enter a website or ip address: " + vbNewLine + "ping %address%" + vbNewLine + "pause" + vbNewLine + "goto start")
    End Sub
End Class

