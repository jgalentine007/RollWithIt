using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Collections.Generic;

namespace Pacem.Media.Media3D
{
    public class Polygon3D
    {
        public Polygon3D(List<Point3D> vertices)
        {
            positions = new Point3D[vertices.Count];
            for (int j = 0; j < vertices.Count; j++)
            {
                positions[j] = vertices[j];
            }
        }

        private Point3D[] positions = null;
        public Point3D[] Positions
        {
            get { return positions; }
            set {
                positions = value; 
            }
        }

        public int[] GetTriangleIndices()
        {
            int[] ret = new int[3 * (positions.Length - 2)];
            int ndx = 0;
            while (ret[ret.Length-1] == 0)
            {
                int mod = ndx % 3;
                if (mod == 0) ret[ndx] = 0;
                else ret[ndx] = (int)Math.Floor((double)ndx / 3D) + (ndx % 3);
                ndx++;
            }
            return ret;
        }

    }
}
