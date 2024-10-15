using System.Text.RegularExpressions;

public static class StringExtensions
{
  public static InputDto ParseInput(this string input)
  {
    var regex = new Regex(@"^(?<action>[\w-]+)(?:\s+(?<id>\d+))?\s*(?:""(?<description>.+)"")?$", RegexOptions.IgnoreCase);
    var match = regex.Match(input);

    if (match.Success)
    {
      var action = match.Groups["action"].Value.ToLower();
      var idGroup = match.Groups["id"].Value;
      int? id = !string.IsNullOrEmpty(idGroup) ? int.Parse(idGroup) : null;
      var description = match.Groups["description"].Value;

      return new InputDto(action, description, id);
    }

    return null;
  }
}