Public Class punto
    'Se instancian las variables private
    Private x, y As Integer

    'Se crean los constructores, valor por defecto y cogiendo resultados

    Public Sub New()
        Me.x = 0
        Me.y = 0
    End Sub

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        Me.x = x
        Me.y = y

    End Sub
    'Se crean los getters y setters públicos
    Public Function getX() As Integer
        Return Me.x
    End Function
    Public Sub setX(ByVal x As Integer)
        Me.x = x
    End Sub
    Public Function getY() As Integer
        Return Me.y
    End Function
    Public Sub setY(ByVal y As Integer)
        Me.y = y
    End Sub
    ' Se sobrescribe la funcion ToString()
    Public Overrides Function ToString() As String
        Return " Punto= {" + Me.x.ToString() + " ," + Me.y.ToString() + "}"
    End Function

    ' Devuelve la distancia entre esta instancia y  (0,0).
    Public Overloads Function distancia() As Double
        Return Math.Sqrt(((Me.x * Me.x) + (Me.y * Me.y)))
    End Function
End Class