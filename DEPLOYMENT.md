# Guía: Desplegar tu Aplicación Blazor

Aprende cómo desplegar tu aplicación Blazor en internet para que cualquiera pueda acceder.

## Opciones de Despliegue

| Plataforma | Costo | Facilidad | Ideal Para |
|-----------|-------|----------|-----------|
| **Azure (Microsoft)** | Gratuito (primeros 12 meses) | Fácil | Aplicaciones profesionales |
| **Vercel** | Gratuito | Muy fácil | Proyectos estáticos |
| **Netlify** | Gratuito | Muy fácil | Sitios web |
| **GitHub Pages** | Gratuito | Moderado | Sitios estáticos |
| **Heroku** | Pago desde $5/mes | Fácil | Aplicaciones backend |

## Recomendación para Principiantes: Azure

Microsoft ofrece:
- 12 meses gratuitos
- $200 de crédito
- Perfecto para aplicaciones Blazor
- Excelente documentación

---

## Desplegar en Azure

### Paso 1: Crear Cuenta Azure

1. Ve a [azure.microsoft.com](https://azure.microsoft.com)
2. Haz clic en **Prueba gratuita**
3. Inicia sesión con tu cuenta de Microsoft
4. Completa el registro (se requiere tarjeta de crédito, pero no se cobrará)

### Paso 2: Preparar tu Proyecto

\`\`\`bash
cd TaskManager

# Verifica que todo compila correctamente
dotnet build

# Publica la aplicación para release
dotnet publish -c Release
\`\`\`

### Paso 3: Crear App Service en Azure

1. Inicia sesión en [Azure Portal](https://portal.azure.com)
2. Haz clic en **Crear un recurso**
3. Busca **App Service**
4. Haz clic en **Crear**

### Paso 4: Configurar App Service

**Detalles básicos:**

| Campo | Valor |
|-------|-------|
| Suscripción | Tu suscripción |
| Grupo de recursos | Crea uno nuevo: `TaskManager-RG` |
| Nombre | `taskmanager-app` (debe ser único) |
| Publicar | `Código` |
| Pila en tiempo de ejecución | `.NET 8 (LTS)` |
| Sistema operativo | `Windows` |
| Región | Elige la más cercana a ti |

**Plan de App Service:**

| Campo | Valor |
|-------|-------|
| Sku y tamaño | `Free F1` (gratuito) |

Haz clic en **Revisar y crear** → **Crear**

### Paso 5: Desplegar desde GitHub

1. En el App Service, ve a **Centro de implementación**
2. Selecciona:
   - Origen: **GitHub**
   - Autorización: Conecta tu GitHub
   - Organización: Tu usuario
   - Repositorio: `TaskManager`
   - Rama: `main`
3. Haz clic en **Guardar**

Azure desplegará automáticamente. Espera 5-10 minutos.

### Paso 6: Acceder a tu Aplicación

1. En el App Service, ve a **Descripción general**
2. Copia la **URL del dominio predeterminado**
3. Abre en tu navegador: `https://taskmanager-app.azurewebsites.net`

¡Tu aplicación está en vivo!

---

## Desplegar en Vercel

### Paso 1: Crear Proyecto en Vercel

Nota: Vercel es mejor para aplicaciones estáticas, pero puede funcionar con Blazor.

1. Ve a [vercel.com](https://vercel.com)
2. Haz clic en **Sign up**
3. Conéctate con tu cuenta de GitHub

### Paso 2: Importar Proyecto

1. En el dashboard de Vercel, haz clic en **New Project**
2. Selecciona tu repositorio `TaskManager`
3. En configuración, selecciona:
   - Framework: **Other**
   - Build Command: `dotnet publish -c Release`
   - Output Directory: `bin/Release/net8.0/publish/wwwroot`

### Paso 3: Desplegar

Haz clic en **Deploy**. Vercel compilará y desplegará tu aplicación.

---

## Desplegar en GitHub Pages

Útil para sitios estáticos. Requiere configuración adicional.

### Paso 1: Crear rama para GitHub Pages

\`\`\`bash
git checkout -b gh-pages
\`\`\`

### Paso 2: Compilar para producción

\`\`\`bash
dotnet publish -c Release -o docs
\`\`\`

### Paso 3: Configurar GitHub

1. Ve a tu repositorio en GitHub
2. Settings → Pages
3. Source: rama `gh-pages`
4. Folder: `/docs`
5. Haz clic en **Save**

Tu sitio estará en: `https://tu-usuario.github.io/TaskManager`

---

## Monitorear tu Aplicación

### En Azure Portal

1. Ve a tu App Service
2. En el menú izquierdo, selecciona **Métricas**
3. Visualiza:
   - Solicitudes HTTP
   - Errores
   - Tiempo de respuesta
   - Uso de CPU

### Ver Logs

\`\`\`bash
# Si tienes Azure CLI instalado
az webapp log tail -n taskmanager-app -g TaskManager-RG
\`\`\`

---

## Actualizar tu Aplicación

### Método 1: Automático (Recomendado)

Con despliegue desde GitHub configurado:

\`\`\`bash
# Haz cambios localmente
# Commit y push a GitHub
git add .
git commit -m "Nueva feature"
git push origin main

# Azure/Vercel desplegará automáticamente
\`\`\`

### Método 2: Manual

\`\`\`bash
dotnet publish -c Release
# Sube los archivos publicados manualmente a tu plataforma
\`\`\`

---

## Dominios Personalizados

Para usar un dominio como `taskmanager.com`:

### En Azure

1. App Service → Dominios personalizados
2. Agrega tu dominio
3. Configura registros DNS en tu proveedor de dominios

### En Vercel

1. Settings → Domains
2. Agrega tu dominio
3. Sigue las instrucciones de configuración DNS

---

## Solucionar Problemas

### Error: "404 Not Found"

Asegúrate de que:
- La URL es correcta
- La aplicación se compiló correctamente
- Los archivos se desplegaron completamente

### Error: "500 Internal Server Error"

Revisa los logs en el portal de tu plataforma de hosting

### Aplicación lenta

Considera:
- Actualizar a un tier superior
- Optimizar el código
- Habilitar caché

---

## Costos Estimados

**Azure (primeros 12 meses):**
- Free tier: $0
- Después: ~$5-10/mes

**Vercel:**
- Free tier: $0
- Pro: $20/mes

**GitHub Pages:**
- Siempre gratuito

---

## Checklist de Despliegue

- [ ] Proyecto compilado sin errores
- [ ] README.md actualizado
- [ ] .gitignore configurado correctamente
- [ ] Código subido a GitHub
- [ ] Integración con plataforma de hosting configurada
- [ ] Despliegue completado
- [ ] URL accesible desde navegador
- [ ] Funcionalidad básica verificada

---

**¡Tu aplicación está lista para el mundo!** 🚀
