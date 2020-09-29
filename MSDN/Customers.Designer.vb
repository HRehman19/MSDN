<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RB_Nat_Othr = New System.Windows.Forms.RadioButton()
        Me.RB_Nat_Pak = New System.Windows.Forms.RadioButton()
        Me.TB_Nationality = New System.Windows.Forms.TextBox()
        Me.Lbl_Comments = New System.Windows.Forms.Label()
        Me.ChkB_Credit = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChkB_Tax = New System.Windows.Forms.CheckBox()
        Me.RTB_Comnts = New System.Windows.Forms.RichTextBox()
        Me.TB_Address = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Email = New System.Windows.Forms.Label()
        Me.TB_CID = New System.Windows.Forms.TextBox()
        Me.GB_ImgandBtns = New System.Windows.Forms.GroupBox()
        Me.Btn_Pic_Browse = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_ClrAll = New System.Windows.Forms.Button()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Lbl_FirstName = New System.Windows.Forms.Label()
        Me.Lbl_CID = New System.Windows.Forms.Label()
        Me.TB_DGV_Filter = New System.Windows.Forms.TextBox()
        Me.RB_By_CNIC = New System.Windows.Forms.RadioButton()
        Me.RB_By_Name = New System.Windows.Forms.RadioButton()
        Me.RB_By_CID = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_Del = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DGV_Update = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DGV_Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVG_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gb_CustomerInfo = New System.Windows.Forms.GroupBox()
        Me.TB_PC = New System.Windows.Forms.TextBox()
        Me.TB_Contact = New System.Windows.Forms.TextBox()
        Me.TB_Name = New System.Windows.Forms.TextBox()
        Me.TB_Email = New System.Windows.Forms.TextBox()
        Me.TB_CNIC = New System.Windows.Forms.TextBox()
        Me.DGV_Customers = New System.Windows.Forms.DataGridView()
        Me.GB_ImgandBtns.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Gb_CustomerInfo.SuspendLayout()
        CType(Me.DGV_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RB_Nat_Othr
        '
        Me.RB_Nat_Othr.AutoSize = True
        Me.RB_Nat_Othr.Location = New System.Drawing.Point(497, 148)
        Me.RB_Nat_Othr.Name = "RB_Nat_Othr"
        Me.RB_Nat_Othr.Size = New System.Drawing.Size(51, 17)
        Me.RB_Nat_Othr.TabIndex = 18
        Me.RB_Nat_Othr.Text = "Other"
        Me.RB_Nat_Othr.UseVisualStyleBackColor = True
        '
        'RB_Nat_Pak
        '
        Me.RB_Nat_Pak.AutoSize = True
        Me.RB_Nat_Pak.Checked = True
        Me.RB_Nat_Pak.Location = New System.Drawing.Point(423, 148)
        Me.RB_Nat_Pak.Name = "RB_Nat_Pak"
        Me.RB_Nat_Pak.Size = New System.Drawing.Size(68, 17)
        Me.RB_Nat_Pak.TabIndex = 17
        Me.RB_Nat_Pak.TabStop = True
        Me.RB_Nat_Pak.Text = "Pakistani"
        Me.RB_Nat_Pak.UseVisualStyleBackColor = True
        '
        'TB_Nationality
        '
        Me.TB_Nationality.ForeColor = System.Drawing.Color.Gray
        Me.TB_Nationality.Location = New System.Drawing.Point(554, 145)
        Me.TB_Nationality.Name = "TB_Nationality"
        Me.TB_Nationality.Size = New System.Drawing.Size(224, 20)
        Me.TB_Nationality.TabIndex = 19
        Me.TB_Nationality.Text = "Nationality"
        '
        'Lbl_Comments
        '
        Me.Lbl_Comments.AutoSize = True
        Me.Lbl_Comments.Location = New System.Drawing.Point(12, 158)
        Me.Lbl_Comments.Name = "Lbl_Comments"
        Me.Lbl_Comments.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_Comments.TabIndex = 15
        Me.Lbl_Comments.Text = "Comments :"
        '
        'ChkB_Credit
        '
        Me.ChkB_Credit.AutoSize = True
        Me.ChkB_Credit.Location = New System.Drawing.Point(697, 173)
        Me.ChkB_Credit.Name = "ChkB_Credit"
        Me.ChkB_Credit.Size = New System.Drawing.Size(81, 17)
        Me.ChkB_Credit.TabIndex = 21
        Me.ChkB_Credit.Text = "Allow Credit"
        Me.ChkB_Credit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(420, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Postal Code :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(12, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Customer CNIC No :"
        '
        'ChkB_Tax
        '
        Me.ChkB_Tax.AutoSize = True
        Me.ChkB_Tax.Location = New System.Drawing.Point(554, 174)
        Me.ChkB_Tax.Name = "ChkB_Tax"
        Me.ChkB_Tax.Size = New System.Drawing.Size(81, 17)
        Me.ChkB_Tax.TabIndex = 20
        Me.ChkB_Tax.Text = "Charge Tax"
        Me.ChkB_Tax.UseVisualStyleBackColor = True
        '
        'RTB_Comnts
        '
        Me.RTB_Comnts.Location = New System.Drawing.Point(123, 145)
        Me.RTB_Comnts.Name = "RTB_Comnts"
        Me.RTB_Comnts.Size = New System.Drawing.Size(250, 46)
        Me.RTB_Comnts.TabIndex = 16
        Me.RTB_Comnts.Text = ""
        '
        'TB_Address
        '
        Me.TB_Address.Location = New System.Drawing.Point(123, 119)
        Me.TB_Address.Name = "TB_Address"
        Me.TB_Address.Size = New System.Drawing.Size(655, 20)
        Me.TB_Address.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Address :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(420, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Contact No :"
        '
        'Lbl_Email
        '
        Me.Lbl_Email.AutoSize = True
        Me.Lbl_Email.Location = New System.Drawing.Point(12, 96)
        Me.Lbl_Email.Name = "Lbl_Email"
        Me.Lbl_Email.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_Email.TabIndex = 9
        Me.Lbl_Email.Text = "Email ID :"
        '
        'TB_CID
        '
        Me.TB_CID.Enabled = False
        Me.TB_CID.Location = New System.Drawing.Point(123, 41)
        Me.TB_CID.Name = "TB_CID"
        Me.TB_CID.ReadOnly = True
        Me.TB_CID.Size = New System.Drawing.Size(250, 20)
        Me.TB_CID.TabIndex = 2
        '
        'GB_ImgandBtns
        '
        Me.GB_ImgandBtns.Controls.Add(Me.Btn_Pic_Browse)
        Me.GB_ImgandBtns.Controls.Add(Me.PictureBox)
        Me.GB_ImgandBtns.Controls.Add(Me.Panel2)
        Me.GB_ImgandBtns.Location = New System.Drawing.Point(784, 0)
        Me.GB_ImgandBtns.Name = "GB_ImgandBtns"
        Me.GB_ImgandBtns.Size = New System.Drawing.Size(200, 197)
        Me.GB_ImgandBtns.TabIndex = 5
        Me.GB_ImgandBtns.TabStop = False
        Me.GB_ImgandBtns.Text = "Image"
        '
        'Btn_Pic_Browse
        '
        Me.Btn_Pic_Browse.Location = New System.Drawing.Point(103, 138)
        Me.Btn_Pic_Browse.Name = "Btn_Pic_Browse"
        Me.Btn_Pic_Browse.Size = New System.Drawing.Size(91, 23)
        Me.Btn_Pic_Browse.TabIndex = 0
        Me.Btn_Pic_Browse.Text = "Browse"
        Me.Btn_Pic_Browse.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.Location = New System.Drawing.Point(25, 20)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(150, 112)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 12
        Me.PictureBox.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_ClrAll)
        Me.Panel2.Controls.Add(Me.Btn_Add)
        Me.Panel2.Location = New System.Drawing.Point(3, 165)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(194, 29)
        Me.Panel2.TabIndex = 1
        '
        'Btn_ClrAll
        '
        Me.Btn_ClrAll.Location = New System.Drawing.Point(100, 3)
        Me.Btn_ClrAll.Name = "Btn_ClrAll"
        Me.Btn_ClrAll.Size = New System.Drawing.Size(91, 23)
        Me.Btn_ClrAll.TabIndex = 1
        Me.Btn_ClrAll.Text = "Clear All"
        Me.Btn_ClrAll.UseVisualStyleBackColor = True
        '
        'Btn_Add
        '
        Me.Btn_Add.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(91, 23)
        Me.Btn_Add.TabIndex = 0
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Lbl_FirstName
        '
        Me.Lbl_FirstName.AutoSize = True
        Me.Lbl_FirstName.ForeColor = System.Drawing.Color.Red
        Me.Lbl_FirstName.Location = New System.Drawing.Point(420, 44)
        Me.Lbl_FirstName.Name = "Lbl_FirstName"
        Me.Lbl_FirstName.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_FirstName.TabIndex = 3
        Me.Lbl_FirstName.Text = "Name :"
        '
        'Lbl_CID
        '
        Me.Lbl_CID.AutoSize = True
        Me.Lbl_CID.ForeColor = System.Drawing.Color.Red
        Me.Lbl_CID.Location = New System.Drawing.Point(12, 44)
        Me.Lbl_CID.Name = "Lbl_CID"
        Me.Lbl_CID.Size = New System.Drawing.Size(71, 13)
        Me.Lbl_CID.TabIndex = 1
        Me.Lbl_CID.Text = "Customer ID :"
        '
        'TB_DGV_Filter
        '
        Me.TB_DGV_Filter.Location = New System.Drawing.Point(528, 6)
        Me.TB_DGV_Filter.Name = "TB_DGV_Filter"
        Me.TB_DGV_Filter.Size = New System.Drawing.Size(250, 20)
        Me.TB_DGV_Filter.TabIndex = 3
        '
        'RB_By_CNIC
        '
        Me.RB_By_CNIC.AutoSize = True
        Me.RB_By_CNIC.Location = New System.Drawing.Point(421, 7)
        Me.RB_By_CNIC.Name = "RB_By_CNIC"
        Me.RB_By_CNIC.Size = New System.Drawing.Size(101, 17)
        Me.RB_By_CNIC.TabIndex = 2
        Me.RB_By_CNIC.TabStop = True
        Me.RB_By_CNIC.Text = "Search by CNIC"
        Me.RB_By_CNIC.UseVisualStyleBackColor = True
        '
        'RB_By_Name
        '
        Me.RB_By_Name.AutoSize = True
        Me.RB_By_Name.Location = New System.Drawing.Point(311, 7)
        Me.RB_By_Name.Name = "RB_By_Name"
        Me.RB_By_Name.Size = New System.Drawing.Size(104, 17)
        Me.RB_By_Name.TabIndex = 1
        Me.RB_By_Name.TabStop = True
        Me.RB_By_Name.Text = "Search by Name"
        Me.RB_By_Name.UseVisualStyleBackColor = True
        '
        'RB_By_CID
        '
        Me.RB_By_CID.AutoSize = True
        Me.RB_By_CID.Location = New System.Drawing.Point(171, 7)
        Me.RB_By_CID.Name = "RB_By_CID"
        Me.RB_By_CID.Size = New System.Drawing.Size(134, 17)
        Me.RB_By_CID.TabIndex = 0
        Me.RB_By_CID.TabStop = True
        Me.RB_By_CID.Text = "Search by Customer ID"
        Me.RB_By_CID.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(213, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Note: Fields that are written red are necessary for adding ""New Customer""."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TB_DGV_Filter)
        Me.Panel1.Controls.Add(Me.RB_By_CNIC)
        Me.Panel1.Controls.Add(Me.RB_By_Name)
        Me.Panel1.Controls.Add(Me.RB_By_CID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 197)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 31)
        Me.Panel1.TabIndex = 6
        '
        'DGV_Del
        '
        Me.DGV_Del.HeaderText = ""
        Me.DGV_Del.Name = "DGV_Del"
        Me.DGV_Del.Width = 70
        '
        'DGV_Update
        '
        Me.DGV_Update.HeaderText = ""
        Me.DGV_Update.Name = "DGV_Update"
        Me.DGV_Update.Width = 70
        '
        'DGV_Address
        '
        Me.DGV_Address.HeaderText = "Address"
        Me.DGV_Address.Name = "DGV_Address"
        Me.DGV_Address.Width = 180
        '
        'DGV_Email
        '
        Me.DGV_Email.HeaderText = "Email ID"
        Me.DGV_Email.Name = "DGV_Email"
        Me.DGV_Email.Width = 150
        '
        'DGV_Contact
        '
        Me.DGV_Contact.HeaderText = "Contact No"
        Me.DGV_Contact.Name = "DGV_Contact"
        Me.DGV_Contact.Width = 120
        '
        'DGV
        '
        Me.DGV.HeaderText = "CNIC"
        Me.DGV.Name = "DGV"
        Me.DGV.Width = 130
        '
        'DVG_Name
        '
        Me.DVG_Name.HeaderText = "Name"
        Me.DVG_Name.Name = "DVG_Name"
        Me.DVG_Name.Width = 130
        '
        'CID
        '
        Me.CID.HeaderText = "Customer ID"
        Me.CID.Name = "CID"
        Me.CID.Width = 88
        '
        'Gb_CustomerInfo
        '
        Me.Gb_CustomerInfo.Controls.Add(Me.TB_PC)
        Me.Gb_CustomerInfo.Controls.Add(Me.TB_Contact)
        Me.Gb_CustomerInfo.Controls.Add(Me.TB_Name)
        Me.Gb_CustomerInfo.Controls.Add(Me.TB_Email)
        Me.Gb_CustomerInfo.Controls.Add(Me.TB_CNIC)
        Me.Gb_CustomerInfo.Controls.Add(Me.RB_Nat_Othr)
        Me.Gb_CustomerInfo.Controls.Add(Me.RB_Nat_Pak)
        Me.Gb_CustomerInfo.Controls.Add(Me.TB_Nationality)
        Me.Gb_CustomerInfo.Controls.Add(Me.Lbl_Comments)
        Me.Gb_CustomerInfo.Controls.Add(Me.ChkB_Credit)
        Me.Gb_CustomerInfo.Controls.Add(Me.Label6)
        Me.Gb_CustomerInfo.Controls.Add(Me.Label5)
        Me.Gb_CustomerInfo.Controls.Add(Me.ChkB_Tax)
        Me.Gb_CustomerInfo.Controls.Add(Me.RTB_Comnts)
        Me.Gb_CustomerInfo.Controls.Add(Me.TB_Address)
        Me.Gb_CustomerInfo.Controls.Add(Me.Label3)
        Me.Gb_CustomerInfo.Controls.Add(Me.Label2)
        Me.Gb_CustomerInfo.Controls.Add(Me.Lbl_Email)
        Me.Gb_CustomerInfo.Controls.Add(Me.Lbl_FirstName)
        Me.Gb_CustomerInfo.Controls.Add(Me.Lbl_CID)
        Me.Gb_CustomerInfo.Controls.Add(Me.TB_CID)
        Me.Gb_CustomerInfo.Controls.Add(Me.Label1)
        Me.Gb_CustomerInfo.Location = New System.Drawing.Point(0, 0)
        Me.Gb_CustomerInfo.Name = "Gb_CustomerInfo"
        Me.Gb_CustomerInfo.Size = New System.Drawing.Size(784, 228)
        Me.Gb_CustomerInfo.TabIndex = 4
        Me.Gb_CustomerInfo.TabStop = False
        Me.Gb_CustomerInfo.Text = "Customer's Information"
        '
        'TB_PC
        '
        Me.TB_PC.Location = New System.Drawing.Point(528, 93)
        Me.TB_PC.Name = "TB_PC"
        Me.TB_PC.Size = New System.Drawing.Size(250, 20)
        Me.TB_PC.TabIndex = 26
        '
        'TB_Contact
        '
        Me.TB_Contact.Location = New System.Drawing.Point(528, 67)
        Me.TB_Contact.Name = "TB_Contact"
        Me.TB_Contact.Size = New System.Drawing.Size(250, 20)
        Me.TB_Contact.TabIndex = 25
        '
        'TB_Name
        '
        Me.TB_Name.Location = New System.Drawing.Point(528, 41)
        Me.TB_Name.Name = "TB_Name"
        Me.TB_Name.Size = New System.Drawing.Size(250, 20)
        Me.TB_Name.TabIndex = 24
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(123, 93)
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(250, 20)
        Me.TB_Email.TabIndex = 23
        '
        'TB_CNIC
        '
        Me.TB_CNIC.Location = New System.Drawing.Point(123, 67)
        Me.TB_CNIC.Name = "TB_CNIC"
        Me.TB_CNIC.Size = New System.Drawing.Size(250, 20)
        Me.TB_CNIC.TabIndex = 22
        '
        'DGV_Customers
        '
        Me.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Customers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CID, Me.DVG_Name, Me.DGV, Me.DGV_Contact, Me.DGV_Email, Me.DGV_Address, Me.DGV_Update, Me.DGV_Del})
        Me.DGV_Customers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_Customers.Location = New System.Drawing.Point(0, 228)
        Me.DGV_Customers.Name = "DGV_Customers"
        Me.DGV_Customers.Size = New System.Drawing.Size(984, 225)
        Me.DGV_Customers.TabIndex = 7
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 453)
        Me.Controls.Add(Me.GB_ImgandBtns)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Gb_CustomerInfo)
        Me.Controls.Add(Me.DGV_Customers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customers"
        Me.Text = "Customers"
        Me.GB_ImgandBtns.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Gb_CustomerInfo.ResumeLayout(False)
        Me.Gb_CustomerInfo.PerformLayout()
        CType(Me.DGV_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RB_Nat_Othr As RadioButton
    Friend WithEvents RB_Nat_Pak As RadioButton
    Friend WithEvents TB_Nationality As TextBox
    Friend WithEvents Lbl_Comments As Label
    Friend WithEvents ChkB_Credit As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ChkB_Tax As CheckBox
    Friend WithEvents RTB_Comnts As RichTextBox
    Friend WithEvents TB_Address As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_Email As Label
    Friend WithEvents TB_CID As TextBox
    Friend WithEvents GB_ImgandBtns As GroupBox
    Friend WithEvents Btn_Pic_Browse As Button
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_ClrAll As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Lbl_FirstName As Label
    Friend WithEvents Lbl_CID As Label
    Friend WithEvents TB_DGV_Filter As TextBox
    Friend WithEvents RB_By_CNIC As RadioButton
    Friend WithEvents RB_By_Name As RadioButton
    Friend WithEvents RB_By_CID As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGV_Del As DataGridViewButtonColumn
    Friend WithEvents DGV_Update As DataGridViewButtonColumn
    Friend WithEvents DGV_Address As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Email As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Contact As DataGridViewTextBoxColumn
    Friend WithEvents DGV As DataGridViewTextBoxColumn
    Friend WithEvents DVG_Name As DataGridViewTextBoxColumn
    Friend WithEvents CID As DataGridViewTextBoxColumn
    Friend WithEvents Gb_CustomerInfo As GroupBox
    Friend WithEvents DGV_Customers As DataGridView
    Friend WithEvents TB_PC As TextBox
    Friend WithEvents TB_Contact As TextBox
    Friend WithEvents TB_Name As TextBox
    Friend WithEvents TB_Email As TextBox
    Friend WithEvents TB_CNIC As TextBox
End Class
