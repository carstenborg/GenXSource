/*
Copyright (C) 1997,1998,1999
Kenji Hiranabe, Eiwa System Management, Inc.

This program is free software.
Implemented by Kenji Hiranabe(hiranabe@esm.co.jp),
conforming to the Java(TM) 3D API specification by Sun Microsystems.

Permission to use, copy, modify, distribute and sell this software
and its documentation for any purpose is hereby granted without fee,
provided that the above copyright notice appear in all copies and
that both that copyright notice and this permission notice appear
in supporting documentation. Kenji Hiranabe and Eiwa System Management,Inc.
makes no representations about the suitability of this software for any
purpose.  It is provided "AS IS" with NO WARRANTY.*/
using System;
namespace javax.vecmath
{
	
	/// <summary> A 4 element point that is represented by single precision
	/// floating point x,y,z,w coordinates.
	/// </summary>
	/// <version>  specification 1.1, implementation $Revision: 1.1 $, $Date: 2002/08/22 20:01:15 $
	/// </version>
	/// <author>  Kenji hiranabe
	/// </author>
	[Serializable]
	public class Point4f:Tuple4f
	{
		/*
		* $Log: Point4f.java,v $
		* Revision 1.1  2002/08/22 20:01:15  egonw
		* Lots of new files. Amongst which the source code of vecmath.jar.
		* The latter has been changed to compile with gcj-3.0.4.
		* Actually, CDK does now compile, i.e. at least the classes mentioned
		* in core.classes and extra.classes. *And* a binary executable can get
		* generated that works!
		*
		* Revision 1.10  1999/10/05  07:03:50  hiranabe
		* copyright change
		*
		* Revision 1.10  1999/10/05  07:03:50  hiranabe
		* copyright change
		*
		* Revision 1.9  1999/10/05  04:56:12  hiranabe
		* Java3D 1.2 support
		* Point4f(Tuple3f t1) constructor
		* set(Tuple3f t1)
		*
		* Revision 1.8  1999/03/04  09:16:33  hiranabe
		* small bug fix and copyright change
		*
		* Revision 1.7  1999/02/28  01:53:49  hiranabe
		* bug in distanceSquared
		* 	double dw = z - p1.w; fixed
		*
		* Revision 1.6  1998/10/14  00:49:10  hiranabe
		* API1.1 Beta02
		*
		* Revision 1.5  1998/04/10  04:52:14  hiranabe
		* API1.0 -> API1.1 (added constructors, methods)
		*
		* Revision 1.4  1998/04/09  08:18:15  hiranabe
		* minor comment change
		*
		* Revision 1.3  1998/04/09  07:05:18  hiranabe
		* API 1.1
		*
		* Revision 1.2  1998/01/05  06:29:31  hiranabe
		* copyright 98
		*
		* Revision 1.1  1997/11/26  03:00:44  hiranabe
		* Initial revision
		*
		*/
		
		
		/// <summary> Constructs and initializes a Point4f from the specified xyzw coordinates.</summary>
		/// <param name="x">the x coordinate
		/// </param>
		/// <param name="y">the y coordinate
		/// </param>
		/// <param name="z">the z coordinate
		/// </param>
		/// <param name="w">the w coordinate
		/// </param>
		public Point4f(float x, float y, float z, float w):base(x, y, z, w)
		{
		}
		
		/// <summary> Constructs and initializes a Point4f from the specified array.</summary>
		/// <param name="p">the array of length 4 containing xyzw in order
		/// </param>
		public Point4f(float[] p):base(p)
		{
		}
		
		/// <summary> Constructs and initializes a Point4f from the specified Point4f.</summary>
		/// <param name="p1">the Point4f containing the initialization x y z w data
		/// </param>
		public Point4f(Point4f p1):base(p1)
		{
		}
		
		/// <summary> Constructs and initializes a Point4f from the specified Point4d.</summary>
		/// <param name="p1">the Point4d containing the initialization x y z w data
		/// </param>
		public Point4f(Point4d p1):base(p1)
		{
		}
		
		/// <summary> Constructs and initializes a Point4f from the specified Tuple4d.</summary>
		/// <param name="t1">the Tuple4d containing the initialization x y z w data
		/// </param>
		public Point4f(Tuple4d t1):base(t1)
		{
		}
		
		/// <summary> Constructs and initializes a Point4f from the specified Tuple4f.</summary>
		/// <param name="t1">the Tuple4f containing the initialization x y z w data
		/// </param>
		public Point4f(Tuple4f t1):base(t1)
		{
		}
		
		/// <summary> Constructs and initializes a Point4f to (0,0,0,0).</summary>
		public Point4f()
		{
			// super(); called implicitly.
		}
		
		/// <summary> Constructs and initializes a Point4d from the specified Tuple3f.
		/// The x,y,z  components of this point are set to the corresponding
		/// components
		/// of tuple t1. The w component of this point is set to 1.
		/// 
		/// </summary>
		/// <param name="t1">the tuple to be copied
		/// </param>
		/// <since> Java3D 1.2
		/// </since>
		public Point4f(Tuple3f t1):base(t1.x, t1.y, t1.z, 1)
		{
		}
		
		/// <summary> Sets the x,y,z components of this point to the corresponding
		/// components of tuple t1. The w component of this point is set to 1.
		/// 
		/// </summary>
		/// <param name="t1">the tuple to be copied
		/// </param>
		/// <since> Java3D 1.2
		/// </since>
		public void  set_Renamed(Tuple3f t1)
		{
			set_Renamed(t1.x, t1.y, t1.z, 1);
		}
		
		/// <summary> Computes the square of the distance between this point and point p1.</summary>
		/// <param name="p1">the other point
		/// </param>
		/// <returns> the square of distance between these two points as a float
		/// </returns>
		public float distanceSquared(Point4f p1)
		{
			double dx = x - p1.x;
			double dy = y - p1.y;
			double dz = z - p1.z;
			double dw = w - p1.w;
			//UPGRADE_WARNING: Data types in Visual C# might be different.  Verify the accuracy of narrowing conversions. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1042'"
			return (float) (dx * dx + dy * dy + dz * dz + dw * dw);
		}
		
		/// <summary> Returns the distance between this point and point p1.</summary>
		/// <param name="p1">the other point
		/// </param>
		/// <returns> the distance between these two points
		/// </returns>
		public float distance(Point4f p1)
		{
			//UPGRADE_WARNING: Data types in Visual C# might be different.  Verify the accuracy of narrowing conversions. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1042'"
			return (float) System.Math.Sqrt(distanceSquared(p1));
		}
		
		/// <summary> Computes the L-1 (Manhattan) distance between this point and point p1.
		/// The L-1 distance is equal to abs(x1-x2) + abs(y1-y2)
		/// + abs(z1-z2) + abs(w1-w2).
		/// </summary>
		/// <param name="p1">the other point
		/// </param>
		/// <returns> L-1 distance
		/// </returns>
		public float distanceL1(Point4f p1)
		{
			return System.Math.Abs(x - p1.x) + System.Math.Abs(y - p1.y) + System.Math.Abs(z - p1.z) + System.Math.Abs(w - p1.w);
		}
		
		/// <summary> Computes the L-infinite distance between this point and point p1.
		/// The L-infinite distance is equal to MAX[abs(x1-x2), abs(y1-y2), abs(z1-z2), abs(w1-w2)].
		/// </summary>
		/// <param name="p1">the other point
		/// </param>
		/// <returns> L-infinite distance
		/// </returns>
		public float distanceLinf(Point4f p1)
		{
			return System.Math.Max(System.Math.Max(System.Math.Abs(x - p1.x), System.Math.Abs(y - p1.y)), System.Math.Max(System.Math.Abs(z - p1.z), System.Math.Abs(w - p1.w)));
		}
		
		/// <summary> Multiplies each of the x,y,z components of the Point4f parameter by 1/w,
		/// places the projected values into this point, and places a 1 as the w
		/// parameter of this point.
		/// </summary>
		/// <param name="p1">the source Point4d, which is not modified
		/// </param>
		public void  project(Point4f p1)
		{
			// zero div may occur.
			x = p1.x / p1.w;
			y = p1.y / p1.w;
			z = p1.z / p1.w;
			w = 1.0f;
		}
	}
}