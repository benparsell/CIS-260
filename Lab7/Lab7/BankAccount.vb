'Author: Ben Parsell
'Project: Lab 7
'Date: 3/15/2016

Option Strict On
Public Class BankAccount
    Private m_Balance As Decimal
    Private m_InterestRate As Double
    Private m_Interest As Decimal
    Private m_Transactions As Integer

    Public Sub New()

    End Sub

    Public Sub New(balance As Decimal, interestRate As Double, interest As Decimal, transactions As Integer)
        Me.Balance = balance
        Me.InterestRate = interestRate
        Me.Interest = interest
        Me.Transactions = transactions
    End Sub

    Public Property Balance As Decimal
        Get
            Return m_Balance
        End Get
        Set(value As Decimal)
            m_Balance = value
        End Set
    End Property

    Public Property InterestRate As Double
        Get
            Return m_InterestRate
        End Get
        Set(value As Double)
            m_InterestRate = value
        End Set
    End Property

    Public Property Interest As Decimal
        Get
            Return m_Interest
        End Get
        Set(value As Decimal)
            m_Interest = value
        End Set
    End Property

    Public Property Transactions As Integer
        Get
            Return m_Transactions
        End Get
        Set(value As Integer)
            m_Transactions = value
        End Set
    End Property

    Public Sub Deposit(depositAmount As Decimal)
        If (depositAmount < 0) Then
            MsgBox("Deposit has to be positive.", , "Deposit Error")
        Else
            Balance += depositAmount
            Transactions += 1
        End If
    End Sub

    Public Sub Withdraw(withdrawAmount As Decimal)
        If (Balance < withdrawAmount) Then
            MsgBox("Withdraw Amount cannot exceed bank balance.", , "Withdraw Error")
        Else
            Balance -= withdrawAmount
            Transactions += 1
        End If
    End Sub

    Public Sub CalculateInterest()
        Interest = Convert.ToDecimal(Balance * InterestRate)
        Balance += Interest
        Transactions += 1
    End Sub
End Class
