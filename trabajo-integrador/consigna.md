# El proyecto de la cursada — dominio propuesto

Documento de cátedra. Define el dominio sobre el que trabajan todos los equipos, su alcance, cómo se reparte en los sprints disponibles y qué hace el docente en su rol de cliente.

## El dominio

> **Seguimiento de cursada y alerta temprana.** Un panel para que quien sigue una comisión sepa a qué estudiantes contactar esta semana, antes de que abandonen.

Se registra la asistencia y las entregas de trabajos, el sistema calcula un indicador de riesgo por estudiante, lo muestra en un panel ordenado por prioridad, y guarda qué se hizo con cada uno.

**La pregunta que el sistema contesta:** *¿a quién llamo esta semana?*

Es una pregunta que no se responde mirando una planilla, y ese es todo el punto: los datos existen, están dispersos, y hasta que alguien no los cruza y los ordena no hay decisión posible. Un equipo que entrega el registro de asistencia y se detiene ahí construyó un sistema transaccional y no llegó a la materia.

## El encargo, como lo recibe el equipo

> Sigo dos comisiones de primer año. Entre las dos son unos sesenta estudiantes. Todos los años pasa lo mismo: en la semana doce me doy cuenta de que hay cinco o seis que no vienen hace un mes, y cuando los llamo ya consiguieron trabajo, ya se anotaron en otra cosa, o directamente no contestan. Y siempre pienso lo mismo: si me daba cuenta en la semana cuatro, capaz que a dos de esos cinco los recuperaba.
>
> Tengo la información. Tomo asistencia todas las clases y anoto quién entregó los trabajos. El problema es que la asistencia está en un cuaderno, las entregas están en el aula virtual, y para saber cómo viene alguien tengo que ponerme a cruzar las dos cosas a mano. Nunca lo hago, porque lleva una tarde entera.
>
> Lo que necesito es simple de decir y no sé si es simple de hacer: quiero abrir algo el lunes a la mañana y que me diga a quién tengo que llamar esta semana.

**El único usuario es quien sigue la comisión.** Una sola persona opera el sistema.

---

## Alcance: once historias en cinco specs

Esta es la referencia de tamaño de la cátedra, no una asignación. **El backlog lo arma cada equipo relevando**.

| Spec | Historias | |
|---|---|---|
| **1 · Cursada y comisión** | H1 | Cargar y ver la nómina de estudiantes de una comisión |
| | H2 | Definir el calendario de clases y de trabajos del cuatrimestre |
| **2 · Registro de asistencia y entregas** | H3 | Registrar la asistencia de una clase |
| | H4 | Corregir la asistencia de una fecha ya registrada |
| | H5 | Registrar la entrega o no entrega de un trabajo |
| **3 · Indicador de riesgo** | H6 | Calcular el riesgo de cada estudiante a partir de asistencia y entregas |
| | H7 | Configurar los umbrales del cálculo sin tocar el código |
| **4 · Panel de seguimiento** | H8 | Ver la comisión ordenada por riesgo, con el detalle que justifica cada valor |
| | H9 | Ver la ficha de un estudiante con su historial |
| **5 · Intervenciones** | H10 | Registrar un contacto con un estudiante y su resultado |
| | H11 | Que el panel muestre a quién ya se contactó y cuándo |

### El esqueleto mínimo

Cuatro historias forman el recorrido completo de punta a punta, y son las que el Product Owner prioriza primero: **H1 → H3 → H6 → H8**. Cargar la nómina, registrar asistencia, calcular riesgo, ver la lista ordenada.

**Van las cuatro en versión mínima, no completas.** Esto es lo que hace viable el orden:

| | Entra en el esqueleto | Queda para después |
|---|---|---|
| H1 · Nómina | Carga manual de estudiantes y verlos | Edición, validaciones, importación desde archivo |
| H3 · Asistencia | Marcar presentes de una fecha y guardar | Corrección (H4), cierre de planilla, ausencias justificadas |
| H6 · Riesgo | **Sólo inasistencias, con umbral fijo escrito en el código** | Incorporar entregas, ponderar señales, configurar el umbral (H7) |
| H8 · Panel | Lista ordenada de mayor a menor riesgo, con el dato que lo justifica | Ficha del estudiante (H9), filtros, marcas de contacto (H11) |

Con esas cuatro versiones flacas el sistema ya contesta *a quién llamo esta semana*, de manera tosca y con una sola señal. Todo lo demás lo engorda.

### Por qué el indicador va temprano y no al final

**El riesgo del proyecto está en el indicador, no en el registro.** Nadie se va a sorprender escribiendo una pantalla de carga: eso ya lo saben hacer. Lo que nadie sabe todavía es qué señales predicen el abandono, cómo se combinan y con qué umbral. Ahí es donde el equipo se puede equivocar, y donde **la clienta misma se contradice**: dice que la señal principal es la asistencia, pero todos los casos concretos que cuenta empezaron por dejar de entregar. Si eso aparece en el sprint 8, está mal y ya no hay tiempo. Construir primero lo conocido y dejar lo incierto para el final concentra todo el riesgo en el momento de menor margen.

**Ordenar por dependencia de datos es rebanar por capas con otro nombre.** Si el criterio es "primero todo lo que carga datos, después lo que los usa", el resultado es que hasta el sprint 7 no hay nada demostrable ante el cliente. En la clase 8 los equipos demostrarían pantallas de carga, y la pregunta de la evaluación —qué decisión habilita esta pantalla— se quedaría sin respuesta. La primera evaluación reprobaría su propio criterio.

**Calcular no necesita las historias completas, necesita algún dato.** Para computar un porcentaje de inasistencias alcanzan una nómina cargada a mano y dos clases registradas. Las entregas, el calendario y la configuración del umbral no hacen falta para la primera versión: hacen falta para la buena. Eso es división por regla de negocio, uno de los patrones de división del tema 8.

### Ritmo sugerido hasta la primera evaluación

No es una asignación —el alcance de cada sprint lo define el equipo— pero es contra lo que el Product Owner prioriza:

| Sprint | Lo que debería estar |
|---|---|
| 1 | H1 y H3 mínimas: hay estudiantes cargados y asistencia registrada |
| 2 | **H6 y H8 mínimas: el sistema ya contesta la pregunta con una sola señal** |
| 3 | H5 y H6 con las dos señales: el indicador incorpora las entregas |
| 4 | H2 y H4: calendario y corrección. El panel se vuelve usable de verdad |
| 5 | H9 y estabilización para la demo |

El hito real es el **sprint 2**: a partir de ahí hay algo que mostrarle al cliente que responde a su pregunta, y todas las revisiones siguientes discuten si responde bien. Antes de eso las revisiones sólo pueden discutir si los datos entran.

### Qué debe existir en cada evaluación

| | **Primera evaluación (clase 8)** | **Entrega final (clase 12)** |
|---|---|---|
| Mínimo | El ciclo completo funcionando con datos reales: se carga, se calcula, se ve ordenado. El indicador usa al menos dos señales | Las once, o menos con el recorte fundamentado |
| Se demuestra | Que el panel ordena y que se entiende por qué cada estudiante está donde está | Que el sistema sostiene el ciclo completo, incluido el registro de intervenciones |
| Se pregunta | Qué decisión habilita cada pantalla | Lo mismo, más por qué se dejó afuera lo que se dejó |
| No alcanza | Ocho historias de carga y ninguna de indicador ni de panel | Un producto que no incorporó el cambio de requerimiento ni explica por qué |

---

## Qué se da y qué descubren

> **El Product Owner es dueño del alcance y de la prioridad. El equipo es dueño del descubrimiento y de la formulación.**

| Se da | Lo descubre el equipo |
|---|---|
| El dominio y el encargo | Cuáles son las señales de riesgo y cómo se combinan |
| La acotación: un solo usuario | Quiénes son los actores y las partes interesadas |
| Las cinco specs y **los nombres de las once historias** | El "para" de cada una: qué decisión habilita |
| El esqueleto mínimo: qué debe correr en la clase 8 | Los criterios de aceptación de cada historia |
| [Una historia de referencia](historia-de-referencia.md), resuelta entre todos en la clase 1 | La división de las que no entran en un sprint |
| El formato de los criterios de aceptación | La estimación y el orden del resto del backlog |
| El cambio de requerimiento de la clase 9 | Los requerimientos no funcionales y los umbrales |

---

## ¿Cómo medimos la participación de cada integrante?

> El trabajo en equipo no se trata de cuánto produce cada uno, sino de cuánto se compromete cada uno con el trabajo del equipo.

A lo largo de la cursada vamos a medir, con frecuencia, el esfuerzo que dedica cada integrante al proyecto. No medimos lo producido: si alguien resuelve en una hora lo que a otro le lleva tres, para nosotros vale lo mismo, porque están acá para aprender. Lo que queremos ver es que cada uno esté, semana a semana, empujando el trabajo. No es una nota: es una señal para nosotros y para ustedes, y sirve para detectar a tiempo si alguien está quedando afuera. Lo importante es que **lo que no está registrado no lo podemos ver**, así que el criterio premia trabajar a la vista.

### Las tres señales

**1. Constancia (40%).** Contamos las semanas en las que cada integrante trabajó en el proyecto. Una semana cuenta si hubo al menos un commit o una actividad en Trello, sin importar si fue un día o todos los días: trabajar un poco cada día o mucho en un solo día vale lo mismo.

**2. Commits (35%).** Cada commit, en cualquier rama, se dimensiona según su tamaño y suma un tiempo estimado:

| Tamaño | Líneas agregadas y borradas | Tiempo que suma |
|---|---|---|
| Chico | Hasta 30 | 0,5 h |
| Mediano | De 31 a 200 | 1,5 h |
| Grande | Más de 200 | 3 h |

Todo commit es, como mínimo, chico, aunque sólo toque un archivo de configuración o suba un documento. El tope de 3 h hace que pegar miles de líneas no valga más que un commit grande: lo que medimos es tiempo dedicado, no volumen. Para contar líneas no tenemos en cuenta `bin/`, `obj/`, `.vs/`, `TestResults/` ni los archivos que genera la plantilla del proyecto (`Platforms/`, `Resources/`, `.csproj`, `.slnx`, `App.xaml`, `MainPage`). Los merges no cuentan.

**3. Trello (25%).** Cada actividad en el tablero suma 1 punto: crear una tarjeta, comentar, moverla de lista, modificarla, adjuntar un archivo, asignar a alguien, completar un ítem de checklist.

Si un integrante usa más de un usuario o email, en GitHub o en Trello, los unificamos.

### ¿Y si trabajamos en pareja?

Cuando dos personas programan juntas y una sola hace el commit, la herramienta le atribuye todo el trabajo a quien commiteó. Para que eso no pase, el commit tiene que nombrar a todos los que participaron, agregando al final del mensaje una línea por cada compañero:

```
Co-authored-by: Nombre Apellido <email@ejemplo.com>
```

Cada coautor suma ese commit y esa semana igual que el autor. En Trello pasa lo mismo: **asignen a la tarjeta a todos los que trabajaron en ella**.

### ¿Cómo se convierte en un porcentaje?

Para cada señal calculamos qué parte del total del equipo aportó cada integrante, y las combinamos con los pesos de arriba: 40% constancia, 35% commits, 25% Trello.

Después suavizamos el resultado: a la participación de cada integrante le aplicamos la **raíz cuadrada** y volvemos a normalizar para que todo sume 100%. El orden no cambia y las distancias se acortan, porque siempre hay trabajo en conjunto que no queda registrado. Pero quien no registró ninguna actividad sigue en cero: suavizar no es regalar.

Por ejemplo, un reparto de 32 / 28 / 18 / 16 / 7 queda, después de suavizar, en 26 / 24 / 20 / 18 / 12.

### ¿Qué ven ustedes?

No publicamos el número exacto, sino una banda que compara a cada integrante contra el reparto parejo del equipo (100% dividido la cantidad de integrantes):

| Banda | Participación suavizada |
|---|---|
| Por encima de lo esperado | Más de 1,25 veces el reparto parejo |
| En lo esperado | Entre 0,75 y 1,25 veces |
| Por debajo de lo esperado | Menos de 0,75 veces |
| Sin participación registrada | Cero |

Además, avisamos cuando un integrante lleva **dos semanas o más sin actividad registrada**, porque es la señal más temprana de que alguien se está quedando afuera.

Una banda baja en una medición no es una sanción: es una conversación que tenemos que tener a tiempo. Lo que sí pesa es una banda baja sostenida durante varios sprints sin que el equipo lo haya planteado en la retrospectiva.
