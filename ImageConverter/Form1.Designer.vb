<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.TxtSelectFile = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnOpenFileDirectory = New System.Windows.Forms.Button()
        Me.TxtBaseConversion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCopyToClipBoard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(12, 126)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(183, 23)
        Me.BtnConvert.TabIndex = 0
        Me.BtnConvert.Text = "Convert to Base64"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'TxtSelectFile
        '
        Me.TxtSelectFile.Location = New System.Drawing.Point(12, 40)
        Me.TxtSelectFile.Name = "TxtSelectFile"
        Me.TxtSelectFile.Size = New System.Drawing.Size(350, 20)
        Me.TxtSelectFile.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnOpenFileDirectory
        '
        Me.BtnOpenFileDirectory.Location = New System.Drawing.Point(13, 66)
        Me.BtnOpenFileDirectory.Name = "BtnOpenFileDirectory"
        Me.BtnOpenFileDirectory.Size = New System.Drawing.Size(183, 23)
        Me.BtnOpenFileDirectory.TabIndex = 2
        Me.BtnOpenFileDirectory.Text = "Open File Directory"
        Me.BtnOpenFileDirectory.UseVisualStyleBackColor = True
        '
        'TxtBaseConversion
        '
        Me.TxtBaseConversion.Location = New System.Drawing.Point(13, 181)
        Me.TxtBaseConversion.Multiline = True
        Me.TxtBaseConversion.Name = "TxtBaseConversion"
        Me.TxtBaseConversion.Size = New System.Drawing.Size(736, 283)
        Me.TxtBaseConversion.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Step 1: Select the file"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Step 2: Convert to Base 64"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Step 3: Copy to clipboard"
        '
        'BtnCopyToClipBoard
        '
        Me.BtnCopyToClipBoard.Location = New System.Drawing.Point(13, 470)
        Me.BtnCopyToClipBoard.Name = "BtnCopyToClipBoard"
        Me.BtnCopyToClipBoard.Size = New System.Drawing.Size(182, 23)
        Me.BtnCopyToClipBoard.TabIndex = 7
        Me.BtnCopyToClipBoard.Text = "Copy to Clipboard"
        Me.BtnCopyToClipBoard.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 572)
        Me.Controls.Add(Me.BtnCopyToClipBoard)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBaseConversion)
        Me.Controls.Add(Me.BtnOpenFileDirectory)
        Me.Controls.Add(Me.TxtSelectFile)
        Me.Controls.Add(Me.BtnConvert)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Image Converter to Base64"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnConvert As System.Windows.Forms.Button
    Friend WithEvents TxtSelectFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnOpenFileDirectory As System.Windows.Forms.Button
    Friend WithEvents TxtBaseConversion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCopyToClipBoard As System.Windows.Forms.Button

End Class
