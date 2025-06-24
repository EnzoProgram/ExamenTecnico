# ExamenTecnico
#  ¿Puede un número X formarse usando la suma de 2 elementos de un array?

## 📋 Descripción
Este proyecto resuelve el problema de verificar si un número objetivo (`numeroSumado`) puede formarse sumando dos elementos distintos de un array de enteros.

Se incluyen dos versiones de la solución:

- **Versión simple**: Implementada con dos bucles anidados. Es fácil de entender pero ineficiente para grandes volúmenes de datos.
- **Versión optimizada**: Utiliza un `HashSet` para almacenar los valores ya recorridos y busca el complemento necesario para alcanzar la suma.

## 🧪 Ejemplos

```csharp
Input: [1, 4, 2, 4], Suma requerida: 8
Output: true

Input: [1, 2, 2, 4], Suma requerida: 8
Output: false 
```
## Tecnologías usadas 
Lenguaje: C#
Tipo de aplicación: Consola
Versión de .NET: .NET 8.0
IDE sugerido: Visual Studio o compilador online

##  Cómo probar
1- Clonar el repositorio o copiar el archivo Program.cs.
2- Abrirlo en un entorno compatible con C# (Visual Studio o compilador online).
3- Ejecutar la aplicación para ver los resultados en la consola.
4- Puedes modificar el array y el número objetivo en Main() para probar otros casos.
