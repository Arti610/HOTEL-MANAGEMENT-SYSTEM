'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://visualbasicproject.blogspot.com
'---------------------------------------

Public Class frmCustomerLookup
    Dim sSql As String

    Private Sub frmCustomerLookup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sSql = "SELECT CustomerID, LastName, FirstName, Address, TelNo  FROM Customers ORDER BY LastName ASC"

        Call FillList()
    End Sub

    Public Sub FillList()
        With lvList
            .Clear()

            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("Customer ID", 0)
            .Columns.Add("Lastname", 140)
            .Columns.Add("Firstname", 140)
            .Columns.Add("Address", 200)
            .Columns.Add("TelNo", 100)

            FillListView(lvList, GetData(sSql))
        End With
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            sSql = "SELECT CustomerID, LastName, FirstName, Address, TelNo  FROM Customers ORDER BY LastName ASC"
        Else
            sSql = "SELECT CustomerID, LastName, FirstName, Address, TelNo  FROM Customers WHERE " & cboField.SelectedItem & " Like '" & txtSearch.Text & "%' ORDER BY LastName ASC"
        End If

        Call FillList()
    End Sub

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        CurrCust.Lastname = lvList.FocusedItem.SubItems(1).Text
        CurrCust.Firstname = lvList.FocusedItem.SubItems(2).Text

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class