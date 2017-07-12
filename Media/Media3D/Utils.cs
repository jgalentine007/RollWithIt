using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Pacem.Media.Media3D
{
    internal static class Utils
    {

        internal static Point3D Point3DClone(Point3D point){
            return new Point3D(point.X, point.Y, point.Z);
        }

    }
}
