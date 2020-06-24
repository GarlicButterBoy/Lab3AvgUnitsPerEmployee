Option Strict On

Public Class Form1

#Region "Constants and Variables"
    'Min and Max Values
    Private Const MIN_GRADE As Integer = 0
    Private Const MAX_GRADE As Integer = 5000

    'Updates after an employees units are all entered
    Dim employeeCounter As Integer = 0
    'Updates after a single unit input 
    Dim unitCounter As Integer = 0
    'Stores running totals for employees
    Dim firstBackup, secondBackup, thirdBackup As Integer

    Dim inputTextBoxList As TextBox()
    Dim outputLabelList As Label()


#End Region

#Region "Arrays of Sorts"
    'An array to store the day in which the program is asking for the units
    Dim arrDays() As String = {"Day 1", "Day 2", "Day 3", "Day 4", "Day 5", "Day 6", "Day 7"}

    Dim arrEmployeeOne(6) As String
    Dim arrEmployeeTwo(6) As String
    Dim arrEmployeeThree(6) As String

    ''' <summary>
    ''' Creates an array of my text boxes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmTextBoxArray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputTextBoxList = {txtFirstEmployeeUnits, txtSecondEmployeeUnits, txtThirdEmployeeUnits, txtUnitInput}
    End Sub

    ''' <summary>
    ''' Creates an array of my output labels
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmLabelsArray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        outputLabelList = {lblFirstAvg, lblSecondAvg, lblThirdAvg, lblCompanyAverage}
    End Sub

#End Region

#Region "Buttons"
    ''' <summary>
    ''' When the user clicks the enter button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'Validation

        'If employeecounter equals 0, then enter if statement for first employee
        If employeeCounter = 0 Then




            'If employeecounter equals 1, then enter elseif statement for second employee
        ElseIf employeeCounter = 1 Then

            'if employeecounter equals 2, then enter elseif statement for second employee
        ElseIf employeeCounter = 2 Then

        End If

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
        StartAnew()
    End Sub

#End Region


#Region "Functions and Subroutines"
    ''' <summary>
    ''' This function is for validating the input each time the user presses enter
    ''' </summary>
    ''' <param name="inputData"></param>
    ''' <returns></returns>
    Function ValidateInput(ByVal inputData As String) As Boolean

        Dim backup As Integer 'stores the string as a double for validation

        If IsNumeric(inputData) Then
            'If the input is a number, then assign that value to backup
            Integer.TryParse(inputData, backup)

            If (backup < MIN_GRADE Or backup > MAX_GRADE) Then
                Return False
            Else
                Return True
            End If

        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' Clears the text propert of all controls in an array
    ''' </summary>
    ''' <param name="controlArray"></param>
    Sub ClearControls(controlArray As Control())
        'For every control in the list that is passed in, empty its text property
        For Each controlToClear As Control In controlArray
            controlToClear.Text = String.Empty
        Next
    End Sub

    ''' <summary>
    ''' Executes when the user pressed the reset button, will reset the form as if it were just opened
    ''' </summary>
    Sub StartAnew()
        'Resets the labels output
        ClearControls(outputLabelList)

        'Resets the text boxes
        ClearControls(inputTextBoxList)
        txtFirstEmployeeUnits.Enabled = True
        txtSecondEmployeeUnits.Enabled = True
        txtThirdEmployeeUnits.Enabled = True
        txtUnitInput.Enabled = True

        'Resets our variables
        employeeCounter = 0
        unitCounter = 0
        firstBackup = 0
        secondBackup = 0
        thirdBackup = 0

        'Resets Focus
        txtUnitInput.Focus()
        btnEnter.Enabled = True
    End Sub

#End Region


End Class
