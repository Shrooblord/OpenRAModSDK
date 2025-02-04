#pragma warning disable SA1124
#region Copyright & License Information
#pragma warning restore SA1124
/*
 * Copyright (c) The OpenRA Developers and Contributors
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

namespace OpenRA.Mods.Shroobs.Traits
{
    using OpenRA.Mods.Common.Traits;
    using OpenRA.Traits;

    public class MobileRefineryInfo : RefineryInfo, Requires<MobileInfo>
    {
        public override object Create(ActorInitializer init) { return new MobileRefinery(init.Self, this); }
    }

    public class MobileRefinery(Actor self, MobileRefineryInfo info) : Refinery(self, info)
    {
        readonly Actor self = self;
    }
}
