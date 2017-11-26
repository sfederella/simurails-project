<h1 align="center">
  <br>
  <img src="https://github.com/sfederella/simurails-project/blob/master/Desarrollo/SimuRails/Resources/Logo.png" alt="SimuRails" width="200">
  <br>
  SimuRails
  <br>
</h1>

### ¿Qué es?

SimuRails es un software desarrollado en el marco de la materia Proyecto Final en la Universidad Tecnológica Nacional en el año 2017. Tiene como objetivo realizar simulaciones de trazas ferroviarias y de subtes. Se ha empezado a utilizar la palabra simulación sin haber dado previamente una definición de ella. Por consiguiente, antes de proseguir con los detalles del software, sería conveniente describir la definición de la palabra simulación:

>La simulación es una técnica que permite construir modelos de un sistema real y operarlos (realizar experimentos) en hipotéticas condiciones exteriores con el objetivo de predecir el comportamiento esperado del sistema real a partir de la información generada en el modelo. El objetivo de la simulación es la obtención de información decisoria que permita mejorar la predicción implícita en toda decisión.

Entonces ¿qué hace SimuRails? Permite modelar escenarios basados en la realidad, y simular el funcionamiento de distintos servicios ferroviarios y obtener resultados para poder ajustar la configuración y así obtener una mejor calidad de servicio.

### ¿Cómo está hecho?

La aplicación fue construida como una aplicación monocapa desktop, ya que fue diseñada para que pueda ser portable e independiente de internet. Posee una base de datos SQLite embebida que está incluida en el instalador. Fue construida en C# y para el frontend se utilizó el framework Material Design. La decisión de utilizar C# se justifica en que la primera versión de la aplicación fue realizada en el año 2015 por otro equipo de desarrollo y dicha versión se puede acceder [aquí.](https://github.com/jonathanvgms/ffccsimulacion)

### Instalación

Para instalar la aplicación hay que bajarse el siguiente [.rar](Resources/SimuRails.rar), descomprimirlo y ejecutar el instalador. Luego de finalizar la instalación, se podrá iniciar la aplicación mediante el acceso directo creado en el escritorio o mediante el menú de windows, en la carpeta UTN Frba, SimuRails.
<p align="center">
  <img src="https://raw.githubusercontent.com/sfederella/simurails-project/master/Resources/Demo-Instalacion.gif" alt="Instalación">
</p>

Para probar el software se puede importar la siguiente [traza de ejemplo.](Resources/Mitre.sr)

### Documentación

En el siguiente enlace de drive, se puede acceder a toda la documentación elaborada acerca del software: <insertar drive>
El manual de usuario puede accederse desde la app
<p align="center">
  <img src="https://raw.githubusercontent.com/sfederella/simurails-project/master/Resources/Demo-Manual.gif" alt="Manual">
</p>

### Aspectos a mejorar

Dentro de puntos que quedaron fuera del alcance, los siguientes son los que a nuestro criterio deberían ser corregidos para que la aplicación pueda dar el salto de calidad requerido para que pueda ser utilizado a nivel profesional:
+ Ajustar el modelo para que las funciones de densidad de probabilidad (a partir de ahora fdp) que definen la cantidad de personas que están esperando en cada estación sean dependientes de la hora del día. Actualmente están desglosadas por estación, pero se mantiene la misma función para las 24 horas del día, lo cual no se condiciona con la realidad (horas pico).
+ Ajustar el modelo para que las fpd mencionadas en el punto anterior tengan una correlación entre sí. Por ejemplo: si una formación arriba a la estación a la hora 12:00:00 y la fdp determina que hay 50 personas esperando en el andén y todas suben a la formación, y 10 segundos después de partir (12:00:10) llega una nueva formación a la estación, la fdp no debería volver a dar como resultado un número cercano a 50 personas esperando por subir, sino uno considerablemente menor.
+ Agregar al modelo pasos de nivel, que conceptualmente funcionan igual que estaciones pero que no pueden ascender ni descender pasajeros y donde el tiempo de atención de la formación es 0.

### Agradecimientos

Queremos agradecer quienes nos brindaron la ayuda necesaria para que podamos llevar a cabo el proyecto.

+ Cátedra de Simulación (UTN FRBA) 
    + Milin Erica
    + Alfiero Gladys
    + Quiroga Silvia
    + Martel Hernan
+ Proyecto Final (UTN FRBA)
    + Eribe Roberto
+ Creadores de la primera versión (UTN FRBA)
    + Velazquez Jonathan
    + Fernandez Facundo
    + Vazquez Leandro Ariel
    + Echerdt Mauro
    + Coacci Pablo
