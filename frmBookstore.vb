' Author: Xavier Hall
' Date: 8 May 2020
' Program: College Bookstore Access Codes
' Purpose: The purpose of this program is to allow users to purchase access codes of software from the campus bookstore.
Public Class frmBookstore
    Protected strCreditCardNumber As String
    Protected strSoftware As String
    Protected decDiscount As Decimal
    Protected decDiscountAmount As Decimal
    Protected decTotal As Decimal
    Const cVisio As Decimal = 14.99D
    Const cQuickbooks As Decimal = 24.99D
    Const cProject As Decimal = 17.99D
    Const cPowerBi As Decimal = 9.99D
    Const cSpeedType As Decimal = 29.99D
    Protected bBtnClicked As Boolean = False
    Protected _VisioSales As Integer = 0
    Protected _QuickbooksSales As Integer = 0
    Protected _ProjectSales As Integer = 0
    Protected _PowerBiSales As Integer = 0
    Protected _SpeedTypeSales As Integer = 0

    Public Function ComputeCosts() As Decimal
        If chkVisio.Checked Then
            decTotal = decTotal + cVisio
        End If
        If chkQuickBooks.Checked Then
            decTotal = decTotal + cQuickbooks
        End If
        If chkProject.Checked Then
            decTotal = decTotal + cProject
        End If
        If chkPowerBi.Checked Then
            decTotal = decTotal + cPowerBi
        End If
        If chkSpeedType.Checked Then
            decTotal = decTotal + cSpeedType
        End If


        Return decTotal
    End Function

    Public Function ComputeDiscountedCosts() As Decimal
        If chkVisio.Checked Then
            decTotal = decTotal + (cVisio - cVisio * 0.06)
        End If
        If chkQuickBooks.Checked Then
            decTotal = decTotal + (cQuickbooks - cQuickbooks * 0.08)
        End If
        If chkProject.Checked Then
            decTotal = decTotal + (cProject - cProject * 0.08)
        End If
        If chkPowerBi.Checked Then
            decTotal = decTotal + (cPowerBi - cPowerBi * 0.05)
        End If
        If chkSpeedType.Checked Then
            decTotal = decTotal + (cSpeedType - cSpeedType * 0.02)
        End If
        Return decTotal
    End Function

    Sub RecordSales()
        If bBtnClicked = True And chkVisio.Checked Then
            _VisioSales += 1
            lblVisio.Text = "Visio Sales: " & _VisioSales.ToString()
            lblVisio.Visible = True
        Else
            lblVisio.Text = "Visio Sales: " & _VisioSales.ToString()
            lblVisio.Visible = True
        End If
        If bBtnClicked = True And chkQuickBooks.Checked Then
            _QuickbooksSales += 1
            lblQuickbooks.Text = "Quickbooks Sales: " & _QuickbooksSales.ToString()
            lblQuickbooks.Visible = True
        Else
            lblQuickbooks.Text = "Quickbooks Sales: " & _QuickbooksSales.ToString()
            lblQuickbooks.Visible = True
        End If
        If bBtnClicked = True And chkProject.Checked Then
            _ProjectSales += 1
            lblProject.Text = "Project Sales: " & _ProjectSales.ToString()
            lblProject.Visible = True
        Else
            lblProject.Text = "Project Sales: " & _ProjectSales.ToString()
            lblProject.Visible = True
        End If
        If bBtnClicked = True And chkPowerBi.Checked Then
            _PowerBiSales += 1
            lblPowerBi.Text = "Power Bi Sales: " & _PowerBiSales.ToString()
            lblPowerBi.Visible = True
        Else
            lblPowerBi.Text = "Power Bi Sales: " & _PowerBiSales.ToString()
            lblPowerBi.Visible = True
        End If
        If bBtnClicked = True And chkSpeedType.Checked Then
            _SpeedTypeSales += 1
            lblSpeedType.Text = "Speed Type Sales: " & _SpeedTypeSales.ToString()
            lblSpeedType.Visible = True
        Else
            lblSpeedType.Text = "Speed Type Sales: " & _SpeedTypeSales.ToString()
            lblSpeedType.Visible = True
        End If
        bBtnClicked = False

    End Sub

    Sub WriteRecord()
        strCreditCardNumber = txtCardNumber.Text
        strSoftware = ""
        If chkVisio.Checked = True Then
            strSoftware = "Visio ,"
        End If
        If chkQuickBooks.Checked = True Then
            strSoftware = strSoftware + " Quickbooks"
        End If
        If chkProject.Checked = True Then
            strSoftware = strSoftware + ", Project"
        End If
        If chkPowerBi.Checked = True Then
            strSoftware = strSoftware + ", Power Bi"
        End If
        If chkSpeedType.Checked = True Then
            strSoftware = strSoftware + ", Speed Type"
        End If

        If radNo.Checked = True Then
            decDiscount = 0D
        ElseIf radYes.Checked = True Then
            decDiscount = decDiscountAmount
            decTotal = -1 * (ComputeCosts() - ComputeDiscountedCosts())
        End If

        Dim strNameandLocationOfFile As String = "C:\Users\Xavier\Desktop\EntryLog.txt"

        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strNameandLocationOfFile)

            objWriter.Write(strCreditCardNumber & " , ")
            objWriter.Write(strSoftware & " , ")
            objWriter.Write(decDiscount & " , ")
            objWriter.Write(decTotal)
            objWriter.WriteLine("")
            objWriter.Close()

        Catch ex As Exception
            MsgBox("No device available - program aborted", , "Error")
            Application.Exit()
        End Try
        decTotal = 0
    End Sub
    Private Sub frmBookstore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCardNumber.Mask = ""
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCardNumber.Clear()
        txtExpDate.Clear()
        radYes.Checked = False
        radNo.Checked = False
        chkPowerBi.Checked = False
        chkProject.Checked = False
        chkQuickBooks.Checked = False
        chkSpeedType.Checked = False
        chkVisio.Checked = False
        lblTotal.Visible = False
        txtCardNumber.Focus()
        lblVisio.Visible = False
        lblQuickbooks.Visible = False
        lblProject.Visible = False
        lblPowerBi.Visible = False
        lblSpeedType.Visible = False
        decTotal = 0
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Input Validation
        If txtCardNumber.TextLength <> 16 Then
            MsgBox("Please enter a valid credit card number in the credit card number box.", , "Error")
            txtCardNumber.Clear()
            txtCardNumber.Focus()
        ElseIf txtExpDate.MaskCompleted = False Then
            MsgBox("Please enter the expiration date in the expiration date box. (Format is: MM/DD)", , "Error")
            txtExpDate.Clear()
            txtExpDate.Focus()
        ElseIf radNo.Checked = False And radYes.Checked = False Then
            MsgBox("Please select whether or not you are student.", , "Error")
            grpStudent.Focus()
        ElseIf chkPowerBi.Checked = False And chkProject.Checked = False And chkQuickBooks.Checked = False And chkSpeedType.Checked = False And chkVisio.Checked = False Then
            MsgBox("Please select the software you wish to purchase.", , "Error")
        ElseIf radNo.Checked = True Then
            lblTotal.Text = "Information received. Your credit card will be charged: " & ComputeCosts().ToString("C2")
            lblTotal.Visible = True
            bBtnClicked = True
        ElseIf radYes.Checked = True Then
            lblTotal.Text = "Information received. Your credit card will be charged: " & ComputeDiscountedCosts().ToString("C2")
            lblTotal.Visible = True
            bBtnClicked = True
        End If

        ' Recording the information and writing to a file
        WriteRecord()

    End Sub

    Private Sub btnDailyTotal_Click(sender As Object, e As EventArgs) Handles btnDailyTotal.Click
        RecordSales()
    End Sub
End Class
