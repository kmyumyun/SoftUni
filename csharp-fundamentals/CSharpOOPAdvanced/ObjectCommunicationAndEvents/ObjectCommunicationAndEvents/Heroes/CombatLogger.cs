﻿using System;

namespace Heroes
{
    public class CombatLogger : Logger
    {
        public override void Handle(LogType type, string message)
        {
            switch (type)
            {
                case LogType.ATTACK:
                    Console.WriteLine(type.ToString() + ": " + message);
                    break;
                case LogType.MAGIC:
                    Console.WriteLine(type.ToString() + ": " + message);
                    break;
            }

            this.PassToSuccessor(type, message);
        }
    }
}
