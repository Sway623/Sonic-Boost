using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sonic_Boost
{
    public interface ISonicSprite : ISprite
    {
        void Update(bool isRunning);
    }
}