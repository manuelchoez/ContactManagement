# Agenda de Contactos - Proyecto en C# con .NET 9

Este proyecto es una **aplicación de consola limpia y moderna en C# y .Net 9** que permite gestionar una agenda de contactos (crear, listar, editar, buscar y eliminar). 
Se ha desarrollado siguiendo buenas prácticas de diseño de software como **inmutabilidad**, **inyección de dependencias**, **separación por capas** y uso de características avanzadas de C#.

---

## Tecnologías y herramientas utilizadas

- ✅ **.NET Core 9** 
- ✅ **C# 9+**
- ✅ Programación funcional con `record`, `init`, `with`
- ✅ Inyección de dependencias (DI) moderna con `HostBuilder`
- ✅ Arquitectura por capas (Modelos, Interfaces, Servicios)
- ✅ Prácticas orientadas a Clean Code y SOLID

---

## Funcionalidades principales

- Agregar nuevos contactos
- Listar todos los contactos
- Buscar contacto por nombre
- Editar un contacto
- Eliminar un contacto
- Flujo de consola simple y claro

---

## Conceptos y habilidades demostradas

| Habilidad                  | Aplicación en el proyecto                     |
|---------------------------|-----------------------------------------------|
| `record`                  | Representación inmutable de `Contacto`        |
| `init`                    | Evita mutación accidental de propiedades      |
| `with`                    | Actualización funcional de objetos            |
| Inyección de dependencias | Configuración con `Host.CreateDefaultBuilder` |
| Programación orientada a interfaces | Uso de `IContactoService`                  |
| Arquitectura limpia       | Separación de responsabilidades por capas     |
| Uso de consola moderna    | Top-level statements y menú interactivo       |

---

## Estructura del proyecto

```
AgendaContactos/
├── Models/
│   └── Contacto.cs
├── Services/
│   ├── Interfaces/
│   │   └── IContactoService.cs
│   └── Implementations/
│       └── ContactoService.cs
├── Composition/
│   └── DependencyInjection.cs
├── Program.cs
└── README.md
```

---

## Ejecución del proyecto

1. Clona el repositorio:

```bash
git clone https://github.com/manuelchoez/ContactManagement.git
cd ContactManagemet.Cli
```

2. Ejecuta el proyecto:

```bash
dotnet run
```

---

## Extensiones futuras 

- 🔃 Persistencia en archivo JSON o base de datos
- 🌐 Migración a API Web con ASP.NET Core
- 🧪 Pruebas unitarias con xUnit y Moq
- 🧩 Interfaz gráfica 
- 🔐 Validación y manejo de errores con FluentValidation

---

## Autor

**Manuel Choez**  
[GitHub](https://github.com/manuelchoez) | [LinkedIn](www.linkedin.com/in/tchoez)
