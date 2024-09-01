Public Class frmLCDetailsView
    Private _LCNO As String
    Public Property LCNo() As String
        Get
            Return _LCNO
        End Get
        Set(ByVal value As String)
            _LCNO = value
        End Set
    End Property
    Private _LCDate As Date
    Public Property LCDate() As Date
        Get
            Return _LCDate
        End Get
        Set(ByVal value As Date)
            _LCDate = value
        End Set
    End Property
    Private _PINo As String
    Public Property PINO() As String
        Get
            Return _PINo
        End Get
        Set(ByVal value As String)
            _PINo = value
        End Set
    End Property
    Private _PIDate As Date
    Public Property PIDate() As Date
        Get
            Return _PIDate
        End Get
        Set(ByVal value As Date)
            _PIDate = value
        End Set
    End Property
    Private _ItemId As Integer
    Public Property ItemId() As Integer
        Get
            Return _ItemId
        End Get
        Set(ByVal value As Integer)
            _ItemId = value
        End Set
    End Property
    Private _SupplierId As Integer
    Public Property SupplierId() As Integer
        Get
            Return _SupplierId
        End Get
        Set(ByVal value As Integer)
            _SupplierId = value
        End Set
    End Property
    Private _LotNO As String
    Public Property LotNo() As String
        Get
            Return _LotNO
        End Get
        Set(ByVal value As String)
            _LotNO = value
        End Set
    End Property
    Private _DepartmentId As Integer
    Public Property DepartmentId() As Integer
        Get
            Return _DepartmentId
        End Get
        Set(ByVal value As Integer)
            _DepartmentId = value
        End Set
    End Property
    Private _LCPrice As Decimal
    Public Property LCPrice() As Decimal
        Get
            Return _LCPrice
        End Get
        Set(ByVal value As Decimal)
            _LCPrice = value
        End Set
    End Property

    Private _CompanyId As Integer
    Public Property CompanyId() As Integer
        Get
            Return _CompanyId
        End Get
        Set(ByVal value As Integer)
            _CompanyId = value
        End Set
    End Property

    Private _LCid As Integer
    Public Property LCId() As Integer
        Get
            Return _LCid
        End Get
        Set(ByVal value As Integer)
            _LCid = value
        End Set
    End Property

    Private _PIId As Integer
    Public Property PIId() As Integer
        Get
            Return _PIId
        End Get
        Set(ByVal value As Integer)
            _PIId = value
        End Set
    End Property
    Private _IsImported As Boolean
    Public Property IsImported() As Boolean
        Get
            Return _IsImported
        End Get
        Set(ByVal value As Boolean)
            _IsImported = value
        End Set
    End Property


    Private Sub frmLCDetailsView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.LCDetailsViewTableAdapter.Fill(Me.OpeningLCDataSet.LCDetailsView, Me.DepartmentId)

    End Sub

  

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        If LCDetailsViewBindingSource.Position > -1 Then

            Dim row As OpeningLCDataSet.LCDetailsViewRow
            row = CType(CType(Me.LCDetailsViewBindingSource.Current, DataRowView).Row, OpeningLCDataSet.LCDetailsViewRow)

            On Error Resume Next

            Me.LCNo = row.LCNo
            Me.LCDate = row.LCDate
            Me.PINO = row.PINo
            Me.PIDate = row.PIDate
            Me.ItemId = row.ItemId
            Me.SupplierId = row.SupplierId
            Me.LotNo = row.LotNo
            Me.LCPrice = row.LCPrice
            Me.LCId = row.LCId
            Me.PIId = row.PIId
            Me.IsImported = row.IsImported

            Me.CompanyId = ReadIntegerData("Select CompanyId From Company Where CompanyCode='" & row.CompanyCode & "'", cnn)


        End If


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

   
End Class