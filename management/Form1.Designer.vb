<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnAddNew = New Button()
        BtnReset = New Button()
        BtnUpdate = New Button()
        BtnPrint = New Button()
        BtnDelete = New Button()
        BtnExit = New Button()
        TxtSearch = New TextBox()
        TxtCourse = New TextBox()
        TxtAge = New TextBox()
        TxtLname = New TextBox()
        TxtFname = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        BtnConn = New Button()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnAddNew
        ' 
        BtnAddNew.Location = New Point(453, 212)
        BtnAddNew.Name = "BtnAddNew"
        BtnAddNew.Size = New Size(94, 29)
        BtnAddNew.TabIndex = 0
        BtnAddNew.Text = "AddNew"
        BtnAddNew.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Location = New Point(600, 212)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(94, 29)
        BtnReset.TabIndex = 1
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(453, 283)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(94, 29)
        BtnUpdate.TabIndex = 2
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnPrint
        ' 
        BtnPrint.Location = New Point(600, 283)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Size = New Size(94, 29)
        BtnPrint.TabIndex = 3
        BtnPrint.Text = "Print"
        BtnPrint.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(453, 350)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(94, 29)
        BtnDelete.TabIndex = 4
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(600, 350)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(94, 29)
        BtnExit.TabIndex = 5
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' TxtSearch
        ' 
        TxtSearch.Location = New Point(520, 96)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.Size = New Size(174, 27)
        TxtSearch.TabIndex = 6
        ' 
        ' TxtCourse
        ' 
        TxtCourse.Location = New Point(161, 350)
        TxtCourse.Name = "TxtCourse"
        TxtCourse.Size = New Size(174, 27)
        TxtCourse.TabIndex = 8
        ' 
        ' TxtAge
        ' 
        TxtAge.Location = New Point(161, 253)
        TxtAge.Name = "TxtAge"
        TxtAge.Size = New Size(174, 27)
        TxtAge.TabIndex = 9
        ' 
        ' TxtLname
        ' 
        TxtLname.Location = New Point(161, 170)
        TxtLname.Name = "TxtLname"
        TxtLname.Size = New Size(174, 27)
        TxtLname.TabIndex = 10
        ' 
        ' TxtFname
        ' 
        TxtFname.Location = New Point(161, 96)
        TxtFname.Name = "TxtFname"
        TxtFname.Size = New Size(174, 27)
        TxtFname.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(37, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 25)
        Label1.TabIndex = 12
        Label1.Text = "First Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(37, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 25)
        Label2.TabIndex = 13
        Label2.Text = "Last Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(37, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 25)
        Label3.TabIndex = 14
        Label3.Text = "Age:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(37, 349)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 25)
        Label4.TabIndex = 15
        Label4.Text = "Course:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(427, 96)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 25)
        Label5.TabIndex = 16
        Label5.Text = "Search:"
        ' 
        ' BtnConn
        ' 
        BtnConn.Location = New Point(227, 399)
        BtnConn.Name = "BtnConn"
        BtnConn.Size = New Size(274, 29)
        BtnConn.TabIndex = 17
        BtnConn.Text = "Test Connection"
        BtnConn.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(37, 460)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(657, 188)
        DataGridView1.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(749, 95)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 19
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(930, 698)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(BtnConn)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TxtFname)
        Controls.Add(TxtLname)
        Controls.Add(TxtAge)
        Controls.Add(TxtCourse)
        Controls.Add(TxtSearch)
        Controls.Add(BtnExit)
        Controls.Add(BtnDelete)
        Controls.Add(BtnPrint)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnReset)
        Controls.Add(BtnAddNew)
        Name = "Form1"
        Text = "Student Management System"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnAddNew As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents TxtCourse As TextBox
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents TxtLname As TextBox
    Friend WithEvents TxtFname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnConn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
