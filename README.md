# Clases_Objetos

**1.** 

Crear una clase **AlbumFotos** con un atributo privado **numeroDePaginas**.
También debe tener un método público **getCantidadPaginas** que devolverá el número de páginas.

El constructor predeterminado debe crear un álbum con 16 páginas. 
Con un constructor adicional, debemos especificar el número de páginas que queremos en el álbum.

Crear una clase **AlbumFotosGrande** cuyo constructor creará un álbum con 64 páginas.

Cree una clase de prueba **AlbumTest** (sería nuestro típico Program.cs) para crear *un álbum con su constructor predeterminado, uno con 24 páginas, un BigPhotoAlbum* y *mostrar la cantidad de páginas que tiene cada uno de los álbumes.*


---------------------

**2.**
Contador con objetos: 
Crear un clase Contador (contador de números), que tenga los métodos:

- incrementar(cantidad: Int)
- decrementar(cantidad: Int) 
- imprimirValorActual

Para lograr el incremento y decremento deberán utilizar una variable que guarde el valor del contador. 
El contador debe inicializarse con un valor propuesto por el usuario.

---------------------

**3.**

Crear un nuevo proyecto con tres clases más otra clase para probar la lógica. Las principales clases del programa son las siguientes clases:

-   Persona
-   Alumno
-   Profesor

La clase Alumno incluirá un método público `Estudiar()` que escribirá `Estoy estudiando` en la pantalla.

La clase Persona debe tener dos métodos públicos `Saludar()` y `SetearEdad(int edad)` que asignarán la edad de la persona.

La clase Profesor incluirá un método público `Explicar()` que escribirá `Estoy explicando` en la pantalla.

También cree un método público `MostrarEdad()` en la clase Alumno que escriba `Mi edad es: x años` en la pantalla.

Debes crear otra clase de prueba llamada Test con un método Main para hacer lo siguiente:

- Crea una nueva Persona y haz que te salude.
- Cree un nuevo estudiante, establezca una edad, salude y muestre su edad en la pantalla.
- Crea un nuevo Profesor, establece una edad, saluda y comienza la explicación.

---------------------

**4.**
Crear un programa en C# que implemente una interfaz IVehiculo con dos métodos, uno `Conducir:void` y otro para `CargarNafta` de tipo bool (TRUE=ya cargó combustible, puede seguir), que tenga un parámetro de tipo integer con la cantidad de gasolina a repostar. 

Luego, crear una clase Auto con un constructor que reciba un parámetro con la cantidad de gasolina inicial del automóvil e implemente los métodos  `Conducir`  y  `CargarNafta` de la interfaz.

El método Conducir() de Auto, mostrará en consola un mensaje y restará una unidad de combustible mientras que todavía sea positivo el valor (el auto tiene combustible). Cuando no tenga más, se avisa por consola.

---------------------