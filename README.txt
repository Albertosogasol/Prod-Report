README

Si se modifica la ruta de la base de datos principal es necesario cambiarla en:
	1. String dbSOurce
	2. Data Connections
	3. Project -> Properties -> Settings -> Connection String


Si se a�ade contrase�a a la base de datos:
	1. La cadena de conexi�n es: dbSource = "Data Source=\\n054fp03\DocCompartido2\Producci�n\021.- Registro Produccion\DB\Static\Registro_Produccion.accdb;Persist Security Info=True;Jet OLEDB:Database Password=Alberto"
	2. Se a�ade en la propiedades del proyecto la contrase�a. Project/Settings/ En el VALUE a�adir los mismos datos que dBSource (a�adiendo la l�nea de Password)