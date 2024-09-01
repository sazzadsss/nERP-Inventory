Public Class frmSearchEntry


    Private Sub frmSearchEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportFormListTableAdapter.FillByModule(Me.ReportFormListDataSet.ReportFormList)
        Me.ReportListTableAdapter.Fill(Me.ReportListDataSet.ReportList)


    End Sub

    Public Sub getallforms(ByVal sender As Object)

        'Get All Form From Module 06.08.16 - Feroz

        Dim Forms As New List(Of Form)()
        Dim formType As Type = Type.GetType("System.Windows.Forms.Form")
        For Each t As Type In sender.GetType().Assembly.GetTypes()
            If UCase(t.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then
                If t.Name.Contains("Report") Then ' Only Add those form which name contain Report 06.08.16 - Feroz
                    Dim add_chk As Integer = ReadIntegerData("select ReportFormListId From ReportFormList Where ReportPathName = '" & t.Name & "'", cnn)
                    'check this form is already in DB 06.08.16 - Feroz
                    If add_chk = 0 Then
                        ExecuteQuery("insert into ReportFormList (ReportFormName ,ReportPathName ,Module ) Values ('" & t.Name.Substring(3) & "','" & t.Name & "','Inventory')", cnn)
                    End If
                End If

            End If
        Next


        'Get All file from Specific Folder

        'Dim reportsFolder As String = IO.Directory.GetCurrentDirectory()
        'Dim rpt1 As String = IO.Directory.GetParent(reportsFolder).FullName
        'Dim rpt2 As String = IO.Directory.GetParent(rpt1).FullName
        'reportsFolder = Path.Combine(rpt2, "Report\Store")

        'For Each foundFile As String In My.Computer.FileSystem.GetFiles(reportsFolder)
        '    ListBox1.Items.Add(foundFile)
        'Next
        'MsgBox(reportsFolder)

    End Sub



    Private Sub ReportListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReportListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReportListDataSet)

    End Sub

    Private Sub UpdateFormButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateFormButton.Click
        getallforms(Me)
        Me.ReportFormListTableAdapter.FillByModule(Me.ReportFormListDataSet.ReportFormList)
    End Sub
End Class