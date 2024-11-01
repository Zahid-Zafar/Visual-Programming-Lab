<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        header = New Label()
        Panel1 = New Panel()
        cancel = New Label()
        TextBox1 = New TextBox()
        textbox_label = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        male_rb = New RadioButton()
        female_rb = New RadioButton()
        gender_label = New Label()
        ComboBox1 = New ComboBox()
        City_label = New Label()
        btn_gender = New Button()
        PictureBox1 = New PictureBox()
        upload_pic = New Label()
        date_lbl = New Label()
        DateTimePicker1 = New DateTimePicker()
        MonthCalendar1 = New MonthCalendar()
        month_lbl = New Label()
        ComboBox2 = New ComboBox()
        CheckBox3 = New CheckBox()
        buy_btn = New Button()
        lable10 = New Label()
        label11 = New Label()
        NumericUpDown1 = New NumericUpDown()
        price = New Label()
        quantity = New Label()
        NumericUpDown2 = New NumericUpDown()
        calculate_btn = New Button()
        name_btn = New Button()
        Followlink = New LinkLabel()
        Label1 = New Label()
        RichTextBox1 = New RichTextBox()
        feedback = New Label()
        bold_btn = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' header
        ' 
        header.AutoSize = True
        header.Font = New Font("Sitka Small", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        header.ForeColor = Color.White
        header.Location = New Point(523, 11)
        header.Name = "header"
        header.Size = New Size(363, 42)
        header.TabIndex = 0
        header.Text = "Windows Form Controls"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Firebrick
        Panel1.Controls.Add(cancel)
        Panel1.Controls.Add(header)
        Panel1.Location = New Point(3, 9)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1380, 65)
        Panel1.TabIndex = 1
        ' 
        ' cancel
        ' 
        cancel.AutoSize = True
        cancel.BackColor = Color.Snow
        cancel.BorderStyle = BorderStyle.FixedSingle
        cancel.Location = New Point(1329, 24)
        cancel.Name = "cancel"
        cancel.Size = New Size(25, 27)
        cancel.TabIndex = 1
        cancel.Text = "X"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(226, 119)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(250, 31)
        TextBox1.TabIndex = 2
        ' 
        ' textbox_label
        ' 
        textbox_label.AutoSize = True
        textbox_label.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        textbox_label.Location = New Point(75, 119)
        textbox_label.Name = "textbox_label"
        textbox_label.Size = New Size(129, 28)
        textbox_label.TabIndex = 3
        textbox_label.Text = "Enter Name:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(228, 201)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(82, 29)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "Pencil"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(226, 248)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(109, 29)
        CheckBox2.TabIndex = 5
        CheckBox2.Text = "Sharpner"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' male_rb
        ' 
        male_rb.AutoSize = True
        male_rb.Location = New Point(245, 383)
        male_rb.Name = "male_rb"
        male_rb.Size = New Size(75, 29)
        male_rb.TabIndex = 6
        male_rb.TabStop = True
        male_rb.Text = "Male"
        male_rb.UseVisualStyleBackColor = True
        ' 
        ' female_rb
        ' 
        female_rb.AutoSize = True
        female_rb.Location = New Point(245, 431)
        female_rb.Name = "female_rb"
        female_rb.Size = New Size(93, 29)
        female_rb.TabIndex = 7
        female_rb.TabStop = True
        female_rb.Text = "Female"
        female_rb.UseVisualStyleBackColor = True
        ' 
        ' gender_label
        ' 
        gender_label.AutoSize = True
        gender_label.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gender_label.Location = New Point(75, 345)
        gender_label.Name = "gender_label"
        gender_label.Size = New Size(86, 28)
        gender_label.TabIndex = 8
        gender_label.Text = "Gender:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(210, 514)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 9
        ' 
        ' City_label
        ' 
        City_label.AutoSize = True
        City_label.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        City_label.Location = New Point(75, 490)
        City_label.Name = "City_label"
        City_label.Size = New Size(54, 28)
        City_label.TabIndex = 10
        City_label.Text = "City:"
        ' 
        ' btn_gender
        ' 
        btn_gender.Location = New Point(426, 404)
        btn_gender.Name = "btn_gender"
        btn_gender.Size = New Size(103, 37)
        btn_gender.TabIndex = 13
        btn_gender.Text = "Verify"
        btn_gender.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(1147, 107)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(232, 211)
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' upload_pic
        ' 
        upload_pic.AutoSize = True
        upload_pic.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        upload_pic.Location = New Point(1183, 354)
        upload_pic.Name = "upload_pic"
        upload_pic.Size = New Size(174, 28)
        upload_pic.TabIndex = 15
        upload_pic.Text = "Click And Upload"
        ' 
        ' date_lbl
        ' 
        date_lbl.AutoSize = True
        date_lbl.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        date_lbl.Location = New Point(639, 107)
        date_lbl.Name = "date_lbl"
        date_lbl.Size = New Size(156, 28)
        date_lbl.TabIndex = 16
        date_lbl.Text = "Date and Time:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(786, 166)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(323, 31)
        DateTimePicker1.TabIndex = 17
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(816, 335)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 18
        ' 
        ' month_lbl
        ' 
        month_lbl.AutoSize = True
        month_lbl.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        month_lbl.Location = New Point(665, 301)
        month_lbl.Name = "month_lbl"
        month_lbl.Size = New Size(143, 28)
        month_lbl.TabIndex = 19
        month_lbl.Text = "Select Month:"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(210, 566)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(182, 33)
        ComboBox2.TabIndex = 20
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(226, 301)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(66, 29)
        CheckBox3.TabIndex = 22
        CheckBox3.Text = "Pen"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' buy_btn
        ' 
        buy_btn.Location = New Point(395, 246)
        buy_btn.Name = "buy_btn"
        buy_btn.Size = New Size(102, 42)
        buy_btn.TabIndex = 23
        buy_btn.Text = "Buy"
        buy_btn.UseVisualStyleBackColor = True
        ' 
        ' lable10
        ' 
        lable10.AutoSize = True
        lable10.Location = New Point(810, 283)
        lable10.Name = "lable10"
        lable10.Size = New Size(0, 25)
        lable10.TabIndex = 24
        ' 
        ' label11
        ' 
        label11.AutoSize = True
        label11.Location = New Point(816, 609)
        label11.Name = "label11"
        label11.Size = New Size(0, 25)
        label11.TabIndex = 25
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(208, 671)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(267, 31)
        NumericUpDown1.TabIndex = 26
        ' 
        ' price
        ' 
        price.AutoSize = True
        price.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        price.Location = New Point(74, 670)
        price.Name = "price"
        price.Size = New Size(64, 28)
        price.TabIndex = 27
        price.Text = "Price:"
        ' 
        ' quantity
        ' 
        quantity.AutoSize = True
        quantity.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        quantity.Location = New Point(75, 744)
        quantity.Name = "quantity"
        quantity.Size = New Size(100, 28)
        quantity.TabIndex = 29
        quantity.Text = "Quantity:"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(209, 745)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(267, 31)
        NumericUpDown2.TabIndex = 28
        ' 
        ' calculate_btn
        ' 
        calculate_btn.Location = New Point(273, 815)
        calculate_btn.Name = "calculate_btn"
        calculate_btn.Size = New Size(103, 37)
        calculate_btn.TabIndex = 30
        calculate_btn.Text = "Calculate"
        calculate_btn.UseVisualStyleBackColor = True
        ' 
        ' name_btn
        ' 
        name_btn.Location = New Point(498, 119)
        name_btn.Name = "name_btn"
        name_btn.Size = New Size(76, 36)
        name_btn.TabIndex = 31
        name_btn.Text = "Ok"
        name_btn.UseVisualStyleBackColor = True
        ' 
        ' Followlink
        ' 
        Followlink.AutoSize = True
        Followlink.Location = New Point(507, 960)
        Followlink.Name = "Followlink"
        Followlink.Size = New Size(341, 25)
        Followlink.TabIndex = 32
        Followlink.TabStop = True
        Followlink.Text = " Click for more updates www.google.com"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(442, 926)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 28)
        Label1.TabIndex = 33
        Label1.Text = "Link:"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(845, 670)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(344, 139)
        RichTextBox1.TabIndex = 34
        RichTextBox1.Text = ""
        ' 
        ' feedback
        ' 
        feedback.AutoSize = True
        feedback.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        feedback.Location = New Point(711, 645)
        feedback.Name = "feedback"
        feedback.Size = New Size(106, 28)
        feedback.TabIndex = 35
        feedback.Text = "Feedback:"
        ' 
        ' bold_btn
        ' 
        bold_btn.Location = New Point(714, 686)
        bold_btn.Name = "bold_btn"
        bold_btn.Size = New Size(103, 37)
        bold_btn.TabIndex = 36
        bold_btn.Text = "Bold"
        bold_btn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(714, 729)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 37)
        Button1.TabIndex = 37
        Button1.Text = "Italic"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(714, 772)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 37)
        Button2.TabIndex = 38
        Button2.Text = "Underline"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1417, 1050)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(bold_btn)
        Controls.Add(feedback)
        Controls.Add(RichTextBox1)
        Controls.Add(Label1)
        Controls.Add(Followlink)
        Controls.Add(name_btn)
        Controls.Add(calculate_btn)
        Controls.Add(quantity)
        Controls.Add(NumericUpDown2)
        Controls.Add(price)
        Controls.Add(NumericUpDown1)
        Controls.Add(label11)
        Controls.Add(lable10)
        Controls.Add(buy_btn)
        Controls.Add(CheckBox3)
        Controls.Add(ComboBox2)
        Controls.Add(month_lbl)
        Controls.Add(MonthCalendar1)
        Controls.Add(DateTimePicker1)
        Controls.Add(date_lbl)
        Controls.Add(upload_pic)
        Controls.Add(PictureBox1)
        Controls.Add(btn_gender)
        Controls.Add(City_label)
        Controls.Add(ComboBox1)
        Controls.Add(gender_label)
        Controls.Add(female_rb)
        Controls.Add(male_rb)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(textbox_label)
        Controls.Add(TextBox1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents header As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents textbox_label As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents male_rb As RadioButton
    Friend WithEvents female_rb As RadioButton
    Friend WithEvents gender_label As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents City_label As Label
    Friend WithEvents btn_gender As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents upload_pic As Label
    Friend WithEvents date_lbl As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents month_lbl As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents buy_btn As Button
    Friend WithEvents lable10 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents price As Label
    Friend WithEvents quantity As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents calculate_btn As Button
    Friend WithEvents name_btn As Button
    Friend WithEvents Followlink As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents cancel As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents feedback As Label
    Friend WithEvents bold_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
