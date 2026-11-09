### En clase

- Demo con el cliente (evaluación final, según el [calendario](../calendario.md))
- Defensa individual
- Contenido de hoy: sistemas de información para la gestión. Dato, información y decisión; niveles operativo, táctico y estratégico; consultas de agregación y reportes
- Presentación de la historia nueva del backlog: [H12 · Estudiantes en riesgo de la comisión](#h12--estudiantes-en-riesgo-de-la-comisión)

### Tarea para la siguiente

- Desarrollar H12 sobre los datos que ya tienen cargados, sin modificar el modelo ni el cálculo de riesgo
- Traer el reporte corriendo con los datos reales de la comisión

---

## H12 · Estudiantes en riesgo de la comisión

> Como **tutor**, quiero **ver cuántos estudiantes de una comisión están en riesgo de abandonar la materia**, para **saber si tengo un problema con algunos estudiantes o con la comisión entera**.

### Criterios de aceptación

**CA1 · El número.** Dado que 1°A tiene 30 estudiantes y el cálculo de riesgo da 7 en riesgo, cuando el tutor abre el reporte de 1°A, entonces ve que 7 de 30 están en riesgo de abandonar.

**CA2 · Coincide con el panel.** Dado que el panel de 1°A muestra 7 estudiantes en riesgo, cuando el tutor abre el reporte en el mismo momento, entonces el reporte también dice 7. Si no coinciden, hay dos cálculos de riesgo en el sistema, y ese es el error a evitar.

**CA3 · Comisión sin datos.** Dado que 1°B tiene estudiantes cargados pero ninguna asistencia ni entrega registrada, cuando el tutor abre el reporte de 1°B, entonces el sistema informa que todavía no hay datos para calcular el riesgo, en lugar de decir que hay 0 en riesgo como si todo estuviera bien.

### Algo para discutir en la demo

El reporte cuenta lo que el cálculo dice. Si el cálculo está mal, el número está mal. Y hay una pregunta que conviene hacerse antes de confiar en él: **¿tres faltas son siempre lo mismo?**

No es lo mismo alguien que faltó a las **últimas tres clases**, que alguien que faltó tres veces **salteadas** a lo largo del cuatrimestre, que alguien que faltó tres veces **hace un mes y después vino siempre**. Los tres tienen tres inasistencias; sólo el primero está por abandonar. Si el cálculo cuenta faltas sin mirar cuándo fueron, los tres aparecen igual en el panel y en el reporte, y el tutor termina llamando al que ya volvió.

No les pedimos que lo cambien ahora. Les pedimos que sepan contestarlo: ¿su cálculo distingue estos casos? Si no, ¿qué habría que cambiar para que los distinga, y qué parte del código se toca? Si la respuesta es "el cálculo de riesgo y nada más", el diseño está bien. Si la respuesta incluye pantallas, hay algo que revisar.
