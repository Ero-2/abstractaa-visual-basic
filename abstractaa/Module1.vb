
Namespace abstracta
    Friend Class Program
        Private Shared Sub Main(ByVal args As String())
            Dim Circulo1 As Circulo = New Circulo(2)
            Dim triangulo1 As Triangulo = New Triangulo(2, 4)
            Dim rectangulo1 As Rectangulo = New Rectangulo(2, 8)
            Console.WriteLine(Circulo1)
            Console.WriteLine(triangulo1)
            Console.WriteLine(rectangulo1)
            Console.ReadKey()
        End Sub
    End Class

    MustInherit Class figuraGeo
        Private nameless As String
        Public MustOverride Function Area() As Double

        Public Sub New(ByVal nombre As String)
            nameless = nombre
        End Sub

        Public Overrides Function ToString() As String
            Return "area de un " & nameless & "=" & Area()
        End Function
    End Class

    Class Triangulo
        Inherits figuraGeo

        Private b, h As Double

        Public Sub New(ByVal b As Double, ByVal h As Double)
            MyBase.New("triangulo")
            Me.b = b
            Me.h = h
        End Sub

        Public Overrides Function Area() As Double
            Return b * h / 2
        End Function
    End Class

    Class Rectangulo
        Inherits figuraGeo

        Private b, h As Double

        Public Sub New(ByVal b As Double, ByVal h As Double)
            MyBase.New("rectangulo")
            Me.b = b
            Me.h = h
        End Sub

        Public Overrides Function Area() As Double
            Return b * h
        End Function
    End Class

    Class Circulo
        Inherits figuraGeo

        Private radio As Double

        Public Sub New(ByVal r As Double)
            MyBase.New("circulo")
            radio = r
        End Sub

        Public Overrides Function Area() As Double
            Return Math.PI * Math.Pow(2, radio)
        End Function
    End Class
End Namespace


