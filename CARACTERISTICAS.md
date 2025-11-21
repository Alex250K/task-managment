# Características Detalladas

## 1. Gestor de Tareas Completo

### Crear Tareas
- Campo de entrada limpio y accesible
- Validación básica (no permite tareas vacías)
- Atajo de teclado: presiona **Enter** para agregar
- Botón **Agregar** para uso con ratón

### Modificar Tareas
- Checkbox para marcar como completada
- Los tareas completadas se ven con estilo diferente
- Cambian de color para mejor visualización
- Estado persiste mientras navegas

### Eliminar Tareas
- Botón rojo claramente identificable
- Confirmación implícita (elimina al instante)
- Fácil acceso en cada fila de tarea

---

## 2. Estadísticas en Tiempo Real

Muestra tres métricas principales:

| Métrica | Descripción |
|---------|------------|
| **Total** | Cantidad total de tareas |
| **Completadas** | Tareas finalizadas |
| **Pendientes** | Tareas aún por hacer |

Se actualizan automáticamente con cada acción.

---

## 3. Interfaz de Usuario

### Diseño
- Limpio y minimalista
- Enfoque en usabilidad
- Jerarquía visual clara
- Espaciado adecuado

### Responsividad
- Se adapta a pantallas pequeñas (móviles)
- Se adapta a pantallas medianas (tablets)
- Se adapta a pantallas grandes (computadoras)

### Accesibilidad
- Labels descriptivos
- Textos legibles
- Colores con buen contraste
- Navegación con teclado

---

## 4. Estructura de Datos

Cada tarea contiene:

```csharp
public class TaskItem
{
    public Guid Id { get; set; }              // ID único
    public string Title { get; set; }         // Nombre de la tarea
    public string Description { get; set; }   // Descripción (opcional)
    public bool IsCompleted { get; set; }     // Estado: completada o no
    public DateTime CreatedAt { get; set; }   // Fecha de creación
}
