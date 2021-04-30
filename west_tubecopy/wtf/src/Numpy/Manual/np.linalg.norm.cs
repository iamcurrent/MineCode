﻿using System;
using System.Collections.Generic;
using System.Text;
using Numpy.Models;
using Python.Runtime;

namespace Numpy
{

    public static partial class np
    {
        public static partial class linalg
        {
            /// <summary>
            /// Matrix or vector norm.
            /// 
            /// This function is able to return one of eight different matrix norms,
            /// or one of an infinite number of vector norms (described below), depending
            /// on the value of the ord parameter.
            /// 
            /// Notes
            /// 
            /// For values of ord &lt;= 0, the result is, strictly speaking, not a
            /// mathematical ‘norm’, but it may still be useful for various numerical
            /// purposes.
            /// 
            /// The following norms can be calculated:
            /// 
            /// The Frobenius norm is given by [1]:
            /// 
            /// The nuclear norm is the sum of the singular values.
            /// 
            /// References
            /// </summary>
            /// <param name="x">
            /// Input array.  If axis is None, x must be 1-D or 2-D.
            /// </param>
            /// <param name="ord">
            /// Order of the norm (see table under Notes). inf means numpy’s
            /// inf object.
            /// </param>
            /// <param name="axis">
            /// If axis is an integer, it specifies the axis of x along which to
            /// compute the vector norms.  If axis is a 2-tuple, it specifies the
            /// axes that hold 2-D matrices, and the matrix norms of these matrices
            /// are computed.  If axis is None then either a vector norm (when x
            /// is 1-D) or a matrix norm (when x is 2-D) is returned.
            /// </param>
            /// <param name="keepdims">
            /// If this is set to True, the axes which are normed over are left in the
            /// result as dimensions with size one.  With this option the result will
            /// broadcast correctly against the original x.
            /// </param>
            /// <returns>
            /// Norm of the matrix or vector(s).
            /// </returns>
            public static NDarray norm(NDarray x, int? ord = null, int? axis = null, bool? keepdims = null)
            {
                var pyargs = ToTuple(new object[] { x, });
                var kwargs = new PyDict();
                if (ord != null) kwargs["ord"] = ToPython(ord);
                if (axis != null) kwargs["axis"] = ToPython(axis);
                if (keepdims != null) kwargs["keepdims"] = ToPython(keepdims);
                var linalg = self.GetAttr("linalg");
                dynamic py = linalg.InvokeMethod("norm", pyargs, kwargs);
                return ToCsharp<NDarray>(py);
            }

            public static NDarray norm(NDarray x, int[] axis, bool? keepdims = null) => norm(x, null, axis, keepdims);

            public static NDarray norm(NDarray x, int? ord, int[] axis, bool? keepdims = null)
            {
                var pyargs = ToTuple(new object[] { x, });
                var kwargs = new PyDict();
                if (ord != null) kwargs["ord"] = ToPython(ord);
                if (axis != null) kwargs["axis"] = ToPython(axis);
                if (keepdims != null) kwargs["keepdims"] = ToPython(keepdims);
                var linalg = self.GetAttr("linalg");
                dynamic py = linalg.InvokeMethod("norm", pyargs, kwargs);
                return ToCsharp<NDarray>(py);
            }


            //public static float norm(NDarray x, int? ord=null, int? axis = null, bool? keepdims = null)
            //{
            //    var pyargs = ToTuple(new object[] { x, });
            //    var kwargs = new PyDict();
            //    if (ord != null) kwargs["ord"] = ToPython(ord);
            //    var linalg = self.GetAttr("linalg");
            //    dynamic py = linalg.InvokeMethod("norm", pyargs, kwargs);

            //    return ToCsharp<float>(py);
            //}

            public static float norm(NDarray x, string ord)
           {
                var pyargs = ToTuple(new object[] { x, });
                var kwargs = new PyDict();
                if (ord != null) kwargs["ord"] = ToPython(ord);
                var linalg = self.GetAttr("linalg");
                dynamic py = linalg.InvokeMethod("norm", pyargs, kwargs);
                return ToCsharp<float>(py);
            }

            public static float norm(NDarray x, Constants ord)
            {
                if (ord != Constants.inf && ord != Constants.neg_inf)
                    throw new ArgumentException("ord must be either inf or neg_inf");

                var pyargs = ToTuple(new object[] { x, });
                var kwargs = new PyDict();
                if (ord != null) kwargs["ord"] = ord == Constants.inf ? dynamic_self.inf : -(dynamic_self.inf);
                var linalg = self.GetAttr("linalg");
                dynamic py = linalg.InvokeMethod("norm", pyargs, kwargs);
                return ToCsharp<float>(py);
            }
        }
    }
}
