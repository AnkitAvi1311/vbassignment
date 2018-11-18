Public Class Form1
    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MyappDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyappDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.MyappDataSet.user)

    End Sub
End Class
