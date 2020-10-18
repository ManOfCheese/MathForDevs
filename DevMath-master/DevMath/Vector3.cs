using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath {

    public struct Vector3 {
        public float x;
        public float y;
        public float z;

        public float Magnitude {
            get {
                return ( float )Math.Sqrt( x * x + y * y + z * z );
            }
        }

        public Vector3 Normalized {
            get {
                Vector3 normalizedValue;
                normalizedValue.x = x / Magnitude;
                normalizedValue.y = y / Magnitude;
                normalizedValue.z = z / Magnitude;
                return normalizedValue;
            }
        }

        public Vector3( float x, float y, float z ) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static implicit operator Vector3( Vector2 v ) {
            Vector3 newVector;
            newVector.x = v.x;
            newVector.y = v.y;
            newVector.z = 0;
            return newVector;
        }

        public static float Dot( Vector3 lhs, Vector3 rhs ) {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        }

        public static Vector3 Cross( Vector3 lhs, Vector3 rhs ) {
            Vector3 value;
            value.x = ( lhs.y * rhs.z ) - ( lhs.z * rhs.y );
            value.y = ( lhs.z * rhs.x ) - ( lhs.x * rhs.z );
            value.z = ( lhs.x * rhs.y ) - ( lhs.y * rhs.x );
            return value;
        }

        public static Vector3 Lerp( Vector3 a, Vector3 b, float t ) {
            return ( a * ( 1 - t ) ) + b * t;
        }

        public static Vector3 operator +( Vector3 lhs, Vector3 rhs ) {
            return new Vector3( lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z );
        }

        public static Vector3 operator -( Vector3 lhs, Vector3 rhs ) {
            return new Vector3( lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z );
        }

        public static Vector3 operator -( Vector3 v ) {
            v.x = -v.x;
            v.y = -v.y;
            v.z = -v.z;
            return v;
        }

        public static Vector3 operator *( Vector3 lhs, float scalar ) {
            return new Vector3( lhs.x * scalar, lhs.y * scalar, lhs.z * scalar );
        }

        public static Vector3 operator /( Vector3 lhs, float scalar ) {
            return new Vector3( lhs.x / scalar, lhs.y / scalar, lhs.z / scalar );
        }
    }
}
