<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRentalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRentalForm))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        ExitAddRentalButton = New Button()
        AddRentalLabel = New Label()
        Panel2 = New Panel()
        ReturnDateLabel = New Label()
        ReturnDateTimePicker = New DateTimePicker()
        ClearRentalButton = New Button()
        AddRentalButton = New Button()
        CancelRentalButton = New Button()
        RentingDateTimePicker = New DateTimePicker()
        Label5 = New Label()
        VehicleLabel = New Label()
        VehicleTextBox = New TextBox()
        CustomerNameLabel = New Label()
        CustomerNameTextBox = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(ExitAddRentalButton)
        Panel1.Controls.Add(AddRentalLabel)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(965, 90)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(91, 90)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' ExitAddRentalButton
        ' 
        ExitAddRentalButton.Dock = DockStyle.Right
        ExitAddRentalButton.FlatAppearance.BorderSize = 0
        ExitAddRentalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ExitAddRentalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ExitAddRentalButton.FlatStyle = FlatStyle.Flat
        ExitAddRentalButton.Font = New Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ExitAddRentalButton.ForeColor = Color.Black
        ExitAddRentalButton.Location = New Point(903, 0)
        ExitAddRentalButton.Margin = New Padding(6)
        ExitAddRentalButton.Name = "ExitAddRentalButton"
        ExitAddRentalButton.Size = New Size(62, 90)
        ExitAddRentalButton.TabIndex = 5
        ExitAddRentalButton.Text = "X"
        ExitAddRentalButton.UseVisualStyleBackColor = True
        ' 
        ' AddRentalLabel
        ' 
        AddRentalLabel.AutoSize = True
        AddRentalLabel.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddRentalLabel.Location = New Point(100, 8)
        AddRentalLabel.Margin = New Padding(6, 0, 6, 0)
        AddRentalLabel.Name = "AddRentalLabel"
        AddRentalLabel.Size = New Size(183, 74)
        AddRentalLabel.TabIndex = 0
        AddRentalLabel.Text = "Add Rental"
        AddRentalLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(ReturnDateLabel)
        Panel2.Controls.Add(ReturnDateTimePicker)
        Panel2.Controls.Add(ClearRentalButton)
        Panel2.Controls.Add(AddRentalButton)
        Panel2.Controls.Add(CancelRentalButton)
        Panel2.Controls.Add(RentingDateTimePicker)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(VehicleLabel)
        Panel2.Controls.Add(VehicleTextBox)
        Panel2.Controls.Add(CustomerNameLabel)
        Panel2.Controls.Add(CustomerNameTextBox)
        Panel2.Location = New Point(23, 131)
        Panel2.Margin = New Padding(6)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(914, 1076)
        Panel2.TabIndex = 3
        ' 
        ' ReturnDateLabel
        ' 
        ReturnDateLabel.AutoSize = True
        ReturnDateLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReturnDateLabel.Location = New Point(28, 823)
        ReturnDateLabel.Margin = New Padding(6, 0, 6, 0)
        ReturnDateLabel.Name = "ReturnDateLabel"
        ReturnDateLabel.Size = New Size(164, 63)
        ReturnDateLabel.TabIndex = 13
        ReturnDateLabel.Text = "Return Date"
        ' 
        ' ReturnDateTimePicker
        ' 
        ReturnDateTimePicker.Location = New Point(202, 839)
        ReturnDateTimePicker.Name = "ReturnDateTimePicker"
        ReturnDateTimePicker.Size = New Size(527, 47)
        ReturnDateTimePicker.TabIndex = 12
        ' 
        ' ClearRentalButton
        ' 
        ClearRentalButton.BackColor = Color.Gray
        ClearRentalButton.FlatAppearance.BorderSize = 0
        ClearRentalButton.FlatAppearance.MouseOverBackColor = Color.Silver
        ClearRentalButton.FlatStyle = FlatStyle.Flat
        ClearRentalButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        ClearRentalButton.ForeColor = Color.Blue
        ClearRentalButton.Location = New Point(38, 910)
        ClearRentalButton.Margin = New Padding(6, 8, 6, 8)
        ClearRentalButton.Name = "ClearRentalButton"
        ClearRentalButton.Size = New Size(208, 72)
        ClearRentalButton.TabIndex = 11
        ClearRentalButton.Text = "Clear"
        ClearRentalButton.UseVisualStyleBackColor = False
        ' 
        ' AddRentalButton
        ' 
        AddRentalButton.BackColor = Color.Gray
        AddRentalButton.FlatAppearance.BorderSize = 0
        AddRentalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AddRentalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        AddRentalButton.FlatStyle = FlatStyle.Flat
        AddRentalButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        AddRentalButton.ForeColor = Color.Black
        AddRentalButton.Location = New Point(669, 910)
        AddRentalButton.Margin = New Padding(6)
        AddRentalButton.Name = "AddRentalButton"
        AddRentalButton.Size = New Size(208, 72)
        AddRentalButton.TabIndex = 10
        AddRentalButton.Text = "Add"
        AddRentalButton.UseVisualStyleBackColor = False
        ' 
        ' CancelRentalButton
        ' 
        CancelRentalButton.BackColor = Color.Gray
        CancelRentalButton.FlatAppearance.BorderSize = 0
        CancelRentalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CancelRentalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        CancelRentalButton.FlatStyle = FlatStyle.Flat
        CancelRentalButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        CancelRentalButton.ForeColor = Color.Red
        CancelRentalButton.Location = New Point(351, 910)
        CancelRentalButton.Margin = New Padding(6)
        CancelRentalButton.Name = "CancelRentalButton"
        CancelRentalButton.Size = New Size(208, 72)
        CancelRentalButton.TabIndex = 9
        CancelRentalButton.Text = "Cancel"
        CancelRentalButton.UseVisualStyleBackColor = False
        ' 
        ' RentingDateTimePicker
        ' 
        RentingDateTimePicker.Location = New Point(202, 756)
        RentingDateTimePicker.Margin = New Padding(6)
        RentingDateTimePicker.Name = "RentingDateTimePicker"
        RentingDateTimePicker.Size = New Size(527, 47)
        RentingDateTimePicker.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(28, 740)
        Label5.Margin = New Padding(6, 0, 6, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 63)
        Label5.TabIndex = 7
        Label5.Text = "Renting Date"
        ' 
        ' VehicleLabel
        ' 
        VehicleLabel.AutoSize = True
        VehicleLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VehicleLabel.Location = New Point(19, 494)
        VehicleLabel.Margin = New Padding(6, 0, 6, 0)
        VehicleLabel.Name = "VehicleLabel"
        VehicleLabel.Size = New Size(106, 63)
        VehicleLabel.TabIndex = 3
        VehicleLabel.Text = "Vehicle"
        ' 
        ' VehicleTextBox
        ' 
        VehicleTextBox.Location = New Point(34, 564)
        VehicleTextBox.Margin = New Padding(6)
        VehicleTextBox.Name = "VehicleTextBox"
        VehicleTextBox.Size = New Size(843, 47)
        VehicleTextBox.TabIndex = 2
        ' 
        ' CustomerNameLabel
        ' 
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CustomerNameLabel.Location = New Point(28, 217)
        CustomerNameLabel.Margin = New Padding(6, 0, 6, 0)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New Size(208, 63)
        CustomerNameLabel.TabIndex = 1
        CustomerNameLabel.Text = "Customer Name"
        ' 
        ' CustomerNameTextBox
        ' 
        CustomerNameTextBox.Location = New Point(38, 287)
        CustomerNameTextBox.Margin = New Padding(6)
        CustomerNameTextBox.Name = "CustomerNameTextBox"
        CustomerNameTextBox.Size = New Size(843, 47)
        CustomerNameTextBox.TabIndex = 0
        ' 
        ' AddRentalForm
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(965, 1222)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddRentalForm"
        Text = "AddRentalForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ExitAddRentalButton As Button
    Friend WithEvents AddRentalLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ClearRentalButton As Button
    Friend WithEvents AddRentalButton As Button
    Friend WithEvents CancelRentalButton As Button
    Friend WithEvents RentingDateTimePicker As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents VehicleLabel As Label
    Friend WithEvents VehicleTextBox As TextBox
    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents ReturnDateLabel As Label
    Friend WithEvents ReturnDateTimePicker As DateTimePicker
End Class
