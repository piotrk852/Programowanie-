using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterTaskConsoleApp;

internal class Printer
{
    private string Name { set; get; }

    private int PaperCount;
    public int paperCount { set; get; }
      
    public Printer (string Name ,int PaperCount) {
    
        this.Name = Name;
        paperCount = PaperCount;
    
    
    
    }

    

}
