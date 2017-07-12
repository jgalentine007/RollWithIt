using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Collections.Generic;

namespace Pacem.Media.Media3D
{
    public class Box : Primitive3D
    {

        public Box(double width, double height, double depth)
            : base(false)
        {
            w = width;
            h = height;
            d = depth;
            Render();
        }

        private double w = 1D;
        private double h = 1D;
        private double d = 1D;

        protected override Geometry3D Tessellate()
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            Point3D A = new Point3D(- w/2,- h/2,- d/2);
            Point3D B = new Point3D( w/2,- h/2,- d/2);
            Point3D C = new Point3D( w/2, h/2,- d/2);
            Point3D D = new Point3D(- w/2, h/2,- d/2);
            Point3D E = new Point3D(- w/2,- h/2, d/2);
            Point3D F = new Point3D( w/2,- h/2, d/2);
            Point3D G = new Point3D( w/2, h/2, d/2);
            Point3D H = new Point3D(-w / 2, h / 2, d / 2);

            List<Point3D> poly1 = new List<Point3D>(4);
            poly1.AddRange(new Point3D[] { Utils.Point3DClone(A), Utils.Point3DClone(B), Utils.Point3DClone(C), Utils.Point3DClone(D) });
            List<Point3D> poly2 = new List<Point3D>(4);
            poly2.AddRange(new Point3D[] { Utils.Point3DClone(E), Utils.Point3DClone(F), Utils.Point3DClone(B), Utils.Point3DClone(A) });
            List<Point3D> poly3 = new List<Point3D>(4);
            poly3.AddRange(new Point3D[] { Utils.Point3DClone(D), Utils.Point3DClone(C), Utils.Point3DClone(G), Utils.Point3DClone(H) });
            List<Point3D> poly4 = new List<Point3D>(4);
            poly4.AddRange(new Point3D[] { Utils.Point3DClone(E), Utils.Point3DClone(A), Utils.Point3DClone(D), Utils.Point3DClone(H) });
            List<Point3D> poly5 = new List<Point3D>(4);
            poly5.AddRange(new Point3D[] { Utils.Point3DClone(B), Utils.Point3DClone(F), Utils.Point3DClone(G), Utils.Point3DClone(C) });
            List<Point3D> poly6 = new List<Point3D>(4);
            poly6.AddRange(new Point3D[] { Utils.Point3DClone(H), Utils.Point3DClone(G), Utils.Point3DClone(F), Utils.Point3DClone(E) });


            List<Polygon3D> faces = new List<Polygon3D>(6);
            faces.Add(new Polygon3D(poly1));
            faces.Add(new Polygon3D(poly2));
            faces.Add(new Polygon3D(poly3));
            faces.Add(new Polygon3D(poly4));
            faces.Add(new Polygon3D(poly5));
            faces.Add(new Polygon3D(poly6));

            int counter = 0;
            for (int j=0; j<faces.Count; j++){
                for (int k = 0; k < faces[j].Positions.Length; k++)
                {
                    mesh.Positions.Add(faces[j].Positions[k]);
                }
                int[] indices = faces[j].GetTriangleIndices();
                for (int k = 0; k < indices.Length; k++)
                {
                    mesh.TriangleIndices.Add(indices[k] + counter);
                }
                counter += faces[j].Positions.Length;
            }

            mesh.Freeze();
            return mesh;

        }
    }

    public class Hexahedron : Box
    {
        public Hexahedron(double radius)
            : base(2D * radius / Math.Sqrt(3D), 2D * radius / Math.Sqrt(3D), 2D * radius / Math.Sqrt(3D))
        {

        }

        public Hexahedron()
            : base(2D / Math.Sqrt(3D), 2D / Math.Sqrt(3D), 2D / Math.Sqrt(3D))
        {

        }
    }
}
