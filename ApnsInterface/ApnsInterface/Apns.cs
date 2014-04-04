using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Security;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ApnsInterface
{
	public class Apns
	{
		private string _certFilePath;
		private string _certFilePassword;
		private string _pushServer;

		public string PushServer { get { return this._pushServer; } set { this._pushServer = value; } }

		public Apns(string certFilePath, string certFilePassword)
		{
			this._certFilePath = certFilePath;
			this._certFilePassword = certFilePassword;
			this._pushServer = "gateway.push.apple.com";
		}

		public void Push(string deviceToken, string message, int count)
		{
			int port = 2195;
			TcpClient client = new TcpClient(this._pushServer, port);

			SslStream sslStream = new SslStream(
					client.GetStream(),
					false,
					new RemoteCertificateValidationCallback(ValidateServerCertificate),
					null
			);

			try
			{
				X509Certificate2 clientCertificate = new X509Certificate2(this._certFilePath, this._certFilePassword);
				X509Certificate2Collection certificatesCollection = new X509Certificate2Collection(clientCertificate);

				sslStream.AuthenticateAsClient(this._pushServer, certificatesCollection, SslProtocols.Tls, true);
			}
			catch
			{
				client.Close();
				throw;
			}

			try
			{
				MemoryStream memoryStream = new MemoryStream();
				BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

				binaryWriter.Write((byte)0);
				binaryWriter.Write((byte)0);
				binaryWriter.Write((byte)32);	// デバイストークンのバイト数

				// デバイストークンをバイト配列にして格納
				binaryWriter.Write(this.GetDeviceToken(deviceToken));

				String payload = "{\"aps\":{\"alert\":\"" + message + "\",\"badge\":" + count.ToString() +"}}";

				binaryWriter.Write((byte)0);
				binaryWriter.Write((byte)System.Text.Encoding.UTF8.GetBytes(payload).Length);

				byte[] bytePayload = System.Text.Encoding.UTF8.GetBytes(payload);
				binaryWriter.Write(bytePayload);
				binaryWriter.Flush();

				byte[] array = memoryStream.ToArray();
				sslStream.Write(array);
				sslStream.Flush();

				client.Close();
			}
			catch
			{
				client.Close();
				throw;
			}
		}


		public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return true;
		}

		private byte[] GetDeviceToken(string deviceToken)
		{
			byte[] token = new byte[32];
			int j = 0;
			for (int i = 0; i < 32; i++)
			{
				token[i] = ((byte)Convert.ToInt32(deviceToken[j].ToString() + deviceToken[j + 1].ToString(), 16));
				j += 2;
			}

			return token;
		}
	}
}
