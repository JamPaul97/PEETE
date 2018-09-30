Imports System.Windows.Forms

Public Class AddItem

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ComboBox1.SelectedIndex >= 0 Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("You have to  select an item.")
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()

        For Each item In Main.Project.Items
            ComboBox1.Items.Add(item.internalName)
        Next
    End Sub
End Class
