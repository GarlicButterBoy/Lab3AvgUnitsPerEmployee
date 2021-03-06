﻿Option Strict On

Public Class Form1

#Region "Constants and Variables"
    'Min and Max Values
    Private Const MIN As Integer = 0
    Private Const MAX As Integer = 5000
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
    Dim arrEmployeeUnits(3, 7) As Integer

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
    ''' When the user clicks the enter button execute this code (its a lot!)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Do

            Do
                'Accepts user input then tries to validate
                Dim userInput As String = txtUnitInput.Text

                If ValidateInput(userInput) Then
                    'If validation succeeds move onto next if-else statement
                    'last unit entered for third employee
                    If employeeCounter = 2 And unitCounter = 6 Then
                        txtThirdEmployeeUnits.Text += txtUnitInput.Text & vbNewLine 'adds the input to the appropriate textbox, then adds a new line
                        Integer.TryParse(txtUnitInput.Text, arrEmployeeUnits(employeeCounter, unitCounter)) 'store the user input into the 2 dimensional array
                        thirdBackup += arrEmployeeUnits(employeeCounter, unitCounter) 'pulls the value from the array and stores it in a backup for later math
                        txtUnitInput.Clear()
                        txtUnitInput.Focus() 'clears textbox and re-focusses
                        employeeCounter += 1
                        lblThirdAvg.Text = "Average:" & Math.Round(thirdBackup / 7, 2) 'Does the math for employee average
                        txtUnitInput.Enabled = False 'disables input and enter button, because program is finished!
                        btnEnter.Enabled = False
                        lblCompanyAverage.Text = "Companies Average is: " & Math.Round((firstBackup + secondBackup + thirdBackup) / 21, 2) 'does the math for Company Average
                        lblDay.Text = "Done!"
                        Exit Do

                        'last unit entered for second employee
                    ElseIf employeeCounter = 1 And unitCounter = 6 Then
                        txtSecondEmployeeUnits.Text += txtUnitInput.Text & vbNewLine 'adds the input to the appropriate textbox, then adds a new line
                        Integer.TryParse(txtUnitInput.Text, arrEmployeeUnits(employeeCounter, unitCounter)) 'store the user input into the 2 dimensional array
                        secondBackup += arrEmployeeUnits(employeeCounter, unitCounter) 'pulls the value from the array and stores it in a backup for later math
                        txtUnitInput.Clear()
                        txtUnitInput.Focus() 'clears textbox and re-focusses
                        unitCounter = 0
                        employeeCounter += 1
                        lblSecondAvg.Text = "Average:" & Math.Round(secondBackup / 7, 2) 'Does the math for employee average
                        btnEnter.Enabled = False
                        lblDay.Text = arrDays(unitCounter) 'updates the current day
                        Exit Do

                        'Last unit entered for first employee
                    ElseIf employeeCounter = 0 And unitCounter = 6 Then
                        txtFirstEmployeeUnits.Text += txtUnitInput.Text & vbNewLine 'adds the input to the appropriate textbox, then adds a new line
                        Integer.TryParse(txtUnitInput.Text, arrEmployeeUnits(employeeCounter, unitCounter)) 'store the user input into the 2 dimensional array
                        firstBackup += arrEmployeeUnits(employeeCounter, unitCounter) 'pulls the value from the array and stores it in a backup for later math
                        txtUnitInput.Clear()
                        txtUnitInput.Focus() 'clears textbox and re-focusses
                        unitCounter = 0
                        employeeCounter += 1
                        lblFirstAvg.Text = "Average:" & Math.Round(firstBackup / 7, 2) 'Does the math for employee average
                        btnEnter.Enabled = False
                        lblDay.Text = arrDays(unitCounter) 'updates the current day
                        Exit Do

                        'first 6 units entered for third employee
                    ElseIf employeeCounter = 2 Then
                        txtThirdEmployeeUnits.Text += txtUnitInput.Text & vbNewLine 'adds the input to the appropriate textbox, then adds a new line
                        Integer.TryParse(txtUnitInput.Text, arrEmployeeUnits(employeeCounter, unitCounter)) 'store the user input into the 2 dimensional array
                        thirdBackup += arrEmployeeUnits(employeeCounter, unitCounter) 'pulls the value from the array and stores it in a backup for later math
                        txtUnitInput.Clear()
                        txtUnitInput.Focus() 'clears textbox and re-focusses
                        unitCounter += 1
                        lblDay.Text = arrDays(unitCounter) 'updates the current day
                        btnEnter.Enabled = False
                        Exit Do

                        'first 6 units entered for second employee
                    ElseIf employeeCounter = 1 Then
                        txtSecondEmployeeUnits.Text += txtUnitInput.Text & vbNewLine 'adds the input to the appropriate textbox, then adds a new line
                        Integer.TryParse(txtUnitInput.Text, arrEmployeeUnits(employeeCounter, unitCounter)) 'store the user input into the 2 dimensional array
                        secondBackup += arrEmployeeUnits(employeeCounter, unitCounter) 'pulls the value from the array and stores it in a backup for later math
                        txtUnitInput.Clear()
                        txtUnitInput.Focus() 'clears textbox and re-focusses
                        unitCounter += 1
                        lblDay.Text = arrDays(unitCounter) 'updates the current day
                        btnEnter.Enabled = False
                        Exit Do

                        'first 6 units entered for third employee
                    ElseIf employeeCounter = 0 Then
                        txtFirstEmployeeUnits.Text += txtUnitInput.Text & vbNewLine 'adds the input to the appropriate textbox, then adds a new line
                        Integer.TryParse(txtUnitInput.Text, arrEmployeeUnits(employeeCounter, unitCounter)) 'store the user input into the 2 dimensional array
                        firstBackup += arrEmployeeUnits(employeeCounter, unitCounter) 'pulls the value from the array and stores it in a backup for later math
                        txtUnitInput.Clear()
                        txtUnitInput.Focus() 'clears textbox and re-focusses
                        unitCounter += 1
                        lblDay.Text = arrDays(unitCounter) 'updates the current day
                        btnEnter.Enabled = False
                        Exit Do
                    End If
                Else
                    'If validation fails
                    MessageBox.Show("Please Input a whole number between 0 and 5000!")
                    txtUnitInput.Clear()
                    txtUnitInput.Focus()
                    Exit Do
                End If
            Loop While unitCounter <= 6

            'When done, do not reset the enter button
            If employeeCounter = 3 Then
                Exit Do
            End If
            'resets the enter button
            btnEnter.Enabled = True
            Exit Do

        Loop While employeeCounter <= 2 'loops until the employeeCounter is above 3

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
            'If the number is outside of our minimum and maximum
            If (backup < MIN Or backup > MAX) Then
                Return False
            Else
                Return True 'otherwise validate
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
