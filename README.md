# Kata-DecoratorPattern

**Kata 5: Mensajes de Log**

**Problema**

Crea un sistema para registrar mensajes de log con decoradores que agreguen información como la fecha, la hora y el nivel de severidad.

**Instrucciones**

1. Crea una interfaz Logger con un método log(String message).

2. Implementa una clase BasicLogger.

3. Crea decoradores como DateLogger, TimeLogger y SeverityLogger.

4. Combina decoradores para registrar mensajes con información adicional.

**Salida Esperada**

[2023-10-01] [10:00:00] [ERROR] Mensaje de error


**Kata 7: Generación de Reportes**

**Problema**

Crea un sistema para generar reportes con decoradores que agreguen encabezados, pies de página y marcas de agua.


**Instrucciones**

1. Crea una interfaz Report con un método generate().

2. Implementa una clase BasicReport.

3. Crea decoradores como HeaderDecorator, FooterDecorator y WatermarkDecorator.

4. Combina decoradores para generar reportes con múltiples elementos.


**Salida Esperada**

Encabezado: Reporte Anual  

Contenido: Datos del reporte  

Pie de página: Página 1  

Marca de agua: Confidencial
