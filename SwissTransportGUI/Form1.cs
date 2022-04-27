using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    ITransport transport = new Transport();
   

    private void Form1_Load(object sender, EventArgs e)
    {
      fromTextBox.Text = "Luzern";
      toTextBox.Text = "Sursee";


    }

    private void VerbindungenRButton_Click(object sender, EventArgs e)
    {
   

    }

    private void TestButton_Click(object sender, EventArgs e)
    {
      var connections = transport.GetConnections(fromTextBox.Text, toTextBox.Text);
     
      foreach(Connection connection in connections.ConnectionList)
      {
        verbindungenDataGridView.Rows.Add(connection.From.Departure,connection.From.Platform,connection.From.Station.Name, connection.To.Station.Name,connection.To.Arrival,connection.To.Platform);
      }
    }
  }
}