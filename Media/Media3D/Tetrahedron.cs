using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Pacem.Media.Media3D
{
    public class Tetrahedron : Primitive3D
    {

        public Tetrahedron(double radius)
            : base(radius)
        {
            
        }

        public Tetrahedron()
            : base(1D)
        {
        }

        protected override Geometry3D Tessellate(double _radius)
        {
            MeshGeometry3D mesh = new MeshGeometry3D();

            Point3D A = new Point3D(0.816496 * _radius, 0 * _radius, 0.57735 * _radius);
            Point3D B = new Point3D(-0.816496 * _radius, 0 * _radius, 0.57735 * _radius);
            Point3D C = new Point3D(0 * _radius, 0.816496 * _radius, -0.57735 * _radius);
            Point3D D = new Point3D(0 * _radius, -0.816496 * _radius, -0.57735 * _radius);

            mesh.Positions.Add(Utils.Point3DClone(B));
            mesh.Positions.Add(Utils.Point3DClone(C));
            mesh.Positions.Add(Utils.Point3DClone(A));
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);

            mesh.Positions.Add(Utils.Point3DClone(A));
            mesh.Positions.Add(Utils.Point3DClone(D));
            mesh.Positions.Add(Utils.Point3DClone(B));
            mesh.TriangleIndices.Add(3);
            mesh.TriangleIndices.Add(4);
            mesh.TriangleIndices.Add(5);

            mesh.Positions.Add(Utils.Point3DClone(A));
            mesh.Positions.Add(Utils.Point3DClone(C));
            mesh.Positions.Add(Utils.Point3DClone(D));
            mesh.TriangleIndices.Add(6);
            mesh.TriangleIndices.Add(7);
            mesh.TriangleIndices.Add(8);

            mesh.Positions.Add(Utils.Point3DClone(C));
            mesh.Positions.Add(Utils.Point3DClone(B));
            mesh.Positions.Add(Utils.Point3DClone(D));
            mesh.TriangleIndices.Add(9);
            mesh.TriangleIndices.Add(10);
            mesh.TriangleIndices.Add(11);

            mesh.Freeze();
            return mesh;

        }
    }
}
