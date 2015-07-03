# webapi-forbidden
#### Blog: http://www.victorcornejo.com

Dia con dia las aplicaciones que consumen servicios de tipo WebApi crecen, y como desarrolladores estamos llamados a profundizar en el conocimiento del protocolo HTTP. Revisemos algunos conceptos muy utilices para el manejo del código 403 Forbidden.

Podemos partir diciendo que nuestra aplicación intercambia mensajes con el servidor Web, el cual tiene publicada la  API que consumimos; como resultado todos los mensajes son interpretados y validados para poder generar “Mensajes de respuesta HTTP”.

Todo mensaje de respuesta contiene una “Linea de Estatus” (Status-Line) que implementa un código numérico de 3 dígitos, con el objetivo de brindar una breve descripción del resultado luego de haber procesado nuestra petición.

Puedes encontrar mayores detalles sobre la estructura de estos mensajes de respuesta en el documento RFC2616 , que describe el uso del protocolo HTTP.

 
###Diferencia entre el Estatus “401 Unauthorized” y el “403 Forbidden”

Los códigos que inician con 4 , se utilizan para identificar errores generados por el cliente de forma voluntaria o involuntaria. Partiendo de esto debemos entender que el código 401 se genera cuando solicitamos un recurso al servidor web, pero no proporcionamos credenciales las cuales son REQUERIDAS para poder completar la petición. Mientras que el código 403  se genera cuando el servidor ha validado nuestras credenciales, el mensaje esta correctamente estructurado pero el recurso solicitado no esta permitido servirlo con el nivel de credenciales que hemos proporcionado.

Prácticamente el error 403 deberíamos presentarlo únicamente a los usuarios autenticados, pero que su nivel de acceso no le permite recibir el recurso solicitado.

Este pequeño detalle en el manejo de las respuestas que brinda nuestro Api puede impactar para bien o para mal en el nivel de “Usabilidad y Experiencia” que una aplicación brinda al usuario.

Es muy incomodo que cuando el usuario solicite un recurso y se genere un mensaje de error 403, sea enviado a la pantalla de login, sobre todo porque partimos del supuesto que nuestro usuario ya se había autenticado previamente,  de lo contrario el servidor hubiera respondido con el código 401.

Este comportamiento es muy común en muchas aplicaciones, situación que genera desconcierto en el usuario; el cual muchas veces cree que la aplicación esta fallando porque no se explica porque se le solicita que ingrese nuevamente sus credenciales.

Este comportamiento lo vemos presente en el proyecto de base que nos crea el Visual Studio cuando seleccionamos la construcción de un WebApi. Para nuestra suerte este comportamiento es muy fácil modificar, permitiendo que la comunicación con nuestros clientes sea mejor.

Dejame tus comentarios en mi blog.
