using Robust.Shared.GameObjects;
using Robust.Shared.Serialization;
using Robust.Shared.ViewVariables;

namespace Content.Shared.Anxiety.Components;

[RegisterComponent]
public sealed partial class AnxietyComponent : Component
{
    [DataField("current")]
    [ViewVariables(VVAccess.ReadWrite)]
    public float Current { get; set; } = 0f;

    [DataField("max")]
    [ViewVariables(VVAccess.ReadWrite)]
    public float Max { get; set; } = 100f;
}
