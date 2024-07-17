using System.Text.RegularExpressions;

namespace ClimateMonitor.Services;

public class FirmwareVersionValidatorService
{
    private static readonly string regex = "^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.(0|[1-9]\\d*)(?:-((?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\\.(?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\\+([0-9a-zA-Z-]+(?:\\.[0-9a-zA-Z-]+)*))?$";

    public bool ValidateFirmwareVersion(string firmwareVersion)
        => Regex.IsMatch(firmwareVersion, regex);
}
