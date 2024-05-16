----¿String es una tipo por valor o un tipo por referencia?----

Clase string es un tipo por referencia pero con semántica de tipo por valor.

----¿Qué secuencias de escape tiene el tipo string?----

Secuencias de escape más comunes utilizadas en las cadenas de C#:

\n: Nueva línea (line feed, LF)
\r: Retorno de carro (carriage return, CR)
\t: Tabulación horizontal (tab)
\b: Retroceso (backspace)
\f: Avance de página (form feed)
\a: Alerta (bell, produce un sonido en algunas consolas)
\v: Tabulación vertical
\\: Barra invertida (backslash)
\": Comilla doble (double quote)
\': Comilla simple (single quote)
\0: Carácter nulo (null character)


----¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?----

El carácter @ se usa para definir una cadena literal de texto, conocida como una cadena verificada,  Esto significa que la cadena se toma tal cual se escribe, sin necesidad de escapar caracteres especiales como las barras invertidas.

El carácter $ se utiliza para definir una cadena interpolada. Esto permite la inclusión de expresiones dentro de la cadena, las cuales son evaluadas y su resultado es incluido en la cadena.
