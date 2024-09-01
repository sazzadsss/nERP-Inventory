Imports System.Deployment.Application
Public Class frmSplash
    Public ReadOnly Property AssemblyVersion() As System.Version
        Get
            Return ApplicationDeployment.CurrentDeployment.CurrentVersion
        End Get
    End Property
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Close()
    End Sub

    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        If (ApplicationDeployment.IsNetworkDeployed) Then
            Version.Text = "Version " + AssemblyVersion.Major.ToString() + "." + AssemblyVersion.Minor.ToString() + "." + AssemblyVersion.Build.ToString() + "." + AssemblyVersion.Revision.ToString()
        Else
            Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Revision)
        End If
        Copyright.Text = My.Application.Info.Copyright

    End Sub

    Private Sub Version_Click(sender As Object, e As EventArgs) Handles Version.Click

    End Sub

    Private Sub Copyright_Click(sender As Object, e As EventArgs) Handles Copyright.Click

    End Sub
End Class