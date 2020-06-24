Option Strict On

Public Class Form1


    'An array to store the day in which the program is asking for the units
    Dim arrDays() As String = {"Day 1", "Day 2", "Day 3", "Day 4", "Day 5", "Day 6", "Day 7", "Done"}
    'Updates after an employees units are all entered
    Dim employeeCounter As Integer = 0
    'Updates after a single unit input 
    Dim unitCounter As Integer = 0




    ''' <summary>
    ''' When the user clicks the enter button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click


    End Sub

    ''' <summary>
    ''' When the user clicks the exit button the program will close
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' When the user clicks the reset button, the form resets to its original state upon opening
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

    End Sub

    ''' <summary>
    ''' This function is for validating the input each time the user presses enter
    ''' </summary>
    ''' <param name="inputData"></param>
    ''' <returns></returns>
    Function ValidateInput(ByVal inputData As String) As Boolean

        Dim backup As Integer 'stores the string as a double for validation

        If IsNumeric(inputData) Then

            Integer.TryParse(inputData, backup)
            Return True
        Else
            Return False
        End If

    End Function

End Class
