# PP II — Desarrollo de sistemas de información orientados a la gestión y apoyo a las decisiones

IFTS N° 11 · Tecnicatura Superior en Desarrollo de Software · 2° cuatrimestre · Prácticas Profesionalizantes
Docente: Emiliano Gallo

## De qué se trata la materia

Durante el cuatrimestre cada equipo lleva adelante **un proyecto de desarrollo de software de punta a punta**: releva el problema con un cliente, define el alcance, construye el producto por partes, lo prueba, lo entrega y lo defiende.

## Cómo se cursa

- **Todos los equipos trabajan sobre el mismo dominio.** El problema lo trae la cátedra; el relevamiento, el alcance y la solución los define cada equipo.
- **Cada semana es un sprint y cada clase es el límite entre dos.** En el mismo encuentro se cierra el sprint entregado y se planifica el siguiente.
- **El docente hace de cliente.** Se lo entrevista, ordena las prioridades, acepta o rechaza lo entregado, y a mitad de cuatrimestre cambia un requerimiento.
- **Las entregas se cargan hasta las 23:59 del jueves previo a la clase**, para que la revisión llegue preparada.
- **Todo el trabajo se registra en Trello:** el backlog, el estado de cada tarea, las minutas y los accionables de cada revisión.

## La dinámica de cada clase

La clase dura cuatro horas y tiene tres bloques: **teoría**, **revisión de entregas** y **cierre de sprint en equipo**.

| | | |
|---|---|---|
| **2 horas** | Teoría | El tema que el proyecto necesita en ese momento |
| **1 hora** | Revisión de entregas | Todos los equipos, cinco minutos cada uno |
| **1 hora (*)** | Cierre de sprint en equipo | Minuta, accionables y planificación del sprint siguiente |

(*) Esta hora es asincrónica, el equipo se puede quedar planificando la siguiente iteración o pueden organizar para juntarse en otro momento.

El orden es ese y no es arbitrario. La teoría abre porque es el bloque que tolera que la clase arranque con gente llegando; la revisión no lo tolera, porque cada equipo tiene turno asignado al minuto. Y el cierre en equipo va último porque lo que se planifica ahí tiene que incorporar la devolución que se acaba de recibir.

### Teoría

El contenido conceptual **no va por delante de la práctica: entra cuando el proyecto lo necesita**. Cada bloque combina el repaso de temas que ya se vieron en otras materias con los temas nuevos que el momento del proyecto exige. Las dos horas incluyen el corte del medio.

**Parte de la teoría sale del código de la propia cursada.** Durante la semana el docente mira los repositorios y los tableros, y lo que le llama la atención lo lleva a la clase para discutirlo entre todos: un principio de diseño mal resuelto, una historia que en realidad eran tres, un criterio de aceptación que no se puede verificar, una consulta que no escala.

### Revisión de entregas

Cada equipo tiene **cinco minutos**, con turno asignado y publicado antes de la clase. En esos cinco minutos entran tres cosas:

1. **La demo del producto en ejecución**, a cargo de un integrante. El rol rota sprint a sprint.
2. **Los desafíos del sprint**: qué costó, qué no entró y por qué.
3. **La devolución del cliente**, que acepta o rechaza lo entregado.

Cuatro reglas, porque con diez equipos en una hora no hay margen: **se demuestra el producto funcionando, no diapositivas**; **la demo llega cargada y corriendo** antes de que termine el equipo anterior, y el tiempo de armar la pantalla sale del turno propio; **un incremento que no corre se registra como no entregado** y el equipo replanifica; y **quien no cargó la entrega el jueves no ocupa turno**. La devolución es frente al curso, para todos igual, y el resto del curso escucha las diez revisiones: al trabajar todos sobre el mismo dominio, el problema de un equipo suele ser el de otro.

### Cierre de sprint en equipo

La última hora es del equipo, sin el docente. No es tiempo libre: es el cierre del sprint, y se cierra por escrito. Antes de terminar la clase tienen que quedar en Trello **la minuta de la revisión**, **los accionables** que dejó la devolución y **el sprint siguiente comprometido**, con las tareas repartidas. Ese registro es lo que se revisa al final del bloque y lo que da por cumplida la clase.

## Roles

| Rol | Quién | Qué hace |
|---|---|---|
| Cliente / Product Owner | El docente | Representa al usuario, ordena el backlog, acepta o rechaza el incremento. **Prioriza, no asigna tareas** |
| Scrum Master | Rota entre los integrantes, un sprint cada uno | Conduce al equipo durante el sprint y presenta la demo en la revisión |
| Minuta | Rota, distinto de quien presenta | Registra la reunión y carga los accionables en Trello |
| Equipo de desarrollo | Todos | Define el alcance del sprint, construye, prueba y documenta |

**El alcance de cada sprint lo define el equipo.** La cátedra prioriza el backlog y fija las fechas de evaluación, pero no reparte el trabajo. Que un equipo advierta a tiempo que lo que se comprometió no llega es parte de lo que la materia enseña.

## Cómo se evalúa

La evaluación es de proceso y de producto. Cada revisión semanal deja registro escrito, y hay **dos instancias calificadas**: una demostración intermedia y la entrega final con defensa individual.

Se evalúa, entre otras cosas: la pertinencia de la solución frente al problema relevado, la capacidad de fundamentar qué decisión habilita cada funcionalidad, la regularidad de las entregas y el realismo creciente de las estimaciones, la calidad técnica, el uso sostenido del repositorio y del tablero, cómo se distribuyó el trabajo dentro del equipo, y la capacidad de defender las decisiones tomadas.

Sobre el uso de asistentes de inteligencia artificial: **está permitido**, y lo que se evalúa es la calidad de la especificación y la solidez de la justificación, no el volumen de código producido. Quien no pueda explicar por qué una decisión es la que es, no tiene el sprint terminado.

## Herramientas

| | |
|---|---|
| Gestión del trabajo | Trello |
| Código | Un repositorio Git por equipo |
| Aula virtual y entregas | Google Classroom |
| Encuentros | Google Meet, salvo las clases presenciales de evaluación |
| Tecnología del producto | La elige cada equipo, con criterio fundamentado |

## Cómo se organiza el material

Este repositorio es **el material de la cátedra**: la teoría de cada unidad y la consigna del proyecto. El trabajo de los equipos no vive acá — va en el repositorio de cada equipo, en Trello y en Classroom.

| Carpeta | Qué hay |
|---|---|
| [unidad-1/](unidad-1/) | Identificación y análisis de la problemática: sistemas y sus límites, tipos de sistema de información, enunciado del problema, actores, relevamiento, requerimientos, historias y criterios de aceptación, alcance |
| [unidad-2/](unidad-2/) | Análisis y diseño de la solución |
| [unidad-3/](unidad-3/) | Desarrollo e implementación |
| [unidad-4/](unidad-4/) | Sistemas de información para la gestión y la toma de decisiones |
| [trabajo-integrador/](trabajo-integrador/) | El dominio del proyecto, el encargo del cliente y el cronograma clase por clase |

**Una carpeta por unidad, y dentro un archivo por tema.** El apunte principal de cada unidad es siempre `contenido.md`. Cuando un tema puntual necesita más profundidad que la que entra en el apunte, se publica como archivo aparte con el nombre del tema —por ejemplo [unidad-1/requisitos.md](unidad-1/requisitos.md), sobre la diferencia entre caso de uso e historia de usuario—.

**Todas las unidades están armadas igual.** Arriba, el dominio de referencia y los objetivos de la unidad: lo que hay que poder hacer al terminarla. Después, los temas numerados, y cada tema cierra siempre con las mismas secciones: **En el dominio** (cómo aplica al proyecto de la cursada), **Errores frecuentes**, **Ejercicio** y **Lecturas**. Si buscás qué se espera de vos, mirá los objetivos; si buscás qué practicar, andá directo al ejercicio del tema.

**Dónde empezar según lo que necesites.** Para saber qué se revisa y qué se ve en cada clase, [trabajo-integrador/consigna.md](trabajo-integrador/consigna.md) tiene el cronograma completo. Para estudiar un tema, buscalo en el `contenido.md` de su unidad. Para entender el problema que hay que resolver, el encargo del cliente está en la misma consigna.

**Dos cosas para no perder de vista.** El material de una unidad se publica antes de la clase en que se usa, así que una unidad todavía no dictada puede estar vacía. Y las citas indican capítulo y sección en lugar de página, porque la paginación cambia entre ediciones y entre las versiones en inglés y en castellano: si una cita te interesa, buscala por el título de la sección.
