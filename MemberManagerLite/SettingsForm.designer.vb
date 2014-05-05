<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.btnBrowseForFile = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNewConnString = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOldString = New System.Windows.Forms.TextBox()
        Me.lblCurrentString = New System.Windows.Forms.Label()
        Me.lblNewString = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.ofdDBLocation = New System.Windows.Forms.OpenFileDialog()
        Me.gpxChangeLogo = New System.Windows.Forms.GroupBox()
        Me.pbxCurrentLogo = New System.Windows.Forms.PictureBox()
        Me.btnFindNewLogo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ofdFindLogo = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpxChangeLogo.SuspendLayout()
        CType(Me.pbxCurrentLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(334, 476)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 34)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(78, 26)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(88, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 26)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "New Location:"
        '
        'txtLocation
        '
        Me.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocation.Location = New System.Drawing.Point(178, 96)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(234, 23)
        Me.txtLocation.TabIndex = 2
        '
        'btnBrowseForFile
        '
        Me.btnBrowseForFile.Location = New System.Drawing.Point(415, 96)
        Me.btnBrowseForFile.Name = "btnBrowseForFile"
        Me.btnBrowseForFile.Size = New System.Drawing.Size(78, 23)
        Me.btnBrowseForFile.TabIndex = 3
        Me.btnBrowseForFile.Text = "Browse..."
        Me.btnBrowseForFile.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnBrowseForFile)
        Me.GroupBox1.Controls.Add(Me.txtNewConnString)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtOldString)
        Me.GroupBox1.Controls.Add(Me.lblCurrentString)
        Me.GroupBox1.Controls.Add(Me.lblNewString)
        Me.GroupBox1.Controls.Add(Me.btnGenerate)
        Me.GroupBox1.Controls.Add(Me.txtLocation)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 259)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change Connection String"
        '
        'txtNewConnString
        '
        Me.txtNewConnString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewConnString.Location = New System.Drawing.Point(178, 184)
        Me.txtNewConnString.Multiline = True
        Me.txtNewConnString.Name = "txtNewConnString"
        Me.txtNewConnString.ReadOnly = True
        Me.txtNewConnString.Size = New System.Drawing.Size(315, 52)
        Me.txtNewConnString.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "New Connection String:"
        '
        'txtOldString
        '
        Me.txtOldString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOldString.Location = New System.Drawing.Point(178, 31)
        Me.txtOldString.Multiline = True
        Me.txtOldString.Name = "txtOldString"
        Me.txtOldString.ReadOnly = True
        Me.txtOldString.Size = New System.Drawing.Size(315, 52)
        Me.txtOldString.TabIndex = 9
        '
        'lblCurrentString
        '
        Me.lblCurrentString.AutoSize = True
        Me.lblCurrentString.Location = New System.Drawing.Point(23, 31)
        Me.lblCurrentString.Name = "lblCurrentString"
        Me.lblCurrentString.Size = New System.Drawing.Size(149, 15)
        Me.lblCurrentString.TabIndex = 8
        Me.lblCurrentString.Text = "Current Connection String:"
        '
        'lblNewString
        '
        Me.lblNewString.AutoSize = True
        Me.lblNewString.Location = New System.Drawing.Point(178, 175)
        Me.lblNewString.Name = "lblNewString"
        Me.lblNewString.Size = New System.Drawing.Size(0, 15)
        Me.lblNewString.TabIndex = 7
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(178, 127)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(125, 33)
        Me.btnGenerate.TabIndex = 6
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'gpxChangeLogo
        '
        Me.gpxChangeLogo.BackColor = System.Drawing.Color.Transparent
        Me.gpxChangeLogo.Controls.Add(Me.pbxCurrentLogo)
        Me.gpxChangeLogo.Controls.Add(Me.btnFindNewLogo)
        Me.gpxChangeLogo.Controls.Add(Me.Label3)
        Me.gpxChangeLogo.Controls.Add(Me.Label4)
        Me.gpxChangeLogo.Controls.Add(Me.TextBox1)
        Me.gpxChangeLogo.Location = New System.Drawing.Point(12, 272)
        Me.gpxChangeLogo.Name = "gpxChangeLogo"
        Me.gpxChangeLogo.Size = New System.Drawing.Size(500, 192)
        Me.gpxChangeLogo.TabIndex = 7
        Me.gpxChangeLogo.TabStop = False
        Me.gpxChangeLogo.Text = "Change Logo"
        '
        'pbxCurrentLogo
        '
        Me.pbxCurrentLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxCurrentLogo.DataBindings.Add(New System.Windows.Forms.Binding("ImageLocation", Global.MemberManagerLite.My.MySettings.Default, "LogoLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pbxCurrentLogo.ImageLocation = Global.MemberManagerLite.My.MySettings.Default.LogoLocation
        Me.pbxCurrentLogo.Location = New System.Drawing.Point(178, 19)
        Me.pbxCurrentLogo.Name = "pbxCurrentLogo"
        Me.pbxCurrentLogo.Size = New System.Drawing.Size(119, 114)
        Me.pbxCurrentLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxCurrentLogo.TabIndex = 9
        Me.pbxCurrentLogo.TabStop = False
        '
        'btnFindNewLogo
        '
        Me.btnFindNewLogo.Location = New System.Drawing.Point(414, 150)
        Me.btnFindNewLogo.Name = "btnFindNewLogo"
        Me.btnFindNewLogo.Size = New System.Drawing.Size(78, 23)
        Me.btnFindNewLogo.TabIndex = 3
        Me.btnFindNewLogo.Text = "Browse..."
        Me.btnFindNewLogo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Current Logo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "New Image:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(178, 150)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 23)
        Me.TextBox1.TabIndex = 2
        '
        'ofdFindLogo
        '
        Me.ofdFindLogo.FileName = "OpenFileDialog1"
        '
        'SettingsForm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MemberManagerLite.My.Resources.Resources.tiny_grid
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(519, 519)
        Me.Controls.Add(Me.gpxChangeLogo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Member Manager Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpxChangeLogo.ResumeLayout(False)
        Me.gpxChangeLogo.PerformLayout()
        CType(Me.pbxCurrentLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseForFile As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNewString As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents lblCurrentString As System.Windows.Forms.Label
    Friend WithEvents txtOldString As System.Windows.Forms.TextBox
    Friend WithEvents ofdDBLocation As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtNewConnString As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gpxChangeLogo As System.Windows.Forms.GroupBox
    Friend WithEvents ofdFindLogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnFindNewLogo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents pbxCurrentLogo As System.Windows.Forms.PictureBox

End Class
