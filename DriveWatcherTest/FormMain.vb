' ****************************************************************************************************************
' FormMain.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Public Class FormMain

    Private Sub DriveAdded(sender As Object, e As SchlumpfSoft.Controls.DriveWatcherControl.DriveAddedEventArgs) Handles _
        DriveWatcher1.DriveAdded

        Me.Label_result.Text = $"Das Laufwerk {e.DriveName} wurde hinzugefügt.{vbCrLf}" &
            $"Der Datenträger hat die Bezeichnung {e.VolumeLabel} und ist vom Typ {e.DriveType}.{vbCrLf}" &
            $"Das Format ist {e.DriveFormat} und der gesamte Speicherplatz beträgt {e.TotalSize} Bytes.{vbCrLf}"

        If e.IsReady Then

            Me.Label_result.Text &= $"Das Laufwerk ist bereit und der freie Speicherplatz beträgt {e.TotalFreeSpace} Bytes."

        Else

            Me.Label_result.Text &= $"Das Laufwerk ist nicht bereit"

        End If

    End Sub

    Private Sub DriveRemoved(sender As Object, e As SchlumpfSoft.Controls.DriveWatcherControl.DriveRemovedEventArgs) Handles _
        DriveWatcher1.DriveRemoved

        Me.Label_result.Text = $"Das Laufwerk {e.DriveName} wurde entfernt."

    End Sub

End Class
