# Rover API

## Potential Improvements

### Class: NavigationModule

- Within the `Move()` and `Rotate()` methods the `startPosition` is set to equal the `CurrentPosition` property.  I dont like this for 2 reasons: firstly it doesnt read very well, secondly it is a side effect of the method

### Class: Coordinates

- The properties here have public setters, this could be removed if we implemented methods to modify them
  - Don't like the way I've implemented the min and max grid sizes in this class.  Makes it easy to break the unit tests, but started running out time.  Will look at this again if the obstacle detection goes well :)
