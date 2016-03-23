Imports System.IO
Public Class frmGenerador
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub btnSeleccion_Click(sender As Object, e As EventArgs) Handles btnSeleccion.Click
        If ofdSeleccion.ShowDialog() = DialogResult.OK Then
            txtSeleccion.Text = ofdSeleccion.FileName
        End If
    End Sub
    Private Sub btnCarpeta_Click(sender As Object, e As EventArgs) Handles btnCarpeta.Click
        If fbdCarpeta.ShowDialog = DialogResult.OK Then
            txtCarpeta.Text = fbdCarpeta.SelectedPath
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If Not txtCarpeta.Text = String.Empty And Not txtSeleccion.Text = String.Empty Then
            Dim Name As String = Path.GetFileNameWithoutExtension(txtSeleccion.Text)
            Dim ArrayName As String() = Name.Split("_")
            If ArrayName.Length = 5 Then
                Try
                    Dim Año As Integer = Integer.Parse(ArrayName(1))
                    Dim Extension As String = Path.GetExtension(txtSeleccion.Text)
                    For i As Integer = 0 To Integer.Parse(nudNumero.Value)
                        Dim Nombre2 As String = Name.Replace(Año.ToString, (Año + i).ToString())
                        My.Computer.FileSystem.CopyFile(txtSeleccion.Text, txtCarpeta.Text & "/" & Nombre2 & Extension, True)
                    Next
                    MessageBox.Show("Archivos copiados correctamente.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Else
                MessageBox.Show("Nombre de archivo inválido.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Debes seleccionar un archivo a copiar y una dirección de destino.", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub
End Class
