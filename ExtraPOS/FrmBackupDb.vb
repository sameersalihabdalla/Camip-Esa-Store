Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmBackupDb
    Dim dbname As String

    'Set time to close for timer
    Private timeleft As Integer = 500 'in seconds

    'Change the backup directory here if required.
    Dim bkpath As String = "C:\MYSQLBACKUPS\"

    'Working directory of my sql
    Dim mysqldirectory As String




    Private Sub FrmBackupDb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hide timer labels

        'Display Welcome Message in the form's textbox
        TextBox1.Text = "Messages:"

        TextBox1.Text += Environment.NewLine
        TextBox1.Text += Environment.NewLine & DateAndTime.Now()
        TextBox1.Text += Environment.NewLine & "Welcome!" & Environment.NewLine & "I am going to backup the local MySQL database..."


        'Define the variables
        Dim dbfullpath As String
        Dim DbFile As String
        'change the DB name here ------------------------
        dbname = "myproject"

        'Change the MySQL Working directory here if required. Find the right directory and replace here. 
        'example: it could be mysqldirectory = "C:\Program Files\MySQL\MySQL Server 5.5\bin\"

        mysqldirectory = "C:\wampnew\bin\mysql\mysql5.7.19\bin"


        'check if the mysqldirectory exists
        Try
            If Not Directory.Exists(mysqldirectory) Then
                TextBox1.Text += Environment.NewLine
                TextBox1.Text += Environment.NewLine & DateAndTime.Now()
                TextBox1.Text += Environment.NewLine & "Could not find MySQL directory at " & mysqldirectory
                TextBox1.Text += Environment.NewLine & "I am unable to continue."

                'program will auto exit as per the timer specified. No need to include application exit here
            Else

                'If MySQL installation directory is found, continue
                'Change the DB backup file name if required here
                DbFile = "MYSQL_BACKUP_" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"




                'Append date and time to MySQL backup file
                dbfullpath = bkpath & DbFile

                'Check if C:\MYSQLBACKUPS folder exists. and if not then create

                Try
                    If Not Directory.Exists(bkpath) Then

                        TextBox1.Text += Environment.NewLine
                        TextBox1.Text += Environment.NewLine & DateAndTime.Now()
                        TextBox1.Text += Environment.NewLine & "I could not find """ + bkpath + """ folder. Creating Folder."

                        Directory.CreateDirectory(bkpath)

                        TextBox1.Text += Environment.NewLine
                        TextBox1.Text += Environment.NewLine & DateAndTime.Now()
                        TextBox1.Text += Environment.NewLine & "Created folder. The backups will be stored at  """ + bkpath + """ "

                    Else
                        TextBox1.Text += Environment.NewLine
                        TextBox1.Text += Environment.NewLine & DateAndTime.Now()
                        TextBox1.Text += Environment.NewLine & " """ + bkpath + """ folder already exists. Backups will be stored at """ + bkpath + """ "

                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                'Start a new process to run Command Prompt

                Dim BackupProcess As New Process

                BackupProcess.StartInfo.FileName = "cmd.exe"
                BackupProcess.StartInfo.UseShellExecute = False
                BackupProcess.StartInfo.WorkingDirectory = mysqldirectory
                BackupProcess.StartInfo.RedirectStandardInput = True
                BackupProcess.StartInfo.RedirectStandardOutput = True


                BackupProcess.Start()

                Dim BackupStream As StreamWriter = BackupProcess.StandardInput
                Dim myStreamreader As StreamReader = BackupProcess.StandardOutput


                TextBox1.Text += Environment.NewLine
                TextBox1.Text += Environment.NewLine & DateAndTime.Now()
                TextBox1.Text += Environment.NewLine & "Attempting to take backup and save to """ + bkpath + """ folder."

                Try
                    BackupStream.WriteLine("mysqldump --routines --default-character-set=utf8 -N  -uroot -p " & dbname & " > """ + dbfullpath + """")
                    TextBox1.Text += Environment.NewLine

                    TextBox1.Text += Environment.NewLine & DateAndTime.Now()
                    TextBox1.Text += Environment.NewLine & "Backup Created Successfully. Click ""View Backups"" to view."

                Catch ex As Exception
                    MsgBox("Some error occured. MySQL may not be installed or DB not found. Contact Admin.")

                End Try

                BackupStream.Close()
                BackupProcess.WaitForExit()
                BackupProcess.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'show timer labels


        'Enable Timer
        Timer1.Enabled = True
        Timer1.Start()


    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Process.Start("explorer.exe", bkpath)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "~ About This Tool ~"
        TextBox1.Text += Environment.NewLine
        TextBox1.Text += "--------------------------"
        TextBox1.Text += Environment.NewLine
        TextBox1.Text += "PURPOSE OF THIS TOOL"
        TextBox1.Text += Environment.NewLine
        TextBox1.Text += "This tool takes a backup of the MySQL database and saves it to " & bkpath & ". So that the backups can be used to restore in the event of system crash or data loss."
        TextBox1.Text += "Thank you for using this tool!"
    End Sub
End Class
