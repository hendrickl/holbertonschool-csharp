using System;

// Represents a geometric shape
class Shape
{
    /// <summary>
    /// Calculates the area of the shape.
    /// </summary>
    /// <returns>The area of the shape.</returns>
    /// <exception cref="NotImplementedException">Thrown when the method is not implemented in a derived class.</exception>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

// Represents a rectangle shape
class Rectangle : Shape
{
    // The width of the rectangle
    private int width;

    // The height of the rectangle
    private int height;

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the width is set to a value less than 0.</exception>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the height is set to a value less than 0.</exception>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle.</returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Returns a string representation of the rectangle.
    /// </summary>
    /// <returns>A string in the format "[Rectangle] width / height".</returns>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}

// Represents a square, which is a special case of a rectangle where all sides are equal. Inherits from the Rectangle class.
class Square : Rectangle
{
    // Size of the square
    private int size;

    /// <summary>
    /// Gets or sets the size of the square.
    /// Setting the size updates both width and height to maintain square dimensions.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the size is less than 0.</exception>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                size = value;
                Width = value;
                Height = value;
            }
        }
    }

    /// <summary>
    /// Returns a string representation of the rectangle.
    /// </summary>
    /// <returns>A string in the format "[Square] size / size".</returns>
    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    }
}