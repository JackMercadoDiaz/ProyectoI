# Sistema de Reservas - API Restaurante

**Proyecto I - EIF 204 Programación II**  
Universidad Nacional de Costa Rica - Sede Regional Chorotega, Campus Nicoya  
I Ciclo 2026

---

## Descripción

API REST desarrollada en ASP.NET Core para la gestión de reservas y operaciones de un 
restaurante. El sistema maneja la estructura física del local (secciones, zonas, mesas), 
clientes, reservas con validaciones de negocio, bloqueos temporales de mesas o zonas, 
horarios habilitados y lista de espera.

---

## Equipo de desarrollo

- Jack Mercado Díaz
- Randy Grijalba Gutiérrez
- Andrid Marín Fajardo
- Génesis Villareal Granados
- Kendall Rosales Gutiérrez

**Docente:** Lawrence Fowks Peña

---

## Tecnologías utilizadas

- **Framework:** ASP.NET Core
- **ORM:** Entity Framework Core (InMemory Database)
- **Lenguaje:** C#
- **Pruebas:** Postman
- **Documentación:** LaTeX

---

## Entidades del modelo

El sistema maneja 8 entidades principales con sus relaciones:

- **Sección** → estructura física mayor (Planta Alta, Planta Baja)
- **Zona** → agrupación dentro de cada sección (Interior, Exterior, VIP)
- **Mesa** → unidad mínima de reserva con capacidad y estado
- **Cliente** → datos de contacto del cliente
- **Horario** → turnos habilitados del restaurante
- **Reserva** → asignación de mesa a cliente en fecha y horario
- **Bloqueo** → periodos donde una mesa o zona queda fuera de servicio
- **Lista de Espera** → cola de espera cuando no hay mesas disponibles

---

## Licencia

Proyecto académico desarrollado para EIF 204 Programación II.
