<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStaffForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStaffForm))
        ControlBoxPanel = New Panel()
        ControlBoxIcon = New PictureBox()
        CloseButton = New Button()
        AddStaffLabel = New Label()
        BodyPanel = New Panel()
        ClearButton = New Button()
        TypeComboBox = New ComboBox()
        StaffDateTimePicker = New DateTimePicker()
        DateLabel = New Label()
        CancelButton = New Button()
        AddStaffConfirmButton = New Button()
        AvailabilityTextBox = New TextBox()
        PhoneNumberTextBox = New TextBox()
        NameTextBox = New TextBox()
        AvailabilityLabel = New Label()
        TypeLabel = New Label()
        PhoneNumberLabel = New Label()
        NameLabel = New Label()
        ControlBoxPanel.SuspendLayout()
        CType(ControlBoxIcon, ComponentModel.ISupportInitialize).BeginInit()
        BodyPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' ControlBoxPanel
        ' 
        ControlBoxPanel.BackColor = Color.Gray
        ControlBoxPanel.BorderStyle = BorderStyle.FixedSingle
        ControlBoxPanel.Controls.Add(ControlBoxIcon)
        ControlBoxPanel.Controls.Add(CloseButton)
        ControlBoxPanel.Controls.Add(AddStaffLabel)
        ControlBoxPanel.Dock = DockStyle.Top
        ControlBoxPanel.Location = New Point(0, 0)
        ControlBoxPanel.Name = "ControlBoxPanel"
        ControlBoxPanel.Size = New Size(452, 42)
        ControlBoxPanel.TabIndex = 10
        ' 
        ' ControlBoxIcon
        ' 
        ControlBoxIcon.Dock = DockStyle.Left
        ControlBoxIcon.Image = CType(resources.GetObject("ControlBoxIcon.Image"), Image)
        ControlBoxIcon.Location = New Point(0, 0)
        ControlBoxIcon.Margin = New Padding(3, 2, 3, 2)
        ControlBoxIcon.Name = "ControlBoxIcon"
        ControlBoxIcon.Size = New Size(46, 40)
        ControlBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage
        ControlBoxIcon.TabIndex = 2
        ControlBoxIcon.TabStop = False
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.Gray
        CloseButton.Dock = DockStyle.Right
        CloseButton.FlatAppearance.BorderSize = 0
        CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        CloseButton.FlatStyle = FlatStyle.Flat
        CloseButton.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CloseButton.Location = New Point(415, 0)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(35, 40)
        CloseButton.TabIndex = 1
        CloseButton.Text = "X"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' AddStaffLabel
        ' 
        AddStaffLabel.AutoSize = True
        AddStaffLabel.BackColor = Color.Gray
        AddStaffLabel.Font = New Font("Gabriola", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddStaffLabel.Location = New Point(40, -1)
        AddStaffLabel.Name = "AddStaffLabel"
        AddStaffLabel.Padding = New Padding(10)
        AddStaffLabel.Size = New Size(83, 48)
        AddStaffLabel.TabIndex = 0
        AddStaffLabel.Text = "Add Staff"
        ' 
        ' BodyPanel
        ' 
        BodyPanel.BackColor = Color.Silver
        BodyPanel.BorderStyle = BorderStyle.FixedSingle
        BodyPanel.Controls.Add(ClearButton)
        BodyPanel.Controls.Add(TypeComboBox)
        BodyPanel.Controls.Add(StaffDateTimePicker)
        BodyPanel.Controls.Add(DateLabel)
        BodyPanel.Controls.Add(CancelButton)
        BodyPanel.Controls.Add(AddStaffConfirmButton)
        BodyPanel.Controls.Add(AvailabilityTextBox)
        BodyPanel.Controls.Add(PhoneNumberTextBox)
        BodyPanel.Controls.Add(NameTextBox)
        BodyPanel.Controls.Add(AvailabilityLabel)
        BodyPanel.Controls.Add(TypeLabel)
        BodyPanel.Controls.Add(PhoneNumberLabel)
        BodyPanel.Controls.Add(NameLabel)
        BodyPanel.Location = New Point(10, 50)
        BodyPanel.Name = "BodyPanel"
        BodyPanel.Padding = New Padding(10)
        BodyPanel.Size = New Size(431, 456)
        BodyPanel.TabIndex = 11
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Gray
        ClearButton.FlatAppearance.BorderSize = 0
        ClearButton.FlatAppearance.MouseOverBackColor = Color.Silver
        ClearButton.FlatStyle = FlatStyle.Flat
        ClearButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        ClearButton.ForeColor = Color.Blue
        ClearButton.Location = New Point(12, 375)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(86, 26)
        ClearButton.TabIndex = 10
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' TypeComboBox
        ' 
        TypeComboBox.FormattingEnabled = True
        TypeComboBox.Items.AddRange(New Object() {"Driver", "Conductor"})
        TypeComboBox.Location = New Point(12, 205)
        TypeComboBox.Name = "TypeComboBox"
        TypeComboBox.Size = New Size(382, 23)
        TypeComboBox.TabIndex = 9
        ' 
        ' StaffDateTimePicker
        ' 
        StaffDateTimePicker.Location = New Point(109, 329)
        StaffDateTimePicker.Name = "StaffDateTimePicker"
        StaffDateTimePicker.Size = New Size(216, 23)
        StaffDateTimePicker.TabIndex = 8
        ' 
        ' DateLabel
        ' 
        DateLabel.AutoSize = True
        DateLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateLabel.Location = New Point(60, 322)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New Size(41, 29)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date"
        ' 
        ' CancelButton
        ' 
        CancelButton.BackColor = Color.Gray
        CancelButton.FlatAppearance.BorderSize = 0
        CancelButton.FlatAppearance.MouseOverBackColor = Color.Silver
        CancelButton.FlatStyle = FlatStyle.Flat
        CancelButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        CancelButton.ForeColor = Color.Red
        CancelButton.Location = New Point(160, 375)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(86, 26)
        CancelButton.TabIndex = 5
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' AddStaffConfirmButton
        ' 
        AddStaffConfirmButton.BackColor = Color.Gray
        AddStaffConfirmButton.FlatAppearance.BorderSize = 0
        AddStaffConfirmButton.FlatAppearance.MouseOverBackColor = Color.Silver
        AddStaffConfirmButton.FlatStyle = FlatStyle.Flat
        AddStaffConfirmButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        AddStaffConfirmButton.Location = New Point(311, 375)
        AddStaffConfirmButton.Name = "AddStaffConfirmButton"
        AddStaffConfirmButton.Size = New Size(86, 26)
        AddStaffConfirmButton.TabIndex = 6
        AddStaffConfirmButton.Text = "Add"
        AddStaffConfirmButton.UseVisualStyleBackColor = False
        ' 
        ' AvailabilityTextBox
        ' 
        AvailabilityTextBox.Location = New Point(12, 286)
        AvailabilityTextBox.Name = "AvailabilityTextBox"
        AvailabilityTextBox.Size = New Size(386, 23)
        AvailabilityTextBox.TabIndex = 7
        ' 
        ' PhoneNumberTextBox
        ' 
        PhoneNumberTextBox.Location = New Point(13, 127)
        PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        PhoneNumberTextBox.Size = New Size(384, 23)
        PhoneNumberTextBox.TabIndex = 5
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(13, 53)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(384, 23)
        NameTextBox.TabIndex = 4
        ' 
        ' AvailabilityLabel
        ' 
        AvailabilityLabel.AutoSize = True
        AvailabilityLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AvailabilityLabel.Location = New Point(18, 254)
        AvailabilityLabel.Name = "AvailabilityLabel"
        AvailabilityLabel.Size = New Size(80, 29)
        AvailabilityLabel.TabIndex = 3
        AvailabilityLabel.Text = "Availability"
        ' 
        ' TypeLabel
        ' 
        TypeLabel.AutoSize = True
        TypeLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TypeLabel.Location = New Point(15, 173)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New Size(39, 29)
        TypeLabel.TabIndex = 2
        TypeLabel.Text = "Type"
        ' 
        ' PhoneNumberLabel
        ' 
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PhoneNumberLabel.Location = New Point(12, 96)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New Size(100, 29)
        PhoneNumberLabel.TabIndex = 1
        PhoneNumberLabel.Text = "Phone number"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NameLabel.Location = New Point(12, 22)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(46, 29)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Name"
        ' 
        ' AddStaffForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(452, 507)
        ControlBox = False
        Controls.Add(BodyPanel)
        Controls.Add(ControlBoxPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "AddStaffForm"
        ControlBoxPanel.ResumeLayout(False)
        ControlBoxPanel.PerformLayout()
        CType(ControlBoxIcon, ComponentModel.ISupportInitialize).EndInit()
        BodyPanel.ResumeLayout(False)
        BodyPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ControlBoxPanel As Panel
    Friend WithEvents BodyPanel As Panel
    Friend WithEvents TypeComboBox As ComboBox
    Friend WithEvents StaffDateTimePicker As DateTimePicker
    Friend WithEvents DateLabel As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents AddStaffConfirmButton As Button
    Friend WithEvents AvailabilityTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AvailabilityLabel As Label
    Friend WithEvents TypeLabel As Label
    Friend WithEvents PhoneNumberLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents AddStaffLabel As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents ControlBoxIcon As PictureBox
    Friend WithEvents ClearButton As Button
End Class
