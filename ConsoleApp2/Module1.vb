Module Module1

    Sub Main()
        Dim totalCompra As Double = 0

        While True
            ' Solicitar al usuario el costo del artículo
            Console.Write("Ingrese el costo del artículo (ingrese un valor negativo para finalizar): $")
            Dim costoArticulo As Double = Double.Parse(Console.ReadLine())

            ' Verificar si se debe finalizar la compra
            If costoArticulo < 0 Then
                Exit While
            End If

            ' Sumar el costo del artículo al total de la compra
            totalCompra += costoArticulo

            ' Solicitar el dinero entregado por el cliente
            Console.Write("Ingrese la cantidad de dinero entregada por el cliente: $")
            Dim dineroEntregado As Double = Double.Parse(Console.ReadLine())

            ' Calcular el cambio a devolver o si se entrega el producto
            If dineroEntregado > costoArticulo Then
                ' Calcular el descuento
                Dim descuento As Double = 0
                If totalCompra >= 1000 Then
                    descuento = totalCompra * 0.1 ' Aplicar 10% de descuento
                ElseIf totalCompra >= 500 Then
                    descuento = totalCompra * 0.05 ' Aplicar 5% de descuento
                End If

                ' Aplicar el descuento
                totalCompra -= descuento

                ' Dar el cambio
                Dim cambio As Double = dineroEntregado - totalCompra
                Console.WriteLine("Descuento aplicado: $" & descuento.ToString("F2"))
                Console.WriteLine("Cambio a devolver: $" & cambio.ToString("F2"))
            ElseIf dineroEntregado = costoArticulo Then
                ' Entregar el producto
                Console.WriteLine("Entregar el producto.")
            Else
                ' El dinero entregado es insuficiente
                Console.WriteLine("El dinero entregado es insuficiente para pagar el artículo.")
                Console.WriteLine("Por favor, entregue más dinero o vuelva pronto por el producto.")
            End If
        End While

        ' Mostrar el total de la compra
        Console.WriteLine("Total de la compra: $" & totalCompra.ToString("F2"))

        ' Esperar a que el usuario presione Enter para salir
        Console.ReadLine()

    End Sub

End Module
