# Ejercitaciones — Identificación y análisis de la problemática

Ejercicios sobre el [dominio del proyecto guía](../trabajo-integrador/consigna.md). El material conceptual está en [contenido.md](contenido.md), y el modelo de formato de una historia de usuario en [historia-de-referencia.md](../trabajo-integrador/historia-de-referencia.md).

Cada ejercicio produce un artefacto que se versiona en el repositorio del equipo. En conjunto constituyen el insumo con el que se planifica la primera iteración.

--------

## 1 — Delimitación del sistema

#### Descripción

Trazar el límite del sistema y sostener el criterio con el que se lo trazó. No existe una respuesta correcta única; existe la obligación de que el criterio esté explícito.

##### Pasos a seguir

1. Dibujar la caja del sistema y completar la tabla con cinco columnas: qué queda dentro, qué constituye el entorno, cuáles son las entradas, cuáles las salidas y cuáles las limitaciones.
2. Verificar la coherencia de la delimitación: toda entrada debe tener quien la provea y toda salida debe tener quien la consuma. Marcar las que no lo tengan.
3. Separar, dentro de la última columna, las limitaciones impuestas por el entorno de las decisiones de alcance adoptadas por el equipo. Escribir el criterio de separación.
4. Contrastar con un equipo que haya trazado un límite distinto. Cada uno defiende el propio nombrando la consecuencia de haberlo trazado así.

#### Resultado

La tabla de delimitación y un párrafo con el criterio. Se revisa cuando el alcance se declara formalmente en el ejercicio 9.

--------

## 2 — Clasificación de funcionalidades por tipo de sistema

#### Descripción

Aplicar por primera vez el criterio de evaluación de la materia: qué decisión habilita cada funcionalidad.

##### Pasos a seguir

1. Tomar la lista de ocho funcionalidades candidatas del dominio, sin ordenar.
2. Clasificar cada una en transaccional, de gestión o de apoyo a la decisión.
3. Escribir, en una línea por funcionalidad, qué decisión habilita y de quién.
4. Marcar las que no habilitan ninguna decisión.
5. En la puesta en común, las funcionalidades que ningún equipo pudo justificar salen del backlog o descienden en prioridad.

#### Resultado

La tabla de clasificación. Las funcionalidades descartadas se registran con el motivo, no se borran: el descarte fundamentado es parte del análisis.

--------

## 3 — Enunciado del problema

#### Descripción

Formular el problema sin nombrar la solución. Es el primer artefacto evaluable del proyecto.

##### Pasos a seguir

1. Redactar el enunciado con la plantilla de cinco piezas: el problema, los afectados, el impacto, y el beneficio de una solución exitosa.
2. Redactar un párrafo con la situación actual: de qué modo se resuelve hoy, con qué herramienta, cuánto tiempo lleva y quién lo hace.
3. Aplicar al enunciado propio el test de la palabra "sistema". Si aparece, reescribir.
4. Intercambiar con otro equipo. El equipo receptor aplica las tres preguntas de Gause y Weinberg: de quién es el problema, qué ocurre si no se hace nada, y si se está resolviendo el problema o el que resulta cómodo resolver.
5. Corregir el enunciado con lo que devolvió el otro equipo.

#### Resultado

El enunciado corregido y el párrafo de situación actual. Todo el trabajo posterior se evalúa contra este documento.

--------

## 4 — Actores, interesados y sujetos de datos

#### Descripción

La identificación de actores es una decisión de alcance: cada actor primario incorporado agrega un conjunto completo de funcionalidad.

##### Pasos a seguir

1. Tomar la lista de doce candidatos del dominio, sin ordenar.
2. Clasificar cada uno en actor primario, actor secundario, parte interesada, sujeto de datos o fuera de consideración.
3. Para cada parte interesada, escribir cómo se satisface su interés sin asignarle pantalla propia.
4. Para cada sujeto de datos, enumerar qué obligaciones genera bajo la Ley 25.326 y qué requerimiento concreto se deriva de ellas.
5. Escribir el objetivo del actor primario a nivel usuario, verificando que no sea ni un objetivo de resumen ni una subfunción.
6. Responder: si el estudiante se incorporara como actor primario, ¿qué funcionalidad nueva aparecería? Estimarla en historias.

#### Resultado

La tabla de clasificación y la estimación del paso 6, que es el argumento cuantitativo de por qué el sistema tiene un solo usuario.

--------

## 5 — Relevamiento

#### Descripción

Tres técnicas aplicadas al mismo problema, con preparación previa escrita y registro posterior.

##### Parte 1 — Preparación de la entrevista

1. Redactar el guion: objetivo de la entrevista, a quién se entrevista y por qué, y un mínimo de cinco preguntas.
2. Para cada pregunta, escribir qué se espera averiguar con ella.
3. Revisar el guion contra las reglas de Fitzpatrick: eliminar toda pregunta que solicite una opinión sobre una idea o un compromiso hipotético, y reemplazarla por una que pida un episodio concreto del pasado.

##### Parte 2 — La entrevista

4. Entrevistar al cliente. Mientras un equipo entrevista, el resto registra qué preguntas produjeron información y cuáles produjeron cortesía.
5. Registrar textualmente los términos que el cliente emplea, sin traducirlos a vocabulario técnico.
6. Redactar el resumen y devolvérselo al cliente para que lo confirme o lo corrija.

##### Parte 3 — Análisis documental

7. Solicitar la planilla de cálculo con la que el cliente hace el seguimiento hoy.
8. Extraer de ella, sin entrevistar: qué datos se consideran importantes (las columnas existentes), cuáles se consideraron y se abandonaron (las columnas vacías), qué cálculos se hacen manualmente y qué se anotó al margen.
9. Comparar lo obtenido en el paso 8 con lo obtenido en la entrevista. Registrar qué apareció en uno y no en el otro.

##### Parte 4 — Glosario

10. Construir el glosario del dominio con los términos del cliente: desenganche, riesgo, intervención, comisión, entrega, umbral, seguimiento, y los que hayan aparecido.

#### Rúbrica de la entrevista

| Criterio | Qué se busca |
|---|---|
| Preguntas por hechos | Solicitan un episodio concreto del pasado |
| Sondeo | Repreguntan sobre la respuesta anterior |
| No inducción | No contienen la respuesta esperada |
| Escucha | Siguen lo que apareció, no sólo la lista propia |
| Registro | Anotan los términos del cliente textualmente |

#### Resultado

El guion, el resumen devuelto y confirmado, el análisis de la planilla y el glosario. El glosario se mantiene hasta el final del proyecto y debe coincidir con los nombres que aparecen en el código.

--------

## 6 — Análisis de requerimientos

#### Descripción

Convertir notas de relevamiento en requerimientos utilizables, aplicando las cinco operaciones y la grilla de Meyer.

##### Pasos a seguir

1. Tomar seis frases textuales del relevamiento propio.
2. Para cada una, responder: si es un requerimiento o una nota.
3. Buscarle dos lecturas distintas. Si se encuentran, identificar qué decisión pendiente produce la ambigüedad y quién debe tomarla.
4. Responder: de qué modo se sabría que está hecho. Si no hay respuesta, no es un requerimiento.
5. Determinar si tiene diseño incorporado y, en ese caso, reescribirlo separando la necesidad de la forma de satisfacerla.
6. Responder: qué decisión del usuario habilita. Lo que no tiene respuesta sale de la lista o desciende en prioridad.
7. Clasificar los sobrevivientes con MoSCoW, verificando que no todos queden en la primera categoría.

#### Resultado

La lista de requerimientos analizados, con las frases descartadas y el motivo de cada descarte.

--------

## 7 — Requerimientos no funcionales

#### Descripción

Los no funcionales no aparecen si no se los busca. El ejercicio consiste en formularlos de manera verificable y en recorrer la grilla completa para encontrar la categoría que nadie mencionó.

##### Pasos a seguir

1. Tomar cuatro requerimientos no funcionales vagos del relevamiento propio.
2. Reescribir cada uno con la forma situación / estímulo / respuesta / medida.
3. Verificar que la medida exista y sea comprobable. Una medida holgada pero verificable es preferible a una exigente pero declarativa.
4. Recorrer la grilla FURPS+ completa y encontrar al menos una categoría que el equipo no haya considerado todavía.
5. Declarar al menos **un atributo descartado con fundamento**, incluido el límite conocido de la solución y la condición bajo la cual el descarte dejaría de ser válido.
6. Separar, en toda la lista, las restricciones impuestas de los atributos elegidos.
7. Consolidar todo en un único documento, fuera de las historias de usuario.

#### Resultado

La Especificación Suplementaria del proyecto. Las historias la referencian; no la copian.

--------

## 8 — Historias de usuario y criterios de aceptación

#### Descripción

Tres ejercicios encadenados sobre la herramienta que el equipo va a usar en cada iteración.

##### Parte 1 — Revisión con INVEST

1. Tomar cinco historias del dominio, algunas de ellas defectuosas.
2. Evaluar cada una letra por letra, escribiendo el veredicto de las seis.
3. Reescribir las que fallen. Una revisión en la que las seis letras resultan satisfactorias casi siempre significa que no se revisó.

##### Parte 2 — Criterios de aceptación

4. Tomar una historia ya correcta y escribir tres o cuatro criterios en formato Dado / Cuando / Entonces.
5. Cada criterio debe usar datos concretos y no categorías, y al menos uno debe cubrir un camino alternativo: ausencia de datos, empates, registros inexistentes.
6. Intercambiar con otro equipo. El equipo receptor debe encontrar un caso no cubierto.

##### Parte 3 — División

7. Tomar una épica del dominio —*configurar cómo se calcula el riesgo*— y dividirla aplicando dos patrones distintos.
8. Comparar ambos cortes: cuál produce divisiones demostrables por separado y cuál aísla mejor la complejidad desconocida.
9. Verificar que ninguna división corresponda a una capa técnica.

#### Resultado

El backlog cerrado al 70%, con épicas, historias y criterios de aceptación. El 30% restante queda declarado como reservado, no como pendiente de definir.

--------

## 9 — Alcance, supuestos y restricciones

#### Descripción

Dejar por escrito qué se sabe, qué no se sabe y qué no puede modificarse.

##### Pasos a seguir

1. Tomar los ocho enunciados del contexto del proyecto y clasificar cada uno en supuesto, restricción, decisión de alcance o ninguna de las tres.
2. Para cada supuesto identificado, completar la formulación: suponemos que, si fuera falso, verifica quién, antes de cuándo.
3. Redactar la declaración de alcance con sus dos listas. **La lista de exclusiones debe tener al menos tantos elementos como la de inclusiones.**
4. Redactar la tabla de restricciones con los seis tipos: tiempo, recursos, conocimiento, normativa, organizacional y técnica.
5. Declarar qué zonas del producto quedan abiertas dentro del 30% reservado y por qué.
6. Verificar contra el ejercicio 1: toda limitación identificada al delimitar el sistema debe aparecer como restricción, y toda decisión de alcance debe aparecer en alguna de las dos listas.

#### Resultado

Media página con las cuatro secciones. Los supuestos se revisan al comienzo de cada iteración, y el que llegó a su fecha de verificación sin verificarse se trata como riesgo abierto.
