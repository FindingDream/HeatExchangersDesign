Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Design_CMTD_Click(sender As Object, e As EventArgs) Handles Button_Design_CMTD.Click
        Dim NewForm As New Form_Design_LMTD()
        NewForm.Show()
    End Sub

    Private Sub Button_Design_NTU_Click(sender As Object, e As EventArgs) Handles Button_Design_NTU.Click
        Dim Newform As New Form_Design_NTU()
        Newform.Show()
    End Sub

    Private Sub Button_Check_CMTD_Click(sender As Object, e As EventArgs) Handles Button_Check_CMTD.Click
        Dim NewForm As New Form_Check_LMTD()
        NewForm.Show()
    End Sub

    Private Sub Button_Check_NTU_Click(sender As Object, e As EventArgs) Handles Button_Check_NTU.Click
        Dim NewForm As New Form_Check_NTU()
        NewForm.Show()
    End Sub
End Class