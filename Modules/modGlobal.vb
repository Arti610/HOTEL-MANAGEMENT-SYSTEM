'---------------------------------------
'Programmed by: Jomar I. Pabuaya
'Website: http://visualbasicproject.blogspot.com
'---------------------------------------

Option Strict Off
Option Explicit On

Imports System.Data.OleDb

Module modGlobal
    Public Structure Customer
        Dim Lastname As String
        Dim Firstname As String
        Dim Company As String
    End Structure

    'Variable structure for user
    Public Structure USER_INFO
        Dim USER_PK As Integer
        Dim USER_NAME As String
        Dim USER_ISADMIN As Boolean
    End Structure

    'Enumerator for form state
    Public Enum FormState
        adStateAddMode = 0
        adStateEditMode = 1
        adStatePopupMode = 2
        adStateViewMode = 3
    End Enum

    Public Structure BUSINESS_INFO
        Dim BUSINESS_NAME As String
        Dim BUSINESS_ADDRESS As String
        Dim BUSINESS_CONTACT_INFO As String
    End Structure
End Module
