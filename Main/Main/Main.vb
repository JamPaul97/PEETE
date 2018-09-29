Imports PEE
Imports System.IO
Public Class Main
    Dim Project As New ProjectClass.project
    Private Sub loadSingleTrainer()
        Dim id As Integer = Trainers_List.SelectedIndex
        Trainer_TrainerType.SelectedItem = Project.Trainers(id).trainerType
        Trainer_Name.Text = Project.Trainers(id).name
        Trainer_Items.Items.Clear()
        For Each item In Project.Trainers(id).items
            Trainer_Items.Items.Add(item)
        Next
        Trainer_Pokemon.Items.Clear()
        If Project.Trainers(id).pokemon1.species IsNot Nothing And Project.Trainers(id).pokemon1.species IsNot "" Then
            Trainer_Pokemon.Items.Add(Project.Trainers(id).pokemon1.species)
        End If
        If Project.Trainers(id).pokemon2.species IsNot Nothing And Project.Trainers(id).pokemon2.species IsNot "" Then
            Trainer_Pokemon.Items.Add(Project.Trainers(id).pokemon2.species)
        End If
        If Project.Trainers(id).pokemon3.species IsNot Nothing And Project.Trainers(id).pokemon3.species IsNot "" Then
            Trainer_Pokemon.Items.Add(Project.Trainers(id).pokemon3.species)
        End If
        If Project.Trainers(id).pokemon4.species IsNot Nothing And Project.Trainers(id).pokemon4.species IsNot "" Then
            Trainer_Pokemon.Items.Add(Project.Trainers(id).pokemon4.species)
        End If
        If Project.Trainers(id).pokemon5.species IsNot Nothing And Project.Trainers(id).pokemon5.species IsNot "" Then
            Trainer_Pokemon.Items.Add(Project.Trainers(id).pokemon5.species)
        End If
        If Project.Trainers(id).pokemon6.species IsNot Nothing And Project.Trainers(id).pokemon6.species IsNot "" Then
            Trainer_Pokemon.Items.Add(Project.Trainers(id).pokemon6.species)
        End If
        Trainer_Pokemon.SelectedIndex = -1
        Trainer_Pokemon.SelectedIndex = 0
    End Sub
    Private Sub loadItems()
        Trainer_Items.Items.Clear()
        Trainer_HeldItem.Items.Clear()
        Trainer_Items.Items.Add("---NONE---")
        Trainer_HeldItem.Items.Add("---NONE---")
        For Each item In Project.Items
            Trainer_Items.Items.Add(item.internalName)
            Trainer_HeldItem.Items.Add(item.internalName)
        Next
    End Sub
    Private Sub loadMoves()
        Trainer_Move1.Items.Clear()
        Trainer_Move2.Items.Clear()
        Trainer_Move3.Items.Clear()
        Trainer_Move4.Items.Clear()
        Trainer_Move1.Items.Add("---NONE---")
        Trainer_Move2.Items.Add("---NONE---")
        Trainer_Move3.Items.Add("---NONE---")
        Trainer_Move4.Items.Add("---NONE---")
        For Each item In Project.Moves
            Trainer_Move1.Items.Add(item.internalName)
            Trainer_Move2.Items.Add(item.internalName)
            Trainer_Move3.Items.Add(item.internalName)
            Trainer_Move4.Items.Add(item.internalName)
        Next
    End Sub
    Private Sub loadSpeices()
        Trainer_Speice.Items.Clear()
        For Each item In Project.Pokemon
            Trainer_Speice.Items.Add(item.InternalName)
        Next
    End Sub
    Private Sub loadAllTrainers()
        Trainers_List.Items.Clear()
        For Each item In Project.Trainers
            Trainers_List.Items.Add(item.name & " - " & item.trainerType)
        Next
    End Sub
    Private Sub loadTrainerTypes()
        Trainer_TrainerType.Items.Clear()
        For Each item In Project.TrainerTypes
            Trainer_TrainerType.Items.Add(item.internalName)
        Next
    End Sub
    Private Sub loadSignlePokemon(ByVal PKM As PEE.TrainersClass.Trainer.pokemon)
        Dim id As Integer
        For Each item In Project.Pokemon
            If item.InternalName = PKM.species Then
                id = item.id
            End If
        Next
        Dim imgurl = Project.GraphicsFolder & "Battlers\" & id.ToString("000") & ".png"
        If File.Exists(imgurl) Then
            Trainer_PokemonImage.Image = Image.FromFile(imgurl)
        Else
            Trainer_PokemonImage.Image = Nothing
        End If

        Trainer_Speice.SelectedItem = PKM.species
        Trainer_Level.Value = PKM.level
        If PKM.heldItem IsNot Nothing And PKM.heldItem IsNot "" Then
            Trainer_HeldItem.SelectedItem = PKM.heldItem
        Else
            Trainer_HeldItem.SelectedItem = "---NONE---"
        End If
        If PKM.move1 IsNot Nothing And PKM.move1 IsNot "" Then
            Trainer_Move1.SelectedItem = PKM.move1
        Else
            Trainer_Move1.SelectedIndex = -1
        End If
        If PKM.move2 IsNot Nothing And PKM.move2 IsNot "" Then
            Trainer_Move2.SelectedItem = PKM.move2
        Else
            Trainer_Move2.SelectedIndex = -1
        End If
        If PKM.move3 IsNot Nothing And PKM.move3 IsNot "" Then
            Trainer_Move3.SelectedItem = PKM.move3
        Else
            Trainer_Move3.SelectedIndex = -1
        End If
        If PKM.move4 IsNot Nothing And PKM.move4 IsNot "" Then
            Trainer_Move4.SelectedItem = PKM.move4
        Else
            Trainer_Move4.SelectedIndex = -1
        End If
        If PKM.ability IsNot Nothing And PKM.ability IsNot "" Then
            Trainer_Ability.SelectedItem = PKM.ability
        Else
            Trainer_Ability.SelectedItem = "---NONE---"
        End If
        Select Case PKM.gender
            Case "F"
                Trainer_Female.Checked = True
            Case "M"
                Trainer_male.Checked = True
            Case Else
                Trainer_Random.Checked = True
        End Select
        If PKM.form IsNot Nothing And PKM.form IsNot "" Then
            Trainer_Form.Text = PKM.form
        Else
            Trainer_Form.Clear()
        End If
        If PKM.shininess IsNot Nothing And PKM.shininess IsNot "" Then
            Trainer_Shiny.Checked = True
        Else
            Trainer_Shiny.Checked = False
        End If
        If PKM.shadowPokemon IsNot Nothing And PKM.shadowPokemon IsNot "" Then
            Trainer_Shadow.Checked = True
        Else
            Trainer_Shadow.Checked = False
        End If
        If PKM.nature IsNot Nothing And PKM.nature IsNot "" Then
            Trainer_Nature.Text = PKM.nature
        Else
            Trainer_Nature.Clear()
        End If
        If PKM.ivs IsNot Nothing And PKM.ivs IsNot "" Then
            Trainer_Ivs.Value = PKM.ivs
        Else
            Trainer_Ivs.Value = 0
        End If
        If PKM.happiness IsNot Nothing And PKM.happiness IsNot "" Then
            Trainer_Happiness.Value = PKM.happiness
        Else
            Trainer_Happiness.Value = 0
        End If
        If PKM.nickname IsNot Nothing And PKM.nickname IsNot "" Then
            Trainer_Nickname.Text = PKM.nickname
        Else
            Trainer_Nickname.Clear()
        End If
        If PKM.ballType IsNot Nothing And PKM.ballType IsNot "" Then
            Trainer_Ball.Value = PKM.ballType
        Else
            Trainer_Ball.Value = -1
        End If
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        Dim dlg As New OpenFileDialog
        dlg.Filter = ".rxproj|*.rxproj"
        dlg.Multiselect = False
        If dlg.ShowDialog = DialogResult.OK Then
            Project = New ProjectClass.project
            Project.Load(dlg.FileName)
            CheckForIllegalCrossThreadCalls = False
            Me.Enabled = False
            StatusLabel.Visible = True
            ProgressBarCurrent.Visible = True
            ProgressBarTotal.Visible = True
            WorkerLoadProject.RunWorkerAsync()
        End If
    End Sub

    Private Sub WorkerLoadProject_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles WorkerLoadProject.DoWork
        StatusLabel.Text = "Loading Abilties {}"
        ProgressBarTotal.Value = 0
        ProgressBarCurrent.Value = 0
#Region "Vars"
#Region "Items"
        Dim strItems() As String
        Dim ItemsCount As Integer
        Dim FileExistItems As Boolean = File.Exists(Project.ItemsFile)
        If FileExistItems = True Then
            strItems = File.ReadAllLines(Project.ItemsFile)
            ItemsCount = strItems.Count
        End If
#End Region
#Region "Moves"
        Dim strMoves() As String
        Dim MovesCount As Integer
        Dim FileExistMoves As Boolean = File.Exists(Project.MovesFile)
        If FileExistMoves = True Then
            strMoves = File.ReadAllLines(Project.MovesFile)
            MovesCount = strMoves.Count
        End If
#End Region
#Region "Pokemon"
        Dim strPokemons As String
        Dim PokemonCount As Integer
        Dim FileExistPokemon As Boolean = File.Exists(Project.PokemonsFile)
        If FileExistPokemon = True Then
            strPokemons = File.ReadAllText(Project.PokemonsFile)
            PokemonCount = strPokemons.Split({"#-------------------------------"}, StringSplitOptions.RemoveEmptyEntries).Count
        End If
#End Region
#Region "Trainers"
        Dim strTrainers As String
        Dim TrainersCount As Integer
        Dim FileExistTrainers As Boolean = File.Exists(Project.TrainersFile)
        If FileExistTrainers = True Then
            strTrainers = File.ReadAllText(Project.TrainersFile)
            TrainersCount = strTrainers.Split({"#-------------------------------"}, StringSplitOptions.RemoveEmptyEntries).Count
        End If
#End Region
#Region "TrainerTypes"
        Dim strTrainerTypes() As String
        Dim TrainerTypesCount As Integer
        Dim FileExistTrainerTypes As Boolean = File.Exists(Project.TrainerTypesFile)
        If FileExistTrainerTypes = True Then
            strTrainerTypes = File.ReadAllLines(Project.TrainerTypesFile)
            TrainerTypesCount = strTrainerTypes.Count - 2
        End If
#End Region
        ProgressBarTotal.Maximum = ItemsCount + MovesCount + PokemonCount + TrainersCount + TrainerTypesCount
#End Region




#Region "Items"
        If FileExistItems = True Then
            ProgressBarCurrent.Value = 0
            ProgressBarCurrent.Maximum = ItemsCount
            For Each line In strItems
                Project.Items.Add(ItemsClass.getItem(line))
                ProgressBarCurrent.Value += 1
                ProgressBarTotal.Value += 1
                StatusLabel.Text = String.Format("Loading Items :  {0} / {1}", ProgressBarCurrent.Value, ItemsCount)

            Next
        End If
#End Region

#Region "Moves"
        If FileExistMoves = True Then
            ProgressBarCurrent.Value = 0
            ProgressBarCurrent.Maximum = MovesCount
            For Each line In strMoves
                Project.Moves.Add(MovesClass.getMove(line))
                ProgressBarCurrent.Value += 1
                ProgressBarTotal.Value += 1
                StatusLabel.Text = String.Format("Loading Moves : {0} / {1}", ProgressBarCurrent.Value, MovesCount)
            Next
        End If
#End Region

#Region "Pokemon"
        If FileExistPokemon = True Then
            ProgressBarCurrent.Value = 0
            ProgressBarCurrent.Maximum = PokemonCount
            For Each content In strPokemons.Split({"#-------------------------------"}, StringSplitOptions.RemoveEmptyEntries)
                Project.Pokemon.Add(PokemonClass.getPokemon(content))
                ProgressBarCurrent.Value += 1
                ProgressBarTotal.Value += 1
                StatusLabel.Text = String.Format("Loading Pokemon : {0} / {1}", ProgressBarCurrent.Value, PokemonCount)
            Next
        End If
#End Region

#Region "Trainers"
        If FileExistTrainers = True Then
            ProgressBarCurrent.Value = 0
            ProgressBarCurrent.Maximum = TrainersCount
            For Each content In strTrainers.Split({"#-------------------------------"}, StringSplitOptions.RemoveEmptyEntries)
                If content.Contains("documentation") Then

                Else
                    Project.Trainers.Add(TrainersClass.getTrainer(content))
                    ProgressBarCurrent.Value += 1
                    ProgressBarTotal.Value += 1
                    StatusLabel.Text = String.Format("Loading Trainers : {0} / {1}", ProgressBarCurrent.Value, TrainersCount)
                End If
            Next
        End If
#End Region

#Region "TrainerTypes"
        If FileExistTrainerTypes = True Then
            ProgressBarCurrent.Value = 0
            ProgressBarCurrent.Maximum = TrainerTypesCount
            Dim aaaaa = strTrainerTypes.Count - 1
            For i As Integer = 2 To strTrainerTypes.Count - 1
                Project.TrainerTypes.Add(TrainersTypesClass.getTrainerType(strTrainerTypes(i)))
                ProgressBarCurrent.Value += 1
                ProgressBarTotal.Value += 1
                StatusLabel.Text = String.Format("Loading Trainer Types : {0} / {1}", ProgressBarCurrent.Value, TrainerTypesCount)
            Next
        End If
#End Region

    End Sub
    Private Sub workerDone() Handles WorkerLoadProject.RunWorkerCompleted
        Me.Enabled = True
        ProgressBarCurrent.Visible = False
        ProgressBarTotal.Visible = False
        StatusLabel.Text = String.Format("Items loaded : {0} - Moves loaded : {1} - Pokemon loaded : {2} - Trainer loaed {3} - Trainer Types loaded : {4}", Project.Items.Count, Project.Moves.Count, Project.Pokemon.Count, Project.Trainers.Count, Project.TrainerTypes.Count)
        loadTrainerTypes()
        loadMoves()
        loadSpeices()
        loadAllTrainers()
        BtnProjectSave.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Trainers_List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Trainers_List.SelectedIndexChanged
        If Trainers_List.SelectedIndex >= 0 Then
            loadSingleTrainer()
        End If
    End Sub

    Private Sub Trainer_Pokemon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Trainer_Pokemon.SelectedIndexChanged
        If Trainers_List.SelectedIndex >= 0 Then
            Select Case Trainer_Pokemon.SelectedIndex
                Case 0
                    loadSignlePokemon(Project.Trainers(Trainers_List.SelectedIndex).pokemon1)
                Case 1
                    loadSignlePokemon(Project.Trainers(Trainers_List.SelectedIndex).pokemon2)
                Case 2
                    loadSignlePokemon(Project.Trainers(Trainers_List.SelectedIndex).pokemon3)
                Case 3
                    loadSignlePokemon(Project.Trainers(Trainers_List.SelectedIndex).pokemon4)
                Case 4
                    loadSignlePokemon(Project.Trainers(Trainers_List.SelectedIndex).pokemon5)
                Case 5
                    loadSignlePokemon(Project.Trainers(Trainers_List.SelectedIndex).pokemon6)
            End Select
        End If
    End Sub
End Class
