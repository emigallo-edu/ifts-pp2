# Documentación, presentación y transferencia de la solución

## Estructura de la unidad

### Finalidad: ¿Para qué?

- que otra persona pueda correr, entender y modificar el sistema sin depender de quien lo escribió;
- dejar a la vista cómo está organizado el sistema hoy y por qué se tomaron las decisiones que lo formaron;
- mostrar la solución a un destinatario no técnico de modo que entienda qué problema resuelve;
- y defender las decisiones propias con fundamentos, reconociendo también lo que quedó pendiente.

### Fundamentos: ¿Por qué?

- un sistema que sólo sabe correr quien lo escribió no se puede transferir;
- la memoria del equipo dura lo que dura el equipo: lo que no se escribe se pierde;
- el cliente no evalúa el código, evalúa si el sistema le resuelve el problema;
- y una decisión que no se puede explicar no es una decisión, es una casualidad.

De esta unidad vamos a ver sólo lo que el proyecto necesita para cerrarse: la documentación mínima del repositorio, el modelo de arquitectura actual, el registro de decisiones y la preparación de la demostración y de la defensa. Los manuales de usuario, la etapa de mantenimiento y la presentación profesional quedan fuera del recorrido de este cuatrimestre.

### Mecanismos: ¿Cómo?

- un README que permite clonar y correr el sistema en una máquina nueva;
- un diagrama de la arquitectura tal como está construida;
- registros de decisión (ADR) escritos en el momento en que se toma cada decisión;
- una demostración que parte del problema del cliente y termina en la decisión que el sistema habilita;
- y una defensa que enuncia cada decisión con su motivo, su costo y lo que la haría cambiar.

--------

# Documentar para que otro pueda seguir

### Antes de comenzar...

- si mañana se suma una persona al equipo, ¿cuánto tarda en tener el sistema corriendo?
- ¿dónde está escrito por qué elegimos esta base de datos, y no otra?
- ¿qué documentación leería alguien que tiene que corregir un error en seis meses?

>Software funcionando sobre documentación extensiva.
>
>[Manifiesto por el Desarrollo Ágil de Software](https://agilemanifesto.org/iso/es/manifesto.html)

### Documentar no es escribir mucho

El manifiesto ágil no dice que la documentación no importa: dice que, entre las dos, preferimos el software funcionando. No se trata de escribir menos, sino de escribir lo que alguien va a leer. La documentación que nadie consulta tiene costo y no tiene valor, y además se desactualiza, porque nadie se entera de que está mal.

Para un proyecto como el nuestro, la documentación que alguien va a leer de verdad es poca y concreta: un README que permite correr el sistema, un diagrama de cómo está organizado y el registro de las decisiones que lo formaron. Y las pruebas, que también son documentación: describen, en un lenguaje que no se desactualiza, qué se espera del sistema.

Un criterio útil para decidir qué escribir es preguntarse qué necesita quien lo va a leer. El marco *Diátaxis* distingue cuatro necesidades: aprender a usar algo por primera vez (tutorial), resolver una tarea concreta (guía práctica), consultar un dato preciso (referencia) y entender por qué algo es como es (explicación). El README es mayormente una guía práctica; los ADR son explicación.

### El README

El README es la puerta de entrada al repositorio. Es lo primero que ve cualquiera que lo abre, y tiene que contestar, en este orden:

1. **Qué es**: una o dos oraciones con el problema que resuelve el sistema, en el lenguaje del cliente.
2. **Cómo se corre**: qué hay que tener instalado, con versiones; cómo se configura la base; y los comandos exactos, en orden.
3. **Cómo se cargan datos de ejemplo**, si existen, y cómo se vuelve a una base vacía.
4. **Cómo se corren las pruebas**.
5. **Cómo está organizado**: qué hay en cada proyecto o carpeta, con un enlace al diagrama de arquitectura.
6. **Cómo se trabaja**: qué rama es la principal, cómo se integra y quiénes integran el equipo.

```markdown
# Seguimiento de cursada

Panel para que quien sigue una comisión sepa a qué estudiantes contactar esta semana.

## Cómo correrlo

Requisitos: .NET 10 SDK y la carga de trabajo de MAUI para Windows.

    git clone https://github.com/equipo/proyecto.git
    cd proyecto
    dotnet build App/App.csproj -f net10.0-windows10.0.19041.0
    dotnet run --project App/App.csproj -f net10.0-windows10.0.19041.0

La base SQLite se crea sola en el primer arranque. Para cargar datos de ejemplo: menú Configuración → "Cargar datos de demostración".

## Pruebas

    dotnet test Test/Test.csproj

## Organización

- `Dominio/`: entidades, reglas y cálculo de riesgo. No depende de MAUI ni de la base.
- `Datos/`: repositorios sobre SQLite.
- `App/`: pantallas y ViewModels.

Diagrama de arquitectura: [docs/arquitectura.md](docs/arquitectura.md) · Decisiones: [docs/decisiones/](docs/decisiones/)

## Cómo trabajamos

`main` siempre corre. Una rama por historia, integración por pull request revisado por otra persona del equipo.
```

La prueba de un README es empírica: **alguien que no lo escribió clona el repositorio en una carpeta nueva y sigue las instrucciones al pie de la letra**. Todo lo que tenga que preguntar, adivinar o resolver por su cuenta es lo que le falta al README.

### El modelo de arquitectura actual

El diagrama de arquitectura que entregamos al final no es el que dibujamos al principio, sino el que describe el sistema **como está construido hoy**. Si no coincide con el código, no documenta nada: confunde.

No hace falta una notación compleja. El modelo C4 propone describir un sistema en niveles de zoom, y para un proyecto como el nuestro alcanzan dos:

- **Contexto**: el sistema como una caja, quién lo usa y con qué otros sistemas se relaciona. En nuestro caso, una sola usuaria y ninguna integración.
- **Componentes**: qué partes tiene adentro (pantallas, servicios, repositorios, base) y cómo dependen unas de otras. Acá es donde se ve si el dominio depende de la base o al revés.

```text
  ┌──────────────────────────────────────────────────────────┐
  │  App (MAUI)                                              │
  │  Pantallas ──► ViewModels                                │
  └──────────────────────┬───────────────────────────────────┘
                         │ usa
  ┌──────────────────────▼───────────────────────────────────┐
  │  Dominio                                                 │
  │  Servicios ──► CalculadoraDeRiesgo                       │
  │  Interfaces de repositorio (puertos)                     │
  └──────────────────────▲───────────────────────────────────┘
                         │ implementa
  ┌──────────────────────┴───────────────────────────────────┐
  │  Datos                                                   │
  │  Repositorios ──► SQLite                                 │
  └──────────────────────────────────────────────────────────┘
```

Lo importante del diagrama no son las cajas, sino las flechas: la dirección de las dependencias es la decisión de arquitectura más importante del proyecto, y es la que hay que poder explicar en la defensa.

### El registro de decisiones

En la unidad 2 vimos [el registro de decisión de arquitectura](../unidad-2/contenido.md#el-registro-de-la-decisión) (ADR): un documento breve, versionado junto al código, que se escribe en el momento en que se toma la decisión, con su contexto, la decisión y sus consecuencias.

Al cerrar el proyecto, la lista de ADR se vuelve el mapa de la defensa. Algunas decisiones de este dominio que merecen un registro:

- qué motor de base de datos usamos, y por qué;
- cómo se calcula el riesgo: qué señales combina, con qué pesos y con qué umbrales;
- qué pasa con los datos que faltan: un estudiante sin clases dictadas, sin trabajos o incorporado tarde;
- qué cuenta como clase dictada y qué cuenta como trabajo vencido;
- qué historias quedaron fuera del alcance, y por qué.

Las tres del medio no son detalles de implementación: son reglas de negocio que el cliente nunca dijo y que el equipo tuvo que decidir. Si no están escritas, nadie sabe que se decidieron.

### Aplicación al proyecto guía

En la revisión del 23/10 intentamos correr las siete aplicaciones siguiendo sólo lo que estaba escrito en cada repositorio. Cuatro no arrancaron sin pasos que no estaban documentados: cadenas de conexión a instancias que no existen, scripts que había que correr a mano en un orden que no figuraba en ningún lado, una base que sólo se crea con un programa aparte. En casi todos los casos el sistema funcionaba, pero sólo en una máquina.

También encontramos documentación desactualizada: un README que dice que algo se crea automáticamente cuando no es así, un documento que describe datos de ejemplo que ya no existen, un archivo de instrucciones que referencia otro archivo que nunca se escribió. La documentación desactualizada es peor que la ausente, porque se le cree.

Para el cierre, el repositorio de cada equipo debería tener, como mínimo:

| Documento | Dónde | Cómo sabemos que está bien |
|---|---|---|
| README | Raíz del repositorio | Alguien que no lo escribió lo sigue y el sistema corre |
| Modelo de arquitectura actual | `docs/arquitectura.md` | Las flechas coinciden con las referencias entre proyectos |
| Registro de decisiones | `docs/decisiones/` | Cada regla de negocio que no vino del cliente tiene su ADR |

### Anti-patrones frecuentes

- **El README de la plantilla**: el repositorio dice "Hello, World!" o no dice nada.
- **Instrucciones que funcionan en una sola máquina**: rutas absolutas, instancias de base con nombre propio, pasos que se dan por sabidos.
- **El diagrama del principio**: el que dibujamos antes de construir, que ya no se parece al sistema.
- **Documentar después, todo junto**: las decisiones se reconstruyen de memoria, y la memoria inventa.
- **Documentación que contradice al código**: se le cree, y por eso hace más daño que no tener nada.

### Síntesis

Documentar no es escribir mucho, sino escribir lo que alguien va a necesitar. Para nuestro proyecto eso es un README que permite correr el sistema en una máquina nueva, un diagrama de la arquitectura tal como está construida y el registro de las decisiones que la formaron, en especial las reglas de negocio que el equipo tuvo que decidir sin que el cliente las dijera. Y la única forma de saber si la documentación sirve es que la use alguien que no la escribió.

### Fuentes

- Beck, K. y otros (2001). *Manifiesto por el Desarrollo Ágil de Software*. https://agilemanifesto.org/iso/es/manifesto.html
- Procida, D. *Diátaxis: a systematic approach to technical documentation authoring*. https://diataxis.fr/
- Brown, S. *The C4 model for visualising software architecture*. https://c4model.com/ · Niveles de diagrama: https://c4model.com/diagrams
- Nygard, M. (2011). "Documenting Architecture Decisions". https://cognitect.com/blog/2011/11/15/documenting-architecture-decisions.html
- GitHub. "Acerca de los archivos README". https://docs.github.com/es/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/about-readmes
- *Make a README*. https://www.makeareadme.com/

--------

# La demostración y la defensa

### Antes de comenzar...

- ¿qué tiene que entender el cliente al terminar la demo?
- si nos preguntan "¿por qué lo hicieron así?", ¿qué contestamos además de "porque funciona"?
- ¿qué hacemos con lo que no llegamos a terminar?

>El propósito de la Sprint Review es inspeccionar el resultado del Sprint y determinar futuras adaptaciones. El Scrum Team presenta los resultados de su trabajo a los interesados clave y se discute el progreso hacia el Objetivo del Producto.
>
>[The Scrum Guide (2020) - Ken Schwaber y Jeff Sutherland, sección "Sprint Review"](https://scrumguides.org/scrum-guide.html) (traducción propia)

### La demo cuenta una historia

Una demo no es un recorrido por las pantallas, sino una historia que empieza en el problema del cliente y termina en la decisión que el sistema le permite tomar. En nuestro caso, la historia ya está escrita en el encargo: alguien que sigue una comisión quiere saber, el lunes a la mañana, a quién tiene que llamar esta semana.

Una estructura que funciona:

| Momento | Qué mostramos | Cuánto tiempo |
|---|---|---|
| **1. El problema** | La pregunta del cliente, en sus palabras | Unos segundos |
| **2. El recorrido** | Los datos cargándose, con una comisión que parezca real | La mayor parte |
| **3. La respuesta** | El panel ordenado, y por qué cada estudiante está donde está | El momento central |
| **4. Lo que falta** | Qué no llegamos a hacer, y por qué quedó afuera | Unos segundos |

El momento 3 es el que justifica todo el sistema. Si al terminar la demo el cliente no sabe a quién tiene que llamar ni por qué, la demo no cumplió su propósito, aunque todas las pantallas hayan funcionado.

### Hablar con alguien que no es técnico

El cliente no evalúa el código, evalúa si el sistema le resuelve el problema. Por eso la demo se hace en el lenguaje del dominio, el mismo que fijamos en el modelo de dominio de la unidad 2:

- decimos "registrar la asistencia de la clase del lunes", no "hacer un insert en la tabla de asistencias";
- decimos "la historia de la ficha del estudiante", no "H9";
- mostramos el sistema funcionando, no el código ni las diapositivas;
- y cuando algo no anda, lo decimos antes de que el cliente lo descubra.

### Preparar la demo

Una demo se prepara como se prepara cualquier otra entrega:

- **datos creíbles**: una comisión con nombres reales, algunos estudiantes en riesgo y otros no, y por lo menos un caso borde que muestre que el cálculo lo resuelve. Con "Prueba 1" y "Prueba 2" el cliente no puede imaginar su propia comisión;
- **el sistema corriendo antes de empezar**, desde la rama principal, con la base ya cargada;
- **un guion**: qué se muestra, en qué orden y quién lo muestra;
- **un ensayo**, con el tiempo medido;
- **un plan B**: si algo falla, qué mostramos en su lugar.

### La defensa: fundamentar una decisión

En la defensa individual no alcanza con contar qué hicimos. Hay que poder explicar por qué. Una decisión bien fundamentada tiene cuatro partes, y son las mismas que las de un ADR:

> **Decidimos** *qué*, **porque** *el motivo, en términos del problema*, **a costa de** *lo que resignamos*, y **lo revisaríamos si** *lo que tendría que cambiar*.

Por ejemplo:

> Decidimos excluir del cálculo las clases que todavía no se dictaron, porque el riesgo tiene que medir lo que ya pasó, a costa de que el porcentaje se mueva mucho al principio del cuatrimestre, cuando hay pocas clases. Lo revisaríamos si el cliente prefiriera no ver alertas en las primeras semanas.

Las preguntas que hay que poder contestar sobre el propio proyecto:

- ¿cómo está organizado el sistema y por qué las dependencias van en esa dirección?;
- ¿cómo se calcula el riesgo y qué pasa en los casos borde?;
- ¿cómo sabemos que el cálculo está bien?: ¿qué pruebas lo verifican?;
- ¿qué parte construí yo, y qué decisiones tomé en ella?;
- ¿qué haríamos distinto si empezáramos de nuevo?

La última pregunta no es una trampa. Reconocer qué salió mal y qué aprendimos es parte de evaluar los resultados del proyecto, y muestra más dominio del tema que defender cada decisión como si hubiera sido perfecta.

### Aplicación al proyecto guía

En la revisión del 23/10 aparecieron varias cosas que en una demo frente al cliente juegan en contra:

- portadas que dicen "INICIO DE DEMOSTRACIÓN" o "Hello, World!", y menús con los códigos de las historias ("Calendario(H2)");
- datos de ejemplo que hacen aparecer a casi todos los estudiantes con riesgo máximo, con lo que el panel no le dice nada al cliente;
- botones que no hacen nada, o que responden "todavía no está implementado".

Nada de eso es grave en el código, pero en la demo le dice al cliente que el sistema no está terminado, aunque lo esté. Para la evaluación final:

1. preparar una comisión de demostración con datos creíbles y con los casos borde resueltos a la vista;
2. sacar de las pantallas todo lo que esté dirigido al equipo y no a la usuaria;
3. lo que no esté implementado, sacarlo o deshabilitarlo, y contarlo en el momento 4 de la demo;
4. que cada integrante pueda contar, con las cuatro partes, al menos dos decisiones que tomó.

### Anti-patrones frecuentes

- **El tour de pantallas**: se muestra todo lo que el sistema hace, y el cliente no se entera de para qué sirve.
- **Datos de prueba sin sentido**: "aaa", "Prueba 1", un solo estudiante.
- **Mostrar código al cliente**: le hablamos a la persona equivocada en el idioma equivocado.
- **Esconder lo que no funciona**: el cliente lo descubre igual, y además deja de confiar en lo que sí funciona.
- **"Eso lo hizo mi compañero"**: en la defensa individual cada integrante responde por el sistema completo, aunque haya construido una parte.
- **Defender todo como perfecto**: una decisión sin costos no fue evaluada, fue defendida.

### Síntesis

La demo es una historia que parte del problema del cliente y termina en la decisión que el sistema le permite tomar, contada en el lenguaje del dominio y con datos creíbles. La defensa es la capacidad de explicar cada decisión con su motivo, su costo y lo que la haría cambiar, que es exactamente la estructura de un ADR. Y reconocer lo que salió mal es parte de evaluar el proyecto, no una debilidad de la defensa.

### Fuentes

- Schwaber, K. y Sutherland, J. (2020). *The Scrum Guide*, sección "Sprint Review". https://scrumguides.org/scrum-guide.html · Versión en castellano: https://scrumguides.org/docs/scrumguide/v2020/2020-Scrum-Guide-Spanish-Latin-South-American.pdf
- Nygard, M. (2011). "Documenting Architecture Decisions". https://cognitect.com/blog/2011/11/15/documenting-architecture-decisions.html
- Evans, E. (2003). *Domain-Driven Design*, Addison-Wesley, cap. 2, "Communication and the Use of Language" (lenguaje ubicuo), ya trabajado en la unidad 2.
