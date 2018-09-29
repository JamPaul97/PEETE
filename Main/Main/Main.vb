Imports PEE
Imports System.IO
Public Class Main
    Dim Project As New ProjectClass.project

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
                Me.Refresh()
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
                Me.Refresh()
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
                Me.Refresh()
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
                    Me.Refresh()
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
                Me.Refresh()
            Next
        End If
#End Region

    End Sub
    Private Sub workerDone() Handles WorkerLoadProject.RunWorkerCompleted
        Me.Enabled = True
        ProgressBarCurrent.Visible = False
        ProgressBarTotal.Visible = False
        StatusLabel.Text = String.Format("Items loaded : {0} - Moves loaded : {1} - Pokemon loaded : {2} - Trainer loaed {3} - Trainer Types loaded : {4}", Project.Items.Count, Project.Moves.Count, Project.Pokemon.Count, Project.Trainers.Count, Project.TrainerTypes.Count)
        Trainers_List.Items.Clear()
        For Each item In Project.Trainers
            Trainers_List.Items.Add(item.name)
        Next
        BtnProjectSave.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
