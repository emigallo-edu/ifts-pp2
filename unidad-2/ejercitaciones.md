# Ejercitaciones — Análisis y diseño de la solución

Ejercicios sobre el [dominio del proyecto guía](../trabajo-integrador/consigna.md). El material conceptual está en [contenido.md](contenido.md).

Cada ejercicio produce un artefacto que se versiona en el repositorio del equipo. No son ejercicios de escritorio: lo que producen es la documentación de diseño del proyecto.

--------

## 1 — Análisis de alternativas y registro de la decisión

#### Descripción

El encargo del cliente admite al menos tres soluciones de esfuerzo creciente. El objetivo es comparar dos de ellas con criterios explícitos y registrar la decisión en un formato que permita revisarla más adelante.

##### Pasos a seguir

1. Enunciar dos alternativas de solución que resuelvan el encargo, una de ellas con un alcance sustancialmente menor que la otra. La alternativa de menor alcance no puede ser una versión recortada de la mayor: tiene que ser una forma distinta de resolver el problema.
2. Construir la matriz de comparación con las alternativas en columnas y estos criterios en filas: factibilidad técnica, operativa, económica y temporal, más los atributos de calidad que el equipo considere relevantes.
3. Completar cada celda con evidencia y no con una calificación. Donde no haya evidencia disponible, escribir qué habría que medir para obtenerla.
4. Redactar el **ADR 1** con las cinco secciones: título, estado, contexto, decisión y consecuencias.
5. La sección de consecuencias debe incluir **al menos dos consecuencias negativas** de la alternativa elegida.
6. Intercambiar el ADR con otro equipo. El equipo receptor debe poder anticipar cuál fue la decisión leyendo únicamente la sección de contexto. Si no puede, el contexto está incompleto o la decisión no se sigue de él.

#### Resultado

`docs/adr/0001-alcance-de-la-solucion.md` y la matriz de comparación, en el repositorio del equipo.

--------

## 2 — Factibilidad operativa medida

#### Descripción

La factibilidad operativa del proyecto se juega en una sola operación: el registro de asistencia, que se repite en cada clase y compite con el tiempo de trabajo de la usuaria. El objetivo es medirla antes de construirla.

##### Pasos a seguir

1. Dibujar sobre papel la pantalla de registro de asistencia tal como el equipo la imagina.
2. Cronometrar cuánto tarda una persona ajena al equipo en registrar la asistencia de 30 estudiantes con 4 ausentes, operando sobre el papel.
3. Contar las interacciones necesarias además de marcar a los cuatro ausentes.
4. Contrastar el resultado con el escenario de usabilidad declarado en el ejercicio 6. Si el tiempo medido supera los dos minutos, la factibilidad operativa está comprometida y el rediseño de esa pantalla es prioritario.
5. Registrar por escrito qué cambio del diseño reduciría el tiempo, y cuánto estima el equipo que lo reduciría.

#### Resultado

Media página con la medición, el conteo de interacciones y la conclusión. Se repite la medición sobre el producto construido y se comparan ambos valores.

--------

## 3 — Modelado del comportamiento de mayor riesgo

#### Descripción

Modelar únicamente donde hay decisiones abiertas. En este dominio, la operación con mayor cantidad de decisiones no resueltas es la confirmación de la asistencia de una clase.

##### Pasos a seguir

1. Construir el **diagrama de secuencia del sistema** del escenario principal de *registrar la asistencia de una clase*. El sistema se representa como una única línea de vida; no deben aparecer objetos internos ni almacenamiento.
2. Contar los eventos que cruzan el límite del sistema y contrastarlos con el conteo de interacciones del ejercicio 2. Si no coinciden, uno de los dos modelos está mal.
3. Redactar el **contrato** de la operación de confirmación: precondiciones, poscondiciones y qué no hace la operación.
4. Enumerar el comportamiento esperado ante cada precondición violada: clase inexistente, clase ya confirmada, estudiante incorporado con posterioridad a la fecha de la clase.
5. Verificar que cada uno de esos comportamientos tenga un criterio de aceptación asociado en el backlog. Los que no lo tengan, agregarlos.

#### Resultado

El diagrama y el contrato, en el repositorio. Los criterios de aceptación agregados, en el tablero.

--------

## 4 — Modelo de datos y prueba de historicidad

#### Descripción

El modelo de datos es la decisión más costosa de revertir. La primera parte construye el modelo; la segunda lo somete a dos preguntas sobre el pasado que la mayoría de los modelos no puede responder.

##### Parte 1 — Construcción del modelo

1. Construir el modelo entidad-relación del dominio. Para cada relación, indicar la cardinalidad y **de qué respuesta del cliente proviene**. Las cardinalidades deducidas sin consultar se marcan como supuestos pendientes de verificación.
2. Derivar el modelo relacional: tablas, claves primarias, claves foráneas y comportamiento ante la eliminación.
3. Verificar el cumplimiento de la tercera forma normal. Donde se decida desnormalizar, registrar la medición que lo justifica.
4. Recorrer el modelo **entidad por entidad** y responder por escrito tres preguntas: si ese dato cambia en el tiempo, si alguien va a necesitar conocer su valor anterior, y quién lo va a preguntar.

##### Parte 2 — Prueba de historicidad

5. Determinar si el modelo construido puede responder: *¿cuántas inasistencias acumulaba un estudiante determinado a una fecha pasada?*
6. Determinar si el modelo construido puede responder: *si el umbral de riesgo se modifica hoy, ¿qué estudiantes habrían quedado en riesgo hace dos meses?*
7. Para cada pregunta que el modelo no pueda responder, escribir el cambio mínimo de esquema que lo permitiría y estimar su costo en horas.
8. Decidir, con fundamento, si ese cambio se incorpora ahora o se difiere, y registrar la decisión.

#### Resultado

El modelo entidad-relación, el esquema relacional y la tabla de respuestas por entidad. Los pasos 5 a 8 son el ensayo del cambio de requerimiento que el cliente introduce más adelante en el proyecto.

--------

## 5 — Auditoría de cohesión y acoplamiento

#### Descripción

Se realiza sobre el código ya entregado, no sobre un diseño hipotético. Se repite en cada incremento y produce una serie temporal que muestra si el diseño mejora o se degrada.

##### Pasos a seguir

1. Enumerar los módulos del sistema y describir cada uno **en una sola oración sin conjunción copulativa**. Marcar los que no superen la prueba.
2. Para cada módulo marcado, enumerar las razones de cambio que concentra y proponer la división.
3. Redactar el contrato del componente que resuelve el cálculo de riesgo: precondiciones, poscondiciones y la lista explícita de lo que el componente no hace.
4. Verificar que el cálculo reciba la fecha de corte como parámetro y no la obtenga internamente del reloj del sistema.
5. Responder la pregunta de control: *si el criterio de riesgo cambiara la ponderación entre inasistencias y entregas, ¿cuántos archivos habría que modificar?*
6. Registrar el número obtenido en el paso 5 junto con la fecha del incremento.

#### Resultado

Una tabla acumulativa con el número del paso 5 por incremento. Un valor superior a dos indica que el punto de variación identificado durante el relevamiento no está encapsulado.

--------

## 6 — Arquitectura y atributos de calidad

#### Descripción

La arquitectura se registra y después se somete a los escenarios de calidad que el proyecto declara. El ejercicio produce el riesgo arquitectónico principal del proyecto, que es un insumo de la retrospectiva.

##### Pasos a seguir

1. Redactar el **ADR 2** con la decisión de arquitectura. El contexto debe nombrar las restricciones reales: presupuesto de horas, conocimiento disponible en el equipo, cantidad de usuarios concurrentes.
2. Dibujar el diagrama de capas con la dirección de las dependencias explícita.
3. Redactar **tres escenarios de atributo de calidad** en formato de seis partes: uno de rendimiento, uno de usabilidad y uno de protección de datos personales.
4. Declarar explícitamente **un atributo descartado con su fundamento**, incluido el límite conocido de la solución y la condición bajo la cual dejaría de ser válida.
5. Para cada escenario, identificar qué decisión de la arquitectura lo hace posible y cuál lo pone en riesgo.
6. Responder la pregunta final: *¿cuál es la decisión de nuestra arquitectura que, de resultar equivocada, compromete dos atributos al mismo tiempo?*

#### Verificación sobre el código

Las tres preguntas se contrastan contra el repositorio, no contra el diagrama:

- ¿En qué archivo está escrita la regla que determina el nivel de riesgo?
- ¿Qué habría que modificar para incorporar una señal nueva?
- ¿Puede ejecutarse el cálculo sin levantar la aplicación ni disponer de almacenamiento?

#### Resultado

`docs/adr/0002-arquitectura.md`, el diagrama de capas y los tres escenarios.

--------

## 7 — Prototipo en papel y evaluación con usuarios

#### Descripción

Construir y evaluar el panel y la pantalla de registro antes de escribir código de interfaz. La evaluación se realiza con personas ajenas al equipo.

##### Parte 1 — Construcción

1. Dibujar sobre papel el panel de seguimiento y la pantalla de registro de asistencia. Sin herramientas digitales.
2. Decidir explícitamente qué información queda visible sin requerir una acción adicional y qué información pasa a un segundo nivel.

##### Parte 2 — Evaluación

3. Convocar a tres personas ajenas al equipo y asignarles dos tareas del dominio, no instrucciones de operación:
   - *Registrá la asistencia de la clase de hoy, faltaron cuatro.*
   - *Decidí a qué estudiantes habría que contactar esta semana.*
4. Observar sin intervenir. **Está prohibido explicar la pantalla.** Registrar dónde la persona duda, no lo que opina.
5. Corregir el prototipo con lo observado.

##### Parte 3 — Evaluación heurística

6. Revisar el prototipo corregido contra las diez heurísticas de usabilidad y registrar qué heurística estaba incumpliendo cada problema detectado en el paso 4.
7. Verificar los criterios mínimos de accesibilidad, en particular que el nivel de riesgo se comprenda sin recurrir al color.

#### Resultado

Las dos versiones del prototipo —antes y después de la evaluación— y tres líneas por cada corrección: qué cambió, por qué, y qué heurística estaba incumpliendo. Es material de la documentación final del proyecto.

--------

## 8 — Selección tecnológica y esqueleto ambulante

#### Descripción

La decisión sobre el conjunto de tecnologías se registra y se valida construyendo el recorrido completo más pequeño posible.

##### Parte 1 — La decisión

1. Construir la tabla de conocimiento previo: una fila por integrante, con las tecnologías que utilizó antes. Es el dato que determina el costo real de la decisión y habitualmente la modifica.
2. Evaluar las opciones consideradas contra los seis criterios de selección.
3. Identificar cuántas fichas de innovación se están gastando y sobre qué. Para cada una, escribir por qué esa novedad es necesaria para este problema.
4. Redactar el **ADR 3** con la decisión, incluida la sección de consecuencias con lo que queda difícil por haber elegido así.

##### Parte 2 — La validación

5. Construir el esqueleto ambulante: una funcionalidad mínima que atraviese todas las capas —una pantalla, un dato persistido, un dato recuperado— y desplegarla.
6. El esqueleto debe ejecutarse en un entorno que no sea el equipo de quien lo construyó.
7. Verificar que los cambios de esquema estén versionados como archivos junto con el código, y que un integrante distinto pueda reconstruir la base desde cero.

#### Resultado

`docs/adr/0003-stack.md` y el esqueleto ambulante desplegado y demostrable. El paso 7 es la verificación que evita que cada integrante termine con un esquema distinto.
