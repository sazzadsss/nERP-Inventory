Imports DevExpress.XtraGrid
Imports DevExpress.XtraPrinting
Imports System.Xml
Public Class frmOIMSheet
    Dim fileName As String = "D:\SavedLayoutToXML1.xml"
    Dim i As Integer
    Private Sub OIM_SHEETBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OIM_SHEETBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OIM_SHEETBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OIM_SheetDataSet)

    End Sub

    Private Sub frmOIMSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OIM_SheetDataSet.OIM_SHEET' table. You can move, or remove it, as needed.
        Me.OIM_SHEETTableAdapter.FillByDepartmentId(Me.OIM_SheetDataSet.OIM_SHEET, DepartmentId)

        On Error Resume Next
        OIM_SHEETGridControl.ForceInitialize()
        ' Restore the previously saved layout
        OIM_SHEETGridControl.MainView.RestoreLayoutFromXml(fileName)

        Me.OIM_SheetDataSet.OIM_SHEET.DepartmentIdColumn.DefaultValue = DepartmentId




    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripButton.Click
        ' '' '' ''Declare a SaveFileDialog object

        '' '' ''Dim objSaveFileDialog As New SaveFileDialog

        ' '' '' ''Set the Save dialog properties
        '' '' ''With objSaveFileDialog
        '' '' ''    .DefaultExt = "xls"
        '' '' ''    .FileName = "OIMSheet-XYZ"
        '' '' ''    .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
        '' '' ''    .FilterIndex = 1
        '' '' ''    .OverwritePrompt = True
        '' '' ''    .Title = "Save File Dialog"
        '' '' ''End With

        ' '' '' ''Show the Save dialog and if the user clicks the Save button,
        ' '' '' ''save the file
        '' '' ''If objSaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

        '' '' ''    Try

        '' '' ''        BandedGridView1.ExportToXls(objSaveFileDialog.FileName)
        '' '' ''        'MessageBox.Show("Exported to ""C:\Order Booking.xls"" Successfully", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '' '' ''    Catch ex As Exception

        '' '' ''        MessageBox.Show(ex.Message)

        '' '' ''    End Try



        '' '' ''End If

        ' '' '' ''Clean up
        '' '' ''objSaveFileDialog.Dispose()
        '' '' ''objSaveFileDialog = Nothing



        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()





    End Sub

    Private Sub CopyToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripButton.Click

        On Error Resume Next

        If OIM_SHEETBindingSource.Position > -1 Then

            Dim row As OIM_SheetDataSet.OIM_SHEETRow
            row = CType(CType(Me.OIM_SHEETBindingSource.Current, DataRowView).Row, OIM_SheetDataSet.OIM_SHEETRow)
            Dim mydate As Nullable(Of DateTime)


            'i = ReadIntData("Select Max(SLNo) From OIM_SHEET WHERE OIM_NO='" & row.OIM_NO & "'", cnn)

            Dim newRow As OIM_SheetDataSet.OIM_SHEETRow = Me.OIM_SheetDataSet.OIM_SHEET.NewRow()
            'i = i + 1
            newRow.OIM_NO = row.OIM_NO
            newRow.OIM_DATE = row.OIM_DATE
            newRow.PO_DATE = row.PO_DATE
            newRow.ESL_REF = row.ESL_REF
            newRow.STYLE_NO = row.STYLE_NO
            newRow.DESCRIPTION = row.DESCRIPTION
            newRow.FABRIC_DESCRIPTION = row.FABRIC_DESCRIPTION
            newRow.PO_NO = row.PO_NO
            newRow.COLOR = row.COLOR
            newRow.COLOR_CODE = row.COLOR_CODE
            newRow.LAB_DIP_REF = row.LAB_DIP_REF
            newRow.ORDER_QUANTITY = row.ORDER_QUANTITY
            newRow.SEAL_BY_DATE = row.SEAL_BY_DATE
            newRow.EX_FACTORY_DATE = row.EX_FACTORY_DATE
            newRow.MUST_EX_BD = row.MUST_EX_BD
            newRow.MODE = row.MODE
            newRow.PACK = row.PACK
            newRow.BARCHODE_PRICE = row.BARCHODE_PRICE
            newRow.TTL_PACKS = row.TTL_PACKS
            newRow.FOB_PRICE = row.FOB_PRICE
            newRow.PO_TYPE = row.PO_TYPE
            newRow.DESTINATION = row.DESTINATION
            newRow.ADDRESS = row.ADDRESS
            newRow.TABTEST = row.TABTEST
            newRow.IS_ACKNOWLEDGEMENT = row.IS_ACKNOWLEDGEMENT
            newRow.ACKNOWLEDGEMENTDATE = mydate
            newRow.BARCODE_RECEIVED = mydate
            newRow.BARCODE_DELIVERED = mydate
            newRow.DepartmentId = DepartmentId
            newRow.SLNO = BandedGridView1.RowCount + 1
            newRow.PRINT_LINE = row.PRINT_LINE
            newRow.IS_OIMRECEIVED = row.IS_OIMRECEIVED
            newRow.ProgramNo = row.ProgramNo



            Me.OIM_SheetDataSet.OIM_SHEET.Rows.Add(newRow)


        End If


    End Sub

    Private Sub frmOIMSheet_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next
        OIM_SHEETGridControl.MainView.SaveLayoutToXml(fileName)

    End Sub


    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "ECHOTEX LIMITED" & vbNewLine & "OIM SHEET"
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 14, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
    End Sub

   
    Private Sub OIMPendingToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OIMPendingToolStripButton.Click
        ExecuteQuery("Update OIM_SHEET SET OIM_NO=NULL Where OIM_NO=' '", cnn)
        OIM_SHEETBindingSource.Filter = "Is_Acknowledgement=1 And OIM_NO is NULL"
    End Sub

    Private Sub AcknowledgementPendingToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcknowledgementPendingToolStripButton.Click

        OIM_SHEETBindingSource.Filter = "Is_Acknowledgement=0 And OIM_NO is NOT NULL"
    End Sub

    Private Sub AllToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripButton.Click
        OIM_SHEETBindingSource.Filter = ""

    End Sub

    Private Sub BandedGridView1_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles BandedGridView1.RowStyle

        If e.RowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle Then
            e.Appearance.BackColor = Color.YellowGreen
        End If


    End Sub

   
    Private Sub ReceiveAcknowledgeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveAcknowledgeToolStripButton.Click
        ' Import System.Xml namespace



        ' Create an isntance of XmlTextReader and call Read method to read the(file)
        Dim textReader As XmlTextReader = New XmlTextReader("E:/Acknowledgement.xml")
        'Dim readElement = XElement.Load(textReader)
        Dim PONO As String = ""
        While textReader.Read()


            If textReader.Name.ToString() = "PONO" Then
                ' Move to fist element
                'textReader.MoveToElement()
                'Console.WriteLine("Name:" + textReader.Name)
                'Console.WriteLine("Base URI:" + textReader.BaseURI)
                'Console.WriteLine("Local Name:" + textReader.LocalName)
                'Console.WriteLine("Attribute Count:" + textReader.AttributeCount.ToString())
                'Console.WriteLine("Depth:" + textReader.Depth.ToString())
                'Console.WriteLine("Line Number:" + textReader.LineNumber.ToString())
                'Console.WriteLine("Node Type:" + textReader.NodeType.ToString())
                'Console.WriteLine("Attribute Count:" + textReader.Value.ToString())


                'Dim PONo As String = String.Empty
                'PONo = ReadStringData("Select PO_No From OIM_Sheet Where PO_NO='" & textReader("PONO") & "'", cnn)

                'If PONo = textReader("PONO") Then
                '    Debug.Print(PONo.ToString & "/" & textReader("PONO"))
                PONO = textReader.ReadString
                ExecuteQuery("Update OIM_SHEET Set IS_ACKNOWLEDGEMENT=1 Where PO_NO='" & PONO & "'", cnn)
                'End If

                MessageBox.Show("PO NO : " & PONO & ",  Acknowledgement Received")


            End If

            If textReader.Name.ToString() = "AcknowledgementDate" Then

                'Dim ReceivedDate As Date
                'ReceivedDate = textReader.ReadString
                'ReceivedDate = Date.ParseExact(textReader.ReadString, "dd/mm/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                ExecuteQuery("Update OIM_SHEET Set ACKNOWLEDGEMENTDATE='" & Today() & "' Where PO_NO='" & PONO & "'", cnn)
                'MessageBox.Show(ReceivedDate)
                'End If
            End If

        End While
        ' If the node has value


        '*** XmlTextReader
        'Dim XmlReader As New XmlTextReader(server.MapPath("test.xml"))

        ''*** Uncomment to use XmlReader
        ''Dim XmlReader As XmlReader = XmlReader.Create(server.MapPath("test.xml"))

        ''*** Uncomment to use XmlNodeReader
        ''Dim XMLDocument = New XmlDocument
        ''XMLDocument.Load(server.MapPath("test.xml"))
        ''Dim XmlReader = New XmlNodeReader(XMLDocument)

        'Dim intID, intProductCountTotal As Integer
        'Dim strPrice, strWeight, strDescription As String

        'While XmlReader.Read()

        '    'extract the atribute "Id" value when the reader reach the "Product" element.
        '    If XmlReader.Name.ToString() = "Product" Then
        '        If XmlReader.HasAttributes Then
        '            While XmlReader.MoveToNextAttribute()
        '                If XmlReader.Name = "Id" Then
        '                    intID = CInt(XmlReader.Value)
        '                End If
        '            End While
        '        End If
        '    End If
        '    If XmlReader.Name.ToString() = "price" Then strPrice = Trim(XmlReader.ReadString())
        '    If XmlReader.Name.ToString() = "weight" Then strWeight = Trim(XmlReader.ReadString())
        '    If XmlReader.Name.ToString() = "description" Then strDescription = Trim(XmlReader.ReadString())

        '    'When the end of each <Product> element is reached by the XmlReader, you can extract all the values you need and import them into a database or whatever
        '    'These readers provide forward-only access to XML data, so I choose to extract the data from each of the elements, and then use the values
        '    If XmlReader.Name.ToString() = "Product" And XmlReader.NodeType.ToString() = "EndElement" Then

        '        response.write("Values at product ID " & CStr(intID) & " is:<br>")
        '        response.write("- price: " & strPrice & "<br>")
        '        response.write("- weight: " & strWeight & "<br>")
        '        response.write("- description: " & strDescription & "<br>")

        '        'Reset the values for next product
        '        intID = 0
        '        strPrice = ""
        '        strWeight = ""
        '        strDescription = ""

        '        intProductCountTotal += 1

        '    End If

        'End While

        'XmlReader.Close()

        '' print the number of <Products> elements counted
        'response.write("<br>Products in XML doc: " & CStr(intProductCountTotal))










    End Sub

    Private Sub BandedGridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles BandedGridView1.CellValueChanged

        If e.Column.Caption = "Is Barcode Received" Then

            'Dim row As StylewiseAccessoriesDataSet.StyleCapture_AccessoriesRow
            'row = CType(CType(Me.StyleCapture_AccessoriesBindingSource.Current, DataRowView).Row, StylewiseAccessoriesDataSet.StyleCapture_AccessoriesRow)

            If e.Value.ToString() = 1 Then


                'Dim WastagePercentage As Integer = ReadIntData("Select WastagePercentage From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)
                'Dim TUnitId As Integer = ReadIntegerData("Select UnitId From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)
                'Dim IsSizeWise As Boolean = ReadBooleanData("Select IsSizeWise From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)
                'Dim IsColorWise As Boolean = ReadBooleanData("Select IsColorWise From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)
                'Dim IsPack As Boolean = ReadBooleanData("Select IsPack From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)
                'Dim PackType As String = ReadStringData("Select PackType From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)
                'Dim IsCosting As Boolean = ReadBooleanData("Select IsCosting From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)
                'Dim SupplierId As Integer = ReadIntegerData("Select SupplierId From AccessoriesList Where AccessoriesId=" & row.AccessoriesId, cnn)


                BandedGridView1.SetRowCellValue(e.RowHandle, BandedGridView1.Columns("BarCodeReceived"), Today)
                'GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("TUnitId"), TUnitId)
                'GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("IsSizeWise"), IsSizeWise)
                'GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("IsColorWise"), IsColorWise)
                'GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("IsPack"), IsPack)
                'GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("PackType"), PackType)
                'GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("IsCosting"), IsCosting)
                'GridView1.SetRowCellValue(e.RowHandle, GridView1.Columns("SupplierId"), SupplierId)


            End If


        End If

    End Sub
End Class