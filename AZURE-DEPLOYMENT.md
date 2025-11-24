# Guía Completa: Conectar y Desplegar en Azure

Esta guía te ayudará a conectar tu aplicación Blazor WebAssembly **TaskManager1** con Microsoft Azure y desplegarla automáticamente usando GitHub Actions.

## 📋 Tabla de Contenidos

1. [Requisitos Previos](#requisitos-previos)
2. [Opción 1: Azure Static Web Apps (Recomendado)](#opción-1-azure-static-web-apps-recomendado)
3. [Opción 2: Azure App Service](#opción-2-azure-app-service)
4. [Configuración de CI/CD con GitHub Actions](#configuración-de-cicd-con-github-actions)
5. [Verificar el Despliegue](#verificar-el-despliegue)
6. [Configuración Avanzada](#configuración-avanzada)
7. [Solución de Problemas](#solución-de-problemas)

## Requisitos Previos

Antes de comenzar, asegúrate de tener:

- ✅ Una cuenta de [Microsoft Azure](https://azure.microsoft.com/free/) (ofrece 12 meses gratis + $200 de crédito)
- ✅ Una cuenta de [GitHub](https://github.com) con tu código subido
- ✅ [Azure CLI](https://docs.microsoft.com/cli/azure/install-azure-cli) instalado (opcional pero recomendado)
- ✅ [.NET 10.0 SDK](https://dotnet.microsoft.com/download) instalado localmente

## Opción 1: Azure Static Web Apps (Recomendado)

**Azure Static Web Apps** es la opción más sencilla y económica para aplicaciones Blazor WebAssembly.

### Ventajas
- ✨ **Completamente gratis** para uso personal y proyectos pequeños
- 🚀 **Despliegue automático** desde GitHub
- 🌐 **SSL gratis** con certificado automático
- ⚡ **CDN global** para mejor rendimiento
- 🔧 **Fácil configuración** en minutos

### Pasos para Configurar

#### 1. Crear un Static Web App en Azure

1. Inicia sesión en [Azure Portal](https://portal.azure.com)
2. Haz clic en **"Crear un recurso"**
3. Busca **"Static Web App"** y selecciónalo
4. Haz clic en **"Crear"**

#### 2. Configurar los Detalles Básicos

| Campo | Valor |
|-------|-------|
| **Suscripción** | Selecciona tu suscripción de Azure |
| **Grupo de recursos** | Crear nuevo: `TaskManager-RG` |
| **Nombre** | `taskmanager-app` (debe ser único globalmente) |
| **Tipo de plan** | `Free` |
| **Región** | Elige la más cercana (ej: East US 2, West Europe) |

#### 3. Configurar la Integración con GitHub

| Campo | Valor |
|-------|-------|
| **Origen** | `GitHub` |
| **Organización** | Tu usuario de GitHub |
| **Repositorio** | `task-managment` |
| **Rama** | `main` o la rama que uses |

#### 4. Configurar los Detalles de Compilación

| Campo | Valor |
|-------|-------|
| **Presets de compilación** | `Blazor` |
| **Ubicación de la aplicación** | `/TaskManager1` |
| **Ubicación de la API** | (dejar vacío) |
| **Ubicación de salida** | `wwwroot` |

#### 5. Revisar y Crear

1. Haz clic en **"Revisar y crear"**
2. Verifica que toda la configuración sea correcta
3. Haz clic en **"Crear"**

Azure creará automáticamente:
- El recurso Static Web App
- Un workflow de GitHub Actions en tu repositorio
- La configuración de despliegue automático

**⏱️ Tiempo estimado:** 2-3 minutos

#### 6. Verificar el Workflow de GitHub Actions

Después de crear el recurso, Azure automáticamente:
1. Crea un archivo `.github/workflows/azure-static-web-apps-<nombre>.yml`
2. Ejecuta el primer despliegue automáticamente

Puedes ver el progreso:
- Ve a tu repositorio en GitHub
- Haz clic en la pestaña **"Actions"**
- Verás el workflow ejecutándose

## Opción 2: Azure App Service

**Azure App Service** es ideal si necesitas más control o funcionalidades backend en el futuro.

### Ventajas
- 🔧 **Mayor control** sobre la configuración del servidor
- 📊 **Métricas avanzadas** y monitoreo
- 🔄 **Escalado automático** disponible
- 🌐 **Soporte para APIs** y servicios backend

### Pasos para Configurar

#### 1. Crear un App Service en Azure

1. Inicia sesión en [Azure Portal](https://portal.azure.com)
2. Haz clic en **"Crear un recurso"**
3. Busca **"App Service"** y selecciónalo
4. Haz clic en **"Crear"**

#### 2. Configurar los Detalles Básicos

| Campo | Valor |
|-------|-------|
| **Suscripción** | Tu suscripción de Azure |
| **Grupo de recursos** | Crear nuevo: `TaskManager-RG` |
| **Nombre** | `taskmanager-app` (debe ser único) |
| **Publicar** | `Código` |
| **Pila en tiempo de ejecución** | `.NET 10 (LTS)` |
| **Sistema operativo** | `Linux` (más económico) o `Windows` |
| **Región** | Elige la más cercana |

#### 3. Configurar el Plan de App Service

| Campo | Valor |
|-------|-------|
| **Plan de Linux/Windows** | Crear nuevo: `TaskManager-Plan` |
| **SKU y tamaño** | `Free F1` (gratis) o `B1` (económico) |

#### 4. Revisar y Crear

1. Haz clic en **"Revisar y crear"**
2. Haz clic en **"Crear"**

**⏱️ Tiempo estimado:** 3-5 minutos

## Configuración de CI/CD con GitHub Actions

Este repositorio ya incluye un workflow de GitHub Actions configurado para desplegar automáticamente a Azure.

### Archivo de Workflow Incluido

El archivo `.github/workflows/azure-deploy.yml` está configurado para:
- ✅ Compilar la aplicación cuando hagas push a `main`
- ✅ Ejecutar tests (si existen)
- ✅ Desplegar automáticamente a Azure
- ✅ Notificar el estado del despliegue

### Configurar Credenciales de Azure

Para que GitHub Actions pueda desplegar en Azure, necesitas configurar las credenciales:

#### Método 1: Usando Azure CLI (Recomendado)

```bash
# 1. Inicia sesión en Azure
az login

# 2. Obtén el ID de tu suscripción
az account show --query id --output tsv

# 3. Crea un Service Principal para el despliegue
az ad sp create-for-rbac \
  --name "github-taskmanager-deploy" \
  --role contributor \
  --scopes /subscriptions/{SUBSCRIPTION_ID}/resourceGroups/TaskManager-RG \
  --sdk-auth

# Esto generará un JSON que debes copiar
```

#### Método 2: Desde Azure Portal

1. Ve a **Azure Active Directory** → **App registrations**
2. Haz clic en **"New registration"**
3. Nombre: `github-taskmanager-deploy`
4. Haz clic en **"Register"**
5. Ve a **Certificates & secrets** → **New client secret**
6. Guarda el **Client Secret** (solo se muestra una vez)
7. Ve a **Overview** y copia:
   - Application (client) ID
   - Directory (tenant) ID
8. Ve a tu Subscription → **Access control (IAM)**
9. Agrega el role assignment **Contributor** a tu aplicación

#### Agregar las Credenciales a GitHub

1. Ve a tu repositorio en GitHub
2. Haz clic en **Settings** → **Secrets and variables** → **Actions**
3. Agrega los siguientes secrets:

| Secret Name | Descripción |
|------------|-------------|
| `AZURE_CREDENTIALS` | El JSON completo del Service Principal |
| `AZURE_WEBAPP_NAME` | El nombre de tu Azure Web App (ej: `taskmanager-app`) |
| `AZURE_RESOURCE_GROUP` | El nombre del grupo de recursos (ej: `TaskManager-RG`) |

### Variables de Entorno Opcionales

Puedes agregar estas variables según necesites:

```yaml
AZURE_WEBAPP_PACKAGE_PATH: './TaskManager1'
DOTNET_VERSION: '10.0.x'
```

## Verificar el Despliegue

### 1. Ver el Progreso en GitHub Actions

1. Ve a tu repositorio en GitHub
2. Haz clic en la pestaña **"Actions"**
3. Selecciona el workflow más reciente
4. Observa cada paso del despliegue

### 2. Acceder a tu Aplicación Desplegada

#### Para Static Web Apps:
```
https://<tu-app-name>.azurestaticapps.net
```

#### Para App Service:
```
https://<tu-app-name>.azurewebsites.net
```

### 3. Verificar en Azure Portal

1. Ve a tu recurso en [Azure Portal](https://portal.azure.com)
2. En **Overview**, verás:
   - URL de la aplicación
   - Estado del servicio
   - Métricas en tiempo real

## Configuración Avanzada

### Dominios Personalizados

#### En Static Web Apps:

1. Ve a tu Static Web App en Azure Portal
2. Haz clic en **"Custom domains"**
3. Haz clic en **"Add"**
4. Ingresa tu dominio: `www.tudominio.com`
5. Sigue las instrucciones para configurar DNS

Configuración DNS requerida:
```
CNAME: www.tudominio.com → tu-app.azurestaticapps.net
```

#### En App Service:

1. Ve a tu App Service en Azure Portal
2. Haz clic en **"Custom domains"**
3. Haz clic en **"Add custom domain"**
4. Verifica la propiedad del dominio
5. Configura SSL/TLS

### Variables de Entorno

Para agregar configuraciones específicas del entorno:

1. Ve a tu recurso en Azure Portal
2. Haz clic en **"Configuration"** (App Service) o **"Environment variables"** (Static Web Apps)
3. Agrega nuevas configuraciones:

```
ASPNETCORE_ENVIRONMENT=Production
ApplicationInsights:InstrumentationKey=tu-clave
```

### Application Insights (Monitoreo)

Para habilitar monitoreo detallado:

1. En Azure Portal, ve a tu recurso
2. Haz clic en **"Application Insights"**
3. Haz clic en **"Turn on Application Insights"**
4. Selecciona crear nuevo o usar existente
5. Haz clic en **"Apply"**

El proyecto ya tiene las dependencias necesarias:
```xml
<PackageReference Include="Microsoft.ApplicationInsights.AspNetCore" Version="2.23.0" />
```

### Configurar Autenticación

Para agregar autenticación con Azure AD:

1. Ve a tu Static Web App o App Service
2. Haz clic en **"Authentication"**
3. Haz clic en **"Add identity provider"**
4. Selecciona el proveedor (Microsoft, Google, Facebook, etc.)
5. Configura según las instrucciones

## Solución de Problemas

### Error: "Application failed to start"

**Causa:** Configuración incorrecta del runtime o ruta de salida

**Solución:**
1. Verifica que el `.csproj` tenga:
   ```xml
   <TargetFramework>net10.0</TargetFramework>
   ```
2. Verifica que la ubicación de salida sea `wwwroot` en Static Web Apps

### Error: "No se puede acceder a la aplicación"

**Causa:** El despliegue aún está en progreso o falló

**Solución:**
1. Ve a **Actions** en GitHub y verifica el estado
2. Revisa los logs del workflow para errores
3. Verifica que todos los secrets estén configurados correctamente

### Error: "401 Unauthorized" en GitHub Actions

**Causa:** Credenciales de Azure incorrectas o expiradas

**Solución:**
1. Verifica que `AZURE_CREDENTIALS` sea válido
2. Regenera el Service Principal si es necesario:
   ```bash
   az ad sp create-for-rbac --name "github-taskmanager-deploy" --role contributor --sdk-auth
   ```
3. Actualiza el secret en GitHub

### La aplicación se despliega pero muestra errores

**Causa:** Archivos faltantes o configuración incorrecta

**Solución:**
1. Verifica que todos los archivos necesarios estén en el repositorio
2. Compila localmente para verificar que no hay errores:
   ```bash
   dotnet publish -c Release
   ```
3. Revisa los logs en Azure Portal:
   - App Service: **Monitoring** → **Log stream**
   - Static Web Apps: **Functions** → **Monitor**

### Problemas con Rutas en Blazor WebAssembly

**Causa:** El servidor no está configurado para manejar rutas de Blazor

**Solución:** Ya está configurado en `staticwebapp.config.json`:
```json
{
  "navigationFallback": {
    "rewrite": "/index.html"
  }
}
```

## Actualizaciones Automáticas

Una vez configurado, cada vez que hagas un `git push` a la rama `main`:

1. ✅ GitHub Actions se ejecutará automáticamente
2. ✅ Compilará la aplicación
3. ✅ Ejecutará tests (si existen)
4. ✅ Desplegará a Azure
5. ✅ Tu aplicación estará actualizada en minutos

```bash
# Hacer cambios en tu código
git add .
git commit -m "Nueva funcionalidad"
git push origin main

# ¡GitHub Actions se encarga del resto! 🚀
```

## Costos Estimados

### Azure Static Web Apps
- **Tier Free**: $0/mes
  - 100 GB de ancho de banda
  - 0.5 GB de almacenamiento
  - Ideal para proyectos personales y pequeños

### Azure App Service
- **Tier Free (F1)**: $0/mes
  - 1 GB de memoria
  - 60 minutos de CPU por día
  - 1 GB de almacenamiento
  
- **Tier Basic (B1)**: ~$13/mes
  - 1.75 GB de memoria
  - CPU ilimitado
  - 10 GB de almacenamiento
  - Soporte para dominios personalizados con SSL

## Recursos Adicionales

### Documentación Oficial
- [Azure Static Web Apps](https://docs.microsoft.com/azure/static-web-apps/)
- [Azure App Service](https://docs.microsoft.com/azure/app-service/)
- [Blazor WebAssembly Deployment](https://docs.microsoft.com/aspnet/core/blazor/host-and-deploy/webassembly)
- [GitHub Actions for Azure](https://github.com/Azure/actions)

### Tutoriales en Video
- [Deploy Blazor to Azure](https://www.youtube.com/results?search_query=deploy+blazor+to+azure)
- [GitHub Actions CI/CD](https://www.youtube.com/results?search_query=github+actions+azure)

### Comunidad y Soporte
- [Stack Overflow - Azure](https://stackoverflow.com/questions/tagged/azure)
- [Stack Overflow - Blazor](https://stackoverflow.com/questions/tagged/blazor)
- [Azure Community](https://techcommunity.microsoft.com/t5/azure/ct-p/Azure)

## Checklist de Despliegue

Usa esta lista para verificar que todo está configurado correctamente:

- [ ] Cuenta de Azure creada
- [ ] Recurso en Azure creado (Static Web App o App Service)
- [ ] Service Principal creado (para App Service)
- [ ] Secrets configurados en GitHub
- [ ] Workflow de GitHub Actions configurado
- [ ] Primera compilación exitosa
- [ ] Aplicación accesible desde la URL de Azure
- [ ] Dominio personalizado configurado (opcional)
- [ ] SSL/TLS habilitado
- [ ] Application Insights configurado (opcional)
- [ ] Documentación actualizada

---

## 🎉 ¡Felicidades!

Tu aplicación TaskManager1 ahora está conectada con Azure y se despliega automáticamente con cada cambio en el código.

**¿Necesitas ayuda?** Abre un [Issue en GitHub](../../issues) con tu pregunta.

**¿Te fue útil esta guía?** ¡Deja una ⭐ en el repositorio!
