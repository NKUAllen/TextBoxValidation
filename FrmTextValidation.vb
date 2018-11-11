Option Strict On

Public Class frmTextValidation

    Private Sub bntSubmit_Click(sender As Object, e As EventArgs) Handles bntSubmit.Click

        Dim strString As String

        txtCreditNumber.BackColor = Color.White
        txtName.BackColor = Color.White

        If Validation(strString) = True Then

            lblName.Text = "Your name: " & txtName.Text

            lblCredit.Text = "Your credit card: " & txtCreditNumber.Text
        End If

    End Sub

    Function Validation(ByRef strString As String) As Boolean

        strString = txtCreditNumber.Text

        Dim intCount As Integer
        Dim intIndex As Integer
        Dim intTotal As Integer

        'Name
        If txtName.Text = String.Empty Then

            txtName.BackColor = Color.Yellow
            txtName.Focus()
            MessageBox.Show("Enter your name!!!")
            Return False

        End If

        'Is credit card  empty?
        If txtCreditNumber.Text = String.Empty Then

            txtCreditNumber.BackColor = Color.Yellow
            txtCreditNumber.Focus()
            MessageBox.Show("Enter your credit card!!!")
            Return False
        End If

        'Credit card text box
        If (txtCreditNumber.Text) Like ("*[!0-9 ]*") Then

            txtCreditNumber.BackColor = Drawing.Color.Yellow
            MessageBox.Show("Enter number only for credit card number!!!")
            Return False
        Else

            Do While intIndex < strString.Length

                If strString(intIndex) = " " Then

                    intCount += 1

                    intIndex += 1

                Else

                    intIndex += 1

                End If

            Loop

            intTotal = intIndex - intCount

            If intTotal > 16 Then

                MessageBox.Show("It's not valid credit card.")
                txtCreditNumber.BackColor = Drawing.Color.Yellow
                Return False

            ElseIf intTotal < 16 Then

                MessageBox.Show("It's not valid credit card.")
                txtCreditNumber.BackColor = Drawing.Color.Yellow
                Return False

            End If

        End If

        Return True

    End Function

    Private Sub bntClear_Click(sender As Object, e As EventArgs) Handles bntClear.Click

        txtCreditNumber.Clear()
        txtName.Clear()

        lblName.Text = String.Empty
        lblCredit.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class
