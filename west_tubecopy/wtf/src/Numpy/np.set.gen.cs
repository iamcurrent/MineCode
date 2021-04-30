// Copyright (c) 2020 by Meinrad Recheis (Member of SciSharp)
// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy.Models;
#if PYTHON_INCLUDED
using Python.Included;
#endif

namespace Numpy
{
    public static partial class np
    {
        
        /// <summary>
        ///	Test whether each element of a 1-D array is also present in a second array.<br></br>
        ///	
        ///	Returns a boolean array the same length as ar1 that is True
        ///	where an element of ar1 is in ar2 and False otherwise.<br></br>
        ///	
        ///	We recommend using isin instead of in1d for new code.<br></br>
        ///	
        ///	Notes
        ///	
        ///	in1d can be considered as an element-wise function version of the
        ///	python keyword in, for 1-D sequences.<br></br>
        ///	 in1d(a, b) is roughly
        ///	equivalent to np.array([item in b for item in a]).<br></br>
        ///	
        ///	However, this idea fails if ar2 is a set, or similar (non-sequence)
        ///	container:  As ar2 is converted to an array, in those cases
        ///	asarray(ar2) is an object array rather than the expected array of
        ///	contained values.
        /// </summary>
        /// <param name="ar1">
        ///	Input array.
        /// </param>
        /// <param name="ar2">
        ///	The values against which to test each value of ar1.
        /// </param>
        /// <param name="assume_unique">
        ///	If True, the input arrays are both assumed to be unique, which
        ///	can speed up the calculation.<br></br>
        ///	Default is False.
        /// </param>
        /// <param name="invert">
        ///	If True, the values in the returned array are inverted (that is,
        ///	False where an element of ar1 is in ar2 and True otherwise).<br></br>
        ///	
        ///	Default is False.<br></br>
        ///	np.in1d(a, b, invert=True) is equivalent
        ///	to (but is faster than) np.invert(in1d(a, b)).
        /// </param>
        /// <returns>
        ///	The values ar1[in1d] are in ar2.
        /// </returns>
        public static NDarray in1d(NDarray ar1, NDarray ar2, bool? assume_unique = false, bool? invert = false)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                ar1,
                ar2,
            });
            var kwargs=new PyDict();
            if (assume_unique!=false) kwargs["assume_unique"]=ToPython(assume_unique);
            if (invert!=false) kwargs["invert"]=ToPython(invert);
            dynamic py = __self__.InvokeMethod("in1d", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        ///	Find the intersection of two arrays.<br></br>
        ///	
        ///	Return the sorted, unique values that are in both of the input arrays.
        /// </summary>
        /// <param name="ar2">
        ///	Input arrays.<br></br>
        ///	Will be flattened if not already 1D.
        /// </param>
        /// <param name="ar1">
        ///	Input arrays.<br></br>
        ///	Will be flattened if not already 1D.
        /// </param>
        /// <param name="assume_unique">
        ///	If True, the input arrays are both assumed to be unique, which
        ///	can speed up the calculation.<br></br>
        ///	Default is False.
        /// </param>
        /// <param name="return_indices">
        ///	If True, the indices which correspond to the intersection of the two
        ///	arrays are returned.<br></br>
        ///	The first instance of a value is used if there are
        ///	multiple.<br></br>
        ///	Default is False.
        /// </param>
        /// <returns>
        /// A tuple of:
        /// intersect1d
        ///	Sorted 1D array of common and unique elements.
        /// comm1
        ///	The indices of the first occurrences of the common values in ar1.
        ///	Only provided if return_indices is True.
        /// comm2
        ///	The indices of the first occurrences of the common values in ar2.
        ///	Only provided if return_indices is True.
        /// </returns>
        public static (NDarray, NDarray, NDarray) intersect1d(NDarray ar2, NDarray ar1, bool assume_unique = false, bool return_indices = false)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                ar2,
                ar1,
            });
            var kwargs=new PyDict();
            if (assume_unique!=false) kwargs["assume_unique"]=ToPython(assume_unique);
            if (return_indices!=false) kwargs["return_indices"]=ToPython(return_indices);
            dynamic py = __self__.InvokeMethod("intersect1d", pyargs, kwargs);
            return (ToCsharp<NDarray>(py[0]), ToCsharp<NDarray>(py[1]), ToCsharp<NDarray>(py[2]));
        }
        
        /// <summary>
        ///	Calculates element in test_elements, broadcasting over element only.<br></br>
        ///	
        ///	Returns a boolean array of the same shape as element that is True
        ///	where an element of element is in test_elements and False otherwise.<br></br>
        ///	
        ///	Notes
        ///	
        ///	isin is an element-wise function version of the python keyword in.<br></br>
        ///	
        ///	isin(a, b) is roughly equivalent to
        ///	np.array([item in b for item in a]) if a and b are 1-D sequences.<br></br>
        ///	
        ///	element and test_elements are converted to arrays if they are not
        ///	already.<br></br>
        ///	 If test_elements is a set (or other non-sequence collection)
        ///	it will be converted to an object array with one element, rather than an
        ///	array of the values contained in test_elements.<br></br>
        ///	 This is a consequence
        ///	of the array constructor’s way of handling non-sequence collections.<br></br>
        ///	
        ///	Converting the set to a list usually gives the desired behavior.
        /// </summary>
        /// <param name="element">
        ///	Input array.
        /// </param>
        /// <param name="test_elements">
        ///	The values against which to test each value of element.<br></br>
        ///	
        ///	This argument is flattened if it is an array or array_like.<br></br>
        ///	
        ///	See notes for behavior with non-array-like parameters.
        /// </param>
        /// <param name="assume_unique">
        ///	If True, the input arrays are both assumed to be unique, which
        ///	can speed up the calculation.<br></br>
        ///	Default is False.
        /// </param>
        /// <param name="invert">
        ///	If True, the values in the returned array are inverted, as if
        ///	calculating element not in test_elements.<br></br>
        ///	Default is False.<br></br>
        ///	
        ///	np.isin(a, b, invert=True) is equivalent to (but faster
        ///	than) np.invert(np.isin(a, b)).
        /// </param>
        /// <returns>
        ///	Has the same shape as element.<br></br>
        ///	 The values element[isin]
        ///	are in test_elements.
        /// </returns>
        public static NDarray isin(NDarray element, NDarray test_elements, bool? assume_unique = false, bool? invert = false)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                element,
                test_elements,
            });
            var kwargs=new PyDict();
            if (assume_unique!=false) kwargs["assume_unique"]=ToPython(assume_unique);
            if (invert!=false) kwargs["invert"]=ToPython(invert);
            dynamic py = __self__.InvokeMethod("isin", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        ///	Find the set difference of two arrays.<br></br>
        ///	
        ///	Return the unique values in ar1 that are not in ar2.
        /// </summary>
        /// <param name="ar1">
        ///	Input array.
        /// </param>
        /// <param name="ar2">
        ///	Input comparison array.
        /// </param>
        /// <param name="assume_unique">
        ///	If True, the input arrays are both assumed to be unique, which
        ///	can speed up the calculation.<br></br>
        ///	Default is False.
        /// </param>
        /// <returns>
        ///	1D array of values in ar1 that are not in ar2. The result
        ///	is sorted when assume_unique=False, but otherwise only sorted
        ///	if the input is sorted.
        /// </returns>
        public static NDarray setdiff1d(NDarray ar1, NDarray ar2, bool assume_unique = false)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                ar1,
                ar2,
            });
            var kwargs=new PyDict();
            if (assume_unique!=false) kwargs["assume_unique"]=ToPython(assume_unique);
            dynamic py = __self__.InvokeMethod("setdiff1d", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        ///	Find the set exclusive-or of two arrays.<br></br>
        ///	
        ///	Return the sorted, unique values that are in only one (not both) of the
        ///	input arrays.
        /// </summary>
        /// <param name="ar2">
        ///	Input arrays.
        /// </param>
        /// <param name="ar1">
        ///	Input arrays.
        /// </param>
        /// <param name="assume_unique">
        ///	If True, the input arrays are both assumed to be unique, which
        ///	can speed up the calculation.<br></br>
        ///	Default is False.
        /// </param>
        /// <returns>
        ///	Sorted 1D array of unique values that are in only one of the input
        ///	arrays.
        /// </returns>
        public static NDarray setxor1d(NDarray ar2, NDarray ar1, bool assume_unique = false)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                ar2,
                ar1,
            });
            var kwargs=new PyDict();
            if (assume_unique!=false) kwargs["assume_unique"]=ToPython(assume_unique);
            dynamic py = __self__.InvokeMethod("setxor1d", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        ///	Find the union of two arrays.<br></br>
        ///	
        ///	Return the unique, sorted array of values that are in either of the two
        ///	input arrays.
        /// </summary>
        /// <param name="ar2">
        ///	Input arrays.<br></br>
        ///	They are flattened if they are not already 1D.
        /// </param>
        /// <param name="ar1">
        ///	Input arrays.<br></br>
        ///	They are flattened if they are not already 1D.
        /// </param>
        /// <returns>
        ///	Unique, sorted union of the input arrays.
        /// </returns>
        public static NDarray union1d(NDarray ar2, NDarray ar1)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                ar2,
                ar1,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("union1d", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        
    }
}
