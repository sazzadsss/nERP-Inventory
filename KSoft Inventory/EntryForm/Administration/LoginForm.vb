Imports System
Imports DevExpress.XtraSplashScreen

Public Class LoginForm


    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Dim loc As Point
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        fade_out()
        Me.Close()
    End Sub
    '    Public Sub fade_in()
    '        'For FadeIn = 0.8 To 2.0 Step 0.1
    '        '    Me.Opacity = FadeIn
    '        '    Me.Refresh()
    '        '    Threading.Thread.Sleep(10)
    '        'Next
    '        Dim NextLevelTime As Long
    '        Transparency = 0
    '        If FirstScreen = True Then 'first screen is a public boolean (true means form 1 is on top, false means form 2 is on top
    '            While Transparency <= 255
    '                NextLevelTime = GetTickCount + 1
    '                While GetTickCount < NextLevelTime
    '                    DoEvents
    'Wend
    'SetLayeredWindowAttributes Amfade.hwnd, 0, Transparency, LWA_ALPHA
    'SetLayeredWindowAttributes amfade2.hwnd, 0, 255 - Transparency, LWA_ALPHA
    'Transparency = Transparency + 1
    'Wend
    'amfade2.Hide
    '            Amfade.SetFocus
    '        End If
    '        If FirstScreen = False Then
    '            While Transparency <= 255
    '                NextLevelTime = GetTickCount + 1
    '                While GetTickCount < NextLevelTime
    '                    DoEvents
    'Wend
    'SetLayeredWindowAttributes Amfade.hwnd, 0, Transparency, LWA_ALPHA
    'SetLayeredWindowAttributes amfade2.hwnd, 0, 255 - Transparency, LWA_ALPHA
    'Transparency = Transparency + 1
    'Wend
    'Amfade.Hide
    '            amfade2.SetFocus
    '        End If
    '    End Sub

    Public Sub fade_out()
        For FadeOut = 90 To 10 Step -10
            Me.Opacity = FadeOut / 100
            Me.Refresh()
            Threading.Thread.Sleep(20)
        Next
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MessageBox.Show(My.Settings.IsRemember.ToString())
        ' fade_in()
        If My.Settings.IsRemember = "True" Then
            Me.RememberCheckBox.Checked = True
        Else
            Me.RememberCheckBox.Checked = False
        End If


        If My.Settings.IsRemember = "True" Then

            Me.Focus()
            Me.DatetimeLabel.Text = Now()
            Me.UsernameTextBox.Text = ReadStringData("Select User_Name From [User] Where User_Id=" & Val(My.Settings.UserId), cnn)
            'Me.PasswordTextBox.Text = ReadStringData("Select Password From [User] Where User_Id=" & Val(My.Settings.UserId), cnn)
            OKButton.Focus()

        Else

            Me.UsernameTextBox.Text = ""
            Me.PasswordTextBox.Text = ""
            Me.Focus()
            Me.UsernameTextBox.Focus()
            Me.DatetimeLabel.Text = Now()

        End If
    End Sub

    Private Sub UsernameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyData = Keys.Enter Then
            PasswordTextBox.Focus()
        End If
    End Sub


    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

        Dim DepId As Integer = ReadIntegerData("Select DepartmentId As DepId From [User] Where User_Name = '" & UsernameTextBox.Text & "' And Active=1", cnn)
        Dim DepName As String = ReadStringData("Select DepartmentName From Department Where DepartmentId =" & DepId, cnn)

        DepartmentTextBox.Text = DepName

    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown

        If e.KeyData = Keys.Enter Then
            OKButton.Focus()
        End If

    End Sub



    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Try

            Dim RowCount As Integer = ReadIntData("Select Count(*) From [User] Where User_Name='" & UsernameTextBox.Text & "' And Password='" & PasswordTextBox.Text & "' And Active=1", cnn)

            If RowCount = 1 Then

                UserName = UsernameTextBox.Text
                UserId = ReadIntegerData("Select User_Id From [User] Where User_Name='" & UsernameTextBox.Text & "' And Password='" & PasswordTextBox.Text & "' And Active=1", cnn)
                DepartmentId = ReadIntegerData("Select DepartmentId From [User] Where User_Id=" & UserId, cnn)

                'Creating a user session while logged in
                Dim sessionManager As New SessionManager()
                sessionManager.CreateNewSession(UserId)
                'End of Creating a user session while logged in

                UserLevel = ReadIntData("Select User_Level From [User] Where User_Id=" & UserId, cnn)

                'Remember 
                If RememberCheckBox.Checked = True Then
                    My.Settings.UserId = UserId.ToString
                    My.Settings.IsRemember = "True"
                    My.Settings.Save()
                Else
                    My.Settings.UserId = ""
                    My.Settings.IsRemember = "False"
                    My.Settings.Save()
                End If

                'Me.PasswordTextBox.Text = ""
                Me.Hide()
                frmMain.MenuStrip.Visible = True
                frmMain.Show()

            ElseIf RowCount > 1 Then
                MessageBox.Show("Duplicate User has been found")
            Else
                MessageBox.Show("Wrong User Name or Password or Connection Problem," & vbNewLine & "Pls,check.", "Info..", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PanelControl1_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub PanelControl1_MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    Private Sub LoginNameLabelControl_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub LoginNameLabelControl_MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    Private Sub MinimiseButton_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs)
        fade_out()
        Me.Close()
    End Sub

End Class
