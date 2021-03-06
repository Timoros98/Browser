﻿Public Class Browser

    Dim StopImage As Image = My.Resources.Browser_Stop_Load
    Dim RefreshImage As Image = My.Resources.Browser_Refresh
    Dim page As New TabPage("Google")
    Dim wb As New WebBrowser()


    Private Sub MainBrowser_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles MainBrowser.Navigated
        LinkText.Text = MainBrowser.Url.ToString
        BtnState.BackgroundImage = My.Resources.Browser_Refresh
        Me.TabControl.SelectedTab.Text = MainBrowser.DocumentTitle
        If CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle.Length > 10 Then
            TabControl.SelectedTab.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle.Substring(0, 9) & "..."
        Else
            TabControl.SelectedTab.Text = CType(TabControl.SelectedTab.Controls.Item(0), WebBrowser).DocumentTitle
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        MainBrowser.GoBack()
        MenuPanel.Visible = False
        wb.GoBack()
    End Sub

    Private Sub BtnForward_Click(sender As Object, e As EventArgs) Handles BtnForward.Click
        MainBrowser.GoForward()
        MenuPanel.Visible = False
        wb.GoForward()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click

        MenuPanel.Visible = False
        If TabControl.SelectedIndex = 0 Then
            MainBrowser.Navigate(My.Settings.Homepage)
        Else
            wb.Navigate(My.Settings.Homepage)
        End If
    End Sub

    Private Sub LinkText_KeyDown(sender As Object, e As KeyEventArgs) Handles LinkText.KeyDown
        If e.KeyCode = Keys.Enter Then
            MainBrowser.Navigate(LinkText.Text)
        End If
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        If MenuPanel.Visible = False Then
            MenuPanel.Visible = True
        Else
            MenuPanel.Visible = False
        End If
    End Sub

    Private Sub LinkText_MouseClick(sender As Object, e As MouseEventArgs) Handles LinkText.MouseClick
        MenuPanel.Visible = False
    End Sub

    Private Sub MainBrowser_GotFocus(sender As Object, e As EventArgs) Handles MainBrowser.GotFocus
        MenuPanel.Visible = False
    End Sub

    Private Sub BtnSetHome_Click(sender As Object, e As EventArgs) Handles BtnSetHome.Click
        If LinkText.Text = "" Then
            MessageBox.Show("Please add a url to set as home!", "Warning!")
        Else
            My.Settings.Homepage = LinkText.Text
            My.Settings.Save()
            MessageBox.Show("Your homepage " + My.Settings.Homepage + " has been set up successfully!", "Success!")
        End If
    End Sub

    Private Sub MainBrowser_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles MainBrowser.Navigating
        BtnState.BackgroundImage = My.Resources.Browser_Stop_Load
    End Sub

    Private Sub BtnState_Click(sender As Object, e As EventArgs) Handles BtnState.Click
        If My.Settings.State = 0 Then
            MainBrowser.Stop()
            wb.Stop()
        Else
            MainBrowser.Refresh()
            wb.Refresh()
        End If
    End Sub

    Private Sub BtnState_BackgroundImageChanged(sender As Object, e As EventArgs) Handles BtnState.BackgroundImageChanged
        If BtnState.BackgroundImage.Equals(StopImage) Then
            My.Settings.State = 0
        Else
            My.Settings.State = 1
        End If
    End Sub

    Private Sub Browser_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", "Browser.exe", Nothing) Is Nothing Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", "Browser.exe", "11001", Microsoft.Win32.RegistryValueKind.DWord)
            MessageBox.Show("Because is the first time that you opening this application you have to restart it to ensure everything is ok with some registry values! Thank you!", "Restart!")
            Me.Close()
        Else

        End If
    End Sub

    Private Sub BtnNewTab_Click(sender As Object, e As EventArgs) Handles BtnNewTab.Click
        Me.TabControl.TabPages.Add(page)
        page.Controls.Add(wb)
        wb.Dock = DockStyle.Fill
        wb.Navigate(New Uri("http://www.google.com"))
    End Sub

    Private Sub BtnDeleteTab_Click(sender As Object, e As EventArgs) Handles BtnDeleteTab.Click
        TabControl.TabPages.Remove(TabControl.SelectedTab)
    End Sub
End Class
