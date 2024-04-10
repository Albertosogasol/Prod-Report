README

Si se modifica la ruta de la base de datos principal es necesario cambiarla en:
	1. String dbSOurce
	2. Data Connections
	3. Project -> Properties -> Settings -> Connection String


Si se añade contraseña a la base de datos:
	1. La cadena de conexión es: dbSource = "Data Source=\\n054fp03\DocCompartido2\Producción\021.- Registro Produccion\DB\Static\Registro_Produccion.accdb;Persist Security Info=True;Jet OLEDB:Database Password=Alberto"
	2. Se añade en la propiedades del proyecto la contraseña. Project/Settings/ En el VALUE añadir los mismos datos que dBSource (añadiendo la línea de Password)