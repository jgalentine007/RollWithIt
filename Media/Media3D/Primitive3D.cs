using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Pacem.Media.Media3D
{
    public abstract class Primitive3D : ModelVisual3D
    {

        internal Primitive3D(bool autorender)
        {
            Content = _content;
            if (autorender) Render();
        }

        public Primitive3D()
        {
            Content = _content;
        }

        public Primitive3D(double radius)
        {
            Content = _content;
            _radius = radius;
            Render();
        }

        protected virtual void Render()
        {   
            if (_radius == double.Epsilon) OnTessellating(new Geometry3DEventArgs(Tessellate()));
            else OnTessellating(new Geometry3DEventArgs(Tessellate(_radius)));
        }

        public static DependencyProperty MaterialProperty =
            DependencyProperty.Register(
                "Material",
                typeof(Material),
                typeof(Primitive3D), new PropertyMetadata(
                    null, new PropertyChangedCallback(OnMaterialChanged)));

        public Material Material
        {
            get { return (Material)GetValue(MaterialProperty); }
            set { SetValue(MaterialProperty, value); }
        }

        internal static void OnMaterialChanged(Object sender, DependencyPropertyChangedEventArgs e)
        {
            Primitive3D p = ((Primitive3D)sender);
            p._content.Material = p.Material;
        }

        internal static void OnGeometryChanged(DependencyObject d)
        {
            Primitive3D p = ((Primitive3D)d);

            p._content.Geometry = p.Tessellate();
        }

        internal double DegToRad(double degrees)
        {
            return (degrees / 180.0) * Math.PI;
        }

        internal double _radius = double.Epsilon;
        internal readonly GeometryModel3D _content = new GeometryModel3D();

        #region VIRTUAL/ABSTRACT

        protected virtual Geometry3D Tessellate(double radius)
        {
            return Tessellate();
        }
        protected virtual Geometry3D Tessellate()
        {
            return new System.Windows.Media.Media3D.MeshGeometry3D();
        }

        #endregion

        #region EVENTS

        public virtual void OnTessellating(Geometry3DEventArgs e)
        { 
            if (Tessellating != null) Tessellating(this, e);
            _content.Geometry = e.Geometry3D;
        }

        public event Geometry3DEventHandler Tessellating;
        public delegate void Geometry3DEventHandler(object sender, Geometry3DEventArgs e);

        #endregion
    }
}
