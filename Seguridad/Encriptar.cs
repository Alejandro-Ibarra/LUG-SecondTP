using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Seguridad
{
    public class Encriptar
    {
		public static string GenerarMD5(string sCadena)
		{
			try
			{
				//Crear un objeto de codificación para garantizar el estándar de codificación para el texto fuente
				UnicodeEncoding UeCodigo = new UnicodeEncoding();
				//Recuperar una matriz de bytes basado en el texto de origen
				byte[] ByteSourceText = UeCodigo.GetBytes(sCadena);
				//Instancias de un objeto MD5 Proveedor
				MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
				//Calcular el valor hash MD5 de la fuente
				byte[] ByteHash = Md5.ComputeHash(ByteSourceText);
				//Y es convertir a formato de cadena para el retorno
				return Convert.ToBase64String(ByteHash);
			}
			catch (CryptographicException ex)
			{
				throw (ex);
			}
			catch (Exception ex)
			{
				throw (ex);
			}
		}
	}
}
