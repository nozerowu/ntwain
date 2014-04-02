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

using System;
namespace NTwain.Triplets
{
	/// <summary>
	/// Class for grouping triplet operations under the Control data group.
	/// </summary>
	public sealed class DGControl
	{
		TwainSession _session;
		internal DGControl(TwainSession session)
		{
			if (session == null) { throw new ArgumentNullException("session"); }
			_session = session;
		}

		Callback _callback;
		internal Callback Callback
		{
			get
			{
				if (_callback == null) { _callback = new Callback(_session); }
				return _callback;
			}
		}

		Callback2 _callback2;
		internal Callback2 Callback2
		{
			get
			{
				if (_callback2 == null) { _callback2 = new Callback2(_session); }
				return _callback2;
			}
		}
		Capability _capability;
		public Capability Capability
		{
			get
			{
				if (_capability == null) { _capability = new Capability(_session); }
				return _capability;
			}
		}
		CustomDSData _customDSData;
		public CustomDSData CustomDSData
		{
			get
			{
				if (_customDSData == null) { _customDSData = new CustomDSData(_session); }
				return _customDSData;
			}
		}
		DeviceEvent _deviceEvent;
		public DeviceEvent DeviceEvent
		{
			get
			{
				if (_deviceEvent == null) { _deviceEvent = new DeviceEvent(_session); }
				return _deviceEvent;
			}
		}
		EntryPoint _entryPoint;
		internal EntryPoint EntryPoint
		{
			get
			{
				if (_entryPoint == null) { _entryPoint = new EntryPoint(_session); }
				return _entryPoint;
			}
		}
		Event _event;
		internal Event Event
		{
			get
			{
				if (_event == null) { _event = new Event(_session); }
				return _event;
			}
		}
		FileSystem _fileSys;
		public FileSystem FileSystem
		{
			get
			{
				if (_fileSys == null) { _fileSys = new FileSystem(_session); }
				return _fileSys;
			}
		}
		Identity _identity;
		public Identity Identity
		{
			get
			{
				if (_identity == null) { _identity = new Identity(_session); }
				return _identity;
			}
		}
		Parent _parent;
		internal Parent Parent
		{
			get
			{
				if (_parent == null) { _parent = new Parent(_session); }
				return _parent;
			}
		}
		PassThru _passThru;
		public PassThru PassThru
		{
			get
			{
				if (_passThru == null) { _passThru = new PassThru(_session); }
				return _passThru;
			}
		}
		PendingXfers _pendingXfers;
		internal PendingXfers PendingXfers
		{
			get
			{
				if (_pendingXfers == null) { _pendingXfers = new PendingXfers(_session); }
				return _pendingXfers;
			}
		}
		SetupFileXfer _setupFileXfer;
		public SetupFileXfer SetupFileXfer
		{
			get
			{
				if (_setupFileXfer == null) { _setupFileXfer = new SetupFileXfer(_session); }
				return _setupFileXfer;
			}
		}
		SetupMemXfer _setupMemXfer;
		public SetupMemXfer SetupMemXfer
		{
			get
			{
				if (_setupMemXfer == null) { _setupMemXfer = new SetupMemXfer(_session); }
				return _setupMemXfer;
			}
		}
		Status _status;
		public Status Status
		{
			get
			{
				if (_status == null) { _status = new Status(_session); }
				return _status;
			}
		}
		StatusUtf8 _statusUtf8;
		public StatusUtf8 StatusUtf8
		{
			get
			{
				if (_statusUtf8 == null) { _statusUtf8 = new StatusUtf8(_session); }
				return _statusUtf8;
			}
		}
		UserInterface _userInterface;
		internal UserInterface UserInterface
		{
			get
			{
				if (_userInterface == null) { _userInterface = new UserInterface(_session); }
				return _userInterface;
			}
		}
		XferGroup _xferGroup;
		public XferGroup XferGroup
		{
			get
			{
				if (_xferGroup == null) { _xferGroup = new XferGroup(_session); }
				return _xferGroup;
			}
		}
	}
}