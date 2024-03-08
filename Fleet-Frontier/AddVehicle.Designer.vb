<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVehicle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddVehicle))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        exitButton = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        ClearButton = New Button()
        AddButton = New Button()
        CancelButton = New Button()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Label4 = New Label()
        AvailabilityTextBox = New TextBox()
        Label3 = New Label()
        FuelTextBox = New TextBox()
        Label2 = New Label()
        NumberPlateTextBox = New TextBox()
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
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(398, 33)
        Panel1.TabIndex = 0
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gabriola", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(41, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 29)
        Label1.TabIndex = 0
        Label1.Text = "Add Vehicle"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Silver
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(ClearButton)
        Panel2.Controls.Add(AddButton)
        Panel2.Controls.Add(CancelButton)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(AvailabilityTextBox)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(FuelTextBox)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(NumberPlateTextBox)
        Panel2.Location = New Point(10, 44)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(377, 395)
        Panel2.TabIndex = 1
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Gray
        ClearButton.FlatAppearance.BorderSize = 0
        ClearButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClearButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        ClearButton.FlatStyle = FlatStyle.Flat
        ClearButton.Font = New Font("Gabriola", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ClearButton.ForeColor = Color.Blue
        ClearButton.Location = New Point(13, 333)
        ClearButton.Margin = New Padding(3, 2, 3, 2)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(86, 26)
        ClearButton.TabIndex = 19
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' AddButton
        ' 
        AddButton.BackColor = Color.Gray
        AddButton.FlatAppearance.BorderSize = 0
        AddButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AddButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        AddButton.FlatStyle = FlatStyle.Flat
        AddButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        AddButton.ForeColor = Color.Black
        AddButton.Location = New Point(277, 333)
        AddButton.Margin = New Padding(3, 2, 3, 2)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(86, 26)
        AddButton.TabIndex = 10
        AddButton.Text = "Add"
        AddButton.UseVisualStyleBackColor = False
        ' 
        ' CancelButton
        ' 
        CancelButton.BackColor = Color.Gray
        CancelButton.FlatAppearance.BorderSize = 0
        CancelButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        CancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        CancelButton.FlatStyle = FlatStyle.Flat
        CancelButton.Font = New Font("Gabriola", 9F, FontStyle.Bold)
        CancelButton.ForeColor = Color.Red
        CancelButton.Location = New Point(144, 333)
        CancelButton.Margin = New Padding(3, 2, 3, 2)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(86, 26)
        CancelButton.TabIndex = 9
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(83, 277)
        DateTimePicker1.Margin = New Padding(3, 2, 3, 2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(219, 23)
        DateTimePicker1.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(41, 278)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 26)
        Label5.TabIndex = 7
        Label5.Text = "Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(13, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 26)
        Label4.TabIndex = 5
        Label4.Text = "Availability"
        ' 
        ' AvailabilityTextBox
        ' 
        AvailabilityTextBox.Location = New Point(13, 237)
        AvailabilityTextBox.Margin = New Padding(3, 2, 3, 2)
        AvailabilityTextBox.Name = "AvailabilityTextBox"
        AvailabilityTextBox.Size = New Size(350, 23)
        AvailabilityTextBox.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 26)
        Label3.TabIndex = 3
        Label3.Text = "Fuel consumption/km"
        ' 
        ' FuelTextBox
        ' 
        FuelTextBox.Location = New Point(13, 170)
        FuelTextBox.Margin = New Padding(3, 2, 3, 2)
        FuelTextBox.Name = "FuelTextBox"
        FuelTextBox.Size = New Size(350, 23)
        FuelTextBox.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gabriola", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 26)
        Label2.TabIndex = 1
        Label2.Text = "Number Plate"
        ' 
        ' NumberPlateTextBox
        ' 
        NumberPlateTextBox.Location = New Point(13, 104)
        NumberPlateTextBox.Margin = New Padding(3, 2, 3, 2)
        NumberPlateTextBox.Name = "NumberPlateTextBox"
        NumberPlateTextBox.Size = New Size(350, 23)
        NumberPlateTextBox.TabIndex = 0
        ' 
        ' AddVehicle
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(398, 448)
        ControlBox = False
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 2, 3, 2)
        Name = "AddVehicle"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents exitButton As Button
    Friend WithEvents NumberPlateTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AvailabilityTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FuelTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents AddButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ClearButton As Button
End Class
