# Mobile Mixed Reality Playable City Prototype
> This repository contains a mobile mixed reality playable city prototype, which has been created to explore user perceptions in the context study.

## Deployment
This repository can be used to create two applications for the Meta Quest 3: one is the prototype itself, and the other is a technology acquaintance application.

### Prototype
To build the prototype application, no changes to the scenes' initial hierarchy need to be applied.

### Technology Acquaintance
To build the technology acquaintance application, the following GameObjects in the hierarchy must be **disabled**:

- ScenarioCollection
- ScenarioSOCLayer
- Adjustment_Point_1
- Adjustment_Point_2

And the following GameObject must be **enabled**:

- deviceAcquaintance

## Prototype Use
The prototype is designed to be placed in the old town of St. Gallen. It contains two cubes used to align its position relative to the Vadian statue. The cubes can be **disabled** by pressing the "B" button on the Quest 3 controller.  

Additionally, the entire scene can be **moved** by pressing the "X" button while using the right controller's "A" button, "B" button, and joystick to control movement.

## Additional Sources
To implement the drawing feature within the prototype, the following script was used:  
https://realary.com/resources
