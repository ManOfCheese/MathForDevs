using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath {

    public class DevMath {
        public static float Lerp( float a, float b, float t ) {
            return ( a * ( 1 - t ) ) + b * t;
        }

        public static float DistanceTraveled( float startVelocity, float acceleration, float time ) {
            return startVelocity * time + 0.5f * acceleration * time * time;
        }

        public static float Clamp( float value, float min, float max ) {
            return Math.Max( Math.Min( value, max ), min );
        }

        public static float RadToDeg( float angle ) {
            return ( float )( angle * ( 180 / Math.PI ) );
        }

        public static float DegToRad( float angle ) {
            return ( float )( angle * ( Math.PI / 180 ) );
        }
    }
}
