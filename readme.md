# Rover API

## Potential Improvements

### Class: NavigationModule

- Within the `Move()` and `Rotate()` methods the `startPosition` is set to equal the `CurrentPosition` property.  I dont like this for 2 reasons: firstly it doesnt read very well, secondly it is a side effect of the method
- 