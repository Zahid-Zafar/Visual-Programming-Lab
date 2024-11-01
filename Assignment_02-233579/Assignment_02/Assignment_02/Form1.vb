'Imports System.Drawing
''Imports System.Reflection.Emit
'Imports System.Security.Policy
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
'Imports DocumentFormat.OpenXml.Drawing.Diagrams
'Imports DocumentFormat.OpenXml.Vml
'Imports DocumentFormat.OpenXml.Spreadsheet
'Imports Nest
'Imports OpenXmlPowerTools
'Imports System.Windows.Forms
'Imports Font = System.Drawing.Font
Imports System.Drawing ' General System.Drawing namespace for graphics
Imports System.Windows.Forms ' Windows Forms for UI elements

' Import specific OpenXML namespaces with aliases to avoid ambiguity
Imports OpenXmlDiagrams = DocumentFormat.OpenXml.Drawing.Diagrams
Imports OpenXmlVml = DocumentFormat.OpenXml.Vml
Imports OpenXmlSpreadsheet = DocumentFormat.OpenXml.Spreadsheet

' You can alias other specific imports if needed or keep them without conflicts
Imports Nest
Imports OpenXmlPowerTools

' Alias System.Drawing.Font to avoid conflicts with other potential 'Font' classes
Imports Font = System.Drawing.Font





Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim arr As String() = {"Tamil Nadu", "Kerala", "Telangana", "Andhra Pradesh", "Delhi"}

        ComboBox1.Items.AddRange(arr)

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles gender_label.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    'Private Sub send_bt_Click(sender As Object, e As EventArgs)
    'MessageBox.Show("Submit Successfully!", "Submit", MessageBoxButtons.OKCancel)
    ' End Sub

    Private Sub btn_gender_Click(sender As Object, e As EventArgs) Handles btn_gender.Click
        If male_rb.Checked Then
            MessageBox.Show("Male")
        ElseIf female_rb.Checked Then
            MessageBox.Show("Female")
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        PictureBox1.Visible = False ' 


        Dim openFileDialog As OpenFileDialog = New OpenFileDialog()


        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Try
                PictureBox1.Image = New Bitmap(openFileDialog.FileName)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox1.Visible = True
            Catch ex As Exception

                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles upload_pic.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem.ToString = "Tamil Nadu" Then

            ComboBox2.Items.Add("Chennai")
            ComboBox2.Items.Add("Trichy")
            ComboBox2.Items.Add("Pondi")
            ComboBox2.Items.Add("Madurai")
            ComboBox2.Items.Add("Kanchipuram")

        ElseIf ComboBox1.SelectedItem.ToString = "Kerala" Then
            ComboBox2.Items.Add("Kolam")
            ComboBox2.Items.Add("Cochin")
            ComboBox2.Items.Add("Thiruvandhapuram")
        End If

    End Sub



    Private Sub buy_btn_Click(sender As Object, e As EventArgs) Handles buy_btn.Click
        Dim Items = String.Empty

        If CheckBox1.Checked Then
            Items += vbCrLf & "Pencil"
        End If

        If CheckBox2.Checked Then
            Items += vbCrLf & "Sharpener"
        End If

        If CheckBox3.Checked Then
            Items += vbCrLf & "Pen"
        End If

        MessageBox.Show("You have bought:" & Items)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        lable10.Text = "DateTimePicker Date: " + DateTimePicker1.Value.ToString("MM/dd/yyyy")

    End Sub


    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        label11.Text = "Month Calendar Date: " + MonthCalendar1.SelectionStart.ToLongDateString()


    End Sub

    Private Sub calculate_btn_Click(sender As Object, e As EventArgs) Handles calculate_btn.Click
        Dim price As Decimal = NumericUpDown1.Value
        Dim quantity As Integer = NumericUpDown2.Value
        Dim total As Decimal = price * quantity

        MessageBox.Show(String.Format("The total price is {0:C}", total))
    End Sub

    Private Function Int() As System.Windows.Forms.Label
        Throw New NotImplementedException()
    End Function

    Private Sub name_btn_Click(sender As Object, e As EventArgs) Handles name_btn.Click
        MessageBox.Show(TextBox1.Text)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub Followlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Followlink.LinkClicked
        Dim url As String = "https://google.com"

        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Environment.Exit(0)
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles feedback.Click

    End Sub


    Private Sub ToggleBold()
        ' Toggle the Bold property of textBox1
        RichTextBox1.Font = New Font(RichTextBox1.Font.FontFamily,
                            RichTextBox1.Font.Size,
                            If(RichTextBox1.Font.Bold, FontStyle.Regular, FontStyle.Bold))
    End Sub

    Private Sub ToggleItalic()
        RichTextBox1.Font = New Font(RichTextBox1.Font.FontFamily,
                                   RichTextBox1.Font.Size,
                                   If(RichTextBox1.Font.Italic, FontStyle.Regular, FontStyle.Italic))
    End Sub

    Private Sub ToggleUnderline()
        RichTextBox1.Font = New Font(RichTextBox1.Font.FontFamily,
                                   RichTextBox1.Font.Size,
                                   If(RichTextBox1.Font.Underline, FontStyle.Regular, FontStyle.Underline))
    End Sub





    Private Sub bold_btn_Click(sender As Object, e As EventArgs) Handles bold_btn.Click
        ToggleBold()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToggleItalic()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ToggleUnderline()
    End Sub

    Private Sub female_rb_CheckedChanged(sender As Object, e As EventArgs) Handles female_rb.CheckedChanged

    End Sub
End Class
