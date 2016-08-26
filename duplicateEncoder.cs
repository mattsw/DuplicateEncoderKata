using System.Linq;
using System;
using System.Collections.Generic;

public class Kata
{

  public static string DuplicateEncode(string word) => 
            new string(word.ToLower()
                .Select(character =>
                    word.ToLower()
                        .Count(innerCharacter => character == innerCharacter) == 1
                        ? '('
                        : ')').ToArray());
}