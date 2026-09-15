# La primera historia de usuario, resuelta entre todos

Documento de cátedra. Es el resultado del taller de la clase 1: la historia **H1** del backlog del dominio, desarrollada de punta a punta con su conversación, sus criterios de aceptación y su revisión con INVEST.

**Para qué sirve.** Es el modelo de formato y de nivel de detalle contra el que se comparan las historias que escribe cada equipo. Las otras diez las escribe el equipo relevando: acá lo que se da es la forma, no el contenido. Si una historia propia no se puede leer al lado de esta sin que se note qué le falta, le falta.

El material conceptual está en [unidad-1/contenido.md](../unidad-1/contenido.md), tema 8; la diferencia entre historia y caso de uso, en [unidad-1/requisitos.md](../unidad-1/requisitos.md). El dominio y el encargo, en [consigna.md](consigna.md).

---

## Por qué H1 va primero

El Product Owner prioriza el esqueleto mínimo **H1 → H3 → H6 → H8**, y H1 abre porque es la precondición de todo lo demás: sin nómina no hay a quién marcar presente ni sobre quién calcular nada.

Conviene decir en voz alta lo incómodo: **es la historia menos valiosa de las cuatro**. La pregunta del cliente —*a quién llamo esta semana*— empieza a contestarse en el sprint 2, con H6 y H8. H1 no contesta nada; habilita. Se prioriza igual porque es la única forma de que exista un dato real sobre el que medir, y porque es chica: entra en el sprint 1 junto con H3 y deja margen.

---

## La tarjeta

> Como **tutor**, quiero **cargar los estudiantes de una comisión y ver la nómina completa**, para **tener sobre quiénes voy a tomar asistencia y medir el riesgo**.

**Sobre el rol.** El cliente no dice "tutor" en ninguna parte del encargo: dice *"sigo dos comisiones de primer año"*. "Tutor" es la palabra que adopta la cátedra por comodidad, y cada equipo tiene que confirmar con el cliente cómo se llama a sí mismo antes de fijarla en el producto: el vocabulario del sistema es el del cliente, no el nuestro (tema 5.6).

**Sobre el "para".** Escribir *"para tener los datos cargados"* es el error más común del taller: repite la capacidad y no nombra ninguna decisión. El "para" de esta historia es débil pero honesto —habilita registrar y medir—, y esa debilidad es información: es la razón por la que H1 sola no se demuestra bien y va acompañada de H3 en el mismo sprint.

---

## La conversación

La tarjeta es la excusa; el contenido salió de preguntarle al cliente. Cada pregunta cerró una decisión de alcance, y sin ellas la historia se habría construido sobre supuestos:

| Pregunta | Respuesta del cliente | Qué decidió |
|---|---|---|
| ¿Cuántas comisiones y cuántos estudiantes? | Dos comisiones de primer año, unos sesenta en total | La nómina se ve **por comisión**, no todo junto. Treinta filas por pantalla es el tamaño real |
| ¿De dónde sale la lista hoy? | Del listado del instituto, que copia a mano en un cuaderno | La carga manual alcanza para la primera versión. Importar el archivo es otra historia |
| ¿Qué datos de cada estudiante usa para decidir? | El nombre, para saber a quién llama | **Apellido, nombre y un identificador.** Nada más entra en el mínimo |
| ¿Y el teléfono, para llamarlo? | Lo tiene en otra planilla, lo busca cuando lo necesita | Queda afuera del mínimo. Vuelve con H10, cuando haya que registrar el contacto |
| ¿Aparece gente después de empezado el cuatrimestre? | Sí, siempre hay dos o tres que se incorporan tarde | Se puede agregar un estudiante en cualquier momento, no sólo al inicio |
| ¿Qué pasa con quien abandona? | No lo borres. Ese es justamente el que me interesa ver | La nómina **no se depura**. Nadie desaparece de la lista |
| ¿Hay más de una persona operando el sistema? | Soy yo sola | Sin usuarios ni permisos. Es una restricción del encargo, no una decisión del equipo |

Las dos respuestas que más cambiaron el diseño son las dos últimas: que nadie se borre convierte la nómina en un registro histórico y no en una lista de gente activa, y que haya un solo usuario saca la autenticación del alcance por completo.

---

## Alcance de esta versión

| Entra | Queda para después |
|---|---|
| Alta manual de un estudiante en una comisión | Editar y dar de baja (patrón *operaciones*) |
| Ver la nómina de una comisión, con el total | Importar desde archivo (patrón *interfaz de entrada*) |
| Dos comisiones cargadas, sin mezclarse | Validaciones de forma de cada campo |
| Rechazar un identificador ya usado | Estado del estudiante: activo, abandonó, recursa |

**Por qué el identificador repetido sí entra y las demás validaciones no.** Un apellido vacío se ve en la pantalla en el momento; un legajo duplicado no se ve, y en el sprint 2 parte la asistencia de una persona en dos filas y le baja el riesgo a la mitad justo a quien había que llamar. La regla es esa: en el mínimo entra la validación que corrompe el indicador, no la que molesta al que carga.

---

## Criterios de aceptación

Cuatro criterios, con datos concretos y dos caminos que no son el feliz. Los define el cliente, no el equipo.

**CA1 · Alta y visualización.** Dado que la comisión 1°A no tiene estudiantes cargados, cuando el tutor carga 30 estudiantes con apellido, nombre y legajo y confirma, entonces la nómina de 1°A muestra los 30 ordenados por apellido e indica que el total es 30.

**CA2 · Nómina vacía.** Dado que la comisión 1°B no tiene ningún estudiante cargado, cuando el tutor abre su nómina, entonces el sistema informa que la comisión todavía no tiene estudiantes y ofrece cargarlos, en lugar de mostrar una tabla vacía.

**CA3 · Identificador repetido.** Dado que en 1°A ya está cargado el legajo 12345, cuando el tutor intenta cargar otro estudiante con el legajo 12345, entonces el alta se rechaza, el sistema informa a qué estudiante corresponde ese legajo y la nómina sigue teniendo 30 estudiantes.

**CA4 · Separación entre comisiones.** Dado que 1°A tiene 30 estudiantes cargados y 1°B tiene 28, cuando el tutor abre la nómina de 1°A, entonces ve únicamente los 30 de 1°A.

**Lo que estos criterios no cubren, a propósito:** el alta con un campo en blanco, el orden alternativo de la lista, dos estudiantes con el mismo apellido, y qué pasa si falla el guardado. Los tres primeros no cambian ninguna decisión del tutor; el cuarto es una garantía mínima que corresponde discutir cuando exista persistencia real, y es el ejemplo de por qué conviene escribir el caso de uso breve antes de la historia: la sección de extensiones obliga a preguntarlo, la plantilla de la historia no.

---

## Revisión con INVEST

| | | Veredicto |
|---|---|---|
| **I** | Independiente | Sí. No espera a ninguna otra historia; es el resto del backlog el que la espera |
| **N** | Negociable | Sí. No dice si la carga es una fila por vez, un formulario o una grilla; eso lo resuelve el equipo |
| **V** | Valiosa | **La más floja de las cuatro del esqueleto.** Habilita, no decide. Se acepta con esa reserva explícita y acompañada de H3 |
| **E** | Estimable | Sí. Es la historia más conocida del backlog: nadie se va a sorprender construyéndola |
| **S** | Chica | Sí. Es la más chica del esqueleto, y por eso sirve de unidad de comparación para estimar el resto |
| **T** | Testeable | Sí. Los cuatro criterios se verifican sobre el producto corriendo, sin mirar el código |

**De paso, la escala.** Conviene tomar esta historia como el punto de referencia de la estimación relativa del equipo —la más chica y la mejor entendida— y estimar todo lo demás comparando contra ella. La velocidad se mide después, desde el tercer sprint.

> **Fuente.** Wake, B. (2003). "INVEST in Good Stories, and SMART Tasks", https://xp123.com/invest-in-good-stories-and-smart-tasks/ · Cohn, M. (2005). *Agile Estimating and Planning*, parte II, caps. de estimación de tamaño y velocidad.

---

## Errores frecuentes en esta historia

- **La historia técnica:** *"como desarrollador, quiero crear la tabla de estudiantes"*. No hay usuario ni valor: es una tarea del sprint, no una historia.
- **El "para" vacío:** *"para tener la nómina cargada"*. Repite la capacidad. Si el "para" se puede deducir del "quiero", falta el "para".
- **El CRUD completo en el sprint 1.** Alta, baja, modificación, importación y validaciones se comen el sprint entero y el cliente sigue sin ver nada que conteste su pregunta.
- **Campos de más.** Domicilio, correo y fecha de nacimiento no participan de ninguna decisión del tutor. El teléfono es el caso interesante: es defendible, pero su historia es H10.
- **Depurar la nómina.** Borrar al que abandonó destruye el único caso que el sistema existe para detectar.
- **Diez criterios de aceptación.** Si hacen falta diez, no es una historia: es una épica sin dividir.

---

## Cómo se usa este documento

Se copia la **forma**, no el contenido: tarjeta con "para" que nombre una decisión, la conversación registrada con lo que decidió cada respuesta, el alcance con su columna de lo que queda afuera, tres o cuatro criterios en Given/When/Then con datos concretos y al menos un camino alternativo, y la revisión con INVEST hecha en serio, incluida la letra que la historia no cumple.

Esa última parte es la que más se saltea. Una revisión con INVEST donde las seis letras dan bien casi siempre significa que no se revisó.

## Lecturas

- Jeffries, R. (2001). "Essential XP: Card, Conversation, Confirmation". https://ronjeffries.com/xprog/articles/expcardconversationconfirmation/
- Cohn, M. (2004). *User Stories Applied*, cap. 2, "Writing Stories", y cap. 6, "Acceptance Testing User Stories".
- North, D. (2006). "Introducing BDD". https://dannorth.net/blog/introducing-bdd/
- Lawrence, R. y otros — "The Humanizing Work Guide to Splitting User Stories". https://www.humanizingwork.com/the-humanizing-work-guide-to-splitting-user-stories/
- Adzic, G. (2011). *Specification by Example*, caps. 1-4.
