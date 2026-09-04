# Unidad 1 — Identificación y análisis de la problemática

Dominio de referencia: **sistema de seguimiento de cursada y alerta temprana de desgranamiento**. Usuario: el tutor. Decisión que apoya: *¿a qué estudiantes contacto esta semana?*

Las fuentes completas están en [CONTENIDOS.md](CONTENIDOS.md).

> **Sobre las citas.** Cada referencia indica capítulo y sección, porque la paginación cambia entre ediciones y entre las versiones en inglés y en castellano. Se indican páginas cuando la fuente es un artículo o cuando se pudo verificar la edición. Los enlaces fueron verificados el 03-09-2026.

---

## Objetivos de la unidad

Al terminar, cada equipo debe poder:

1. Trazar el límite de su sistema y justificar qué quedó afuera.
2. Distinguir un sistema transaccional, uno de gestión y uno de apoyo a la decisión, y señalar qué parte de su producto es cada cosa.
3. Enunciar el problema que resuelve sin nombrar la solución.
4. Identificar actores, usuarios, partes interesadas y sujetos de datos.
5. Relevar necesidades de información con una técnica elegida y fundamentada.
6. Convertir el relevamiento en requerimientos analizados, priorizados y verificables.
7. Distinguir requerimientos funcionales de no funcionales y escribir ambos de forma comprobable.
8. Escribir épicas, historias de usuario y criterios de aceptación, y dividir lo que no entra en un sprint.
9. Declarar alcance, supuestos y restricciones por escrito.

---

# Tema 1 — Sistemas: elementos, límites, entorno y limitaciones

## 1.1 Qué es un sistema

Un sistema es un conjunto de **elementos interrelacionados** que funcionan juntos con un **propósito**. Las tres condiciones son necesarias: hay partes identificables, las partes se relacionan entre sí de modo que lo que le pasa a una afecta a otra, y el conjunto persigue un fin que ninguna parte alcanza sola.

De ahí sale la propiedad que más importa para diseñar software: un sistema no es la suma de sus partes, es el producto de sus interacciones. Ackoff lo ilustra con el ejemplo del automóvil desarmado —todas las piezas en el piso, ninguna de las propiedades del auto, ninguna pieza transporta a nadie— en su exposición sobre pensamiento sistémico, y lo formaliza en "Towards a System of Systems Concepts", *Management Science*, 17(11), julio 1971, pp. 661-671, donde define sistema, elemento, entorno y estado.

> **Fuente.** Ackoff, R. — "If Russ Ackoff had given a TED Talk…", 12 min, https://www.youtube.com/watch?v=OqEeIG8aPPk · Ackoff, R. (1971). "Towards a System of Systems Concepts", *Management Science*, 17(11), pp. 661-671, https://doi.org/10.1287/mnsc.17.11.661

La consecuencia práctica es directa: se puede construir cada módulo correctamente y no tener sistema. Un registro de asistencia impecable, un cálculo de indicadores impecable y un panel impecable no producen alerta temprana si no están conectados por un flujo que termine en una decisión.

## 1.2 El límite

El límite es lo que separa el sistema del resto del mundo, y todo lo que está afuera y lo afecta es su **entorno**.

Lo importante, y lo que cuesta aceptar, es que el límite no viene con el problema: se decide. Weinberg dedica los dos primeros capítulos de *An Introduction to General Systems Thinking* —cap. 1, "The Problem", y cap. 2, "The Approach"— a mostrar que un sistema es un punto de vista sobre la realidad y no una porción de la realidad, y en el cap. 4 formula la Ley Ojo-Cerebro, según la cual la capacidad de observación y la capacidad de razonamiento se compensan mutuamente. Dos equipos frente al mismo enunciado pueden trazar límites distintos y estar los dos bien, siempre que puedan sostener el criterio.

> **Fuente.** Weinberg, G. (1975). *An Introduction to General Systems Thinking*, Dorset House (ed. Silver Anniversary, 2001), caps. 1-2 y cap. 4.

El criterio operativo para trazarlo:

| Pregunta | Si la respuesta es sí… |
|---|---|
| ¿Lo construimos y lo podemos cambiar? | Está **adentro** del sistema. |
| ¿Nos afecta pero no lo controlamos? | Es **entorno**. |
| ¿Ni nos afecta ni lo afectamos? | Está **fuera de consideración**. |

Lo que cruza el límite son **entradas** —lo que el sistema recibe— y **salidas** —lo que entrega—. Identificarlas es la forma más rápida de verificar que el límite está bien trazado: si hay una entrada que nadie provee o una salida que nadie consume, el recorte está mal.

## 1.3 Limitaciones

Una **limitación** es una condición del entorno que el sistema no puede modificar y a la que tiene que adaptarse. No se negocia: se planifica alrededor. Conviene separarla desde el principio de la **decisión de alcance**, que es algo que el equipo eligió y por lo tanto puede revisar. Confundirlas tiene un costo concreto: se termina tratando como fatalidad algo que era una decisión, o discutiendo eternamente algo que ya estaba fijado. Este par vuelve en el tema 9.

## 1.4 En el dominio

| | |
|---|---|
| **Adentro** | Registro de asistencia y entregas · cálculo de indicadores de riesgo · panel de seguimiento · alertas y umbrales · registro de intervenciones |
| **Entorno** | El sistema de gestión académica del instituto · el correo · el calendario académico · el estudiante · el tutor |
| **Entradas** | Nómina de estudiantes y comisiones · asistencia de cada clase · entregas registradas · umbrales configurados por el tutor |
| **Salidas** | Listado priorizado de estudiantes a contactar · alertas · historial de intervenciones |
| **Limitaciones** | El instituto no expone su base de datos · el tutor trabaja con lo que anota manualmente · el cuatrimestre dura 16 semanas |

El estudiante está en el entorno: sus actos generan los datos que entran, pero no opera el sistema. El tutor también está en el entorno, porque es quien lo usa. Ninguna persona está *dentro* del límite; adentro está el software.

La caja del diagrama de casos de uso es literalmente el límite del sistema, y los actores dibujados afuera son, por definición, el entorno. Es notación que los estudiantes ya conocen de Modelado y Diseño de Software.

> **Fuente.** Larman, C. *UML y patrones* / *Applying UML and Patterns* (3ª ed.), cap. 6, "Use Cases", sección sobre diagramas de casos de uso y límite del sistema.

## 1.5 Errores frecuentes

- Tomar el límite como dado por el enunciado, en vez de decidirlo y justificarlo.
- Poner adentro a las personas. Adentro va el software; las personas son actores.
- Confundir limitación con decisión de alcance.
- Un límite tan amplio que el sistema incluye media institución.

## 1.6 Ejercicio

Cada equipo dibuja la caja de su sistema y completa la tabla de adentro, entorno, entradas, salidas y limitaciones. Después se contrastan dos equipos que hayan trazado límites distintos y cada uno defiende el suyo. No se busca la respuesta correcta, se busca que el criterio esté explícito.

## 1.7 Lecturas

- Weinberg, G. (1975). *An Introduction to General Systems Thinking*, caps. 1-2 y 4.
- Ackoff, R. (1971). "Towards a System of Systems Concepts", *Management Science*, 17(11), pp. 661-671. https://doi.org/10.1287/mnsc.17.11.661
- Brooks, F. (1987). "No Silver Bullet: Essence and Accidents of Software Engineering", *IEEE Computer*, 20(4), pp. 10-19, sección "Essential Difficulties". https://worrydream.com/refs/Brooks_1986_-_No_Silver_Bullet.pdf
- Ackoff, R. — "If Russ Ackoff had given a TED Talk…" (12 min). https://www.youtube.com/watch?v=OqEeIG8aPPk

---

# Tema 2 — Sistemas de información en la organización

Es el tema que da nombre a la materia y el que más peso tiene en la unidad.

## 2.1 Dato, información y conocimiento

Un **dato** es el registro de un hecho, sin interpretación: *"Pérez faltó el 12/09"*. La **información** son datos procesados y puestos en contexto de modo que respondan una pregunta: *"Pérez acumula 4 inasistencias en 6 clases"*. El **conocimiento** es la capacidad de actuar a partir de eso: *"Pérez está en riesgo de abandono y hay que contactarlo"*.

Ackoff ordena esta cadena en "From Data to Wisdom" y agrega algo que conviene retener: los sistemas de información suelen ser muy buenos produciendo datos y bastante malos produciendo información, porque producir información exige saber cuál es la pregunta. Un sistema que muestra todo no informa: le traslada al usuario el trabajo de filtrar.

> **Fuente.** Ackoff, R. (1989). "From Data to Wisdom", *Journal of Applied Systems Analysis*, 16, pp. 3-9.

## 2.2 Los niveles de la organización

Las necesidades de información cambian según quién decide y sobre qué horizonte. Gorry y Scott Morton toman los tres niveles de control de la organización propuestos por Anthony y muestran que cada uno necesita información con características distintas.

| | **Operativo** | **Táctico (control de gestión)** | **Estratégico (planeamiento)** |
|---|---|---|---|
| Horizonte | Hoy, esta semana | El mes, el cuatrimestre | Años |
| Agregación | Dato individual | Consolidado por grupo | Muy agregado |
| Origen | Interno | Interno | Interno y externo |
| Frecuencia | Alta, continua | Periódica | Baja, puntual |
| Precisión | Exacta | Alta | Estimada alcanza |
| En el dominio | El tutor: a quién llamo | La coordinación: cómo viene esta comisión | El rectorado: qué carreras retienen |

> **Fuente.** Gorry, G. A. y Scott Morton, M. S. (1971). "A Framework for Management Information Systems", *Sloan Management Review*, 13(1), otoño 1971, pp. 55-70. Copia del working paper MIT 510-71 en https://hdl.handle.net/1721.1/47936

## 2.3 Decisiones estructuradas y no estructuradas

El segundo eje del marco de Gorry y Scott Morton es el grado de estructura de la decisión, que toman del trabajo de Simon sobre decisiones programadas y no programadas.

Una decisión **estructurada** tiene un procedimiento conocido y repetible, y se puede automatizar por completo: calcular el porcentaje de asistencia. Una **semiestructurada** tiene una parte conocida y otra que requiere criterio: determinar qué combinación de señales indica riesgo. Una **no estructurada** no tiene procedimiento y se apoya en juicio y experiencia: decidir cómo abordar a un estudiante determinado.

El mismo marco recoge las tres fases de toda decisión —inteligencia, diseño y elección—, y un sistema puede apoyar cualquiera de las tres, que no es lo mismo. La mayor parte del valor de un sistema de alerta temprana está en la primera: avisar que hay una decisión pendiente que el usuario todavía no sabe que tiene.

> **Fuente.** Gorry y Scott Morton (1971), op. cit., pp. 55-70, sección donde cruzan el marco de Anthony (1965) con la distinción programada / no programada de Simon (1960).

## 2.4 Los tres tipos de sistema

Del cruce de los dos ejes salen los tres tipos que pide el programa. No se distinguen por la tecnología sino por la pregunta que responden.

**Transaccional (TPS).** Registra los hechos del día a día. Alta frecuencia, dato detallado, precisión total, decisión estructurada o ninguna. Su trabajo es capturar, validar y persistir sin perder nada. Es la base de todo lo demás: sin transaccional confiable, los otros dos mienten con más elegancia. En el dominio: tomar asistencia, registrar una entrega, dar de alta un estudiante.

**De gestión (SIG / MIS).** Consolida lo que el transaccional registró y lo compara contra lo esperado. Periódico, agregado, orientado al control; responde *cómo venimos*. Su forma típica es el reporte y su forma más útil es el reporte de excepción, que muestra sólo lo que se sale de lo previsto. En el dominio: inasistencias acumuladas por comisión, porcentaje de entregas del mes, comparación entre comisiones.

**De apoyo a la decisión (DSS).** Sirve a una decisión semiestructurada o no estructurada. Es ad hoc, exploratorio, y admite que el usuario cambie parámetros y vea qué pasa. No decide: reduce la incertidumbre de quien decide. En el dominio: el panel de riesgo con umbrales configurables, la simulación de qué pasa si se baja el umbral de inasistencias, el listado priorizado de a quién contactar.

> **Fuente.** Laudon, K. y Laudon, J. *Sistemas de información gerencial*, Pearson, caps. 1-2 (organizaciones y sistemas de información) y cap. sobre inteligencia de negocios y toma de decisiones.

## 2.5 Los cinco supuestos falsos de Ackoff

Ackoff escribió en 1967 el mejor argumento que existe contra el sistema que muestra todo. Identifica cinco supuestos que los diseñadores de sistemas de información dan por buenos y que casi nunca lo son:

1. Que al que decide le falta información. Casi siempre le sobra: lo que le falta es información *relevante*. El problema no es de cantidad, es de filtrado.
2. Que hay que darle la información que pide. Si no sabe bien cómo decide, no sabe qué necesita, y pedirá todo por las dudas.
3. Que si tiene la información que necesita, decidirá mejor. Sólo si entiende cómo usarla.
4. Que más comunicación entre áreas mejora el desempeño. No necesariamente.
5. Que no hace falta que entienda cómo funciona el sistema, sólo cómo usarlo. Sin entenderlo, no puede evaluar si le está mintiendo.

De los cinco, el primero es el que ordena esta materia entera. Si al usuario le sobra información, el sistema que agrega una pantalla más con todos los datos empeora el problema; el sistema útil filtra, prioriza y avisa. Es la diferencia entre un tablero y un reporte lindo: el reporte muestra lo que pasó, el tablero está organizado alrededor de una decisión pendiente y ordena lo que muestra por urgencia de esa decisión.

> **Fuente.** Ackoff, R. (1967). "Management Misinformation Systems", *Management Science*, 14(4), diciembre 1967, pp. B147-B156. Los cinco supuestos se enumeran al comienzo del artículo, pp. B147-B148. https://doi.org/10.1287/mnsc.14.4.B147

## 2.6 En el dominio

| Tipo | Funcionalidad | Pregunta que responde | Nivel / estructura |
|---|---|---|---|
| Transaccional | Registrar asistencia de la clase de hoy | ¿Qué pasó? | Operativo, estructurada |
| Transaccional | Registrar una entrega | ¿Qué pasó? | Operativo, estructurada |
| De gestión | Inasistencias acumuladas por comisión | ¿Cómo venimos contra lo esperado? | Táctico, estructurada |
| De gestión | Reporte de estudiantes con menos del 60% de entregas | ¿Qué se sale de lo previsto? | Táctico, semiestructurada |
| Apoyo a la decisión | Panel de riesgo ordenado por prioridad | ¿A quién llamo esta semana? | Táctico, semiestructurada |
| Apoyo a la decisión | Umbrales configurables y simulación | ¿Qué pasa si cambio el criterio de riesgo? | Táctico, no estructurada |
| Apoyo a la decisión | Historial de intervenciones y su resultado | ¿Qué funcionó las otras veces? | Táctico, no estructurada |

Acá se enuncia el criterio de evaluación de la materia, que después se aplica todo el cuatrimestre: cada equipo debe poder explicar qué decisión habilita cada pantalla que construye. Una pantalla que no habilita ninguna decisión no está terminada, está de más.

## 2.7 Errores frecuentes

- Construir sólo la capa transaccional y llamarla sistema de gestión. Es el desvío más común y termina en un CRUD.
- Confundir tablero con reporte: poner todos los indicadores juntos sin ordenarlos por la decisión.
- Suponer que agregar un filtro más resuelve un problema de relevancia.
- Creer que el sistema debe decidir. En decisiones no estructuradas decide la persona.

## 2.8 Ejercicio

Se entrega a cada equipo una lista de ocho funcionalidades candidatas del dominio, mezcladas. Para cada una hay que clasificarla en transaccional, de gestión o de apoyo a la decisión; escribir en una línea qué decisión habilita y de quién; y marcar las que no habilitan ninguna. En la puesta en común, las que nadie pudo justificar salen del backlog o bajan de prioridad. Es la primera aplicación del criterio de la materia.

## 2.9 Lecturas

- Gorry, G. A. y Scott Morton, M. S. (1971). "A Framework for Management Information Systems", *Sloan Management Review*, 13(1), pp. 55-70. https://hdl.handle.net/1721.1/47936
- Ackoff, R. (1967). "Management Misinformation Systems", *Management Science*, 14(4), pp. B147-B156. **Lectura obligatoria.** https://doi.org/10.1287/mnsc.14.4.B147
- Ackoff, R. (1989). "From Data to Wisdom", *Journal of Applied Systems Analysis*, 16, pp. 3-9.
- Laudon, K. y Laudon, J. *Sistemas de información gerencial*, Pearson, caps. 1-2.

---

# Tema 3 — Contextualización del problema

## 3.1 Qué es un problema

Un problema es la brecha entre una situación actual y una situación deseada, que le importa a alguien. Si falta alguno de los tres términos no hay problema que resolver: sin situación actual descrita con evidencia se está diseñando para una suposición, sin situación deseada no hay criterio para saber si la solución sirvió, y sin alguien a quien le importe no hay quién adopte el sistema.

## 3.2 Problema, síntoma y solución disfrazada

El **síntoma** es una manifestación observable: *"el tutor llega tarde a detectar abandonos"*. El **problema** es la brecha que lo produce: *"la información de asistencia y entregas está dispersa y sin consolidar, así que la señal de riesgo aparece cuando ya es tarde"*. La **solución disfrazada de problema** es un enunciado que ya decidió qué construir: *"no tenemos un sistema de seguimiento"*.

El test rápido: si el enunciado nombra una tecnología, una pantalla o un sistema, es una solución escrita al revés. Un enunciado de problema no debería contener la palabra "sistema".

## 3.3 Las preguntas de Gause y Weinberg

Hay tres preguntas que conviene poder contestar antes de escribir una línea de código.

**¿De quién es el problema?** No siempre es de quien lo trae. Quien pide el sistema y quien sufre el problema pueden ser personas distintas, y la solución se diseña para el segundo.

**¿Qué pasa si no hacemos nada?** Si la respuesta es "nada grave", o el problema está mal elegido o está mal enunciado. Esta pregunta también da la medida del valor, porque el costo de no resolverlo es el techo de lo que vale resolverlo.

**¿Estamos resolviendo el problema o el que nos resulta cómodo resolver?** Es la más incómoda, y la que más se elude: los equipos tienden a redefinir el problema hacia lo que ya saben hacer.

> **Fuente.** Gause, D. y Weinberg, G. (1982). *Are Your Lights On? How to Figure Out What the Problem Really Is*, Dorset House. Libro completo, ~90 pp.; las preguntas están en las partes I y II. · Gause, D. y Weinberg, G. (1989). *Exploring Requirements: Quality Before Design*, Dorset House, parte I, sobre definición del problema y ambigüedad.

## 3.4 La estructura del enunciado

La plantilla del documento de Visión del Proceso Unificado ordena las cinco piezas:

> El problema de **[describir el problema]**, afecta a **[los interesados afectados]**, cuyo impacto es **[cuál es la consecuencia]**, y una solución exitosa permitiría **[cuál sería el beneficio]**.

Y en paralelo, la situación actual: cómo se resuelve hoy. Siempre hay un cómo —una planilla, un cuaderno, la memoria de alguien— y describirlo es obligatorio, porque es la línea de base contra la que se compara y suele ser la mejor fuente de requisitos.

> **Fuente.** Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 7, "Other Requirements", §7.6 "NextGen Example: (Partial) Vision" y §7.7 "Commentary: Vision". En la edición en castellano, cap. de requisitos adicionales.

## 3.5 En el dominio

Enunciado de referencia:

> El problema de **que la información de asistencia y entregas esté dispersa, sin consolidar y sin criterio de alerta**, afecta a **los tutores de comisión, que siguen varias comisiones a la vez**, cuyo impacto es que **el desenganche de un estudiante se detecta cuando ya dejó de cursar, cuando la intervención todavía era posible semanas antes**, y una solución exitosa permitiría **que el tutor sepa cada semana a qué estudiantes contactar, antes de que abandonen**.

Situación actual: el tutor anota la asistencia en papel y la vuelca a una planilla de cálculo cuando puede; las entregas están en el aula virtual; nadie cruza las dos fuentes. La señal de que alguien está por abandonar es que dejó de aparecer, y para entonces ya abandonó.

Tres enunciados defectuosos, con su diagnóstico:

| Enunciado | Qué está mal |
|---|---|
| "No existe un sistema que permita registrar la asistencia de los estudiantes." | Es una solución, no un problema. Nombra el sistema y la funcionalidad. |
| "Los estudiantes abandonan la carrera." | Es un síntoma, y de un problema mucho más grande que el que el equipo puede resolver. No dice quién decide ni qué información falta. |
| "El instituto necesita mejorar sus indicadores de retención." | Interesado equivocado y decisión ausente. El sistema es para el tutor, no para el rectorado, y "mejorar indicadores" no es una decisión que alguien tome un martes. |

## 3.6 Ejercicio

Cada equipo escribe su enunciado con la plantilla de cinco piezas, más el párrafo de situación actual. Se intercambian entre equipos y cada uno le aplica al del otro las tres preguntas de Gause y Weinberg y el test de la palabra "sistema". Este enunciado es la primera entrega evaluable de la cursada.

## 3.7 Lecturas

- Gause, D. y Weinberg, G. (1982). *Are Your Lights On?*, Dorset House. Libro completo.
- Gause, D. y Weinberg, G. (1989). *Exploring Requirements*, Dorset House, parte I.
- Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 7, §7.6-7.7 (documento de Visión).
- Christensen, C. y otros (2016). "Know Your Customers' Jobs to Be Done", *Harvard Business Review*, sept.-oct. 2016. https://hbr.org/2016/09/know-your-customers-jobs-to-be-done
- Fowler, M. — "Observed Requirement". https://martinfowler.com/bliki/ObservedRequirement.html
- Fowler, M. — "Feature Devotion". https://martinfowler.com/bliki/FeatureDevotion.html

---

# Tema 4 — Identificación de actores, usuarios y partes interesadas

## 4.1 Actor

Un **actor** es un rol externo al sistema que interactúa con él. La definición viene de Jacobson y tiene una palabra decisiva: rol, no persona ni puesto.

Por qué importa: una misma persona puede cumplir varios roles —el tutor que además coordina— y un mismo rol lo pueden cumplir muchas personas —los quince tutores del instituto—. Si se modelan personas o puestos, el modelo se rompe con la primera reorganización; si se modelan roles, sobrevive.

Cockburn distingue el **actor primario**, que tiene un objetivo y usa el sistema para alcanzarlo e inicia la interacción, del **actor secundario o de soporte**, al que el sistema necesita para completar su trabajo. En el dominio, el tutor es primario; el servicio de correo y el sistema de gestión académica son secundarios.

> **Fuente.** Jacobson, I., Booch, G. y Rumbaugh, J. (1999). *The Unified Software Development Process*, Addison-Wesley, caps. de captura de requisitos ("Requirements Capture: From Vision to Requirements" y "Requirements Capture: Use-Case Model"). Ed. en castellano: *El Proceso Unificado de Desarrollo de Software*, Addison-Wesley, 2000. · Cockburn, A. (2000). *Writing Effective Use Cases*, Addison-Wesley, cap. 4, "Stakeholders and Actors", secciones "The Primary Actor", "Actors versus Roles" y "Supporting Actors". Borrador público del libro: https://kurzy.kpi.fei.tuke.sk/zsi/resources/CockburnBookDraft.pdf

## 4.2 Partes interesadas

Cockburn organiza el relevamiento alrededor de interesados e intereses: un interesado es cualquiera que tenga algo en juego en el comportamiento del sistema, lo use o no.

Todo usuario es interesado, pero no todo interesado es usuario. La distinción tiene efecto directo sobre el alcance: los intereses de quien no usa el sistema se satisfacen con salidas —un informe, una exportación—, no con pantallas. Confundirlos es la vía más rápida a construir tres aplicaciones en vez de una.

> **Fuente.** Cockburn, A. (2000). *Writing Effective Use Cases*, cap. 4, "Stakeholders and Actors", sección "Stakeholders".

## 4.3 Sujeto de datos

Hay una tercera figura que no es ni usuario ni interesado en sentido clásico: aquel cuyos datos el sistema procesa sin que él lo use. La Ley 25.326 lo llama *titular de los datos* y le reconoce derechos —acceso, rectificación y supresión— con independencia de que toque el sistema o no.

En este dominio es central, porque el estudiante es titular de datos sobre su desempeño académico: no es usuario, no decide nada, y sin embargo el sistema tiene obligaciones con él. De ahí salen requerimientos concretos —control de acceso, finalidad del tratamiento, plazo de conservación— que se retoman en el tema 7 y en la Unidad 4.

> **Fuente.** Ley N° 25.326 de Protección de los Datos Personales, art. 2 (definición de titular de los datos), art. 4 (calidad de los datos y finalidad), art. 5 (consentimiento) y arts. 14-16 (derechos de acceso, rectificación y supresión). Texto actualizado: https://www.argentina.gob.ar/normativa/nacional/ley-25326-64790/actualizacion

## 4.4 Niveles de objetivo

Cockburn propone tres alturas para describir lo que un actor quiere, con la metáfora del mar:

| Nivel | Metáfora | Ejemplo en el dominio |
|---|---|---|
| Resumen | Nube / barrilete (blanco) | Reducir el desgranamiento de la comisión |
| **Usuario** | **Mar (azul)** | **Identificar a los estudiantes en riesgo de esta semana** |
| Subfunción | Pez | Registrar la asistencia de una clase |

El nivel útil para relevar es el del mar: un objetivo que una persona completa de una sentada y que, al terminar, la deja satisfecha. El nivel nube es demasiado vago para construir y el nivel pez es un paso, no un objetivo. Los equipos tienden a irse al nivel pez porque es el que se parece a una pantalla.

> **Fuente.** Cockburn, A. (2000). *Writing Effective Use Cases*, cap. 5, "Three Named Goal Levels", secciones "User Goals (Blue, Sea-Level)", "Summary Level (White, Cloud/Kite)", "Finding the Right Goal Level" y "Raising and Lowering Goal Levels".

## 4.5 Cómo se identifican

Cinco preguntas agotan la lista: quién va a operar el sistema; quién recibe algo que el sistema produce sin operarlo; quién provee datos que el sistema necesita; con qué otros sistemas se conecta; y los datos de quién se procesan.

## 4.6 En el dominio

| Quién | Qué es | Interés | Cómo se satisface |
|---|---|---|---|
| Tutor de comisión | Actor primario, único usuario | Saber a quién contactar esta semana | Usando el sistema |
| Coordinación de carrera | Parte interesada | Ver cómo evoluciona la retención | Un informe exportable |
| Rectorado | Parte interesada | Indicadores institucionales | Fuera de alcance en esta versión |
| Estudiante | Sujeto de datos | Que sus datos se traten con una finalidad legítima | Control de acceso y finalidad declarada |
| Sistema de gestión académica | Actor secundario | — | Importación de la nómina, si se decide |
| Servicio de correo | Actor secundario | — | Envío de alertas, si se decide |

La acotación que define el proyecto es que hay un solo usuario, el tutor. Sin esa restricción los equipos derivan a construir un campus virtual, porque en cuanto el estudiante entra como actor primario aparecen login, perfil, notificaciones y mensajería, y el alcance se multiplica.

## 4.7 Errores frecuentes

- Listar puestos del organigrama en lugar de roles.
- Agregar actores "por si acaso": cada actor agregado multiplica los casos de uso.
- Confundir parte interesada con usuario y darle pantalla propia.
- Describir objetivos a nivel de subfunción y quedarse sin ver el objetivo real.

## 4.8 Ejercicio

Se entrega una lista mezclada de doce candidatos del dominio. Cada equipo los clasifica en actor primario, actor secundario, parte interesada, sujeto de datos o fuera de consideración, y después escribe el objetivo a nivel usuario del actor primario.

## 4.9 Lecturas

- Cockburn, A. (2000). *Writing Effective Use Cases*, caps. 4 y 5. https://kurzy.kpi.fei.tuke.sk/zsi/resources/CockburnBookDraft.pdf
- Jacobson, I., Booch, G. y Rumbaugh, J. (1999). *El Proceso Unificado de Desarrollo de Software*, caps. de captura de requisitos.
- Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 6, "Use Cases", secciones sobre actores y sus tipos.
- Ley N° 25.326, arts. 2, 4, 5 y 14-16. https://www.argentina.gob.ar/normativa/nacional/ley-25326-64790/actualizacion
- Fowler, M. — "Use Cases And Stories". https://martinfowler.com/bliki/UseCasesAndStories.html

---

# Tema 5 — Relevamiento de necesidades de información

## 5.1 El problema de fondo

La gente no sabe decir qué información necesita, pero sabe contar qué hizo. Es la consecuencia directa del segundo supuesto de Ackoff: si alguien no tiene claro cómo decide, no puede especificar qué necesita para decidir, y por las dudas va a pedir todo.

De ahí la regla que ordena todo el relevamiento: preguntar por hechos del pasado, no por deseos del futuro. "¿Cómo hiciste la última vez?" produce información verificable; "¿te gustaría tener…?" produce cortesía.

## 5.2 Entrevista

Es la técnica principal y la que más se hace mal.

**Preparación.** Antes de entrar hacen falta tres cosas escritas: el objetivo de la entrevista, a quién se entrevista y por qué, y las preguntas. Una entrevista sin preparación se convierte en una charla agradable de la que no sale ningún requisito.

**Estructura.** Kendall y Kendall describen tres formas de ordenar las preguntas. La **pirámide** empieza cerrada y específica y se abre, y sirve cuando el entrevistado está frío o desconfiado. El **embudo** empieza abierta y se cierra, y es la más útil para relevar: primero "contame cómo hacés el seguimiento", después el detalle. El **rombo** combina las dos, para entrevistas largas.

**Tipos de pregunta.** La abierta —"¿cómo te das cuenta de que un estudiante está por abandonar?"—, la cerrada —"¿cuántas comisiones tenés a cargo?"— y el sondeo —"¿por qué?", "¿me das un ejemplo?", "¿cuándo fue la última vez?"—. El sondeo es donde aparece la información que importa.

> **Fuente.** Kendall, K. y Kendall, J. *Análisis y diseño de sistemas* (8ª ed.), Pearson, cap. 4, "Métodos interactivos para obtener información": preparación de la entrevista, tipos de pregunta, y estructuras de pirámide, embudo y rombo.

**Las reglas de Fitzpatrick.** *The Mom Test* se llama así porque hasta tu madre te va a mentir si le preguntás si tu idea es buena. Tres reglas: hablar de la vida del otro y no de tu idea; preguntar por hechos específicos del pasado y no por opiniones sobre el futuro; escuchar más de lo que se habla.

| Pregunta mala | Por qué | Reemplazo |
|---|---|---|
| "¿Te gustaría un sistema que te avise de los estudiantes en riesgo?" | Pide una opinión sobre una idea. Todos dicen que sí. | "Contame la última vez que te enteraste tarde de que alguien abandonó. ¿Cómo te enteraste?" |
| "¿Usarías un panel con indicadores?" | Compromiso hipotético, sin costo. | "¿Qué hacés hoy para saber cómo viene la comisión? ¿Cuánto tiempo te lleva?" |
| "¿Qué funcionalidades te gustaría que tenga?" | Le pide al usuario que haga el diseño. | "¿Qué fue lo último que quisiste saber y no pudiste averiguar?" |

> **Fuente.** Fitzpatrick, R. (2013). *The Mom Test*, caps. 1-2 (las tres reglas y las preguntas malas) y cap. 3 (preguntas buenas). Ed. en castellano: *El Mom Test*, trad. Verónica Torras, ISBN 9781671455351. https://www.momtestbook.com/

**Registro y devolución.** Se toma nota durante y se escribe un resumen después. La devolución escrita al entrevistado, para que confirme o corrija, es parte de la técnica y no una cortesía: es donde se detectan los malentendidos, cuando todavía son baratos.

## 5.3 Observación

Sirve para ver lo que la persona hace, que casi nunca coincide con lo que dice que hace, no por mentir sino porque las rutinas se automatizan y dejan de ser conscientes.

Kendall y Kendall la ubican entre los métodos discretos e incluyen la observación del entorno físico —dónde está sentada la persona, qué tiene a mano, qué anotó en un papel pegado al monitor—, que ellos sistematizan bajo el nombre de STROBE. Ese papel pegado al monitor suele ser un requisito.

Lo que hay que mirar: qué herramienta usa realmente, qué pasos hace que no figuran en ningún procedimiento, dónde duda, dónde vuelve atrás y qué hace dos veces.

> **Fuente.** Kendall, K. y Kendall, J. *Análisis y diseño de sistemas* (8ª ed.), cap. 5, "Métodos discretos para obtener información": observación del comportamiento del tomador de decisiones y observación del entorno físico (STROBE).

## 5.4 Análisis documental

Es la técnica más barata y la más subestimada, porque los documentos que ya existen contienen los datos que importan, ya filtrados por años de uso. Kendall y Kendall distinguen documentos cuantitativos —informes, formularios, registros, planillas— de cualitativos —memos, manuales, carteles, correos—.

Un formulario o una planilla en uso revela, sin entrevistar a nadie: qué datos se consideran importantes (las columnas que existen), qué datos se consideran innecesarios (las columnas que quedaron vacías), quién los completa y cuándo, qué cálculos se hacen a mano, y qué se anota en el margen, que es lo que el formulario no previó.

En el dominio se traduce en pedirle al tutor la planilla de cálculo con la que sigue la cursada hoy. En cinco minutos da más requisitos que media hora de entrevista.

> **Fuente.** Kendall, K. y Kendall, J. *Análisis y diseño de sistemas* (8ª ed.), cap. 5, sección sobre investigación de datos duros: documentos cuantitativos y cualitativos.

## 5.5 Cuestionario

Sirve cuando hay muchos destinatarios dispersos y ya se sabe qué preguntar. Es una herramienta para cuantificar lo que se descubrió por otras vías, no para descubrir.

Los cuidados son tres: preguntas que no admitan dos lecturas, escalas consistentes, y aceptar que la tasa de respuesta va a ser baja. Un cuestionario mal diseñado produce datos con apariencia de rigor, que es peor que no tener datos.

En este dominio es poco aplicable, porque hay un solo usuario. Vale decirlo explícitamente en clase: elegir la técnica es parte del relevamiento, y descartar una con fundamento es una decisión válida.

> **Fuente.** Kendall, K. y Kendall, J. *Análisis y diseño de sistemas* (8ª ed.), cap. 4, sección sobre planeación y diseño de cuestionarios, tipos de escala y administración.

## 5.6 El vocabulario del cliente

Todo lo que el entrevistado nombra hay que anotarlo con sus palabras. Evans llama a esto el punto de partida del lenguaje ubicuo: el vocabulario que usa el experto del dominio debe ser el mismo que aparezca en las historias, en la spec, en el modelo de datos y en el código.

Si el tutor dice "desenganche", la entidad no se llama `StudentStatusFlag`. Cuando el lenguaje del código y el del cliente divergen, cada conversación necesita traducción, y en cada traducción se pierde algo.

Glosario mínimo del dominio, a construir durante la entrevista: desenganche, riesgo, intervención, comisión, entrega, umbral, seguimiento.

> **Fuente.** Evans, E. (2003). *Domain-Driven Design: Tackling Complexity in the Heart of Software*, Addison-Wesley, cap. 1, "Crunching Knowledge", y cap. 2, "Communication and the Use of Language" (lenguaje ubicuo). Resumen libre: *Domain-Driven Design Reference*, CC-BY, https://www.domainlanguage.com/wp-content/uploads/2016/05/DDD_Reference_2015-03.pdf · Fowler, M. — "Ubiquitous Language", https://martinfowler.com/bliki/UbiquitousLanguage.html

## 5.7 Actividad: entrevista en vivo

El docente actúa como tutor y cada equipo llega con sus preguntas escritas.

Antes, cada equipo entrega su guion: objetivo, cinco preguntas como mínimo, y qué espera averiguar con cada una. Durante, se hacen turnos rotativos y el resto del curso escucha y anota qué preguntas produjeron información y cuáles produjeron cortesía. Después, en la puesta en común, se revisa qué se descubrió que ningún equipo esperaba y qué preguntó un equipo que a los demás no se les había ocurrido.

Se evalúa con esta rúbrica:

| Criterio | Qué se busca |
|---|---|
| Preguntas por hechos | Piden un episodio concreto del pasado |
| Sondeo | Repreguntan sobre la respuesta anterior |
| No inducción | No contienen la respuesta esperada |
| Escucha | Siguen lo que apareció, no sólo su lista |
| Registro | Anotan términos del cliente textualmente |

## 5.8 Errores frecuentes

- Leer la lista de preguntas de corrido, sin escuchar la respuesta.
- Preguntar por deseos y funcionalidades en lugar de por hechos.
- No pedir los documentos que ya existen.
- Traducir el vocabulario del cliente a jerga técnica mientras se toma nota.
- No devolver lo entendido para que lo validen.

## 5.9 Lecturas

- Kendall, K. y Kendall, J. *Análisis y diseño de sistemas* (8ª ed.), Pearson, caps. 4 y 5.
- Fitzpatrick, R. (2013). *The Mom Test*, caps. 1-3. https://www.momtestbook.com/
- Gause, D. y Weinberg, G. (1989). *Exploring Requirements*, parte I y caps. de talleres de requisitos.
- Wiegers, K. y Beatty, J. (2013). *Software Requirements* (3ª ed.), Microsoft Press, parte II, "Requirements Development", cap. sobre elicitación.
- Evans, E. (2003). *Domain-Driven Design*, caps. 1-2.
- Fowler, M. — "Observed Requirement". https://martinfowler.com/bliki/ObservedRequirement.html
- Farley, D. — "A Practical Guide To User Stories & Requirements". https://www.youtube.com/watch?v=MECG5MPy_cc

---

# Tema 6 — Identificación y análisis de requerimientos

## 6.1 De la nota al requerimiento

Lo que sale de una entrevista son notas. Un requerimiento es otra cosa: es una afirmación sobre lo que el sistema tiene que hacer, o sobre la cualidad con que debe hacerlo, escrita de modo que se pueda verificar si se cumplió.

Entre una cosa y la otra hay cinco pasos: **filtrar**, porque no todo lo que dijo el cliente es requerimiento y hay contexto, anécdota y deseo; **deduplicar**, porque lo mismo aparece dicho de tres maneras en tres momentos distintos; **desambiguar**, para que cada frase admita una sola lectura; **clasificar** en funcional o no funcional, que es el tema 7; y **priorizar**, porque no entra todo.

## 6.2 Atributos de un requerimiento utilizable

La norma ISO/IEC/IEEE 29148 lista las características de un requisito individual y de un conjunto de requisitos. Las cinco que se usan en esta materia son: **necesario** —si se saca, falta algo; si nadie lo extraña, no era requisito—; **no ambiguo** —admite una sola interpretación—; **verificable** —existe una forma de comprobar que se cumplió—; **trazable** —se puede seguir hasta el problema o la decisión que lo motiva—; y **sin diseño adentro** —dice *qué*, no *cómo*—.

> **Fuente.** ISO/IEC/IEEE 29148:2018, *Systems and software engineering — Life cycle processes — Requirements engineering*, cláusula 5.2.5 (características de un requisito individual) y 5.2.6 (características de un conjunto de requisitos).

## 6.3 Los siete pecados del especificador

Meyer hace en "On Formalism in Specifications" un ejercicio que conviene repetir en clase: toma un enunciado de requerimiento en prosa, de apariencia razonable, y lo desarma. Del análisis sale una tipología de siete defectos que funciona como grilla de revisión:

| Pecado | Qué es |
|---|---|
| **Ruido** | Hay texto que no aporta información sobre ninguna característica del problema. |
| **Silencio** | Hay una característica del problema que ningún elemento del texto cubre. |
| **Sobreespecificación** | Hay texto que no describe el problema sino una solución posible. |
| **Contradicción** | Dos elementos definen la misma característica de manera incompatible. |
| **Ambigüedad** | Un elemento permite interpretar una característica de al menos dos maneras. |
| **Referencia adelantada** | El texto usa una característica que recién se define más adelante. |
| **Wishful thinking** | Define una característica de tal modo que ninguna solución candidata podría verificarse contra ella. |

El punto de Meyer no es que haya que escribir todo en notación matemática, sino que la prosa parece precisa cuando no lo es, y que la sensación de haber entendido no es evidencia de haber entendido.

> **Fuente.** Meyer, B. (1985). "On Formalism in Specifications", *IEEE Software*, 2(1), enero 1985, pp. 6-26. Los siete pecados se enumeran en la sección "The seven sins of the specifier". PDF: https://se.inf.ethz.ch/~meyer/publications/ieee/formalism.pdf · Resumen: https://blog.acolyer.org/2016/11/08/on-formalisms-in-specifications/ · Versión moderna del argumento: Meyer, B. (2018). "The Formal Picnic Approach to Requirements", https://bertrandmeyer.com/2018/12/17/formal-picnic-approach-requirements/

**Técnica de clase.** Tomar una frase del propio relevamiento y buscarle tres lecturas distintas. Si se encuentran, la frase no era un requerimiento. Ejemplo del dominio, sobre *"el sistema debe avisar cuando un estudiante está en riesgo"*: ¿avisar a quién, al tutor, al estudiante, a la coordinación? ¿avisar cuándo, en el momento en que cruza el umbral o en un resumen semanal? ¿"en riesgo" según qué criterio, inasistencias, entregas, ambas, con qué peso? Tres lecturas, tres decisiones pendientes, y ninguna la puede tomar el equipo por su cuenta.

Palabras que casi siempre señalan ambigüedad: rápido, fácil, amigable, adecuado, eficiente, flexible, robusto, "etc.", "y/o", "si corresponde", "de manera automática".

## 6.4 Verificabilidad

La pregunta de control es una sola: ¿cómo sabríamos que está hecho? Si no hay respuesta, no es un requerimiento sino una intención.

La plantilla Volere llama a esto el **criterio de ajuste** (*fit criterion*): la medida concreta contra la que se comprueba el requisito. Es la misma idea que después toma la forma de criterio de aceptación en una historia de usuario, en el tema 8.

> **Fuente.** Robertson, S. y Robertson, J. — *Volere Requirements Specification Template*, sección 12 y siguientes, definición de *fit criterion*. Uso académico exento de pago. https://www.volere.org/templates/volere-requirements-specification-template/

## 6.5 Diseño adentro del requerimiento

Un requerimiento que trae la solución cierra el diseño antes de haberlo pensado, y además oculta la necesidad real detrás de una forma. Es la sobreespecificación de Meyer.

| Con diseño adentro | Requerimiento | Qué se ganó |
|---|---|---|
| "Un desplegable con las comisiones" | "El tutor selecciona sobre qué comisión trabaja" | Con 40 comisiones un desplegable no sirve. El requisito sigue valiendo. |
| "Un semáforo rojo/amarillo/verde" | "El tutor distingue de un vistazo el nivel de riesgo de cada estudiante" | El semáforo puede fallar por accesibilidad. La necesidad no. |
| "Exportar a Excel" | "La coordinación recibe el estado de la comisión en un formato que pueda procesar" | Deja abierto CSV, PDF o un informe en pantalla. |

Hay una excepción: cuando el "cómo" es una restricción real impuesta desde afuera —una norma, un sistema con el que hay que integrarse—, entonces sí es un requisito y va como restricción, en el tema 9.

## 6.6 Trazabilidad y priorización

Cada requerimiento se ata a algo: al enunciado del problema o a una decisión que el usuario tiene que tomar. El filtro es la pregunta de la materia —¿qué decisión del tutor habilita esto?— y lo que no tiene respuesta sale de la lista o baja al fondo.

Para priorizar hay dos herramientas. **MoSCoW** clasifica en *Must* —sin esto no hay producto—, *Should* —importante, hay alternativa—, *Could* —si sobra tiempo— y *Won't* —explícitamente afuera, esta vez—; la última categoría es la que más sirve, porque deja escrito lo que no se va a hacer. **Valor contra esfuerzo** ordena en una matriz de dos ejes: lo de alto valor y bajo esfuerzo va primero, lo de bajo valor y alto esfuerzo no va. Ninguna de las dos funciona si todo es *Must*: un backlog donde todo es prioritario no está priorizado.

El backlog se cierra al 70% de lo relevado y se reserva un 30% para lo que aparezca. No es que falte trabajo, es reconocer por escrito que todavía no se sabe todo, y es la aplicación directa del principio de simplicidad del Manifiesto: maximizar la cantidad de trabajo no realizado.

> **Fuente.** Beck, K. y otros (2001). *Manifiesto Ágil*, décimo principio: "La simplicidad, o el arte de maximizar la cantidad de trabajo no realizado, es esencial". https://agilemanifesto.org/iso/es/principles.html

## 6.7 Ejercicio

Se toman seis frases textuales de los relevamientos de los equipos y para cada una se contesta: ¿es un requerimiento o una nota?; ¿qué segunda lectura admite?; ¿cómo sabríamos que está hecho?; ¿tiene diseño adentro y, si sí, cómo se reescribe?; ¿qué decisión habilita? Lo que sobrevive a los cinco pasos entra al backlog.

## 6.8 Lecturas

- Meyer, B. (1985). "On Formalism in Specifications", *IEEE Software*, 2(1), pp. 6-26. https://se.inf.ethz.ch/~meyer/publications/ieee/formalism.pdf
- Meyer, B. (2018). "The Formal Picnic Approach to Requirements". https://bertrandmeyer.com/2018/12/17/formal-picnic-approach-requirements/
- Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 5, "Evolutionary Requirements", y cap. 7, "Other Requirements".
- Plantilla Volere, sección de *fit criterion* y de restricciones. https://www.volere.org/templates/volere-requirements-specification-template/
- ISO/IEC/IEEE 29148:2018, cláusulas 5.2.5 y 5.2.6.
- Cohn, M. — "Advantages of User Stories over Requirements and Use Cases". https://www.mountaingoatsoftware.com/articles/advantages-of-user-stories-for-requirements

---

# Tema 7 — Requerimientos funcionales y no funcionales

## 7.1 La distinción

El requerimiento **funcional** dice qué hace el sistema: calcular el índice de riesgo de cada estudiante. El **no funcional** dice con qué cualidad lo hace, y bajo qué restricciones: el panel completo carga en menos de 3 segundos.

El funcional se descubre solo, porque el cliente lo pide. El no funcional no aparece si no se lo va a buscar, porque nadie pide explícitamente que el sistema sea confiable: se da por supuesto. Y como no se pidió no se construye, y como no se construyó se descubre en producción.

Por eso hace falta una grilla, no para clasificar sino para acordarse de preguntar por la categoría que nadie mencionó.

## 7.2 FURPS+

La grilla del Proceso Unificado, que Larman explica en pocas páginas:

| Letra | Categoría | Pregunta que dispara |
|---|---|---|
| **F** | Functionality (funcionalidad) | Qué hace, incluida la seguridad |
| **U** | Usability (usabilidad) | Factores humanos, ayuda, documentación, accesibilidad |
| **R** | Reliability (confiabilidad) | Frecuencia de fallas, recuperación, previsibilidad |
| **P** | Performance (rendimiento) | Tiempos de respuesta, uso de recursos, disponibilidad |
| **S** | Supportability (soporte) | Mantenibilidad, configurabilidad, adaptabilidad |
| **+** | Restricciones | De diseño, de implementación, de interfaz, físicas |

El "+" es donde entra lo que no es una cualidad sino una imposición: el lenguaje que hay que usar, la norma que hay que cumplir, el sistema con el que hay que integrarse.

> **Fuente.** Larman, C. *Applying UML and Patterns*, cap. 5, "Evolutionary Requirements", §5.2 "Types of Requirements", donde presenta FURPS+ atribuyéndolo a Robert Grady (Hewlett-Packard). Texto de la 2ª ed. disponible en https://www.oreilly.com/library/view/applying-uml-and/0130925691/0130925691_ch05lev1sec2.html

La norma ISO/IEC 25010 organiza lo mismo en ocho características —adecuación funcional, eficiencia de desempeño, compatibilidad, usabilidad, fiabilidad, seguridad, mantenibilidad y portabilidad—, es más completa y está disponible en castellano. Cualquiera de las dos sirve; conviene usar una sola y no mezclar vocabularios.

> **Fuente.** ISO/IEC 25010, modelo de calidad del producto software. Resumen en castellano de las ocho características y sus subcaracterísticas: https://iso25000.com/index.php/normas-iso-25000/iso-25010

## 7.3 Cómo se escribe uno verificable

"El sistema debe ser rápido" no es un requerimiento: no se puede aceptar ni rechazar, así que no se puede terminar. Un no funcional utilizable tiene tres partes:

> En **[situación]**, cuando **[estímulo]**, el sistema **[respuesta]** en **[medida]**.

| Vago | Verificable |
|---|---|
| El sistema debe ser rápido | Con 300 estudiantes cargados, el panel de riesgo se muestra completo en menos de 3 segundos |
| El sistema debe ser seguro | Sólo un usuario autenticado con rol de tutor accede a los datos de su comisión; un intento de acceso a otra comisión se rechaza y se registra |
| Debe ser fácil de usar | Un tutor que nunca vio el sistema registra la asistencia de una clase completa en menos de 2 minutos, sin ayuda |
| Debe ser confiable | Ningún registro de asistencia confirmado se pierde ante una caída; al reiniciar, los datos confirmados están |

La medida no tiene que ser ambiciosa, tiene que existir. Un umbral flojo pero verificable vale más que uno exigente pero declarativo. Es la misma noción de *fit criterion* del tema 6.

## 7.4 Dónde viven

En un documento aparte —la **Especificación Suplementaria** del Proceso Unificado—, no adentro de cada historia de usuario.

La razón es práctica: un no funcional atraviesa muchas historias, así que si se copia en cada una se duplica, cuando cambia se actualiza en algunas y no en otras, y termina habiendo dos versiones contradictorias del mismo requisito. Se escribe una vez y las historias lo referencian.

> **Fuente.** Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 7, "Other Requirements", §7.4 "NextGen Example: (Partial) Supplementary Specification" y §7.5 "Commentary: Supplementary Specification".

## 7.5 Restricciones frente a atributos elegidos

Dentro de los no funcionales hay dos cosas distintas. La **restricción impuesta** viene del entorno: la Ley 25.326 obliga a determinado tratamiento de los datos personales y no se discute. El **atributo elegido** es un nivel que el equipo decide: que el panel cargue en 3 segundos y no en 10 es una decisión con costo. La distinción vuelve a ser la del tema 1 y se cierra en el 9.

## 7.6 En el dominio

| Categoría | Requerimiento | Estado |
|---|---|---|
| F / Seguridad | Sólo el tutor autenticado accede a los datos de sus comisiones | Obligatorio (Ley 25.326, art. 9) |
| F / Seguridad | Los datos de desempeño se usan sólo para el seguimiento y no se comparten | Obligatorio (Ley 25.326, art. 4, finalidad) |
| U | Un tutor sin capacitación registra la asistencia de una clase en menos de 2 minutos | Elegido |
| U | El nivel de riesgo se distingue sin depender sólo del color | Elegido (accesibilidad) |
| R | Un registro confirmado no se pierde ante una caída | Elegido |
| P | El panel carga en menos de 3 segundos con 300 estudiantes | Elegido |
| P | **Escalabilidad: descartada.** Un solo usuario concurrente | **Descartado con fundamento** |
| S | Los umbrales de riesgo se cambian sin tocar el código | Elegido |
| + | El equipo no cursó desarrollo web: el stack se elige sobre lo conocido | Restricción |

La fila del descarte es tan importante como las demás. Un equipo que declara que la escalabilidad no aplica a su sistema, y explica por qué, demuestra más criterio que uno que copia una lista genérica de atributos de calidad. Descartar con fundamento es diseñar.

## 7.7 Ejercicio

Cuatro requerimientos no funcionales vagos, tomados de los relevamientos. Cada equipo los reescribe con la forma situación-estímulo-respuesta-medida y después recorre la grilla FURPS+ buscando una categoría que no haya considerado todavía.

## 7.8 Lecturas

- Larman, C. *Applying UML and Patterns*, cap. 5 §5.2 (FURPS+) y cap. 7 §7.4-7.5 (Especificación Suplementaria). https://www.oreilly.com/library/view/applying-uml-and/0130925691/0130925691_ch05lev1sec2.html
- ISO/IEC 25010, ocho características de calidad del producto software. https://iso25000.com/index.php/normas-iso-25000/iso-25010
- Farley, D. (2021). *Modern Software Engineering*, Addison-Wesley, parte III, "Optimise for Managing Complexity", caps. 9-13. PDF en `Docs/` del repositorio.
- Fowler, M. — "Story Test". https://martinfowler.com/bliki/StoryTest.html
- Ley N° 25.326, arts. 4 y 9. https://www.argentina.gob.ar/normativa/nacional/ley-25326-64790/actualizacion

---

# Tema 8 — Épicas, historias de usuario y criterios de aceptación

Es el tema más extenso de la unidad, porque es la herramienta que el equipo va a usar todas las semanas del cuatrimestre.

## 8.1 De dónde viene y para qué sirve

La historia de usuario nace en Extreme Programming. Beck la introduce como una de las prácticas primarias y su función original es de planificación, no de especificación: es una unidad de trabajo lo bastante chica para estimarse y lo bastante valiosa para entregarse.

> **Fuente.** Beck, K. y Andres, C. (2004). *Extreme Programming Explained: Embrace Change* (2ª ed.), Addison-Wesley, cap. 7, "Primary Practices", prácticas *Stories*, *Whole Team* y *Weekly Cycle*. Índice del capítulo: https://www.oreilly.com/library/view/extreme-programming-explained/0321278658/ch07.html

Fowler insiste en un punto que evita la mayoría de los problemas: la historia no es el requerimiento escrito en otro formato, es un marcador de una conversación pendiente. Si se la trata como documento se vuelve una especificación mala; si se la trata como recordatorio, funciona.

> **Fuente.** Fowler, M. — "User Story", https://martinfowler.com/bliki/UserStory.html · "Conversational Stories", https://martinfowler.com/bliki/ConversationalStories.html

## 8.2 Las 3 C

Jeffries resume la historia en tres componentes, y los tres son necesarios. La **card** (tarjeta) es un título y un par de líneas, deliberadamente chica: no entra la especificación completa, y esa limitación es la función. La **conversation** (conversación) es donde está el contenido real, y la tarjeta es la excusa para que el equipo y el cliente hablen. La **confirmation** (confirmación) es cómo vamos a saber que está hecho: los criterios de aceptación.

La falla más común es quedarse con la primera C. Una tarjeta sin conversación y sin confirmación es un ticket, y produce lo que el desarrollador supuso, no lo que el cliente necesitaba.

> **Fuente.** Jeffries, R. (2001). "Essential XP: Card, Conversation, Confirmation". https://ronjeffries.com/xprog/articles/expcardconversationconfirmation/

## 8.3 La plantilla

> Como **[rol]**, quiero **[capacidad]**, para **[beneficio]**.

Hay tres cosas que decir sobre ella. El **"para" es lo que importa**, porque ahí está el valor y es lo único que permite decidir prioridad, discutir alternativas y evaluar si la historia sirve; quien no puede escribir el "para" todavía no entendió el requerimiento. El **"como" es un rol**, no una persona ni un desarrollador: "como desarrollador quiero crear la tabla de estudiantes" no es una historia porque no hay usuario ni valor, es una tarea. Y **la plantilla es una ayuda, no una obligación**: Cohn y Fowler coinciden en que si una historia se entiende mejor de otra forma se escribe de otra forma, porque el problema no es el formato sino perder el valor de vista.

| | |
|---|---|
| ✗ | Como desarrollador, quiero crear la tabla de asistencias, para guardar los datos. |
| ✗ | Como tutor, quiero un panel, para poder usar el sistema. |
| ✓ | Como tutor, quiero ver los estudiantes de mi comisión ordenados por nivel de riesgo, para decidir a quién contacto esta semana. |
| ✓ | Como tutor, quiero registrar el resultado de un contacto, para no volver a llamar a alguien con quien ya hablé. |

> **Fuente.** Cohn, M. (2004). *User Stories Applied: For Agile Software Development*, Addison-Wesley, cap. 2, "Writing Stories". Capítulo disponible en https://athena.ecs.csus.edu/~buckley/CSc191/User_stories_part_2.pdf · Wake, B. — "What Is a User Story?", https://xp123.com/what-is-a-user-story/

## 8.4 Épica

Una épica es una historia demasiado grande para entrar en un sprint. No es una categoría distinta ni un nivel jerárquico: es una cuestión de tamaño, relativa al equipo y a la iteración.

Sirve para anotar una capacidad importante antes de conocer el detalle, y se divide cuando se acerca el momento de construirla. Dividirla antes es especular; dividirla después es tarde.

> **Fuente.** Cohn, M. (2004). *User Stories Applied*, cap. 2, "Writing Stories", sección sobre historias grandes y épicas. · Cohn, M. — "The Two Ways to Add Detail to User Stories", https://www.mountaingoatsoftware.com/blog/the-two-ways-to-add-detail-to-user-stories

## 8.5 INVEST

La rúbrica de Wake para revisar una historia, que Cohn desarrolla en el capítulo 2 de *User Stories Applied*:

| | | Qué se pregunta | En el dominio |
|---|---|---|---|
| **I** | Independiente | ¿Se puede construir sin esperar a otra? | Si "ver el panel" necesita que exista "calcular riesgo", hay dependencia: se ordenan o se rebanan distinto |
| **N** | Negociable | ¿Deja margen para discutir el cómo? | Si dice "con un semáforo de tres colores", ya se cerró el diseño |
| **V** | Valiosa | ¿Le sirve a alguien que no sea el equipo? | "Crear la tabla" no le sirve al tutor |
| **E** | Estimable | ¿El equipo puede darle un tamaño? | Si nadie sabe cuánto es, falta información: hay que investigar antes |
| **S** | Small (chica) | ¿Entra en un sprint con margen? | Si ocupa todo el sprint no entra, porque no queda lugar para el error |
| **T** | Testeable | ¿Se puede comprobar que está hecha? | Si no hay criterio de aceptación, no se puede aceptar |

Las dos que más rechazan historias en la práctica son la **V** y la **T**.

> **Fuente.** Wake, B. (2003). "INVEST in Good Stories, and SMART Tasks". https://xp123.com/invest-in-good-stories-and-smart-tasks/ · Cohn, M. (2004). *User Stories Applied*, cap. 2, "Writing Stories", donde desarrolla los seis atributos.

## 8.6 Criterios de aceptación

Son la tercera C: definen cuándo la historia está terminada, y los define el cliente —en esta cursada, el docente en rol de Product Owner—, no el equipo.

Hay dos formatos y los dos son válidos. La **lista de verificación** es directa y sirve para historias simples:

> - Se muestran sólo los estudiantes de las comisiones del tutor conectado.
> - El orden por defecto es de mayor a menor riesgo.
> - Si no hay estudiantes en riesgo, se muestra un mensaje explícito y no una tabla vacía.

**Given / When / Then** viene de BDD; North lo propone como un vocabulario para describir comportamiento en lugar de pruebas, y su virtud es que fuerza a explicitar el estado previo, que es donde se esconden los malentendidos:

> **Dado que** el tutor tiene la comisión 2°A a cargo y el estudiante Pérez acumula 4 inasistencias sobre 6 clases, **cuando** el tutor abre el panel de seguimiento, **entonces** Pérez aparece en el listado con nivel de riesgo alto y con el detalle "4 de 6 clases ausente".

> **Fuente.** North, D. (2006). "Introducing BDD", donde presenta el vocabulario Given/When/Then y su origen en JBehave. https://dannorth.net/blog/introducing-bdd/ · Historia y evolución del formato: https://cucumber.io/docs/bdd/history/ · Cohn, M. (2004). *User Stories Applied*, cap. 6, "Acceptance Testing User Stories".

Un criterio de aceptación es bueno cuando usa datos concretos y no categorías —"4 inasistencias sobre 6", no "muchas inasistencias"—; cuando es observable desde afuera, o sea que describe lo que se ve y no cómo está implementado; cuando cubre el camino alternativo y no sólo el feliz —qué pasa si no hay datos, si el estudiante no tiene registro, si dos estudiantes empatan en riesgo—; y cuando no repite la historia con otras palabras. Tres o cuatro criterios por historia suele ser la medida: uno solo indica que falta pensar, diez indican que la historia es una épica.

## 8.7 División de historias

Cuando una historia no entra en un sprint hay que rebanarla, y cada rebanada tiene que entregar valor de punta a punta. La partición por capas —"una historia para la base de datos, otra para la pantalla"— no sirve, porque ninguna de las dos se puede demostrar ni aceptar.

| Patrón | Cómo se corta | Ejemplo |
|---|---|---|
| Pasos del flujo | Una etapa del recorrido por vez | Primero ver el listado; después marcar contactado; después registrar el resultado |
| Variantes de regla de negocio | Una regla por vez | Primero riesgo por inasistencias; después incorporar entregas |
| Variaciones de datos | Un subconjunto de datos | Primero una comisión; después varias |
| Interfaz de entrada | Un modo de carga por vez | Primero carga manual; después importación |
| Escenario simple / complejo | El caso feliz primero | Primero sin empates ni casos límite; después los bordes |
| Operaciones | Una operación CRUD por vez | Primero ver; después editar; después borrar |
| Esfuerzo | Separar lo caro de lo barato | Primero el cálculo con umbral fijo; después configurable |

La heurística general es buscar dónde está la complejidad real —lo que puede sorprender— y aislarla en una rebanada, dejando las variaciones para después.

> **Fuente.** Lawrence, R. y otros — "The Humanizing Work Guide to Splitting User Stories", https://www.humanizingwork.com/the-humanizing-work-guide-to-splitting-user-stories/ · Diagrama de flujo de decisión en PDF: https://www.humanizingwork.com/wp-content/uploads/2020/10/HW-Story-Splitting-Flowchart.pdf

## 8.8 Estimación y backlog

**Estimación relativa.** Se estima el tamaño de una historia comparándola con otra, no en horas. Cohn desarrolla el porqué: las personas son malas estimando duración y bastante buenas comparando tamaños. Una escala chica —1, 2, 3, 5, 8— alcanza, y lo que supere 8 se divide.

**Velocidad.** Es lo que el equipo efectivamente terminó en un sprint. Es una observación, no una meta, y sirve para estimar el siguiente sprint con realismo. Se mide desde el tercer sprint, cuando ya hay con qué comparar.

**Backlog.** Ordenado por prioridad, refinado continuamente y cerrado al 70%. Beck y Fowler lo enuncian como la regla básica de la planificación en XP: el alcance es la variable, no la fecha.

> **Fuente.** Cohn, M. (2005). *Agile Estimating and Planning*, Addison-Wesley, parte II, caps. sobre estimación de tamaño, puntos de historia y velocidad. Ed. en castellano: *Estimación y planificación ágil*. · Beck, K. y Fowler, M. (2000). *Planning Extreme Programming*, Addison-Wesley, caps. sobre estimación, velocidad y el juego de la planificación. Ed. en castellano: *Planificación extrema*, Addison-Wesley, 2002.

## 8.9 Enganche con SDD

La historia con sus criterios de aceptación es lo que entra en la especificación. Una historia con un criterio verificable produce una spec que se puede satisfacer y defender; una historia sin criterio produce una spec que el agente completa a su criterio y que el equipo no puede justificar en la revisión.

Adzic lo formula antes de que existieran los agentes: el valor de una especificación está en los ejemplos concretos que la acompañan, no en la exhaustividad de la prosa. Es la misma idea que sostiene el enfoque de la materia.

> **Fuente.** Adzic, G. (2011). *Specification by Example*, Manning, caps. sobre *deriving scope from goals*, *specifying collaboratively* e *illustrating using examples*.

## 8.10 Taller

**Revisión con INVEST.** Cinco historias del dominio, algunas defectuosas. Cada equipo las evalúa letra por letra y reescribe las que fallan.

**Criterios de aceptación.** Se toma una historia ya buena y cada equipo escribe tres o cuatro criterios en formato Given/When/Then, con datos concretos y al menos un camino alternativo. Se intercambian y el otro equipo tiene que encontrar un caso no cubierto.

**División.** Se entrega una épica del dominio —*"como tutor quiero configurar cómo se calcula el riesgo"*— y cada equipo la divide aplicando dos patrones distintos. Se comparan los cortes.

## 8.11 Errores frecuentes

- La historia técnica, sin usuario ni valor.
- El "para" vacío: "para poder usar el sistema".
- El criterio de aceptación que repite la historia sin decir cómo se comprueba.
- Dividir por capas en lugar de por valor.
- Épicas disfrazadas de historias, que se descubren a mitad del sprint.
- Estimar en horas y convertir la velocidad en meta de productividad.

## 8.12 Lecturas

- Jeffries, R. (2001). "Essential XP: Card, Conversation, Confirmation". https://ronjeffries.com/xprog/articles/expcardconversationconfirmation/
- Wake, B. (2003). "INVEST in Good Stories, and SMART Tasks". https://xp123.com/invest-in-good-stories-and-smart-tasks/
- North, D. (2006). "Introducing BDD". https://dannorth.net/blog/introducing-bdd/
- Lawrence, R. — "The Humanizing Work Guide to Splitting User Stories". https://www.humanizingwork.com/the-humanizing-work-guide-to-splitting-user-stories/
- Beck, K. y Andres, C. (2004). *Extreme Programming Explained* (2ª ed.), cap. 7.
- Beck, K. y Fowler, M. (2000). *Planning Extreme Programming*, caps. de estimación y planificación.
- Cohn, M. (2004). *User Stories Applied*, caps. 2 y 6.
- Fowler, M. — "User Story" y "Conversational Stories". https://martinfowler.com/bliki/UserStory.html
- Adzic, G. (2011). *Specification by Example*, caps. 1-4.
- Kniberg, H. — "Agile Product Ownership in a Nutshell" (15 min). https://www.youtube.com/watch?v=502ILHjX9EE · subtitulado al castellano: https://www.youtube.com/watch?v=BoJaTyYRPIo
- Farley, D. — "Requirement Specification vs User Stories" (GOTO 2023). https://www.youtube.com/watch?v=Cg4Jhx099mU
- Schwaber, K. y Sutherland, J. (2020). *La Guía Scrum*, 13 pp. https://scrumguides.org/docs/scrumguide/v2020/2020-Scrum-Guide-Spanish-European.pdf

---

# Tema 9 — Alcance, supuestos y restricciones

## 9.1 Alcance

Definir el alcance es escribir dos listas, y la segunda es la que sirve: lo que **está dentro de alcance**, o sea lo que se compromete a construir, y lo que está **fuera de alcance**, o sea lo que explícitamente no se va a construir esta vez.

La lista de exclusiones es la que evita la discusión de la semana 10, porque deja por escrito y acordado con el cliente lo que el equipo decidió no hacer. Un alcance declarado sólo en positivo se expande solo: todo lo que no se prohibió parece incluido. Sirve además para decir "todavía no" en lugar de "no", porque una funcionalidad fuera de alcance en esta versión sigue existiendo como candidata para la siguiente.

> **Fuente.** Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 7, §7.6-7.7, documento de Visión, sección de alcance. · Robertson, S. y Robertson, J. — *Volere Requirements Specification Template*, secciones 1-8 (propósito, interesados, restricciones, hechos relevantes y supuestos). https://www.volere.org/templates/volere-requirements-specification-template/

## 9.2 Supuestos

Un supuesto es algo que damos por cierto sin haberlo verificado y sobre lo cual estamos tomando decisiones.

Los supuestos existen siempre; lo que se elige es si están escritos o no. El no escrito es el peligroso, porque nadie lo revisa —nadie sabe que está ahí— y aparece en el sprint 6, cuando ya hay código construido encima. DeMarco y Lister lo formulan en términos de riesgo: un riesgo es un problema que todavía no ocurrió, y gestionarlo empieza por darle un nombre. Un supuesto no verificado es un riesgo sin nombre.

> **Fuente.** DeMarco, T. y Lister, T. (2003). *Waltzing with Bears: Managing Risk on Software Projects*, Dorset House, parte I, caps. 1-4 (qué es un riesgo, por qué gestionarlo y el costo de no declararlo). Ed. en castellano: *Bailando con osos*.

Cómo se escribe uno:

> **Suponemos que** [afirmación]. **Si fuera falso**, [consecuencia]. **Verifica** [quién], **antes de** [cuándo].

Aplicado al dominio:

> Suponemos que **el tutor puede obtener la nómina de estudiantes de su comisión en formato digital**. Si fuera falso, **hay que construir la carga manual de la nómina, que agrega una historia de tamaño medio al sprint 1**. Verifica **el equipo, preguntándole al cliente**, antes de **la planificación del sprint 1**.

El supuesto más caro de este dominio suele ser dar por hecho que los datos de asistencia ya existen en algún lado. No existen: alguien los tiene que cargar, y esa es una decisión de diseño con consecuencias sobre todo el producto.

## 9.3 Restricciones

Una restricción es una condición impuesta desde afuera y no negociable. No se discute: se planifica alrededor.

| Tipo | En el dominio |
|---|---|
| Tiempo | 12 sprints, con la demo intermedia y la final ya fijadas |
| Recursos | 1 a 2 horas semanales por integrante; unas 60 horas-persona por equipo |
| Conocimiento | El equipo todavía no cursó los módulos de desarrollo web |
| Normativa | Ley 25.326: los datos son personales y el tratamiento tiene requisitos |
| Organizacional | El cliente está disponible los viernes |
| Técnica | El instituto no expone su base de datos |

La distinción entre restricción y decisión de alcance es la misma del tema 1, y acá tiene consecuencia práctica: la restricción se acepta, la decisión de alcance se revisa. Tratar una decisión como restricción es renunciar a algo que se podía cambiar; tratar una restricción como decisión es discutir eternamente algo que ya estaba fijado.

## 9.4 El triángulo invertido

En la gestión tradicional se fija el alcance y se estiman tiempo y costo. En un proyecto con fecha inamovible el planteo se invierte: el tiempo y los recursos son fijos y la variable es el alcance.

Beck y Fowler lo desarrollan en *Planning Extreme Programming*: si la fecha no se mueve y el equipo no crece, la única palanca disponible es qué entra y qué no. Por eso priorizar no es un trámite administrativo sino la decisión central del proyecto. Y por eso el principio de simplicidad del Manifiesto —"el arte de maximizar la cantidad de trabajo no realizado"— no es una recomendación estética sino la consecuencia lógica de tener tiempo fijo.

En esta cursada la restricción es literal: las clases 9 y 15 son las evaluaciones y no se mueven.

> **Fuente.** Beck, K. y Fowler, M. (2000). *Planning Extreme Programming*, Addison-Wesley, caps. sobre el juego de la planificación y sobre qué hacer cuando el alcance no entra. · Beck, K. y otros (2001). *Manifiesto Ágil*, décimo principio. https://agilemanifesto.org/iso/es/principles.html · Fowler, M. y Highsmith, J. (2001). "The Agile Manifesto", *Software Development*, 9(8), pp. 28-35. · Fowler, M. — "Scope Limbering", https://martinfowler.com/bliki/ScopeLimbering.html

## 9.5 La entrega

Media página por equipo, con cuatro secciones:

```
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

Sobre la última sección: el 30% reservado del backlog es alcance declarado como incierto, no alcance faltante. Es una decisión de planificación y hay que sostenerla como tal.

## 9.6 Ejercicio

Ocho enunciados tomados del contexto real de la cursada. Cada equipo los clasifica en supuesto, restricción, decisión de alcance o ninguna de las tres, y para cada supuesto escribe cómo lo verificaría y antes de cuándo.

## 9.7 Lecturas

- Larman, C. *Applying UML and Patterns* (3ª ed.), cap. 7, §7.6-7.7, documento de Visión.
- Beck, K. y Fowler, M. (2000). *Planning Extreme Programming*, caps. de planificación y alcance.
- DeMarco, T. y Lister, T. (2003). *Waltzing with Bears*, parte I, caps. 1-4.
- Beck, K. y otros (2001). *Manifiesto Ágil* y sus doce principios. https://agilemanifesto.org/iso/es/manifesto.html · https://agilemanifesto.org/iso/es/principles.html
- Fowler, M. — "Scope Limbering". https://martinfowler.com/bliki/ScopeLimbering.html
- Plantilla Volere, secciones de restricciones, supuestos y hechos relevantes. https://www.volere.org/templates/volere-requirements-specification-template/

---

# Cierre de la unidad

## Lo que queda entregado

Al terminar la unidad, cada equipo tiene escrito: el límite de su sistema con entradas, salidas y limitaciones; el enunciado del problema y la descripción de la situación actual; la lista de actores, usuarios, partes interesadas y sujetos de datos; el registro del relevamiento y el glosario de términos del cliente; la lista de requerimientos analizados y priorizados; la Especificación Suplementaria con los no funcionales, incluidos los descartes fundamentados; el backlog al 70% con épicas, historias y criterios de aceptación; y la media página de alcance, supuestos y restricciones. Con eso se planifica el sprint 1.

## Los cuatro hilos que atraviesan la unidad

**El límite es una decisión.** Aparece en el tema 1 como límite del sistema, en el 4 como recorte de actores, en el 6 como priorización y en el 9 como alcance. Es la misma decisión tomada con distinto grado de detalle.

**Menos información, mejor decisión.** El argumento de Ackoff en el tema 2 es el que justifica el filtro de trazabilidad del tema 6, el descarte fundamentado del tema 7 y el 70% del backlog del tema 9.

**Lo que no se puede verificar no se puede terminar.** Aparece como criterio de ajuste en el tema 6, como medida en el tema 7 y como criterio de aceptación en el tema 8. Es el mismo principio con tres nombres.

**El vocabulario del cliente es el del sistema.** Se recoge en el tema 5 y tiene que sobrevivir hasta el código.

## Evaluación de la unidad

No hay instancia calificada propia: la unidad se evalúa a través de los productos que alimentan el sprint 1 y de la revisión semanal. Los indicadores concretos son cuatro: que el enunciado del problema no nombre la solución; que cada historia del backlog tenga un "para" que nombre una decisión del tutor; que cada historia tenga criterios de aceptación verificables con datos concretos; y que los supuestos estén escritos, con responsable y fecha de verificación.

## Material a preparar antes de dictar

- La planilla de cálculo del tutor, para el ejercicio de análisis documental del tema 5.
- El guion del docente en rol de cliente: qué contesta, qué omite y en qué se contradice.
- Las listas de los ejercicios: 8 funcionalidades (tema 2), 12 candidatos a actor (tema 4), 6 frases de relevamiento (tema 6), 4 no funcionales vagos (tema 7), 5 historias (tema 8) y 8 enunciados (tema 9).
- Las tres plantillas de entrega: Visión recortada, grilla FURPS+ y rúbrica INVEST.
