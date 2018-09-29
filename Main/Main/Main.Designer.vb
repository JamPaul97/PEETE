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
        Me.WorkerLoadProject = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProgressBarTotal = New System.Windows.Forms.ToolStripProgressBar()
        Me.ProgressBarCurrent = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TrainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Trainers_List = New System.Windows.Forms.ToolStripComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectToolStripMenuItem, Me.TrainerToolStripMenuItem, Me.AboutToolStripMenuItem, Me.Trainers_List})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(778, 27)
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
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'BtnProjectSave
        '
        Me.BtnProjectSave.Enabled = False
        Me.BtnProjectSave.Name = "BtnProjectSave"
        Me.BtnProjectSave.Size = New System.Drawing.Size(180, 22)
        Me.BtnProjectSave.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'WorkerLoadProject
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBarTotal, Me.ProgressBarCurrent, Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 455)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(778, 22)
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 477)
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
End Class
