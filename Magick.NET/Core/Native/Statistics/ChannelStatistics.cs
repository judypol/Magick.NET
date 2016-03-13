//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
  public partial class ChannelStatistics
  {
    private static class NativeMethods
    {
      [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.ChannelStatistics+NativeMethods.#.cctor()")]
      static NativeMethods() { NativeLibraryLoader.Load(); }
      public static class X64
      {
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ChannelStatistics_Depth_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Entropy_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Kurtosis_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Maximum_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Mean_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Minimum_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Skewness_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_StandardDeviation_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Sum_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_SumCubed_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_SumFourthPower_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_SumSquared_Get(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Variance_Get(IntPtr instance);
      }
      public static class X86
      {
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ChannelStatistics_Depth_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Entropy_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Kurtosis_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Maximum_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Mean_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Minimum_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Skewness_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_StandardDeviation_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Sum_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_SumCubed_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_SumFourthPower_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_SumSquared_Get(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern double ChannelStatistics_Variance_Get(IntPtr instance);
      }
    }
    private sealed class NativeChannelStatistics : ConstNativeInstance
    {
      private IntPtr _Instance = IntPtr.Zero;
      public NativeChannelStatistics(IntPtr instance)
      {
        _Instance = instance;
      }
      public override IntPtr Instance
      {
        get
        {
          if (_Instance == IntPtr.Zero)
            throw new ObjectDisposedException(typeof(ChannelStatistics).ToString());
          return _Instance;
        }
        set
        {
          _Instance = value;
        }
      }
      public int Depth
      {
        get
        {
          UIntPtr result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_Depth_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_Depth_Get(Instance);
          return (int)result;
        }
      }
      public double Entropy
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_Entropy_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_Entropy_Get(Instance);
          return result;
        }
      }
      public double Kurtosis
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_Kurtosis_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_Kurtosis_Get(Instance);
          return result;
        }
      }
      public double Maximum
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_Maximum_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_Maximum_Get(Instance);
          return result;
        }
      }
      public double Mean
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_Mean_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_Mean_Get(Instance);
          return result;
        }
      }
      public double Minimum
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_Minimum_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_Minimum_Get(Instance);
          return result;
        }
      }
      public double Skewness
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_Skewness_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_Skewness_Get(Instance);
          return result;
        }
      }
      public double StandardDeviation
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_StandardDeviation_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_StandardDeviation_Get(Instance);
          return result;
        }
      }
      public double Sum
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_Sum_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_Sum_Get(Instance);
          return result;
        }
      }
      public double SumCubed
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_SumCubed_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_SumCubed_Get(Instance);
          return result;
        }
      }
      public double SumFourthPower
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_SumFourthPower_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_SumFourthPower_Get(Instance);
          return result;
        }
      }
      public double SumSquared
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_SumSquared_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_SumSquared_Get(Instance);
          return result;
        }
      }
      public double Variance
      {
        get
        {
          double result;
          if (NativeLibrary.Is64Bit)
            result = NativeMethods.X64.ChannelStatistics_Variance_Get(Instance);
          else
            result = NativeMethods.X86.ChannelStatistics_Variance_Get(Instance);
          return result;
        }
      }
    }
  }
}
