He creado la API en .NET CORE, he usado entity framework core para crear una BBDD in memory, 
por hacer algo diferente. He aislado todo lo relacionado con ella en una clase.
Algo parecido a un singleton privatizando el contructor pero sin hacerlo estático ya que no es necesario 
debido a que internamente ya almacena los datos aun habiendo terminado el ciclo de vida del controlador.
He creado una clase modelo, con metaetiquetas y un controlador que realiza las funciones de CRUD sobre User 
con algunas diferencias a lo pedido. Basta con poner en la url: /api/users para acceder al controlador,
al ser una api restful, no necesita indicarle la acción (getall, get…) porque ya se incluye en el tipo
de petición http con el method.
Por ahora he decidido no tratar excepciones, así nos aseguramos que los clientes vigilen errores 500 jeje,
aunque si sería bueno incluirlos.

Si se cuelga sobre un IIS(no local) no olvide habilitar las cabeceras put y delete, de lo contrario no serán accesibles.

PD: a vuestra página corporativa le falla la redirección cuando la llamas sin www.
Gracias y un saludo.