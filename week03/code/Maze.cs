/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        // Get the current position
        var currentPos = (_currX, _currY);
        
        // Check if current position exists in maze map
        if (!_mazeMap.ContainsKey(currentPos))
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        // Get the movement directions for current position
        // Array format: [left, right, up, down]
        bool[] directions = _mazeMap[currentPos];
        bool canMoveLeft = directions[0];
        
        // Check if we can move left
        if (!canMoveLeft)
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        // Move left (decrease x coordinate)
        _currX--;
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        // Get the current position
        var currentPos = (_currX, _currY);
        
        // Check if current position exists in maze map
        if (!_mazeMap.ContainsKey(currentPos))
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        // Get the movement directions for current position
        // Array format: [left, right, up, down]
        bool[] directions = _mazeMap[currentPos];
        bool canMoveRight = directions[1];
        
        // Check if we can move right
        if (!canMoveRight)
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        // Move right (increase x coordinate)
        _currX++;
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        // Get the current position
        var currentPos = (_currX, _currY);
        
        // Check if current position exists in maze map
        if (!_mazeMap.ContainsKey(currentPos))
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        // Get the movement directions for current position
        // Array format: [left, right, up, down]
        bool[] directions = _mazeMap[currentPos];
        bool canMoveUp = directions[2];
        
        // Check if we can move up
        if (!canMoveUp)
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        // Move up (decrease y coordinate)
        _currY--;
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        // Get the current position
        var currentPos = (_currX, _currY);
        
        // Check if current position exists in maze map
        if (!_mazeMap.ContainsKey(currentPos))
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        // Get the movement directions for current position
        // Array format: [left, right, up, down]
        bool[] directions = _mazeMap[currentPos];
        bool canMoveDown = directions[3];
        
        // Check if we can move down
        if (!canMoveDown)
        {
            throw new InvalidOperationException("Can't go that way!");
        }
        
        // Move down (increase y coordinate)
        _currY++;
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}