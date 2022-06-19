using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_Suggestions_System
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  public class Solution
  {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
      // Step 1 - Sort the products in asc
      // Step 2 -for each char in searchWord match with the product one by one from the array, each char in searchWord will be matching same posititon char in product from array
      // Step 3 - matched product will be added to temp list
      // Step 4 - replace products with the temp list as our next char search would be on the new temp list instead products, because we have already filtered products based on the first char matched from the products array. We will be doing this until we matched all chars frm searchWord.
      // those products which are matched with the first char of searchWord are the list of products will go for second char match and so on

      var result = new List<IList<string>>();

      // Step 1 - 
      Array.Sort(products);


      // Step 2 -
      for (int i = 0; i < searchWord.Length; i++)
      {
        var temp = new List<string>();
        foreach (var product in products)
        {
          if (i < product.Length && searchWord[i] == product[i])
          {
            // Step 3 -
            temp.Add(product);
          }
        }
        result.Add(temp.Take(3).ToList());
        products = temp.ToArray();
      }

      return result;
    }
  }
}
