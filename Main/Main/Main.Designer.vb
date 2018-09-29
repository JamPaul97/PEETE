<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnProjectSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Trainers_List = New System.Windows.Forms.ToolStripComboBox()
        Me.WorkerLoadProject = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProgressBarTotal = New System.Windows.Forms.ToolStripProgressBar()
        Me.ProgressBarCurrent = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Trainer_Pokemon = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.Trainer_ButtonSave = New System.Windows.Forms.Button()
        Me.Trainer_Nature = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Trainer_Ball = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Trainer_Nickname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Trainer_Happiness = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Trainer_Ivs = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Trainer_Shadow = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Trainer_Shiny = New System.Windows.Forms.CheckBox()
        Me.Trainer_Form = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Trainer_Random = New System.Windows.Forms.RadioButton()
        Me.Trainer_Female = New System.Windows.Forms.RadioButton()
        Me.Trainer_male = New System.Windows.Forms.RadioButton()
        Me.Trainer_Ability = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Trainer_Move4 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Trainer_Move3 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Trainer_Move2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Trainer_Move1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Trainer_Level = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Trainer_HeldItem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Trainer_Speice = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Trainer_PokemonImage = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Trainer_Items = New System.Windows.Forms.ListBox()
        Me.Trainer_Name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Trainer_TrainerType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GB1.SuspendLayout()
        CType(Me.Trainer_Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trainer_Happiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trainer_Ivs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Trainer_Level, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trainer_PokemonImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectToolStripMenuItem, Me.TrainerToolStripMenuItem, Me.AboutToolStripMenuItem, Me.Trainers_List})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(921, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.BtnProjectSave, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(56, 23)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'BtnProjectSave
        '
        Me.BtnProjectSave.Enabled = False
        Me.BtnProjectSave.Name = "BtnProjectSave"
        Me.BtnProjectSave.Size = New System.Drawing.Size(100, 22)
        Me.BtnProjectSave.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(97, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TrainerToolStripMenuItem
        '
        Me.TrainerToolStripMenuItem.Name = "TrainerToolStripMenuItem"
        Me.TrainerToolStripMenuItem.Size = New System.Drawing.Size(55, 23)
        Me.TrainerToolStripMenuItem.Text = "Trainer"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 23)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Trainers_List
        '
        Me.Trainers_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Trainers_List.Name = "Trainers_List"
        Me.Trainers_List.Size = New System.Drawing.Size(121, 23)
        '
        'WorkerLoadProject
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBarTotal, Me.ProgressBarCurrent, Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 303)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(921, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProgressBarTotal
        '
        Me.ProgressBarTotal.Name = "ProgressBarTotal"
        Me.ProgressBarTotal.Size = New System.Drawing.Size(100, 16)
        Me.ProgressBarTotal.Visible = False
        '
        'ProgressBarCurrent
        '
        Me.ProgressBarCurrent.Name = "ProgressBarCurrent"
        Me.ProgressBarCurrent.Size = New System.Drawing.Size(100, 16)
        Me.ProgressBarCurrent.Visible = False
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(120, 17)
        Me.StatusLabel.Text = "ToolStripStatusLabel1"
        Me.StatusLabel.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Trainer_Pokemon)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.GB1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Trainer_Name)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Trainer_TrainerType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(903, 271)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main Trainer"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(592, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Add Pokemon"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Trainer_Pokemon
        '
        Me.Trainer_Pokemon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Trainer_Pokemon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Pokemon.FormattingEnabled = True
        Me.Trainer_Pokemon.Location = New System.Drawing.Point(429, 32)
        Me.Trainer_Pokemon.Name = "Trainer_Pokemon"
        Me.Trainer_Pokemon.Size = New System.Drawing.Size(157, 21)
        Me.Trainer_Pokemon.TabIndex = 42
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(429, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Trainer Pokemons"
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.Trainer_ButtonSave)
        Me.GB1.Controls.Add(Me.Trainer_Nature)
        Me.GB1.Controls.Add(Me.Label17)
        Me.GB1.Controls.Add(Me.Trainer_Ball)
        Me.GB1.Controls.Add(Me.Label15)
        Me.GB1.Controls.Add(Me.Trainer_Nickname)
        Me.GB1.Controls.Add(Me.Label14)
        Me.GB1.Controls.Add(Me.Trainer_Happiness)
        Me.GB1.Controls.Add(Me.Label12)
        Me.GB1.Controls.Add(Me.Trainer_Ivs)
        Me.GB1.Controls.Add(Me.Label11)
        Me.GB1.Controls.Add(Me.GroupBox5)
        Me.GB1.Controls.Add(Me.GroupBox4)
        Me.GB1.Controls.Add(Me.Trainer_Form)
        Me.GB1.Controls.Add(Me.Label10)
        Me.GB1.Controls.Add(Me.GroupBox3)
        Me.GB1.Controls.Add(Me.Trainer_Ability)
        Me.GB1.Controls.Add(Me.Label9)
        Me.GB1.Controls.Add(Me.Trainer_Move4)
        Me.GB1.Controls.Add(Me.Label8)
        Me.GB1.Controls.Add(Me.Trainer_Move3)
        Me.GB1.Controls.Add(Me.Label7)
        Me.GB1.Controls.Add(Me.Trainer_Move2)
        Me.GB1.Controls.Add(Me.Label5)
        Me.GB1.Controls.Add(Me.Trainer_Move1)
        Me.GB1.Controls.Add(Me.Label3)
        Me.GB1.Controls.Add(Me.Trainer_Level)
        Me.GB1.Controls.Add(Me.Label13)
        Me.GB1.Controls.Add(Me.Trainer_HeldItem)
        Me.GB1.Controls.Add(Me.Label2)
        Me.GB1.Controls.Add(Me.Trainer_Speice)
        Me.GB1.Controls.Add(Me.Label1)
        Me.GB1.Controls.Add(Me.Trainer_PokemonImage)
        Me.GB1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GB1.Location = New System.Drawing.Point(172, 60)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(728, 206)
        Me.GB1.TabIndex = 40
        Me.GB1.TabStop = False
        Me.GB1.Text = "Pokemon 1"
        '
        'Trainer_ButtonSave
        '
        Me.Trainer_ButtonSave.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_ButtonSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_ButtonSave.Location = New System.Drawing.Point(647, 177)
        Me.Trainer_ButtonSave.Name = "Trainer_ButtonSave"
        Me.Trainer_ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.Trainer_ButtonSave.TabIndex = 75
        Me.Trainer_ButtonSave.Text = "Save"
        Me.Trainer_ButtonSave.UseVisualStyleBackColor = False
        '
        'Trainer_Nature
        '
        Me.Trainer_Nature.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Nature.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Nature.Location = New System.Drawing.Point(311, 172)
        Me.Trainer_Nature.Name = "Trainer_Nature"
        Me.Trainer_Nature.Size = New System.Drawing.Size(157, 20)
        Me.Trainer_Nature.TabIndex = 74
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(311, 156)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Nature"
        '
        'Trainer_Ball
        '
        Me.Trainer_Ball.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Ball.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Ball.Location = New System.Drawing.Point(244, 173)
        Me.Trainer_Ball.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Trainer_Ball.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.Trainer_Ball.Name = "Trainer_Ball"
        Me.Trainer_Ball.Size = New System.Drawing.Size(61, 20)
        Me.Trainer_Ball.TabIndex = 72
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(241, 157)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 13)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "Ball"
        '
        'Trainer_Nickname
        '
        Me.Trainer_Nickname.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Nickname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Nickname.Location = New System.Drawing.Point(81, 172)
        Me.Trainer_Nickname.MaxLength = 10
        Me.Trainer_Nickname.Name = "Trainer_Nickname"
        Me.Trainer_Nickname.Size = New System.Drawing.Size(157, 20)
        Me.Trainer_Nickname.TabIndex = 70
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(81, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Nickname"
        '
        'Trainer_Happiness
        '
        Me.Trainer_Happiness.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Happiness.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Happiness.Location = New System.Drawing.Point(12, 173)
        Me.Trainer_Happiness.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Trainer_Happiness.Name = "Trainer_Happiness"
        Me.Trainer_Happiness.Size = New System.Drawing.Size(61, 20)
        Me.Trainer_Happiness.TabIndex = 68
        Me.Trainer_Happiness.Value = New Decimal(New Integer() {70, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(9, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Happiness"
        '
        'Trainer_Ivs
        '
        Me.Trainer_Ivs.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Ivs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Ivs.Location = New System.Drawing.Point(146, 73)
        Me.Trainer_Ivs.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.Trainer_Ivs.Name = "Trainer_Ivs"
        Me.Trainer_Ivs.Size = New System.Drawing.Size(61, 20)
        Me.Trainer_Ivs.TabIndex = 66
        Me.Trainer_Ivs.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(143, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Ivs"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.Trainer_Shadow)
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(565, 111)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(157, 42)
        Me.GroupBox5.TabIndex = 64
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Shadow"
        '
        'Trainer_Shadow
        '
        Me.Trainer_Shadow.AutoSize = True
        Me.Trainer_Shadow.Location = New System.Drawing.Point(37, 19)
        Me.Trainer_Shadow.Name = "Trainer_Shadow"
        Me.Trainer_Shadow.Size = New System.Drawing.Size(82, 17)
        Me.Trainer_Shadow.TabIndex = 0
        Me.Trainer_Shadow.Text = "Is Shadow?"
        Me.Trainer_Shadow.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Trainer_Shiny)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(402, 111)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(157, 42)
        Me.GroupBox4.TabIndex = 63
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Shiny"
        '
        'Trainer_Shiny
        '
        Me.Trainer_Shiny.AutoSize = True
        Me.Trainer_Shiny.Location = New System.Drawing.Point(44, 19)
        Me.Trainer_Shiny.Name = "Trainer_Shiny"
        Me.Trainer_Shiny.Size = New System.Drawing.Size(69, 17)
        Me.Trainer_Shiny.TabIndex = 0
        Me.Trainer_Shiny.Text = "Is Shiny?"
        Me.Trainer_Shiny.UseVisualStyleBackColor = True
        '
        'Trainer_Form
        '
        Me.Trainer_Form.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Form.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Form.Location = New System.Drawing.Point(239, 131)
        Me.Trainer_Form.Name = "Trainer_Form"
        Me.Trainer_Form.Size = New System.Drawing.Size(157, 20)
        Me.Trainer_Form.TabIndex = 62
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(239, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Form"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Trainer_Random)
        Me.GroupBox3.Controls.Add(Me.Trainer_Female)
        Me.GroupBox3.Controls.Add(Me.Trainer_male)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 42)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gender"
        '
        'Trainer_Random
        '
        Me.Trainer_Random.AutoSize = True
        Me.Trainer_Random.Location = New System.Drawing.Point(155, 19)
        Me.Trainer_Random.Name = "Trainer_Random"
        Me.Trainer_Random.Size = New System.Drawing.Size(65, 17)
        Me.Trainer_Random.TabIndex = 2
        Me.Trainer_Random.TabStop = True
        Me.Trainer_Random.Text = "Random"
        Me.Trainer_Random.UseVisualStyleBackColor = True
        '
        'Trainer_Female
        '
        Me.Trainer_Female.AutoSize = True
        Me.Trainer_Female.Location = New System.Drawing.Point(75, 19)
        Me.Trainer_Female.Name = "Trainer_Female"
        Me.Trainer_Female.Size = New System.Drawing.Size(59, 17)
        Me.Trainer_Female.TabIndex = 1
        Me.Trainer_Female.TabStop = True
        Me.Trainer_Female.Text = "Female"
        Me.Trainer_Female.UseVisualStyleBackColor = True
        '
        'Trainer_male
        '
        Me.Trainer_male.AutoSize = True
        Me.Trainer_male.Location = New System.Drawing.Point(6, 19)
        Me.Trainer_male.Name = "Trainer_male"
        Me.Trainer_male.Size = New System.Drawing.Size(48, 17)
        Me.Trainer_male.TabIndex = 0
        Me.Trainer_male.TabStop = True
        Me.Trainer_male.Text = "Male"
        Me.Trainer_male.UseVisualStyleBackColor = True
        '
        'Trainer_Ability
        '
        Me.Trainer_Ability.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Ability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Trainer_Ability.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Ability.FormattingEnabled = True
        Me.Trainer_Ability.Items.AddRange(New Object() {"0 - First Natural Ability", "1 - Secong Natural Ability", "2 - Hidden Ability", "3 - Hidden Ability", "4 - Hidden Ability", "5 - Hidden Ability", "---NONE---"})
        Me.Trainer_Ability.Location = New System.Drawing.Point(239, 84)
        Me.Trainer_Ability.Name = "Trainer_Ability"
        Me.Trainer_Ability.Size = New System.Drawing.Size(157, 21)
        Me.Trainer_Ability.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(239, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Ability"
        '
        'Trainer_Move4
        '
        Me.Trainer_Move4.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Move4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Trainer_Move4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Move4.FormattingEnabled = True
        Me.Trainer_Move4.Location = New System.Drawing.Point(565, 84)
        Me.Trainer_Move4.Name = "Trainer_Move4"
        Me.Trainer_Move4.Size = New System.Drawing.Size(157, 21)
        Me.Trainer_Move4.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(565, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Move 4"
        '
        'Trainer_Move3
        '
        Me.Trainer_Move3.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Move3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Trainer_Move3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Move3.FormattingEnabled = True
        Me.Trainer_Move3.Location = New System.Drawing.Point(402, 84)
        Me.Trainer_Move3.Name = "Trainer_Move3"
        Me.Trainer_Move3.Size = New System.Drawing.Size(157, 21)
        Me.Trainer_Move3.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(402, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Move 3"
        '
        'Trainer_Move2
        '
        Me.Trainer_Move2.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Move2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Trainer_Move2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Move2.FormattingEnabled = True
        Me.Trainer_Move2.Location = New System.Drawing.Point(565, 34)
        Me.Trainer_Move2.Name = "Trainer_Move2"
        Me.Trainer_Move2.Size = New System.Drawing.Size(157, 21)
        Me.Trainer_Move2.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(565, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Move 2"
        '
        'Trainer_Move1
        '
        Me.Trainer_Move1.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Move1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Trainer_Move1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Move1.FormattingEnabled = True
        Me.Trainer_Move1.Location = New System.Drawing.Point(402, 34)
        Me.Trainer_Move1.Name = "Trainer_Move1"
        Me.Trainer_Move1.Size = New System.Drawing.Size(157, 21)
        Me.Trainer_Move1.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(402, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Move 1"
        '
        'Trainer_Level
        '
        Me.Trainer_Level.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Level.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Level.Location = New System.Drawing.Point(79, 73)
        Me.Trainer_Level.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Trainer_Level.Name = "Trainer_Level"
        Me.Trainer_Level.Size = New System.Drawing.Size(61, 20)
        Me.Trainer_Level.TabIndex = 49
        Me.Trainer_Level.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(76, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Level"
        '
        'Trainer_HeldItem
        '
        Me.Trainer_HeldItem.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_HeldItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Trainer_HeldItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_HeldItem.FormattingEnabled = True
        Me.Trainer_HeldItem.Location = New System.Drawing.Point(239, 34)
        Me.Trainer_HeldItem.Name = "Trainer_HeldItem"
        Me.Trainer_HeldItem.Size = New System.Drawing.Size(157, 21)
        Me.Trainer_HeldItem.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(239, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Help Item"
        '
        'Trainer_Speice
        '
        Me.Trainer_Speice.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_Speice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Trainer_Speice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Speice.FormattingEnabled = True
        Me.Trainer_Speice.Location = New System.Drawing.Point(76, 34)
        Me.Trainer_Speice.Name = "Trainer_Speice"
        Me.Trainer_Speice.Size = New System.Drawing.Size(157, 21)
        Me.Trainer_Speice.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(76, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Specie"
        '
        'Trainer_PokemonImage
        '
        Me.Trainer_PokemonImage.BackColor = System.Drawing.SystemColors.Control
        Me.Trainer_PokemonImage.Location = New System.Drawing.Point(6, 16)
        Me.Trainer_PokemonImage.Name = "Trainer_PokemonImage"
        Me.Trainer_PokemonImage.Size = New System.Drawing.Size(64, 64)
        Me.Trainer_PokemonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Trainer_PokemonImage.TabIndex = 0
        Me.Trainer_PokemonImage.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Trainer_Items)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 164)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Trainer Items"
        '
        'Trainer_Items
        '
        Me.Trainer_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Trainer_Items.FormattingEnabled = True
        Me.Trainer_Items.Location = New System.Drawing.Point(3, 16)
        Me.Trainer_Items.Name = "Trainer_Items"
        Me.Trainer_Items.Size = New System.Drawing.Size(151, 145)
        Me.Trainer_Items.TabIndex = 0
        '
        'Trainer_Name
        '
        Me.Trainer_Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_Name.Location = New System.Drawing.Point(9, 76)
        Me.Trainer_Name.Name = "Trainer_Name"
        Me.Trainer_Name.Size = New System.Drawing.Size(157, 20)
        Me.Trainer_Name.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(6, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Name"
        '
        'Trainer_TrainerType
        '
        Me.Trainer_TrainerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Trainer_TrainerType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Trainer_TrainerType.FormattingEnabled = True
        Me.Trainer_TrainerType.Location = New System.Drawing.Point(6, 34)
        Me.Trainer_TrainerType.Name = "Trainer_TrainerType"
        Me.Trainer_TrainerType.Size = New System.Drawing.Size(157, 21)
        Me.Trainer_TrainerType.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Trainer Type"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 325)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Pokemon Essential Easy Trainer Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        CType(Me.Trainer_Ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trainer_Happiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trainer_Ivs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Trainer_Level, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trainer_PokemonImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnProjectSave As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WorkerLoadProject As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ProgressBarTotal As ToolStripProgressBar
    Friend WithEvents ProgressBarCurrent As ToolStripProgressBar
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents TrainerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Trainers_List As ToolStripComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Trainer_Pokemon As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GB1 As GroupBox
    Friend WithEvents Trainer_ButtonSave As Button
    Friend WithEvents Trainer_Nature As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Trainer_Ball As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents Trainer_Nickname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Trainer_Happiness As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Trainer_Ivs As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Trainer_Shadow As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Trainer_Shiny As CheckBox
    Friend WithEvents Trainer_Form As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Trainer_Random As RadioButton
    Friend WithEvents Trainer_Female As RadioButton
    Friend WithEvents Trainer_male As RadioButton
    Friend WithEvents Trainer_Ability As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Trainer_Move4 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Trainer_Move3 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Trainer_Move2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Trainer_Move1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Trainer_Level As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Trainer_HeldItem As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Trainer_Speice As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Trainer_PokemonImage As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Trainer_Items As ListBox
    Friend WithEvents Trainer_Name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Trainer_TrainerType As ComboBox
    Friend WithEvents Label6 As Label
End Class
