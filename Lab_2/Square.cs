namespace Lab_2;

public class Square
{
    public int area;
    public int botX;
    public int botY;
    public int length;
    public int points;
    public int topX;
    public int topY;
    public int x;
    public int y;


    public Square(int indexX, int indexY, int indexLength, int indexPoints)
    {
        x = indexX;
        y = indexY;
        length = indexLength;
        points = indexPoints;
        area = length / 4 * (length / 4);
        botX = x - length / 2;
        botY = y - length / 2;
        topX = x + length / 2;
        topY = y + length / 2;
    }

    public bool Hit(int dotX, int dotY)
    {
        if (dotX > botX && dotX < topX &&
            dotY > botY && dotY < topY)
            return true;

        return false;
    }

    public double shapeScore()
    {
        double equationSquare = getShapeType() * points / area;
        return equationSquare;
    }

    public int getShapeType()
    {
        return 1;
    }
}