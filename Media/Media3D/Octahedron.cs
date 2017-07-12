using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Pacem.Media.Media3D
{
    public class Octahedron : Primitive3D
    {

        public Octahedron(double radius)
            : base(radius)
        {
        }

        public Octahedron()
            : base(1D)
        {
        }

        protected override Geometry3D Tessellate(double radius)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            Point3D A = new Point3D(0 * radius,0.707106* radius,0.707106* radius);
            Point3D B = new Point3D(0* radius,-0.707106* radius,0.707106* radius);
            Point3D C = new Point3D(1* radius,0* radius,0* radius);
            Point3D D = new Point3D(0* radius,0.707106* radius,-0.707106* radius);
            Point3D E = new Point3D(-1* radius,0* radius,0* radius);
            Point3D F = new Point3D(0* radius,-0.707106* radius,-0.707106* radius);

            mesh.Positions.Add(Utils.Point3DClone(A));
            mesh.Positions.Add(Utils.Point3DClone(C));
            mesh.Positions.Add(Utils.Point3DClone(B));
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);

            mesh.Positions.Add(Utils.Point3DClone(A));
            mesh.Positions.Add(Utils.Point3DClone(D));
            mesh.Positions.Add(Utils.Point3DClone(C));
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);

            mesh.Positions.Add(Utils.Point3DClone(A));
            mesh.Positions.Add(Utils.Point3DClone(E));
            mesh.Positions.Add(Utils.Point3DClone(D));
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(8);

            mesh.Positions.Add(Utils.Point3DClone(A));
            mesh.Positions.Add(Utils.Point3DClone(B));
            mesh.Positions.Add(Utils.Point3DClone(E));
            mesh.TriangleIndices.Add(9);
            mesh.TriangleIndices.Add(10);
            mesh.TriangleIndices.Add(11);

            mesh.Positions.Add(Utils.Point3DClone(B));
            mesh.Positions.Add(Utils.Point3DClone(F));
            mesh.Positions.Add(Utils.Point3DClone(E));
            mesh.TriangleIndices.Add(12);
            mesh.TriangleIndices.Add(13);
            mesh.TriangleIndices.Add(14);

            mesh.Positions.Add(Utils.Point3DClone(B));
            mesh.Positions.Add(Utils.Point3DClone(C));
            mesh.Positions.Add(Utils.Point3DClone(F));
            mesh.TriangleIndices.Add(15);
            mesh.TriangleIndices.Add(16);
            mesh.TriangleIndices.Add(17);

            mesh.Positions.Add(Utils.Point3DClone(D));
            mesh.Positions.Add(Utils.Point3DClone(F));
            mesh.Positions.Add(Utils.Point3DClone(C));
            mesh.TriangleIndices.Add(18);
            mesh.TriangleIndices.Add(19);
            mesh.TriangleIndices.Add(20);

            mesh.Positions.Add(Utils.Point3DClone(F));
            mesh.Positions.Add(Utils.Point3DClone(D));
            mesh.Positions.Add(Utils.Point3DClone(E));
            mesh.TriangleIndices.Add(21);
            mesh.TriangleIndices.Add(22);
            mesh.TriangleIndices.Add(23);

            mesh.Freeze();
            return mesh;
        }

    }
}
