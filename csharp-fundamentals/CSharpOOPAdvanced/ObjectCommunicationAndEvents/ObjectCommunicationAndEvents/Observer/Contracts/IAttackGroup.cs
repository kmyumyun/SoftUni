﻿using Heroes;

namespace Heroes.Contracts
{
    public interface IAttackGroup
    {
        void AddMember(IAttacker attacker);

        void GroupTarget(ITarget target);

        void GroupAttack();
    }
}
