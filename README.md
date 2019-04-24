# sistemaACC-2D
Programa simulador 2D de un Sistema de Control de Crucero Adaptivo (ACC) para Autos, programado en Visual Basic con 4 escenarios posibles.
## Requerimientos
- Descargar [Visual Studio Community IDE 2019](https://visualstudio.microsoft.com/downloads/)
## Problema
![Demo](https://raw.githubusercontent.com/Yizack/sistemaACC-2D/master/problema.jpg)
Un vehículo (coche de ego) está equipado con control de crucero adaptable (ACC) cuenta
con un sensor (radar), que mide la distancia al vehículo precedente en el mismo carril
(coche principal), Drel, así como la velocidad relativa del vehículo principal, Vrel.
- El sistema ACC funciona en los 2 modos siguientes:
  - Control de velocidad: El coche de ego viaja a una velocidad de-conjunto.
  - Control de espacio: El coche de ego mantiene una distancia segura del coche
principal.
- El sistema ACC decide qué modo utilizar basados en mediciones de radar en tiempo real:
- Si el coche principal está demasiado cerca, el sistema ACC cambia de control de
velocidad a control de espacio.
- Si el coche principal está muy lejos, el sistema ACC cambia de control de espacio a
control de velocidad.
##
## Escenarios
| Escenario | Descripción
|---------|-------------|
| 1 | Un auto Principal se encuentra detenido en la carretera, llega el auto Ego y se detiene para evitar chocar. |
| 2 | Un auto Ego viaja rápidamente en el carril izquierdo, de repente un auto Principal se cruza por delante, y el auto Ego reacciona y reduce su velocidad para mentener una distancia segura. |
| 3 | Un auto Principal viaja lento mientras un auto Ego viaja rápidamente por el mismo carril detecta al auto Principal y reduce su velocidad para mantener una distancia segura. |
| 4 | Un auto Ego va viajando detrás de un auto Principal, de repente el auto Principal cambia de carril y entonces el auto Ego vuelve a su velocidad original. |
##
## Demo
![Demo](https://raw.githubusercontent.com/Yizack/sistemaACC-2D/master/demo.jpg)