using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSecurity.SymmetricKey
{
	class Ceasar
	{
		public static string Encrypt(string p, int k)
		{
			p = p.ToUpper();
			StringBuilder c = new StringBuilder();
			for (int i = 0; i < p.Length; i++)
			{
                c.Append((char)(p[i] + ((k + 26) % 26) - 65) % 26 + 65);
			}
			return c.ToString();
		}

		public static string Decrypt(string c, int k)
		{
			c = c.ToUpper();
			Console.Write(c + " " + k + " ");
			Console.WriteLine(Encrypt(c, -1 * k));
			return Encrypt(c, -1 * k);
		}
	}
}
