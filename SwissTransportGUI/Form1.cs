using SwissTransport.Core;
using SwissTransport.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

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

    
    }

    private void VerbindungenRButton_Click(object sender, EventArgs e)
    {


    }

    private void TestButton_Click(object sender, EventArgs e)
    {
      var connections = transport.GetConnections(fromComboBox.Text, toComboBox.Text);

      foreach (Connection connection in connections.ConnectionList)
      {
        verbindungenDataGridView.Rows.Add(connection.From.Departure, connection.From.Platform,
          connection.From.Station.Name, connection.To.Station.Name, connection.To.Arrival, connection.To.Platform);
      }
    }

    private void AutoSuggestions(ComboBox comboBox)
    {
      string textSave = comboBox.Text;
      
      for (int i = comboBox.Items.Count; i > 0; i--)
      {
        comboBox.Items.RemoveAt(i);
      }
      
    
      comboBox.Text = textSave;
        var stations = transport.GetStations(comboBox.Text);
      foreach (Station station in stations.StationList)
      {
        comboBox.Items.Add(station.Name);
       
      }
     
    }

    private void FromKomboBox_KeyUp(object sender, KeyEventArgs e)
    {
      if (char.IsLetterOrDigit((char) e.KeyCode))
      {
        AutoSuggestions(fromComboBox);
      }
    
    }

    private void fromComboBox_Enter(object sender, EventArgs e)
    {
    fromComboBox.DroppedDown = true;
    }

    private void fromComboBox_Leave(object sender, EventArgs e)
    {
    fromComboBox.DroppedDown = false;
    }
  }
}