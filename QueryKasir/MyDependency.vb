Public Class MyDependency

    Public Function SelectDependencyScript() As String
        Return <SQL>
          SELECT
            t_statusbed.statusBed
        FROM
            t_statusbed
                </SQL>
    End Function

End Class
