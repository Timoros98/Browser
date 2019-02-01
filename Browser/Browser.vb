Public Class Browser
    Dim StopImage As Image = My.Resources.Browser_Stop_Load
    Dim RefreshImage As Image = My.Resources.Browser_Refresh

    Private Sub MainBrowser_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles MainBrowser.Navigated
        LinkText.Text = MainBrowser.Url.ToString
        BtnState.BackgroundImage = My.Resources.Browser_Refresh
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        MainBrowser.GoBack()
        MenuPanel.Visible = False
    End Sub

    Private Sub BtnForward_Click(sender As Object, e As EventArgs) Handles BtnForward.Click
        MainBrowser.GoForward()
        MenuPanel.Visible = False
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        MainBrowser.Navigate(My.Settings.Homepage)
        MenuPanel.Visible = False
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
            MessageBox.Show("Your homepage has been set up successfully!", "Success!")
        End If
    End Sub

    Private Sub MainBrowser_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles MainBrowser.Navigating
        BtnState.BackgroundImage = My.Resources.Browser_Stop_Load
    End Sub

    Private Sub BtnState_Click(sender As Object, e As EventArgs) Handles BtnState.Click
        If My.Settings.State = 0 Then
            MainBrowser.Stop()
        Else
            MainBrowser.Refresh()
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
End Class
