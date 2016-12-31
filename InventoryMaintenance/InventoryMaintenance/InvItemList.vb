'Author: Ben Parsell
'Project: Lab 10
'Date: 4/5/2016
Public Class InvItemList
    Private invItems As List(Of InvItem)

    Public Sub New()
        invItems = New List(Of InvItem)
    End Sub

    Public ReadOnly Property Count As Integer
        Get
            Return invItems.Count
        End Get
    End Property

    Default Public Property GetItemByIndex(index As Integer) As InvItem
        Get
            If index < 0 OrElse index >= invItems.Count Then
                Throw New ArgumentOutOfRangeException("index", "The index must be between 0 and " & invItems.Count - 1 & ".")
            Else
                Return invItems(index)
            End If
        End Get
        Set(value As InvItem)
            invItems(index) = value
        End Set
    End Property

    Public Sub Add(invItem As InvItem)
        invItems.Add(invItem)
        RaiseEvent Changed(Me)
    End Sub

    Public Sub Add(itemNo As Integer, description As String, price As Decimal)
        Dim item As New InvItem(itemNo, description, price)
        RaiseEvent Changed(Me)
        invItems.Add(item)
    End Sub

    Public Sub Remove(invItem As InvItem)
        invItems.Remove(invItem)
        RaiseEvent Changed(Me)
    End Sub

    Public Sub Fill()
        invItems = InvItemDB.GetItems
    End Sub

    Public Sub Save()
        InvItemDB.SaveItems(invItems)
    End Sub

    Public Event Changed(invItems As InvItemList)

    Public Shared Operator +(p1 As InvItemList, p As InvItem) As InvItemList
        p1.Add(p)
        Return p1
    End Operator

    Public Shared Operator -(p1 As InvItemList, p As InvItem) As InvItemList
        p1.Remove(p)
        Return p1
    End Operator


End Class
