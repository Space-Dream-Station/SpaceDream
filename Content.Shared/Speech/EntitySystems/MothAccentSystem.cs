using System.Text.RegularExpressions;
using Content.Shared.Speech.Components;

namespace Content.Shared.Speech.EntitySystems;

public sealed partial class MothAccentSystem : RelayAccentSystem<MothAccentComponent>
{
    private static readonly Regex RegexLowerBuzz = new("z{1,3}");
    private static readonly Regex RegexUpperBuzz = new("Z{1,3}");

    public override string Accentuate(string message, Entity<MothAccentComponent>? ent = null)
    {
        // ADT-Tweak-Start
        // // buzzz
        // message = RegexLowerBuzz.Replace(message, "zzz");
        // // buZZZ
        // message = RegexUpperBuzz.Replace(message, "ZZZ");
        // SD-tweak-start
        message = Regex.Replace(message, "з{1,3}", "зз");
        message = Regex.Replace(message, "с{1,3}", "с");
        message = Regex.Replace(message, "ц{1,3}", "ц");
        message = Regex.Replace(message, "ж{1,3}", "жж");
        message = Regex.Replace(message, "З{1,3}", "ЗЗ");
        message = Regex.Replace(message, "С{1,3}", "С");
        message = Regex.Replace(message, "Ц{1,3}", "Ц");
        message = Regex.Replace(message, "Ж{1,3}", "ЖЖ");
        // SD-tweak-end
        // ADT-Tweak-End

        return message;
    }
}
