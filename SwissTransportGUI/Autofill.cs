using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using SwissTransport.Models;
using SwissTransport.Core;

namespace SwissTransportGUI
{
  
  
  internal class Autofill
  {
    ITransport transport = new Transport();
 

    public void AutoFillMe(ComboBox searchBox)
    {
      searchBox.Items.Clear();
      searchBox.SelectionStart = searchBox.Text.Length + 1;
      var stations = transport.GetStations(searchBox.Text);
      try
      {
        foreach (Station station in stations.StationList)
        {
          searchBox.Items.Add(station.Name);

        }
      }
      catch
      {
          searchBox.Items.Clear();
          searchBox.SelectionStart = searchBox.Text.Length + 1;
           searchBox.Items.Clear();
          searchBox.Items.Add("Keine Ergebnisse");
          
      }





    }
  }
}
