Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TSMI_Customers_Click(sender As Object, e As EventArgs) Handles TSMI_Customers.Click
        TSB_Customers_Click(sender, e)
    End Sub

    Private Sub TSB_Customers_Click(sender As Object, e As EventArgs) Handles TSB_Customers.Click
        P_Container.Controls.Clear()
        Dim F_Cust As New Customers With {.TopLevel = False}
        P_Container.Controls.Add(F_Cust)
        F_Cust.Show()
    End Sub
End Class
