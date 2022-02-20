namespace Lab_2;

public class Circle
{
    public double area;
    public int length;
    public int points;
    public double rad;
    public int x;
    public int y;

    public Circle(int x, int y, int length, int points)
    {
        this.x = x;
        this.y = y;
        this.length = length;
        this.points = points;
        rad = this.length / (Math.PI * 2);
        area = this.length * this.length / (Math.PI * 4);
    }

    public bool Hit(int dotX, int dotY)
    {
        if ((dotY - x) * (dotX - x) +
            (dotY - y) * (dotY - y) <= rad * rad)
            return true;

        return false;
    }

    public double shapeScore()
    {
        var equationCircle = getShapeType() * points / area;
        return equationCircle;
    }

    public int getShapeType()
    {
        return 2;
    }
}