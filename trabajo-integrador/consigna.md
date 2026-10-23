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

## ¿Cómo evaluamos la calidad del producto?

> La calidad no se trata de que el código sea elegante, sino de que el sistema se pueda cambiar sin miedo y se pueda usar sin que nadie lo explique.

En esta segunda mitad, además de qué historias funcionan, vamos a mirar cómo están construidas. No vamos a evaluar todo lo que se puede decir de un diseño: elegimos siete puntos concretos, que se pueden verificar en pocos minutos y que ustedes mismos pueden revisar antes de cada entrega. Lo importante es que **cada ítem se comprueba en el código o en la app**, no se discute de memoria: si no se puede mostrar, no cumple.

### En el código

**1. Métodos chicos.** Ningún método supera las 20 líneas ni una complejidad ciclomática de 10. La complejidad cuenta los caminos posibles dentro de un método: cada `if`, cada ciclo y cada `&&` suma uno. Se ve en Visual Studio con *Analizar → Calcular métricas de código*, en las columnas de líneas de código ejecutable y complejidad ciclomática. Un método largo casi siempre está haciendo más de una cosa.

**2. Cada cosa en su capa.** Las pantallas (`.xaml.cs`) no tienen lógica: sólo `InitializeComponent`, el `BindingContext` y, como mucho, avisarle al ViewModel que la página apareció. Las reglas del negocio, como el cálculo del riesgo o el orden del panel, viven en el dominio y no en el ViewModel. La pregunta para hacerse es: ¿podríamos calcular el riesgo sin abrir ninguna pantalla?

**3. Las dependencias apuntan al dominio.** Las entidades y los servicios no tienen `using` de MAUI ni de la base de datos, y ningún ViewModel hace `new` de un repositorio: lo recibe por el constructor. Se verifica buscando esos textos en el código. Si cambiamos de base de datos, el dominio no se tendría que enterar.

**4. Cada dato escrito una sola vez.** Los estados ("Presente", "Ausente"), los niveles de riesgo y los umbrales se definen en un solo lugar y se usan desde ahí. Se verifica buscando el texto: si aparece escrito en tres archivos, cuando cambie vamos a tener que acordarnos de los tres.

**5. Las reglas están probadas.** Hay tests del cálculo de riesgo, incluidos los casos borde: un estudiante sin clases registradas, sin trabajos, o que se incorporó tarde. Esos casos son justamente donde el cálculo se rompe, y un test los encuentra antes que la clienta.

### En la aplicación

**6. El recorrido completo funciona desde la rama integrada.** Cargar la nómina, registrar asistencia y entregas, y ver el panel ordenado, con datos reales y de punta a punta. Evaluamos lo que está integrado en la rama principal del equipo: lo que vive sólo en una rama de feature, para nosotros todavía no existe.

**7. Las entradas están validadas.** Los campos vacíos, los duplicados y los formatos inválidos se rechazan con un mensaje que le dice a quien usa el sistema qué hacer, no sólo que algo salió mal. Se verifica probando cada formulario con datos incorrectos a propósito.

### ¿Cómo se califica?

Cada ítem queda en uno de tres estados: **cumple**, **a mejorar** o **no cumple**. No hay puntaje por ítem ni promedio: lo que vamos a mirar en la entrega final es que los "no cumple" de la revisión anterior se hayan resuelto. Antes de cada entrega, recorran ustedes los siete puntos: es la misma revisión que vamos a hacer nosotros.

---

## ¿Cómo medimos la participación de cada integrante?

> El trabajo en equipo no se trata de cuánto produce cada uno, sino de cuánto se compromete cada uno con el trabajo del equipo.

A lo largo de la cursada vamos a mirar, con frecuencia, cuánto empuja cada integrante el proyecto: la constancia semana a semana, los commits en el repositorio y la actividad en Trello. No medimos volumen ni producción, sino que cada uno esté trabajando y que se vea. El resultado no es una nota sino una de tres categorías (*según lo esperado*, *por debajo de lo esperado* o *poco o nada de participación*), y sirve para detectar a tiempo si alguien está quedando afuera. Lo importante es que **lo que no está registrado no lo podemos ver**: si trabajan en pareja, agreguen al commit una línea `Co-authored-by: Nombre Apellido <email>` por cada compañero, y en Trello asignen la tarjeta a todos los que trabajaron en ella.
