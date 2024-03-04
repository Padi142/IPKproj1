using CommandLine;

namespace IPKproj1.model;

public class Arguments
{
    [Option('t', "type", Required = true, HelpText = "Transport protocol used for connection (tcp or udp)")]
    public string Transport { get; set; }

    [Option('s', "server", Required = true, HelpText = "Server IP")]
    public string Server { get; set; }

    [Option('p', "port", Default = 4567, HelpText = "Server port")]
    public int Port { get; set; }

    // [Option('d', "timeout", Default = 250, HelpText = "UDP confirmation timeout")]
    // public ushort Timeout { get; set; }
    //
    // [Option('r', "retransmissions", Default = 3, HelpText = "Maximum number of UDP retransmissions")]
    // public byte Retransmissions { get; set; }

    [Option('h', "help", HelpText = "Prints program help output and exits")]
    public bool Help { get; set; }

}