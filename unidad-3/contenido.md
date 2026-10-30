# Desarrollo e implementación

## Estructura de la unidad

### Finalidad: ¿Para qué?

- organizar el sistema de modo que el costo de cambiarlo se mantenga bajo mientras lo construimos;
- verificar que lo construido hace lo que el cliente pidió, también en los casos que nadie mencionó;
- integrar el trabajo de todo el equipo en una única versión que funcione;
- mejorar el diseño del código existente sin romper lo que ya anda;
- y lograr que el sistema corra fuera de la máquina de quien lo escribió.

### Fundamentos: ¿Por qué?

- el software se construye de a incrementos, y cada incremento se apoya en los anteriores;
- lo que no está probado no sabemos si funciona: suponemos que funciona;
- el trabajo que no está integrado no existe para el cliente;
- el código se lee muchas más veces de las que se escribe, y se cambia durante toda su vida;
- y toda deuda técnica se paga: lo único que se decide es cuándo y con qué interés.

En la unidad anterior el **costo del cambio** era un criterio para tomar decisiones de diseño. En esta unidad se vuelve una práctica de todos los días: las pruebas lo hacen visible, la integración frecuente lo mantiene chico y la refactorización lo reduce. No se trata de construir rápido y después ordenar, sino de construir de una manera que nos permita seguir construyendo.

### Mecanismos: ¿Cómo?

- organización en capas y dirección de las dependencias;
- atributos de calidad expresados como escenarios verificables;
- prototipado y evaluación de la interfaz;
- selección fundamentada de tecnologías y herramientas;
- pruebas unitarias, de integración y de aceptación, con foco en los casos borde;
- integración frecuente sobre una rama principal, con revisión de código;
- refactorización respaldada por pruebas y gestión explícita de la deuda técnica;
- y configuración fuera del código, ambientes reproducibles e integración continua.

--------

# Arquitectura de la solución

### Qué es la arquitectura de un software

>La arquitectura representa las decisiones de diseño significativas que dan forma a un sistema, donde la significancia se mide por el costo del cambio.
>
>Grady Booch

>Arquitectura es respecto a cosas importantes, sea lo que esto sea.
>
>[Ralph Johnson - Martin Fowler](https://martinfowler.com/architecture/)

>El objetivo de la arquitectura de software es minimizar los recursos humanos necesarios para construir y mantener el sistema requerido.
>
>Clean Architecture - Robert C. Martin

Las tres formulaciones convergen en un mismo punto: la arquitectura no se define por el tipo de elementos que la componen sino por el costo de modificarlos. Fowler recoge la definición de Booch y agrega una precisión operativa: aquello que resulta arquitectónico es lo que las personas con experiencia en el sistema perciben como difícil de cambiar, y el trabajo del diseño consiste en reducir la cantidad de elementos que presentan esa propiedad.

De allí se derivan dos consecuencias para un proyecto de esta escala. La primera es que no todo constituye arquitectura: la presentación visual de un botón no lo es, mientras que la ubicación de las reglas de negocio sí. La segunda es que el objetivo no consiste en acertar una arquitectura definitiva sino en reducir el conjunto de decisiones irreversibles, manteniendo abiertas la mayor cantidad posible de opciones durante el mayor tiempo posible.

### Organización en capas

La organización en capas constituye la estructura por defecto de las aplicaciones de gestión, y lo es porque separa tres conjuntos de responsabilidades que cambian por motivos distintos y con frecuencias distintas.

| Capa | Responsabilidad | Motivo de cambio |
|---|---|---|
| **Presentación** | Mostrar información y recibir acciones | Cambia la forma de trabajo del usuario |
| **Dominio** | Las reglas del problema | Cambia el negocio |
| **Datos** | Persistir y recuperar | Cambia la tecnología de almacenamiento |

La regla que vuelve efectiva la separación es la **dirección de las dependencias**: la presentación conoce al dominio y el dominio no conoce a la presentación. Cuando la capa de dominio incorpora conocimiento sobre la pantalla en que sus resultados se muestran, las capas existen en el diagrama pero no en el sistema.

Fowler formula dos precisiones habitualmente ignoradas. La primera es que capas lógicas y capas físicas no son equivalentes: es perfectamente posible mantener tres capas rigurosamente separadas dentro de un único proceso, y en proyectos de esta escala suele ser lo indicado. La segunda es que dentro de una aplicación de tamaño medio la separación entre presentación, dominio y datos constituye la primera división y no la única: dentro del dominio corresponde volver a dividir según áreas funcionales.

Evans aporta el fundamento que explica por qué la capa de dominio es la que importa: aislarla es lo que permite que el modelo evolucione siguiendo al problema en lugar de seguir a la interfaz.

### Puertos y adaptadores

La organización más productiva para una aplicación de escala reducida que debe ser verificable es la que Cockburn describe como puertos y adaptadores, también denominada arquitectura hexagonal. Su intención declarada:

>Permitir que una aplicación pueda ser operada indistintamente por usuarios, programas, pruebas automatizadas o scripts por lotes, y que pueda desarrollarse y probarse de manera aislada de los dispositivos y las bases de datos que utilizará en ejecución.
>
>[Hexagonal (Ports & Adapters) Architecture - Alistair Cockburn](https://alistair.cockburn.us/hexagonal-architecture/)

El mecanismo consiste en que el dominio define **puertos** —interfaces expresadas en sus propios términos— y todo elemento externo ingresa mediante un **adaptador** que implementa ese puerto. El almacenamiento es un adaptador. La interfaz de usuario es un adaptador. La prueba automatizada es otro adaptador, y esa simetría es lo que vuelve valioso el esquema.

```text
                    ┌───────────────────────────────┐
     Adaptador      │                               │      Adaptador
     de entrada ───►│  Puerto      DOMINIO          │◄─── de salida
                    │              reglas del       │
     interfaz       │              problema         │      almacenamiento
     de usuario     │                               │      correo
     pruebas        │                        Puerto │
                    └───────────────────────────────┘
```

### Arquitectura limpia

Robert C. Martin reúne las capas, los puertos y adaptadores y otras propuestas similares en una sola formulación, que llama arquitectura limpia (*Clean Architecture*). El sistema se dibuja como círculos concéntricos, y todo el esquema descansa sobre una única regla:

>La regla que hace funcionar esta arquitectura es la regla de dependencia: las dependencias del código fuente sólo pueden apuntar hacia adentro. Nada en un círculo interior puede saber nada de algo en un círculo exterior.
>
>[The Clean Architecture - Robert C. Martin](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)

```text
  ┌─────────────────────────────────────────────────────────┐
  │  Frameworks y drivers: MAUI, SQLite, EF Core            │
  │   ┌─────────────────────────────────────────────────┐   │
  │   │  Adaptadores: ViewModels, repositorios          │   │
  │   │   ┌─────────────────────────────────────────┐   │   │
  │   │   │  Casos de uso: registrar asistencia,    │   │   │
  │   │   │  calcular el riesgo de una comisión     │   │   │
  │   │   │   ┌─────────────────────────────────┐   │   │   │
  │   │   │   │  Entidades: Estudiante, Clase,  │   │   │   │
  │   │   │   │  reglas del dominio             │   │   │   │
  │   │   │   └─────────────────────────────────┘   │   │   │
  │   │   └─────────────────────────────────────────┘   │   │
  │   └─────────────────────────────────────────────────┘   │
  └─────────────────────────────────────────────────────────┘
              las dependencias apuntan hacia adentro
```

Respecto de lo anterior, el aporte es doble. Por un lado, separa dentro del dominio las **entidades**, que son las reglas más estables del problema, de los **casos de uso**, que son lo que el sistema hace con ellas en esta aplicación en particular. Por otro, ubica a la base de datos y al framework de interfaz en el círculo más externo, como detalles: el centro del sistema es el problema, no la herramienta con que se lo resuelve.

No se trata de una arquitectura distinta de las anteriores, sino de la misma idea llevada a su forma más explícita: el dominio no conoce a quienes lo usan ni a quienes lo guardan.

### Síntesis

La arquitectura se define por el costo de cambio de las decisiones que la componen, no por la cantidad de elementos que contiene. En un proyecto de escala reducida el trabajo arquitectónico consiste casi íntegramente en dos operaciones: fijar la dirección de las dependencias, de modo que el dominio no conozca a quienes lo consumen, y aislar el punto de variación identificado durante el relevamiento. Todo lo demás admite ser simple, y conviene que lo sea.

--------

# Pruebas

### Antes de comenzar...

- ¿cómo sabemos que el cálculo del riesgo está bien, sin abrir la aplicación y probarlo a mano?
- si mañana cambiamos SQLite por SQL Server, ¿qué prueba nos avisaría que algo se rompió?
- ¿quién decide cuándo una historia está terminada: nosotros o el cliente?

>Las pruebas de un programa pueden usarse para mostrar la presencia de errores, pero nunca para mostrar su ausencia.
>
>Edsger W. Dijkstra - *Notes on Structured Programming* (1970), sección 3, "On the reliability of mechanisms"

### Las pruebas según su objetivo

Antes de hablar de tipos de pruebas, conviene ubicarlas según para qué sirven. Humble y Farley, en el capítulo 4 de *Continuous Delivery*, "Implementing a Testing Strategy", retoman los cuadrantes de Brian Marick y las organizan con dos preguntas: si están orientadas al negocio o a la tecnología, y si sirven para apoyar el desarrollo o para criticar el sistema ya construido.

![Cuadrantes de pruebas según su objetivo](https://raw.githubusercontent.com/emigallo-edu/entrega-continua/main/Presentaciones/test-quadrant.png)

[Sección de pruebas del material de entrega continua](https://github.com/emigallo-edu/entrega-continua/blob/main/Presentaciones/content.md#pruebas).

### Cada prueba contesta una pregunta distinta

Hasta ahora venimos escribiendo pruebas unitarias: tomamos una regla, le pasamos datos y verificamos el resultado. Para cerrar el proyecto necesitamos dos tipos más, y lo importante es que no se trata de tener más pruebas, sino de contestar preguntas que las unitarias no pueden contestar.

| Tipo | La pregunta que contesta | Qué usa | Quién la entiende |
|---|---|---|---|
| **Unitaria** | ¿La regla está bien escrita? | El dominio solo, con dobles en lugar de la base | El equipo |
| **De integración** | ¿Nuestro código y la tecnología se entienden? | Nuestro adaptador contra la tecnología real: la base, un archivo, el reloj | El equipo |
| **De aceptación** | ¿El sistema hace lo que el cliente pidió? | El recorrido completo, desde la entrada del caso de uso hasta el resultado | El cliente |

Las tres se escriben igual, con el mismo framework y la misma estructura Dado/Cuando/Entonces. Lo que cambia es qué parte del sistema ponemos a prueba y contra qué la comparamos.

### La pirámide

Fowler, recogiendo una idea de Mike Cohn, propone pensar la cantidad de pruebas de cada tipo como una pirámide: muchas unitarias en la base, porque son rápidas y precisas; algunas de integración en el medio; y pocas de aceptación arriba, porque son más lentas y, cuando fallan, nos dicen que algo está mal pero no dónde.

```text
                 ▲
                ╱ ╲          aceptación: pocas, una por criterio importante
               ╱───╲
              ╱     ╲        integración: una por adaptador
             ╱───────╲
            ╱         ╲      unitarias: muchas, todas las reglas y sus bordes
           ╱───────────╲
```

### Del criterio de aceptación a la prueba

Los criterios de aceptación que escribimos en la unidad 1 ya tienen la forma de una prueba. Si están bien escritos —con datos concretos, observables desde afuera y con algún camino que no es el feliz—, pasar de uno a la otra es casi una traducción.

Tomemos el CA3 de [la historia de referencia](../trabajo-integrador/historia-de-referencia.md#criterios-de-aceptación):

> **CA3 · Identificador repetido.** Dado que en 1°A ya está cargado el legajo 12345, cuando el tutor intenta cargar otro estudiante con el legajo 12345, entonces el alta se rechaza, el sistema informa a qué estudiante corresponde ese legajo y la nómina sigue teniendo 30 estudiantes.

En la [demo del TPI](../trabajo-integrador/DemoTPI/) el identificador es el DNI, y la prueba queda así:

```csharp
// H1 · CA3 · Identificador repetido
[TestMethod]
public void Given_DniYaCargado_When_RegistrarOtroConElMismoDni_Then_SeRechazaYLaNominaNoCambia()
{
    using BaseEnMemoria baseDeDatos = new BaseEnMemoria();
    EstudianteRepositorioEF repositorio = new EstudianteRepositorioEF(baseDeDatos);
    RegistrarEstudianteService registrar = new RegistrarEstudianteService(repositorio);
    registrar.Registrar(new Estudiante() { Nombre = "Juan", Apellido = "Pérez", Email = "juan@mail.com", Telefono = "11 4567-8901", Dni = "12.345.678" });

    Estudiante otro = new Estudiante() { Nombre = "Ana", Apellido = "Gómez", Email = "ana@mail.com", Telefono = "11 4567-0000", Dni = "12345678" };
    ArgumentException ex = Assert.ThrowsExactly<ArgumentException>(() => registrar.Registrar(otro));

    Assert.AreEqual("El DNI 12345678 ya está cargado para Pérez, Juan", ex.Message);
    Assert.HasCount(1, repositorio.ObtenerTodos());
}
```

Tres cosas para mirar:
- El nombre de la prueba es el criterio: quien la lee sin conocer el código sabe qué se verifica.
- Cada parte del "entonces" es un `Assert`: que se rechace, que diga a quién corresponde y que la nómina no cambie.
- Y la prueba entra por el servicio, no por la pantalla: es lo que se suele llamar una prueba *subcutánea*, que opera justo debajo de la interfaz de usuario. Probar a través de la pantalla es posible, pero lento y frágil, y lo que el cliente pidió es una regla, no un botón.


El sistema sí rechaza el DNI repetido, pero porque la base tiene un índice único, no porque el dominio conozca la regla. Quien usa el sistema recibiría un error de Entity Framework en lugar de "este DNI ya es de Pérez, Juan". Ese es el valor de escribir la prueba desde el criterio: la regla estaba en el criterio, en la base y en ningún lugar del dominio. La corrección va donde vive la regla, en el servicio:

```csharp
Estudiante? existente = this._repositorio.ObtenerTodos().FirstOrDefault(e => e.Dni == dni);
if (existente != null)
{
    throw new ArgumentException($"El DNI {dni} ya está cargado para {existente.Apellido}, {existente.Nombre}");
}
```

### Lo que el doble no simula

Las pruebas unitarias de la demo usan `EstudianteRepositorioFake`, una lista en memoria que reemplaza a la base. Es un **doble de prueba**: un objeto que ocupa el lugar de otro durante la prueba. Se distinguen varios tipos —*dummy*, *fake*, *stub*, *spy* y *mock*— según cuánto del original imitan y qué verifican, y el nuestro es un *fake*: funciona de verdad, pero de una manera simplificada que no sirve para producción.

Lo importante es que el doble sólo hace lo que nosotros le programamos, y por eso las pruebas unitarias no pueden encontrar los errores que viven en la diferencia entre el doble y la tecnología real. El *fake* de la demo acepta dos estudiantes con el mismo DNI sin quejarse, y devuelve la lista en el orden en que se cargó. La base no hace ninguna de las dos cosas. Para eso están las pruebas de integración.

### Pruebas de integración contra la base

Una prueba de integración pone a prueba **nuestro adaptador contra la tecnología real**: en nuestro caso, el repositorio de Entity Framework contra SQLite. Para que sea rápida y no ensucie la base de la aplicación, usamos una base SQLite en memoria, que se crea cuando se abre la conexión y desaparece cuando se cierra:

```csharp
// Una base SQLite real que vive en memoria mientras la conexión esté abierta.
// Cada prueba arranca con una base nueva y vacía.
internal sealed class BaseEnMemoria : IDbContextFactory<DemoTPIContext>, IDisposable
{
    private readonly SqliteConnection _conexion;
    private readonly DbContextOptions<DemoTPIContext> _opciones;

    public BaseEnMemoria()
    {
        this._conexion = new SqliteConnection("Filename=:memory:");
        this._conexion.Open();
        this._opciones = new DbContextOptionsBuilder<DemoTPIContext>().UseSqlite(this._conexion).Options;

        using DemoTPIContext contexto = this.CreateDbContext();
        contexto.Database.EnsureCreated();
    }

    public DemoTPIContext CreateDbContext()
    {
        return new DemoTPIContext(this._opciones);
    }

    public void Dispose()
    {
        this._conexion.Dispose();
    }
}
```

Como `BaseEnMemoria` implementa la misma interfaz que recibe el repositorio, `IDbContextFactory`, el repositorio no se entera de que está en una prueba. Es la arquitectura de **puertos y adaptadores** trabajando a nuestro favor: la prueba es un adaptador más.

### Los casos borde

Las reglas se rompen en los bordes, y el borde más importante de nuestro dominio es el cálculo del riesgo. Es el punto 5 de [cómo evaluamos la calidad del producto](../trabajo-integrador/consigna.md#cómo-evaluamos-la-calidad-del-producto), y cada uno de estos casos es una prueba unitaria:

- un estudiante sin clases registradas todavía: ¿el riesgo es cero, máximo o "sin datos"?;
- una comisión sin trabajos con fecha vencida: ¿la señal de entregas cuenta o no cuenta?;
- un estudiante que se incorporó en la semana cinco: ¿las clases anteriores cuentan como ausencias?;
- un estudiante justo en el umbral: ¿el 25 % es riesgo o no lo es?

Ninguna de esas preguntas la contestó el cliente, y la prueba nos obliga a decidirlas. Lo que decidamos va a la prueba. Si en lugar de decidir lo dejamos librado a lo que haga el código, la que lo descubre es la clienta, en la demo.

--------

# Refactorización y deuda técnica

### Antes de comenzar...

- ¿qué método de nuestro proyecto nadie quiere tocar? ¿por qué?
- si hoy tuviéramos que agregar una tercera señal al cálculo del riesgo, ¿cuántos archivos habría que cambiar?
- ¿cuándo fue la última vez que mejoramos código que ya funcionaba?

### Qué es refactorizar

>Refactorización (sustantivo): un cambio en la estructura interna del software para hacerlo más fácil de entender y más barato de modificar, sin cambiar su comportamiento observable.
>
>[Definition Of Refactoring - Martin Fowler](https://martinfowler.com/bliki/DefinitionOfRefactoring.html)

La definición tiene dos mitades y las dos importan. La primera dice para qué: entender y modificar más barato, que es exactamente el costo del cambio con el que definimos la arquitectura. La segunda dice la condición: **sin cambiar el comportamiento**. Un cambio que arregla un error o agrega una funcionalidad puede ser necesario, pero no es una refactorización, y mezclar las dos cosas en el mismo cambio hace imposible saber cuál de las dos rompió algo.

No se trata de "ordenar el código" cuando sobra tiempo, sino de una práctica de todos los días que depende de una condición previa: **sin pruebas no hay refactorización**. Si no tenemos cómo verificar que el comportamiento no cambió, lo que estamos haciendo es cambiar código y esperar. Fowler dedica a esto el capítulo 4 de *Refactoring*, "Building Tests", antes de entrar al catálogo de técnicas.

### Los olores y los siete puntos

Fowler llama *olores* (*code smells*) a los síntomas que indican que conviene refactorizar, y cada olor tiene sus refactorizaciones en el catálogo. Los puntos de código de nuestra evaluación de calidad son, en buena medida, olores con nombre propio:

| Punto de la evaluación | El olor | La refactorización |
|---|---|---|
| 1 · Métodos chicos | Función larga (*Long Function*) | *Extract Function* |
| 2 · Cada cosa en su capa | Lógica en el code-behind o en el ViewModel | *Move Function* al dominio |
| 3 · Las dependencias apuntan al dominio | `new` de un repositorio dentro de un ViewModel | Recibirlo por el constructor, tipado con la interfaz |
| 4 · Cada dato escrito una sola vez | Código duplicado y literales sueltos (*Duplicated Code*) | *Replace Magic Literal* por una constante o un enum |
| 5 · Las reglas están probadas | — | Es la condición para todas las demás |

El tamaño y la complejidad de cada método se ven en Visual Studio con *Analizar → Calcular métricas de código*. La lista de métodos que superan los umbrales es, literalmente, la lista de refactorizaciones pendientes.

[Refactoring Guru](https://refactoring.guru/refactoring/smells)

### La deuda técnica

Cuando entregamos algo sabiendo que el diseño no es el adecuado, tomamos un préstamo: ganamos tiempo ahora. La deuda es la diferencia entre el diseño que tenemos y el que necesitamos, y los **intereses** son el esfuerzo de más que nos cuesta cada cambio que hacemos sobre ese código. Mientras no pagamos la deuda, la seguimos pagando en intereses.

Consideraciones a tener cuenta:
- No toda deuda es igual: hay deuda **deliberada** ("lo dejamos así para llegar a la demo")
- y deuda **inadvertida** ("ahora que lo vemos, esto se tendría que haber hecho de otra manera")

En los dos casos puede ser **prudente**, si sabemos lo que estamos tomando y por qué, o **imprudente**, si no. La segunda es dónde pagar primero: en el código que casi no se toca los intereses son bajos y se puede convivir con la deuda, mientras que en las zonas de mucha actividad hace falta tolerancia cero, porque los intereses son altísimos.

Para nosotros, la deuda que conviene registrar no es "el código está feo", sino algo concreto: qué quedó mal, por qué lo dejamos así y qué nos cuesta. Una tarjeta en Trello con la etiqueta *deuda* alcanza. Si la decisión de tomarla fue deliberada, además, es una decisión, y va al registro de decisiones.