Imports System.Data.SqlClient
Imports System.IO
Public Class Customers
    Public Shared con As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=POS;User ID=HSSS; Password=0698211;")
    Public Shared cmd As SqlCommand
    Public Shared dr As SqlDataReader
    Public Shared ColCID, ColCNIC, ColContact As Int64
    Public Shared ColName, ColEmail, ColAddress As String
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Utype As String = MainForm.TSSL_RollType.Text
        If Utype = "User" Or Utype = "user" Then DGV_Customers.Columns(1).Visible = False
        CustFun.CustomerID()
        CustFun.DGV_CustLoad()
        If RB_Nat_Pak.Checked = True Then RB_Nat_Pak_CheckedChanged(sender, e)
    End Sub
    Private Sub TB_CNIC_Leave(sender As Object, e As EventArgs) Handles TB_CNIC.Leave
        Dim CheckCCNIC As String = ""
        If Btn_Add.Text = "Add" Then
            cmd = New SqlCommand("Select Cust_ID from Customers where CNIC = '" & TB_CNIC.Text.Trim() & "'", con)
        ElseIf Btn_Add.Text = "Update" Then
            cmd = New SqlCommand("Select Cust_ID from Customers where CNIC = '" & TB_CNIC.Text.Trim() & "' and Cust_ID <> '" & TB_CID.Text.Trim() & "'", con)
        End If
        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
        Using dr = cmd.ExecuteReader()
            If dr.HasRows Then
                If dr.Read Then
                    CheckCCNIC = dr("Cust_ID")
                    MessageBox.Show("This CNIC No is already assigned to Customer ID : " + CheckCCNIC, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End If
        End Using
    End Sub
    Private Sub TB_Nationality_Enter(sender As Object, e As EventArgs) Handles TB_Nationality.Enter
        If TB_Nationality.Text = "Nationality" Then
            TB_Nationality.Text = ""
            TB_Nationality.ForeColor = Color.FromKnownColor(KnownColor.WindowText)
        End If
    End Sub
    Private Sub TB_Nationality_Leave(sender As Object, e As EventArgs) Handles TB_Nationality.Leave
        If TB_Nationality.Text = "" Then
            TB_Nationality.Text = "Nationality"
            TB_Nationality.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub RB_Nat_Pak_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Nat_Pak.CheckedChanged
        TB_Nationality.Enabled = False
        TB_Nationality.ReadOnly = True
        TB_Nationality.Text = "Pakistani"
        TB_Nationality.ForeColor = Color.FromKnownColor(KnownColor.WindowText)
    End Sub
    Private Sub RB_Nat_Othr_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Nat_Othr.CheckedChanged
        TB_Nationality.Enabled = True
        TB_Nationality.ReadOnly = False
        TB_Nationality.Text = ""
        TB_Nationality_Leave(sender, e)
    End Sub
    Private Sub TB_DGV_Filter_TextChanged(sender As Object, e As EventArgs) Handles TB_DGV_Filter.TextChanged
        CustFun.DGV_CustLoad()
    End Sub
    Private Sub Btn_Pic_Browse_Click(sender As Object, e As EventArgs) Handles Btn_Pic_Browse.Click
        Dim ImageDialogue As OpenFileDialog = New OpenFileDialog()
        ImageDialogue.Title = "Select your Image."
        ImageDialogue.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}"
        ImageDialogue.Filter = "Image Files|*.gif; *.jpg; *.png; *.bmp;"
        ImageDialogue.RestoreDirectory = False

        If ImageDialogue.ShowDialog() = DialogResult.OK Then
            PictureBox.Image = Image.FromFile(ImageDialogue.FileName)
        End If
    End Sub
    Private Sub RB_By_CID_CheckedChanged(sender As Object, e As EventArgs) Handles RB_By_CID.CheckedChanged
        TB_DGV_Filter.Text = ""
        DGV_Customers.Columns(1).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window)
        DGV_Customers.Columns(2).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window)
    End Sub
    Private Sub RB_By_Name_CheckedChanged(sender As Object, e As EventArgs) Handles RB_By_Name.CheckedChanged
        TB_DGV_Filter.Text = ""
        DGV_Customers.Columns(0).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window)
        DGV_Customers.Columns(2).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window)
    End Sub
    Private Sub RB_By_CNIC_CheckedChanged(sender As Object, e As EventArgs) Handles RB_By_CNIC.CheckedChanged
        TB_DGV_Filter.Text = ""
        DGV_Customers.Columns(0).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window)
        DGV_Customers.Columns(1).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window)
    End Sub
    Private Sub Btn_ClrAll_Click(sender As Object, e As EventArgs) Handles Btn_ClrAll.Click
        TB_CID.Text = ""
        TB_Name.Text = ""
        TB_CNIC.Text = ""
        TB_Contact.Text = ""
        TB_Email.Text = ""
        TB_PC.Text = ""
        TB_Address.Text = ""
        RTB_Comnts.Text = ""
        RB_Nat_Pak.Checked = True
        TB_Nationality.Text = ""
        RB_Nat_Pak_CheckedChanged(sender, e)
        ChkB_Tax.Checked = False
        ChkB_Credit.Checked = False
        If Btn_Add.Text = "Update" Then Btn_Add.Text = "Add"
        Customers_Load(sender, e)
    End Sub
    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Dim TxtChk As String = 0
        TxtChk = CustFun.TxtBoxChek()
        If TxtChk <> 0 Then
            If TxtChk = 1 Then
                TB_Name.Focus()
            ElseIf TxtChk = 2 Then
                TB_CNIC.Focus()
            End If
        ElseIf Btn_Add.Text = "Add" Then
            Try
                Using cmd = New SqlCommand("Insert into Customers (Name, CNIC, Contact_No, Email, Address, Postal_Code, " _
                      & "Country, Comments, Taxable, Creditor, Picture, Status) values ('" & TB_Name.Text.Trim & "', " _
                      & "'" & TB_CNIC.Text.Trim & "', '" & TB_Contact.Text.Trim & "', '" & TB_Email.Text.Trim & "', " _
                      & "'" & TB_Address.Text.Trim & "', '" & TB_PC.Text.Trim & "', '" & TB_Nationality.Text.Trim & "', " _
                      & "'" & RTB_Comnts.Text.ToString & "', '" & ChkB_Tax.CheckState & "', '" & ChkB_Credit.CheckState & "'," _
                      & " @Picture, '" & "Active" & "')", con)

                    Dim ms As New MemoryStream()
                    PictureBox.Image.Save(ms, PictureBox.Image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@Picture", SqlDbType.Image) With {
                        .Value = data
                    }
                    cmd.Parameters.Add(p)
                    If con.State = ConnectionState.Closed Then con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("New customer has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Btn_ClrAll.PerformClick()
                End Using
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message))
            End Try
        ElseIf Btn_Add.Text = "Update" Then
            Try

                Using cmd = New SqlCommand("Update Customers set Name = '" & TB_Name.Text.Trim & "', " _
                            & "CNIC = '" & TB_CNIC.Text.Trim & "', Contact_No = '" & TB_Contact.Text.Trim & "', " _
                            & "Email = '" & TB_Email.Text.Trim & "', Address = '" & TB_Address.Text.Trim & "', " _
                            & "Postal_Code = '" & TB_PC.Text.Trim & "', Country = '" & TB_Nationality.Text.Trim & "', " _
                            & "Comments = '" & RTB_Comnts.Text.ToString & "', Taxable = '" & ChkB_Tax.CheckState & "', " _
                            & "Creditor = '" & ChkB_Credit.CheckState & "', Picture = @Picture where Cust_ID " _
                            & "= '" & TB_CID.Text.Trim & "'", con)
                    Dim ms As New MemoryStream()
                    PictureBox.Image.Save(ms, PictureBox.Image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@Picture", SqlDbType.Image) With {
                        .Value = data
                    }
                    cmd.Parameters.Add(p)
                    If con.State = ConnectionState.Closed Then con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Customer has been Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Btn_ClrAll.PerformClick()
                End Using
            Catch ex As Exception
                MessageBox.Show(String.Format("Error : {0}", ex.Message))
            End Try
        End If
    End Sub

    '"""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~ Data Grid View Code ~~~~~~~~~~~~'
    '---------------------------------------------'
    Private Sub DGV_Customers_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Customers.CellClick
        Dim index As Integer = e.RowIndex
        Dim DelCusId As Int64 = 0
        Dim Result As DialogResult
        Try
            'Updating
            If e.ColumnIndex = 6 And e.RowIndex >= 0 Then
                If Me.DGV_Customers.Rows(index).Cells(0).Value <> "" Then
                    DelCusId = DGV_Customers.Rows(index).Cells(0).Value.ToString
                    Btn_Add.Text = "Update"
                    CustFun.CustomerLoad(DelCusId)
                End If
                'Deleting
            ElseIf e.ColumnIndex = 7 And e.RowIndex >= 0 Then
                If Me.DGV_Customers.Rows(index).Cells(0).Value <> "" Then
                    DelCusId = DGV_Customers.Rows(index).Cells(0).Value.ToString
                    Result = MessageBox.Show("You are about to Delete Customer ID = " & DelCusId & "." & Environment.NewLine & " Do you really want to delete it?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If Result = DialogResult.Yes Then
                        Try
                            Using cmd = New SqlCommand("Update Customers set Status = 'Deleted' where Cust_ID = '" & DelCusId & "'", con)
                                If con.State = ConnectionState.Closed Then con.Open()
                                cmd.ExecuteNonQuery()
                                MessageBox.Show("Customer has been Deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End Using
                        Catch ex As Exception
                            MessageBox.Show(String.Format("Error : {0}", ex.Message))
                        End Try
                        Customers_Load(sender, e)
                    Else
                        MessageBox.Show("Deletion has been canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error : {0}", ex.Message))
        End Try
    End Sub

End Class

