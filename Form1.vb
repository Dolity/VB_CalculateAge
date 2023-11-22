Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click

        Dim age As Long

        Try
            age = Convert.ToInt64(txtAge.Text)
            txtMonth.Text = Convert.ToString(age * 12)
            txtWeek.Text = Convert.ToString(age * 52)
            txtDay.Text = Convert.ToString(age * 365)
            txtHour.Text = Convert.ToString(age * 365 * 24)
            txtMinute.Text = Convert.ToString(age * 365 * 24 * 60)
            txtSecond.Text = Convert.ToString(age * 365 * 24 * 60 * 60)
        Catch ex As Exception
            MsgBox(ex.Message)
            l2.Focus()
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are you sure to exit?", "Age Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Information.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim iReset As DialogResult

        iReset = MessageBox.Show("Are you sure to Reset?", "Age Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If iReset = DialogResult.Yes Then

            txtAge.Text = ""
            txtMonth.Text = ""
            txtWeek.Text = String.Empty
            txtDay.Text = String.Empty
            txtHour.Text = String.Empty
            txtMinute.Text = String.Empty
            txtSecond.Text = String.Empty


        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim fileName As String = "ageSaved.txt"
        Dim downloadFolderPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
        Dim filePath As String = Path.Combine(downloadFolderPath, fileName)

        Using writer As New StreamWriter(filePath)
            writer.WriteLine("Full name" + vbTab + ":" + txtFullName.Text)
            writer.WriteLine("Age" + vbTab + vbTab + ":" + txtAge.Text)
            writer.WriteLine("Months" + vbTab + vbTab + ":" + txtMonth.Text)
            writer.WriteLine("Weeks" + vbTab + vbTab + ":" + txtWeek.Text)
            writer.WriteLine("Days" + vbTab + vbTab + ":" + txtDay.Text)
            writer.WriteLine("Hours" + vbTab + vbTab + ":" + txtHour.Text)
            writer.WriteLine("Minutes" + vbTab + vbTab + ":" + txtMinute.Text)
            writer.WriteLine("Seconds" + vbTab + vbTab + ":" + txtSecond.Text)
        End Using

        MessageBox.Show($"Data saved to {filePath}")

    End Sub
End Class
