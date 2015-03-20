# Shouter
Realizacion del Ejercicio Evaluatorio para la seleccion en Moravia

Mejoras/Desarrollos:
--------------------
- Agregado de lang="en" o lang="es" al tag html para informar al browser el lenguaje en el que esta escrito el site. Practica recomendada para proporcionar accesibilidad
- Cambio site.css para mejorar el aspecto
- Upgrade a Bootstrap 3
- Agrego estructuras propias de Bootstrap como el container y grid entre otras
- Diseño Responsive
- Agrego validaciones
	- Campos Required en el login para no enviar el formulario innecesariamente y proveer feedback instantaneo al usuario
	- Campo e-mail para el login
- Agrego elementos HTML5 como fieldset, label (for), placeholder,, etc
- Corrijo fallas en la seguridad (Se podia acceder a los comments por url sin iniciar sesion previamente.)
- Cambio nombre de archivos para respetar convenciones de MVC
- Aplico MVVM del lado de la UI
- Aplico Capas para desacoplar Presentacion, Logica y Acceso a Datos
- Utilizo DataAnnotations para unificar validacion de campos en el server y en el client
- Globalization: Cambio de idioma basado en la configuracion del navegador del usuario (idiomas disponibles Español e Ingles, siendo el segundo el por defecto para cualquier otra configuracion)
- Ajax: En la pantalla de comments se insertan nuevos comentarios sin refrescar la pagina
- Hora "humanizada" agrego mas alternativas comunes hoy en dia, como "Ayer" y "Ahora".
- Refresco la hora "humanizada" cada 15 segundos (Antes estaba estatica al momento de cargarse).

	

