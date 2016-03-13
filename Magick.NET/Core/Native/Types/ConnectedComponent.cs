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
  public partial class ConnectedComponent
  {
    private static class NativeMethods
    {
      [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.ConnectedComponent+NativeMethods.#.cctor()")]
      static NativeMethods() { NativeLibraryLoader.Load(); }
      public static class X64
      {
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ConnectedComponent_DisposeList(IntPtr list);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ConnectedComponent_GetHeight(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ConnectedComponent_GetInstance(IntPtr list, UIntPtr index);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ConnectedComponent_GetWidth(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ConnectedComponent_GetX(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ConnectedComponent_GetY(IntPtr instance);
      }
      public static class X86
      {
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ConnectedComponent_DisposeList(IntPtr list);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ConnectedComponent_GetHeight(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ConnectedComponent_GetInstance(IntPtr list, UIntPtr index);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ConnectedComponent_GetWidth(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ConnectedComponent_GetX(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ConnectedComponent_GetY(IntPtr instance);
      }
    }
    private static class NativeConnectedComponent
    {
      public static void DisposeList(IntPtr list)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.ConnectedComponent_DisposeList(list);
        else
          NativeMethods.X86.ConnectedComponent_DisposeList(list);
      }
      public static int GetHeight(IntPtr instance)
      {
        if (NativeLibrary.Is64Bit)
          return (int)NativeMethods.X64.ConnectedComponent_GetHeight(instance);
        else
          return (int)NativeMethods.X86.ConnectedComponent_GetHeight(instance);
      }
      public static IntPtr GetInstance(IntPtr list, int index)
      {
        if (NativeLibrary.Is64Bit)
          return NativeMethods.X64.ConnectedComponent_GetInstance(list, (UIntPtr)index);
        else
          return NativeMethods.X86.ConnectedComponent_GetInstance(list, (UIntPtr)index);
      }
      public static int GetWidth(IntPtr instance)
      {
        if (NativeLibrary.Is64Bit)
          return (int)NativeMethods.X64.ConnectedComponent_GetWidth(instance);
        else
          return (int)NativeMethods.X86.ConnectedComponent_GetWidth(instance);
      }
      public static int GetX(IntPtr instance)
      {
        if (NativeLibrary.Is64Bit)
          return (int)NativeMethods.X64.ConnectedComponent_GetX(instance);
        else
          return (int)NativeMethods.X86.ConnectedComponent_GetX(instance);
      }
      public static int GetY(IntPtr instance)
      {
        if (NativeLibrary.Is64Bit)
          return (int)NativeMethods.X64.ConnectedComponent_GetY(instance);
        else
          return (int)NativeMethods.X86.ConnectedComponent_GetY(instance);
      }
    }
  }
}
