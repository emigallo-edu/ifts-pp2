# SOLID

### Antes de comenzar...

- ¿cómo sabemos si un código está bien diseñado, más allá de que funcione?
- ¿qué le pasa a un código cuando el cliente nos pide un cambio que no habíamos previsto?

**SOLID** es un acrónimo que agrupa cinco ideas sobre diseño orientado a objetos. Robert C. Martin las reunió a principios de los 2000, y Michael Feathers les puso el nombre. Es probablemente el conjunto de principios de diseño más conocido, y por eso lo usamos como puerta de entrada: no porque sea completo, sino porque es un buen lugar para empezar a preguntarnos qué hace que un diseño sea mejor que otro.

SOLID no cubre todo lo que importa en un diseño: deja afuera ideas tan importantes como la sencillez o el bajo acoplamiento en general, que vamos a ver más adelante. Y no todas sus letras son principios en el mismo sentido: algunas describen una propiedad que buscamos en el diseño, y otras se parecen más a una técnica para lograrla.

Lo que tienen en común las cinco es una misma preocupación: **que un cambio en el sistema cueste poco**. Cada letra ataca una forma distinta en que un cambio se vuelve caro.

--------

##### 1. S — Responsabilidad única (Single Responsibility)

>Un módulo debería ser responsable ante uno, y sólo un, actor.
>
>Clean Architecture - Robert C. Martin, cap. 7, "SRP: The Single Responsibility Principle"

No se trata de que una clase "haga una sola cosa", sino de que tenga **una sola razón para cambiar**. Si una clase cambia cuando cambia el criterio de negocio, y también cuando cambia el formato de un reporte, y también cuando cambia dónde se guardan los datos, tiene tres razones para cambiar, y cada cambio pone en riesgo a las otras dos.

Es la forma que toma en SOLID una idea más general: la **alta cohesión**.

*Cómo se detecta:* cuando para describir lo que hace la clase necesitamos usar "y": "calcula el riesgo **y** arma el texto **y** lo guarda en un archivo".

##### 2. O — Abierto-cerrado (Open-Closed)

>Las entidades de software deberían estar abiertas para su extensión, pero cerradas para su modificación.
>
>Object-Oriented Software Construction - Bertrand Meyer, cap. 3, "Modularity"

Agregar un comportamiento nuevo no debería obligarnos a modificar el código que ya funciona. Si cada vez que aparece una variante nueva tenemos que abrir la misma clase y agregar un `case` o un `else if`, esa clase está cerrada para la extensión y abierta para la modificación: justo al revés.

*Cómo se detecta:* un `switch` o una cadena de `if` que pregunta por un tipo, un código o un texto para decidir qué hacer, y que crece cada vez que aparece una variante.

##### 3. L — Sustitución de Liskov (Liskov Substitution)

>Si para cada objeto o1 de tipo S hay un objeto o2 de tipo T tal que, para todos los programas P definidos en términos de T, el comportamiento de P no cambia cuando o1 es sustituido por o2, entonces S es un subtipo de T.
>
>"Data Abstraction and Hierarchy" - Barbara Liskov, 1987

Dicho de forma más simple: donde el código espera un objeto de la clase base, tiene que poder recibir cualquiera de sus subclases sin enterarse. Si una subclase lanza una excepción en un método que la clase base promete cumplir, o si ignora lo que se le pide, la herencia está mintiendo: la subclase *es un* tipo de la base en el código, pero no se *comporta* como tal.

*Cómo se detecta:* código que pregunta `if (objeto is SubclaseTal)` antes de usarlo, métodos sobrescritos que lanzan `NotSupportedException`, o métodos sobrescritos que devuelven algo distinto de lo que la clase base promete, aunque no fallen.

##### 4. I — Segregación de interfaces (Interface Segregation)

>Los clientes no deberían estar obligados a depender de interfaces que no usan.
>
>Agile Software Development: Principles, Patterns, and Practices - Robert C. Martin, cap. 12, "The Interface Segregation Principle"

Una interfaz grande obliga a todas las clases que la implementan a ofrecer todos sus métodos, aunque algunos no tengan sentido para ellas. Es preferible tener varias interfaces chicas, cada una pensada para quien la usa, que una sola que intenta cubrir todos los casos.

*Cómo se detecta:* implementaciones de una interfaz con métodos vacíos o que lanzan `NotSupportedException` "porque no aplica".

##### 5. D — Inversión de dependencias (Dependency Inversion)

>Los módulos de alto nivel no deberían depender de los módulos de bajo nivel. Ambos deberían depender de abstracciones.
>
>Agile Software Development: Principles, Patterns, and Practices - Robert C. Martin, cap. 11, "The Dependency-Inversion Principle"

La parte del sistema que expresa las reglas importantes (a quién hay que contactar, cuándo, por qué) no debería depender de los detalles (si el aviso sale por email, si el registro se guarda en un archivo o en una base de datos). Cuando la regla crea directamente los detalles con `new`, no podemos cambiar un detalle sin tocar la regla, y tampoco podemos probar la regla sin arrastrar todos los detalles.

Esta es la letra que más se parece a una técnica que a un principio: lo que buscamos en realidad es **bajo acoplamiento**, y depender de abstracciones es una de las formas de lograrlo.

*Cómo se detecta:* una clase con reglas de negocio que hace `new` de clases que escriben archivos, envían mensajes o acceden a una base de datos.

--------

### Lo que SOLID no dice

SOLID es un buen punto de partida, pero no alcanza. Hay otras ideas de diseño que vamos a usar tanto o más que estas:
- alta cohesión y bajo acoplamiento, que SOLID toca sólo en parte;
- sencillez: el mejor diseño es el más simple que resuelve el problema de hoy;
- diseño suficiente: no agregar abstracciones "por si acaso";
- nombres con sentido, que ya vimos con el lenguaje ubicuo.

Y una advertencia importante: aplicar SOLID a todo, en todos lados, produce código lleno de interfaces y clases que nadie necesitaba. Los principios sirven para detectar dónde un cambio va a doler, y para invertir el esfuerzo de diseño justamente ahí.

--------

# Actividad: detectar y mejorar

#### Descripción

Tres fragmentos de código. Todos funcionan, pero cada uno tiene una parte que no cumple alguna de las letras de SOLID, y eso va a doler en cuanto la clienta pida el cambio que acompaña a cada ejercicio.

Se juntan 15' con sus equipos para que debatan cuál principio SOLID no está cumpliendo cada ejercicio.

##### Pasos a seguir

Para cada ejercicio:
1. Leer el código y el pedido de la clienta.
2. Identificar qué letra de SOLID no se cumple, y cuál es el síntoma que lo delata.
3. Listar qué habría que modificar para atender el pedido **tal como está hoy el código**.

Lo importante no es encontrar "la" solución, sino poder explicar por qué el código mejorado es más fácil de cambiar.

--------

## Ejercicio 1

```csharp
public class Avisador
{
    public void Avisar(Estudiante estudiante, string canal, string mensaje)
    {
        switch (canal)
        {
            case "email":
                Console.WriteLine($"[Email a {estudiante.Email}] {mensaje}");
                break;

            case "sms":
                Console.WriteLine($"[SMS a {estudiante.Telefono}] {mensaje}");
                break;

            default:
                throw new ArgumentException($"Canal desconocido: {canal}");
        }
    }
}
```

**Pedido de la clienta:** "Quiero que también se pueda avisar por WhatsApp. Y el año que viene, seguramente, por la app del instituto."

--------

## Ejercicio 2

```csharp
public class InformeDeRiesgo
{
    public void Generar(Comision comision)
    {
        StringBuilder texto = new StringBuilder();
        texto.AppendLine($"Informe de riesgo - Comisión {comision.Nombre}");

        foreach (Estudiante estudiante in comision.Estudiantes)
        {
            double porcentaje = comision.PorcentajeDeInasistencias(estudiante);

            string nivel;
            if (porcentaje >= 25)
                nivel = "ALTO";
            else if (porcentaje >= 15)
                nivel = "MEDIO";
            else
                nivel = "BAJO";

            texto.AppendLine($"{estudiante.Legajo} {estudiante.Nombre}: {porcentaje:0.0}% {nivel}");
        }

        File.WriteAllText($"informe-{comision.Nombre}.txt", texto.ToString());
    }
}
```

**Pedido de la clienta:** "El umbral de riesgo alto ya no es 25%, ahora es 20%. Ah, y el informe lo quiero en CSV, para abrirlo con Excel."

--------

## Ejercicio 3

```csharp
public class SeguimientoSemanal
{
    public void Ejecutar(Comision comision)
    {
        CanalEmail email = new CanalEmail();
        ArchivoDeContactos contactos = new ArchivoDeContactos("contactos.txt");

        foreach (Estudiante estudiante in comision.Estudiantes)
        {
            if (comision.PorcentajeDeInasistencias(estudiante) >= 25)
            {
                email.EnviarMensaje(estudiante, "Notamos que faltaste a varias clases. ¿Podemos hablar?");
                contactos.Registrar(estudiante, DateTime.Now);
            }
        }
    }
}
```

**Pedido de la clienta:** "Antes de usarlo quiero estar segura de que sólo contacta a quienes están en riesgo." El equipo quiere escribir una prueba automática que lo verifique, sin mandar emails reales ni escribir archivos.