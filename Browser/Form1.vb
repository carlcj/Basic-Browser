Public Class Form1

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.GoForward()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Refresh()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.GoBack()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebBrowser1.GoHome()

    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        Label2.Text = WebBrowser1.StatusText

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Label1.Text = WebBrowser1.DocumentTitle
        TextBox1.Text = WebBrowser1.Url.ToString


    End Sub
End Class
