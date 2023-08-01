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
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(520, 96)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(174, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(161, 350)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(174, 27)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(161, 253)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(174, 27)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(161, 170)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(174, 27)
        TextBox5.TabIndex = 10
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(161, 96)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(174, 27)
        TextBox6.TabIndex = 11
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(BtnExit)
        Controls.Add(BtnDelete)
        Controls.Add(BtnPrint)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnReset)
        Controls.Add(BtnAddNew)
        Name = "Form1"
        Text = "Student Management System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnAddNew As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
