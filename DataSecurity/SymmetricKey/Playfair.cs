using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSecurity.SymmetricKey
{
	class Playfair
	{
		private static char[][] key = new char[5][];
		static Playfair()
		{
			key[0] = new char[5];
			key[1] = new char[5];
			key[2] = new char[5];
			key[3] = new char[5];
			key[4] = new char[5];
		}

		private static void InitKey(string k)
		{
			k = k.ToUpper().Replace("J", "I");
			bool[] chara = new bool[26];
			chara['J' - 65] = true;

			int index = 0, x = 0, y = 0;
			for (index = 0; index < k.Length; index++)
				if (chara[k[index] - 65] == false)
				{
					key[x][y] = k[index];
					chara[k[index] - 65] = true;
					y++;
					if (y > 4)
					{
						y = 0;
						x++;
					}
				}
			if (x * 5 + y < 24)
				for (int i = 0; i < 26; i++)
					if (chara[i] == true)
						continue;
					else
					{
						key[x][y] = (char)(i + 65);
						y++;
						if (y > 4)
						{
							y = 0;
							x++;
						}
					}
		}

		private static int[] FindChar(char a, char[][]key)
		{
			for(int i = 0; i < 5; i ++)
				for(int j = 0; j < 5; j ++)
				{
					if (key[i][j] == a)
						return new int[] { i, j };
				}
			return new int[] { 5, 5 };
		}

		private static StringBuilder Rule(StringBuilder p, char[][]key, bool encrypt)
		{
			StringBuilder tmp = new StringBuilder("  ");
			int[] locate1 = FindChar(p[0], key);
			int[] locate2 = FindChar(p[1], key);
			if (locate1[0] == locate2[0])
			{
				if (encrypt)
				{
					if (locate1[1] == 4)
						locate1[1] = 0;
					else
						locate1[1]++;
					if (locate2[1] == 4)
						locate2[1] = 0;
					else
						locate2[1]++;
				}
				else
				{
					if (locate1[1] == 0)
						locate1[1] = 4;
					else
						locate1[1]--;
					if (locate2[1] == 0)
						locate2[1] = 4;
					else
						locate2[1]--;
				}
				tmp[0] = key[locate1[0]][locate1[1]];
				tmp[1] = key[locate2[0]][locate2[1]];
			}
			else
			if (locate1[1] == locate2[1])
			{
				if(encrypt)
				{
					if (locate1[0] == 4)
						locate1[0] = 0;
					else
						locate1[0]++;
					if (locate2[0] == 4)
						locate2[0] = 0;
					else
						locate2[0]++;
				}
				else
				{
					if (locate1[0] == 0)
						locate1[0] = 4;
					else
						locate1[0]--;
					if (locate2[0] == 0)
						locate2[0] = 4;
					else
						locate2[0]--;
				}
				tmp[0] = key[locate1[0]][locate1[1]];
				tmp[1] = key[locate2[0]][locate2[1]];
			}
			else
			{
				tmp[0] = key[locate1[0]][locate2[1]];
				tmp[1] = key[locate2[0]][locate1[1]];
			}
			return tmp;
        }

		public static string Encrypt(string p, string k)
		{
			InitKey(k);
			p = p.ToUpper().Replace("J", "I");
			StringBuilder c = new StringBuilder();
			int index = 0;
			for (; index < p.Length - 1;)
			{
				StringBuilder tmp = new StringBuilder("  ");
				if (p[index] == p[index + 1])
				{
					tmp[0] = p[index];
					tmp[1] = 'X';
					index++;
				}
				else
				{
					tmp[0] = p[index];
					tmp[1] = p[index + 1];
					index += 2;
				}
				c.Append(Rule(tmp, key, true));
			}
			if (index == p.Length - 1)
			{
				StringBuilder tmp = new StringBuilder("  ");
				tmp[0] = p[index];
				tmp[1] = 'X';
				c.Append(Rule(tmp, key, true));
			}
			return c.ToString();
		}

		public static string Decrypt(string c, string k)
		{
			InitKey(k);
			c = c.ToUpper().Replace("J", "I");
			StringBuilder p = new StringBuilder();
			int index = 0;
			for (; index < c.Length;)
			{
				StringBuilder tmp = new StringBuilder("  ");
				tmp[0] = c[index];
				tmp[1] = c[index + 1];
				index += 2;
				p.Append(Rule(tmp, key, false));
			}
			return p.ToString();
		}
	}
}
