<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateRental
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateRental))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        exitButton = New Button()
        UpdateRentalLabel = New Label()
        Panel2 = New Panel()
        ReturnDateTimePicker = New DateTimePicker()
        RentalDateTimePicker = New DateTimePicker()
        CustomerNameTextBox = New TextBox()
        ClearButton = New Button()
        ReturnDateLabel = New Label()
        CustomerNameLabel = New Label()
        VehicleComboBox = New ComboBox()
        UpdateRentalButton = New Button()
        CancelRentalButton = New Button()
        RentalDateLabel = New Label()
        VehicleLabel = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(exitButton)
        Panel1.Controls.Add(UpdateRentalLabel)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(398, 33)
        Panel1.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' exitButton
        ' 
        exitButton.Dock = DockStyle.Right
        exitButton.FlatAppearance.BorderSize = 0
        exitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        exitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        exitButton.FlatStyle = FlatStyle.Flat
        exitButton.Font = New Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        exitButton.ForeColor = Color.Black
        exitButton.Location = New Point(373, 0)
        exitButton.Margin = New Padding(3, 2, 3, 2)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(25, 33)
        exitButton.TabIndex = 5
        exitButton.Text = "X"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' UpdateRentalLabel
        ' 
        UpdateRentalLabel.AutoSize = True
        UpdateRentalLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateRentalLabel.Location = New Point(46, 3)
        UpdateRentalLabel.Name = "UpdateRentalLabel"
        UpdateRentalLabel.Size = New Size(100, 29)
        UpdateRentalLabel.TabIndex = 0
        UpdateRentalLabel.Text = "Update Rental"
        UpdateRentalLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(ReturnDateTimePicker)
        Panel2.Controls.Add(RentalDateTimePicker)
        Panel2.Controls.Add(CustomerNameTextBox)
        Panel2.Controls.Add(ClearButton)
        Panel2.Controls.Add(ReturnDateLabel)
        Panel2.Controls.Add(CustomerNameLabel)
        Panel2.Controls.Add(VehicleComboBox)
        Panel2.Controls.Add(UpdateRentalButton)
        Panel2.Controls.Add(CancelRentalButton)
        Panel2.Controls.Add(RentalDateLabel)
        Panel2.Controls.Add(VehicleLabel)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 33)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(398, 390)
        Panel2.TabIndex = 9
        ' 
        ' ReturnDateTimePicker
        ' 
        ReturnDateTimePicker.Location = New Point(23, 277)
        ReturnDateTimePicker.Name = "ReturnDateTimePicker"
        ReturnDateTimePicker.Size = New Size(350, 23)
        ReturnDateTimePicker.TabIndex = 21
        ' 
        ' RentalDateTimePicker
        ' 
        RentalDateTimePicker.Location = New Point(23, 189)
        RentalDateTimePicker.Name = "RentalDateTimePicker"
        RentalDateTimePicker.Size = New Size(350, 23)
        RentalDateTimePicker.TabIndex = 20
        ' 
        ' CustomerNameTextBox
        ' 
        CustomerNameTextBox.Location = New Point(23, 43)
        CustomerNameTextBox.Name = "CustomerNameTextBox"
        CustomerNameTextBox.Size = New Size(350, 23)
        CustomerNameTextBox.TabIndex = 19
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Gray
        ClearButton.FlatAppearance.BorderSize = 0
        ClearButton.FlatAppearance.MouseOverBackColor = Color.Silver
        ClearButton.FlatStyle = FlatStyle.Flat
        ClearButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        ClearButton.ForeColor = Color.Blue
        ClearButton.Location = New Point(23, 333)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(86, 26)
        ClearButton.TabIndex = 18
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' ReturnDateLabel
        ' 
        ReturnDateLabel.AutoSize = True
        ReturnDateLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold)
        ReturnDateLabel.Location = New Point(23, 248)
        ReturnDateLabel.Margin = New Padding(1, 0, 1, 0)
        ReturnDateLabel.Name = "ReturnDateLabel"
        ReturnDateLabel.Size = New Size(88, 26)
        ReturnDateLabel.TabIndex = 16
        ReturnDateLabel.Text = "Date of Return"
        ' 
        ' CustomerNameLabel
        ' 
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold)
        CustomerNameLabel.Location = New Point(23, 14)
        CustomerNameLabel.Margin = New Padding(1, 0, 1, 0)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New Size(94, 26)
        CustomerNameLabel.TabIndex = 14
        CustomerNameLabel.Text = "Customer Name"
        ' 
        ' VehicleComboBox
        ' 
        VehicleComboBox.FormattingEnabled = True
        VehicleComboBox.Location = New Point(23, 115)
        VehicleComboBox.Margin = New Padding(1)
        VehicleComboBox.Name = "VehicleComboBox"
        VehicleComboBox.Size = New Size(350, 23)
        VehicleComboBox.TabIndex = 11
        ' 
        ' UpdateRentalButton
        ' 
        UpdateRentalButton.BackColor = Color.Gray
        UpdateRentalButton.FlatAppearance.BorderSize = 0
        UpdateRentalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        UpdateRentalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        UpdateRentalButton.FlatStyle = FlatStyle.Flat
        UpdateRentalButton.Font = New Font("Gabriola", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UpdateRentalButton.ForeColor = Color.Black
        UpdateRentalButton.Location = New Point(287, 333)
        UpdateRentalButton.Margin = New Padding(3, 2, 3, 2)
        UpdateRentalButton.Name = "UpdateRentalButton"
        UpdateRentalButton.Size = New Size(86, 26)
        UpdateRentalButton.TabIndex = 10
        UpdateRentalButton.Text = "Update"
        UpdateRentalButton.UseVisualStyleBackColor = False
        ' 
        ' CancelRentalButton
        ' 
        CancelRentalButton.BackColor = Color.Gray
        CancelRentalButton.FlatAppearance.BorderSize = 0
        CancelRentalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CancelRentalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        CancelRentalButton.FlatStyle = FlatStyle.Flat
        CancelRentalButton.Font = New Font("Gabriola", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CancelRentalButton.ForeColor = Color.Red
        CancelRentalButton.Location = New Point(154, 333)
        CancelRentalButton.Margin = New Padding(3, 2, 3, 2)
        CancelRentalButton.Name = "CancelRentalButton"
        CancelRentalButton.Size = New Size(86, 26)
        CancelRentalButton.TabIndex = 9
        CancelRentalButton.Text = "Cancel"
        CancelRentalButton.UseVisualStyleBackColor = False
        ' 
        ' RentalDateLabel
        ' 
        RentalDateLabel.AutoSize = True
        RentalDateLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RentalDateLabel.Location = New Point(23, 160)
        RentalDateLabel.Name = "RentalDateLabel"
        RentalDateLabel.Size = New Size(86, 26)
        RentalDateLabel.TabIndex = 3
        RentalDateLabel.Text = "Date of Rental"
        ' 
        ' VehicleLabel
        ' 
        VehicleLabel.AutoSize = True
        VehicleLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VehicleLabel.Location = New Point(23, 88)
        VehicleLabel.Name = "VehicleLabel"
        VehicleLabel.Size = New Size(48, 26)
        VehicleLabel.TabIndex = 1
        VehicleLabel.Text = "Vehicle"
        ' 
        ' UpdateRental
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(398, 423)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "UpdateRental"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents exitButton As Button
    Friend WithEvents UpdateRentalLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ClearButton As Button
    Friend WithEvents ReturnDateLabel As Label
    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents VehicleComboBox As ComboBox
    Friend WithEvents UpdateRentalButton As Button
    Friend WithEvents CancelRentalButton As Button
    Friend WithEvents RentalDateLabel As Label
    Friend WithEvents VehicleLabel As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents ReturnDateTimePicker As DateTimePicker
    Friend WithEvents RentalDateTimePicker As DateTimePicker
End Class
