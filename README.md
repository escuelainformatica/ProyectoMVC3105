# ProyectoMVC3105

Editar el archivo para usar MVC

## 1) Editar el archivo de configuración

En startup.cs editar el método **Configure** con las siguiente líneas

```c#
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
```
En startup.cs en el método **ConfigureService** agregar la siguiente lineal

```c#
services.AddControllersWithViews();
```

## 2) Como crear un controlador?

(opción) Crear una carpeta llamada **controller** (puede tener cualquier nombre)

Dentro de la carpeta, con el botón derecho (en la vista de solution explorer), crear un Controller.

Cree un controlador vacío (Controller Empty)

El Controlador es una clase, así que debe iniciar en mayúscula. Además, el controlador tiene que terminar con el post-fijo Controller.

## 3) Crear una acción en el controlador

Dentro del controlador, crear métodos de la siguiente manera.

```c#
    public IActionResult Index()
    {
        return View();
    }
```
Donde **Index** es el nombre de la ruta que el cliente va a usar para llamar al código.

## 4) Crear una vista.

Dentro de la acción, con el botón derecho encima de la vista, cree una vista nueva. La vista a crear debe tener el mismo nombre que el metodo.











