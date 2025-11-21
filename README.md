# Task Manager - Gestor de Tareas Interactivo

Una aplicación web moderna y responsiva construida con **Blazor WebAssembly** para gestionar tareas de forma eficiente. Perfecta como proyecto de aprendizaje en .NET.

![Blazor](https://img.shields.io/badge/.NET-8.0-blue)
![License](https://img.shields.io/badge/License-MIT-green)
![Status](https://img.shields.io/badge/Status-Active-brightgreen)

## Características Principales

✓ **Crear tareas** - Agrega nuevas tareas con un solo clic o presionando Enter  
✓ **Marcar completadas** - Marca tareas como completadas con un checkbox  
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
TaskManager/
├── Pages/
│   └── Index.razor                 # Página principal con toda la lógica
├── Shared/
│   └── MainLayout.razor            # Layout base de la aplicación
├── wwwroot/
│   ├── index.html                  # Página HTML principal
│   └── css/
│       └── app.css                 # Estilos principales
├── App.razor                       # Componente raíz
├── Program.cs                      # Configuración de la aplicación
├── TaskManager.csproj              # Archivo de configuración del proyecto
├── README.md                       # Este archivo
└── .gitignore                      # Archivos ignorados por Git
\`\`\`

## Cómo Usar la Aplicación

### Crear una Tarea

1. Escribe el nombre de la tarea en el campo de entrada
2. Presiona **Enter** o haz clic en el botón **Agregar**
3. La tarea aparecerá en la lista

### Marcar como Completada

- Haz clic en el **checkbox** a la izquierda de la tarea
- La tarea se marcará con una línea gris (completada)

### Eliminar una Tarea

- Haz clic en el botón rojo **Eliminar** al final de la tarea
- La tarea se removerá inmediatamente

### Ver Estadísticas

- En la parte superior verás:
  - **Total**: Cantidad total de tareas
  - **Completadas**: Tareas finalizadas
  - **Pendientes**: Tareas aún por hacer

## Captura de Pantalla

[Aquí irían capturas de pantalla de la aplicación funcionando]

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

**¡Gracias por usar Task Manager!** Si te fue útil, considera dejar una ⭐
