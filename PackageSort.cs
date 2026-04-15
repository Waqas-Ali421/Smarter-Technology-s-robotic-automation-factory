public class PackageSort
{
    public static string Sort(double width, double height, double length, double mass)
    {
        bool bulky = width * height * length >= 1_000_000
                     || width >= 150 || height >= 150 || length >= 150;
        bool heavy = mass >= 20;

        if (bulky && heavy) return "REJECTED";
        if (bulky || heavy) return "SPECIAL";
        return "STANDARD";
    }
}
