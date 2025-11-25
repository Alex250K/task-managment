# Inicio Rápido: Desplegar en Azure en 5 Minutos

¿Quieres ver tu aplicación en línea rápidamente? Sigue esta guía simplificada.

## Opción Más Rápida: Azure Static Web Apps

### Paso 1: Crear Cuenta Azure (2 minutos)

1. Ve a [azure.microsoft.com/free](https://azure.microsoft.com/free)
2. Haz clic en **"Comenzar gratis"**
3. Inicia sesión con tu cuenta Microsoft
4. Completa el registro (requiere tarjeta, pero no se cobra en tier gratuito)

### Paso 2: Crear Static Web App (2 minutos)

1. Inicia sesión en [portal.azure.com](https://portal.azure.com)
2. Busca **"Static Web Apps"** en la barra de búsqueda superior
3. Haz clic en **"+ Create"** / **"+ Crear"**
4. Llena el formulario:
   - **Resource Group**: Crea uno nuevo llamado `TaskManager-RG`
   - **Name**: `taskmanager-app` (o el que prefieras, debe ser único)
   - **Plan type**: Selecciona **Free**
   - **Region**: Selecciona la más cercana a ti
   - **Deployment source**: Selecciona **GitHub**
   - **Sign in with GitHub**: Autoriza Azure a acceder a tu GitHub
   - **Organization**: Tu usuario de GitHub
   - **Repository**: Selecciona `task-managment`
   - **Branch**: `main`
   - **Build Presets**: Selecciona **Blazor**
   - **App location**: `/TaskManager1`
   - **Api location**: (dejar vacío)
   - **Output location**: `wwwroot`
5. Haz clic en **"Review + create"** → **"Create"**

### Paso 3: ¡Listo! (1 minuto)

Azure automáticamente:
- ✅ Creará el recurso en Azure
- ✅ Creará un workflow de GitHub Actions en tu repositorio
- ✅ Desplegará tu aplicación

**Ver el progreso:**
1. Ve a tu repositorio en GitHub
2. Haz clic en la pestaña **"Actions"**
3. Verás el workflow ejecutándose

**Acceder a tu aplicación:**
1. Vuelve a Azure Portal
2. Ve a tu Static Web App
3. En **Overview**, verás la URL: `https://tu-app.azurestaticapps.net`
4. Haz clic en la URL para abrir tu aplicación

## Actualizaciones Automáticas

Ahora, cada vez que hagas push a GitHub:

```bash
git add .
git commit -m "Mi actualización"
git push origin main
```

GitHub Actions automáticamente:
1. ✅ Compilará tu código
2. ✅ Ejecutará tests
3. ✅ Desplegará la nueva versión
4. ✅ Tu aplicación estará actualizada en ~2 minutos

## Configuración Manual del Secret (Si es necesario)

Si el workflow no se ejecuta automáticamente, necesitas configurar el token:

1. Ve a tu Static Web App en Azure Portal
2. Haz clic en **"Manage deployment token"**
3. Copia el token
4. Ve a tu repositorio en GitHub
5. **Settings** → **Secrets and variables** → **Actions**
6. Haz clic en **"New repository secret"**
7. Name: `AZURE_STATIC_WEB_APPS_API_TOKEN`
8. Value: Pega el token que copiaste
9. Haz clic en **"Add secret"**

## ¿Necesitas Más Detalles?

Consulta la [Guía Completa de Azure](AZURE-DEPLOYMENT.md) para:
- Configuración avanzada
- Dominios personalizados
- Variables de entorno
- Application Insights
- Autenticación
- Solución de problemas

## Resumen de Costos

**Azure Static Web Apps - Tier Free:**
- ✅ Completamente gratis
- ✅ 100 GB de ancho de banda por mes
- ✅ SSL automático
- ✅ CDN global
- ✅ Perfecto para proyectos personales

**No necesitas tarjeta de crédito después del periodo de prueba para el tier gratuito.**

---

**¡Eso es todo!** Tu aplicación ahora está en producción en Azure. 🎉

¿Problemas? Abre un [Issue](../../issues) y te ayudaremos.
