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
    Autofill autofill = new Autofill();


    private void Form1_Load(object sender, EventArgs e)
    {


    }

    private void VerbindungenRButton_Click(object sender, EventArgs e)
    {


    }

    private void TestButton_Click(object sender, EventArgs e)
    {
     bool isArrival = false;
     if (isArrivalTimeCheckBox.Checked)
     {
       isArrival = true;

     }
      var connections = transport.GetConnections(fromComboBox.Text, toComboBox.Text, datePicker.Value, timePicker.Value, isArrival);

      foreach (Connection connection in connections.ConnectionList)
      {
        verbindungenDataGridView.Rows.Add(connection.From.Departure, connection.From.Platform,
          connection.From.Station.Name, connection.To.Station.Name, connection.To.Arrival, connection.To.Platform);
      }
    }

    private void AutoSuggestions(ComboBox comboBox)
    {

     
    }

    private void FromComboBox_KeyUp(object sender, KeyEventArgs e)
    {
      if ((char.IsLetterOrDigit((char)e.KeyCode)) && fromComboBox.Text != null)
      {
        autofill.AutoFillMe(fromComboBox);
      }

    }
    private void ToComboBoxKeyUp(object sender, KeyEventArgs e)
    {
      if ((char.IsLetterOrDigit((char)e.KeyCode))&& toComboBox.Text != null )
      {
        autofill.AutoFillMe(toComboBox);
      }
    }

    private void ToComboBox_Enter(object sender, EventArgs e)
    {
      toComboBox.DroppedDown = true;
    }

    private void ToComboBox_Leave(object sender, EventArgs e)
    {
      toComboBox.DroppedDown = false;
    }

    private void FromComboBox_Enter(object sender, EventArgs e)
    {
      fromComboBox.DroppedDown = true;
    }

    private void FromComboBox_Leave(object sender, EventArgs e)
    {
      fromComboBox.DroppedDown = false;
    }
  }
}