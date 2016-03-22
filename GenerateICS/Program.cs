using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateICS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write(ICS(new DateTime(2014, 1, 1), new DateTime(2014, 3, 12), "New Test EVent", "This is a test event", "location"));
            Console.Read();
        }

        public static string ICS(DateTime start, DateTime end, string name, string description, string location) {
            string dataFormat = string.Format("BEGIN:VCALENDAR\nVERSION:2.0\nMETHOD:PUBLISH\nBEGIN:VEVENT\nDTSTART:{0}\nDTEND:{1}\nLOCATION:{2}\nTRANSP: OPAQUE\nSEQUENCE:0\nUID:\nDTSTAMP:\nSUMMARY:\nDESCRIPTION:\nPRIORITY:1\nCLASS:PUBLIC\nBEGIN:VALARM\nTRIGGER:-PT10080M\nACTION:DISPLAY\nDESCRIPTION:Reminder\nEND:VALARM\nEND:VEVENT\nEND:VCALENDAR\n",
                start, end, name, description, location);

            return dataFormat;
            //"BEGIN:VCALENDAR\nVERSION:2.0\nMETHOD:PUBLISH\nBEGIN:VEVENT\nDTSTART:".date("Ymd\THis\Z",strtotime($start))."\nDTEND:".date("Ymd\THis\Z",strtotime($end))."\nLOCATION:".$location."\nTRANSP: OPAQUE\nSEQUENCE:0\nUID:\nDTSTAMP:".date("Ymd\THis\Z")."\nSUMMARY:".$name."\nDESCRIPTION:".$description."\nPRIORITY:1\nCLASS:PUBLIC\nBEGIN:VALARM\nTRIGGER:-PT10080M\nACTION:DISPLAY\nDESCRIPTION:Reminder\nEND:VALARM\nEND:VEVENT\nEND:VCALENDAR\n";

        }
        //function save() {
        //    file_put_contents($this->name.".ics",$this->data);
        //}
        //function show() {
        //    header("Content-type:text/calendar");
        //    header('Content-Disposition: attachment; filename="'.$this->name.'.ics"');
        //    Header('Content-Length: '.strlen($this->data));
        //    Header('Connection: close');
        //    echo $this->data;
        //}


        /*
BEGIN:VCALENDAR
VERSION:2.0
METHOD:PUBLISH
BEGIN:VEVENT
DTSTART:1/1/2014 12:00:00 AM
DTEND:3/12/2014 12:00:00 AM
LOCATION:New Test EVent
TRANSP: OPAQUE
SEQUENCE:0
UID:
DTSTAMP:
SUMMARY:
DESCRIPTION:
PRIORITY:1
CLASS:PUBLIC
BEGIN:VALARM
TRIGGER:-PT10080M
ACTION:DISPLAY
DESCRIPTION:Reminder
END:VALARM
END:VEVENT
END:VCALENDAR         
         */
    }
}
