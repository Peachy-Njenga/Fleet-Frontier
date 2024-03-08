<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        controlBarPanel = New Panel()
        minimizeButton = New Button()
        controlBarLabel = New Label()
        exitButton = New Button()
        controlBarIcon = New PictureBox()
        sideBar = New Panel()
        lowSidebarPanel = New Panel()
        VehicleButton = New Button()
        StaffButton = New Button()
        homeButton = New Button()
        tripButton = New Button()
        rentButton = New Button()
        logoPanel = New Panel()
        busLogo = New PictureBox()
        logoLabel = New Label()
        logoutButton = New Button()
        middlePanel = New Panel()
        Panel1 = New Panel()
        BodyPanel = New Panel()
        VehiclesUserControl1 = New VehiclesUserControl()
        StaffUserControl1 = New StaffUserControl()
        WelcomeLabel = New Label()
        controlBarPanel.SuspendLayout()
        CType(controlBarIcon, ComponentModel.ISupportInitialize).BeginInit()
        sideBar.SuspendLayout()
        lowSidebarPanel.SuspendLayout()
        logoPanel.SuspendLayout()
        CType(busLogo, ComponentModel.ISupportInitialize).BeginInit()
        middlePanel.SuspendLayout()
        Panel1.SuspendLayout()
        BodyPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' controlBarPanel
        ' 
        controlBarPanel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        controlBarPanel.Controls.Add(minimizeButton)
        controlBarPanel.Controls.Add(controlBarLabel)
        controlBarPanel.Controls.Add(exitButton)
        controlBarPanel.Controls.Add(controlBarIcon)
        controlBarPanel.Dock = DockStyle.Top
        controlBarPanel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        controlBarPanel.ForeColor = Color.White
        controlBarPanel.Location = New Point(0, 0)
        controlBarPanel.Margin = New Padding(2, 3, 2, 3)
        controlBarPanel.Name = "controlBarPanel"
        controlBarPanel.Size = New Size(1241, 34)
        controlBarPanel.TabIndex = 0
        ' 
        ' minimizeButton
        ' 
        minimizeButton.Dock = DockStyle.Right
        minimizeButton.FlatAppearance.BorderSize = 0
        minimizeButton.FlatStyle = FlatStyle.Flat
        minimizeButton.Font = New Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        minimizeButton.ForeColor = Color.Black
        minimizeButton.Location = New Point(1183, 0)
        minimizeButton.Name = "minimizeButton"
        minimizeButton.Size = New Size(29, 34)
        minimizeButton.TabIndex = 4
        minimizeButton.Text = "-"
        minimizeButton.UseVisualStyleBackColor = True
        ' 
        ' controlBarLabel
        ' 
        controlBarLabel.AutoSize = True
        controlBarLabel.Font = New Font("MV Boli", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        controlBarLabel.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        controlBarLabel.Location = New Point(45, 4)
        controlBarLabel.Margin = New Padding(2, 0, 2, 0)
        controlBarLabel.Name = "controlBarLabel"
        controlBarLabel.Size = New Size(119, 20)
        controlBarLabel.TabIndex = 0
        controlBarLabel.Text = "Fleet Frontier"
        ' 
        ' exitButton
        ' 
        exitButton.Dock = DockStyle.Right
        exitButton.FlatAppearance.BorderSize = 0
        exitButton.FlatStyle = FlatStyle.Flat
        exitButton.Font = New Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        exitButton.ForeColor = Color.Black
        exitButton.Location = New Point(1212, 0)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(29, 34)
        exitButton.TabIndex = 1
        exitButton.Text = "X"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' controlBarIcon
        ' 
        controlBarIcon.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        controlBarIcon.Dock = DockStyle.Left
        controlBarIcon.Image = CType(resources.GetObject("controlBarIcon.Image"), Image)
        controlBarIcon.Location = New Point(0, 0)
        controlBarIcon.Name = "controlBarIcon"
        controlBarIcon.Size = New Size(40, 34)
        controlBarIcon.SizeMode = PictureBoxSizeMode.StretchImage
        controlBarIcon.TabIndex = 3
        controlBarIcon.TabStop = False
        ' 
        ' sideBar
        ' 
        sideBar.BackColor = Color.Gray
        sideBar.Controls.Add(lowSidebarPanel)
        sideBar.Controls.Add(logoPanel)
        sideBar.Controls.Add(logoutButton)
        sideBar.Dock = DockStyle.Left
        sideBar.Location = New Point(0, 0)
        sideBar.Margin = New Padding(10)
        sideBar.Name = "sideBar"
        sideBar.Size = New Size(217, 661)
        sideBar.TabIndex = 0
        ' 
        ' lowSidebarPanel
        ' 
        lowSidebarPanel.Controls.Add(VehicleButton)
        lowSidebarPanel.Controls.Add(StaffButton)
        lowSidebarPanel.Controls.Add(homeButton)
        lowSidebarPanel.Controls.Add(tripButton)
        lowSidebarPanel.Controls.Add(rentButton)
        lowSidebarPanel.Dock = DockStyle.Fill
        lowSidebarPanel.Location = New Point(0, 190)
        lowSidebarPanel.Name = "lowSidebarPanel"
        lowSidebarPanel.Size = New Size(217, 421)
        lowSidebarPanel.TabIndex = 7
        ' 
        ' VehicleButton
        ' 
        VehicleButton.Dock = DockStyle.Top
        VehicleButton.FlatAppearance.BorderSize = 0
        VehicleButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        VehicleButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        VehicleButton.FlatStyle = FlatStyle.Flat
        VehicleButton.Font = New Font("Gabriola", 9F)
        VehicleButton.ForeColor = Color.White
        VehicleButton.Image = CType(resources.GetObject("VehicleButton.Image"), Image)
        VehicleButton.ImageAlign = ContentAlignment.MiddleLeft
        VehicleButton.Location = New Point(0, 100)
        VehicleButton.Margin = New Padding(2, 3, 2, 3)
        VehicleButton.Name = "VehicleButton"
        VehicleButton.Padding = New Padding(6, 0, 0, 0)
        VehicleButton.Size = New Size(217, 50)
        VehicleButton.TabIndex = 8
        VehicleButton.Text = "Vehicle"
        VehicleButton.TextAlign = ContentAlignment.MiddleLeft
        VehicleButton.TextImageRelation = TextImageRelation.ImageBeforeText
        VehicleButton.UseVisualStyleBackColor = True
        ' 
        ' StaffButton
        ' 
        StaffButton.Dock = DockStyle.Top
        StaffButton.FlatAppearance.BorderSize = 0
        StaffButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        StaffButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        StaffButton.FlatStyle = FlatStyle.Flat
        StaffButton.Font = New Font("Gabriola", 9F)
        StaffButton.ForeColor = Color.White
        StaffButton.Image = CType(resources.GetObject("StaffButton.Image"), Image)
        StaffButton.ImageAlign = ContentAlignment.MiddleLeft
        StaffButton.Location = New Point(0, 50)
        StaffButton.Margin = New Padding(2, 3, 2, 3)
        StaffButton.Name = "StaffButton"
        StaffButton.Padding = New Padding(6, 0, 0, 0)
        StaffButton.Size = New Size(217, 50)
        StaffButton.TabIndex = 7
        StaffButton.Text = "Staff"
        StaffButton.TextAlign = ContentAlignment.MiddleLeft
        StaffButton.TextImageRelation = TextImageRelation.ImageBeforeText
        StaffButton.UseVisualStyleBackColor = True
        ' 
        ' homeButton
        ' 
        homeButton.Dock = DockStyle.Top
        homeButton.FlatAppearance.BorderSize = 0
        homeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        homeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        homeButton.FlatStyle = FlatStyle.Flat
        homeButton.Font = New Font("Gabriola", 9F)
        homeButton.ForeColor = Color.White
        homeButton.Image = CType(resources.GetObject("homeButton.Image"), Image)
        homeButton.ImageAlign = ContentAlignment.MiddleLeft
        homeButton.Location = New Point(0, 0)
        homeButton.Margin = New Padding(2, 3, 2, 3)
        homeButton.Name = "homeButton"
        homeButton.Padding = New Padding(6, 0, 0, 0)
        homeButton.Size = New Size(217, 50)
        homeButton.TabIndex = 1
        homeButton.Text = "Home"
        homeButton.TextAlign = ContentAlignment.MiddleLeft
        homeButton.TextImageRelation = TextImageRelation.ImageBeforeText
        homeButton.UseVisualStyleBackColor = True
        ' 
        ' tripButton
        ' 
        tripButton.FlatAppearance.BorderSize = 0
        tripButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        tripButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        tripButton.FlatStyle = FlatStyle.Flat
        tripButton.Font = New Font("Gabriola", 9F)
        tripButton.ForeColor = Color.White
        tripButton.Image = CType(resources.GetObject("tripButton.Image"), Image)
        tripButton.ImageAlign = ContentAlignment.MiddleLeft
        tripButton.Location = New Point(2, 156)
        tripButton.Margin = New Padding(2, 3, 2, 3)
        tripButton.Name = "tripButton"
        tripButton.Padding = New Padding(6, 0, 0, 0)
        tripButton.Size = New Size(215, 50)
        tripButton.TabIndex = 6
        tripButton.Text = "Trips"
        tripButton.TextAlign = ContentAlignment.MiddleLeft
        tripButton.TextImageRelation = TextImageRelation.ImageBeforeText
        tripButton.UseVisualStyleBackColor = True
        ' 
        ' rentButton
        ' 
        rentButton.FlatAppearance.BorderSize = 0
        rentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        rentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        rentButton.FlatStyle = FlatStyle.Flat
        rentButton.Font = New Font("Gabriola", 9F)
        rentButton.ForeColor = Color.White
        rentButton.Image = CType(resources.GetObject("rentButton.Image"), Image)
        rentButton.ImageAlign = ContentAlignment.MiddleLeft
        rentButton.Location = New Point(0, 212)
        rentButton.Margin = New Padding(2, 3, 2, 3)
        rentButton.Name = "rentButton"
        rentButton.Padding = New Padding(6, 0, 0, 0)
        rentButton.Size = New Size(217, 50)
        rentButton.TabIndex = 4
        rentButton.Text = "Renting"
        rentButton.TextAlign = ContentAlignment.MiddleLeft
        rentButton.TextImageRelation = TextImageRelation.ImageBeforeText
        rentButton.UseVisualStyleBackColor = True
        ' 
        ' logoPanel
        ' 
        logoPanel.Controls.Add(busLogo)
        logoPanel.Controls.Add(logoLabel)
        logoPanel.Dock = DockStyle.Top
        logoPanel.Location = New Point(0, 0)
        logoPanel.Margin = New Padding(2, 3, 2, 3)
        logoPanel.Name = "logoPanel"
        logoPanel.Size = New Size(217, 190)
        logoPanel.TabIndex = 0
        ' 
        ' busLogo
        ' 
        busLogo.BackColor = Color.Transparent
        busLogo.Dock = DockStyle.Top
        busLogo.Image = CType(resources.GetObject("busLogo.Image"), Image)
        busLogo.Location = New Point(0, 0)
        busLogo.Margin = New Padding(2, 3, 2, 3)
        busLogo.Name = "busLogo"
        busLogo.Size = New Size(217, 151)
        busLogo.SizeMode = PictureBoxSizeMode.StretchImage
        busLogo.TabIndex = 0
        busLogo.TabStop = False
        ' 
        ' logoLabel
        ' 
        logoLabel.AutoSize = True
        logoLabel.FlatStyle = FlatStyle.Flat
        logoLabel.Font = New Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        logoLabel.ForeColor = Color.DarkOrange
        logoLabel.Location = New Point(8, 152)
        logoLabel.Margin = New Padding(2, 0, 2, 0)
        logoLabel.Name = "logoLabel"
        logoLabel.Size = New Size(161, 21)
        logoLabel.TabIndex = 1
        logoLabel.Text = "FLEET FRONTIER"
        ' 
        ' logoutButton
        ' 
        logoutButton.Dock = DockStyle.Bottom
        logoutButton.FlatAppearance.BorderSize = 0
        logoutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        logoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        logoutButton.FlatStyle = FlatStyle.Flat
        logoutButton.Font = New Font("Gabriola", 9F)
        logoutButton.ForeColor = Color.White
        logoutButton.Image = CType(resources.GetObject("logoutButton.Image"), Image)
        logoutButton.ImageAlign = ContentAlignment.MiddleLeft
        logoutButton.Location = New Point(0, 611)
        logoutButton.Margin = New Padding(2, 3, 2, 3)
        logoutButton.Name = "logoutButton"
        logoutButton.Padding = New Padding(6, 0, 0, 0)
        logoutButton.Size = New Size(217, 50)
        logoutButton.TabIndex = 5
        logoutButton.Text = "Log Out "
        logoutButton.TextAlign = ContentAlignment.MiddleLeft
        logoutButton.TextImageRelation = TextImageRelation.ImageBeforeText
        logoutButton.UseVisualStyleBackColor = True
        ' 
        ' middlePanel
        ' 
        middlePanel.Controls.Add(Panel1)
        middlePanel.Dock = DockStyle.Fill
        middlePanel.Location = New Point(0, 34)
        middlePanel.Name = "middlePanel"
        middlePanel.Size = New Size(1241, 661)
        middlePanel.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(BodyPanel)
        Panel1.Controls.Add(sideBar)
        Panel1.Controls.Add(WelcomeLabel)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1241, 661)
        Panel1.TabIndex = 1
        ' 
        ' BodyPanel
        ' 
        BodyPanel.BackColor = Color.White
        BodyPanel.Controls.Add(VehiclesUserControl1)
        BodyPanel.Controls.Add(StaffUserControl1)
        BodyPanel.Dock = DockStyle.Fill
        BodyPanel.Location = New Point(217, 0)
        BodyPanel.Name = "BodyPanel"
        BodyPanel.Size = New Size(1024, 661)
        BodyPanel.TabIndex = 1
        ' 
        ' VehiclesUserControl1
        ' 
        VehiclesUserControl1.Dock = DockStyle.Fill
        VehiclesUserControl1.Location = New Point(0, 0)
        VehiclesUserControl1.Margin = New Padding(3, 2, 3, 2)
        VehiclesUserControl1.Name = "VehiclesUserControl1"
        VehiclesUserControl1.Padding = New Padding(20)
        VehiclesUserControl1.Size = New Size(1024, 661)
        VehiclesUserControl1.TabIndex = 1
        ' 
        ' StaffUserControl1
        ' 
        StaffUserControl1.Dock = DockStyle.Fill
        StaffUserControl1.Location = New Point(0, 0)
        StaffUserControl1.Margin = New Padding(3, 2, 3, 2)
        StaffUserControl1.Name = "StaffUserControl1"
        StaffUserControl1.Padding = New Padding(20)
        StaffUserControl1.Size = New Size(1024, 661)
        StaffUserControl1.TabIndex = 0
        ' 
        ' WelcomeLabel
        ' 
        WelcomeLabel.AutoSize = True
        WelcomeLabel.BackColor = Color.Transparent
        WelcomeLabel.Dock = DockStyle.Fill
        WelcomeLabel.Font = New Font("Gabriola", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        WelcomeLabel.Location = New Point(0, 0)
        WelcomeLabel.Name = "WelcomeLabel"
        WelcomeLabel.Size = New Size(0, 26)
        WelcomeLabel.TabIndex = 0
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1241, 695)
        ControlBox = False
        Controls.Add(middlePanel)
        Controls.Add(controlBarPanel)
        Font = New Font("Impact", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2, 3, 2, 3)
        MinimizeBox = False
        MinimumSize = New Size(712, 561)
        Name = "MainForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        controlBarPanel.ResumeLayout(False)
        controlBarPanel.PerformLayout()
        CType(controlBarIcon, ComponentModel.ISupportInitialize).EndInit()
        sideBar.ResumeLayout(False)
        lowSidebarPanel.ResumeLayout(False)
        logoPanel.ResumeLayout(False)
        logoPanel.PerformLayout()
        CType(busLogo, ComponentModel.ISupportInitialize).EndInit()
        middlePanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        BodyPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents controlBarPanel As Panel
    Friend WithEvents sideBar As Panel
    Friend WithEvents controlBarLabel As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents controlBarIcon As PictureBox
    Friend WithEvents minimizeButton As Button
    Friend WithEvents middlePanel As Panel
    Friend WithEvents logoPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents logoLabel As Label
    Friend WithEvents busLogo As PictureBox
    Friend WithEvents logoutButton As Button
    Friend WithEvents WelcomeLabel As Label
    Friend WithEvents lowSidebarPanel As Panel
    Friend WithEvents homeButton As Button
    Friend WithEvents tripButton As Button
    Friend WithEvents rentButton As Button
    Friend WithEvents VehicleButton As Button
    Friend WithEvents StaffButton As Button
    Friend WithEvents BodyPanel As Panel
    Friend WithEvents StaffUserControl1 As StaffUserControl
    Friend WithEvents VehiclesUserControl1 As VehiclesUserControl

End Class
