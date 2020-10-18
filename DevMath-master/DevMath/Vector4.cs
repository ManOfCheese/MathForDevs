using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath {

    public struct Vector4 {
        public float x;
        public float y;
        public float z;
        public float w;

        public float Magnitude {
            get {
                return ( float )Math.Sqrt( x * x + y * y + z * z + w * w );
            }
        }

        public Vector4 Normalized {
            get {
                Vector4 normalizedValue;
                normalizedValue.x = x / Magnitude;
                normalizedValue.y = y / Magnitude;
                normalizedValue.z = z / Magnitude;
                normalizedValue.w = w / Magnitude;
                return normalizedValue;
            }
        }

        public Vector4( float x, float y, float z, float w ) {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static implicit operator Vector4( Vector3 v ) {
            Vector4 newVector;
            newVector.x = v.x;
            newVector.y = v.y;
            newVector.z = v.z;
            newVector.w = 0;
            return newVector;
        }

        public static float Dot( Vector4 lhs, Vector4 rhs ) {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z + lhs.w * rhs.w;
        }

        public static Vector4 Lerp( Vector4 a, Vector4 b, float t ) {
            return ( a * ( 1 - t ) ) + b * t;
        }

        public static Vector4 operator +( Vector4 lhs, Vector4 rhs ) {
            return new Vector4( lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w );
        }

        public static Vector4 operator -( Vector4 lhs, Vector4 rhs ) {
            return new Vector4( lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w );
        }

        public static Vector4 operator -( Vector4 v ) {
            v.x = -v.x;
            v.y = -v.y;
            v.z = -v.z;
            v.w = -v.w;
            return v;
        }

        public static Vector4 operator *( Vector4 lhs, float scalar ) {
            return new Vector4( lhs.x * scalar, lhs.y * scalar, lhs.z * scalar, lhs.w * scalar );
        }

        public static Vector4 operator /( Vector4 lhs, float scalar ) {
            return new Vector4( lhs.x / scalar, lhs.y / scalar, lhs.z / scalar, lhs.w / scalar );
        }
    }
}
