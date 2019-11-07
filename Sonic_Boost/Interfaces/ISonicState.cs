using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sonic_Boost
{
    public interface ISonicState
    {
        void Up();
        void Down();
        void Right();
        void Left();
        void Idle();
        void ChargeSpin();
        void Boost();
        void SwitchToInvincible(bool animate);
        void BeKilled();
        void Update();
    }
}