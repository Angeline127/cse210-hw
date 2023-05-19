using System;
using System.Collections.Generic;
using System.IO;


//journalentry class
public class JournalEntry {
    public string _Text {get; set; }
    public DateTime _TimeStamp {get; set; }

    public JournalEntry(string text) {
        _Text = text;
        _TimeStamp = DateTime.Now;
    }


    public JournalEntry(string text, DateTime timeStamp) {
        _Text = text;
        _TimeStamp = timeStamp;
    }

    public override string ToString() {
        return _TimeStamp.ToString() + " - " + _Text;
    }
}
 