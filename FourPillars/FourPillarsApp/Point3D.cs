namespace FourPillarsApp;
public struct Point3D
{
    public int x, y, z;

    public Point3D(int x, int y, int z = 1) // gives z a default value of 1, if nothing for z is provided when calling the constructor
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double DistanceFromOrigin()
    {
        return Math.Sqrt(x * x + y * y + z * z);
    }
}

