using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDangNhap
{
    internal class DocSoThanhChu
    {
        private static readonly string[] Units = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        private static readonly string[] Teens = { "mười", "mười một", "mười hai", "mười ba", "mười bốn", "mười lăm", "mười sáu", "mười bảy", "mười tám", "mười chín" };
        private static readonly string[] Tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        private static readonly string[] ThousandsGroups = { "", "nghìn", "triệu", "tỷ" };

        public static string ConvertToWords(double number)
        {
            if (number == 0)
                return "không";

            if (number < 0)
                return "âm " + ConvertToWords(Math.Abs(number));

            var integerPart = (long)number;
            var fractionalPart = number - integerPart;

            var words = ConvertIntegerToWords(integerPart);

            if (fractionalPart > 0)
            {
                var fractionalWords = ConvertFractionalToWords(fractionalPart);
                words += " phẩy " + fractionalWords;
            }

            return words.Trim();
        }

        private static string ConvertIntegerToWords(long number)
        {
            var words = "";

            var groupIndex = 0;

            while (number > 0)
            {
                var group = number % 1000;
                number /= 1000;

                var groupWords = ConvertGroupToWords((int)group);
                if (!string.IsNullOrWhiteSpace(groupWords))
                {
                    words = groupWords + " " + ThousandsGroups[groupIndex] + " " + words;
                }

                groupIndex++;
            }

            return words.Trim();
        }

        private static string ConvertGroupToWords(int number)
        {
            var hundreds = number / 100;
            var tensUnits = number % 100;
            var tens = tensUnits / 10;
            var units = tensUnits % 10;

            var groupWords = "";

            if (hundreds > 0)
            {
                groupWords += Units[hundreds] + " trăm ";
                if (tensUnits > 0 && tensUnits < 10)
                {
                    groupWords += "linh ";
                }
            }

            if (tensUnits > 0)
            {
                if (tensUnits < 10)
                {
                    groupWords += Units[units];
                }
                else if (tensUnits < 20)
                {
                    groupWords += Teens[tensUnits - 10];
                }
                else
                {
                    groupWords += Tens[tens];
                    if (units > 0)
                    {
                        groupWords += " " + Units[units];
                    }
                }
            }

            return groupWords.Trim();
        }

        private static string ConvertFractionalToWords(double number)
        {
            var words = "";
            var fractionalPart = number.ToString(CultureInfo.InvariantCulture).Split('.')[1];
            foreach (var digit in fractionalPart)
            {
                words += Units[int.Parse(digit.ToString())] + " ";
            }
            return words.Trim();
        }
    }
}
