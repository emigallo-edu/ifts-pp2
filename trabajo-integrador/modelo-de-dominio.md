# El modelo de dominio, resuelto entre todos

Documento de cátedra. Es el modelo de dominio del proyecto de la cursada: los conceptos del problema, sus relaciones y sus datos simples, en el vocabulario del cliente y sin decisiones de software. Acompaña a la [historia de referencia](historia-de-referencia.md) y se lee con ella: la historia muestra la forma de una historia de usuario, este documento muestra la forma de un modelo.

**Para qué sirve.** Es el modelo contra el que cada equipo compara el suyo. **Se copia la forma, no el contenido:** el diagrama que cabe en una reunión, la tabla de conceptos con sus atributos, la de asociaciones con su multiplicidad, la lista explícita de lo que quedó afuera y por qué, y las preguntas que el modelo le abre al cliente. Un modelo propio que no se puede leer al lado de este sin que se note qué le falta, le falta.

El material conceptual está en [unidad-2/contenido.md](../unidad-2/contenido.md), tema "El dominio"; el dominio y el encargo, en [consigna.md](consigna.md). El modelo de datos derivado de este modelo —con sus claves, sus vigencias y sus decisiones de persistencia— está en el mismo archivo, tema "Modelado de datos", y **no es este artefacto**: este se valida con el cliente, aquel con el equipo.

---

## Qué modela y qué no

El modelo cubre las once historias del backlog, no sólo las del esqueleto mínimo. Eso es deliberado y tiene un límite: cubre los conceptos que las historias **ya nombradas** necesitan, y ni uno más. No es un modelo del instituto, ni de la carrera, ni de la actividad docente: es un modelo de la pregunta *a quién llamo esta semana*.

Tres cosas que este modelo no es, y que son los tres errores habituales:

- **No es un modelo de datos.** No hay claves, ni tipos, ni tablas intermedias, ni decisiones de historicidad. Esas aparecen cuando se deriva el esquema, y se discuten con el equipo, no con el cliente.
- **No es un diagrama de clases del programa.** No hay métodos, ni servicios, ni repositorios, ni controladores. `PanelController` no es un concepto del dominio de nadie.
- **No es exhaustivo ni definitivo.** Se armó con lo que el relevamiento dio hasta hoy y se amplía en cada iteración. La versión que se entrega en el sprint 2 es más chica que esta: está al final del documento.

---

## El modelo

```text
                                            ┌──────────────────────┐
                                            │  CRITERIO DE RIESGO  │
                                            └───────────┬──────────┘
                                                        │ determina el riesgo de
                      está integrada por                ▼
┌──────────────┐                                ┌──────────────┐
│   COMISIÓN   ├───────────────────────────────►│  ESTUDIANTE  │
└───┬──────────┘                                └──────────┬───┘
    │ tiene en el calendario                               │ acumula y recibe
    │                                                      │
    │   ┌──────────────┐   registra   ┌──────────────┐     │
    ├──►│    CLASE     ├─────────────►│  ASISTENCIA  │◄────┤
    │   └──────────────┘              └──────────────┘     │
    │                                                      │
    │   ┌──────────────┐   registra   ┌──────────────┐     │
    └──►│   TRABAJO    ├─────────────►│   ENTREGA    │◄────┤
        └──────────────┘              └──────────────┘     │
                                                           │
                                      ┌──────────────┐     │
                                      │   CONTACTO   │◄────┘
                                      └──────────────┘
```

Ocho conceptos. Entra completo en una reunión, que es el único criterio de tamaño que importa: cuando un modelo deja de caber en la conversación con el cliente, dejó de ser vocabulario compartido y se convirtió en documentación.

### Los conceptos

| Concepto | Qué es, en palabras del cliente | Atributos |
|---|---|---|
| **Comisión** | Uno de los dos grupos de primer año que sigue | Nombre, ciclo lectivo, cuatrimestre |
| **Estudiante** | Alguien a quien puede tener que llamar | Legajo, apellido, nombre, fecha de incorporación |
| **Clase** | Un encuentro del cuatrimestre en el que se toma asistencia | Fecha |
| **Asistencia** | Que un estudiante estuvo o no estuvo en una clase | Condición: presente o ausente |
| **Trabajo** | Un práctico que los estudiantes tienen que entregar | Título, fecha límite |
| **Entrega** | Que un estudiante entregó o no entregó un trabajo | Condición: entregado o no entregado |
| **Contacto** | Que se comunicó con un estudiante y qué pasó | Fecha, medio, resultado |
| **Criterio de riesgo** | A partir de cuánto considera que alguien está en riesgo | Umbral de inasistencias, umbral de trabajos no entregados |

**La asistencia es un concepto, no un dato de la clase.** Es el punto donde más modelos se equivocan: la asistencia parece una marca dentro de la clase o una lista dentro del estudiante, y no es ninguna de las dos. Es un hecho con condición propia, que vincula a un estudiante con una clase y que **admite corrección** (H4). Si fuera una simple asociación, corregir sería borrar, y se perdería que hubo corrección. Lo mismo vale para la entrega respecto del trabajo.

**El criterio de riesgo es un concepto porque el cliente lo va a cambiar.** Mientras el umbral vive escrito en el código, no hay nada que el cliente pueda nombrar ni corregir. En cuanto H7 aparece —configurar los umbrales sin tocar el código— el criterio pasa a ser algo del dominio, con nombre propio, que alguien decide y que explica por qué un estudiante figuraba en rojo en mayo y en amarillo en junio sin que sus inasistencias hubieran cambiado.

**La fecha de incorporación es atributo y no concepto, por ahora.** El cliente dijo que siempre hay dos o tres que se incorporan tarde, y ese dato no es decorativo: sin él, el porcentaje de inasistencias de quien entró en la semana seis está mal calculado, y está mal en la peor dirección —le infla el riesgo justamente a quien no lo tiene—. Alcanza como atributo del estudiante **mientras cada estudiante pertenezca a una sola comisión**. Si el cliente dice que alguien puede cursar en dos comisiones o cambiarse de una a otra, la fecha deja de ser un dato del estudiante y aparece un concepto nuevo, **Inscripción**, entre Comisión y Estudiante. Es la pregunta de relevamiento que más puede cambiar este modelo, y está sin responder.

### Las asociaciones

Sólo están las relaciones cuyo conocimiento el sistema tiene que conservar en el tiempo. La multiplicidad no se deduce: se pregunta.

| Asociación | Multiplicidad | Por qué se conserva |
|---|---|---|
| Comisión **está integrada por** Estudiante | 1 — 0..* | Sin ella no hay nómina por comisión, y H1 exige que 1°A y 1°B no se mezclen |
| Comisión **tiene en el calendario** Clase | 1 — 0..* | El denominador del porcentaje de inasistencias son las clases de esa comisión, no las de la otra |
| Comisión **tiene en el calendario** Trabajo | 1 — 0..* | Cada comisión tiene sus propias consignas y fechas |
| Clase **registra** Asistencia | 1 — 0..* | Es el hecho que se carga en H3 y se corrige en H4 |
| Estudiante **acumula** Asistencia | 1 — 0..* | Es la señal principal del indicador y el detalle que justifica el orden del panel |
| Trabajo **registra** Entrega | 1 — 0..* | Es el hecho que se carga en H5 |
| Estudiante **acumula** Entrega | 1 — 0..* | Es la segunda señal del indicador |
| Estudiante **recibe** Contacto | 1 — 0..* | H11 necesita saber a quién ya se contactó y cuándo, para no llamarlo dos veces |
| Criterio de riesgo **determina el riesgo de** Estudiante | 1 — 0..* | Es lo que convierte asistencias y entregas en una prioridad de llamado |

**Dos reglas que la multiplicidad sola no dice**, y que conviene anotar al lado del modelo porque son las que rompen el indicador si se incumplen: hay **a lo sumo una asistencia por estudiante y clase** —corregir la asistencia de una fecha modifica el registro existente, no agrega otro (H4)— y **a lo sumo una entrega por estudiante y trabajo**. Sin esa regla, el mismo estudiante aparece dos veces en el cálculo y el porcentaje que decide a quién llamar es falso.

**Sobre el criterio de riesgo.** Se dibuja uno solo, vigente para todos. Si el cliente dijera que quiere umbrales distintos para 1°A y 1°B —plausible: son dos comisiones con historias distintas—, la asociación se mueve a Comisión y el modelo cambia. Otra pregunta abierta.

---

## Lo que quedó afuera, y por qué

Un concepto que no sostiene ninguna historia no aporta información: agrega ruido a la conversación con el cliente. Lo que se dejó afuera se deja afuera **argumentado**, que es distinto de olvidarlo.

| Lo que no está | Por qué |
|---|---|
| **Riesgo** o **Nivel de riesgo** | No es un concepto del dominio: es lo que resulta de mirar las asistencias y las entregas de un estudiante contra el criterio. Es exactamente el caso del atraso de un préstamo en el ejemplo de la biblioteca. Modelarlo como clase invita a guardarlo, y un valor derivado guardado se desactualiza en la primera carga posterior |
| **Panel** | Es una pantalla, no un concepto. Si el panel aparece en el modelo de dominio, lo que se está modelando es la interfaz |
| **Tutor** | Hay un solo usuario y el sistema no distingue entre varios: modelarlo no habilita ninguna decisión. Vuelve el día en que dos personas sigan la misma comisión y haya que saber quién registró qué |
| **Materia**, **Carrera**, **Docente**, **Aula** | Existen en el instituto y no participan de ninguna de las once historias |
| **Nota** y **Calificación** | El cliente nunca las nombró. Le importa si el trabajo se entregó, no con cuánto se aprobó. Es la tentación más fuerte del dominio y hay que resistirla hasta que el cliente la pida |
| **Cuaderno** y **Aula virtual** | Son de dónde saca hoy los datos, no conceptos del problema. Confundir la fuente de un dato con un concepto es el camino corto a modelar el procedimiento actual en lugar del dominio |
| **Estado del estudiante** (activo, abandonó, recursa) | No se relevó. Y hay una razón para no inventarlo: si el sistema supiera que alguien abandonó, habría que preguntarse si sale del panel, y el cliente fue explícito en que no quiere que nadie desaparezca de la lista |
| **Teléfono** del estudiante | Entra con H10, cuando haya que registrar el contacto. Hoy no participa de ninguna decisión: el cliente lo busca en otra planilla |
| **Justificación** de una inasistencia | Es un atributo candidato de Asistencia, y está afuera del mínimo por decisión de alcance de H3, no porque no exista. Va a volver |

---

## Las preguntas que el modelo abre

Un modelo de dominio sirve tanto por lo que afirma como por lo que vuelve visible. Estas son las preguntas que este modelo dejó a la vista y que hay que llevarle al cliente, no resolver en la mesa del equipo:

- ¿Un estudiante puede estar en las dos comisiones, o cambiarse de una a otra a mitad de cuatrimestre? De la respuesta depende que aparezca el concepto **Inscripción**.
- ¿La asistencia es presente y ausente, o hay más condiciones? ¿La llegada tarde cuenta como presente? ¿Y la ausencia justificada baja el riesgo o no lo toca?
- ¿Un trabajo entregado fuera de término cuenta como entregado? El cliente dijo que los casos que recuerda empezaron por dejar de entregar: la entrega tardía puede ser la señal más temprana de todas.
- ¿Los umbrales son los mismos para las dos comisiones?
- ¿Qué cuenta como contacto? ¿Un mensaje sin respuesta es un contacto? De eso depende que H11 sirva o estorbe.
- ¿Las clases del calendario se cargan de antemano o aparecen cuando se toma asistencia? Es la diferencia entre poder decir *faltó a 4 de 10* y sólo poder decir *faltó 4 veces*.

**Y la pregunta de vocabulario, que es la que decide los nombres.** El cliente no dice "tutor", dice que sigue dos comisiones. La spec 5 se llama *Intervenciones* y H10 habla de *contacto*: son dos palabras para lo mismo y hay que quedarse con una, la del cliente. Lo mismo entre *trabajo*, *práctico* y *TP*, y entre *clase* y *encuentro*. Estos nombres son los que después van a estar en las historias, en el esquema de la base y en el código: elegirlos por comodidad del equipo es contratar la traducción que el lenguaje ubicuo existe para eliminar.

---

## El modelo del sprint 2

El modelo no se completa antes de construir. La versión que corresponde al sprint 2 —esqueleto mínimo H1 → H3 → H6 → H8, con el umbral escrito en el código— tiene cuatro conceptos:

```text
                      está integrada por
┌──────────────┐                        ┌──────────────┐
│   COMISIÓN   ├───────────────────────►│  ESTUDIANTE  │
└───┬──────────┘                        └──────┬───────┘
    │ tiene en el calendario                   │ acumula
    │   ┌──────────────┐   registra     ┌──────▼───────┐
    └──►│    CLASE     ├───────────────►│  ASISTENCIA  │
        └──────────────┘                └──────────────┘
```

Con esos cuatro conceptos el sistema ya contesta la pregunta del cliente, de manera tosca y con una sola señal. Lo demás lo engorda, y engorda en este orden:

| Iteración | Qué agrega al modelo |
|---|---|
| H5 y H6 con dos señales | **Trabajo** y **Entrega** |
| H2 y H4 | Ningún concepto nuevo: la clase pasa a existir antes de que se tome asistencia, y la asistencia se corrige en lugar de duplicarse |
| H7 | **Criterio de riesgo** deja de estar en el código y pasa a ser un concepto que el cliente configura |
| H10 y H11 | **Contacto**, y el teléfono vuelve como atributo del estudiante |

Un modelo terminado en la primera semana no es más confiable por ser exhaustivo: es más caro de corregir, porque todo lo que tiene de más está construido sobre supuestos que nadie validó.

---

## Errores frecuentes en este modelo

- **La asistencia como atributo del estudiante.** *Cantidad de inasistencias* dentro de Estudiante es un valor derivado disfrazado de dato. Se desactualiza solo, y no deja registrar qué día faltó ni corregirlo después.
- **La comisión como texto dentro del estudiante.** Si el cliente la nombra en una conversación, es una clase. Y cuando es clase hay dónde colgar el calendario, que es lo que hace falta dos historias después.
- **El riesgo como clase.** Es lo derivado, no lo dado. Aparece en casi todos los modelos del taller y es el error más instructivo de todos.
- **Modelar el CRUD.** *Alta de estudiante*, *Edición de nómina* y *Carga de asistencia* no son conceptos del dominio: son operaciones sobre él. Si los nombres del modelo empiezan con un verbo de sistema, se está modelando la aplicación.
- **Veinte clases en el primer modelo.** Materia, carrera, docente, aula, período, nota, condición, correlatividad. Todas existen en el instituto; ninguna contesta a quién llamar esta semana.
- **Un modelo que el cliente nunca vio.** Es el error que no se ve en el diagrama y que invalida el artefacto completo: si nadie del lado del dominio lo leyó y lo corrigió, no es un acuerdo, es un dibujo.

---

## Lecturas

- Evans, E. (2003). *Domain-Driven Design*, Addison-Wesley, cap. 1, "Crunching Knowledge", y cap. 2, "Communication and the Use of Language". Fragmento traducido en el repositorio: [DDD - Lenguaje ubicuo](../unidad-2/DDD%20-%20Lenguaje%20ubicuo.pdf).
- Larman, C. *Applying UML and Patterns* (3ª ed.), Prentice Hall, cap. 9, "Domain Models: Visualizing Concepts", en particular §9.16 "Is a Domain Model Really a Data Model?".
- Jacobson, I., Booch, G. y Rumbaugh, J. (1999). *The Unified Software Development Process*, Addison-Wesley, cap. 6, "Capturing Requirements", secc. "Understanding the System Context Using a Domain Model".
- Fowler, M. — "Ubiquitous Language". https://martinfowler.com/bliki/UbiquitousLanguage.html
- Fowler, M. — "Anemic Domain Model". https://martinfowler.com/bliki/AnemicDomainModel.html
