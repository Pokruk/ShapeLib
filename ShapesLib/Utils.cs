namespace ShapesLib.Example; 

public class Utils {
    public static double CalculateAreaSum(IShape[] shapes) {
        var res = 0d;
        foreach (var shape in shapes) {
            res += shape.GetArea();
        }

        return res;
    }
}