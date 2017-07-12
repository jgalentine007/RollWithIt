using System;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace Pacem.Media.Media3D
{
    public sealed class Geometry3DEventArgs : System.EventArgs
    {

        internal Geometry3DEventArgs(Geometry3D geom)
        {
            _geom = geom;
        }

        Geometry3D _geom = null;

        public Geometry3D Geometry3D
        {
            get { return _geom; }        
        }

        public bool IsEmpty
        {
            get
            {
                return _geom == null;
            }
        }

    }
}
