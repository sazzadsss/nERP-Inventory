<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStoreBalance
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
        Me.components = New System.ComponentModel.Container()
        Me.ItemListDataSet = New KSoft_Inventory.ItemListDataSet()
        Me.ItemListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListTableAdapter = New KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter()
        Me.TableAdapterManager = New KSoft_Inventory.ItemListDataSetTableAdapters.TableAdapterManager()
        Me.BalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BalanceDataSet = New KSoft_Inventory.BalanceDataSet()
        Me.ToDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FromDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalReceiveDataSet = New KSoft_Inventory.TotalReceiveDataSet()
        Me.IssueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IssueTableAdapter = New KSoft_Inventory.TotalReceiveDataSetTableAdapters.IssueTableAdapter()
        Me.ReceiveTableAdapter = New KSoft_Inventory.TotalReceiveDataSetTableAdapters.ReceiveTableAdapter()
        Me.TableAdapterManager2 = New KSoft_Inventory.TotalReceiveDataSetTableAdapters.TableAdapterManager()
        Me.ReceiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonNew = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOld = New System.Windows.Forms.RadioButton()
        Me.btnFilterByValue = New System.Windows.Forms.Button()
        Me.btnStartProcessbyvalue = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.filterButton2 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.WithCerCheckBox = New System.Windows.Forms.CheckBox()
        Me.Template3RadioButton = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RemovefilterButton = New System.Windows.Forms.Button()
        Me.SubCategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.SubCategoryLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubCategoryDataSet = New KSoft_Inventory.SubCategoryDataSet()
        Me.Template2RadioButton = New System.Windows.Forms.RadioButton()
        Me.Template1RadioButton = New System.Windows.Forms.RadioButton()
        Me.btnStartProcess = New System.Windows.Forms.Button()
        Me.PrgLongProcess = New System.Windows.Forms.ProgressBar()
        Me.GeneratingLabel = New System.Windows.Forms.Label()
        Me.SubCategoryCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryDataSet = New KSoft_Inventory.CategoryDataSet()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New KSoft_Inventory.DepartmentDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ItemListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemListLookupDataSet = New KSoft_Inventory.ItemListLookupDataSet()
        Me.BalanceTableAdapter = New KSoft_Inventory.BalanceDataSetTableAdapters.BalanceTableAdapter()
        Me.TableAdapterManager1 = New KSoft_Inventory.BalanceDataSetTableAdapters.TableAdapterManager()
        Me.BalanceViewDataSet = New KSoft_Inventory.BalanceViewDataSet()
        Me.BalanceViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BalanceViewTableAdapter = New KSoft_Inventory.BalanceViewDataSetTableAdapters.BalanceViewTableAdapter()
        Me.TableAdapterManager3 = New KSoft_Inventory.BalanceViewDataSetTableAdapters.TableAdapterManager()
        Me.ItemListTableAdapter1 = New KSoft_Inventory.ItemListLookupDataSetTableAdapters.ItemListTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentTableAdapter = New KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter()
        Me.bgrLongProcess = New System.ComponentModel.BackgroundWorker()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CategoryTableAdapter = New KSoft_Inventory.CategoryDataSetTableAdapters.CategoryTableAdapter()
        Me.SubCategoryLookupTableAdapter = New KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryLookupTableAdapter()
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalReceiveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IssueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceViewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemListDataSet
        '
        Me.ItemListDataSet.DataSetName = "ItemListDataSet"
        Me.ItemListDataSet.EnforceConstraints = False
        Me.ItemListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemListBindingSource
        '
        Me.ItemListBindingSource.DataMember = "ItemList"
        Me.ItemListBindingSource.DataSource = Me.ItemListDataSet
        '
        'ItemListTableAdapter
        '
        Me.ItemListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ItemLeadTimeTableAdapter = Nothing
        Me.TableAdapterManager.ItemListLookupTableAdapter = Nothing
        Me.TableAdapterManager.ItemListTableAdapter = Me.ItemListTableAdapter
        Me.TableAdapterManager.UpdateOrder = KSoft_Inventory.ItemListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BalanceBindingSource
        '
        Me.BalanceBindingSource.DataMember = "Balance"
        Me.BalanceBindingSource.DataSource = Me.BalanceDataSet
        '
        'BalanceDataSet
        '
        Me.BalanceDataSet.DataSetName = "BalanceDataSet"
        Me.BalanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToDateDateTimePicker
        '
        Me.ToDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.ToDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateDateTimePicker.Location = New System.Drawing.Point(419, 24)
        Me.ToDateDateTimePicker.Name = "ToDateDateTimePicker"
        Me.ToDateDateTimePicker.Size = New System.Drawing.Size(77, 20)
        Me.ToDateDateTimePicker.TabIndex = 5
        '
        'FromDateDateTimePicker
        '
        Me.FromDateDateTimePicker.CustomFormat = "dd-MMM-yy"
        Me.FromDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateDateTimePicker.Location = New System.Drawing.Point(283, 24)
        Me.FromDateDateTimePicker.Name = "FromDateDateTimePicker"
        Me.FromDateDateTimePicker.Size = New System.Drawing.Size(74, 20)
        Me.FromDateDateTimePicker.TabIndex = 4
        '
        'TotalReceiveDataSet
        '
        Me.TotalReceiveDataSet.DataSetName = "TotalReceiveDataSet"
        Me.TotalReceiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IssueBindingSource
        '
        Me.IssueBindingSource.DataMember = "Issue"
        Me.IssueBindingSource.DataSource = Me.TotalReceiveDataSet
        '
        'IssueTableAdapter
        '
        Me.IssueTableAdapter.ClearBeforeFill = True
        '
        'ReceiveTableAdapter
        '
        Me.ReceiveTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = KSoft_Inventory.TotalReceiveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReceiveBindingSource
        '
        Me.ReceiveBindingSource.DataMember = "Issue_Receive"
        Me.ReceiveBindingSource.DataSource = Me.IssueBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(202, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "From Date "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(364, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "To Date "
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnFilterByValue)
        Me.GroupBox1.Controls.Add(Me.btnStartProcessbyvalue)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.filterButton2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.WithCerCheckBox)
        Me.GroupBox1.Controls.Add(Me.Template3RadioButton)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RemovefilterButton)
        Me.GroupBox1.Controls.Add(Me.SubCategoryComboBox)
        Me.GroupBox1.Controls.Add(Me.Template2RadioButton)
        Me.GroupBox1.Controls.Add(Me.Template1RadioButton)
        Me.GroupBox1.Controls.Add(Me.btnStartProcess)
        Me.GroupBox1.Controls.Add(Me.PrgLongProcess)
        Me.GroupBox1.Controls.Add(Me.GeneratingLabel)
        Me.GroupBox1.Controls.Add(Me.SubCategoryCheckBox)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CategoryComboBox)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.DepartmentComboBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ToDateDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.FromDateDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1173, 93)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RadioButtonNew)
        Me.GroupBox2.Controls.Add(Me.RadioButtonOld)
        Me.GroupBox2.Location = New System.Drawing.Point(632, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(107, 38)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'RadioButtonNew
        '
        Me.RadioButtonNew.AutoSize = True
        Me.RadioButtonNew.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.RadioButtonNew.Location = New System.Drawing.Point(53, 13)
        Me.RadioButtonNew.Name = "RadioButtonNew"
        Me.RadioButtonNew.Size = New System.Drawing.Size(50, 19)
        Me.RadioButtonNew.TabIndex = 37
        Me.RadioButtonNew.Text = "New"
        Me.RadioButtonNew.UseVisualStyleBackColor = True
        '
        'RadioButtonOld
        '
        Me.RadioButtonOld.AutoSize = True
        Me.RadioButtonOld.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.RadioButtonOld.Location = New System.Drawing.Point(6, 13)
        Me.RadioButtonOld.Name = "RadioButtonOld"
        Me.RadioButtonOld.Size = New System.Drawing.Size(44, 19)
        Me.RadioButtonOld.TabIndex = 36
        Me.RadioButtonOld.Text = "Old"
        Me.RadioButtonOld.UseVisualStyleBackColor = True
        '
        'btnFilterByValue
        '
        Me.btnFilterByValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFilterByValue.Image = Global.KSoft_Inventory.My.Resources.Resources.filter
        Me.btnFilterByValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilterByValue.Location = New System.Drawing.Point(548, 59)
        Me.btnFilterByValue.Name = "btnFilterByValue"
        Me.btnFilterByValue.Size = New System.Drawing.Size(87, 23)
        Me.btnFilterByValue.TabIndex = 35
        Me.btnFilterByValue.Text = "By Value"
        Me.btnFilterByValue.UseVisualStyleBackColor = True
        '
        'btnStartProcessbyvalue
        '
        Me.btnStartProcessbyvalue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStartProcessbyvalue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStartProcessbyvalue.Location = New System.Drawing.Point(1037, 13)
        Me.btnStartProcessbyvalue.Name = "btnStartProcessbyvalue"
        Me.btnStartProcessbyvalue.Size = New System.Drawing.Size(57, 41)
        Me.btnStartProcessbyvalue.TabIndex = 30
        Me.btnStartProcessbyvalue.Text = "Show by Value"
        Me.btnStartProcessbyvalue.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(757, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "CB <"
        '
        'filterButton2
        '
        Me.filterButton2.Image = Global.KSoft_Inventory.My.Resources.Resources.filter
        Me.filterButton2.Location = New System.Drawing.Point(934, 58)
        Me.filterButton2.Name = "filterButton2"
        Me.filterButton2.Size = New System.Drawing.Size(31, 23)
        Me.filterButton2.TabIndex = 28
        Me.filterButton2.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(793, 59)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown1.TabIndex = 27
        '
        'WithCerCheckBox
        '
        Me.WithCerCheckBox.AutoSize = True
        Me.WithCerCheckBox.Location = New System.Drawing.Point(849, 61)
        Me.WithCerCheckBox.Name = "WithCerCheckBox"
        Me.WithCerCheckBox.Size = New System.Drawing.Size(87, 17)
        Me.WithCerCheckBox.TabIndex = 26
        Me.WithCerCheckBox.Text = "Only certified"
        Me.WithCerCheckBox.UseVisualStyleBackColor = True
        '
        'Template3RadioButton
        '
        Me.Template3RadioButton.AutoSize = True
        Me.Template3RadioButton.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Template3RadioButton.Location = New System.Drawing.Point(854, 24)
        Me.Template3RadioButton.Name = "Template3RadioButton"
        Me.Template3RadioButton.Size = New System.Drawing.Size(111, 19)
        Me.Template3RadioButton.TabIndex = 25
        Me.Template3RadioButton.Text = "With Production"
        Me.Template3RadioButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Category"
        '
        'RemovefilterButton
        '
        Me.RemovefilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RemovefilterButton.Location = New System.Drawing.Point(641, 59)
        Me.RemovefilterButton.Name = "RemovefilterButton"
        Me.RemovefilterButton.Size = New System.Drawing.Size(100, 23)
        Me.RemovefilterButton.TabIndex = 23
        Me.RemovefilterButton.Text = "&Remove Filter"
        Me.RemovefilterButton.UseVisualStyleBackColor = True
        '
        'SubCategoryComboBox
        '
        Me.SubCategoryComboBox.DataSource = Me.SubCategoryLookupBindingSource
        Me.SubCategoryComboBox.DisplayMember = "SubCategoryName"
        Me.SubCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubCategoryComboBox.FormattingEnabled = True
        Me.SubCategoryComboBox.Location = New System.Drawing.Point(297, 59)
        Me.SubCategoryComboBox.Name = "SubCategoryComboBox"
        Me.SubCategoryComboBox.Size = New System.Drawing.Size(151, 21)
        Me.SubCategoryComboBox.TabIndex = 21
        Me.SubCategoryComboBox.ValueMember = "SubCategoryId"
        '
        'SubCategoryLookupBindingSource
        '
        Me.SubCategoryLookupBindingSource.DataMember = "SubCategoryLookup"
        Me.SubCategoryLookupBindingSource.DataSource = Me.SubCategoryDataSet
        '
        'SubCategoryDataSet
        '
        Me.SubCategoryDataSet.DataSetName = "SubCategoryDataSet"
        Me.SubCategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Template2RadioButton
        '
        Me.Template2RadioButton.AutoSize = True
        Me.Template2RadioButton.Checked = True
        Me.Template2RadioButton.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Template2RadioButton.Location = New System.Drawing.Point(747, 24)
        Me.Template2RadioButton.Name = "Template2RadioButton"
        Me.Template2RadioButton.Size = New System.Drawing.Size(106, 19)
        Me.Template2RadioButton.TabIndex = 20
        Me.Template2RadioButton.TabStop = True
        Me.Template2RadioButton.Text = "With Sub Store"
        Me.Template2RadioButton.UseVisualStyleBackColor = True
        '
        'Template1RadioButton
        '
        Me.Template1RadioButton.AutoSize = True
        Me.Template1RadioButton.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Template1RadioButton.Location = New System.Drawing.Point(508, 24)
        Me.Template1RadioButton.Name = "Template1RadioButton"
        Me.Template1RadioButton.Size = New System.Drawing.Size(123, 19)
        Me.Template1RadioButton.TabIndex = 19
        Me.Template1RadioButton.Text = "Without Sub Store"
        Me.Template1RadioButton.UseVisualStyleBackColor = True
        '
        'btnStartProcess
        '
        Me.btnStartProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStartProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStartProcess.Location = New System.Drawing.Point(968, 13)
        Me.btnStartProcess.Name = "btnStartProcess"
        Me.btnStartProcess.Size = New System.Drawing.Size(64, 41)
        Me.btnStartProcess.TabIndex = 18
        Me.btnStartProcess.Text = "Show by QTY"
        Me.btnStartProcess.UseVisualStyleBackColor = True
        '
        'PrgLongProcess
        '
        Me.PrgLongProcess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrgLongProcess.Location = New System.Drawing.Point(968, 59)
        Me.PrgLongProcess.Name = "PrgLongProcess"
        Me.PrgLongProcess.Size = New System.Drawing.Size(199, 21)
        Me.PrgLongProcess.TabIndex = 12
        Me.PrgLongProcess.Visible = False
        '
        'GeneratingLabel
        '
        Me.GeneratingLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeneratingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneratingLabel.ForeColor = System.Drawing.Color.Red
        Me.GeneratingLabel.Location = New System.Drawing.Point(968, 63)
        Me.GeneratingLabel.Name = "GeneratingLabel"
        Me.GeneratingLabel.Size = New System.Drawing.Size(199, 19)
        Me.GeneratingLabel.TabIndex = 13
        Me.GeneratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SubCategoryCheckBox
        '
        Me.SubCategoryCheckBox.AutoSize = True
        Me.SubCategoryCheckBox.Checked = True
        Me.SubCategoryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SubCategoryCheckBox.Location = New System.Drawing.Point(204, 61)
        Me.SubCategoryCheckBox.Name = "SubCategoryCheckBox"
        Me.SubCategoryCheckBox.Size = New System.Drawing.Size(87, 17)
        Me.SubCategoryCheckBox.TabIndex = 17
        Me.SubCategoryCheckBox.Text = "SubCategory"
        Me.SubCategoryCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = Global.KSoft_Inventory.My.Resources.Resources.filter
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(455, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "By Qty"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataSource = Me.CategoryBindingSource
        Me.CategoryComboBox.DisplayMember = "CategoryName"
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(80, 59)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(116, 21)
        Me.CategoryComboBox.TabIndex = 14
        Me.CategoryComboBox.ValueMember = "CategoryId"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.CategoryDataSet
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(1098, 13)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(70, 41)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel Process"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.DataSource = Me.DepartmentBindingSource
        Me.DepartmentComboBox.DisplayMember = "DepartmentName"
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(80, 24)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(117, 21)
        Me.DepartmentComboBox.TabIndex = 9
        Me.DepartmentComboBox.ValueMember = "DepartmentId"
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DepartmentDataSet
        '
        'DepartmentDataSet
        '
        Me.DepartmentDataSet.DataSetName = "DepartmentDataSet"
        Me.DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(2, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Department"
        '
        'ItemListBindingSource1
        '
        Me.ItemListBindingSource1.DataMember = "ItemList"
        Me.ItemListBindingSource1.DataSource = Me.ItemListLookupDataSet
        '
        'ItemListLookupDataSet
        '
        Me.ItemListLookupDataSet.DataSetName = "ItemListLookupDataSet"
        Me.ItemListLookupDataSet.EnforceConstraints = False
        Me.ItemListLookupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BalanceTableAdapter
        '
        Me.BalanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BalanceTableAdapter = Me.BalanceTableAdapter
        Me.TableAdapterManager1.UpdateOrder = KSoft_Inventory.BalanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BalanceViewDataSet
        '
        Me.BalanceViewDataSet.DataSetName = "BalanceViewDataSet"
        Me.BalanceViewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BalanceViewBindingSource
        '
        Me.BalanceViewBindingSource.DataMember = "BalanceView"
        Me.BalanceViewBindingSource.DataSource = Me.BalanceViewDataSet
        '
        'BalanceViewTableAdapter
        '
        Me.BalanceViewTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = KSoft_Inventory.BalanceViewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ItemListTableAdapter1
        '
        Me.ItemListTableAdapter1.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CategoryName"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "SubCategoryName"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Sub Category"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ItemName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ItemName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OpeningBalance"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Opening Balance"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Received"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Received"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Issued"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Issued"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'bgrLongProcess
        '
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 109)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1185, 427)
        Me.CrystalReportViewer1.TabIndex = 10
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'SubCategoryLookupTableAdapter
        '
        Me.SubCategoryLookupTableAdapter.ClearBeforeFill = True
        '
        'frmStoreBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 554)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStoreBalance"
        Me.Text = "Master Store Balance [1]"
        CType(Me.ItemListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalReceiveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IssueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubCategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemListLookupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceViewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemListDataSet As KSoft_Inventory.ItemListDataSet
    Friend WithEvents ItemListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListTableAdapter As KSoft_Inventory.ItemListDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents BalanceTableAdapter As KSoft_Inventory.BalanceDataSetTableAdapters.BalanceTableAdapter
    Friend WithEvents BalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BalanceDataSet As KSoft_Inventory.BalanceDataSet
    Friend WithEvents TableAdapterManager1 As KSoft_Inventory.BalanceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager As KSoft_Inventory.ItemListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ToDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TotalReceiveDataSet As KSoft_Inventory.TotalReceiveDataSet
    Friend WithEvents IssueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IssueTableAdapter As KSoft_Inventory.TotalReceiveDataSetTableAdapters.IssueTableAdapter
    Friend WithEvents ReceiveTableAdapter As KSoft_Inventory.TotalReceiveDataSetTableAdapters.ReceiveTableAdapter
    Friend WithEvents ReceiveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager2 As KSoft_Inventory.TotalReceiveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BalanceViewDataSet As KSoft_Inventory.BalanceViewDataSet
    Friend WithEvents BalanceViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BalanceViewTableAdapter As KSoft_Inventory.BalanceViewDataSetTableAdapters.BalanceViewTableAdapter
    Friend WithEvents TableAdapterManager3 As KSoft_Inventory.BalanceViewDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemListBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ItemListLookupDataSet As KSoft_Inventory.ItemListLookupDataSet
    Friend WithEvents ItemListTableAdapter1 As KSoft_Inventory.ItemListLookupDataSetTableAdapters.ItemListTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DepartmentDataSet As KSoft_Inventory.DepartmentDataSet
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As KSoft_Inventory.DepartmentDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents PrgLongProcess As System.Windows.Forms.ProgressBar
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents bgrLongProcess As System.ComponentModel.BackgroundWorker
    Friend WithEvents GeneratingLabel As System.Windows.Forms.Label
    Friend WithEvents SubCategoryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CategoryDataSet As KSoft_Inventory.CategoryDataSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As KSoft_Inventory.CategoryDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents Template2RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Template1RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents btnStartProcess As System.Windows.Forms.Button
    Friend WithEvents SubCategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubCategoryLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubCategoryDataSet As KSoft_Inventory.SubCategoryDataSet
    Friend WithEvents SubCategoryLookupTableAdapter As KSoft_Inventory.SubCategoryDataSetTableAdapters.SubCategoryLookupTableAdapter
    Friend WithEvents RemovefilterButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Template3RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents WithCerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents filterButton2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnStartProcessbyvalue As System.Windows.Forms.Button
    Friend WithEvents btnFilterByValue As System.Windows.Forms.Button
    Friend WithEvents RadioButtonNew As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonOld As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
