# Proyecto 4
> [!IMPORTANT]
> PARA AUDITORES: Se hizo un archivo .env(variables de entorno) y la conexion con BD
<ul>
    <li>Borrar el .env que se les genera al momento de darle git clone y volverlo a crear</li>
    <li>Se necesita ir a la consola NuGet (en Herramientas > Administrador de paquetes NuGet > Consola)</li>
    <li>luego ejecuta estos comandos uno por uno</li>
    <li>Comando para variables de entorno: Install-Package dotenv.net</li>
    <li>Comando para MySQL Server: Install-Package MySql.Data -Version 8.0.33</li>
</ul>

> [!TIP]
> Para generar nuevo archivo .env
<ul>
    <li>Darle click derecho a la solucion en VS > Agregar > nuevo elemento > escribir: <b>.env</b> > agregar nuevo elemento</li>
    <li>Dentro de ese archivo .env se coloca lo siguiente: </li>

    # Este archivo sirve para que la conexion de BD no crea problemas con sus maquinas
    DB_SERVER=127.0.0.1		#localhost o 127.0.0.1
    DB_PORT=3306			#puerto donde tengan MySQL Server
    DB_USER=ESCM			#root
    DB_PASSWORD=escm1823	#contraseña MySQL
    DB_NAME=RentaDeVideos	#nombre de la BD
</ul>

# Grupo 3
<ul>
    <li>Edwin Stevens Cambranes Mendizábal 0901-22-940</li>
    <li>Bryan Raúl Ramirez López 0901-21-8202</li>
    <li>Diego Fernando Saquil Gramajo 0901-22-4103</li>
    <li>Juan Carlos Sandoval Quej 0901-22-4170</li>
    <li>Nelson Jose Godinez Mendez 0901-22-3350</li>
</ul>
