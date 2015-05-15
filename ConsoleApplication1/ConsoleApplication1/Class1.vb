Public Class Class_Invisible

    Structure Structure_Log
        Public ReadOnly log As String
        Public ReadOnly time As Date

        Sub New(s As String)
            log = s
            time = Date.Now
        End Sub

        Sub WriteLog()
            Console.WriteLine("Invisible")
        End Sub
    End Structure

End Class
