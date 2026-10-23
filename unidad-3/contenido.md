# Desarrollo e implementación

## Estructura de la unidad

### Finalidad: ¿Para qué?

- organizar el sistema de modo que el costo de cambiarlo se mantenga bajo mientras lo construimos;
- verificar que lo construido hace lo que el cliente pidió, también en los casos que nadie mencionó;
- integrar el trabajo de todo el equipo en una única versión que funcione;
- mejorar el diseño del código existente sin romper lo que ya anda;
- y lograr que el sistema corra fuera de la máquina de quien lo escribió.

### Fundamentos: ¿Por qué?

- el software se construye de a incrementos, y cada incremento se apoya en los anteriores;
- lo que no está probado no sabemos si funciona: suponemos que funciona;
- el trabajo que no está integrado no existe para el cliente;
- el código se lee muchas más veces de las que se escribe, y se cambia durante toda su vida;
- y toda deuda técnica se paga: lo único que se decide es cuándo y con qué interés.

En la unidad anterior el **costo del cambio** era un criterio para tomar decisiones de diseño. En esta unidad se vuelve una práctica de todos los días: las pruebas lo hacen visible, la integración frecuente lo mantiene chico y la refactorización lo reduce. No se trata de construir rápido y después ordenar, sino de construir de una manera que nos permita seguir construyendo.

### Mecanismos: ¿Cómo?

- organización en capas y dirección de las dependencias;
- atributos de calidad expresados como escenarios verificables;
- prototipado y evaluación de la interfaz;
- selección fundamentada de tecnologías y herramientas;
- pruebas unitarias, de integración y de aceptación, con foco en los casos borde;
- integración frecuente sobre una rama principal, con revisión de código;
- refactorización respaldada por pruebas y gestión explícita de la deuda técnica;
- y configuración fuera del código, ambientes reproducibles e integración continua.

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

### Arquitectura limpia

Robert C. Martin reúne las capas, los puertos y adaptadores y otras propuestas similares en una sola formulación, que llama arquitectura limpia (*Clean Architecture*). El sistema se dibuja como círculos concéntricos, y todo el esquema descansa sobre una única regla:

>La regla que hace funcionar esta arquitectura es la regla de dependencia: las dependencias del código fuente sólo pueden apuntar hacia adentro. Nada en un círculo interior puede saber nada de algo en un círculo exterior.
>
>[The Clean Architecture - Robert C. Martin](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)

```text
  ┌─────────────────────────────────────────────────────────┐
  │  Frameworks y drivers: MAUI, SQLite, EF Core            │
  │   ┌─────────────────────────────────────────────────┐   │
  │   │  Adaptadores: ViewModels, repositorios          │   │
  │   │   ┌─────────────────────────────────────────┐   │   │
  │   │   │  Casos de uso: registrar asistencia,    │   │   │
  │   │   │  calcular el riesgo de una comisión     │   │   │
  │   │   │   ┌─────────────────────────────────┐   │   │   │
  │   │   │   │  Entidades: Estudiante, Clase,  │   │   │   │
  │   │   │   │  reglas del dominio             │   │   │   │
  │   │   │   └─────────────────────────────────┘   │   │   │
  │   │   └─────────────────────────────────────────┘   │   │
  │   └─────────────────────────────────────────────────┘   │
  └─────────────────────────────────────────────────────────┘
              las dependencias apuntan hacia adentro
```

Respecto de lo anterior, el aporte es doble. Por un lado, separa dentro del dominio las **entidades**, que son las reglas más estables del problema, de los **casos de uso**, que son lo que el sistema hace con ellas en esta aplicación en particular. Por otro, ubica a la base de datos y al framework de interfaz en el círculo más externo, como detalles: el centro del sistema es el problema, no la herramienta con que se lo resuelve.

No se trata de una arquitectura distinta de las anteriores, sino de la misma idea llevada a su forma más explícita: el dominio no conoce a quienes lo usan ni a quienes lo guardan.

### Síntesis

La arquitectura se define por el costo de cambio de las decisiones que la componen, no por la cantidad de elementos que contiene. En un proyecto de escala reducida el trabajo arquitectónico consiste casi íntegramente en dos operaciones: fijar la dirección de las dependencias, de modo que el dominio no conozca a quienes lo consumen, y aislar el punto de variación identificado durante el relevamiento. Todo lo demás admite ser simple, y conviene que lo sea.
