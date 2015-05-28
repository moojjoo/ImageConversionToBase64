Imports System.IO

Public Class Form1

    Private Sub BtnOpenFileDirectory_Click(sender As Object, e As EventArgs) Handles BtnOpenFileDirectory.Click
        Dim dialog As New OpenFileDialog()

        If DialogResult.OK = dialog.ShowDialog Then
            TxtSelectFile.Text = dialog.FileName
        End If
    End Sub


    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        'Dim fileName As String
        Dim base64String As String


        If TxtSelectFile.Text.Substring(TxtSelectFile.Text.Length - 3).ToLower() = "gif" Then
            base64String = ImageToBase64(Image.FromFile(TxtSelectFile.Text), Imaging.ImageFormat.Gif)
        ElseIf TxtSelectFile.Text.Substring(TxtSelectFile.Text.Length - 3).ToLower() = "peg" Then
            base64String = ImageToBase64(Image.FromFile(TxtSelectFile.Text), Imaging.ImageFormat.Jpeg)
        Else 'Has to be a .png file than....
            base64String = ImageToBase64(Image.FromFile(TxtSelectFile.Text), Imaging.ImageFormat.Png)
        End If


        TxtBaseConversion.Text = base64String
    End Sub


    Public Function ImageToBase64(image As Image, format As Imaging.ImageFormat) As String
        Using ms As New MemoryStream()
            ' Convert Image to byte[]
            image.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray()

            ' Convert byte[] to Base64 String
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function


    Private Sub BtnCopyToClipBoard_Click(sender As Object, e As EventArgs) Handles BtnCopyToClipBoard.Click
        If TxtBaseConversion.Text.Length > 0 Then
            ' Copy the selected text to the Clipboard.
            TxtBaseConversion.Copy()
        End If
    End Sub
End Class
