// SPDX-FileCopyrightText: 2025 LuciferEOS <stepanteliatnik2022@gmail.com>
// SPDX-FileCopyrightText: 2025 ReserveBot <211949879+ReserveBot@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Actions;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;


namespace Content.Goobstation.Shared._Slon.Spider
{
    [RegisterComponent]
    public sealed partial class WebPassageActionComponent : Component
    {
        [DataField(customTypeSerializer: typeof(PrototypeIdSerializer<EntityPrototype>))]
        public string SpawnId = "SpiderWebPassage";

        [DataField(customTypeSerializer: typeof(PrototypeIdSerializer<EntityPrototype>))]
        public string WebAction = "ActionWebPassage";

        [DataField] public EntityUid? Action;
        [DataField] public float DoAfter { get; set; } = 10f;
    }

    [Serializable]
    public sealed partial class WebPassageActionEvent : InstantActionEvent
    {
    }
}
