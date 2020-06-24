Option Strict On

Public Class Form1

#Region "Constants and Variables"
    'Min and Max Values
    Private Const MIN_GRADE As Integer = 0
    Private Const MAX_GRADE As Integer = 5000
    Dim backup As Integer = 0
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

    Dim arrEmployeeOne(6) As Integer
    Dim arrEmployeeTwo(6) As Integer
    Dim arrEmployeeThree(6) As Integer

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

        Dim userInput As String = txtUnitInput.Text

        'If employeecounter equals 0, then enter if statement for first employee
        If employeeCounter = 0 Then

            'If the users input is valid, move one otherwise reject
            If ValidateInput(userInput) Then

                If unitCounter = 0 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtFirstEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeOne(unitCounter) = backup
                    firstBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 1 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtFirstEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeOne(unitCounter) = backup
                    firstBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 2 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtFirstEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeOne(unitCounter) = backup
                    firstBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 3 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtFirstEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeOne(unitCounter) = backup
                    firstBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 4 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtFirstEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeOne(unitCounter) = backup
                    firstBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 5 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtFirstEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeOne(unitCounter) = backup
                    firstBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 6 Then
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtFirstEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeOne(unitCounter) = backup
                    firstBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    employeeCounter += 1
                    unitCounter = 0
                    lblFirstAvg.Text = "Average:" & firstBackup / 7
                    lblDay.Text = arrDays(unitCounter)

                End If

            Else
                MessageBox.Show("Please Input a whole number between 0 and 5000!")
                txtUnitInput.Clear()
                txtUnitInput.Focus()

            End If

            'If employeecounter equals 1, then enter elseif statement for second employee
        ElseIf employeeCounter = 1 Then

            'If the users input is valid, move one otherwise reject
            If ValidateInput(userInput) Then

                If unitCounter = 0 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtSecondEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeTwo(unitCounter) = backup
                    secondBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 1 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtSecondEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeTwo(unitCounter) = backup
                    secondBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 2 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtSecondEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeTwo(unitCounter) = backup
                    secondBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 3 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtSecondEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeTwo(unitCounter) = backup
                    secondBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 4 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtSecondEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeTwo(unitCounter) = backup
                    secondBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 5 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtSecondEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeTwo(unitCounter) = backup
                    secondBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 6 Then
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtSecondEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeTwo(unitCounter) = backup
                    secondBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblSecondAvg.Text = "Average:" & secondBackup / 7
                    employeeCounter += 1
                    unitCounter = 0
                    lblDay.Text = arrDays(unitCounter)

                End If

            Else
                MessageBox.Show("Please Input a whole number between 0 and 5000!")
                txtUnitInput.Clear()
                txtUnitInput.Focus()

            End If

            'if employeecounter equals 2, then enter elseif statement for second employee
        ElseIf employeeCounter = 2 Then

            'If the users input is valid, move one otherwise reject
            If ValidateInput(userInput) Then

                If unitCounter = 0 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtThirdEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeThree(unitCounter) = backup
                    thirdBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 1 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtThirdEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeThree(unitCounter) = backup
                    thirdBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 2 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtThirdEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeThree(unitCounter) = backup
                    thirdBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 3 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtThirdEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeThree(unitCounter) = backup
                    thirdBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 4 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtThirdEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeThree(unitCounter) = backup
                    thirdBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 5 Then
                    unitCounter += 1
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtThirdEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeThree(unitCounter) = backup
                    thirdBackup += backup
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    lblDay.Text = arrDays(unitCounter)

                ElseIf unitCounter = 6 Then
                    Integer.TryParse(txtUnitInput.Text, backup)
                    txtThirdEmployeeUnits.Text += backup.ToString & vbNewLine
                    arrEmployeeThree(unitCounter) = backup
                    thirdBackup += backup
                    txtUnitInput.Clear()
                    lblThirdAvg.Text = "Average:" & thirdBackup / 7
                    txtUnitInput.Enabled = False
                    btnEnter.Enabled = False
                    lblCompanyAverage.Text = "Companies Average is: " & (firstBackup + secondBackup + thirdBackup) / 21
                    lblDay.Text = "Done!"

                End If

            End If

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

        'Resets the labels output
        ClearControls(outputLabelList)
        lblDay.Text = arrDays(unitCounter)

        'Resets Focus
        txtUnitInput.Focus()
        btnEnter.Enabled = True

    End Sub

#End Region


End Class
