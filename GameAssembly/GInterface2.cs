using System;
using System.Net.Sockets;

public interface GInterface2
{
	string String_2 { get; set; }

	int Int32_0 { get; set; }

	string String_3 { get; }

	TcpClient TcpClient_0 { get; set; }

	event EventHandler<GEventArgs0> Event_0;

	TcpClient CreateConnection(string destinationHost, int destinationPort);

	void CreateConnectionAsync(string destinationHost, int destinationPort);
}
