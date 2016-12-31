'Author: Ben Parsell
'Project: Homework 6
'Date: 4/4/2016

Option Strict On
Public Class SavedTransactions
    Private m_CustomerID As String
    Private m_TransactionNumber As Integer
    Private m_TransactionType As Char
    Private m_TransactionAmount As Decimal

    Public Sub New()

    End Sub

    Public Sub New(customerID As String, transactionNumber As Integer, transactionType As Char, transactionAmount As Decimal)
        Me.CustomerID = customerID
        Me.TransactionNumber = transactionNumber
        Me.TransactionType = transactionType
        Me.TransactionAmount = transactionAmount
    End Sub

    Public Property CustomerID As String
        Get
            Return m_CustomerID
        End Get
        Set(value As String)
            m_CustomerID = value
        End Set
    End Property

    Public Property TransactionNumber As Integer
        Get
            Return m_TransactionNumber
        End Get
        Set(value As Integer)
            m_TransactionNumber = value
        End Set
    End Property

    Public Property TransactionType As Char
        Get
            Return m_TransactionType
        End Get
        Set(value As Char)
            m_TransactionType = value
        End Set
    End Property

    Public Property TransactionAmount As Decimal
        Get
            Return m_TransactionAmount
        End Get
        Set(value As Decimal)
            m_TransactionAmount = value
        End Set
    End Property
End Class
