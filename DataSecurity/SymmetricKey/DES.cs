using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSecurity.SymmetricKey
{
    public class DES
    {
        private static string XOR(string s1, string s2)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i].Equals(s2[i]))
                    sb.Append('0');
                else
                    sb.Append('1');
            }
            return sb.ToString();
        }
        private static string toBinaryFromText(string text)
        {
            //To byte[]
            byte[] byte_array = System.Text.Encoding.ASCII.GetBytes(text);
            StringBuilder binary = new StringBuilder();
            foreach (byte b in byte_array)
            {
                StringBuilder sb = new StringBuilder(Convert.ToString(b, 2));
                while (sb.Length < 8)
                {
                    sb.Insert(0, '0');
                }
                binary.Append(sb.ToString());
            }
            return binary.ToString();
        }
        private static int toDecFromBinary(string text)
        {
            int result = 0 ;
            for(int i = text.Length - 1; i >=0; i--)
            {
                if (text[i] == '1')
                    result += (int)Math.Pow(2, text.Length - 1 - i);
            }
            return result;
        }

        private static string toBinaryFromHexaDecimal(char hex)
        {
            switch(hex)
            {
                case '0': return "0000"; break;
                case '1': return "0001"; break;
                case '2': return "0010"; break;
                case '3': return "0011"; break;
                case '4': return "0100"; break;
                case '5': return "0101"; break;
                case '6': return "0110"; break;
                case '7': return "0111"; break;
                case '8': return "1000"; break;
                case '9': return "1001"; break;
                case 'A': return "1010"; break;
                case 'B': return "1011"; break;
                case 'C': return "1100"; break;
                case 'D': return "1101"; break;
                case 'E': return "1110"; break;
                case 'F': return "1111"; break;
                default: return null;
            }
        }
        private static string toBinaryFromHexaDecimal(string hex)
        {
            StringBuilder sb = new StringBuilder();
            hex = hex.ToUpper();
            for(int i=0; i<hex.Length; i++)
            {
                sb.Append(toBinaryFromHexaDecimal(hex[i]));
                //Console.WriteLine(String.Format("Hex: {0}, Binary: {1}", hex[i], toBinaryFromHexaDecimal(hex[i])));
            }
            return sb.ToString();
        }
        private static string ShiftLeft(string binary, int num_shift)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = num_shift; i < binary.Length; i++)
            {
                sb.Append(binary[i]);
            }
            for (int i = 0; i < num_shift; i++)
            {
                sb.Append(binary[i]);
            }
            return sb.ToString();
        }

        private static string Compress(string binary56)
        {
            int[] new_position = new int[48]
                { 13, 16, 10, 23, 0, 4, 2, 27,
                    14, 5, 20, 9 ,22, 18, 11, 3,
                    25, 7, 15, 6, 26, 19, 12, 1,
                    40, 51, 30, 36, 46, 54, 29, 39,
                    50, 44, 32, 47, 43, 48, 38, 55,
                    33, 52, 45, 41, 49, 35, 28, 31
                };
            StringBuilder binary48 = new StringBuilder();
            for (int i = 0; i < 48; i++)
            {
                binary48.Append(binary56[new_position[i]]);
            }
            return binary48.ToString();
        }
        public static string GenerateKey(string key56, int round)
        {
            string left = key56.Substring(0, key56.Length/2),
                right = key56.Substring(key56.Length / 2);
            //Console.WriteLine(String.Format("C{0}= {1}", round, left));
            //Console.WriteLine(String.Format("D{0}= {1}", round, right));
            //Console.WriteLine();
            int num_shift;
            if (round == 1 || round == 2 || round == 9 || round == 16)
                num_shift = 1;
            else
                num_shift = 2;
            //Console.WriteLine(String.Format("C{0}= {1}", round, ShiftLeft(left, num_shift)));
            //Console.WriteLine(String.Format("D{0}= {1}", round, ShiftLeft(right, num_shift)));
            //Console.WriteLine();
            return String.Format("{0}{1}", ShiftLeft(left, num_shift), ShiftLeft(right, num_shift));
        }
        private static string toKey56(string key64)
        {
            int[] new_position = new int[56]
               {  
                   56, 48, 40, 32, 24, 16, 8,
                   0, 57, 49, 41, 33, 25, 17,
                   9, 1, 58, 50, 42, 34, 26,
                   18, 10, 2, 59, 51, 43, 35,
                   62, 54, 46, 38, 30, 22, 14,
                   6, 61, 53, 45, 37, 29, 21,
                   13, 5, 60, 52, 44, 36, 28,
                   20, 12, 4, 27, 19, 11, 3
               };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 56; i++)
            {
                sb.Append(key64[new_position[i]]);
            }
            return sb.ToString();
        }

        public static string Expand(string binary32)
        {
            int[] new_position = new int[48]
               {  31, 0, 1, 2, 3, 4,
                   3, 4, 5, 6, 7, 8,
                   7, 8, 9, 10, 11, 12,
                   11, 12, 13, 14, 15, 16,
                   15, 16, 17, 18, 19, 20,
                   19, 20, 21, 22, 23, 24,
                   23, 24, 25, 26, 27, 28,
                   27, 28, 29, 30, 31, 0
               };
            StringBuilder binary48 = new StringBuilder();
            for (int i = 0; i < 48; i++)
            {
                binary48.Append(binary32[new_position[i]]);
            }
            return binary48.ToString();
        }
        private static string S_Box(string binary6, char[][] s_box)
        {
            //b0_b5
            int row_num = toDecFromBinary(String.Format("{0}{1}", binary6[0], binary6[5]).ToString());
            //b1_b2_b3_b4
            int col_num = toDecFromBinary(binary6.Substring(1, 4));
            //Console.WriteLine(String.Format("binary6: {0}, hex: {1}, binary4: {2}", binary6, s_box[row_num][col_num], toBinaryFromHexaDecimal(s_box[row_num][col_num])));
            return toBinaryFromHexaDecimal(s_box[row_num][col_num]);
        }
        private static string S_Boxes(string binary48)
        {
            char[][] s_box1 = new char[][]
            {
                new char[]{'E', '4', 'D', '1', '2', 'F', 'B', '8', '3', 'A', '6', 'C', '5', '9', '0', '7'},
                new char[]{'0', 'F', '7', '4', 'E', '2', 'D', '1', 'A', '6', 'C', 'B', '9', '5', '3', '8'},
                new char[]{'4', '1', 'E', '8', 'D', '6', '2', 'B', 'F', 'C', '9', '7', '3', 'A', '5', '0'},
                new char[]{'F', 'C', '8', '2', '4', '9', '1', '7', '5', 'B', '3', 'E', 'A', '0', '6', 'D'},
            };
            char[][] s_box2 = new char[][]
            {
                new char[]{'F', '1', '8', 'E', '6', 'B', '3', '4', '9', '7', '2', 'D', 'C', '0', '5', 'A'},
                new char[]{'3', 'D', '4', '7', 'F', '2', '8', 'E', 'C', '0', '1', 'A', '6', '9', 'B', '5'},
                new char[]{'0', 'E', '7', 'B', 'A', '4', 'D', '1', '5', '8', 'C', '6', '9', '3', '2', 'F'},
                new char[]{'D', '8', 'A', '1', '3', 'F', '3', '2', 'B', '6', '7', 'C', '0', '5', 'E', '9'},
            };
            char[][] s_box3 = new char[][]
            {
                    new char[]{'A', '0', '9', 'E', '6', '3', 'F', '5', '1', 'D', 'C', '7', 'B', '4', '2', '8' },
                    new char[]{'D', '7', '0', '9', '3', '4', '6', 'A', '2', '8', '5', 'E', 'C', 'B', 'F', '1' },
                    new char[]{'D', '6', '4', '9', '8', 'F', '3', '0', 'B', '1', '2', 'C', '5', 'A', 'E', '7' },
                    new char[]{'1', 'A', 'D', '0', '6', '9', '8', '7', '4', 'F', 'E', '3', 'B', '5', '2', 'C' }
            };
            char[][] s_box4 = new char[][]
            {
                new char[]{'7', 'D', 'E', '3', '0', '6', '9', 'A', '1', '2', '8', '5', 'B', 'C', '4', 'F' },
                new char[]{'D', '8', 'B', '5', '6', 'F', '0', '3', '4', '7', '2', 'C', '1', 'A', 'E', '9' },
                new char[]{'A', '6', '9', '0', 'C', 'B', '7', 'D', 'F', '1', '3', 'E', '5', '2', '8', '4' },
                new char[]{'3', 'F', '0', '6', 'A', '1', 'D', '8', '9', '4', '5', 'B', 'C', '7', '2', 'E' }
            };
            char[][] s_box5 = new char[][]
            {
                new char[]{'2', 'C', '4', '1', '7', 'A', 'B', '6', '8', '5', '3', 'F', 'D', '0', 'E', '9' },
                new char[]{'E', 'B', '2', 'C', '4', '7', 'D', '1', '5', '0', 'F', 'A', '3', '9', '8', '6' },
                new char[]{'4', '2', '1', 'B', 'A', 'D', '7', '8', 'F', '9', 'C', '5', '6', '3', '0', 'E' },
                new char[]{'B', '8', 'C', '7', '1', 'E', '2', 'D', '6', 'F', '0', '9', 'A', '4', '5', '3' }
            };
            Char[][] s_box6 = new char[][]
            {
                new char[]{'C', '1', 'A', 'F', '9', '2', '6', '8', '0', 'D', '3', '4', 'E', '7', '5', 'B' },
                new char[]{'A', 'F', '4', '2', '7', 'C', '9', '5', '6', '1', 'D', 'E', '0', 'B', '3', '8' },
                new char[]{'9', 'E', 'F', '5', '2', '8', 'C', '3', '7', '0', '4', 'A', '1', 'D', 'B', '6' },
                new char[]{'4', '3', '2', 'C', '9', '5', 'F', 'A', 'B', 'E', '1', '7', '6', '0', '8', 'D' }
            };
            char[][] s_box7 = new char[][]
            {
                new char[]{'4', 'B', '2', 'E', 'F', '0', '8', 'D', '3', 'C', '9', '7', '5', 'A', '6', '1' },
                new char[]{'D', '0', 'B', '7', '4', '9', '1', 'A', 'E', '3', '5', 'C', '2', 'F', '8', '6' },
                new char[]{'1', '4', 'B', 'B', 'C', '3', '7', 'E', 'A', 'F', '6', '8', '0', '5', '9', '2' },
                new char[]{'6', 'B', 'D', '8', '1', '4', 'A', '7', '9', '5', '0', 'F', 'E', '2', '3', 'C' }
            };
            char[][] s_box8 = new char[][]
            {
                new char[]{'D', '2', '8', '4', '6', 'F', 'B', '1', 'A', '9', '3', 'E', '5', '0', 'C', '7' },
                new char[]{'1', 'F', 'D', '8', 'A', '3', '7', '4', 'C', '5', '6', 'B', '0', 'E', '9', '2' },
                new char[]{'7', 'B', '4', '1', '9', 'C', 'E', '2', '0', '6', 'A', 'D', 'F', '3', '5', '8' },
                new char[]{'2', '1', 'E', '7', '4', 'A', '8', '0', 'F', 'C', '9', '0', '3', '5', '6', 'B' }
            };

            //Tách 1 số 48-bit thành 8 số 6-bit
            string[] binary6_array = new string[8];
            for(int i=0; i<8; i++)
            {
                binary6_array[i] = binary48.Substring(i * 6, 6);
            }

            //Nén 8 số 6-bit thành 8 số 4-bit dùng s_box tương ứng, tạo thành binary32 từ 8 binary4
            StringBuilder binary32 = new StringBuilder();
            binary32.Append(S_Box(binary6_array[0], s_box1));
            binary32.Append(S_Box(binary6_array[1], s_box2));
            binary32.Append(S_Box(binary6_array[2], s_box3));
            binary32.Append(S_Box(binary6_array[3], s_box4));
            binary32.Append(S_Box(binary6_array[4], s_box5));
            binary32.Append(S_Box(binary6_array[5], s_box6));
            binary32.Append(S_Box(binary6_array[6], s_box7));
            binary32.Append(S_Box(binary6_array[7], s_box8));
            return binary32.ToString();
        }

        private static string P_Box(string binary32)
        {
            int[] new_position = new int[32] {
                15, 6, 19, 20, 28, 11, 27, 16,
                0, 14, 22, 25, 4, 17, 30, 9,
                1, 7, 23, 13, 31, 26, 2, 8,
                18, 12, 29, 5, 21, 10, 3, 24
            };
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<32; i++)
            {
                sb.Append(binary32[new_position[i]]);
            }
            return sb.ToString();
        }
        public static string GenerateCipher(string bplain, string bkey)
        {
            string left = bplain.Substring(0, bplain.Length / 2),
                   right = bplain.Substring(bplain.Length / 2);
            //Console.WriteLine(String.Format("Key after being compressed: {0}", Compress(bkey)));
            return right + XOR(left, P_Box(S_Boxes(XOR(Expand(right), Compress(bkey)))));
        }
        private static string initialPermutation(string binary64)
        {
            int[] new_position = new int[64]
                {
                    57, 49, 41, 33, 25, 17, 9,  1,
                    59, 51, 43, 35, 27, 19, 11, 3,
                    61, 53, 45, 37, 29, 21, 13, 5,
                    63, 55, 47, 39, 31, 23, 15, 7,
                    56, 48, 40, 32, 24, 16, 8,  0,
                    58, 50, 42, 34, 26, 18, 10, 2,
                    60, 52, 44, 36, 28, 20, 12, 4,
                    62, 54, 46, 38, 30, 22, 14, 6
                };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 64; i++)
            {
                sb.Append(binary64[new_position[i]]);
            }
            return sb.ToString();
        }
        public static string Encrypt(string plain_text, string key_text)
        {
            string bplain = initialPermutation(toBinaryFromHexaDecimal(plain_text));
            string bkey = toKey56(toBinaryFromHexaDecimal(key_text));
            //Console.WriteLine(String.Format("Plain after convert to binary: {0}", toBinaryFromHexaDecimal(plain_text)));
            //Console.WriteLine(String.Format("Plain after initial permutation: {0}", bplain));
            //Console.WriteLine(String.Format("Key after convert to binary: {0}", bplain));
            //Console.WriteLine(String.Format("Key after 56 permutattion: {0}", bplain));
            for (int round = 1; round <= 16; round++)
            {
                bkey   = GenerateKey(bkey, round);
                bplain = GenerateCipher(bplain, bkey);
                Console.WriteLine(String.Format("Cipher after round {0}: {1}", round, bplain));
            }
            return bplain;
        }

        
    }
}
