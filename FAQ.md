# Preguntas Frecuentes (FAQ)

Respuestas a las preguntas más comunes sobre Task Manager.

## General

### ¿Qué es Task Manager?

Task Manager es una aplicación web moderna para gestionar tareas y listas de pendientes. Está construida con Blazor WebAssembly y .NET 8.0, ofreciendo una interfaz intuitiva y responsiva.

### ¿Es gratuito?

Sí, completamente gratuito y de código abierto bajo licencia MIT.

### ¿Puedo usarlo comercialmente?

Sí, puedes usarlo y modificarlo para uso comercial según la licencia MIT.

### ¿Dónde puedo reportar bugs?

Abre un [Issue](../../issues) en el repositorio de GitHub con los detalles del problema.

---

## Instalación

### ¿Qué necesito para ejecutarlo?

- Visual Studio 2022 (o superior) o Visual Studio Code
- .NET 8.0 SDK
- Un navegador moderno

### ¿Funciona en Mac/Linux?

Sí, .NET 8.0 es multiplataforma. La aplicación funciona en Windows, Mac y Linux.

### ¿Por qué no me compila?

Asegúrate de:
1. Tener .NET 8.0 instalado: `dotnet --version`
2. Restaurar paquetes: `dotnet restore`
3. Limpiar proyecto: `dotnet clean`

### ¿Cuánto espacio ocupa?

Aproximadamente 100MB después de compilar (bin/obj excluidos).

---

## Funcionalidad

### ¿Mis tareas se guardan?

Actualmente, las tareas se guardan en memoria del navegador. Se pierden al cerrar la pestaña. En v1.1.0 implementaremos almacenamiento persistente con LocalStorage.

### ¿Puedo sincronizar en múltiples dispositivos?

Actualmente no. En v2.0.0 agregaremos backend y sincronización.

### ¿Hay límite de tareas?

No hay límite técnico, pero muy muchas tareas pueden afectar el rendimiento.

### ¿Puedo exportar mis tareas?

No en v1.0.0, pero está planeado para futuras versiones.

### ¿Hay aplicación móvil?

No en v1.0.0. Está planeada para v3.1.0 usando MAUI.

---

## Desarrollo

### ¿Cómo contribuyo?

Lee [CONTRIBUCION.md](CONTRIBUCION.md) para los detalles completos.

Resumen:
1. Fork el repositorio
2. Crea una rama con tu feature
3. Haz commit de cambios
4. Push a tu fork
5. Abre un Pull Request

### ¿Necesito experiencia?

Recomendamos tener conocimientos básicos de:
- C# y .NET
- Blazor
- HTML/CSS

Pero está bien si eres principiante, ¡es un proyecto educativo!

### ¿Dónde puedo aprender sobre Blazor?

- [Documentación oficial de Blazor](https://learn.microsoft.com/es-es/aspnet/core/blazor/)
- [Microsoft Learn - Blazor](https://learn.microsoft.com/es-es/training/modules/build-blazor-webassembly-visual-studio-code/)
- [Tutorials de Blazor](https://learn.microsoft.com/es-es/aspnet/core/blazor/tutorials/)

### ¿Puedo usar esto para aprender?

¡Por supuesto! Es perfecto para aprender Blazor, C# y desarrollo web.

---

## Despliegue

### ¿Dónde puedo desplegar la aplicación?

Opciones:
- **Azure** (recomendado para Blazor)
- Vercel
- GitHub Pages
- Tu propio servidor

Ver [DEPLOYMENT.md](DEPLOYMENT.md) para detalles.

### ¿Cuál es la mejor opción?

Para principiantes: **Azure** (gratuito primeros 12 meses)

### ¿Cuánto cuesta?

- Azure: Gratuito primeros 12 meses, luego ~$5-10/mes
- Vercel: Gratuito
- GitHub Pages: Gratuito (limitaciones)

### ¿Necesito una base de datos?

En v1.0.0 no, los datos están en el navegador.
En v2.0.0 sí, implementaremos backend con base de datos.

---

## Problemas Comunes

### Error: "The type or namespace name 'Microsoft' could not be found"

**Causa**: Paquetes NuGet no restaurados

**Solución**:
\`\`\`bash
dotnet restore
dotnet build
\`\`\`

### Error: "Address already in use"

**Causa**: El puerto 7001 ya está en uso

**Solución**: Cierra otras instancias de Visual Studio o cambia el puerto

### La página no carga CSS

**Causa**: Caché del navegador

**Solución**: `Ctrl + Shift + Delete` para limpiar caché

### Las tareas desaparecen al refrescar

**Esperado**: En v1.0.0 no hay persistencia. Es normal.
**Futuro**: Se implementará en v1.1.0

---

## Soporte

### ¿Cómo contacto para soporte?

- Abre un [Issue](../../issues) en GitHub
- Participa en [Discussions](../../discussions)
- Revisa [GUIA_INSTALACION.md](GUIA_INSTALACION.md)

### ¿Hay comunidad?

Sí, participa en:
- Issues y Discussions de GitHub
- Stack Overflow (etiqueta `blazor`)
- Comunidad de Microsoft Learn

### ¿Dónde puedo ver actualizaciones?

- Watch este repositorio en GitHub
- Síguenos en las Releases
- Revisa [ROADMAP.md](ROADMAP.md)

---

## Licencia

### ¿Cuál es la licencia?

MIT License. Ver [LICENSE](LICENSE)

### ¿Puedo modificar el código?

Sí, completamente. Solo debes incluir la licencia MIT.

### ¿Puedo venderlo?

Sí, puedes vender derivados, pero debes incluir la licencia MIT.

### ¿Necesito dar crédito?

No es obligatorio según la licencia, pero es apreciado.

---

## Roadmap

### ¿Cuándo será la próxima versión?

Ver [ROADMAP.md](ROADMAP.md) para fechas estimadas.

### ¿Puedo solicitar una característica?

Sí, abre un [Issue](../../issues/new) con la etiqueta "enhancement".

### ¿Cómo se priorizan las características?

Según:
- Solicitudes de usuarios
- Impacto en la experiencia
- Complejidad técnica
- Disponibilidad de recursos

---

## Performance

### ¿Qué tan rápido es?

- Carga inicial: < 2 segundos
- Tiempo de respuesta: < 100ms
- Tamaño: ~2MB comprimido

### ¿Qué navegadores soporta?

Todos los navegadores modernos:
- Chrome/Edge 90+
- Firefox 88+
- Safari 14+

### ¿Funciona offline?

En v1.0.0 sí, es una Progressive Web App.
Pero sin sincronización. En v2.0.0 mejoraremos esto.

---

## Seguridad

### ¿Es seguro usar mi data?

Actualmente, las tareas están solo en tu navegador.
No se envía a ningún servidor en v1.0.0.
En v2.0.0 tendrá autenticación y encriptación.

### ¿Qué data se recopila?

Ninguna. No hay tracking ni analytics en v1.0.0.

---

## Otros

### ¿Por qué Blazor?

Porque:
- .NET en el navegador
- Desarrollado por Microsoft
- Gran comunidad
- Perfecto para aprender

### ¿Puedo usar esto en producción?

En v1.0.0 es un proyecto educativo.
Para producción, espera a v2.0.0 con backend.

### ¿Hay tests?

No en v1.0.0, pero es importante agregarse en futuras versiones.

### ¿Puedo hacer mi propia versión?

Claro, es software libre. Hazlo tuyo.

---

**¿Tienes más preguntas? Abre un [Issue](../../issues/new) o una [Discussion](../../discussions/new)** 💬
