Sub Main()

    Dim opcion As String

        Console.WriteLine("Escribe tu apellido Paterno")
        Dim apPat As String = Console.ReadLine()

        Console.WriteLine("Escribe tu apellido Materno")
        Dim apMat As String = Console.ReadLine()

        Console.WriteLine("Escribe tus nombres")
        Dim nombres As String = Console.ReadLine()

        Console.WriteLine("Escribe tu rut sin digito verificador")
    Dim rut As String = Console.ReadLine()




    Console.WriteLine("Escribe tu fecha de nacimiento dd/mm/yyyy")

    Dim Fnac As String = Console.ReadLine()

    If (IsDate(Fnac)) = False Then
        MsgBox("Fecha errónea ingrese nuevamente los datos")
        Main()
    ElseIf (DateTime.Now < (Fnac)) Then
        MsgBox("la fecha supera la fecha de hoy ingrese nuevamente los datos")
        Main()

    Else


    End If

    Console.WriteLine(apMat.ToUpper)
    Console.WriteLine(apPat.ToUpper)
    Console.WriteLine(nombres.ToUpper)
    Console.WriteLine(calcular(rut))
    Console.WriteLine(Fnaci(Fnac))

    Console.WriteLine("Desea ingresar nuevos datos?<si/no>")
    opcion = Console.ReadLine()
    If opcion = "si" Then
        Main()
    ElseIf opcion = "no" Then
    End If

    End Sub



Function Fnaci(ByVal Fnac1 As String) As String
    Dim dia, mes, ano As String
    Dim Fnac2 As String


    dia = DateDiff("d", Fnac1, "13/09/2016")
    mes = DateDiff("m", Fnac1, "13/09/2016")
    ano = DateDiff("yyyy", Fnac1, "13/09/2016")

    Fnac2 = "Edad en; " +
             dia + " días, " +
             mes + " Meses y " +
             ano + " Años "

    Return Fnac2

End Function

Function calcular(ByVal rut As String) As String
    Dim Final As String
    Dim Digito As Integer
    Dim Contador As Integer
    Dim Multiplo As Integer
    Dim Acumulador As Integer
    Dim RutDigito As String
    Dim sinDigito As String
    Contador = 2
    Acumulador = 0
    sinDigito = rut
    While rut <> 0
        Multiplo = (rut Mod 10) * Contador
        Acumulador = Acumulador + Multiplo
        rut = rut \ 10
        Contador = Contador + 1
        If Contador = 8 Then
            Contador = 2
        End If
    End While
    Digito = 11 - (Acumulador Mod 11)
    RutDigito = CStr(Digito)
    If Digito = 10 Then RutDigito = "K"
    If Digito = 11 Then RutDigito = "0"
    Final = sinDigito + "-" + RutDigito
    Return Final
End Function

Sub fecha()
    Console.WriteLine("Escribe tu fecha de nacimiento dd/mm/yyyy")
    Dim Fnac As String = Console.ReadLine()

End Sub