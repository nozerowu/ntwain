﻿// The MIT License (MIT)
// Copyright (c) 2013 Yin-Chun Wang
//
// Permission is hereby granted, free of charge, to any person obtaining a 
// copy of this software and associated documentation files (the "Software"), 
// to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included 
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF 
// OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using NTwain.Data;
using NTwain.Values;
using System;

namespace NTwain.Triplets
{
	public sealed class JpegCompression : OpBase
	{
		internal JpegCompression(TwainSession session) : base(session) { }

		/// <summary>
		/// Causes the Source to return the parameters that will be used during the compression of data
		/// using the JPEG algorithms.
		/// </summary>
		/// <param name="compression">The compression.</param>
		/// <returns></returns>
		public ReturnCode Get(out TWJpegCompression compression)
		{
			Session.VerifyState(4, 6, DataGroups.Image, DataArgumentType.JpegCompression, Message.Get);
			compression = new TWJpegCompression();
			return PInvoke.DsmEntry(Session.AppId, Session.SourceId, Message.Get, compression);
		}

		/// <summary>
		/// Causes the Source to return the power-on default values applied to JPEG-compressed data
		/// transfers.
		/// </summary>
		/// <param name="compression">The compression.</param>
		/// <returns></returns>
		public ReturnCode GetDefault(out TWJpegCompression compression)
		{
			Session.VerifyState(4, 6, DataGroups.Image, DataArgumentType.JpegCompression, Message.GetDefault);
			compression = new TWJpegCompression();
			return PInvoke.DsmEntry(Session.AppId, Session.SourceId, Message.GetDefault, compression);
		}

		/// <summary>
		/// Return the Source to using its power-on default values for JPEG-compressed transfers.
		/// </summary>
		/// <param name="compression">The compression.</param>
		/// <returns></returns>
		public ReturnCode Reset(out TWJpegCompression compression)
		{
			Session.VerifyState(4, 4, DataGroups.Image, DataArgumentType.JpegCompression, Message.Reset);
			compression = new TWJpegCompression();
			return PInvoke.DsmEntry(Session.AppId, Session.SourceId, Message.Reset, compression);
		}

		/// <summary>
		/// Allows the application to configure the compression parameters to be used on all future JPEGcompressed
		/// transfers during the current session. The application should have already
		/// established that the requested values are supported by the Source.
		/// </summary>
		/// <param name="compression">The compression.</param>
		/// <returns></returns>
		public ReturnCode Set(TWJpegCompression compression)
		{
			Session.VerifyState(4, 4, DataGroups.Image, DataArgumentType.JpegCompression, Message.Set);
			return PInvoke.DsmEntry(Session.AppId, Session.SourceId, Message.Set, compression);
		}
	}
}