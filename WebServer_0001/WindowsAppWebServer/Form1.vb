Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1

    Shared uri As String = "http://jsonplaceholder.typicode.com"

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If Not String.IsNullOrEmpty(txtBox_cep.Text) Then
            Dim unused = GetAllInfo(txtBox_cep.Text)
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim lineOk As String = Nothing
        lineOk += If(String.IsNullOrEmpty(txtBoxUserId.Text), vbLf & "Please, enter the User Id", Nothing)
        lineOk += If(String.IsNullOrEmpty(txtBoxTitle.Text), vbLf & "Please, enter the Title", Nothing)
        lineOk += If(String.IsNullOrEmpty(txtBoxBoby.Text), vbLf & "Please, enter the Body", Nothing)

        If lineOk IsNot Nothing AndAlso lineOk <> "" Then
            MessageBox.Show(lineOk)
        Else
            Dim unused = sendRequest(New Post(Convert.ToInt32(txtBoxUserId.Text), txtBoxTitle.Text, txtBoxBoby.Text))
        End If
    End Sub

    Public Async Function GetAllInfo(ByVal id As String) As Task
        Dim url As String = String.Format(uri & "/posts/{0}", id)
        Dim req = WebRequest.CreateHttp(url)
        req.Method = "GET"
        req.UserAgent = "url"

        Using response = req.GetResponse()
            Dim strDates As Stream = response.GetResponseStream()
            Dim strReader As StreamReader = New StreamReader(strDates)
            Dim objResponse As Object = strReader.ReadToEnd()
            Dim post As Post = JsonConvert.DeserializeObject(Of Post)(objResponse.ToString())
            txtBoxResponse.Text = objResponse.ToString()
            strReader.Close()
            response.Close()
        End Using
    End Function

    Public Async Function sendRequest(ByVal post As Post) As Task
        Dim param As String = String.Format("title={0}&body={1}&userId={2}", post.title, post.body, post.userId)
        Dim dt = Encoding.UTF8.GetBytes(param)
        Dim url As String = uri & "/posts/"
        Dim req = WebRequest.CreateHttp(url)
        req.ContentType = "application/x-www-form-urlencoded"
        req.ContentLength = dt.Length
        req.Method = "POST"
        req.UserAgent = "url"

        Try

            Using stream = req.GetRequestStream()
                stream.Write(dt, 0, dt.Length)
                stream.Close()
            End Using

            Using response = req.GetResponse()
                Dim strDates As Stream = response.GetResponseStream()
                Dim strReader As StreamReader = New StreamReader(strDates)
                Dim objResponse As Object = strReader.ReadToEnd()
                Dim pst = JsonConvert.DeserializeObject(Of Post)(objResponse.ToString())
                txtBoxResponse.Text = objResponse.ToString()
                strDates.Close()
                response.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Function
End Class
