Imports System.Data.SqlClient
Imports System.IO
Public Class CustFun
    Public Shared con As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=POS;User ID=HSSS; Password=0698211;")
    Public Shared cmd As SqlCommand
    Public Shared dr As SqlDataReader
    Public Shared ColCID, ColCNIC, ColContact As Int64
    Public Shared ColName, ColEmail, ColAddress As String

    Public Shared Function DGV_CustLoad()
        Customers.DGV_Customers.Rows.Clear()
        Try
            If Customers.RB_By_CID.Checked = True And Customers.TB_DGV_Filter.Text <> "" Then
                cmd = New SqlCommand("SELECT * FROM CUSTOMERS WHERE CUST_ID LIKE '%" & Customers.TB_DGV_Filter.Text & "' " _
                                     & "AND STATUS = 'Active' ORDER BY CUST_ID ASC", con)
                Customers.DGV_Customers.Columns(0).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf Customers.RB_By_Name.Checked = True And Customers.TB_DGV_Filter.Text <> "" Then
                cmd = New SqlCommand("SELECT * FROM CUSTOMERS WHERE NAME LIKE '%" & Customers.TB_DGV_Filter.Text & "%' " _
                                     & "AND STATUS = 'Active' ORDER BY NAME ASC", con)
                Customers.DGV_Customers.Columns(1).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf Customers.RB_By_CNIC.Checked = True And Customers.TB_DGV_Filter.Text <> "" Then
                cmd = New SqlCommand("SELECT * FROM CUSTOMERS WHERE CNIC LIKE '" & Customers.TB_DGV_Filter.Text & "%' " _
                                     & "AND STATUS = 'Active' ORDER BY CNIC ASC", con)
                Customers.DGV_Customers.Columns(2).DefaultCellStyle.BackColor = Color.LightGreen
            Else
                cmd = New SqlCommand("SELECT * FROM CUSTOMERS WHERE STATUS = 'Active' ORDER BY CUST_ID DESC", con)
                Customers.DGV_Customers.Columns(0).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window)
                Customers.DGV_Customers.Columns(1).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window)
                Customers.DGV_Customers.Columns(2).DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window)
            End If
            If con.State = ConnectionState.Closed Then con.Open()
            Using dr = cmd.ExecuteReader
                While dr.Read
                    ColCID = dr.Item("Cust_ID")
                    ColName = dr.Item("Name")
                    ColCNIC = dr.Item("CNIC")
                    ColContact = dr.Item("Contact_No")
                    ColEmail = dr.Item("Email")
                    ColAddress = dr.Item("Address")
                    Dim DGV_Ro As String()
                    DGV_Ro = New String() {ColCID, ColName, ColCNIC, ColContact, ColEmail, ColAddress}
                    Customers.DGV_Customers.Rows.Add(DGV_Ro)
                    Customers.DGV_Update.Text = "Update"
                    Customers.DGV_Update.UseColumnTextForButtonValue = True
                    Customers.DGV_Del.Text = "Delete"
                    Customers.DGV_Del.UseColumnTextForButtonValue = True
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
        Return Nothing
    End Function
    Public Shared Function TxtBoxChek()
        Dim TBCheck As String = 0
        If Customers.TB_Name.Text = "" Then
            MessageBox.Show("Please enter ""Name"".", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBCheck = 1
        ElseIf Customers.TB_CNIC.Text = "" Then
            MessageBox.Show("Please enter ""Customer CNIC No"".", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBCheck = 2
        End If
        Return TBCheck
    End Function

    Public Shared Function CustomerID()
        Dim Val As String
        Using cmd = New SqlCommand("select Cust_ID from Customers where Cust_ID = (Select MAX(Cust_ID) from Customers)", con)
            If con.State = ConnectionState.Closed Then con.Open()
            Using dr = cmd.ExecuteReader()
                If dr.HasRows = False Then
                    Val = 0
                    Customers.TB_CID.Text = Val + 1
                ElseIf dr.Read Then
                    Val = dr.Item("Cust_ID")
                    Customers.TB_CID.Text = Val + 1
                End If
            End Using
        End Using
        Return Nothing
    End Function

    Public Shared Function CustomerLoad(UD_ID As Int64)
        Dim Nation As String = ""
        Using cmd = New SqlCommand("select * from Customers where Cust_ID = '" & UD_ID & "'", con)
            If con.State = ConnectionState.Closed Then con.Open()
            Using dr = cmd.ExecuteReader()
                If dr.Read Then
                    Customers.TB_CID.Text = dr("Cust_ID")
                    Customers.TB_Name.Text = dr("Name")
                    Customers.TB_CNIC.Text = dr("CNIC")
                    Customers.TB_Contact.Text = dr("Contact_No")
                    Customers.TB_Email.Text = dr("Email")
                    Customers.TB_PC.Text = dr("Postal_Code")
                    Customers.TB_Address.Text = dr("Address")
                    Customers.RTB_Comnts.Text = dr("Comments")
                    Nation = dr("Country")
                    Customers.ChkB_Tax.Checked = dr("Taxable")
                    Customers.ChkB_Credit.Checked = dr("Creditor")
                    Dim data As Byte() = DirectCast(dr("Picture"), Byte())
                    Dim ms As New MemoryStream(data)
                    Customers.PictureBox.Image = Image.FromStream(ms)
                End If
                If Nation.Trim = "Pakistani" Then
                    Customers.TB_Nationality.Text = Nation
                    Customers.RB_Nat_Pak.PerformClick()
                ElseIf Nation.Trim <> "Pakistani" Then
                    Customers.RB_Nat_Othr.Checked = True
                    Customers.TB_Nationality.Text = Nation
                End If
            End Using
        End Using
        Return Nothing
    End Function
End Class
