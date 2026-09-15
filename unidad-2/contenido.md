# Análisis y diseño de la solución

## Índice

<!-- TOC depthFrom:1 depthTo:3 -->

- [Análisis y diseño de la solución](#análisis-y-diseño-de-la-solución)
  - [Estructura de la unidad](#estructura-de-la-unidad)
    - [Finalidad: ¿Para qué?](#finalidad-para-qué)
    - [Fundamentos: ¿Por qué?](#fundamentos-por-qué)
    - [Mecanismos: ¿Cómo?](#mecanismos-cómo)
    - [Material](#material)
    - [Conocimiento necesario](#conocimiento-necesario)
- [Análisis de alternativas de solución](#análisis-de-alternativas-de-solución)
    - [El problema que resuelve](#el-problema-que-resuelve)
    - [El espacio de decisión](#el-espacio-de-decisión)
    - [El último momento responsable](#el-último-momento-responsable)
    - [Comparación de alternativas](#comparación-de-alternativas)
    - [El registro de la decisión](#el-registro-de-la-decisión)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes)
    - [Síntesis](#síntesis)
- [Criterios de evaluación y selección: la factibilidad](#criterios-de-evaluación-y-selección-la-factibilidad)
    - [Naturaleza del estudio de factibilidad](#naturaleza-del-estudio-de-factibilidad)
    - [Factibilidad técnica](#factibilidad-técnica)
    - [Factibilidad operativa](#factibilidad-operativa)
    - [Factibilidad económica](#factibilidad-económica)
    - [Factibilidad temporal](#factibilidad-temporal)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-1)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-1)
    - [Síntesis](#síntesis-1)
- [Modelado funcional: casos de uso y diagramas de secuencia](#modelado-funcional-casos-de-uso-y-diagramas-de-secuencia)
    - [El modo de uso determina el detalle](#el-modo-de-uso-determina-el-detalle)
    - [El caso de uso como descripción de comportamiento](#el-caso-de-uso-como-descripción-de-comportamiento)
    - [Diagrama de secuencia del sistema](#diagrama-de-secuencia-del-sistema)
    - [Diagrama de secuencia de diseño](#diagrama-de-secuencia-de-diseño)
    - [Contratos de operación](#contratos-de-operación)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-2)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-2)
    - [Síntesis](#síntesis-2)
- [Modelado de datos: entidad-relación y modelo relacional](#modelado-de-datos-entidad-relación-y-modelo-relacional)
    - [Modelo de dominio y modelo de datos](#modelo-de-dominio-y-modelo-de-datos)
    - [El modelo entidad-relación](#el-modelo-entidad-relación)
    - [Derivación al modelo relacional](#derivación-al-modelo-relacional)
    - [Normalización](#normalización)
    - [El dato que cambia con el tiempo](#el-dato-que-cambia-con-el-tiempo)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-3)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-3)
    - [Síntesis](#síntesis-3)
- [Diseño de procesos, componentes e interfaces](#diseño-de-procesos-componentes-e-interfaces)
    - [El criterio de descomposición](#el-criterio-de-descomposición)
    - [Cohesión y acoplamiento](#cohesión-y-acoplamiento)
    - [La interfaz como contrato](#la-interfaz-como-contrato)
    - [Asignación de responsabilidades](#asignación-de-responsabilidades)
    - [Cohesión y acoplamiento de componentes](#cohesión-y-acoplamiento-de-componentes)
    - [Diseño de procesos](#diseño-de-procesos)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-4)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-4)
    - [Síntesis](#síntesis-4)
- [Arquitectura de la solución](#arquitectura-de-la-solución)
    - [Qué es la arquitectura de un software](#qué-es-la-arquitectura-de-un-software)
    - [Organización en capas](#organización-en-capas)
    - [Cliente-servidor: distribución de la ejecución](#cliente-servidor-distribución-de-la-ejecución)
    - [Servicios e integraciones](#servicios-e-integraciones)
    - [Puertos y adaptadores](#puertos-y-adaptadores)
    - [La arquitectura y la estructura del equipo](#la-arquitectura-y-la-estructura-del-equipo)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-5)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-5)
    - [Síntesis](#síntesis-5)
- [Atributos de calidad y sus tensiones](#atributos-de-calidad-y-sus-tensiones)
    - [Del adjetivo al escenario](#del-adjetivo-al-escenario)
    - [Los atributos en juego](#los-atributos-en-juego)
    - [Las tensiones](#las-tensiones)
    - [Evaluación de la arquitectura](#evaluación-de-la-arquitectura)
    - [Calidad interna y costo de cambio](#calidad-interna-y-costo-de-cambio)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-6)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-6)
    - [Síntesis](#síntesis-6)
- [Prototipado y diseño de interfaces](#prototipado-y-diseño-de-interfaces)
    - [El prototipo como experimento](#el-prototipo-como-experimento)
    - [Baja fidelidad](#baja-fidelidad)
    - [Alta fidelidad](#alta-fidelidad)
    - [Evaluación del prototipo](#evaluación-del-prototipo)
    - [Heurísticas de usabilidad](#heurísticas-de-usabilidad)
    - [Accesibilidad](#accesibilidad)
    - [Consistencia visual e identidad de producto](#consistencia-visual-e-identidad-de-producto)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-7)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-7)
    - [Síntesis](#síntesis-7)
- [Definición de tecnologías y herramientas de desarrollo](#definición-de-tecnologías-y-herramientas-de-desarrollo)
    - [La pregunta correcta](#la-pregunta-correcta)
    - [Fichas de innovación](#fichas-de-innovación)
    - [Criterios de selección](#criterios-de-selección)
    - [El esqueleto ambulante](#el-esqueleto-ambulante)
    - [Las herramientas que no son el lenguaje](#las-herramientas-que-no-son-el-lenguaje)
    - [Aplicación al proyecto guía](#aplicación-al-proyecto-guía-8)
    - [Anti-patrones frecuentes](#anti-patrones-frecuentes-8)
    - [Síntesis](#síntesis-8)
- [Los hilos que atraviesan la unidad](#los-hilos-que-atraviesan-la-unidad)

<!-- /TOC -->

## Estructura de la unidad

### Finalidad: ¿Para qué?

- elegir una solución entre varias, en lugar de aceptar la primera;
- fundamentar esa elección con criterios explícitos y verificables;
- traducir el problema relevado a modelos que permitan construirlo;
- organizar el sistema de modo que el costo del cambio se mantenga bajo;
- y dejar registro de las decisiones tomadas, para poder defenderlas y para poder revisarlas.

La unidad anterior terminó con un problema comprendido, un conjunto de requerimientos analizados y un backlog priorizado. Nada de eso indica todavía qué se va a construir ni cómo. El propósito de esta unidad es cubrir esa distancia: convertir un problema comprendido en una solución diseñada, entendiendo por diseño no el dibujo de pantallas sino el conjunto de decisiones estructurales que determinan qué se puede cambiar después y a qué costo.

La distinción entre problema y solución es la que ordena todo el recorrido. El problema pertenece al dominio del cliente y no admite variantes: existe con independencia de que se construya software o no. La solución, en cambio, es una construcción del equipo, y por lo tanto admite alternativas, se evalúa, se descarta y se justifica. Confundir ambos planos tiene una consecuencia concreta y observable: toda crítica a la solución se vive como una crítica al problema, y el equipo la defiende en lugar de evaluarla.

El diseño, entendido de este modo, no es una etapa que antecede a la construcción y luego se abandona. Es una actividad que se ejerce en cada incremento, y cuyo resultado se mide por una propiedad muy concreta: cuánto cuesta introducir el próximo cambio.

### Fundamentos: ¿Por qué?

- toda decisión de diseño tiene un costo, y el costo que no se explicita se paga igual;
- las decisiones tomadas temprano se toman con la menor cantidad de información disponible;
- el costo de revertir una decisión crece con el tiempo y con el código construido encima;
- un diseño que no se puede verificar no puede considerarse terminado;
- y lo que no se encapsula se disemina, de modo que cada cambio posterior obliga a intervenir en muchos lugares.

El concepto de **costo del cambio** adquiere centralidad. Toda decisión de diseño puede evaluarse por su efecto sobre él: una estructura que concentra en un único lugar aquello que se espera que cambie reduce el costo de los cambios futuros; una que lo dispersa lo multiplica. La dificultad es que ese costo no se manifiesta en el momento en que la decisión se toma, sino varios incrementos después, cuando corregirla ya implica reescribir.

De ahí se sigue el criterio que atraviesa la unidad entera: **el trabajo del diseño no consiste en anticipar lo que el sistema va a necesitar, sino en identificar qué es probable que cambie y aislarlo**. La anticipación exhaustiva es imposible y además cara; la identificación de los puntos de variación probable es factible y barata, porque el relevamiento ya proveyó la información necesaria para hacerla.

La segunda noción que organiza la unidad es la de **compromiso**. No existen decisiones de arquitectura sin contrapartida: la flexibilidad se paga con complejidad, el rendimiento con mantenibilidad, la seguridad con usabilidad. Un diseño que parece no tener contrapartidas es, casi siempre, un diseño cuyas contrapartidas todavía no se identificaron.

### Mecanismos: ¿Cómo?

El diseño de una solución no se realiza mediante una técnica única ni produce un artefacto único. Se realiza a través de un conjunto articulado de análisis, modelos y decisiones registradas, cuya finalidad es reducir la incertidumbre antes de comprometer construcción:

- análisis comparado de alternativas de solución;
- estudio de factibilidad técnica, operativa, económica y temporal;
- modelado del comportamiento mediante casos de uso y diagramas de secuencia;
- modelado de datos mediante entidad-relación y su derivación al modelo relacional;
- descomposición en componentes según criterios de cohesión, acoplamiento e interfaz;
- definición de la arquitectura y de la dirección de las dependencias;
- especificación de los atributos de calidad como escenarios verificables;
- prototipado y evaluación de la interfaz antes de su construcción;
- selección fundamentada del conjunto de tecnologías y herramientas;
- y registro de las decisiones adoptadas mediante ADR.

### Material

- [Clean Architecture](https://www.pearson.com/en-us/subject-catalog/p/clean-architecture-a-craftsmans-guide-to-software-structure-and-design/P200000009528) — Robert C. Martin
- [Modern Software Engineering](https://www.davefarley.net/?p=352) — David Farley — 📄 PDF en `Docs/` del repositorio
- [Object-Oriented Software Construction](https://bertrandmeyer.com/OOSC2/) — Bertrand Meyer
- [Applying UML and Patterns](https://www.craiglarman.com/wiki/index.php?title=Book_Applying_UML_and_Patterns) — Craig Larman
- [Software Architecture in Practice](https://www.oreilly.com/library/view/software-architecture-in/9780132942799/) — Bass, Clements y Kazman
- [On the Criteria To Be Used in Decomposing Systems into Modules](https://doi.org/10.1145/361598.361623) — David Parnas
- [The Entity-Relationship Model](https://doi.org/10.1145/320434.320440) — Peter Chen
- [A Relational Model of Data for Large Shared Data Banks](https://doi.org/10.1145/362384.362685) — Edgar Codd
- [Documenting Architecture Decisions](https://cognitect.com/blog/2011/11/15/documenting-architecture-decisions.html) — Michael Nygard
- [10 Usability Heuristics for User Interface Design](https://www.nngroup.com/articles/ten-usability-heuristics/) — Jakob Nielsen

### Conocimiento necesario

- [Unidad 1 — Identificación y análisis de la problemática](../unidad-1/contenido.md), en particular el límite del sistema, los requerimientos no funcionales y los criterios de aceptación.
- [Casos de uso e historias de usuario](../unidad-1/requisitos.md).
- Modelado en UML y diagramas de clases, provenientes de Modelado y Diseño de Software y de Desarrollo de Sistemas Orientado a Objetos.
- Álgebra relacional y SQL, provenientes de Administración de Base de Datos.
- [El dominio del proyecto guía](../trabajo-integrador/consigna.md).

> **Sobre las citas.** Cada referencia indica capítulo y sección, porque la paginación cambia entre ediciones y entre las versiones en inglés y en castellano. Se indican páginas cuando la fuente es un artículo. Los enlaces fueron verificados el 14-09-2026.

--------

# Análisis de alternativas de solución

### El problema que resuelve

Un equipo que dispone de una sola propuesta no realizó una elección: adoptó la primera representación de la solución que estuvo disponible. Esa primera representación tiene una propiedad que conviene reconocer, porque se repite con regularidad: suele coincidir con aquello que el equipo ya sabía construir antes de escuchar al cliente. El análisis de alternativas existe para interrumpir esa coincidencia.

El análisis comparado cumple además una función que no es evidente. Comparar dos alternativas obliga a explicitar el criterio con el cual se las compara, y ese criterio —no la alternativa seleccionada— es lo que sostiene después las decisiones de arquitectura. Una sola alternativa mantiene el criterio implícito; dos lo vuelven necesario. Por eso el resultado más valioso de este análisis no es la opción ganadora sino la lista de criterios que la hicieron ganar, que es la que permite revisar la decisión cuando el contexto cambie.

Esta dinámica es un caso particular de una propiedad general del diseño de software, que Richards y Ford enuncian como primera ley de la arquitectura.

>Todo en arquitectura de software es un compromiso. Si alguien cree haber encontrado algo que no lo es, simplemente todavía no identificó cuál es el compromiso.
>
>Fundamentals of Software Architecture - Mark Richards & Neal Ford

La segunda ley que formulan resulta igualmente pertinente para la evaluación de un proyecto académico, y explica por qué el registro de la decisión importa tanto como la decisión: *el porqué es más importante que el cómo*.

### El espacio de decisión

La expresión "alternativa de solución" no designa productos distintos, sino decisiones distintas sobre cuatro planos, que conviene recorrer en el orden en que se enumeran, porque cada uno condiciona al siguiente.

##### 1. Construir, adaptar o adquirir

Es la primera pregunta y la que menos se formula: si el problema requiere efectivamente escribir software nuevo, o si admite una solución armada con herramientas existentes. Fowler propone una distinción útil para responderla, entre el software **estratégico** —aquel que constituye la ventaja propia y por lo tanto conviene construir— y el software **de utilidad** —aquel que todas las organizaciones necesitan y en el que ninguna obtiene ventaja por tener una versión propia—. La distinción no resuelve la decisión, pero la ordena: identifica qué parte del sistema justifica esfuerzo de construcción y cuál no.

##### 2. Alcance

Qué porción del problema se resuelve en esta versión. Es la dimensión con mayor impacto sobre la viabilidad del proyecto y la que admite más variantes legítimas: la misma problemática puede abordarse resolviendo el ciclo completo o resolviendo únicamente el segmento donde la información hoy no existe.

##### 3. Arquitectura

Cómo se organiza lo que se construye. Aplicación con servidor, aplicación de escritorio, proceso que produce un informe periódico. Cada opción determina qué atributos de calidad resultan alcanzables y cuáles quedan comprometidos.

##### 4. Tecnología

Con qué se construye. Lenguaje, motor de base de datos, bibliotecas.

El error de secuencia más costoso consiste en comenzar por el cuarto plano. Un equipo que inicia su análisis discutiendo el framework ya resolvió implícitamente que construirá software a medida, que el alcance es el total y que la arquitectura será la que ese framework impone. Tres decisiones adoptadas sin haber sido formuladas, y por lo tanto sin registro ni fundamento.

### El último momento responsable

No todas las decisiones deben tomarse al comienzo. El criterio operativo es el del **último momento responsable**: el punto a partir del cual postergar la decisión resulta más costoso que tomarla con información incompleta.

El argumento que lo sostiene es de disponibilidad de información. Toda decisión adoptada tempranamente se adopta con la menor cantidad de información que el proyecto va a tener en toda su vida. Postergarla no constituye indecisión, sino una estrategia de reducción de incertidumbre, siempre que se realice el trabajo de mantener abiertas las opciones. Una decisión postergada sin ese trabajo no está postergada: fue tomada por omisión y sin registro, que es la peor de las formas posibles.

La versión industrial del mismo principio es la ingeniería concurrente basada en conjuntos, documentada en el desarrollo de producto de Toyota. En lugar de seleccionar tempranamente una alternativa y corregirla después, se desarrollan varias en paralelo y se eliminan progresivamente a medida que la información se vuelve disponible. Ward, Liker, Cristiano y Sobek denominaron *la segunda paradoja de Toyota* al hecho, contraintuitivo, de que retrasar decisiones produjera mejores productos en menos tiempo.

En un proyecto acotado el desarrollo paralelo de alternativas no es viable, porque consume un presupuesto que no existe. Lo que sí es viable, y es lo que esta instancia del diseño exige, es explorar dos alternativas en el plano del análisis antes de comprometer construcción. Es el único momento del proyecto en el que cambiar de posición no tiene costo de reescritura.

### Comparación de alternativas

El instrumento mínimo es una matriz que dispone las alternativas en columnas y los criterios en filas, con evidencia en cada celda. Los criterios provienen del estudio de factibilidad y de los atributos de calidad que el proyecto haya declarado relevantes; ningún criterio se incorpora sin que exista una respuesta a la pregunta de cómo se lo mide.

Sobre las matrices ponderadas conviene una advertencia metodológica. Asignar pesos y calcular un resultado produce un número, y el número produce la impresión de que la decisión fue objetiva. No lo fue: la subjetividad se desplazó hacia los pesos, que rara vez se discuten porque quedaron fijados antes de comenzar. La matriz cumple una función de ordenamiento de la discusión y de registro, no de sustitución del juicio. Cuando el resultado del cálculo contradice el criterio del equipo, lo que corresponde revisar son los pesos, y esa revisión es la parte sustantiva del ejercicio.

### El registro de la decisión

Una decisión sin registro se vuelve a discutir, y se vuelve a discutir en el peor momento posible: varios incrementos después, cuando ya existe código construido sobre ella y nadie conserva el contexto que la justificó.

El formato de referencia es el **registro de decisión de arquitectura** (ADR), propuesto por Michael Nygard. Es un documento breve, versionado junto con el código, con cinco secciones.

```text
┌──────────────────────────────────────────────────────────────────────┐
│ TÍTULO                                                               │
│ Frase nominal corta y numerada                                       │
│ "ADR 3: El cálculo de riesgo se resuelve en el servidor"             │
├──────────────────────────────────────────────────────────────────────┤
│ ESTADO                                                               │
│ propuesta | aceptada | obsoleta | reemplazada por ADR N              │
├──────────────────────────────────────────────────────────────────────┤
│ CONTEXTO                                                             │
│ Las fuerzas en juego: técnicas, organizacionales, de plazo.          │
│ Redactado en lenguaje neutral, sin defender todavía ninguna opción   │
├──────────────────────────────────────────────────────────────────────┤
│ DECISIÓN                                                             │
│ "Vamos a...". Voz activa, oración completa                           │
├──────────────────────────────────────────────────────────────────────┤
│ CONSECUENCIAS                                                        │
│ El contexto resultante tras aplicar la decisión:                     │
│ lo positivo, lo negativo y lo neutro                                 │
└──────────────────────────────────────────────────────────────────────┘
```

Nygard insiste en dos condiciones de forma que determinan si el instrumento funciona: que el documento completo ocupe una o dos páginas, y que esté redactado en prosa legible y no en enumeraciones sueltas.

>Cada registro describe un conjunto de fuerzas y una única decisión en respuesta a ellas. [...] El documento completo debería tener una o dos páginas de extensión. Escribiremos cada uno como si fuera una conversación con un futuro desarrollador.
>
>[Documenting Architecture Decisions - Michael Nygard](https://cognitect.com/blog/2011/11/15/documenting-architecture-decisions.html)

La sección que con mayor frecuencia se omite es la última, y es la que otorga valor al registro: una decisión cuyas consecuencias negativas no fueron escritas no fue evaluada, fue justificada. La distinción no es retórica. Un ADR sin consecuencias adversas es indistinguible de una defensa, y por lo tanto no permite revisar nada.

Un ADR no se edita cuando la decisión cambia. Se redacta uno nuevo que reemplaza al anterior, y el anterior conserva su estado de reemplazado. La secuencia de decisiones constituye información en sí misma: documenta qué se sabía en cada momento del proyecto, y es el material con el que se sostiene después la fundamentación de lo construido.

### Aplicación al proyecto guía

El encargo del proyecto guía admite al menos tres alternativas defendibles, con esfuerzo creciente.

| | **A. Planilla instrumentada** | **B. Aplicación con panel** | **C. Integración con el sistema académico** |
|---|---|---|---|
| Naturaleza | Planilla de cálculo con fórmulas de riesgo y formato condicional | Aplicación propia: registro, cálculo, panel, alertas e intervenciones | La anterior, alimentada desde el sistema del instituto |
| Origen de los datos | Carga manual, como en la situación actual | Carga manual en pantallas diseñadas para esa tarea | Importación |
| Qué resuelve | El cruce entre asistencia y entregas | El cruce, la priorización, el historial y el seguimiento de las intervenciones | Todo lo anterior, más el trabajo de carga |
| Qué no resuelve | El seguimiento en el tiempo; la clienta sigue manteniendo fórmulas | La carga continúa siendo manual | — |

La alternativa A no es una opción de relleno y constituye la vara de comparación del proyecto. Resuelve la queja literal del encargo —el cruce manual entre dos fuentes de datos— con un esfuerzo de construcción marginal. Si la solución que el equipo propone construir no supera con claridad a una planilla bien confeccionada, el problema no reside en la calidad de la construcción sino en la definición del alcance.

La alternativa C se descarta por factibilidad y no por preferencia: el instituto no expone su base de datos, lo que constituye una limitación del entorno en el sentido establecido en la unidad anterior, y por lo tanto no es negociable. Descartarla por escrito cumple dos funciones: deja constancia de que fue evaluada y deja identificado el camino de evolución para una versión posterior.

La alternativa B se sostiene sobre un argumento que el ADR correspondiente debe explicitar: el problema del cliente no consiste en cruzar dos planillas sino en sostener un seguimiento a lo largo del tiempo, y registrar qué se hizo con cada estudiante y con qué resultado es precisamente lo que una planilla no hace.

### Anti-patrones frecuentes

- **Alternativas decorativas**: presentar tres opciones donde dos fueron construidas para perder. El análisis pierde toda función de control y se transforma en una justificación.
- **Comenzar por la tecnología**: discutir el framework antes que el alcance implica haber tomado ya, sin formularlas, las tres decisiones anteriores.
- **Descarte sin fundamento medible**: afirmar que una alternativa "no escala" sin definir qué carga se espera ni cómo se la mediría. Es una opinión enunciada con vocabulario técnico.
- **ADR sin consecuencias adversas**: convierte el registro en una defensa y elimina su utilidad para revisar la decisión más adelante.
- **Delegar la decisión en la matriz ponderada**: el resultado numérico no reemplaza el juicio; sólo desplaza la subjetividad hacia los pesos.

### Síntesis

El análisis de alternativas no produce una solución: produce un criterio. Su valor no está en la opción seleccionada sino en el conjunto de razones explicitadas que permiten, más adelante, evaluar si la decisión sigue siendo válida. Una decisión registrada puede revisarse; una decisión implícita sólo puede repetirse o abandonarse.

### Fuentes

- Richards, M. y Ford, N. (2020). *Fundamentals of Software Architecture: An Engineering Approach*, O'Reilly, cap. 1, "Introduction", sección "Laws of Software Architecture", y cap. 4, "Architecture Characteristics Defined".
- Nygard, M. (2011). "Documenting Architecture Decisions". https://cognitect.com/blog/2011/11/15/documenting-architecture-decisions.html · Plantillas y herramientas: https://adr.github.io/
- Poppendieck, M. y Poppendieck, T. (2003). *Lean Software Development: An Agile Toolkit*, Addison-Wesley, cap. 3, "Decide as Late as Possible".
- Ward, A., Liker, J., Cristiano, J. y Sobek, D. (1995). "The Second Toyota Paradox: How Delaying Decisions Can Make Better Cars Faster", *Sloan Management Review*, 36(3), pp. 43-61.
- Fowler, M. — "Utility vs Strategic Dichotomy". https://martinfowler.com/bliki/UtilityVsStrategicDichotomy.html

--------

# Criterios de evaluación y selección: la factibilidad

### Naturaleza del estudio de factibilidad

El estudio de factibilidad es la respuesta estructurada a una pregunta única: si el proyecto puede efectivamente realizarse. Se responde por cuatro vías independientes, y la falla de cualquiera de ellas invalida la alternativa completa.

| Dimensión | Pregunta | Consecuencia de no evaluarla |
|---|---|---|
| **Técnica** | ¿Existe la tecnología, está disponible y el equipo puede usarla? | Se descubre a mitad de la construcción, sin margen de corrección |
| **Operativa** | ¿El sistema va a ser usado, y por quién? | Se entrega una solución correcta que nadie incorpora a su trabajo |
| **Económica** | ¿El beneficio justifica el esfuerzo? | Se invierte más de lo que el problema justificaba |
| **Temporal** | ¿Entra en el plazo disponible? | Se llega al hito con una fracción del alcance comprometido |

Kendall y Kendall ubican este estudio en la iniciación del proyecto y son explícitos respecto de la función que cumple: no es un trámite destinado a justificar una decisión ya adoptada, sino el filtro que descarta proyectos. Un estudio de factibilidad del que nunca resulta un rechazo no está operando como filtro, sino como formalidad.

Conviene señalar que las cuatro dimensiones no tienen el mismo grado de dificultad para un equipo de desarrollo. La técnica resulta cómoda porque se formula en el vocabulario propio de la disciplina; las otras tres exigen mirar la organización, el presupuesto y el calendario, y son sistemáticamente las que se evalúan peor.

### Factibilidad técnica

Interroga si la tecnología necesaria existe, si está disponible y si el equipo puede utilizarla. Las tres condiciones son distintas entre sí, y la que habitualmente falla es la tercera.

La evaluación honesta de esta dimensión no consiste en discutir si el equipo puede, sino en verificarlo mediante una construcción reducida. Farley desarrolla este criterio bajo la noción de trabajo experimental: un experimento requiere una hipótesis, una medición y control de las variables, y produce evidencia donde una discusión produce opiniones. Una construcción de dos horas que levante un servidor, persista un registro y lo recupere responde la pregunta técnica con un grado de certeza que ninguna deliberación alcanza.

Esta idea reaparece más adelante bajo la forma del esqueleto ambulante, que es su aplicación sistemática al inicio del proyecto.

### Factibilidad operativa

Interroga si el sistema será efectivamente utilizado. Es la dimensión que invalida la mayor cantidad de proyectos técnicamente correctos, y exige desplazar la mirada del código hacia la persona y hacia el proceso de trabajo en el que el sistema se va a insertar.

Tres controles concretos permiten evaluarla:

- **Quién produce el dato, en qué momento y con qué esfuerzo.** Un sistema cuyo funcionamiento depende de que alguien registre información en un momento en que esa persona está ocupada en otra tarea no será alimentado, con independencia de su corrección.
- **Qué ocurre cuando el dato falta.** Un sistema que se vuelve inconsistente ante un registro omitido no es operable en condiciones reales, donde los registros se omiten.
- **Qué deja de hacer el usuario.** Si la solución se suma al procedimiento vigente en lugar de reemplazarlo, el trabajo total aumentó y la adopción no se va a producir.

La relación con el relevamiento es directa: el enemigo de la factibilidad operativa es el supuesto no verificado. La afirmación de que el usuario registrará la información en el momento en que el hecho ocurre es un supuesto, y como tal requiere responsable y fecha de verificación.

### Factibilidad económica

En contextos profesionales se calcula sobre costo de desarrollo, costo de operación y beneficio esperado. En un proyecto académico la unidad de medida no es monetaria sino la **hora-persona**, y el presupuesto se encuentra fijado de antemano.

```text
  Equipo                                   3 a 4 integrantes
  Dedicación                               1 a 2 horas semanales por integrante
  Incrementos de desarrollo                9
  ────────────────────────────────────────────────────────────────────────────
  Presupuesto total                        ~60 horas-persona por equipo
  Disponible por historia                  ~4 horas-persona
  (incluye especificación, construcción, pruebas y documentación)
```

Ese número tiene una consecuencia que conviene enunciar antes de que se manifieste: toda funcionalidad que consuma más de cinco horas-persona está desplazando una historia completa del backlog. La factibilidad económica de un proyecto con presupuesto fijo se juega íntegramente en la decisión sobre qué no se construye.

El concepto ausente en la mayoría de los análisis es el de **costo de oportunidad**. El costo real de construir la importación desde archivo no son las horas que insume, sino las funcionalidades del panel que no se construyeron durante esas horas. El costo se mide contra la mejor alternativa disponible para esos mismos recursos, nunca contra cero.

### Factibilidad temporal

Interroga si el alcance comprometido entra en el plazo. Cuando la fecha es inamovible, el planteo tradicional se invierte: el tiempo y los recursos quedan fijos y la única variable disponible es el alcance. De ahí que la priorización no constituya una tarea administrativa sino la decisión central del proyecto, y que el principio de simplicidad del Manifiesto Ágil —maximizar la cantidad de trabajo no realizado— sea una consecuencia lógica de tener tiempo fijo antes que una preferencia estética.

Lo que esta unidad agrega respecto del tratamiento del alcance en la unidad anterior es que el diseño incide sobre el plazo en ambas direcciones. Una arquitectura que el equipo no comprende consume semanas en diagnóstico; una arquitectura que separa el cálculo del registro permite construir y demostrar el cálculo sin esperar a que el registro esté completo. Elegir una arquitectura es, entre otras cosas, elegir el orden en que resulta posible entregar.

### Aplicación al proyecto guía

Las tres alternativas, evaluadas sobre las cuatro dimensiones:

| | **A. Planilla** | **B. Aplicación** | **C. Integración** |
|---|---|---|---|
| **Técnica** | Alta: la herramienta ya está en uso | Media: el equipo no cursó aún los módulos de desarrollo web. Se mitiga con una construcción mínima de punta a punta al inicio | **Inviable**: el instituto no expone su base de datos |
| **Operativa** | Media: persiste la dependencia del mantenimiento de fórmulas | Media-alta si el registro resulta rápido. **Constituye el riesgo principal del proyecto** | Alta: elimina la carga manual |
| **Económica** | Esfuerzo marginal, pero no cubre el encargo completo | Consume exactamente el presupuesto disponible | Excede el presupuesto |
| **Temporal** | Entra en un incremento | Entra con recorte sostenido del alcance | No entra |

El resultado del análisis no es la selección de la alternativa B, sino su selección bajo dos condiciones escritas: que la pantalla de registro de asistencia se diseñe contra el tiempo real disponible de la usuaria, y que el recorte de alcance sea una decisión permanente y no una intención. Ese es el nivel de fundamentación que distingue un análisis de una justificación.

### Anti-patrones frecuentes

- **Factibilidad afirmativa**: un párrafo que concluye que todo es factible. Un estudio que no descarta nada no cumple función de filtro.
- **Evaluar sólo la dimensión técnica**: es la única de las cuatro formulada en el vocabulario propio del equipo, y por eso la única que se evalúa con detalle.
- **Estimar sin contabilizar pruebas, documentación e integración**: es la causa más frecuente de subestimación sistemática.
- **Confundir disponibilidad con competencia**: la distancia entre que una tecnología exista y que el equipo pueda usarla se mide en semanas de proyecto.
- **Evaluar cada funcionalidad contra cero**: ignora el costo de oportunidad y produce un backlog en el que todo parece justificable.

### Síntesis

La factibilidad es el mecanismo por el cual una alternativa deja de ser una intención y se convierte en un compromiso. Su función es descartar, y un estudio que no descarta no está evaluando. En un proyecto con presupuesto y fecha fijos, la dimensión decisiva no es la técnica sino la económica, porque determina qué queda fuera; y la más frecuentemente subestimada es la operativa, porque sólo se manifiesta cuando el sistema ya está construido.

### Fuentes

- Kendall, K. y Kendall, J. *Análisis y diseño de sistemas* (8ª ed.), Pearson, cap. 3, "Administración de proyectos", secciones sobre iniciación del proyecto y determinación de la factibilidad técnica, económica y operativa.
- Senn, J. *Análisis y diseño de sistemas de información* (2ª ed.), McGraw-Hill, cap. sobre investigación preliminar y estudio de factibilidad.
- Farley, D. (2021). *Modern Software Engineering*, Addison-Wesley, cap. 8, "Being Experimental", secciones "Hypothesis", "Measurement" y "Controlling the Variables".
- Beck, K. y Fowler, M. (2000). *Planning Extreme Programming*, Addison-Wesley, caps. sobre el juego de la planificación y sobre alcance variable.
- DeMarco, T. y Lister, T. (2003). *Waltzing with Bears: Managing Risk on Software Projects*, Dorset House, parte I.

--------

# Modelado funcional: casos de uso y diagramas de secuencia

### El modo de uso determina el detalle

Antes de seleccionar una notación corresponde decidir para qué se la va a utilizar, porque de ese uso depende cuánto detalle resulta razonable. Fowler distingue tres modos.

| Modo | Finalidad | Detalle requerido |
|---|---|---|
| **Boceto** | Pensar de manera comunicable. Se dibuja, se discute y se descarta | El mínimo que sostenga la conversación |
| **Plano** | Especificar antes de construir. Una persona modela y otra implementa | Alto, y exige mantenimiento |
| **Lenguaje de programación** | Generar el sistema desde el modelo | Completo |

>Los diagramas de UML que dibujo suelen ser bocetos. Uso bocetos para ayudarme a comunicar ideas y alternativas sobre lo que estoy por hacer. [...] Lo esencial de un boceto es la selectividad.
>
>[UmlAsSketch - Martin Fowler](https://martinfowler.com/bliki/UmlAsSketch.html)

En un proyecto de estas dimensiones el modo pertinente es el de boceto, y conviene sostenerlo de manera explícita. Un diagrama que debe mantenerse sincronizado manualmente con el código se desactualiza en pocos incrementos, y a partir de ese momento desinforma, lo cual es peor que su inexistencia. El criterio operativo que se deriva es directo: **se modela aquello que todavía no está decidido**. Un diagrama que representa algo que el equipo ya sabe cómo va a construir no agrega información, agrega trabajo.

### El caso de uso como descripción de comportamiento

El caso de uso describe cómo un actor alcanza un objetivo mediante el sistema, incluidos los recorridos en los que no lo alcanza. Su valor no reside en el diagrama sino en el texto, y dentro del texto, en la sección de extensiones: es la que obliga a formular qué ocurre cuando el recorrido principal se interrumpe.

La relación entre caso de uso e historia de usuario está tratada en [unidad-1/requisitos.md](../unidad-1/requisitos.md). Lo que interesa en el plano del diseño es la consecuencia: la historia enuncia qué valor se entrega, mientras que el caso de uso enuncia qué secuencia de interacciones lo produce, y esa secuencia constituye el insumo directo tanto del diagrama de secuencia como de la distribución de responsabilidades entre componentes.

Cockburn propone el formato breve —dos o tres líneas por caso— como punto de partida, y reserva el formato completo para aquellos casos en los que el detalle modifica una decisión. En un proyecto con presupuesto acotado, redactar en formato completo la totalidad de los casos consume horas que se restan de la construcción; redactar en formato completo los dos de mayor riesgo constituye una inversión.

El diagrama de casos de uso, por su parte, no describe comportamiento: enumera objetivos y delimita el sistema. Funciona como índice, y en esa función resulta útil. Dos criterios evitan discusiones recurrentes: la caja del diagrama es la representación literal del límite del sistema establecido en la unidad anterior, de modo que todo elemento ubicado dentro de ella debe ser construido por el equipo; y las relaciones de inclusión y extensión se emplean poco, porque descomponer casos de uso para reutilizar tres pasos produce diagramas que aparentan diseño sin serlo.

### Diagrama de secuencia del sistema

El diagrama de secuencia del sistema toma un escenario de un caso de uso y representa exclusivamente lo que atraviesa el límite: los eventos que el actor genera, su orden y las respuestas del sistema. El sistema se representa como una única línea de vida, tratado como caja negra. No aparecen clases, objetos ni almacenamiento.

Su función es precisa y temprana: **fijar la interfaz entre el sistema y su entorno**. De allí se obtienen las operaciones que el sistema debe ofrecer, que son las que posteriormente se distribuyen entre componentes.

```text
  Tutor                          :Sistema
    │                                │
    │──── abrirClase(fecha) ────────►│
    │◄─── nómina de 30 estudiantes ──│
    │                                │
    │──── marcarAusente(legajo) ────►│   (una vez por cada ausente)
    │                                │
    │──── confirmarAsistencia() ────►│
    │◄─── confirmación ──────────────│
    │                                │
```

Un diagrama de esta extensión ya impone una decisión que la historia de usuario correspondiente no contenía: que se registran los ausentes y no los presentes, porque son menos. Es una decisión de diseño con efecto directo sobre la factibilidad operativa, y ejemplifica por qué el modelado temprano produce información y no sólo documentación.

### Diagrama de secuencia de diseño

El segundo diagrama abre la caja: representa los objetos o componentes internos y los mensajes que intercambian. Es el instrumento donde el acoplamiento se vuelve visible, porque el acoplamiento consiste precisamente en eso, en quién necesita comunicarse con quién para que un comportamiento ocurra.

Es el diagrama de mayor rendimiento de esta unidad y el que menos se construye. Una sola hoja permite detectar los dos defectos de diseño más frecuentes en proyectos de esta escala: un objeto que se comunica con todos los demás —el controlador que concentra el comportamiento, tratado más adelante como defecto de cohesión— y una cadena de mensajes de varios saltos destinada a obtener un dato, que es acoplamiento estructural encubierto.

### Contratos de operación

Un contrato de operación describe qué cambia en el estado del sistema cuando una operación se ejecuta, en términos de precondiciones y poscondiciones, sin comprometer una implementación.

Meyer lo formaliza como diseño por contrato: la precondición constituye la obligación de quien invoca y el beneficio de quien ejecuta; la poscondición invierte los papeles; el invariante expresa lo que se mantiene verdadero en todo momento. La idea de fondo es que cada módulo declare qué exige y qué garantiza, y que esa declaración forme parte de su interfaz y no de su documentación.

No se trata de un aparato teórico distante. Es el mismo contenido que los criterios de aceptación en formato Dado/Cuando/Entonces, formulado para quien diseña en lugar de para quien recibe.

| | Formulación para el cliente | Formulación para el diseño |
|---|---|---|
| Estructura | Dado / Cuando / Entonces | Precondición / Operación / Poscondición |
| Ejemplo | Dado que la comisión tiene 30 estudiantes cargados, cuando se marcan 4 ausentes y se confirma, entonces el panel refleja las 4 inasistencias | Pre: la clase existe y no está confirmada. Post: quedan registradas 4 ausencias y la clase queda confirmada |

Redactar el contrato antes de construir la operación produce un efecto observable: aparecen las precondiciones que no habían sido consideradas. Qué ocurre si se confirma dos veces la misma clase es una pregunta que el contrato obliga a responder y que la historia de usuario no formula.

### Aplicación al proyecto guía

El criterio de selección de qué modelar y qué no, aplicado al dominio:

| Se modela | Fundamento |
|---|---|
| Diagrama de secuencia del sistema de *registrar la asistencia de una clase* | Es la operación con mayor riesgo operativo: determina cuántas interacciones cuesta la tarea que se repite en cada clase |
| Diagrama de secuencia de diseño de *calcular el riesgo de la comisión* | Es donde se decide si el cálculo constituye un componente aislado o queda distribuido en la consulta del panel |
| Contrato de *confirmar asistencia* | Presenta precondiciones no evidentes: clase inexistente, clase ya confirmada, estudiante incorporado con posterioridad a la fecha |
| **No se modelan** el alta de estudiante ni el listado | Son operaciones conocidas, sin decisiones abiertas. Modelarlas es ceremonia |

### Anti-patrones frecuentes

- **Modelado exhaustivo previo a la construcción**: redactar todos los casos de uso en formato completo consume el presupuesto de los primeros incrementos sin producir nada verificable.
- **Confundir el diagrama de casos de uso con el diseño**: el diagrama enumera objetivos; no describe comportamiento ni estructura.
- **Diagramas de secuencia del sistema con elementos internos**: si aparece el almacenamiento, el sistema dejó de tratarse como caja negra y el diagrama perdió su función.
- **Modelar únicamente el recorrido principal**: las extensiones son la parte del análisis que descubre trabajo no previsto.
- **Sostener diagramas sincronizados manualmente con el código**: se desactualizan y a partir de ese punto inducen error.

### Síntesis

El modelado funcional no documenta: decide. Su rendimiento se concentra en los puntos donde existe incertidumbre —la operación que se repite, el comportamiento que todavía no está definido, la precondición que nadie formuló— y decae hasta volverse negativo cuando se aplica a lo que ya está resuelto. El contrato de operación es la forma en que el modelado se conecta con la verificación, y por lo tanto con la noción de terminado.

### Fuentes

- Larman, C. *Applying UML and Patterns* (3ª ed.), Prentice Hall, cap. 6, "Use Cases", §6.5 "Use Cases in Two Formats"; cap. 10, "System Sequence Diagrams"; cap. 11, "Operation Contracts".
- Fowler, M. (2003). *UML Distilled* (3ª ed.), Addison-Wesley, cap. 4, "Sequence Diagrams". Ed. en castellano: *UML gota a gota*.
- Cockburn, A. (2000). *Writing Effective Use Cases*, Addison-Wesley, cap. 2, "A Use Case Is a Prose Essay", y cap. 6, "Preconditions, Triggers, and Guarantees".
- Meyer, B. (1997). *Object-Oriented Software Construction* (2ª ed.), Prentice Hall, cap. 11, "Design by Contract: Building Reliable Software".
- Fowler, M. — "UmlMode", https://martinfowler.com/bliki/UmlMode.html · "UmlAsSketch", https://martinfowler.com/bliki/UmlAsSketch.html

--------

# Modelado de datos: entidad-relación y modelo relacional

### Modelo de dominio y modelo de datos

El modelo de dominio es una representación visual de los conceptos del problema y de sus relaciones, construida durante el relevamiento con el vocabulario del cliente, y no describe almacenamiento. El modelo de datos describe cómo esos conceptos se persisten.

La similitud entre ambos es suficiente como para que se confundan, y la confusión tiene consecuencias observables: se terminan discutiendo claves foráneas con el cliente, o se modela el problema como si el único requisito fuera guardarlo. Larman es explícito en que el modelo de dominio no constituye un modelo de datos y no incorpora responsabilidades ni estructuras de almacenamiento. Evans avanza en otra dirección y sostiene que el modelo debe estar ligado a la implementación y expresado en el mismo lenguaje que utiliza el negocio, que es el lenguaje ubicuo establecido durante el relevamiento.

En un proyecto de esta escala ambos modelos terminarán pareciéndose considerablemente, y eso no constituye un defecto. Lo que sí constituye un defecto es no saber cuál de los dos se está construyendo, porque de ello depende con quién se lo valida.

### El modelo entidad-relación

Chen propone el modelo entidad-relación en 1976 con un objetivo declarado: incorporar información semántica del mundo real al modelo de datos, situándose en un nivel por encima del modelo relacional, y proveer una notación diagramática que funcione como herramienta de diseño de bases de datos.

Sus tres construcciones:

| Construcción | Definición | Ejemplo |
|---|---|---|
| **Entidad** | Objeto del mundo real sobre el cual se desea registrar información | Estudiante, Comisión, Clase |
| **Atributo** | Propiedad de una entidad | Legajo, apellido, fecha |
| **Relación** | Asociación entre entidades | Un estudiante *pertenece a* una comisión |

La decisión que con mayor frecuencia se resuelve mal es la **cardinalidad**. Uno a uno, uno a muchos, muchos a muchos. Se resuelve consultando al cliente y nunca deduciéndola: si un estudiante puede pertenecer a dos comisiones es una pregunta de relevamiento, no de diseño, y la respuesta modifica el modelo completo.

Cuando una relación de muchos a muchos posee atributos propios, la relación es en realidad una entidad. Es el caso central del dominio de este proyecto: la asistencia no es una asociación entre estudiantes y clases, sino un hecho con fecha y estado que vincula a ambos y que admite corrección.

### Derivación al modelo relacional

El modelo relacional de Codd es anterior al entidad-relación y es el que los motores implementan. Su aporte consiste en separar la forma en que los datos se almacenan de la forma en que se consultan, y en sostener toda la estructura sobre una única construcción, la relación, sobre la cual operan un álgebra y un cálculo.

>Los futuros usuarios de los grandes bancos de datos deben protegerse de tener que saber cómo están organizados los datos en la máquina.
>
>A Relational Model of Data for Large Shared Data Banks - Edgar F. Codd

La derivación desde el modelo entidad-relación es prácticamente mecánica:

| En el modelo entidad-relación | En el modelo relacional |
|---|---|
| Entidad | Tabla, con clave primaria |
| Atributo | Columna, con su dominio |
| Relación uno a muchos | Clave foránea en el extremo "muchos" |
| Relación muchos a muchos | Tabla intermedia con ambas claves foráneas |
| Relación con atributos propios | Tabla propia |

Lo que el modelo entidad-relación no expresa y el esquema sí debe resolver es el comportamiento ante la eliminación del extremo único. La integridad referencial no constituye un detalle de implementación: es una regla de negocio inscripta en el esquema. En el dominio de este proyecto la regla proviene directamente del relevamiento —no eliminar a quien abandona, porque es precisamente el caso que el sistema existe para detectar— y su traducción al esquema es la ausencia de eliminación física.

### Normalización

Normalizar consiste en eliminar redundancia de modo que cada hecho quede registrado una única vez. Su fundamento es operativo antes que formal: el dato duplicado se actualiza en un lugar y no en el otro, y a partir de ese momento el sistema dispone de dos respuestas distintas para la misma pregunta.

El recorrido mínimo, con el síntoma que cada forma corrige:

| Forma | Regla | Síntoma que corrige |
|---|---|---|
| **1FN** | Cada celda contiene un único valor; no existen grupos repetidos | Una columna que almacena varias fechas de inasistencia separadas por comas |
| **2FN** | Ningún atributo depende de una parte de la clave compuesta | El nombre del estudiante repetido en cada registro de asistencia |
| **3FN** | Ningún atributo depende de otro atributo no clave | El nombre de la carrera almacenado junto a cada comisión |

Para un sistema de esta escala, la tercera forma normal es suficiente. Kent redactó la guía breve que conviene leer completa, y su aporte central consiste en mostrar que la normalización no constituye un ritual sino una consecuencia de enunciar correctamente qué depende de qué.

La desnormalización es una decisión legítima de rendimiento y, como tal, requiere medición previa y registro. Desnormalizar de manera preventiva, antes de disponer de un problema medido, es optimización prematura y se paga con inconsistencias que aparecen tardíamente y cuya causa resulta difícil de localizar.

### El dato que cambia con el tiempo

Esta es la sección de mayor consecuencia práctica del tema, y la que sistemáticamente queda fuera de los modelos construidos sin asistencia.

La mayor parte de los modelos de datos representan el **estado actual**: cuántas inasistencias acumula hoy cada estudiante, cuál es el umbral vigente hoy. La representación funciona correctamente hasta que se formula una pregunta sobre el pasado, momento en el cual no existe respuesta posible, porque el pasado fue sobrescrito.

Fowler cataloga las variantes del problema bajo la denominación de patrones temporales, y la distinción que conviene retener es la que separa el **tiempo del hecho** del **tiempo del registro**. No son equivalentes: la asistencia de una fecha puede registrarse una semana después, y una corrección posterior modifica lo que el sistema sabe, no lo que ocurrió. Cuando ambas dimensiones importan simultáneamente, la información es bitemporal.

Las tres soluciones habituales, ordenadas por costo de implementación:

| Patrón | Mecanismo | Cuándo resulta suficiente |
|---|---|---|
| **Registro de auditoría** | Los cambios se registran en una estructura separada, sin alterar el modelo principal | Cuando el histórico se consulta ocasionalmente |
| **Vigencia** | Cada registro incorpora el intervalo durante el cual es válido | Cuando un valor cambia y es necesario conocer cuál regía en una fecha dada |
| **Objeto temporal** | Cada modificación genera una versión nueva; ningún valor se sobrescribe | Cuando el historial forma parte del producto |

La consecuencia de diseño no es modelar toda la información como bitemporal, lo cual constituiría sobreingeniería y consumiría el presupuesto disponible. La consecuencia es formular la pregunta entidad por entidad y registrar la respuesta: si ese dato cambia en el tiempo, si alguien va a necesitar conocer su valor anterior, y quién lo va a preguntar. En el dominio de este proyecto tres entidades responden afirmativamente, y ninguna de las tres es evidente antes de formular la pregunta.

### Aplicación al proyecto guía

Modelo mínimo defendible del sistema de seguimiento:

```text
  COMISION      (id, nombre, ciclo_lectivo, cuatrimestre)
  ESTUDIANTE    (legajo, apellido, nombre)
  INSCRIPCION   (legajo → ESTUDIANTE, id_comision → COMISION, desde, hasta)   ◄── vigencia
  CLASE         (id, id_comision → COMISION, fecha, confirmada)
  ASISTENCIA    (id_clase → CLASE, legajo → ESTUDIANTE, estado)
  TRABAJO       (id, id_comision → COMISION, titulo, fecha_limite)
  ENTREGA       (id_trabajo → TRABAJO, legajo → ESTUDIANTE, estado, fecha)
  UMBRAL        (id, nombre, valor, vigente_desde, vigente_hasta)             ◄── vigencia
  INTERVENCION  (id, legajo → ESTUDIANTE, fecha, medio, resultado)
```

El esquema incorpora cuatro decisiones que requieren fundamentación:

##### 1. La asistencia es una entidad y no una relación

Posee estado propio y admite corrección. Si se la modelara como la simple asociación entre estudiante y clase, corregir implicaría eliminar, y se perdería el registro de que hubo corrección, que es información relevante para el usuario.

##### 2. La inscripción incorpora vigencia

Porque el relevamiento estableció que hay incorporaciones posteriores al inicio del período y que nadie se elimina. Sin la fecha de incorporación, el porcentaje de inasistencias de quien ingresó avanzado el cuatrimestre resulta incorrecto, y lo hace en la dirección más perjudicial: sobreestima el riesgo de quien menos lo tiene.

##### 3. El umbral es una entidad con vigencia

Es lo que permite configurar el criterio sin intervenir el código, y lo que habilita explicar por qué un estudiante presentaba un nivel de riesgo en un momento y otro distinto más adelante sin que sus inasistencias hubieran cambiado.

##### 4. El riesgo no forma parte del esquema

Se calcula; no se almacena. Almacenarlo implicaría duplicar un hecho derivado, con el problema conocido de la desactualización silenciosa. La excepción legítima aparece si se requiere representar la evolución del riesgo a lo largo del tiempo, en cuyo caso corresponde almacenar una instantánea por período, y esa es una decisión que requiere registro.

El recorte correspondiente al primer incremento es considerablemente menor que este esquema: estudiante, comisión, clase y asistencia, sin vigencias. El modelo completo constituye el horizonte y no la primera entrega. Lo que el diseño exige es saber cuál de los dos se está construyendo.

### Anti-patrones frecuentes

- **Modelar la interfaz en lugar del dominio**: una tabla por pantalla. Produce un esquema que sólo sirve para la primera versión de la interfaz.
- **Almacenar el resultado del cálculo junto a la entidad**: se desactualiza en el primer registro posterior y produce dos respuestas para la misma pregunta.
- **Tabla única con todos los atributos**: incumplimiento de la primera forma normal, más frecuente de lo que la teoría sugiere.
- **Eliminación física de registros que el dominio exige conservar**: destruye precisamente el caso que el sistema existe para detectar.
- **Deducir la cardinalidad en lugar de consultarla**: es una pregunta de relevamiento y su respuesta modifica el esquema completo.
- **Modelar historicidad en todas las entidades**: el extremo opuesto también constituye un defecto, y consume un presupuesto que el proyecto no tiene.

### Síntesis

El modelo de datos es la decisión de diseño más costosa de revertir, porque todo lo demás se construye encima. Su calidad no se mide por el grado de normalización alcanzado sino por dos propiedades: que represente el vocabulario y las reglas del dominio relevado, y que haya respondido explícitamente, entidad por entidad, la pregunta sobre el cambio en el tiempo. Un esquema que sólo representa el presente responde correctamente hasta la primera pregunta sobre el pasado.

### Fuentes

- Chen, P. (1976). "The Entity-Relationship Model — Toward a Unified View of Data", *ACM Transactions on Database Systems*, 1(1), pp. 9-36. https://doi.org/10.1145/320434.320440
- Codd, E. F. (1970). "A Relational Model of Data for Large Shared Data Banks", *Communications of the ACM*, 13(6), pp. 377-387. https://doi.org/10.1145/362384.362685
- Kent, W. (1983). "A Simple Guide to Five Normal Forms in Relational Database Theory", *Communications of the ACM*, 26(2), pp. 120-125. https://doi.org/10.1145/358024.358054
- Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 9, "Domain Models", §9.16 "Is a Domain Model Really a Data Model?".
- Evans, E. (2003). *Domain-Driven Design*, Addison-Wesley, cap. 3, "Binding Model and Implementation", y cap. 5, "A Model Expressed in Software".
- Fowler, M. — "Temporal Patterns". https://martinfowler.com/eaaDev/timeNarrative.html
- Snodgrass, R. T. (1999). *Developing Time-Oriented Database Applications in SQL*, Morgan Kaufmann. Disponible completo por el autor: https://www2.cs.arizona.edu/~rts/tdbbook.pdf

--------

# Diseño de procesos, componentes e interfaces

### El criterio de descomposición

La pregunta central del diseño de componentes admite una formulación única: por dónde se corta el sistema.

La respuesta intuitiva consiste en cortar por los pasos del procesamiento —un módulo que lee, uno que calcula, uno que presenta—, y es exactamente la que Parnas refuta en 1972. Su artículo compara dos descomposiciones del mismo programa: una organizada según el diagrama de flujo y otra organizada según las decisiones de diseño que cada módulo oculta. La conclusión es que el criterio adecuado no es la secuencia de ejecución sino el ocultamiento de información.

>Proponemos, en cambio, comenzar con una lista de decisiones de diseño difíciles o decisiones de diseño que probablemente cambien. Cada módulo se diseña entonces para ocultar esa decisión a los demás.
>
>On the Criteria To Be Used in Decomposing Systems into Modules - David L. Parnas

La consecuencia práctica es contraintuitiva y conviene enunciarla con claridad: **los módulos no se corresponden con los pasos de la ejecución, sino con los elementos que pueden cambiar por separado**. Un sistema descompuesto según el flujo obliga a intervenir en todos los módulos ante cualquier modificación del comportamiento; un sistema descompuesto según los puntos de variación concentra cada cambio en un único lugar.

### Cohesión y acoplamiento

Ambos términos provienen del artículo fundacional de Stevens, Myers y Constantine sobre diseño estructurado, y continúan siendo el par de medidas más productivo del que dispone el diseño de software.

| Medida | Qué expresa | Valor deseable |
|---|---|---|
| **Cohesión** | Grado de relación entre los elementos contenidos en un módulo | Alto |
| **Acoplamiento** | Grado de dependencia de un módulo respecto de los detalles de otro | Bajo |

Farley les dedica dos capítulos completos y aporta el encuadre que conviene retener: modularidad y cohesión constituyen los instrumentos fundamentales para gestionar la complejidad, y el costo de la baja cohesión no es estético sino económico, porque obliga a intervenir en múltiples lugares para producir un cambio conceptualmente único.

Dos verificaciones permiten evaluar ambas medidas sin necesidad de revisar el código completo:

- **Cohesión.** Describir el módulo en una oración. Si la descripción requiere una conjunción copulativa, la cohesión es baja.
- **Acoplamiento.** Enumerar qué cambios en otros módulos obligarían a intervenir en este. Si la enumeración es extensa, el acoplamiento es alto.

Farley formula además una advertencia pertinente para proyectos de escala reducida: **desacoplar tiene costo en código**. Introducir una interfaz donde antes existía una invocación directa agrega líneas y agrega indirección. La operación se justifica donde se espera variación y no se justifica donde no se la espera, lo cual devuelve el problema al criterio de Parnas: el esfuerzo de desacoplamiento se concentra en los puntos de cambio probable, identificados durante el relevamiento.

### La interfaz como contrato

La interfaz de un componente constituye lo único que los demás pueden observar de él. Todo elemento expuesto se incorpora de hecho al contrato: alguien establecerá una dependencia sobre él y a partir de ese momento no podrá modificarse sin romper.

De ahí la preferencia que Farley enuncia como criterio por defecto, ocultar información siempre que resulte posible, y que Meyer convierte en método mediante el diseño por contrato ya tratado: la interfaz declara qué exige y qué garantiza, y todo lo demás permanece bajo control del componente.

Meyer aporta además cinco reglas de modularidad, de las cuales dos resultan de aplicación inmediata y detectan una proporción alta de los defectos habituales:

- **Interfaces pequeñas.** Si dos módulos se comunican, deben intercambiar la menor cantidad posible de información.
- **Interfaces explícitas.** Si un módulo depende de otro, la dependencia debe ser visible en el texto del programa.

La segunda es la que se incumple con mayor frecuencia en proyectos de esta escala, y casi siempre a través del almacenamiento: dos componentes que se comunican escribiendo y leyendo la misma tabla presentan un acoplamiento fuerte cuya dependencia no aparece en ninguna parte del código. Es la forma más difícil de detectar y la más costosa de corregir, porque no se manifiesta hasta que uno de los dos cambia.

### Asignación de responsabilidades

Cohesión y acoplamiento permiten evaluar un diseño, pero no indican cómo producirlo. Para eso existen dos catálogos que formulan criterios equivalentes con vocabularios distintos.

**GRASP**, desarrollado por Larman, agrupa patrones de asignación de responsabilidades. Los cinco de aplicación general:

| Patrón | Criterio |
|---|---|
| **Experto en información** | La responsabilidad se asigna donde reside la información necesaria para cumplirla |
| **Creador** | La creación de un objeto corresponde a quien lo contiene, lo agrega o posee sus datos de inicialización |
| **Controlador** | El evento del sistema es recibido por un objeto que no pertenece a la capa de presentación |
| **Bajo acoplamiento** | Entre dos diseños posibles, se prefiere el que genera menos dependencias |
| **Alta cohesión** | Entre dos diseños posibles, se prefiere el que mantiene responsabilidades más enfocadas |

**SOLID**, formulado por Martin, agrupa principios de diseño de clases. El primero es el más utilizado y el peor interpretado: el principio de responsabilidad única no establece que una clase deba hacer una sola cosa, sino que **debe tener una única razón para cambiar**, definida por quién solicita el cambio. Si un mismo módulo debe modificarse tanto ante un cambio en el criterio de negocio como ante un cambio en el formato de presentación, existen dos razones y corresponde dividirlo.

Los restantes cuatro, enunciados de manera compacta: abierto/cerrado, extender sin modificar; sustitución de Liskov, un subtipo debe poder reemplazar al tipo base sin alterar la corrección del programa; segregación de interfaces, ningún cliente debería depender de métodos que no utiliza; inversión de dependencias, los detalles dependen de las abstracciones y no a la inversa.

### Cohesión y acoplamiento de componentes

Un componente es una unidad de despliegue: aquello que puede construirse, versionarse y entregarse por separado. En proyectos de escala reducida los componentes suelen materializarse como módulos o paquetes y no como artefactos desplegables independientes, lo cual no altera la validez de los criterios.

Martin traslada ambas medidas al nivel de componente. Dos principios resultan de aplicación directa:

- **Equivalencia entre reutilización y entrega**: la unidad que se reutiliza debe coincidir con la unidad que se versiona y se libera. Lo que no puede versionarse no puede reutilizarse con seguridad.
- **Cierre común**: las clases que cambian por la misma razón y al mismo tiempo pertenecen al mismo componente. Es el principio de responsabilidad única aplicado a un nivel superior de granularidad, y es el criterio más útil para decidir la organización en paquetes.

A ellos se agrega una regla de acoplamiento que en proyectos de esta escala resulta suficiente por sí sola: **ausencia de ciclos**. Cuando un componente depende de otro que a su vez depende del primero, no existe forma de construir, probar ni comprender uno con independencia del otro.

```text
  Con ciclo                              Sin ciclo
  ┌──────────┐     ┌──────────┐          ┌──────────┐     ┌──────────┐
  │ Módulo A │ ──► │ Módulo B │          │ Módulo A │ ──► │ Módulo B │
  └──────────┘     └──────────┘          └──────────┘     └──────────┘
       ▲                │                                      │
       │                ▼                                      ▼
  ┌──────────┐     ┌──────────┐                           ┌──────────┐
  │ Módulo D │ ◄── │ Módulo C │                           │ Módulo C │
  └──────────┘     └──────────┘                           └──────────┘
```

La aparición de un ciclo suele indicar la ausencia de un tercer componente que ambos deberían utilizar, y no un exceso de dependencias.

### Diseño de procesos

Se entiende aquí por proceso el recorrido completo que satisface un objetivo del usuario atravesando varios componentes. El sistema del proyecto guía presenta tres.

```text
  REGISTRO      interfaz de carga ──► validación ──► persistencia

  CÁLCULO       lectura de hechos ──► reglas de riesgo ──► ordenamiento

  SEGUIMIENTO   panel ──► selección ──► registro de intervención ──┐
                  ▲                                                │
                  └────────────────────────────────────────────────┘
```

Esos tres recorridos obligan a resolver una decisión que ninguna historia de usuario formula: **en qué momento se ejecuta el cálculo**, al consultar el panel o ante cada registro de asistencia. La decisión tiene consecuencias sobre el rendimiento, sobre la consistencia y sobre si el riesgo se almacena o se deriva. En un sistema con un único usuario y un volumen de datos reducido, calcular al consultar es la opción correcta y la más simple. Lo que el diseño exige no es acertar, sino haber identificado que existía una decisión.

### Aplicación al proyecto guía

El componente que requiere aislamiento es el que resuelve el cálculo de riesgo, y los fundamentos son tres, en orden de peso.

##### 1. Es el punto de variación identificado

El relevamiento muestra que la clienta no sostiene un criterio único sobre cuál es la señal principal de desgranamiento, y el criterio real se va a establecer recién a mitad del proyecto. Es, en los términos de Parnas, la decisión de diseño que probablemente cambie.

##### 2. Es lo único verificable sin interfaz

Un componente que recibe hechos y produce un valor se verifica mediante una tabla de casos, sin necesidad de levantar la aplicación ni de disponer de almacenamiento. Esa propiedad determina el costo de las pruebas automatizadas de toda la unidad siguiente.

##### 3. Es el objeto de la fundamentación

Si el criterio de riesgo está distribuido entre la consulta al almacenamiento y la construcción de la pantalla, no existe una respuesta posible a la pregunta por cómo se calcula el riesgo, porque no hay un lugar donde esté escrito.

Su interfaz, formulada como contrato:

```text
  calcularRiesgo(comisión, fecha_de_corte)
      → lista de (estudiante, nivel, señales que lo justifican)

  Pre    la comisión existe
         la fecha de corte no es anterior al inicio del período

  Post   una fila por cada estudiante inscripto y vigente a la fecha de corte
         el nivel se calcula con los umbrales vigentes a esa fecha
         cada fila incluye los valores que justifican el nivel asignado

  No hace    no escribe en el almacenamiento
             no aplica formato
             no ordena para una presentación concreta
```

Las tres exclusiones finales son las que preservan la cohesión del componente. La fecha de corte como parámetro, en lugar de una referencia interna al momento actual, es lo que permite responder preguntas sobre el pasado y lo que vuelve al componente independiente del reloj, condición necesaria para poder verificarlo.

### Anti-patrones frecuentes

- **Descomponer según los pasos del flujo**: produce módulos que deben modificarse todos ante cualquier cambio de comportamiento.
- **Controlador que concentra el comportamiento**: recibe el evento, consulta, calcula y construye la respuesta. Es el defecto de cohesión más frecuente.
- **Reglas de negocio en la consulta o en la presentación**: dispersa el criterio y elimina la posibilidad de verificarlo de manera aislada.
- **Comunicación entre componentes a través del almacenamiento compartido**: acoplamiento fuerte e invisible, que no aparece en ninguna declaración del código.
- **Interfaces que exponen estructuras internas**: todo lo expuesto se convierte en contrato y deja de poder modificarse libremente.
- **Desacoplar la totalidad del sistema**: la indirección tiene costo, y aplicada donde no se espera variación constituye sobreingeniería.

### Síntesis

La descomposición correcta no sigue la secuencia de ejecución sino la distribución de la variabilidad esperada. Cohesión y acoplamiento son las dos medidas que permiten evaluarla, y ambas admiten verificación rápida sin instrumentos: describir el módulo en una oración y enumerar qué lo obliga a cambiar. El resultado del diseño de componentes se mide por una sola cantidad, que es cuántos lugares del sistema deben modificarse para introducir el próximo cambio previsible.

### Fuentes

- Parnas, D. L. (1972). "On the Criteria To Be Used in Decomposing Systems into Modules", *Communications of the ACM*, 15(12), pp. 1053-1058. https://doi.org/10.1145/361598.361623
- Stevens, W., Myers, G. y Constantine, L. (1974). "Structured Design", *IBM Systems Journal*, 13(2), pp. 115-139. https://doi.org/10.1147/sj.132.0115
- Farley, D. (2021). *Modern Software Engineering*, cap. 9, "Modularity"; cap. 10, "Cohesion"; cap. 12, "Information Hiding and Abstraction"; cap. 13, "Managing Coupling", sección "Decoupling May Mean More Code".
- Meyer, B. (1997). *Object-Oriented Software Construction* (2ª ed.), cap. 3, "Modularity", secciones sobre los cinco criterios y las cinco reglas.
- Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 17, "GRASP: Designing Objects with Responsibilities".
- Martin, R. C. (2017). *Clean Architecture*, parte III, "Design Principles", caps. 7 a 11; parte IV, "Component Principles", caps. 13 y 14.

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

### Cliente-servidor: distribución de la ejecución

En una aplicación con arquitectura cliente-servidor existe una decisión que suele adoptarse por inercia y que merece formularse: qué porción del comportamiento se ejecuta en el cliente y cuál en el servidor.

Para un sistema con un único usuario, sin requisitos de operación desconectada y sin necesidad de interacción de grano fino, la ejecución concentrada en el servidor con presentación renderizada constituye la opción de menor complejidad. Lo que corresponde explicitar es qué se resigna: interactividad inmediata y actualización autónoma de la vista.

La regla general que trasciende la elección tecnológica es que **las reglas de negocio no residen en el cliente**. Todo lo que se ejecuta del lado del usuario es modificable por él y debe revalidarse del otro lado. En esta unidad el criterio importa por consistencia; sus implicancias de seguridad corresponden a un tratamiento posterior.

### Servicios e integraciones

Un sistema se vuelve distribuido cuando sus partes se comunican a través de la red. Esa frontera modifica las propiedades de toda invocación: lo que era una llamada a una función pasa a poder demorarse, fallar parcialmente o producir un resultado inconsistente.

Respecto de la descomposición en servicios independientes, la posición sostenida por quienes más contribuyeron a difundirla es explícita: la casi totalidad de los casos exitosos comenzaron como sistemas monolíticos que se dividieron al crecer, mientras que los que se iniciaron directamente distribuidos presentaron dificultades severas. El fundamento es económico: la complejidad distribuida se paga desde el primer día, mientras que el beneficio aparece recién con una escala de equipos y de carga que un proyecto de esta naturaleza no alcanza.

Farley arriba a la misma conclusión desde el diseño: los servicios constituyen una forma de modularidad con una frontera de despliegue, útil cuando es necesario escalar organizaciones, y el criterio que determina su viabilidad sigue siendo el acoplamiento.

De las integraciones con sistemas externos, esta unidad requiere retener una sola idea, desarrollada por Nygard: **todo punto de integración es un punto de falla**, y corresponde diseñar el comportamiento del sistema para el caso en que el otro extremo no responde. La pregunta de diseño no es si la integración funciona, sino qué ocurre cuando no funciona.

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

Farley dedica una sección al criterio de adopción, y coincide con el que atraviesa la unidad: se adopta cuando existe un dominio con reglas propias cuyo aislamiento resulta valioso. Aplicar el esquema al sistema completo, incluidas las operaciones de registro que no poseen reglas, constituye ceremonia; aplicarlo al núcleo donde reside el criterio que se espera que cambie es lo que permite verificarlo sin almacenamiento y modificarlo sin intervenir la presentación.

### La arquitectura y la estructura del equipo

Conway observó en 1968 que la estructura de un sistema reproduce la estructura de comunicación de la organización que lo construye.

>Las organizaciones que diseñan sistemas están abocadas a producir diseños que son copias de las estructuras de comunicación de esas organizaciones.
>
>[How Do Committees Invent? - Melvin Conway](http://www.melconway.com/Home/Committees_Paper.html)

No se trata de una metáfora sino de una restricción operativa, y su consecuencia en un proyecto de equipo reducido es inmediata. Si el trabajo se distribuye por capas técnicas —una persona construye las pantallas, otra el almacenamiento—, el sistema reproducirá esa división y las reglas del dominio quedarán repartidas entre ambas mitades. Si se distribuye por funcionalidad completa, los límites del sistema caerán donde el problema los requiere.

Es una decisión de arquitectura que se toma durante la planificación del trabajo, habitualmente sin advertir que se la está tomando.

### Aplicación al proyecto guía

La arquitectura mínima defendible para el dominio del proyecto:

```text
                              navegador
                                  │
                                  │ HTTP
  ┌───────────────────────────────▼───────────────────────────────┐
  │  PRESENTACIÓN                                                 │
  │  pantallas de registro, panel, ficha, informes                │
  ├───────────────────────────────────────────────────────────────┤
  │  DOMINIO                                                      │
  │  reglas de asistencia y entregas                              │
  │  ►► cálculo de riesgo ◄◄  (detrás de un puerto propio)        │
  │  reglas de intervención                                       │
  ├───────────────────────────────────────────────────────────────┤
  │  DATOS                                                        │
  │  repositorios ──► base relacional                             │
  └───────────────────────────────────────────────────────────────┘
```

Cada pieza requiere una justificación explícita:

| Decisión | Fundamento |
|---|---|
| Un único proceso desplegable | Un usuario y un volumen reducido de datos. La complejidad distribuida no encuentra contrapartida |
| Tres capas lógicas | Separan responsabilidades que cambian por motivos distintos |
| Cálculo de riesgo detrás de un puerto | Es el punto de variación identificado y el único elemento verificable sin interfaz |
| Almacenamiento relacional | El dominio es relacional: entidades estables con relaciones definidas |
| Sin control de acceso en la primera versión | El encargo establece un único usuario. La decisión queda declarada como diferida, no como omitida |

Las dos últimas filas son las que requieren mayor capacidad de fundamentación, porque ambas constituyen decisiones y no evidencias, y ambas serán revisadas cuando el alcance del sistema se amplíe.

### Anti-patrones frecuentes

- **Descomposición en servicios sin escala que la justifique**: se asume la totalidad de la complejidad distribuida sin obtener ninguno de sus beneficios.
- **Capas presentes en el diagrama y ausentes en el código**: reglas de negocio alojadas en la presentación o en la consulta al almacenamiento.
- **Dependencias en dirección inversa**: el dominio que conoce el formato de presentación pierde toda posibilidad de reutilización y de verificación aislada.
- **Adoptar la arquitectura que el framework impone sin poder explicarla**: que la herramienta resuelva parte del diseño es legítimo; desconocer qué resolvió, no.
- **Aplicar puertos y adaptadores a la totalidad del sistema**: es la forma de sobreingeniería más habitual inmediatamente después de conocer el esquema.
- **Distribuir el trabajo por capas dentro del equipo**: por la observación de Conway, el diseño reproducirá esa división con independencia de lo que indique el diagrama.

### Síntesis

La arquitectura se define por el costo de cambio de las decisiones que la componen, no por la cantidad de elementos que contiene. En un proyecto de escala reducida el trabajo arquitectónico consiste casi íntegramente en dos operaciones: fijar la dirección de las dependencias, de modo que el dominio no conozca a quienes lo consumen, y aislar el punto de variación identificado durante el relevamiento. Todo lo demás admite ser simple, y conviene que lo sea.

### Fuentes

- Martin, R. C. (2017). *Clean Architecture*, cap. 15, "What Is Architecture?"; cap. 16, "Independence"; cap. 17, "Boundaries: Drawing Lines"; cap. 22, "The Clean Architecture".
- Fowler, M. (2003). "Who Needs an Architect?", *IEEE Software*, 20(5). https://martinfowler.com/ieeeSoftware/whoNeedsArchitect.pdf
- Fowler, M. (2002). *Patterns of Enterprise Application Architecture*, Addison-Wesley, cap. 1, "Layering" · "Presentation Domain Data Layering", https://martinfowler.com/bliki/PresentationDomainDataLayering.html
- Cockburn, A. (2005). "Hexagonal (Ports & Adapters) Architecture". https://alistair.cockburn.us/hexagonal-architecture/
- Farley, D. (2021). *Modern Software Engineering*, cap. 11, "Separation of Concerns", secciones "Ports & Adapters" y "When to Adopt Ports & Adapters"; cap. 13, sección "Microservices".
- Fowler, M. — "Monolith First", https://martinfowler.com/bliki/MonolithFirst.html · "Microservice Premium", https://martinfowler.com/bliki/MicroservicePremium.html
- Nygard, M. (2018). *Release It!* (2ª ed.), Pragmatic Bookshelf, caps. sobre puntos de integración y antipatrones de estabilidad.
- Conway, M. (1968). "How Do Committees Invent?", *Datamation*, 14(5), pp. 28-31. http://www.melconway.com/Home/Committees_Paper.html
- Evans, E. (2003). *Domain-Driven Design*, cap. 4, "Isolating the Domain".

--------

# Atributos de calidad y sus tensiones

### Del adjetivo al escenario

La unidad anterior estableció que un requerimiento no funcional sólo es útil si admite comprobación. Los atributos de calidad son la forma en que esa exigencia se traduce a un instrumento operable.

Bass, Clements y Kazman proponen el **escenario de atributo de calidad** en seis partes, que convierte un adjetivo en una afirmación verificable:

```text
  ┌─────────────────────┬─────────────────────────────────────────────────────┐
  │ Fuente del estímulo │ La tutora                                           │
  │ Estímulo            │ Abre el panel de una comisión                       │
  │ Artefacto           │ El sistema completo                                 │
  │ Entorno             │ Operación normal, con el período completo cargado   │
  │ Respuesta           │ El panel se presenta ordenado por nivel de riesgo   │
  │ Medida de respuesta │ En menos de 3 segundos, con 60 estudiantes          │
  │                     │ y 16 semanas de datos                               │
  └─────────────────────┴─────────────────────────────────────────────────────┘
```

La comparación entre la afirmación de que el sistema debe ser rápido y el escenario completo muestra la diferencia de estatus entre ambas: la primera no puede verificarse, no permite diseñar contra ella ni rechazar un incremento; la segunda cumple las tres funciones y además especifica qué se debe probar.

Un criterio de economía acompaña la técnica: tres escenarios por proyecto, no quince. Un conjunto extenso de escenarios que nunca se verifican equivale a no tener ninguno, con el costo adicional de haberlos redactado.

### Los atributos en juego

| Atributo | Pregunta que responde | Medida aplicable al proyecto guía |
|---|---|---|
| **Mantenibilidad** | ¿Cuánto cuesta modificarlo? | Cantidad de lugares que deben intervenirse para incorporar una señal de riesgo |
| **Escalabilidad** | ¿Soporta mayor carga? | **Prácticamente no aplica**: un usuario, volumen reducido |
| **Usabilidad** | ¿Puede utilizarse eficazmente? | Tiempo requerido para registrar la asistencia de una clase |
| **Seguridad** | ¿Quién accede a qué? | Datos personales de estudiantes bajo el régimen de la Ley 25.326 |

La fila correspondiente a la escalabilidad es la de mayor valor formativo. **Descartar un atributo con fundamento tiene el mismo valor que incorporarlo**, y este proyecto constituye el caso apropiado para ejercerlo: no existe concurrencia ni volumen, y diseñar para una escala inexistente consume el presupuesto en un problema imaginario. Lo que corresponde escribir es el límite conocido de la solución y la condición bajo la cual dejaría de ser válida.

Respecto del marco normativo, la referencia habitual es ISO/IEC 25010. Conviene registrar que la revisión de 2023 modificó el modelo respecto de la versión de 2011 que circula en la mayoría de los apuntes: el modelo pasó a nueve características, la usabilidad fue redefinida como capacidad de interacción, la portabilidad fue redefinida como flexibilidad e incorporó la escalabilidad como subcaracterística, y se agregó la seguridad física como característica propia. Toda cita al modelo debe indicar cuál de las dos versiones utiliza.

### Las tensiones

Ningún atributo se obtiene sin contrapartida, y varios se obtienen a costa de otro. Reconocer estas tensiones es lo que distingue una decisión de arquitectura de una declaración de intenciones.

| Tensión | Manifestación en el dominio |
|---|---|
| Seguridad ↔ usabilidad | Todo control de acceso agrega pasos. Con un único usuario, exigir autenticación constituye costo sin contrapartida |
| Rendimiento ↔ mantenibilidad | Precalcular y almacenar el riesgo mejora el tiempo de respuesta y degrada la consistencia |
| Flexibilidad ↔ simplicidad | Umbrales configurables aportan flexibilidad y agregan código, estructura y casos de prueba |
| Alcance ↔ plazo | Cada atributo que se decide atender consume horas del presupuesto fijo |

El tratamiento adecuado no consiste en resolver las tensiones de manera definitiva, sino en explicitarlas y registrar la posición adoptada. Es lo que ATAM propone a escala de sistemas grandes: recorrer los escenarios de calidad sobre la arquitectura para identificar **puntos de sensibilidad**, donde una decisión afecta significativamente a un atributo; **puntos de compromiso**, donde una decisión afecta a dos atributos en sentidos opuestos; y **riesgos**, decisiones que pueden comprometer el cumplimiento de un escenario.

### Evaluación de la arquitectura

La versión reducida del método, aplicable a un proyecto de esta escala, consiste en tomar el registro de decisión de arquitectura junto con los tres escenarios declarados, y determinar para cada escenario qué decisión lo hace posible y qué decisión lo pone en riesgo. El producto de ese recorrido es una sola afirmación, que constituye el riesgo arquitectónico principal del proyecto: cuál es la decisión que, de resultar equivocada, compromete simultáneamente dos atributos.

En el dominio del proyecto guía esa decisión aparece siempre en el mismo lugar, que es el momento y la ubicación del cálculo de riesgo: almacenarlo mejora el rendimiento y degrada la consistencia; calcularlo en la consulta preserva la consistencia y concentra el costo en el momento de mayor visibilidad.

### Calidad interna y costo de cambio

Existe un par que aparenta ser una tensión sin serlo, y conviene tratarlo explícitamente porque constituye el argumento con que habitualmente se justifica el deterioro del diseño a mitad de proyecto.

Fowler lo formula como hipótesis de resistencia del diseño: inicialmente, prescindir del diseño produce mayor velocidad; a partir de un punto —que ubica en semanas y no en años— las curvas se cruzan y el código sin diseño resulta más lento de modificar que el código con diseño.

>Al pensar en la calidad interna, insisto en que debemos abordarla únicamente desde una perspectiva económica. Una alta calidad interna reduce el costo de futuras funcionalidades, lo que significa que invertir tiempo en escribir buen código realmente reduce los costos.
>
>[Is High Quality Software Worth the Cost? - Martin Fowler](https://martinfowler.com/articles/is-quality-worth-cost.html)

La distinción que sostiene el argumento es la que separa la **calidad interna** —diseño, cohesión, verificabilidad: imperceptible para el usuario y determinante del costo de cambio— de la **calidad externa** —funcionalidad y acabado: perceptible y legítimamente negociable con el cliente—. La primera no constituye materia de negociación porque no es un beneficio para el usuario sino una condición de costo; la segunda es exactamente aquello sobre lo que se negocia al priorizar.

### Aplicación al proyecto guía

Los tres escenarios que el proyecto debe declarar:

```text
  RENDIMIENTO
    La tutora abre el panel de una comisión, en operación normal, con 60 estudiantes
    y 16 semanas registradas → el panel ordenado se presenta en menos de 3 segundos.

  USABILIDAD
    La tutora registra la asistencia de una clase, al finalizarla, con 30 estudiantes
    de los cuales 4 están ausentes → la operación queda confirmada en menos de
    2 minutos y con no más de 6 interacciones además de marcar los ausentes.

  PROTECCIÓN DE DATOS PERSONALES
    Una persona no autorizada accede al equipo donde se ejecuta el sistema
    → no puede obtener apellido, nombre ni legajo de ningún estudiante.
    Declarado como diferido a la etapa de seguridad, no como omitido.
```

Los tres admiten verificación, los tres pueden demostrarse, y ninguno de los tres afirma que el sistema deba ser rápido, usable o seguro.

### Anti-patrones frecuentes

- **Atributos enunciados como adjetivos**: rápido, seguro, escalable, amigable. Sin fuente, estímulo ni medida no constituyen requisitos.
- **Diseñar para una escala inexistente**: consume presupuesto real para resolver un problema hipotético, y es el error de mayor costo en proyectos acotados.
- **Declarar un conjunto extenso de atributos sin verificar ninguno**: el listado produce la apariencia de rigor y ninguno de sus efectos.
- **Justificar la degradación de la calidad interna por la presión de entrega**: confunde calidad interna con acabado externo, y el argumento se invalida en el plazo de semanas.
- **No registrar las tensiones**: la tensión no explicitada se resuelve igualmente, y lo hace siempre en favor de la alternativa más simple de programar.

### Síntesis

Un atributo de calidad sólo existe si está formulado como escenario verificable; de lo contrario es un adjetivo. Su valor no radica en la cantidad de atributos declarados sino en la identificación de las tensiones entre ellos y en el registro de la posición adoptada frente a cada una. La única tensión aparente que no debe negociarse es la que opone calidad interna y velocidad de entrega, porque no existe: la calidad interna es el mecanismo por el cual la velocidad se sostiene en el tiempo.

### Fuentes

- Bass, L., Clements, P. y Kazman, R. (2013). *Software Architecture in Practice* (3ª ed.), Addison-Wesley, cap. 4, "Understanding Quality Attributes"; cap. 13, "Architectural Tactics and Patterns".
- Kazman, R., Klein, M. y Clements, P. (2000). *ATAM: Method for Architecture Evaluation*, CMU/SEI-2000-TR-004, Software Engineering Institute. https://resources.sei.cmu.edu/library/asset-view.cfm?assetid=5177
- Fowler, M. (2019). "Is High Quality Software Worth the Cost?". https://martinfowler.com/articles/is-quality-worth-cost.html
- Fowler, M. — "Design Stamina Hypothesis". https://martinfowler.com/bliki/DesignStaminaHypothesis.html
- Farley, D. (2021). *Modern Software Engineering*, cap. 2, "What Is Engineering?", sección "Trade-Offs".
- ISO/IEC 25010:2023, *Systems and software engineering — SQuaRE — Product quality model*. https://www.iso.org/standard/78176.html · Versión anterior de ocho características: ISO/IEC 25010:2011, https://www.iso.org/standard/35733.html

--------

# Prototipado y diseño de interfaces

### El prototipo como experimento

Un prototipo no constituye una versión preliminar del producto sino un experimento con una pregunta asociada. Si la pregunta no puede enunciarse, lo que se está construyendo es el producto bajo otro nombre, con el agravante de que se lo construye sin haber resuelto las decisiones que el prototipo debía informar.

Las preguntas que un sistema de este tipo requiere responder antes de construir su interfaz son tres, y las tres admiten respuesta sobre papel:

1. En cuántos pasos se registra la asistencia de una clase.
2. Al observar el panel, si el usuario comprende por qué un estudiante aparece en primer lugar.
3. Qué hace el usuario inmediatamente después de observarlo, y si encuentra dónde registrar la acción que tomó.

### Baja fidelidad

El prototipo de baja fidelidad se construye con papel. Rettig publicó en 1994 el argumento de referencia a su favor, y sus fundamentos se mantienen vigentes:

- **Se construye en horas**, lo que permite explorar varias alternativas en lugar de una.
- **Se modifica frente al usuario**, durante la misma sesión de evaluación.
- **No genera apego**: nadie defiende un esquema trazado en minutos, de modo que las observaciones se incorporan en lugar de discutirse.
- **Concentra la atención en el recorrido y no en el acabado.**

El último fundamento es el que determina la elección de fidelidad, y conviene explicitarlo porque orienta toda la actividad. Un prototipo con apariencia terminada recibe observaciones sobre su presentación visual; un esquema trazado a mano recibe observaciones sobre si se comprende. En la instancia de diseño lo que se necesita es lo segundo, y obtenerlo depende de que el artefacto no parezca terminado.

### Alta fidelidad

El prototipo de alta fidelidad —construido con herramientas de diseño, navegable, con tipografía y color definitivos— responde otras preguntas: acuerdo sobre la identidad visual, validación de la densidad real de información de una pantalla compleja, y referencia estable contra la cual construir.

Presenta dos riesgos que conviene anticipar. El primero es que se lo confunda con el producto: un cliente que recorre un prototipo navegable concluye que el sistema está próximo a terminarse, de modo que corresponde explicitar su naturaleza antes de presentarlo. El segundo es que compite por el mismo presupuesto que la construcción.

El criterio de aplicación que se deriva es de economía: baja fidelidad para todas las pantallas, alta fidelidad únicamente para aquella cuya disposición de información constituye en sí misma el producto.

### Evaluación del prototipo

Un prototipo que no se evalúa con una persona ajena al equipo es un dibujo. La evaluación mínima consiste en asignar una tarea —no una instrucción— y observar sin intervenir.

Nielsen estableció que una proporción alta de los problemas de usabilidad se detecta con cinco usuarios, y que resulta más productivo distribuir el esfuerzo en varias evaluaciones reducidas que concentrarlo en una extensa. Tres condiciones determinan si la evaluación produce información:

- **Se asigna una tarea del dominio**, no una instrucción de operación. La diferencia entre pedir que se determine a quién corresponde contactar y pedir que se pruebe el panel es la diferencia entre observar el problema y observar la pantalla.
- **Quien conduce no explica.** Si la pantalla requiere explicación, esa necesidad es el hallazgo.
- **Se registra dónde el usuario duda, no lo que opina.** La duda constituye evidencia; la opinión, en una situación de evaluación, suele constituir cortesía.

### Heurísticas de usabilidad

La evaluación heurística —revisar una interfaz contra un conjunto de principios— complementa la evaluación con usuarios a un costo considerablemente menor. Nielsen y Molich la propusieron en 1990 y el conjunto de diez principios se mantiene como referencia.

Las cinco que un sistema de este tipo incumple con mayor frecuencia:

| Heurística | Forma que asume el incumplimiento |
|---|---|
| **Visibilidad del estado del sistema** | La asistencia se registra y ningún elemento confirma que la operación se completó |
| **Correspondencia con el mundo real** | La pantalla emplea un vocabulario técnico distinto del que utiliza el usuario para el mismo concepto |
| **Control y libertad del usuario** | Un registro erróneo no admite corrección inmediata |
| **Reconocer antes que recordar** | El panel presenta un valor numérico de riesgo cuya escala el usuario debe recordar |
| **Diseño estético y minimalista** | El panel presenta todas las columnas disponibles porque estaban disponibles |

Las dos últimas son las que comprometen específicamente a este producto, y no por casualidad: constituyen la traducción al plano de la interfaz del primer supuesto falso identificado por Ackoff durante el análisis del problema, según el cual al responsable de una decisión no le falta información sino que le sobra. **Una pantalla que presenta la totalidad de los datos le devuelve al usuario el trabajo de filtrar, que es exactamente el trabajo que el sistema fue construido para realizar.**

### Accesibilidad

En el contexto de este proyecto la accesibilidad no constituye un agregado optativo sino una obligación normativa. La Ley 26.653, sancionada en 2010, establece que el Estado nacional en sus tres poderes, los organismos descentralizados, las empresas del Estado y las concesionarias de servicios públicos deben respetar las normas de accesibilidad en el diseño de sus sitios web. La Oficina Nacional de Tecnologías de Información fija el estándar técnico, y mediante la Disposición ONTI 2/2014 ese estándar quedó establecido en las pautas WCAG del W3C.

El conjunto mínimo verificable, aplicable a un sistema de esta naturaleza:

- **Contraste suficiente** entre texto y fondo.
- **El color no es el único portador de información.** Una presentación que distingue niveles de riesgo únicamente por color resulta inutilizable para una porción significativa de la población.
- **Todo control alcanzable mediante teclado.**
- **Etiquetas asociadas a los campos** de los formularios de registro.
- **Textos alternativos** en los elementos gráficos que comunican información.

El segundo criterio es el que este producto incumple sistemáticamente, porque el panel se concibe con codificación cromática, y constituye además el ejemplo más claro de por qué la accesibilidad mejora el diseño para la totalidad de los usuarios: la exigencia de que el nivel de riesgo se comprenda sin recurrir al color obliga a ordenar la lista por prioridad, que es precisamente lo que el cliente solicitó desde el comienzo.

### Consistencia visual e identidad de producto

La guía de estilos mínima no constituye un manual de identidad institucional. Se trata de cinco decisiones registradas en media página, adoptadas una vez para evitar volver a adoptarlas en cada pantalla.

```text
  COLOR         Un color principal, uno de alarma, dos o tres neutros
  TIPOGRAFÍA    Una familia, tres tamaños: título, texto, dato secundario
  ESPACIADO     Una unidad base y sus múltiplos
  COMPONENTES   Definición única de botón, tabla, formulario y mensaje de error
  VOCABULARIO   Los términos del cliente, fijados
```

La última línea es la de mayor rendimiento y menor costo: constituye la aplicación del lenguaje ubicuo al plano de la interfaz. Cuando el sistema denomina a cada concepto del mismo modo que lo denomina el usuario, no hay nada que aprender para operarlo.

### Aplicación al proyecto guía

La pantalla que define este producto es el panel, y su diseño se resuelve en una única decisión: qué información resulta visible sin requerir una acción adicional.

| Debe estar a la vista | Corresponde a un segundo nivel |
|---|---|
| El ordenamiento por prioridad | El detalle completo de cada estudiante |
| Quién ocupa el primer lugar y el dato que lo justifica | El historial de asistencia clase por clase |
| Si ya fue contactado y en qué fecha | La configuración de los umbrales |

La columna izquierda responde la pregunta del cliente sin intervención adicional. Todo elemento que se incorpore a esa columna compite con esa respuesta, y esa competencia es el criterio con el que se evalúa cada agregado.

### Anti-patrones frecuentes

- **Construir la interfaz y luego mostrarla**: el prototipo existe precisamente para invertir esa secuencia, y construido después no informa ninguna decisión.
- **Alta fidelidad de todo el sistema antes de disponer de comportamiento**: consume presupuesto de construcción para producir un artefacto que no se ejecuta.
- **Evaluar el prototipo con integrantes del propio equipo**: conocen el recorrido previsto y por lo tanto no pueden encontrar lo que el recorrido tiene de confuso.
- **Explicar la pantalla durante la evaluación**: invalida la observación y oculta exactamente el problema que se buscaba detectar.
- **Panel con la totalidad de las columnas disponibles**: reproduce el informe que el usuario ya tenía y no resuelve el problema de relevancia.
- **Codificación cromática como único indicador**: incumple la normativa de accesibilidad y además elimina el ordenamiento por prioridad.

### Síntesis

El prototipo es un instrumento de reducción de incertidumbre y no una etapa preliminar de la construcción. Su fidelidad debe ser la mínima que permita responder la pregunta planteada, porque la fidelidad excedente desplaza la atención del recorrido hacia el acabado. En un sistema de apoyo a la decisión, el criterio de diseño de la interfaz coincide con el criterio de diseño del sistema completo: lo que se muestra se justifica por la decisión que habilita, y lo que no habilita ninguna decisión compite con lo que sí lo hace.

### Fuentes

- Rettig, M. (1994). "Prototyping for Tiny Fingers", *Communications of the ACM*, 37(4), pp. 21-27. https://doi.org/10.1145/175276.175288
- Nielsen, J. (1994, act. 2024). "10 Usability Heuristics for User Interface Design", Nielsen Norman Group. https://www.nngroup.com/articles/ten-usability-heuristics/
- Nielsen, J. y Molich, R. (1990). "Heuristic Evaluation of User Interfaces", *CHI '90 Proceedings*, pp. 249-256. https://doi.org/10.1145/97243.97281
- Nielsen, J. (2000). "Why You Only Need to Test with 5 Users". https://www.nngroup.com/articles/why-you-only-need-to-test-with-5-users/
- Snyder, C. (2003). *Paper Prototyping: The Fast and Easy Way to Design and Refine User Interfaces*, Morgan Kaufmann.
- Krug, S. (2014). *Don't Make Me Think, Revisited*, New Riders. Ed. en castellano: *No me hagas pensar*.
- Norman, D. (2013). *The Design of Everyday Things* (ed. revisada), Basic Books, cap. 1. Ed. en castellano: *El diseño de las cosas cotidianas*.
- Ley N° 26.653 de Accesibilidad de la Información en las Páginas Web. https://www.argentina.gob.ar/normativa/nacional/ley-26653-175694
- W3C — *Web Content Accessibility Guidelines (WCAG) 2.2*. https://www.w3.org/TR/WCAG22/

--------

# Definición de tecnologías y herramientas de desarrollo

### La pregunta correcta

No existe el mejor lenguaje ni el mejor framework. Existe la tecnología adecuada para un equipo determinado, un problema determinado y un plazo determinado, y las tres condiciones intervienen con el mismo peso.

Cuando el problema y el plazo están fijados de antemano, la totalidad del peso se desplaza hacia la primera condición. Con un presupuesto acotado de horas y un equipo que no cursó aún los módulos correspondientes, **el tiempo de aprendizaje forma parte del costo de la tecnología**, y es el componente que sistemáticamente queda fuera de la estimación.

### Fichas de innovación

El criterio publicado de mayor utilidad práctica sobre esta decisión es el de Dan McKinley.

>Digamos que cada empresa dispone de alrededor de tres fichas de innovación. Podés gastarlas como quieras, pero el suministro está fijado durante un largo tiempo.
>
>[Choose Boring Technology - Dan McKinley](https://mcfunley.com/choose-boring-technology)

Gastar una ficha significa incorporar algo que el equipo desconoce. La operación se justifica cuando aquello que se incorpora está directamente vinculado con lo que el proyecto tiene de distintivo. En un sistema de apoyo a la decisión lo distintivo es el cálculo y la presentación de la prioridad; no existe fundamento para gastar fichas en el motor de almacenamiento ni en el mecanismo de presentación.

La regla de decisión que se deriva es verificable: si ningún integrante del equipo utilizó previamente una herramienta, debe existir un motivo escrito por el cual esa herramienta resulta necesaria para este problema. El interés por aprenderla constituye un motivo legítimo en un proyecto individual y no lo constituye en uno de equipo, donde el costo de la curva de aprendizaje lo asumen todos los integrantes.

### Criterios de selección

| Criterio | Verificación |
|---|---|
| **Conocimiento previo del equipo** | Cuántos integrantes la utilizaron. Si ninguno, se está gastando una ficha |
| **Documentación y comunidad** | Si es posible resolver un problema concreto en un tiempo acotado |
| **Costo** | Toda herramienta utilizada debe disponer de alternativa sin cargo |
| **Ajuste al problema** | Datos relacionales, usuario único, informes agregados |
| **Facilidad de despliegue** | Una tecnología que el equipo no sabe desplegar constituye una deuda con fecha de vencimiento conocida |
| **Ajuste a la estructura del equipo** | Si varias personas pueden trabajar en paralelo sin interferencia |

El penúltimo criterio es el que con mayor frecuencia se subestima. Un conjunto de herramientas que funciona correctamente en el equipo de quien lo seleccionó y que ningún otro integrante logra poner en funcionamiento convierte a esa persona en la única capaz de avanzar. Es un problema de distribución del trabajo antes que un problema técnico, y reproduce en el plano operativo la observación de Conway.

### El esqueleto ambulante

La validación de la decisión tecnológica no se obtiene prolongando la deliberación, sino construyendo un **esqueleto ambulante**: la implementación mínima que atraviesa todas las capas del sistema de punta a punta y se despliega.

Cockburn lo define en esos términos, y Freeman y Pryce aportan el fundamento que lo vuelve valioso: el esqueleto ambulante obliga a resolver tempranamente el armado, el despliegue y la ejecución de pruebas, que es donde se concentran las sorpresas de un proyecto. Una funcionalidad mínima construida y desplegada al inicio responde en pocas horas lo que una discusión sobre tecnología no responde nunca, porque produce evidencia en lugar de argumentos.

Su valor adicional es de verificación externa: un equipo que dispone del esqueleto ambulante en ejecución al término del primer incremento tiene el riesgo técnico del proyecto bajo control; uno que dispone de varias pantallas sin desplegar no sabe todavía si lo tiene.

### Las herramientas que no son el lenguaje

La decisión tecnológica excede la selección del lenguaje, y la porción que queda fuera del análisis es la que determina las dificultades de las etapas posteriores.

| Elemento | Qué se decide |
|---|---|
| Repositorio | Uno por equipo, con una estrategia de ramas acordada |
| Tablero | El backlog registrado y el estado de cada elemento visible |
| Almacenamiento | El motor, y **de qué manera se versiona el esquema** |
| Ambientes | Al menos uno de desarrollo y uno publicable |
| Formato y estilo | Una convención única, aplicada mediante herramienta |

La fila correspondiente al almacenamiento es la que previene la mayor cantidad de problemas. Un equipo que comienza creando estructuras manualmente en el entorno de cada integrante dispone, a los pocos incrementos, de tantos esquemas distintos como integrantes y de ninguna forma de reproducirlos. Establecer desde el inicio que **los cambios de esquema son archivos versionados junto con el código** tiene un costo marginal al comienzo del proyecto y evita una crisis previa a la primera demostración.

### Aplicación al proyecto guía

Lo que el problema requiere, enunciado sin nombrar productos:

- **Almacenamiento relacional**, con relaciones definidas y volumen reducido.
- **Presentación renderizada del lado del servidor**, dado que no existe requisito de interacción de grano fino y sí conviene la simplicidad.
- **Sin control de acceso en la primera versión**, por tratarse de un sistema de usuario único; la decisión queda declarada como diferida.
- **Capacidad de consulta agregada** para el panel y los informes, dado que el análisis de la información constituye el núcleo del producto.
- **Despliegue simple**, dado que el sistema debe publicarse y el presupuesto no admite administrar infraestructura.

Lo que el problema no requiere conviene enunciarlo con igual precisión: contenedores, descomposición en servicios, framework de interfaz con estado en el cliente, caché y mensajería. Cada uno de esos elementos representa, en este contexto, una ficha de innovación gastada fuera del problema.

### Anti-patrones frecuentes

- **Seleccionar la tecnología antes de definir el alcance y la arquitectura**: las tres decisiones anteriores quedan tomadas por implicación.
- **Seleccionar por prestigio o por presencia en el mercado laboral**: son criterios válidos para la formación profesional y no para un proyecto con presupuesto fijo.
- **Gastar las tres fichas de innovación en el primer incremento**: concentra toda la incertidumbre técnica en el momento de menor experiencia del equipo.
- **Adoptar una herramienta que una sola persona domina**: concentra el riesgo y anula la distribución del trabajo.
- **Diferir el despliegue hasta el final**: lo convierte en una crisis en lugar de una tarea, y lo hace en el momento de menor margen.
- **Un esquema de datos por integrante**: elimina la reproducibilidad y produce defectos que no se manifiestan hasta la integración.

### Síntesis

La selección tecnológica es una decisión de costo antes que una decisión técnica, y el componente principal de ese costo es el aprendizaje. El criterio de las fichas de innovación proporciona una regla verificable: la novedad se concentra donde el proyecto tiene su valor distintivo y se evita en todo lo demás. La decisión no se valida discutiéndola sino construyendo el recorrido completo más pequeño posible y desplegándolo, porque es la única forma de convertir una expectativa en evidencia.

### Fuentes

- McKinley, D. (2015). "Choose Boring Technology". https://mcfunley.com/choose-boring-technology · https://boringtechnology.club/
- Cockburn, A. — "Walking Skeleton". https://alistair.cockburn.us/walking-skeleton/
- Freeman, S. y Pryce, N. (2009). *Growing Object-Oriented Software, Guided by Tests*, Addison-Wesley, cap. 4, "Kick-Starting the Test-Driven Cycle".
- Humble, J. y Farley, D. (2010). *Continuous Delivery*, Addison-Wesley, cap. 2, "Configuration Management", y caps. sobre gestión de datos y versionado del esquema. Ed. en castellano: *Entrega continua*, Anaya Multimedia, 2014.
- Nygard, M. (2011). "Documenting Architecture Decisions". https://cognitect.com/blog/2011/11/15/documenting-architecture-decisions.html

--------

# Los hilos que atraviesan la unidad

##### 1. Toda decisión tiene un costo, y el costo que no se explicita se paga igual

Aparece como comparación de alternativas, como estudio de factibilidad, como tensión entre atributos de calidad y como fichas de innovación. Es la primera ley de la arquitectura de software enunciada en cuatro contextos distintos. El objetivo del diseño no es evitar los compromisos, que son inevitables, sino identificarlos y registrar la posición adoptada frente a cada uno.

##### 2. Se encapsula aquello que se espera que cambie

El criterio de Parnas ordena el modelo de datos —lo que varía en el tiempo requiere representación de su historia—, la descomposición en componentes, la dirección de las dependencias de la arquitectura y el diferimiento de decisiones tecnológicas. En un dominio determinado ese punto de variación es siempre identificable, y el relevamiento ya proveyó la información necesaria para encontrarlo.

##### 3. Lo que no se puede verificar no está diseñado

El contrato de operación, el escenario de atributo de calidad en seis partes y la evaluación del prototipo con un usuario ajeno al equipo son el mismo principio formulado en tres lenguajes: el del diseño, el de la arquitectura y el de la interfaz. Es la continuación directa del criterio establecido en la unidad anterior respecto de los requerimientos y los criterios de aceptación.

##### 4. El diseño se justifica contra el problema

Cada decisión estructural admite ser enunciada nombrando la decisión del usuario que habilita. Una pieza de arquitectura que no puede enunciarse de ese modo no está mal construida: está construida sin fundamento, que es una condición distinta y más difícil de corregir.
