#region Copyright 2001-2006 Christoph Daniel R�egg [GPL]
//Math.NET Symbolics: Yttrium, part of Math.NET
//Copyright (c) 2001-2006, Christoph Daniel Rueegg, http://cdrnet.net/.
//All rights reserved.
//This Math.NET package is available under the terms of the GPL.

//This program is free software; you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation; either version 2 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using MathNet.Symbolics.Core;
using MathNet.Symbolics.Backend.Containers;

namespace MathNet.Symbolics.Backend.Traversing
{
    public class ConditionalCollectVisitor : AbstractScanVisitor
    {
        private SignalSet _signals;
        private PortSet _ports;
        private BusSet _buses;

        private Predicate<Signal> _signalMatch;
        private Predicate<Port> _portMatch;
        private Predicate<Bus> _busMatch;

        #region Constructors
        public ConditionalCollectVisitor()
        {
            _signals = new SignalSet();
            _ports = new PortSet();
            _buses = new BusSet();

            _signalMatch = DummySignalPredicate;
            _portMatch = DummyPortPredicate;
            _busMatch = DummyBusPredicate;
        }
        public ConditionalCollectVisitor(Predicate<Signal> signalMatch, Predicate<Port> portMatch, Predicate<Bus> busMatch)
        {
            _signals = new SignalSet();
            _ports = new PortSet();
            _buses = new BusSet();

            _signalMatch = signalMatch;
            _portMatch = portMatch;
            _busMatch = busMatch;
        }
        public ConditionalCollectVisitor(Predicate<Signal> signalMatch) : this()
        {
            _signalMatch = signalMatch;
        }
        public ConditionalCollectVisitor(Predicate<Port> portMatch) : this()
        {
            _portMatch = portMatch;
        }
        public ConditionalCollectVisitor(Predicate<Bus> busMatch) : this()
        {
            _busMatch = busMatch;
        }
        #endregion

        public void Reset()
        {
            _signals.Clear();
            _ports.Clear();
            _buses.Clear();
        }

        public SignalSet Signals
        {
            get { return _signals; }
        }

        public PortSet Ports
        {
            get { return _ports; }
        }

        public BusSet Buses
        {
            get { return _buses; }
        }

        public override bool EnterSignal(Signal signal, Port parent, bool again, bool root)
        {
            if(again)
                return false;
            if(_signalMatch(signal))
                _signals.Add(signal);
            return true;
        }

        public override bool EnterPort(Port port, Signal parent, bool again, bool root)
        {
            if(again)
                return false;
            if(_portMatch(port))
                _ports.Add(port);
            return true;
        }

        public override bool VisitLeaf(Bus bus, bool again)
        {
            if(!again && _busMatch(bus))
                _buses.Add(bus);
            return true;
        }

        #region Dummy Predicates
        private bool DummySignalPredicate(Signal signal)
        {
            return true;
        }
        private bool DummyPortPredicate(Port port)
        {
            return true;
        }
        private bool DummyBusPredicate(Bus bus)
        {
            return true;
        }
        #endregion
    }
}