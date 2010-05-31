﻿/*
 *  The ircd.net project is an IRC deamon implementation for the .NET Plattform
 *  It should run on both .NET and Mono
 * 
 *  Copyright (c) 2009-2010 Thomas Bruderer <apophis@apophis.ch>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.Collections.Generic;

namespace IrcD.Commands
{
    public class IsOn : CommandBase
    {
        public IsOn(IrcDaemon ircDaemon)
            : base(ircDaemon, "ISON")
        { }

        public override void Handle(UserInfo info, List<string> args)
        {
        }
    }
}

//private void IsonDelegate(UserInfo info, List<string> args)
//{
//    if (!info.Registered)
//    {
//        SendNotRegistered(info);
//        return;
//    }
//    if (args.Count < 1)
//    {
//        SendNeedMoreParams(info);
//        return;
//    }

//    var nickList = new List<string>();
//    foreach (string nick in args)
//    {
//        if (nicks.ContainsKey(nick))
//            nickList.Add(nick);
//    }
//    SendIsOn(info, nickList);
//}