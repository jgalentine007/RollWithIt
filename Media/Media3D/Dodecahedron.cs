using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Collections.Generic;

namespace Pacem.Media.Media3D
{
    public class Dodecahedron : Primitive3D
    {

        public Dodecahedron(double radius)
            : base(radius)
        {
        }

        public Dodecahedron()
            : base(1D)
        {
        }

        protected override Geometry3D Tessellate(double radius)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            Point3D n1 = new Point3D(0.356822 * radius, 0 * radius, 0.934172 * radius);
            Point3D n2 = new Point3D(-0.356822 * radius, 0 * radius, 0.934172 * radius);
            Point3D n3 = new Point3D(0.57735 * radius, 0.57735 * radius, 0.57735 * radius);
            Point3D n4 = new Point3D(0 * radius, 0.934172 * radius, 0.356822 * radius);
            Point3D n5 = new Point3D(-0.57735 * radius, 0.57735 * radius, 0.57735 * radius);
            Point3D n6 = new Point3D(-0.57735 * radius, -0.57735 * radius, 0.57735 * radius);
            Point3D n7 = new Point3D(0 * radius, -0.934172 * radius, 0.356822 * radius);
            Point3D n8 = new Point3D(0.57735 * radius, -0.57735 * radius, 0.57735 * radius);
            Point3D n9 = new Point3D(0.934172 * radius, 0.356822 * radius, 0 * radius);
            Point3D n10 = new Point3D(0.934172 * radius, -0.356822 * radius, 0 * radius);
            Point3D n11 = new Point3D(0 * radius, -0.934172 * radius, -0.356822 * radius);
            Point3D n12 = new Point3D(0.57735 * radius, -0.57735 * radius, -0.57735 * radius);
            Point3D n13 = new Point3D(0.57735 * radius, 0.57735 * radius, -0.57735 * radius);
            Point3D n14 = new Point3D(0.356822 * radius, 0 * radius, -0.934172 * radius);
            Point3D n15 = new Point3D(-0.57735 * radius, -0.57735 * radius, -0.57735 * radius);
            Point3D n16 = new Point3D(-0.356822 * radius, 0 * radius, -0.934172 * radius);
            Point3D n17 = new Point3D(0 * radius, 0.934172 * radius, -0.356822 * radius);
            Point3D n18 = new Point3D(-0.57735 * radius, 0.57735 * radius, -0.57735 * radius);
            Point3D n19 = new Point3D(-0.934172 * radius, -0.356822 * radius, 0 * radius);
            Point3D n20 = new Point3D(-0.934172 * radius, 0.356822 * radius, 0 * radius);

            List<Point3D> poly1 = new List<Point3D>(5);
            List<Point3D> poly2 = new List<Point3D>(5);
            List<Point3D> poly3 = new List<Point3D>(5);
            List<Point3D> poly4 = new List<Point3D>(5);
            List<Point3D> poly5 = new List<Point3D>(5);
            List<Point3D> poly6 = new List<Point3D>(5);
            List<Point3D> poly7 = new List<Point3D>(5);
            List<Point3D> poly8 = new List<Point3D>(5);
            List<Point3D> poly9 = new List<Point3D>(5);
            List<Point3D> poly10 = new List<Point3D>(5);
            List<Point3D> poly11 = new List<Point3D>(5);
            List<Point3D> poly12 = new List<Point3D>(5);

            poly1.Add(n4);  poly1.Add(n3); poly1.Add(n1); poly1.Add(n2); poly1.Add(n5);
            poly2.Add(n7);  poly2.Add(n6);  poly2.Add(n2);  poly2.Add(n1); poly2.Add(n8);
            poly3.Add(n9);  poly3.Add(n10);  poly3.Add(n8);  poly3.Add(n1);  poly3.Add(n3);
            poly4.Add(n11);  poly4.Add(n7);  poly4.Add(n8);  poly4.Add(n10);   poly4.Add(n12);
            poly5.Add(n13);  poly5.Add(n14);  poly5.Add(n12);  poly5.Add(n10);  poly5.Add(n9);
            poly6.Add(n15);  poly6.Add(n11);  poly6.Add(n12);  poly6.Add(n14);  poly6.Add(n16);
            poly7.Add(n17);  poly7.Add(n18);  poly7.Add(n16);  poly7.Add(n14);  poly7.Add(n13);
            poly8.Add(n19);  poly8.Add(n15);  poly8.Add(n16);  poly8.Add(n18);  poly8.Add(n20); 
            poly9.Add(n4);  poly9.Add(n5);  poly9.Add(n20);  poly9.Add(n18);  poly9.Add(n17);
            poly10.Add(n6);  poly10.Add(n19);  poly10.Add(n20);  poly10.Add(n5);  poly10.Add(n2);
            poly11.Add(n11);  poly11.Add(n15);  poly11.Add(n19);  poly11.Add(n6);  poly11.Add(n7);
            poly12.Add(n9);  poly12.Add(n3);  poly12.Add(n4); poly12.Add(n17); poly12.Add(n13); 

        
            List<Polygon3D> faces = new List<Polygon3D>(12);
            faces.Add(new Polygon3D(poly1));
            faces.Add(new Polygon3D(poly2));
            faces.Add(new Polygon3D(poly3));
            faces.Add(new Polygon3D(poly4));
            faces.Add(new Polygon3D(poly5));
            faces.Add(new Polygon3D(poly6));
            faces.Add(new Polygon3D(poly7));
            faces.Add(new Polygon3D(poly8));
            faces.Add(new Polygon3D(poly9));
            faces.Add(new Polygon3D(poly10));
            faces.Add(new Polygon3D(poly11));
            faces.Add(new Polygon3D(poly12));

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
}
