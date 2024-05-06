using Grpc.Net.Client;
using GrpcServer;

namespace GrpcClient;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    async private void buttonAdd_Click(object sender, EventArgs e)
    {
        var channel = GrpcChannel.ForAddress("https://localhost:7046");
        var client = new Calculator.CalculatorClient(channel);
        var reply = await client.AddAsync(new CalculatorRequest { A = 2, B = 5 });
        MessageBox.Show($"2 + 5 = {reply.Result}");
    }
}
