﻿namespace TheTankGame.Entities.Miscellaneous
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Parts.Contracts;

    public class VehicleAssembler : IAssembler
    {
        private readonly IList<IAttackModifyingPart> arsenalParts;
        private readonly IList<IDefenseModifyingPart> shellParts;
        private readonly IList<IHitPointsModifyingPart> enduranceParts;

        public VehicleAssembler()
        {
            this.arsenalParts = new List<IAttackModifyingPart>();
            this.shellParts = new List<IDefenseModifyingPart>();
            this.enduranceParts = new List<IHitPointsModifyingPart>();
        }

        public IReadOnlyCollection<IAttackModifyingPart> ArsenalParts
                                => this.arsenalParts.ToList().AsReadOnly();

        public IReadOnlyCollection<IDefenseModifyingPart> ShellParts
                                => this.shellParts.ToList().AsReadOnly();

        public IReadOnlyCollection<IHitPointsModifyingPart> EnduranceParts
                                => this.enduranceParts.ToList().AsReadOnly();

        public double TotalWeight
                         => this.ArsenalParts.Where(x => x != null).Sum(p => p.Weight) +
                            this.ShellParts.Where(x => x != null).Sum(p => p.Weight) +
                            this.EnduranceParts.Where(x => x != null).Sum(p => p.Weight);

        public decimal TotalPrice
                         => this.ArsenalParts.Where(x => x != null).Sum(p => p.Price) +
                            this.ShellParts.Where(x => x != null).Sum(p => p.Price) +
                            this.EnduranceParts.Where(x => x != null).Sum(p => p.Price);

        public long TotalAttackModification
             => this.ArsenalParts.Where(x => x != null).Sum(p => p.AttackModifier);

        public long TotalDefenseModification
             => this.ShellParts.Where(x => x != null).Sum(p => p.DefenseModifier);

        public long TotalHitPointModification
             => this.EnduranceParts.Where(x => x != null).Sum(p => p.HitPointsModifier);

        public void AddArsenalPart(IPart arsenalPart)
        {
            this.arsenalParts.Add((IAttackModifyingPart)arsenalPart);
        }

        public void AddShellPart(IPart shellPart)
        {
            this.shellParts.Add((IDefenseModifyingPart)shellPart);
        }

        public void AddEndurancePart(IPart endurancePart)
        {
            this.enduranceParts.Add((IHitPointsModifyingPart)endurancePart);
        }
    }
}