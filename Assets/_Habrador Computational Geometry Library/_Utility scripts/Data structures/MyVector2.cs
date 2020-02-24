using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Habrador_Computational_Geometry
{
    //Unity loves to automatically cast beween Vector2 and Vector3
    //Because theres no way to stop it, its better to use a custom struct 
    public struct MyVector2
    {
        public float x;
        public float y;

        public MyVector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }



        //
        // To make vector operations easier
        //

        //Test if this vector is the same as another vector
        public bool Equals(MyVector2 other)
        {
            //This is not accurate enough
            //if (Mathf.Approximately(this.x, other.x) && Mathf.Approximately(this.y, other.y))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            if (Mathf.Abs(this.x - other.x) < MathUtility.EPSILON && Mathf.Abs(this.y - other.y) < MathUtility.EPSILON)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static float Dot(MyVector2 a, MyVector2 b)
        {
            float dotProduct = a.x * b.x + a.y * b.y;

            return dotProduct;
        }

        public static float Magnitude(MyVector2 a)
        {
            float magnitude = Mathf.Sqrt((a.x * a.x) + (a.y * a.y));

            return magnitude;
        }

        public static float SqrMagnitude(MyVector2 a)
        {
            float sqrMagnitude = (a.x * a.x) + (a.y * a.y);

            return sqrMagnitude;
        }

        public static float Distance(MyVector2 a, MyVector2 b)
        {
            float distance = Magnitude(a - b);

            return distance;
        }

        public static float SqrDistance(MyVector2 a, MyVector2 b)
        {
            float distance = SqrMagnitude(a - b);

            return distance;
        }

        public static MyVector2 Normalize(MyVector2 v)
        {
            float v_magnitude = Magnitude(v);

            MyVector2 v_normalized = new MyVector2(v.x / v_magnitude, v.y / v_magnitude);

            return v_normalized;
        }


        //Operator overloads
        public static MyVector2 operator +(MyVector2 a, MyVector2 b)
        {
            return new MyVector2(a.x + b.x, a.y + b.y);
        }

        public static MyVector2 operator -(MyVector2 a, MyVector2 b)
        {
            return new MyVector2(a.x - b.x, a.y - b.y);
        }

        public static MyVector2 operator *(MyVector2 a, float b)
        {
            return new MyVector2(a.x * b, a.y * b);
        }

        public static MyVector2 operator *(float b, MyVector2 a)
        {
            return new MyVector2(a.x * b, a.y * b);
        }

        public static MyVector2 operator -(MyVector2 a)
        {
            return a * -1f;
        }
    }
}
