# Rover API

## Potential Improvements

### Class: NavigationModule

- Some sort of regex validation for the command string would be useful
- Validation within the methods would also be useful i.e. a Move cannot be a Rotation command and vice versa

### Class: Coordinates

- The properties here have public setters, this could be removed if we implemented methods to modify them
  - Don't like the way I've implemented the min and max grid sizes in this class.  Makes it easy to break the unit tests, but started running out of time.  Will look at this again if the obstacle detection goes well :)

## Notes

- Realised at the end that implementing a return type from the `Move()` and `Rotate()` methods would have allowed me to test for obstacles a lot easier...
- In general, the implementation is quite messy and could be tidied up a lot, a couple of these would be:

    - Access modifiers should be a lot more restrictive
    - The domain classes should be refactored to stop any clients misusing them (i.e. the client could easily set the coordinates to a negative value, but the Coordinate value object should prevet this)