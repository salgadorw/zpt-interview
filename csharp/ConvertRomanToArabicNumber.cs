using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
	public class ConvertRomanToArabicNumber
	{
		private readonly Dictionary<char, int> translationData;


		public ConvertRomanToArabicNumber()
		{
			translationData = new Dictionary<char, int>
			{
				{'I',1 },
				{'V',5 },
				{'X',10 },
				{'L',50 },
				{'C',100 },
				{'D',500 },
				{'M',1000 }
			};

		}

		public int Convert(string romanNumber)
		{
			var values = romanNumber.ToCharArray();

			int result = 0;

			for (var i = 0; i < values.Length;i++)
			{
				if (i > 0)
					if (translationData[values[i - 1]] > translationData[values[i]])
						result += translationData[values[i]];
					else
						result += translationData[values[i]] - (translationData[values[i - 1]]*2);
				else
					result += translationData[values[i]];
			}

			return result;
		}

		

	}
}
