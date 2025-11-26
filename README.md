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
/TaskManager1/
├── TaskManager1.sln           # (Nombre de la solución)
└── /TaskManager1/             # Carpeta principal del proyecto
    ├── **Connected Services** # (Generalmente ignorado o puede contener archivos de configuración)
    ├── **Dependencies** # (Ignorado, manejado por el .csproj y NuGet)
    ├── **Properties** # Contiene AssemblyInfo.cs o launchSettings.json
    ├── **wwwroot** # Recursos estáticos de la web
    │   ├── **css**
    │   │   ├── app.css
    │   │   └── site.css
    │   ├── **lib** # Librerías estáticas de terceros (ej. Bootstrap, jQuery)
    │   │   └── bootstrap/
    │   ├── sample-data/       # Datos de ejemplo
    │   │   └── weather.json
    │   ├── ChartJsBlazorInterop.js # Archivo JavaScript de interop
    │   ├── favicon.png
    │   ├── icon-192.png
    │   └── index.html         # Archivo de inicio del cliente (WebAssembly)
    ├── **Layout** # Componentes de diseño
    │   ├── MainLayout.razor
    │   └── NavMenu.razor
    ├── **Models** # Clases de datos y modelos
    │   ├── StatusEnum.cs      # Enum para estados
    │   └── TodoItem.cs        # Clase de modelo
    ├── **Pages** # Páginas ruteables (Componentes principales)
    │   ├── Counter.razor
    │   ├── Home.razor
    │   ├── Metrics.razor
    │   └── NotFound.razor
    ├── **Services** # Lógica de negocio e interacción con datos
    │   └── TaskService.cs     # Servicio de gestión de tareas
    ├── _Imports.razor         # Directivas de importación a nivel de proyecto
    ├── App.razor              # Componente raíz de la aplicación
    ├── libman.json            # Configuración de LibMan (gestor de librerías estáticas)
    ├── msbuild.binlog         # (Ignorado)
    ├── Program.cs             # Punto de entrada de la aplicación
    └── TaskManager1.csproj    # Archivo de configuración del proyecto C#
.gitignore                     # Archivo crucial (ver siguiente sección)
README.md                      # Descripción y configuración del proyecto
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
