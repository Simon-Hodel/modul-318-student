using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Mail;

namespace SwissTransportGUI
{
  public class Share
  {
    private string _fromDeparture;
    private string _fromPlatform;
    private string _fromName;
    private string _toName;
    private string _toPlatform;
    private string _toArrival;

    public Share(string fromDeparture, string fromPlatform, string fromName, string toName, string toPlatform, string toArrival)
    {
      _fromDeparture = fromDeparture;
      _fromPlatform = fromPlatform;
      _fromName = fromName;
      _toName = toName;
      _toPlatform = toPlatform;
      _toArrival = toArrival; 
    }

    public string ShareInfo
    {
      get
      {
        return $"mailto:{"mailname@mailservice.com"}?subject={"Passende Verbindung"}" +
               $"&body=Von ={_fromName}, Abfahrtszeit ={_fromDeparture}, Platfrom ={_fromPlatform} \n" +
               $"Nach ={_toName}, Ankunftszeit ={_toArrival}, Platform ={_toPlatform}";
      }
    }

    public void OpenShare()
    {
      Process.Start(new ProcessStartInfo(ShareInfo) { UseShellExecute = true });
    }
  }
}
