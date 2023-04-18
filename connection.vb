Imports System.Data.SqlClient

Module connection
    Public cn As New SqlConnection("Data Source=(localdb)\Local;Initial Catalog=Stock_charefi;Integrated Security=True")
    Public id As Integer
    Public nom As String
    Public prenom As String
    Public idVente As Integer


End Module
