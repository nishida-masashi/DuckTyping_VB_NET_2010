Module Module1

    Sub Main()
        Class_Normal.GetValue.WriteLog()
        Class_Invisible.GetValue.WriteLog()
    End Sub

    Structure Structure_Log
        Public ReadOnly log As String
        Public ReadOnly time As Date

        Sub New(s As String)
            log = s
            time = Date.Now
        End Sub

        Sub WriteLog()
            Console.WriteLine(time.ToString + log)
        End Sub
    End Structure

End Module

Partial Class Class_Normal

    Shared t As New Structure_Log("Class_Normal")

    Shared Function GetValue() As Structure_Log
        Return t
    End Function

End Class

Partial Class Class_Invisible

    Shared t As New Structure_Log("Class_Invisible")

    Shared Function GetValue() As Structure_Log
        Return t
    End Function

End Class


