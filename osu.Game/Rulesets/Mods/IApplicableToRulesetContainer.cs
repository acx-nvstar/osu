// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Mods
{
    /// <summary>
    /// An interface for <see cref="Mod"/>s that can be applied to <see cref="RulesetContainer"/>s.
    /// </summary>
    public interface IApplicableToRulesetContainer<TObject> : IApplicableMod
        where TObject : HitObject
    {
        /// <summary>
        /// Applies this <see cref="IApplicableToRulesetContainer{TObject}"/> to a <see cref="RulesetContainer{TObject}"/>.
        /// </summary>
        /// <param name="rulesetContainer">The <see cref="RulesetContainer{TObject}"/> to apply to.</param>
        void ApplyToRulesetContainer(RulesetContainer<TObject> rulesetContainer);
    }
}
