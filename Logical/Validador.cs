using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projeto.Logical
{
    public class Validador
    {
        public static bool ValidarDocumento(string documento)
        {
            var apenasDigits = new string(documento.Where(char.IsDigit).ToArray());

            if (string.IsNullOrWhiteSpace(apenasDigits))
            { 
                return false; 
            }

            if (apenasDigits.Length == 11)
            {

                if (apenasDigits.Distinct().Count() == 1)
                    return false;

                int[] nums = apenasDigits.Select(c => c - '0').ToArray();

                int sum = 0;
                for (int i = 0; i < 9; i++)
                    sum += nums[i] * (10 - i);

                int rem = sum % 11;
                int dv1 = (rem < 2) ? 0 : 11 - rem;
                if (nums[9] != dv1) return false;

                sum = 0;
                for (int i = 0; i < 10; i++)
                    sum += nums[i] * (11 - i);

                rem = sum % 11;
                int dv2 = (rem < 2) ? 0 : 11 - rem;
                return nums[10] == dv2;
            }

            if (apenasDigits.Length == 14)
            { 
                if (apenasDigits.Distinct().Count() == 1)
                    return false;

                int[] nums = apenasDigits.Select(c => c - '0').ToArray();

                int[] weights1 = new int[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] weights2 = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                int sum = 0;
                for (int i = 0; i < 12; i++)
                    sum += nums[i] * weights1[i];

                int rem = sum % 11;
                int dv1 = (rem < 2) ? 0 : 11 - rem;
                if (nums[12] != dv1) return false;

                sum = 0;
                for (int i = 0; i < 13; i++)
                    sum += nums[i] * weights2[i];

                rem = sum % 11;
                int dv2 = (rem < 2) ? 0 : 11 - rem;
                return nums[13] == dv2;
            }
            else
            {
                return false;
            }
        }
    }
}
