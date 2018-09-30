Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = String.Format("Easy Trainer Editor Version : {0} . {1} by JamPaul97 2018
Project build : {2}.{3}
Pokemon Logo, Pokémon, Pokémon character names, Nintendo 3DS, Nintendo DS, Wii, Wii U, and Wiiware are trademarks of Nintendo.
Pee.dll Version : {4} - By JamPaul97
Pee.dll is personal coded and may not be used by other applications/users without the consent of its creator.
PEETE code may not be used/replacted/copies by any other user(s)/application(s).
All icons used in program was found on : http://icons8.com

", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision, PEE.ProjectClass.pVersion)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class