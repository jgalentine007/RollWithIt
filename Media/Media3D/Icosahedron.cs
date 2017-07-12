using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Collections.Generic;

namespace Pacem.Media.Media3D
{
    public class Icosahedron : Primitive3D
    {

        public Icosahedron(double radius)
            : base(radius)
        {
        }

        public Icosahedron()
            : base(1D)
        {
        }

        protected override Geometry3D Tessellate(double radius)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            Point3D n1 = new Point3D(0* radius,0.525732* radius,0.85065* radius);
            Point3D n2 = new Point3D(0* radius,-0.525732* radius,0.85065* radius);
            Point3D n3 = new Point3D(0.85065* radius,0* radius,0.525732* radius);
            Point3D n4 = new Point3D(0.525732* radius,0.85065* radius,0* radius);
            Point3D n5 = new Point3D(-0.525732* radius,0.85065* radius,0* radius);
            Point3D n6 = new Point3D(-0.85065* radius,0* radius,0.525732* radius);
            Point3D n7 = new Point3D(-0.525732* radius,-0.85065* radius,0* radius);
            Point3D n8 = new Point3D(0.525732* radius,-0.85065* radius,0* radius);
            Point3D n9 = new Point3D(0.85065* radius,0* radius,-0.525732* radius);
            Point3D n10 = new Point3D(0* radius,-0.525732* radius,-0.85065* radius);
            Point3D n11 = new Point3D(0* radius,0.525732* radius,-0.85065* radius);
            Point3D n12 = new Point3D(-0.85065* radius,0* radius,-0.525732* radius);

            List<Point3D> poly1 = new List<Point3D>(3);
            List<Point3D> poly2 = new List<Point3D>(3);
            List<Point3D> poly3 = new List<Point3D>(3);
            List<Point3D> poly4 = new List<Point3D>(3);
            List<Point3D> poly5 = new List<Point3D>(3);
            List<Point3D> poly6 = new List<Point3D>(3);
            List<Point3D> poly7 = new List<Point3D>(3);
            List<Point3D> poly8 = new List<Point3D>(3);
            List<Point3D> poly9 = new List<Point3D>(3);
            List<Point3D> poly10 = new List<Point3D>(3);
            List<Point3D> poly11 = new List<Point3D>(3);
            List<Point3D> poly12 = new List<Point3D>(3);
            List<Point3D> poly13 = new List<Point3D>(3);
            List<Point3D> poly14 = new List<Point3D>(3);
            List<Point3D> poly15 = new List<Point3D>(3);
            List<Point3D> poly16 = new List<Point3D>(3);
            List<Point3D> poly17 = new List<Point3D>(3);
            List<Point3D> poly18 = new List<Point3D>(3);
            List<Point3D> poly19 = new List<Point3D>(3);
            List<Point3D> poly20 = new List<Point3D>(3);

            poly1.Add( n1);  poly1.Add( n3);  poly1.Add( n2); 
            poly2.Add( n1);  poly2.Add( n4);  poly2.Add( n3); 
            poly3.Add( n1);  poly3.Add( n5);  poly3.Add( n4); 
            poly4.Add( n1);  poly4.Add( n6);  poly4.Add( n5); 
            poly5.Add( n1);  poly5.Add( n2);  poly5.Add( n6); 
            poly6.Add( n2);  poly6.Add( n7);  poly6.Add( n6); 
            poly7.Add( n2);  poly7.Add( n8);  poly7.Add( n7); 
            poly8.Add( n2);  poly8.Add( n3);  poly8.Add( n8); 
            poly9.Add( n4);  poly9.Add( n9);  poly9.Add( n3); 
            poly10.Add( n9);  poly10.Add( n8);  poly10.Add( n3); 
            poly11.Add( n8);  poly11.Add( n10);  poly11.Add( n7); 
            poly12.Add( n8);  poly12.Add( n9);  poly12.Add( n10); 
            poly13.Add( n4);  poly13.Add( n11);  poly13.Add( n9); 
            poly14.Add( n11);  poly14.Add( n10);  poly14.Add( n9); 
            poly15.Add( n10);  poly15.Add( n12);  poly15.Add( n7); 
            poly16.Add( n10);  poly16.Add( n11);  poly16.Add( n12); 
            poly17.Add( n4);  poly17.Add( n5);  poly17.Add( n11); 
            poly18.Add( n5);  poly18.Add( n12);  poly18.Add( n11); 
            poly19.Add( n12);  poly19.Add( n6);  poly19.Add( n7);
            poly20.Add(n12); poly20.Add(n5); poly20.Add(n6);


            List<Polygon3D> faces = new List<Polygon3D>(20);
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
            faces.Add(new Polygon3D(poly13));
            faces.Add(new Polygon3D(poly14));
            faces.Add(new Polygon3D(poly15));
            faces.Add(new Polygon3D(poly16));
            faces.Add(new Polygon3D(poly17));
            faces.Add(new Polygon3D(poly18));
            faces.Add(new Polygon3D(poly19));
            faces.Add(new Polygon3D(poly20));

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
