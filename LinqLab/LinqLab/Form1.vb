'Author: Ben Parsell
'Date: 3/29/2016
'Project: LinqLab

Option Strict On
Imports System.IO
Public Class LinqLab

    Dim studentsTextIn As New StreamReader(New FileStream("Students.txt", FileMode.OpenOrCreate, FileAccess.Read))
    Dim classListTextIn As New StreamReader(New FileStream("ClassList.txt", FileMode.OpenOrCreate, FileAccess.Read))

    Dim myStudentsList As New List(Of Students)
    Dim myClassList As New List(Of ClassList)

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Do While studentsTextIn.Peek <> -1
            Dim row As String = studentsTextIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            Dim myStudents As New Students
            myStudents.StudentID = columns(0)
            myStudents.FirstName = columns(1)
            myStudents.LastName = columns(2)
            myStudents.Major = columns(3)
            myStudentsList.Add(myStudents)
        Loop

        studentsTextIn.Close()

        Do While classListTextIn.Peek <> -1
            Dim row As String = classListTextIn.ReadLine
            Dim columns() As String = row.Split(CChar("|"))
            Dim myClassListObject As New ClassList
            myClassListObject.StuID = columns(0)
            myClassListObject.Dept = columns(1)
            myClassListObject.ClassNum = columns(2)
            myClassListObject.Credits = Convert.ToInt32(columns(3))
            myClassList.Add(myClassListObject)
        Loop

        studentsTextIn.Close()


        Dim students =
            From myStudents In myStudentsList Join classList In myClassList
                On myStudents.StudentID Equals classList.StuID
            Select classList.StuID, myStudents.LastName, myStudents.FirstName, classList.Dept, classList.ClassNum, classList.Credits

        Dim creditTotals As Integer
        Dim i As Integer = 0
        Dim studentID As String = ""
        Dim myFirstName As String = ""
        Dim myLastName As String = ""
        For Each myStudents In students
            If myStudents.StuID <> studentID Then
                lsvLinq.Items.Add(myStudents.StuID)
                studentID = myStudents.StuID
            Else
                lsvLinq.Items.Add("")
            End If
            lsvLinq.Items(i).SubItems.Add(myStudents.LastName)
            lsvLinq.Items(i).SubItems.Add(myStudents.FirstName)
            lsvLinq.Items(i).SubItems.Add(myStudents.Dept)
            lsvLinq.Items(i).SubItems.Add(myStudents.ClassNum)
            lsvLinq.Items(i).SubItems.Add(Convert.ToString(myStudents.Credits))
            i += 1
        Next



    End Sub
End Class
