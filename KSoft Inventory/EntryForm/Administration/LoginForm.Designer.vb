<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cancel As DevExpress.XtraEditors.SimpleButton

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DepartmentIdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataSet = New KSoft_Inventory.UserDataSet()
        Me.UserTableAdapter = New KSoft_Inventory.UserDataSetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.UserDataSetTableAdapters.TableAdapterManager()
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.OKButton = New DevExpress.XtraEditors.SimpleButton()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RememberCheckBox = New System.Windows.Forms.CheckBox()
        Me.DatetimeLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        DepartmentIdLabel = New System.Windows.Forms.Label()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepartmentIdLabel
        '
        DepartmentIdLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(35, Byte), Integer))
        DepartmentIdLabel.ForeColor = System.Drawing.Color.White
        DepartmentIdLabel.Location = New System.Drawing.Point(36, 168)
        DepartmentIdLabel.Name = "DepartmentIdLabel"
        DepartmentIdLabel.Size = New System.Drawing.Size(210, 20)
        DepartmentIdLabel.TabIndex = 3
        DepartmentIdLabel.Text = "&Department:"
        DepartmentIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.White
        Me.UsernameLabel.Location = New System.Drawing.Point(36, 74)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(210, 20)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.White
        Me.PasswordLabel.Location = New System.Drawing.Point(36, 121)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(210, 20)
        Me.PasswordLabel.TabIndex = 1
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.White
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTextBox.Location = New System.Drawing.Point(36, 94)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(210, 20)
        Me.UsernameTextBox.TabIndex = 0
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.White
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTextBox.Location = New System.Drawing.Point(36, 141)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(210, 20)
        Me.PasswordTextBox.TabIndex = 2
        '
        'Cancel
        '
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(372, 168)
        Me.Cancel.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cancel.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.Cancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(83, 40)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.UserDataSet
        '
        'UserDataSet
        '
        Me.UserDataSet.DataSetName = "UserDataSet"
        Me.UserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.UserDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'DepartmentDataSet
        '
        Me.DepartmentDataSet.DataSetName = "DepartmentDataSet"
        Me.DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DepartmentDataSet
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'OKButton
        '
        Me.OKButton.Appearance.ForeColor = System.Drawing.Color.Black
        Me.OKButton.Appearance.Options.UseForeColor = True
        Me.OKButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.OKButton.Location = New System.Drawing.Point(283, 168)
        Me.OKButton.LookAndFeel.SkinMaskColor = System.Drawing.Color.SteelBlue
        Me.OKButton.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.OKButton.LookAndFeel.UseDefaultLookAndFeel = False
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(83, 40)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "&OK"
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.BackColor = System.Drawing.Color.White
        Me.DepartmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DepartmentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DepartmentTextBox.Location = New System.Drawing.Point(36, 188)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(210, 20)
        Me.DepartmentTextBox.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(493, 54)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "nERP Inventory Log in "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RememberCheckBox
        '
        Me.RememberCheckBox.AutoSize = True
        Me.RememberCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.RememberCheckBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.RememberCheckBox.Location = New System.Drawing.Point(283, 121)
        Me.RememberCheckBox.Name = "RememberCheckBox"
        Me.RememberCheckBox.Size = New System.Drawing.Size(164, 17)
        Me.RememberCheckBox.TabIndex = 18
        Me.RememberCheckBox.Text = "Remember Log-in Information"
        Me.RememberCheckBox.UseVisualStyleBackColor = False
        '
        'DatetimeLabel
        '
        Me.DatetimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.DatetimeLabel.Location = New System.Drawing.Point(283, 78)
        Me.DatetimeLabel.Name = "DatetimeLabel"
        Me.DatetimeLabel.Size = New System.Drawing.Size(172, 20)
        Me.DatetimeLabel.TabIndex = 19
        Me.DatetimeLabel.Text = "{0}"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(493, 54)
        Me.Label2.TabIndex = 20
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoginForm
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.KSoft_Inventory.My.Resources.Resources.noise
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(477, 236)
        Me.Controls.Add(Me.DatetimeLabel)
        Me.Controls.Add(Me.RememberCheckBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(DepartmentIdLabel)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserDataSet As KSoft_Inventory.UserDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As KSoft_Inventory.UserDataSetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As KSoft_Inventory.UserDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents OKButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DepartmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RememberCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DatetimeLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
