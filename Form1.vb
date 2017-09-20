Imports System
Imports System.ServiceProcess
Imports System.Diagnostics
Imports System.IO
Imports System.Collections

Public Class SCSM

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnservicios.Click
        'https://msdn.microsoft.com/es-es/library/system.serviceprocess.servicecontroller(v=vs.110).aspx

        Dim service As ServiceController = New ServiceController("HealthService")
        Try
            If ((service.Status.Equals(ServiceControllerStatus.Stopped)) Or
                        (service.Status.Equals(ServiceControllerStatus.StopPending))) Then
                service.Start()
                MsgBox(service.Status)
            Else
                service.Stop()
                MsgBox(service.Status)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub btnrenombrar_Click(sender As Object, e As EventArgs) Handles btnrenombrar.Click
        'https://msdn.microsoft.com/es-es/library/45we914z(v=vs.100).aspx
        'Dim directorioold1 As String = "D:\1"
        'Dim directorioold2 As String = "E:\1"
        'Dim directorionew As String = "2"

        Dim directorioold1 As String = "D:\Program Files\Microsoft System Center 2012 R2\Service Manager\Health Service State"
        Dim directorioold2 As String = "E:\Program Files\Microsoft System Center 2012 R2\Service Manager\Health Service State"
        Dim directorionew As String = "Health Service State1"
        Try
            If Directory.Exists(directorioold1) Then
                My.Computer.FileSystem.RenameDirectory(directorioold1, directorionew)
                MsgBox("Archivo renombrado" & directorionew)
            Else
                If Directory.Exists(directorioold2) Then
                    My.Computer.FileSystem.RenameDirectory(directorioold2, directorionew)
                    MsgBox("Archivo renombrado" & directorionew)
                Else
                    MsgBox("Rutas no existen: " & vbNewLine & directorioold1 & vbNewLine & directorioold2)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        'https://msdn.microsoft.com/es-es/library/24t911bf(v=vs.100).aspx
        Dim eliminar1 As String = "D:\Program Files\Microsoft System Center 2012 R2\Service Manager\Health Service State1"
        Dim eliminar2 As String = "E:\Program Files\Microsoft System Center 2012 R2\Service Manager\Health Service State1"
        Try
            If Directory.Exists(eliminar1) Then
                My.Computer.FileSystem.DeleteDirectory(eliminar1, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                MsgBox("Archivo borrado" & eliminar2)
            Else
                If Directory.Exists(eliminar2) Then
                    My.Computer.FileSystem.DeleteDirectory(eliminar2, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin)
                    MsgBox("Archivo borrado" & eliminar2)
                Else
                    MsgBox("Rutas no existen: " & vbNewLine & eliminar1 & vbNewLine & eliminar2)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'https://msdn.microsoft.com/es-es/library/system.serviceprocess.servicecontroller(v=vs.110).aspx
        Dim service As ServiceController = New ServiceController("OMSDK")
        Try
            If ((service.Status.Equals(ServiceControllerStatus.Stopped)) Or
            (service.Status.Equals(ServiceControllerStatus.StopPending))) Then
                service.Start()
                MsgBox(service.Status)
            Else
                service.Stop()
                MsgBox(service.Status)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'https://msdn.microsoft.com/es-es/library/system.serviceprocess.servicecontroller(v=vs.110).aspx
        Dim service As ServiceController = New ServiceController("OMCFG")
        Try
            If ((service.Status.Equals(ServiceControllerStatus.Stopped)) Or
                (service.Status.Equals(ServiceControllerStatus.StopPending))) Then
                service.Start()
                MsgBox(service.Status)
            Else
                service.Stop()
                MsgBox(service.Status)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
