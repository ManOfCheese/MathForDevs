using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath {

    public class Circle {
        public Vector2 Position {
            get; set;
        }

        public float Radius {
            get; set;
        }

        public bool CollidesWith( Circle circle ) {
            float dist = (float)Math.Pow( circle.Position.x - Position.x, 2 ) + (float)Math.Pow( circle.Position.y - Position.y, 2 ) - circle.Radius - Radius;
            if ( dist < 0 ) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
