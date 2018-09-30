Public Class TrainerTypeEditor
    Private Sub loadAllTrainerTypes()
        Types_List.Items.Clear()
        For Each item In Main.Project.Types
            Types_List.Items.Add(item.InternalName)
        Next
        StatusCount.Text = "Trainer Types loaded : " & Main.Project.Types.Count
    End Sub
    Private Sub loadSingleType()
        Dim id As Integer = Types_List.SelectedIndex
        Type_ID.Value = Main.Project.TrainerTypes(id).id
        Type_DisplayName.Text = Main.Project.TrainerTypes(id).name
        Type_InternalName.Text = Main.Project.TrainerTypes(id).internalName
        Type_BaseMoney.Value = Main.Project.TrainerTypes(id).baseMoney
        Type_BattleBGM.Text = Main.Project.TrainerTypes(id).battleBGM
        Type_VictoryBGM.Text = Main.Project.TrainerTypes(id).victoryBGM
        Type_IntroME.Text = Main.Project.TrainerTypes(id).intoME
        Select Case Main.Project.TrainerTypes(id).gender
            Case "Male"
                Type_Male.Checked = True
            Case "Female"
                Type_Female.Checked = True
            Case "Mixed"
                Type_Mixed.Checked = True
        End Select
        Type_SkillCode.Text = Main.Project.TrainerTypes(id).skillCode
        Type_SkillLevel.Value = Main.Project.TrainerTypes(id).skillLevel
    End Sub
    Private Sub saveSingleType()
        Dim id = Types_List.SelectedIndex
        Main.Project.TrainerTypes(id).id = Type_ID.Value.ToString
        Main.Project.TrainerTypes(id).name = Type_DisplayName.Text
        Main.Project.TrainerTypes(id).internalName = Type_DisplayName.Text
        Main.Project.TrainerTypes(id).baseMoney = Type_BaseMoney.Value.ToString
        Main.Project.TrainerTypes(id).battleBGM = Type_BattleBGM.Text
        Main.Project.TrainerTypes(id).victoryBGM = Type_VictoryBGM.Text
        Main.Project.TrainerTypes(id).intoME = Type_IntroME.Text
        Select Case True
            Case Type_Male.Checked
                Main.Project.TrainerTypes(id).gender = "Male"
            Case Type_Female.Checked
                Main.Project.TrainerTypes(id).gender = "Female"
            Case Type_Mixed.Checked
                Main.Project.TrainerTypes(id).gender = "Mixed"
        End Select
        Main.Project.TrainerTypes(id).skillCode = Type_SkillCode.Text
        Main.Project.TrainerTypes(id).skillLevel = Type_SkillLevel.Value.ToString
        Main.Project.Save(PEE.ProjectClass.Save.TrainerTypes)
    End Sub
    Private Sub TrainerTypeEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAllTrainerTypes()
    End Sub

    Private Sub Types_List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Types_List.SelectedIndexChanged
        If Types_List.SelectedIndex >= 0 Then
            loadSingleType()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If Types_List.SelectedIndex >= 0 Then
            saveSingleType()
        End If
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        Dim tr As New PEE.TrainersTypesClass.TrainerType
        tr.internalName = "NEWTRAINER"
        tr.name = "NewTrainer"
        tr.baseMoney = "0"
        tr.id = (Main.Project.TrainerTypes.Count + 1).ToString
        tr.gender = "Mixed"
        tr.skillLevel = "0"
        Main.Project.TrainerTypes.Add(tr)
        loadAllTrainerTypes()
        Types_List.SelectedIndex = -1
        Types_List.SelectedIndex = Types_List.Items.Count - 1
    End Sub

    Private Sub TrainerTypeEditor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class