﻿namespace WebApplication1;
public class Triangle
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
        Validate();
    }
    private void Validate()
    {
        if (_firstSide <= 0)
            throw new ArgumentOutOfRangeException(nameof(_firstSide), "first side value is negative or 0");
        if (_secondSide <= 0)
            throw new ArgumentOutOfRangeException(nameof(_secondSide), "second side value is negative or 0");
        if (_thirdSide <= 0)
            throw new ArgumentOutOfRangeException(nameof(_thirdSide), "third side value is negative or 0");
        TriangleInequalityCheckForAllSides();
    }
    private void TriangleInequalityCheckForAllSides()
    {
        TriangleInequalityCheckForSpecificSide(_firstSide, _secondSide, _thirdSide);
        TriangleInequalityCheckForSpecificSide(_secondSide, _firstSide, _thirdSide);
        TriangleInequalityCheckForSpecificSide(_thirdSide, _secondSide, _firstSide);
    }
    private void TriangleInequalityCheckForSpecificSide(double testSide, double leftSide, double rightSide)
    {
        if (testSide >= leftSide + rightSide)
            throw new ArgumentOutOfRangeException(nameof(testSide), "side value is too big (the triangle inequality is not satisfied)");
    }
    public double GetArea()
    {
        double semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _firstSide) * (semiPerimeter - _secondSide) * (semiPerimeter - _thirdSide));
    }
}
