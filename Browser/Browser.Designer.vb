<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Browser
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browser))
        Me.SearchPanel = New System.Windows.Forms.Panel()
        Me.BtnNewTab = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.LinkText = New System.Windows.Forms.TextBox()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnState = New System.Windows.Forms.Button()
        Me.BtnForward = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSetHome = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MainBrowser = New System.Windows.Forms.WebBrowser()
        Me.NewTabTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnDeleteTab = New System.Windows.Forms.Button()
        Me.DeleteTabTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SearchPanel.SuspendLayout()
        Me.MenuPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchPanel
        '
        Me.SearchPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.SearchPanel.Controls.Add(Me.BtnDeleteTab)
        Me.SearchPanel.Controls.Add(Me.BtnNewTab)
        Me.SearchPanel.Controls.Add(Me.BtnMenu)
        Me.SearchPanel.Controls.Add(Me.LinkText)
        Me.SearchPanel.Controls.Add(Me.BtnHome)
        Me.SearchPanel.Controls.Add(Me.BtnState)
        Me.SearchPanel.Controls.Add(Me.BtnForward)
        Me.SearchPanel.Controls.Add(Me.BtnBack)
        Me.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchPanel.Location = New System.Drawing.Point(0, 0)
        Me.SearchPanel.Name = "SearchPanel"
        Me.SearchPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.SearchPanel.Size = New System.Drawing.Size(1181, 45)
        Me.SearchPanel.TabIndex = 0
        '
        'BtnNewTab
        '
        Me.BtnNewTab.BackgroundImage = Global.Browser.My.Resources.Resources.Browser_New_Tab
        Me.BtnNewTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNewTab.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnNewTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnNewTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BtnNewTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewTab.Location = New System.Drawing.Point(166, 9)
        Me.BtnNewTab.Name = "BtnNewTab"
        Me.BtnNewTab.Size = New System.Drawing.Size(24, 24)
        Me.BtnNewTab.TabIndex = 6
        Me.NewTabTip.SetToolTip(Me.BtnNewTab, "Creates a new tab")
        Me.BtnNewTab.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMenu.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnMenu.BackgroundImage = Global.Browser.My.Resources.Resources.Browser_Menu
        Me.BtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMenu.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenu.Location = New System.Drawing.Point(1143, 5)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(30, 30)
        Me.BtnMenu.TabIndex = 5
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'LinkText
        '
        Me.LinkText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkText.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkText.Location = New System.Drawing.Point(195, 8)
        Me.LinkText.Name = "LinkText"
        Me.LinkText.Size = New System.Drawing.Size(873, 26)
        Me.LinkText.TabIndex = 4
        '
        'BtnHome
        '
        Me.BtnHome.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnHome.BackgroundImage = Global.Browser.My.Resources.Resources.Browser_Home
        Me.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHome.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Location = New System.Drawing.Point(129, 6)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(30, 30)
        Me.BtnHome.TabIndex = 3
        Me.BtnHome.UseVisualStyleBackColor = False
        '
        'BtnState
        '
        Me.BtnState.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnState.BackgroundImage = Global.Browser.My.Resources.Resources.Browser_Refresh
        Me.BtnState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnState.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnState.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnState.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnState.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BtnState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnState.Location = New System.Drawing.Point(89, 8)
        Me.BtnState.Name = "BtnState"
        Me.BtnState.Size = New System.Drawing.Size(26, 26)
        Me.BtnState.TabIndex = 2
        Me.BtnState.UseVisualStyleBackColor = False
        '
        'BtnForward
        '
        Me.BtnForward.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnForward.BackgroundImage = Global.Browser.My.Resources.Resources.Browser_Forward
        Me.BtnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnForward.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnForward.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BtnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnForward.Location = New System.Drawing.Point(46, 3)
        Me.BtnForward.Name = "BtnForward"
        Me.BtnForward.Size = New System.Drawing.Size(36, 36)
        Me.BtnForward.TabIndex = 1
        Me.BtnForward.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnBack.BackgroundImage = Global.Browser.My.Resources.Resources.Browser_Back
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Location = New System.Drawing.Point(3, 3)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(36, 36)
        Me.BtnBack.TabIndex = 0
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'MenuPanel
        '
        Me.MenuPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuPanel.Controls.Add(Me.PictureBox1)
        Me.MenuPanel.Controls.Add(Me.BtnSetHome)
        Me.MenuPanel.Location = New System.Drawing.Point(1026, 42)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(155, 369)
        Me.MenuPanel.TabIndex = 6
        Me.MenuPanel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Browser.My.Resources.Resources.Browser_Home
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(116, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BtnSetHome
        '
        Me.BtnSetHome.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnSetHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSetHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSetHome.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnSetHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnSetHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BtnSetHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSetHome.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetHome.Location = New System.Drawing.Point(3, 9)
        Me.BtnSetHome.Name = "BtnSetHome"
        Me.BtnSetHome.Size = New System.Drawing.Size(109, 35)
        Me.BtnSetHome.TabIndex = 6
        Me.BtnSetHome.Text = "Set Home"
        Me.BtnSetHome.UseVisualStyleBackColor = False
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 45)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1181, 568)
        Me.TabControl.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MainBrowser)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1173, 536)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Title"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MainBrowser
        '
        Me.MainBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainBrowser.Location = New System.Drawing.Point(3, 3)
        Me.MainBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.MainBrowser.Name = "MainBrowser"
        Me.MainBrowser.Size = New System.Drawing.Size(1167, 530)
        Me.MainBrowser.TabIndex = 15
        Me.MainBrowser.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        '
        'NewTabTip
        '
        Me.NewTabTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NewTabTip.ToolTipTitle = "New Tab"
        '
        'BtnDeleteTab
        '
        Me.BtnDeleteTab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDeleteTab.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnDeleteTab.BackgroundImage = Global.Browser.My.Resources.Resources.Browser_Stop_Load
        Me.BtnDeleteTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDeleteTab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeleteTab.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnDeleteTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnDeleteTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.BtnDeleteTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteTab.Location = New System.Drawing.Point(1074, 8)
        Me.BtnDeleteTab.Name = "BtnDeleteTab"
        Me.BtnDeleteTab.Size = New System.Drawing.Size(26, 26)
        Me.BtnDeleteTab.TabIndex = 7
        Me.DeleteTabTip.SetToolTip(Me.BtnDeleteTab, "Delete currently selected tab")
        Me.BtnDeleteTab.UseVisualStyleBackColor = False
        '
        'DeleteTabTip
        '
        Me.DeleteTabTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.DeleteTabTip.ToolTipTitle = "Delete Tab"
        '
        'Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 613)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.SearchPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Browser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Browser 0.2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SearchPanel.ResumeLayout(False)
        Me.SearchPanel.PerformLayout()
        Me.MenuPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SearchPanel As Panel
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnForward As Button
    Friend WithEvents BtnState As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents LinkText As TextBox
    Friend WithEvents BtnMenu As Button
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnSetHome As Button
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents MainBrowser As WebBrowser
    Friend WithEvents BtnNewTab As Button
    Friend WithEvents NewTabTip As ToolTip
    Friend WithEvents BtnDeleteTab As Button
    Friend WithEvents DeleteTabTip As ToolTip
End Class
