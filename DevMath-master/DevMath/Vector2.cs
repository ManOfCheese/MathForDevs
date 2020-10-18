using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath {

    public struct Vector2 {
        public float x;
        public float y;

        public float Magnitude {
            get {
                return ( float )Math.Sqrt( x * x + y * y );
            }
        }

        public Vector2 Normalized {
            get {
                Vector2 normalizedValue;
                normalizedValue.x = x / Magnitude;
                normalizedValue.y = y / Magnitude;
                return normalizedValue;
            }
        }

        public Vector2( float x, float y ) {
            this.x = x;
            this.y = y;
        }

        public static float Dot( Vector2 lhs, Vector2 rhs ) {
            return lhs.x * rhs.x + lhs.y * rhs.y;
        }

        public static Vector2 Lerp( Vector2 a, Vector2 b, float t ) {
            return ( a * ( 1 - t ) ) + b * t;
        }

        public static float Angle( Vector2 lhs, Vector2 rhs ) {
            return ( float )Math.Atan2( rhs.y - lhs.y, rhs.x - lhs.x );
        }

        public static Vector2 DirectionFromAngle( float angle ) {
            float x = 1f;
            float y = 0f;
            return new Vector2( x * ( float )Math.Cos( DevMath.DegToRad( angle ) ) - y * ( float )Math.Sin( DevMath.DegToRad( angle ) ), x * 
                ( float )Math.Sin( DevMath.DegToRad( angle ) ) - y * ( float )Math.Cos( DevMath.DegToRad( angle ) ) );
        }

        public static Vector2 operator +( Vector2 lhs, Vector2 rhs ) {
            return new Vector2( lhs.x + rhs.x, lhs.y + rhs.y );
        }

        public static Vector2 operator -( Vector2 lhs, Vector2 rhs ) {
            return new Vector2( lhs.x - rhs.x, lhs.y - rhs.y );
        }

        public static Vector2 operator -( Vector2 v ) {
            v.x = -v.x;
            v.y = -v.y;
            return v;
        }

        public static Vector2 operator *( Vector2 lhs, float scalar ) {
            return new Vector2( lhs.x * scalar, lhs.y * scalar );
        }

        public static Vector2 operator *( float scalar, Vector2 lhs ) {
            return new Vector2( lhs.x * scalar, lhs.y * scalar );
        }

        public static Vector2 operator /( Vector2 lhs, float scalar ) {
            return new Vector2( lhs.x / scalar, lhs.y / scalar );
        }
    }
}
