<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainerTypeEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrainerTypeEditor))
        Me.Type_SkillCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Type_SkillLevel = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Type_Mixed = New System.Windows.Forms.RadioButton()
        Me.Type_Female = New System.Windows.Forms.RadioButton()
        Me.Type_Male = New System.Windows.Forms.RadioButton()
        Me.Type_IntroME = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Type_VictoryBGM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Type_BattleBGM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Type_BaseMoney = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Type_DisplayName = New System.Windows.Forms.TextBox()
        Me.Type_InternalName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Type_ID = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.StatusCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Types_List = New System.Windows.Forms.ToolStripComboBox()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainerTypesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.Type_SkillLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Type_BaseMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Type_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Type_SkillCode
        '
        Me.Type_SkillCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Type_SkillCode.Location = New System.Drawing.Point(524, 52)
        Me.Type_SkillCode.Multiline = True
        Me.Type_SkillCode.Name = "Type_SkillCode"
        Me.Type_SkillCode.Size = New System.Drawing.Size(168, 102)
        Me.Type_SkillCode.TabIndex = 93
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(521, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Skill Code"
        '
        'Type_SkillLevel
        '
        Me.Type_SkillLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Type_SkillLevel.Location = New System.Drawing.Point(350, 52)
        Me.Type_SkillLevel.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Type_SkillLevel.Name = "Type_SkillLevel"
        Me.Type_SkillLevel.Size = New System.Drawing.Size(78, 20)
        Me.Type_SkillLevel.TabIndex = 91
        Me.Type_SkillLevel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(347, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Skill Level"
        '
        'Type_Mixed
        '
        Me.Type_Mixed.AutoSize = True
        Me.Type_Mixed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Type_Mixed.Location = New System.Drawing.Point(470, 137)
        Me.Type_Mixed.Name = "Type_Mixed"
        Me.Type_Mixed.Size = New System.Drawing.Size(53, 17)
        Me.Type_Mixed.TabIndex = 89
        Me.Type_Mixed.TabStop = True
        Me.Type_Mixed.Text = "Mixed"
        Me.Type_Mixed.UseVisualStyleBackColor = True
        '
        'Type_Female
        '
        Me.Type_Female.AutoSize = True
        Me.Type_Female.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Type_Female.Location = New System.Drawing.Point(405, 137)
        Me.Type_Female.Name = "Type_Female"
        Me.Type_Female.Size = New System.Drawing.Size(59, 17)
        Me.Type_Female.TabIndex = 88
        Me.Type_Female.TabStop = True
        Me.Type_Female.Text = "Female"
        Me.Type_Female.UseVisualStyleBackColor = True
        '
        'Type_Male
        '
        Me.Type_Male.AutoSize = True
        Me.Type_Male.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Type_Male.Location = New System.Drawing.Point(351, 136)
        Me.Type_Male.Name = "Type_Male"
        Me.Type_Male.Size = New System.Drawing.Size(48, 17)
        Me.Type_Male.TabIndex = 87
        Me.Type_Male.TabStop = True
        Me.Type_Male.Text = "Male"
        Me.Type_Male.UseVisualStyleBackColor = True
        '
        'Type_IntroME
        '
        Me.Type_IntroME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Type_IntroME.Location = New System.Drawing.Point(350, 94)
        Me.Type_IntroME.Name = "Type_IntroME"
        Me.Type_IntroME.Size = New System.Drawing.Size(168, 20)
        Me.Type_IntroME.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(347, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Intro ME"
        '
        'Type_VictoryBGM
        '
        Me.Type_VictoryBGM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Type_VictoryBGM.Location = New System.Drawing.Point(187, 134)
        Me.Type_VictoryBGM.Name = "Type_VictoryBGM"
        Me.Type_VictoryBGM.Size = New System.Drawing.Size(157, 20)
        Me.Type_VictoryBGM.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(184, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Victory BGM"
        '
        'Type_BattleBGM
        '
        Me.Type_BattleBGM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Type_BattleBGM.Location = New System.Drawing.Point(187, 94)
        Me.Type_BattleBGM.Name = "Type_BattleBGM"
        Me.Type_BattleBGM.Size = New System.Drawing.Size(157, 20)
        Me.Type_BattleBGM.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(184, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Battle BGM"
        '
        'Type_BaseMoney
        '
        Me.Type_BaseMoney.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Type_BaseMoney.Location = New System.Drawing.Point(187, 52)
        Me.Type_BaseMoney.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Type_BaseMoney.Name = "Type_BaseMoney"
        Me.Type_BaseMoney.Size = New System.Drawing.Size(78, 20)
        Me.Type_BaseMoney.TabIndex = 80
        Me.Type_BaseMoney.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(184, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Base Money"
        '
        'Type_DisplayName
        '
        Me.Type_DisplayName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Type_DisplayName.Location = New System.Drawing.Point(12, 134)
        Me.Type_DisplayName.Name = "Type_DisplayName"
        Me.Type_DisplayName.Size = New System.Drawing.Size(157, 20)
        Me.Type_DisplayName.TabIndex = 78
        '
        'Type_InternalName
        '
        Me.Type_InternalName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Type_InternalName.Location = New System.Drawing.Point(12, 94)
        Me.Type_InternalName.Name = "Type_InternalName"
        Me.Type_InternalName.Size = New System.Drawing.Size(157, 20)
        Me.Type_InternalName.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Internal Name"
        '
        'Type_ID
        '
        Me.Type_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Type_ID.Location = New System.Drawing.Point(12, 52)
        Me.Type_ID.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.Type_ID.Name = "Type_ID"
        Me.Type_ID.Size = New System.Drawing.Size(78, 20)
        Me.Type_ID.TabIndex = 74
        Me.Type_ID.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(9, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 13)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "ID"
        '
        'StatusCount
        '
        Me.StatusCount.BackColor = System.Drawing.SystemColors.Control
        Me.StatusCount.Name = "StatusCount"
        Me.StatusCount.Size = New System.Drawing.Size(120, 17)
        Me.StatusCount.Text = "ToolStripStatusLabel1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 162)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(699, 22)
        Me.StatusStrip1.TabIndex = 72
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Types_List
        '
        Me.Types_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Types_List.Name = "Types_List"
        Me.Types_List.Size = New System.Drawing.Size(121, 23)
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddNewToolStripMenuItem.Text = "Add New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'TrainerTypesToolStripMenuItem
        '
        Me.TrainerTypesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.AddNewToolStripMenuItem})
        Me.TrainerTypesToolStripMenuItem.Name = "TrainerTypesToolStripMenuItem"
        Me.TrainerTypesToolStripMenuItem.Size = New System.Drawing.Size(88, 23)
        Me.TrainerTypesToolStripMenuItem.Text = "Trainer Types"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Display Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrainerTypesToolStripMenuItem, Me.Types_List})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(699, 27)
        Me.MenuStrip1.TabIndex = 71
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TrainerTypeEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 184)
        Me.Controls.Add(Me.Type_SkillCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Type_SkillLevel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Type_Mixed)
        Me.Controls.Add(Me.Type_Female)
        Me.Controls.Add(Me.Type_Male)
        Me.Controls.Add(Me.Type_IntroME)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Type_VictoryBGM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Type_BattleBGM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Type_BaseMoney)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Type_DisplayName)
        Me.Controls.Add(Me.Type_InternalName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Type_ID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TrainerTypeEditor"
        Me.Text = "TrainerTypeEditor"
        CType(Me.Type_SkillLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Type_BaseMoney, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Type_ID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Type_SkillCode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Type_SkillLevel As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Type_Mixed As RadioButton
    Friend WithEvents Type_Female As RadioButton
    Friend WithEvents Type_Male As RadioButton
    Friend WithEvents Type_IntroME As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Type_VictoryBGM As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Type_BattleBGM As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Type_BaseMoney As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Type_DisplayName As TextBox
    Friend WithEvents Type_InternalName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Type_ID As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents StatusCount As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Types_List As ToolStripComboBox
    Friend WithEvents AddNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrainerTypesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
