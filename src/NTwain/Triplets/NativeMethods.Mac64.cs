﻿using NTwain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NTwain.Triplets
{
    static partial class NativeMethods
    {
        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref IntPtr data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref DataGroups data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_AUDIOINFO data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_CAPABILITY data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_CUSTOMDSDATA data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_DEVICEEVENT data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_CALLBACK data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_CALLBACK2 data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            IntPtr zero,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            [In, Out]TW_ENTRYPOINT data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_EVENT data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_FILESYSTEM data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            IntPtr zero,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            [In, Out]TW_IDENTITY data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_PASSTHRU data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_PENDINGXFERS data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_SETUPFILEXFER data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_SETUPMEMXFER data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_STATUSUTF8 data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_USERINTERFACE data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_CIECOLOR data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_EXTIMAGEINFO data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_FILTER data);

        //[DllImport(DSM.WinDsmDll, EntryPoint = DSM.EntryName)]
        //public static extern ReturnCode DsmMac64(
        //    [In, Out]TW_IDENTITY origin,
        //    [In, Out]TW_IDENTITY destination,
        //    DataGroups dg,
        //    DataArgumentType dat,
        //    Message msg,
        //    ref TWGrayResponse data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_IMAGEINFO data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_IMAGELAYOUT data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_IMAGEMEMXFER data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_JPEGCOMPRESSION data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_PALETTE8 data);

        //[DllImport(DSM.WinDsmDll, EntryPoint = DSM.EntryName)]
        //public static extern ReturnCode DsmMac64(
        //    [In, Out]TW_IDENTITY origin,
        //    [In, Out]TW_IDENTITY destination,
        //    DataGroups dg,
        //    DataArgumentType dat,
        //    Message msg,
        //    ref TWRgbResponse data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_STATUS data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_MEMORY data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_METRICS data);

        [DllImport(Mac64Dll, EntryPoint = EntryName)]
        public static extern ReturnCode DsmMac64(
            [In, Out]TW_IDENTITY origin,
            [In, Out]TW_IDENTITY destination,
            DataGroups dg,
            DataArgumentType dat,
            Message msg,
            ref TW_TWAINDIRECT data);

    }
}
