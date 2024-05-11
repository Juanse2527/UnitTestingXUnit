Explicación del Código en C#
============================

1\. Pruebas de Concatenación de Cadenas (ConcatenateStringsTest)
----------------------------------------------------------------

Se crea una instancia de StringOperations.

Se definen dos cadenas (str1 y str2).

Se llama al método ConcatenateStrings de la instancia de StringOperations con str1 y str2.

Se compara el resultado con la concatenación esperada de las dos cadenas.

2\. Pruebas de Reversión de Cadenas (ReverseStringTest)
-------------------------------------------------------

Se crea una instancia de StringOperations.

Se define una cadena (str1).

Se llama al método ReverseString de la instancia de StringOperations con una cadena invertida.

Se compara el resultado con la cadena original.

3\. Pruebas de Longitud de Cadena (GetStringLengthTestWhenThereIsText, GetStringLengthTestWhenStrIsNull)
--------------------------------------------------------------------------------------------------------

Se crea una instancia de StringOperations.

Se define una cadena (str), que puede ser nula en el segundo caso.

Se llama al método GetStringLength de la instancia de StringOperations.

Se compara la longitud devuelta con la longitud real de la cadena.

4\. Prueba de Eliminación de Espacios en Blanco (RemoveWhitespaceTest)
----------------------------------------------------------------------

Se crea una instancia de StringOperations.

Se define una cadena con espacios en blanco (palabra).

Se llama al método RemoveWhitespace de la instancia de StringOperations.

Se compara el resultado con la cadena esperada sin espacios en blanco.

5\. Pruebas de Truncado de Cadena (TruncateStringTest\_MaxLenght\_Under\_0\_Or\_0, TruncateStringTest\_When\_maxlenghtBiggerThanInput)
--------------------------------------------------------------------------------------------------------------------------------------

Se crea una instancia de StringOperations.

Se define una cadena (input) y una longitud máxima (maxlenght).

Se llama al método TruncateString de la instancia de StringOperations.

Se compara el resultado con la cadena original si la longitud máxima es menor o igual a cero, o con la cadena original si la longitud máxima es mayor que la longitud de la cadena.

6\. Prueba de Palíndromo (IsPalindromeTest)
-------------------------------------------

Se crea una instancia de StringOperations.

Se define una cadena (str) que se espera que sea un palíndromo.

Se llama al método IsPalindrome de la instancia de StringOperations.

Se compara el resultado con el valor esperado de si la cadena es un palíndromo o no.

7\. Prueba de Conteo de Ocurrencias (CountOccurrences)
------------------------------------------------------

Se crea un logger.

Se crea una instancia de StringOperations con el logger.

Se define una cadena (input) y un carácter (character).

Se llama al método CountOccurrences de la instancia de StringOperations.

Se compara el resultado con el número esperado de ocurrencias del carácter en la cadena.

8\. Prueba de Pluralización (PluralizeTest)
-------------------------------------------

Se crea una instancia de StringOperations.

Se define una cadena (input) que se espera que sea singular.

Se llama al método Pluralize de la instancia de StringOperations.

Se compara el resultado con la forma plural esperada de la cadena.

9\. Prueba de Cantidad en Palabras (QuantintyInWords)
-----------------------------------------------------

Se crea una instancia de StringOperations.

Se define una cadena (str) y una cantidad (cant).

Se espera que el método convierta la cantidad y la cadena en palabras.

Se compara el resultado con la cantidad y la cadena convertidas en palabras esperadas.

10\. Prueba de Conversión de Números Romanos a Números (FromRomanToNumber)
--------------------------------------------------------------------------

Se crea una instancia de StringOperations.

Se define una cadena que representa un número romano (romano).

Se llama al método FromRomanToNumber de la instancia de StringOperations.

Se compara el resultado con el número esperado.

11\. Prueba de Lectura de Archivo (ReadFileTest)
------------------------------------------------

Se crea una instancia de StringOperations.

Se define un nombre de archivo (fileName).

Se crea una instancia de FileReaderConector para leer el archivo.

Se llama al método ReadFile de la instancia de StringOperations.

Se compara el resultado con el contenido esperado del archivo.#