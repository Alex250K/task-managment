# TaskManager1 Pro - Gestor de Tareas Interactivo
🧠 **Descripción del Proyecto:** 
TaskManager1 es una aplicación web desarrollada con Blazor WebAssembly, diseñada para gestionar tareas de forma eficiente. Utiliza componentes Razor, interoperabilidad con JavaScript y una estructura modular que facilita la escalabilidad y el mantenimiento.

![Blazor](https://img.shields.io/badge/.NET-8.0-blue)
![License](https://img.shields.io/badge/License-MIT-green)
![Status](https://img.shields.io/badge/Status-Active-brightgreen)

## Características Principales

✓ **Crear tareas** - Agrega nuevas tareas con un solo clic o presionando Enter  
✓ **Marcar completadas** - Selecciona la opcion de la lista desplegable 
✓ **Eliminar tareas** - Elimina tareas que ya no necesites  
✓ **Estadísticas en tiempo real** - Visualiza el total, completadas y pendientes  
✓ **Interfaz moderna** - Diseño limpio, responsivo y profesional  
✓ **Compatible móvil** - Se adapta perfectamente a cualquier dispositivo  

## Tecnologías Utilizadas

- **Blazor WebAssembly** - Framework frontend en C#
- **.NET 8.0** - Plataforma de desarrollo
- **HTML5** - Estructura semántica
- **CSS3** - Estilos modernos y responsivos
- **JavaScript** - Interactividad

## Requisitos Previos

Antes de comenzar, asegúrate de tener instalado:

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (o superior) o [Visual Studio Code](https://code.visualstudio.com/)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Git (para clonar el repositorio)

## Instalación

### Opción 1: Clonar desde GitHub

\`\`\`bash
git clone https://github.com/tu-usuario/TaskManager.git
cd TaskManager
\`\`\`

### Opción 2: Descargar ZIP

1. Haz clic en el botón verde "Code"
2. Selecciona "Download ZIP"
3. Extrae los archivos en tu computadora

## Ejecutar el Proyecto

### Con Visual Studio

1. Abre `TaskManager.csproj` con Visual Studio 2022
2. Presiona **F5** o haz clic en **Ejecutar**
3. La aplicación se abrirá automáticamente en tu navegador

### Con CLI (línea de comandos)

\`\`\`bash
dotnet watch run
\`\`\`

La aplicación estará disponible en: `https://localhost:7001`

## Estructura del Proyecto

\`\`\`
TaskManager1/
```
│
├── Dependencies/                  # Referencias externas necesarias para compilar y ejecutar el proyecto
│   ├── Connected Services/       # Servicios conectados como APIs externas o Azure
│   ├── Analyzers/                # Herramientas que analizan el código para mejorar calidad y estilo
│   ├── Frameworks/               # Frameworks base como .NET Core o ASP.NET
│   └── Packages/                 # Paquetes NuGet instalados (como Entity Framework, etc.)
│
├── Properties/
│   └── launchSettings.json       # Configuración de perfiles de ejecución (puertos, entorno, etc.)
│
├── wwwroot/                      # Carpeta pública para archivos estáticos
│   └── sample-data/              # Datos de ejemplo y recursos visuales
│       ├── ChartUsBlazorInterop.js  # Script JS para interoperabilidad con Blazor (gráficas, etc.)
│       ├── favicon.png              # Ícono del sitio web
│       ├── icon-192.png             # Ícono para dispositivos móviles
│       └── index.html               # Página HTML base (usualmente para SPA o pruebas)
│
├── Layout/
│   └── MainLayout.razor          # Componente de diseño principal (estructura de la interfaz)
│
├── Pages/
│   ├── StatusEnum.cs             # Enumeración para estados de tareas (ej. Pendiente, Completado)
│   └── TodoItem.cs               # Modelo de datos para una tarea (título, estado, fecha, etc.)
│
├── Services/
│   ├── App.razor                 # Punto de entrada de la aplicación Blazor
│   ├── libman.json               # Configuración de librerías externas (JS, CSS) vía LibMan
│   ├── msbuild.binlog            # Archivo de registro de compilación (útil para depuración)
│   ├── Program.cs                # Configuración inicial del host y servicios (como DI, rutas)
│
└── (Otros archivos del proyecto)
```

🚀 Cómo Ejecutar el Proyecto
1. Abre el proyecto en Visual Studio 2022 o superior.

2. Asegúrate de tener instalado el SDK de .NET 6 o .NET 7.

3. Ejecuta el proyecto en modo Debug o Release.

4. Accede a la aplicación en tu navegador en https://localhost:5001.

📦 Dependencias Clave
1. Blazor WebAssembly

2. LibMan para gestión de librerías JS

3. Interop JS para gráficos (ChartUsBlazorInterop.js)

## Cómo Usar la Aplicación

### Crear una Tarea

1. Escribe el nombre de la tarea en el campo de entrada
2. Presiona **Enter** o haz clic en el botón **Agregar**
3. La tarea aparecerá en la lista

### Marcar como Completada

- Selecciona el campo completada de la lista desplegable
- La tarea posicionara en la columna correspondiente al estado Completada

### Eliminar una Tarea

- Haz clic en el botón rojo **Eliminar** al final de la tarea
- La tarea se removerá inmediatamente

### Ver Estadísticas

- En la parte superior verás:
  - **Total**: Cantidad total de tareas
  - **Completadas**: Tareas finalizadas
  - **Pendientes**: Tareas aún por hacer

## Captura de Pantalla

<img width="1890" height="413" alt="image" src="https://github.com/user-attachments/assets/a749f116-4d6d-4087-b2e1-5d8da871ea43" />


📌 Funcionalidades

Crear, editar y eliminar tareas

Visualizar estados mediante enumeraciones

<img width="1553" height="507" alt="image" src="https://github.com/user-attachments/assets/70c02a01-1654-4d30-8364-58c1fbd0c490" />


Interfaz modular con diseño adaptable

Integración con gráficos JS para visualización de datos
##DIAGRAMA DE ARQUITECTURA

<img width="501" height="343" alt="image" src="https://github.com/user-attachments/assets/1508682b-42a3-425c-a900-ef47451145d9" />

## Upgrade Metrics Dashboard

Goal Description
Upgrade the @Metrics.razor dashboard to be dynamic, practical, and real-time. This involves refactoring 
C#TaskService to manage state and notify components of changes, updating @Home.razor to use this service, and enhancing 
@Metrics.razor with filters and charts.

## Proposed Changes
Services
[MODIFY] C#TaskService.cs
- Add a private List<TodoItem> _tasks.
- Add an event event Action OnChange.
- Add methods GetTasks(), AddTask(), UpdateTask(), DeleteTask() that modify _tasks, save to localStorage, and invoke OnChange.
- Initialize _tasks in a InitializeAsync() method or similar.

  ## Pages
  [MODIFY] @Home.razor  
- Remove local tasks list management.
- Use C#TaskService methods for all CRUD operations.
- Subscribe to TaskService.OnChange to re-render when tasks change (if needed, though Home is the primary modifier).

[MODIFY] @Metrics.razor

- Inject @TaskService
- Subscribe to TaskService.OnChange in OnInitialized.
- Implement Dispose to unsubscribe.
- Add filters for Time Period (All Time, Today, Week, Month) and Task Type (All, Pending, Completed, etc.).
- Add a simple CSS-based Bar Chart to visualize task distribution.
- Calculate metrics dynamically from TaskService.Tasks.

  ## Models
  - Ensure TodoItem has necessary fields (checked, it has CreatedAt, Status, Importance).

  # Verification Plan
  Manual Verification
 1. Open two browser windows/tabs (if possible) or just switch between Home and Metrics.
 2. Add a task in Home.
 3. Verify Metrics updates immediately (real-time).
 4. Check filters on Metrics page.
 5. Verify Bar Chart renders correctly.

<img width="1561" height="787" alt="image" src="https://github.com/user-attachments/assets/e9a3927e-2a63-4943-80a1-5703b368c768" />
```
  
Este diagrama muestra cómo se conectan los componentes clave de la aplicación Blazor WebAssembly:
- App.razor como punto de entrada
- MainLayout.razor como diseño base
- Pages y Services como módulos funcionales
- Program.cs como configuración del host
- wwwroot como carpeta de recursos públicos

Todo esto se comunica a través de la web con el servidor ASP.NET Core, formando una arquitectura moderna y eficiente.

## Funcionalidades Futuras

- [ ] Almacenamiento persistente en navegador (LocalStorage)
- [ ] Categorías y etiquetas para tareas
- [ ] Filtrado por estado (todas, completadas, pendientes)
- [ ] Orden personalizado de tareas (drag & drop)
- [ ] Exportar tareas a PDF
- [ ] Backend con base de datos
- [ ] Autenticación de usuarios
- [ ] Sincronización en múltiples dispositivos

## Contribución

Las contribuciones son bienvenidas. Para reportar bugs o sugerir mejoras:

1. Abre un [Issue](../../issues/new)
2. Describe claramente el problema o sugerencia
3. Si es posible, incluye capturas de pantalla

## Licencia

Este proyecto está bajo la licencia MIT. Ver archivo `LICENSE` para más detalles.

## Autor

Creado como proyecto de aprendizaje en Blazor para el taller de .NET

**Fecha de creación**: Noviembre 2025  
**Fecha de entrega**: 25 de noviembre de 2025

## Soporte

Si encuentras problemas:

1. Verifica que tienes .NET 8.0 instalado: `dotnet --version`
2. Restaura los paquetes NuGet: `dotnet restore`
3. Limpia y reconstruye: `dotnet clean` y `dotnet build`
4. Abre un [Issue](../../issues) con la descripción del problema

## Links Útiles

- [Documentación oficial de Blazor](https://learn.microsoft.com/es-es/aspnet/core/blazor/)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- [Guía de Git](https://git-scm.com/doc)

---

**¡Gracias por usar TaskManager Pro!** Si te fue útil, considera dejar una ⭐
