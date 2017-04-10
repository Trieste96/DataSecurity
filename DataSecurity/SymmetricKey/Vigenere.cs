using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSecurity.SymmetricKey
{
	class Vigenere
	{
		public static string Encrypt(string p, string k)
		{
			p = p.ToUpper();
			StringBuilder c = new StringBuilder();
			StringBuilder key = new StringBuilder();
			while (p.Length > key.Length)
				key.Append(k);
			for(int i = 0; i < p.Length; i ++)
			{
				c.Append(Ceasar.Encrypt(p[i].ToString(), key[i] - 65));
			}
			return c.ToString();
		}

		public static string Decrypt(string c, string k)
		{
			c = c.ToUpper();
			StringBuilder p = new StringBuilder();
			StringBuilder key = new StringBuilder();
			while (c.Length > key.Length)
				key.Append(k);
			for (int i = 0; i < c.Length; i++)
			{
				p.Append(Ceasar.Decrypt(c[i].ToString(), key[i] - 65));
			}
			return p.ToString();
		}
	}
}
