<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVehicle
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        AddVehiclePanel = New Panel()
        AddButton = New Button()
        PlateLabel = New Label()
        FuelLabel = New Label()
        AvailabilityLabel = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Panel2 = New Panel()
        Label4 = New Label()
        AddVehiclePanel.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' AddVehiclePanel
        ' 
        AddVehiclePanel.BackColor = Color.FromArgb(CByte(255), CByte(159), CByte(67))
        AddVehiclePanel.BorderStyle = BorderStyle.FixedSingle
        AddVehiclePanel.Controls.Add(Panel2)
        AddVehiclePanel.Controls.Add(TextBox3)
        AddVehiclePanel.Controls.Add(TextBox2)
        AddVehiclePanel.Controls.Add(TextBox1)
        AddVehiclePanel.Controls.Add(AvailabilityLabel)
        AddVehiclePanel.Controls.Add(FuelLabel)
        AddVehiclePanel.Controls.Add(PlateLabel)
        AddVehiclePanel.Controls.Add(AddButton)
        AddVehiclePanel.Dock = DockStyle.Fill
        AddVehiclePanel.Location = New Point(0, 0)
        AddVehiclePanel.Name = "AddVehiclePanel"
        AddVehiclePanel.Size = New Size(576, 324)
        AddVehiclePanel.TabIndex = 0
        ' 
        ' AddButton
        ' 
        AddButton.BackColor = Color.Gray
        AddButton.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AddButton.Location = New Point(228, 257)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(100, 23)
        AddButton.TabIndex = 0
        AddButton.Text = "Add"
        AddButton.UseVisualStyleBackColor = False
        ' 
        ' PlateLabel
        ' 
        PlateLabel.AutoSize = True
        PlateLabel.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PlateLabel.Location = New Point(56, 74)
        PlateLabel.Name = "PlateLabel"
        PlateLabel.Size = New Size(106, 16)
        PlateLabel.TabIndex = 1
        PlateLabel.Text = "Number Plate"
        ' 
        ' FuelLabel
        ' 
        FuelLabel.AutoSize = True
        FuelLabel.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FuelLabel.Location = New Point(56, 139)
        FuelLabel.Name = "FuelLabel"
        FuelLabel.Size = New Size(93, 16)
        FuelLabel.TabIndex = 2
        FuelLabel.Text = "Fuel per KM"
        ' 
        ' AvailabilityLabel
        ' 
        AvailabilityLabel.AutoSize = True
        AvailabilityLabel.Font = New Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AvailabilityLabel.Location = New Point(56, 206)
        AvailabilityLabel.Name = "AvailabilityLabel"
        AvailabilityLabel.Size = New Size(92, 16)
        AvailabilityLabel.TabIndex = 3
        AvailabilityLabel.Text = "Availability"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(228, 199)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(152, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(228, 132)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(152, 23)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(228, 67)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(152, 23)
        TextBox3.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(574, 52)
        Panel2.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(123, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(296, 18)
        Label4.TabIndex = 8
        Label4.Text = "Please Input the New Vehicle's Details"
        ' 
        ' AddVehicle
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(AddVehiclePanel)
        Name = "AddVehicle"
        Size = New Size(576, 324)
        AddVehiclePanel.ResumeLayout(False)
        AddVehiclePanel.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents AddVehiclePanel As Panel
    Friend WithEvents AddButton As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents AvailabilityLabel As Label
    Friend WithEvents FuelLabel As Label
    Friend WithEvents PlateLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label

End Class
