using System.Linq;
using System;
using System.Collections.Generic;

public class Kata
{

  public static string DuplicateEncode(string word)
  {
    var result = word.ToLower().ToCharArray().Aggregate(new Dictionary<string, int>(), (current, next) =>
            {
                var strVal = next.ToString();
                if (current.ContainsKey(strVal)) current[strVal] = current[strVal] + 1;
                else current.Add(strVal, 1);

                return current;
            });
    return string.Join(string.Empty, word.ToLower()
        .ToCharArray()
        .Select(character => result[character.ToString()] == 1 ? "(" : ")"));
  }
}