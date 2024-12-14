Imports System.Diagnostics.Eventing.Reader

Imports System.Drawing
Imports System.Threading
Imports System.Runtime.InteropServices



Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result2 As DialogResult = MessageBox.Show("Istall? BLUEREDDIT CRACKED FREE PREMIUM APK EXE MOD 2030 NO VIRUS!!111!!1.",
                                                      "SETUP MODDED APK FREE",
                                                      MessageBoxButtons.YesNoCancel,
                                                      MessageBoxIcon.Question)
    End Sub

    Private Sub clickmuahahah(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        MessageBox.Show(":)")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Crack button
        If Not ProgressBar1.Value + ProgressBar1.Maximum / 10 > 100 Then

            ProgressBar1.Value += ProgressBar1.Maximum / 10
        Else
            If ProgressBar1.Value = 100 Then
                Button2.Enabled = True
            End If

            MessageBox.Show("Already racked :DDDDDD")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim index As Integer = 0
        Do While index <= 9
            ProgressBar2.Value += ProgressBar2.Maximum / 10
            index += 1
            Threading.Thread.Sleep(CInt(Int((1000 * Rnd()) + 1)))
        Loop
        Button2.Enabled = False
        RainbowScreen.StartRainbow()
        ScreenMelter.StartMelting()
        WindowTitleChanger.StartChangingTitle()
    End Sub

    Public Class WindowTitleChanger

        ' Import necessary Win32 functions
        <DllImport("user32.dll", CharSet:=CharSet.Ansi)>
        Private Shared Function SetWindowTextA(hWnd As IntPtr, lpString As String) As Boolean
        End Function

        <DllImport("user32.dll")>
        Private Shared Function GetForegroundWindow() As IntPtr
        End Function

        Private Shared isRunning As Boolean = False
        Private Shared rnd As New Random()

        Public Shared Sub StartChangingTitle()
            If isRunning Then Return
            isRunning = True
            Dim t As New Thread(AddressOf ChangeTitleThread)
            t.Start()
        End Sub

        Public Shared Sub StopChangingTitle()
            isRunning = False
        End Sub

        Private Shared Sub ChangeTitleThread()
            Try
                While isRunning
                    Dim titleChars(70) As Char ' Equivalent to CHAR local_9[0x46]; (+1 for null terminator)
                    For i As Integer = 0 To 69 ' Loop from 0 to 69 (inclusive)
                        Dim uVar1 As Integer = Environment.TickCount
                        Dim uVar3 As UInteger = CUInt(uVar1 Xor (uVar1 << 13))
                        uVar3 = uVar3 Xor (uVar3 << 17)
                        titleChars(i) = ChrW(CUInt((uVar3 Xor uVar3 >> 5) Mod 71) + 48) ' Mod 0x47 (71), +48 to make it printable
                    Next
                    Dim title As String = New String(titleChars, 0, 70)
                    Dim hWnd As IntPtr = GetForegroundWindow()
                    SetWindowTextA(hWnd, title)
                    Thread.Sleep(10)
                    If Not isRunning Then Exit While
                End While
            Catch ex As Exception
                'Handle exceptions such as the window closing.
            Finally
                'Any clean up if needed.
            End Try
        End Sub

        ' A more accurate replacement for rdtsc if needed (requires unsafe code)
        <DllImport("kernel32.dll")>
        Private Shared Function QueryPerformanceCounter(ByRef lpPerformanceCount As Long) As Boolean
        End Function

        <DllImport("kernel32.dll")>
        Private Shared Function QueryPerformanceFrequency(ByRef lpFrequency As Long) As Boolean
        End Function

        Private Shared Function GetPreciseTimestamp() As Long
            Dim counter As Long = 0
            QueryPerformanceCounter(counter)
            Return counter
        End Function
    End Class

    Public Class RainbowScreen

        ' Import necessary Win32 functions
        <DllImport("gdi32.dll")>
        Private Shared Function CreateSolidBrush(crColor As Integer) As IntPtr
        End Function

        <DllImport("gdi32.dll")>
        Private Shared Function SelectObject(hdc As IntPtr, hObject As IntPtr) As IntPtr
        End Function

        <DllImport("gdi32.dll")>
        Private Shared Function PatBlt(hdc As IntPtr, x As Integer, y As Integer, w As Integer, h As Integer, rop As UInteger) As Boolean
        End Function

        <DllImport("gdi32.dll")>
        Private Shared Function DeleteObject(hObject As IntPtr) As Boolean
        End Function

        <DllImport("user32.dll")>
        Private Shared Function GetDC(hWnd As IntPtr) As IntPtr
        End Function

        <DllImport("user32.dll")>
        Private Shared Function ReleaseDC(hWnd As IntPtr, hDC As IntPtr) As Integer
        End Function

        <DllImport("user32.dll")>
        Private Shared Function GetDesktopWindow() As IntPtr
        End Function


        Private Shared isRunning As Boolean = False
        Private Shared rnd As New Random()

        Public Shared Sub StartRainbow()
            If isRunning Then Return
            isRunning = True
            Dim t As New Thread(AddressOf RainbowThread)
            t.Start()
        End Sub

        Public Shared Sub StopRainbow()
            isRunning = False
        End Sub

        Private Shared Sub RainbowThread()
            Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim y As Integer = Screen.PrimaryScreen.Bounds.Height

            Dim desktopHandle As IntPtr = GetDesktopWindow()
            Dim hdc As IntPtr = GetDC(desktopHandle)

            Try
                While isRunning
                    ' Generate random RGB color
                    Dim r As Integer = rnd.Next(256) ' 0-255
                    Dim g As Integer = rnd.Next(256)
                    Dim b As Integer = rnd.Next(256)

                    ' Create COLORREF value
                    Dim colorRef As Integer = b * 65536 + g * 256 + r

                    Dim brush As IntPtr = CreateSolidBrush(colorRef)

                    If brush <> IntPtr.Zero Then ' Check if brush creation was successful
                        Dim oldBrush As IntPtr = SelectObject(hdc, brush)

                        PatBlt(hdc, 0, 0, x, y, &H5A0049) ' PATINVERT

                        SelectObject(hdc, oldBrush) ' Restore the old brush
                        DeleteObject(brush) ' Delete the created brush
                    End If

                    Thread.Sleep(rnd.Next(130, 331)) ' 130-330 (inclusive to match C++'s 130-329 range)
                    If Not isRunning Then Exit While 'Check if the thread should stop after the sleep.
                End While

            Finally
                ReleaseDC(desktopHandle, hdc)
            End Try
        End Sub
    End Class
    Public Class ScreenMelter

        ' Import necessary Win32 functions
        <DllImport("gdi32.dll")>
        Public Shared Function StretchBlt(hdcDest As IntPtr, nXOriginDest As Integer, nYOriginDest As Integer, nWidthDest As Integer, nHeightDest As Integer, hdcSrc As IntPtr, nXOriginSrc As Integer, nYOriginSrc As Integer, nWidthSrc As Integer, nHeightSrc As Integer, dwRop As UInteger) As Boolean
        End Function

        <DllImport("user32.dll")>
        Public Shared Function GetDC(hWnd As IntPtr) As IntPtr
        End Function

        <DllImport("user32.dll")>
        Public Shared Function ReleaseDC(hWnd As IntPtr, hDC As IntPtr) As Integer
        End Function

        <DllImport("user32.dll")>
        Public Shared Function GetDesktopWindow() As IntPtr
        End Function

        Private Shared Function BitBlt(hdcDest As IntPtr, nXDest As Integer, nYDest As Integer, nWidth As Integer, nHeight As Integer, hdcSrc As IntPtr, nXSrc As Integer, nYSrc As Integer, dwRop As UInteger) As Boolean
        End Function

        Private Shared isRunning As Boolean = False
        Private Shared rnd As New Random()

        Public Shared Sub StartMelting()
            If isRunning Then Return
            isRunning = True
            Dim t As New Thread(AddressOf MeltingThread)
            t.Start()
        End Sub

        Public Shared Sub StopMelting()
            isRunning = False
        End Sub

        Private Shared Sub MeltingThread()
            Dim x As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim y As Integer = Screen.PrimaryScreen.Bounds.Height

            Dim desktopHandle As IntPtr = GetDesktopWindow()
            Dim hdc As IntPtr = GetDC(desktopHandle)

            Try
                While isRunning
                    Dim xs As Integer = rnd.Next(x)
                    Dim ys As Integer = rnd.Next(y)
                    Dim sel As Integer = rnd.Next(1, 5) ' 1 to 4
                    Dim size As Integer = rnd.Next(200, 501) ' 200 to 500 (inclusive)
                    Dim rndVal As Integer = rnd.Next(30, 81) ' 30 to 80 (inclusive)

                    Select Case sel
                        Case 1
                            For i As Integer = 0 To rndVal Step 10
                                If Not isRunning Then Exit For
                                BitBlt(hdc, xs + i, ys + i, size, size, hdc, xs, ys, &HCC0020) 'SRCCOPY
                                Thread.Sleep(1)
                            Next
                        Case 2
                            For i As Integer = 0 To rndVal Step 10
                                If Not isRunning Then Exit For
                                BitBlt(hdc, xs + i, ys - i, size, size, hdc, xs, ys, &HCC0020) 'SRCCOPY
                                Thread.Sleep(1)
                            Next
                        Case 3
                            For i As Integer = 0 To rndVal Step 10
                                If Not isRunning Then Exit For
                                BitBlt(hdc, xs - i, ys + i, size, size, hdc, xs, ys, &HCC0020) 'SRCCOPY
                                Thread.Sleep(1)
                            Next
                        Case 4
                            For i As Integer = 0 To rndVal Step 10
                                If Not isRunning Then Exit For
                                BitBlt(hdc, xs - i, ys - i, size, size, hdc, xs, ys, &HCC0020) 'SRCCOPY
                                Thread.Sleep(1)
                            Next
                    End Select
                End While
            Finally
                ReleaseDC(desktopHandle, hdc)
            End Try
        End Sub
    End Class
End Class
