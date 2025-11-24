# GitHub Actions Workflows para Azure

Este directorio contiene los workflows de CI/CD para desplegar automáticamente la aplicación TaskManager1 en Microsoft Azure.

## Workflows Disponibles

### 1. `azure-static-web-apps.yml` (Recomendado)

**Descripción:** Despliega la aplicación en Azure Static Web Apps.

**Cuándo se ejecuta:**
- Automáticamente al hacer push a la rama `main`
- En pull requests hacia `main`
- Manualmente desde la pestaña Actions

**Requisitos:**
- Secret: `AZURE_STATIC_WEB_APPS_API_TOKEN`
  - Obtenerlo desde Azure Portal → Static Web App → Manage deployment token

**Características:**
- ✅ Compilación automática de .NET
- ✅ Despliegue a Static Web Apps
- ✅ Preview deployments para pull requests
- ✅ Completamente gratis

### 2. `azure-app-service.yml`

**Descripción:** Despliega la aplicación en Azure App Service.

**Cuándo se ejecuta:**
- Manualmente desde la pestaña Actions (por defecto está deshabilitado)
- Descomenta las líneas de `on: push:` para activar despliegue automático

**Requisitos (elige una opción):**

**Opción A - Publish Profile:**
- Secret: `AZURE_WEBAPP_PUBLISH_PROFILE`
  - Obtenerlo desde Azure Portal → App Service → Get publish profile

**Opción B - Service Principal:**
- Secret: `AZURE_CREDENTIALS` (JSON del Service Principal)
- Variable: `AZURE_WEBAPP_NAME` (nombre de tu Web App)

**Características:**
- ✅ Build separado del despliegue
- ✅ Artefactos intermedios
- ✅ Soporte para entornos staging/production
- ✅ Mayor control sobre el proceso

## Configurar Secrets en GitHub

Para que los workflows funcionen, necesitas configurar secrets:

1. Ve a tu repositorio en GitHub
2. **Settings** → **Secrets and variables** → **Actions**
3. Haz clic en **"New repository secret"**
4. Agrega los secrets necesarios según el workflow que uses

## Cómo Activar el Despliegue Automático

### Para Static Web Apps:

Ya está activado por defecto. Cada push a `main` desplegará automáticamente.

### Para App Service:

1. Abre `.github/workflows/azure-app-service.yml`
2. Descomenta las siguientes líneas:
   ```yaml
   on:
     push:
       branches:
         - main
   ```
3. Haz commit y push de los cambios

## Ver el Estado del Despliegue

1. Ve a tu repositorio en GitHub
2. Haz clic en la pestaña **"Actions"**
3. Verás los workflows ejecutándose o completados
4. Haz clic en uno para ver los detalles y logs

## Badges de Estado

Puedes agregar badges al README para mostrar el estado de los workflows:

```markdown
![Azure Static Web Apps CI/CD](https://github.com/tu-usuario/task-managment/workflows/Deploy%20to%20Azure%20Static%20Web%20Apps/badge.svg)

![Azure App Service CI/CD](https://github.com/tu-usuario/task-managment/workflows/Deploy%20to%20Azure%20App%20Service/badge.svg)
```

## Solución de Problemas

### Error: "Secret not found"

**Solución:** Verifica que el secret esté configurado correctamente en GitHub Settings.

### Error: "Authentication failed"

**Solución:** Regenera el token o credenciales y actualiza el secret.

### Error: "Build failed"

**Solución:** 
1. Revisa los logs del workflow para identificar el error
2. Prueba compilar localmente: `dotnet build`
3. Verifica que todas las dependencias estén en el `.csproj`

### El workflow no se ejecuta

**Solución:**
1. Verifica que el archivo YAML esté en `.github/workflows/`
2. Verifica la sintaxis del YAML
3. Asegúrate de hacer push a la rama correcta (`main`)

## Personalización

### Cambiar la rama de despliegue

Edita la sección `on:` en el workflow:

```yaml
on:
  push:
    branches:
      - tu-rama  # Cambia 'main' por tu rama
```

### Agregar más pasos

Puedes agregar pasos adicionales como tests, linting, etc:

```yaml
- name: Run tests
  run: dotnet test

- name: Run linter
  run: dotnet format --verify-no-changes
```

### Cambiar la versión de .NET

Edita la variable de entorno:

```yaml
env:
  DOTNET_VERSION: '10.0.x'  # Cambia a tu versión
```

## Recursos Adicionales

- [GitHub Actions Documentation](https://docs.github.com/actions)
- [Azure Static Web Apps GitHub Actions](https://docs.microsoft.com/azure/static-web-apps/github-actions-workflow)
- [Azure App Service GitHub Actions](https://docs.microsoft.com/azure/app-service/deploy-github-actions)
- [Guía Completa de Azure](../../AZURE-DEPLOYMENT.md)
- [Inicio Rápido](../../AZURE-QUICKSTART.md)

---

**¿Necesitas ayuda?** Abre un [Issue](../../issues) describiendo tu problema.
