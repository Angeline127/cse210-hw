using System;
using System.Collections.Generic;
using System.IO;


//journalentry class
public class JournalEntry {
    public string Text {get; set; }
    public DateTime TimeStamp {get; set; }

    public JournalEntry(string text) {
        Text = text;
        TimeStamp = DateTime.Now;
    }


    public JournalEntry(string text, DateTime timeStamp) {
        Text = text;
        TimeStamp = timeStamp;
    }

    public override string ToString() {
        return TimeStamp.ToString() + " - " + Text;
    }
}
 