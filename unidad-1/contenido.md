# Identificación y análisis de la problemática

## Índice

<!-- TOC depthFrom:1 depthTo:3 -->

- [Identificación y análisis de la problemática](#identificación-y-análisis-de-la-problemática)
  - [Estructura de la unidad](#estructura-de-la-unidad)
    - [Finalidad: ¿Para qué?](#finalidad-para-qué)
    - [Fundamentos: ¿Por qué?](#fundamentos-por-qué)
    - [Mecanismos: ¿Cómo?](#mecanismos-cómo)
    - [Material](#material)
    - [Conocimiento necesario](#conocimiento-necesario)
- [Sistemas: elementos, límites, entorno y limitaciones](#sistemas-elementos-límites-entorno-y-limitaciones)
    - [Qué es un sistema](#qué-es-un-sistema)
    - [El límite](#el-límite)
    - [Limitaciones](#limitaciones)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes)
    - [Síntesis](#síntesis)
- [Sistemas de información en la organización](#sistemas-de-información-en-la-organización)
    - [Dato, información y conocimiento](#dato-información-y-conocimiento)
    - [Los niveles de la organización](#los-niveles-de-la-organización)
    - [Decisiones estructuradas y no estructuradas](#decisiones-estructuradas-y-no-estructuradas)
    - [Los tres tipos de sistema](#los-tres-tipos-de-sistema)
    - [Los cinco supuestos falsos de Ackoff](#los-cinco-supuestos-falsos-de-ackoff)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-1)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-1)
    - [Síntesis](#síntesis-1)
- [Contextualización del problema](#contextualización-del-problema)
    - [Qué es un problema](#qué-es-un-problema)
    - [Problema, síntoma y solución disfrazada](#problema-síntoma-y-solución-disfrazada)
    - [Las preguntas de Gause y Weinberg](#las-preguntas-de-gause-y-weinberg)
    - [La estructura del enunciado](#la-estructura-del-enunciado)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-2)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-2)
    - [Síntesis](#síntesis-2)
- [Identificación de actores, usuarios y partes interesadas](#identificación-de-actores-usuarios-y-partes-interesadas)
    - [El actor como rol](#el-actor-como-rol)
    - [Partes interesadas](#partes-interesadas)
    - [El sujeto de datos](#el-sujeto-de-datos)
    - [Niveles de objetivo](#niveles-de-objetivo)
    - [Procedimiento de identificación](#procedimiento-de-identificación)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-3)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-3)
    - [Síntesis](#síntesis-3)
- [Relevamiento de necesidades de información](#relevamiento-de-necesidades-de-información)
    - [El problema de fondo](#el-problema-de-fondo)
    - [Entrevista](#entrevista)
    - [Observación](#observación)
    - [Análisis documental](#análisis-documental)
    - [Cuestionario](#cuestionario)
    - [El vocabulario del cliente](#el-vocabulario-del-cliente)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-4)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-4)
    - [Síntesis](#síntesis-4)
- [Identificación y análisis de requerimientos](#identificación-y-análisis-de-requerimientos)
    - [De la nota al requerimiento](#de-la-nota-al-requerimiento)
    - [Atributos de un requerimiento utilizable](#atributos-de-un-requerimiento-utilizable)
    - [Los siete pecados del especificador](#los-siete-pecados-del-especificador)
    - [Verificabilidad](#verificabilidad)
    - [Diseño dentro del requerimiento](#diseño-dentro-del-requerimiento)
    - [Trazabilidad y priorización](#trazabilidad-y-priorización)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-5)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-5)
    - [Síntesis](#síntesis-5)
- [Requerimientos funcionales y no funcionales](#requerimientos-funcionales-y-no-funcionales)
    - [La distinción](#la-distinción)
    - [FURPS+ como grilla de descubrimiento](#furps-como-grilla-de-descubrimiento)
    - [Formulación verificable](#formulación-verificable)
    - [Dónde se documentan](#dónde-se-documentan)
    - [Restricción impuesta y atributo elegido](#restricción-impuesta-y-atributo-elegido)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-6)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-6)
    - [Síntesis](#síntesis-6)
- [Épicas, historias de usuario y criterios de aceptación](#épicas-historias-de-usuario-y-criterios-de-aceptación)
    - [Origen y función](#origen-y-función)
    - [Las 3 C](#las-3-c)
    - [La plantilla](#la-plantilla)
    - [Épica](#épica)
    - [INVEST](#invest)
    - [Criterios de aceptación](#criterios-de-aceptación)
    - [División de historias](#división-de-historias)
    - [Estimación y backlog](#estimación-y-backlog)
    - [Relación con la especificación](#relación-con-la-especificación)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-7)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-7)
    - [Síntesis](#síntesis-7)
- [Alcance, supuestos y restricciones](#alcance-supuestos-y-restricciones)
    - [Alcance](#alcance)
    - [Supuestos](#supuestos)
    - [Restricciones](#restricciones)
    - [El triángulo invertido](#el-triángulo-invertido)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-8)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-8)
    - [Síntesis](#síntesis-8)
- [Los hilos que atraviesan la unidad](#los-hilos-que-atraviesan-la-unidad)

<!-- /TOC -->

## Estructura de la unidad

### Finalidad: ¿Para qué?

- delimitar el sistema y justificar qué queda dentro y qué queda fuera;
- distinguir qué tipo de sistema de información se está construyendo y qué decisión apoya;
- enunciar el problema sin nombrar la solución;
- relevar las necesidades de información con técnicas elegidas y fundamentadas;
- y convertir ese relevamiento en requerimientos analizados, priorizados y verificables.

El propósito de esta unidad es construir el insumo sobre el cual se diseña: un problema comprendido, con sus actores identificados, sus necesidades de información relevadas y sus requerimientos formulados de manera que pueda comprobarse si se cumplieron. Nada de eso determina todavía qué se va a construir, y esa separación es deliberada.

La unidad se apoya en una distinción que atraviesa toda la materia: el problema pertenece al dominio del cliente y existe con independencia de que se construya software; la solución es una producción del equipo. Un enunciado de problema que nombra un sistema, una pantalla o una tecnología dejó de ser un enunciado de problema y pasó a ser una solución escrita al revés, con la particularidad de que ya no puede evaluarse, porque no hay contra qué compararla.

La segunda distinción que organiza el trabajo es la que separa **registrar** de **informar**. Un sistema que acumula datos no produce información por acumulación: la información supone una pregunta previa y un criterio de relevancia. Toda la unidad se ordena alrededor de identificar cuál es esa pregunta y quién la formula.

### Fundamentos: ¿Por qué?

- el límite de un sistema no viene dado por el enunciado: es una decisión del observador, y por lo tanto requiere justificación;
- a quien decide no le falta información, le sobra: el problema no es de cantidad sino de relevancia;
- las personas no saben enunciar qué información necesitan, pero sí describir qué hicieron;
- un requerimiento que no puede verificarse no puede darse por terminado;
- y el supuesto que no se escribe no se revisa, y reaparece cuando ya hay construcción encima.

El concepto de **relevancia** adquiere centralidad. Un sistema de información no se evalúa por el volumen de datos que presenta sino por su capacidad de reducir la incertidumbre de una decisión concreta que una persona concreta debe tomar en un momento concreto. De ahí se deriva el criterio con que se evalúa cada funcionalidad a lo largo del proyecto: qué decisión habilita. Una funcionalidad que no habilita ninguna decisión no está incompleta, está de más, y su costo no es sólo el de construirla sino el de competir por la atención del usuario con las que sí habilitan una.

De ahí se sigue también el tratamiento del alcance. Si la información relevante es escasa y la disponible es abundante, el trabajo de análisis consiste tanto en incorporar como en descartar, y **el descarte fundamentado tiene el mismo valor que la incorporación**. Un backlog donde todo es prioritario no está priorizado, del mismo modo que un conjunto de requerimientos no funcionales copiado de una lista genérica no fue analizado.

### Mecanismos: ¿Cómo?

El análisis de una problemática no se realiza mediante una técnica única ni produce un artefacto único. Se realiza mediante un conjunto articulado de delimitaciones, técnicas de relevamiento y formulaciones verificables:

- delimitación del sistema, su entorno, sus entradas y sus salidas;
- clasificación de las necesidades de información según el nivel de decisión al que sirven;
- enunciado del problema y descripción de la situación actual;
- identificación de actores, usuarios, partes interesadas y sujetos de datos;
- entrevista, observación, análisis documental y cuestionario;
- construcción del glosario del dominio;
- análisis, desambiguación y priorización de requerimientos;
- clasificación en funcionales y no funcionales, y formulación de estos últimos como medidas;
- escritura de épicas, historias de usuario y criterios de aceptación;
- y declaración escrita de alcance, supuestos y restricciones.

### Material

- [Manifiesto por el Desarrollo Ágil de Software](https://agilemanifesto.org/iso/es/manifesto.html) y sus [doce principios](https://agilemanifesto.org/iso/es/principles.html)
- [Management Misinformation Systems](https://doi.org/10.1287/mnsc.14.4.B147) — Russell Ackoff
- [A Framework for Management Information Systems](https://hdl.handle.net/1721.1/47936) — Gorry y Scott Morton
- [On Formalism in Specifications](https://se.inf.ethz.ch/~meyer/publications/ieee/formalism.pdf) — Bertrand Meyer
- [Writing Effective Use Cases](https://kurzy.kpi.fei.tuke.sk/zsi/resources/CockburnBookDraft.pdf) — Alistair Cockburn
- [The Mom Test](https://www.momtestbook.com/) — Rob Fitzpatrick
- [INVEST in Good Stories, and SMART Tasks](https://xp123.com/invest-in-good-stories-and-smart-tasks/) — Bill Wake
- [Introducing BDD](https://dannorth.net/blog/introducing-bdd/) — Dan North
- [Ley N° 25.326 de Protección de los Datos Personales](https://www.argentina.gob.ar/normativa/nacional/ley-25326-64790/actualizacion)
- [Fuentes completas y ampliadas de la unidad](../Docs/CONTENIDOS.md)

### Conocimiento necesario

- Modelado en UML, casos de uso y diagramas de clases, provenientes de Modelado y Diseño de Software y de Desarrollo de Sistemas Orientado a Objetos.
- Nociones de organización y procesos, provenientes del trayecto previo.
- [El dominio del proyecto guía](../trabajo-integrador/consigna.md) y [la historia de usuario de referencia](../trabajo-integrador/historia-de-referencia.md).
- Los ejercicios de esta unidad están en [ejercitaciones.md](ejercitaciones.md).

> **Sobre las citas.** Cada referencia indica capítulo y sección, porque la paginación cambia entre ediciones y entre las versiones en inglés y en castellano. Se indican páginas cuando la fuente es un artículo. Los enlaces fueron verificados el 14-09-2026.

--------

# Sistemas: elementos, límites, entorno y limitaciones

### Qué es un sistema

Un sistema es un conjunto de **elementos interrelacionados** que funcionan conjuntamente con un **propósito**. Las tres condiciones son necesarias y ninguna es suficiente por sí sola: existen partes identificables, esas partes se relacionan de modo que lo que ocurre en una afecta a otra, y el conjunto persigue un fin que ninguna parte alcanza de manera aislada.

De allí se deriva la propiedad con mayor consecuencia para el diseño de software.

>Un sistema no es la suma del comportamiento de sus partes: es el producto de sus interacciones.
>
>Russell Ackoff

Ackoff lo ilustra con el ejemplo del automóvil desarmado: la totalidad de las piezas dispuestas sobre el piso no conserva ninguna de las propiedades del automóvil, y ninguna pieza transporta a nadie. Lo formaliza en "Towards a System of Systems Concepts", donde define sistema, elemento, entorno y estado.

La consecuencia práctica es directa y contraintuitiva: es posible construir cada módulo correctamente y no obtener un sistema. Un registro de asistencia correcto, un cálculo de indicadores correcto y una pantalla de presentación correcta no producen alerta temprana si no están vinculados por un flujo que termine en una decisión.

### El límite

El límite es lo que separa el sistema del resto del mundo, y todo aquello que se encuentra fuera de él y lo afecta constituye su **entorno**.

Lo que cuesta aceptar, y sin embargo ordena toda la unidad, es que el límite no viene dado con el problema: se decide. Weinberg dedica los primeros capítulos de *An Introduction to General Systems Thinking* a mostrar que un sistema es un punto de vista sobre la realidad y no una porción de la realidad, y formula en el cuarto la Ley Ojo-Cerebro, según la cual capacidad de observación y capacidad de razonamiento se compensan mutuamente.

>Un sistema es una manera de mirar el mundo.
>
>An Introduction to General Systems Thinking - Gerald Weinberg

Dos equipos frente al mismo enunciado pueden trazar límites distintos y ambos ser correctos, siempre que puedan sostener el criterio con el que los trazaron. Lo que no es admisible es no haberlo trazado, porque en ese caso el límite queda definido por omisión y se expande hasta donde alcance el tiempo disponible.

El criterio operativo para determinarlo:

| Pregunta | Si la respuesta es afirmativa |
|---|---|
| ¿Lo construimos y podemos modificarlo? | Está **dentro** del sistema |
| ¿Nos afecta pero no lo controlamos? | Es **entorno** |
| ¿Ni nos afecta ni lo afectamos? | Está **fuera de consideración** |

Lo que atraviesa el límite son **entradas** —lo que el sistema recibe— y **salidas** —lo que entrega—. Identificarlas constituye la verificación más rápida de que el límite fue correctamente trazado: si existe una entrada que nadie provee o una salida que nadie consume, la delimitación es incorrecta.

### Limitaciones

Una **limitación** es una condición del entorno que el sistema no puede modificar y a la cual debe adaptarse. No se negocia: se planifica alrededor de ella.

Conviene separarla desde el inicio de la **decisión de alcance**, que es algo que el equipo eligió y que por lo tanto puede revisar. La confusión entre ambas tiene un costo concreto en las dos direcciones: se trata como fatalidad algo que era una decisión revisable, o se discute indefinidamente algo que ya estaba fijado. La distinción se retoma al tratar alcance y restricciones.

### Aplicación al proyecto guía

| | |
|---|---|
| **Dentro** | Registro de asistencia y entregas · cálculo de indicadores de riesgo · panel de seguimiento · alertas y umbrales · registro de intervenciones |
| **Entorno** | El sistema de gestión académica del instituto · el correo · el calendario académico · el estudiante · el tutor |
| **Entradas** | Nómina de estudiantes y comisiones · asistencia de cada clase · entregas registradas · umbrales configurados |
| **Salidas** | Listado priorizado de estudiantes a contactar · alertas · historial de intervenciones |
| **Limitaciones** | El instituto no expone su base de datos · el tutor trabaja con lo que registra manualmente · el cuatrimestre dura 16 semanas |

El estudiante pertenece al entorno: sus actos generan los datos que ingresan, pero no opera el sistema. El tutor también pertenece al entorno, precisamente porque es quien lo usa. Ninguna persona se ubica dentro del límite; dentro del límite está el software.

La caja del diagrama de casos de uso es la representación literal de ese límite, y los actores dibujados fuera de ella constituyen, por definición, el entorno. Es notación ya conocida por quienes cursaron Modelado y Diseño de Software, y su valor en esta instancia no es documental sino de control: obliga a que la delimitación quede explícita.

### Anti-patrones frecuentes

- **Tomar el límite como dado por el enunciado**: el enunciado describe una situación, no una delimitación. Quien no decide el límite lo hereda de sus propias suposiciones.
- **Ubicar personas dentro del límite**: dentro va el software; las personas son actores y pertenecen al entorno.
- **Confundir limitación con decisión de alcance**: produce resignación frente a lo revisable y discusión indefinida sobre lo que ya estaba fijado.
- **Un límite que abarca media institución**: vuelve el problema irresoluble con el presupuesto disponible y traslada la decisión de recorte al final del proyecto, cuando ya es cara.

### Síntesis

El límite del sistema es la primera decisión de alcance del proyecto y se toma antes de disponer de información suficiente, lo cual no la vuelve opcional sino revisable. Su verificación no requiere instrumentos: si toda entrada tiene quien la provea y toda salida tiene quien la consuma, la delimitación es coherente. Si alguna no lo tiene, el límite está mal trazado y conviene descubrirlo antes de construir.

### Fuentes

- Weinberg, G. (1975). *An Introduction to General Systems Thinking*, Dorset House (ed. Silver Anniversary, 2001), caps. 1-2 y cap. 4, "Interpreting Observations" (Ley Ojo-Cerebro).
- Ackoff, R. (1971). "Towards a System of Systems Concepts", *Management Science*, 17(11), pp. 661-671. https://doi.org/10.1287/mnsc.17.11.661
- Brooks, F. (1987). "No Silver Bullet: Essence and Accidents of Software Engineering", *IEEE Computer*, 20(4), sección "Essential Difficulties". https://worrydream.com/refs/Brooks_1986_-_No_Silver_Bullet.pdf
- Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 6, "Use Cases", sección sobre el límite del sistema en el diagrama de casos de uso.
- Ackoff, R. — "If Russ Ackoff had given a TED Talk…" (12 min). https://www.youtube.com/watch?v=OqEeIG8aPPk

--------

# Sistemas de información en la organización

Es el tema que da nombre a la materia y el que determina el criterio con el que se evalúa el proyecto completo.

### Dato, información y conocimiento

Un **dato** es el registro de un hecho, sin interpretación. La **información** son datos procesados y situados en un contexto tal que responden una pregunta. El **conocimiento** es la capacidad de actuar a partir de ella.

```text
  DATO           "Pérez estuvo ausente el 12/09"
                 Registro de un hecho. No responde nada por sí solo
        │
        ▼
  INFORMACIÓN    "Pérez acumula 4 inasistencias sobre 6 clases"
                 Datos procesados que responden una pregunta previa
        │
        ▼
  CONOCIMIENTO   "Pérez está en riesgo de abandono y corresponde contactarlo"
                 Capacidad de actuar a partir de la información
```

Ackoff ordena esta cadena en "From Data to Wisdom" y agrega una observación que conviene retener: los sistemas de información suelen ser muy eficaces produciendo datos y poco eficaces produciendo información, porque producir información exige conocer previamente cuál es la pregunta. Un sistema que presenta la totalidad de lo que registra no informa: le transfiere al usuario el trabajo de filtrar.

### Los niveles de la organización

Las necesidades de información varían según quién decide y sobre qué horizonte temporal. Gorry y Scott Morton retoman los tres niveles de control organizacional propuestos por Anthony y muestran que cada uno requiere información con características distintas.

| | **Operativo** | **Táctico (control de gestión)** | **Estratégico (planeamiento)** |
|---|---|---|---|
| Horizonte | El día, la semana | El mes, el cuatrimestre | Años |
| Agregación | Dato individual | Consolidado por grupo | Muy agregado |
| Origen | Interno | Interno | Interno y externo |
| Frecuencia | Alta, continua | Periódica | Baja, puntual |
| Precisión | Exacta | Alta | Estimada |
| En el dominio | El tutor: a quién contactar | La coordinación: cómo evoluciona la comisión | El rectorado: qué carreras retienen |

La consecuencia de diseño es que un mismo dato sirve a los tres niveles con distinto grado de agregación y distinto horizonte, y que una solución construida para un nivel no sirve para otro por el simple agregado de un filtro.

### Decisiones estructuradas y no estructuradas

El segundo eje del marco de Gorry y Scott Morton es el grado de estructura de la decisión, tomado del trabajo de Simon sobre decisiones programadas y no programadas.

Una decisión **estructurada** dispone de un procedimiento conocido y repetible, y admite automatización completa: calcular un porcentaje de asistencia. Una **semiestructurada** presenta una porción resoluble por procedimiento y otra que requiere criterio: determinar qué combinación de señales indica riesgo. Una **no estructurada** carece de procedimiento y se apoya en juicio y experiencia: decidir de qué modo abordar a una persona determinada.

El mismo marco recoge las tres fases de toda decisión —inteligencia, diseño y elección— y un sistema puede apoyar cualquiera de ellas, que no son equivalentes. La mayor parte del valor de un sistema de alerta temprana reside en la primera: advertir que existe una decisión pendiente que el usuario todavía no sabe que tiene.

### Los tres tipos de sistema

Del cruce de ambos ejes resultan los tres tipos. No se distinguen por la tecnología que emplean sino por la pregunta que responden.

##### Transaccional

Registra los hechos de la operación cotidiana. Alta frecuencia, dato detallado, precisión total, decisión estructurada o ausencia de decisión. Su función es capturar, validar y persistir sin pérdida. Constituye la base de los otros dos: sin un transaccional confiable, los demás producen respuestas erróneas con mayor elegancia.

##### De gestión

Consolida lo que el transaccional registró y lo compara contra lo esperado. Periódico, agregado, orientado al control; responde por la evolución. Su forma típica es el informe, y su forma más útil es el informe de excepción, que presenta únicamente aquello que se aparta de lo previsto.

##### De apoyo a la decisión

Sirve a una decisión semiestructurada o no estructurada. Es exploratorio y admite que el usuario modifique parámetros y observe el efecto. No decide: reduce la incertidumbre de quien decide.

### Los cinco supuestos falsos de Ackoff

Ackoff formuló en 1967 el argumento de referencia contra el sistema que presenta la totalidad de la información disponible. Identifica cinco supuestos que los diseñadores de sistemas de información dan por válidos y que raramente lo son.

>La mayoría de los sistemas de información gerencial se diseñan sobre el supuesto de que la deficiencia crítica bajo la cual operan los gerentes es la falta de información relevante.
>
>Management Misinformation Systems - Russell Ackoff

1. **Que a quien decide le falta información.** Habitualmente le sobra: lo que le falta es información *relevante*. El problema no es de cantidad sino de filtrado.
2. **Que corresponde entregarle la información que solicita.** Si no tiene claro cómo decide, no puede especificar qué necesita, y solicitará todo por precaución.
3. **Que disponiendo de la información necesaria decidirá mejor.** Únicamente si comprende cómo utilizarla.
4. **Que mayor comunicación entre áreas mejora el desempeño.** No necesariamente.
5. **Que no es necesario que comprenda cómo funciona el sistema, sólo cómo usarlo.** Sin comprenderlo no puede evaluar si el sistema le está entregando información incorrecta.

De los cinco, el primero ordena la materia completa. Si al usuario le sobra información, el sistema que agrega una pantalla más con todos los datos agrava el problema en lugar de resolverlo. Es la diferencia entre un informe y un tablero: el informe presenta lo ocurrido; el tablero se organiza alrededor de una decisión pendiente y ordena lo que presenta según la urgencia de esa decisión.

### Aplicación al proyecto guía

Los tres tipos coexisten en el mismo desarrollo:

| Tipo | Funcionalidad | Pregunta que responde | Nivel / estructura |
|---|---|---|---|
| Transaccional | Registrar la asistencia de la clase | ¿Qué ocurrió? | Operativo, estructurada |
| Transaccional | Registrar una entrega | ¿Qué ocurrió? | Operativo, estructurada |
| De gestión | Inasistencias acumuladas por comisión | ¿Cómo evoluciona contra lo esperado? | Táctico, estructurada |
| De gestión | Informe de estudiantes por debajo de un porcentaje de entregas | ¿Qué se aparta de lo previsto? | Táctico, semiestructurada |
| Apoyo a la decisión | Panel de riesgo ordenado por prioridad | ¿A quién contactar esta semana? | Táctico, semiestructurada |
| Apoyo a la decisión | Umbrales configurables y simulación | ¿Qué ocurre si cambio el criterio? | Táctico, no estructurada |
| Apoyo a la decisión | Historial de intervenciones y su resultado | ¿Qué funcionó en ocasiones anteriores? | Táctico, no estructurada |

Aquí se establece el criterio de evaluación que se aplica durante todo el proyecto: **cada equipo debe poder explicar qué decisión habilita cada pantalla que construye**. Una pantalla que no habilita ninguna decisión no está incompleta; está de más, y además compite por la atención del usuario con las que sí habilitan alguna.

### Anti-patrones frecuentes

- **Construir únicamente la capa transaccional y denominarla sistema de gestión**: es la desviación más frecuente y produce un registro de datos sin capacidad de decisión.
- **Confundir tablero con informe**: presentar todos los indicadores disponibles sin ordenarlos según la decisión que apoyan.
- **Suponer que un filtro adicional resuelve un problema de relevancia**: agregar filtros traslada al usuario el trabajo que el sistema debía realizar.
- **Atribuir la decisión al sistema**: en decisiones no estructuradas decide la persona, y el sistema que pretende decidir por ella termina siendo ignorado.

### Síntesis

La distinción entre los tres tipos de sistema no es taxonómica sino operativa: determina qué se construye y para quién. Un sistema de apoyo a la decisión no se obtiene agregando gráficos a uno transaccional, porque su diferencia no está en la presentación sino en que parte de una pregunta conocida y descarta todo lo que no contribuye a responderla. El primer supuesto falso de Ackoff es el fundamento de ese descarte y reaparece en cada decisión de alcance del proyecto.

### Fuentes

- Ackoff, R. (1967). "Management Misinformation Systems", *Management Science*, 14(4), pp. B147-B156. Los cinco supuestos se enumeran al comienzo del artículo. **Lectura obligatoria.** https://doi.org/10.1287/mnsc.14.4.B147
- Gorry, G. A. y Scott Morton, M. S. (1971). "A Framework for Management Information Systems", *Sloan Management Review*, 13(1), pp. 55-70. Copia del working paper MIT 510-71: https://hdl.handle.net/1721.1/47936
- Ackoff, R. (1989). "From Data to Wisdom", *Journal of Applied Systems Analysis*, 16, pp. 3-9.
- Laudon, K. y Laudon, J. *Sistemas de información gerencial*, Pearson, caps. 1-2 y cap. sobre inteligencia de negocios y toma de decisiones.

--------

# Contextualización del problema

### Qué es un problema

Un problema es la brecha entre una situación actual y una situación deseada, que le importa a alguien. Si falta alguno de los tres términos no hay problema que resolver: sin una situación actual descrita con evidencia se está diseñando sobre una suposición; sin situación deseada no existe criterio para determinar si la solución sirvió; y sin alguien a quien le importe no hay quien adopte el sistema.

### Problema, síntoma y solución disfrazada

Tres enunciados que se confunden con frecuencia y que conviene distinguir con precisión, porque conducen a productos distintos.

| | Definición | Ejemplo |
|---|---|---|
| **Síntoma** | Manifestación observable de la brecha | El tutor detecta tarde los abandonos |
| **Problema** | La brecha que lo produce | La información de asistencia y entregas está dispersa y sin consolidar, de modo que la señal de riesgo aparece cuando la intervención ya no es posible |
| **Solución disfrazada** | Un enunciado que ya decidió qué construir | No existe un sistema de seguimiento |

La verificación es rápida: si el enunciado nombra una tecnología, una pantalla o un sistema, se trata de una solución escrita al revés. Un enunciado de problema no debería contener la palabra "sistema".

### Las preguntas de Gause y Weinberg

Tres preguntas ordenan el trabajo previo a cualquier construcción.

##### ¿De quién es el problema?

No siempre pertenece a quien lo plantea. Quien solicita el sistema y quien padece el problema pueden ser personas distintas, y la solución se diseña para la segunda.

##### ¿Qué ocurre si no se hace nada?

Si la respuesta es que no ocurre nada grave, el problema está mal elegido o mal enunciado. La pregunta proporciona además la medida del valor, porque el costo de no resolverlo constituye el techo de lo que vale resolverlo.

##### ¿Se está resolviendo el problema o el que resulta cómodo resolver?

Es la más incómoda y la que más se elude. Los equipos tienden a redefinir el problema en dirección a lo que ya saben construir, y la redefinición ocurre sin que nadie la formule explícitamente.

### La estructura del enunciado

La plantilla del documento de Visión ordena las cinco piezas del enunciado:

> El problema de **[describir el problema]**, afecta a **[los interesados afectados]**, cuyo impacto es **[cuál es la consecuencia]**, y una solución exitosa permitiría **[cuál sería el beneficio]**.

En paralelo se describe la **situación actual**: de qué modo se resuelve hoy. Siempre existe un modo —una planilla, un cuaderno, la memoria de alguien— y describirlo es obligatorio por dos razones: constituye la línea de base contra la cual se compara la solución, y suele ser la mejor fuente de requisitos disponible, porque incorpora años de ajuste sobre el problema real.

### Aplicación al proyecto guía

Enunciado de referencia:

> El problema de **que la información de asistencia y entregas esté dispersa, sin consolidar y sin criterio de alerta**, afecta a **los tutores de comisión, que siguen varias comisiones simultáneamente**, cuyo impacto es que **el desenganche de un estudiante se detecta cuando ya dejó de cursar, siendo que la intervención era posible semanas antes**, y una solución exitosa permitiría **que el tutor sepa cada semana a qué estudiantes contactar, antes de que abandonen**.

Situación actual: la asistencia se registra en papel y se vuelca a una planilla de cálculo ocasionalmente; las entregas residen en el aula virtual; nadie cruza ambas fuentes. La señal de que alguien está por abandonar es que dejó de presentarse, y para entonces ya abandonó.

Tres enunciados defectuosos, con su diagnóstico:

| Enunciado | Defecto |
|---|---|
| "No existe un sistema que permita registrar la asistencia de los estudiantes." | Es una solución, no un problema. Nombra el sistema y la funcionalidad |
| "Los estudiantes abandonan la carrera." | Es un síntoma, y de un problema de escala mayor a la que el equipo puede abordar. No identifica quién decide ni qué información falta |
| "El instituto necesita mejorar sus indicadores de retención." | Interesado equivocado y decisión ausente. El sistema es para el tutor, y mejorar indicadores no es una decisión que alguien tome un día determinado |

### Anti-patrones frecuentes

- **Enunciar la solución en lugar del problema**: cierra el diseño antes de haberlo pensado y elimina toda posibilidad de evaluar alternativas.
- **Enunciar un síntoma**: conduce a soluciones que atienden la manifestación y dejan intacta la causa.
- **Omitir la situación actual**: descarta la fuente de requisitos más económica disponible y elimina la línea de base contra la cual medir la mejora.
- **Elegir un interesado que no es quien padece el problema**: produce un sistema correcto para la persona equivocada.

### Síntesis

El enunciado del problema es el artefacto contra el cual se evalúa todo lo demás, y su calidad se verifica por ausencia: no debe nombrar la solución. Las tres preguntas de Gause y Weinberg funcionan como control, y la tercera —si se está resolviendo el problema o el que resulta cómodo resolver— es la que con mayor frecuencia modifica el rumbo del proyecto, precisamente porque nadie la formula de manera espontánea.

### Fuentes

- Gause, D. y Weinberg, G. (1982). *Are Your Lights On? How to Figure Out What the Problem Really Is*, Dorset House. Libro completo, ~90 pp.; las preguntas se desarrollan en las partes I y II.
- Gause, D. y Weinberg, G. (1989). *Exploring Requirements: Quality Before Design*, Dorset House, parte I, sobre definición del problema y ambigüedad.
- Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 7, "Other Requirements", §7.6 "NextGen Example: (Partial) Vision" y §7.7 "Commentary: Vision".
- Christensen, C. y otros (2016). "Know Your Customers' Jobs to Be Done", *Harvard Business Review*. https://hbr.org/2016/09/know-your-customers-jobs-to-be-done
- Fowler, M. — "Observed Requirement", https://martinfowler.com/bliki/ObservedRequirement.html · "Feature Devotion", https://martinfowler.com/bliki/FeatureDevotion.html

--------

# Identificación de actores, usuarios y partes interesadas

### El actor como rol

Un **actor** es un rol externo al sistema que interactúa con él. La definición proviene de Jacobson y contiene una palabra decisiva: rol, no persona ni puesto.

La distinción tiene consecuencias de diseño. Una misma persona puede cumplir varios roles —el tutor que además coordina— y un mismo rol puede ser cumplido por muchas personas. Si se modelan personas o puestos, el modelo se invalida con la primera reorganización; si se modelan roles, sobrevive a ella.

Cockburn distingue el **actor primario**, que persigue un objetivo, inicia la interacción y utiliza el sistema para alcanzarlo, del **actor secundario o de soporte**, al que el sistema necesita para completar su trabajo. La distinción determina quién obtiene pantallas y quién no.

### Partes interesadas

Cockburn organiza el relevamiento alrededor de interesados e intereses: un interesado es cualquiera que tenga algo en juego en el comportamiento del sistema, lo utilice o no.

Todo usuario es interesado, pero no todo interesado es usuario. La distinción tiene efecto directo sobre el alcance: los intereses de quien no opera el sistema se satisfacen mediante salidas —un informe, una exportación—, no mediante pantallas propias. Confundir ambas categorías es la vía más rápida hacia la construcción de tres aplicaciones en lugar de una.

### El sujeto de datos

Existe una tercera figura que no es usuario ni interesado en el sentido clásico: aquella cuyos datos el sistema procesa sin que ella lo opere. La Ley 25.326 la denomina *titular de los datos* y le reconoce derechos —acceso, rectificación y supresión— con independencia de que interactúe con el sistema.

>Los datos objeto de tratamiento no pueden ser utilizados para finalidades distintas o incompatibles con aquellas que motivaron su obtención.
>
>[Ley N° 25.326, artículo 4, inciso 3](https://www.argentina.gob.ar/normativa/nacional/ley-25326-64790/actualizacion)

En este dominio la figura es central, porque el estudiante es titular de datos sobre su desempeño académico: no es usuario, no toma ninguna decisión sobre el sistema, y sin embargo el sistema tiene obligaciones respecto de él. De allí se derivan requerimientos concretos —control de acceso, finalidad declarada del tratamiento, plazo de conservación— que se retoman al tratar los requerimientos no funcionales.

### Niveles de objetivo

Cockburn propone tres alturas para describir aquello que un actor persigue, mediante la metáfora del mar:

| Nivel | Metáfora | Ejemplo en el dominio |
|---|---|---|
| Resumen | Nube / barrilete | Reducir el desgranamiento de la comisión |
| **Usuario** | **Mar** | **Identificar a los estudiantes en riesgo de esta semana** |
| Subfunción | Pez | Registrar la asistencia de una clase |

El nivel útil para relevar es el intermedio: un objetivo que una persona completa en una sola sesión de trabajo y que, al terminarlo, la deja satisfecha. El nivel superior resulta demasiado vago para construir y el inferior describe un paso y no un objetivo. Los equipos tienden a desplazarse hacia el nivel inferior porque es el que guarda mayor parecido con una pantalla.

### Procedimiento de identificación

Cinco preguntas agotan la lista de candidatos:

1. Quién va a operar el sistema.
2. Quién recibe algo que el sistema produce, sin operarlo.
3. Quién provee datos que el sistema necesita.
4. Con qué otros sistemas se establece comunicación.
5. Los datos de quién se procesan.

Las dos últimas son las que habitualmente se omiten, y son las que producen requerimientos de integración y de protección de datos que de otro modo aparecen tarde.

### Aplicación al proyecto guía

| Quién | Qué es | Interés | Cómo se satisface |
|---|---|---|---|
| Tutor de comisión | Actor primario, único usuario | Saber a quién contactar esta semana | Operando el sistema |
| Coordinación de carrera | Parte interesada | Conocer la evolución de la retención | Un informe exportable |
| Rectorado | Parte interesada | Indicadores institucionales | Fuera de alcance en esta versión |
| Estudiante | Sujeto de datos | Que sus datos se traten con finalidad legítima | Control de acceso y finalidad declarada |
| Sistema de gestión académica | Actor secundario | — | Importación de la nómina, si se decide |
| Servicio de correo | Actor secundario | — | Envío de alertas, si se decide |

La acotación que define el proyecto es la existencia de un único usuario. Sin esa restricción los equipos derivan hacia la construcción de un campus virtual, porque en cuanto el estudiante ingresa como actor primario aparecen autenticación, perfil, notificaciones y mensajería, y el alcance se multiplica sin que el problema original avance.

### Anti-patrones frecuentes

- **Enumerar puestos del organigrama en lugar de roles**: el modelo se invalida con la primera reorganización.
- **Incorporar actores por precaución**: cada actor agregado multiplica los casos de uso y el alcance.
- **Asignar pantalla propia a una parte interesada**: los intereses de quien no opera el sistema se satisfacen con salidas.
- **Describir objetivos a nivel de subfunción**: produce un catálogo de pantallas sin que el objetivo real quede formulado.

### Síntesis

La identificación de actores es una decisión de alcance disfrazada de tarea de análisis: cada actor primario incorporado agrega un conjunto completo de funcionalidad. La distinción entre usuario, parte interesada y sujeto de datos determina quién obtiene pantallas, quién obtiene salidas y frente a quién existen obligaciones sin que haya interacción. Las tres categorías tienen consecuencias distintas y ninguna es sustituible por otra.

### Fuentes

- Cockburn, A. (2000). *Writing Effective Use Cases*, Addison-Wesley, cap. 4, "Stakeholders and Actors", secciones "The Primary Actor", "Actors versus Roles", "Supporting Actors" y "Stakeholders"; cap. 5, "Three Named Goal Levels". Borrador público: https://kurzy.kpi.fei.tuke.sk/zsi/resources/CockburnBookDraft.pdf
- Jacobson, I., Booch, G. y Rumbaugh, J. (1999). *The Unified Software Development Process*, Addison-Wesley, caps. de captura de requisitos. Ed. en castellano: *El Proceso Unificado de Desarrollo de Software*, Addison-Wesley, 2000.
- Ley N° 25.326 de Protección de los Datos Personales, art. 2 (titular de los datos), art. 4 (calidad de los datos y finalidad), art. 5 (consentimiento) y arts. 14-16 (derechos de acceso, rectificación y supresión). https://www.argentina.gob.ar/normativa/nacional/ley-25326-64790/actualizacion
- Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 6, "Use Cases", secciones sobre actores y sus tipos.
- Fowler, M. — "Use Cases And Stories". https://martinfowler.com/bliki/UseCasesAndStories.html

--------

# Relevamiento de necesidades de información

### El problema de fondo

Las personas no saben enunciar qué información necesitan, pero sí saben describir qué hicieron. Es la consecuencia directa del segundo supuesto de Ackoff: quien no tiene claro cómo decide no puede especificar qué necesita para decidir, y por precaución solicitará todo.

De allí la regla que ordena el relevamiento completo: **preguntar por hechos del pasado y no por deseos sobre el futuro**. La pregunta por cómo se resolvió la última vez produce información verificable; la pregunta por lo que se querría tener produce cortesía.

### Entrevista

Es la técnica principal y la que con mayor frecuencia se aplica mal.

##### Preparación

Antes de la entrevista deben existir tres elementos escritos: el objetivo, la identificación de a quién se entrevista y por qué, y las preguntas. Una entrevista sin preparación se transforma en una conversación agradable de la que no resulta ningún requisito.

##### Estructura

Kendall y Kendall describen tres formas de ordenar las preguntas. La **pirámide** comienza con preguntas cerradas y específicas y se abre progresivamente, y resulta adecuada cuando el entrevistado está poco predispuesto. El **embudo** comienza abierta y se cierra, y es la más útil para relevar: primero la descripción general del trabajo, después el detalle. El **rombo** combina ambas y se aplica a entrevistas extensas.

##### Tipos de pregunta

La abierta, la cerrada y el sondeo. El sondeo —por qué, un ejemplo, cuándo fue la última vez— es donde aparece la información sustantiva, y es el que se omite cuando quien entrevista está concentrado en avanzar sobre su lista.

##### Las reglas de Fitzpatrick

*The Mom Test* se denomina así porque hasta la propia madre mentirá si se le pregunta si una idea es buena. Establece tres reglas: hablar de la vida del interlocutor y no de la propia idea; preguntar por hechos específicos del pasado y no por opiniones sobre el futuro; y escuchar más de lo que se habla.

| Pregunta defectuosa | Defecto | Reemplazo |
|---|---|---|
| ¿Te gustaría un sistema que te avise de los estudiantes en riesgo? | Solicita una opinión sobre una idea. La respuesta es afirmativa por cortesía | Contame la última vez que te enteraste tarde de que alguien abandonó. ¿Cómo te enteraste? |
| ¿Usarías un panel con indicadores? | Compromiso hipotético, sin costo para quien lo asume | ¿Qué hacés hoy para saber cómo evoluciona la comisión? ¿Cuánto tiempo te lleva? |
| ¿Qué funcionalidades te gustaría que tenga? | Traslada el diseño al usuario | ¿Qué fue lo último que quisiste saber y no pudiste averiguar? |

##### Registro y devolución

Se toma nota durante la entrevista y se redacta un resumen posteriormente. La devolución escrita al entrevistado, para que confirme o corrija, forma parte de la técnica y no constituye una cortesía: es el momento en que los malentendidos se detectan, cuando todavía son económicos de corregir.

### Observación

Permite registrar lo que la persona hace, que raramente coincide con lo que declara hacer. La discrepancia no obedece a mala fe sino a que las rutinas se automatizan y dejan de ser conscientes.

Kendall y Kendall la ubican entre los métodos discretos e incluyen la observación del entorno físico —dónde se ubica la persona, qué tiene a mano, qué anotó en un papel adherido al monitor—, que sistematizan bajo la denominación STROBE. Ese papel adherido al monitor suele constituir un requisito.

Lo que corresponde observar: qué herramienta utiliza efectivamente, qué pasos realiza que no figuran en ningún procedimiento, dónde duda, dónde retrocede y qué hace dos veces.

### Análisis documental

Es la técnica más económica y la más subestimada, porque los documentos existentes contienen los datos relevantes ya filtrados por años de uso. Kendall y Kendall distinguen documentos cuantitativos —informes, formularios, registros, planillas— de cualitativos —memorandos, manuales, carteles, correos—.

Un formulario o una planilla en uso revela, sin necesidad de entrevistar a nadie:

- qué datos se consideran importantes, que son las columnas existentes;
- qué datos se consideran innecesarios, que son las columnas que quedaron vacías;
- quién los completa y en qué momento;
- qué cálculos se realizan manualmente;
- y qué se anota al margen, que es aquello que el formulario no previó.

### Cuestionario

Resulta adecuado cuando existen muchos destinatarios dispersos y ya se conoce qué preguntar. Es una herramienta para cuantificar lo que se descubrió por otras vías, no para descubrir.

Los cuidados son tres: preguntas que no admitan dos lecturas, escalas consistentes, y aceptación de que la tasa de respuesta será baja. Un cuestionario mal diseñado produce datos con apariencia de rigor, lo cual es peor que la ausencia de datos.

En un dominio con un único usuario la técnica es poco aplicable, y conviene declararlo explícitamente: la elección de la técnica forma parte del relevamiento, y **descartar una con fundamento constituye una decisión de análisis tan válida como aplicarla**.

### El vocabulario del cliente

Todo término que el entrevistado emplea debe registrarse con sus palabras. Evans lo señala como punto de partida del lenguaje ubicuo: el vocabulario que utiliza el experto del dominio debe ser el mismo que aparezca en las historias, en la especificación, en el modelo de datos y en el código.

Cuando el lenguaje del código y el del cliente divergen, cada conversación requiere traducción, y en cada traducción se pierde información. El costo no se manifiesta de inmediato: aparece cuando el cliente rechaza un incremento porque lo construido no es lo que había pedido, y ambas partes tienen razón.

Glosario mínimo del dominio, a construir durante la entrevista: desenganche, riesgo, intervención, comisión, entrega, umbral, seguimiento.

### Aplicación al proyecto guía

Las cuatro técnicas aplicadas al dominio, con su rendimiento esperado:

| Técnica | Aplicación | Rendimiento |
|---|---|---|
| Entrevista | Con el tutor, sobre episodios concretos de detección tardía | Alto: es la fuente principal |
| Observación | Cómo registra hoy la asistencia y cuánto tiempo le lleva | Alto: determina la factibilidad operativa |
| Análisis documental | La planilla de cálculo con la que sigue la cursada actualmente | Muy alto y de costo mínimo |
| Cuestionario | — | **Descartado con fundamento**: un único usuario |

La planilla en uso es el documento más valioso del relevamiento: sus columnas indican qué datos se consideran relevantes, sus columnas vacías indican qué se consideró y se abandonó, y sus cálculos manuales indican exactamente qué trabajo debe automatizarse.

### Anti-patrones frecuentes

- **Leer la lista de preguntas de corrido**: convierte la entrevista en un formulario y elimina el sondeo, que es donde aparece la información.
- **Preguntar por deseos y funcionalidades**: produce una lista de funcionalidades solicitadas por cortesía, sin fundamento en ningún hecho.
- **No solicitar los documentos existentes**: descarta la fuente más económica del relevamiento.
- **Traducir el vocabulario del cliente a jerga técnica al tomar nota**: la traducción se pierde y con ella el lenguaje común.
- **No devolver lo entendido para su validación**: los malentendidos se detectan entonces durante la construcción, cuando corregirlos es caro.

### Síntesis

El relevamiento no consiste en preguntar qué se necesita sino en reconstruir cómo se trabaja hoy. Las cuatro técnicas se eligen según el tipo de información buscada y la cantidad de destinatarios, y la elección debe fundamentarse, incluido el descarte. El producto del relevamiento no son sólo las notas: es también el glosario del dominio, que debe sobrevivir sin traducciones hasta el código.

### Fuentes

- Kendall, K. y Kendall, J. *Análisis y diseño de sistemas* (8ª ed.), Pearson, cap. 4, "Métodos interactivos para obtener información" (preparación de la entrevista, tipos de pregunta, estructuras de pirámide, embudo y rombo, y diseño de cuestionarios); cap. 5, "Métodos discretos para obtener información" (observación, STROBE e investigación de datos duros).
- Fitzpatrick, R. (2013). *The Mom Test*, caps. 1-2 (las tres reglas y las preguntas defectuosas) y cap. 3 (preguntas adecuadas). Ed. en castellano: *El Mom Test*, trad. Verónica Torras. https://www.momtestbook.com/
- Evans, E. (2003). *Domain-Driven Design*, Addison-Wesley, cap. 1, "Crunching Knowledge", y cap. 2, "Communication and the Use of Language". Resumen libre: https://www.domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf
- Gause, D. y Weinberg, G. (1989). *Exploring Requirements*, parte I y caps. sobre talleres de requisitos.
- Wiegers, K. y Beatty, J. (2013). *Software Requirements* (3ª ed.), Microsoft Press, parte II, "Requirements Development".
- Fowler, M. — "Ubiquitous Language", https://martinfowler.com/bliki/UbiquitousLanguage.html · "Observed Requirement", https://martinfowler.com/bliki/ObservedRequirement.html

--------

# Identificación y análisis de requerimientos

### De la nota al requerimiento

Lo que resulta de una entrevista son notas. Un requerimiento es otra cosa: una afirmación sobre lo que el sistema debe hacer, o sobre la cualidad con que debe hacerlo, formulada de modo que pueda verificarse si se cumplió.

Entre ambas cosas median cinco operaciones:

```text
  NOTAS DEL RELEVAMIENTO
        │
        ├─► FILTRAR       no todo lo dicho es requerimiento: hay contexto,
        │                 anécdota y deseo
        │
        ├─► DEDUPLICAR    lo mismo aparece formulado de tres maneras
        │                 en tres momentos distintos
        │
        ├─► DESAMBIGUAR   cada enunciado debe admitir una sola lectura
        │
        ├─► CLASIFICAR    funcional o no funcional
        │
        └─► PRIORIZAR     porque no entra todo
              │
              ▼
        REQUERIMIENTOS
```

### Atributos de un requerimiento utilizable

La norma ISO/IEC/IEEE 29148 enumera las características de un requisito individual y de un conjunto de requisitos. Las cinco de aplicación directa:

- **Necesario**: si se elimina, algo falta. Si nadie lo extraña, no era un requisito.
- **No ambiguo**: admite una sola interpretación.
- **Verificable**: existe una forma de comprobar que se cumplió.
- **Trazable**: puede seguirse hasta el problema o la decisión que lo motiva.
- **Sin diseño incorporado**: enuncia *qué*, no *cómo*.

### Los siete pecados del especificador

Meyer realiza en "On Formalism in Specifications" un ejercicio que conviene reproducir: toma un enunciado de requerimiento en prosa, de apariencia razonable, y lo desarma. Del análisis resulta una tipología de siete defectos que funciona como grilla de revisión.

| Defecto | Definición |
|---|---|
| **Ruido** | Hay texto que no aporta información sobre ninguna característica del problema |
| **Silencio** | Hay una característica del problema que ningún elemento del texto cubre |
| **Sobreespecificación** | Hay texto que no describe el problema sino una solución posible |
| **Contradicción** | Dos elementos definen la misma característica de manera incompatible |
| **Ambigüedad** | Un elemento permite interpretar una característica de al menos dos maneras |
| **Referencia adelantada** | El texto emplea una característica que se define más adelante |
| **Wishful thinking** | Define una característica de modo tal que ninguna solución candidata podría verificarse contra ella |

El argumento de Meyer no consiste en que todo deba escribirse en notación matemática, sino en que **la prosa aparenta precisión cuando no la tiene**, y que la sensación de haber comprendido no constituye evidencia de comprensión.

La técnica derivada consiste en tomar una frase del propio relevamiento y buscarle tres lecturas distintas. Si se encuentran, la frase no era un requerimiento. Sobre el enunciado *el sistema debe avisar cuando un estudiante está en riesgo*: a quién avisa, al tutor, al estudiante o a la coordinación; en qué momento, al cruzar el umbral o en un resumen periódico; y según qué criterio se determina el riesgo, por inasistencias, por entregas o por ambas con qué ponderación. Tres lecturas, tres decisiones pendientes, y ninguna de ellas puede tomarla el equipo por su cuenta.

Términos que casi siempre señalan ambigüedad: rápido, fácil, amigable, adecuado, eficiente, flexible, robusto, "etc.", "y/o", "si corresponde", "de manera automática".

### Verificabilidad

La pregunta de control es una sola: de qué modo se sabría que está hecho. Si no existe respuesta, no se trata de un requerimiento sino de una intención.

La plantilla Volere denomina a esa respuesta **criterio de ajuste**: la medida concreta contra la cual se comprueba el requisito. Es la misma noción que adopta después la forma de criterio de aceptación en una historia de usuario.

### Diseño dentro del requerimiento

Un requerimiento que incorpora la solución cierra el diseño antes de haberlo pensado, y además oculta la necesidad real detrás de una forma particular de satisfacerla. Es la sobreespecificación de Meyer.

| Con diseño incorporado | Requerimiento | Qué se gana al reescribirlo |
|---|---|---|
| Un desplegable con las comisiones | El tutor selecciona sobre qué comisión trabaja | Con cuarenta comisiones el desplegable deja de servir; el requisito sigue siendo válido |
| Un semáforo de tres colores | El tutor distingue de un vistazo el nivel de riesgo de cada estudiante | El semáforo puede fallar por accesibilidad; la necesidad no |
| Exportar a un formato de planilla | La coordinación recibe el estado de la comisión en un formato que pueda procesar | Deja abiertas varias formas de satisfacerlo |

Existe una excepción: cuando el modo de resolver constituye una restricción real impuesta desde el entorno —una norma, un sistema con el que debe establecerse comunicación—, entonces sí es un requisito y se documenta como restricción.

### Trazabilidad y priorización

Cada requerimiento se vincula con algo: con el enunciado del problema o con una decisión que el usuario debe tomar. El filtro es la pregunta que ordena la materia —qué decisión del tutor habilita— y lo que no tiene respuesta sale de la lista o desciende en prioridad.

Para priorizar existen dos instrumentos. **MoSCoW** clasifica en *Must*, sin lo cual no hay producto; *Should*, importante pero con alternativa; *Could*, si sobra tiempo; y *Won't*, explícitamente excluido en esta versión. La última categoría es la de mayor utilidad, porque deja registrado por escrito aquello que no se va a construir. **Valor contra esfuerzo** ordena sobre dos ejes: lo de alto valor y bajo esfuerzo se construye primero, lo de bajo valor y alto esfuerzo no se construye. Ninguno de los dos instrumentos funciona si todo se clasifica como obligatorio.

El backlog se cierra al 70% de lo relevado y se reserva el 30% restante para lo que aparezca. No expresa una carencia de trabajo sino el reconocimiento escrito de que todavía no se conoce todo, y constituye la aplicación directa del décimo principio del Manifiesto Ágil.

>La simplicidad, o el arte de maximizar la cantidad de trabajo no realizado, es esencial.
>
>[Principios del Manifiesto por el Desarrollo Ágil de Software](https://agilemanifesto.org/iso/es/principles.html)

### Aplicación al proyecto guía

El filtro de trazabilidad aplicado a cuatro requerimientos candidatos del dominio:

| Requerimiento candidato | Decisión que habilita | Resultado |
|---|---|---|
| Ver la comisión ordenada por nivel de riesgo | A quién contactar esta semana | Entra, con prioridad alta |
| Registrar el resultado de un contacto | A quién no volver a contactar, y qué forma de contacto funcionó | Entra |
| Configurar los umbrales del cálculo | Qué criterio de riesgo se aplica | Entra, con prioridad menor: el criterio inicial puede fijarse en el código |
| Registrar el domicilio del estudiante | Ninguna | **Sale de la lista** |

La última fila es la que se discute, y es la que enseña el criterio: el dato es razonable, el costo de registrarlo es bajo, y no habilita ninguna decisión del usuario. Su costo real no es el de construirlo sino el de ocupar espacio en una pantalla que existe para responder una sola pregunta.

### Anti-patrones frecuentes

- **Trasladar las notas de la entrevista al backlog sin análisis**: produce requerimientos duplicados, ambiguos y sin criterio de verificación.
- **Requerimientos formulados con adjetivos**: rápido, amigable, robusto. No pueden aceptarse ni rechazarse.
- **Requerimientos con diseño incorporado**: cierran el diseño antes de pensarlo y ocultan la necesidad real.
- **Backlog donde todo es obligatorio**: equivale a un backlog sin priorizar, y traslada la decisión de recorte al momento de menor margen.
- **Omitir la pregunta por la decisión que habilita**: es el único filtro que impide que el backlog crezca indefinidamente.

### Síntesis

El análisis de requerimientos es una operación de reducción antes que de recolección: filtra, deduplica, desambigua y descarta. La grilla de Meyer proporciona el vocabulario para nombrar los defectos y la pregunta por la verificación proporciona el criterio de corte. Lo que no puede verificarse no puede terminarse, y lo que no habilita ninguna decisión no debería haber entrado.

### Fuentes

- Meyer, B. (1985). "On Formalism in Specifications", *IEEE Software*, 2(1), pp. 6-26. Los siete pecados se enumeran en la sección "The seven sins of the specifier". https://se.inf.ethz.ch/~meyer/publications/ieee/formalism.pdf · Resumen: https://blog.acolyer.org/2016/11/08/on-formalisms-in-specifications/
- Meyer, B. (2018). "The Formal Picnic Approach to Requirements". https://bertrandmeyer.com/2018/12/17/formal-picnic-approach-requirements/
- ISO/IEC/IEEE 29148:2018, *Requirements engineering*, cláusulas 5.2.5 (características de un requisito individual) y 5.2.6 (características de un conjunto).
- Robertson, S. y Robertson, J. — *Volere Requirements Specification Template*, definición de *fit criterion*. Uso académico exento de pago. https://www.volere.org/templates/volere-requirements-specification-template/
- Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 5, "Evolutionary Requirements", y cap. 7, "Other Requirements".
- Beck, K. y otros (2001). *Manifiesto Ágil* y sus doce principios. https://agilemanifesto.org/iso/es/principles.html

--------

# Requerimientos funcionales y no funcionales

### La distinción

El requerimiento **funcional** enuncia qué hace el sistema. El **no funcional** enuncia con qué cualidad lo hace y bajo qué restricciones.

La asimetría entre ambos determina el método de trabajo. El funcional se descubre por sí solo, porque el cliente lo solicita. El no funcional no aparece si no se lo busca deliberadamente, porque nadie solicita explícitamente que el sistema sea confiable: se da por supuesto. Y como no fue solicitado no se construye, y como no se construyó se descubre en operación, que es el momento de mayor costo.

De allí la necesidad de una grilla, cuya función no es clasificar sino **recordar preguntar por la categoría que nadie mencionó**.

### FURPS+ como grilla de descubrimiento

| Letra | Categoría | Pregunta que dispara |
|---|---|---|
| **F** | Funcionalidad | Qué hace, incluida la seguridad |
| **U** | Usabilidad | Factores humanos, ayuda, documentación, accesibilidad |
| **R** | Confiabilidad | Frecuencia de fallas, recuperación, previsibilidad |
| **P** | Rendimiento | Tiempos de respuesta, uso de recursos, disponibilidad |
| **S** | Soporte | Mantenibilidad, configurabilidad, adaptabilidad |
| **+** | Restricciones | De diseño, de implementación, de interfaz, físicas |

El signo final es donde ingresa aquello que no constituye una cualidad sino una imposición: el lenguaje que debe emplearse, la norma que debe cumplirse, el sistema con el que debe establecerse comunicación.

La norma ISO/IEC 25010 organiza el mismo territorio de manera más completa y está disponible en castellano. Conviene registrar que **la revisión de 2023 modificó el modelo** respecto de la versión de 2011 que circula en la mayoría de los apuntes: pasó de ocho a nueve características, la usabilidad fue redefinida como capacidad de interacción, la portabilidad fue redefinida como flexibilidad e incorporó la escalabilidad como subcaracterística, y se agregó la seguridad física como característica propia. Cualquiera de los dos marcos sirve; lo que no sirve es mezclar vocabularios ni citar el modelo sin indicar qué versión se está utilizando.

### Formulación verificable

El enunciado de que el sistema debe ser rápido no constituye un requerimiento: no puede aceptarse ni rechazarse, y por lo tanto no puede darse por terminado. Un no funcional utilizable tiene cuatro partes.

> En **[situación]**, cuando **[estímulo]**, el sistema **[respuesta]** en **[medida]**.

| Formulación vaga | Formulación verificable |
|---|---|
| El sistema debe ser rápido | Con 300 estudiantes cargados, el panel de riesgo se presenta completo en menos de 3 segundos |
| El sistema debe ser seguro | Sólo un usuario autenticado con rol de tutor accede a los datos de su comisión; un intento de acceso a otra comisión se rechaza y queda registrado |
| Debe ser fácil de usar | Un tutor que nunca operó el sistema registra la asistencia de una clase completa en menos de 2 minutos, sin asistencia |
| Debe ser confiable | Ningún registro de asistencia confirmado se pierde ante una interrupción; al reiniciar, los datos confirmados están disponibles |

La medida no necesita ser exigente: necesita existir. Un umbral holgado pero verificable tiene más valor que uno exigente pero declarativo, porque el primero puede comprobarse y el segundo sólo puede afirmarse.

### Dónde se documentan

En un documento separado —la **Especificación Suplementaria**— y no dentro de cada historia de usuario.

La razón es operativa: un no funcional atraviesa muchas historias, de modo que si se replica en cada una se duplica; cuando cambia se actualiza en algunas y no en otras; y termina existiendo más de una versión contradictoria del mismo requisito. Se escribe una vez y las historias lo referencian.

### Restricción impuesta y atributo elegido

Dentro de los no funcionales conviven dos categorías que conviene no mezclar. La **restricción impuesta** proviene del entorno y no se negocia: la Ley 25.326 establece obligaciones sobre el tratamiento de datos personales. El **atributo elegido** es un nivel que el equipo decide alcanzar y que tiene costo: que el panel se presente en tres segundos y no en diez es una decisión.

La distinción es la misma que separa limitación de decisión de alcance, y su consecuencia práctica es idéntica: la restricción se acepta y se planifica alrededor; el atributo elegido se revisa cuando el presupuesto aprieta.

### Aplicación al proyecto guía

| Categoría | Requerimiento | Estado |
|---|---|---|
| F / Seguridad | Sólo el tutor autenticado accede a los datos de sus comisiones | Obligatorio (Ley 25.326, art. 9) |
| F / Seguridad | Los datos de desempeño se utilizan sólo para el seguimiento y no se comparten | Obligatorio (Ley 25.326, art. 4, finalidad) |
| U | Un tutor sin capacitación registra la asistencia de una clase en menos de 2 minutos | Elegido |
| U | El nivel de riesgo se distingue sin depender únicamente del color | Elegido, por accesibilidad |
| R | Un registro confirmado no se pierde ante una interrupción | Elegido |
| P | El panel se presenta en menos de 3 segundos con 300 estudiantes | Elegido |
| P | **Escalabilidad: descartada.** Un único usuario concurrente | **Descartado con fundamento** |
| S | Los umbrales de riesgo se modifican sin intervenir el código | Elegido |
| + | El equipo no cursó desarrollo web: la tecnología se elige sobre lo conocido | Restricción |

La fila del descarte tiene el mismo valor que las restantes. Un equipo que declara que la escalabilidad no aplica a su sistema y explica por qué demuestra más criterio que uno que reproduce una lista genérica de atributos de calidad. **Descartar con fundamento es diseñar.**

### Anti-patrones frecuentes

- **Enunciar no funcionales como adjetivos**: no pueden aceptarse ni rechazarse, y por lo tanto no forman parte de ninguna definición de terminado.
- **Replicar el mismo no funcional dentro de cada historia**: produce versiones divergentes del mismo requisito.
- **Copiar una lista genérica de atributos de calidad**: incorpora requisitos que nadie va a verificar y omite los que el problema sí requiere.
- **No recorrer la grilla completa**: las categorías que nadie menciona son precisamente las que se descubren en operación.
- **Confundir restricción impuesta con atributo elegido**: conduce a negociar lo que no se negocia y a considerar inamovible lo que sí podía revisarse.

### Síntesis

Los requerimientos no funcionales son los que determinan si un sistema correcto resulta además utilizable, y no aparecen espontáneamente en el relevamiento. La grilla existe para provocar la pregunta y la formulación en cuatro partes existe para que la respuesta pueda comprobarse. El descarte fundamentado de una categoría es un resultado de análisis y no una omisión, siempre que quede escrito junto con su razón.

### Fuentes

- Larman, C. *Applying UML and Patterns*, cap. 5, "Evolutionary Requirements", §5.2 "Types of Requirements", donde presenta FURPS+ atribuyéndolo a Robert Grady (Hewlett-Packard). https://www.oreilly.com/library/view/applying-uml-and/0130925691/0130925691_ch05lev1sec2.html · cap. 7, §7.4-7.5 (Especificación Suplementaria).
- ISO/IEC 25010:2023, *Product quality model*, https://www.iso.org/standard/78176.html · Versión 2011, con las ocho características, https://www.iso.org/standard/35733.html · Resumen en castellano: https://iso25000.com/index.php/normas-iso-25000/iso-25010
- Farley, D. (2021). *Modern Software Engineering*, parte III, "Optimise for Managing Complexity", caps. 9-13. PDF en `Docs/` del repositorio.
- Ley N° 25.326, arts. 4 y 9. https://www.argentina.gob.ar/normativa/nacional/ley-25326-64790/actualizacion
- Fowler, M. — "Story Test". https://martinfowler.com/bliki/StoryTest.html

--------

# Épicas, historias de usuario y criterios de aceptación

Es el tema más extenso de la unidad, porque la historia de usuario es el instrumento que el equipo utiliza en cada iteración del proyecto.

### Origen y función

La historia de usuario surge en Extreme Programming. Beck la introduce como una de las prácticas primarias, y su función original es de planificación y no de especificación: constituye una unidad de trabajo suficientemente pequeña para estimarse y suficientemente valiosa para entregarse.

Fowler señala el punto que evita la mayor parte de los problemas asociados a su uso: la historia no es el requerimiento escrito en otro formato, sino el marcador de una conversación pendiente. Tratada como documento se convierte en una especificación deficiente; tratada como recordatorio, funciona.

### Las 3 C

Jeffries sintetiza la historia en tres componentes, y los tres son necesarios.

| Componente | Qué es | Qué ocurre si falta |
|---|---|---|
| **Tarjeta** | Un título y dos líneas, deliberadamente pequeña | Sin ella no hay unidad de planificación |
| **Conversación** | El contenido real; la tarjeta es la excusa para que ocurra | Se construye lo que el desarrollador supuso |
| **Confirmación** | Los criterios de aceptación | La historia no puede aceptarse ni rechazarse |

La falla más frecuente consiste en quedarse con el primer componente. Una tarjeta sin conversación y sin confirmación es un ticket, y produce aquello que el desarrollador supuso en lugar de aquello que el cliente necesitaba. La pequeñez de la tarjeta no es una limitación del formato: es su función, porque obliga a que la conversación ocurra.

### La plantilla

> Como **[rol]**, quiero **[capacidad]**, para **[beneficio]**.

Tres observaciones sobre ella. El **beneficio es la parte sustantiva**, porque allí reside el valor y es lo único que permite decidir prioridad, discutir alternativas y evaluar si la historia sirve; quien no puede escribirlo todavía no comprendió el requerimiento. El **rol es un rol**, no una persona ni un integrante del equipo de desarrollo: una historia formulada desde el punto de vista del desarrollador no tiene usuario ni valor, y por lo tanto es una tarea. Y **la plantilla es una ayuda y no una obligación**: si una historia se comprende mejor formulada de otro modo, se formula de otro modo, porque el problema nunca fue el formato sino perder de vista el valor.

| | |
|---|---|
| ✗ | Como desarrollador, quiero crear la tabla de asistencias, para guardar los datos |
| ✗ | Como tutor, quiero un panel, para poder usar el sistema |
| ✓ | Como tutor, quiero ver los estudiantes de mi comisión ordenados por nivel de riesgo, para decidir a quién contacto esta semana |
| ✓ | Como tutor, quiero registrar el resultado de un contacto, para no volver a llamar a alguien con quien ya hablé |

### Épica

Una épica es una historia demasiado grande para completarse en una iteración. No constituye una categoría distinta ni un nivel jerárquico: es una cuestión de tamaño, relativa al equipo y a la duración de la iteración.

Su utilidad consiste en registrar una capacidad importante antes de conocer el detalle, y se divide cuando se aproxima el momento de construirla. Dividirla antes es especular sobre información que todavía no existe; dividirla después es tarde.

### INVEST

La rúbrica de Wake para revisar una historia:

| | | Qué se pregunta | En el dominio |
|---|---|---|---|
| **I** | Independiente | ¿Puede construirse sin esperar a otra? | Si ver el panel requiere que exista el cálculo de riesgo, hay dependencia: se ordenan o se dividen de otro modo |
| **N** | Negociable | ¿Deja margen para discutir el cómo? | Si especifica un semáforo de tres colores, el diseño ya quedó cerrado |
| **V** | Valiosa | ¿Le sirve a alguien ajeno al equipo? | Crear una tabla no le sirve al tutor |
| **E** | Estimable | ¿El equipo puede asignarle un tamaño? | Si nadie sabe cuánto es, falta información y corresponde investigar antes |
| **S** | Pequeña | ¿Entra en una iteración con margen? | Si ocupa la iteración completa no entra, porque no queda lugar para el error |
| **T** | Verificable | ¿Puede comprobarse que está hecha? | Sin criterio de aceptación no puede aceptarse |

Las dos que con mayor frecuencia rechazan historias en la práctica son la **V** y la **T**. Una revisión en la que las seis letras resultan satisfactorias casi siempre significa que la revisión no se realizó.

### Criterios de aceptación

Constituyen el tercer componente de las 3 C: definen cuándo la historia está terminada, y los define el cliente, no el equipo.

Existen dos formatos y ambos son válidos. La **lista de verificación** es directa y resulta adecuada para historias simples:

> - Se presentan sólo los estudiantes de las comisiones del tutor conectado.
> - El orden por defecto es de mayor a menor riesgo.
> - Si no hay estudiantes en riesgo, se presenta un mensaje explícito y no una tabla vacía.

**Dado / Cuando / Entonces** proviene de BDD. North lo propone como un vocabulario para describir comportamiento en lugar de pruebas, y su virtud consiste en que obliga a explicitar el estado previo, que es donde se alojan los malentendidos:

> **Dado que** el tutor tiene la comisión 2°A a cargo y el estudiante Pérez acumula 4 inasistencias sobre 6 clases, **cuando** el tutor abre el panel de seguimiento, **entonces** Pérez aparece en el listado con nivel de riesgo alto y con el detalle "4 de 6 clases ausente".

Un criterio de aceptación es adecuado cuando emplea datos concretos y no categorías; cuando es observable desde fuera, es decir, describe lo que se ve y no cómo está implementado; cuando cubre además del recorrido principal algún camino alternativo —ausencia de datos, empates, registros inexistentes—; y cuando no reformula la historia con otras palabras. Tres o cuatro criterios por historia suele ser la medida adecuada: uno solo indica que falta análisis, diez indican que la historia es una épica sin dividir.

### División de historias

Cuando una historia no entra en una iteración corresponde dividirla, y cada división debe entregar valor de punta a punta. La partición por capas técnicas no sirve, porque ninguna de las partes resultantes puede demostrarse ni aceptarse.

| Patrón | Criterio de corte | Ejemplo |
|---|---|---|
| Pasos del flujo | Una etapa del recorrido por vez | Primero ver el listado; después marcar contactado; después registrar el resultado |
| Variantes de regla de negocio | Una regla por vez | Primero riesgo por inasistencias; después incorporar entregas |
| Variaciones de datos | Un subconjunto de datos | Primero una comisión; después varias |
| Interfaz de entrada | Un modo de carga por vez | Primero carga manual; después importación |
| Escenario simple o complejo | El caso principal primero | Primero sin empates ni casos límite; después los bordes |
| Operaciones | Una operación por vez | Primero consultar; después editar; después eliminar |
| Esfuerzo | Separar lo costoso de lo económico | Primero el cálculo con umbral fijo; después configurable |

La heurística general consiste en localizar dónde reside la complejidad real —aquello que puede sorprender— y aislarla en una división propia, dejando las variaciones para después. Es el mismo criterio que ordena la construcción del proyecto guía, donde el cálculo del indicador se prioriza por encima de las pantallas de registro precisamente porque es lo desconocido.

### Estimación y backlog

##### Estimación relativa

El tamaño de una historia se estima comparándola con otra, no en horas. El fundamento es empírico: las personas estiman mal la duración y comparan tamaños razonablemente bien. Una escala reducida resulta suficiente, y lo que supere el valor mayor se divide.

##### Velocidad

Es lo que el equipo efectivamente terminó en una iteración. Constituye una observación y no una meta, y sirve para estimar la iteración siguiente con realismo. Se mide a partir de la tercera iteración, cuando ya existe con qué comparar. Convertida en meta de productividad deja de informar, porque el equipo ajusta la estimación en lugar de ajustar el alcance.

##### Backlog

Ordenado por prioridad, refinado de manera continua y cerrado al 70%. Beck y Fowler lo enuncian como la regla básica de la planificación: el alcance es la variable, no la fecha.

### Relación con la especificación

La historia con sus criterios de aceptación es lo que ingresa en la especificación. Una historia con criterios verificables produce una especificación que puede satisfacerse y defenderse; una historia sin criterios produce una especificación que se completa con supuestos de quien la implementa y que el equipo no puede justificar durante la revisión.

Adzic lo formula antes de la existencia de asistentes automáticos: el valor de una especificación reside en los ejemplos concretos que la acompañan y no en la exhaustividad de su prosa. Es el mismo argumento que sostiene el enfoque de la materia respecto de la documentación.

### Aplicación al proyecto guía

El backlog del proyecto está organizado en cinco especificaciones con once historias, y cuatro de ellas conforman el recorrido completo de punta a punta. El detalle está en [la consigna](../trabajo-integrador/consigna.md), y el modelo de formato y de nivel de detalle está resuelto en [la historia de referencia](../trabajo-integrador/historia-de-referencia.md).

Lo que corresponde observar en este tema es el criterio de ordenamiento: el indicador de riesgo se prioriza antes que la mayor parte de las pantallas de registro. La razón no es de dependencia de datos sino de riesgo: **el equipo ya sabe construir pantallas de carga y todavía no sabe qué señales predicen el abandono ni con qué umbral**. Ordenar por dependencia de datos equivale a dividir por capas con otro nombre, y posterga hasta el final aquello que puede sorprender.

### Anti-patrones frecuentes

- **La historia técnica**: sin usuario ni valor, es una tarea de la iteración y no una historia.
- **El beneficio vacío**: si puede deducirse de la capacidad solicitada, falta el beneficio.
- **El criterio de aceptación que reformula la historia**: no indica cómo se comprueba y por lo tanto no permite aceptar.
- **Dividir por capas en lugar de por valor**: produce partes que no pueden demostrarse ni aceptarse.
- **Épicas presentadas como historias**: se descubren a mitad de la iteración, cuando ya no hay margen.
- **Estimar en horas y convertir la velocidad en meta**: la velocidad deja de informar en cuanto se la utiliza para evaluar.

### Síntesis

La historia de usuario es una unidad de planificación y de conversación, no un formato de especificación. Sus tres componentes son igualmente necesarios, y el que con mayor frecuencia se omite —la confirmación— es el que determina si la historia puede darse por terminada. La rúbrica INVEST y los patrones de división son instrumentos de control sobre el tamaño y el valor, y ambos operan sobre la misma restricción: cada entrega debe poder demostrarse ante el cliente.

### Fuentes

- Jeffries, R. (2001). "Essential XP: Card, Conversation, Confirmation". https://ronjeffries.com/xprog/articles/expcardconversationconfirmation/
- Wake, B. (2003). "INVEST in Good Stories, and SMART Tasks". https://xp123.com/invest-in-good-stories-and-smart-tasks/
- North, D. (2006). "Introducing BDD". https://dannorth.net/blog/introducing-bdd/ · Historia del formato: https://cucumber.io/docs/bdd/history/
- Lawrence, R. y otros — "The Humanizing Work Guide to Splitting User Stories". https://www.humanizingwork.com/the-humanizing-work-guide-to-splitting-user-stories/
- Beck, K. y Andres, C. (2004). *Extreme Programming Explained: Embrace Change* (2ª ed.), Addison-Wesley, cap. 7, "Primary Practices", prácticas *Stories*, *Whole Team* y *Weekly Cycle*.
- Beck, K. y Fowler, M. (2000). *Planning Extreme Programming*, Addison-Wesley, caps. sobre estimación, velocidad y el juego de la planificación.
- Cohn, M. (2004). *User Stories Applied*, Addison-Wesley, cap. 2, "Writing Stories", y cap. 6, "Acceptance Testing User Stories". · (2005). *Agile Estimating and Planning*, parte II.
- Fowler, M. — "User Story", https://martinfowler.com/bliki/UserStory.html · "Conversational Stories", https://martinfowler.com/bliki/ConversationalStories.html
- Adzic, G. (2011). *Specification by Example*, Manning, caps. 1-4.
- Schwaber, K. y Sutherland, J. (2020). *La Guía Scrum*, 13 pp. https://scrumguides.org/docs/scrumguide/v2020/2020-Scrum-Guide-Spanish-European.pdf

--------

# Alcance, supuestos y restricciones

### Alcance

Definir el alcance consiste en escribir dos listas, y la segunda es la que cumple la función: lo que **está dentro de alcance**, es decir aquello que se compromete a construir, y lo que está **fuera de alcance**, es decir aquello que explícitamente no se va a construir en esta versión.

La lista de exclusiones es la que evita la discusión de las últimas semanas del proyecto, porque deja registrado y acordado con el cliente aquello que el equipo decidió no hacer. Un alcance declarado únicamente en positivo se expande por sí solo: todo lo que no fue excluido parece incluido. Sirve además para responder con un aplazamiento en lugar de una negativa, porque una funcionalidad fuera de alcance en esta versión continúa siendo candidata para la siguiente.

### Supuestos

Un supuesto es algo que se da por cierto sin haberlo verificado y sobre lo cual se están tomando decisiones.

Los supuestos existen siempre; lo que se elige es si quedan escritos o no. El supuesto no escrito es el peligroso, porque nadie lo revisa —nadie sabe que está allí— y se manifiesta avanzado el proyecto, cuando ya existe construcción apoyada sobre él. DeMarco y Lister lo formulan en términos de riesgo: un riesgo es un problema que todavía no ocurrió, y gestionarlo comienza por nombrarlo. **Un supuesto no verificado es un riesgo sin nombre.**

La formulación completa incorpora la verificación:

> **Suponemos que** [afirmación]. **Si fuera falso**, [consecuencia]. **Verifica** [quién], **antes de** [cuándo].

Aplicada al dominio:

> Suponemos que **el tutor puede obtener la nómina de estudiantes de su comisión en formato digital**. Si fuera falso, **hay que construir la carga manual de la nómina, que agrega una historia de tamaño medio a la primera iteración**. Verifica **el equipo, consultando al cliente**, antes de **la planificación de la primera iteración**.

El supuesto más costoso de este dominio consiste en dar por existentes los datos de asistencia. No existen: alguien debe registrarlos, y eso constituye una decisión de diseño con consecuencias sobre el producto completo.

### Restricciones

Una restricción es una condición impuesta desde el entorno y no negociable. No se discute: se planifica alrededor de ella.

| Tipo | En el dominio |
|---|---|
| Tiempo | Las fechas de las dos evaluaciones están fijadas |
| Recursos | 1 a 2 horas semanales por integrante; unas 60 horas-persona por equipo |
| Conocimiento | El equipo todavía no cursó los módulos de desarrollo web |
| Normativa | Ley 25.326: los datos son personales y su tratamiento tiene requisitos |
| Organizacional | La disponibilidad del cliente es acotada y periódica |
| Técnica | El instituto no expone su base de datos |

La distinción entre restricción y decisión de alcance es la misma que separa limitación de decisión al delimitar el sistema, y aquí tiene consecuencia práctica inmediata: la restricción se acepta, la decisión de alcance se revisa. Tratar una decisión como restricción implica renunciar a algo que podía modificarse; tratar una restricción como decisión implica discutir indefinidamente algo que ya estaba fijado.

### El triángulo invertido

En la gestión tradicional se fija el alcance y se estiman tiempo y costo. En un proyecto con fecha inamovible el planteo se invierte: el tiempo y los recursos son fijos y la variable es el alcance.

```text
  GESTIÓN TRADICIONAL              PROYECTO CON FECHA FIJA

      ALCANCE  (fijo)                 TIEMPO  (fijo)
         │                               │
         ▼                               ▼
   tiempo y costo                     ALCANCE
      (estimados)                     (variable)
```

Beck y Fowler lo desarrollan en *Planning Extreme Programming*: si la fecha no se mueve y el equipo no crece, la única palanca disponible es qué se construye y qué no. De allí que priorizar no constituya una tarea administrativa sino la decisión central del proyecto, y que el principio de simplicidad del Manifiesto no sea una recomendación estética sino la consecuencia lógica de operar con tiempo fijo.

### Aplicación al proyecto guía

La declaración de alcance ocupa media página y tiene cuatro secciones:

```text
  ALCANCE
    Dentro:  ...
    Fuera:   ...

  SUPUESTOS
    Suponemos que ... / si fuera falso ... / verifica ... antes de ...

  RESTRICCIONES
    ...

  EL 30% RESERVADO
    Qué zonas del producto quedan abiertas y por qué
```

Sobre la última sección: el 30% reservado del backlog constituye alcance declarado como incierto y no alcance faltante. Es una decisión de planificación y debe sostenerse como tal frente al cliente, porque de otro modo se interpreta como trabajo pendiente de definir.

### Anti-patrones frecuentes

- **Declarar el alcance sólo en positivo**: todo lo no excluido se interpreta como incluido, y el alcance se expande sin que nadie lo decida.
- **Supuestos no escritos**: nadie los revisa porque nadie sabe que existen, y se manifiestan cuando ya hay construcción apoyada sobre ellos.
- **Supuestos escritos sin responsable ni fecha**: quedan registrados y nunca se verifican, que es la misma situación con más documentación.
- **Tratar una decisión de alcance como restricción**: implica renunciar a algo que podía revisarse.
- **Presentar el porcentaje reservado como trabajo sin definir**: es una decisión de planificación y debe sostenerse como tal.

### Síntesis

Alcance, supuestos y restricciones son tres formas de una misma operación: dejar por escrito qué se sabe, qué no se sabe y qué no se puede modificar. La lista de exclusiones es la más útil de las tres porque es la única que impide la expansión silenciosa del trabajo. Y el supuesto sólo cumple su función cuando incorpora responsable y fecha de verificación, porque sin ellos queda documentado pero no gestionado.

### Fuentes

- Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 7, §7.6-7.7, documento de Visión, sección de alcance.
- Beck, K. y Fowler, M. (2000). *Planning Extreme Programming*, Addison-Wesley, caps. sobre el juego de la planificación y sobre qué hacer cuando el alcance no entra. Ed. en castellano: *Planificación extrema*, Addison-Wesley, 2002.
- DeMarco, T. y Lister, T. (2003). *Waltzing with Bears: Managing Risk on Software Projects*, Dorset House, parte I, caps. 1-4. Ed. en castellano: *Bailando con osos*.
- Beck, K. y otros (2001). *Manifiesto Ágil* y sus doce principios. https://agilemanifesto.org/iso/es/manifesto.html · https://agilemanifesto.org/iso/es/principles.html
- Fowler, M. — "Scope Limbering". https://martinfowler.com/bliki/ScopeLimbering.html
- Robertson, S. y Robertson, J. — *Volere Requirements Specification Template*, secciones de restricciones, supuestos y hechos relevantes. https://www.volere.org/templates/volere-requirements-specification-template/

--------

# Los hilos que atraviesan la unidad

##### 1. El límite es una decisión

Aparece como límite del sistema, como recorte de actores, como priorización de requerimientos y como declaración de alcance. Es la misma decisión tomada cuatro veces con distinto grado de detalle, y en las cuatro el error es el mismo: no tomarla, con lo cual el límite queda definido por lo que alcance el tiempo disponible.

##### 2. Menos información, mejor decisión

El argumento de Ackoff sobre la sobreabundancia de información es el que justifica el filtro de trazabilidad sobre los requerimientos, el descarte fundamentado de atributos de calidad y el cierre del backlog al 70%. En los tres casos la operación es la misma: descartar con criterio explícito.

##### 3. Lo que no se puede verificar no se puede terminar

Aparece como criterio de ajuste en el análisis de requerimientos, como medida en los no funcionales y como criterio de aceptación en las historias. Es el mismo principio con tres nombres, y es el que conecta esta unidad con la definición de terminado que el equipo aplica en cada iteración.

##### 4. El vocabulario del cliente es el del sistema

Se recoge durante el relevamiento y debe sobrevivir sin traducciones hasta el código. Cada traducción intermedia introduce una pérdida, y la pérdida se manifiesta cuando el cliente rechaza un incremento porque no es lo que había pedido y ambas partes tienen razón.
