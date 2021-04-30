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
        ///	compatible: Python bool
        /// </summary>
        public  static Dtype bool_
        {
            get
            {
                dynamic py = self.GetAttr("bool_");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("bool_", ToPython(value));
            }
        }
        
        /// <summary>
        ///	8 bits
        /// </summary>
        public  static Dtype bool8
        {
            get
            {
                dynamic py = self.GetAttr("bool8");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("bool8", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: C char
        /// </summary>
        public  static Dtype @byte
        {
            get
            {
                dynamic py = self.GetAttr("byte");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("byte", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: C short
        /// </summary>
        public  static Dtype @short
        {
            get
            {
                dynamic py = self.GetAttr("short");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("short", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: C int
        /// </summary>
        public  static Dtype intc
        {
            get
            {
                dynamic py = self.GetAttr("intc");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("intc", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: Python int
        /// </summary>
        public  static Dtype int_
        {
            get
            {
                dynamic py = self.GetAttr("int_");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("int_", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: C long long
        /// </summary>
        public  static Dtype longlong
        {
            get
            {
                dynamic py = self.GetAttr("longlong");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("longlong", ToPython(value));
            }
        }
        
        /// <summary>
        ///	large enough to fit a pointer
        /// </summary>
        public  static Dtype intp
        {
            get
            {
                dynamic py = self.GetAttr("intp");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("intp", ToPython(value));
            }
        }
        
        /// <summary>
        ///	8 bits
        /// </summary>
        public  static Dtype int8
        {
            get
            {
                dynamic py = self.GetAttr("int8");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("int8", ToPython(value));
            }
        }
        
        /// <summary>
        ///	16 bits
        /// </summary>
        public  static Dtype int16
        {
            get
            {
                dynamic py = self.GetAttr("int16");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("int16", ToPython(value));
            }
        }
        
        /// <summary>
        ///	32 bits
        /// </summary>
        public  static Dtype int32
        {
            get
            {
                dynamic py = self.GetAttr("int32");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("int32", ToPython(value));
            }
        }
        
        /// <summary>
        ///	64 bits
        /// </summary>
        public  static Dtype int64
        {
            get
            {
                dynamic py = self.GetAttr("int64");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("int64", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: C unsigned char
        /// </summary>
        public  static Dtype ubyte
        {
            get
            {
                dynamic py = self.GetAttr("ubyte");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("ubyte", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: C unsigned short
        /// </summary>
        public  static Dtype @ushort
        {
            get
            {
                dynamic py = self.GetAttr("ushort");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("ushort", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: C unsigned int
        /// </summary>
        public  static Dtype uintc
        {
            get
            {
                dynamic py = self.GetAttr("uintc");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("uintc", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: Python int
        /// </summary>
        public  static Dtype @uint
        {
            get
            {
                dynamic py = self.GetAttr("uint");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("uint", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: C long long
        /// </summary>
        public  static Dtype ulonglong
        {
            get
            {
                dynamic py = self.GetAttr("ulonglong");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("ulonglong", ToPython(value));
            }
        }
        
        /// <summary>
        ///	large enough to fit a pointer
        /// </summary>
        public  static Dtype uintp
        {
            get
            {
                dynamic py = self.GetAttr("uintp");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("uintp", ToPython(value));
            }
        }
        
        /// <summary>
        ///	8 bits
        /// </summary>
        public  static Dtype uint8
        {
            get
            {
                dynamic py = self.GetAttr("uint8");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("uint8", ToPython(value));
            }
        }
        
        /// <summary>
        ///	16 bits
        /// </summary>
        public  static Dtype uint16
        {
            get
            {
                dynamic py = self.GetAttr("uint16");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("uint16", ToPython(value));
            }
        }
        
        /// <summary>
        ///	32 bits
        /// </summary>
        public  static Dtype uint32
        {
            get
            {
                dynamic py = self.GetAttr("uint32");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("uint32", ToPython(value));
            }
        }
        
        /// <summary>
        ///	64 bits
        /// </summary>
        public  static Dtype uint64
        {
            get
            {
                dynamic py = self.GetAttr("uint64");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("uint64", ToPython(value));
            }
        }
        
        /// <summary>
        ///	&#160;
        /// </summary>
        public  static Dtype half
        {
            get
            {
                dynamic py = self.GetAttr("half");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("half", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: C float
        /// </summary>
        public  static Dtype single
        {
            get
            {
                dynamic py = self.GetAttr("single");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("single", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: C double
        /// </summary>
        public  static Dtype @double
        {
            get
            {
                dynamic py = self.GetAttr("double");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("double", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: Python float
        /// </summary>
        public  static Dtype float_
        {
            get
            {
                dynamic py = self.GetAttr("float_");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("float_", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: C long float
        /// </summary>
        public  static Dtype longfloat
        {
            get
            {
                dynamic py = self.GetAttr("longfloat");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("longfloat", ToPython(value));
            }
        }
        
        /// <summary>
        ///	16 bits
        /// </summary>
        public  static Dtype float16
        {
            get
            {
                dynamic py = self.GetAttr("float16");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("float16", ToPython(value));
            }
        }
        
        /// <summary>
        ///	32 bits
        /// </summary>
        public  static Dtype float32
        {
            get
            {
                dynamic py = self.GetAttr("float32");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("float32", ToPython(value));
            }
        }
        
        /// <summary>
        ///	64 bits
        /// </summary>
        public  static Dtype float64
        {
            get
            {
                dynamic py = self.GetAttr("float64");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("float64", ToPython(value));
            }
        }
        
        /// <summary>
        ///	96 bits, platform?
        /// </summary>
        public  static Dtype float96
        {
            get
            {
                dynamic py = self.GetAttr("float96");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("float96", ToPython(value));
            }
        }
        
        /// <summary>
        ///	128 bits, platform?
        /// </summary>
        public  static Dtype float128
        {
            get
            {
                dynamic py = self.GetAttr("float128");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("float128", ToPython(value));
            }
        }
        
        /// <summary>
        ///	&#160;
        /// </summary>
        public  static Dtype csingle
        {
            get
            {
                dynamic py = self.GetAttr("csingle");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("csingle", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: Python complex
        /// </summary>
        public  static Dtype complex_
        {
            get
            {
                dynamic py = self.GetAttr("complex_");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("complex_", ToPython(value));
            }
        }
        
        /// <summary>
        ///	&#160;
        /// </summary>
        public  static Dtype clongfloat
        {
            get
            {
                dynamic py = self.GetAttr("clongfloat");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("clongfloat", ToPython(value));
            }
        }
        
        /// <summary>
        ///	two 32-bit floats
        /// </summary>
        public  static Dtype complex64
        {
            get
            {
                dynamic py = self.GetAttr("complex64");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("complex64", ToPython(value));
            }
        }
        
        /// <summary>
        ///	two 64-bit floats
        /// </summary>
        public  static Dtype complex128
        {
            get
            {
                dynamic py = self.GetAttr("complex128");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("complex128", ToPython(value));
            }
        }
        
        /// <summary>
        ///	two 96-bit floats,
        ///	platform?
        /// </summary>
        public  static Dtype complex192
        {
            get
            {
                dynamic py = self.GetAttr("complex192");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("complex192", ToPython(value));
            }
        }
        
        /// <summary>
        ///	two 128-bit floats,
        ///	platform?
        /// </summary>
        public  static Dtype complex256
        {
            get
            {
                dynamic py = self.GetAttr("complex256");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("complex256", ToPython(value));
            }
        }
        
        /// <summary>
        ///	any Python object
        /// </summary>
        public  static Dtype object_
        {
            get
            {
                dynamic py = self.GetAttr("object_");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("object_", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: Python bytes
        /// </summary>
        public  static Dtype bytes_
        {
            get
            {
                dynamic py = self.GetAttr("bytes_");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("bytes_", ToPython(value));
            }
        }
        
        /// <summary>
        ///	compatible: Python unicode/str
        /// </summary>
        public  static Dtype unicode_
        {
            get
            {
                dynamic py = self.GetAttr("unicode_");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("unicode_", ToPython(value));
            }
        }
        
        /// <summary>
        ///	&#160;
        /// </summary>
        public  static Dtype @void
        {
            get
            {
                dynamic py = self.GetAttr("void");
                return ToCsharp<Dtype>(py);
            }
            set
            {
                self.SetAttr("void", ToPython(value));
            }
        }
        
        
    }
}
