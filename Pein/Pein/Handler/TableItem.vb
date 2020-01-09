Public Class TableItem
    ' a list of them to track more than one table:

    Public Property Name As String
    Public Property CheckSum As Int64

    Public Sub New(n As String)
        Name = n
        CheckSum = 0
    End Sub
End Class

