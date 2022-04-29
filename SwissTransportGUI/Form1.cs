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
    int selectionNumber = 1;


    private void Form1_Load(object sender, EventArgs e)
    {
     

    }

    private void VerbindungenRButton_Click(object sender, EventArgs e)
    {


    }

    private void SearchButton_Click(object sender, EventArgs e)
    {

      switch (selectionNumber)
      {
        case  1:
          bool isArrival = false;
          if (isArrivalTimeCheckBox.Checked)
          {
            isArrival = true;

          }
          var connections = transport.GetConnections(fromComboBox.Text, toComboBox.Text, datePicker.Value, timePicker.Value, isArrival);

          foreach (Connection connection in connections.ConnectionList)
          {
            verbindungenDataGridView.Rows.Clear();
            verbindungenDataGridView.Rows.Add(connection.From.Departure, connection.From.Platform,
              connection.From.Station.Name, connection.To.Station.Name, connection.To.Arrival, connection.To.Platform);
          }
          break;

        case 2:
          var stationBoard = transport.GetStationBoard(fromComboBox.Text, fromComboBox.Text);

          foreach (StationBoard station in stationBoard.Entries)
          {
            verbindungenDataGridView.Rows.Clear();
            verbindungenDataGridView.Rows.Add(station.Stop.Departure,"",stationBoard.Station.Name,station.To,"","");
          }
          break;

      }
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

    private void verbindungenRButton_CheckedChanged(object sender, EventArgs e)
    {
      toComboBox.Visible = true;
      timePicker.Visible = true;
      datePicker.Visible = true;
      isArrivalTimeCheckBox.Visible = true;
      wechselbutton.Visible = true;
      selectionNumber = 1;
    }
    private void abfahrtstafelRButton_CheckedChanged(object sender, EventArgs e)
    {
      toComboBox.Visible = false;
      timePicker.Visible = false;
      datePicker.Visible = false;
      isArrivalTimeCheckBox.Visible = false;
      wechselbutton.Visible = false;
      selectionNumber = 2;

    }

    private void Wechselbutton_Click(object sender, EventArgs e)
    {
      string zwischenspeicher = fromComboBox.Text;
        fromComboBox.Text = toComboBox.Text;
        toComboBox.Text = zwischenspeicher;
        SearchButton_Click(sender,e);
        
    }
  }
 
}