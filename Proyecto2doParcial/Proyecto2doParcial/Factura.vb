﻿Public Class Factura
    Private _numFactura As Integer
    Property NumFactura() As Integer
        Get
            Return _numFactura
        End Get
        Set(value As Integer)
            _numFactura = value
        End Set
    End Property
    Private _fechaEmision As String
    Property FechaEmision As String
        Get
            Return _fechaEmision
        End Get
        Set(value As String)
            _fechaEmision = value
        End Set
    End Property
    Private _razonSocial As String
    Property RazonSocial() As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            _razonSocial = value
        End Set
    End Property
    Private _ruc As String
    Property Ruc() As String
        Get
            Return _ruc
        End Get
        Set(value As String)
            _ruc = value
        End Set
    End Property

    Public Sub New(numFactura As Integer, fechaEmision As String, razonSocial As String, ruc As String)

        Me._numFactura = numFactura
        Me._fechaEmision = fechaEmision
        Me._razonSocial = razonSocial
        Me._ruc = ruc
        'arreglo productos

    End Sub
End Class
